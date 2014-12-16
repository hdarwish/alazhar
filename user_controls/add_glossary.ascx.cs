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

public partial class user_controls_add_glossary : System.Web.UI.UserControl
{
    public static int row_id = 0;
    glossary_DT obj = new glossary_DT();
    glossary_details_DT obj_details = new glossary_details_DT();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // FillGrid();
        }
        if (content_type.Value == "16")
        {
            if (content_id.Value != "")
            {
                getData();
                fillcontrol();
                invisible();
                visible();
                //id_href.Visible = false;

                if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
                {
                    //Button2.Visible = false;
                    //uploadfile.Enabled = false;
                    Dimmed();
                    Enabled();
                }
                if (Session["user_type"].ToString() == "5")
                {
                    Dimmed();
                }
                
            }
        }
    }
    private void getData()
    {
        obj = glossary_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
        obj_details = glossary_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());


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
    protected void Button1_Click(object sender, EventArgs e)
    {
        save();


    }
    public void invisible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            trcolectorname.Visible = false;
            trrevisionname.Visible = false;
        } 
    }
    public void visible()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
            tr1.Visible = true;
        }
    }
    public void save()
    { 
        if (CheckValidate())
        {
            if (vaildfile())
            {
                //getData();
                lblerror.Visible = true;
                obj.form_lock = obj.form_lock;
                obj.form_status = obj.form_status;
                obj.file_status = obj.file_status;
                obj.lock_files = obj.lock_files;
                //obj.form_file = obj.form_file;
                
                glossary_DB.Save(obj);
               
                obj_details.id = CDataConverter.ConvertToInt(content_id.Value);
                obj_details.glossary_id  = CDataConverter.ConvertToInt(content_id.Value);
                obj_details.lang_id = menus_update.get_current_lang();
                obj_details.glossary_definition = txt_def.Text;
              
                obj_details.notes = txt_notes.Text;
                obj_details.data_entry_revision_name = "";
                obj_details.data_collector_name = txtFormDataColectorName.Text;
                obj_details.data_revision_name = txtFormDataRevisionName.Text;
                obj_details.data_entry_name = "";
              
                obj_details.id = glossary_details_DB.Save(obj_details);
                if (obj_details.id > 0)
                {
                   
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
                ShowAlertMessage("لقد تم الحفظ");
            }
        }

    }
    public void fillcontrol()
    {
        lbltitle.Text = obj_details.title;
        txt_def.Text = obj_details.glossary_definition;
       
        txt_notes.Text = obj_details.notes;
      
        txtFormDataColectorName.Text = obj_details.data_collector_name;
      
        txtFormDataRevisionName.Text = obj_details.data_revision_name;
        
       

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

                    lblerror.Visible = true;
                    //labfile.ForeColor = System.Drawing.Color.Red;
                     lblerror.Text = "يجب إضافة ملف";
                    vaild = false;
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

                    lblerror.Visible = true;
                    
                    lblerror.Text = "يجب إضافة ملف";
                    vaild = false;
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

                    lblerror.Visible = true;
                    //labfile.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "يجب إضافة ملف";
                    vaild = false;
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
                    lblerror.Visible = true;
                    lblerror.Text = " اسم الملف غير صحيح ";
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
                lblerror.Visible = true;
                lblerror.Text = " امتداد الملف غير صحيح ";
                vaild = false;
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
        if (txt_def.Text == "")
        {
            isValid = false;
            lblerror.Visible = true;
            lblerror.Text = "يجب إدخال تعريف المصطلح";
            goto returnPart;
        }
        if (menus_update.get_current_lang() == 1)
        {
            if (txtFormDataColectorName.Text == "")
            {
                if (txtFormDataColectorName.Text == "")
                {
                    isValid = false;
                    lblerror.Visible = true;
                    lblerror.Text = "يجب إدخال جامع البيانات";
                    goto returnPart;
                }
            }
            if (txtFormDataRevisionName.Text == "")
            {
                if (txtFormDataRevisionName.Text == "")
                {
                    isValid = false;
                    lblerror.Visible = true;
                    lblerror.Text = "يجب إدخال مراجع البيانات ";
                    goto returnPart;
                }
            }
            
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
}
    

   
