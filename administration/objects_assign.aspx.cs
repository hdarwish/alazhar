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
using System.Runtime.Serialization;
using System.Net.Mail;
using System.Text;

public partial class administration_objects_assign : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            get_content_types();
            get_researches(0);
        }
    }

    public void get_researches(int object_id)
    {
        string assign_field = "";
        switch (object_id)
        {
            case 1:
                assign_field = "research_assign_char";
                break;
            case 2:
                assign_field = "research_assign_event";
                break;
            case 3:
                assign_field = "research_assign_topics";
                break;
            case 4:
                assign_field = "research_assign_place";
                break;
            case 5:
                assign_field = "research_assign_artifact";
                break;
            case 6:
                assign_field = "research_assign_video";
                break;
            case 7:
                assign_field = "research_assign_audio";
                break;
            case 8:
                assign_field = "research_assign_doc";
                break;
            case 9:
                assign_field = "research_assign_article";
                break;
            case 10:
                assign_field = "research_assign_book";
                break;
            case 11:
                assign_field = "research_assign_image";
                break;
            case 12:
                assign_field = "research_assign_manuscript";
                break;
            case 13:
                assign_field = "research_assign_thesis";
                break;
            case 14:
                assign_field = "research_assign_conference_proceeding";
                break;
            case 15:
                assign_field = "research_site_assign";
                break;

        }
        SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@assign_field", assign_field) };
        DataTable dt = DatabaseFunctions.SelectData(sqlParams1, "get_users_data");
        researcher.DataSource = dt;
        researcher.DataBind();

    }

    public void get_content_types()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { };
        DataTable dt = DatabaseFunctions.SelectData(sqlParams, "get_content_types");
        types_list.DataSource = dt;
        types_list.DataBind();
    }
    protected void objects_grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        objects_grid.PageIndex = e.NewPageIndex;
        get_researches(Convert.ToInt16(types_list.SelectedValue));
    }
    protected void proceed_Click(object sender, EventArgs e)
    {
        int z;
        foreach (GridViewRow row in objects_grid.Rows)
        {
            // Access the CheckBox
            CheckBox cbActiveEn = (CheckBox)row.FindControl("ActivateEn");
            HtmlInputHidden sID = (HtmlInputHidden)row.FindControl("user_id");
            if (cbActiveEn != null && cbActiveEn.Checked)
            {
                z = General_Helping.ExcuteQuery("update Users set active=1 where id=" + sID.Value.ToString());
            }
            else
            {
                z = General_Helping.ExcuteQuery("update Users set active=0 where id=" + sID.Value.ToString());
            }

            // Access the CheckBox
            CheckBox cbDel = (CheckBox)row.FindControl("DeleteEvent");
            if (cbDel != null && cbDel.Checked)
            {
                SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ID", sID.Value.ToString()) };
                int rslt = DatabaseFunctions.UpdateData(sqlParams, "User_Delete");
            }

        }
        get_researches(Convert.ToInt16(types_list.SelectedValue));
    }
    public void fill_grid()
    {
        DataTable dt = new DataTable();
        switch (types_list.SelectedValue)
        {
            case "1":
                SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", object_name.Text), 
                       
                        new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
               dt = DatabaseFunctions.SelectData(sqlParams1, "get_characters_titles1");
                
                break;
            case "2":
                SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@event_name", object_name.Text),
                   
                        new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams2, "get_events_titles1");
                break;
            case "3":
                SqlParameter[] sqlParams3 = new SqlParameter[] { new SqlParameter("@topic_name", object_name.Text),
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams3, "get_topics_titles1");
                break;
            case "4":
                SqlParameter[] sqlParams4 = new SqlParameter[] { new SqlParameter("@place_name", object_name.Text),
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams4, "get_places_titles1");
                break;
            case "5":
                SqlParameter[] sqlParams5 = new SqlParameter[] { new SqlParameter("@artifact_name", object_name.Text), 
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams5, "get_artifacts_titles1");
                break;
            case "6":
                SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", object_name.Text),
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams6, "get_video_titles1");
                break;
            case "7":
                SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", object_name.Text),
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams7, "get_audio_titles1");
                break;
            case "8":
                SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", object_name.Text),
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams8, "get_docs_titles1");
                break;
            case "9":
                SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", object_name.Text), 
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams9, "get_articles_titles1");
                break;
            case "10":
                SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", object_name.Text),
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams10, "get_books_titles1");
                break;
            case "11":
                SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", object_name.Text),
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams11, "get_images_titles1");
                break;
            case "12":
                SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@manuscript_name", object_name.Text),
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams12, "get_manuscripts_titles1");
                break;
            case "13":
                SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@these_name", object_name.Text),
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams13, "get_theses_titles1");
                break;
            case "14":
                SqlParameter[] sqlParams14 = new SqlParameter[] { new SqlParameter("@conference_proceeding_name", object_name.Text),
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles1");
                break;
            case "15":
                SqlParameter[] sqlParams15 = new SqlParameter[] { new SqlParameter("@website_name", object_name.Text), 
                          new SqlParameter("@assigned", RadioBtt_researsh.SelectedIndex )};
                dt = DatabaseFunctions.SelectData(sqlParams15, "get_website_titles1");
                break;
        }
        objects_grid.DataSource = dt;
        objects_grid.DataBind();
    }
    protected void agree_btn_Click(object sender, EventArgs e)
    {
        fill_grid();
        get_researches(Convert.ToInt16(types_list.SelectedValue));
    }
    public void send_mail(DataTable object_dt)
    {
        string exportpath = Server.MapPath("Uploads/ACT_Report.pdf");
        ExportOptions crExportOptions;
        MailMessage _Message = new MailMessage();
        _Message.Subject = "مشروع ذاكرة الأزهر الشريف";
        _Message.BodyEncoding = Encoding.Unicode;
        _Message.IsBodyHtml = true;
        _Message.Body = "<html><body dir='rtl'><h3 >";
        _Message.Body += "    السيد/ " + researcher.SelectedItem.Text;
        _Message.Body += "    </h3> ";
        _Message.Body += " <h3 > " + "  لقد تم تكليفك بالبحث فى العناصر التالية: " + "</h3>";
        _Message.Body += "<table dir='rtl' width='100%' border='1' style='border-collapse:collapse;'>";
        _Message.Body += "<tr><td width='15%'>كود العنصر</td><td width='15%'>نوع العنصر</td><td width='25%'>اسم العنصر</td>";
        _Message.Body += "<td width='25%'>بيانات أخرى</td><td width='20%'>تاريخ التكليف</td></tr>";
        for (int c = 0; c < object_dt.Rows.Count; c++)
        {
            _Message.Body += "<tr><td>&nbsp;" + object_dt.Rows[c]["code"] + "</td>";
            _Message.Body += "<td>&nbsp;" + object_dt.Rows[c]["type"] + "</td>";
            _Message.Body += "<td>&nbsp;" + object_dt.Rows[c]["name"] + "</td>";
            _Message.Body += "<td>&nbsp;" + object_dt.Rows[c]["other"] + "</td>";
            _Message.Body += "<td>&nbsp;" + object_dt.Rows[c]["date"] + "</td>";
            _Message.Body += "</tr>";

        }
        _Message.Body += "</table>";
        _Message.Body += "<br/><br/><h3 > نرجو اتباع الآتى :  </h3> ";
        _Message.Body += "<br/>* كتابة كود العنصر على الاستمارة";
        _Message.Body += "<br/>* كتابة كود العنصر على الملفات الورقية المصاحبة للإستمارة";
        _Message.Body += "<br/>* وضع كود العنصر كإسم للملفات الرقمية المصاحبة للإستمارة";
        _Message.Body += "<br/><br/><h3 > مع تحيات </h3> ";
        _Message.Body += "<h3 >   فريق العمل بمشروع ذاكرة الأزهر الشريف  </h3> ";
        _Message.Body += "</body></html>";
        SmtpClient Client = new SmtpClient();
        Client.Port = int.Parse(ConfigurationManager.AppSettings["SMTP_Port"]);
        Client.Host = ConfigurationManager.AppSettings["SMTP_Host"];
        string UserName = ConfigurationManager.AppSettings["SMTP_UserName"];
        string Password = ConfigurationManager.AppSettings["SMTP_Password"];
        _Message.From = new MailAddress(ConfigurationManager.AppSettings["SMTP_FromAddress"]);
        System.Net.NetworkCredential SMTPUserInfo = new System.Net.NetworkCredential(UserName, Password);
        Client.UseDefaultCredentials = false;
        Client.Credentials = SMTPUserInfo;
        Client.Timeout = 1000000000;
        try
        {
            SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(researcher.SelectedValue)) };
            DataTable user_info = DatabaseFunctions.SelectData(sqlParams1,"get_user_by_ID");
            if (user_info.Rows.Count > 0)
                _Message.To.Add(new MailAddress(user_info.Rows[0]["E_mail"].ToString()));
            string mail = user_info.Rows[0]["E_mail"].ToString();
            Client.Send(_Message);
        }
        catch (Exception ex)
        {
            //Response.Write("لم يتم ارسال الايميل بنجاح");
        }
    }
    protected void add_btn_Click(object sender, EventArgs e)
    {
        if (researcher.Items.Count > 0)
        {
            string obj_type = "";
            string obj_code = "";
            string obj_table = "";
            switch (types_list.SelectedValue)
            {
                case "1":
                    obj_type = "الشخصيات";
                    obj_code = "1_";
                    obj_table = "characters";
                    break;
                case "2":
                    obj_type = "الأحداث والمواقف";
                    obj_code = "2_";
                    obj_table = "events";
                    break;
                case "3":
                    obj_type = "الموضوعات";
                    obj_code = "3_";
                    obj_table = "topics";
                    break;
                case "4":
                    obj_type = "الآثار المعمارى";
                    obj_code = "4_";
                    obj_table = "places";
                    break;
                case "5":
                    obj_type = "القطع المتحفية";
                    obj_code = "5_";
                    obj_table = "artifacts";
                    break;
                case "6":
                    obj_type = "التسجيلات التلفزيونية";
                    obj_code = "6_";
                    obj_table = "content_media";
                    break;
                case "7":
                    obj_type = "التسجيلات الإذاعية";
                    obj_code = "7_";
                    obj_table = "content_media";
                    break;
                case "8":
                    obj_type = "الوثائق";
                    obj_code = "8_";
                    obj_table = "documents";
                    break;
                case "9":
                    obj_type = "المقالات";
                    obj_code = "9_";
                    obj_table = "documents";
                    break;
                case "10":
                    obj_type = "الكتب";
                    obj_code = "10_";
                    obj_table = "documents";
                    break;
                case "11":
                    obj_type = "الصور";
                    obj_code = "11_";
                    obj_table = "content_images";
                    break;
                case "12":
                    obj_type = "المخطوطات";
                    obj_code = "12_";
                    obj_table = "manuscripts";
                    break;
                case "13":
                    obj_type = "أطروحة";
                    obj_code = "13_";
                    obj_table = "theses";
                    break;
                case "14":
                    obj_type = "بحث فى مؤتمر";
                    obj_code = "14_";
                    obj_table = "conference_proceedings";
                    break;
                case "15":
                    obj_type = "موقع الكترونى";
                    obj_code = "15_";
                    obj_table = "WebSites_Template";
                    break;
            }

            DataTable object_dt = new DataTable();
            object_dt.Columns.Add("code");
            object_dt.Columns.Add("type");
            object_dt.Columns.Add("name");
            object_dt.Columns.Add("date");
            object_dt.Columns.Add("other");


            foreach (GridViewRow row in objects_grid.Rows)
            {
                DataRow dr_data;
                // Access the CheckBox
                dr_data = object_dt.NewRow();
                CheckBox cbActiveEn = (CheckBox)row.FindControl("ActivateEn");
                HtmlInputHidden sID = (HtmlInputHidden)row.FindControl("user_id");
                int x, z;
                //title_lbl
                Label title_lbl = (Label)row.FindControl("title_lbl");
                Label add_info_lbl = (Label)row.FindControl("add_info_lbl");

                if (cbActiveEn != null && cbActiveEn.Checked)
                {
                    string updatesql = "update " + obj_table + " set assigned_to=" + researcher.SelectedValue;
                    updatesql += " where id=" + sID.Value.ToString();
                    z = General_Helping.ExcuteQuery(updatesql);
                    dr_data["code"] = obj_code + sID.Value.ToString();
                    dr_data["type"] = obj_type;
                    dr_data["name"] = title_lbl.Text;
                    dr_data["date"] = DateTime.Now.ToShortDateString();
                    dr_data["other"] = add_info_lbl.Text;
                    object_dt.Rows.Add(dr_data);
                }
            }
            if (object_dt.Rows.Count > 0)
                send_mail(object_dt);
            fill_grid();
            ShowAlertMessage("تم الإسناد بنجاح");
            get_researches(Convert.ToInt16(types_list.SelectedValue));

        }
    }
    public static void ShowAlertMessage(string success)
    {

        Page page = HttpContext.Current.Handler as Page;
        if (page != null)
        {
            success = success.Replace("'", "\'");
            ScriptManager.RegisterStartupScript(page, page.GetType(), "success_msg", "alert('" + success + "');", true);
        }
    }
    protected void cancel_btn_Click(object sender, EventArgs e)
    {
        if (researcher.Items.Count > 0)
        {
            string obj_type = "";
            string obj_code = "";
            string obj_table = "";
            switch (types_list.SelectedValue)
            {
                case "1":
                    obj_type = "الشخصيات";
                    obj_code = "1_";
                    obj_table = "characters";
                    break;
                case "2":
                    obj_type = "الأحداث والمواقف";
                    obj_code = "2_";
                    obj_table = "events";
                    break;
                case "3":
                    obj_type = "الموضوعات";
                    obj_code = "3_";
                    obj_table = "topics";
                    break;
                case "4":
                    obj_type = "الآثار المعمارى";
                    obj_code = "4_";
                    obj_table = "places";
                    break;
                case "5":
                    obj_type = "القطع المتحفية";
                    obj_code = "5_";
                    obj_table = "artifacts";
                    break;
                case "6":
                    obj_type = "التسجيلات التلفزيونية";
                    obj_code = "6_";
                    obj_table = "content_media";
                    break;
                case "7":
                    obj_type = "التسجيلات الإذاعية";
                    obj_code = "7_";
                    obj_table = "content_media";
                    break;
                case "8":
                    obj_type = "الوثائق";
                    obj_code = "8_";
                    obj_table = "documents";
                    break;
                case "9":
                    obj_type = "المقالات";
                    obj_code = "9_";
                    obj_table = "documents";
                    break;
                case "10":
                    obj_type = "الكتب";
                    obj_code = "10_";
                    obj_table = "documents";
                    break;
                case "11":
                    obj_type = "الصور";
                    obj_code = "11_";
                    obj_table = "content_images";
                    break;
                case "12":
                    obj_type = "المخطوطات";
                    obj_code = "12_";
                    obj_table = "manuscripts";
                    break;
                case "13":
                    obj_type = "أطروحة";
                    obj_code = "13_";
                    obj_table = "theses";
                    break;
                case "14":
                    obj_type = "بحث فى مؤتمر";
                    obj_code = "14_";
                    obj_table = "conference_proceedings";
                    break;
                case "15":
                    obj_type = "موقع الكترونى";
                    obj_code = "15_";
                    obj_table = "WebSites_Template";
                    break;
            }

            DataTable object_dt = new DataTable();
            object_dt.Columns.Add("code");
            object_dt.Columns.Add("type");
            object_dt.Columns.Add("name");
            object_dt.Columns.Add("date");
            object_dt.Columns.Add("other");


            foreach (GridViewRow row in objects_grid.Rows)
            {
                DataRow dr_data;
                // Access the CheckBox
                dr_data = object_dt.NewRow();
                CheckBox cbActiveEn = (CheckBox)row.FindControl("ActivateEn");
                HtmlInputHidden sID = (HtmlInputHidden)row.FindControl("user_id");
                int x, z;
                //title_lbl
                Label title_lbl = (Label)row.FindControl("title_lbl");
                Label add_info_lbl = (Label)row.FindControl("add_info_lbl");

                if (cbActiveEn != null && cbActiveEn.Checked)
                {
                    string updatesql = "update " + obj_table + " set assigned_to=0";
                    updatesql += " where id=" + sID.Value.ToString();
                    z = General_Helping.ExcuteQuery(updatesql);
                    dr_data["code"] = obj_code + sID.Value.ToString();
                    dr_data["type"] = obj_type;
                    dr_data["name"] = title_lbl.Text;
                    dr_data["date"] = DateTime.Now.ToShortDateString();
                    dr_data["other"] = add_info_lbl.Text;
                    object_dt.Rows.Add(dr_data);
                }
            }
            if (object_dt.Rows.Count > 0)
                send_mail(object_dt);
            fill_grid();
            ShowAlertMessage("تم إلغاء الإسناد بنجاح");
            get_researches(Convert.ToInt16(types_list.SelectedValue));

        }
    }
    protected void chkSelectAll_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkAll = (CheckBox)objects_grid.HeaderRow.FindControl("chkSelectAll");
        if (chkAll.Checked == true)
        {
            foreach (GridViewRow gvRow in objects_grid.Rows)
            {
                CheckBox chkSel = (CheckBox)gvRow.FindControl("ActivateEn");
                chkSel.Checked = true;
            }
        }
        else
        {
            foreach (GridViewRow gvRow in objects_grid.Rows)
            {
                CheckBox chkSel = (CheckBox)gvRow.FindControl("ActivateEn");
                chkSel.Checked = false;
            }
        }
    }

}
