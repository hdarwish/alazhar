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
        if (!Page.IsPostBack)
        {
           
        }

        Image almaa = (Image)Master.FindControl("almaa");
        almaa.ImageUrl = "../images/menu/4_o.gif";

        LinkButton1.CssClass = "out_links4_sel";
        Image1.ImageUrl = "../images/p3.gif";

        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton6.CssClass = "out_links4";
        LinkButton7.CssClass = "out_links4";


    }

 

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        description.Visible = true;
        live.Visible = false;
        birth.Visible = false;
        malfat.Visible = false;
        makoteb.Visible = false;
        photos.Visible = false;

        LinkButton1.CssClass = "out_links4_sel";
        Image1.ImageUrl = "../images/p3.gif";
        Image2.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton6.CssClass = "out_links4";
        LinkButton7.CssClass = "out_links4";
        
       

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        birth.Visible = true;
        birth1.Visible = true;
        birth2.Visible =  false;
        birth3.Visible =  false;
        description.Visible = false;
        live.Visible = false;
        malfat.Visible = false;
        makoteb.Visible = false;
        photos.Visible = false;



        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton6.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton7.CssClass = "out_links4";
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        live.Visible = true;
        live1.Visible = true;
        live2.Visible = false;
        birth.Visible = false;
        description.Visible = false;
        malfat.Visible = false;
        makoteb.Visible = false;
        photos.Visible = false;

        Image3.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image2.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton7.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton6.CssClass = "out_links4";
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        malfat.Visible = true;
        live.Visible = false;
        birth.Visible = false;
        description.Visible = false;
        makoteb.Visible = false;
        photos.Visible = false;


        Image4.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image2.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton2.CssClass = "out_links4_sel";
        LinkButton7.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton6.CssClass = "out_links4";
    
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        makoteb.Visible = true;
        malfat.Visible = false;
        live.Visible = false;
        birth.Visible = false;
        description.Visible = false;
        photos.Visible = false;


        Image5.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image2.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton3.CssClass = "out_links4_sel";
        LinkButton7.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton6.CssClass = "out_links4";
       
    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        photos.Visible = true;
        makoteb.Visible = false;
        malfat.Visible = false;
        live.Visible = false;
        birth.Visible = false;
        description.Visible = false;


        Image6.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image2.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton4.CssClass = "out_links4_sel";
        LinkButton7.CssClass = "out_links4";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton6.CssClass = "out_links4";
       

      
       
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        birth.Visible = true;
        birth2.Visible = true;

        birth1.Visible = false;
        description.Visible = false;

        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton6.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton7.CssClass = "out_links4";

    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
     
    }

    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        birth.Visible = true;
        birth3.Visible = true;
        birth2.Visible = false;
        birth1.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton6.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton7.CssClass = "out_links4";
    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        birth.Visible = true;
        birth1.Visible = true;
        birth3.Visible = false;
        birth2.Visible = false;
        description.Visible = false;
        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton6.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton7.CssClass = "out_links4";
    }

    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        birth.Visible = true;
        birth2.Visible = true;
        birth3.Visible = false;
        birth1.Visible = false;
        description.Visible = false;

        Image2.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image3.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton6.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton7.CssClass = "out_links4";
    }

    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        live.Visible = true;
        live2.Visible = true;
        live1.Visible= false;
        birth.Visible = false;
        description.Visible = false;

        Image3.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image2.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton7.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton6.CssClass = "out_links4";
    }
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        live.Visible = true;
        live3.Visible = true;
        live1.Visible = false;
        live2.Visible = false;
        birth.Visible = false;
        description.Visible = false;

        Image3.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image2.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton7.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton6.CssClass = "out_links4";
    }
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        live.Visible = true;
        live1.Visible = true;
        live2.Visible = false;
        live3.Visible = false;
        birth.Visible = false;
        description.Visible = false;

        Image3.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image2.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton7.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton6.CssClass = "out_links4";
    }

    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        live.Visible = true;
        live2.Visible = true;
        live1.Visible = false;
        live3.Visible = false;
        birth.Visible = false;
        description.Visible = false;

        Image3.ImageUrl = "../images/p3.gif";
        Image1.ImageUrl = "../images/p2.gif";
        Image2.ImageUrl = "../images/p2.gif";
        Image4.ImageUrl = "../images/p2.gif";
        Image5.ImageUrl = "../images/p2.gif";
        Image6.ImageUrl = "../images/p2.gif";
        Image7.ImageUrl = "../images/p2.gif";

        LinkButton7.CssClass = "out_links4_sel";
        LinkButton2.CssClass = "out_links4";
        LinkButton3.CssClass = "out_links4";
        LinkButton4.CssClass = "out_links4";
        LinkButton5.CssClass = "out_links4";
        LinkButton1.CssClass = "out_links4";
        LinkButton6.CssClass = "out_links4";
    }
}
