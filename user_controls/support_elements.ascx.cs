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

public partial class user_controls_support_elements : System.Web.UI.UserControl
{
    General_Helping Obj_General_Helping = new General_Helping();
    contents_relations_DT content_relation_obj_to_save = new contents_relations_DT();
    //public int current_content_id ;//= 62;
    //public int current_content_type ;//= 6;
    protected override void OnInit(EventArgs e)
    {
        this.Smrt_Srch_SupportedElementName.Value_Handler += new support_Smart_Search.Delegate_support_Selected_Value(SupportMOnMember_Data);

    }
    private void SupportMOnMember_Data(string Value)
    {

        ddlNameChanged();
    }
    private void Fill_smart(string Value)
    { //public void fill_objects_titles()
        //{
        string setvalue = "";
        DataTable dt = new DataTable();

        if (Value != "")
        {
            SqlParameter[] sqlParams5 = new SqlParameter[] { new SqlParameter("@content_id",CDataConverter.ConvertToInt(content_id.Value)),
                                                                    new SqlParameter("@content_type",CDataConverter.ConvertToInt(content_type.Value))};

            switch (Value)
            {

                case "5":
                    Smrt_Srch_SupportedElementName.stored = "get_artifacts_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;
                    break;
                case "6":
                    Smrt_Srch_SupportedElementName.stored = "get_video_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;
                    break;
                case "7":
                    Smrt_Srch_SupportedElementName.stored = "get_audio_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;
                    break;
                case "8":
                    Smrt_Srch_SupportedElementName.stored = "get_docs_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;
                    break;
                case "9":
                    Smrt_Srch_SupportedElementName.stored = "get_articles_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;
                    break;
                case "10":
                    Smrt_Srch_SupportedElementName.stored = "get_books_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;
                    break;
                case "11":
                    Smrt_Srch_SupportedElementName.stored = "get_images_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;
                    break;
                case "12":
                    Smrt_Srch_SupportedElementName.stored = "get_manuscripts_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;
                    break;
                case "13":
                    Smrt_Srch_SupportedElementName.stored = "get_theses_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;
                    break;
                case "14":
                    Smrt_Srch_SupportedElementName.stored = "get_conference_proceedings_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;
                    break;
                case "15":
                    Smrt_Srch_SupportedElementName.stored = "get_website_titles_smartSearsh";
                    Smrt_Srch_SupportedElementName.stored_parameters = sqlParams5;

                    break;

            }
           
            
        }

        Smrt_Srch_SupportedElementName.Value_Field = "id";
        Smrt_Srch_SupportedElementName.Text_Field = "title";
        Smrt_Srch_SupportedElementName.DataBind();


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
            { fillSupportedTypeDDL();
            ddlTypeChanged();
            }

            if (Session["user_type"].ToString() == "5")
            {
                gvSupportedElements.Columns[6].Visible = false;
                gvSupportedElements.Columns[5].Visible = false;
               
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
        int rslut = contents_log_DB.Save(clog);
    }
    public void fillSupportedTypeDDL()
    {
        DataTable DT = General_Helping.GetDataTable("select id,title from content_types where id>4 and id<16");
        Obj_General_Helping.SmartBindDDL(ddlSupportedElementType, DT, "id", "title", ".. اختر عنصر ..");

    }
    public void fillGrid()
    {
        if (content_id.Value != "" & content_type.Value != "")
        {

            gvSupportedElements.DataSource = contents_relations_DB.SelectSupportByIDType(CDataConverter.ConvertToInt(content_id.Value), CDataConverter.ConvertToInt(content_type.Value));
            gvSupportedElements.DataBind();
        }
    }
    public void Enabled()
    {
        if (Session["user_type"] != null && Session["user_type"].ToString() == "4")
        {
            if (Request.QueryString["operation"].ToString() == "wrong")
            {
                btnsupsave.Visible = false;
                SqlParameter[] sqlParamse = new SqlParameter[] {new SqlParameter ("@content_type",CDataConverter.ConvertToInt(content_type.Value)),
              new SqlParameter("@content_id",CDataConverter.ConvertToInt(content_id.Value)),
                new SqlParameter("@lang_id",CDataConverter.ConvertToInt(menus_update.get_current_lang()))};

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
            btnsupsave.Visible = false;
            tbl_all.Visible = false;
        }
    }


    protected void ddlSupportedElementType_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblpage.Visible = false;
        ddlTypeChanged();
    }
    public void ddlSupportedElementName_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblpage.Visible = false;
        //SupportddlNameChanged();

    }
    protected void gvSupportedElements_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {


        if ((e.Row.RowType == DataControlRowType.DataRow))
        {
            //assuming that the required value column is the second column in gridview  e.Row.Cells[1].Text 
            TextBox lb = (TextBox)e.Row.FindControl("txtlinkgrd");
            TextBox txtType = (TextBox)e.Row.FindControl("txtTypeName");
            TextBox txtId = (TextBox)e.Row.FindControl("txtNameId");
            switch (txtType.Text)
            {
                case "5":

                    lb.Text = "../Esdarat/artifactsDetails.aspx?id=" + txtId.Text;
                        break;
                case "6":
                    lb.Text = "../media/video_player.aspx?playvideoid=" + txtId.Text;
                    break;
                case "7":
                    lb.Text = "../media/audio_player.aspx.aspx?playaudioid=" + txtId.Text;
                    break;
                case "8":
                    lb.Text = "../Esdarat/document_details.aspx?id=" + txtId.Text;
                    break;
                case "9":
                    lb.Text = "../Esdarat/articles_details.aspx?id=" + txtId.Text;
                    break;
                case "10":
                    lb.Text = "../Esdarat/books_details.aspx?id=" + txtId.Text;
                    break;
                case "11":
                    lb.Text = "../media/photoDetails.aspx?id=" + txtId.Text;
                    break;
                case "12":
                    lb.Text = "../Esdarat/manuscriptDetails.aspx?id=" + txtId.Text;
                    break;
                case "13":
                    lb.Text = "../Elzakera/thesesDetails.aspx?id=" + txtId.Text;
                    break;
                case "14":
                    lb.Text = "../Esdarat/ConferenceProceedDetails.aspx?id=" + txtId.Text;
                    break;
                case "15":
                    lb.Text = "../Esdarat/webSiteDetails.aspx?id=" + txtId.Text;
                    break;

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
    public void btnsupsave_Click(object sender, EventArgs e)
    {
        if (content_id.Value != "" && content_type.Value != "")
        {
            if (CDataConverter.ConvertToInt(Smrt_Srch_SupportedElementName.SelectedValue) > 0)
            {
                content_relation_obj_to_save.id = CDataConverter.ConvertToInt(control_relation_id.Value);
                content_relation_obj_to_save.content_type1 = CDataConverter.ConvertToInt(content_type.Value);
                content_relation_obj_to_save.content_type2 = CDataConverter.ConvertToInt(ddlSupportedElementType.SelectedValue);
                content_relation_obj_to_save.content_id1 = CDataConverter.ConvertToInt(content_id.Value);
                content_relation_obj_to_save.content_id2 = CDataConverter.ConvertToInt(Smrt_Srch_SupportedElementName.SelectedValue);
                content_relation_obj_to_save.relation_id = 0;
                content_relation_obj_to_save.other_relation_ar = "";
                content_relation_obj_to_save.other_relation_en = "";
                content_relation_obj_to_save.other_relation_fr = "";
                contents_relations_DB.Save(content_relation_obj_to_save);
                log(11);
                ShowAlertMessage("تم الحفظ ");
                lblpage.ForeColor = System.Drawing.Color.Green;
                fillGrid();
                control_relation_id.Value = "";
                myRowIndex1.Value = "";
                ddlSupportedElementType.SelectedIndex = -1;
                Smrt_Srch_SupportedElementName.Clear_Controls();
                txtlink.Text = "";
               
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
        TextBox tbcontentId2 = (TextBox)gvSupportedElements.Rows[Int16.Parse(myRowIndex1.Value)].FindControl("contentId2");
        TextBox tbcontentType2 = (TextBox)gvSupportedElements.Rows[Int16.Parse(myRowIndex1.Value)].FindControl("contentType2");
        TextBox tbRelation_id = (TextBox)gvSupportedElements.Rows[Int16.Parse(myRowIndex1.Value)].FindControl("Relation_id");
        TextBox link = (TextBox)gvSupportedElements.Rows[Int16.Parse(myRowIndex1.Value)].FindControl("txtlinkgrd");

        for (int i = 0; i < gvSupportedElements.Rows.Count; i++)
        {
            gvSupportedElements.Rows[i].BackColor = System.Drawing.Color.White;
        }

        gvSupportedElements.Rows[Int16.Parse(myRowIndex1.Value)].BackColor = System.Drawing.Color.Lavender;

        foreach (ListItem item in ddlSupportedElementType.Items)
        {
            item.Selected = false;
        }
        ListItem contentTypeSelectedListItem = ddlSupportedElementType.Items.FindByValue(tbcontentType2.Text);

        if (contentTypeSelectedListItem != null)
        {
            contentTypeSelectedListItem.Selected = true;

        };
        ddlTypeChanged();
        
        Smrt_Srch_SupportedElementName.SelectedValue = tbcontentId2.Text;
        //foreach (ListItem item in ddlSupportElementName.Items)
        //{
        //    item.Selected = false;
        //}
        //ListItem selectedListItem = ddlSupportElementName.Items.FindByValue(tbcontentId2.Text);

        //if (selectedListItem != null)
        //{
        //    selectedListItem.Selected = true;
        //};
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
            log(37);
            lblpage.Visible = true;
            lblpage.Text = "تم الحذف";
            lblpage.ForeColor = System.Drawing.Color.Red;
            fillGrid();
        }
    }
   
    protected void ddlTypeChanged()
    {
        int current_content_id = CDataConverter.ConvertToInt(content_id.Value);
        int current_content_type = CDataConverter.ConvertToInt(content_type.Value);
        lblpage.Visible = false;
        if (ddlSupportedElementType.SelectedIndex != 0)
        {
            //ddlSupportedElementName.Items.Clear();
            //Fill_smart(ddlSupportedElementType.SelectedValue);
            DataTable DT = new DataTable();
            switch (ddlSupportedElementType.SelectedValue)
            {
                case "5":
                    if (current_content_type == 5)
                        DT = General_Helping.GetDataTable("select artifact_id as id,title from artifacts_details join artifacts on artifacts_details.artifact_id=artifacts.id  where lang_id=1 and artifact_id <>" + current_content_id + " order by artifacts_details.title asc");
                    else
                        DT = General_Helping.GetDataTable("select artifact_id as id,title from artifacts_details join artifacts on artifacts_details.artifact_id=artifacts.id where lang_id=1 order by artifacts_details.title asc");
                    txtlink.Text = "";
                    break;
                case "6":
                    if (current_content_type == 6)
                        DT = General_Helping.GetDataTable("select content_media_id as id,title from content_media_details join content_media on content_media_details.content_media_id=content_media.id where content_media.content_media_type=6 and lang_id=1 and content_media_id <>" + current_content_id + "  order by content_media_details.title asc");
                    else
                        DT = General_Helping.GetDataTable("select content_media_id as id,title from content_media_details join content_media on content_media_details.content_media_id=content_media.id where content_media.content_media_type=6 and lang_id=1 order by content_media_details.title asc");
                    txtlink.Text = "../media/video_tracks.aspx";
                    break;
                case "7": 
                    if (current_content_type == 7)
                        DT = General_Helping.GetDataTable("select content_media_id as id,title from content_media_details join content_media on content_media_details.content_media_id=content_media.id where content_media.content_media_type=7 and lang_id=1 and content_media_id <>" + current_content_id + " order by content_media_details.title asc");
                    else
                        DT = General_Helping.GetDataTable("select content_media_id as id,title from content_media_details join content_media on content_media_details.content_media_id=content_media.id where content_media.content_media_type=7 and lang_id=1");
                    txtlink.Text = "../media/audio_tracks.aspx";
                    break;
                case "8":
                    if (current_content_type == 8)
                        DT = General_Helping.GetDataTable("select doc_id as id, title from documents_details join documents on documents_details.doc_id=documents.id where documents.doc_type=3 and lang_id=1 and doc_id <>" + current_content_id + " order by documents_details.title asc");
                    else
                        DT = General_Helping.GetDataTable("select doc_id as id, title from documents_details join documents on documents_details.doc_id=documents.id where documents.doc_type=3 and lang_id=1  order by documents_details.title asc");
                    txtlink.Text = "../Esdarat/list_document.aspx";
                    break;
                case "9":
                    if (current_content_type == 9)
                        DT = General_Helping.GetDataTable("select doc_id as id, title from documents_details join documents on documents_details.doc_id=documents.id where documents.doc_type=2 and lang_id=1 and doc_id <>" + current_content_id + "  order by documents_details.title asc");
                    else
                        DT = General_Helping.GetDataTable("select doc_id as id, title from documents_details join documents on documents_details.doc_id=documents.id where documents.doc_type=2 and lang_id=1 order by documents_details.title asc");
                    txtlink.Text = "~/Esdarat/list_articles.aspx";
                    break;
                case "10": 
                    if (current_content_type == 10)
                        DT = General_Helping.GetDataTable("select doc_id as id, title from documents_details join documents on documents_details.doc_id=documents.id where documents.doc_type=1 and lang_id=1 and doc_id <>" + current_content_id + " order by documents_details.title asc");
                    else
                        DT = General_Helping.GetDataTable("select doc_id as id, title from documents_details join documents on documents_details.doc_id=documents.id where documents.doc_type=1 and lang_id=1 order by documents_details.title asc");
                    txtlink.Text = "../Esdarat/list_characters_books.aspx";
                    break;
                case "11":
                    if (current_content_type == 11)
                        DT = General_Helping.GetDataTable("select content_image_id as id, title from content_images_details join content_images on content_images_details.content_image_id=content_images.id where lang_id=1 and content_image_id <>" + current_content_id + " order by content_images_details.title asc");
                    else
                        DT = General_Helping.GetDataTable("select content_image_id as id, title from content_images_details join content_images on content_images_details.content_image_id=content_images.id where lang_id=1 order by content_images_details.title asc");
                    
                    txtlink.Text = "../media/photo_gallery.aspx";
                    break;
                case "12":
                    if (current_content_type == 12)
                        DT = General_Helping.GetDataTable("select manuscript_id as id,title from manuscripts_details join manuscripts on manuscripts_details.manuscript_id=manuscripts.id where lang_id=1 and manuscript_id <>" + current_content_id + " order by manuscripts_details.title asc");
                    else
                        DT = General_Helping.GetDataTable("select manuscript_id as id,title from manuscripts_details join manuscripts on manuscripts_details.manuscript_id=manuscripts.id where lang_id=1 order by manuscripts_details.title asc");
                    
                    txtlink.Text = "";
                    break;
                case "13":
                    if (current_content_type == 13)
                        DT = General_Helping.GetDataTable("select these_id as id,title from theses_details join theses on theses_details.these_id=theses.id where lang_id=1 and these_id <>" + current_content_id + "  order by theses_details.title asc");
                    else
                        DT = General_Helping.GetDataTable("select these_id as id,title from theses_details join theses on theses_details.these_id=theses.id where lang_id=1 order by theses_details.title asc");
                        txtlink.Text = "";
                    break;
                case "14":
                    if (current_content_type == 14)
                        DT = General_Helping.GetDataTable("select conference_proceeding_id as id,title from conference_proceedings_details join conference_proceedings on conference_proceedings_details.conference_proceeding_id=conference_proceedings.id where lang_id=1 and conference_proceeding_id <>" + current_content_id + " order by conference_proceedings_details.title asc");
                    else
                        DT = General_Helping.GetDataTable("select conference_proceeding_id as id,title from conference_proceedings_details join conference_proceedings on conference_proceedings_details.conference_proceeding_id=conference_proceedings.id where lang_id=1 order by conference_proceedings_details.title asc");
                    txtlink.Text = "";
                    break;
                case "15":
                    if (current_content_type == 15)
                        DT = General_Helping.GetDataTable("select website_id as id,title from WebSites_Template_details join WebSites_Template on WebSites_Template_details.website_id=WebSites_Template.id where lang_id=1 and website_id <>" + current_content_id + " order by WebSites_Template_details.title asc");
                  
                    else
                        DT = General_Helping.GetDataTable("select website_id as id,title from WebSites_Template_details join WebSites_Template on WebSites_Template_details.website_id=WebSites_Template.id where lang_id=1 order by WebSites_Template_details.title asc");
                        txtlink.Text = "";
                    break;

            }
            if (DT.Rows.Count > 0)
            {
                Fill_smart(ddlSupportedElementType.SelectedValue);
                Smrt_Srch_SupportedElementName.Clear_Selected();
            }
            else
                Smrt_Srch_SupportedElementName.Clear_Selected();
            
        }
        else

            Smrt_Srch_SupportedElementName.Clear_Selected();
           
           
       
       
    }
    public void ddlNameChanged()
    {
        if (Smrt_Srch_SupportedElementName.SelectedValue != "" && Smrt_Srch_SupportedElementName.SelectedValue != "--- البحث بالكود ----")
        {
            
                switch (ddlSupportedElementType.SelectedValue)
                {
                    case "5":

                        txtlink.Text = "../Esdarat/artifactsDetails.aspx?id=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                    case "6":
                        txtlink.Text = "../media/video_player.aspx?playvideoid=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                    case "7":
                        txtlink.Text = "../media/audio_player.aspx.aspx?playaudioid=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                    case "8":
                        txtlink.Text = "../Esdarat/document_details.aspx?id=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                    case "9":
                        txtlink.Text = "../Esdarat/articles_details.aspx?id=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                    case "10":
                        txtlink.Text = "../Esdarat/books_details.aspx?id=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                    case "11":
                  
                        txtlink.Text = "../media/photoDetails.aspx?id=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                    case "12":
                        txtlink.Text = "../Esdarat/manuscriptDetails.aspx?id=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                         case "13":
                        txtlink.Text = "../Elzakera/thesesDetails.aspx?id=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                         case "14":
                        txtlink.Text = "../Esdarat/ConferenceProceedDetails.aspx?id=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                         case "15":
                        txtlink.Text = "../Esdarat/webSiteDetails.aspx?id=" + Smrt_Srch_SupportedElementName.SelectedValue;
                        break;
                        
                       

                }

        }
    }
   
}
