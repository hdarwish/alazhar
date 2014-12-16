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

public partial class administration_lookup_grd_veiw : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fill_grid();
        }
    }
    protected void grdveiw1_onpreRender(object sender, EventArgs e)
    {
        string code_name = Request.QueryString["id"];

        if (GridView1.Rows.Count > 1)
        {
            for (int rowIndex = 0; rowIndex < GridView1.Rows.Count ; rowIndex++)
            {
                GridViewRow row = GridView1.Rows[rowIndex];
                LinkButton lbtn = (LinkButton)row.FindControl("lbtnEdit");
                lbtn.PostBackUrl += "&id=" + code_name;
                
            }
        }
     

        
       
    }


    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fill_grid();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        string code_name = Request.QueryString["id"];
        switch (code_name)
        {
            case "col":
                colors_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "rel":
             relations_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "places_types":
                places_types_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "materials":
                materials_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "styles":
                styles_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "author_type":
                author_type_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "authors_role":
                authors_role_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "techniques":
                techniques_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "raw_material":
                raw_material_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "content_media_type":
                content_media_type_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "content_images_types":
                content_images_types_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "places_styles":
                places_styles_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "architechture_elemnts":
                architechture_elemnts_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "raw_material_use":
                raw_material_use_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "periods":
                periods_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "languages":
                languages_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "copy_status":
                copy_status_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "copy_contains":
                copy_contains_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "copy_has":
                copy_has_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;

            case "license_type":
                license_type_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument));
                break;
        }
        fill_grid();
    
    }
    protected void fill_grid()
    {
        DataTable retunDT = new DataTable();
        string code_name = Request.QueryString["id"];
        if (code_name!="")
            lbtnAdd.PostBackUrl = "~/administration/lookup_add_edit.aspx?table_id=0&id=" + code_name;
                
        switch (code_name)
        {
            case "col":
                lblcodeName.Text = "الألوان";
                retunDT = colors_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "rel":
                lblcodeName.Text = "العلاقات";
                
                retunDT = relations_DB.SelectAll();
                GridView1.Columns[0].Visible = true;
                GridView1.Columns[1].Visible = true;
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                
                string str=GridView1.Columns[0].ToString();
                break;


            case "places_types":
                lblcodeName.Text = "نوع الاثر";
                
                retunDT = places_types_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "materials":
                lblcodeName.Text = "الشكل المادى";
               
                retunDT = materials_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;


            case "styles":
                lblcodeName.Text = "مضمون الوثيقة";

                retunDT = styles_DB.SelectByContent_Type(8);
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "author_type":
                lblcodeName.Text = "نوع / مصدر المؤلف";
               
                retunDT = author_type_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "authors_role":
                lblcodeName.Text = "دور المؤلف";
                
                retunDT = authors_role_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "techniques":
                lblcodeName.Text = "الأسلوب الفنى";
               
                retunDT = techniques_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "raw_material":
                lblcodeName.Text = "مادة الصنع";
               
                retunDT = raw_material_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "content_media_type":
                lblcodeName.Text = "نوع العمل";
               
                retunDT = content_media_type_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "content_images_types":
                lblcodeName.Text = "نوع الصورة";
               
                retunDT = content_images_types_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "places_styles":
                lblcodeName.Text = "الطراز الأساسى للأثر";
               
                retunDT = places_styles_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "architechture_elemnts":
                lblcodeName.Text = "العنصر المعمارى الخاص بهذا الطراز";
                
                retunDT = architechture_elemnts_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "raw_material_use":
                lblcodeName.Text = "موضع استخدام المادة الخام";
               
                retunDT = raw_material_use_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "periods":
                lblcodeName.Text = "العصر";
               
                retunDT = periods_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "languages":
                lblcodeName.Text = "لغة المخطوط";
                
                retunDT = languages_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "copy_status":
                lblcodeName.Text = "حالة النسخ";
                
                retunDT = copy_status_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "copy_contains":
                lblcodeName.Text = "النسخة تحتوى على";
                
                retunDT = copy_contains_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "copy_has":
                lblcodeName.Text = "النسخة بها";
               
                retunDT = copy_has_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;

            case "license_type":
                lblcodeName.Text = "نوع الإجازة";
                
                retunDT = license_type_DB.SelectAll();
                GridView1.DataSource = retunDT;
                GridView1.DataBind();
                break;
        }
    }
   
}
