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

public partial class user_controls_main_elements : System.Web.UI.UserControl
{
    General_Helping Obj_General_Helping = new General_Helping();
    contents_relations_DT content_relation_obj_to_save = new contents_relations_DT();
   // public int current_content_id ;//= 62;
   // public int current_content_type;//=6;

   

    protected override void OnInit(EventArgs e)
    {
        this.Smrt_Srch_MainElementName.Value_Handler += new Smart_Search.Delegate_Selected_Value(MainMOnMember_Data);

    }
    private void MainMOnMember_Data(string Value)
    {
        ddlNameChanged();
    }


    private void Fill_smart(string Value)
    { //public void fill_objects_titles()
        //{
        string setvalue = "";
        DataTable dt = new DataTable();
        if (Request["operation"].ToString() == "new")
            setvalue = "20";
        if (Request["operation"].ToString() == "unfinished")
            setvalue = "21";
        if (Request["operation"].ToString() == "wrong")
            setvalue = "25";
        if (Value != "")
        {
            switch (Value)
            {

                case "1":
                    SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@content_id", content_id.Value),
                                                                    new SqlParameter("@content_type", content_type.Value)};
                    Smrt_Srch_MainElementName.stored = "get_characters_titles_smartSearsh";
                    Smrt_Srch_MainElementName.stored_parameters = sqlParams1;
                    break;
                case "2":
                    SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@content_id", content_id.Value),
                                                                    new SqlParameter("@content_type", content_type.Value)};

                    Smrt_Srch_MainElementName.stored = "get_events_titles_smartSearsh";
                    Smrt_Srch_MainElementName.stored_parameters = sqlParams2;
                    break;
                case "3":
                    SqlParameter[] sqlParams3 = new SqlParameter[] { new SqlParameter("@content_id", content_id.Value),
                                                                    new SqlParameter("@content_type", content_type.Value)};
                    Smrt_Srch_MainElementName.stored = "get_topics_titles_smartSearsh";
                    Smrt_Srch_MainElementName.stored_parameters = sqlParams3;
                    break;
                case "4":
                    SqlParameter[] sqlParams4 = new SqlParameter[] { new SqlParameter("@content_id", content_id.Value),
                                                                    new SqlParameter("@content_type", content_type.Value)};

                    Smrt_Srch_MainElementName.stored = "get_places_titles_smartSearsh";
                    Smrt_Srch_MainElementName.stored_parameters = sqlParams4;
                    break;

            }
        }

        Smrt_Srch_MainElementName.Value_Field = "id";
        Smrt_Srch_MainElementName.Text_Field = "title";
        Smrt_Srch_MainElementName.DataBind();


    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (content_type.Value != "" && content_id.Value != "")
        {


            ddlNameChanged();


        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        { fillMainTypeDDL();
        ddlTypeChanged();
        }
       
         if (Session["user_type"] != null)
        {
       
            fillGrid();

            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {

                btnsave.Visible = false;
                Enabled();
            }
            if (Session["user_type"].ToString() == "5")
            {
                btnsave.Visible = false;
                tbl_all.Visible = false;
                gvMainElements.Columns[6].Visible = false;
                gvMainElements.Columns[5].Visible = false;
               
            }
        }
    }

    public int gridCount
    {

        get
        {
            return gvMainElements.Rows.Count;
        }


    }

    public void log(int operation_id)
    {
        if (content_type.Value !="" & content_id.Value != "")
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
    }
    public void Enabled()
    {
     if (Session["user_type"] != null && Session["user_type"].ToString() == "4")
        {
            if (Request.QueryString["operation"].ToString() == "wrong")
            {
                btnsave.Visible = false;
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
            btnsave.Visible = false;
            tbl_all.Visible = false;
        }
    }
    public void fillMainTypeDDL()
    {
        DataTable DT = General_Helping.GetDataTable("select id,title from content_types where id<5");
        Obj_General_Helping.SmartBindDDL(ddlMainElementType, DT, "id", "title", ".. اختر عنصر ..");
        
    }
    public void fillGrid()
    {
        if (content_id.Value != "" && content_type.Value != "")
        {
            gvMainElements.DataSource = contents_relations_DB.SelectByIDType(CDataConverter.ConvertToInt(content_id.Value), CDataConverter.ConvertToInt(content_type.Value));
            gvMainElements.DataBind();
        }
    }
    protected void ddlMainElementType_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblpage.Visible = false;
        ddlTypeChanged();
    }
    protected void ddlMainElementName_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblpage.Visible = false;
        ddlNameChanged();
 
    }
    public void btnsave_Click(object sender, EventArgs e)
    {
        if (content_id.Value != "" && content_type.Value != "")
        {
            if (CDataConverter.ConvertToInt(Smrt_Srch_MainElementName.SelectedValue) > 0)
            {
                content_relation_obj_to_save.id = CDataConverter.ConvertToInt(control_relation_id.Value);
                content_relation_obj_to_save.content_type1 = CDataConverter.ConvertToInt(content_type.Value);
                content_relation_obj_to_save.content_type2 = ddlMainElementType.SelectedIndex;
                content_relation_obj_to_save.content_id1 = CDataConverter.ConvertToInt(content_id.Value);
                content_relation_obj_to_save.content_id2 = CDataConverter.ConvertToInt(Smrt_Srch_MainElementName.SelectedValue);
                content_relation_obj_to_save.relation_id = CDataConverter.ConvertToInt(ddlMainElementRelationName.SelectedValue);
                content_relation_obj_to_save.other_relation_ar = "";
                content_relation_obj_to_save.other_relation_en = "";
                content_relation_obj_to_save.other_relation_fr = "";
                contents_relations_DB.Save(content_relation_obj_to_save);
                log(10);
                //lblpage.Visible = true;
                //lblpage.Text = "تم الحفظ";
                ShowAlertMessage("تم الحفظ");
                lblpage.ForeColor = System.Drawing.Color.Green;
                fillGrid();
                control_relation_id.Value = "";
                myRowIndex1.Value = "";
                ddlMainElementType.SelectedIndex = -1;
                //ddlMainElementName.SelectedIndex = -1;
                Smrt_Srch_MainElementName.Clear_Controls();
                txtlink.Text = "";
                ddlMainElementRelationName.SelectedIndex = -1;
            }
            else
            {
                lblpage.Visible = true;
                lblpage.Text = "* عفوا يجب القيام بإختيار";
                lblpage.ForeColor = System.Drawing.Color.Red;
            }
        }
        else { ShowAlertMessage("يجب اختيار نوع العنصر والاسم أولاً"); }
    }
    public void ImgBtnEdit_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        lblpage.Visible = false;
        control_relation_id.Value = ((ImageButton)sender).CommandArgument;
        myRowIndex1.Value = ((ImageButton)sender).CommandName;
        TextBox tbcontentId2 = (TextBox)gvMainElements.Rows[Int16.Parse(myRowIndex1.Value)].FindControl("contentId2");
        TextBox tbcontentType2 = (TextBox)gvMainElements.Rows[Int16.Parse(myRowIndex1.Value)].FindControl("contentType2");
        TextBox tbRelation_id = (TextBox)gvMainElements.Rows[Int16.Parse(myRowIndex1.Value)].FindControl("Relation_id");
        TextBox link = (TextBox)gvMainElements.Rows[Int16.Parse(myRowIndex1.Value)].FindControl("txtlinkgrd");

        
        for (int i=0 ;i<gvMainElements.Rows.Count;i++)
        {
           gvMainElements.Rows[i].BackColor = System.Drawing.Color.White;
        }
       
        gvMainElements.Rows[Int16.Parse(myRowIndex1.Value)].BackColor = System.Drawing.Color.Lavender;
       
        foreach (ListItem item in ddlMainElementType.Items)
        {
            item.Selected = false;
        }
        ListItem contentTypeSelectedListItem = ddlMainElementType.Items.FindByValue(tbcontentType2.Text);

        if (contentTypeSelectedListItem != null)
        {
            contentTypeSelectedListItem.Selected = true;
            
        };
        ddlTypeChanged();
        //ddlMainElementName.SelectedIndex = -1;
        //ListItem selectedListItem = ddlMainElementName.Items.FindByValue(tbcontentId2.Text);
        Smrt_Srch_MainElementName.SelectedValue = tbcontentId2.Text;
        //ddlMainElementName.SelectedValue = tbcontentId2.Text;
        //if (selectedListItem != null)
        //{
        //    selectedListItem.Selected = true;
        //};

        if (CDataConverter.ConvertToInt(ddlMainElementRelationName.Items.Count) > 0)
        {
            foreach (ListItem item in ddlMainElementRelationName.Items)
            {
                item.Selected = false;
            }
            ListItem RelationSelectedListItem = ddlMainElementRelationName.Items.FindByValue(tbRelation_id.Text);

            if (RelationSelectedListItem != null)
            {
                RelationSelectedListItem.Selected = true;
            };
        }
        txtlink.Text = link.Text;
    }
    public void ImgBtnDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        if (Session["user_type"].ToString() == "5")
        { ShowAlertMessage("عفواً لايمكنك الحذف"); }
        else
        {
            int delete_id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            contents_relations_DB.Delete(delete_id);
            log(39);
            lblpage.Visible = true;
            lblpage.Text = "تم الحذف";
            lblpage.ForeColor = System.Drawing.Color.Red;
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
    protected void ddlMainElementRelationName_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlNameChanged();
    }
    public void ddlNameChanged()
    {
        if (Smrt_Srch_MainElementName.SelectedValue != "" && Smrt_Srch_MainElementName.SelectedValue != "--- البحث بالكود ----")
        {

           
            switch (ddlMainElementType.SelectedValue)
                {
                    case "1":
                        txtlink.Text = "../sheikhs/characters_details.aspx?id=" + Smrt_Srch_MainElementName.SelectedValue;
                        break;
                    case "2":
                        txtlink.Text = "../events/event_details.aspx?id=" + Smrt_Srch_MainElementName.SelectedValue;
                        break;
                    case "3":
                        txtlink.Text = "../topics/topic_details.aspx?id=" + Smrt_Srch_MainElementName.SelectedValue;
                        break;
                    case "4":
                        txtlink.Text = "../places/places_details.aspx?id=" + Smrt_Srch_MainElementName.SelectedValue;
                        break;
                }

           
        }
    }

    protected void ddlTypeChanged()
    {
        lblpage.Visible = false;
        if (ddlMainElementType.SelectedIndex != 0)
        {
            int current_content_id = CDataConverter.ConvertToInt(content_id.Value);
            int current_content_type = CDataConverter.ConvertToInt(content_type.Value);
            DataTable DT = new DataTable();
           switch (ddlMainElementType.SelectedIndex)
           {
               case 1:
                   if (current_content_type == 1)
                       DT = General_Helping.GetDataTable("select char_id as id,name as title from characters_details where lang_id=1 and char_id <>" + current_content_id + "  order by title asc");
                   else
                       DT = General_Helping.GetDataTable("select char_id as id,name as title from characters_details where lang_id=1 order by title asc");
                   txtlink.Text = "../sheikhs/Default.aspx";
                   break;
               case 2:
                   if (current_content_type == 2)
                       DT = General_Helping.GetDataTable("select event_id as id,title from events_details where lang_id=1 and event_id <>" + current_content_id + "  order by events_details.title asc");
                   else
                       DT = General_Helping.GetDataTable("select event_id as id,title from events_details where lang_id=1 order by events_details.title asc");
                   txtlink.Text = "../events/Default.aspx";
                   break;

               case 3:
                   if (current_content_type == 3)
                       DT = General_Helping.GetDataTable("select topic_id as id,title from topics_details where lang_id=1 and topic_id <>" + current_content_id + "  order by topics_details.title asc");
                   else
                       DT = General_Helping.GetDataTable("select topic_id as id,title from topics_details where lang_id=1 order by topics_details.title asc");
                   txtlink.Text = "../topics/Default.aspx";
                   break;
               case 4:
                   if (current_content_type == 4)
                       DT = General_Helping.GetDataTable("select place_id as id,name as title from places_details where lang_id=1 and  place_id <>" + current_content_id + "  order by title asc");
                   else
                       DT = General_Helping.GetDataTable("select place_id as id,name as title from places_details where lang_id=1  order by title asc");
                   txtlink.Text = "../places/Default.aspx";
                   break;
           }
           
           if (DT.Rows.Count > 0)
           {//    Obj_General_Helping.SmartBindDDL(ddlMainElementName, DT, "id", "title", ".. اختر اسم ..");
               Fill_smart(ddlMainElementType.SelectedValue);
               Smrt_Srch_MainElementName.Clear_Selected();
           }
           else
           { Smrt_Srch_MainElementName.Clear_Selected(); }
           
            
            DataTable DT1 = General_Helping.GetDataTable("select id,title_ar from relations where content_type1=" + CDataConverter.ConvertToInt(content_type.Value) + " and content_type2=" + ddlMainElementType.SelectedIndex + " or  content_type1=" + ddlMainElementType.SelectedIndex + " and content_type2=" +CDataConverter.ConvertToInt(content_type.Value));
            if (DT1.Rows.Count > 0)
                Obj_General_Helping.SmartBindDDL(ddlMainElementRelationName, DT1, "id", "title_ar", ".. اختر علاقة ..");
            else
                ddlMainElementRelationName.Items.Clear();
        }
        else
        {
            Smrt_Srch_MainElementName.Clear_Selected();
            ddlMainElementRelationName.Items.Clear();
        }
    }
    protected void gvMainElements_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {

       
        if ((e.Row.RowType == DataControlRowType.DataRow))
        {
            //assuming that the required value column is the second column in gridview  e.Row.Cells[1].Text 
            TextBox lb = (TextBox)e.Row.FindControl("txtlinkgrd");
            TextBox txtType = (TextBox)e.Row.FindControl("txtTypeName");
            TextBox txtId = (TextBox)e.Row.FindControl("txtNameId");
            switch (txtType.Text)
            {
                case "1":
                    lb.Text="../sheikhs/characters_details.aspx?id="+txtId.Text;
                    break;
                case "2":
                    lb.Text = "../events/event_details.aspx?id=" + txtId.Text;
                    break;
                case "3":
                    lb.Text = "../topics/topic_details.aspx?id=" + txtId.Text;
                    break;
                case "4":
                    lb.Text = "../places/places_details.aspx?id=" + txtId.Text;
                    break;

            }

           
        }
    }
}
