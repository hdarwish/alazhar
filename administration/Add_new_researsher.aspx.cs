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

public partial class Add_new_researsher : BasePage
{

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            string v = Request.QueryString["id"];
            DataTable objectsDT = content_types_DB.SelectAll();
            ChB_item.DataSource = content_types_DB.SelectAll();
            ChB_item.DataBind();
            txtid.Value = v;
            if (txtid.Value != "")
            {
                DataTable dt = new DataTable();
                SqlParameter[] userparm = new SqlParameter[] { new SqlParameter("@id", v) };
                dt = DatabaseFunctions.SelectData(userparm, "get_user_by_ID");

                RFV_password.Enabled = false;

                for (int i = 0; i < objectsDT.Rows.Count; i++)
                {
                    string select = dt.Rows[0][i].ToString();
                    if (select == "0")
                    {
                        ChB_item.Items[i].Selected = false;
                    }
                    else
                    {
                        ChB_item.Items[i].Selected = true;
                    }
                }


                txtresearsh_name.Text = dt.Rows[0]["name"].ToString();
                txtuser_name.Text = dt.Rows[0]["username"].ToString();

                input_password.Value = dt.Rows[0]["password"].ToString();

                txtuser_email.Text = dt.Rows[0]["E_mail"].ToString();
                txtuser_mobile.Text = dt.Rows[0]["mobile"].ToString();

                ddlusertype.SelectedValue = dt.Rows[0]["user_type"].ToString();
                ddlusertype.DataBind();


            }
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        txtresearsh_name.Text = " ";
        txtuser_name.Text = " ";
        txtuser_password.Text = " ";
        txtuser_email.Text = " ";
        txtuser_mobile.Text = " ";

        for (int counter = 0; counter < ChB_item.Items.Count; counter++)
        {
            ChB_item.Items[counter].Selected = false;
        }
    }
    public static void ShowAlertMessage(string error)
    {

        Page page = HttpContext.Current.Handler as Page;
        if (page != null)
        {
            error = error.Replace("'", "\'");
            ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + error + "');", true);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtid.Value == "")
        {
            DataTable dtusers = users_DB.SelectAll();
            int userscnt = 0;
            if (dtusers.Rows.Count > 0)
            {
                foreach (DataRow dr in dtusers.Rows)
                {
                    if (dr["username"].ToString() == txtuser_name.Text)
                    {
                        userscnt++;
                    }
                }
            }
            if (userscnt > 0)
            {
                ShowAlertMessage("عفوا تم إدخال مستخدم أخر بنفس اسم المرور من قبل اختر اسم اخر ");
                txtuser_name.Text = "";
                return;
            }
        }

        int research_assign_char = 0,
            research_assign_event = 0,
            research_assign_topics = 0,
            research_assign_place = 0,
            research_assign_artifact = 0,
            research_assign_video = 0,
            research_assign_audio = 0,
            research_assign_doc = 0,
            research_assign_article = 0,
            research_assign_book = 0,
            research_assign_image = 0,
            research_assign_manuscript = 0,
            research_assign_thesis = 0,
            research_assign_conference_proceeding = 0,
            research_site_assign = 0;
        for (int counter = 0; counter < ChB_item.Items.Count; counter++)
        {
            if (ChB_item.Items[counter].Selected == true)
            {
                switch (counter)
                {
                    case 0:
                        research_assign_char = 1;
                        break;
                    case 1:
                        research_assign_event = 1;
                        break;
                    case 2:
                        research_assign_topics = 1;
                        break;
                    case 3:
                        research_assign_place = 1;
                        break;
                    case 4:
                        research_assign_artifact = 1;
                        break;
                    case 5:
                        research_assign_video = 1;
                        break;
                    case 6:
                        research_assign_audio = 1;
                        break;
                    case 7:
                        research_assign_doc = 1;
                        break;
                    case 8:
                        research_assign_article = 1;
                        break;
                    case 9:
                        research_assign_book = 1;
                        break;
                    case 10:
                        research_assign_image = 1;
                        break;
                    case 11:
                        research_assign_manuscript = 1;
                        break;
                    case 12:
                        research_assign_thesis = 1;
                        break;
                    case 13:
                        research_assign_conference_proceeding = 1;
                        break;
                    case 14:
                        research_site_assign = 1;
                        break;
                    
                }
            }
            else
            {
                switch (counter)
                {
                    case 0:
                        research_assign_char = 0;
                        break;
                    case 1:
                        research_assign_event = 0;
                        break;
                    case 2:
                        research_assign_topics = 0;
                        break;
                    case 3:
                        research_assign_place = 0;
                        break;
                    case 4:
                        research_assign_artifact = 0;
                        break;
                    case 5:
                        research_assign_video = 0;
                        break;
                    case 6:
                        research_assign_audio = 0;
                        break;
                    case 7:
                        research_assign_doc = 0;
                        break;
                    case 8:
                        research_assign_article = 0;
                        break;
                    case 9:
                        research_assign_book = 0;
                        break;
                    case 10:
                        research_assign_image = 0;
                        break;
                    case 11:
                        research_assign_manuscript = 0;
                        break;
                    case 12:
                        research_assign_thesis = 0;
                        break;
                    case 13:
                        research_assign_conference_proceeding = 0;
                        break;
                    case 14:
                        research_site_assign = 0;
                        break;
                }
            }
        }
        
        if (txtid.Value == "")
        {
            RFV_password.Enabled = true;
            
            SqlParameter[] insertpar = new SqlParameter[]
            {
            new SqlParameter("@researshname",txtresearsh_name.Text),
            new SqlParameter ("@username",txtuser_name.Text),
            new SqlParameter ("@password",txtuser_password.Text),
            new SqlParameter("@email",txtuser_email.Text),
            new SqlParameter("@mobile",txtuser_mobile.Text),
            new SqlParameter("@user_type",ddlusertype.SelectedValue.ToString()),
            new SqlParameter("@research_assign_char",(research_assign_char)),
            new SqlParameter("@research_assign_event",(research_assign_event)),
            new SqlParameter("@research_assign_topics",(research_assign_topics)),
            new SqlParameter("@research_assign_place",(research_assign_place)),
            new SqlParameter("@research_assign_artifact",research_assign_artifact),
            new SqlParameter("@research_assign_video",research_assign_video),
            new SqlParameter("@research_assign_audio",research_assign_audio),
            new SqlParameter("@research_assign_doc",research_assign_doc),
            new SqlParameter("@research_assign_article",research_assign_article),
            new SqlParameter("@research_assign_book",research_assign_book),
            new SqlParameter("@research_assign_image",research_assign_image),
            new SqlParameter("@research_assign_manuscript",research_assign_manuscript),
            new SqlParameter("@research_assign_thesis",research_assign_thesis),
            new SqlParameter("@research_assign_conference_proceeding",research_assign_conference_proceeding),
            new SqlParameter("@research_site_assign",research_site_assign)
            };
            int insert = DatabaseFunctions.UpdateData(insertpar, "insert_resaershname");
            Response.Redirect("researsher_view.aspx");
        }
        else
        {
            if (txtuser_password.Text != "")
            {
                input_password.Value = txtuser_password.Text;
            }
            SqlParameter[] updatepar = new SqlParameter[]
        {
        new SqlParameter("@id",Convert.ToInt16(txtid.Value)),
        new SqlParameter("@researshname",txtresearsh_name.Text),
        new SqlParameter ("@username",txtuser_name.Text),
        new SqlParameter ("@password",input_password.Value),
        new SqlParameter("@email",txtuser_email.Text),
        new SqlParameter("@mobile",txtuser_mobile.Text),
        new SqlParameter("@user_type",ddlusertype.SelectedValue.ToString()),
        new SqlParameter("@research_assign_char",(research_assign_char)),
        new SqlParameter("@research_assign_event",(research_assign_event)),
        new SqlParameter("@research_assign_topics",(research_assign_topics)),
        new SqlParameter("@research_assign_place",(research_assign_place)),
        new SqlParameter("@research_assign_artifact",research_assign_artifact),
        new SqlParameter("@research_assign_video",research_assign_video),
        new SqlParameter("@research_assign_audio",research_assign_audio),
        new SqlParameter("@research_assign_doc",research_assign_doc),
        new SqlParameter("@research_assign_article",research_assign_article),
        new SqlParameter("@research_assign_book",research_assign_book),
        new SqlParameter("@research_assign_image",research_assign_image),
        new SqlParameter("@research_assign_manuscript",research_assign_manuscript),
        new SqlParameter("@research_assign_thesis",research_assign_thesis),
        new SqlParameter("@research_assign_conference_proceeding",research_assign_conference_proceeding),
        new SqlParameter("@research_site_assign",research_site_assign)
        };

            int insert = DatabaseFunctions.UpdateData(updatepar, "update_resaershname");
            Response.Redirect("researsher_view.aspx");
        }
    }
    
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("researsher_view.aspx");
    }
}
