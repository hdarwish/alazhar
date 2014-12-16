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

public partial class user_controls_add_reference : System.Web.UI.UserControl
{
    private string sqlCon = Database.ConnectionString;
    public int rowsofgrid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            filldrop_types();
            //fillGrid();

        }
        if (Session["user_type"] != null)
        {
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {

                Btn_ref.Visible = false;
                Enabled();
            }
            if (Session["user_type"].ToString() == "5")
            {
                Btn_ref.Visible = false;
                tr_ref.Visible = false;
                GridView1.Columns[3].Visible = false;

            }
        }
    }
    public void filldrop_types()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { };
        DataTable dt = DatabaseFunctions.SelectData(sqlParams, "select_content_types_allsupport");
        drop_type.Visible = true;
        drop_type.DataSource = dt;
        drop_type.DataBind();
        drop_type.DataValueField = "id";
        drop_type.DataTextField = "title";
        ListItem litem = new ListItem("-- اختر النوع --", "0");
        litem.Selected = true;
        drop_type.Items.Insert(0, litem );

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

                    if (cont_fields.Rows[x]["type"].ToString() == "Button")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        Button btn = (Button)this.FindControl(id);
                        if (btn != null)
                        {
                            btn.Visible = true;
                            btn.ForeColor = System.Drawing.Color.Red;
                            //chbox.Focus();
                        }

                    }
                }
            }
        }
    }
    public void log(int operation_id)
    {
        if (content_id.Value != "" && content_type.Value != "")
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
    public void save()
    {
        if (content_id.Value != "" & content_type.Value != "")
        {
            content_references_DT obj = new content_references_DT();
            obj.id = 0;
            if (drop_type.SelectedValue != "")
            {
                lblerror.Visible = false;
                if (txt_ref.Text != "")
                {
                    lblerror.Visible = false;
                    obj.title = txt_ref.Text;
                    if (CDataConverter.ConvertToInt(content_id.Value) > 0)
                    {
                        obj.content_id = CDataConverter.ConvertToInt(content_id.Value);
                    }
                    if (CDataConverter.ConvertToInt(content_type.Value) > 0)
                    {
                        obj.content_type = CDataConverter.ConvertToInt(content_type.Value);
                    }
                    if (CDataConverter.ConvertToInt(drop_type.SelectedValue) > 0)
                    {
                        obj.content_type2 = CDataConverter.ConvertToInt(drop_type.SelectedValue);
                    }
                    obj.lang_id = 1;
                    obj.notes = txt_notes.Text;

                    int res = content_references_DB.Save(obj);

                    if (res > 0)
                    {
                        fillGrid();
                        log(12);
                        ShowAlertMessage("تم الحفظ");
                    }
                    txt_ref.Text = "";
                    txt_notes.Text = "";
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "يجب ادخال اسم المرجع أولاً";
                }
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "يجب ادخال النوع أولاً";
            }
        }
        else { ShowAlertMessage("يجب اختيار نوع الاستمارة والاسم أولاً"); }
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

    public void fillGrid()
    {
        //string  str = txt_notes.Text;
        //str.
        if (content_id.Value != "" & content_type.Value != "")
        {
            DataTable dt = content_references_DB.SelectByContentID_type(CDataConverter.ConvertToInt(content_type.Value), CDataConverter.ConvertToInt(content_id.Value));
            GridView1.DataSource = dt;
            GridView1.DataBind();
            rowsofgrid = GridView1.Rows.Count;
        }
    }
    protected void drop_type_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    public void imgDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        if (Session["user_type"].ToString() == "5")
        { ShowAlertMessage("عفواً لايمكنك الحذف"); }
        else
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                content_references_DB.Delete(id);
                fillGrid();
                log(38);
            }
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //if (e.CommandName == "DeleteItem")
        //{
        //    int id = Convert.ToInt32(e.CommandArgument);
        //    content_references_DB.Delete(id);
        //    fillGrid();


        //}
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            int type = (int)Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "content_type2"));
            Label lab = (Label)e.Row.FindControl("type");

            if (type == 6)
            {
                lab.Text = "تسجيل تليفزيوني";
            }
            if (type == 7)
            {
                lab.Text = "تسجيل إذاعي";
            }

            if (type == 8)
            {
                lab.Text = "الوثائق";
            }
            if (type == 9)
            { lab.Text = " المقالات"; }
            if (type == 10)
            { lab.Text = " الكتب"; }
            if (type == 11)
            { lab.Text = "الصور"; }
            if (type == 12)
            { lab.Text = " المخطوطات"; }
            if (type == 13)
            { lab.Text = " أطروحة"; }
            if (type == 14)
            { lab.Text = " بحث في مؤتمر"; }
            if (type == 15)
            { lab.Text = "موقع إلكترونى"; }
            if (type == 16)
            { lab.Text = "المصطلحات"; }
        }
    }
    protected void Btn_ref_Click(object sender, EventArgs e)
    {
        save();


    }


    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        DataTable myDataTable = content_references_DB.SelectByContentID_type(CDataConverter.ConvertToInt(content_type.Value), CDataConverter.ConvertToInt(content_id.Value));
        GridView1.DataSource = myDataTable;

        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
}
