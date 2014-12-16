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

public partial class Esdarat_articles_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Convert.ToInt16(Request.QueryString["id"]);
            HiddenID.Value = id.ToString();
            View();
        }
    }
    public void View()
    {
        SqlParameter[] sqlparams = new SqlParameter[]
        {

           new SqlParameter("@lang_id",Convert.ToInt16(1)),
           new SqlParameter("@doc_id",Convert.ToInt16 (HiddenID.Value))
           
        };
        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlparams, "documents_articlesdetails_select");
        if (dt.Rows.Count > 0)
        {
            if (dt.Rows[0]["large_image"].ToString() == "")
            {
                link_pdf1.Visible = false;
            }
            else
            {
                link_pdf1.Visible = true;
                link_pdf1.HRef = "~/images/esdarat/" + dt.Rows[0]["large_image"].ToString();
            }
            Labtitle.Text = dt.Rows[0]["title"].ToString();
            //Labbrief.Text = dt.Rows[0]["brief"].ToString();
            
            Labpubtitle.Text = dt.Rows[0]["resource"].ToString();
            labpubLocation.Text = dt.Rows[0]["folders_no"].ToString();
            lblseriesno.Text = dt.Rows[0]["series_no"].ToString();
            labpageno.Text = dt.Rows[0]["pages_no"].ToString();
            lblAuthor.Text = dt.Rows[0]["name"].ToString();
            //labisbn.Text = dt.Rows[0]["isbn"].ToString();
           
            //labdirsub.Text = dt.Rows[0]["notes"].ToString();
            //labtags.Text = dt.Rows[0]["title_ar"].ToString();
            Lablang.Text = dt.Rows[0]["doc_lang"].ToString();
          
        }

    }
}
