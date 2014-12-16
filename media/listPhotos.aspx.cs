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
using System.Xml;
public partial class Esdarat_listPhotos : BasePage
{
    public static DataTable data_tabe;
    public static int dt_totcunt;
    public static int dt_currstart;
    XmlDocument doc = new XmlDocument();

    protected void page_load(object sender, EventArgs e)
    {
        Page.Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
        Page.Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
        Page.Response.AppendHeader("Expires", "0"); // Proxies.
        if (!IsPostBack)
        {
            Session["Lang"] = "1"; Session["content_type"] = "0"; Session["content_id"] = "0";
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                emb1.Attributes["value"] = " myDesign_E.swf";
                //sourceflash.Attributes["src"] = " myDesign_E.swf";
            }

            
            UserControl divcontrol4 = (UserControl)Page.Master.FindControl("rightUC11");
            divcontrol4.Visible = false;
            UserControl divcontrol5 = (UserControl)Page.Master.FindControl("leftUC11");
            divcontrol5.Visible = false;


            //HtmlGenericControl divcontrol = (HtmlGenericControl)Page.Master.FindControl("rightUC11").FindControl("maindiv");
            //divcontrol.Style.Add("display", "none");
            //divcontrol.Style.Add("visibility", "hidden");
            //divcontrol.Style.Add("clear", "both");
            //HtmlGenericControl divcontrol1 = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("mainDev");
            //divcontrol1.Style.Add("display", "none");
            //divcontrol1.Style.Add("visibility", "hidden");
            //divcontrol1.Style.Add("clear", "both");
            HtmlGenericControl divcontrol6 = (HtmlGenericControl)Page.Master.FindControl("body_left");
            divcontrol6.Attributes.Remove("class");
            HtmlGenericControl divcontrol7 = (HtmlGenericControl)Page.Master.FindControl("body_left_right");
            divcontrol7.Attributes.Remove("class");
            HtmlGenericControl divcontrol3 = (HtmlGenericControl)Page.Master.FindControl("maindiv");

            divcontrol3.Attributes.Add("width", "100%");

            SqlParameter[] sqlParams;

            if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
            {
                sqlParams = new SqlParameter[] { new SqlParameter("@content_type", Request.QueryString["type"].ToString()), 
                                                     
            new SqlParameter("@content_id", Request.QueryString["id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };
            }
            else
            {
                sqlParams = new SqlParameter[] { new SqlParameter("@content_type", "0"), 
                                                     
            new SqlParameter("@content_id", "0"), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

            }




            DataTable dt = DatabaseFunctions.SelectData(sqlParams, "get_images_content");
            if (dt.Rows.Count > 0)
            {
              

                data_tabe = dt;
                dt_totcunt = dt.Rows.Count;
                dt_currstart = 0;

                if (Request.QueryString["imgid"] != null)
                {
                    focus_img();
                }
                else
                {
                    int totcunt = dt.Rows.Count;
                    int currstart = 0;
                    if (dt.Rows.Count / 50.0 > 1.0)
                    {

                        DataTable finalList = dt.Select().Skip(currstart * 50).Take(totcunt - (currstart * 50) < 50 ? totcunt - (currstart * 50) : 50).CopyToDataTable();
                        xml_initiate(finalList);
                        backbtn.Visible = false;
                        nextbtn.Visible = true;
                    }
                    else
                    {
                        backbtn.Visible = false;
                        nextbtn.Visible = false;
                        xml_initiate(dt);
                    }
                }
            }
            else
            {
                //Response.Redirect("~/general/default.aspx");
            }


            

        }

    }


    protected void xml_initiate(DataTable photoslist)
    {
        try
        {
            
            // XML declaration
            XmlNode declaration = doc.CreateNode(XmlNodeType.XmlDeclaration, null, null);
            doc.AppendChild(declaration);

            // Root element: gallery
            XmlElement root = doc.CreateElement("gallery");
            doc.AppendChild(root);

            XmlAttribute albumMainTitle = doc.CreateAttribute("albumMainTitle");
            if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
            {
                switch (Request.QueryString["type"].ToString())
                {
                    case "1":
                        albumMainTitle.Value = characters_details_DB.SelectBychar_ID(CDataConverter.ConvertToInt(Request.QueryString["id"]), menus_update.get_current_lang()).name;
                        break;
                    case "2":
                        albumMainTitle.Value = events_details_DB.SelectByevent_ID(CDataConverter.ConvertToInt(Request.QueryString["id"]), menus_update.get_current_lang()).title;
                        break;
                    case "3":
                        albumMainTitle.Value = topics_details_DB.SelectBytopic_ID(CDataConverter.ConvertToInt(Request.QueryString["id"]), menus_update.get_current_lang()).title;
                        break;
                    case "4":
                        albumMainTitle.Value = places_details_DB.SelectByID(CDataConverter.ConvertToInt(Request.QueryString["id"]), menus_update.get_current_lang()).name;
                        break;
                }
            }
            else
            {
                if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                {
                    albumMainTitle.Value = "Photo Album";
                }
                else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                {
                    albumMainTitle.Value = "photo album";
                }
                else
                    albumMainTitle.Value = "ألبوم الصور";

            }

            root.Attributes.Append(albumMainTitle);
            XmlAttribute selectedImage = doc.CreateAttribute("selectedImage");
            selectedImage.Value = "0";
            DataTable images_types = content_images_types_DB.SelectAll();
            DataTable TimeLine = periods_DB.SelectAll();
            if (photoslist != null)
            {
                if (photoslist.Rows.Count != 0)
                {
                    for (int i = 0; i < photoslist.Rows.Count; i++)
                    {

                        if (Request.QueryString["imgid"] != null)
                        {
                            if (Request.QueryString["imgid"].ToString() == photoslist.Rows[i]["id"].ToString())
                            {
                                selectedImage.Value = (i + 1).ToString();
                                root.Attributes.Append(selectedImage);
                            }
                        }

                        string directory = @"~/images/uploaded_images/";
                        string filename = photoslist.Rows[i]["large_image"].ToString();
                        string path = System.IO.Path.Combine(directory, filename);
                        // Sub-element: image
                        XmlElement image = doc.CreateElement("image");
                        root.AppendChild(image);
                        XmlElement thumbFile = doc.CreateElement("thumbFile");
                        if (photoslist.Rows[i]["small_image"] != null)
                            if (photoslist.Rows[i]["small_image"].ToString() != "")
                            {
                                if (Server.MapPath(path) != "" && System.IO.File.Exists(Server.MapPath(path)))
                                    thumbFile.InnerText = "../images/uploaded_images/" + photoslist.Rows[i]["small_image"].ToString();
                                else
                                    thumbFile.InnerText = "../img/Thumb.jpg";
                            }
                            else
                                thumbFile.InnerText = "../img/Thumb.jpg";
                        image.AppendChild(thumbFile);
                        XmlElement photoFile = doc.CreateElement("photoFile");
                        if (photoslist.Rows[i]["large_image"] != null)
                            if (photoslist.Rows[i]["large_image"].ToString() != "")
                            {
                                if (Server.MapPath(path) != "" && System.IO.File.Exists(Server.MapPath(path)))
                                    photoFile.InnerText = "../images/uploaded_images/" + photoslist.Rows[i]["large_image"].ToString();
                                else
                                    photoFile.InnerText = "../img/azhar-char.gif";
                            }
                            else
                                photoFile.InnerText = "../img/azhar-char.gif";
                        image.AppendChild(photoFile);
                        XmlElement photoTitle = doc.CreateElement("photoTitle");
                        photoTitle.InnerText = photoslist.Rows[i]["title"].ToString();
                        image.AppendChild(photoTitle);
                        XmlElement photoDesc = doc.CreateElement("photoDesc");
                        photoDesc.InnerText = photoslist.Rows[i]["describtion"].ToString();
                        image.AppendChild(photoDesc);

                        XmlElement itemA = doc.CreateElement("itemA");
                        XmlAttribute idA = doc.CreateAttribute("idA");

                        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        {
                            idA.Value = "Photographer/ painter";
                        }
                        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        {
                            idA.Value = "Photographe/peintre ";
                        }
                        else
                            idA.Value = "المصور/الرسام ";


                        // idA.Value = (String) GetGlobalResourceObject("Resources:Master","Photographer") ;
                        itemA.Attributes.Append(idA);
                        itemA.InnerText = photoslist.Rows[i]["photographer"].ToString();
                        image.AppendChild(itemA);

                        XmlElement itemB = doc.CreateElement("itemB");
                        XmlAttribute idB = doc.CreateAttribute("idB");
                        if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        {
                            idB.Value = "Type de l’image  ";
                        }

                        else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        {
                            idB.Value = "Type of Photo/ portrait";
                        }
                        else
                            idB.Value = "نوع الصورة ";


                        // idB.Value = (String)GetGlobalResourceObject("Resources:Master", "Image_Type"); 
                        itemB.Attributes.Append(idB);
                        if (photoslist.Rows[i]["category"] != null)
                        {
                            for (int con = 0; con < images_types.Rows.Count; con++)
                            {
                                if (images_types.Rows[con]["id"].ToString() == photoslist.Rows[i]["category"].ToString())
                                {
                                    itemB.InnerText = images_types.Rows[con]["title_ar"].ToString();
                                    break;
                                }
                            }
                        }
                        image.AppendChild(itemB);

                        XmlElement itemC = doc.CreateElement("itemC");
                        XmlAttribute idC = doc.CreateAttribute("idC");


                        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        {
                            idC.Value = "Date of photo/ painting A.D ";
                        }
                        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        {
                            idC.Value = "Date de photographie/ de peinture AP.JC ";
                        }
                        else
                            idC.Value = "تاريخ الصورة الميلادى ";


                        // idC.Value = (String)GetGlobalResourceObject("Resources:Master", "Image_dateAD"); 
                        itemC.Attributes.Append(idC);
                        itemC.InnerText = photoslist.Rows[i]["record_date_georgian"].ToString();
                        image.AppendChild(itemC);

                        XmlElement itemD = doc.CreateElement("itemD");
                        XmlAttribute idD = doc.CreateAttribute("idD");


                        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        {
                            idD.Value = "Date of photo/ painting A.H";
                        }
                        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        {
                            idD.Value = "Date de photographie/ de peinture H ";
                        }
                        else
                            idD.Value = " تاريخ الصورة الهجرى";

                        // idD.Value = (String)GetGlobalResourceObject("Resources:Master", "Hijra_Image_date");  
                        itemD.Attributes.Append(idD);
                        itemD.InnerText = photoslist.Rows[i]["record_date_hijri"].ToString();
                        image.AppendChild(itemD);

                        XmlElement itemE = doc.CreateElement("itemE");
                        XmlAttribute idE = doc.CreateAttribute("idE");


                        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        {
                            idE.Value = "Source/ copyright  ";
                        }
                        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        {
                            idE.Value = "Source et autorité ayant le droit d’auteur";
                        }
                        else
                            idE.Value = "  المصدر";


                        // idE.Value = (String)GetGlobalResourceObject("Resources:Master", "Source_destination_Copyright"); 
                        itemE.Attributes.Append(idE);
                        itemE.InnerText = photoslist.Rows[i]["resource_name"].ToString();
                        image.AppendChild(itemE);


                        XmlElement itemF = doc.CreateElement("itemF");
                        XmlAttribute idF = doc.CreateAttribute("idF");


                        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        {
                            idF.Value = "Notes";
                        }
                        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        {
                            idF.Value = "Remarques";
                        }
                        else
                            idF.Value = "ملاحظة";

                        //idF.Value = (String)GetGlobalResourceObject("Resources:Master", "Image_notes"); 
                        itemF.Attributes.Append(idF);
                        itemF.InnerText = photoslist.Rows[i]["notes"].ToString();
                        image.AppendChild(itemF);

                        XmlElement itemG = doc.CreateElement("itemG");
                        XmlAttribute idG = doc.CreateAttribute("idG");



                        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        {
                            idG.InnerText = "The age  which the photo is related to";
                        }
                        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        {
                            idG.InnerText = "L’époque à la quelle appartient l’image  ";
                        }
                        else
                            idG.InnerText = "العصر الذي تنتمي إليه الصورة ";


                        // idG.InnerText = (String)GetGlobalResourceObject("Resources:Master", "Age_belongs_photo"); 
                        itemG.Attributes.Append(idG);

                        if (photoslist.Rows[i]["period_id_multi"] != null && photoslist.Rows[i]["period_id_multi"].ToString() != "")
                        {
                            String[] temp = photoslist.Rows[i]["period_id_multi"].ToString().Split(',');
                            if (temp.Length > 0)
                            {
                                for (int tj = 0; tj < temp.Length; tj++)
                                {
                                    for (int tl = 0; tl < TimeLine.Rows.Count; tl++)
                                    {

                                        if (TimeLine.Rows[tl]["id"].ToString() == temp[tj])
                                        {
                                            if (tj == temp.Length - 1)
                                                itemG.InnerText += TimeLine.Rows[tl]["title"].ToString();
                                            else
                                                itemG.InnerText += TimeLine.Rows[tl]["title"].ToString() + ", ";
                                            break;
                                        }
                                    }
                                }
                            }
                        }


                        image.AppendChild(itemG);

                        XmlElement itemH = doc.CreateElement("itemH");
                        XmlAttribute idH = doc.CreateAttribute("idH");

                        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                        {
                            idH.Value = "Notes";
                        }
                        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                        {
                            idH.Value = "Remarques";
                        }
                        else
                            idH.Value = " ملاحظة على العصر";

                        // idH.Value = (String)GetGlobalResourceObject("Resources:Master", "Notes_on_age"); 
                        itemH.Attributes.Append(idH);
                        itemH.InnerText = photoslist.Rows[i]["period_desc"].ToString();
                        image.AppendChild(itemH);

                    }
                }
            }


            doc.Save(Server.MapPath(@"~/media/myData.xml"));
        }


        catch (InvalidCastException ex)
        {
            // Response.Write(ex.Message);
            throw (ex);
        }
    }
    protected void backbtn_Click(object sender, ImageClickEventArgs e)
    {
        DataTable dt;
        if (data_tabe != null)
        {
            dt = (DataTable)data_tabe;
        }
        else
        {
            dt = getDT();

        }


        int totcunt;
        if (dt_totcunt != null)
        {
            totcunt = CDataConverter.ConvertToInt(dt_totcunt);
        }
        else
        { totcunt = dt.Rows.Count; }
        int currstart;
        if (dt_currstart != null)
        { currstart = CDataConverter.ConvertToInt(dt_currstart); }
        else
        { currstart = 0; }
        currstart -= 1;
        dt_currstart = currstart;
        DataTable finalList = dt.Select().Skip(currstart * 50).Take(totcunt - (currstart * 50) < 50 ? totcunt - (currstart * 50) : 50).CopyToDataTable();
        xml_initiate(finalList);
        if (currstart == 0)
            backbtn.Visible = false;
        nextbtn.Visible = true;
    }
    protected void nextbtn_Click(object sender, ImageClickEventArgs e)
    {

        DataTable dt;
        if (data_tabe != null)
        {
            dt = (DataTable)data_tabe;
        }
        else
        {
            dt = getDT();

        }


        int totcunt;
        if (dt_totcunt != null)
        {
            totcunt = CDataConverter.ConvertToInt(dt_totcunt);
        }
        else
        { totcunt = dt.Rows.Count; }
        int currstart;
        if (dt_currstart != null)
        { currstart = CDataConverter.ConvertToInt(dt_currstart); }
        else
        { currstart = 0; }
        currstart += 1;
        dt_currstart = currstart;
        DataTable finalList = dt.Select().Skip(currstart * 50).Take(totcunt - (currstart * 50) < 50 ? totcunt - (currstart * 50) : 50).CopyToDataTable();
        xml_initiate(finalList);
        if (totcunt - (currstart * 50) < 50)
            nextbtn.Visible = false;
        backbtn.Visible = true;
    }

    protected void focus_img()
    {
        DataTable dt;
        if (data_tabe != null)
        {
            dt = (DataTable)data_tabe;
        }
        else
        {
            dt = getDT();

        }
        DataRow[] resultsize = dt.Select("id=" + Request.QueryString["imgid"] + "");
        int idx = dt.Rows.IndexOf(resultsize[0]);
        double start_idx = Math.Floor(Convert.ToDouble(idx / 50));
        //end code
        int totcunt;
        if (dt_totcunt != null)
        {
            totcunt = CDataConverter.ConvertToInt(dt_totcunt);
        }
        else
        { totcunt = dt.Rows.Count; }
        int currstart = Convert.ToInt32(start_idx);
        dt_currstart = currstart;
        DataTable finalList = dt.Select().Skip(currstart * 50).Take(totcunt - (currstart * 50) < 50 ? totcunt - (currstart * 50) : 50).CopyToDataTable();
        xml_initiate(finalList);
        if (totcunt - (currstart * 50) < 50)
            nextbtn.Visible = false;
        backbtn.Visible = true;
    }
    protected DataTable getDT()
    {
        SqlParameter[] sqlParams;

        if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
        {
            sqlParams = new SqlParameter[] { new SqlParameter("@content_type", Request.QueryString["type"].ToString()), 
                                                     
            new SqlParameter("@content_id", Request.QueryString["id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };
        }
        else
        {
            sqlParams = new SqlParameter[] { new SqlParameter("@content_type", "0"), 
                                                     
            new SqlParameter("@content_id", "0"), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

        }
        DataTable dt = DatabaseFunctions.SelectData(sqlParams, "get_images_content");
        return dt;
    }
}
