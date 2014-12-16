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

public partial class masterpage_add_articles : System.Web.UI.UserControl
{
    public static int row_id = 0;
    documents_DT obj = new documents_DT();
    documents_details_DT obj_details = new documents_details_DT();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // FillGrid();
        }
        if (content_type.Value == "9")
        {
            if (content_id.Value != "")
            {
                getData();
fillcheck_periods();
                fillcontrol();
                filldrop_lang();
                //filldrop_author();
                //filldrop_char();
                //filldrop_role();
                
               // FillGrid();
                invisible();
                visible();
                set_example_label();

                if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
                {
                    //Button2.Visible = false;
                   // uploadfile.Enabled = false;
                    Dimmed();
                    Enabled();
                }
                if (Session["user_type"].ToString() == "4")
                {
                    txt_art_title.ReadOnly = true;
                }
                if (Session["user_type"].ToString() == "5")
                {
                    Button1.Visible = false;
                   // Button2.Visible = false;
                    uploadfile.Enabled = false;
                   // drop_char.Enabled = false;
                    //drop_author.Enabled = false;
                   // drop_role.Enabled = false;
                    //TextBox1.ReadOnly = true;
                    Dimmed();
                }
                if (menus_update.get_current_lang() == 1)
                {
                    //trtrgma.Visible = false;
                   // gview_moalf.Columns[2].Visible = false;
                    //gview_moalf.Columns[4].Visible = false;
                }
                else
                {
                    //trtrgma.Visible = true;
                    //tr_grid.Visible = true;
                    //gview_moalf.Columns[3].Visible = false;
                    //gview_moalf.Columns[3].Visible = true;
                    //gview_moalf.Columns[5].Visible = false;
                }
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
        obj = documents_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        obj_details = documents_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());


    }
    private void filldrop_lang()
    {
        languages_DT obj = new languages_DT();
        DataTable lang_dt = languages_DB.SelectAll();

        drop_lang.DataSource = lang_dt;
        drop_lang.DataBind();
        ListItem litem = new ListItem("-- اختر اللغة --", "0");
        drop_lang.Items.Insert(0, litem);
        if (obj_details.doc_lang2 != null)
        {
            if (obj_details.doc_lang2 != 0)
            {

                int id = obj_details.doc_lang2;
                drop_lang.Items.FindByValue(id.ToString()).Selected = true;

            }
            else
            {
                //ListItem litem = new ListItem("-- اختر اللغة --", "0");
                litem.Selected = true;
                //drop_lang.Items.Insert(0, litem);
            }
        }

    }
    private void filldrop_author()
    {
        //    DataTable dt = authors_details_DB.SelectAll();
        //    drop_author.DataSource = dt;
        //    drop_author.DataBind();
        //    ListItem litem = new ListItem("-- اختر اسم المؤلف --", "0");
        //    litem.Selected = true;
        //    drop_author.Items.Insert(0, litem);
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
        //chk_periods.DataValueField = "id";
        // chk_periods.DataTextField = "title";

    }
    public void Dimmed()
    {


        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblarticle.Rows)
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
                        if (id == "txt_folderno")
                        {
                            txt_folderno2.ReadOnly = txt_folderno3.ReadOnly = false;
                            txt_folderno2.ForeColor = txt_folderno3.ForeColor = System.Drawing.Color.Red;
                        }
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
                        drop.Enabled = true;
                        drop.ForeColor = System.Drawing.Color.Red;
                        //chbox.Focus();

                    }
                    
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        save();


    }
    public void invisible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[14];
            arrv[0] = "trtitle";

            arrv[1] = "trspecial";
            arrv[2] = "trpageno";
            arrv[3] = "trlang";
            arrv[4] = "trres";
            arrv[5] = "trfolderno";
            arrv[6] = "trseriesno";
            arrv[7] = "trnotes";
            arrv[8] = "trtags";
            arrv[9] = "trperiods";
            arrv[10] = "trpicture";
            arrv[11] = "trcolectorname";
            arrv[12] = "trrevisionname";
            arrv[13] = "trfoldernolbl";
           // arrv[13] = "trpagetile";

            for (int i = 0; i < 14; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                if (tr.ID != null)
                    tr.Visible = false;


            }
        }
    }
    public void visible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[5];
            arrv[0] = "trtitle";
            arrv[1] = "trres";
            arrv[2] = "trnotes";
            arrv[3] = "trtags";
            arrv[4] = "file_tr";
            //arrv[5] = "trpagetile";

            for (int i = 0; i < 5; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;

            }
        }
    }
    public void save()
    { //if (CheckValidate())
        {
            if (vaildfile())
            {

                lblerror.Visible = false;

                obj.doc_type = 2;
                if (chk_site.Checked == true)

                { obj.highlight = 1; }
                else obj.highlight = 0;
                if (chk_pan.Checked == true)
                { obj.highlight_panorama = 1; }
                else { obj.highlight_panorama = 0; }
                obj.pages_to = CDataConverter.ConvertToInt(txt_to.Text);
                obj.pages_from = CDataConverter.ConvertToInt(txt_from.Text);
                obj.pages_no = CDataConverter.ConvertToInt(txt_to.Text);
                if (txt_folderno.Text != "" || txt_folderno2.Text !="" || txt_folderno3.Text !="")
                {
                    obj.folders_no = txt_folderno.Text + " " + txt_folderno2.Text + " " + txt_folderno3.Text;
                }
                
                //obj.period_id = CDataConverter.ConvertToInt(chk_periods.SelectedValue);
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
                    obj.period_id_multi = periods;
                    //}

                }
		
                documents_DB.Save(obj);
                //doc_id.Value = obj.id.ToString();
                /////////////////////////////////////////

                
                obj_details.doc_id = CDataConverter.ConvertToInt(content_id.Value);
                //if (Session["Lang"] != null)
                //{ //int lang = int.Parse(HttpContext.Current.Session["Lang"].ToString());
                //    //obj_details.lang_id = Convert.ToInt32(Session["Lang"].ToString());
                //}
                obj_details.lang_id = menus_update.get_current_lang();
                obj_details.title = txt_art_title.Text;
               

                if (CDataConverter.ConvertToInt(drop_lang.SelectedValue) > 0)
                {
                    //other.Enabled = false;
                    obj_details.doc_lang2 = CDataConverter.ConvertToInt(drop_lang.SelectedValue);
                }

              
                //else if (drop_lang.SelectedIndex == 0)
                //{
                //Label4.Visible = true;
                //Label4.Text = "يجب ادخال لغة المقالة";
                //return;
                // }
                obj_details.keywords = txt_tags.Text;
                obj_details.notes = txt_notes.Text;
                obj_details.series_no = txt_seriesno.Text;
                obj_details.resource = txt_res.Text;
                obj_details.brief =
                 obj_details.direct_subject =
                 obj_details.docs_type =
                 obj_details.material_shape =
                 obj_details.material_type =
                 obj_details.publish_location =
                 obj_details.request_id =
                 obj_details.series = null;
                obj_details.data_collector_name = txtFormDataColectorName.Text;
                obj_details.data_revision_name = txtFormDataRevisionName.Text;
                obj_details.form_pic_state = CDataConverter.ConvertToInt(rblFormImage.SelectedValue);

                obj_details.id = documents_details_DB.Save(obj_details);
                if (obj_details.id > 0)
                {
                    ShowAlertMessage("لقد تم الحفظ");
                    log(2);


                    id_href.Visible = true;
                    if (menus_update.get_current_lang() == 1)
                    {
                        if (obj.form_file != "")
                        { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + obj.form_file; }
                        else id_href.Visible = false;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        if (obj.form_file_en != "")
                        { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + obj.form_file_en; }
                        else id_href.Visible = false;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        if (obj.form_file_fr != "")
                        { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + obj.form_file_fr; }
                        else id_href.Visible = false;
                    }
                }
                
                else { ShowAlertMessage("من فضلك أعد المحاولة"); }
                lbl_folderno.Text = obj.folders_no;
            }
        }

    }
    public void fillcontrol()
    {

        if (obj.highlight_panorama == 1)
        { chk_pan.Checked = true; }
        else chk_pan.Checked = false;
        if (obj.highlight == 1)
        { chk_site.Checked = true; }
        else chk_site.Checked = false;
        txt_from.Text = obj.pages_from.ToString();
        txt_to.Text = obj.pages_to.ToString();
        lbl_folderno.Text = obj.folders_no;
        //if (obj.period_id > 0)
        //{ chk_periods.SelectedValue = obj.period_id.ToString(); }
if (obj.period_id_multi != null && obj.period_id_multi != "")
        {
            String[] temp = obj.period_id_multi.ToString().Split(',');
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
        txt_art_title.Text = obj_details.title;
        txt_notes.Text = obj_details.notes;
        txt_seriesno.Text = obj_details.series_no;
        txtFormDataColectorName.Text = obj_details.data_collector_name;
        txt_res.Text = obj_details.resource;
        txtFormDataRevisionName.Text = obj_details.data_revision_name;
        //drop_lang.SelectedItem.Text  = obj_details.doc_lang;
        rblFormImage.SelectedValue = obj_details.form_pic_state.ToString();
        txt_tags.Text = obj_details.keywords;
        id_href.Visible = true;

        if (menus_update.get_current_lang() == 1)
        {
            if (obj.form_file != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + obj.form_file; }
            else id_href.Visible = false;
        }
        if (menus_update.get_current_lang() == 2)
        {
            if (obj.form_file_en != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + obj.form_file_en; }
            else id_href.Visible = false;
        }
        if (menus_update.get_current_lang() == 3)
        {
            if (obj.form_file_fr != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + obj.form_file_fr; }
            else id_href.Visible = false;
        }

    }

    protected Boolean vaildfile()
    {
        bool vaild = false;
        string filename = uploadfile.FileName;
        if (menus_update.get_current_lang() == 1)
        {
            if (obj.form_file == "")
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
            if (obj.form_file_en == "")
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
            if (obj.form_file_fr == "")
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

        string fileName = uploadfile.FileName;
        savePath += fileName;
        uploadfile.SaveAs(savePath);
        if (menus_update.get_current_lang() == 1)
        { obj.form_file = fileName; }
        else if (menus_update.get_current_lang() == 2)
        { obj.form_file_en = fileName; }
        else if (menus_update.get_current_lang() == 3)
        { obj.form_file_fr = fileName; }

    }

    private bool CheckValidate()
    {
        bool isValid = true;
        //if (txt_art_title.Text == "")
        //{
        //    isValid = false;
        //    lblerror.Visible = true;
        //    lblerror.Text = "يجب ادخال اسم المقالة";
        //    goto returnPart;
        //}
        if (txt_from.Text == "" || txt_to.Text == "")
        {
            isValid = false;
            lblerror.Visible = true;
            lblerror.Text = "يجب إدخال عدد الصفحات من / إلي ";
            goto returnPart;
        }
        if (CDataConverter.ConvertToInt(drop_lang.SelectedValue) < 0)
        {
            isValid = false;
            lblerror.Visible = true;
            lblerror.Text = "يجب اختيار اللغة ";
            goto returnPart;
        }
        if (txt_res.Text == "")
        {
            isValid = false;
            lblerror.Visible = true;
            lblerror.Text = "يجب ادخال اسم المقالة";
            goto returnPart;
        }
        if (CDataConverter.ConvertToInt(chk_periods.SelectedValue) < 0)
        {
            isValid = false;
            lblerror.Visible = true;
            lblerror.Text = "يجب اختيار العصر المرتبط بالمقالة";
            goto returnPart;
        }
        if (txt_tags.Text == "")
        {
            isValid = false;
            lblerror.Visible = true;
            lblerror.Text = "";
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
    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //    int id = 0;
    //    if (CDataConverter.ConvertToInt(drop_char.SelectedValue) > 0)
    //    {
    //        docs_authors_DT authors_doc_dt = new docs_authors_DT();
    //        authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
    //        authors_doc_dt.author_id = CDataConverter.ConvertToInt(drop_char.SelectedValue);
    //        authors_doc_dt.is_character = 1;
    //        authors_doc_dt.relation_title_ar = "";
    //        //authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
    //        authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
    //        authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
    //        id = authors_doc_dt.id;
    //    }
    //    if (TextBox1.Text != "")
    //    {
    //        authors_DT authors_new = new authors_DT();
    //        authors_new.id = 0;
    //        authors_new.notes = "";
    //        authors_new.id = authors_DB.Save(authors_new);
    //        authors_details_DT author_details_new = new authors_details_DT();
    //        author_details_new.id = 0;
    //        author_details_new.author_id = authors_new.id;
    //        author_details_new.name = TextBox1.Text;
    //        author_details_new.details = null;
    //        author_details_new.address = null;
    //        author_details_new.title = null;
    //        author_details_new.lang_id = menus_update.get_current_lang();
    //        int res = authors_details_DB.Save(author_details_new);

    //        if (res > 0)
    //        {
    //            docs_authors_DT authors_doc_dt = new docs_authors_DT();
    //            authors_doc_dt.id = 0;
    //            authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
    //            authors_doc_dt.author_id = author_details_new.author_id;
    //            authors_doc_dt.is_character = 0;
    //            authors_doc_dt.relation_title_ar = "";
    //            //authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
    //            authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
    //            authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
    //            id = authors_doc_dt.id;

    //        }

    //    }

    //    //if (CDataConverter.ConvertToInt(drop_author.SelectedValue) > 0)
    //    //{
    //    //    docs_authors_DT authors_doc_dt = new docs_authors_DT();
    //    //    //// HiddenField or session [doc_id] ////
    //    //    authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
    //    //    authors_doc_dt.author_id = CDataConverter.ConvertToInt(drop_author.SelectedValue); ;
    //    //    authors_doc_dt.is_character = 0;
    //    //    authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
    //    //    // authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
    //    //    authors_doc_dt.relation_title_ar = "";
    //    //    authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
    //    //    id = authors_doc_dt.id;
    //    //}
    //    if (id > 0)
    //    {
    //        //FillGrid();


    //    }
    //    FillGrid();
    //    TextBox1.Text = "";

    //}
    //public void FillGrid()
    //{
    //    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt(content_id.Value)),
    //       new SqlParameter("@lang_id", menus_update.get_current_lang ()) };
    //    DataTable dt = new DataTable();
    //    dt = DatabaseFunctions.SelectData(sqlParams, "authorstitle_select");
    //    gview_moalf.Visible = true;
    //    gview_moalf.DataSource = dt;
    //    gview_moalf.DataBind();

    //    /////////////////////////////////////////////////////////////////////
    //    if (CDataConverter.ConvertToInt(menus_update.get_current_lang()) > 1)
    //    {
    //        SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt(content_id.Value)) ,
    //        new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //        DataTable dt2 = new DataTable();
    //        dt2 = DatabaseFunctions.SelectData(sqlParams1, "authorstitle_conference_select");
    //        for (int f = 0; f < dt.Rows.Count; f++)
    //        {
    //            DataRow[] foundRows;

    //            foundRows = dt2.Select("author_id = '" + dt.Rows[f]["author_id"].ToString() + "'");
    //            if (foundRows.Length > 0)
    //            {
    //                dt.Rows[f]["name_ar"] = foundRows[0][1].ToString();
    //            }
    //        }
    //    }

    //}

    //public void imgDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    //{
    //    int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
    //    if (id > 0)
    //    {
    //        docs_authors_DB.Delete(id);
    //        FillGrid();

    //    }
    //}

    protected void drop_lang_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (drop_lang.SelectedIndex > 0)
        //{ other.Enabled = false; }
        //else { other.Enabled = true; }
    }
    //protected void drop_char_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (drop_char.SelectedValue != "0")
    //    { //drop_author.Enabled = false;
    //        TextBox1.Enabled = false;
    //    }
    //    else
    //    { //drop_author.Enabled = true;
    //        TextBox1.Enabled = true;
    //    }


    //}

    //protected void drop_author_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (drop_author.SelectedValue != "0")
    //    { drop_char.Enabled = false; TextBox1.Enabled = false; }
    //    else { drop_char.Enabled = true; TextBox1.Enabled = true; }
    //}

    //protected void TextBox1_TextChanged(object sender, EventArgs e)
    //{
    //    if (TextBox1.Text != "")
    //    {
    //        drop_char.Enabled = false;
    //    }
    //    else { drop_char.Enabled = true; }
    //}
    //protected void btn_moalf_Click(object sender, EventArgs e)
    //{
    //    if (txt_enmoalf.Text != "")
    //    {
    //        authors_details_DT author_details_new = authors_details_DB.SelectByID(row_id);
    //        //authors_details_DT author_details_new = new authors_details_DT();
    //        author_details_new.id = author_details_new.id;
    //        author_details_new.author_id = row_id;
    //        author_details_new.name = txt_enmoalf.Text;
    //        author_details_new.details = null;
    //        author_details_new.address = null;
    //        author_details_new.title = null;
    //        author_details_new.lang_id = menus_update.get_current_lang();
    //        int res = authors_details_DB.Save(author_details_new);

    //    }
    //    txt_enmoalf.Text = "";
    //    FillGrid();
    //}
    //protected void btn_translate_Click(object sender, EventArgs e)
    //{
    //   //if (IsPostBack)
    //    {
    //        Button btn = (Button)gview_moalf.FindControl ("btn_translate");
    //        btn.CausesValidation = false;
    //        btn.ValidationGroup = "F";
    //    }

    //    if (content_type.Value != "0")
    //    {
    //        if (content_id.Value != "0")
    //            row_id = CDataConverter.ConvertToInt(((Button)sender).CommandArgument);
    //        myRowIndex1.Value = ((Button)sender).CommandName;
    //        if (row_id > 0)
    //        {

    //            for (int i = 0; i < gview_moalf.Rows.Count; i++)
    //            {
    //                gview_moalf.Rows[i].BackColor = System.Drawing.Color.White;
    //            }
    //            gview_moalf.Rows[CDataConverter.ConvertToInt(myRowIndex1.Value)].BackColor = System.Drawing.Color.Lavender;
    //            authors_details_DT dt = authors_details_DB.SelectByID(row_id);
    //            // txt_enmoalf.Text = dt.name;
    //            //trsave.Visible = true;
    //            trtrgma.Visible = true;
    //            //tbl_translate.Visible = true;
    //            Button2.Visible = false;
    //            // tbl_all.Visible = false;
    //        }
    //    }
    //}
    //protected void btn_translate2_Click(object sender, EventArgs e)
    //{
    //    Button btn = (Button)gview_moalf.FindControl("btn_translate");
    //    btn.CausesValidation = false;
    //    btn.ValidationGroup = "F";


    //    if (content_type.Value != "0")
    //    {
    //        if (content_id.Value != "0")
    //            row_id = CDataConverter.ConvertToInt(((Button)sender).CommandArgument);
    //        myRowIndex1.Value = ((Button)sender).CommandName;
    //        if (row_id > 0)
    //        {

    //            for (int i = 0; i < gview_moalf.Rows.Count; i++)
    //            {
    //                gview_moalf.Rows[i].BackColor = System.Drawing.Color.White;
    //            }
    //            gview_moalf.Rows[CDataConverter.ConvertToInt(myRowIndex1.Value)].BackColor = System.Drawing.Color.Lavender;
    //            authors_details_DT dt = authors_details_DB.SelectByID(row_id);
    //            // txt_enmoalf.Text = dt.name;
    //            //trsave.Visible = true;
    //            trtrgma.Visible = true;
    //            //tbl_translate.Visible = true;
    //            Button2.Visible = false;
    //            // tbl_all.Visible = false;
    //        }
    //    }
    //}
    
}
