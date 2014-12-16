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

public partial class Esdarat_artifactsDetails2 : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[20];
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        {
            trname.Attributes["class"] = "accordion_title_enfr";
            Div1.Attributes["class"] = "accordion_title_enfr";
            Div2.Attributes["class"] = "accordion_body_enfr";
            Tdb_desc.Attributes["class"] = "accordion_title_enfr";
            Tdbrief_desc.Attributes["class"] = "accordion_body_empty";
            Tddetails_desc.Attributes["class"] = "accordion_title_enfr";
            Tddetails_desc2.Attributes["class"] = "accordion_body_empty";
            TDname_maker.Attributes["class"] = "accordion_title_enfr";
            TDtxt_maker.Attributes["class"] = "accordion_body_empty";
            TDtrtype.Attributes["class"] = "accordion_title_enfr";
            TDdrop_style.Attributes["class"] = "accordion_title_enfr";
            TDtrcolor.Attributes["class"] = "accordion_title_enfr";
            TDdrop_color.Attributes["class"] = "accordion_title_enfr";
            TDtrtechinque.Attributes["class"] = "accordion_title_enfr";
            TDdrop_techinque.Attributes["class"] = "accordion_title_enfr";
            TDtrraw.Attributes["class"] = "accordion_title_enfr";
            TDdrop_raw.Attributes["class"] = "accordion_title_enfr";
            TDtrdimension.Attributes["class"] = "accordion_title_enfr";
            Dimension.Attributes["class"] = "accordion_body_enfr";
            TDtrdimater.Attributes["class"] = "accordion_title_enfr";
            trdimater.Attributes["class"] = "accordion_title_enfr";
            TDtrorg.Attributes["class"] = "accordion_title_enfr";
            trorg.Attributes["class"] = "accordion_body_enfr";
            Tdtrnotes.Attributes["class"] = "accordion_title_enfr";
            trnotes.Attributes["class"] = "accordion_body_enfr";
            TDtrtags.Attributes["class"] = "accordion_title_enfr";
            trtags.Attributes["class"] = ".accordion_body_enfr";
            TDtrperiods.Attributes["class"] = "accordion_title_enfr";
            trperiods.Attributes["class"] = "accordion_body_enfr";


        }

        if (!IsPostBack)
        {
            int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
            HiddenID.Value = id.ToString();
            if (id != 0)
            {
                Session["content_id"] = id.ToString();
                Session["content_type"] = "5";
                fillcheck_periods();
                filldrop_raw();
                fillstyle();
                fillcolor();
                filltech();
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
        chk_periods.DataSource = per_dt;
        chk_periods.DataBind();
    }
    private void filldrop_raw()
    {
        raw_material_DT obj_dt = new raw_material_DT();
        DataTable dt = raw_material_DB.SelectAll();
        drop_raw_ddl.DataSource = dt;
        drop_raw_ddl.DataBind();
        ListItem litem = new ListItem("-- اختر مادة الصنع--", "0");
        drop_raw_ddl.Items.Insert(0, litem);
    }
    private void fillstyle()
    {
        styles_DT obj_dt = new styles_DT();
        DataTable dt = styles_DB.SelectByContent_Type(5);
        drop_style_ddl.DataSource = dt;
        drop_style_ddl.DataBind();
        ListItem litem = new ListItem("-- اختر نوع القطعة --", "0");
        drop_style_ddl.Items.Insert(0, litem);
    }
    private void fillcolor()
    {
        DataTable style_dt = colors_DB.SelectAll();
        drop_color_ddl.DataSource = style_dt;
        drop_color_ddl.DataBind();
        ListItem litem = new ListItem("-- اختر لون القطعة  --", "0");
        drop_color_ddl.Items.Insert(0, litem);
    }
    private void filltech()
    {
        DataTable style_dt = techniques_DB.SelectAll();
        drop_techinque_ddl.DataSource = style_dt;
        drop_techinque_ddl.DataBind();
        ListItem litem = new ListItem("-- اختر الأسلوب الفني  --", "0");
        drop_techinque_ddl.Items.Insert(0, litem);
    }
    public void View()
    {
        int p = 0;

        artifacts_DT obj = new artifacts_DT();
        artifacts_details_DT obj_details = new artifacts_details_DT();
        obj = artifacts_DB.SelectByID(Convert.ToInt16(HiddenID.Value));
        obj_details = artifacts_details_DB.SelectByID(Convert.ToInt16(HiddenID.Value));
        if (obj != null)
        {
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                if (obj.form_status != 12)
                    Response.Redirect("~/Esdarat/listArtifacts.aspx");
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                if (obj.form_status_en != 12)
                    Response.Redirect("~/Esdarat/listArtifacts.aspx");
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                if (obj.form_status_fr != 12)
                    Response.Redirect("~/Esdarat/listArtifacts.aspx");
            }
        }

        //------------------------------------------------------------------------------------------------------

        HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
        pdf_continer.Visible = false;
        //HtmlGenericControl div_related = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_related");
        //div_related.Visible = true;

        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        lcImage.Visible = true;

        HtmlGenericControl div_show = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_show");
        div_show.Visible = true;

        Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
        // lclabel.Text = "القطعه المتحفيه";



        //------------------------------------------------------------------- no 1 ---------------------------------------------------------------


        if (obj_details.maker_name == null || obj_details.maker_name == "")
        { TDname_maker.Visible = TDtxt_maker.Visible = false; }
        else
        {
            txt_maker.Text = obj_details.maker_name;
            count_fields = count_fields + 1;
            arr_divs[p] = "TDname_maker";
            p = p + 1;
        }
        //------------------------------------------------------------------- no 2 ---------------------------------------------------------------

        if (obj.style_id != 0)
        {
            string id = obj.style_id.ToString();
            drop_style_ddl.Items.FindByValue(id).Selected = true;
            drop_style.Text = drop_style_ddl.SelectedItem.Text;
            count_fields = count_fields + 1;
            arr_divs[p] = "TDtrtype";
            p = p + 1;
        }
        else
        {
            TDtrtype.Visible = TDdrop_style.Visible = false;
        }
        //------------------------------------------------------------------- no 3 ---------------------------------------------------------------

        if (obj.color_id != 0)
        {
            string id = obj.color_id.ToString();
            drop_color_ddl.Items.FindByValue(id).Selected = true;
            drop_color.Text = drop_color_ddl.SelectedItem.Text;
            count_fields = count_fields + 1;
            arr_divs[p] = "TDtrcolor";
            p = p + 1;
        }
        else
        {
            TDtrcolor.Visible = TDdrop_color.Visible = false;
        }
        //------------------------------------------------------------------- no 4 ---------------------------------------------------------------

        if (obj.technique_id != 0)
        {
            string id = obj.technique_id.ToString();
            drop_techinque_ddl.Items.FindByValue(id).Selected = true;
            drop_techinque.Text = drop_techinque_ddl.SelectedItem.Text;

            count_fields = count_fields + 1;
            arr_divs[p] = "TDtrtechinque";
            p = p + 1;
        }
        else { TDtrtechinque.Visible = TDdrop_techinque.Visible = false; }

        Labtitle.Text = obj_details.title;
       
       

        //------------------------------------------------------------------- no 5 ---------------------------------------------------------------

        if (obj.material_id != 0)
        {
            string id = obj.material_id.ToString();
            drop_raw_ddl.Items.FindByValue(id).Selected = true;
            drop_raw.Text = drop_raw_ddl.SelectedItem.Text;
            count_fields = count_fields + 1;
            arr_divs[p] = "TDtrraw";
            p = p + 1;
        }
        else
        {
            TDtrraw.Visible = TDdrop_raw.Visible = false;
        }
       //------------------------------------------------------------------- no 6 ---------------------------------------------------------------

        if ((obj.weight == null || obj.weight == "") && (obj.width == null || obj.width == "")
             && (obj.length == null || obj.length == "") && (obj.diameter == null || obj.diameter == "")
            && (obj.perimeter == null || obj.perimeter == "") && (obj.height == null || obj.height == ""))
        { TDtrdimension.Visible = Dimension.Visible = false; }
        else
        {

            count_fields = count_fields + 1;
            arr_divs[p] = "TDtrdimension";
            p = p + 1;
            if (obj.weight == null || obj.weight == "0")
            {
                Label41.Visible = txt_wight.Visible = false;
            }
            else
            {
 
                txt_wight.Text = obj.weight;
            }
            if (obj.width == null || obj.width == "0")
            {
                Label37.Visible = txt_width.Visible = false;
            }
            else
            {
                txt_width.Text = obj.width;
            }
            if (obj.length == null || obj.length == "0")
            {
                Label36.Visible = txt_length.Visible = false;
            }
            else
            {
                txt_length.Text = obj.length;
            }
            if (obj.diameter == null || obj.diameter == "0")
            {
                Label39.Visible = txt_dimater.Visible = false;
            }
            else
            {
                txt_dimater.Text = obj.diameter;
            }
            if (obj.perimeter == null || obj.perimeter == "0")
            {
                Label40.Visible = txt_perimeter.Visible = false;
            }
            else
            {
                txt_perimeter.Text = obj.perimeter;
            }
            if (obj.height == null || obj.height == "0")
            {
                Label38.Visible = txt_height.Visible = false;
            }
            else
            {
                txt_height.Text = obj.height;
            }
        }

        //------------------------------------------------------------------- no 7 ---------------------------------------------------------------

        if (obj.small_image != "")
        {

            lcImage.Attributes.CssStyle.Add("height", "300");
            lcImage.ImageUrl = "~/images/esdarat/" + obj.small_image.ToString();

            //lcImage.ImageUrl = "~/upload/forms/" + obj.large_image.ToString();
        }
        else
        {
            lcImage.Attributes.CssStyle.Add("height", "300");
            //lcImage.Height = 50 ;
            //lcImage.Width = 40;
            lcImage.ImageUrl = "../img/Icon%208.jpg";
        }
        if (obj.large_image != "")
        {
            Div2.Visible = Div1.Visible = true;
            string flash_name = "";
            string[] strArray = obj.large_image.ToString().Split('.');
            flashdiv.InnerHtml = "";
            flashdiv.InnerHtml =
    "<script language='JavaScript' type='text/javascript'>" +
    "	AC_FL_RunContent(" +
    "		'codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=10,0,0,0'," +
    "		'width', '400'," +
    "		'height', '100%'," +
    "		'src', ''," +
    "		'quality', 'high'," +
    "		'pluginspage', 'http://www.adobe.com/go/getflashplayer'," +
    "		'align', 'middle'," +
    "		'play', 'true'," +
    "		'loop', 'true'," +
    "		'scale', 'showall'," +
    "		'wmode', 'window'," +
    "		'devicefont', 'false'," +
    "		'id', '" + strArray[0] + "'," +
    "		'bgcolor', '#ffffff'," +
    "		'name', '" + strArray[0] + "'," +
    "		'menu', 'true'," +
    "		'allowFullScreen', 'false'," +
    "		'allowScriptAccess','sameDomain'," +
    "		'movie', '../images/esdarat/" + strArray[0] + "'," +
    "		'salign', ''" +
    "		); " +
    "</script>" +
    "<noscript>" +
    "	<object classid='clsid:d27cdb6e-ae6d-11cf-96b8-444553540000' codebase='http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=10,0,0,0' id='swf' align='middle'>" +
    "	<param name='allowScriptAccess' value='sameDomain' />" +
    "	<param name='allowFullScreen' value='false' />" +
    "	<param name='movie' value='" + flash_name + "' /><param name='quality' value='high' /><param name='bgcolor' value='#ffffff' />	<embed src='" + flash_name + "' quality='high' bgcolor='#ffffff' width='550' height='400' name='swf' align='middle' allowScriptAccess='sameDomain' allowFullScreen='false' type='application/x-shockwave-flash' pluginspage='http://www.adobe.com/go/getflashplayer' />" +
    "	</object>" +
    "</noscript>";

            //src_flash.Attributes["src"] = v; rezk
            //src_flash.Attributes.Add("value",v);

            count_fields = count_fields + 1;
            arr_divs[p] = "Div1";
            p = p + 1;

        }
        else
        {
            Div2.Visible = Div1.Visible = false;


        }
        //object objectswf = (object)FindControl("swffile"); 

        //if (obj.large_image != "")
        //{
        //    objectswf = obj.large_image;
        //    //this.frame_url.Attributes["src"] = media_details_obj_to_veiw.content_url;
        //    //frame_url.Attributes.Add("src", media_details_obj_to_veiw.content_url);

        //}



        //------------------------------------------------------------------- no 8 ---------------------------------------------------------------

        if (obj_details.artifact_brief == "" || obj_details.artifact_brief == null)
        { Tdb_desc.Visible = Tdbrief_desc.Visible = false; }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[p] = "Tdb_desc";
            p = p + 1;
            brief_desc.Text = obj_details.artifact_brief;
        }
        //------------------------------------------------------------------- no 9 ---------------------------------------------------------------

        if (obj_details.artifact_details == "" || obj_details.artifact_details == null)
        { Tddetails_desc.Visible = Tddetails_desc2.Visible = false; }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[p] = "Tddetails_desc";
            p = p + 1;
            details_desc.Text = obj_details.artifact_details;
        }

        //------------------------------------------------------------------- no 10 ---------------------------------------------------------------

        if (obj_details.start_date == "" || obj_details.start_date == null)
        { Label19.Visible = txt_date.Visible = false; }
        else
        {
            txt_date.Text = obj_details.start_date;

        }
        if (obj_details.end_date == "" || obj_details.end_date == null)
        {
            Label18.Visible = txt_hdate.Visible = false;
        }
        else
        {
            txt_hdate.Text = obj_details.end_date;
        }


        if ((obj_details.start_date == "" || obj_details.start_date == null) && (obj_details.end_date == "" || obj_details.end_date == null))
        { TDtrdimater.Visible = trdimater.Visible = false; }

        else
        {
            TDtrdimater.Visible = true;
            count_fields = count_fields + 1;
            arr_divs[p] = "TDtrdimater";
            p = p + 1;
        }

        //------------------------------------------------------------------- no 11 ---------------------------------------------------------------

        if ((obj.city == null || obj.city == "") && (obj.country == null || obj.country == "") && (obj.save_no.ToString() == null || obj.save_no.ToString() == "0") &&
            (obj.source_name == null || obj.source_name == "") && (obj.source_notes == null || obj.source_notes == ""))
        { TDtrorg.Visible = trorg.Visible = false; }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[p] = "TDtrorg";
            p = p + 1;
            if (obj.city == null || obj.city == "")
            { Label23.Visible = false; }
            else
            {
                txt_city.Text = obj.city;
            }
            if (obj.country == null || obj.country == "")
            { Label22.Visible = false; }
            else
            {
                txt_country.Text = obj.country;
            }
            txt_save_no.Text = obj.save_no.ToString();
            if (obj.source_name == null || obj.source_name == "")
            {
                Label21.Visible = txt_org.Visible = false;
            }
            else
            {
                txt_org.Text = obj.source_name;

            }
            if (obj.source_notes == null || obj.source_notes == "")
            {
                Label25.Visible = txt_org_notes.Visible = false;
            }
            else
            {
                txt_org_notes.Text = obj.source_notes;
            }

        }

        //------------------------------------------------------------------- no 12 ---------------------------------------------------------------

        if (obj_details.notes == "" || obj_details.notes == null)
        { Tdtrnotes.Visible = trnotes.Visible = false; }
        else
        {
            txt_notes.Text = obj_details.notes;
            count_fields = count_fields + 1;
            arr_divs[p] = "Tdtrnotes";
            p = p + 1;
        }

        //------------------------------------------------------------------- no 13 ---------------------------------------------------------------

        if (obj_details.keywords == "" || obj_details.keywords == null)
        { TDtrtags.Visible = trtags.Visible = false; }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[p] = "TDtrtags";
            p = p + 1;
            txt_tags.Text = obj_details.keywords; 
        }


        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
        {
            lclabel.Text = "القطعه المتحفيه";

        }
        else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
        {
            lclabel.Text = "Artifacts";


        }
        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        {
            lclabel.Text = "Artefacts";


        }

        //------------------------------------------------------------------- no 14 ---------------------------------------------------------------
        if (obj.period_id_multi != null && obj.period_id_multi != "")
        {
            String[] temp = obj.period_id_multi.ToString().Split(',');
            if (temp.Length > 0)
            {
                for (int j = 0; j < temp.Length; j++)
                {
                    for (int i = 0; i < chk_periods.Items.Count; i++)
                    {

                        if (temp[j] == chk_periods.Items[i].Value)
                        {
                            if (j > 0)
                            {
                                chk_periods.Items[i].Selected = true;
                                lbl_chk_periods.Text += ", " + chk_periods.Items[i].Text;
                            }
                            else
                            {
                                chk_periods.Items[i].Selected = true;
                                lbl_chk_periods.Text += chk_periods.Items[i].Text;
                            }
                        }
                    }
                }
            }

            count_fields = count_fields + 1;
            arr_divs[p] = "TDtrperiods";
            p = p + 1;
        }
        else
        {
            TDtrperiods.Visible = trperiods.Visible = false;
        }



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
