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

public partial class masterpage_add_books : System.Web.UI.UserControl
{
    public static int row_id = 0;
    documents_DT docobj = new documents_DT();
    documents_details_DT docdetails = new documents_details_DT();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }

        if (content_type.Value == "10")
        {
            if (content_id.Value != "")
            {
                getData();
                fillcheck_periods();
                fillcontrol();
                filldrop_lang();
                //filldrop_type();
                
              
                invisible();
                visible();
                //set_example_label();
            }
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {
                Dimmed();
                Enabled();
            }

            if (Session["user_type"].ToString() == "4")
            {
                txt_title.ReadOnly = true;
            }
            if (Session["user_type"].ToString() == "5")
            {
                
                Button1.Visible = false;
                Dimmed();
                 

            }
            //if (menus_update.get_current_lang() == 1)
            //{ trtrgma.Visible = false;
            //gview_moalf.Columns[2].Visible = false;
            //gview_moalf.Columns[4].Visible = false;
            //}
            //else { trtrgma.Visible = true;
            //gview_moalf.Columns[3].Visible = false;
            ////gview_moalf.Columns[3].Visible = true;
            //gview_moalf.Columns[5].Visible = false;
            //}

        }
    }

    private void set_example_label()
    {

        
    }
    private void getData()
    {
        docobj = documents_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        docdetails = documents_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value),menus_update.get_current_lang());


    }
    private void filldrop_lang()
    {
        languages_DT obj = new languages_DT();
        DataTable lang_dt = languages_DB.SelectAll();
        drop_lang.DataSource = lang_dt;
        drop_lang.DataBind();
        ListItem litem = new ListItem("-- اختر اللغة --", "0");
        drop_lang.Items.Insert(0, litem);
        if (docdetails.doc_lang2 != null)
        {
            if (docdetails.doc_lang2 != 0)
            {

                int id = docdetails.doc_lang2;
                drop_lang.Items.FindByValue(id.ToString()).Selected = true;
               
            }
            else
            {

                litem.Selected = true;

            }
        }


    }
    private void filldrop_type()
    {
        //DataTable dt = author_type_DB.SelectAll();
        //drop_type.DataSource = dt;
        //drop_type.DataBind();
        if (docdetails.title_type_id > 0)
        {
            ListItem litem = new ListItem("-- اختر نوع العنوان --", "0");
           // drop_type.Items.Insert(0, litem);
            string id = docdetails.title_type_id.ToString();
            //drop_type.Items.FindByValue(id).Selected = true;
        }
        else
        {
            ListItem litem = new ListItem("-- اختر نوع العنوان --", "0");
            litem.Selected = true;
            //drop_type.Items.Insert(0, litem);
        }
    }
    //private void filldrop_author()
    //{
    //    //DataTable dt = authors_details_DB.SelectAll();
    //    //drop_author.DataSource = dt;
    //    //drop_author.DataBind();
    //    //ListItem litem = new ListItem("-- اختر اسم المؤلف --", "0");
    //    //litem.Selected = true;
    //    //drop_author.Items.Insert(0, litem);



    //}
    //private void filldrop_char()
    //{
    //    DataTable dt = characters_details_DB.SelectBylang_ID(menus_update.get_current_lang());
    //    drop_char.DataSource = dt;
    //    drop_char.DataBind();
    //    ListItem litem = new ListItem("--  اختر اسم المؤلف من الشخصيات  --", "0");
    //    litem.Selected = true;
    //    drop_char.Items.Insert(0, litem);
    //}
    //private void filldrop_role()
    //{
    //    DataTable dt = authors_role_DB.SelectAll();
    //    drop_role.DataSource = dt;
    //    drop_role.DataBind();
    //    ListItem litem = new ListItem("-- اختر دور المؤلف--", "0");
    //    litem.Selected = true;
    //    drop_role.Items.Insert(0, litem);
    //}
    //private void filldrop_author_type()
    //{
    //    DataTable dt = author_type_DB.SelectAll();
    //    drop_author_type.DataSource = dt;
    //    drop_author_type.DataBind();
    //    ListItem litem = new ListItem("-- اختر نوع اسم المؤلف--", "0");
    //    litem.Selected = true;
    //    drop_author_type.Items.Insert(0, litem);
    //}
    private void fillcheck_periods()
    {
        periods_DT obj = new periods_DT();
        DataTable per_dt = periods_DB.SelectAll();
        chk_periods.DataSource = per_dt;
        chk_periods.DataBind();


    }
    public void test()
    {
        //string name = this.NamingContainer.ToString();
        // Class1 clss = new Class1();
        // clss.Dimmed(books);
    }
    public void Dimmed()
    {
        //Class1 clss = new Class1();
        //clss.Dimmed();
        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblbook.Rows)
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
                    if (cont_fields.Rows[x]["type"].ToString() == "FileUpload")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        FileUpload upfile = (FileUpload)this.FindControl(id);
                        upfile.Enabled = true;
                        upfile.BorderColor = System.Drawing.Color.Red;
                        upfile.ForeColor = System.Drawing.Color.Red;
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
            string[] arrv = new string[24];
            arrv[0] = "trtitle";
            arrv[1] = "trspecial";
            arrv[2] = "trtitletype";
            arrv[3] = "trlang";
            arrv[4] = "trpublisher";
            arrv[5] = "trseries";
            arrv[6] = "trnotes";
            arrv[7] = "trtags";
            arrv[8] = "trperiods";
            arrv[9] = "trpicture";
            arrv[10] = "trcolectorname";
            arrv[11] = "trrevisionname";
            arrv[12] = "file_tr";
            arrv[13] = "trpublishno";
            arrv[14] = "trfolderno";
            arrv[15] = "trorg";
           // arrv[16] = "trcity";
            arrv[16] = "trno";
            arrv[17] = "trartno";
            arrv[18] = "trperiods2";
            //arrv[19] = "trdate";
            //arrv[20] = "trdate2";
            arrv[19] = "trpublishno2";
            arrv[20] = "trfolderno2";
            arrv[21] = "trfolderno2";
            arrv[22] = "trno2";
            arrv[23] = "trartno2";
            for (int i = 0; i< 24; i++)
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
            string[] arrv = new string[10];
            arrv[0] = "trtitle";
            arrv[1] = "trpublisher";
            arrv[2] = "trseries";
            arrv[3] = "trorg";
            arrv[4] = "trtags";
            arrv[5] = "trnotes";
            arrv[6] = "trpagetitle";
            arrv[7] = "file_tr";
            arrv[8] = "trseries2";
            arrv[9] = "trcity";
            for (int i = 0; i < 10; i++)
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
    protected Boolean vaildfile()
    {
        bool vaild = false;
        string filename = uploadfile.FileName;
        if (menus_update.get_current_lang() == 1)
        {
            if (docobj.form_file == "")
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
            if (docobj.form_file_en == "")
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
            if (docobj.form_file_fr == "")
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
                }
                else
                {
                    saveFileSystem();
                    vaild = true;
                }
            }
            else
            {
                labfile.Visible = true;
                labfile.Text = " امتداد الملف غير صحيح ";
                vaild = false;
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
        { docobj.form_file = fileName; }
        else if (menus_update.get_current_lang() == 2)
        { docobj.form_file_en = fileName; }
        else if (menus_update.get_current_lang() == 3)
        { docobj.form_file_fr = fileName; }


    }
    public void save()
    { 
        if (CheckValidate())

        {
            if (vaildfile())
            {
                lblerror.Visible = false;
               
              

                docobj.doc_type = 1;

                if (chk_site.Checked == true)
                { docobj.highlight = 1; }
                else docobj.highlight = 0;
                if (chk_pan.Checked == true)
                { docobj.highlight_panorama = 1; }
                else { docobj.highlight_panorama = 0; }

                docobj.folders_no = txt_folder_no.Text;
                docobj.publish_no = txt_publish_no.Text;
                docobj.creater_no = txt_createrno.Text;
                docobj.pages_no = CDataConverter.ConvertToInt(txt_from.Text);
                /*docobj.isbn =
                docobj.large_image =
                docobj.small_image = null;*/
                publishers_DT doc_objp = new publishers_DT();
              
                //publishers_DT publisher_dt = new publishers_DT();

                doc_objp = publishers_DB.SelectByID(docobj.publisher_id);

                if (menus_update.get_current_lang() == 1)
                {
                    doc_objp.id = docobj.publisher_id;
                    doc_objp.title_ar = txt_publisher.Text;
                    
                }
                if (menus_update.get_current_lang()== 2)
                {
                    doc_objp.id = docobj.publisher_id;
                
                    doc_objp.title_en = txt_publisher.Text;
                   
                }
                if (menus_update.get_current_lang() == 3)
                {
                    doc_objp.id = docobj.publisher_id;
                   
                    doc_objp.title_fr = txt_publisher.Text;
                }
                doc_objp.id = publishers_DB.Save(doc_objp);
                if (doc_objp.id > 0)
                { docobj.publisher_id = doc_objp.id; }
                else docobj.publisher_id = 0;
                docobj.publish_date = txt_date.Text;
                docobj.publish_hdate = txt_hdate.Text;
                //docobj.period_id = CDataConverter.ConvertToInt(chk_periods.SelectedValue);
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
                    docobj.period_id_multi = periods;
                    //}

                }
                
                docobj.id = documents_DB.Save(docobj);

                /////////////////////////////////////////

                //docdetails.id = docdetails.id;
                docdetails.doc_id = CDataConverter.ConvertToInt(content_id.Value);
                docdetails.title = txt_title.Text;
                //docdetails.title_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
                docdetails.FromTitle = txtFromTitle.Text;
                docdetails.FromHeader = txtFromHeader.Text;
                //docdetails.FromDocumented = txtDocumented.Text;
                docdetails.save_public_no = txt_genno.Text;
                docdetails.save_specifics_no = txt_specifno.Text;
                docdetails.library_no = txt_library.Text;
                docdetails.organization_save = txt_org.Text;
                docdetails.city = txt_city.Text;
                docdetails.country_name = txt_country.Text;
                docdetails.art_no = txt_art.Text;
               
                docdetails.doc_lang2 = CDataConverter.ConvertToInt(drop_lang.SelectedValue);
                
               
                docdetails.notes = TextBox3.Text;
                docdetails.series_no = txt_series_no.Text;
                docdetails.series = txt_series.Text;
                docdetails.keywords = txt_tags.Text;
                docdetails.publish_location = txt_plocation.Text;
                docdetails.brief =
                 docdetails.direct_subject =
                 docdetails.docs_type =
                 docdetails.material_shape =
                 docdetails.material_type =
                 docdetails.request_id =null;
                docdetails.title_type_id =
                docdetails.lang_id = menus_update.get_current_lang();
                docdetails.data_collector_name = txtFormDataColectorName.Text;
                docdetails.data_revision_name = txtFormDataRevisionName.Text;

                docdetails.id = documents_details_DB.Save(docdetails);
                if (docdetails.id > 0)
                {

                    ShowAlertMessage("لقد تم الحفظ بنجاح");
                   

                }
                else { ShowAlertMessage("من فضلك اعد المحاولة"); }
                id_href.Visible = true;
                if (menus_update.get_current_lang() == 1)
                {
                    if (docobj.form_file != "")
                    { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + docobj.form_file; }
                    else id_href.Visible = false;
                }
                if (menus_update.get_current_lang() == 2)
                {
                    if (docobj.form_file_en != "")
                    { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + docobj.form_file_en; }
                    else id_href.Visible = false;
                }
                if (menus_update.get_current_lang() == 3)
                {
                    if (docobj.form_file_fr != "")
                    { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + docobj.form_file_fr; }
                    else id_href.Visible = false;
                }
                log(2);
            }
        }

    }
    public void fillcontrol()
    {

        if (docobj.highlight_panorama == 1)
        { chk_pan.Checked = true; }
        else chk_pan.Checked = false;
        if (docobj.highlight == 1)
        { chk_site.Checked = true; }
        
        txt_folder_no.Text = docobj.folders_no.ToString();
        //if (docobj.period_id > 0)
        //{ chk_periods.SelectedValue = docobj.period_id.ToString(); }
        if (docobj.period_id_multi != null && docobj.period_id_multi != "")
        {
            String[] temp = docobj.period_id_multi.ToString().Split(',');
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
        txt_art.Text = docdetails.art_no;
        txt_city.Text = docdetails.city;
        txt_country.Text = docdetails.country_name;
        txt_specifno.Text = docdetails.save_specifics_no;
        txt_genno.Text = docdetails.save_public_no;
        rblFormImage.SelectedValue = docdetails.form_pic_state.ToString();
        txt_tags.Text = docdetails.keywords;
        txt_series.Text = docdetails.series;
        //other.Text = docdetails.other_doc_lang;
        txt_plocation.Text = docdetails.publish_location;
        publishers_DT publisher_dt = new publishers_DT();
        publisher_dt = publishers_DB.SelectByID(docobj.publisher_id);
       
        if (menus_update.get_current_lang() == 1)
        { txt_publisher.Text = publisher_dt.title_ar; }
        if (menus_update.get_current_lang() == 2)
        { txt_publisher.Text = publisher_dt.title_en; }
        if (menus_update.get_current_lang() == 3)
        { txt_publisher.Text = publisher_dt.title_fr; }
        txt_title.Text = docdetails.title;
        txt_date.Text = docobj.publish_date;
        txt_hdate.Text = docobj.publish_hdate;
        txt_series_no.Text = docdetails.series_no;
        txt_publish_no.Text = docobj.publish_no;
        txt_from.Text = docobj.pages_no.ToString();
        txt_createrno.Text = docobj.creater_no;
        txt_org.Text = docdetails.organization_save;
        txt_specifno.Text = docdetails.save_specifics_no;
        txt_library.Text = docdetails.library_no;
        TextBox3.Text = docdetails.notes;

        txtFromTitle.Text = docdetails.FromTitle;
        txtFromHeader.Text = docdetails.FromHeader;
        rblFormImage.SelectedIndex = CDataConverter.ConvertToInt(docdetails.form_pic_state);
        id_href.Visible = true;
        if (menus_update.get_current_lang() == 1)
        {
            if (docobj.form_file != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + docobj.form_file; }
            else id_href.Visible = false;
        }
        if (menus_update.get_current_lang() == 2)
        {
            if (docobj.form_file_en != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + docobj.form_file_en; }
            else id_href.Visible = false;
        }
        if (menus_update.get_current_lang() == 3)
        {
            if (docobj.form_file_fr != "")
            { id_href.Visible = true; id_href.HRef = "~/images/esdarat/" + docobj.form_file_fr; }
            else id_href.Visible = false;
        }
        txtFormDataColectorName.Text = docdetails.data_collector_name;
        txtFormDataRevisionName.Text = docdetails.data_revision_name;

    }
    private bool CheckValidate()
    {
        bool isValid = true;
        if (menus_update.get_current_lang() == 1)
        {
            if (CDataConverter.ConvertToInt(chk_periods.SelectedValue) < 0)
            {
                isValid = false;
                lblerror.Visible = true;
                lblerror.Text = "يجب اختيار العصر المرتبط بالمقالة";
                goto returnPart;
            }
           
            //if (txt_hdate.Text != "")
            //{
            //    if (security_issues.check_date(txt_hdate.Text) == false)
            //    {
            //        isValid = false;
            //        lblerror.Visible = true;
            //        //lblError2.ForeColor = System.Drawing.Color.Red;
            //        lblerror.Text = "(التاريخ الهجري غير صحيح يجب أن يكون( سنة أو (يوم/شهر/سنة)";
            //        goto returnPart;
            //    }

            //}
            //if (txt_date.Text != "")
            //{
            //    if (security_issues.check_date(txt_date.Text) == false)
            //    {
            //        isValid = false;
            //        lblerror.Visible = true;
            //        //lblError3.ForeColor = System.Drawing.Color.Red;
            //        lblerror.Text = "(التاريخ الميلادي غير صحيح يجب أن يكون( سنة أو (يوم/شهر/سنة)";
            //        goto returnPart;
            //    }
            //}

            if (txt_from.Text == "")
            {
                isValid = false;
                lblerror.Visible = true;
                lblerror.Text = "يجب إدخال عدد الصفحات من / إلي ";
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
            ShowAlertMessage("يجب إدخال العصر الذي يتناوله/ يرتبط به الكتاب");
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
    //public void FillGrid()
    //{
    //    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt(content_id.Value)),
    //        new SqlParameter("@lang_id", menus_update.get_current_lang ()) };
    //    DataTable dt = new DataTable();
    //    dt = DatabaseFunctions.SelectData(sqlParams, "authorstitle_select");
        
    //    gview_moalf.Visible = true;
    //    gview_moalf.DataSource = dt;
    //    gview_moalf.DataBind();

    //}
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
    protected void Button2_Click(object sender, EventArgs e)
    {

        //if (CDataConverter.ConvertToInt(drop_char.SelectedValue) > 0)
        //{
        //    docs_authors_DT authors_doc_dt = new docs_authors_DT();
        //    authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
        //    authors_doc_dt.author_id = CDataConverter.ConvertToInt(drop_char.SelectedValue);
        //    authors_doc_dt.is_character = 1;
        //    authors_doc_dt.relation_title_ar = "";
        //    authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
        //    authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
        //    authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
        //    id.Value = authors_doc_dt.id.ToString();
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
        //    author_details_new.id = authors_details_DB.Save(author_details_new);

        //    if (author_details_new.id > 0)
        //    {
        //        docs_authors_DT authors_doc_dt = new docs_authors_DT();
        //        authors_doc_dt.id = 0;
        //        authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
        //        authors_doc_dt.author_id = author_details_new.author_id;
        //        authors_doc_dt.is_character = 0;
        //        authors_doc_dt.relation_title_ar = "";
        //        authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
        //        authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
        //        authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
        //        id.Value = authors_doc_dt.id.ToString();

        //    }

        //}

        //if (CDataConverter.ConvertToInt(drop_author.SelectedValue) > 0)
        //{
        //    docs_authors_DT authors_doc_dt = new docs_authors_DT();

        //    authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
        //    authors_doc_dt.author_id = CDataConverter.ConvertToInt(drop_author.SelectedValue); ;
        //    authors_doc_dt.is_character = 0;
        //    authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
        //    authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
        //    authors_doc_dt.relation_title_ar = "";
        //    authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
        //    id.Value = authors_doc_dt.id.ToString();
        //}

        //FillGrid();
       // TextBox1.Text ="";

    }
    protected void gview_moalf_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
    }

    //protected void imgDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    //{
    //     int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
    //     if (id > 0)
    //     {
    //           docs_authors_DB.Delete(id);
    //            FillGrid();
             
            
    //     }
    //}
    //protected void drop_char_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (drop_char.SelectedValue != "0")
    //    { //drop_author.Enabled = false; 
    //        TextBox1.Enabled = false; }
    //    else { //drop_author.Enabled = true; 
    //        TextBox1.Enabled = true; }
        

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
    //    if (txt_enmoalf.Text  != "")
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
    //    if (content_type.Value != "0")
    //    {
    //        if (content_id.Value != "0")
    //            row_id = CDataConverter.ConvertToInt(((Button)sender).CommandArgument);
    //        if (row_id > 0)
    //        {
    //            authors_details_DT dt = authors_details_DB.SelectByID(row_id);
    //            txt_enmoalf.Text = dt.name;
    //            //trsave.Visible = true;
    //            trtrgma.Visible = true;
    //            //tbl_translate.Visible = true;
    //            Button2.Visible = false;
    //            // tbl_all.Visible = false;
    //        }
    //    }
    //}
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          