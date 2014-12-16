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
        Image1.ImageUrl = "../images/p2.gif";
        Image2.ImageUrl = "../images/p3.gif";
        Image history = (Image)Master.FindControl("history");
        history.ImageUrl = "../images/menu/2_o.gif";
        if (!Page.IsPostBack)
        {
            description.Visible = false;
            history.Visible = true;
            history1.Visible = true;

            LinkButton1.CssClass = "out_links4";
            LinkButton2.CssClass = "out_links4_sel";
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Image1.ImageUrl = "../images/p3.gif";
        Image2.ImageUrl = "../images/p2.gif";
        description.Visible = true;
        history.Visible =  false;
        LinkButton1.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
          Image2.ImageUrl = "../images/p3.gif";
          Image1.ImageUrl = "../images/p2.gif";
        history.Visible = true;
        history1.Visible = true;
        history2.Visible = false;
        history3.Visible = false;
        history4.Visible = false;
        history5.Visible = false;
        history6.Visible = false;
        history7.Visible = false;
        description.Visible = false;
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        history.Visible = true;
        history2.Visible = true;
        history1.Visible = false;
        history3.Visible = false;
        description.Visible = false;
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";

        history.Visible = true;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        description.Visible = false;
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        history.Visible = true;
        history3.Visible = true;
        history1.Visible = false;
        history2.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        history.Visible = true;
        history1.Visible = true;
        history6.Visible = false;
        history4.Visible = false;
        history2.Visible = false;
        history3.Visible = false;
        history7.Visible = false;
        history5.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        history.Visible = true;
        history4.Visible = true;
        history1.Visible = false;
        history3.Visible = false;
        history2.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }

    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        history.Visible = true;
        history2.Visible = true;
        history6.Visible = false;
        history1.Visible = false;
        history4.Visible = false;
        history3.Visible = false;
        history7.Visible = false;
        history5.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }

    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        history.Visible = true;
        history5.Visible = true;
        history3.Visible = false;
        history4.Visible = false;
        history1.Visible = false;
        history2.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }

    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        history.Visible = true;
        history3.Visible = true;
        history6.Visible = false;
        history1.Visible = false;
        history2.Visible = false;
        history4.Visible = false;
        history7.Visible = false;
        history5.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }

    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        history.Visible = true;
        history6.Visible = true;
        history1.Visible = false;
        history2.Visible = false;
        history3.Visible = false;
        history4.Visible = false;
        history5.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }

    protected void LinkButton14_Click(object sender, EventArgs e)
    {
       history.Visible = true;
        history4.Visible = true;
        history6.Visible = false;
        history1.Visible = false;
        history2.Visible = false;
        history3.Visible = false;
        history7.Visible = false;
        history5.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }

    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        history.Visible = true;
        history7.Visible = true;
        history6.Visible = false;
        history1.Visible = false;
        history2.Visible = false;
        history3.Visible = false;
        history4.Visible = false;
        history5.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }
    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        history.Visible = true;
        history5.Visible = true;
        history6.Visible = false;
        history1.Visible = false;
        history2.Visible = false;
        history3.Visible = false;
        history4.Visible = false;
        history7.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }
    protected void LinkButton17_Click(object sender, EventArgs e)
    {
        history.Visible = true;
        history6.Visible = true;
        history7.Visible = false;
        history1.Visible = false;
        history2.Visible = false;
        history3.Visible = false;
        history4.Visible = false;
        history5.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4_sel";
    }
}
