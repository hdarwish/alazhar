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

public partial class sheikhs_characters_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            Session["content_id"] = Request["id"];
            Session["content_type"] = "1";
            int id = Convert.ToInt16(Request.QueryString["id"]);
            HiddenID.Value = id.ToString (); 
            ViewDetails(id);
            string no_books = "0";
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", HttpContext.Current.Session["lang_id"].ToString()) };
            DataTable audios_count_DT = new DataTable();
            audios_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_audios_count");
            if (audios_count_DT.Rows.Count > 0)
            {
                Label1.Visible = true;
                HyperLink1.Visible = true;
            }

            DataTable videos_count_DT = new DataTable();
            videos_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_videos_count");
            if (videos_count_DT.Rows.Count > 0)
            {
                Label1.Visible = true;
                HyperLink2.Visible = true;
                Label11.Visible = true;
            }
        }

    }

    public void ViewDetails(int id)
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) ,
         new SqlParameter("@lang_id",Convert.ToInt16(1))};

        DataTable charDT = new DataTable();
        charDT = DatabaseFunctions.SelectData(sqlParams, "characters_details_select2");
        if (charDT.Rows.Count > 0)
        {
            //////////////////Title & image & birthday//////
            Img.ImageUrl = "~/images/sheikhs/" + charDT.Rows[0]["image_name"].ToString();
            LabName.Text = charDT.Rows[0]["titles"].ToString() + " "  +charDT.Rows[0]["other_names"].ToString();
            LabBirthday.Text = "(" + charDT.Rows[0]["hbirth_date"].ToString() + " - " + charDT.Rows[0]["hdeath_date"].ToString() + "هـ" + "/";
            lab_deathday.Text =  charDT.Rows[0]["birth_date"].ToString() + " - " + charDT.Rows[0]["death_date"].ToString() + "م" + ")";
            LabDetails.InnerText  = charDT.Rows[0]["char_details"].ToString();
             if (charDT.Rows[0]["title2"].ToString() != "")
             { Labtype.Text = charDT.Rows[0]["title2"].ToString();}
             else Labtype.Visible = false ;
            //LabBrief.Text = charDT.Rows[0]["char_brief"].ToString();
            //LabAzhar.Text = charDT.Rows[0]["mashyakha_azhar"].ToString(); 
          
            //////////////////////////Accordion5 birth_details///////////////////////////////////////
            if (charDT.Rows[0]["birth_details"].ToString() != "")
            {
                Label LabBirthDetails = (Label)Accordion5.FindControl("LabBirthDetails");
                LabBirthDetails.Text = "<p dir='rtl' style='text-align: justify; font-size: 14px; width: 100%' class='text'>" + charDT.Rows[0]["birth_details"].ToString() + "</p>";
            }
            else Accordion5.Visible = false;
            
           /////////////////////////////Accordion6 scientific_life/////////////////////////////////////

            if (charDT.Rows[0]["scientific_life"].ToString() != "")
            {
                Label LabScientific = (Label)Accordion6.FindControl("LabScientific");
                LabScientific.Text = "<p dir='rtl' style='text-align: justify; font-size: 14px; width: 100%' class='text'>" + charDT.Rows[0]["scientific_life"].ToString() + "</p>";
            }
            else Accordion6.Visible = false;

            //////////////////////////Accordion7 working_life/////////////////////////////////////////////

            if (charDT.Rows[0]["working_life"].ToString() != "")
            {
                Label lab_work_life = (Label)Accordion7.FindControl("lab_work_life");

                lab_work_life.Text = "<p dir='rtl' style='text-align: justify; font-size: 14px; width: 100%' class='text'>" + charDT.Rows[0]["working_life"].ToString() + "</p>";
                
            }
            else Accordion7.Visible = false;
            //////////////////////////////Accordion8 activities////////////////////////////////////////////////

            if (charDT.Rows[0]["activities"].ToString() != "")
            {
                Label Lab_activity = (Label)Accordion8.FindControl("Lab_activity");
                Lab_activity.Text = "<p dir='rtl' style='text-align: justify; font-size: 14px; width: 100%' class='text'>" + charDT.Rows[0]["activities"].ToString() + "</p>";
            }
            else Accordion8.Visible = false;
            
        }
        ////////////////////////////////////// Tags////////////////////////////////////////////////
        //SqlParameter[] sqlParamsTag = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) 
        //  };
        //DataTable char_Tag = new DataTable();
        //char_Tag = DatabaseFunctions.SelectData(sqlParamsTag, "char_tags_select");
        //int countert = 0;
        //if (char_Tag.Rows.Count > 0)
        //{
        //    DataList6.DataSource = char_Tag;
        //    DataList6.DataBind();
        //    foreach (DataListItem item in DataList6.Items)
        //    {
        //        LinkButton link_tags = (LinkButton)item.FindControl("link_tags");
        //        link_tags.Text = char_Tag.Rows[countert]["title_ar"].ToString();
        //        countert++;
        //    }

        //}
        //////////////////////////////BIRTHDAY////////////////////////////////////////////////
        //SqlParameter[] sqlParamsAch = new SqlParameter[] { new SqlParameter("@Char_id",Convert.ToInt16 (HiddenID.Value)) ,
        //  new SqlParameter("@lang",Convert.ToInt16(1))};
        //DataTable char_AchvDT = new DataTable();
        //char_AchvDT = DatabaseFunctions.SelectData(sqlParamsAch, "achievements_details_Select");
        //if (char_AchvDT.Rows.Count > 0)
        //{
           
        //    DataList1.DataSource = char_AchvDT;
        //    DataList1.DataBind();
        //    int counter = 0;
        //    foreach (DataListItem item in DataList1.Items)
        //    {
        //        Label Labelid = (Label)item.FindControl("Labelid");
        //        Labelid.Text = char_AchvDT.Rows[counter]["details"].ToString();
        //        counter++;
        //    }

        //}
        //else Accordion0.Visible = false;
        ///////////////////////////// ACHIEVEMENTS ///////////////////////////////////////////
        SqlParameter[] sqlParamsAch = new SqlParameter[] { new SqlParameter("@Char_id",Convert.ToInt16 (HiddenID.Value)) ,
          new SqlParameter("@lang",Convert.ToInt16(1))};
        DataTable char_AchvDT = new DataTable();
        char_AchvDT = DatabaseFunctions.SelectData(sqlParamsAch, "achievements_details_Select2");
        if (char_AchvDT.Rows.Count > 0)
        {
            DataList DataList1 = (DataList)Accordion0.FindControl("DataList1");
            DataList1.DataSource = char_AchvDT;
            DataList1.DataBind();
            int counter = 0;
            foreach (DataListItem item in DataList1.Items)
            {
                HtmlGenericControl Labelid = (HtmlGenericControl)item.FindControl("Labelid");
                //Label Labelid = (Label)item.FindControl("Labelid");
                Labelid.InnerHtml = char_AchvDT.Rows[counter]["details"].ToString();
                counter++;
            }

        }
        else Accordion0.Visible = false;
        ///////////////////////////// AWSEMA ///////////////////////////////////////////
        SqlParameter[] sqlParamsAwsema = new SqlParameter[] 
        { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) ,
        new SqlParameter("@lang_id",Convert.ToInt16(1))};

        DataTable char_Awsema = new DataTable();
        char_Awsema = DatabaseFunctions.SelectData(sqlParamsAwsema, "awsema_details_select2");
        if (char_Awsema.Rows.Count > 0)
        {
            DataList DataList2 = (DataList)Accordion1.FindControl("DataList2");
            DataList2.DataSource = char_Awsema;
            DataList2.DataBind();
            int countA = 0;
            foreach (DataListItem ditem in DataList2.Items)
            {
                HtmlGenericControl LinkID = (HtmlGenericControl)ditem.FindControl("LinkID");
               // Label LinkID = (Label)ditem.FindControl("LinkID");
                LinkID.InnerHtml = char_Awsema.Rows[countA]["details"].ToString();
                countA++;
            }

        }
        else Accordion1.Visible = false;
        ////////////////////////////////////////////TAKREZAT////////////////////////////////////////////////////////////
        SqlParameter[] sqlParamsTkreza = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) ,
          new SqlParameter("@lang_id",Convert.ToInt16(1))};

        DataTable char_Tkreza = new DataTable();
        char_Tkreza = DatabaseFunctions.SelectData(sqlParamsTkreza, "takreezat_details_select2");
        if (char_Tkreza.Rows.Count > 0)
        {
            DataList DataList3 = (DataList)Accordion2.FindControl("DataList3");
            DataList3.DataSource = char_Tkreza;
            DataList3.DataBind();
            int count = 0;
            foreach (DataListItem Titem in DataList3.Items)
            {
                HtmlGenericControl LinkID = (HtmlGenericControl)Titem.FindControl("LinkID");
                LinkID.InnerHtml = char_Tkreza.Rows[count]["details"].ToString();
                count++;
            }

        }
        else Accordion2.Visible = false;

        ////////////////////////////////////////////Written////////////////////////////////////////////////////////////
        /////////////// books ///////////////////////


        SqlParameter[] sqlParamsb = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                     
            new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                     
            new SqlParameter("@lang", HttpContext.Current.Session["lang_id"].ToString()) };

        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParamsb, "list_books_select");
        DataList DataList6 = (DataList)Accordion3.FindControl("DataList6");
        DataList6.DataSource = dt;
        DataList6.DataBind();
        int counterb = 0;

        if (dt.Rows.Count > 0)
        {
            foreach (DataListItem item in DataList6.Items)
            {
                LinkButton Labbooktitle = (LinkButton)item.FindControl("link_book");
                Labbooktitle.Text = dt.Rows[counterb]["title"].ToString();
                Labbooktitle.PostBackUrl = "~/Esdarat/books_details.aspx?id=" + dt.Rows[counterb]["doc_id"].ToString();
                //Label Labwriter =(Label)item.FindControl("Labwriter");
                //Labwriter.Text = dt.Rows[counterb]["publish_location"].ToString();
                //Label Labres = (Label)item.FindControl("Labres");
                //Labres.Text = dt.Rows[counterb]["resource"].ToString();
                //ImageButton Img_book = (ImageButton)item.FindControl("Img_book");
                //if (dt.Rows[counterb]["small_image"].ToString() != "")
                //{
                //    //HtmlInputHidden hidden_id = (HtmlInputHidden)item.FindControl("hidden_id");
                //hidden_id.Value = dt.Rows[counterb]["doc_id"].ToString();
                //    Img_book.ImageUrl = "~/images/Esdarat/" + dt.Rows[counter]["small_image"].ToString();
                //}
                //else Img_book.ImageUrl = "~/images/noImageAvailable.jpg";
                //Img_book.PostBackUrl = "~/esdarat/books_details.aspx?id=" + dt.Rows[counter]["doc_id"].ToString();
                counterb++;
            }
        }
        else written_book.Visible = false;


            ///////////////////Moalfat////////////////////////////////
            SqlParameter[] sqlParamsDocs = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) 
          };
            //[characters_docwrittenabout_select]
            DataTable char_Docs = new DataTable();
            char_Docs = DatabaseFunctions.SelectData(sqlParamsDocs, "char_moalafat_select");
            if (char_Docs.Rows.Count > 0)
            {
                DataList DataList4 = (DataList)Accordion3.FindControl("DataList4");
                DataList4.DataSource = char_Docs;
                DataList4.DataBind();
                int count = 0;
                foreach (DataListItem Titem in DataList4.Items)
                {
                    Label LinkID = (Label)Titem.FindControl("LinkID");
                    LinkID.Text = char_Docs.Rows[count]["title_ar"].ToString();
                    count++;
                }

            }
            else Table3.Visible = false;

            ////////////////wrriten About///////////////////

            SqlParameter[] sqlParamsWDocs = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) 
          };
            //[characters_docwrittenabout_select]
            DataTable char_WDocs = new DataTable();
            char_WDocs = DatabaseFunctions.SelectData(sqlParamsWDocs, "char_moalafatabout_select");
            if (char_WDocs.Rows.Count > 0)
            {
                DataList dl = (DataList)Accordion4.FindControl("DataList5");
                dl.DataSource = char_WDocs;
                dl.DataBind();
                int count = 0;
                foreach (DataListItem Titem in dl.Items)
                {
                    Label LinkID = (Label)Titem.FindControl("LinkID");
                    LinkID.Text = char_WDocs.Rows[count]["title_ar"].ToString();
                    count++;
                }

            }
            else Accordion4.Visible = false;

        }
    }
    

