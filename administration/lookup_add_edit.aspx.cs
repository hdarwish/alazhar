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

public partial class administration_lookup_add_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string code_name = Request.QueryString["id"];
            string table_id = Request.QueryString["table_id"];
            switch (code_name)
            {
                case "col":
                    lblTitle.Text += " - الألوان";
                    if (table_id != "0")
                    {
                        colors_DT color_obj = colors_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                        txtArabicTitle.Text = color_obj.title_ar.ToString();
                        txtEngilshTitle.Text = color_obj.title_en.ToString();
                        txtFrenshTitle.Text = color_obj.title_fr.ToString();
                    }
                break;
                case "rel":
                lblTitle.Text += " - العلاقات";
                ddls.Visible = true;
                fillddls();
                if (table_id != "0")
                {
                   
                    relations_DT Relation_obj = relations_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = Relation_obj.title_ar.ToString();
                    txtEngilshTitle.Text = Relation_obj.title_en.ToString();
                    txtFrenshTitle.Text = Relation_obj.title_fr.ToString();
                    if (Relation_obj.content_type1 < 5)
                    {
                        fillddls();
                        ddlMain.SelectedValue = Relation_obj.content_type1.ToString();
                    ddlsub.SelectedValue = Relation_obj.content_type2.ToString();
                    }
                    else if (Relation_obj.content_type2 < 5 && Relation_obj.content_type1 > 4)
                    {
                        fillddlsReverse();
                        ddlMain.SelectedValue = Relation_obj.content_type1.ToString();
                        ddlsub.SelectedValue = Relation_obj.content_type2.ToString();
                    }

                }
                break;

                case "places_types":
                lblTitle.Text += " - نوع الاثر";
                if (table_id != "0")
                {
                    places_types_DT places_types_obj = places_types_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = places_types_obj.title_ar.ToString();
                    txtEngilshTitle.Text = places_types_obj.title_en.ToString();
                    txtFrenshTitle.Text = places_types_obj.title_fr.ToString();

                }
                break;

                case "materials":
                lblTitle.Text += " - الشكل المادى";
                if (table_id != "0")
                {
                    materials_DT materials_obj = materials_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = materials_obj.title_ar.ToString();
                    txtEngilshTitle.Text = materials_obj.title_en.ToString();
                    txtFrenshTitle.Text = materials_obj.title_fr.ToString();

                }
                break;


                case "styles":                    
                lblTitle.Text += " - مضمون الوثيقة";
                if (table_id != "0")
                {
                    styles_DT styles_obj = styles_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = styles_obj.title_ar.ToString();
                    txtEngilshTitle.Text = styles_obj.title_en.ToString();
                    txtFrenshTitle.Text = styles_obj.title_fr.ToString();

                }
                break;

                case "author_type":
                lblTitle.Text += " - نوع / مصدر المؤلف";
                if (table_id != "0")
                {
                    author_type_DT author_type_obj = author_type_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = author_type_obj.author_type.ToString();
                    txtEngilshTitle.Text = author_type_obj.author_type_en.ToString();
                    txtFrenshTitle.Text = author_type_obj.author_type_fr.ToString();

                }
                break;

                case "authors_role":
                lblTitle.Text += " - دور المؤلف";
                if (table_id != "0")
                {
                    authors_role_DT authors_role_obj = authors_role_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = authors_role_obj.author_role.ToString();
                    txtEngilshTitle.Text = authors_role_obj.author_role_en.ToString();
                    txtFrenshTitle.Text = authors_role_obj.author_role_fr.ToString();

                }
                break;

                case "techniques":
                lblTitle.Text += " - الأسلوب الفنى";
                if (table_id != "0")
                {
                    techniques_DT techniques_obj = techniques_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = techniques_obj.title_ar.ToString();
                    txtEngilshTitle.Text = techniques_obj.title_en.ToString();
                    txtFrenshTitle.Text = techniques_obj.title_fr.ToString();

                }
                break;

                case "raw_material":
                lblTitle.Text += " - مادةالصنع";
                if (table_id != "0")
                {
                    raw_material_DT raw_material_obj = raw_material_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = raw_material_obj.title_ar.ToString();
                    txtEngilshTitle.Text = raw_material_obj.title_en.ToString();
                    txtFrenshTitle.Text = raw_material_obj.title_fr.ToString();

                }
                break;

                case "content_media_type":
                lblTitle.Text += " - نوع العمل";
                if (table_id != "0")
                {
                    content_media_type_DT content_media_type_obj = content_media_type_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = content_media_type_obj.title.ToString();
                    txtEngilshTitle.Text = content_media_type_obj.title_en.ToString();
                    txtFrenshTitle.Text = content_media_type_obj.title_fr.ToString();

                }
                break;

                case "content_images_types":
                lblTitle.Text += " - نوع الصورة";
                if (table_id != "0")
                {
                    content_images_types_DT content_images_types_obj = content_images_types_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = content_images_types_obj.title_ar.ToString();
                    txtEngilshTitle.Text = content_images_types_obj.title_en.ToString();
                    txtFrenshTitle.Text = content_images_types_obj.title_fr.ToString();

                }
                break;

                case "places_styles":
                lblTitle.Text += " - الطراز الأساسى للأثر";
                if (table_id != "0")
                {
                    places_styles_DT places_styles_obj = places_styles_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = places_styles_obj.title_ar.ToString();
                    txtEngilshTitle.Text = places_styles_obj.title_en.ToString();
                    txtFrenshTitle.Text = places_styles_obj.title_fr.ToString();

                }
                break;

                case "architechture_elemnts":
                lblTitle.Text += " - العنصر المعمارى الخاص بهذا الطراز";
                if (table_id != "0")
                {
                    architechture_elemnts_DT architechture_elemnts_obj = architechture_elemnts_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = architechture_elemnts_obj.title_ar.ToString();
                    txtEngilshTitle.Text = architechture_elemnts_obj.title_en.ToString();
                    txtFrenshTitle.Text = architechture_elemnts_obj.title_fr.ToString();

                }
                break;

                case "raw_material_use":
                lblTitle.Text += " - موضع استخدام المادة الخام";
                if (table_id != "0")
                {
                    raw_material_use_DT raw_material_use_obj = raw_material_use_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = raw_material_use_obj.title_ar.ToString();
                    txtEngilshTitle.Text = raw_material_use_obj.title_en.ToString();
                    txtFrenshTitle.Text = raw_material_use_obj.title_fr.ToString();

                }
                break;

                case "periods":
                lblTitle.Text += " - العصر";
                if (table_id != "0")
                {
                    periods_DT periods_obj = periods_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = periods_obj.title.ToString();
                    txtEngilshTitle.Text = periods_obj.title_en.ToString();
                    txtFrenshTitle.Text = periods_obj.title_fr.ToString();

                }
                break;

                case "languages":
                lblTitle.Text += " - لغة المخطوط";
                if (table_id != "0")
                {
                    languages_DT languages_obj = languages_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = languages_obj.title_ar.ToString();
                    txtEngilshTitle.Text = languages_obj.title_en.ToString();
                    txtFrenshTitle.Text = languages_obj.title_fr.ToString();

                }
                break;

                case "copy_status":
                lblTitle.Text += " - حالة النسخ";
                if (table_id != "0")
                {
                    copy_status_DT copy_status_obj = copy_status_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = copy_status_obj.title_ar.ToString();
                    txtEngilshTitle.Text = copy_status_obj.title_en.ToString();
                    txtFrenshTitle.Text = copy_status_obj.title_fr.ToString();

                }
                break;

                case "copy_contains":
                lblTitle.Text += " - النسخة تحتوى على";
                if (table_id != "0")
                {
                    copy_contains_DT copy_contains_obj = copy_contains_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = copy_contains_obj.title_ar.ToString();
                    txtEngilshTitle.Text = copy_contains_obj.title_en.ToString();
                    txtFrenshTitle.Text = copy_contains_obj.title_fr.ToString();

                }
                break;

                case "copy_has":
                lblTitle.Text += " - النسخة بها";
                if (table_id != "0")
                {
                    copy_has_DT copy_has_obj = copy_has_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = copy_has_obj.title_ar.ToString();
                    txtEngilshTitle.Text = copy_has_obj.title_en.ToString();
                    txtFrenshTitle.Text = copy_has_obj.title_fr.ToString();

                }
                break;

                case "license_type":
                lblTitle.Text += " - نوع الإجازة";
                if (table_id != "0")
                {
                    license_type_DT license_type_obj = license_type_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    txtArabicTitle.Text = license_type_obj.title_ar.ToString();
                    txtEngilshTitle.Text = license_type_obj.title_en.ToString();
                    txtFrenshTitle.Text = license_type_obj.title_fr.ToString();

                }
                break;

               
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string code_name = Request.QueryString["id"];
        string table_id = Request.QueryString["table_id"];
        switch (code_name)
        {
            case "col":
                if (table_id != "0")
                {
                    colors_DT color_obj = colors_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                    color_obj.title_ar = txtArabicTitle.Text;
                    color_obj.title_en = txtEngilshTitle.Text;
                    color_obj.title_fr = txtFrenshTitle.Text;
                    colors_DB.Save(color_obj);
                    Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=col");
                }
                else
                {
                    colors_DT color_obj = new colors_DT();
                    color_obj.id = 0;
                    color_obj.title_ar = txtArabicTitle.Text;
                    color_obj.title_en = txtEngilshTitle.Text;
                    color_obj.title_fr = txtFrenshTitle.Text;
                    colors_DB.Save(color_obj);
                    Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=col");
                }
            break;
            case "rel":
            if (table_id != "0")
            {
                relations_DT Relation_obj = relations_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                Relation_obj.title_ar = txtArabicTitle.Text;
                Relation_obj.title_en = txtEngilshTitle.Text;
                Relation_obj.title_fr = txtFrenshTitle.Text;
                Relation_obj.content_type1 = CDataConverter.ConvertToInt(ddlMain.SelectedValue);
                Relation_obj.content_type2 = CDataConverter.ConvertToInt(ddlsub.SelectedValue);
                relations_DB.Save(Relation_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=rel");
            }
            else
            {
                relations_DT Relation_obj = new relations_DT();
                Relation_obj.id = 0;
                Relation_obj.title_ar = txtArabicTitle.Text;
                Relation_obj.title_en = txtEngilshTitle.Text;
                Relation_obj.title_fr = txtFrenshTitle.Text;
                Relation_obj.content_type1 = CDataConverter.ConvertToInt(ddlMain.SelectedValue);
                Relation_obj.content_type2 = CDataConverter.ConvertToInt(ddlsub.SelectedValue);
                relations_DB.Save(Relation_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=rel");
            }
            break;

            case "places_types":
            if (table_id != "0")
            {
                places_types_DT places_types_obj = places_types_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                places_types_obj.title_ar = txtArabicTitle.Text;
                places_types_obj.title_en = txtEngilshTitle.Text;
                places_types_obj.title_fr = txtFrenshTitle.Text;
                places_types_DB.Save(places_types_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=places_types");
            }
            else
            {
                places_types_DT places_types_obj = new places_types_DT();
                places_types_obj.id = 0;
                places_types_obj.title_ar = txtArabicTitle.Text;
                places_types_obj.title_en = txtEngilshTitle.Text;
                places_types_obj.title_fr = txtFrenshTitle.Text;
                places_types_DB.Save(places_types_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=places_types");
            }
            break;

            case "materials":
            if (table_id != "0")
            {
                materials_DT materials_obj = materials_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                materials_obj.title_ar = txtArabicTitle.Text;
                materials_obj.title_en = txtEngilshTitle.Text;
                materials_obj.title_fr = txtFrenshTitle.Text;
                materials_DB.Save(materials_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=materials");
            }
            else
            {
                materials_DT materials_obj = new materials_DT();
                materials_obj.id = 0;
                materials_obj.title_ar = txtArabicTitle.Text;
                materials_obj.title_en = txtEngilshTitle.Text;
                materials_obj.title_fr = txtFrenshTitle.Text;
                materials_DB.Save(materials_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=materials");
            }
            break;

            case "styles":
            if (table_id != "0")
            {
                styles_DT styles_obj = styles_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                styles_obj.title_ar = txtArabicTitle.Text;
                styles_obj.title_en = txtEngilshTitle.Text;
                styles_obj.title_fr = txtFrenshTitle.Text;
                styles_obj.content_type = 8;
                styles_DB.Save(styles_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=styles");
            }
            else
            {
                styles_DT styles_obj = new styles_DT();
                styles_obj.id = 0;
                styles_obj.title_ar = txtArabicTitle.Text;
                styles_obj.title_en = txtEngilshTitle.Text;
                styles_obj.title_fr = txtFrenshTitle.Text;
                styles_obj.content_type = 8;
                styles_DB.Save(styles_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=styles");
            }
            break;

            case "author_type":
            if (table_id != "0")
            {
                author_type_DT author_type_obj = author_type_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                author_type_obj.author_type = txtArabicTitle.Text;
                author_type_obj.author_type_en = txtEngilshTitle.Text;
                author_type_obj.author_type_fr = txtFrenshTitle.Text;
                author_type_DB.Save(author_type_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=author_type");
            }
            else
            {
                author_type_DT author_type_obj = new author_type_DT();
                author_type_obj.id = 0;
                author_type_obj.author_type = txtArabicTitle.Text;
                author_type_obj.author_type_en = txtEngilshTitle.Text;
                author_type_obj.author_type_fr = txtFrenshTitle.Text;
                author_type_DB.Save(author_type_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=author_type");
            }
            break;

            case "authors_role":
            if (table_id != "0")
            {
                authors_role_DT author_role_obj = authors_role_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                author_role_obj.author_role = txtArabicTitle.Text;
                author_role_obj.author_role_en = txtEngilshTitle.Text;
                author_role_obj.author_role_fr = txtFrenshTitle.Text;
                authors_role_DB.Save(author_role_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=authors_role");
            }
            else
            {
                authors_role_DT authors_role_obj = new authors_role_DT();
                authors_role_obj.id = 0;
                authors_role_obj.author_role = txtArabicTitle.Text;
                authors_role_obj.author_role_en = txtEngilshTitle.Text;
                authors_role_obj.author_role_fr = txtFrenshTitle.Text;
                authors_role_DB.Save(authors_role_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=authors_role");
            }
            break;

            case "techniques":
            if (table_id != "0")
            {
                techniques_DT techniques_obj = techniques_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                techniques_obj.title_ar = txtArabicTitle.Text;
                techniques_obj.title_en = txtEngilshTitle.Text;
                techniques_obj.title_fr = txtFrenshTitle.Text;
                techniques_DB.Save(techniques_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=techniques");
            }
            else
            {
                techniques_DT techniques_obj = new techniques_DT();
                techniques_obj.id = 0;
                techniques_obj.title_ar = txtArabicTitle.Text;
                techniques_obj.title_en = txtEngilshTitle.Text;
                techniques_obj.title_fr = txtFrenshTitle.Text;
                techniques_DB.Save(techniques_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=techniques");
            }
            break;

            case "raw_material":
            if (table_id != "0")
            {
                raw_material_DT raw_material_obj = raw_material_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                raw_material_obj.title_ar = txtArabicTitle.Text;
                raw_material_obj.title_en = txtEngilshTitle.Text;
                raw_material_obj.title_fr = txtFrenshTitle.Text;
                raw_material_DB.Save(raw_material_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=raw_material");
            }
            else
            {
                raw_material_DT raw_material_obj = new raw_material_DT();
                raw_material_obj.id = 0;
                raw_material_obj.title_ar = txtArabicTitle.Text;
                raw_material_obj.title_en = txtEngilshTitle.Text;
                raw_material_obj.title_fr = txtFrenshTitle.Text;
                raw_material_DB.Save(raw_material_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=raw_material");
            }
            break;

            case "content_media_type":
            if (table_id != "0")
            {
                content_media_type_DT content_media_type_obj = content_media_type_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                content_media_type_obj.title = txtArabicTitle.Text;
                content_media_type_obj.title_en = txtEngilshTitle.Text;
                content_media_type_obj.title_fr = txtFrenshTitle.Text;
                content_media_type_DB.Save(content_media_type_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=content_media_type");
            }
            else
            {
                content_media_type_DT content_media_type_obj = new content_media_type_DT();
                content_media_type_obj.id = 0;
                content_media_type_obj.title = txtArabicTitle.Text;
                content_media_type_obj.title_en = txtEngilshTitle.Text;
                content_media_type_obj.title_fr = txtFrenshTitle.Text;
                content_media_type_DB.Save(content_media_type_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=content_media_type");
            }
            break;

            case "content_images_types":
            if (table_id != "0")
            {
                content_images_types_DT content_images_types_obj = content_images_types_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                content_images_types_obj.title_ar = txtArabicTitle.Text;
                content_images_types_obj.title_en = txtEngilshTitle.Text;
                content_images_types_obj.title_fr = txtFrenshTitle.Text;
                content_images_types_DB.Save(content_images_types_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=content_images_types");
            }
            else
            {
                content_images_types_DT content_images_types_obj = new content_images_types_DT();
                content_images_types_obj.id = 0;
                content_images_types_obj.title_ar = txtArabicTitle.Text;
                content_images_types_obj.title_en = txtEngilshTitle.Text;
                content_images_types_obj.title_fr = txtFrenshTitle.Text;
                content_images_types_DB.Save(content_images_types_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=content_images_types");
            }
            break;

            case "places_styles":
            if (table_id != "0")
            {
                places_styles_DT places_styles_obj = places_styles_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                places_styles_obj.title_ar = txtArabicTitle.Text;
                places_styles_obj.title_en = txtEngilshTitle.Text;
                places_styles_obj.title_fr = txtFrenshTitle.Text;
                places_styles_DB.Save(places_styles_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=places_styles");
            }
            else
            {
                places_styles_DT places_styles_obj = new places_styles_DT();
                places_styles_obj.id = 0;
                places_styles_obj.title_ar = txtArabicTitle.Text;
                places_styles_obj.title_en = txtEngilshTitle.Text;
                places_styles_obj.title_fr = txtFrenshTitle.Text;
                places_styles_DB.Save(places_styles_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=places_styles");
            }
            break;

            case "architechture_elemnts":
            if (table_id != "0")
            {
                architechture_elemnts_DT architechture_elemnts_obj = architechture_elemnts_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                architechture_elemnts_obj.title_ar = txtArabicTitle.Text;
                architechture_elemnts_obj.title_en = txtEngilshTitle.Text;
                architechture_elemnts_obj.title_fr = txtFrenshTitle.Text;
                architechture_elemnts_DB.Save(architechture_elemnts_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=architechture_elemnts");
            }
            else
            {
                architechture_elemnts_DT architechture_elemnts_obj = new architechture_elemnts_DT();
                architechture_elemnts_obj.id = 0;
                architechture_elemnts_obj.title_ar = txtArabicTitle.Text;
                architechture_elemnts_obj.title_en = txtEngilshTitle.Text;
                architechture_elemnts_obj.title_fr = txtFrenshTitle.Text;
                architechture_elemnts_DB.Save(architechture_elemnts_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=architechture_elemnts");
            }
            break;

            case "raw_material_use":
            if (table_id != "0")
            {
                raw_material_use_DT raw_material_use_obj = raw_material_use_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                raw_material_use_obj.title_ar = txtArabicTitle.Text;
                raw_material_use_obj.title_en = txtEngilshTitle.Text;
                raw_material_use_obj.title_fr = txtFrenshTitle.Text;
                raw_material_use_DB.Save(raw_material_use_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=raw_material_use");
            }
            else
            {
                raw_material_use_DT raw_material_use_obj = new raw_material_use_DT();
                raw_material_use_obj.id = 0;
                raw_material_use_obj.title_ar = txtArabicTitle.Text;
                raw_material_use_obj.title_en = txtEngilshTitle.Text;
                raw_material_use_obj.title_fr = txtFrenshTitle.Text;
                raw_material_use_DB.Save(raw_material_use_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=raw_material_use");
            }
            break;

            case "periods":
            if (table_id != "0")
            {
                periods_DT periods_obj = periods_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                periods_obj.title = txtArabicTitle.Text;
                periods_obj.title_en = txtEngilshTitle.Text;
                periods_obj.title_fr = txtFrenshTitle.Text;
                periods_DB.Save(periods_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=periods");
            }
            else
            {
                periods_DT periods_obj = new periods_DT();
                periods_obj.id = 0;
                periods_obj.title = txtArabicTitle.Text;
                periods_obj.title_en = txtEngilshTitle.Text;
                periods_obj.title_fr = txtFrenshTitle.Text;
                periods_DB.Save(periods_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=periods");
            }
            break;

            case "languages":
            if (table_id != "0")
            {
                languages_DT languages_obj = languages_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                languages_obj.title_ar = txtArabicTitle.Text;
                languages_obj.title_en = txtEngilshTitle.Text;
                languages_obj.title_fr = txtFrenshTitle.Text;
                languages_DB.Save(languages_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=languages");
            }
            else
            {
                languages_DT languages_obj = new languages_DT();
                languages_obj.id = 0;
                languages_obj.title_ar = txtArabicTitle.Text;
                languages_obj.title_en = txtEngilshTitle.Text;
                languages_obj.title_fr = txtFrenshTitle.Text;
                languages_DB.Save(languages_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=languages");
            }
            break;

            case "copy_status":
            if (table_id != "0")
            {
                copy_status_DT copy_status_obj = copy_status_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                copy_status_obj.title_ar = txtArabicTitle.Text;
                copy_status_obj.title_en = txtEngilshTitle.Text;
                copy_status_obj.title_fr = txtFrenshTitle.Text;
                copy_status_DB.Save(copy_status_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=copy_status");
            }
            else
            {
                copy_status_DT copy_status_obj = new copy_status_DT();
                copy_status_obj.id = 0;
                copy_status_obj.title_ar = txtArabicTitle.Text;
                copy_status_obj.title_en = txtEngilshTitle.Text;
                copy_status_obj.title_fr = txtFrenshTitle.Text;
                copy_status_DB.Save(copy_status_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=copy_status");
            }
            break;

            case "copy_contains":
            if (table_id != "0")
            {
                copy_contains_DT copy_contains_obj = copy_contains_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                copy_contains_obj.title_ar = txtArabicTitle.Text;
                copy_contains_obj.title_en = txtEngilshTitle.Text;
                copy_contains_obj.title_fr = txtFrenshTitle.Text;
                copy_contains_DB.Save(copy_contains_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=copy_contains");
            }
            else
            {
                copy_contains_DT copy_contains_obj = new copy_contains_DT();
                copy_contains_obj.id = 0;
                copy_contains_obj.title_ar = txtArabicTitle.Text;
                copy_contains_obj.title_en = txtEngilshTitle.Text;
                copy_contains_obj.title_fr = txtFrenshTitle.Text;
                copy_contains_DB.Save(copy_contains_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=copy_contains");
            }
            break;

            case "copy_has":
            if (table_id != "0")
            {
                copy_has_DT copy_has_obj = copy_has_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                copy_has_obj.title_ar = txtArabicTitle.Text;
                copy_has_obj.title_en = txtEngilshTitle.Text;
                copy_has_obj.title_fr = txtFrenshTitle.Text;
                copy_has_DB.Save(copy_has_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=copy_has");
            }
            else
            {
                copy_has_DT copy_has_obj = new copy_has_DT();
                copy_has_obj.id = 0;
                copy_has_obj.title_ar = txtArabicTitle.Text;
                copy_has_obj.title_en = txtEngilshTitle.Text;
                copy_has_obj.title_fr = txtFrenshTitle.Text;
                copy_has_DB.Save(copy_has_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=copy_has");
            }
            break;

            case "license_type":
            if (table_id != "0")
            {
                license_type_DT license_type_obj = license_type_DB.SelectByID(CDataConverter.ConvertToInt(table_id));
                license_type_obj.title_ar = txtArabicTitle.Text;
                license_type_obj.title_en = txtEngilshTitle.Text;
                license_type_obj.title_fr = txtFrenshTitle.Text;
                license_type_DB.Save(license_type_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=license_type");
            }
            else
            {
                license_type_DT license_type_obj = new license_type_DT();
                license_type_obj.id = 0;
                license_type_obj.title_ar = txtArabicTitle.Text;
                license_type_obj.title_en = txtEngilshTitle.Text;
                license_type_obj.title_fr = txtFrenshTitle.Text;
                license_type_DB.Save(license_type_obj);
                Response.Redirect("~/administration/lookup_grd_veiw.aspx?id=license_type");
            }
            break;

        }
    }
    protected void fillddls()
    {
        DataTable main_dt = new DataTable();
        DataTable sub_dt = new DataTable();
        main_dt = General_Helping.GetDataTable("select * from content_types where id<=4");
        sub_dt = content_types_DB.SelectAll();
        ddlMain.DataSource = main_dt;
        ddlsub.DataSource = sub_dt;
        ddlMain.DataValueField = "id";
        ddlsub.DataValueField = "id";
        ddlMain.DataTextField = "title";
        ddlsub.DataTextField = "title";
        ddlMain.DataBind();
        ddlsub.DataBind();

    }
    protected void fillddlsReverse()
    {
        DataTable main_dt = new DataTable();
        DataTable sub_dt = new DataTable();
        sub_dt = General_Helping.GetDataTable("select * from content_types where id<=4");
        main_dt = content_types_DB.SelectAll();
        ddlMain.DataSource = main_dt;
        ddlsub.DataSource = sub_dt;
        ddlMain.DataValueField = "id";
        ddlsub.DataValueField = "id";
        ddlMain.DataTextField = "title";
        ddlsub.DataTextField = "title";
        ddlMain.DataBind();
        ddlsub.DataBind();
    }
}
