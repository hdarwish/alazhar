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

public partial class contactus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Image mahamer = (Image)Master.FindControl("mahamer");
        mahamer.ImageUrl = "../images/menu/5_o.gif";

        if (!Page.IsPostBack)
        {
            ListItem item;
            item = new ListItem("D", "--");
            DropDownList2.Items.Add(item);
            item = new ListItem("M", "--");
            DropDownList3.Items.Add(item);
            item = new ListItem("Y", "--");
            DropDownList4.Items.Add(item);

            item = new ListItem("D", "--");
            DropDownList5.Items.Add(item);
            item = new ListItem("M", "--");
            DropDownList6.Items.Add(item);
            item = new ListItem("Y", "--");
            DropDownList7.Items.Add(item);

            for (int i = 1; i <= 31; i++)
            {
                item = new ListItem(i.ToString(), i.ToString());
                DropDownList2.Items.Add(item);
            }

            for (int i = 1; i <= 12; i++)
            {
                item = new ListItem(i.ToString(), i.ToString());
                DropDownList3.Items.Add(item);
            }

            for (int i = 1900; i <= 2008; i++)
            {
                item = new ListItem(i.ToString(), i.ToString());
                DropDownList4.Items.Add(item);
            }


            for (int i = 1; i <= 31; i++)
            {
                item = new ListItem(i.ToString(), i.ToString());
                DropDownList5.Items.Add(item);
            }

            for (int i = 1; i <= 12; i++)
            {
                item = new ListItem(i.ToString(), i.ToString());
                DropDownList6.Items.Add(item);
            }

            for (int i = 1900; i <= 2008; i++)
            {
                item = new ListItem(i.ToString(), i.ToString());
                DropDownList7.Items.Add(item);
            }
        }
    }
}
