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

public partial class Photo_Gallery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString() ),//
                                                        new SqlParameter("@content_id",HttpContext.Current.Session["content_id"].ToString() ), //
                                                        new SqlParameter("@lang",HttpContext.Current.Session["lang_id"].ToString() ) }; //

        
            DataTable PhotosDT = new DataTable(); 
            PhotosDT = DatabaseFunctions.SelectData(sqlParams, "photos_select");
            for (int u = 0; u < PhotosDT.Rows.Count; u++)
            {
                PhotosDT.Rows[u]["large_image"] = get_folder_name(PhotosDT.Rows[u]["content_type"].ToString()) + PhotosDT.Rows[u]["large_image"].ToString(); 
            }
            Repeater1.DataSource = PhotosDT;
            Repeater1.DataBind();

            System.Text.StringBuilder javaScript = new System.Text.StringBuilder();
           

            for (int i = 0; i < PhotosDT.Rows.Count; i++)
            {
                if (i == 0)
                {
                    javaScript.Append("var photosArray = \n[\n");
                }

                DataRow dataRow = PhotosDT.Rows[i];

                for (int j = 0; j < dataRow.Table.Columns.Count; j++)
                {
                    if (j == 0)
                        javaScript.Append(" [ ");

                    javaScript.Append("'" + dataRow[j].ToString().Trim() + "'");
                    if ((j + 1) == dataRow.Table.Columns.Count)
                        javaScript.Append(" ]");
                    else
                        javaScript.Append(",");
                }

                if ((i + 1) == PhotosDT.Rows.Count)
                {
                    javaScript.Append("\n];\n");
                }
                else
                {
                    javaScript.Append(",\n");
                }
            }
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "ArrayScript", javaScript.ToString(), true);


        }
    }
    public string get_folder_name(string content_type)
    {
        string folder_name = "";
        switch (content_type)
        {
            case "1" :
                folder_name = "sheikhs/";
                break;
            case "2":
                folder_name = "events/";
                break;
            case "3":
                folder_name = "topics/";
                break;
            case "4":
                folder_name = "architict/";
                break;
            case "11":
                folder_name = "images/";
                break;
            default:
                break;

        }
        return folder_name;
    }
    #region Private Variables
    protected DataTable PhotosDT;
    #endregion

    #region Overriden Events
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        LoadDataTable();
    }
    #endregion

    #region Private Methods
    private void LoadDataTable()
    {
        SqlParameter[] sqlParams = new SqlParameter[] {    new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", HttpContext.Current.Session["lang_id"].ToString()) };

        
            DataTable PhotosDT = new DataTable(); 
            PhotosDT = DatabaseFunctions.SelectData(sqlParams, "photos_select");
        
    }
    #endregion

   
}
