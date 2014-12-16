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

public partial class masterpage_manuscripts_form : System.Web.UI.UserControl
{
    manuscripts_DT manuscripts_obj_to_save = new manuscripts_DT();
    manuscripts_details_DT manuscripts_details_obj_to_save = new manuscripts_details_DT();
    
   
    
    public void Page_Load(object sender, EventArgs e)
    {
        //HiddenField Hfield_ref = (HiddenField)add_reference1.FindControl("content_type");
        //Hfield_ref.Value = content_type.Value;
        //HiddenField Hfield_ref_content_id = (HiddenField)add_reference1.FindControl("content_id");
        //add_reference1.fillGrid();
        //add_reference1.filldrop_types();

        //Hfield_ref_content_id.Value = content_id.Value;

        man_lang.DataSource = languages_DB.SelectAll();
        man_lang.DataBind();

        copy_state.DataSource = copy_status_DB.SelectAll();
        copy_state.DataBind();

        copy_contains.DataSource = copy_contains_DB.SelectAll();
        copy_contains.DataBind();

        copy_has.DataSource = copy_has_DB.SelectAll();
        copy_has.DataBind();

        license_type.DataSource = license_type_DB.SelectAll();
        license_type.DataBind();
        
        if (content_id.Value != "")
        {
            getData();
            fillcheck_periods();
            filldata();
            unvisable_all();
            visable_translated_only();
            set_example_label();
        }
        if (HttpContext.Current.Session["user_type"].ToString() == "8")
        {
            //RequiredFieldValidator4.ValidationGroup = "files";
            file_tr.Visible = false;
        }
         

        if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
        {
            //fucontentFile.Enabled = false;
            dimmed();
            Enabled();

        }
        if (Session["user_type"].ToString() == "5")
        {
            //drop_char.Enabled = false;
            //drop_author.Enabled = false;
            //drop_role.Enabled = false;
            //drop_type.Enabled = false;
            //txt_art_title.ReadOnly = true;
            btnsave.Visible = false;
            fucontentFile.Enabled = false;
            dimmed();
        }
       
        //}
    }
    private void fillcheck_periods()
    {
        periods_DT obj = new periods_DT();
        DataTable per_dt = periods_DB.SelectAll();
        chk_periods.DataSource = per_dt;
        chk_periods.DataBind();
        //chk_periods.DataValueField = "id";
        // chk_periods.DataTextField = "title";

    }
    private void set_example_label()
    {

        //if (CDataConverter.ConvertToInt(content_id.Value) > 0 && CDataConverter.ConvertToInt(content_type.Value) > 0)
        //{
        //    if (menus_update.get_current_lang() == 1)
        //        Label555.Text = content_type.Value + "_" + content_id.Value + "." + "doc/docx/pdf";
        //    else if (menus_update.get_current_lang() == 2)
        //        Label555.Text = content_type.Value + "_" + content_id.Value + "_en." + "doc/docx/pdf";
        //    else if (menus_update.get_current_lang() == 3)
        //        Label555.Text = content_type.Value + "_" + content_id.Value + "_fr." + "doc/docx/pdf";
        //}
        //else { Label55.Visible = false; }
    }
    public void visable_translated_only()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[12];
            arrv[0] = "tr3";
            arrv[1] = "tr5";
            arrv[2] = "tr16";
            arrv[3] = "tr17";
            arrv[4] = "tr18";
            arrv[5] = "tr20";
            arrv[6] = "tr25";
            arrv[7] = "file_tr";
            arrv[8] = "tr_date";
            arrv[9] = "tr_place";
            arrv[10] = "tr_copier";
            

            tr_title.Visible = true;
            tr_title2.Visible = true;
            for (int i = 0; i < 11; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;
            }
           
        }
    }

    public void unvisable_all()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[24];
			arrv[0] = "tr2";
            arrv[1] = "tr4";
            arrv[2] = "tr6";
            arrv[3] = "tr7";
            arrv[4] = "tr8";
            //arrv[5] = "title_source";
            arrv[5] = "tr9";
            arrv[6] = "tr10";
            arrv[7] = "tr11";
            arrv[8] = "tr12";
            arrv[9] = "tr13";
            arrv[10] = "tr14";
            arrv[11] = "tr15";
            arrv[12] = "tr_id_1";
            arrv[13] = "tr19";
            arrv[14] = "tr21";
            arrv[15] = "tr29";
            arrv[16] = "tr30";
            arrv[17] = "tr31";
            arrv[18] = "tr28";
            arrv[19] = "tr26";
            
            
            for (int i = 0; i < 20; i++)
            {
                
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = false;
               
            }
        }
    }

    public void dimmed()
    {

        foreach (System.Web.UI.HtmlControls.HtmlTableRow tblrw in tbltitle.Rows)
        {
            foreach (Control ctr in tblrw.Cells)
            {
                foreach (Control control in ctr.Controls)
                {
                    if (control.GetType().ToString() == "System.Web.UI.WebControls.TextBox")
                    {

                        ((TextBox)control).ReadOnly = true;
                    }
                }
            }
        }
        foreach (System.Web.UI.HtmlControls.HtmlTableRow tblrw in tblauthor.Rows)
        {
            foreach (Control ctr in tblrw.Cells)
            {
                foreach (Control control in ctr.Controls)
                {
                    if (control.GetType().ToString() == "System.Web.UI.WebControls.TextBox")
                    {

                        ((TextBox)control).ReadOnly = true;
                    }
                }
            }
        }
        foreach (System.Web.UI.HtmlControls.HtmlTableRow tblrw in tblcopy.Rows)
        {
            foreach (Control ctr in tblrw.Cells)
            {
                foreach (Control control in ctr.Controls)
                {
                    if (control.GetType().ToString() == "System.Web.UI.WebControls.TextBox")
                    {

                        ((TextBox)control).ReadOnly = true;
                    }
                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.RadioButtonList")
                    {

                        ((RadioButtonList)control).Enabled = false;
                    }
                }
            }
        }
        foreach (System.Web.UI.HtmlControls.HtmlTableRow tblrw in tblsaveplace.Rows)
        {
            foreach (Control ctr in tblrw.Cells)
            {
                foreach (Control control in ctr.Controls)
                {
                    if (control.GetType().ToString() == "System.Web.UI.WebControls.TextBox")
                    {

                        ((TextBox)control).ReadOnly = true;
                    }
                }
            }
        }
        
        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblmanus.Rows)
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
                    if (control.GetType().ToString() == "System.Web.UI.WebControls.FileUpload")
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
                    if (cont_fields.Rows[x]["type"].ToString().Trim() == "TextBox")
                    {
                        //string id = Page.FindControl(cont_fields.Rows[x]["control_name"].ToString());
                        id = cont_fields.Rows[x]["control_name"].ToString().Trim();
                        TextBox txtbox = (TextBox)this.FindControl(id);
                        txtbox.ReadOnly = false;
                        txtbox.ForeColor = System.Drawing.Color.Red;

                    }
                    if (cont_fields.Rows[x]["type"].ToString().Trim() == "RadioButtonList")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString().Trim();
                        RadioButtonList rad = (RadioButtonList)this.FindControl(id);
                         rad.Enabled = true;
                        rad.ForeColor = System.Drawing.Color.Red;
                    }
                    if (cont_fields.Rows[x]["type"].ToString().Trim() == "CheckBox")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString().Trim();
                        CheckBox chbox = (CheckBox)this.FindControl(id);
                        chbox.Enabled = true;
                        chbox.ForeColor = System.Drawing.Color.Red;
                        chbox.Focus();
                    }
                    if (cont_fields.Rows[x]["type"].ToString().Trim() == "CheckBoxList")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString().Trim();
                        CheckBoxList chboxList = (CheckBoxList)this.FindControl(id);
                        chboxList.Enabled = true;
                        chboxList.ForeColor = System.Drawing.Color.Red;
                        
                    }

                    if (cont_fields.Rows[x]["type"].ToString().Trim() == "FileUpload")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString().Trim();
                        FileUpload chbox = (FileUpload)this.FindControl(id);
                        chbox.Enabled = true;
                        //chbox.ForeColor = System.Drawing.Color.Red;
                        //chbox.Focus();
                    }
                }
            }
        }
    }
    protected Boolean vaildfile()
    {
        bool vaild = false;
        string filename = fucontentFile.FileName;
        if (menus_update.get_current_lang() == 1)
        {
            if (manuscripts_obj_to_save.form_file == "")
            {
                filename = fucontentFile.FileName;
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
            if (manuscripts_obj_to_save.form_file_en == "")
            {
                filename = fucontentFile.FileName;
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
            if (manuscripts_obj_to_save.form_file_fr == "")
            {
                filename = fucontentFile.FileName;
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
            String[] FileNameDot = fucontentFile.FileName.Split('.');
            if (FileNameDot.Length == 2)
            {
                int id = CDataConverter.ConvertToInt(content_id.Value);
                int cont_type = CDataConverter.ConvertToInt(content_type.Value);
                string fileCode = cont_type.ToString() + "_" + id.ToString();
                if (menus_update.get_current_lang() == 2)
                { fileCode = cont_type.ToString() + "_" + id.ToString() + "_en"; }
                else if (menus_update.get_current_lang() == 3)
                { fileCode = cont_type.ToString() + "_" + id.ToString() + "_fr"; }
                if (FileNameDot[0].ToString() != fileCode)
                {
                    labfile.Visible = true;
                    labfile.Text = " اسم الملف غير صحيح ";
                    vaild = false; return vaild;
                }
                else if (FileNameDot[1].ToString() != "doc" && FileNameDot[1].ToString() != "docx" && FileNameDot[1].ToString() != "pdf")
                {
                    labfile.Visible = true;
                    labfile.Text = " امتداد الملف غير صحيح ";
                    vaild = false;
                    return vaild;
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

        else { vaild = true; }
        return vaild;
    }
    protected void saveFileSystem()
    {
        //documents_DT obj = documents_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        string savePath = MapPath("~") + "\\images\\esdarat\\";

        string fileName = fucontentFile.FileName;
        savePath += fileName;
        fucontentFile.SaveAs(savePath);
        if (menus_update.get_current_lang() == 1)
        { manuscripts_obj_to_save.form_file = fileName; }
        else if (menus_update.get_current_lang() == 2)
        { manuscripts_obj_to_save.form_file_en = fileName; }
        else if (menus_update.get_current_lang() == 3)
        { manuscripts_obj_to_save.form_file_fr = fileName; }

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
            ShowAlertMessage("يجب إدخال العصر الذي تتناوله/ ترتبط به المخطوط");
            goto returnPart;
        }
    returnPart:
        return isValid;

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
    public void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            getData();
            if (CheckValidate())
            {
                if (vaildfile())
                {
                    
                    manuscripts_obj_to_save.id = Convert.ToInt16(content_id.Value);
                    if (highlight_panorama.Checked)
                        manuscripts_obj_to_save.highlight_panorama = 1;
                    else
                        manuscripts_obj_to_save.highlight_panorama = 0;
                    if (highlight.Checked)
                        manuscripts_obj_to_save.highlight = 1;
                    else
                        manuscripts_obj_to_save.highlight = 0;

                    manuscripts_obj_to_save.rblFormImage = rblFormImage.SelectedIndex.ToString();
                   
                    //manuscripts_obj_to_save.period_id = manuscripts_obj_to_save.period_id;
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
                        manuscripts_obj_to_save.period_id_multi = periods;
                        //}

                    }

                  

                    if (menus_update.get_current_lang() == 1)
                    {
                        if (manuscripts_obj_to_save.form_file != "")
                        { form_file.Visible = true; form_file.HRef = "~/images/esdarat/" + manuscripts_obj_to_save.form_file; }
                        else form_file.Visible = false;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        if (manuscripts_obj_to_save.form_file_en != "")
                        { form_file.Visible = true; form_file.HRef = "~/images/esdarat/" + manuscripts_obj_to_save.form_file_en; }
                        else form_file.Visible = false;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        if (manuscripts_obj_to_save.form_file_fr != "")
                        { form_file.Visible = true; form_file.HRef = "~/images/esdarat/" + manuscripts_obj_to_save.form_file_fr; }
                        else form_file.Visible = false;
                    }


                    int res = manuscripts_DB.Save(manuscripts_obj_to_save);

                    manuscripts_details_obj_to_save.manuscript_id = Convert.ToInt16(content_id.Value);
                    //manuscripts_details_obj_to_save.title = title.Text;
                    manuscripts_details_obj_to_save.title_fromtitle = txt_fromtitle.Text;
                    manuscripts_details_obj_to_save.title_mosk = txt_title_documented.Text;
                    manuscripts_details_obj_to_save.title_intro = txt_title_intro.Text;
                    //manuscripts_details_obj_to_save.title_mosk = txt_title_mosk.Text;
                    manuscripts_details_obj_to_save.title_src = txt_source_place.Text;
                    //manuscripts_details_obj_to_save.author = author.Text;
                    manuscripts_details_obj_to_save.author = txt_author.Text;
                    manuscripts_details_obj_to_save.author_fromtitle = txt_author_fromtitle.Text;
                    manuscripts_details_obj_to_save.author_intro = txt_author_mokdma.Text;
                    manuscripts_details_obj_to_save.author_mosk = txt_author_moska.Text;

                    if (man_lang.SelectedValue != "")
                        manuscripts_details_obj_to_save.man_lang = man_lang.SelectedValue;
                    //else
                    //    manuscripts_details_obj_to_save.man_lang = other_lang.Text;

                    manuscripts_details_obj_to_save.copy_place = copy_place.Text;
                    manuscripts_details_obj_to_save.copier = copier.Text;
                    manuscripts_details_obj_to_save.copy_date = copy_date.Text;
                    manuscripts_details_obj_to_save.copy_date_type = copy_date_type.SelectedValue;
                    if (copy_state.SelectedValue != "")
                        manuscripts_details_obj_to_save.copy_state = copy_state.SelectedValue;
                    //else
                    //    manuscripts_details_obj_to_save.copy_state = other_copy_state.Text;

                    if (license_type.SelectedValue != "")
                        manuscripts_details_obj_to_save.license_type = license_type.SelectedValue;
                    else
                        manuscripts_details_obj_to_save.license_type = other_license_type.Text;
                    manuscripts_details_obj_to_save.oldest_license_date_m = oldest_license_date_m.Text;
                    manuscripts_details_obj_to_save.oldest_license_date_h = oldest_license_date_h.Text;
                    manuscripts_details_obj_to_save.listinging = listinging.SelectedValue;
                    manuscripts_details_obj_to_save.listinging_date_m = listinging_date_m.Text;
                    manuscripts_details_obj_to_save.listinging_date_h = listinging_date_h.Text;

                    manuscripts_details_obj_to_save.collection_no = collection_no.Text;
                    manuscripts_details_obj_to_save.papers_from = papers_from.Text;
                    manuscripts_details_obj_to_save.papers_to = papers_to.Text;
                    manuscripts_details_obj_to_save.parts_no = parts_no.Text;
                    manuscripts_details_obj_to_save.folders_no = folders_no.Text;

                    manuscripts_details_obj_to_save.length = length.Text;
                    manuscripts_details_obj_to_save.width = width.Text;
                    manuscripts_details_obj_to_save.height = height.Text;
                    manuscripts_details_obj_to_save.ruler = ruler.Text;


                    string copy_contains_str = "";
                    for (int i = 0; i < copy_contains.Items.Count; i++)
                    {
                        if (copy_contains.Items[i].Selected == true)
                        {
                            copy_contains_str += copy_contains.Items[i].Value + ",";
                        }
                    }
                    if (copy_contains_str != "")
                    {

                        //if (multiper.Length > 1)
                        //{
                        manuscripts_details_obj_to_save.copy_contains = copy_contains_str;
                        //}

                    }


                    string copy_has_str = "";
                    for (int i = 0; i < copy_has.Items.Count; i++)
                    {
                        if (copy_has.Items[i].Selected == true)
                        {
                            copy_has_str += copy_has.Items[i].Value + ",";
                        }
                    }
                    if (copy_has_str != "")
                    {

                        //if (multiper.Length > 1)
                        //{
                        manuscripts_details_obj_to_save.copy_has = copy_has_str;
                        //}

                    }
                    //if (copy_contains.SelectedValue != "")
                    //    manuscripts_details_obj_to_save.copy_contains = copy_contains.SelectedValue;
                    //else
                    //    manuscripts_details_obj_to_save.copy_contains = other_copy_contains.Text;
                    if (font_type.SelectedValue != "")
                        manuscripts_details_obj_to_save.font_type = font_type.SelectedValue;
                    //else
                    //    manuscripts_details_obj_to_save.font_type = other_font_type.Text;
                    //if (copy_has.SelectedValue != "")
                    //    manuscripts_details_obj_to_save.copy_has = copy_has.SelectedValue;
                    //else
                    //    manuscripts_details_obj_to_save.copy_has = other_copy_has.Text;
                    manuscripts_details_obj_to_save.introduction = introduction.Text;
                    manuscripts_details_obj_to_save.conclusion = conclusion.Text;
                    manuscripts_details_obj_to_save.country = country.Text;
                    manuscripts_details_obj_to_save.town = town.Text;
                    manuscripts_details_obj_to_save.general_no = general_no.Text;

                    manuscripts_details_obj_to_save.special_no = special_no.Text;
                    manuscripts_details_obj_to_save.the_art = the_art.Text;
                    manuscripts_details_obj_to_save.special_lib = special_lib.Text;
                    manuscripts_details_obj_to_save.notes = notes.Text;
                    manuscripts_details_obj_to_save.keywords = keywords.Text;

                    //manuscripts_details_obj_to_save.period_id = Convert.ToInt16(period_id.SelectedValue);
                    //manuscripts_details_obj_to_save.period_notes = period_notes.Text;

                    ////string lang_id = "";
                    ////if (Session["Lang"] != null && Session["Lang"].ToString() != "")
                    ////{
                    ////    if (Session["Lang"].ToString() == "ar")
                    ////        lang_id = "1";
                    ////    if (Session["Lang"].ToString() == "en")
                    ////        lang_id = "2";
                    ////    if (Session["Lang"].ToString() == "fr")
                    ////        lang_id = "3";
                    ////}

                    manuscripts_details_obj_to_save.lang_id = menus_update.get_current_lang();
                    manuscripts_details_obj_to_save.data_collector_name = data_collector_name.Text;
                    //manuscripts_details_obj_to_save.data_entry_name  = data_entry_name.Text;
                    //manuscripts_details_obj_to_save.data_entry_revision_name = data_entry_revision_name.Text;
                    manuscripts_details_obj_to_save.data_revision_name = data_revision_name.Text;
                    manuscripts_details_obj_to_save.manuscript_id = manuscripts_details_DB.Save(manuscripts_details_obj_to_save);

                    // Recording log action
                    ShowAlertMessage("لقد تم الحفظ");
                    if (res > 0 && manuscripts_details_obj_to_save.manuscript_id > 0)
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
                    filldata();

                }
            }
        }
        catch
        {
            lblpage.Visible = false;
        }
        //this.Page.GetType().InvokeMember("fill_data", System.Reflection.BindingFlags.InvokeMethod, null, this.Page, new object[] { });
        //this.Page.GetType().InvokeMember("fill_objects_titles", System.Reflection.BindingFlags.InvokeMethod, null, this.Page, new object[] { });

        
    }
    private void getData()
    {
        //TamalokatGridView.DataSource = tamalokat_DB.SelectByID(Convert.ToInt16(content_id.Value));
        //TamalokatGridView.DataBind();

        //TawfikatGridView.DataSource = tawkifat_DB.SelectByID(Convert.ToInt16(content_id.Value));
        //TawfikatGridView.DataBind();

        manuscripts_obj_to_save = manuscripts_DB.SelectByID(Convert.ToInt16(content_id.Value));
        manuscripts_details_obj_to_save = manuscripts_details_DB.SelectByID(Convert.ToInt16(content_id.Value), menus_update.get_current_lang());
        //contents_timeline_obj_to_select = contents_timeline_DB.SelectByID(Convert.ToInt16(content_id.Value));
    }
    public void filldata()
    {
        if (manuscripts_obj_to_save.highlight_panorama == 1)
            highlight_panorama.Checked = true;
        if (manuscripts_obj_to_save.highlight == 1)
            highlight.Checked = true;

        rblFormImage.SelectedIndex =CDataConverter.ConvertToInt(manuscripts_obj_to_save.rblFormImage);
        //period_id.SelectedValue = Convert.ToString(manuscripts_obj_to_save.period_id);
        if (manuscripts_obj_to_save.period_id_multi != null && manuscripts_obj_to_save.period_id_multi != "")
        {
            String[] temp = manuscripts_obj_to_save.period_id_multi.ToString().Split(',');
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
        if (manuscripts_obj_to_save.form_file != "")
        {
            //RequiredFieldValidator4.ValidationGroup = "files";
            form_file.HRef  = "~/images/manuscripts/" + manuscripts_obj_to_save.form_file;
        }
        else
            form_file.Visible = false;
        title.Text = manuscripts_details_obj_to_save.title;
    
        txt_source_place.Text = manuscripts_details_obj_to_save.title_src;
        //author.Text = manuscripts_details_obj_to_save.author;
        txt_fromtitle.Text = manuscripts_details_obj_to_save.title_fromtitle;
        txt_title_intro.Text = manuscripts_details_obj_to_save.title_intro;

        txt_title_documented.Text = manuscripts_details_obj_to_save.title_mosk;

        //manuscripts_details_obj_to_save.author = author.Text;
        txt_author.Text = manuscripts_details_obj_to_save.author;
        txt_author_mokdma.Text = manuscripts_details_obj_to_save.author_intro;
        txt_author_fromtitle.Text = manuscripts_details_obj_to_save.author_fromtitle;
        txt_author_moska.Text = manuscripts_details_obj_to_save.author_mosk;

        if (manuscripts_details_obj_to_save.man_lang != "")
            man_lang.SelectedValue = manuscripts_details_obj_to_save.man_lang;
        copy_place.Text = manuscripts_details_obj_to_save.copy_place;
        copier.Text = manuscripts_details_obj_to_save.copier;
        copy_date.Text = manuscripts_details_obj_to_save.copy_date;
        copy_date_type.SelectedValue = manuscripts_details_obj_to_save.copy_date_type;
        if (manuscripts_details_obj_to_save.copy_state != "")
            copy_state.SelectedValue = manuscripts_details_obj_to_save.copy_state;

        collection_no.Text = manuscripts_details_obj_to_save.collection_no;
        papers_from.Text = manuscripts_details_obj_to_save.papers_from;
        papers_to.Text = manuscripts_details_obj_to_save.papers_to;
        parts_no.Text = manuscripts_details_obj_to_save.parts_no;
        folders_no.Text = manuscripts_details_obj_to_save.folders_no;

        length.Text = manuscripts_details_obj_to_save.length;
        width.Text = manuscripts_details_obj_to_save.width;
        height.Text = manuscripts_details_obj_to_save.height;
        ruler.Text = manuscripts_details_obj_to_save.ruler;

        if (manuscripts_details_obj_to_save.copy_contains != null && manuscripts_details_obj_to_save.copy_contains != "")
        {
            String[] temp = manuscripts_details_obj_to_save.copy_contains.ToString().Split(',');
            if (temp.Length > 0)
            {
                for (int i = 0; i < copy_contains.Items.Count; i++)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (copy_contains.Items[i].Value == temp[j])
                        {
                            copy_contains.Items[i].Selected = true;
                        }
                    }
                }
            }
        }

        //if (manuscripts_details_obj_to_save.copy_contains != "")
        //    copy_contains.SelectedValue = manuscripts_details_obj_to_save.copy_contains;
        
        
        
        if (manuscripts_details_obj_to_save.font_type != "")
            font_type.SelectedValue = manuscripts_details_obj_to_save.font_type;


        if (manuscripts_details_obj_to_save.copy_has != null && manuscripts_details_obj_to_save.copy_has != "")
        {
            String[] temp = manuscripts_details_obj_to_save.copy_has.ToString().Split(',');
            if (temp.Length > 0)
            {
                for (int i = 0; i < copy_has.Items.Count; i++)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (copy_has.Items[i].Value == temp[j])
                        {
                            copy_has.Items[i].Selected = true;
                        }
                    }
                }
            }
        }

        
        introduction.Text = manuscripts_details_obj_to_save.introduction;
        conclusion.Text = manuscripts_details_obj_to_save.conclusion;
        country.Text = manuscripts_details_obj_to_save.country;
        town.Text = manuscripts_details_obj_to_save.town;
        general_no.Text = manuscripts_details_obj_to_save.general_no;
        special_no.Text = manuscripts_details_obj_to_save.special_no;
        the_art.Text = manuscripts_details_obj_to_save.the_art;
        special_lib.Text = manuscripts_details_obj_to_save.special_lib;
        notes.Text = manuscripts_details_obj_to_save.notes;
        keywords.Text = manuscripts_details_obj_to_save.keywords;
        data_collector_name.Text = manuscripts_details_obj_to_save.data_collector_name;
        //data_entry_name.Text = manuscripts_details_obj_to_save.data_entry_name;
        //data_entry_revision_name.Text = manuscripts_details_obj_to_save.data_entry_revision_name;
        data_revision_name.Text = manuscripts_details_obj_to_save.data_revision_name;
        if (manuscripts_details_obj_to_save.license_type != "")
            license_type.SelectedValue = manuscripts_details_obj_to_save.license_type;

        oldest_license_date_m.Text = manuscripts_details_obj_to_save.oldest_license_date_m;
        oldest_license_date_h.Text = manuscripts_details_obj_to_save.oldest_license_date_h;
        listinging.SelectedValue = manuscripts_details_obj_to_save.listinging;

        listinging_date_m.Text = manuscripts_details_obj_to_save.listinging_date_m;
        listinging_date_h.Text = manuscripts_details_obj_to_save.listinging_date_h;
        //period_id.SelectedValue = Convert.ToString(manuscripts_details_obj_to_save.period_id);
        //period_notes.Text = manuscripts_details_obj_to_save.period_notes;
        form_file.Visible = true;
        if (menus_update.get_current_lang() == 1)
        {
            if (manuscripts_obj_to_save.form_file != "")
            { form_file.Visible = true; form_file.HRef = "~/images/esdarat/" + manuscripts_obj_to_save.form_file; }
            else form_file.Visible = false;
        }
        if (menus_update.get_current_lang() == 2)
        {
            if (manuscripts_obj_to_save.form_file_en != "")
            { form_file.Visible = true; form_file.HRef = "~/images/esdarat/" + manuscripts_obj_to_save.form_file_en; }
            else form_file.Visible = false;
        }
        if (menus_update.get_current_lang() == 3)
        {
            if (manuscripts_obj_to_save.form_file_fr != "")
            { form_file.Visible = true; form_file.HRef = "~/images/esdarat/" + manuscripts_obj_to_save.form_file_fr; }
            else form_file.Visible = false;
        }

        //data_collector_name.Text = manuscripts_details_obj_to_save.data_collector_name;
        //data_revision_name.Text = manuscripts_details_obj_to_save.data_revision_name;
        //data_entry_name.Text = manuscripts_details_obj_to_save.data_entry_name;
        //data_entry_revision_name.Text = manuscripts_details_obj_to_save.data_entry_revision_name;
    }
    protected void EgazaGridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }

    
}
