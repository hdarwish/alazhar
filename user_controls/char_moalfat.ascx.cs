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
public partial class user_controls_char_moalfat : System.Web.UI.UserControl
{
    // private string sqlCon = Database.ConnectionString;
    public static int row_id = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { filldrop_types(); }

        if (Session["user_type"] != null)
        {
            
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {

                Button1.Visible = false;
                Enabled();
            }
            if (Session["user_type"].ToString() == "5")
            {
                Button1.Visible = false;
                //Button2.Visible = false;
                tbl_all.Visible = false;
                tbl_translate.Visible = false;
                tbl_view.Visible = true;
                GridView1.Columns[8].Visible = false;
                GridView1.Columns[9].Visible = false;
                if (menus_update.get_current_lang() == 1)
                {
                    GridView1.Columns[3].Visible = false;
                    GridView1.Columns[4].Visible = false;

                }
                if (menus_update.get_current_lang() == 2)
                {
                    //if (GridView1.Rows.Count > 0)
                    //{ tbl_translate.Visible = true; }
                    //else { tbl_translate.Visible = false; }
                    GridView1.Columns[3].Visible = true;
                    GridView1.Columns[4].Visible = false;
		    GridView1.Columns[9].Visible = false;

                }
                if (menus_update.get_current_lang() == 3)
                {
                    //if (GridView1.Rows.Count > 0)
                    //{ tbl_translate.Visible = true; }
                    //else { tbl_translate.Visible = false; }
                    GridView1.Columns[3].Visible = false;
                    GridView1.Columns[4].Visible = true;
		    GridView1.Columns[9].Visible = false;

                }
            }
            if (Session["user_type"].ToString() == "4" || Session["user_type"].ToString() == "8")
            {

                if (menus_update.get_current_lang() == 1)
                {

                    tbl_all.Visible = true;
                    tbl_translate.Visible = false;
                    GridView1.Columns[3].Visible =  false;
                    GridView1.Columns[4].Visible = false;
                    GridView1.Columns[7].Visible = true;
	            GridView1.Columns[9].Visible = false;

                }
                if (menus_update.get_current_lang() == 2)
                {
                    tbl_all.Visible = false;
                    if (GridView1.Rows.Count > 0)
                    { tbl_translate.Visible = true; }
                    else { tbl_translate.Visible = false; Button1.Visible = false; }
                    GridView1.Columns[4].Visible = false;
                    GridView1.Columns[5].Visible = false;
                    GridView1.Columns[6].Visible = false;
                    GridView1.Columns[7].Visible = false;
                    GridView1.Columns[8].Visible = false;
                    GridView1.Columns[9].Visible = true;
                }
                if (menus_update.get_current_lang() == 3)
                {
                    tbl_all.Visible = false;
                    if (GridView1.Rows.Count > 0)
                    { tbl_translate.Visible = true; }
                    else { tbl_translate.Visible = false;
                    Button1.Visible = false;
                    GridView1.EmptyDataText = "عفوآ لا توجد بيانات ";
                    }
                    GridView1.Columns[3].Visible = false;
                    GridView1.Columns[4].Visible = true;
                    GridView1.Columns[5].Visible = false;
                    GridView1.Columns[6].Visible = false;
                    GridView1.Columns[7].Visible = false;
                    GridView1.Columns[8].Visible = false;
                    GridView1.Columns[9].Visible = true;

                }
                //Button1.Visible = false;
                // newobject_tr.Visible = false;
                //tbl_all.Visible = false;

            }
	fillGrid();

        }


    }

    private void filldrop_types()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { };
        DataTable dt = DatabaseFunctions.SelectData(sqlParams, "select_content_types");
        drop_type.DataSource = dt;
        drop_type.DataBind();
        ListItem litem = new ListItem("-- اختر النوع --", "0");
        litem.Selected = true;
        drop_type.Items.Insert(0, litem);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        save();
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
                        }
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
        clog.note_date = DateTime.Now.ToShortDateString();
        clog.lang_id = menus_update.get_current_lang();
        int rslut = contents_log_DB.Save(clog);
    }
    public void save()
    {
        if (content_id.Value != "")
        {
            if (menus_update.get_current_lang() == 1)
            {
                char_moalafat_DT obj = new char_moalafat_DT();
                obj.id = 0;
                if (CDataConverter.ConvertToInt(Smrt_Srch_title.SelectedValue) > 0 && chkcomplete.Checked)
                {
                    obj.content_id = CDataConverter.ConvertToInt(Smrt_Srch_title.SelectedValue);
                }
                else if(chkcandidate.Checked)
                { obj.content_id = 0; }
                else
		{
		   ShowAlertMessage("يجب اختيار اسم عنصر");
		   return;
			}
                obj.char_id = CDataConverter.ConvertToInt(content_id.Value);

                obj.content_type = CDataConverter.ConvertToInt(drop_type.SelectedValue);
                obj.moalaf_type = CDataConverter.ConvertToInt(RadioButtonList1.SelectedValue);
                obj.complete = CDataConverter.ConvertToInt(chkcomplete.Checked);
                obj.candidate = CDataConverter.ConvertToInt(chkcandidate.Checked);
                obj.title_ar = TextBox1.Text;

                int id = char_moalafat_DB.Save(obj);
                //ShowAlertMessage(dt1.Rows.Count.ToString()+","+dt2.Rows.Count.ToString());
		//ShowAlertMessage(id.ToString());

		if (id > 0)
                {
                    fillGrid();
                    log(13);
                    ShowAlertMessage("تم الحفظ");
                }
            }
            if (menus_update.get_current_lang() == 2 || menus_update.get_current_lang() == 3)
            {
                string sql = "";
                if (TextBox2.Text != "")
                {
                    if (menus_update.get_current_lang() == 2)
                    {
                        sql = " update char_moalafat set title_en= '" + TextBox2.Text + "' where id= " + row_id;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        sql = " update char_moalafat set title_fr= '" + TextBox2.Text + "' where id= " + row_id;
                    }
                    General_Helping.ExcuteQuery(sql);

                    row_id = 0;
                    tbl_translate.Visible = true;
                    TextBox2.Text = "";
                    ShowAlertMessage("لقد تم الحفظ");
                    fillGrid();
                }
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
        if (menus_update.get_current_lang() == 1)
        {
            SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@char_id", CDataConverter.ConvertToInt(content_id.Value)) };
            DataTable dt1 = DatabaseFunctions.SelectData(newSqlParams, "char_molafat_select_bycontentid0");
            DataTable dt2 = DatabaseFunctions.SelectData(newSqlParams, "char_molafat_select_bycontentid");
            //ShowAlertMessage(content_id.Value+","+dt1.Rows.Count.ToString()+","+dt2.Rows.Count.ToString());//+id.ToString()
            if (dt1.Rows.Count > 0 || dt2.Rows.Count > 0) //|| dt2.Rows.Count > 0
            {
                
                    dt2.Merge(dt1);
                    GridView1.DataSource = dt2;
                    GridView1.DataBind();
               
            }

        }
        if (menus_update.get_current_lang() == 2 || menus_update.get_current_lang() == 3)
        {
            SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@char_id", CDataConverter.ConvertToInt(content_id.Value)) };
            DataTable dt1 = DatabaseFunctions.SelectData(newSqlParams, "char_molafat_select_bycontentid0");
            if (dt1.Rows.Count > 0)
            {
                GridView1.DataSource = dt1;
                GridView1.DataBind();
            }
        }

        //DataTable dt = char_moalafat_DB.SelectByContent_id(CDataConverter.ConvertToInt(content_id.Value));


    }
    protected void drop_type_SelectedIndexChanged(object sender, EventArgs e)
    {

        string sql = "";
        DataTable dt = new DataTable();
        switch (drop_type.SelectedValue)
        {
            case "6":
                sql = "SELECT content_media.id,dbo.content_media_details.content_media_id, dbo.content_media_details.title from dbo.content_media INNER JOIN";

                sql += " dbo.content_media_details ON dbo.content_media.id = dbo.content_media_details.content_media_id where content_media_type=6 and content_media_details.lang_id=1 order by content_media_details.title asc";
                break;
            case "7":
                sql = "SELECT content_media.id,dbo.content_media_details.content_media_id, dbo.content_media_details.title from dbo.content_media INNER JOIN";

                sql += " dbo.content_media_details ON dbo.content_media.id = dbo.content_media_details.content_media_id where content_media_type=7 and content_media_details.lang_id=1 order by content_media_details.title asc";
                break;
            case "8":

                sql = " SELECT documents.id,dbo.documents_details.doc_id, dbo.documents_details.title from dbo.documents INNER JOIN";
                sql += " dbo.documents_details ON dbo.documents.id = dbo.documents_details.doc_id where documents_details.lang_id=1 and doc_type=3 order by documents_details.title asc";
                break;

            case "9":
                sql = " SELECT documents.id,dbo.documents_details.doc_id, dbo.documents_details.title from dbo.documents INNER JOIN";
                sql += " dbo.documents_details ON dbo.documents.id = dbo.documents_details.doc_id where documents_details.lang_id=1 and doc_type=2 order by documents_details.title asc";
                break;


            case "10":
                sql = " SELECT documents.id ,dbo.documents_details.doc_id, dbo.documents_details.title from dbo.documents INNER JOIN";
                sql += " dbo.documents_details ON dbo.documents.id = dbo.documents_details.doc_id where documents_details.lang_id=1 and doc_type=1 order by documents_details.title asc";
                break;

            case "12":
                sql = "select manuscripts.id,manuscripts_details.manuscript_id, manuscripts_details.title from manuscripts INNER JOIN manuscripts_details";
                sql += " on manuscripts.id = manuscripts_details.manuscript_id where manuscripts_details.lang_id=1 order by manuscripts_details.title asc";
                break;

            case "13":
                sql = "select theses.id,theses_details.these_id, theses_details.title from theses INNER JOIN ";
                sql += " theses_details on theses.id = theses_details.these_id where theses_details.lang_id=1 order by theses_details.title asc";
                break;

            case "14":
                sql = "select conference_proceedings.id,conference_proceedings_details.conference_proceeding_id , conference_proceedings_details.title from conference_proceedings INNER JOIN ";
                sql += "  conference_proceedings_details on conference_proceedings.id = conference_proceedings_details.conference_proceeding_id where conference_proceedings_details.lang_id=1 order by conference_proceedings_details.title asc";
                break;
        }

        //SqlDataAdapter da = new SqlDataAdapter(sql, sqlCon);

        dt = General_Helping.GetDataTable(sql);
        if (CDataConverter.ConvertToInt(drop_type.SelectedValue) > 0)
        {

            if (dt.Rows.Count > 0)
            {
                Smrt_Srch_title.DataSource = dt;
                Smrt_Srch_title.DataBind();

                ListItem litem = new ListItem("-- اختر العنوان --", "0");
                litem.Selected = true;
                Smrt_Srch_title.Items.Insert(0, litem);
            }
	    else
	    {
		Smrt_Srch_title.Items.Clear();
	    }

        }
        else
        {

            //Smrt_Srch_title.Items.Clear();
        }


    }
    protected void Smrt_Srch_title_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (CDataConverter.ConvertToInt(Smrt_Srch_title.SelectedValue) > 0)
        { //id_title.Visible = false; 
        }
        else
        { //id_title.Visible = true; 
        }

    }
    public void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (menus_update.get_current_lang() != 1)
        {
            if (e.CommandName == "TranslateItem")
            { row_id = CDataConverter.ConvertToInt(e.CommandArgument.ToString()); }
        }

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            int type = (int)Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "moalaf_type"));
            Label lab = (Label)e.Row.FindControl("moalaf_type");
            if (type == 1)
            {
                lab.Text = "مؤلف";
            }
            if (type == 2)
            { lab.Text = "مؤلف عنه"; }


            int checed = (int)CDataConverter.ConvertToInt(DataBinder.Eval(e.Row.DataItem, "complete"));
            CheckBox chkcomp = new CheckBox();

            Label element_type_name = (Label)e.Row.FindControl("element_type_name");
            if (checed == 1)
            {
                chkcomp = (CheckBox)e.Row.FindControl("CheckBox1");
                chkcomp.Checked = true;
                //Label element_type_name_hidden = (Label)e.Row.FindControl("element_type_name_hidden");
                //element_type_name.Text = element_type_name_hidden.Text;
            }
            else chkcomp.Checked = true;
            CheckBox chkcand = new CheckBox();
            int checed2 = (int)CDataConverter.ConvertToInt(DataBinder.Eval(e.Row.DataItem, "candidate"));
            //Label VocStat = (Label)e.Row.FindControl("VocStatus");
            if (checed2 == 1)
            {
                chkcand = (CheckBox)e.Row.FindControl("CheckBox2");
                chkcand.Checked = true;
                Label title_ar_hidden = (Label)e.Row.FindControl("title_ar_hidden");
                element_type_name.Text = title_ar_hidden.Text;

            }
            else chkcand.Checked = false;
            if (menus_update.get_current_lang() == 1)
            {
                GridView1.Columns[3].Visible = false;
                GridView1.Columns[4].Visible = false;
                
            }
            if (menus_update.get_current_lang() == 2)
            {
                Label element_type_name_ar = (Label)e.Row.FindControl("element_type_name");
                //Label element_type_name_hidden_ar = (Label)e.Row.FindControl("element_type_name_hidden");
                //element_type_name_ar.Text = element_type_name_hidden_ar.Text;



                Label element_typeen_name = (Label)e.Row.FindControl("element_typeen_name");
                Label element_type_name_hidden = (Label)e.Row.FindControl("element_type_nameen_hidden");
                element_typeen_name.Text = element_type_name_hidden.Text;

                GridView1.Columns[2].Visible = true;
                GridView1.Columns[8].Visible = false;
                GridView1.Columns[4].Visible = false;
                GridView1.Columns[5].Visible = false;
                GridView1.Columns[6].Visible = false;
                GridView1.Columns[7].Visible = false;
                GridView1.Columns[3].Visible = true;
                
            }
            if (menus_update.get_current_lang() == 3)
            {
                Label element_type_name_ar = (Label)e.Row.FindControl("element_type_name");
                //Label element_type_name_hidden_ar = (Label)e.Row.FindControl("element_type_name_hidden");
                //element_type_name_ar.Text = element_type_name_hidden_ar.Text;

                Label element_typefr_name = (Label)e.Row.FindControl("element_typefr_name");
                Label element_type_name_hidden = (Label)e.Row.FindControl("element_type_namefr_hidden");
                element_typefr_name.Text = element_type_name_hidden.Text;
                GridView1.Columns[3].Visible = false;
                GridView1.Columns[5].Visible = false;
                GridView1.Columns[6].Visible = false;
                GridView1.Columns[7].Visible = false;
                GridView1.Columns[8].Visible = false;
                
            }

        }
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
                char_moalafat_DB.Delete(id);
                fillGrid();
                log(40);
            }
        }
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ////if (e.CommandName == "DeleteItem")
        //{   
        //    //int id = Convert.ToInt32(e.CommandArgument.ToString());
        //    id = e.RowIndex + 1;
        //    char_moalafat_DB.Delete(id);
        //    fillGrid();



        //}

    }
    protected void chkcomplete_CheckedChanged(object sender, EventArgs e)
    {
        if (chkcomplete.Checked == false)
        {
            newobject_tr.Visible = true;
            objectname_tr.Visible = false;
        }
        else
        {
            objectname_tr.Visible = true;
            newobject_tr.Visible = false;
            chkcandidate.Checked = false;
        }

    }
    protected void chkcandidate_CheckedChanged(object sender, EventArgs e)
    {
        if (chkcandidate.Checked == false)
        {
            newobject_tr.Visible = true;
            if (Smrt_Srch_title.SelectedIndex > 0)
            { Smrt_Srch_title.SelectedIndex = 0; }
            objectname_tr.Visible = false;
        }
        else
        {
            objectname_tr.Visible = false;

            newobject_tr.Visible = true;
            chkcomplete.Checked = false;
        }

    }

   
    protected void btn_translate_Click(object sender, EventArgs e)
    {

        //int id = Convert.ToInt32(GridView1.FindControl(.CommandArgument.ToString());
        if (content_id.Value != "")
        {
            row_id = CDataConverter.ConvertToInt(((Button)sender).CommandArgument);
            tbl_translate.Visible = true;
            Button1.Visible = true;
            tbl_all.Visible = false;
        }
        //fillGrid();



    }

}
