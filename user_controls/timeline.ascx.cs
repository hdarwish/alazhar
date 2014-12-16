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
using System.Data.SqlClient;

public partial class user_controls_timeline : System.Web.UI.UserControl
{
    General_Helping Obj_General_Helping = new General_Helping();
    contents_timeline_DT content_timeline_obj_to_save = new contents_timeline_DT();
    contents_timeline_DT content_timeline_obj_to_select = new contents_timeline_DT();
    public int rowsofgrid;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { }
        if (Session["user_type"] != null)
        {
            fillGrid();
            
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {
                btnsavetimline.Visible = false;
                Enabled();
            }
            if (Session["user_type"].ToString() == "5")
            {
                btnsavetimline.Visible = false;
                tbl_all.Visible = false;
                gvMainElements.Columns[7].Visible =
           gvMainElements.Columns[6].Visible = false;
            }
        }

    }
    public void log(int operation_id)
    {
        if (content_type.Value != "" & content_id.Value != "")
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
    public int gridCount
    {

        get
        {
            return gvMainElements.Rows.Count;
        }


    }

    public void fillGrid()
    {


        if (content_type.Value == "1")
        {
            Tr1.Visible = Tr2.Visible = true;
        }
        else
        {
            Tr1.Visible = Tr2.Visible = false;
        }
        gvMainElements.DataSource = contents_timeline_DB.SelectByIDandType(CDataConverter.ConvertToInt(content_id.Value), CDataConverter.ConvertToInt(content_type.Value));
        gvMainElements.DataBind();




    }
    public void Enabled()
    {
        if (Session["user_type"] != null && Session["user_type"].ToString() == "4")
        {
            if (Request.QueryString["operation"].ToString() == "wrong")
            {
                btnsavetimline.Visible = false;
                SqlParameter[] sqlParamse = new SqlParameter[] {new SqlParameter ("@content_type",CDataConverter.ConvertToInt(content_type.Value)),
              new SqlParameter("@content_id",CDataConverter.ConvertToInt(content_id.Value)),
              new SqlParameter("@lang_id",menus_update.get_current_lang())};

                DataTable cont_fields = DatabaseFunctions.SelectData(sqlParamse, "contents_notes_fields_enabled");
                int i = cont_fields.Rows.Count;

                for (int x = 0; x < i; x++)
                {
                    string id = "";

                    if (cont_fields.Rows[x]["type"].ToString() == "Button")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        Button btn = (Button)this.FindControl(id);
                        if (btn != null)
                        {
                            
                            btn.Visible = true;

                            btn.ForeColor = System.Drawing.Color.Red;

                            btn.Focus();
                        
                        }



                    }
                }
            }
        }
        if (Session["user_type"].ToString() == "5")
        {
            btnsavetimline.Visible = false;
            tbl_all.Visible = false;
        }
    }
    //public Boolean  GridRows()
    //{
    //    bool flag = false;
    //    if (content_id.Value != "" & content_type.Value != "")
    //    {

    //        if (gvMainElements.Rows.Count > 0)
    //        { flag = true; }


    //    }
    //    return flag;
    //}
    public void ImgBtnEdit_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        lblpage.Visible = false;
        timeline_id.Value = ((ImageButton)sender).CommandArgument;
        myRowIndex1.Value = ((ImageButton)sender).CommandName;
        content_timeline_obj_to_select = contents_timeline_DB.SelectByID(CDataConverter.ConvertToInt(timeline_id.Value));
        txtGorgDatefrom.Text = content_timeline_obj_to_select.melady_date_from;
        txtGorgDateto.Text = content_timeline_obj_to_select.melady_date_to;
        txtHijriDatefrom.Text = content_timeline_obj_to_select.hegry_date_from;
        txtHijriDateto.Text = content_timeline_obj_to_select.hegry_date_to;
        txtNotes.Text = content_timeline_obj_to_select.notes;
        TextBox1.Text = content_timeline_obj_to_select.melady_date_rep;
        TextBox2.Text = content_timeline_obj_to_select.hegry_date_rep;
        TextBox3.Text = content_timeline_obj_to_select.reason_note;
        for (int i = 0; i < gvMainElements.Rows.Count; i++)
        {
            gvMainElements.Rows[i].BackColor = System.Drawing.Color.White;
        }
        gvMainElements.Rows[CDataConverter.ConvertToInt(myRowIndex1.Value)].BackColor = System.Drawing.Color.Lavender;
    }
    public void ImgBtnDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        if (Session["user_type"].ToString() == "5")
        { ShowAlertMessage("عفواً لايمكنك الحذف"); }
        else
        {
            int delete_id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            contents_timeline_DB.Delete(delete_id);
            log(36);
            lblpage.Visible = true;
            lblpage.Text = "تم الحذف";
            lblpage.ForeColor = System.Drawing.Color.Red;
            timeline_id.Value = "";
            fillGrid();
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
    private Boolean Valid()
    {
        /* if (security_issues.check_date(txtGorgDatefrom.Text) == false && txtGorgDatefrom.Text != "")
        {
            lblpage.Visible = true;
            lblpage.Text = "أدخل التاريخ الميلادى بالصيغة الصحيحة";
            txtGorgDatefrom.Text = "";
            return false;
        }
        else if (security_issues.check_date(txtGorgDateto.Text) == false && txtGorgDateto.Text != "")
        {
            lblpage.Visible = true;
            lblpage.Text = "أدخل التاريخ الميلادى بالصيغة الصحيحة";
            txtGorgDateto.Text = "";
            return false;
        }
        else if (security_issues.check_date(txtHijriDatefrom.Text) == false && txtHijriDatefrom.Text != "")
        {
            lblpage.Visible = true;
            lblpage.Text = "أدخل التاريخ الهجرى بالصيغة الصحيحة";
            txtHijriDatefrom.Text = "";
            return false;
        }
        else if (security_issues.check_date(txtHijriDateto.Text) == false && txtHijriDateto.Text != "")
        {
            lblpage.Visible = true;
            lblpage.Text = "أدخل التاريخ الهجرى بالصيغة الصحيحة";
            txtHijriDateto.Text = "";
            return false;
        }
        else if (content_type.Value == "1" && security_issues.check_date(TextBox1.Text) == false && TextBox1.Text != "")
        {
            lblpage.Visible = true;
            lblpage.Text = "أدخل التاريخ الميلادى لسنة التمثيل على الخط الزمنى بالصيغة الصحيحة";
            TextBox1.Text = "";
            return false;
        }
        else if (content_type.Value == "1" && security_issues.check_date(TextBox2.Text) == false && TextBox2.Text != "")
        {
            lblpage.Visible = true;
            lblpage.Text = "أدخل التاريخ الهجرى لسنة التمثيل على الخط الزمنى بالصيغة الصحيحة";
            TextBox2.Text = "";
            return false;
        } 
        else if (content_type.Value == "1" && TextBox3.Text == "")
        {
            lblpage.Visible = true;
            lblpage.Text = "يجب ادخال سبب اختيار هذه السنة";
            TextBox3.Text = "";
            return false;
        }
        else if (security_issues.check_date(txtGorgDatefrom.Text) != false && security_issues.check_date(txtGorgDateto.Text) != false)
        {
            if (Dates_operations.date_validate(txtGorgDateto.Text) != "" && Dates_operations.date_validate(txtGorgDatefrom.Text) != "")
            {
                if (Dates_operations.Date_compare(txtGorgDateto.Text, txtGorgDatefrom.Text) == false)
                {
                    lblpage.Visible = true;
                    lblpage.Text = "يجب مراعاة ترتيب التواريخ من إلى";
                    txtGorgDateto.Text = "";
                    return false;
                }
            }
            else if (CDataConverter.ConvertToInt(txtGorgDateto.Text) < CDataConverter.ConvertToInt(txtGorgDatefrom.Text))
            {
                lblpage.Visible = true;
                lblpage.Text = "يجب مراعاة ترتيب التواريخ من إلى";
                txtGorgDateto.Text = "";
                return false;
            }

        }
        else if (security_issues.check_date(txtHijriDatefrom.Text) != false && security_issues.check_date(txtHijriDateto.Text) != false)
        {
            if (Dates_operations.date_validate(txtHijriDateto.Text) != "" && Dates_operations.date_validate(txtHijriDatefrom.Text) != "")
            {
                if (Dates_operations.Date_compare(txtHijriDateto.Text, txtHijriDatefrom.Text) == false)
                {
                    lblpage.Visible = true;
                    lblpage.Text = "يجب مراعاة ترتيب التواريخ من إلى";
                    txtHijriDateto.Text = "";
                    return false;
                }
            }
            else if (CDataConverter.ConvertToInt(txtHijriDateto.Text) < CDataConverter.ConvertToInt(txtHijriDatefrom.Text))
            {
                lblpage.Visible = true;
                lblpage.Text = "يجب مراعاة ترتيب التواريخ من إلى";
                txtGorgDateto.Text = "";
                return false;
            }
        } */
        return true;

    }
    protected void btnsavetimline_Click(object sender, EventArgs e)
    {
        if (content_type.Value != "" & content_id.Value != "")
        {
            if (Valid())
            {
                content_timeline_obj_to_save.id = CDataConverter.ConvertToInt(timeline_id.Value);
                content_timeline_obj_to_save.content_id = CDataConverter.ConvertToInt(content_id.Value);
                content_timeline_obj_to_save.content_type = content_type.Value;
                content_timeline_obj_to_save.hegry_date_from = txtHijriDatefrom.Text;
                content_timeline_obj_to_save.hegry_date_to = txtHijriDateto.Text;
                content_timeline_obj_to_save.lang_id = menus_update.get_current_lang();
 content_timeline_obj_to_save.melady_date_rep=TextBox1.Text ;
         content_timeline_obj_to_save.hegry_date_rep=TextBox2.Text ;
         content_timeline_obj_to_save.reason_note=TextBox3.Text ;
                content_timeline_obj_to_save.melady_date_from = txtGorgDatefrom.Text;
                //if (security_issues.check_date(txtGorgDateto.Text) == false && security_issues.check_date(txtGorgDatefrom.Text) != false)
                //    content_timeline_obj_to_save.melady_date_to = txtGorgDatefrom.Text;
                //else
                content_timeline_obj_to_save.melady_date_to = txtGorgDateto.Text;
                content_timeline_obj_to_save.notes = txtNotes.Text;
                contents_timeline_DB.Save(content_timeline_obj_to_save);
                log(14);
                ShowAlertMessage("تم الحفظ");

                timeline_id.Value = "";
                myRowIndex1.Value = "";

                fillGrid();
                Clear_controls();
                rowsofgrid = gvMainElements.Rows.Count;
            }
        }
        else { ShowAlertMessage("يجب اختيار نوع العنصر واسم العنصر أولاً"); }
    }
    protected void Clear_controls()
    {
        txtGorgDatefrom.Text =
            txtGorgDateto.Text =
            txtHijriDatefrom.Text =
            txtHijriDateto.Text =
        TextBox1.Text=
        TextBox2.Text=
        TextBox3.Text=
            lblpage.Text =
            txtNotes.Text = "";
        
        lblpage.Visible = false;
    }
}
