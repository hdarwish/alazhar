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

public partial class Esdarat_webSiteDetails : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[12];
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
            HiddenID.Value = id.ToString();
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                tr_title.Attributes["class"] = "accordion_title_enfr";
                //trsitetitle.Attributes["class"] = "accordion_body_enfr";
                tr_lang.Attributes["class"] = "accordion_title_enfr";
                tr_lang2.Attributes["class"] = "accordion_body_enfr";
                Trelectitle.Attributes["class"] = "accordion_title_enfr";
                Trelectitle2.Attributes["class"] = "accordion_body_enfr";
                rerespon.Attributes["class"] = "accordion_title_enfr";
                rerespon2.Attributes["class"] = "accordion_body_enfr";
                trdesc.Attributes["class"] = "accordion_title_enfr";
                trdesc2.Attributes["class"] = "accordion_body_enfr";
                trdate.Attributes["class"] = "accordion_title_enfr";
                trdate2.Attributes["class"] = "accordion_body_enfr";
                trnotes.Attributes["class"] = "accordion_title_enfr";
                trnotes2.Attributes["class"] = "accordion_body_enfr";                
            }            
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
    public void View()
    {
        int j = 0;
         WebSites_Template_DT website_obj= new WebSites_Template_DT();
         WebSites_Template_details_DT website_details_obj= new WebSites_Template_details_DT();

        website_obj = WebSites_Template_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value));
        website_details_obj = WebSites_Template_details_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value), menus_update.get_current_lang());
        if (website_obj != null)
        {            
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                if (website_obj.form_status != 12)
                    Response.Redirect("~/Esdarat/listWebSites.aspx");
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                if (website_obj.form_status_en != 12)
                    Response.Redirect("~/Esdarat/listWebSites.aspx");
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                if (website_obj.form_status_fr != 12)
                    Response.Redirect("~/Esdarat/listWebSites.aspx");
            }
        }
        //---------------------------------------------------------------- no 1----------------------------------------------------------------------------------

        if (website_details_obj.title != null && website_details_obj.title !="")
        {
            Labtitle.Text = website_details_obj.title;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_title";
            j = j + 1;
        }
        else
        {
            tr_title.Visible = false;
            //trsitetitle.Visible = false;
        }
        //------------------------------------------------------------------ no 2 --------------------------------------------------------------------------------

        if (website_obj.site_lang.ToString() != "0" && website_obj.site_lang.ToString() != "")
        {
            if (website_obj.site_lang.ToString() == "1")
            {
                if (menus_update.get_current_lang().ToString() == "1")
                    Lablang.Text = "العربية";
                else if (menus_update.get_current_lang().ToString() == "2")
                    Lablang.Text = "Arabic";
                else if (menus_update.get_current_lang().ToString() == "3")
                    Lablang.Text = "Langue Arabe";
            }

            else if (website_obj.site_lang.ToString() == "2")
            {
                if (menus_update.get_current_lang().ToString() == "2")
                    Lablang.Text = "English";
                else if (menus_update.get_current_lang().ToString() == "1")
                    Lablang.Text = " اللغة الأنجليزية";
                else if (menus_update.get_current_lang().ToString() == "3")
                    Lablang.Text = "Anglais";


            }
            else if (website_obj.site_lang.ToString() == "3")
            {

                if (menus_update.get_current_lang().ToString() == "1")
                    Lablang.Text = "الفرنسية";
                else if (menus_update.get_current_lang().ToString() == "2")
                    Lablang.Text = " french";
                else if (menus_update.get_current_lang().ToString() == "3")
                    Lablang.Text = "French";
            }

            count_fields = count_fields + 1;
            arr_divs[j] = "tr_lang";
            j = j + 1;

        }
        else
        {
            tr_lang2.Visible = tr_lang.Visible = false;
        }
        //----------------------------------------------------------------no 3 ----------------------------------------------------------------------------------


        if (website_obj.url != null && website_obj.url != "")
        {
            Laburl.Text = website_obj.url;
            count_fields = count_fields + 1;
            arr_divs[j] = "Trelectitle";
            j = j + 1;
        }
        else
        {
            Trelectitle.Visible = false;
            Trelectitle2.Visible = false;
        }
        //-------------------------------------------------------------- no 4 ------------------------------------------------------------------------------------

        if (website_details_obj.responsible_name != null && website_details_obj.responsible_name != "")
        {
            Labres.Text = website_details_obj.responsible_name;
            count_fields = count_fields + 1;
            arr_divs[j] = "rerespon";
            j = j + 1;
        }
        else
        {
            rerespon.Visible = false;
            rerespon2.Visible = false;
        }
        //----------------------------------------------- no 5---------------------------------------------------------------------------------------------------

        if (website_details_obj.describtion != null && website_details_obj.describtion != "")
        {
            Labdesc.Text = website_details_obj.describtion;
            count_fields = count_fields + 1;
            arr_divs[j] = "trdesc";
            j = j + 1;
        }
        else
        {
            trdesc.Visible = false;
            trdesc2.Visible = false;
        }
        //---------------------------------------------------------------- no 6----------------------------------------------------------------------------------

        if (website_obj.site_login_date != null && website_obj.site_login_date != "")
        {
            Labdate.Text = website_obj.site_login_date;
            count_fields = count_fields + 1;
            arr_divs[j] = "trdate";
            j = j + 1;
        }
        else
        {
            trdate.Visible = false;
            trdate2.Visible = false;
        }

        //-----------------------------------------------------no 7 ---------------------------------------------------------------------------------------------

        if (website_details_obj.notes != null && website_details_obj.notes != "")
        {
            Labnotes.Text = website_details_obj.notes;
            count_fields = count_fields + 1;
            arr_divs[j] = "trnotes";
            j = j + 1;
        }
        else
        {
            trnotes.Visible = false;
            trnotes2.Visible = false;
        }


      
        //--------------------------------------------------------------------------------------------------------------------------------------------------




        HtmlGenericControl div_related = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_related");
        div_related.Visible = false;
        HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
        pdf_continer.Visible = false;

        

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
