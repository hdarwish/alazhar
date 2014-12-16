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
        sewar.Visible =false;
        lis.Visible = true;

        if (!Page.IsPostBack)
        {
            Label2.Text = "  27  ";
        }

        Image almaa = (Image)Master.FindControl("almaa");
        almaa.ImageUrl = "../images/menu/4_o.gif";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        sewar.Visible = true;
        lis.Visible = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        sewar.Visible = false;
        lis.Visible = true;
    }

  
   
}
