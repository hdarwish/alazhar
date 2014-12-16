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

public partial class Elzakera_Add_new_technique : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string v = Request.QueryString["id"];
            idtxt.Text = v;
            if (idtxt.Text != "")
            {
                string title_ar = Request.QueryString["title_ar"];
                string title_en = Request.QueryString["title_en"];
                string title_fr = Request.QueryString["title_fr"];
                tech_ar.Text = title_ar;
                tech_en.Text = title_en;
                tech_fre.Text = title_fr;
            }
        }  
	}
    
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        tech_ar.Text = " ";
        tech_en.Text = " ";
        tech_fre.Text = " ";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (idtxt.Text.Length==0)
        {
        SqlParameter[] insertpar = new SqlParameter[]
        {
         new SqlParameter("@title_ar",tech_ar.Text),
         new SqlParameter ("@title_en",tech_en.Text),
         new SqlParameter ("@title_fr",tech_fre.Text)
        };

        int insert = DatabaseFunctions.UpdateData(insertpar, "tech_ins");
            Response.Redirect("techniqes.aspx");
        }
        else 
        {
            SqlParameter[] insertpar = new SqlParameter[]
        {new SqlParameter("@id",idtxt.Text),
         new SqlParameter("@title_ar",tech_ar.Text),
         new SqlParameter ("@title_en",tech_en.Text),
         new SqlParameter ("@title_fr",tech_fre.Text)
        };

            int insert = DatabaseFunctions.UpdateData(insertpar, "tech_update");
            Response.Redirect("techniqes.aspx");
        }
    }
}
