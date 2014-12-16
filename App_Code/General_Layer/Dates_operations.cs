using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Dates_operations
/// </summary>
namespace Dates
{
    public class Dates_operations
    {
        public static string date_validate(string date)
        {
            String date_validated   = "";
            if (date != "" ){
                if( date.Length > 10 || date.Length < 8){

                    return date_validated;
                }
                String str1  = date;
                Char ch1   = '\\';
                Char ch2   = '/';
                str1.Replace(ch1, ch2);
                String[] str2   = str1.Split('/');
                if (str2.Length != 3 || str2[0].Length > 2 || str2[1].Length > 2 || CDataConverter.ConvertToInt(str2[0]) > 31 || CDataConverter.ConvertToInt(str2[1]) > 12)
                {

                    return date_validated;
                }
                if (CDataConverter.ConvertToInt(str2[0]) < 10 && str2[0].Length < 2)
                    date_validated += "0" + str2[0] + "/";
                else
                   date_validated += str2[0] + "/";


                if (CDataConverter.ConvertToInt(str2[1]) < 10 && str2[1].Length < 2)
                    date_validated += "0" + str2[1] + "/";
                else
                    date_validated += str2[1] + "/";
                

                date_validated += str2[2];

            }
            return date_validated;
        }

        public static string date_validate_year(string date)
        {
            String date_validated = "";
            if (date != "")
            {
                if (date.Length == 4)
                {
                    if (CDataConverter.ConvertToInt(date.Substring(0,1)) > 0)
                    {
                        date_validated = date;
                        return date_validated;
                    }
                }
                if (date.Length > 10 || date.Length < 8)
                {
                    
                    return date_validated;
                }
                String str1 = date;
                Char ch1 = '\\';
                Char ch2 = '/';
                str1.Replace(ch1, ch2);
                String[] str2 = str1.Split('/');
                if (str2.Length != 3 || str2[0].Length > 2 || str2[1].Length > 2 || CDataConverter.ConvertToInt(str2[0]) > 31 || CDataConverter.ConvertToInt(str2[1]) > 12)
                {

                    return date_validated;
                }
                if (CDataConverter.ConvertToInt(str2[0]) < 10 && str2[0].Length < 2)
                    date_validated += "0" + str2[0] + "/";
                else
                    date_validated += str2[0] + "/";


                if (CDataConverter.ConvertToInt(str2[1]) < 10 && str2[1].Length < 2)
                    date_validated += "0" + str2[1] + "/";
                else
                    date_validated += str2[1] + "/";


                date_validated += str2[2];

            }
            return date_validated;
        }

        public static string date_validate_any_year(string date)
        {
            String date_validated = "";
            if (date != "")
            {
                int count = date.Split('/').Length - 1;
                if (date.Length <= 4 && date.Length > 0 && count == 0)
                {
                    if (CDataConverter.ConvertToInt(date.Substring(0, 1)) > 0)
                    {
                        date_validated = date;
                        return date_validated;
                    }
                }
                if (count == 1)
                {
                    String str1 = date;
                    Char ch1 = '\\';
                    Char ch2 = '/';
                    str1.Replace(ch1, ch2);
                    String[] str2 = str1.Split('/');
                    if (str2.Length != 2 || str2[0].Length > 2 || str2[1].Length > 4 || CDataConverter.ConvertToInt(str2[0]) > 12 || CDataConverter.ConvertToInt(str2[0]) < 1 || CDataConverter.ConvertToInt(str2[1].Substring(0, 1)) == 0)
                    {

                        return date_validated;
                    }
                    else
                    {
                        if (CDataConverter.ConvertToInt(str2[0]) < 10 && str2[0].Length < 2)
                            date_validated += "0" + str2[0] + "/";
                        else
                            date_validated += str2[0] + "/";


                        date_validated += str2[1];
                    }
                }
                if (count == 2)
                {
                    String str1 = date;
                    Char ch1 = '\\';
                    Char ch2 = '/';
                    str1.Replace(ch1, ch2);
                    String[] str2 = str1.Split('/');
                    if (str2.Length != 3 || str2[0].Length > 2 || str2[1].Length > 2 || str2[2].Length > 4 || CDataConverter.ConvertToInt(str2[0]) > 31 || CDataConverter.ConvertToInt(str2[0]) < 1 || CDataConverter.ConvertToInt(str2[1]) > 12 || CDataConverter.ConvertToInt(str2[1]) < 1 || CDataConverter.ConvertToInt(str2[2].Substring(0, 1)) == 0)
                    {

                        return date_validated;
                    }
                    else
                    {
                        if (CDataConverter.ConvertToInt(str2[0]) < 10 && str2[0].Length < 2)
                            date_validated += "0" + str2[0] + "/";
                        else
                            date_validated += str2[0] + "/";


                        if (CDataConverter.ConvertToInt(str2[1]) < 10 && str2[1].Length < 2)
                            date_validated += "0" + str2[1] + "/";
                        else
                            date_validated += str2[1] + "/";


                        date_validated += str2[2];
                    }

                }
            }
            return date_validated;
        }
        public static Boolean Date_compare(string first_date, string second_date)
        {
            String[] str1   = first_date.Split('/');
            String[] str2  = second_date.Split('/');
            if( CDataConverter.ConvertToInt(str1[2]) < CDataConverter.ConvertToInt(str2[2]) )
                
                return false;
            else if( CDataConverter.ConvertToInt(str1[1]) < CDataConverter.ConvertToInt(str2[1]) && str1[2] == str2[2])
                
                return false;
            else if( CDataConverter.ConvertToInt(str1[0]) < CDataConverter.ConvertToInt(str2[0]) && str1[1] == str2[1] && str1[2] == str2[2])
               
                return false;
            

            return true;
        }
    }
}
