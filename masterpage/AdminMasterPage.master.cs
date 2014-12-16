using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.IO;
using System.Data.SqlClient;
public partial class AdminMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string uu = Session["Lang"].ToString();
        if (!IsPostBack)
        {
            if (Session["Lang"] != null)
            {
                if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                {
                    EnLinkButton.Visible = false;
                }
                if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                {
                    FrLinkButton.Visible = false;
                }
                if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                {
                    ArLinkButton.Visible = false;
                }
            }


            if (Session["username"] == null)
            {
                login_href.InnerText = "تسجيل الدخول";
                welcome_lbl.Visible = false;
            }
            else
            {
                login_href.InnerText = "تسجيل الخروج";
                welcome_lbl.Visible = true;
                welcome_lbl.Text = "مرحباً: " + Session["thename"].ToString();
            }
            //this.Page.Title = "ذاكرة الأزهر";
            if ( Session["username"] == null)
            {
                string page_name = Path.GetFileName(Request.Path);
                if (page_name.ToLower() != "login.aspx")
                {
                    Response.Redirect("login.aspx");
                }
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                Session["Lang"] = "ar";
            }
            else
            {
                string page_name = Path.GetFileName(Request.Path);
                if (!security_issues.check_page_access(page_name))
                {
                    Response.Redirect("login.aspx");
                }
            }
            if (Session["user_type"] != null)
            {
                if (Session["user_type"].ToString() == "10")
                { tbl_lang.Visible = false; }
                else { tbl_lang.Visible = true; }
            }
        }
    }
    protected void ArLinkButton_Click(object sender, EventArgs e)
    {
        Session["Lang"] = "ar";
        Response.Redirect(Request.Url.ToString());
    }
    protected void EnLinkButton_Click(object sender, EventArgs e)
    {
        Session["Lang"] = "en";
        Response.Redirect(Request.Url.ToString());
    }
    protected void FrLinkButton_Click(object sender, EventArgs e)
    {
        Session["Lang"] = "fr";
        Response.Redirect(Request.Url.ToString());
    }
    
}
