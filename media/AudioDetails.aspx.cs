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

public partial class Media_AudioDetails : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[20];
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlGenericControl div_related = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_related");
        div_related.Visible = false;
      //  if (!IsPostBack)
        {
            int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
            HiddenID2.Value = id.ToString();
            if (id != 0)
            {
                Session["content_id"] = id.ToString();
                Session["content_type"] = "7";
                //Session["referred"] = "true";
                //fillcheck_periods();
                View();

            }
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                tr_title.Attributes["class"] = "accordion_title_enfr";
                //traudiotit.Attributes["class"] = "accordion_body_enfr";
                Tr5.Attributes["class"] = "accordion_title_enfr";
                trcatagory.Attributes["class"] = "accordion_body_enfr";
                Tr7.Attributes["class"] = "accordion_title_enfr";
                trdescrption.Attributes["class"] = "accordion_body_enfr";
                Tr2.Attributes["class"] = "accordion_title_enfr";
                treposideno.Attributes["class"] = "accordion_body_enfr";
                Tr4.Attributes["class"] = "accordion_title_enfr";
                trperiod.Attributes["class"] = "accordion_body_enfr";
                tr3.Attributes["class"] = "accordion_title_enfr";
                trguest.Attributes["class"] = "accordion_body_enfr";
                tr10.Attributes["class"] = "accordion_title_enfr";
                trguestpos.Attributes["class"] = "accordion_body_enfr";
                tr6.Attributes["class"] = "accordion_title_enfr";
                trinterviwer.Attributes["class"] = "accordion_body_enfr";
                trrecorddate2.Attributes["class"] = "accordion_title_enfr";
                trrecorddata.Attributes["class"] = "accordion_body_enfr";
                tr13.Attributes["class"] = "accordion_title_enfr";
                trresource.Attributes["class"] = "accordion_body_enfr";
                tr15.Attributes["class"] = "accordion_title_enfr";
                trresourcename.Attributes["class"] = "accordion_body_enfr";
                trcountry2.Attributes["class"] = "accordion_title_enfr";
                trcountry.Attributes["class"] = "accordion_body_enfr";
                trsourcecity.Attributes["class"] = "accordion_title_enfr";
                trcity.Attributes["class"] = "accordion_body_enfr";
                trsaveno.Attributes["class"] = "accordion_title_enfr";
                trsaveno2.Attributes["class"] = "accordion_body_enfr";
                trresourcenotes.Attributes["class"] = "accordion_title_enfr";
                trresourcenotes2.Attributes["class"] = "accordion_body_enfr";
                tr120.Attributes["class"] = "accordion_title_enfr";
                trnotes.Attributes["class"] = "accordion_body_enfr";




           }

            //-------------------------clored the Divs-------------------------------------
            for (int y = 0; y < count_fields; y = y + 2)
            {
                if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                {
                    changeDiv_cssClass(sender, e, arr_divs[y], "accordion_title_enfr2");
                    if (arr_divs[y + 1] != null)
                    {
                        changeDiv_cssClass(sender, e, arr_divs[y + 1], "accordion_title_enfr");
                    }
                }
                else
                {
                    changeDiv_cssClass(sender, e, arr_divs[y], "accordion_title2");
                    if (arr_divs[y + 1] != null)
                    {
                        changeDiv_cssClass(sender, e, arr_divs[y + 1], "accordion_title");
                    }
                }
            }
        }
    }

    public string Get_Path()
    {
        string path = "";
        content_media_DT media_obj_to_veiw = new content_media_DT();
        media_obj_to_veiw = content_media_DB.SelectByID(Convert.ToInt16(HiddenID2.Value));

        path += ResolveUrl("~/upload/audio/" + media_obj_to_veiw.file_name.ToString() + media_obj_to_veiw.extension.ToString());
        return path;
    }
    public void View()
    {
        int j = 0;

        content_media_DT media_obj_to_veiw = new content_media_DT();
        content_media_details_DT media_details_obj_to_veiw = new content_media_details_DT();


        media_obj_to_veiw = content_media_DB.SelectByID(Convert.ToInt16(HiddenID2.Value));
        media_details_obj_to_veiw = content_media_details_DB.SelectByID(Convert.ToInt16(HiddenID2.Value), menus_update.get_current_lang());


        if (media_obj_to_veiw != null)
        {
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                if (media_obj_to_veiw.form_status != 12)
                    Response.Redirect("~/media/audio_list.aspx");
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                if (media_obj_to_veiw.form_status_en != 12)
                    Response.Redirect("~/media/audio_list.aspx");
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                if (media_obj_to_veiw.form_status_fr != 12)
                    Response.Redirect("~/media/audio_list.aspx");
            }
        }

        else
            Response.Redirect("~/media/audio_list.aspx");
       

       //---------------------------------------------------------------------  no 0 -------------------------------------------------------------------------------------
        if (media_details_obj_to_veiw.title != null && media_details_obj_to_veiw.title != "")
        { Label9.Text = media_details_obj_to_veiw.title;
        count_fields = count_fields + 1;
        arr_divs[j] = "tr_title";
        j = j + 1;
        }
        else
        {
           // traudiotit.Visible = 
                tr_title.Visible = false; 
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.content_url!= null && media_details_obj_to_veiw.content_url != "")
        {
            string pattern = @"\www";
            System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex(pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions. MatchCollection matches = rgx.Matches(media_details_obj_to_veiw.content_url.ToString());
            if (matches.Count > 0 &&  media_details_obj_to_veiw.content_url != "")
            {
                string str = media_details_obj_to_veiw.content_url;
                int x = str.IndexOf("//www");
                str = str.Remove(0, x);
                str = str.Replace("watch?v=", "embed/");
                audframe.Attributes["src"] = str;
            }
            else
            { frame_url.Visible = false; }
        }
        else { frame_url.Visible = false; }
        //----------------------------------------------------------------- no 1  -----------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.category != null && media_details_obj_to_veiw.category != "")
        {
            if (media_details_obj_to_veiw.lang_id == "1")
            {
                switch (media_details_obj_to_veiw.category)
                {

                    case "1":
                        catagory.Text = "برنامج فني";
                        break;

                    case "2":
                        catagory.Text = "برنامج وثائقي";
                        break;

                    case "3":
                        catagory.Text = "مسلسلات ودراما";
                        break;


                    case "4":
                        catagory.Text = "كلمة لمناسبة معينة";
                        break;

                    case "5":
                        catagory.Text = "برنامج حواري";
                        break;

                    case "6":
                        catagory.Text = "فيلم تسجيلي";
                        break;


                    case "7":
                        catagory.Text = "برنامج رياضي";
                        break;

                    case "8":
                        catagory.Text = "برامج دينية";
                        break;

                    case "9":
                        catagory.Text = "خطبة";
                        break;

                    case "10":
                        catagory.Text = "برنامج تثقيفي";
                        break;


                    case "11":
                        catagory.Text = "برنامج أطفال";
                        break;

                    case "12":
                        catagory.Text = "أخرى";
                        break;

                }
            }
            else if (media_details_obj_to_veiw.lang_id == "2")
            {
                switch (media_details_obj_to_veiw.category)
                {

                    case "1":
                        catagory.Text = "Art Program";
                        break;

                    case "2":
                        catagory.Text = "Documentary Program";
                        break;

                    case "3":
                        catagory.Text = "Series and Drama";
                        break;


                    case "4":
                        catagory.Text = "Word For Specific Occasion";
                        break;

                    case "5":
                        catagory.Text = "Talk show";
                        break;

                    case "6":
                        catagory.Text = "A documentary film";
                        break;


                    case "7":
                        catagory.Text = "Athletic program";
                        break;

                    case "8":
                        catagory.Text = "Religious programs";
                        break;

                    case "9":
                        catagory.Text = "Sermon";
                        break;

                    case "10":
                        catagory.Text = "Educational program";
                        break;


                    case "11":
                        catagory.Text = "Children program";
                        break;

                    case "12":
                        catagory.Text = "Other";
                        break;

                }
            }

            count_fields = count_fields + 1;
            arr_divs[j] = "Tr5";
            j = j + 1;
            
            //catagory.Text = media_details_obj_to_veiw.category; }
        }
        else { trcatagory.Visible = Tr5.Visible = false; }

        
        //------------------------------------------------------------------- no 2  ---------------------------------------------------------------------------------------


        if (media_details_obj_to_veiw.name != null && media_details_obj_to_veiw.name != "")
        { txt_eposideno.Text = media_details_obj_to_veiw.name;
        count_fields = count_fields + 1;
        arr_divs[j] = "Tr2";
        j = j + 1;
        
        }
        else
        {
            treposideno.Visible = Tr2.Visible = false;
        }
        //------------------------------------------------------------------------------ no 3  ----------------------------------------------------------------------------

        if (media_details_obj_to_veiw.period != null && media_details_obj_to_veiw.period != "")
        { period.Text = media_details_obj_to_veiw.period;
        count_fields = count_fields + 1;
        arr_divs[j] = "Tr4";
        j = j + 1;
        }
        else
        {
            trperiod.Visible = Tr4.Visible = false;
        }
        //-------------------------------------------------------------------------  no 4    ---------------------------------------------------------------------------------

        ////txt_author_moska.Text = manuscripts_details_obj_to_veiw.author_mosk;
        //if (theses_obj_to_veiw.theses_type != null && theses_obj_to_veiw.theses_type.ToString() != "")
        //{
        //    if (theses_obj_to_veiw.theses_type.ToString() == "2")
        //    {
        //        theses_type.Text = "دكتوراه";
        //    }

        //    if (theses_obj_to_veiw.theses_type.ToString() == "1")
        //    {
        //        theses_type.Text = "ماجستير";
        //        //Label55.Visible = true;
        //    }
        //    //else
        //    //{
        //    //    if (theses_obj_to_veiw.theses_type != "")
        //    //    {
        //    //        /Label55.Visible = false;
        //    //        license_type.SelectedValue = manuscripts_details_obj_to_veiw.license_type;
        //    //        //license_type.Visible = true;
        //    //        lbl_license_type.Text = license_type.SelectedItem.Text;
        //    //        //lbl_license_type.Text = license_type.Items[CDataConverter.ConvertToInt(manuscripts_details_obj_to_veiw.license_type) - 1].Text;
        //    //    }
        //    //}
        //    else
        //    { trthesestype.Visible = tr3.Visible = false; }
        //}
        //else
        //{ trthesestype.Visible = tr3.Visible = false; }
        if (media_details_obj_to_veiw.guest_details != null && media_details_obj_to_veiw.guest_details != "")
        { guest_name.Text = Convert.ToString(media_details_obj_to_veiw.guest_details);
        count_fields = count_fields + 1;
        arr_divs[j] = "tr3";
        j = j + 1;
        }
        else
        {
            trguest.Visible = tr3.Visible = false;
        }
        //--------------------------------------------------------------- no 5  -------------------------------------------------------------------------------------------


        if (media_details_obj_to_veiw.guest_desc != null && media_details_obj_to_veiw.guest_desc != "")
        { guesst_position.Text = Convert.ToString(media_details_obj_to_veiw.guest_desc);
        count_fields = count_fields + 1;
        arr_divs[j] = "tr10";
        j = j + 1;
        }
        else
        {
            trguestpos.Visible = tr10.Visible = false;
        }

        //--------------------------------------------------------------------- no 6  -------------------------------------------------------------------------------------


        if (media_details_obj_to_veiw.presenter_details != "" && media_details_obj_to_veiw.presenter_details != null)
        { interviwer_name.Text = media_details_obj_to_veiw.presenter_details;
        count_fields = count_fields + 1;
        arr_divs[j] = "tr6";
        j = j + 1;
        }
        else
        {
            trinterviwer.Visible = tr6.Visible = false;
        }
        //---------------------------------------------------------------------- no 7   ------------------------------------------------------------------------------------



        //if (media_obj_to_veiw.record_date_georgian != "" && media_obj_to_veiw.record_date_georgian != null)
        //{ txt_recorddatem.Text = media_obj_to_veiw.record_date_georgian; }
        //else
        //{
        //    trrecorddata.Visible = trrecorddate2.Visible = false;
        //}

        //if (media_obj_to_veiw.record_date_hijri != "" && media_obj_to_veiw.record_date_hijri != null)
        //{ txt_recorddateh.Text = media_obj_to_veiw.record_date_hijri; }
        //else
        //{
        //    trrecorddata.Visible = trrecorddate2.Visible = false;
        //}

        if (media_obj_to_veiw.record_date_georgian != null && media_obj_to_veiw.record_date_georgian != "")
        { txt_recorddatem.Text = media_obj_to_veiw.record_date_georgian; }
        if (media_obj_to_veiw.record_date_hijri != null && media_obj_to_veiw.record_date_hijri != "")
        { txt_recorddateh.Text = media_obj_to_veiw.record_date_hijri; }


        if ((media_obj_to_veiw.record_date_georgian == null || media_obj_to_veiw.record_date_georgian == "") && (media_obj_to_veiw.record_date_hijri == null || media_obj_to_veiw.record_date_hijri == ""))

        { trrecorddata.Visible = trrecorddate2.Visible = false; }
        else 
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "trrecorddate2";
            j = j + 1;
        }

        //------------------------------------------------------------------------- no 8    ---------------------------------------------------------------------------------


        if (media_obj_to_veiw.record_place != null && media_obj_to_veiw.record_place != "")
        { txt_resource.Text = media_obj_to_veiw.record_place;
        count_fields = count_fields + 1;
        arr_divs[j] = "tr13";
        j = j + 1;
        }
        else
        {
            trresource.Visible = tr13.Visible = false;
        }
        //------------------------------------------------------------------------  no 9   ----------------------------------------------------------------------------------


        if (media_details_obj_to_veiw.resource_name != "" && media_details_obj_to_veiw.resource_name != null)
        { txt_resourcename.Text = media_details_obj_to_veiw.resource_name;

        count_fields = count_fields + 1;
        arr_divs[j] = "tr15";
        j = j + 1;
        }
        else
        {
            trresourcename.Visible = tr15.Visible = false;
        }

        //------------------------------------------------------------------------ no 10   ----------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.resource_country != "")
        {

            lbl_sourcecountry.Text = media_details_obj_to_veiw.resource_country;
            count_fields = count_fields + 1;
            arr_divs[j] = "trcountry2";
            j = j + 1;
        }
        else
        { trcountry.Visible = trcountry2.Visible = false; }

        //-------------------------------------------------------------------- no 11  --------------------------------------------------------------------------------------


        if (media_details_obj_to_veiw.resource_city != null && media_details_obj_to_veiw.resource_city != "")
        {
            lbl_city.Text = media_details_obj_to_veiw.resource_city;
            count_fields = count_fields + 1;
            arr_divs[j] = "trsourcecity";
            j = j + 1;
        }
        else
        { trsourcecity.Visible = trcity.Visible = false; }

        //------------------------------------------------------------------- no 12  ---------------------------------------------------------------------------------------


        if (media_details_obj_to_veiw.resource_save_no != null && media_details_obj_to_veiw.resource_save_no != "")
        {
            Lab_saveno.Text = media_details_obj_to_veiw.resource_save_no;
            count_fields = count_fields + 1;
            arr_divs[j] = "trsaveno";
            j = j + 1;
        }
        else
        { trsaveno.Visible = trsaveno2.Visible = false; }
        //-----------------------------------------------------------------------------  no 13    -----------------------------------------------------------------------------

        if (media_details_obj_to_veiw.desc != null && media_details_obj_to_veiw.desc != "")
        {
            txt_descrption.Text = media_details_obj_to_veiw.desc;

            count_fields = count_fields + 1;
            arr_divs[j] = "Tr7";
            j = j + 1;
        }
        else
        {
            trdescrption.Visible = Tr7.Visible = false;
        }
        //---------------------------------------------------------------------- no 14  ------------------------------------------------------------------------------------


        if (media_details_obj_to_veiw.resource_note != null && media_details_obj_to_veiw.resource_note != "")
        {
            Lab_res_notes.Text = media_details_obj_to_veiw.resource_note;
            count_fields = count_fields + 1;
            arr_divs[j] = "trresourcenotes";
            j = j + 1;
        }
        else
        { trresourcenotes.Visible = trresourcenotes2.Visible = false; }
        //---------------------------------------------------------------------------- no 15   ------------------------------------------------------------------------------


        if (media_details_obj_to_veiw.notes != null && media_details_obj_to_veiw.notes != "")
        {
            notes.Text = media_details_obj_to_veiw.notes;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr120";
            j = j + 1;
        }
        else
        { trnotes.Visible = tr120.Visible = false; }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------

        HtmlGenericControl div_related = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_related");
        div_related.Visible = false;
        HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
        pdf_continer.Visible = false;


        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        if (media_obj_to_veiw.small_image != "")
        {

            lcImage.ImageUrl = "../upload/Videos/" + media_obj_to_veiw.small_image;
        }
        else lcImage.ImageUrl = "../img/Icon-8.jpg";


        Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");

        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
        {
            lclabel.Text = "Audios";
        }
        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        {
            lclabel.Text = "Audios";
        }
        else {
            lclabel.Text = "التسجيل الأذاعى";
        }
        
    }

    public void changeDiv_cssClass(object sender, EventArgs e, String DivName, String ClassName)
    {
        // Find the div control as htmlgenericcontrol type, if found apply style
        System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("ContentPlaceHolder2").FindControl(DivName);

        if (div != null)
        {
             div.Attributes.Remove("class");
            div.Attributes.Add("class", ClassName);
        }

    }
     
  
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   