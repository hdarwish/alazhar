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
using Dates;
using System.Data.SqlClient;

public partial class user_controls_topics : System.Web.UI.UserControl
{
    topics_DT topics_obj_to_save = new topics_DT();
    topics_details_DT topics_details_obj_to_save = new topics_details_DT();
    contents_timeline_DT contents_timeline_obj_to_save = new contents_timeline_DT();

    


    public void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        if (content_id.Value != "")
        {
            getData();
            filldata();
            set_example_label();
        }
        //}
        //if (HttpContext.Current.Session["user_type"].ToString() == "8")
        //{
        //    RequiredFieldValidator4.ValidationGroup = "files";
        //    file_tr.Visible = false;
        //}
        if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
        {

            dimmed();
            Enabled();
        }
        if (Session["user_type"].ToString() == "5")
        {
            btnsave.Visible = false;
            dimmed();
        }
        unvisable_all();
        visable_translated_only();
    }
   
    private void set_example_label()
    {

        //if (CDataConverter.ConvertToInt(content_id.Value) > 0 && CDataConverter.ConvertToInt(content_type.Value) > 0)
        //{
        //    if (menus_update.get_current_lang() == 1)
        //        Label55.Text = content_type.Value + "_" + content_id.Value + "." + "doc/docx/pdf";
        //    else if (menus_update.get_current_lang() == 2)
        //        Label55.Text = content_type.Value + "_" + content_id.Value + "_en." + "doc/docx/pdf";
        //    else if (menus_update.get_current_lang() == 3)
        //        Label55.Text = content_type.Value + "_" + content_id.Value + "_fr." + "doc/docx/pdf";
        //}
        //else { Label55.Visible = false; }
    }
    public void visable_translated_only()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[5];
            
            arrv[0] = "tr_id_5";
            arrv[1] = "tr_id_4";
            arrv[2] = "tr_id_3";
            arrv[3] = "tr_id_6";
            arrv[4] = "tr_id_1";
            for (int i = 0; i < 5; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;
            }
            foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblTopics.Rows)
            {
                foreach (Control ctr in r.Cells)
                {
                    foreach (Control control in ctr.Controls)
                    {
                        if (control.GetType().ToString() == "System.Web.UI.WebControls.DropDownList")
                        {

                            ((DropDownList)control).Enabled = false;
                        }


                        else if (control.GetType().ToString() == "System.Web.UI.WebControls.RadioButtonList")
                        {

                            ((RadioButtonList)control).Enabled = false;
                        }


                    }
                }
            }
        }
    }

    public void unvisable_all()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            for (int i = 1; i < 10; i++)
            {
                HtmlTableRow tr = (HtmlTableRow)this.FindControl("tr_id_" + i.ToString());
                tr.Visible = false;

            }
        }
    }

    public void dimmed()
    {
        if (Session["user_type"] != null && Session["user_type"].ToString() == "5")
        {
           
            txtNotes.ReadOnly =
            txtLinkWords.ReadOnly = true;
            txtFormDataColectorName.Enabled =
            txtFormDataRevisionName.Enabled =
            rblSpecialElement.Enabled =
            rblFormImage.Enabled =


            uploadfile.Enabled = false;
        }
        if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
        {
           
            txtNotes.ReadOnly =
            txtLinkWords.ReadOnly = true;
            txtFormDataColectorName.Enabled =
            txtFormDataRevisionName.Enabled =
            rblSpecialElement.Enabled =
            rblFormImage.Enabled =
           
           
            uploadfile.Enabled = false;
        }

    }
    public void Enabled()
    {
        if (Session["user_type"] != null && Session["user_type"].ToString() == "4")
        {
            if (Request.QueryString["operation"].ToString() == "wrong")
            {
                SqlParameter[] sqlParamse = new SqlParameter[] {new SqlParameter ("@content_type",CDataConverter.ConvertToInt(content_type.Value)),
              new SqlParameter("@content_id",CDataConverter.ConvertToInt(content_id.Value)),
              new SqlParameter("@lang_id",menus_update.get_current_lang())};

                DataTable cont_fields = DatabaseFunctions.SelectData(sqlParamse, "contents_notes_fields_enabled");
                int i = cont_fields.Rows.Count;

                for (int x = 0; x < i; x++)
                {
                    string id = "";
                    if (cont_fields.Rows[x]["type"].ToString() == "TextBox")
                    {
                        //string id = Page.FindControl(cont_fields.Rows[x]["control_name"].ToString());
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        TextBox txtbox = (TextBox)this.FindControl(id);
                        txtbox.ReadOnly = false;
                        txtbox.Enabled = true;
                        txtbox.ForeColor = System.Drawing.Color.Red;

                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "Label")
                    {
                        //string id = Page.FindControl(cont_fields.Rows[x]["control_name"].ToString());
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        Label lbl = (Label)this.FindControl(id);
                        lbl.ForeColor = System.Drawing.Color.Red;

                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "RadioButtonList")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        RadioButtonList rad = (RadioButtonList)this.FindControl(id);
                        rad.Enabled = true;
                        rad.ForeColor = System.Drawing.Color.Red;
                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "CheckBox")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        CheckBox chbox = (CheckBox)this.FindControl(id);
                        chbox.Enabled = true;
                        chbox.ForeColor = System.Drawing.Color.Red;
                        chbox.Focus();
                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "FileUpload")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        FileUpload fupload = (FileUpload)this.FindControl(id);
                        fupload.Enabled = true;
                        fupload.ForeColor = System.Drawing.Color.Red;
                        fupload.Focus();


                    }
                }
            }
        }
    }
    

    public void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtDesc.Value == "" || txtDetailedDesc.Value == "")
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('يجب إدخال الوصف التفصيلى والوصف المختصر ')</script>");
                return;
            }
            getData();
            topics_obj_to_save.id = Convert.ToInt16(content_id.Value);
            
           
            if (vaildfile())
            {
                //topics_obj_to_save.form_file = uploadfile.FileName;
                //saveFileSystem();

                if (topics_obj_to_save.form_file != "" && menus_update.get_current_lang() == 1)
                {
                    id_href.Visible = true;
                    id_href.HRef = "~/images/topics/" + topics_obj_to_save.form_file;
                }
                else if (topics_obj_to_save.form_file_en != "" && menus_update.get_current_lang() == 2)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/images/topics/" + topics_obj_to_save.form_file_en;
                }
                else if (topics_obj_to_save.form_file_fr != "" && menus_update.get_current_lang() == 3)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/images/topics/" + topics_obj_to_save.form_file_fr;
                }
            }
            else if (id_href.HRef == "#")
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('يجب إدخال ملف إستمارة الموضوع ')</script>");
                return;
            }
            int res = topics_DB.Save(topics_obj_to_save);
            topics_details_obj_to_save.topic_id = Convert.ToInt16(content_id.Value);
            topics_details_obj_to_save.title = txtTitle.Text;
            topics_details_obj_to_save.special_element = rblSpecialElement.SelectedIndex;
           topics_details_obj_to_save.topic_brief = txtDesc.Value;
            topics_details_obj_to_save.topic_details = txtDetailedDesc.Value;
            topics_details_obj_to_save.notes = txtNotes.Text;
            topics_details_obj_to_save.link_words = txtLinkWords.Text;
            topics_details_obj_to_save.link_words = txtLinkWords.Text;
            topics_details_obj_to_save.form_pic_state = CDataConverter.ConvertToInt(rblFormImage.SelectedIndex);
            topics_details_obj_to_save.data_collector_name = txtFormDataColectorName.Text;
            topics_details_obj_to_save.data_revision_name = txtFormDataRevisionName.Text;
            //topics_details_obj_to_save.data_entry_name = txtFormDataEntryName.Text;
            //topics_details_obj_to_save.data_entry_revision_name = txtFormDataEntryRevisionName.Text;
         
            topics_details_obj_to_save.lang_id = menus_update.get_current_lang();
            res = topics_details_DB.Save(topics_details_obj_to_save);
            //lblpage.Visible = true;
            ShowAlertMessage("لقد تم الحفظ بنجاح");
            // Recording log action
            contents_log_DT clog = new contents_log_DT();
            clog.id = 0;
            clog.content_type = Convert.ToInt16(content_type.Value);
            clog.content_id = Convert.ToInt16(content_id.Value);
            clog.operation_id = 2;
            clog.user_id = Convert.ToInt16(Session["user_id"].ToString());
            clog.note_date = DateTime.Now.ToShortDateString();
            clog.lang_id = menus_update.get_current_lang();
            int rslut = contents_log_DB.Save(clog);
        }
        catch
        {
            lblpage.Visible = false;
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
    private void getData()
    {
        topics_obj_to_save = topics_DB.SelectByID(Convert.ToInt16(content_id.Value));
        topics_details_obj_to_save = topics_details_DB.SelectByID(Convert.ToInt16(content_id.Value), menus_update.get_current_lang());
        contents_timeline_obj_to_save = contents_timeline_DB.SelectByID(Convert.ToInt16(content_id.Value));
    }
    public void filldata()
    {
        txtTitle.Text = topics_details_obj_to_save.title;
        rblSpecialElement.SelectedIndex = CDataConverter.ConvertToInt(topics_details_obj_to_save.special_element);
        txtDesc.Value = topics_details_obj_to_save.topic_brief;
        txtDetailedDesc.Value = topics_details_obj_to_save.topic_details;
        txtNotes.Text = topics_details_obj_to_save.notes;

       
        if (menus_update.get_current_lang() == 1)
        {
            if (topics_obj_to_save.form_file != "")
            {

                id_href.Visible = true;
                id_href.HRef = "~/images/topics/" + topics_obj_to_save.form_file;
            }
            else id_href.Visible = false;

        }
        else if (menus_update.get_current_lang() == 2)
        {
            if (topics_obj_to_save.form_file_en != "")
            {
                id_href.Visible = true;
                id_href.HRef = "~/images/topics/" + topics_obj_to_save.form_file_en;
            }
            else id_href.Visible = false;
        }
        else if (menus_update.get_current_lang() == 3)
        {
            if (topics_obj_to_save.form_file_fr != "")
            {
                id_href.Visible = true;
                id_href.HRef = "~/images/topics/" + topics_obj_to_save.form_file_fr;
            }
            else id_href.Visible = false;
        }
        else id_href.Visible = false;

        txtLinkWords.Text = topics_details_obj_to_save.link_words;
        txtFormDataColectorName.Text = topics_details_obj_to_save.data_collector_name;
        txtFormDataRevisionName.Text = topics_details_obj_to_save.data_revision_name;
        //txtFormDataEntryName.Text = topics_details_obj_to_save.data_entry_name;
        //txtFormDataEntryRevisionName.Text = topics_details_obj_to_save.data_entry_revision_name;
        rblFormImage.SelectedIndex = CDataConverter.ConvertToInt(topics_details_obj_to_save.form_pic_state);
    }
   

    protected Boolean vaildfile()
    {
        bool vaild = false;
        string filename = uploadfile.FileName;
        if (filename == "" && id_href.HRef != "#")
        {
            vaild = true;
            return vaild;
        }

        if (filename == "" && id_href.HRef == "#")
        {

            labfile.Visible = true;
            //labfile.ForeColor = System.Drawing.Color.Red;
            labfile.Text = "يجب إضافة ملف";
            vaild = false;

        }

        else if (filename != "")
        {
            String[] FileNameDot = uploadfile.FileName.Split('.');
            if (FileNameDot.Length == 2)
            {
                int id = CDataConverter.ConvertToInt(content_id.Value);
                int cont_type = CDataConverter.ConvertToInt(content_type.Value);
                string fileCode = cont_type.ToString() + "_" + id.ToString();
                if (menus_update.get_current_lang() == 2)
                    fileCode = cont_type.ToString() + "_" + id.ToString() + "_en";
                else if (menus_update.get_current_lang() == 3)
                    fileCode = cont_type.ToString() + "_" + id.ToString() + "_fr";
                if (FileNameDot[1].ToString() != "doc" && FileNameDot[1].ToString() != "docx" && FileNameDot[1].ToString() != "pdf")
                {
                    labfile.Visible = true;
                    labfile.Text = " امتداد الملف غير صحيح ";
                    vaild = false;
                    return vaild;
                }
                else if (FileNameDot[0].ToString() != fileCode)
                {
                    labfile.Visible = true;
                    labfile.Text = " اسم الملف غير صحيح ";
                    vaild = false;
                }
                else
                {
                    saveFileSystem();
                    vaild = true;
                }
            }
            else
            {
                labfile.Visible = true;
                labfile.Text = " امتداد الملف غير صحيح ";
                vaild = false;
            }
        }
        return vaild;



    }


    protected void saveFileSystem()
    {

        string savePath = MapPath("~") + "\\images\\topics\\";

        string fileName = uploadfile.FileName;
        savePath += fileName;
        uploadfile.SaveAs(savePath);
        if (menus_update.get_current_lang() == 1)
            topics_obj_to_save.form_file = fileName;
        else if (menus_update.get_current_lang() == 2)
            topics_obj_to_save.form_file_en = fileName;
        else if (menus_update.get_current_lang() == 3)
            topics_obj_to_save.form_file_fr = fileName;



    }
    
}
