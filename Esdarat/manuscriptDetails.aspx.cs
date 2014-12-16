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

public partial class Esdarat_manuscriptDetails : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[22];
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
            HiddenID.Value = id.ToString();
            if (id != 0)
            {
                Session["content_id"] = id.ToString();
                Session["content_type"] = "12";
                //Session["referred"] = "true";
                if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                {
                    tr.Attributes["class"] = "accordion_title_enfr";
                    tr_title.Attributes["class"] = "accordion_title_enfr";
                    trtitfromtit.Attributes["class"] = "accordion_body_enfr";
                    tr_title2.Attributes["class"] = "accordion_title_enfr";
                    trtitfromintro.Attributes["class"] = "accordion_body_enfr";
                    Tr5.Attributes["class"] = "accordion_title_enfr";
                    trauthfromtit.Attributes["class"] = "accordion_body_enfr";
                    Tr2.Attributes["class"] = "accordion_title_enfr";
                    trauthfromintro.Attributes["class"] = "accordion_body_enfr";
                    tr6.Attributes["class"] = "accordion_title_enfr";
                    trlang.Attributes["class"] = "accordion_body_enfr";
                    tr_place.Attributes["class"] = "accordion_title_enfr";
                    trplace.Attributes["class"] = "accordion_body_enfr";
                    tr_copier.Attributes["class"] = "accordion_title_enfr";
                    trcopier.Attributes["class"] = "accordion_body_enfr";
                    tr_date.Attributes["class"] = "accordion_title_enfr";
                    trdates.Attributes["class"] = "accordion_body_enfr";
                    tr8.Attributes["class"] = "accordion_title_enfr";
                    trcopystate.Attributes["class"] = "accordion_body_enfr";
                    tr9.Attributes["class"] = "accordion_title_enfr";
                    trgroupno.Attributes["class"] = "accordion_body_enfr";
                    tr10.Attributes["class"] = "accordion_title_enfr";
                    trfromto.Attributes["class"] = "accordion_body_enfr";
                    tr11.Attributes["class"] = "accordion_title_enfr";
                    trpartno.Attributes["class"] = "accordion_body_enfr";
                    tr12.Attributes["class"] = "accordion_title_enfr";
                    trfolderno.Attributes["class"] = "accordion_body_enfr";
                    tr13.Attributes["class"] = "accordion_title_enfr";
                    trlength.Attributes["class"] = "accordion_body_enfr";
                    tr14.Attributes["class"] = "accordion_title_enfr";
                    trruler.Attributes["class"] = "accordion_body_enfr";
                    tr15.Attributes["class"] = "accordion_title_enfr";
                    trcopycontains.Attributes["class"] = "accordion_body_enfr";
                    tr16.Attributes["class"] = "accordion_title_enfr";
                    trfonttype.Attributes["class"] = "accordion_body_enfr";
                    tr17.Attributes["class"] = "accordion_title_enfr";
                    trcopyhas.Attributes["class"] = "accordion_body_enfr";
                    tr18.Attributes["class"] = "accordion_title_enfr";
                    trintro.Attributes["class"] = "accordion_body_enfr";
                    tr19.Attributes["class"] = "accordion_title_enfr";
                    trconclusion.Attributes["class"] = "accordion_body_enfr";
                    tr20.Attributes["class"] = "accordion_title_enfr";
                    Tr21.Attributes["class"] = "accordion_body_enfr";
                    tr119.Attributes["class"] = "accordion_title_enfr";
                    saveorg.Attributes["class"] = "accordion_body_enfr";
                    trnotes.Attributes["class"] = "accordion_title_enfr";
                    tr120.Attributes["class"] = "accordion_body_enfr";
                    tregaza.Attributes["class"] = "accordion_title_enfr";
                    trlicense.Attributes["class"] = "accordion_body_enfr";
                    trolddates.Attributes["class"] = "accordion_title_enfr";
                    troldest.Attributes["class"] = "accordion_body_enfr";
                    trsamaa.Attributes["class"] = "accordion_title_enfr";
                    trhearings.Attributes["class"] = "accordion_body_enfr";
                    troldhearings.Attributes["class"] = "accordion_title_enfr";
                    troldhearingsdate.Attributes["class"] = "accordion_body_enfr";
                    tr1.Attributes["class"] = "accordion_title_enfr";
                    trgid1.Attributes["class"] = "accordion_body_enfr";
                    tr3.Attributes["class"] = "accordion_title_enfr";
                    tr_grid_tawfikat.Attributes["class"] = "accordion_body_enfr";
                }
                fillcheck_periods();
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
        }
    }
    private void fillcheck_periods()
    {
        periods_DT obj = new periods_DT();
        DataTable per_dt = periods_DB.SelectAll();
        //chk_periods.DataSource = per_dt;
        //chk_periods.DataBind();
        man_lang.DataSource = languages_DB.SelectAll();
        man_lang.DataBind();

        copy_state.DataSource = copy_status_DB.SelectAll();
        copy_state.DataBind();

        copy_contains.DataSource = copy_contains_DB.SelectAll();
        copy_contains.DataBind();

        copy_has.DataSource = copy_has_DB.SelectAll();
        copy_has.DataBind();

        license_type.DataSource = license_type_DB.SelectAll();
        license_type.DataBind();
        //chk_periods.DataValueField = "id";
        // chk_periods.DataTextField = "title";

    }
    public void View()
    {
        int j = 0;

        manuscripts_DT manuscripts_obj_to_veiw = new manuscripts_DT();
        manuscripts_details_DT manuscripts_details_obj_to_veiw = new manuscripts_details_DT();
        manuscripts_obj_to_veiw = manuscripts_DB.SelectByID(Convert.ToInt16(HiddenID.Value));
        manuscripts_details_obj_to_veiw = manuscripts_details_DB.SelectByID(Convert.ToInt16(HiddenID.Value), menus_update.get_current_lang());
        if (manuscripts_obj_to_veiw != null)
        {
            //if (manuscripts_obj_to_veiw.form_status != 12)
            //    Response.Redirect("~/Esdarat/listManuscript.aspx");
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                if (manuscripts_obj_to_veiw.form_status != 12)
                    Response.Redirect("~/Esdarat/listManuscript.aspx");
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                if (manuscripts_obj_to_veiw.form_status_en != 12)
                    Response.Redirect("~/Esdarat/listManuscript.aspx");
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                if (manuscripts_obj_to_veiw.form_status_fr != 12)
                    Response.Redirect("~/Esdarat/listManuscript.aspx");
            }
        }

        Labtitle.Text = manuscripts_details_obj_to_veiw.title;
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.title_fromtitle != null && manuscripts_details_obj_to_veiw.title_fromtitle != "")
        {
            txt_fromtitle.Text = manuscripts_details_obj_to_veiw.title_fromtitle;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_title";
            j = j + 1;
        }
        else
        {
            trtitfromtit.Visible = tr_title.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.title_intro != null && manuscripts_details_obj_to_veiw.title_intro != "")
        {
            txt_title_intro.Text = manuscripts_details_obj_to_veiw.title_intro;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_title2";
            j = j + 1;
        }
        else
        {
            trtitfromintro.Visible = tr_title2.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        //txt_title_mosk.Text= manuscripts_details_obj_to_save.title_mosk ;

        //manuscripts_details_obj_to_save.author = author.Text;
        if (manuscripts_details_obj_to_veiw.author_fromtitle != null && manuscripts_details_obj_to_veiw.author_fromtitle != "")
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "Tr5";
            j = j + 1;

            author.Text = manuscripts_details_obj_to_veiw.author_fromtitle;
        }
        else { trauthfromtit.Visible = Tr5.Visible = false; }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.author_mosk != null && manuscripts_details_obj_to_veiw.author_mosk != "")
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "Tr2";
            j = j + 1;
            txt_author_mokdma.Text = manuscripts_details_obj_to_veiw.author_mosk;
        }
        else
        {
            trauthfromintro.Visible = Tr2.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------


        //txt_author_moska.Text = manuscripts_details_obj_to_veiw.author_mosk;
        if (manuscripts_details_obj_to_veiw.license_type != null && manuscripts_details_obj_to_veiw.license_type.ToString() != "")
        {
            if (manuscripts_details_obj_to_veiw.license_type.ToString() != "3" && manuscripts_details_obj_to_veiw.license_type.ToString() != "2" && manuscripts_details_obj_to_veiw.license_type.ToString() != "1")
            {
                other_license_type.Text = manuscripts_details_obj_to_veiw.license_type;
                Label55.Visible = true;
            }
            else
            {
                if (manuscripts_details_obj_to_veiw.license_type != "")
                {
                    Label55.Visible = false;
                    license_type.SelectedValue = manuscripts_details_obj_to_veiw.license_type;
                    //license_type.Visible = true;
                    lbl_license_type.Text = license_type.SelectedItem.Text;
                    //lbl_license_type.Text = license_type.Items[CDataConverter.ConvertToInt(manuscripts_details_obj_to_veiw.license_type) - 1].Text;
                }
            }
            count_fields = count_fields + 1;
            arr_divs[j] = "tregaza";
            j = j + 1;
        }
        else
            tregaza.Visible = trlicense.Visible = false;
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------


        if (manuscripts_details_obj_to_veiw.listinging != null && manuscripts_details_obj_to_veiw.listinging != "")
        {
            listinging.SelectedValue = manuscripts_details_obj_to_veiw.listinging;
            lbl_listinging.Text = listinging.SelectedItem.Text;
            count_fields = count_fields + 1;
            arr_divs[j] = "trsamaa";
            j = j + 1;
        }
        else
            trhearings.Visible = trsamaa.Visible = false;
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.copy_has != null && manuscripts_details_obj_to_veiw.copy_has != "")
        {
            String[] temp = manuscripts_details_obj_to_veiw.copy_has.ToString().Split(',');
            if (temp.Length > 0)
            {
                for (int i = 0; i < copy_has.Items.Count; i++)
                {
                    for (int k = 0; k < temp.Length - 1; k++)
                    {
                        if (copy_has.Items[i].Value == temp[k])
                        {
                            copy_has.Items[i].Selected = true;
                            lbl_copy_has.Text += k < temp.Length - 2 && k != temp.Length - 1 ? copy_has.Items[i].Text + ", " : copy_has.Items[i].Text + ".";
                        }
                    }
                }
            }
            count_fields = count_fields + 1;
            arr_divs[j] = "tr17";
            j = j + 1;
        }
        else
        {
            trcopyhas.Visible = tr17.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------


        if (manuscripts_details_obj_to_veiw.font_type != null && manuscripts_details_obj_to_veiw.font_type != "")
        {
            font_type.SelectedValue = manuscripts_details_obj_to_veiw.font_type;
            lbl_font_type.Text = font_type.SelectedItem.Text;

            count_fields = count_fields + 1;
            arr_divs[j] = "tr16";
            j = j + 1;
        }
        else
        {
            trfonttype.Visible = tr16.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.copy_contains != null && manuscripts_details_obj_to_veiw.copy_contains != "")
        {
            String[] temp = manuscripts_details_obj_to_veiw.copy_contains.ToString().Split(',');
            if (temp.Length > 0)
            {
                for (int i = 0; i < copy_contains.Items.Count; i++)
                {
                    for (int n = 0; n < temp.Length - 1; n++)
                    {
                        if (copy_contains.Items[i].Value == temp[n])
                        {
                            copy_contains.Items[i].Selected = true;
                            lbl_copy_contains.Text += n < temp.Length - 2 && n != temp.Length - 1 ? copy_contains.Items[i].Text + ", " : copy_contains.Items[i].Text + ".";
                        }
                    }
                }
            }
            count_fields = count_fields + 1;
            arr_divs[j] = "tr15";
            j = j + 1;
        }
        else
        {
            trcopycontains.Visible = tr15.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.copy_state != null && manuscripts_details_obj_to_veiw.copy_state != "")
        {
            copy_state.SelectedValue = manuscripts_details_obj_to_veiw.copy_state;
            lbl_copy_state.Text = copy_state.SelectedItem.Text;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr8";
            j = j + 1;
        }
        else
        {
            trcopystate.Visible = tr8.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.copy_date_type != null && manuscripts_details_obj_to_veiw.copy_date_type != "")
        {
            copy_date_type.SelectedValue = manuscripts_details_obj_to_veiw.copy_date_type;
            lbl_copy_date_type.Text = copy_date_type.SelectedItem.Text;
        }
        if (manuscripts_details_obj_to_veiw.copy_date != null && manuscripts_details_obj_to_veiw.copy_date != "")
        {
            copy_date.Text = manuscripts_details_obj_to_veiw.copy_date;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_date";
            j = j + 1;
        }
        else
        {
            trdates.Visible = tr_date.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.man_lang != null && manuscripts_details_obj_to_veiw.man_lang != "")
        {
            man_lang.SelectedValue = manuscripts_details_obj_to_veiw.man_lang;
            lbl_man_lang.Text = man_lang.SelectedItem.Text;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (man_lang.SelectedIndex == -1)
        { trlang.Visible = tr6.Visible = false; }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "tr6";
            j = j + 1;
        }
        //author_src.SelectedValue = manuscripts_details_obj_to_veiw.author_src;
        if (manuscripts_details_obj_to_veiw.copy_place != null && manuscripts_details_obj_to_veiw.copy_place != "")
        {
            copy_place.Text = manuscripts_details_obj_to_veiw.copy_place;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_place";
            j = j + 1;


        }
        else
        {
            trplace.Visible = tr_place.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------


        if (manuscripts_details_obj_to_veiw.copier != null && manuscripts_details_obj_to_veiw.copier != "")
        {
            copier.Text = manuscripts_details_obj_to_veiw.copier;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_copier";
            j = j + 1;
        }
        else
        {
            trcopier.Visible = tr_copier.Visible = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.copy_state != "")
            copy_state.SelectedValue = manuscripts_details_obj_to_veiw.copy_state;

        if (manuscripts_details_obj_to_veiw.collection_no != null && manuscripts_details_obj_to_veiw.collection_no != "")
        { 
            collection_no.Text = manuscripts_details_obj_to_veiw.collection_no;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr9";
            j = j + 1;

        }
        else
        {
            trgroupno.Visible = tr9.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.papers_from != null && manuscripts_details_obj_to_veiw.papers_from != "" &&
            manuscripts_details_obj_to_veiw.papers_to != null && manuscripts_details_obj_to_veiw.papers_to != "")
        {
            papers_from.Text = manuscripts_details_obj_to_veiw.papers_from;
            papers_to.Text = manuscripts_details_obj_to_veiw.papers_to;

            count_fields = count_fields + 1;
            arr_divs[j] = "tr10";
            j = j + 1;
        }
        else
        {
            trfromto.Visible = tr10.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.parts_no != null && manuscripts_details_obj_to_veiw.parts_no != "")
        {
            parts_no.Text = manuscripts_details_obj_to_veiw.parts_no;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr11";
            j = j + 1;
        }
        else
        {
            trpartno.Visible = tr11.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.folders_no != null && manuscripts_details_obj_to_veiw.folders_no != "")
        {
            folders_no.Text = manuscripts_details_obj_to_veiw.folders_no;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr12";
            j = j + 1;
        }
        else
        {
            trfolderno.Visible = tr12.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if ((manuscripts_details_obj_to_veiw.length == null || manuscripts_details_obj_to_veiw.length == "") &&
           (manuscripts_details_obj_to_veiw.width == null || manuscripts_details_obj_to_veiw.width == "") &&
           (manuscripts_details_obj_to_veiw.height == null || manuscripts_details_obj_to_veiw.height == ""))
        { trlength.Visible = tr13.Visible = false; }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "tr13";
            j = j + 1;


            if (manuscripts_details_obj_to_veiw.length != null && manuscripts_details_obj_to_veiw.length != "")
                length.Text = manuscripts_details_obj_to_veiw.length;
            else
                trlength.Visible = false;
            //if (manuscripts_details_obj_to_veiw.width != null && manuscripts_details_obj_to_veiw.width != "")
            //    width.Text = manuscripts_details_obj_to_veiw.width;
            //else
            //    trwidth.Visible = false;
            //if (manuscripts_details_obj_to_veiw.height != null && manuscripts_details_obj_to_veiw.height != "")
            //    height.Text = manuscripts_details_obj_to_veiw.height;
            //else
            //    trheight.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.ruler != null && manuscripts_details_obj_to_veiw.ruler != "")
        {
            ruler.Text = manuscripts_details_obj_to_veiw.ruler;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr14";
            j = j + 1;
        }
        else
            trruler.Visible = tr14.Visible = false;
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------


        if (manuscripts_details_obj_to_veiw.introduction != null && manuscripts_details_obj_to_veiw.introduction != "")
        {
            introduction.Text = manuscripts_details_obj_to_veiw.introduction;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr18";
            j = j + 1;
        }
        else
            trintro.Visible = tr18.Visible = false;
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.conclusion != null && manuscripts_details_obj_to_veiw.conclusion != "")
        {
            conclusion.Text = manuscripts_details_obj_to_veiw.conclusion;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr19";
            j = j + 1;
        }
        else
            trconclusion.Visible = tr19.Visible = false;
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if ((manuscripts_details_obj_to_veiw.country == null || manuscripts_details_obj_to_veiw.country == "") &&
          (manuscripts_details_obj_to_veiw.town == null || manuscripts_details_obj_to_veiw.town == ""))
        { Tr21.Visible = tr20.Visible = false; }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "tr20";
            j = j + 1;


            if (manuscripts_details_obj_to_veiw.country != null && manuscripts_details_obj_to_veiw.country != "")
                country.Text = manuscripts_details_obj_to_veiw.country;
            else
                Tr21.Visible = false;
            //if (manuscripts_details_obj_to_veiw.town != null && manuscripts_details_obj_to_veiw.town != "")
            //    town.Text = manuscripts_details_obj_to_veiw.town;
            //else
            //    Tr22.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if ((manuscripts_details_obj_to_veiw.general_no == null || manuscripts_details_obj_to_veiw.general_no == "") &&
           (manuscripts_details_obj_to_veiw.special_no == null || manuscripts_details_obj_to_veiw.special_no == "") &&
            (manuscripts_details_obj_to_veiw.the_art == null || manuscripts_details_obj_to_veiw.the_art == "") &&
            (manuscripts_details_obj_to_veiw.special_lib == null || manuscripts_details_obj_to_veiw.special_lib == ""))
        { saveorg.Visible = tr119.Visible = false; }
        else
        {

            count_fields = count_fields + 1;
            arr_divs[j] = "tr119";
            j = j + 1;




            //if (manuscripts_details_obj_to_veiw.general_no != null && manuscripts_details_obj_to_veiw.general_no != "")
            //    general_no.Text = manuscripts_details_obj_to_veiw.general_no;
            //else
            //    trgeneralno.Visible = false;

            //if (manuscripts_details_obj_to_veiw.special_no != null && manuscripts_details_obj_to_veiw.special_no != "")
            //    special_no.Text = manuscripts_details_obj_to_veiw.special_no;
            //else
            //    trspecialno.Visible = false;

            //if (manuscripts_details_obj_to_veiw.the_art != null && manuscripts_details_obj_to_veiw.the_art != "")
            //    the_art.Text = manuscripts_details_obj_to_veiw.the_art;
            //else
            //    trart.Visible = false;

            //if (manuscripts_details_obj_to_veiw.special_lib != null && manuscripts_details_obj_to_veiw.special_lib != "")
            //    special_lib.Text = manuscripts_details_obj_to_veiw.special_lib;
            //else
            //    splib.Visible = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.notes != null && manuscripts_details_obj_to_veiw.notes != "")
        {
            notes.Text = manuscripts_details_obj_to_veiw.notes;
            count_fields = count_fields + 1;
            arr_divs[j] = "trnotes";
            j = j + 1;
        }
        else
            trnotes.Visible = tr120.Visible = false;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (manuscripts_details_obj_to_veiw.license_type != "")
            license_type.SelectedValue = manuscripts_details_obj_to_veiw.license_type;

        if ((manuscripts_details_obj_to_veiw.oldest_license_date_m == null || manuscripts_details_obj_to_veiw.oldest_license_date_m == "") &&
          (manuscripts_details_obj_to_veiw.oldest_license_date_h == null || manuscripts_details_obj_to_veiw.oldest_license_date_h == ""))
        { troldest.Visible = trolddates.Visible = false; }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "trolddates";
            j = j + 1;

            oldest_license_date_m.Text = manuscripts_details_obj_to_veiw.oldest_license_date_m;
            oldest_license_date_h.Text = manuscripts_details_obj_to_veiw.oldest_license_date_h;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        if ((manuscripts_details_obj_to_veiw.listinging_date_m == null || manuscripts_details_obj_to_veiw.listinging_date_m == "") &&
          (manuscripts_details_obj_to_veiw.listinging_date_h == null || manuscripts_details_obj_to_veiw.listinging_date_h == ""))
        { troldhearingsdate.Visible = troldhearings.Visible = false; }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "troldhearings";
            j = j + 1;

            listinging_date_m.Text = manuscripts_details_obj_to_veiw.listinging_date_m;
            listinging_date_h.Text = manuscripts_details_obj_to_veiw.listinging_date_h;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------


        if (manuscripts_obj_to_veiw.file_name != "")
        {

            HtmlAnchor link_pdf1 = (HtmlAnchor)Page.Master.FindControl("leftUC11").FindControl("link_pdf1");
            link_pdf1.HRef = "~/images/esdarat/" + manuscripts_obj_to_veiw.file_name;
            Label lbl_veiw = (Label)Page.Master.FindControl("leftUC11").FindControl("lbl_veiw");
            //lbl_veiw.Text = "عرض المخطوط";
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                lbl_veiw.Text = "عرض المخطوط";
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                lbl_veiw.Text = "Showing manuscript";
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                lbl_veiw.Text = "Affichage manuscrit";
        }

        else
        {
            HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
            pdf_continer.Visible = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

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

        SqlParameter[] sqlParams_tamalokat = new SqlParameter[] { new SqlParameter("@manuscript_id", CDataConverter.ConvertToInt(HiddenID.Value)) };
        DataTable dt_tamalokat = new DataTable();
        dt_tamalokat = DatabaseFunctions.SelectData(sqlParams_tamalokat, "tamalokat_Select_select");
        if (dt_tamalokat.Rows.Count > 0)
        {
            TamalokatGridView.DataSource = dt_tamalokat;
            TamalokatGridView.DataBind();
            if (menus_update.get_current_lang() == 1)
            {

                TamalokatGridView.Columns[2].Visible = TamalokatGridView.Columns[1].Visible = false;
            }
            if (menus_update.get_current_lang() == 2)
            {


                TamalokatGridView.Columns[0].Visible = TamalokatGridView.Columns[2].Visible = false;

            }
            if (menus_update.get_current_lang() == 3)
            {


                TamalokatGridView.Columns[0].Visible = TamalokatGridView.Columns[1].Visible = false;

            }
            count_fields = count_fields + 1;
            arr_divs[j] = "tr1";
            j = j + 1;
        }
        else
        {
            trgid1.Visible = tr1.Visible = false;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        SqlParameter[] sqlParams_tawkifat = new SqlParameter[] { new SqlParameter("@manuscript_id", CDataConverter.ConvertToInt(HiddenID.Value)) };
        DataTable dt_tawkifat = new DataTable();
        dt_tawkifat = DatabaseFunctions.SelectData(sqlParams_tawkifat, "tawkifat_Select_select");
        if (dt_tawkifat.Rows.Count > 0)
        {
            TawfikatGridView.DataSource = dt_tawkifat;
            TawfikatGridView.DataBind();
            if (menus_update.get_current_lang() == 1)
            {


                TawfikatGridView.Columns[2].Visible = TawfikatGridView.Columns[1].Visible = false;
            }
            if (menus_update.get_current_lang() == 2)
            {



                TawfikatGridView.Columns[0].Visible = TawfikatGridView.Columns[2].Visible = false;

            }
            if (menus_update.get_current_lang() == 3)
            {



                TawfikatGridView.Columns[0].Visible = TawfikatGridView.Columns[1].Visible = false;

            }

            count_fields = count_fields + 1;
            arr_divs[j] = "tr3";
            j = j + 1;
        }
        else
        {
            tr_grid_tawfikat.Visible = tr3.Visible = false;
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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     