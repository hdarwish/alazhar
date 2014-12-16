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
using System.IO;

public partial class masterpage_leftUC1 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ireq_id = "";
        if (Request.QueryString["id"] != null)
        {
            ireq_id = Request.QueryString["id"].ToString();
        }
        else
        { ireq_id = "0"; }
        if ((getpage_name() == "8" || getpage_name() == "9" ||
            getpage_name() == "10" || getpage_name() == "11" ||
            getpage_name() == "12" || getpage_name() == "13" ||
            getpage_name() == "14" || getpage_name() == "15" ||
            getpage_name() == "16") || getpage_name() == "7" ||
            getpage_name() == "5" || 
            getpage_name() == "6" &&  ireq_id != "0")
        {
            div_related.Visible = false;
            
        }
        else
        {
            div_show.Visible = true;
            div_related.Visible = true;
            pdf_continer.Visible = false;
        }
        if (getpage_name() == "1" || getpage_name() == "7" || getpage_name() == "6")
        {
            pdf_continer.Visible = false;
        }
        if (getpage_name() == "0" &&  ireq_id == "0")
        {
            div_show.Visible = false;
            pdf_continer.Visible = false;
            retatedTo.Visible = false;
        }
        if (Session["content_type"] != null && Session["content_id"] != null)
        {
            if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
            {
                if (Request.QueryString["type"] == "1")
                {
                    characters_DT obj = characters_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));

                    Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
                    if (obj.image_name != "")
                    {

                        lcImage.ImageUrl = "../images/sheikhs/" + obj.image_name;
                    }
                    else lcImage.ImageUrl = "../img/azhar-char.gif";
                    Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
                    HtmlGenericControl rlabel = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("relatspan");
                    HtmlGenericControl div_related_images = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_related_images");
                    div_related_images.Visible = false;
                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                    {
                        lclabel.Text = "الشخصية";
                        rlabel.InnerText = " محتوى متعلق بالشخصية ";
                    }
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                    {
                        lclabel.Text = "The character";
                        rlabel.InnerText = " Content related to The character ";

                    }
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        lclabel.Text = "de caractère";
                        rlabel.InnerText = " Contenu lié au caractère ";

                    }
                }
                else if (Request.QueryString["type"] == "2")
                {
                    events_DT obj = events_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));

                    Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");


                    //   lcImage.ImageUrl = "../images/sheikhs/" + obj.image_name;
                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                    {
                        lcImage.ImageUrl = "../img/event2.jpg";
                    }
                    else
                        lcImage.ImageUrl = "../img/event2_en.jpg";



                    HtmlGenericControl div_related_images = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_related_images");
                    div_related_images.Visible = false;
                    Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");

                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                    { lclabel.Text = "الحدث"; }
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                    { lclabel.Text = "Event"; }
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    { lclabel.Text = "événement"; }




                    // lclabel.Text = "الحدث";
                    HtmlGenericControl rlabel = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("relatspan");
                    // rlabel.InnerText = " محتوى متعلق بالحدث ";

                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                    { rlabel.InnerText = "محتوى متعلق بالحدث "; }
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                    { rlabel.InnerText = "Content related to the event "; }
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    { rlabel.InnerText = "Contenu lié à l'événement "; }

                }
                else if (Request.QueryString["type"] == "3")
                {
                    topics_DT obj = topics_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));

                    Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                    {
                        lcImage.ImageUrl = "../img/subject2.jpg";
                    }
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                    {
                        lcImage.ImageUrl = "../img/sub_en-L.jpg";
                    }
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        lcImage.ImageUrl = "../img/sub_fr-L.jpg";
                    }
                     HtmlGenericControl div_related_images = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_related_images");
                    div_related_images.Visible = false;
                    Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
                    //lclabel.Text = "الموضوع";
                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                        lclabel.Text = "الموضوع";
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        lclabel.Text = "topic";
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        lclabel.Text = "sujet";
                    HtmlGenericControl rlabel = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("relatspan");
                    //rlabel.InnerText = " محتوى متعلق بالموضوع ";
                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                        rlabel.InnerText = " محتوى متعلق بالموضوع ";
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        rlabel.InnerText = " Content related to the topic";
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        rlabel.InnerText = "Contenu lié au sujet";
                }
                else if (Request.QueryString["type"] == "4")
                { 
                places_DT obj = places_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));

                    Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
                    if (obj.image_name != "")
                    {

                        lcImage.ImageUrl = "../upload/forms/" + obj.image_name;
                        lcImage.Style.Add("width", "227px"); lcImage.Style.Add("hight", "169px");
                    }
                    else lcImage.ImageUrl = "../img/place.jpg";
                     HtmlGenericControl div_related_images = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_related_images");
                    div_related_images.Visible = false;
                    Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
                       // lclabel.Text = "الأثر المعمارى";
                        HtmlGenericControl rlabel = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("relatspan");
                     //   rlabel.InnerText = " محتوى متعلق بالأثر المعمارى ";
       

                        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                        {
                            lclabel.Text = "الأثر المعمارى";
                            rlabel.InnerText = "  محتوى متعلق بالأثر المعمارى ";
                        }
                        else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        {
                            lclabel.Text = "places";
                            rlabel.InnerText = "Architectural related content";

                        }
                        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        {
                            lclabel.Text = "places";
                            rlabel.InnerText = "Contenu architectural liées";

                        }
                }
                else if (Request.QueryString["type"] == "5")
                {
                   
                }
                else if (Request.QueryString["type"] == "6")
                {
                    content_media_DT media_obj_to_veiw = content_media_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));
                    Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
                    if (media_obj_to_veiw.small_image != "")
                    {

                        lcImage.ImageUrl = "../upload/Videos/" + media_obj_to_veiw.small_image;
                    }
                    else lcImage.ImageUrl = "~/img/Icon-3.jpg"; ;


                    Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
                    // lclabel.Text = "lclabel";
                    if (menus_update.get_current_lang() == 1)
                        lclabel.Text = "التسجيل التلفزيوني";
                    else if (menus_update.get_current_lang() == 2)
                        lclabel.Text = "Media TV";
                    else if (menus_update.get_current_lang() == 3)
                        lclabel.Text = "Media TV"; 
                }
                else if (Request.QueryString["type"] == "7")
                {
               
                    content_media_DT media_obj_to_veiw = content_media_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));
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
                    else
                    {
                        lclabel.Text = "التسجيل الأذاعى";
                    }
                }
                else if (Request.QueryString["type"] == "8")
                {
                    documents_DT obj = documents_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));
                    Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
                    if (obj.small_image != "")
                    {
                        //Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
                        lcImage.ImageUrl = "../images/esdarat/" + obj.small_image;
                        //Image1.ImageUrl = "~/images/esdarat/" + obj.small_image;
                    }
                    else lcImage.ImageUrl = "../img/Icon-1.jpg";
                    Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");


                    if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                    {
                        lclabel.Text = "Documents";
                    }
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        lclabel.Text = "Documents";
                    }
                    else
                    {
                        lclabel.Text = "الوثيقة";
                    }
                }
                else if (Request.QueryString["type"] == "9")
                {
                    documents_DT obj = documents_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));
                    Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
                    if (obj.small_image != "")
                    {

                        lcImage.ImageUrl = "../images/esdarat/" + obj.small_image;
                        //Image1.ImageUrl = "~/images/esdarat/" + obj.small_image;
                    }
                    else lcImage.ImageUrl = "../img/Icon-7.jpg";
                    Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");



                    if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                    {
                        lclabel.Text = "Articles";
                    }
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        lclabel.Text = "Articles";
                    }
                    else
                    {
                        lclabel.Text = "المقالة";
                    }

                }
                else if (Request.QueryString["type"] == "10")
                {
                    documents_DT book_obj = documents_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));
                    Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
                    if (book_obj.small_image != "")
                    {

                        lcImage.ImageUrl = "../images/esdarat/" + book_obj.small_image;
                    }
                    else lcImage.ImageUrl = "../img/Icon-2.jpg";


                    Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
                    //lclabel.Text = "الكـتاب";
                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                        lclabel.Text = "الكـتاب";
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        lclabel.Text = "book";
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        lclabel.Text = "livre";
                }
                else if (Request.QueryString["type"] == "11")
                {

                }
                else if (Request.QueryString["type"] == "12")
                {
                    manuscripts_DT manuscripts_obj_to_veiw = manuscripts_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));
                    Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
                    if (manuscripts_obj_to_veiw.image_name != "")
                    {

                        lcImage.ImageUrl = "../images/esdarat/" + manuscripts_obj_to_veiw.image_name;
                    }
                    else lcImage.ImageUrl = "../img/Icon-4.jpg";

                    //-------------------------------------------------------------------------------------------------------------------------------------------------------------

                    Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
                    //lclabel.Text = "المخطوط";
                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                        lclabel.Text = "المخطوط";
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        lclabel.Text = "Manuscript";
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        lclabel.Text = "manuscrit";
                }
                else if (Request.QueryString["type"] == "13")
                {
                    theses_DT theses_obj_to_veiw = theses_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));
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
                else if (Request.QueryString["type"] == "14")
                {
                    conference_proceedings_DT conferenceProceedingsObj = conference_proceedings_DB.SelectByID(CDataConverter.ConvertToInt(Request["id"]));
                    Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
                    if (conferenceProceedingsObj.image_name != "")
                    {

                        lcImage.ImageUrl = "../images/esdarat/" + conferenceProceedingsObj.image_name;
                    }
                    else lcImage.ImageUrl = "~/img/Icon-6.jpg";


                    Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
                    // Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");

                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                    {
                        lclabel.Text = " المؤتمر";
                    }
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                    {
                        lclabel.Text = "The Conference ";
                    }
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        lclabel.Text = " le conférence ";
                    }
                }
                else if (Request.QueryString["type"] == "15")
                {

                }
                else if (Request.QueryString["type"] == "16")
                {

                }
                }
            
            }
        
        if (!IsPostBack)
        {
            //////// when item is main elements only ///////////
            if (getpage_name() == "1" || getpage_name() == "7" || getpage_name() == "6")
            {
                pdf_continer.Visible = false;
            }
            if (getpage_name() == "0" &&  ireq_id == "0")
            {
                div_show.Visible = false;
                pdf_continer.Visible = false;
                retatedTo.Visible = false;
            }
            int type = CDataConverter.ConvertToInt(getpage_name());
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                mainDev.Attributes["class"] = "inner_page_body_right_enfr";
                div_related.Attributes["class"] = "_divrelated_enfr"; retatedTo.Attributes["class"] = "_divrelated_enfr";
                imgrelt.Attributes["class"] = "_divrelated_img_enfr";
                relatspan.Style.Add("float", "left");
                divtext.Style.Add("float", "right");
                divimg.Style.Add("float", "right");
                divimg.Style.Add("margin-left", "0px");
                divimg.Style.Add("margin-right", "15px");
                imgdivrelt.Style.Add("float", "left"); pdf_icon.Style.Add("float", "left"); pdf_content.Style.Add("float", "left");
                pdf_conent_middle_SUB.Style.Add("padding-right", "0pt"); pdf_conent_middle_SUB.Style.Add("padding-left", "10pt");
                pdf_conent_middle.Style.Add("text-align", "left");
                //pdf_conent_middle.Style.Add("width", "160px"); pdf_conent_middle.Style.Add("height", "32px"); 
                //pdf_conent_middle.Style.Add("background-color", "#EBE1C6");
                
                Div1.Style.Add("float", "left"); Div2.Style.Add("float", "left"); Div3.Style.Add("float", "left");
            }
            if (type < 5)
            {
                string page_name = Path.GetFileName(Request.Path);
                Session["page_name"] = page_name;

                //string images_count_str = menus_update.get_images_count(page_name);
                //if (images_count_str == "")
                //{
                //    images_link.HRef = "";
                //    images_link.Attributes.Add("onclick", "javascript : void(0);");
                //}
                //images_count.Text += images_count_str;
                string docs_count_str = menus_update.get_docs_count(page_name);
                if (docs_count_str == "")
                {
                    docs_link.HRef = "";
                    docs_link.Attributes.Add("onclick", "javascript : void(0);");
                }
                else
                {
                    docs_count.Text += docs_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        docs_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }
                string books_count_str = menus_update.get_books_count(page_name);
                if (books_count_str == "")
                {
                    books_link.HRef = "";
                    books_link.Attributes.Add("onclick", "javascript : void(0);");
                }
                else
                {
                    books_count.Text += books_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        books_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }
                string articles_count_str = menus_update.get_articles_count(page_name);
                if (articles_count_str == "")
                {
                    articles_link.HRef = "";
                    articles_link.Attributes.Add("onclick", "javascript : void(0);");
                }
                else
                {
                    articles_count.Text += articles_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        articles_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }
                string videos_count_str = menus_update.get_videos_count(page_name);
                if (videos_count_str == "")
                {
                    videos_link.HRef = "";
                    videos_link.Attributes.Add("onclick", "javascript : void(0);");
                }
                else
                {
                    videos_count.Text += videos_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        videos_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }
                string audios_count_str = menus_update.get_audios_count(page_name);
                if (audios_count_str == "")
                {
                    audios_link.HRef = "";
                    audios_link.Attributes.Add("onclick", "javascript : void(0);");
                }
                else
                {
                    audios_count.Text += audios_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        audios_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }
                string artifacts_count_str = menus_update.get_artifacts_count(page_name);
                if (artifacts_count_str == "")
                {
                    artifacts_link.HRef = "";
                    artifacts_link.Attributes.Add("onclick", "javascript : void(0);");
                }
                else
                {
                    artifacts_count.Text += artifacts_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        artifacts_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }
                string manuscripts_count_str = menus_update.get_manuscripts_count(page_name);
                if (manuscripts_count_str == "")
                {
                    manuscripts_link.HRef = "";
                    manuscripts_link.Attributes.Add("onclick", "javascript : void(0);");
                }
                else
                {
                    manuscripts_count.Text += manuscripts_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        manuscripts_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }

                string photos_count_str = menus_update.get_images_count(page_name);
                if (photos_count_str == "")
                {
                    pics_link.HRef = "";
                    pics_link.Attributes.Add("onclick", "javascript : void(0);");
                }
                else
                {
                    pics_count.Text += photos_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        pics_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }
                string websites_count_str = menus_update.get_websites_count(page_name);
                if (websites_count_str == "")
                {
                    web_link.HRef = "";
                    web_link.Attributes.Add("onclick", "javascript : void(0);");
                }
              
                else
                {
                    web_count.Text += websites_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        web_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }

                string ConferenceProceedings_count_str = menus_update.get_ConferenceProceedings_count(page_name);
                if (ConferenceProceedings_count_str == "")
                {
                    ConferenceProceedings_link.HRef = "";
                    ConferenceProceedings_link.Attributes.Add("onclick", "javascript : void(0);");
                }
                else
                {
                    ConferenceProceedings_count.Text += ConferenceProceedings_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        ConferenceProceedings_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }
                string theses_count_str = menus_update.get_theses_count(page_name);

                if (theses_count_str == "")
                {
                    theses_link.HRef = "";
                    theses_link.Attributes.Add("onclick", "javascript : void(0);");
                }
                else
                {
                    theses_count.Text += theses_count_str;
                    if (getpage_name() != "0" &&  ireq_id != "0")
                    {
                        theses_link.HRef += "?id=" +  ireq_id + "&type=" + getpage_name();
                    }
                }
                string page_name2 = Request.FilePath;

                ////// Get REALATED IMAGES ////////
                if (type != 3)
                {
                    DataTable dt = menus_update.get_images_related(page_name);
                    if (dt.Rows.Count > 0)
                    {
                        if (page_name == "characterdetails.aspx" || page_name == "eventsDetails.aspx" || page_name == "eventsDetails.aspx"
                            || page_name == "placesDetails.aspx" || page_name == "placesMoreDetails.aspx")
                        {
                            
                                if (dt.Rows[0]["small_image"].ToString() != "")
                                {
                                    img_1_1.ImageUrl = "../images/uploaded_images/" + dt.Rows[0]["small_image"].ToString();
                                    a_1_1.HRef = "../media/listPhotos.aspx?type=" + getpage_name() + "&id=" +  ireq_id + "&imgid=" + dt.Rows[0]["id"].ToString();

                                    if (dt.Rows[0]["title"].ToString() != "")
                                    {
                                        img_1_1.ToolTip = dt.Rows[0]["title"].ToString();
                                    }
                                }

                            
                            if (dt.Rows.Count > 1)
                            {
                                if (dt.Rows[1]["small_image"].ToString() != "")
                                {
                                    img_1_2.ImageUrl = "../images/uploaded_images/" + dt.Rows[1]["small_image"].ToString();
                                    a_1_2.HRef = "../media/listPhotos.aspx?type=" + getpage_name() + "&id=" +  ireq_id + "&imgid=" + dt.Rows[1]["id"].ToString();

                                    if (dt.Rows[1]["title"].ToString() != "")
                                    {
                                        img_1_2.ToolTip = dt.Rows[1]["title"].ToString();
                                    }
                                }

                            }
                            else { img_1_2.Visible = false; }
                            if (dt.Rows.Count > 2)
                            {
                                if (dt.Rows[2]["small_image"].ToString() != "")
                                {
                                    img_1_3.ImageUrl = "../images/uploaded_images/" + dt.Rows[2]["small_image"].ToString();
                                    a_1_3.HRef = "../media/listPhotos.aspx?type=" + getpage_name() + "&id=" +  ireq_id + "&imgid=" + dt.Rows[2]["id"].ToString();

                                    if (dt.Rows[2]["title"].ToString() != "")
                                    {
                                        img_1_3.ToolTip = dt.Rows[2]["title"].ToString();
                                    }
                                }
                            }
                            else { img_1_3.Visible = false; }
                            //else { img_1_3.Visible = false; }
                            ////// Get REALATED IMAGES ////////


                            //switch (page_name2)
                            //{
                            //    //chars_tr2
                            //    case "/azhar/media/photo_gallery.aspx":
                            //        images_tr.Attributes.Remove("class");
                            //        images_tr.Attributes.Add("class", "left-menu-roll");
                            //        break;
                            //    case "/azhar/Esdarat/list_document.aspx":
                            //        docs_tr.Attributes.Remove("class");
                            //        docs_tr.Attributes.Add("class", "left-menu-roll");
                            //        break;
                            //    case "/azhar/manuscripts/Default.aspx":
                            //        manuscripts_tr.Attributes.Remove("class");
                            //        manuscripts_tr.Attributes.Add("class", "left-menu-roll");
                            //        break;
                            //    case "/azhar/Esdarat/list_characters_books.aspx":
                            //        books_tr.Attributes.Remove("class");
                            //        books_tr.Attributes.Add("class", "left-menu-roll");
                            //        break;

                            //    case "/azhar/Esdarat/list_articles.aspx":
                            //        articles_tr.Attributes.Remove("class");
                            //        articles_tr.Attributes.Add("class", "left-menu-roll");
                            //        break;

                            //    case "/azhar/media/audio_tracks.aspx":
                            //        audios_tr.Attributes.Remove("class");
                            //        audios_tr.Attributes.Add("class", "left-menu-roll");
                            //        break;

                            //    case "/azhar/media/video_tracks.aspx":
                            //        videos_tr.Attributes.Remove("class");
                            //        videos_tr.Attributes.Add("class", "left-menu-roll");
                            //        break;

                            //    case "/azhar/artifacts/Default.aspx":
                            //        artifacts_tr.Attributes.Remove("class");
                            //        artifacts_tr.Attributes.Add("class", "left-menu-roll");
                            //        break;
                            //}
                        }
                    }
                    else
                    {
                        div_related_images.Visible = false;
                        div_show.Attributes.CssStyle.Add("height", "300");
                    }
                }
                else
                {
                    div_related_images.Visible = false;
                    div_show.Attributes.CssStyle.Add("height", "300");
                }
            }
            else
            {
                div_related_images.Visible = false;
                div_show.Attributes.CssStyle.Add("height", "300");
            }
        }
    }
    public string getpage_name()
    {

        string contentType = "";
        string fullPath = Request.Url.AbsolutePath;
        string pagename = System.IO.Path.GetFileName(fullPath).ToLower();
        switch (pagename)
        {
            case "characterdetails.aspx":
                {
                    contentType = "1";
                    break;
                }
            case "eventsdetails.aspx":
                {
                    contentType = "2";
                    break;
                }
            case "topicsdetails.aspx":
                {
                    contentType = "3";
                    break;
                }
            case "placesdetails.aspx":
                {
                    contentType = "4";
                    break;
                }
            case "artifactsdetails.aspx":
                {
                    contentType = "5";
                    break;
                }
            case "tvaudiodetailss.aspx":
                {
                    contentType = "6";
                    break;
                }
            case "audiodetails.aspx":
                {
                    contentType = "7";
                    break;

                }
            case "document_details.aspx":
                {
                    contentType = "8";
                    break;


                }
            case "article_details.aspx":
                {
                    contentType = "9";
                    break;


                }
            case "books_details.aspx":
                {
                    contentType = "10";
                    break;


                }
            case "listphotos.asp":
                {
                    contentType = "11";
                    break;


                }
            case "manuscriptdetails.aspx":
                {
                    contentType = "12";
                    break;


                }
            case "thesesdetails.aspx":
                {
                    contentType = "13";
                    break;


                }
            case "conferenceproceeddetails.aspx":
                {
                    contentType = "14";
                    break;


                }
            case "websitedetails.aspx":
                {
                    contentType = "15";
                    break;


                }
            case "glossary_details.aspx":
                {
                    contentType = "16";
                    break;


                }
        }
        return contentType;
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              