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

public partial class topics_topic_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Convert.ToInt16(Request.QueryString["id"]);
            Session["content_id"] = Request["id"];
            Session["content_type"] = "3";
            HiddenID.Value = id.ToString();
            View();
        }
    }
    public void View()
    {
        SqlParameter[] sqlparams = new SqlParameter[]
        {

           new SqlParameter("@lang_id",Convert.ToInt16(1)),
           new SqlParameter("@topic_id",Convert.ToInt16 (HiddenID.Value))
           
        };
        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlparams, "topics_details_select2");
        if (dt.Rows.Count > 0)
        {
            Labtitle.Text = dt.Rows[0]["title"].ToString();
            Labdetails.InnerText = dt.Rows[0]["topic_details"].ToString();
            string y = dt.Rows[0]["large_image"].ToString();
            if (dt.Rows[0]["large_image"].ToString() != "")
            {
                Img.ImageUrl = "~/images/topics/" + dt.Rows[0]["large_image"].ToString();
            }
            else
            {
                Img.Visible = false;

            }
        }
    }
}
