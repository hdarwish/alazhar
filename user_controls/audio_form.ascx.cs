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

public partial class user_controls_audio_form : System.Web.UI.UserControl
{
    //change temp_content_media with the actual audio_content_media id
   // public int content_id;//temp_content_media = ;//62;
    content_media_DT content_media_obj_to_save = new content_media_DT();
    content_media_details_DT content_media_details_obj_to_save = new content_media_details_DT();
    //contents_timeline_DT contents_timeline_obj_to_save = new contents_timeline_DT();

    //content_media_DT content_media_obj_to_save = new content_media_DT();
    //content_media_details_DT content_media_details_obj_to_save = new content_media_details_DT();
    //DataTable timeline_DT = new DataTable();


    public void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        //content_id.Value = "43";
        //content_type.Value = "7";
       }
       
            if (content_id.Value != "")
            {
                RblMediaType.DataSource = content_media_type_DB.SelectAll();
                rblTimeLine.DataSource = periods_DB.SelectAll();
                RblMediaType.DataBind();
                rblTimeLine.DataBind();

                getData();
                filldata();
                //set_example_label();

                if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
                {
                    unvisible();
                    visable_translated_only();
                }
                if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
                {
                    //btnsave.Visible = false;
                    //uploadfile.Enabled = false;
                    Dimmed();
                    Enabled();
                }

                if (Session["user_type"].ToString() == "5")
                {
                    //uploadfile.Enabled = false;
                    btnsave.Visible = false;
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
        trCommenter.Visible = false;
        trDate.Visible = false;
        trDesc.Visible = false;
        trDuration.Visible = false;
        trFormDataCollectorName.Visible = false;
       
        trFormDataRevisionName.Visible = false;
        trFormImage.Visible = false;
        trGuest.Visible = false;
        trGuestPosition.Visible = false;
        trHighlight.Visible = false;
        trLinkWords.Visible = false;
        trName.Visible = false;
        trNotes.Visible = false;
        trResourceName.Visible = false;
        trTimeLine.Visible = false;
        //trTitle.Visible = false;
        trType.Visible = false;
        file_tr.Visible = false;
        trSave.Visible = false;
    }
    public void visable_translated_only()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[11];
            arrv[0] = "trName";
            arrv[1] = "trDesc";
            arrv[2] = "trGuest";
            arrv[3] = "trGuestPosition";
            arrv[4] = "trCommenter";
            arrv[5] = "trResourceName";
            arrv[6] = "trNotes";
            arrv[7] = "trLinkWords";
            arrv[8] = "trSave";
            arrv[9] = "file_tr";
            arrv[10] = "trDuration";
            for (int i = 0; i < 11; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;
            }
            foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblAudio.Rows)
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
        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblAudio.Rows)
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
                    //    if (btn != null)
                    //    {
                    //    btn.Visible = true;
                    //    btn.ForeColor = System.Drawing.Color.Red;
                    //    }
                    //}
                    
                    if (cont_fields.Rows[x]["type"].ToString() == "FileUpload")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        FileUpload upfile = (FileUpload)this.FindControl(id);
                        upfile.Enabled = true;
                        //upfile.ForeColor = System.Drawing.Color.Red;
                        upfile.BorderColor = System.Drawing.Color.Red;
                        upfile.Style.Add("ForeColor", "Red");

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
        clog.lang_id = menus_update.get_current_lang();
        clog.user_id = Convert.ToInt16(Session["user_id"].ToString());
        clog.note_date = DateTime.Now.ToShortDateString();
        int rslut = contents_log_DB.Save(clog);
    }
    public void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            getData();
            content_media_obj_to_save.id = Convert.ToInt16(content_id.Value);
           // if (security_issues.check_date(txtGorgDate.Text))
            content_media_obj_to_save.record_date_georgian = txtGorgDate.Text;
           // if (security_issues.check_date(txtHijriDate.Text))
            content_media_obj_to_save.record_date_hijri =  txtHijriDate.Text;
            content_media_obj_to_save.period_id = CDataConverter.ConvertToInt(rblTimeLine.SelectedValue);
            content_media_obj_to_save.period_desc = txtTimelineNotes.Text;
            content_media_obj_to_save.highlight = CDataConverter.ConvertToInt(chk_highlight.Checked);
            content_media_obj_to_save.highlight_panorama = CDataConverter.ConvertToInt(chk_pano.Checked);
            
            if (vaildfile())
            {
                if (content_media_obj_to_save.form_file != "" && menus_update.get_current_lang() == 1)
                {
                    id_href.Visible = true;
                    id_href.HRef = "~/upload/audio/" + content_media_obj_to_save.form_file;
                }
                else if (content_media_obj_to_save.form_file_en != "" && menus_update.get_current_lang() == 2)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/upload/audio/" + content_media_obj_to_save.form_file_en;
                }
                else if (content_media_obj_to_save.form_file_fr != "" && menus_update.get_current_lang() == 3)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/upload/audio/" + content_media_obj_to_save.form_file_fr;
                }
               
              
            }
            else if (id_href.HRef == "#")
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('يجب إدخال ملف إستمارة الملف الصوتى ')</script>");
                return;
            }
           int media_id = content_media_DB.Save(content_media_obj_to_save);
          
            content_media_details_obj_to_save.id = Convert.ToInt16(content_id.Value);
            //content_media_details_obj_to_save.special_element = rblSpecialElement.SelectedIndex;
            content_media_details_obj_to_save.form_pic_state = rblFormImage.SelectedIndex;
            content_media_details_obj_to_save.desc = txtDesc.Text;
            content_media_details_obj_to_save.guest_desc = TextGuestDesc.Text;
            content_media_details_obj_to_save.notes = txtNotes.Text;
            content_media_details_obj_to_save.link_words = txtLinkWords.Text;
            content_media_details_obj_to_save.name = txtName.Text;
            content_media_details_obj_to_save.title = txtTitle.Text;
            content_media_details_obj_to_save.content_url = txtUrl.Text;
            content_media_details_obj_to_save.category = RblMediaType.SelectedValue.ToString();
            content_media_details_obj_to_save.period = txthours.Text + ":" + ddlMin.SelectedValue + ":" + ddlSec.SelectedValue;
            content_media_details_obj_to_save.guest_details = txtGuestName.Text;
            content_media_details_obj_to_save.presenter_details = txtCommenterName.Text;
            content_media_details_obj_to_save.data_collector_name = txtFormDataColectorName.Text;
            content_media_details_obj_to_save.data_revision_name = txtFormDataRevisionName.Text;
            //content_media_details_obj_to_save.data_entry_name = txtFormDataEntryName.Text;
            //content_media_details_obj_to_save.data_entry_revision_name = txtFormDataEntryRevisionName.Text;
            content_media_details_obj_to_save.resource_name = txtresourceName.Text;
            content_media_details_obj_to_save.resource_country = txtresourceCountry.Text;
            content_media_details_obj_to_save.resource_city = txtresourceCity.Text;
            content_media_details_obj_to_save.resource_save_no = txtSaveNo.Text;
            content_media_details_obj_to_save.resource_note = txtResourceNote.Text;
            content_media_details_obj_to_save.lang_id = menus_update.get_current_lang().ToString();
            int media_details_id = content_media_details_DB.Save(content_media_details_obj_to_save);
           

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
            if (media_id > 0 && media_details_id > 0)
            { 
                log(2); 
            }
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
         content_media_obj_to_save = content_media_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        content_media_details_obj_to_save = content_media_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());
        //timeline_DT = contents_timeline_DB.SelectByIDandType(CDataConverter.ConvertToInt(content_id.Value), 7);
    }
    protected Boolean vaildfile()
    {
        bool vaild = false;
        string filename = uploadfile.FileName;
        if (menus_update.get_current_lang() == 1)
        {
            if (content_media_obj_to_save.form_file == "")
            {
                filename = uploadfile.FileName;
                if (filename == "")
                {

                    labfile.Visible = true;
                    //labfile.ForeColor = System.Drawing.Color.Red;
                    labfile.Text = "يجب إضافة ملف";
                    vaild = false; return vaild;
                }
            }
        }
        else if (menus_update.get_current_lang() == 2)
        {
            if (content_media_obj_to_save.form_file_en == "")
            {
                filename = uploadfile.FileName;
                if (filename == "")
                {

                    labfile.Visible = true;
                    //labfile.ForeColor = System.Drawing.Color.Red;
                    labfile.Text = "يجب إضافة ملف";
                    vaild = false; return vaild;
                }
            }
        }
        else if (menus_update.get_current_lang() == 3)
        {
            if (content_media_obj_to_save.form_file_fr == "")
            {
                filename = uploadfile.FileName;
                if (filename == "")
                {

                    labfile.Visible = true;
                    //labfile.ForeColor = System.Drawing.Color.Red;
                    labfile.Text = "يجب إضافة ملف";
                    vaild = false; return vaild;
                }
            }
        }

        if (filename != "")
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
                    vaild = false; return vaild;
                }
                else
                {
                    saveFileSystem();
                    vaild = true; return vaild;
                }
            }
            else
            {
                labfile.Visible = true;
                labfile.Text = " امتداد الملف غير صحيح ";
                vaild = false; return vaild;
            }
        }
        return vaild;



    }

    protected void saveFileSystem()
    {
       
           string savePath = MapPath("~") + "\\upload\\audio\\";

        string fileName = uploadfile.FileName;
        savePath += fileName;
        uploadfile.SaveAs(savePath);
        if (menus_update.get_current_lang() == 1)
            content_media_obj_to_save.form_file = fileName;
        else if (menus_update.get_current_lang() == 2)
            content_media_obj_to_save.form_file_en = fileName;
        else if (menus_update.get_current_lang() == 3)
            content_media_obj_to_save.form_file_fr = fileName;


        

    }
    public void filldata()
    {
        if (content_media_details_obj_to_save.content_media_id != 0)
        {
            txtTitle.Text = content_media_details_obj_to_save.title;
            RblMediaType.SelectedValue = content_media_details_obj_to_save.category.ToString();
            //rblSpecialElement.SelectedIndex = CDataConverter.ConvertToInt(content_media_details_obj_to_save.special_element);
            if (content_media_obj_to_save.highlight == 1)
                chk_highlight.Checked = true;
            else chk_highlight.Checked = false;
            if (content_media_obj_to_save.highlight_panorama == 1)
                chk_pano.Checked = true;
            else chk_pano.Checked = false;
            txtDesc.Text = content_media_details_obj_to_save.desc;
            txtName.Text = content_media_details_obj_to_save.name;
            txtUrl.Text = content_media_details_obj_to_save.content_url;
            if (content_media_details_obj_to_save.period != null && content_media_details_obj_to_save.period != "")
            {
               

                if (content_media_details_obj_to_save.period.Split(':').Count() > 2)
                {
                    txthours.Text = content_media_details_obj_to_save.period.Split(':')[0];
                    ddlMin.SelectedValue = content_media_details_obj_to_save.period.Split(':')[1];
                    ddlSec.SelectedValue = content_media_details_obj_to_save.period.Split(':')[2].Split(' ')[0];
                }
                else if (content_media_details_obj_to_save.period.Split(':').Count() == 2)
                {
                    ddlMin.SelectedValue = content_media_details_obj_to_save.period.Split(':')[0];
                    ddlSec.SelectedValue = content_media_details_obj_to_save.period.Split(':')[1].Split(' ')[0];
                }
            }
            txtGuestName.Text = content_media_details_obj_to_save.guest_details;
            TextGuestDesc.Text = content_media_details_obj_to_save.guest_desc;
            txtCommenterName.Text = content_media_details_obj_to_save.presenter_details;
            txtGorgDate.Text = content_media_obj_to_save.record_date_georgian;
            txtHijriDate.Text = content_media_obj_to_save.record_date_hijri;
            txtresourceName.Text = content_media_details_obj_to_save.resource_name;
            txtresourceCountry.Text = content_media_details_obj_to_save.resource_country;
            txtresourceCity.Text = content_media_details_obj_to_save.resource_city;
            txtSaveNo.Text = content_media_details_obj_to_save.resource_save_no;
            txtResourceNote.Text = content_media_details_obj_to_save.resource_note;
            txtNotes.Text = content_media_details_obj_to_save.notes;
            txtLinkWords.Text = content_media_details_obj_to_save.link_words;
            txtFormDataColectorName.Text = content_media_details_obj_to_save.data_collector_name;
            txtFormDataRevisionName.Text = content_media_details_obj_to_save.data_revision_name;
           // txtFormDataEntryName.Text = content_media_details_obj_to_save.data_entry_name;
           // txtFormDataEntryRevisionName.Text = content_media_details_obj_to_save.data_entry_revision_name;
            rblFormImage.SelectedIndex = CDataConverter.ConvertToInt(content_media_details_obj_to_save.form_pic_state);
            rblTimeLine.SelectedValue = content_media_obj_to_save.period_id.ToString();
            txtTimelineNotes.Text = content_media_obj_to_save.period_desc;
          
             if (menus_update.get_current_lang() == 1)
            {
                if (content_media_obj_to_save.form_file != "")
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/upload/audio/" + content_media_obj_to_save.form_file;
                }
                else id_href.Visible = false;

            }
            else if (menus_update.get_current_lang() == 2)
            {
                if (content_media_obj_to_save.form_file_en != "")
                {
                    id_href.Visible = true;
                    id_href.HRef = "~/upload/audio/" + content_media_obj_to_save.form_file_en;
                }
                else id_href.Visible = false;
            }
            else if (menus_update.get_current_lang() == 3)
            {
                if (content_media_obj_to_save.form_file_fr != "")
                {
                    id_href.Visible = true;
                    id_href.HRef = "~/upload/audio/" + content_media_obj_to_save.form_file_fr;
                }
                else id_href.Visible = false;
            }
            else id_href.Visible = false;
        }
    }
}
