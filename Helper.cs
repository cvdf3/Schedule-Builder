using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Schedule_Builder
{
    //shortcut to get Connection String
    public static class Helper
    {
        public static string ConnectStr(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string getMonth(string num)
        {
            switch (num)
            {
                case "1":
                    return "Januaray";
                case "2":
                    return "February";
                case "3":
                    return "March";
                case "4":
                    return "April";
                case "5":
                    return "May";
                case "6":
                    return "June";
                case "7":
                    return "July";
                case "8":
                    return "August";
                case "9":
                    return "September";
                case "10":
                    return "October";
                case "11":
                    return "November";
                case "12":
                    return "December";
            }
            return null;
        }
    }
}
