using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Globalization;


public partial class administration_researsher_view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         
         
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add_new_researsher.aspx");
    }
    
    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {
             if (e.Row.RowType == DataControlRowType.DataRow)
        {
            int chek = 0;
                 DataTable selct_user_for_delete = General_Helping.GetDataTable("selct_users");

             for (int i = e.Row.RowIndex,counter=0; i < selct_user_for_delete.Rows.Count; i++)
             {
                
                 for (int j = 8; j < selct_user_for_delete.Columns.Count; j++)
              {
                  if (selct_user_for_delete.Rows[i][j].ToString() == "0")
                  {
                      counter++;
                  }
              }
                 chek = counter;
             }
             if (chek != 9)
             {
                 LinkButton LBTDelet = (LinkButton)e.Row.FindControl("LBTDelet");
                 LBTDelet.Visible = false;
             }
             else
             {
                 LinkButton LBTDelet = (LinkButton)e.Row.FindControl("LBTDelet");
                 LBTDelet.Visible = true;
             }
        }
    }
}
    
    

