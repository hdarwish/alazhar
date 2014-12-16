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

public partial class sheikhs_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        sewar.Visible = false;
        list.Visible = true;

        if (!Page.IsPostBack)
        {
           
        }

        Image sheyog = (Image)Master.FindControl("sheyog");
        sheyog.ImageUrl = "../images/menu/3_o.gif";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
       
        list.Visible = true;
        sewar.Visible = false;
      
      
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      
        sewar.Visible = true;
        list.Visible = false;
    }

  

   
}
