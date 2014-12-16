 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Search
/// </summary>
public class Search
{
 
	public Search()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string getNormalizedName(string str)
    {
        System.Text.StringBuilder normalizedSTR = new System.Text.StringBuilder(); ;
        char[] normalizedSTRarr = str.ToCharArray();
        foreach (char ch in normalizedSTRarr)
        {
            if (ch == 'أ' || ch == 'إ' || ch == 'ا' || ch == 'أ' || ch == 'آ')
            { normalizedSTR.Append('ا'); }
            else if (ch == 'ه' || ch == 'ة')
            { normalizedSTR.Append('ه'); }
            else if (ch == 'ي' || ch == 'ى' || ch == 'ئ')
            { normalizedSTR.Append('ى'); }
            else if (ch == 'ؤ' || ch == 'و')
            { normalizedSTR.Append('و'); }
            else
            { normalizedSTR.Append(ch); }
        }
        return normalizedSTR.ToString();
    }
   
    public DataTable Get_dt(SqlParameter[] sqlParam, String itemName)
    {
        DataTable dt  = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParam, "[search_"+itemName+"_Select]");
        return dt;
    }
    public LinkButton Get_linkbtn(SqlParameter[] sqlParam, DataTable itemdt, ListViewDataItem item, String linkbtnName)
    {
        LinkButton lnktitle = (LinkButton)item.FindControl(linkbtnName);

        if (itemdt.Rows[item.DataItemIndex]["title"].ToString() != "")
        {
            if (itemdt.Rows[item.DataItemIndex]["title"].ToString().Length > 100)
            {
                lnktitle.Text = itemdt.Rows[item.DataItemIndex]["title"].ToString().Substring(0, 100);
            }
            else { lnktitle.Text = itemdt.Rows[item.DataItemIndex]["title"].ToString(); }

            lnktitle.PostBackUrl = itemdt.Rows[item.DataItemIndex]["link"].ToString();
        }
        else if((itemdt.Columns.Contains("desc"))!=null)
        {
            if (itemdt.Rows[item.DataItemIndex]["desc"].ToString() != "")
            {
                if (itemdt.Rows[item.DataItemIndex]["desc"].ToString().Length > 100)
                {
                    lnktitle.Text = itemdt.Rows[item.DataItemIndex]["desc"].ToString().Substring(0, 100);

                }
                else { lnktitle.Text = itemdt.Rows[item.DataItemIndex]["desc"].ToString(); }
                lnktitle.PostBackUrl = itemdt.Rows[item.DataItemIndex]["link"].ToString();
            }
        }
        else if ((itemdt.Columns.Contains("keywords")) != null)
        {
            if (itemdt.Rows[item.DataItemIndex]["keywords"].ToString() != "")
            {
                if (itemdt.Rows[item.DataItemIndex]["keywords"].ToString().Length > 100)
                {
                    lnktitle.Text = itemdt.Rows[item.DataItemIndex]["keywords"].ToString().Substring(0, 100);

                }
                else { lnktitle.Text = itemdt.Rows[item.DataItemIndex]["keywords"].ToString(); }
                lnktitle.PostBackUrl = itemdt.Rows[item.DataItemIndex]["link"].ToString();
            }
        }
        return lnktitle;
    }
 

     
}