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

public partial class Elzakera_thesesDetails : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[12];
    protected void Page_Load(object sender, EventArgs e)
    {        
            Session["content_id"] = Request["id"];
            Session["content_type"] = "13";
            int id = Convert.ToInt16(Request.QueryString["id"]);
            HiddenID2.Value = id.ToString();
            if (id != 0)
            {
             hits_count obj = new hits_count(); 
                obj.hit_count_save(id, 1);  
            }
                if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                {
                    //trtitle2.Attributes["class"] = "accordion_title_enfr";
                    tr9.Attributes["class"] = "accordion_title_enfr";
                    Tr5.Attributes["class"] = "accordion_title_enfr";
                    trauthfromtit.Attributes["class"] = "accordion_body_enfr";
                    Tr7.Attributes["class"] = "accordion_title_enfr";
                    trsupervisor.Attributes["class"] = "accordion_body_enfr";
                    Tr2.Attributes["class"] = "accordion_title_enfr";
                    trsupervisor1.Attributes["class"] = "accordion_body_enfr";
                    Tr4.Attributes["class"] = "accordion_title_enfr";
                    trsupervisor2.Attributes["class"] = "accordion_body_enfr";
                    tr3.Attributes["class"] = "accordion_title_enfr";
                    trthesestype.Attributes["class"] = "accordion_body_enfr";
                    tr10.Attributes["class"] = "accordion_title_enfr";
                    trgroupno.Attributes["class"] = "accordion_body_enfr";
                    tr6.Attributes["class"] = "accordion_title_enfr";
                    trlang.Attributes["class"] = "accordion_body_enfr";
                    trunversity.Attributes["class"] = "accordion_title_enfr";
                    tr12.Attributes["class"] = "accordion_body_enfr";
                    tr13.Attributes["class"] = "accordion_title_enfr";
                    trsection.Attributes["class"] = "accordion_body_enfr";
                    tr155.Attributes["class"] = "accordion_title_enfr";
                    trcollage.Attributes["class"] = "accordion_body_enfr";
                    tr_date.Attributes["class"] = "accordion_title_enfr";
                    trdates.Attributes["class"] = "accordion_body_enfr";
                    tr120.Attributes["class"] = "accordion_title_enfr";
                    trnotes.Attributes["class"] = "accordion_body_enfr";                    
                }
                filllang();                    
                View();
                //-------------------------clored the Divs-------------------------------------
                for (int y = 0; y < count_fields-1; y = y + 2)
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
    private void filllang()
    {
        languages_DT obj = new languages_DT();
        DataTable lang_dt = languages_DB.SelectAll();

        man_lang.DataSource = lang_dt;
        man_lang.DataBind();
        ListItem litem = new ListItem("-- اختر اللغة  --", "0");
        man_lang.Items.Insert(0, litem);

    }
    public void View()
    {
        int j = 0;


        int lang = menus_update.get_current_lang();
        theses_DT theses_obj_to_veiw = new theses_DT();
        theses_details_DT theses_details_obj_to_veiw = new theses_details_DT();
        //link to specififc table in DB
        theses_obj_to_veiw = theses_DB.SelectByID(Convert.ToInt16(HiddenID2.Value));
        theses_details_obj_to_veiw = theses_details_DB.SelectByID(Convert.ToInt16(HiddenID2.Value));
        //to connect bet theses & theses_details for the same these by id
        if (theses_obj_to_veiw != null)
        {
         //if (theses_obj_to_veiw.form_status != 12)
         //  Response.Redirect("~/Elzakera/list_theses.aspx");
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                if (theses_obj_to_veiw.form_status != 12)
                Response.Redirect("~/Elzakera/list_theses.aspx");
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
               if (theses_obj_to_veiw.form_status_en != 12)
                Response.Redirect("~/Elzakera/list_theses.aspx");
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                if (theses_obj_to_veiw.form_status_fr != 12)
                    Response.Redirect("~/Elzakera/list_theses.aspx");
            }

        }
        Labtitle.Text = theses_details_obj_to_veiw.title;  
        //name of theses from these_details
        //--------------------------------------------------------no 0--------------------------------------------------------------------------------------------
        if (theses_details_obj_to_veiw.title != null && theses_details_obj_to_veiw.title != "")
        {
            Labtitle.Text = theses_details_obj_to_veiw.title;
            if (lang == 2)
            {
                // td4.Visible = true;
            }
            else
            {// td4.Visible = false; 
            }

            count_fields = count_fields + 1;
            arr_divs[j] = "tr9";
            j = j + 1;
        }
        else
        { tr9.Visible = Labtitle.Visible = false; }
////////////////////////////////////////////////////////////     no 1  ///////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.searcher_name != null && theses_details_obj_to_veiw.searcher_name != "")
        { author.Text = theses_details_obj_to_veiw.author;

        count_fields = count_fields + 1;
        arr_divs[j] = "Tr5";
        j = j + 1;
        }
        else { trauthfromtit.Visible = Tr5.Visible = false; }
////////////////////////////////////////////////////////      no  2 //////////////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.supervisor_name != null && theses_details_obj_to_veiw.supervisor_name != "")
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "Tr7";
            j = j + 1;
            
            txt_supervisior.Text = theses_details_obj_to_veiw.supervisor_name; }
        else
        {trsupervisor.Visible = Tr7.Visible = false;}
/////////////////////////////////////////////////////////////////      n0 3////////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.supervisor_name1 != null && theses_details_obj_to_veiw.supervisor_name1 != "")
        { txt_super.Text = theses_details_obj_to_veiw.supervisor_name1;
        count_fields = count_fields + 1;
        arr_divs[j] = "Tr2";
        j = j + 1;
        
        }
        else
        {trsupervisor1.Visible = Tr2.Visible = false;}
/////////////////////////////////////////////////////////////             no 4 ////////////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.supervisor_name2 != null && theses_details_obj_to_veiw.supervisor_name2 != "")
        { txt_supervisor2.Text = theses_details_obj_to_veiw.supervisor_name2;
        count_fields = count_fields + 1;
        arr_divs[j] = "Tr4";
        j = j + 1;
        }
        else
        {trsupervisor2.Visible = Tr4.Visible = false;}
        //txt_author_moska.Text = manuscripts_details_obj_to_veiw.author_mosk;
        //////////////////////////////////////////////////////////     no 5      ///////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.lang_id == 1)
        {
            if (theses_obj_to_veiw.theses_type != null && theses_obj_to_veiw.theses_type.ToString() != "")
            {
                if (theses_obj_to_veiw.theses_type.ToString() == "2")
                {
                    theses_type.Text = "دكتوراه";
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr3";
                    j = j + 1;
                }
                else if (theses_obj_to_veiw.theses_type.ToString() == "1")
                {
                    theses_type.Text = "ماجستير";
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr3";
                    j = j + 1;
                    //Label55.Visible = true;
                }
                else
                { trthesestype.Visible = tr3.Visible = false; }
            }
            else
            { trthesestype.Visible = tr3.Visible = false; }
        }
        else if (theses_details_obj_to_veiw.lang_id == 2)
        {
            if (theses_obj_to_veiw.theses_type != null && theses_obj_to_veiw.theses_type.ToString() != "")
            {
                if (theses_obj_to_veiw.theses_type.ToString() == "2")
                {
                    theses_type.Text = "PhD";
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr3";
                    j = j + 1;
                }
                else if (theses_obj_to_veiw.theses_type.ToString() == "1")
                {
                    theses_type.Text = "Master";
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr3";
                    j = j + 1;
                    //Label55.Visible = true;
                }
                else
                { trthesestype.Visible = tr3.Visible = false; }
            }
            else
            { trthesestype.Visible = tr3.Visible = false; }
        }
        else
        {
            if (theses_details_obj_to_veiw.lang_id == 3)
            {
                if (theses_obj_to_veiw.theses_type != null && theses_obj_to_veiw.theses_type.ToString() != "")
                {
                    if (theses_obj_to_veiw.theses_type.ToString() == "2")
                    {
                        theses_type.Text = "PhD";
                        count_fields = count_fields + 1;
                        arr_divs[j] = "tr3";
                        j = j + 1;
                    }
                    else if (theses_obj_to_veiw.theses_type.ToString() == "1")
                    {
                        theses_type.Text = "maître";

                        count_fields = count_fields + 1;
                        arr_divs[j] = "tr3";
                        j = j + 1;
                        //Label55.Visible = true;
                    }
                    else
                    { trthesestype.Visible = tr3.Visible = false; }
                }
                else
                { trthesestype.Visible = tr3.Visible = false; }
            }
        }
////////////////////////////////////////////////////////////     no 6         ///////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.theses_no != null && theses_details_obj_to_veiw.theses_no != 0)
        { collection_no.Text = Convert.ToString(theses_details_obj_to_veiw.theses_no);
        count_fields = count_fields + 1;
        arr_divs[j] = "tr10";
        j = j + 1;
        }
        else
        {trgroupno.Visible = tr10.Visible = false;}
        ///////////////////////////////////////////////////////////////    no 7//////////////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.theses_lang != "")
        {
            foreach (ListItem x in man_lang.Items)
            {
                if (x.Text == theses_details_obj_to_veiw.theses_lang.ToString())
                {
                    x.Selected = true;
                }
            }
            //man_lang.SelectedItem = theses_details_obj_to_veiw.theses_lang;
            lbl_man_lang.Text = man_lang.SelectedItem.Text;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr6";
            j = j + 1;
        }
        if (man_lang.SelectedIndex == -1)
        { trlang.Visible = tr6.Visible = false; }
///////////////////////////////////////////////////////////     no 8       ////////////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.unversity != "" && theses_details_obj_to_veiw.unversity != null)
        { txt_unversity.Text = theses_details_obj_to_veiw.unversity;
        count_fields = count_fields + 1;
        arr_divs[j] = "trunversity";
        j = j + 1;
        
        
        }
        else
        {trunversity.Visible = tr12.Visible = false;}
///////////////////////////////////////////////////////         no 9   //////////////////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.section != "" && theses_details_obj_to_veiw.section != null)
        { txt_section.Text = theses_details_obj_to_veiw.section;
        count_fields = count_fields + 1;
        arr_divs[j] = "tr13";
        j = j + 1;
        }
        else
        {trsection.Visible = tr13.Visible = false;}
/////////////////////////////////////////////////////////             no 10 //////////////////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.collage != "" && theses_details_obj_to_veiw.collage != null)
        { txt_collage.Text = theses_details_obj_to_veiw.collage;
        count_fields = count_fields + 1;
        arr_divs[j] = "tr155";
        j = j + 1;
        
        }
        else
        {trcollage.Visible = tr155.Visible = false;}
//////////////////////////////////////////////////////////////////        no 11     /////////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.theses_date != null && theses_details_obj_to_veiw.theses_date != "")
        { lbl_copy_date_type.Text = theses_details_obj_to_veiw.theses_date + " مـ "; }
        if (theses_details_obj_to_veiw.theses_hdate != null && theses_details_obj_to_veiw.theses_hdate != "")
        {
         //lbl_copy_date_type.Text = theses_details_obj_to_veiw.theses_hdate + " هـ"; 
        }
        if ((theses_details_obj_to_veiw.theses_date == null || theses_details_obj_to_veiw.theses_date == "")
            && (theses_details_obj_to_veiw.theses_hdate == null || theses_details_obj_to_veiw.theses_hdate == ""))
        { trdates.Visible = tr_date.Visible = false; }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_date";
            j = j + 1;
        }

///////////////////////////////////////////////////////////////////        no 12 ///////////////////////////////////////////////////////////////////////////////////////////
        if (theses_details_obj_to_veiw.notes != null && theses_details_obj_to_veiw.notes != "")
        {
            notes.Text = theses_details_obj_to_veiw.notes;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr120";
            j = j + 1;
        }
        else
        { trnotes.Visible = tr120.Visible = false; }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (theses_obj_to_veiw.file_name != "")
        {
            HtmlAnchor link_pdf1 = (HtmlAnchor)Page.Master.FindControl("leftUC11").FindControl("link_pdf1");
            link_pdf1.HRef = "~/images/esdarat/" + theses_obj_to_veiw.file_name;
            Label lbl_veiw = (Label)Page.Master.FindControl("leftUC11").FindControl("lbl_veiw");
            //lbl_veiw.Text = "عرض الأطروحة";
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                lbl_veiw.Text = "عرض الأطروحة";
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                lbl_veiw.Text = "Showing thesis";
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                lbl_veiw.Text = "Affichage thèse";
            link_pdf1.Visible = true;
        }
        else
        {
            HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
            pdf_continer.Visible = false;
        }
        //HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
        //pdf_continer.Visible = false;
        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        if (theses_obj_to_veiw.image_name != "")
        {
            lcImage.ImageUrl = "../images/esdarat/" + theses_obj_to_veiw.image_name;
        }
        else lcImage.ImageUrl = "~/img/Icon-7.jpg";
        Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
        //lclabel.Text = "الأطروحة";
        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
        {
            lclabel.Text = "الأطروحة";           
        }
        else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            lclabel.Text = "Thesis";
        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            lclabel.Text = "thèse";
        
    }

    public void changeDiv_cssClass(object sender, EventArgs e, String DivName, String ClassName)
    {
        // Find the div control as htmlgenericcontrol type, if found apply style
        System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("ContentPlaceHolder2").FindControl(DivName);

        if (div != null)
        {
            // div.Attributes.Remove("class");
            div.Attributes.Add("class", ClassName);
        }

    }
     
}
