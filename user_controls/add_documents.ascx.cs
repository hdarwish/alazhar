﻿using System;
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

public partial class masterpage_add_documents : System.Web.UI.UserControl
{
    documents_DT obj = new documents_DT();
    documents_details_DT obj_dt = new documents_details_DT();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (content_id.Value != "")
        {

            if (content_type.Value == "8")
            {
                fillmaterial();
                filltypes();
                filllang();
                invisible();
                visible();
            }
            getdata();
            fillcheck_periods();
            fillcontrol();
            set_example_label();
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {

                Dimmed();
                Enabled();
            }
            if (Session["user_type"].ToString() == "4")
            {
                txt_art_title.ReadOnly = true;
            }
            if (Session["user_type"].ToString() == "5")
            {
                Dimmed();
                Button1.Visible = false;

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
    private void filllang()
    {
        documents_details_DT doc_dobj = new documents_details_DT();
        doc_dobj = documents_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());
        languages_DT obj = new languages_DT();
        DataTable lang_dt = languages_DB.SelectAll();

        drop_lang.DataSource = lang_dt;
        drop_lang.DataBind();
        ListItem litem = new ListItem("-- اختر اللغة  --", "0");
        drop_lang.Items.Insert(0, litem);
        if (doc_dobj.doc_lang != "")
        {
            if (doc_dobj.doc_lang != null)
            {
                string id = doc_dobj.doc_lang;
                drop_lang.Items.FindByText(id).Selected = true;
            }

        }
        else
        {
            litem.Selected = true;

        }
    }
    private void fillmaterial()
    {
        documents_details_DT doc_dobj = new documents_details_DT();
        doc_dobj = documents_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());
        materials_DT obj_dt = new materials_DT();
        DataTable dt = materials_DB.SelectByContent_Type(8);
        drop_material.DataSource = dt;
        drop_material.DataBind();
        ListItem litem = new ListItem("-- اختر الشكل المادي --", "0");
        drop_material.Items.Insert(0, litem);
        if (doc_dobj.material_type != "")
        {
            if (doc_dobj.material_type != null)
            {
                string id = doc_dobj.material_type;
                drop_material.Items.FindByText(id).Selected = true;
            }
        }
        else
        {
            litem.Selected = true;
        }
    }
    private void filltypes()
    {
        documents_details_DT doc_dobj = new documents_details_DT();
        doc_dobj = documents_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());
        styles_DT obj_sdt = new styles_DT();
        DataTable style_dt = styles_DB.SelectByContent_Type(8);
        drop_docstype.DataSource = style_dt;
        drop_docstype.DataBind();
        ListItem litem = new ListItem("-- اختر مضمون الوثيقة --", "0");
        drop_docstype.Items.Insert(0, litem);
        if (doc_dobj.docs_type != "")
        {
            if (doc_dobj.docs_type != null)
            {
                string id = doc_dobj.docs_type;
                drop_docstype.Items.FindByText(id).Selected = true;
            }
        }
        else
        {
            litem.Selected = true;
        }
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
        //Class1 clss = new Class1();
        //clss.Dimmed();

        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tbldoc.Rows)
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
    //public void dimmed()
    //{
    //    if (Session["user_type"] != null && Session["user_type"].ToString() == "5")
    //    {

    //        txt_creater.ReadOnly =
    //        txt_creater_no.ReadOnly =
    //        txt_hdate.ReadOnly =
    //        txt_date.ReadOnly =
    //        txt_org.ReadOnly =
    //        txt_country.ReadOnly =
    //        txt_city.ReadOnly =
    //        txt_save_no.ReadOnly =
    //        txt_m_other.ReadOnly =
    //        txt_org_notes.ReadOnly = true;
    //        drop_material.Enabled =
    //        chk_pan.Enabled =
    //        drop_docstype.Enabled =
    //        drop_lang.Enabled =
    //        CheckBox1.Enabled =
    //        chk_periods.Enabled =
    //        rblFormImage.Enabled = false;

    //    }
    //    if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
    //    {

    //        txt_creater.ReadOnly =
    //        txt_creater_no.ReadOnly =
    //        txt_hdate.ReadOnly =
    //        txt_date.ReadOnly =
    //        txt_org.ReadOnly =
    //        txt_country.ReadOnly =
    //        txt_city.ReadOnly =
    //        txt_save_no.ReadOnly =
    //        txt_m_other.ReadOnly =
    //        txt_org_notes.ReadOnly = true;
    //        drop_material.Enabled =
    //        chk_pan.Enabled =
    //        drop_docstype.Enabled =
    //        drop_lang.Enabled =
    //        CheckBox1.Enabled =
    //        chk_periods.Enabled =
    //        rblFormImage.Enabled = false;
    //    }

    //}
    public void invisible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[19];
            arrv[0] = "trtitle";
            arrv[1] = "trspecial";
            arrv[2] = "trpublish";
            arrv[3] = "trcreater";
            arrv[4] = "trlang";
            arrv[5] = "trcreaterno";
            arrv[6] = "trdate";
            arrv[7] = "trsaveorg";
            arrv[8] = "trmaterial";
            arrv[9] = "trtags";
            arrv[10] = "trperiods";
            arrv[11] = "trpicture";
            arrv[12] = "trcolectorname";
            arrv[13] = "trrevisionname";
            arrv[14] = "file_tr";
            arrv[15] = "trdocstype";
            arrv[16] = "trsum";
            arrv[17] = "trpageno";
            arrv[18] = "trperiods2";


            for (int i = 0; i < 19; i++)
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
            string[] arrv = new string[6];
            arrv[0] = "trtitle";
            // arrv[1] = "trcreater";
            //arrv[2] = "trdate";
            // arrv[2] = "trcreaterno";
            arrv[1] = "trsaveorg";
            arrv[2] = "trnotes";
            arrv[3] = "trtags";
            arrv[4] = "file_tr";
            arrv[5] = "trcreater";
            trtitle2.Visible = true;
            for (int i = 0; i < 6; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;

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
                        chbox.Focus();


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
                        drop.Focus();


                    }

                    if (cont_fields.Rows[x]["type"].ToString() == "FileUpload")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        FileUpload upfile = (FileUpload)this.FindControl(id);
                        upfile.Enabled = true;
                        upfile.BorderColor = System.Drawing.Color.Red;
                        upfile.ForeColor = System.Drawing.Color.Red;
                        upfile.Focus();


                    }
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        save();
        
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
    public void save()
    {
        //documents_DT obj = documents_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        string Filename = "";
        if (CheckValidate())
        {
            if (vaildfile())
            {
                obj.id = CDataConverter.ConvertToInt(content_id.Value);
                
                obj.highlight = CDataConverter.ConvertToInt(chk_site.Checked);
                obj.highlight_panorama = CDataConverter.ConvertToInt(chk_pan.Checked);
                obj.publish_date = txt_date.Text;
                obj.publish_hdate = txt_hdate.Text;
                obj.publish_or_not = CDataConverter.ConvertToInt(rad_publish.SelectedValue);
                
                obj.creater_no = txt_creater_no.Text;
                obj.pages_from = CDataConverter.ConvertToInt(txt_from.Text);
                obj.pages_no = CDataConverter.ConvertToInt(txt_no.Text);
                obj.pages_to = CDataConverter.ConvertToInt(txt_to.Text);
                obj.content_type = 8;
                obj.doc_type = 3;
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
               
               
                obj_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
                obj_dt.title = txt_art_title.Text;
                obj_dt.brief = "w";
                obj_dt.organization_save = txt_org.Text;
                obj_dt.save_no = txt_save_no.Text;
                obj_dt.city = txt_city.Text;
                obj_dt.resource = txt_creater.Text;
                obj_dt.country_name = txt_country.Text;
                obj_dt.save_notes = txt_org_notes.Text;
                obj_dt.docs_type = drop_docstype.SelectedItem.Text;
                obj_dt.material_type = drop_material.SelectedItem.Text;
                obj_dt.lang_id = menus_update.get_current_lang();
                obj_dt.doc_lang = drop_lang.SelectedItem.Text;
                obj_dt.FromDocumented= txt_othertitle.Text;
                obj_dt.docs_sum = CheckBox1.Checked;
                obj_dt.doc_lang2 = CDataConverter.ConvertToInt(drop_lang.SelectedValue);
                obj_dt.material_type2 = CDataConverter.ConvertToInt(drop_material.SelectedValue);
                obj_dt.notes = txt_notes.Text;
                obj_dt.keywords = txt_tags.Text;
                obj_dt.docs_type2 = CDataConverter.ConvertToInt(drop_docstype.SelectedValue);
                obj_dt.data_collector_name = txtFormDataColectorName.Text;
                obj_dt.data_revision_name = txtFormDataRevisionName.Text;
                obj_dt.form_pic_state = CDataConverter.ConvertToInt(rblFormImage.SelectedValue);
                int res = documents_details_DB.Save(obj_dt);
                if (res > 0)
                {
                    ShowAlertMessage("لقد تم الحفظ بنجاح");


                    if (obj.form_file != "" && menus_update.get_current_lang() == 1)
                    {

                        id_href.Visible = true;
                        id_href.HRef = "~/images/esdarat/" + obj.form_file;
                    }
                    else if (obj.form_file_en != "" && menus_update.get_current_lang() == 2)
                    {

                        id_href.Visible = true;
                        id_href.HRef = "~/images/esdarat/" + obj.form_file_en;
                    }
                    else if (obj.form_file_fr != "" && menus_update.get_current_lang() == 3)
                    {

                        id_href.Visible = true;
                        id_href.HRef = "~/images/esdarat/" + obj.form_file_fr;
                    }
                }
                log(2);
            }
        }
    }
    public void getdata()
    {
        obj = documents_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        obj_dt = documents_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());
    }

    public void fillcontrol()
    {
        //documents_DT doc_obj = new documents_DT();

        //doc_obj = documents_DB.SelectByID(id);

        if (obj.highlight_panorama == 1)
        { chk_pan.Checked = true; }
        else chk_pan.Checked = false;
        if (obj.highlight == 1)
        { chk_site.Checked = true; }
        txt_no.Text = obj.pages_no.ToString();
        txt_from.Text = obj.pages_from.ToString();
        txt_to.Text = obj.pages_to.ToString();
        rad_publish.SelectedValue = obj.publish_or_not.ToString();
        txt_creater_no.Text = obj.creater_no;
        txt_hdate.Text = obj.publish_hdate;
        txt_date.Text = obj.publish_date;
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
        //documents_details_DT doc_dobj = new documents_details_DT();
        //doc_dobj = documents_details_DB.SelectByID(id);
        txt_art_title.Text = obj_dt.title;
        txt_othertitle.Text = obj_dt.FromDocumented;
        txtFormDataColectorName.Text = obj_dt.data_collector_name;
        txtFormDataRevisionName.Text = obj_dt.data_revision_name;
        txt_notes.Text = obj_dt.notes;
        txt_org.Text = obj_dt.organization_save;
        txt_country.Text = obj_dt.country_name;
        txt_city.Text = obj_dt.city;
        txt_save_no.Text = obj_dt.save_no;
        txt_org_notes.Text = obj_dt.save_notes;
        txt_tags.Text = obj_dt.keywords;
        txt_creater.Text = obj_dt.resource;
        rblFormImage.SelectedValue = obj_dt.form_pic_state.ToString();
        CheckBox1.Checked = obj_dt.docs_sum;
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
        if (menus_update.get_current_lang() == 1)
        {

            if (vaildfile())
            { isValid = true; }
            if (CDataConverter.ConvertToInt(drop_material.SelectedIndex) < 1 )
            {
                isValid = false;
                lblError4.Visible = true;

                lblError4.Text = "يجب اختيار الشكل المادي";
                goto returnPart;
            }
            if (CDataConverter.ConvertToInt(drop_docstype.SelectedIndex) < 1 )
            {
                isValid = false;
                lblError5.Visible = true;

                lblError5.Text = "يجب اختيار مضمون الوثيقة";
                goto returnPart;
            }
            if (CDataConverter.ConvertToInt(drop_lang.SelectedIndex) < 1 )
            {
                isValid = false;
                lblError6.Visible = true;
                lblError6.Text = "يجب اختيار اللغة ";
                goto returnPart;
            }

            for (int i = 0; i < chk_periods.Items.Count; i++)
            {
                if (chk_periods.Items[i].Selected)
                {
                    goto returnPart;
                }

            }
            isValid = false;
            ShowAlertMessage("يجب إدخال العصر الذي يتناوله/ يرتبط به الوثيقة");
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

    protected void drop_material_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (drop_material.SelectedIndex > 0)
        //{
        //    txt_m_other.Enabled = false;
        //}
        //else txt_m_other.Enabled = true;
    }
    protected void drop_docstype_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (drop_docstype.SelectedIndex > 0)
        //{
        //    txt_type_other.Enabled = false;
        //}
        //else txt_type_other.Enabled = true;
    }
    protected void drop_lang_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (drop_lang.SelectedIndex > 0)
        //{ other.Enabled = false; }
        //else other.Enabled = true;

    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        