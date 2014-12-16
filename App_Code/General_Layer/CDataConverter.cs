using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Globalization;


/// <summary>
/// Summary description for CDataTransformer
/// </summary>

    public class CDataConverter
    {
        public CDataConverter()
        {

        }


        public static int ConvertToInt(object obj)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            {
                return 0;
            }
        }

      

        public static decimal ConvertToDecimal(object obj)
        {
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch
            {
                return 0;
            }
        }

        public static double ConvertToDouble(object obj)
        {
            try
            {
                return Convert.ToDouble(obj);
            }
            catch
            {
                return 0.0;
            }
        }

        private static DateTime Convert_DT_ToDateTime(string DT)
        {
            //without  // slashes
            int Year = CDataConverter.ConvertToInt(DT.Substring(0, 4));
            int month = CDataConverter.ConvertToInt(DT.Substring(4, 2));
            int day = CDataConverter.ConvertToInt(DT.Substring(6, 2));
            return new DateTime(Year, month, day);
        }

        //public static DateTime SubtractTwoDates(DateTime FrstDT, DateTime ScndDT)
        //{
        //    TimeSpan dt = FrstDT - ScndDT;
        //    dt.TotalDays

        //    return dt;
        //}

      
    }
