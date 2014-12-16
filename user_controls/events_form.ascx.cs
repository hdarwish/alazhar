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
using System.Reflection;
using System.Data.SqlClient;

public partial class masterpage_Events_Form : System.Web.UI.UserControl
{
    events_DT events_obj_to_save = new events_DT();
    events_details_DT events_details_obj_to_save = new events_details_DT();
    contents_timeline_DT contents_timeline_obj_to_save = new contents_timeline_DT();


    public void Page_Load(object sender, EventArgs e)
    {
        if (content_id.Value != "")
        {
            getData();
            filldata();
           // set_example_label();

        }
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

    public void visable_translated_only()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[4];
            arrv[0] = "tr_id_2";
            arrv[1] = "tr_id_3";
            arrv[2] = "tr_id_5";
            arrv[3] = "tr_id_6";
            for (int i = 0; i < 4; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;
            }
            foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblEvents.Rows)
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
                        else if (control.GetType().ToString() == "System.Web.UI.WebControls.CheckBoxList")
                        {

                            ((CheckBoxList)control).Enabled = false;
                        }


                    }
                }
            }
        }
    }
    private void set_example_label()
    {

        if (CDataConverter.ConvertToInt(content_id.Value) > 0 && CDataConverter.ConvertToInt(content_type.Value) > 0)
        {
            if (menus_update.get_current_lang() == 1)
                Label55.Text = content_type.Value + "_" + content_id.Value + "." + "doc/docx/pdf";
            else if (menus_update.get_current_lang() == 2)
                Label55.Text = content_type.Value + "_" + content_id.Value + "_en." + "doc/docx/pdf";
            else if (menus_update.get_current_lang() == 3)
                Label55.Text = content_type.Value + "_" + content_id.Value + "_fr." + "doc/docx/pdf";
        }
        else { Label55.Visible = false; }
    }
    public void unvisable_all()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            for (int i = 1; i < 12; i++)
            {
                if (i == 8)
                    continue;
                HtmlTableRow tr = (HtmlTableRow)this.FindControl("tr_id_" + i.ToString());
                tr.Visible = false;

            }
        }
    }

    public void dimmed()
    {
        if (Session["user_type"] != null && Session["user_type"].ToString() == "5")
        {
            txtTitle.ReadOnly = 
            txtStartDate.ReadOnly =
            txtEndDate.ReadOnly =
            txtsthegry.ReadOnly =
            txtendhegry.ReadOnly =
            txtNotes.ReadOnly =
            txtLinkWords.ReadOnly = true;
            txtFormDataColectorName.Enabled =
            txtFormDataRevisionName.Enabled =
            chk_highlight.Enabled = chk_pano.Enabled =
            rblFormImage.Enabled =

            chk_periods.Enabled =


            uploadfile.Enabled = false;
        }
        if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
        {
            txtTitle.ReadOnly = 
            txtStartDate.ReadOnly =
            txtEndDate.ReadOnly =
            txtsthegry.ReadOnly =
            txtendhegry.ReadOnly =
            txtNotes.ReadOnly =
            txtLinkWords.ReadOnly = true;
            txtFormDataColectorName.Enabled =
            txtFormDataRevisionName.Enabled =
            chk_highlight.Enabled = chk_pano.Enabled =
            rblFormImage.Enabled =

            chk_periods.Enabled =


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
                    if (cont_fields.Rows[x]["type"].ToString() == "CheckBoxList")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        CheckBoxList chbL = (CheckBoxList)this.FindControl(id);
                        chbL.Enabled = true;
                        chbL.ForeColor = System.Drawing.Color.Red;
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

private bool CheckValidate()
    {
        bool isValid = true;
        if (menus_update.get_current_lang() == 1)
        {

            

            for (int i = 0; i < chk_periods.Items.Count; i++)
            {
                if (chk_periods.Items[i].Selected)
                {
                    goto returnPart;
                }

            }
            isValid = false;
            ShowAlertMessage("يجب إدخال العصر الذي يتناوله الحدث ويدور حوله");
            goto returnPart;
        }

    returnPart:
        return isValid;

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
	if (CheckValidate())
        {
            if (vaildfile())
            {
            events_obj_to_save.id = Convert.ToInt16(content_id.Value);
            //if (security_issues.check_date(txtStartDate.Text) != false)
            {
                events_obj_to_save.start_date = txtStartDate.Text;
            }
           // else
           // {
           //     txtStartDate.Text = "";
           // }
           // if (security_issues.check_date(txtEndDate.Text) != false)
            {
                events_obj_to_save.end_date = txtEndDate.Text;
            }
            //else
           // {
            //    txtEndDate.Text = "";
           // }
            // dates hegri start//
            //if (security_issues.check_date(txtsthegry.Text) != false)
            { events_obj_to_save.start_date_hergi = txtsthegry.Text ; }

            //else { txtsthegry.Text = ""; }

            // dates hegri end//
            //if (security_issues.check_date(txtendhegry.Text) != false)
            { events_obj_to_save.end_date_hergi = txtendhegry.Text; }

            //else { txtendhegry.Text = ""; }
            
            if (vaildfile())
            {

                if (events_obj_to_save.form_file != "" && menus_update.get_current_lang() == 1)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/images/events/" + events_obj_to_save.form_file;
                }
                else if (events_obj_to_save.form_file_en != "" && menus_update.get_current_lang() == 2)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/images/events/" + events_obj_to_save.form_file_en;
                }
                else if (events_obj_to_save.form_file_fr != "" && menus_update.get_current_lang() == 3)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/images/events/" + events_obj_to_save.form_file_fr;
                }
            }
            events_obj_to_save.rblFormImage = CDataConverter.ConvertToInt(rblFormImage.SelectedValue);
            //events_obj_to_save.period_id = CDataConverter.ConvertToInt(chk_periods.SelectedValue);
		string periods = "";
                for (int i = 0; i < chk_periods.Items.Count; i++)
                {
                    if (chk_periods.Items[i].Selected == true)
                    {
                        periods += chk_periods.Items[i].Value + ",";
                    }
                }
                if (periods != "")
                {

                    //if (multiper.Length > 1)
                    //{
                    events_obj_to_save.period_id_multi = periods;
                    //}

                }

                if (chk_highlight.Checked == true)
                { events_obj_to_save.highlight = 1; }
                else events_obj_to_save.highlight = 0;
            int res = events_DB.Save(events_obj_to_save);
            events_details_obj_to_save.event_id = Convert.ToInt16(content_id.Value);
            events_details_obj_to_save.title = txtTitle.Text;
            //events_details_obj_to_save.special_element = rblSpecialElement.SelectedIndex;
            if (chk_pano.Checked == true)
            { events_details_obj_to_save.special_element = 1; }
            else { events_details_obj_to_save.special_element = 0; }
           // events_details_obj_to_save.form_pic_state = rblFormImage.SelectedIndex;
            events_details_obj_to_save.event_brief = txtDesc.Value;
            events_details_obj_to_save.event_details = txtDetailedDesc.Value;
            events_details_obj_to_save.notes = txtNotes.Text;
            events_details_obj_to_save.link_words = txtLinkWords.Text;
            events_details_obj_to_save.link_words = txtLinkWords.Text;
           // events_details_obj_to_save.form_pic_state = CDataConverter.ConvertToInt(rblFormImage.SelectedIndex);
            events_details_obj_to_save.data_collector_name = txtFormDataColectorName.Text;
            events_details_obj_to_save.data_revision_name = txtFormDataRevisionName.Text;

            events_details_obj_to_save.lang_id = menus_update.get_current_lang();
            res = events_details_DB.Save(events_details_obj_to_save);
            //lblpage.Visible = true;
            ShowAlertMessage("لقد تم الحفظ بنجاح");
            // Recording log action
            if (res > 0)
            {
                contents_log_DT clog = new contents_log_DT();
                clog.id = 0;
                clog.content_type = Convert.ToInt16(content_type.Value);
                clog.content_id = Convert.ToInt16(content_id.Value);
                clog.operation_id = 2;
                clog.lang_id = menus_update.get_current_lang();
                clog.user_id = Convert.ToInt16(Session["user_id"].ToString());
                clog.note_date = DateTime.Now.ToShortDateString();
                int rslut = contents_log_DB.Save(clog);
            }

            //Response.Write("<script language='javascript'>window.location.href = 'final_revision_home.aspx?operation=new';</script>");
		}        
           }        

        }
        catch
        {
            lblpage.Visible = false;
        }
        //this.Page.GetType().InvokeMember("fill_data", System.Reflection.BindingFlags.InvokeMethod, null, this.Page, new object[] { });
        //this.Page.GetType().InvokeMember("fill_objects_titles", System.Reflection.BindingFlags.InvokeMethod, null, this.Page, new object[] { });

        //fill_data()
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
        events_obj_to_save = events_DB.SelectByID(Convert.ToInt16(content_id.Value));
        events_details_obj_to_save = events_details_DB.SelectByID(Convert.ToInt16(content_id.Value), menus_update.get_current_lang());
        contents_timeline_obj_to_save = contents_timeline_DB.SelectByID(Convert.ToInt16(content_id.Value));
    }

    protected Boolean vaildfile()
    {
        bool vaild = false;
        string filename = uploadfile.FileName;
        if (filename == "" && id_href.HRef != "")
        {
            vaild = true;
            return vaild;
        }

        if (filename == "" && id_href.HRef == "")
        {

            labfile.Visible = true;
            //labfile.ForeColor = System.Drawing.Color.Red;
            labfile.Text = "يجب إضافة ملف";
            vaild = false; return vaild;

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

        string savePath = MapPath("~") + "\\images\\events\\";

        string fileName = uploadfile.FileName;
        savePath += fileName;
        uploadfile.SaveAs(savePath);
        if (menus_update.get_current_lang() == 1)
            events_obj_to_save.form_file = fileName;
        else if (menus_update.get_current_lang() == 2)
            events_obj_to_save.form_file_en = fileName;
        else if (menus_update.get_current_lang() == 3)
            events_obj_to_save.form_file_fr = fileName;



    }

    public void filldata()
    {
        periods_DT obj = new periods_DT();
        DataTable per_dt = periods_DB.SelectAll();
        chk_periods.DataSource = per_dt;
        chk_periods.DataBind();
        txtTitle.Text = events_details_obj_to_save.title;
        //rblSpecialElement.SelectedIndex = CDataConverter.ConvertToInt(events_details_obj_to_save.special_element);

        if (events_details_obj_to_save.special_element == 1)
        { chk_pano.Checked = true; }
        else chk_pano.Checked = false;
        if (events_obj_to_save.highlight == 1)
        { chk_highlight.Checked = true; }
        else chk_highlight.Checked = false;
        txtDesc.Value = events_details_obj_to_save.event_brief;
        txtDetailedDesc.Value = events_details_obj_to_save.event_details;
        txtStartDate.Text = events_obj_to_save.start_date;
        txtEndDate.Text = events_obj_to_save.end_date;
        // dates hegri start//
        txtsthegry.Text = events_obj_to_save.start_date_hergi;
        // dates hegri end//
        txtendhegry.Text = events_obj_to_save.end_date_hergi;

        txtNotes.Text = events_details_obj_to_save.notes;
        txtLinkWords.Text = events_details_obj_to_save.link_words;
        rblFormImage.SelectedValue = events_obj_to_save.rblFormImage.ToString();
        if (menus_update.get_current_lang() == 1)
        {
            if (events_obj_to_save.form_file != "")
            {

                id_href.Visible = true;
                id_href.HRef = "~/images/events/" + events_obj_to_save.form_file;
            }
            else id_href.Visible = false;

        }
        else if (menus_update.get_current_lang() == 2)
        {
            if (events_obj_to_save.form_file_en != "")
            {
                id_href.Visible = true;
                id_href.HRef = "~/images/events/" + events_obj_to_save.form_file_en;
            }
            else id_href.Visible = false;
        }
        else if (menus_update.get_current_lang() == 3)
        {
            if (events_obj_to_save.form_file_fr != "")
            {
                id_href.Visible = true;
                id_href.HRef = "~/images/events/" + events_obj_to_save.form_file_fr;
            }
            else id_href.Visible = false;
        }
        else id_href.Visible = false;

        txtFormDataColectorName.Text = events_details_obj_to_save.data_collector_name;
        txtFormDataRevisionName.Text = events_details_obj_to_save.data_revision_name;

        //rblFormImage.SelectedIndex = CDataConverter.ConvertToInt(events_details_obj_to_save.form_pic_state);
        //chk_periods.SelectedValue = events_obj_to_save.period_id.ToString();
        if (events_obj_to_save.period_id_multi != null && events_obj_to_save.period_id_multi != "")
        {
            String[] temp = events_obj_to_save.period_id_multi.ToString().Split(',');
            if (temp.Length > 0)
            {
                for (int i = 0; i < chk_periods.Items.Count; i++)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (chk_periods.Items[i].Value == temp[j])
                        {
                            chk_periods.Items[i].Selected = true;
                        }
                    }
                }
            }
        }

    }
}
