using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;

public partial class general_search_general : BasePage
{
   
    public static string srch = "";
    public static string page_id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //HtmlGenericControl div_related =
            Page.Master.FindControl("leftUC11").Visible = false;
            Session["content_id"] = "0";
            Session["content_type"] = "0";
            if (Session["k"].ToString() != null)
            {
                if (Request["K"].ToString() != null)
                    srch = Session["k"].ToString();
            }
            else { Response.Redirect("../Default.aspx"); }

            if (srch != "")
            {
                
                getsrc(); }
            // div_related.Visible = false;
            else Response.Redirect("../Default.aspx");
        }

    }

    private string getNormalizedName(string str)
    {
        System.Text.StringBuilder normalizedSTR = new System.Text.StringBuilder(); ;
        char[] normalizedSTRarr = str.ToCharArray();
        foreach (char ch in normalizedSTRarr)
        {
            if (ch == 'أ' || ch == 'إ' || ch == 'ا' || ch == 'أ' || ch == 'آ')
            { normalizedSTR.Append('ا'); }
            else if (ch == 'ه' || ch == 'ة')
            { normalizedSTR.Append('ه'); }
            else if (ch == 'ي' || ch == 'ى' || ch == 'ئ')
            { normalizedSTR.Append('ى'); }
            else if (ch == 'ؤ' || ch == 'و')
            { normalizedSTR.Append('و'); }
            else
            { normalizedSTR.Append(ch); }
        }
        return normalizedSTR.ToString();
    }

    public void getsrc()
    {
        if (srch != "")
        {

            SqlParameter[] sqlParamter = new SqlParameter[] 

        {  
           new SqlParameter("@lang_id",menus_update.get_current_lang()),
               
           new SqlParameter("@kewword", getNormalizedName(srch.Trim())) 
         };


            Search search_obj = new Search();

            String[] itemName = { "char", "event", "topics", "place", "artifacts", "tv", "sound", "documents", "articles", "books", "images", "manuscripts", "theses", "conference_proceedings", "website", "glossary" };
            int cnt1=0,cnt2=0,cnt3=0,cnt4=0;
            for (int i = 0; i < 16; i++)
            {
                DataTable dt_item = search_obj.Get_dt(sqlParamter, itemName[i]);

                //---------------------------find list view---------------------------------------------
                int j = 1;

                if (itemName[i] == "char" || itemName[i] == "event" || itemName[i] == "topics" || itemName[i] == "place")
                {
                    j = 1;
                }
                if (itemName[i] == "artifacts" || itemName[i] == "tv" || itemName[i] == "sound" || itemName[i] == "images")
                {
                    j = 2;
                     
                }
                if (itemName[i] == "documents" || itemName[i] == "articles" || itemName[i] == "books" || itemName[i] == "manuscripts")
                {
                    j = 3;
                    
                }
                if (itemName[i] == "theses" || itemName[i] == "conference_proceedings" || itemName[i] == "website" || itemName[i] == "glossary")
                {
                    j = 4;
                }

                ListView lst = this.Master.FindControl("ContentPlaceHolder2").FindControl("TabContainer2").FindControl("TabPanel" + j.ToString()).FindControl("lstview_" + itemName[i]) as ListView;
                lst.DataSource = dt_item;
                lst.DataBind();

                if (dt_item.Rows.Count > 0)
                {
                    String str = "lbl_" + itemName[i];
                    Label lbl = this.Master.FindControl("ContentPlaceHolder2").FindControl("TabContainer2").FindControl("TabPanel" + j.ToString()).FindControl("lbl_" + itemName[i]) as Label;

                    lbl.Visible = true;
                    lbl.Text = dt_item.Rows.Count.ToString();
                    if (j == 1)
                    { cnt1 += CDataConverter.ConvertToInt(lbl.Text); }
                    else if (j == 2)
                    { cnt2 += CDataConverter.ConvertToInt(lbl.Text); }
                    else if (j == 3)
                    { cnt3 += CDataConverter.ConvertToInt(lbl.Text); }
                    else if (j == 4)
                    { cnt4 += CDataConverter.ConvertToInt(lbl.Text); }
                    if (lst != null)
                    {
                        foreach (ListViewDataItem item in lst.Items)
                        {
                            LinkButton lnktitle = search_obj.Get_linkbtn(sqlParamter, dt_item, item, "lnktitle");

                        }
                    }
                    DataPager dtpager = this.Master.FindControl("ContentPlaceHolder2").FindControl("TabContainer2").FindControl("TabPanel" + j.ToString()).FindControl("DataPager_" + itemName[i]) as DataPager;
                   // page_id = dtpager.PagedControlID.ToString();
                    if (dt_item.Rows.Count < 10)
                        dtpager.Visible = false;
                    
                       

                   
                    

                }

                else
                {

                    switch (i)
                    {
                        case 0:
                            tr_char0.Visible = false;
                            tr_char1.Visible = false;
                            tr_char2.Visible = false;
                            tr_char3.Visible = false;
                            break;
                        case 1:
                            tr_event0.Visible = false;
                            tr_event1.Visible = false;
                            tr_event2.Visible = false;
                            tr_event3.Visible = false;
                            break;
                        case 2:
                            tr_topics0.Visible = false;
                            tr_topics1.Visible = false;
                            tr_topics2.Visible = false;
                            tr_topics3.Visible = false;
                            break;
                        case 3:
                            tr_place0.Visible = false;
                            tr_place1.Visible = false;
                            tr_place2.Visible = false;
                            tr_place3.Visible = false;
                            break;
                        case 4:
                            tr_artifacts0.Visible = false;
                            tr_artifacts1.Visible = false;
                            tr_artifacts2.Visible = false;
                            tr_artifacts3.Visible = false;
                            break;
                        case 5:
                            tr_tv0.Visible = false;
                            tr_tv1.Visible = false;
                            tr_tv2.Visible = false;
                            tr_tv3.Visible = false;
                            break;
                        case 6:
                            tr_sound0.Visible = false;
                            tr_sound1.Visible = false;
                            tr_sound2.Visible = false;
                            tr_sound3.Visible = false;
                            break;
                        case 7:
                            tr_documents0.Visible = false;
                            tr_documents1.Visible = false;
                            tr_documents2.Visible = false;
                            tr_documents3.Visible = false;
                            break;
                        case 8:
                            tr_articles0.Visible = false;
                            tr_articles1.Visible = false;
                            tr_articles2.Visible = false;
                            tr_articles3.Visible = false;
                            break;
                        case 9:
                            tr_books0.Visible = false;
                            tr_books1.Visible = false;
                            tr_books2.Visible = false;
                            tr_books3.Visible = false;
                            break;
                        case 10:
                            tr_images0.Visible = false;
                            tr_images1.Visible = false;
                            tr_images2.Visible = false;
                            tr_images3.Visible = false;
                            break;
                        case 11:
                            tr_manuscripts0.Visible = false;
                            tr_manuscripts1.Visible = false;
                            tr_manuscripts2.Visible = false;
                            tr_manuscripts3.Visible = false;
                            break;
                        case 12:
                            tr_theses0.Visible = false;
                            tr_theses1.Visible = false;
                            tr_theses2.Visible = false;
                            tr_theses3.Visible = false;
                            break;
                        case 13:
                            tr_conference_proceedings0.Visible = false;
                            tr_conference_proceedings1.Visible = false;
                            tr_conference_proceedings2.Visible = false;
                            tr_conference_proceedings3.Visible = false;
                            break;
                        case 14:
                            tr_website0.Visible = false;
                            tr_website1.Visible = false;
                            tr_website2.Visible = false;
                            tr_website3.Visible = false;
                            break;
                        case 15:
                            tr_glossary0.Visible = false;
                            tr_glossary1.Visible = false;
                            tr_glossary2.Visible = false;
                            tr_glossary3.Visible = false;
                            break;


                    }

                }


            }
           
            if (cnt1 + cnt2 + cnt3 + cnt4 == 0)
            {

                noresults1.Text = "لا توجد نتائج للبحث عن " + "\"";
                noresults1.Visible =
                noresults2.Visible =
                noresults3.Visible =true;
                noresults2.Text = srch;
                noresults3.Text = "\"" + " حاول البحث بشكل مختلف ";
                noresults1.Style.Add("Color", "#FF6D00"); noresults3.Style.Add("Color", "#FF6D00");
                noresults2.Style.Add("Color", "#C66370");
                TabPanel1.Visible=
                    TabPanel2.Visible=
                TabPanel3.Visible=
                    TabPanel4.Visible = false;
            }
            else
            {
                TabPanel1.HeaderText += " (" + cnt1 + ") ";
                TabPanel2.HeaderText += " (" + cnt2 + ") ";
                TabPanel3.HeaderText += " (" + cnt3 + ") ";
                TabPanel4.HeaderText += " (" + cnt4 + ") ";
                noresults1.Visible =
                noresults2.Visible =
                noresults3.Visible = false;
                TabPanel1.Visible =
                    TabPanel2.Visible =
                TabPanel3.Visible =
                    TabPanel4.Visible = true;
            }
        }
    }
    protected void DataPager_char_PreRender(object sender, EventArgs e)
    {
        if (page_id == "DataPager_char")
        {
            getsrc();
        }
    }
    protected void DataPager_topics_PreRender(object sender, EventArgs e)
    {

        if (page_id == "DataPager_topics")
        {

            getsrc();
        }
    }
    protected void DataPager_event_PreRender(object sender, EventArgs e)
    {

        if (page_id == "DataPager_event")
        {
            getsrc();
        }
    }

    protected void DataPager_place_PreRender(object sender, EventArgs e)
    {

        if (page_id == "DataPager_place")
        {
            getsrc();
        }
    }

    protected void DataPager_artifacts_PreRender(object sender, EventArgs e)
    {

        if (page_id == "DataPager_artifacts")
        {
            getsrc();
        }
    }

    protected void DataPager_documents_PreRender(object sender, EventArgs e)
    {

        if (page_id == "DataPager_documents")
        {
            getsrc();
        }
    }

    protected void DataPager_articles_PreRender(object sender, EventArgs e)
    {

        if (page_id == "DataPager_articles")
        {
            getsrc();
        }
    }
    protected void DataPager_books_PreRender(object sender, EventArgs e)
    {

        if (page_id == "DataPager_books")
        {
            getsrc();
        }
    }
    protected void DataPager_theses_PreRender(object sender, EventArgs e)
    {
       
        if (page_id == "DataPager_theses")
        {
            getsrc();
        }
    }
    protected void DataPager_tv_PreRender(object sender, EventArgs e)
    {
        if (page_id == "DataPager_tv")
        {
            getsrc();
         }
    }
    protected void DataPager_sound_PreRender(object sender, EventArgs e)
    {
        if (page_id == "DataPager_sound")
        {
            getsrc();
        }
    }

    protected void DataPager_images_PreRender(object sender, EventArgs e)
    {
        if (page_id == "DataPager_images")
        {
            getsrc();
        }
    }

    protected void DataPager_manuscripts_PreRender(object sender, EventArgs e)
    {
        if (page_id == "DataPager_manuscripts")
        {
            getsrc();
        }
    }

    protected void DataPager_conference_proceedings_PreRender(object sender, EventArgs e)
    {
        if (page_id == "DataPager_conference_proceedings")
        {
            getsrc();
        }
    }

    protected void DataPager_website_PreRender(object sender, EventArgs e)
    {
        if (page_id == "DataPager_website")
        {
            getsrc();
        }
    }

    protected void DataPager_glossary_PreRender(object sender, EventArgs e)
    {
        if (page_id == "DataPager_glossary")
        { 
            getsrc();
        }
    }



    // AFTER paged changed //

    protected void lstviewchar_PagePropertiesChanged(object sender, EventArgs e)
    { 
        page_id = "DataPager_char"; 
    }
    protected void lstviewevent_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_event";
    }

    protected void lstviewtopics_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_topics";
    }
    protected void lstviewplace_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_place";
         
    }
    protected void lstviewartifacts_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_artifacts";     
    }

    protected void lstviewtv_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_tv";
         
    }
    protected void lstviewsound_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_sound";
      
    }

    protected void lstviewimages_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_images";
 
    }
    protected void lstviewdocuments_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_documents";
         
    }

    protected void lstviewarticles_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_articles";
         
    }
    protected void lstviewbooks_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_books";

    }
    protected void lstviewtheses_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_theses";
        
    }

    protected void lstviewmanuscripts_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_manuscripts";

    }
    protected void lstviewconferenceproceedings_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_conference_proceedings";
    }
    protected void lstviewwebsite_PagePropertiesChanged(object sender, EventArgs e)
    {
        page_id = "DataPager_website";
         
    }
    protected void lstviewglossary_PagePropertiesChanged(object sender, EventArgs e)
    {
       page_id = "DataPager_glossary"; 
        
    }
    

}
