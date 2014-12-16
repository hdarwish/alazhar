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

public partial class masterpage_conference_proceed : System.Web.UI.UserControl
{
    public static int row_id = 0;
    conference_proceedings_DT conference = new conference_proceedings_DT();
    conference_proceedings_details_DT conference_details = new conference_proceedings_details_DT();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { //FillGrid(); 
        }

        if (HiddenField1.Value == "0")
        {
            HiddenField1.Value = "1";
            getData();
            fillcheck_periods();
            fillcontrol();
            filldrop_lang();
            
            invisible();
            visible();
            set_example_label();
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {
                // Button2.Visible = false;
               // uploadfile.Enabled = false;
                Dimmed();
                Enabled();
                //tbl_translate.Visible = false;
            }
            if (Session["user_type"].ToString() == "5")
            {
                Button1.Visible = false;
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
    private void getData()
    {
        conference = conference_proceedings_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        conference_details = conference_proceedings_details_DB.SelectByConference_ID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());


    }
    private void filldrop_lang()
    {
        languages_DT obj = new languages_DT();
        DataTable lang_dt = languages_DB.SelectAll();

        drop_lang.DataSource = lang_dt;
        drop_lang.DataBind();
        ListItem litem = new ListItem("-- اختر اللغة --", "0");
        drop_lang.Items.Insert(0, litem);
        
           
        if (conference_details.conference_lang != 0)
        {
            int id = conference_details.conference_lang;
            drop_lang.Items.FindByValue(id.ToString()).Selected = true;
        }
            
       
        else
        {

            litem.Selected = true;

        }

    }
    private void filldrop_author()
    {
        //DataTable dt = authors_details_DB.SelectAll();
        //drop_author.DataSource = dt;
        //drop_author.DataBind();
        //ListItem litem = new ListItem("-- اختر اسم المؤلف --", "0");
        //litem.Selected = true;
        //drop_author.Items.Insert(0, litem);
    }
    private void filldrop_char()
    {
        //DataTable dt = characters_details_DB.SelectBylang_ID(menus_update.get_current_lang());
        //drop_char.DataSource = dt;
        //drop_char.DataBind();
        //ListItem litem = new ListItem("--  اختر اسم المؤلف من الشخصيات  --", "0");
        //litem.Selected = true;
        //drop_char.Items.Insert(0, litem);
    }
    private void filldrop_role()
    {
        //DataTable dt = authors_role_DB.SelectAll();
        //drop_role.DataSource = dt;
        //drop_role.DataBind();
        //ListItem litem = new ListItem("-- اختر دور المؤلف--", "0");
        //litem.Selected = true;
        //drop_role.Items.Insert(0, litem);
    }
    private void fillcheck_periods()
    {
        periods_DT obj = new periods_DT();
        DataTable per_dt = periods_DB.SelectAll();
        chk_periods.DataSource = per_dt;
        chk_periods.DataBind();


    }
    public void Dimmed()
    {

        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tbmoatmr.Rows)
        {
            foreach (Control ctr in r.Cells)
            {

                foreach (Control control in ctr.Controls)
                {

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
                        if (txtbox != null)
                        {
                            txtbox.ReadOnly = false;
                            txtbox.ForeColor = System.Drawing.Color.Red;
                        }

                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "RadioButtonList")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        RadioButtonList rad = (RadioButtonList)this.FindControl(id);
                        if (rad != null)
                        {
                            rad.Enabled = true;
                            rad.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "CheckBox")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        CheckBox chbox = (CheckBox)this.FindControl(id);
                        if (chbox != null)
                        {
                            chbox.Enabled = true;
                            chbox.ForeColor = System.Drawing.Color.Red;
                        }
                        //chbox.Focus();

                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "CheckBoxList")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        CheckBoxList chbL = (CheckBoxList)this.FindControl(id);
                        chbL.Enabled = true;
                        chbL.ForeColor = System.Drawing.Color.Red;
                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "DropDownList")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        DropDownList drop = (DropDownList)this.FindControl(id);
                        if (drop != null)
                        {
                            drop.Enabled = true;
                            drop.ForeColor = System.Drawing.Color.Red;
                            //chbox.Focus();
                        }
                    }
                    //if (cont_fields.Rows[x]["type"].ToString() == "Button")
                    //{
                    //    id = cont_fields.Rows[x]["control_name"].ToString();
                    //    Button btn = (Button)this.FindControl(id);
                    //    if (btn != null)
                    //    {
                    //        btn.Visible = true;
                    //        //btn.ForeColor = System.Drawing.Color.Red;
                    //    }
                    //}
                    if (cont_fields.Rows[x]["type"].ToString() == "FileUpload")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        FileUpload upfile = (FileUpload)this.FindControl(id);
                        if (upfile != null)
                        {
                            upfile.Enabled = true;
                            //btn.ForeColor = System.Drawing.Color.Red;
                        }

                    }


                }
            }
        }

    }
    public void invisible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[16];
            arrv[0] = "trtitle";
            arrv[1] = "trrevisionname";
            arrv[2] = "trspecial";
            arrv[3] = "trpageno";
            arrv[4] = "trconference";
            arrv[5] = "trcolectorname";
            arrv[6] = "trdate";
            arrv[7] = "trplace";
            arrv[8] = "trcountry";
            arrv[9] = "trorg";
            arrv[10] = "trpicture";
            arrv[11] = "trnotes";
            arrv[12] = "trtags";
            arrv[13] = "trperiods";
            arrv[14] = "file_tr";
            arrv[15] = "trlang";

            for (int i = 0; i < 16; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = false;


            }
        }
    }
    public void visible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[8];
            arrv[0] = "trtitle";
            arrv[1] = "trconference";
            arrv[2] = "trplace";
            arrv[3] = "trcountry";
            arrv[4] = "trorg";
            arrv[5] = "trnotes";
            arrv[6] = "trtags";
            arrv[7] = "file_tr";
            // arrv[8] = "trgrid_moalf";
            // arrv[9] = "trsave";
            //arrv[10] = "trtrgma";

            for (int i = 0; i < 8; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;

            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        save();

    }
    public void save()
    {
        if (CheckValidate())
        {
            if (vaildfile())
            {
                lblerror.Visible = false;

                if (chk_site.Checked == true)
                { conference.highlight = 1; }
                else conference.highlight = 0;
                if (chk_pan.Checked == true)
                { conference.highlight_panorama = 1; }
                else { conference.highlight_panorama = 0; }

                conference.conf_date = txt_date.Text;
                conference.conf_hdate = txt_hdate.Text;
                //conference.period_id =CDataConverter.ConvertToInt(chk_periods.SelectedValue);
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
                    conference.period_id_multi = periods;
                    //}

                }
                conference.id = conference_proceedings_DB.Save(conference);

                conference_details.conference_proceeding_id = CDataConverter.ConvertToInt(content_id.Value);




                //if (CDataConverter.ConvertToInt(drop_lang.SelectedValue) > 0)
                //{
                //    other.Enabled = false;
                //    conference_details.conference_lang = drop_lang.SelectedItem.Text;
                //}
                //else if (other.Text != "")
                //{
                //    other.Enabled = true;
                //    //conference_details.conference_lang  = other.Text;
                //}
                conference_details.conference_org = txt_org.Text;
                conference_details.conference_lang =  CDataConverter.ConvertToInt(drop_lang.SelectedValue);
                conference_details.conference_from = CDataConverter.ConvertToInt(txt_from.Text);
                conference_details.conference_to = CDataConverter.ConvertToInt(txt_to.Text);
                conference_details.keywords = txt_tags.Text;
                conference_details.notes = txt_notes.Text;
                conference_details.conference_city = txt_city.Text;
                conference_details.conference_country = txt_country.Text;
                conference_details.conference_place = txt_place.Text;
                conference_details.conference_name = txt_name.Text;
                conference_details.conference_no = txt_conf_no.Text;
                conference_details.data_collector_name = txtFormDataColectorName.Text;
                conference_details.data_revision_name = txtFormDataRevisionName.Text;
                conference_details.form_pic_state = CDataConverter.ConvertToInt(rblFormImage.SelectedIndex);
                conference_details.lang_id = menus_update.get_current_lang();
                int res = conference_proceedings_details_DB.Save(conference_details);
                if (res > 0)
                {
                    ShowAlertMessage("لقد تم الحفظ");
                    log(2);
                }
                id_href.Visible = true;
                if (menus_update.get_current_lang() == 1)
                {
                    if (conference.form_file != "")
                    { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + conference.form_file; }
                    else id_href.Visible = false;
                }
                if (menus_update.get_current_lang() == 2)
                {
                    if (conference.form_file_en != "")
                    { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + conference.form_file_en; }
                    else id_href.Visible = false;
                }
                if (menus_update.get_current_lang() == 3)
                {
                    if (conference.form_file_fr != "")
                    { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + conference.form_file_fr; }
                    else id_href.Visible = false;
                }
            }
            //else
            //{ ShowAlertMessage("من فضلك أعد المحاولة"); }

        }

    }
    public void fillcontrol()
    {
        if (conference.highlight_panorama == 1)
        { chk_pan.Checked = true; }
        else chk_pan.Checked = false;
        if (conference.highlight == 1)
        { chk_site.Checked = true; }
        txt_from.Text = conference_details.conference_from.ToString();
        txt_to.Text = conference_details.conference_to.ToString();
        txt_conf_no.Text = conference_details.conference_no;
        //if (conference.period_id > 0)
        //{ chk_periods.SelectedValue =  conference.period_id.ToString(); }
        if (conference.period_id_multi != null && conference.period_id_multi != "")
        {
            String[] temp = conference.period_id_multi.ToString().Split(',');
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
        txt_hdate.Text = conference.conf_hdate;
        txt_date.Text = conference.conf_date;
        txt_art_title.Text = conference_details.title;
        txt_notes.Text = conference_details.notes;
        txt_city.Text = conference_details.conference_city;
        txt_country.Text = conference_details.conference_country;
        txt_place.Text = conference_details.conference_place;
        txt_org.Text = conference_details.conference_org;
        txt_name.Text = conference_details.conference_name;
        txtFormDataColectorName.Text = conference_details.data_collector_name;

        txtFormDataRevisionName.Text = conference_details.data_revision_name;

        rblFormImage.SelectedIndex = CDataConverter.ConvertToInt(conference_details.form_pic_state);
        txt_tags.Text = conference_details.keywords;
        id_href.Visible = true;

        if (menus_update.get_current_lang() == 1)
        {
            if (conference.form_file != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + conference.form_file; }
            else id_href.Visible = false;
        }
        if (menus_update.get_current_lang() == 2)
        {
            if (conference.form_file_en != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + conference.form_file_en; }
            else id_href.Visible = false;
        }
        if (menus_update.get_current_lang() == 3)
        {
            if (conference.form_file_fr != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + conference.form_file_fr; }
            else id_href.Visible = false;
        }
    }
    protected Boolean vaildfile()
    {
        bool vaild = false;
        string filename = uploadfile.FileName;
        if (menus_update.get_current_lang() == 1)
        {
            if (conference.form_file == "")
            {
                filename = uploadfile.FileName;
                if (filename == "")
                {

                    labfile.Visible = true;
                    //labfile.ForeColor = System.Drawing.Color.Red;
                    labfile.Text = "يجب إضافة ملف";
                    vaild = false;
                    return vaild;
                }
            }
           
        }
        else if (menus_update.get_current_lang() == 2)
        {
            if (conference.form_file_en == "")
            {
                filename = uploadfile.FileName;
                if (filename == "")
                {

                    labfile.Visible = true;
                    //labfile.ForeColor = System.Drawing.Color.Red;
                    labfile.Text = "يجب إضافة ملف";
                    vaild = false;
                    return vaild;
                }
            }
        }
        else if (menus_update.get_current_lang() == 3)
        {
            if (conference.form_file_fr == "")
            {
                filename = uploadfile.FileName;
                if (filename == "")
                {

                    labfile.Visible = true;
                    //labfile.ForeColor = System.Drawing.Color.Red;
                    labfile.Text = "يجب إضافة ملف";
                    vaild = false;
                    return vaild;
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
                { fileCode = cont_type.ToString() + "_" + id.ToString() + "_en"; }
                else if (menus_update.get_current_lang() == 3)
                { fileCode = cont_type.ToString() + "_" + id.ToString() + "_fr"; }
                if (FileNameDot[0].ToString() != fileCode)
                {
                    labfile.Visible = true;
                    labfile.Text = " اسم الملف غير صحيح ";
                    vaild = false;
                    return vaild;
                }
                else if (FileNameDot[1].ToString() == "doc" || FileNameDot[1].ToString() == "docx" || FileNameDot[1].ToString() == "pdf")
                {

                    saveFileSystem();
                    vaild = true;
                    return vaild;

                }
                else
                {
                    labfile.Visible = true;
                    labfile.Text = " امتداد الملف غير صحيح ";
                    vaild = false;
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

        else { vaild = true; }
        return vaild;
    }
    protected void saveFileSystem()
    {

        string savePath = MapPath("~") + "\\images\\esdarat\\";

        string fileName = uploadfile.FileName;
        
        savePath += fileName;

        if (System.IO.File.Exists(fileName))
        {
            System.IO.File.Delete(fileName);
            uploadfile.SaveAs(savePath);
        }
        else
        {
            uploadfile.SaveAs(savePath);

        }
        if (menus_update.get_current_lang() == 1)
        { conference.form_file = fileName; }
        else if (menus_update.get_current_lang() == 2)
        { conference.form_file_en = fileName; }
        else if (menus_update.get_current_lang() == 3)
        { conference.form_file_fr = fileName; }


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
    private bool CheckValidate()
    {
        bool isValid = true;
        if (menus_update.get_current_lang() == 1)
        {
            if (CDataConverter.ConvertToInt(drop_lang.SelectedValue) < 0)
            {
                isValid = false;
                lblerror.Visible = true;
                lblerror.Text = "يجب اختيار اللغة أو كتابة لغة أخري";
                goto returnPart;
            }


            if (txt_hdate.Text != "")
            {
                if (security_issues.check_date(txt_hdate.Text) == false)
                {
                    isValid = false;
                    lblerror.Visible = true;
                    lblerror.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "(التاريخ الهجري غير صحيح يجب أن يكون( سنة أو (يوم/شهر/سنة)";
                    goto returnPart;

                }
            }
            if (txt_date.Text != "")
            {
                if (security_issues.check_date(txt_date.Text) == false)
                {
                    isValid = false;
                    lblerror.Visible = true;
                    lblerror.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "(التاريخ الميلادي غير صحيح يجب أن يكون( سنة أو (يوم/شهر/سنة)";
                    goto returnPart;

                }
            }
            for (int i = 0; i < chk_periods.Items.Count; i++)
            {
                if (chk_periods.Items[i].Selected)
                {
                    goto returnPart;
                }

            }
            isValid = false;
            ShowAlertMessage("يجب إدخال العصر الذي يتناوله/ يرتبط به البحث");
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        //int id = 0;
        //if (CDataConverter.ConvertToInt(drop_char.SelectedValue) > 0)
        //{
        //    docs_authors_DT authors_doc_dt = new docs_authors_DT();
        //    authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
        //    authors_doc_dt.author_id = CDataConverter.ConvertToInt(drop_char.SelectedValue);
        //    authors_doc_dt.is_character = 1;
        //    authors_doc_dt.relation_title_ar = "";
        //    //authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
        //    authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
        //    authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
        //    id = authors_doc_dt.id;
        //    General_Helping.ExcuteQuery("update docs_authors set doc_type = 1 where docs_authors.id= " + authors_doc_dt.id);

        //}
        //if (TextBox1.Text != "")
        //{
        //    authors_DT authors_new = new authors_DT();
        //    authors_new.id = 0;
        //    authors_new.notes = "";
        //    authors_new.id = authors_DB.Save(authors_new);
        //    authors_details_DT author_details_new = new authors_details_DT();
        //    author_details_new.id = 0;
        //    author_details_new.author_id = authors_new.id;
        //    author_details_new.name = TextBox1.Text;
        //    author_details_new.details = null;
        //    author_details_new.address = null;
        //    author_details_new.title = null;
        //    author_details_new.lang_id = menus_update.get_current_lang();   
        //    int res = authors_details_DB.Save(author_details_new);
        //    if (res > 0)
        //    {
        //        docs_authors_DT authors_doc_dt = new docs_authors_DT();
        //        authors_doc_dt.id = 0;
        //        authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
        //        authors_doc_dt.author_id = author_details_new.author_id;
        //        authors_doc_dt.is_character = 0;
        //        authors_doc_dt.relation_title_ar = "";
        //        //authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
        //        authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
        //        authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
        //        id = authors_doc_dt.id;
        //        General_Helping.ExcuteQuery("update docs_authors set doc_type = 1 where docs_authors.id= " + authors_doc_dt.id);
        //    }

        //}

        ////if (CDataConverter.ConvertToInt(drop_author.SelectedValue) > 0)
        ////{
        //    //docs_authors_DT authors_doc_dt = new docs_authors_DT();
        //    ////// HiddenField or session [doc_id] ////
        //    //authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
        //    //authors_doc_dt.author_id = CDataConverter.ConvertToInt(drop_author.SelectedValue); ;
        //    //authors_doc_dt.is_character = 0;
        //    //authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
        //    //// authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
        //    //authors_doc_dt.relation_title_ar = "";
        //    //authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
        //    //id = authors_doc_dt.id;
        //    //General_Helping.ExcuteQuery("update docs_authors set doc_type = 1 where docs_authors.id= " + authors_doc_dt.id);

        ////}
        //if (id > 0)
        //{            //FillGrid();


        //}
        //FillGrid();

    }

    //public void imgDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    //{
    //    int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
    //    if (id > 0)
    //    {

    //        // docs_authors_DT dauthors_dt = new docs_authors_DT();
    //        //DataTable dt = docs_authors_DB.SelectByIDIsAuthor(id);
    //        //int author_id = CDataConverter.ConvertToInt(dt.Rows[0]["author_id"].ToString());
    //        //authors_DB.Delete(author_id);
    //        //authors_details_DB.Delete_authors(author_id);
    //        //docs_authors_DT docs_dt = new docs_authors_DT();
    //        docs_authors_DB.Delete(id);
    //        FillGrid();

    //    }
    //    //log(2);
    //}
    protected void drop_lang_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (drop_lang.SelectedIndex > 0)
        //{ other.Enabled = false; }
        //else { other.Enabled = true; }
    }
    protected void drop_char_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (drop_char.SelectedValue != "0")
        //{ //drop_author.Enabled = false;
        //  TextBox1.Enabled = false; 
        //}
        //else {
        //    //drop_author.Enabled = true; }
        //     TextBox1.Enabled = true;
        //}
    }
    protected void drop_author_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (drop_author.SelectedValue != "0")
        //{ drop_char.Enabled = false; TextBox1.Enabled = false; }
        //else { drop_char.Enabled = true; TextBox1.Enabled = true; }
    }
    protected void btn_translate_Click(object sender, EventArgs e)
    {
        //if (content_type.Value != "0")
        //{
        //    if (content_id.Value != "0")
        //        row_id = CDataConverter.ConvertToInt(((Button)sender).CommandArgument);
        //    if (row_id > 0)
        //    {
        //        trsave.Visible = true;
        //        trtrgma.Visible = true;
        //        //tbl_translate.Visible = true;
        //        Button2.Visible = false;
        //        // tbl_all.Visible = false;
        //    }
        //}
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //if (TextBox2.Text != "")
        //{
        //    //authors_DT authors_new = new authors_DT();
        //    //authors_new.id = 0;
        //    //authors_new.notes = "";
        //    //authors_new.id = authors_DB.Save(authors_new);
        //    authors_details_DT author_details_new = authors_details_DB.SelectByID(row_id);
        //    //authors_details_DT author_details_new = new authors_details_DT();
        //    author_details_new.id = author_details_new.id;
        //    author_details_new.author_id = row_id;
        //    author_details_new.name = TextBox2.Text;
        //    author_details_new.details = null;
        //    author_details_new.address = null;
        //    author_details_new.title = null;
        //    author_details_new.lang_id = menus_update.get_current_lang();
        //    int res = authors_details_DB.Save(author_details_new);
        //    //if (res > 0)
        //    //{
        //    //    docs_authors_DT authors_doc_dt = new docs_authors_DT();
        //    //    authors_doc_dt.id = authors_doc_dt.id;
        //    //    authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
        //    //    authors_doc_dt.author_id = row_id;
        //    //    authors_doc_dt.is_character = 0;
        //    //    authors_doc_dt.relation_title_ar = "";
        //    //    //authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
        //    //    authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
        //    //    authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
        //    //    //id = authors_doc_dt.id;
        //    //    General_Helping.ExcuteQuery("update docs_authors set doc_type = 1 where docs_authors.id= " + authors_doc_dt.id);
        //    //}

        //}
        //TextBox2.Text = "";
        //FillGrid();

    }
    //protected void gview_moalf_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
    //    if (e.CommandName == "TranslateItem")
    //    {
    //        if (content_type.Value != "0")
    //        {
    //            if (content_id.Value != "0")
    //                row_id = CDataConverter.ConvertToInt(e.CommandArgument.ToString());
    //            if (row_id > 0)
    //            {
    //                trsave.Visible = true;
    //                trtrgma.Visible = true;
    //                Button2.Visible = false;
    //            }
    //        }
    //    }
    //    else if (e.CommandName == "RemoveItem")
    //    {
    //        //int i = General_Helping.ExcuteQuery("Delete from users where id=" + e.CommandArgument.ToString());
    //        //FillGrid(CDataConverter.ConvertToInt(gvMain.PageIndex.ToString()), "id", "ASC");
    //    }
    //}
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   