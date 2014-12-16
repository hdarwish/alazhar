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

public partial class sheikhs_characterdetails : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[14];
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
            int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
            Session["content_id"] = id.ToString();
            Session["content_type"] = "1";
            //Session["referred"] = "true";
           
            HiddenID.Value = id.ToString();
            if (id > 0)
            { hits_count obj = new hits_count(); 
                obj.hit_count_save(id, 1); }
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                trname.Attributes["class"] = "accordion_title_enfr";
                trhbirthdate.Attributes["class"] = "accordion_title_enfr";
                trhdeathdate.Attributes["class"] = "accordion_title_enfr";
                trchartype.Attributes["class"] = "accordion_title_enfr";
                trshohra.Attributes["class"] = "accordion_title_enfr";
                //trothername.Attributes["class"] = "accordion_title_enfr";
                tral2ab.Attributes["class"] = "accordion_title_enfr";
                trtitles.Attributes["class"] = "accordion_title_enfr";
                trnabtha.Attributes["class"] = "accordion_title_enfr";
                trdetails.Attributes["class"] = "accordion_body_enfr";
                trnash2a.Attributes["class"] = "accordion_title_enfr";
                trbdetails.Attributes["class"] = "accordion_body_enfr";
                trsci.Attributes["class"] = "accordion_title_enfr";
                trscientific.Attributes["class"] = "accordion_body_enfr";
                trworkin.Attributes["class"] = "accordion_title_enfr";
                trworklife.Attributes["class"] = "accordion_body_enfr";
                tracti.Attributes["class"] = "accordion_title_enfr";
                tractivities.Attributes["class"] = "accordion_body_enfr";
                trmalm.Attributes["class"] = "accordion_title_enfr";
                trawsma.Attributes["class"] = "accordion_body_enfr";
                trach.Attributes["class"] = "accordion_title_enfr";
                trachieve.Attributes["class"] = "accordion_body_enfr";
                trsaid.Attributes["class"] = "accordion_title_enfr";
                trwhtwritten.Attributes["class"] = "accordion_body_enfr";
                trn.Attributes["class"] = "accordion_title_enfr";
                trnotes.Attributes["class"] = "accordion_body_enfr";
             }
            //fillcheck_periods();
            fillchar_type();
            View();

            //-------------------------clored the Divs-------------------------------------
            for (int y = 0; y < count_fields; y = y + 2)
            {
                if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                {
                    changeDiv_cssClass(sender, e, arr_divs[y], "accordion_title_enfr2");
                    changeDiv_cssClass(sender, e, arr_divs[y + 1], "accordion_title_enfr");
                }
                else
                {
                    changeDiv_cssClass(sender, e, arr_divs[y], "accordion_title2");
                    changeDiv_cssClass(sender, e, arr_divs[y + 1], "accordion_title");
                }
            }

    }    
    private void fillchar_type()
    {
        char_types_DT obj = new char_types_DT();
        DataTable obj_db = char_types_DB.SelectAll();
        rad_char_type.DataSource = obj_db;
        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" )
            {rad_char_type.DataTextField = "title_en";}
        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            { rad_char_type.DataTextField = "title_fr"; }
        else { rad_char_type.DataTextField = "title_ar"; }
        rad_char_type.DataValueField = "id";
        rad_char_type.DataBind();

    }
    private void fillcheck_periods()
    {
        periods_DT obj = new periods_DT();
        DataTable per_dt = periods_DB.SelectAll();
       // chk_periods.DataSource = per_dt;
       // chk_periods.DataBind();
        //chk_periods.DataValueField = "id";
        // chk_periods.DataTextField = "title";

    }
    public void View()
    {
        int j = 0;
        characters_DT obj = new characters_DT();
        characters_details_DT obj_dt = new characters_details_DT();
        obj = characters_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value));
        obj_dt = characters_details_DB.SelectBychar_ID(CDataConverter.ConvertToInt(HiddenID.Value), menus_update.get_current_lang());
        if (obj != null)
        {
            if (obj.form_status != 12)
                Response.Redirect("~/sheikhs/Default.aspx");
            else if ((Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2") && obj.form_status_en != 12)
            {
                Response.Redirect("~/sheikhs/Default.aspx");
            }
            else if ((Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3") && obj.form_status_fr != 12)
            {
                Response.Redirect("~/sheikhs/Default.aspx");
            }
        }
        //---------------------------------------------------no 1------------------------------------------------------------

        if ((obj_dt.birth_date == null || obj_dt.birth_date == "") &&
         (obj_dt.hbirth_date == null || obj_dt.hbirth_date == ""))
        { trhbirthdate.Visible = false; }
        else
        {
            txt_birth_date.Text = obj_dt.birth_date;
            txt_hbirth_date.Text = obj_dt.hbirth_date;
            count_fields = count_fields + 1;
            arr_divs[j] = "trhbirthdate";
            j = j + 1;
        }
        //---------------------------------------------------no 2-----------------------------------------------------------

        if ((obj_dt.death_date == null || obj_dt.death_date == "") &&
         (obj_dt.hdeath_date == null || obj_dt.hdeath_date == ""))
        { trhdeathdate.Visible = false; }
        else
        {
            txt_death_date.Text = obj_dt.death_date;
            txt_hdeath_date.Text = obj_dt.hdeath_date;
            count_fields = count_fields + 1;
            arr_divs[j] = "trhdeathdate";
            j = j + 1;
        }



        //---------------------------------------------------no 3------------------------------------------------------------
        if (obj.char_type > 0)
        {
            string id = obj.char_type.ToString();
            rad_char_type.Items.FindByValue(id).Selected = true;
            lbl_char_type.Text = rad_char_type.SelectedItem.Text;

            count_fields = count_fields + 1;
            arr_divs[j] = "trchartype";
            j = j + 1;
        }
        else
        {
            trchartype.Visible = false;
        }


        //if (obj.period_id_multi != null && obj.period_id_multi != "")
        //{
        //    String[] temp = obj.period_id_multi.ToString().Split(',');
        //    if (temp.Length > 0)
        //    {
        //        for (int j = 0; j < temp.Length; j++)
        //        {
        //            for (int i = 0; i < chk_periods.Items.Count; i++)
        //            {

        //                if (temp[j] == chk_periods.Items[i].Value)
        //                {
        //                    if (j > 0)
        //                    {
        //                        chk_periods.Items[i].Selected = true;
        //                        lbl_chk_periods.Text += ", " + chk_periods.Items[i].Text;
        //                    }
        //                    else
        //                    {
        //                        chk_periods.Items[i].Selected = true;
        //                        lbl_chk_periods.Text += chk_periods.Items[i].Text;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        if (obj.image_name != "")
        {
           
            lcImage.ImageUrl = "../images/sheikhs/" + obj.image_name;
            if (lcImage.Width.Value > 227)
            { 
                lcImage.Width = 227;
            }
            if (lcImage.Height.Value > 169)
            {
                lcImage.Width = 169;
            }

        }
        else lcImage.ImageUrl = "../img/azhar-char.gif";
        Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
        HtmlGenericControl rlabel = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("relatspan");
        HtmlGenericControl divtext = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("relatspan");
        HtmlGenericControl divimg = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("relatspan");
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
        txt_name.Text = obj_dt.name;

        //---------------------------------------------------no 4------------------------------------------------------------

        if (obj_dt.other_names != null && obj_dt.other_names != "")
        {
            txt_other_name.Text = obj_dt.other_names;
            count_fields = count_fields + 1;
            arr_divs[j] = "trshohra";
            j = j + 1;
        }
        else
        {
           // trothername.Visible =
            trshohra.Visible = false;
        }
        //---------------------------------------------------no 5------------------------------------------------------------

        if (obj_dt.titles != null && obj_dt.titles != "")
        {
            txt_titles.Text = obj_dt.titles;
            count_fields = count_fields + 1;
            arr_divs[j] = "tral2ab";
            j = j + 1;
        }
        else
        {
            trtitles.Visible = tral2ab.Visible = false;
        }

        //---------------------------------------------------no 6------------------------------------------------------------

        if (obj_dt.char_details != null && obj_dt.char_details != "")
        {
            txt_char_details.Text = obj_dt.char_details;
            count_fields = count_fields + 1;
            arr_divs[j] = "trnabtha";
            j = j + 1;
        }
        else
        {
            trdetails.Visible = trnabtha.Visible = false;
        }

        //---------------------------------------------------no 7------------------------------------------------------------

        if (obj_dt.birth_details != null && obj_dt.birth_details != "")
        {
            txt_birth_details.Text = obj_dt.birth_details;
            count_fields = count_fields + 1;
            arr_divs[j] = "trnash2a";
            j = j + 1;
        }
        else
        {
            trbdetails.Visible = trnash2a.Visible = false;
        }
        //---------------------------------------------------no 8------------------------------------------------------------

        if (obj_dt.scientific_life != null && obj_dt.scientific_life != "")
        {
            txt_scientific_life.Text = obj_dt.scientific_life;
            count_fields = count_fields + 1;
            arr_divs[j] = "trsci";
            j = j + 1;
        }
        else
        {
            trscientific.Visible = trsci.Visible = false;
        }
        //---------------------------------------------------no 9------------------------------------------------------------

        if (obj_dt.working_life != null && obj_dt.working_life != "")
        {
            txt_working_life.Text = obj_dt.working_life;
            count_fields = count_fields + 1;
            arr_divs[j] = "trworkin";
            j = j + 1;
        }
        else
        { trworklife.Visible = trworkin.Visible = false; }

        //---------------------------------------------------no 10------------------------------------------------------------

        if (obj_dt.activities != null && obj_dt.activities != "")
        {
            txt_activities.Text = obj_dt.activities;

            count_fields = count_fields + 1;
            arr_divs[j] = "tracti";
            j = j + 1;
        }

        else
        {
            tractivities.Visible = tracti.Visible = false;
        }

        //---------------------------------------------------no 11------------------------------------------------------------

        DataTable wesams = awsema_details_DB.select_bychar_id(CDataConverter.ConvertToInt(HiddenID.Value));
        if (wesams.Rows.Count > 0)
        {
            txt_awesma.Text = wesams.Rows[0]["details"].ToString();
            count_fields = count_fields + 1;
            arr_divs[j] = "trmalm";
            j = j + 1;
        }
        else
        {
            trawsma.Visible = trmalm.Visible = false;
        }


        //---------------------------------------------------no 12------------------------------------------------------------

        achievements_details_DT achvd_dt = achievements_details_DB.SelectBy_CharID(CDataConverter.ConvertToInt(HiddenID.Value), menus_update.get_current_lang());

        if (achvd_dt.id != 0)
        {
            txt_achiev.Text = achvd_dt.details;
            count_fields = count_fields + 1;
            arr_divs[j] = "trach";
            j = j + 1;
        }
        else
        {
            trachieve.Visible = trach.Visible = false;
        }
        //---------------------------------------------------no 13------------------------------------------------------------

        if (obj_dt.written_about != null && obj_dt.written_about != "")
        {
            txt_written_about.Text = obj_dt.written_about;
            count_fields = count_fields + 1;
            arr_divs[j] = "trsaid";
            j = j + 1;
        }
        else
        {
            trwhtwritten.Visible = trsaid.Visible = false;
        }

        //---------------------------------------------------no 14------------------------------------------------------------

        if (obj_dt.notes != null && obj_dt.notes != "")
        {
            txt_notes.Text = obj_dt.notes;
            count_fields = count_fields + 1;
            arr_divs[j] = "trn";
            j = j + 1;
        }
        else
        {
            trnotes.Visible = trn.Visible = false;
        }
       
         
    }
    public void changeDiv_cssClass(object sender, EventArgs e, String DivName, String ClassName)
    {
        // Find the div control as htmlgenericcontrol type, if found apply style
        if (DivName != null)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("ContentPlaceHolder2").FindControl(DivName);

            if (div != null)
            {
                div.Attributes.Remove("class");
                div.Attributes.Add("class", ClassName);
            }
        }

    }
    //protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        int type = (int)Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "moalaf_type"));
    //        Label lab = (Label)e.Row.FindControl("moalaf_type");
    //        if (type == 1)
    //        {
    //            lab.Text = "مؤلف";
    //        }
    //        if (type == 2)
    //        { lab.Text = "مؤلف عنه"; }


    //    }
    //}
    //protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        int type = (int)Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "content_type2"));
    //        Label lab = (Label)e.Row.FindControl("type");

    //        if (type == 6)
    //        {
    //            lab.Text = "تسجيل تليفزيوني";
    //        }
    //        if (type == 7)
    //        {
    //            lab.Text = "تسجيل إذاعي";
    //        }

    //        if (type == 8)
    //        {
    //            lab.Text = "الوثائق";
    //        }
    //        if (type == 9)
    //        { lab.Text = " المقالات"; }
    //        if (type == 10)
    //        { lab.Text = " الكتب"; }
    //        if (type == 11)
    //        { lab.Text = "الصور"; }
    //        if (type == 12)
    //        { lab.Text = " المخطوطات"; }
    //        if (type == 13)
    //        { lab.Text = " أطروحة"; }
    //        if (type == 14)
    //        { lab.Text = " بحث في مؤتمر"; }
    //        if (type == 15)
    //        { lab.Text = "موقع إلكترونى"; }
    //        if (type == 16)
    //        { lab.Text = "المصطلحات"; }
    //    }
    //}
}
