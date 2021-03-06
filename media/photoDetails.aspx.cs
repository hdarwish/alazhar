﻿using System;
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

public partial class Esdarat_photoDetails : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Convert.ToInt16(Request.QueryString["id"]);
            HiddenID.Value = id.ToString();
            if (id != 0)
            {
                Session["content_id"] = Request["id"];
                Session["content_type"] = "11";
                fillcheck_periods();
                View();
            }
        }
    }
    private void fillcheck_periods()
    {
        periods_DT obj = new periods_DT();
        DataTable per_dt = periods_DB.SelectAll();
        chk_periods.DataSource = per_dt;
        chk_periods.DataBind();
        RblMediaType.DataSource = content_images_types_DB.SelectAll();
        RblMediaType.DataBind();
      

    }
    public void View()
    {
        //SqlParameter[] sqlparams = new SqlParameter[]
        //{
        //   new SqlParameter("@lang_id",Convert.ToInt16(1)),
        //   new SqlParameter("@doc_ID",Convert.ToInt16 (HiddenID.Value))           
        //};
        //DataTable dt = new DataTable();
        //dt = DatabaseFunctions.SelectData(sqlparams, "documents_docdetails_select");
        content_images_DT content_images_obj_to_veiw = new content_images_DT();
        content_images_details_DT content_images_details_obj_to_veiw = new content_images_details_DT();
        content_images_obj_to_veiw = content_images_DB.SelectByID(Convert.ToInt16(HiddenID.Value));
        content_images_details_obj_to_veiw = content_images_details_DB.SelectByID(Convert.ToInt16(HiddenID.Value), menus_update.get_current_lang());

        if (content_images_obj_to_veiw != null)
        {
            if (content_images_obj_to_veiw.form_status != 12)
                Response.Redirect("~/media/listPhotos.aspx");
        }
        if ( content_images_obj_to_veiw.period_id != 0)
        {
            String[] temp = content_images_obj_to_veiw.period_id.ToString().Split(',');
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
        }
        else
        { tr1.Visible = trperiods.Visible = false; }
        //if (manuscripts_obj_to_veiw.form_file != "")
        //{
        //    //RequiredFieldValidator4.ValidationGroup = "files";
        //    link_pdf1.HRef = "~/images/manuscripts/" + manuscripts_obj_to_veiw.form_file;
        //}
        //else
        //    link_pdf1.Visible = false;
        Labtitle.Text = content_images_details_obj_to_veiw.title;
        // title_src.SelectedValue = manuscripts_details_obj_to_save.title_src;
        //author.Text = manuscripts_details_obj_to_save.author;
        if (content_images_details_obj_to_veiw.describtion != null && content_images_details_obj_to_veiw.describtion != "")
        { txtDesc.Text = content_images_details_obj_to_veiw.describtion; }
        else
        {
            trtitfromintro.Visible = tr_title2.Visible = false;
        }
        if (content_images_details_obj_to_veiw.category != null && content_images_details_obj_to_veiw.category != "")
        {                          
            RblMediaType.Items[CDataConverter.ConvertToInt(content_images_details_obj_to_veiw.category.ToString())-1].Selected = true;
            lbl_RblMediaType.Text =  RblMediaType.SelectedItem.Text ;                                                
        }
        else
        {
            tr_title.Visible = trtitfromtit.Visible = false;
        }

        if (content_images_details_obj_to_veiw.photographer != null && content_images_details_obj_to_veiw.photographer != "")
        { txtCommenterName.Text = content_images_details_obj_to_veiw.photographer; }
        else 
        {
            trauthfromtit.Visible = Tr5.Visible = false;
        }
        //txt_title_mosk.Text= manuscripts_details_obj_to_save.title_mosk ;
        //manuscripts_details_obj_to_save.author = author.Text;
        if ((content_images_obj_to_veiw.record_date_georgian != null && content_images_obj_to_veiw.record_date_georgian != "")
            || (content_images_obj_to_veiw.record_date_hijri != null && content_images_obj_to_veiw.record_date_hijri != ""))
        { txtGorgDate.Text = content_images_obj_to_veiw.record_date_georgian;
        txtHijriDate.Text = content_images_obj_to_veiw.record_date_hijri;
        }
        else { trauthfromintro.Visible = Tr2.Visible = false; }

        if (content_images_details_obj_to_veiw.resource_name != null && content_images_details_obj_to_veiw.resource_name != "")
        { txtresourceName.Text = content_images_details_obj_to_veiw.resource_name; }
        else
        {
            trlang.Visible = tr6.Visible = false;
        }
        //txt_author_moska.Text = manuscripts_details_obj_to_veiw.author_mosk;
        if (content_images_details_obj_to_veiw.notes != null && content_images_details_obj_to_veiw.notes != "")
            txtNotes.Text = content_images_details_obj_to_veiw.notes;
        else
            trplace.Visible = tr_place.Visible = false;
        HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
        pdf_continer.Visible = false;        
        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        if (content_images_obj_to_veiw.large_image != "")
        {
            lcImage.ImageUrl = "../images/uploaded_images/" + content_images_obj_to_veiw.large_image;
        }
        else lcImage.ImageUrl = "../images/no img av.bmp";       
        Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
        lclabel.Text = "الصورة";                           
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     