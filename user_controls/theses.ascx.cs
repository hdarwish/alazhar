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

public partial class masterpage_theses : System.Web.UI.UserControl
{
    theses_DT theses_dt = new theses_DT();

    theses_details_DT theses_details = new theses_details_DT();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { //FillGrid(); 
        }

        if (content_id.Value != "")
        {
            getData();
            filldrop_lang();
            fillcheck_periods();
            fillcontrol();

            set_example_label();
            if (Session["user_type"] != null && Session["lang"] != null)
            {
                invisible();
                visible();
            }
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {

                //uploadfile.Enabled = false;
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
    private void set_example_label()
    {

        //if (CDataConverter.ConvertToInt(content_id.Value) > 0 && CDataConverter.ConvertToInt(content_type.Value) > 0)
        //{
        //    if (menus_update.get_current_lang() == 1)
        //        Label55.Text = content_id.Value + "_" + content_type.Value + "." + "doc/docx/pdf";
        //    else if (menus_update.get_current_lang() == 2)
        //        Label55.Text = content_type.Value + "_" + content_id.Value + "_en." + "doc/docx/pdf";
        //    else if (menus_update.get_current_lang() == 3)
        //        Label55.Text = content_type.Value + "_" + content_id.Value + "_fr." + "doc/docx/pdf";
        //}
        //else { Label55.Visible = false; }
    }
    private void getData()
    {
        theses_dt = theses_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        theses_details = theses_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));


    }
    private void filldrop_lang()
    {
        languages_DT obj = new languages_DT();
        DataTable lang_dt = languages_DB.SelectAll();

        drop_lang.DataSource = lang_dt;
        drop_lang.DataBind();
        ListItem litem = new ListItem("-- اختر اللغة --", "0");
        drop_lang.Items.Insert(0, litem);
        if (theses_details.theses_lang != "")
        {
            if (theses_details.theses_lang != null)
            {
                string id = theses_details.theses_lang;
                drop_lang.Items.FindByText(id).Selected = true;
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


    }
    public void Dimmed()
    {
        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in trthese.Rows)
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
                new SqlParameter("@lang_id",CDataConverter.ConvertToInt(menus_update.get_current_lang()))};

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
    public void invisible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            string[] arrv = new string[18];
            //arrv[0] = "trtitle";
            arrv[0] = "trRevisionName";
            arrv[1] = "trname";
            arrv[2] = "trspecial";
            arrv[3] = "trsupervisor";
            arrv[4] = "trsupervisor1";
            arrv[5] = "trsupervisor2";
            arrv[6] = "trthesestype";
            arrv[7] = "trpageno";
            arrv[8] = "trlang";
            arrv[9] = "trunversity";
            arrv[10] = "trsection";
            arrv[11] = "trcollage";
            arrv[12] = "trdate";
            arrv[13] = "trnotes";
            arrv[14] = "trtags";
            arrv[15] = "trperiods";
            arrv[16] = "trpicuter";
            arrv[17] = "trColectorName";
           
            //arrv[19] = "file_tr";
            for (int i = 0; i < 18; i++)
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
            string[] arrv = new string[7];
            arrv[0] = "trname";
            arrv[1] = "trsupervisor";
            arrv[2] = "trsupervisor1";
            arrv[3] = "trunversity";
            arrv[4] = "trnotes";
            arrv[5] = "trtags";
            arrv[6] = "file_tr";

            for (int i = 0; i < 6; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;

            }
            //foreach (System.Web.UI.HtmlControls.HtmlTableRow r in trthese.Rows)
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
                { theses_dt.highlight = 1; }
                else theses_dt.highlight = 0;
                if (chk_pan.Checked == true)
                { theses_dt.highlight_panorama = 1; }
                else { theses_dt.highlight_panorama = 0; }

                theses_dt.theses_date = txt_date.Text;
                theses_dt.theses_hdate = txt_hdate.Text;
                theses_dt.theses_type = CDataConverter.ConvertToInt(RadioButtonList1.SelectedValue);
                //theses_dt.period_id = CDataConverter.ConvertToInt(chk_periods.SelectedValue);
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
                    theses_dt.period_id_multi = periods;
                    //}

                }
                theses_dt.id = theses_DB.Save(theses_dt);

                theses_details.these_id = CDataConverter.ConvertToInt(content_id.Value);
                theses_details.title = txt_art_title.Text;


                theses_details.theses_lang2 = CDataConverter.ConvertToInt(drop_lang.SelectedValue);



                theses_details.theses_date = "";
                theses_details.theses_hdate = "";
                theses_details.keywords = txt_tags.Text;
                theses_details.notes = txt_notes.Text;
                theses_details.unversity = txt_unversity.Text;
                theses_details.section = txt_section.Text;
                theses_details.collage = txt_collage.Text;
                theses_details.searcher_name = txt_art_title0.Text;
                theses_details.supervisor_name = txt_super.Text;
                theses_details.supervisor_name1 = txt_supervisor1.Text;
                theses_details.supervisor_name2 = txt_supervisor2.Text;
                theses_details.theses_no = CDataConverter.ConvertToInt(txt_from.Text);
                theses_details.data_collector_name = txtFormDataColectorName.Text;
                theses_details.data_revision_name = txtFormDataRevisionName.Text;
                theses_details.form_pic_state = CDataConverter.ConvertToInt(rblFormImage.SelectedIndex);
                theses_details.lang_id = menus_update.get_current_lang();

                int res = theses_details_DB.Save(theses_details);
                if (res > 0)
                {
                    ShowAlertMessage("لقد تم الحفظ");
                    log(2);
                    if (menus_update.get_current_lang() == 1)
                    {
                        if (theses_dt.form_file != "")
                        { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + theses_dt.form_file; }
                        else id_href.Visible = false;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        if (theses_dt.form_file_en != "")
                        { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + theses_dt.form_file_en; }
                        else id_href.Visible = false;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        if (theses_dt.form_file_fr != "")
                        { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + theses_dt.form_file_fr; }
                        else id_href.Visible = false;
                    }
                }

                else { ShowAlertMessage("من فضلك اعد المحاولة"); }




            }
        }
    }
    public void fillcontrol()
    {
        if (theses_dt.highlight_panorama == 1)
        { chk_pan.Checked = true; }
        else chk_pan.Checked = false;
        if (theses_dt.highlight == 1)
        { chk_site.Checked = true; }
        txt_from.Text = theses_details.theses_no.ToString();
        if (theses_dt.theses_type != 0)
        { RadioButtonList1.SelectedValue = theses_dt.theses_type.ToString(); }
        //if (theses_dt.period_id != 0)
        //{ chk_periods.SelectedValue = theses_dt.period_id.ToString(); }
        if (theses_dt.period_id_multi != null && theses_dt.period_id_multi != "")
        {
            String[] temp = theses_dt.period_id_multi.ToString().Split(',');
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
        txt_date.Text = theses_dt.theses_date;
        txt_hdate.Text = theses_dt.theses_hdate;
        txt_art_title.Text = theses_details.title;
        txt_art_title0.Text = theses_details.searcher_name;
        txt_super.Text = theses_details.supervisor_name;
        txt_supervisor1.Text = theses_details.supervisor_name1;
        txt_supervisor2.Text = theses_details.supervisor_name2;
        txt_unversity.Text = theses_details.unversity;
        txt_collage.Text = theses_details.collage;
        txt_section.Text = theses_details.section;
        txt_notes.Text = theses_details.notes;
        txtFormDataColectorName.Text = theses_details.data_collector_name;
        txtFormDataRevisionName.Text = theses_details.data_revision_name;
        rblFormImage.SelectedIndex = CDataConverter.ConvertToInt(theses_details.form_pic_state);
        txt_tags.Text = theses_details.keywords;
        id_href.Visible = true;
        if (menus_update.get_current_lang() == 1)
        {
            if (theses_dt.form_file != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + theses_dt.form_file; }
            else id_href.Visible = false;
        }
        if (menus_update.get_current_lang() == 2)
        {
            
            if (theses_dt.form_file_en != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + theses_dt.form_file_en; }
            else id_href.Visible = false;

        }
        if (menus_update.get_current_lang() == 3)
        {
            if (theses_dt.form_file_fr != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + theses_dt.form_file_fr; }
            else id_href.Visible = false;
        }
    }


    protected Boolean vaildfile()
    {
        bool vaild = false;
        string filename = uploadfile.FileName;
        if (menus_update.get_current_lang() == 1)
        {
            if (theses_dt.form_file == "")
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
            if (theses_dt.form_file_en == "")
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
            if (theses_dt.form_file_fr == "")
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
        string savePath = MapPath("~") + "\\images\\esdarat\\";

        string fileName = uploadfile.FileName;
        savePath += fileName;
        uploadfile.SaveAs(savePath);
        if (menus_update.get_current_lang() == 1)
        { theses_dt.form_file = fileName; }
        else if (menus_update.get_current_lang() == 2)
        { theses_dt.form_file_en = fileName; }
        else if (menus_update.get_current_lang() == 3)
        { theses_dt.form_file_fr = fileName; }


    }
    private bool CheckValidate()
    {
        bool isValid = true;
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

        if (CDataConverter.ConvertToInt(drop_lang.SelectedValue) < 0)
        {
            isValid = false;
            lblerror.Visible = true;
            lblerror.Text = "يجب اختيار اللغة أو كتابة لغة أخري";
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
    public void log(int operation_id)
    {
        contents_log_DT clog = new contents_log_DT();
        clog.id = 0;
        clog.content_type = Convert.ToInt16(content_type.Value);
        clog.content_id = Convert.ToInt16(content_id.Value);
        clog.operation_id = operation_id;
        clog.user_id = Convert.ToInt16(Session["user_id"].ToString());
        clog.lang_id = menus_update.get_current_lang();
        clog.note_date = DateTime.Now.ToShortDateString();
        int rslut = contents_log_DB.Save(clog);
    }
    protected void drop_lang_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (drop_lang.SelectedIndex > 0)
        //{ other.Enabled = false; }
        //else { other.Enabled = true; }
    }
}
