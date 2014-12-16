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

public partial class Esdarat_BooksDetails : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[20];

    protected void Page_Load(object sender, EventArgs e)
    {
        int id = CDataConverter.ConvertToInt(HttpUtility.HtmlEncode(Request.QueryString["id"]));
        HiddenID.Value = id.ToString();
        if (id != 0)
        {
            Session["content_id"] = id.ToString();
            Session["content_type"] = "10";
            Session["lang"] = menus_update.get_current_lang();
            View();
            if (menus_update.get_current_lang() == 1)
            {
                gview_moalf.Columns[1].Visible = false;
                gview_moalf.Columns[3].Visible = false;
            }
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                tr_fromtitle.Attributes["class"] = "accordion_title_enfr";
                tr_titleIntro.Attributes["class"] = "accordion_title_enfr";
                tr_titleIntro1.Attributes["class"] = "accordion_body_enfr";
                tr_grid_name.Attributes["class"] = "accordion_title_enfr";
                tr_grid.Attributes["class"] = "accordion_body_enfr";
                tr_lang.Attributes["class"] = "accordion_title_enfr";
                tr_lang2.Attributes["class"] = "accordion_body_enfr";
                tr_pubtitle.Attributes["class"] = "accordion_title_enfr";
                tr_pubtitle1.Attributes["class"] = "accordion_body_enfr";
                tr_series.Attributes["class"] = "accordion_title_enfr";
                tr_series1.Attributes["class"] = "accordion_body_enfr";
                tr_seriesno.Attributes["class"] = "accordion_title_enfr";
                tr_seriesno1.Attributes["class"] = "accordion_body_enfr";
                printno.Attributes["class"] = "accordion_title_enfr";
                printno1.Attributes["class"] = "accordion_body_enfr";
                tr_pageno.Attributes["class"] = "accordion_title_enfr";
                tr_pageno1.Attributes["class"] = "accordion_body_enfr";
                tr_partno.Attributes["class"] = "accordion_title_enfr";
                tr_partno1.Attributes["class"] = "accordion_body_enfr";
                tr_folderno.Attributes["class"] = "accordion_title_enfr";
                tr_folderno1.Attributes["class"] = "accordion_body_enfr";
                tr20.Attributes["class"] = "accordion_title_enfr";
                trsaveplace.Attributes["class"] = "accordion_body_enfr";
                tr119.Attributes["class"] = "accordion_title_enfr";
                saveorg.Attributes["class"] = "accordion_body_enfr";
                tr12.Attributes["class"] = "accordion_title_enfr";
                trnotes.Attributes["class"] = "accordion_body_enfr";
                tr5.Attributes["class"] = "accordion_title_enfr";
                dirsub.Attributes["class"] = "accordion_body_enfr";
                tr_publisherno.Attributes["class"] = "accordion_title_enfr";
                tr_publisherno1.Attributes["class"] = "accordion_body_enfr";
                request_no.Attributes["class"] = "accordion_title_enfr";
                nores.Attributes["class"] = "accordion_body_enfr";
                isbn.Attributes["class"] = "accordion_title_enfr";
                isbn1.Attributes["class"] = "accordion_body_enfr";
                resource.Attributes["class"] = "accordion_title_enfr";
                resource1.Attributes["class"] = "accordion_body_enfr";
            }
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
    }
    public void View()
    {
        int j = 0;
        try
        {
            int doc_id = CDataConverter.ConvertToInt(HiddenID.Value);
            if (doc_id > 0)
            {
                int lang = menus_update.get_current_lang();
                documents_DT book_obj = documents_DB.SelectByID(doc_id);
                documents_details_DT book_details_obj = documents_details_DB.SelectByID(doc_id, lang);
                publishers_DT publisher_dt = publishers_DB.SelectByID(book_obj.publisher_id);
                if (book_obj != null)
                {
                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                    {
                        //lbl_fromtitle.Text = book_details_obj.FromTitle;
                        if (book_obj.form_status != 12)
                            Response.Redirect("~/Esdarat/list_characters_books.aspx");
                    }
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                    {
                        //lbl_fromtitle.Text = book_details_obj.FromTitle;
                        if (book_obj.form_status_en != 12)
                            Response.Redirect("~/Esdarat/list_characters_books.aspx");
                    }
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        //lbl_fromtitle.Text = book_details_obj.FromTitle;
                        if (book_obj.form_status_fr != 12)
                            Response.Redirect("~/Esdarat/list_characters_books.aspx");
                    }
                }



                //----------------------------------------no 0----------------------------------------------

                if (book_details_obj.title != "")
                {
                    lbl_fromtitle.Text = book_details_obj.title;
                }
                else
                {
                    tr_fromtitle.Visible = false;
                    tr_fromtitle.Visible = false;
                }
                //----------------------------------------no 1----------------------------------------------


                if (book_details_obj.FromHeader != "")
                {
                    lbl_fromheader.Text = book_details_obj.FromHeader;

                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr_titleIntro";
                    j = j + 1;
                }
                else
                {
                    tr_titleIntro.Visible = false;
                    tr_titleIntro1.Visible = false;
                }
                //----------------------------------------no 3----------------------------------------------

                if (book_details_obj.doc_lang != "")
                {
                    Lablang.Text = book_details_obj.doc_lang;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr_lang";
                    j = j + 1;
                }
                else
                {
                    tr_lang.Visible = false;
                    tr_lang2.Visible = false;

                }
                //----------------------------------------no 4----------------------------------------------


                if (book_details_obj.series != "")
                {
                    lbl_series.Text = book_details_obj.series;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr_series";
                    j = j + 1;
                }
                else
                {
                    tr_series.Visible = false;
                    tr_series1.Visible = false;
                }
                //----------------------------------------no 5----------------------------------------------

                if (book_details_obj.series_no != "")
                {
                    lbl_seriesno.Text = book_details_obj.series_no;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr_seriesno";
                    j = j + 1;
                }
                else
                {

                    tr_seriesno.Visible = false;
                    tr_seriesno1.Visible = false;
                }
                //----------------------------------------no 6----------------------------------------------

                if (book_obj.publish_no != "")
                {
                    lblprintno.Text = book_obj.publish_no.ToString();
                    count_fields = count_fields + 1;
                    arr_divs[j] = "printno";
                    j = j + 1;
                }

                else
                {
                    printno.Visible = false;
                    printno1.Visible = false;
                }
                //----------------------------------------no 7----------------------------------------------

                if (book_obj.pages_no != 0)
                {
                    labpageno.Text = book_obj.pages_no.ToString();
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr_pageno";
                    j = j + 1;
                }

                else
                {
                    tr_pageno.Visible = false;
                    tr_pageno1.Visible = false;
                }
                //----------------------------------------no 8----------------------------------------------

                if (book_obj.creater_no != "")
                {
                    lbl_partno.Text = book_obj.creater_no.ToString();
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr_partno";
                    j = j + 1;
                }
                else
                {
                    tr_partno.Visible = false;
                    tr_partno1.Visible = false;
                }
                //----------------------------------------no 9----------------------------------------------

                if (book_obj.folders_no != "")
                {
                    labfolderno.Text = book_obj.folders_no;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr_folderno";
                    j = j + 1;
                }

                else
                {
                    tr_folderno.Visible = false;
                    tr_folderno1.Visible = false;

                }
                //----------------------------------------no 9----------------------------------------------

                if (book_obj.folders_no != "")
                {
                    labfolderno.Text = book_obj.folders_no;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr_folderno";
                    j = j + 1;
                }
                else
                {
                    tr_folderno.Visible = false;
                    tr_folderno1.Visible = false;
                }

                //----------------------------------------no 10----------------------------------------------
                if (publisher_dt != null)
                {
                    if (menus_update.get_current_lang() == 1)
                    { Labpubtitle.Text = publisher_dt.title_ar; }
                    else if (menus_update.get_current_lang() == 2)
                    { Labpubtitle.Text = publisher_dt.title_en; }
                    else if (menus_update.get_current_lang() == 3)
                    { Labpubtitle.Text = publisher_dt.title_fr; }
                    tr_pubtitle.Visible = true;
                    tr_pubtitle1.Visible = true;

                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr_pubtitle";
                    j = j + 1;


                }
                else
                {
                    tr_pubtitle.Visible = false;
                    tr_pubtitle.Visible = false;
                }


                if (book_details_obj.publish_location != "")
                {
                    labpubLocation.Text = book_details_obj.publish_location;
                }

                else
                {
                    tr_Location.Visible = false;

                }
                //----------------------------------------no 11---------------------------------------------
                if (book_details_obj.organization_save != "")
                {
                    lbl_org_save.Text = book_details_obj.organization_save;
                }
                else
                {
                    trsaveplace1.Visible = false;
                }


                if (book_details_obj.city != "")
                {
                    town.Text = book_details_obj.city;
                }
                else
                {
                    trsaveCity.Visible = false;
                }
                if (book_details_obj.country_name != "")
                {
                    country.Text = book_details_obj.country_name;
                }
                else
                {
                    trsavecountry.Visible = false;
                }


                if (book_details_obj.organization_save != "" || book_details_obj.city != "" || book_details_obj.country_name != ""  )
                {
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr20";
                    j = j + 1;
                }
                else if (book_details_obj.organization_save == "" && book_details_obj.city == "" && book_details_obj.country_name == ""  )
                {
                    tr20.Visible = false;
                    trsaveplace.Visible = false;
                }
                //----------------------------------------no 12---------------------------------------------

                if (book_details_obj.save_public_no != "")
                {
                    general_no.Text = book_details_obj.save_public_no;
                }
                else
                {
                    trgeneralno.Visible = false;
                }


                if (book_details_obj.save_specifics_no != "")
                {
                    special_no.Text = book_details_obj.save_specifics_no;
                }
                else
                {
                    trspecialno.Visible = false;
                }

                if (book_details_obj.art_no != "")
                {
                    the_art.Text = book_details_obj.art_no;
                }
                else
                {
                    trart.Visible = false;
                }


                if (book_details_obj.library_no != "")
                {
                    special_lib.Text = book_details_obj.library_no;
                }
                else
                {
                    splib.Visible = false;
                }
                if (book_details_obj.save_public_no != "" || book_details_obj.save_specifics_no != "" || book_details_obj.art_no != "" || book_details_obj.library_no != "")
                {
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr119";
                    j = j + 1;
                }
                else if (book_details_obj.save_public_no == "" && book_details_obj.save_specifics_no == "" && book_details_obj.art_no == "" && book_details_obj.library_no == "")
                {
                    tr119.Visible = false;
                    saveorg.Visible = false;
                }

                //----------------------------------------no 13----------------------------------------------

                if (book_details_obj.notes != "")
                {
                    notes.Text = book_details_obj.notes;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr12";
                    j = j + 1;
                }
                else
                {
                    tr12.Visible = false;
                    trnotes.Visible = false;
                }

                //----------------------------------------no 14----------------------------------------------

                if (book_details_obj.direct_subject != "")
                {
                    labdirsub.Text = book_details_obj.direct_subject;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr5";
                    j = j + 1;
                }

                else
                {
                    tr5.Visible = false;
                    dirsub.Visible = false;
                }


                if (book_obj.publish_date != "")
                {
                    labdate.Text = book_obj.publish_date;

                }

                else
                {
                    tr_labdate.Visible = false;
                }

                if (book_obj.publish_hdate != "")
                {
                    labhdate.Text = book_obj.publish_hdate;
                }

                else
                {
                    tr_labhdate.Visible = false;
                }

                //----------------------------------------no 15----------------------------------------------

                if (book_obj.publish_no != "")
                {
                    labpublishno.Text = book_obj.publish_no;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "tr_publisherno";
                    j = j + 1;
                }

                else
                {
                    tr_publisherno.Visible = false;
                    tr_publisherno1.Visible = false;

                }

                //----------------------------------------no 16----------------------------------------------

                if (book_details_obj.request_id != "")
                {
                    labnores.Text = book_details_obj.request_id;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "request_no";
                    j = j + 1;
                }

                else
                {
                    request_no.Visible = false;
                    nores.Visible = false;
                }


                //----------------------------------------no 17---------------------------------------------


                if (book_obj.isbn != "")
                {
                    labisbn.Text = book_obj.isbn;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "isbn";
                    j = j + 1;
                }
                else
                {
                    isbn.Visible = false;
                    isbn1.Visible = false;
                }
                //----------------------------------------no 18----------------------------------------------

                if (book_details_obj.resource != "")
                {
                    Labresource.Text = book_details_obj.resource;
                    count_fields = count_fields + 1;
                    arr_divs[j] = "resource";
                    j = j + 1;
                }
                else
                {
                    resource.Visible = false;
                    resource1.Visible = false;
                }


                //----------------------------------------no ----------------------------------------------

              
                //if (book_details_obj.save_no != "")
                //{
                //    lbl_partno.Text = book_details_obj.save_no;
                //}
                //else
                //{
                //    tr_partno.Visible = false;
                //    tr_partno1.Visible = false;
                //}
                //if (book_details_obj.save_notes  != "")
                //{
                //    notes.Text = book_details_obj.save_notes;
                //}
                //else
                //{
                //   trnotes.Visible = false;
                //   tr12.Visible = false;
                //}







                grid_author_view();

                if (book_obj.small_image != "")
                {

                    HtmlAnchor link_pdf1 = (HtmlAnchor)Page.Master.FindControl("leftUC11").FindControl("link_pdf1");
                    link_pdf1.HRef = "~/images/esdarat/" + book_obj.large_image;
                    Label lbl_veiw = (Label)Page.Master.FindControl("leftUC11").FindControl("lbl_veiw");
                    //lbl_veiw.Text = "عرض الكتاب";
                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                        lbl_veiw.Text = "عرض الكتاب";
                    else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        lbl_veiw.Text = "View the book";
                    else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        lbl_veiw.Text = "voir le livre";
                }

                else
                {
                    HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
                    pdf_continer.Visible = false;
                }

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
                //lclabel.Text = "book";
            }
        }
        catch { }

    }
    public void grid_author_view()
    {

        int id = CDataConverter.ConvertToInt(HiddenID.Value);
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt(id)),
           new SqlParameter("@lang_id", menus_update.get_current_lang()) };
        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParams, "authorstitle_select");
        if (dt.Rows.Count > 0)
        {
            tr_grid_name.Visible = true;
            tr_grid.Visible = true;
            gview_moalf.Visible = true;
            gview_moalf.DataSource = dt;
            gview_moalf.DataBind();
            /////////////////////////////////////////////////////////////////////
            if (CDataConverter.ConvertToInt(menus_update.get_current_lang()) > 1)
            {
                SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt(id)) ,
                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                DataTable dt2 = new DataTable();
                dt2 = DatabaseFunctions.SelectData(sqlParams1, "authorstitle_select");
                for (int f = 0; f < dt.Rows.Count; f++)
                {
                    if (dt.Rows[f]["is_character"].ToString() == "1")
                    {
                        dt.Rows[f].Delete();
                    }
                    else
                    {
                        DataRow[] foundRows;
                        foundRows = dt2.Select("author_id = '" + dt.Rows[f]["author_id"].ToString() + "'");
                        if (foundRows.Length > 0)
                        {
                            dt.Rows[f]["name_ar"] = foundRows[0][2].ToString();
                        }
                    }
                }
                gview_moalf.Visible = true;
                gview_moalf.DataSource = dt;
                gview_moalf.DataBind();
            }
        }
        else { tr_grid_name.Visible = false; tr_grid.Visible = false; }
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
