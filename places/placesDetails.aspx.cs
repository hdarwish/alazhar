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

public partial class places_placesDetails : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[12];
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
        Session["content_id"] = id.ToString();
        Session["content_type"] = "4";
        //Session["referred"] = "true";
        hrefdetails.HRef = "placesMoreDetails.aspx?id=" + id.ToString();
       
        HiddenID.Value = id.ToString();
        if (id > 0)
        {
            hits_count obj = new hits_count();
            obj.hit_count_save(id, 4);
        }

        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        {
            Tr5.Attributes["class"] = "accordion_title_enfr";
            Tr4.Attributes["class"] = "accordion_title_enfr";
            trbrief.Attributes["class"] = "accordion_body_enfr";
            tr_title.Attributes["class"] = "accordion_title_enfr";
            trtdesc.Attributes["class"] = "accordion_body_enfr";
            tr6.Attributes["class"] = "accordion_title_enfr";
            trmaker.Attributes["class"] = "accordion_body_enfr";
            tr7.Attributes["class"] = "accordion_title_enfr";
            trtype.Attributes["class"] = "accordion_body_enfr";
           
        }

        fillDDLsRBts();
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
    public void fillDDLsRBts()
    {
        DataTable DT1 = General_Helping.GetDataTable("select id,title_ar from places_types");
        rbl_place_type.DataSource = DT1;
        rbl_place_type.DataTextField = "title_ar";
        rbl_place_type.DataValueField = "id";
        rbl_place_type.DataBind();
    }
    public void View()
    {
        int j = 0;

        places_DT obj = new places_DT();
        places_details_DT obj_dt = new places_details_DT();
        obj = places_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value));
        obj_dt = places_details_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value), menus_update.get_current_lang());
        if (obj != null)
        {
            if (obj.form_status != 12)
                Response.Redirect("~/places/Default.aspx");
        }

        //imgMoreDetails.HRef = "~/places/placesMoreDetails.aspx?id=" + CDataConverter.ConvertToInt(HiddenID.Value);

        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        if (obj.image_name != "")
        {

            lcImage.ImageUrl = "../upload/forms/" + obj.image_name;
            lcImage.Style.Add("width", "227px"); lcImage.Style.Add("hight", "169px");
        }
        else lcImage.ImageUrl = "../img/place.jpg";

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

        Labtitle.Text = obj_dt.name;



        if (obj_dt.brief != null && obj_dt.brief != "")
        {
            txt_brief.Text = obj_dt.brief.ToString();
            count_fields = count_fields + 1;
            arr_divs[j] = "Tr4";
            j = j + 1;
        }
        else
        {
            Tr4.Visible = trbrief.Visible = false;
        }
        if (obj.place_type != null && obj.place_type != 0)
        {
            if (obj.place_type > 0)
            {
                string id = obj.place_type.ToString();
                rbl_place_type.Items.FindByValue(id).Selected = true;
            }
            lbl_place_type.Text = rbl_place_type.SelectedItem.Text;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_title";
            j = j + 1;
        }
        else
        {
            tr_title.Visible = trtdesc.Visible = false;
        }


        if ((obj.creation_georg_date == null || obj.creation_georg_date == "") &&
           (obj.creation_hijr_date == null || obj.creation_hijr_date == ""))
        { tr6.Visible = trmaker.Visible = false; }
        else
        {
            txt_creation_georg_date.Text = obj.creation_georg_date;
            txt_creation_hijr_date.Text = obj.creation_hijr_date;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr6";
            j = j + 1;
        }


        if ((obj.end_creation_georg_date == null || obj.end_creation_georg_date == "") &&
                  (obj.end_creation_hijr_date == null || obj.end_creation_hijr_date == ""))
        { tr7.Visible = trtype.Visible = false; }
        else
        {
            txt_end_creation_georg_date.Text = obj.end_creation_georg_date;
            txt_end_creation_hijr_date.Text = obj.end_creation_hijr_date;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr7";
            j = j + 1;
        }



    }
    public void changeDiv_cssClass(object sender, EventArgs e, String DivName, String ClassName)
    {
        // Find the div control as htmlgenericcontrol type, if found apply style
        if (DivName != null)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = Master.FindControl("ContentPlaceHolder2").FindControl(DivName) as System.Web.UI.HtmlControls.HtmlGenericControl;

            if (div != null)
            {
                // div.Attributes.Remove("class");
                div.Attributes.Add("class", ClassName);
            }
        }

    }
     
}
