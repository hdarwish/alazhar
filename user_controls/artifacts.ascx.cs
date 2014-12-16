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
using System.Reflection;
using System.Text.RegularExpressions;

public partial class masterpage_artifacts : System.Web.UI.UserControl
{

    artifacts_DT obj = new artifacts_DT();
    artifacts_details_DT obj_details = new artifacts_details_DT();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (content_id.Value != "")
        {
                getData();
                fillcheck_periods();
                fillcontrol();
                filldrop_raw();
                fillstyle();
                fillcolor();
                filltech();
                
                invisible();
                visible();
                set_example_label();

            }
           
           
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {
                uploadfile.Enabled = false;
                Dimmed();
                Enabled();
                
            }
            if (Session["user_type"].ToString() == "5")
            {
                //drop_char.Enabled = false;
                //drop_author.Enabled = false;
                //drop_role.Enabled = false;
                //drop_type.Enabled = false;
                //txt_art_title.ReadOnly = true;
                Button1.Visible = false;
                uploadfile.Enabled = false;
                Dimmed();



            }
           // lblpagetitle.Text = lblelemnt.Text;
        }

    
    //private void filllang()
    //{
    //    documents_details_DT doc_dobj = new documents_details_DT();
    //    doc_dobj = documents_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
    //    languages_DT obj = new languages_DT();
    //    DataTable lang_dt = languages_DB.SelectAll();

    //    drop_techinque.DataSource = lang_dt;
    //    drop_techinque.DataBind();
    //    ListItem litem = new ListItem("-- اختر اللغة  --", "0");
    //    drop_techinque.Items.Insert(0, litem);
    //    if (doc_dobj.doc_lang != "" )
    //    {
    //        string id = doc_dobj.doc_lang;
    //        drop_techinque.Items.FindByText(id).Selected = true;


    //    }
    //    else
    //    {
    //        litem.Selected = true;

    //    }
    //}
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
    private void filldrop_raw()
    {

        //doc_dobj = artifacts_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));

        raw_material_DT obj_dt = new raw_material_DT();
        DataTable dt = raw_material_DB.SelectAll();
        drop_raw.DataSource = dt;
        drop_raw.DataBind();
        ListItem litem = new ListItem("-- اختر مادة الصنع--", "0");
        drop_raw.Items.Insert(0, litem);
        if (obj.material_id != 0)
        {
            string id = obj.material_id.ToString();
            drop_raw.Items.FindByValue(id).Selected = true;
        }
        else
        {
            litem.Selected = true;
        }
    }

    private void fillstyle()
    {

        obj = artifacts_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        styles_DT obj_dt = new styles_DT();
        DataTable dt = styles_DB.SelectByContent_Type(5);
        drop_style.DataSource = dt;
        drop_style.DataBind();
        ListItem litem = new ListItem("-- اختر نوع القطعة --", "0");
        drop_style.Items.Insert(0, litem);
        if (obj.style_id != 0)
        {
            string id = obj.style_id.ToString();
            drop_style.Items.FindByValue(id).Selected = true;
        }
        else
        {
            litem.Selected = true;
        }
    }
    private void fillcolor()
    {
        DataTable style_dt = colors_DB.SelectAll();
        drop_color.DataSource = style_dt;
        drop_color.DataBind();
        ListItem litem = new ListItem("-- اختر لون القطعة  --", "0");
        drop_color.Items.Insert(0, litem);
        if (obj.color_id != 0)
        {
            string id = obj.color_id.ToString();
            drop_color.Items.FindByValue(id).Selected = true;
        }
        else
        {
            litem.Selected = true;
        }
    }


    private void filltech()
    {
        DataTable style_dt = techniques_DB.SelectAll();
        drop_techinque.DataSource = style_dt;
        drop_techinque.DataBind();
        ListItem litem = new ListItem("-- اختر الأسلوب الفني  --", "0");
        drop_techinque.Items.Insert(0, litem);
        if (obj.technique_id != 0)
        {
            string id = obj.technique_id.ToString();
            drop_techinque.Items.FindByValue(id).Selected = true;
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

    private void getData()
    {
        obj = artifacts_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        obj_details = artifacts_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));


    }
    public void Dimmed()
    {
        //Class1 clss = new Class1();
        //clss.Dimmed();
        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblartif.Rows)
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
    public void invisible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[19];
            arrv[0] = "trtitle";
            arrv[1] = "trspecial";
            arrv[2] = "trbrief";
            arrv[3] = "trtdesc";
            arrv[4] = "trnotes";
            arrv[5] = "trmaker";
            arrv[6] = "trtype";
            arrv[7] = "trcolor";
            arrv[8] = "trraw";
            arrv[9] = "trtags";
            arrv[10] = "trperiods";
            arrv[11] = "trpicture";
            arrv[12] = "trcolectorname";
            arrv[13] = "trrevisionname";
           
            arrv[14] = "trdimension";
            arrv[15] = "trdimater";
            arrv[16] = "trtechinque";
            arrv[17] = "trperiods1";
            arrv[18] = "trorg";
           
       
            
            

            for (int i = 0; i < 19; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                if (tr != null)
                    tr.Visible = false;


            }
        }

    }
    public void visible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[7];
            arrv[0] = "trbrief";
            arrv[1] = "trtdesc";
            arrv[2] = "trmaker";
            arrv[3] = "trorg";
            arrv[4] = "trnotes";
            arrv[5] = "trtags";
            arrv[6] = "file_tr";
            for (int i = 0; i < 7; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;

            }
            //foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblartif.Rows)
            //{
            //    foreach (Control ctr in r.Cells)
            //    {
            //        foreach (Control control in ctr.Controls)
            //        {
            //            if (control.GetType().ToString() == "System.Web.UI.WebControls.DropDownList")
            //            {

            //                ((DropDownList)control).Enabled = false;
            //            }


            //            else if (control.GetType().ToString() == "System.Web.UI.WebControls.RadioButtonList")
            //            {

            //                ((RadioButtonList)control).Enabled = false;
            //            }


            //        }
            //    }
            //}
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
                }
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
                if (brief_desc.Value == "" || details_desc.Value == "" )
                {
                    Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('يجب إدخال الوصف التفصيلى والوصف المختصر ')</script>");
                    return;
                }
                obj.id = CDataConverter.ConvertToInt(content_id.Value);
                obj.highlight = CDataConverter.ConvertToInt(chk_site.Checked);
                obj.highlight_panorama  = CDataConverter.ConvertToInt(chk_pan.Checked);
                obj.weight = txt_wight.Text;
                obj.width = txt_width.Text;
                obj.length = txt_length.Text;
                obj.diameter = txt_dimater.Text;
                obj.perimeter = txt_perimeter.Text;
                obj.height = txt_height.Text;
                obj.city = txt_city.Text;
                obj.country = txt_country.Text;
                obj.save_no = txt_save_no.Text;
                obj.source_name = txt_org.Text;
                obj.source_notes = txt_org_notes.Text;
              
                obj.color_id = CDataConverter.ConvertToInt(drop_color.SelectedValue);
                obj.era_notes = "";
                obj.material_id = CDataConverter.ConvertToInt(drop_raw.SelectedValue);
                obj.style_id = CDataConverter.ConvertToInt(drop_style.SelectedValue);
                obj.technique_id = CDataConverter.ConvertToInt(drop_techinque.SelectedValue);
               
                string periods="";
                for(int i=0; i<chk_periods.Items.Count;i++)
                {
                    if(chk_periods.Items[i].Selected==true)
                    {
                           periods+=chk_periods.Items[i].Value + ",";
                    }
                }
                if (periods != "")
                { 
                    
                    //if (multiper.Length > 1)
                    //{
                        obj.period_id_multi = periods;
                    //}
            
                }
            
            artifacts_DB.Save(obj);
           
            obj_details.artifact_id = CDataConverter.ConvertToInt(content_id.Value);
            obj_details.start_date = txt_date.Text;
            obj_details.location = "";
            obj_details.location_code = "";
            obj_details.make_date = "";
            obj_details.period_notes = "";
            obj_details.related_art_date = "";
           
            obj_details.related_event = "";
            obj_details.related_event_type = "";
            obj_details.related_loc_type = "";
            obj_details.related_objectives = "";
            obj_details.related_obj_type = "";
            obj_details.end_date = txt_hdate.Text;
            obj_details.save_org  = "";
            obj_details.save_org_no = "";
            obj_details.maker_name = txt_maker.Text;
            obj_details.notes = txt_notes.Text;
            obj_details.content_type = 5;
            obj_details.data_entry_name = "";
            obj_details.data_revision_name = "";
           
            obj_details.lang_id = menus_update.get_current_lang();
            obj_details.artifact_brief = brief_desc.Value;
            obj_details.artifact_details = details_desc.Value;
            obj_details.keywords = txt_tags.Text;
            obj_details.data_collector_name = txtFormDataColectorName.Text;
            obj_details.data_revision_name = txtFormDataRevisionName.Text;
            obj_details.form_pic_state = CDataConverter.ConvertToInt(rblFormImage.SelectedValue);
            int res = artifacts_details_DB.Save(obj_details);
            if (res > 0)
            { ShowAlertMessage("لقد تم الحفظ بنجاح"); }
            log(2); 
           }
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
    public void fillcontrol()
    { 
        if (obj.highlight == 1)
           chk_site.Checked = true;
        else chk_site.Checked = false;
        if (obj.highlight_panorama == 1)
            chk_pan.Checked = true;
        else chk_pan.Checked = false;
        txt_wight.Text = obj.weight;
        txt_width.Text = obj.width;
        txt_length.Text = obj.length;
        txt_dimater.Text = obj.diameter ;
        txt_perimeter.Text = obj.perimeter;
        txt_height.Text = obj.height;
        txt_city.Text = obj.city ;
         txt_country.Text = obj.country ;
         txt_save_no.Text = obj.save_no.ToString();
         txt_org.Text = obj.source_name;
        txt_org_notes.Text = obj.source_notes ;
        
        if (obj.period_id_multi != null && obj.period_id_multi != "")
        {
            String[] temp = obj.period_id_multi.ToString().Split(',');
            if (temp.Length>0)
            {
                for (int i = 0; i < chk_periods.Items.Count; i++ )
                {
                    for(int j = 0; j < temp.Length; j++)
                    {
                        if (chk_periods.Items[i].Value == temp[j])
                        {
                            chk_periods.Items[i].Selected = true;
                        }
                    }
                }
            }
        }
        txt_date.Text = obj_details.start_date;
        txt_hdate.Text = obj_details.end_date ;
        txt_maker.Text=  obj_details.maker_name ;
        txt_notes.Text = obj_details.notes ;
        txt_art_title.Text = obj_details.title;
        brief_desc.Value = obj_details.artifact_brief  ;
        details_desc.Value = obj_details.artifact_details ;
        txt_tags.Text = obj_details.keywords  ;
        txtFormDataColectorName.Text = obj_details.data_collector_name  ;
        txtFormDataRevisionName.Text = obj_details.data_revision_name  ;
        rblFormImage.SelectedValue = obj_details.form_pic_state.ToString ();
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
            if (txt_hdate.Text != "")
            {
                if (security_issues.check_date(txt_hdate.Text) == false)
                {
                    isValid = false;
                    lblerror.Visible = true;
                    //lblError2.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "(تاريخ الصنع الهجري غير صحيح يجب أن يكون( سنة أو (يوم/شهر/سنة)";
                    goto returnPart;
                }
            }

            if (txt_date.Text != "")
            {
                if (security_issues.check_date(txt_date.Text) == false)
                {
                    isValid = false;
                    lblerror.Visible = true;
                    //lblError3.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "(تاريخ الصنع الميلادي غير صحيح يجب أن يكون( سنة أو (يوم/شهر/سنة)";
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
            ShowAlertMessage("يجب إدخال العصر الذي تتناوله/ ترتبط به القطعة المتحفية");
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
        if (drop_style.SelectedIndex > 0)
        {
            txt_m_other.Enabled = false;
        }
        else txt_m_other.Enabled = true;
    }
    protected void drop_docstype_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drop_color.SelectedIndex > 0)
        {
            txt_type_other.Enabled = false;
        }
        else txt_type_other.Enabled = true;
    }
    protected void drop_techinque_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drop_techinque.SelectedIndex > 0)
        { other.Enabled = false; }
        else other.Enabled = true;

    }
    protected void drop_raw_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        