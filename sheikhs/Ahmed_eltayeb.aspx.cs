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

        Image sheyog = (Image)Master.FindControl("sheyog");
        sheyog.ImageUrl = "../images/menu/3_o.gif";
        if (!Page.IsPostBack)
        {
           

        }


        birth.Visible = true;
        birth1.Visible = true;
        Mission.Visible = false;
        Honor.Visible = false;
        birth2.Visible = false;
        Scientific_work.Visible = false;
        Position.Visible = false;
        books.Visible = false;
        LinkButton1.CssClass = "out_links4_sel";
        Image1.ImageUrl = "../images/p3.gif";

        Image2.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";

        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton40.CssClass = "out_links4";
    }



    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        birth.Visible = true;
        birth1.Visible = true;
        Mission.Visible = false;
        Honor.Visible = false;
        birth2.Visible = false;
        Scientific_work.Visible = false;
        Position.Visible = false;
        books.Visible = false;
        LinkButton1.CssClass = "out_links4_sel";
        Image1.ImageUrl = "../images/p3.gif";


        Image2.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton40.CssClass = "out_links4";
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Mission.Visible = true;
        birth.Visible =  false;
        Honor.Visible = false;
        Scientific_work.Visible = false;
        Position.Visible = false;
        books.Visible = false;
        LinkButton2.CssClass = "out_links4_sel";
        Image2.ImageUrl = "../images/p3.gif";


        Image1.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        LinkButton1.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton40.CssClass = "out_links4";
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Honor.Visible = true;
        Mission.Visible = false;
        birth.Visible = false;
        Scientific_work.Visible = false;
        Position.Visible = false;
        books.Visible = false;
        LinkButton3.CssClass = "out_links4_sel";
        Image3.ImageUrl = "../images/p3.gif";


        Image2.ImageUrl = "../images/p2.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        LinkButton2.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton40.CssClass = "out_links4";
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Scientific_work.Visible = true;
        Scientific_work1.Visible = true;
        Scientific_work2.Visible = false;
        Honor.Visible = false;
        Mission.Visible = false;
        birth.Visible = false;
        Position.Visible = false;
        books.Visible = false;
        LinkButton4.CssClass = "out_links4_sel";
        Image4.ImageUrl = "../images/p3.gif";



        Image2.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton40.CssClass = "out_links4";
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Position.Visible = true;
        Scientific_work.Visible = false;
        Scientific_work1.Visible = false;
        Scientific_work2.Visible = false;
        Honor.Visible = false;
        Mission.Visible = false;
        birth.Visible = false;
        books.Visible = false;
        LinkButton5.CssClass = "out_links4_sel";
        Image5.ImageUrl = "../images/p3.gif";


        Image2.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";

        LinkButton40.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
      
    }

    protected void LinkButton40_Click(object sender, EventArgs e)
    {
        books.Visible = true;
        Position.Visible = false;
        Scientific_work.Visible = false;
        Scientific_work1.Visible = false;
        Scientific_work2.Visible = false;
        Honor.Visible = false;
        Mission.Visible = false;
        birth.Visible = false;

        LinkButton40.CssClass = "out_links4_sel";
        Image6.ImageUrl = "../images/p3.gif";


        Image2.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";

        LinkButton5.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        birth1.Visible = false;
        birth2.Visible = true;
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        birth1.Visible =  true;
        birth2.Visible = false;
    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Scientific_work.Visible = true;
        Scientific_work2.Visible = true;
        Scientific_work1.Visible = false;
        Honor.Visible = false;
        Mission.Visible = false;
        birth.Visible = false;

        LinkButton4.CssClass = "out_links4_sel";
        Image4.ImageUrl = "../images/p3.gif";



        Image2.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";

        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
    }
}