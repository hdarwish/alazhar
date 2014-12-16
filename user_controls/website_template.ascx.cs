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

public partial class user_controls_website_template : System.Web.UI.UserControl
{
    //change temp_content_media with the actual video_content_media id
    //public int content_id;// = 42;temp_content_media
    WebSites_Template_DT website_obj_to_save = new WebSites_Template_DT();
    WebSites_Template_details_DT website_details_obj_to_save = new WebSites_Template_details_DT();
    //contents_timeline_DT contents_timeline_obj_to_save = new contents_timeline_DT();

   
    //DataTable timeline_DT = new DataTable();


    public void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //content_id.Value = "42";
            //content_type.Value = "6";


        }
        if (content_id.Value != "" && content_type.Value == "15")
        {

            RblLangType.DataSource = languages_DB.SelectAll();
            RblLangType.DataBind();
           

            getData();
            filldata();
            set_example_label();
            if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
            {
                unvisible();
                visable_translated_only();
            }
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {
                
                Dimmed();
                Enabled();
            }
            if (Session["user_type"].ToString() == "5")
            {
                btnsave.Visible = false;
                uploadfile.Enabled = false;
                Dimmed();
            }

        }
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
    public void unvisible()
    {
        
        trDate.Visible = false;
        trDesc.Visible = false;
        trurl.Visible = false;
        trFormDataCollectorName.Visible = false;
       
        trFormDataRevisionName.Visible = false;

        trSiteLang.Visible = false;
        trHighlight.Visible = false;
        trLinkWords.Visible = false;
        trName.Visible = false;
        trNotes.Visible = false;
      
        trTitle.Visible = false;
        tr28.Visible = false;
        file_tr.Visible = false;
        trSave.Visible = false;
    }
    public void visable_translated_only()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[7];
            arrv[0] = "trTitle";
            arrv[1] = "trDesc";
            arrv[2] = "trLinkWords";
            arrv[3] = "trNotes";
           arrv[4] = "trSave";
           arrv[5] = "file_tr";
           arrv[6] = "trTitle";
            for (int i = 0; i < 7; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;
            }
            foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblWebsite.Rows)
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

    public void Dimmed()
    {
        //Class1 clss = new Class1();
        //clss.Dimmed();
        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblWebsite.Rows)
        {
            foreach (Control ctr in r.Cells)
            {
                foreach (Control control in ctr.Controls)
                {
                    // foreach (Control childc in control.Controls )
                    //{
                    //    if (childc is TextBox)
                    //    {
                    // foreach(Control c2 in control.Controls)
                    //{

                    if (control.GetType().ToString() == "System.Web.UI.WebControls.TextBox")
                    {

                        ((TextBox)control).ReadOnly = true;
                    }

                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.CheckBox")
                    {

                        ((CheckBox)control).Enabled = false;
                    }

                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.DropDownList")
                    {

                        ((DropDownList)control).Enabled = false;
                    }


                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.RadioButtonList")
                    {

                        ((RadioButtonList)control).Enabled = false;
                    }
                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.CheckBoxList")
                    {

                        ((CheckBoxList)control).Enabled = false;
                    }
                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.FileUpload")
                    {

                        ((FileUpload)control).Enabled = false;
                    }


                }
            }
        }
    }
    public void log(int operation_id)
    {
        contents_log_DT clog = new contents_log_DT();
        clog.id = 0;
        clog.content_type = Convert.ToInt16(content_type.Value);
        clog.content_id = Convert.ToInt16(content_id.Value);
        clog.operation_id = operation_id;
        clog.user_id = Convert.ToInt16(Session["user_id"].ToString());
        clog.note_date = DateTime.Now.ToShortDateString();
	clog.lang_id = menus_update.get_current_lang();
        int rslut = contents_log_DB.Save(clog);
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
                        txtbox.ForeColor = System.Drawing.Color.Red;

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
                        //chbox.Focus();

                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "DropDownList")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        DropDownList drop = (DropDownList)this.FindControl(id);
                        drop.Enabled = true;
                        drop.ForeColor = System.Drawing.Color.Red;
                        //chbox.Focus();

                    }
                    //if (cont_fields.Rows[x]["type"].ToString() == "Button")
                    //{
                    //    id = cont_fields.Rows[x]["control_name"].ToString();
                    //    Button btn = (Button)this.FindControl(id);
                    //    btn.Visible = true;
                    //    //btn.ForeColor = System.Drawing.Color.Red;

                    //}
                    if (cont_fields.Rows[x]["type"].ToString() == "FileUpload")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        FileUpload upfile = (FileUpload)this.FindControl(id);
                        upfile.Enabled = true;
                        //btn.ForeColor = System.Drawing.Color.Red;


                    }


                }
            }
        }

    }
    public void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            getData();
         
            
            if (security_issues.check_date(txtDate.Text))
                website_obj_to_save.site_login_date = txtDate.Text;
            website_obj_to_save.highlight = CDataConverter.ConvertToInt(chk_highlight.Checked);
            website_obj_to_save.highlight_panorama = CDataConverter.ConvertToInt(chk_pano.Checked);
            website_obj_to_save.url = txtUrl.Text;
            website_obj_to_save.site_lang = CDataConverter.ConvertToInt(RblLangType.SelectedValue);
            website_obj_to_save.data_collector_name = txtFormDataColectorName.Text;
            website_obj_to_save.data_revision_name = txtFormDataRevisionName.Text;
            website_obj_to_save.form_pic_state = CDataConverter.ConvertToInt(rblFormImage.SelectedIndex);
            if (vaildfile())
            {
                if (website_obj_to_save.form_file != "" && menus_update.get_current_lang() == 1)
                {
                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + website_obj_to_save.form_file;
                }
                else if (website_obj_to_save.form_file_en != "" && menus_update.get_current_lang() == 2)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + website_obj_to_save.form_file_en;
                }
                else if (website_obj_to_save.form_file_fr != "" && menus_update.get_current_lang() == 3)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + website_obj_to_save.form_file_fr;
                }
                
            }
            else if (id_href.HRef == "#")
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('يجب إدخال ملف إستمارة الموقع الالكترونى ')</script>");
                return;
            }
            WebSites_Template_DB.Save(website_obj_to_save);

           

            website_details_obj_to_save.describtion = txtDesc.Text;

            website_details_obj_to_save.notes = txtNotes.Text;
            website_details_obj_to_save.keywords = txtLinkWords.Text;
            website_details_obj_to_save.responsible_name = txtName.Text;
            website_details_obj_to_save.title = txtTitle.Text;

       
            website_details_obj_to_save.lang_id = menus_update.get_current_lang();
            WebSites_Template_details_DB.Save(website_details_obj_to_save);
            log(2);
            //if (timeline_DT.Rows.Count > 0)
            //{
            //    foreach (DataRow rw in timeline_DT.Rows)
            //    {
            //        contents_timeline_obj_to_save.id = CDataConverter.ConvertToInt(rw["id"]);

            //        contents_timeline_obj_to_save.period_id = rblTimeLine.SelectedIndex;

            //        contents_timeline_obj_to_save.notes = txtTimelineNotes.Text;
            //        contents_timeline_DB.Save_content(contents_timeline_obj_to_save);
            //    }
            //}
            ShowAlertMessage("تم حفظ بيانات الإستمارة بنجاح");
        }
        catch
        {

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
       website_obj_to_save = WebSites_Template_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        website_details_obj_to_save = WebSites_Template_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());
           
        
        //timeline_DT = contents_timeline_DB.SelectByIDandType(CDataConverter.ConvertToInt(content_id.Value), 6);
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
            return vaild;

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
                    return vaild;
                }
                else
                {
                    saveFileSystem();
                    vaild = true;
                    return vaild;
                }
            }
            else
            {
                labfile.Visible = true;
                labfile.Text = " امتداد الملف غير صحيح ";
                vaild = false;
                return vaild;
            }
        }
        return vaild;



    }
    protected void saveFileSystem()
    {

        string savePath = MapPath("~") + "\\upload\\forms\\";


        string fileName = uploadfile.FileName;
        savePath += fileName;
        uploadfile.SaveAs(savePath);
        if (menus_update.get_current_lang() == 1)
            website_obj_to_save.form_file = fileName;
        else if (menus_update.get_current_lang() == 2)
            website_obj_to_save.form_file_en = fileName;
        else if (menus_update.get_current_lang() == 3)
            website_obj_to_save.form_file_fr = fileName;



    }

    public void filldata()
    {
        if (website_details_obj_to_save.website_id != 0)
        {
            txtTitle.Text = website_details_obj_to_save.title;

            RblLangType.SelectedValue = website_obj_to_save.site_lang.ToString();
            //rblSpecialElement.SelectedIndex = CDataConverter.ConvertToInt(content_media_details_obj_to_select.special_element);
            if (website_obj_to_save.highlight == 1)
                chk_highlight.Checked = true;
            else chk_highlight.Checked = false;
            if (website_obj_to_save.highlight_panorama == 1)
                chk_pano.Checked = true;
            else chk_pano.Checked = false;
            txtDesc.Text = website_details_obj_to_save.describtion;
            txtName.Text = website_details_obj_to_save.responsible_name;
            txtDate.Text = website_obj_to_save.site_login_date;
            txtUrl.Text = website_obj_to_save.url;
            txtNotes.Text = website_details_obj_to_save.notes;
            txtLinkWords.Text = website_details_obj_to_save.keywords;
            txtFormDataColectorName.Text = website_obj_to_save.data_collector_name;
            txtFormDataRevisionName.Text = website_obj_to_save.data_revision_name;
            rblFormImage.SelectedIndex = CDataConverter.ConvertToInt(website_obj_to_save.form_pic_state);


            if (menus_update.get_current_lang() == 1)
            {
                if (website_obj_to_save.form_file != "")
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + website_obj_to_save.form_file;
                }
                else id_href.Visible = false;

            }
            else if (menus_update.get_current_lang() == 2)
            {
                if (website_obj_to_save.form_file_en != "")
                {
                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + website_obj_to_save.form_file_en;
                }
                else id_href.Visible = false;
            }
            else if (menus_update.get_current_lang() == 3)
            {
                if (website_obj_to_save.form_file_fr != "")
                {
                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + website_obj_to_save.form_file_fr;
                }
                else id_href.Visible = false;


            }
            else id_href.Visible = false;
        }
    }
}
