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
/// Summary description for security_issues
/// </summary>
public class security_issues
{
	public security_issues()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="page_name"></param>
    /// <returns></returns>

    public static bool check_page_access(string page_name)
    {
        string user_type = HttpContext.Current.Session["user_type"].ToString();
        bool access_page = true;
        switch (page_name.ToLower())
        {
            case "final_revision_home.aspx":
                if (user_type != "8")
                    access_page = false;
                break;
            case "test_form2.aspx":
                if (user_type != "6")
                    access_page = false;
                break;
            case "add_articles.aspx":
            case "add_books.aspx":
            case "add_characters.aspx":
            case "add_documents.aspx":
            case "entry_form.aspx":
                if (user_type != "4")
                    access_page = false;
                break;
         case "quality_control_notes.aspx":
                if (user_type != "5")
                    access_page = false;
                break;
            default:
                break;
        }
        return access_page;
    }

    public static bool check_date(string date_str)
    {
        int count = date_str.Split('/').Length - 1;
        string[] dates_arr = date_str.Split('/');
        bool access_page = true;
        string new_date="";
        if (count > 2)
        {
            access_page = false;
            return access_page;
        }
        switch (count)
        {
            case 0:
                new_date = Dates.Dates_operations.date_validate_any_year(date_str);
                if (new_date == "" || Convert.ToInt16(date_str)==0)
                    access_page = false;
                break;
            case 1:
                new_date = Dates.Dates_operations.date_validate_any_year(date_str);
                if (new_date == "")
                    access_page = false;
                if (Convert.ToInt16(dates_arr[0]) > 12 || Convert.ToInt16(dates_arr[0]) < 1 || Convert.ToInt16(dates_arr[1]) == 0)
                    access_page = false;
                break;
            case 2:
                new_date = Dates.Dates_operations.date_validate_any_year(date_str);
                if (new_date == "")
                    access_page = false;
                break;
            default:
                break;
        }
        return access_page;
    }
}
