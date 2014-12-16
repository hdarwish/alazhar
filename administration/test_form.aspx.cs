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
public partial class administration_test_form : System.Web.UI.Page
{
    General_Helping Obj_General_Helping = new General_Helping();

    protected override void OnInit(EventArgs e)
    {
       
        // Smrt_Srch_title.Query = "select id,title from documents_details where lang_id=1 ";

     
        this.Smart_Search_main_elements.Value_Handler += new Smart_Search.Delegate_Selected_Value(MOnMember_Data);
        //base.OnInit(e);
    }

    private void MOnMember_Data(string Value)
    {
        if (Value != "")
        {

            
            switch (Value)
            {
                case "1":
                    SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", ""), new SqlParameter("@selview", CDataConverter.ConvertToInt(0)), new SqlParameter("@user_id", "0") };
                    //dt = DatabaseFunctions.SelectData(sqlParams1, "get_characters_titles");
                    Smart_Search_support_elements.stored = "get_characters_titles";
                    Smart_Search_support_elements.stored_parameters = sqlParams1;
                    break;
                case "2":
                    SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@event_name", ""), new SqlParameter("@selview", CDataConverter.ConvertToInt(0)), new SqlParameter("@user_id", "0") };
                    //dt = DatabaseFunctions.SelectData(sqlParams2, "get_events_titles");
                    Smart_Search_support_elements.stored = "get_events_titles";
                    Smart_Search_support_elements.stored_parameters = sqlParams2;
                    break;
                case "3":
                    SqlParameter[] sqlParams3 = new SqlParameter[] { new SqlParameter("@topic_name", ""), new SqlParameter("@selview", CDataConverter.ConvertToInt(0)), new SqlParameter("@user_id", "0") };
                    //dt = DatabaseFunctions.SelectData(sqlParams3, "get_topics_titles");
                    Smart_Search_support_elements.stored = "get_topics_titles";
                    Smart_Search_support_elements.stored_parameters = sqlParams3;
                    break;
                case "4":
                    //dt = DatabaseFunctions.SelectData(stored_parameters, "get_characters_titles");
                    break;
                case "5":
                    // dt = DatabaseFunctions.SelectData(stored_parameters, "get_characters_titles");
                    break;
                case "6":
                    SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", ""), new SqlParameter("@selview", CDataConverter.ConvertToInt(0)), new SqlParameter("@user_id", "0") };
                    //dt = DatabaseFunctions.SelectData(sqlParams6, "get_video_titles");
                    Smart_Search_support_elements.stored = "get_video_titles";
                    Smart_Search_support_elements.stored_parameters = sqlParams6;
                    break;
                case "7":
                    SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", CDataConverter.ConvertToInt(0)), new SqlParameter("@user_id", "0") };
                    //dt = DatabaseFunctions.SelectData(sqlParams7, "get_audio_titles");
                    Smart_Search_support_elements.stored = "get_audio_titles";
                    Smart_Search_support_elements.stored_parameters = sqlParams7;
                    break;
                case "8":
                    SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", ""), new SqlParameter("@selview", CDataConverter.ConvertToInt(0)), new SqlParameter("@user_id", "0") };
                    //dt = DatabaseFunctions.SelectData(sqlParams8, "get_docs_titles");
                    Smart_Search_support_elements.stored = "get_docs_titles";
                    Smart_Search_support_elements.stored_parameters = sqlParams8;
                    break;
                case "9":
                    SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", ""), new SqlParameter("@selview", CDataConverter.ConvertToInt(0)), new SqlParameter("@user_id", "0") };
                    //dt = DatabaseFunctions.SelectData(sqlParams9, "get_articles_titles");
                    Smart_Search_support_elements.stored = "get_articles_titles";
                    Smart_Search_support_elements.stored_parameters = sqlParams9;
                    break;
                case "10":
                    SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", ""), new SqlParameter("@selview", CDataConverter.ConvertToInt(0)), new SqlParameter("@user_id", "0") };
                    //dt = DatabaseFunctions.SelectData(sqlParams10, "get_books_titles");
                    Smart_Search_support_elements.stored = "get_books_titles";
                    Smart_Search_support_elements.stored_parameters = sqlParams10;
                    break;
                case "11":
                    SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", ""), new SqlParameter("@selview", CDataConverter.ConvertToInt(0)), new SqlParameter("@user_id", "0") };
                    //dt = DatabaseFunctions.SelectData(sqlParams11, "get_images_titles");
                    Smart_Search_support_elements.stored = "get_images_titles";
                    Smart_Search_support_elements.stored_parameters = sqlParams11;
                    break;
            }
           
            
            Smart_Search_support_elements.Value_Field = "id";
            Smart_Search_support_elements.Text_Field = "title";
            Smart_Search_support_elements.DataBind();
            
            //    Clear_Cntrl();
        //    Fil_Dll();
        //    pnl_bil.Visible = true;
        //    Fil_Grid_bil();
        //    Fil_Grd_Dtl_Init(Get_Bil_Dtl_Init());


        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HiddenField Hfield_content_type2 = (HiddenField)places_form1.FindControl("content_type");
            Hfield_content_type2.Value = "4";
            HiddenField Hfield_content_id2 = (HiddenField)places_form1.FindControl("content_id");
            Hfield_content_id2.Value = "1";
            //places_form1.filldata();
            //places_form1.fillGridVeiws();
            SqlParameter[] typeSqlParams = new SqlParameter[] { new SqlParameter("@id", CDataConverter.ConvertToInt(0)) };
            Smart_Search_main_elements.stored = "content_types_Select";
            Smart_Search_main_elements.stored_parameters = typeSqlParams;
            Smart_Search_main_elements.Value_Field = "id";
            Smart_Search_main_elements.Text_Field = "title";
            Smart_Search_main_elements.DataBind();
          
            //Smrt_Srch_title.sql_Connection = sqlCon;
           
        }



        //if (CDataConverter.ConvertToInt(ddlElementType.SelectedValue) > 0)
        //    Session["type"] = ddlElementType.SelectedValue;
        //else
        //    Session["type"] = "";
        //if (CDataConverter.ConvertToInt(ddlElementName.SelectedValue) > 0)
        //    Session["name"] = ddlElementName.SelectedValue;
        //else
        //    Session["name"] = "";
        //if (Session["type"] != null && Session["name"] != null)
        //{
        //    if (Session["type"].ToString() != "" && Session["name"].ToString() != "")
        //    {
        //        //Control c1 = LoadControl("~/user_controls/video_form.ascx");
        //        divForm.Controls.Clear();
        //        Response.Cache.SetNoStore();
        //        switch (CDataConverter.ConvertToInt(ddlElementType.SelectedValue))
        //        {
                        
        //            case 1:
        //                break;
        //            case 2:
        //                break;
        //            case 3:
        //                break;
        //            case 4:
        //                break;
        //            case 5: 
        //                break;
        //            case 6:
        //                user_controls_video_form ucf6 = LoadControl("~/user_controls/video_form.ascx") as user_controls_video_form;
        //                divForm.Controls.Add(ucf6);
        //                //ucf6.content_id = CDataConverter.ConvertToInt(ddlElementName.SelectedValue);
                       
        //                break;
        //            case 7:
        //                user_controls_audio_form ucf7 = LoadControl("~/user_controls/audio_form.ascx") as user_controls_audio_form;
        //                divForm.Controls.Add(ucf7);
        //                //ucf7.content_id = CDataConverter.ConvertToInt(ddlElementName.SelectedValue);
        //                break;
        //            case 8:
        //                break;
        //            case 9:
        //                break;
        //            case 10: 
        //                break;
        //            case 11:
        //                user_controls_photo_form ucf11 = LoadControl("~/user_controls/photo_form.ascx") as user_controls_photo_form;
        //                divForm.Controls.Add(ucf11);
        //               // ucf11.content_id = CDataConverter.ConvertToInt(ddlElementName.SelectedValue);
        //                break;
                  
        //        }
                
               


                //Control c2 = LoadControl("~/user_controls/main_elements.ascx");

                //divMain.Controls.Clear();
                //user_controls_main_elements ucme = LoadControl("~/user_controls/main_elements.ascx") as user_controls_main_elements;
                //divMain.Controls.Add(ucme);
                //ucme.current_content_id = CDataConverter.ConvertToInt(ddlElementName.SelectedValue);
                //ucme.current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);

                //Control c3 = LoadControl("~/user_controls/support_elements.ascx");
                //divSupport.Controls.Clear();
                //user_controls_support_elements ucse = LoadControl("~/user_controls/support_elements.ascx") as user_controls_support_elements;
                //divSupport.Controls.Add(ucse);
                //ucse.current_content_id = CDataConverter.ConvertToInt(ddlElementName.SelectedValue);
                //ucse.current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
     }
      
//    private void fillMainTypeDDL()
//    {
//        DataTable DT = General_Helping.GetDataTable("select id,title from content_types");
//        Obj_General_Helping.SmartBindDDL(ddlElementType, DT, "id", "title", ".. اختر عنصر ..");

//    }
//    protected void ddlElementType_SelectedIndexChanged(object sender, EventArgs e)
//    {
//        //lblpage.Visible = false;
//        ddlTypeChanged();
       
//    }
//    protected void ddlElementName_SelectedIndexChanged(object sender, EventArgs e)
//    {
       
//    }
//    protected void ddlTypeChanged()
//    {
//        //lblpage.Visible = false;
//        if (ddlElementType.SelectedIndex != 0)
//        {
//            DataTable DT = new DataTable();
//            switch (ddlElementType.SelectedIndex)
//            {
//                case 1: DT = General_Helping.GetDataTable("select char_id as id,name as title from characters_details"); break;
//                case 2: DT = General_Helping.GetDataTable("select event_id as id,title from events_details"); break;
//                case 3: DT = General_Helping.GetDataTable("select topic_id as id,title from topics_details"); break;
//                case 6: DT = General_Helping.GetDataTable("select content_media_id as id,title from content_media_details join content_media on content_media_details.content_media_id=content_media.id where content_media.content_media_type=6"); break;
//                case 7: DT = General_Helping.GetDataTable("select content_media_id as id,title from content_media_details join content_media on content_media_details.content_media_id=content_media.id where content_media.content_media_type=7"); break;
//                case 8: DT = General_Helping.GetDataTable("select doc_id as id, title from documents_details join documents on documents_details.doc_id=documents.id where documents.doc_type=3"); break;
//                case 9: DT = General_Helping.GetDataTable("select doc_id as id, title from documents_details join documents on documents_details.doc_id=documents.id where documents.doc_type=2"); break;
//                case 10: DT = General_Helping.GetDataTable("select doc_id as id, title from documents_details join documents on documents_details.doc_id=documents.id where documents.doc_type=1"); break;
//                case 11: DT = General_Helping.GetDataTable("select content_id as id, title from content_images"); break;


//            }
//            if (DT.Rows.Count > 0)
//                Obj_General_Helping.SmartBindDDL(ddlElementName, DT, "id", "title", ".. اختر اسم ..");
//            else
//                ddlElementName.Items.Clear();

//        }
//        else
//        {
//            ddlElementName.Items.Clear();
//            divForm.Controls.Clear();
//            divMain.Controls.Clear();
//            divSupport.Controls.Clear();

//        }
//    }
}
