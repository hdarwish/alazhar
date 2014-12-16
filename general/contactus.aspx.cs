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
using System.Xml;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

public partial class contactus : BasePage
{
    //General_Helping Obj_General_Helping = new General_Helping();

    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlAnchor currentMenu = (HtmlAnchor)Page.Master.FindControl("hypSiteMap2");
        currentMenu.HRef = "~/general/contactus.aspx";
        Literal lbl_veiw = (Literal)Page.Master.FindControl("Literal2");
        currentMenu.Visible = true;

        lbl_veiw.Text = ">> ِإتصل بنا ";
        //if (!IsPostBack)
        //{
           
        
           


        //    //if (Session["Lang"].ToString() == "1" || Session["Lang"].ToString() == "ar")
        //    //{
        //    //    //mainclass.Attributes.Add("href", "../css/detailsCSS.css");
        //    //}
        //    //if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        //    //{
               
        //    //}
        //}
    }

   
}