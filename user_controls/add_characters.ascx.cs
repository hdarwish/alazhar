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
using System.IO;

public partial class masterpage_add_characters : System.Web.UI.UserControl
{
    //public int content_id;
    // public int content_type;
    characters_DT char_dt = new characters_DT();
    characters_details_DT dt = new characters_details_DT();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { }
        if (content_id.Value != "")
        {
            getData();
            fillcheck_periods();
            fillcontrol();
            fillchar_type();
            
            invisible();
            visible();
            //set_example_label();

            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {
                Dimmed();
                Enabled();
            }
            if (Session["user_type"].ToString() == "5")
            {
                Button1.Visible = false;
                Dimmed();
            }

        }
    }
    private void getData()
    {
        char_dt = characters_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        dt = characters_details_DB.SelectBychar_ID(CDataConverter.ConvertToInt(content_id.Value),menus_update.get_current_lang());
        //theses_details = theses_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));

    }
    //private void set_example_label()
    //{

    //    if (CDataConverter.ConvertToInt(content_id.Value) > 0 && CDataConverter.ConvertToInt(content_type.Value) > 0)
    //    {
    //        if (menus_update.get_current_lang() == 1)
    //            Label55.Text = content_type.Value + "_" + content_id.Value + "." + "doc/docx/pdf";
    //        else if (menus_update.get_current_lang() == 2)
    //            Label55.Text = content_type.Value + "_" + content_id.Value + "_en." + "doc/docx/pdf";
    //        else if (menus_update.get_current_lang() == 3)
    //            Label55.Text = content_type.Value + "_" + content_id.Value + "_fr." + "doc/docx/pdf";
    //    }
    //    else { Label55.Visible = false; }
    //}
    public void invisible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[24];
            arrv[0] = "trcolectorname";
            arrv[1] = "trname";
            arrv[2] = "trspecial";
            arrv[3] = "trchartype";
            arrv[4] = "trothername";
            arrv[5] = "trrevisionname";
            arrv[6] = "trtitles";
            arrv[7] = "trhbirthdate";
            arrv[8] = "trbirthdate";
            arrv[9] = "trhdeathdate";
            arrv[10] = "trdeathdate";
            arrv[11] = "trdetails";
            arrv[12] = "trbdetails";
            arrv[13] = "trscientific";
            arrv[14] = "trworklife";
            arrv[15] = "tractivities";
            arrv[16] = "trawsma";
            arrv[17] = "trachieve";
            arrv[18] = "trwhtwritten";
            arrv[19] = "trnotes";
            arrv[20] = "trtags";
            arrv[21] = "trperiods";
            arrv[22] = "file_tr";
            arrv[23] = "trimage";


            for (int i = 0; i < 24; i++)
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
            string[] arrv = new string[14];
            arrv[0] = "trname";
            arrv[1] = "trdetails";
            arrv[2] = "trbdetails";
            arrv[3] = "trscientific";
            arrv[4] = "trworklife";
            arrv[5] = "tractivities";
            arrv[6] = "trawsma";
            arrv[7] = "trachieve";
            arrv[8] = "trwhtwritten";
            arrv[9] = "trnotes";
            arrv[10] = "trtags";
            arrv[11] = "trothername";
            arrv[12] = "trtitles";
            arrv[13] = "file_tr";
           //arrv[13] = "trdeathdate";
            //arrv[14] = "trhdeathdate";
            //arrv[15] = "trhbirthdate";
            //arrv[16] = "trbirthdate"; 
               

            for (int i = 0; i < 14; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;

            }
        }
    }
    private void fillchar_type()
    {
        char_types_DT obj = new char_types_DT();
        DataTable obj_db = char_types_DB.SelectAll();
        rad_char_type.DataSource = obj_db;
        //chk_char_type.DataTextField = "title_ar";
        //chk_char_type.DataValueField = "id";
        rad_char_type.DataBind();

    }
    protected Boolean vaildfile()
    {
        bool vaild = false;
        string filename = uploadfile.FileName;
        if (menus_update.get_current_lang() == 1)
        {
            if (char_dt.form_file == "")
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
            else
            {
                vaild = true;
                return vaild;
            }
        }
        else if (menus_update.get_current_lang() == 2)
        {
            if (char_dt.form_file_en == "")
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
	    else
            {
                vaild = true;
                return vaild;
            }
        }
        else if (menus_update.get_current_lang() == 3)
        {
            if (char_dt.form_file_fr == "")
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
	    else
                {
                    vaild = true;
                    return vaild;
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

        string savePath = MapPath("~") + "\\images\\sheikhs\\";

        string fileName = uploadfile.FileName;
        savePath += fileName;
        uploadfile.SaveAs(savePath);
        if (menus_update.get_current_lang() == 1) 
        char_dt.form_file = fileName;
        else if (menus_update.get_current_lang() == 2 )
            char_dt.form_file_en = fileName;
        else if (menus_update.get_current_lang() == 3)
            char_dt.form_file_fr = fileName;



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
        //Class1 clss = new Class1();
        //clss.Dimmed();


        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblchar.Rows)
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
                     
                   
                 // else if(control.GetType().ToString() == "System.Web.UI.HtmlTextWriterAttribute.ReadOnly" )

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
                    if (cont_fields.Rows[x]["type"].ToString() == "FileUpload")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        FileUpload fupload = (FileUpload)this.FindControl(id);
                        fupload.Enabled = true;
                        fupload.ForeColor = System.Drawing.Color.Red;
                        fupload.BorderColor = System.Drawing.Color.Red;
                        fupload.Focus();


                    }
                     
                    //if (cont_fields.Rows[x]["type"].ToString() == "Button")
                    //{
                    //    id = cont_fields.Rows[x]["control_name"].ToString();
                    //    Button btn = (Button)this.FindControl(id);
                    //    btn.Visible = true;
                    //    btn.ForeColor = System.Drawing.Color.Red;



                    //}
                }
                
            }
            //comment nora //
            //string xx = txt_scientific_life.GetType().ToString();
        }
    }
    public void save()
    {
        if (CheckValidate())
        {
            if (vaildfile())
            {
                
                //char_dt.period_id = CDataConverter.ConvertToInt(chk_periods.SelectedValue);
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
                    char_dt.period_id_multi = periods;
                    //}

                }
                SqlParameter[] sqlParam = new SqlParameter[] { new SqlParameter("@id",CDataConverter.ConvertToInt(content_id.Value)),
                new SqlParameter ("@char_type",CDataConverter.ConvertToInt(rad_char_type.SelectedValue)) , 
                new SqlParameter ("@highlight",CDataConverter.ConvertToInt(chk_highlight.Checked)) ,
                new SqlParameter ("@highlight_panorama",CDataConverter.ConvertToInt(chk_pano.Checked)),
                new SqlParameter ("@form_file",char_dt.form_file ),
                new SqlParameter ("@form_file_en",char_dt.form_file_en ),
                new SqlParameter ("@form_file_fr",char_dt.form_file_fr ),
                new SqlParameter ("@period_id_multi",char_dt.period_id_multi  ),
                new SqlParameter ("@rblFormImage",CDataConverter.ConvertToInt(rblFormImage.SelectedValue)  )
                };

                int res = DatabaseFunctions.UpdateData(sqlParam, "characters_update");
                 
		characters_details_DT obj = new characters_details_DT();
                obj.char_id = CDataConverter.ConvertToInt(content_id.Value);
                obj.titles = txt_titles.Text;
                obj.other_names = txt_other_name.Text;
                obj.name = txt_name.Text;
                obj.hbirth_date = txt_hbirth_date.Text;
                obj.birth_date = txt_birth_date.Text;
                obj.hdeath_date = txt_hdeath_date.Text;
                obj.death_date = txt_death_date.Text;
                obj.char_details = txt_char_details.Value;
                obj.birth_details = txt_birth_details.Value;
                obj.scientific_life = txt_scientific_life.Value;
                obj.working_life = txt_working_life.Value;
                obj.activities = txt_activities.Value;
                obj.notes = txt_notes.Text;
                obj.keywords = txt_keywords.Text;
                obj.written_about = txt_written_about.Value;
                obj.data_collector_name = txtFormDataColectorName.Text;
                obj.data_revision_name = txtFormDataRevisionName.Text;
                obj.form_pic_state = CDataConverter.ConvertToInt(rblFormImage.SelectedValue);
                obj.lang_id = menus_update.get_current_lang();
                obj.char_brief = "";
                obj.mashyakha_azhar = "";
                
                characters_details_DB.Update(obj);
//ShowAlertMessage(res.ToString()  + "," + res2.ToString()  );
                if (txt_achiev.Value != "")
                {
                    DataTable achev_edit_dt = achievements_DB.SelectByCharID(CDataConverter.ConvertToInt(content_id.Value));
                    achievements_details_DT obj_achve_details = achievements_details_DB.SelectBy_CharID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());
                    //achievements_details_DT obj_achve_details = new achievements_details_DT();
                    if (achev_edit_dt != null && achev_edit_dt.Rows.Count > 0)
                    { obj_achve_details.id = CDataConverter.ConvertToInt(achev_edit_dt.Rows[0]["id"].ToString()); }
                    else { obj_achve_details.id = 0; }
                    obj_achve_details.char_id = CDataConverter.ConvertToInt(content_id.Value);
                    obj_achve_details.details = txt_achiev.Value;
                    obj_achve_details.lang_id = menus_update.get_current_lang();
                    achievements_details_DB.Save(obj_achve_details);

                }
                if (txt_awesma.Value != "")
                {
                    DataTable awsema_dt = awsema_details_DB.select_bychar_id(CDataConverter.ConvertToInt(content_id.Value));

                    awsema_details_DT obj_aws_det = new awsema_details_DT();
                    if (awsema_dt.Rows.Count > 0)
                    { obj_aws_det.id = CDataConverter.ConvertToInt(awsema_dt.Rows[0]["id"].ToString()); }
                    else { obj_aws_det.id = 0; }
                    obj_aws_det.char_id = CDataConverter.ConvertToInt(content_id.Value);
                    obj_aws_det.lang_id = menus_update.get_current_lang();
                    obj_aws_det.details = txt_awesma.Value;
                    awsema_details_DB.Save(obj_aws_det);
                }


                ShowAlertMessage("لقد تم الحفظ بنجاح");
               
                if (char_dt.form_file != "" && menus_update.get_current_lang() == 1)
                {
                    
                    id_href.Visible = true;
                    id_href.HRef = "~/images/sheikhs/" + char_dt.form_file;
                }
                else if (char_dt.form_file_en != "" && menus_update.get_current_lang() == 2)
                {
                   
                    id_href.Visible = true;
                    id_href.HRef = "~/images/sheikhs/" + char_dt.form_file_en;
                }
                else if (char_dt.form_file_fr != "" && menus_update.get_current_lang() == 3)
                {                    
                    id_href.Visible = true;
                    id_href.HRef = "~/images/sheikhs/" + char_dt.form_file_fr;
                }
                log(2);
            }
            
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
    public void fillcontrol()
    {
        if (char_dt.highlight == 1)
            chk_highlight.Checked = true;
        else chk_highlight.Checked = false;
        if (char_dt.highlight_panorama == 1)
            chk_pano.Checked = true;
        else chk_pano.Checked = false;
        if (char_dt.char_type > 0)
        { rad_char_type.SelectedValue = char_dt.char_type.ToString(); }
        //if (char_dt.period_id > 0)
        //{ chk_periods.SelectedValue = char_dt.period_id.ToString(); }
        if (char_dt.period_id_multi != null && char_dt.period_id_multi != "")
        {
            String[] temp = char_dt.period_id_multi.ToString().Split(',');
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

        txt_name.Text = dt.name;
        txt_activities.Value = dt.activities;
        txt_birth_details.Value = dt.birth_details;
        txt_char_details.Value =  dt.char_details;
        txt_birth_date.Text = dt.birth_date;
        txt_hbirth_date.Text = dt.hbirth_date;
        txt_death_date.Text = dt.death_date;
        txt_hdeath_date.Text = dt.hdeath_date;
        txt_other_name.Text = dt.other_names;
        txt_scientific_life.Value = dt.scientific_life;
        txt_working_life.Value = dt.working_life;
        txt_written_about.Value = dt.written_about;
        txt_titles.Text = dt.titles;
        txt_notes.Text = dt.notes;
        txt_keywords.Text = dt.keywords;
        txtFormDataColectorName.Text = dt.data_collector_name;
        txtFormDataRevisionName.Text = dt.data_revision_name;
        rblFormImage.SelectedValue = char_dt.rblFormImage.ToString();

        achievements_details_DT achvd_dt = achievements_details_DB.SelectBy_CharID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());

        if (achvd_dt != null)
        { txt_achiev.Value = achvd_dt.details; }

        DataTable wesams = awsema_details_DB.select_bychar_id(CDataConverter.ConvertToInt(content_id.Value));
        if (wesams.Rows.Count > 0)
        {
            txt_awesma.Value = wesams.Rows[0]["details"].ToString();
        }

        if (menus_update.get_current_lang()==1)
        {
            if (char_dt.form_file != "")
            {

                id_href.Visible = true;
                id_href.HRef = "~/images/sheikhs/" + char_dt.form_file;
            }
            else id_href.Visible = false;

        }
        else if (menus_update.get_current_lang() == 2)
        {
            if (char_dt.form_file_en != "")
            {
                id_href.Visible = true;
                id_href.HRef = "~/images/sheikhs/" + char_dt.form_file_en;
            }
            else id_href.Visible = false;
        }
        else if (menus_update.get_current_lang() == 3)
        {
            if (char_dt.form_file_fr != "")
            {
                id_href.Visible = true;
                id_href.HRef = "~/images/sheikhs/" + char_dt.form_file_fr;
            }
            else id_href.Visible = false;
        }
        else id_href.Visible = false;



    }

    protected void lnk_Click(object sender, EventArgs e)
    {
        //characters_DT char_dt = characters_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        //lnk.PostBackUrl  = "~/images/sheikhs/" + char_dt.form_file;

    }


    private bool CheckValidate()
    {
        bool isValid = true;
        if (menus_update.get_current_lang() == 1)
        {
           /* if (txt_hbirth_date.Text != "")
            {

                if (security_issues.check_date(txt_hbirth_date.Text) == false)
                {
                    isValid = false;
                    lblerror.Visible = true;
                    lblerror.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "(تاريخ الميلاد غير صحيح يجب أن يكون( سنة أو (يوم/شهر/سنة)";
                    goto returnPart;

                }
            }
            if (txt_birth_date.Text != "")
            {
                if (security_issues.check_date(txt_birth_date.Text) == false)
                {
                    isValid = false;
                    lblerror.Visible = true;
                    lblerror.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "(تاريخ الميلاد غير صحيح يجب أن يكون( سنة أو (يوم/ شهر/سنة)";
                    goto returnPart;
                }

            }

            if (txt_hdeath_date.Text != "")
            {
                if (security_issues.check_date(txt_hdeath_date.Text) == false)
                {
                    isValid = false;
                    lblerror.Visible = true;
                    lblerror.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "(التاريخ غير صحيح يجب أن يكون( سنة أو (يوم/شهر/سنة)";
                    goto returnPart;
                }
            }
            else
            {
                isValid = false;
                lblerror.Visible = true;
                lblerror.ForeColor = System.Drawing.Color.Red;
                lblerror.Text = "يجب إدخال تاريخ الوفاة الهجري";
                goto returnPart;
            }

            if (txt_death_date.Text != "")
            {
                if (security_issues.check_date(txt_death_date.Text) == false)
                {
                    isValid = false;
                    lblerror.Visible = true;
                    lblerror.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "(التاريخ غير صحيح يجب أن يكون( سنة أو (يوم/شهر/سنة)";
                    goto returnPart;
                }
            }
            else
            {
                isValid = false;
                lblerror.Visible = true;
                lblerror.ForeColor = System.Drawing.Color.Red;
                lblerror.Text = "يجب إدخال تاريخ الوفاة الميلادي";
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
            ShowAlertMessage("يجب إدخال العصر الذي تنتمي إليه الشخصية");
            goto returnPart;
	*/
            
        }
        if (txt_char_details.Value == "" || txt_scientific_life.Value == "" || txt_achiev.Value == "")
        {
            isValid = false;
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('يجب إدخال نبذة عن الشخصية والحياة العلمية والثقافية وأهم الإنجازات ')</script>");

            goto returnPart;
        }

    
    returnPart:
        return isValid;

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

}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           