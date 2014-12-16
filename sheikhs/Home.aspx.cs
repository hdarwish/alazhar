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

public partial class sheikhs_home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewRandmizeData();
    }
    public void ViewRandmizeData()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@lang_id", Convert.ToInt16(1)) };
        DataTable charDT = new DataTable();
        charDT = DatabaseFunctions.SelectData(sqlParams, "content_image_charcterRandomRecord");
        if (charDT.Rows.Count > 0)
        {
            //LinkChar.Text = charDT.Rows[0]["ImageID"].ToString();
            ImageButton1.ImageUrl = "../images/sheikhs/" + charDT.Rows[0]["image_name"].ToString();
            // img1.ImageUrl = "~/images/" + eventsDT.Rows[0]["image_url_" + Session["Lang"].ToString()].ToString();
            HiddenID.Value = charDT.Rows[0]["char_id"].ToString();
            ImageButton1.PostBackUrl = "../characters_details.aspx?id=" + int.Parse(HiddenID.Value);
            ImageButton1.ToolTip = charDT.Rows[0]["char_brief"].ToString();
           
        }
    }
    
}
