using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Schedule_Builder
{
    public class DataAccess
    {
        //gets a list of the personnel on the specified shift
        public List<Person> getShift(string shift_)
        {
            //creates the connection to the SQL database and automatically closes afterwards
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectStr("Schedules")))
            {
                //direct SQL query is less secure than calling a procedure from the database
                return connection.Query<Person>("dbo.Personnel_GetShift @Shift_", new { Shift_ = shift_ }).ToList(); 
            }
        }

        //adds or updates the information of the person specified
        public void addUpdate(string id, string name, string admin, string shift, string position,
            string kellyDay, string station)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectStr("Schedules")))
            {
                List<Person> newPerson = new List<Person>();
                newPerson.Add(new Person { ID = id, Name = name, Admin_ = admin,
                    Shift_ = shift, Position = position, Kelly_Day = kellyDay, Station = station });

                try
                {
                    connection.Execute("dbo.Personnel_Add @ID, @Name, @Admin_, @Shift_, @Position, " +
                    "@Kelly_Day, @Station", newPerson);
                }
                catch
                {
                    connection.Execute("dbo.Personnel_Update @ID, @Name, @Admin_, @Shift_, @Position, " +
                    "@Kelly_Day, @Station", newPerson);
                
                    MessageBox.Show($"ID #{ id }: { name } has been updated.");
                }
            }
        }

        //removes a person from the database
        public void deletePerson(string id, string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectStr("Schedules")))
            {
                List<Person> deletedPerson = new List<Person>();
                deletedPerson.Add(new Person { ID = id, Name = name});

                try
                {
                    connection.Execute("dbo.Personnel_DeletePerson @ID", deletedPerson);
                    MessageBox.Show($"ID #{ id }: { name }, was removed from the system...");
                }
                catch//add parameter
                {
                    MessageBox.Show($"ID #{ id }: { name }, not found...");
                }
            }
        }

        //get the days of the month
        public List<DayInfo> getDays(string month, string year)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectStr("Schedules")))
            {
                try
                {
                    return connection.Query<DayInfo>("dbo.Calendar_GetDays @Month, @Year", 
                        new { Month = month, Year = year }).ToList();
                }
                catch
                {
                    MessageBox.Show("Please enter a Month and Year.");
                    return null;
                }
            }
        }

        //gets a list of the personnel on the specified shift
        public List<Truck> getTrucks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectStr("Schedules")))
            {
                return connection.Query<Truck>("dbo.Trucks_GetTrucks").ToList();
            }
        }

        //adds or updates the information of the truck specified
        public void addUpdateTruck(string number, string station, string positions)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectStr("Schedules")))
            {
                List<Truck> newTruck = new List<Truck>();
                newTruck.Add(new Truck {Number = number, StationNumber = station, Positions = positions});
                try
                {
                    connection.Execute("dbo.Trucks_AddTruck @Number, @StationNumber, @Positions", newTruck);
                }
                catch(Exception e)
                {
                    connection.Execute("dbo.Trucks_UpdateTruck @Number, @StationNumber, @Positions", newTruck);
                    
                    MessageBox.Show($"{ number } has been updated at Station { station }.");
                }
            }
        }

        //removes a truck from the database
        public void deleteTruck(string number)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectStr("Schedules")))
            {
                List<Truck> deletedTruck = new List<Truck>();
                deletedTruck.Add(new Truck { Number = number });
                try
                {
                    connection.Execute("dbo.Trucks_DeleteTruck @Number", deletedTruck);
                    MessageBox.Show($"{ number } was removed from the system...");
                }
                catch//add parameter
                {
                    MessageBox.Show($"{ number } not found...");
                }
            }
        }
    }   
}       
