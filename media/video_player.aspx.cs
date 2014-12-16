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

public partial class videoPlayer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Get_Path();
        }
    }
    public string Get_Path()
    {
        string path = "";


       
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playvideoid"])) ,
        new SqlParameter("@content_type", Convert.ToInt16(0))};
        DataTable videosDT = new DataTable();
        videosDT = DatabaseFunctions.SelectData(sqlParams, "videos_select");


        SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playvideoid"])) };
        DataTable vidoesTagsDT = new DataTable();
        vidoesTagsDT = DatabaseFunctions.SelectData(sqlParams1, "get_videos_tags");

        DLTags.DataSource = vidoesTagsDT;
        DLTags.DataBind();

       
       

        lblTitle.Text = videosDT.Rows[0]["title"].ToString();
        //lblCategory.Text = videosDT.Rows[0]["category"].ToString();
        lblDesc.Text = videosDT.Rows[0]["desc"].ToString();
        if (videosDT.Rows[0]["record_place"].ToString() != "")
        {
            lblplace.Text = videosDT.Rows[0]["record_place"].ToString();
        }
        else lblplace.Text = "غير معروف";
        if (videosDT.Rows[0]["record_date_georgian"].ToString() != "")
        {
            lbldate.Text = videosDT.Rows[0]["record_date_georgian"].ToString();
        }
        else lbldate.Text = "غير معروف";
        if (videosDT.Rows[0]["name"].ToString() != "")
            lblName.Text = videosDT.Rows[0]["name"].ToString();
        else
            trName.Visible = false;
       
        lblDuration.Text = videosDT.Rows[0]["period"].ToString();
        lblJuest.Text = videosDT.Rows[0]["guest_details"].ToString();
        if (videosDT.Rows[0]["presenter_details"].ToString() != "")
            lblPresenter.Text = videosDT.Rows[0]["presenter_details"].ToString();
        else
            trPresenter.Visible = false;
        lblResource.Text = videosDT.Rows[0]["resource_name"].ToString();
        
        //path += "http://";
        path += ResolveUrl("~/upload/Videos/" + videosDT.Rows[0]["file_name"].ToString() + videosDT.Rows[0]["extension"].ToString());
        // path += "&image=";
        //path += ResolveUrl("~/upload/Videos/" + videosDT.Rows[0]["thumbnail"].ToString());
        //videoDesc.Text = videosDT.Rows[0]["description"].ToString();
        return path;
    }
}
