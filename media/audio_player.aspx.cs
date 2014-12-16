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

public partial class audioPlayer : System.Web.UI.Page
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



        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playaudioid"])) ,
        new SqlParameter("@content_type", Convert.ToInt16(0))};
        DataTable audiosDT = new DataTable();
        audiosDT = DatabaseFunctions.SelectData(sqlParams, "audio_select");

        SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playaudioid"]))};
        DataTable audiosTagsDT = new DataTable();
        audiosTagsDT = DatabaseFunctions.SelectData(sqlParams1, "get_audios_tags");

        DLTags.DataSource = audiosTagsDT;
        DLTags.DataBind();
        
        lblTitle.Text = audiosDT.Rows[0]["title"].ToString();
        //lblCategory.Text = audiosDT.Rows[0]["category"].ToString();
        lblDesc.Text = audiosDT.Rows[0]["desc"].ToString();
        lblName.Text = audiosDT.Rows[0]["name"].ToString();
        lblDuration.Text = audiosDT.Rows[0]["period"].ToString();
        lblJuest.Text = audiosDT.Rows[0]["guest_details"].ToString();
        if (audiosDT.Rows[0]["record_place"].ToString() != "")
        {
            lblplace.Text = audiosDT.Rows[0]["record_place"].ToString();
        }
        else lblplace.Text = "غير معروف";
        if (audiosDT.Rows[0]["record_date_georgian"].ToString() != "")
        {
            lbldate.Text = audiosDT.Rows[0]["record_date_georgian"].ToString();
        }
        else lbldate.Text = "غير معروف";
        if (audiosDT.Rows[0]["presenter_details"].ToString() != "")
            lblPresenter.Text = audiosDT.Rows[0]["presenter_details"].ToString();
        else
            trPresenter.Visible = false;
        lblResource.Text = audiosDT.Rows[0]["resource_name"].ToString();
        //path += "http://";
        path += ResolveUrl("~/upload/audio/" + audiosDT.Rows[0]["file_name"].ToString() + audiosDT.Rows[0]["extension"].ToString());
        // path += "&image=";
        //path += ResolveUrl("~/upload/Videos/" + videosDT.Rows[0]["thumbnail"].ToString());
        //videoDesc.Text = videosDT.Rows[0]["description"].ToString();


        return path;
    }
 
    protected void DLAudioAttached_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        
    }
}
