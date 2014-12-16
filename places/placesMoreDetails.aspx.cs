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
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;
using System.IO;

public partial class places_placesMoreDetails : BasePage
{
  

    General_Helping Obj_General_Helping = new General_Helping();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
            Session["content_id"] = id.ToString();
            Session["content_type"] = "4";
            //Session["referred"] = "true";
            
            HiddenID.Value = id.ToString();
            if (id > 0)
            {
                hits_count obj = new hits_count();
                obj.hit_count_save(id, 4);
            }
            fillDDLsRBts();
            fillGridVeiws();
            View();


            if (Session["Lang"].ToString() == "1" || Session["Lang"].ToString() == "ar")
            {
                //mainclass.Attributes.Add("href", "../css/detailsCSS.css");
            }
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                div_1.Attributes["class"] = "float";
                //mainclass.Attributes.Add("href", "../css/detailsCSSen.css");
                mainheaderdiv.Attributes["class"] = "mainHeaderL";
                sideBardiv.Attributes["class"] = "sideBarL";
                div100.Attributes["class"] = "showContentL";
                div101.Attributes["class"] = "mainContentL";
                div102.Attributes["class"] = "mainContentL";
                div103.Attributes["class"] = "mainContentL";
                div104.Attributes["class"] = "mainContentL";
                div105.Attributes["class"] = "mainContentL";
                div106.Attributes["class"] = "mainContentL";
                div107.Attributes["class"] = "mainContentL";
                div108.Attributes["class"] = "mainContentL";
                div109.Attributes["class"] = "mainContentL";
                div110.Attributes["class"] = "mainContentL";
            }

            //////////////////////////////////

            string page_name = Path.GetFileName(Request.Path);
            Session["page_name"] = page_name;
            //page_name == "placesMoreDetails.aspx")

            //DataTable dt = menus_update.get_images_related(page_name);
            //if (dt.Rows.Count > 0)
            //{

            //    if (dt.Rows[0]["small_image"].ToString() != "")
            //    {
            //        img_1_1.ImageUrl = "../images/uploaded_images/" + dt.Rows[0]["small_image"].ToString();
            //        a_1_1.HRef = "../media/listPhotos.aspx?type=" + Session["content_type"].ToString() + "&id=" + Session["content_id"].ToString() + "&imgid=" + dt.Rows[0]["id"].ToString();

            //        if (dt.Rows[0]["title"].ToString() != "")
            //        {
            //            img_1_1.ToolTip = dt.Rows[0]["title"].ToString();
            //        }
            //    }


            //    if (dt.Rows.Count > 1)
            //    {
            //        if (dt.Rows[1]["small_image"].ToString() != "")
            //        {
            //            img_1_2.ImageUrl = "../images/uploaded_images/" + dt.Rows[1]["small_image"].ToString();
            //            a_1_2.HRef = "../media/listPhotos.aspx?type=" + Session["content_type"].ToString() + "&id=" + Session["content_id"].ToString() + "&imgid=" + dt.Rows[1]["id"].ToString();

            //            if (dt.Rows[1]["title"].ToString() != "")
            //            {
            //                img_1_2.ToolTip = dt.Rows[1]["title"].ToString();
            //            }
            //        }

            //    }
            //    else { img_1_2.Visible = false; }
            //    if (dt.Rows.Count > 2)
            //    {
            //        if (dt.Rows[2]["small_image"].ToString() != "")
            //        {
            //            img_1_3.ImageUrl = "../images/uploaded_images/" + dt.Rows[2]["small_image"].ToString();
            //            a_1_3.HRef = "../media/listPhotos.aspx?type=" + Session["content_type"].ToString() + "&id=" + Session["content_id"].ToString() + "&imgid=" + dt.Rows[2]["id"].ToString();

            //            if (dt.Rows[2]["title"].ToString() != "")
            //            {
            //                img_1_3.ToolTip = dt.Rows[2]["title"].ToString();
            //            }
            //        }
            //    }
            //    else { img_1_3.Visible = false; }
            //    /////--------
            //    if (dt.Rows.Count > 3)
            //    {
            //        if (dt.Rows[2]["small_image"].ToString() != "")
            //        {
            //            img_1_4.ImageUrl = "../images/uploaded_images/" + dt.Rows[2]["small_image"].ToString();
            //            a_1_4.HRef = "../media/listPhotos.aspx?type=" + Session["content_type"].ToString() + "&id=" + Session["content_id"].ToString() + "&imgid=" + dt.Rows[2]["id"].ToString();

            //            if (dt.Rows[2]["title"].ToString() != "")
            //            {
            //                img_1_4.ToolTip = dt.Rows[2]["title"].ToString();
            //            }
            //        }
            //    }
            //    else { img_1_4.Visible = false; }

            //    if (dt.Rows.Count > 4)
            //    {
            //        if (dt.Rows[2]["small_image"].ToString() != "")
            //        {
            //            img_1_5.ImageUrl = "../images/uploaded_images/" + dt.Rows[2]["small_image"].ToString();
            //            a_1_5.HRef = "../media/listPhotos.aspx?type=" + Session["content_type"].ToString() + "&id=" + Session["content_id"].ToString() + "&imgid=" + dt.Rows[2]["id"].ToString();

            //            if (dt.Rows[2]["title"].ToString() != "")
            //            {
            //                img_1_5.ToolTip = dt.Rows[2]["title"].ToString();
            //            }
            //        }
            //    }
            //    else { img_1_5.Visible = false; }

            //    if (dt.Rows.Count > 5)
            //    {
            //        if (dt.Rows[2]["small_image"].ToString() != "")
            //        {
            //            img_1_6.ImageUrl = "../images/uploaded_images/" + dt.Rows[2]["small_image"].ToString();
            //            a_1_6.HRef = "../media/listPhotos.aspx?type=" + Session["content_type"].ToString() + "&id=" + Session["content_id"].ToString() + "&imgid=" + dt.Rows[2]["id"].ToString();

            //            if (dt.Rows[2]["title"].ToString() != "")
            //            {
            //                img_1_6.ToolTip = dt.Rows[2]["title"].ToString();
            //            }
            //        }
            //    }
            //    else { img_1_6.Visible = false; }

            //    if (dt.Rows.Count > 6)
            //    {
            //        if (dt.Rows[2]["small_image"].ToString() != "")
            //        {
            //            img_1_7.ImageUrl = "../images/uploaded_images/" + dt.Rows[2]["small_image"].ToString();
            //            a_1_7.HRef = "../media/listPhotos.aspx?type=" + Session["content_type"].ToString() + "&id=" + Session["content_id"].ToString() + "&imgid=" + dt.Rows[2]["id"].ToString();

            //            if (dt.Rows[2]["title"].ToString() != "")
            //            {
            //                img_1_7.ToolTip = dt.Rows[2]["title"].ToString();
            //            }
            //        }
            //    }
            //    else { img_1_7.Visible = false; }

            //    if (dt.Rows.Count > 7)
            //    {
            //        if (dt.Rows[2]["small_image"].ToString() != "")
            //        {
            //            img_1_8.ImageUrl = "../images/uploaded_images/" + dt.Rows[2]["small_image"].ToString();
            //            a_1_8.HRef = "../media/listPhotos.aspx?type=" + Session["content_type"].ToString() + "&id=" + Session["content_id"].ToString() + "&imgid=" + dt.Rows[2]["id"].ToString();

            //            if (dt.Rows[2]["title"].ToString() != "")
            //            {
            //                img_1_8.ToolTip = dt.Rows[2]["title"].ToString();
            //            }
            //        }
            //    }
            //    else { img_1_8.Visible = false; }

          


            //}
        }
    }

  

    public void fillDDLsRBts()
    {
        DataTable DT = General_Helping.GetDataTable("select id,title,title_en,title_fr from periods");
        rbl_main_architectural_styles_type.DataSource = DT;
        rbl_main_architectural_styles_type.DataTextField = "title";
        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            rbl_main_architectural_styles_type.DataTextField = "title_en";
        if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            rbl_main_architectural_styles_type.DataTextField = "title_fr";
        rbl_main_architectural_styles_type.DataValueField = "id";
        rbl_main_architectural_styles_type.DataBind();
        DataTable DT1 = General_Helping.GetDataTable("select id,title_ar,title_en,title_fr from places_types");
        rbl_current_function.DataSource = DT1;
        rbl_current_function.DataTextField = "title_ar";
        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            rbl_current_function.DataTextField = "title_en";
        if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            rbl_current_function.DataTextField = "title_fr";
        rbl_current_function.DataValueField = "id";
        rbl_current_function.DataBind();
        DataTable DT4 = General_Helping.GetDataTable("select id,title_ar,title_en,title_fr from raw_material");
        rbl_building_raw_material.DataSource = DT4;
        rbl_building_raw_material.DataTextField = "title_ar";
        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            rbl_building_raw_material.DataTextField = "title_en";
        if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            rbl_building_raw_material.DataTextField = "title_fr";
        rbl_building_raw_material.DataValueField = "id";
        rbl_building_raw_material.DataBind();
        //for (int index = 0; index < rbl_building_raw_material.Items.Count; index++)
        //{
        //    ListItem item = rbl_building_raw_material.Items[index];
        //    string valueToSet = rbl_building_raw_material.Items[index].Value;
        //    item.Attributes.Add("JSvalue", valueToSet);//set client side attribute JSvalue
        //}


        DataTable DT5 = General_Helping.GetDataTable("select id,title_ar,title_en,title_fr from raw_material_use");
        rbl_building_raw_material_use.DataSource = DT5;
        rbl_building_raw_material_use.DataTextField = "title_ar";
        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            rbl_building_raw_material_use.DataTextField = "title_en";
        if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            rbl_building_raw_material_use.DataTextField = "title_fr";
        rbl_building_raw_material_use.DataValueField = "id";
        rbl_building_raw_material_use.DataBind();
    }
    public void fillGridVeiws()
    {


        SqlParameter[] sqlParams_building_material = new SqlParameter[] { new SqlParameter("@place_id", CDataConverter.ConvertToInt(HiddenID.Value)) };
        DataTable dt_building_material = new DataTable();
        dt_building_material = DatabaseFunctions.SelectData(sqlParams_building_material, "place_building_material_select");
        if (dt_building_material.Rows.Count > 0)
        {
            gv_building_material.Visible = true;
            gv_building_material.DataSource = dt_building_material;
            gv_building_material.DataBind();

            for (int r = 0; r < dt_building_material.Rows.Count; r++)
            {
                Label lbl = (Label)gv_building_material.Rows[r].FindControl("lblConTitle");
                places_building_material_DT places_building_material_obj = places_building_material_DB.SelectByID(CDataConverter.ConvertToInt(dt_building_material.Rows[r]["id"]));

                if (places_building_material_obj.building_raw_material_other != null && places_building_material_obj.building_raw_material_other != "")
                {
                    String[] temp = places_building_material_obj.building_raw_material_other.ToString().Split('-');
                    if (temp.Length > 0)
                    {
                        String[] temp2 = temp[0].Split(',');
                        if (temp2.Length > 0)
                        {
                            for (int i = 0; i < rbl_building_raw_material.Items.Count; i++)
                            {
                                for (int j = 0; j < temp2.Length; j++)
                                {
                                    if (rbl_building_raw_material.Items[i].Value == temp2[j])
                                    {
                                        //rbl_building_raw_material.Items[i].Selected = true;

                                        if (rbl_building_raw_material.Items[i].Value != "10")
                                        {
                                            if (lbl.Text != "")
                                                lbl.Text += ", " + rbl_building_raw_material.Items[i].Text;
                                            else
                                                lbl.Text += rbl_building_raw_material.Items[i].Text;
                                        }
                                        else
                                        {
                                            if (lbl.Text != "")
                                                lbl.Text += ", " + rbl_building_raw_material.Items[i].Text + "- ";
                                            else
                                                lbl.Text += rbl_building_raw_material.Items[i].Text + "- ";
                                        }




                                    }
                                }
                            }
                        }
                    }
                    if (temp.Length > 1)
                    {
                        if (temp[1] != "")
                        {
                            lbl.Text += temp[1].ToString();
                        }
                    }

                }


            }




        }
        else
            gv_building_material.EmptyDataText = (String)GetGlobalResourceObject("Master", "check_data") ;
        SqlParameter[] sqlParams_function = new SqlParameter[] { new SqlParameter("@place_id", CDataConverter.ConvertToInt(HiddenID.Value)) };
        DataTable dt_function = new DataTable();
        dt_function = DatabaseFunctions.SelectData(sqlParams_function, "place_function_select");
        if (dt_function.Rows.Count > 0)
        {
            gv_function.Visible = true;
            gv_function.DataSource = dt_function;
            gv_function.DataBind();
        }
        else
            gv_function.EmptyDataText = (String)GetGlobalResourceObject("Master", "check_data");



    }
    public void View()
    {
        places_DT places_obj_to_save = new places_DT();
        places_details_DT places_details_obj_to_save = new places_details_DT();
        
        places_obj_to_save = places_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value));
        places_details_obj_to_save = places_details_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value), menus_update.get_current_lang());
        
        if (places_obj_to_save != null)
        {
            if (places_obj_to_save.form_status != 12 && (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1"))
                Response.Redirect("~/places/Default.aspx");
            if (places_obj_to_save.form_status_en != 12 && (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2"))
                Response.Redirect("~/places/Default.aspx");
            if (places_obj_to_save.form_status_fr != 12 && (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3"))
                Response.Redirect("~/places/Default.aspx");
        }
        imBack.HRef = "~/places/placesDetails.aspx?id=" + CDataConverter.ConvertToInt(HiddenID.Value);
        mainTitle.InnerText = places_details_obj_to_save.name;
        fillGridVeiws();


        if (places_details_obj_to_save.description != null && places_details_obj_to_save.description != "")
        { txt_description.Text = places_details_obj_to_save.description; }
        else { txt_description.Text = (String)GetGlobalResourceObject("Master", "check_data"); }
        if (places_details_obj_to_save.notes != null && places_details_obj_to_save.notes != "")
            txtNotes.InnerText = places_details_obj_to_save.notes;
        else
            txtNotes.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.outside_entrances != null && places_details_obj_to_save.outside_entrances != "")
        txt_outside_entrances.InnerText = places_details_obj_to_save.outside_entrances;
        else
            txt_outside_entrances.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.outside_interfaces != null && places_details_obj_to_save.outside_interfaces != "")
        txt_outside_interfaces.InnerText = places_details_obj_to_save.outside_interfaces;
        else
            txt_outside_interfaces.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.outside_windows != null && places_details_obj_to_save.outside_windows != "")
        txt_outside_windows.InnerText = places_details_obj_to_save.outside_windows;
        else
            txt_outside_windows.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.outside_minarets != null && places_details_obj_to_save.outside_minarets != "")
        
        txt_outside_minarets.InnerText = places_details_obj_to_save.outside_minarets;
        else
            txt_outside_minarets.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.outside_domes != null && places_details_obj_to_save.outside_domes != "")
        
        txt_outside_domes.InnerText = places_details_obj_to_save.outside_domes;
        else
            txt_outside_domes.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.inside_yard != null && places_details_obj_to_save.inside_yard != "")
        
        txt_inside_yard.InnerText = places_details_obj_to_save.inside_yard;
        else
            txt_inside_yard.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.inside_roofs != null && places_details_obj_to_save.inside_roofs != "")
        
        txt_inside_roofs.InnerText = places_details_obj_to_save.inside_roofs;
        else
            txt_inside_roofs.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.inside_iwans != null && places_details_obj_to_save.inside_iwans != "")
        
        txt_inside_iwans.InnerText = places_details_obj_to_save.inside_iwans;
        else
            txt_inside_iwans.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.inside_halls != null && places_details_obj_to_save.inside_halls != "")
        
        txt_inside_halls.InnerText = places_details_obj_to_save.inside_halls;
        else
            txt_inside_halls.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.inside_seats != null && places_details_obj_to_save.inside_seats != "")
        
        txt_inside_seats.InnerText = places_details_obj_to_save.inside_seats;
        else
            txt_inside_seats.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.inside_supplements != null && places_details_obj_to_save.inside_supplements != "")
       
        txt_inside_supplements.InnerText = places_details_obj_to_save.inside_supplements;
        else
            txt_inside_supplements.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.inside_sabeel_room != null && places_details_obj_to_save.inside_sabeel_room != "")
       
        txt_inside_sabeel_room.InnerText = places_details_obj_to_save.inside_sabeel_room;
        else
            txt_inside_sabeel_room.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.literature != null && places_details_obj_to_save.literature != "")
        txt_literature.InnerText = places_details_obj_to_save.literature;
        else
            txt_literature.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.geometric != null && places_details_obj_to_save.geometric != "")
        txt_geometric.InnerText = places_details_obj_to_save.geometric;
        else
            txt_geometric.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.geometric != null && places_details_obj_to_save.geometric != "")
        txt_floral.InnerText = places_details_obj_to_save.floral;
        else
            txt_floral.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (CDataConverter.ConvertToInt(places_details_obj_to_save.main_architectural_styles_type) > 0)
        {
            string id = places_details_obj_to_save.main_architectural_styles_type.ToString();
            rbl_main_architectural_styles_type.Items.FindByValue(id).Selected = true;
            lbl_main_architectural_styles_type.InnerText = rbl_main_architectural_styles_type.SelectedItem.Text;
        }else
            lbl_main_architectural_styles_type.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.main_architectural_styles_type_general_feature != null && places_details_obj_to_save.main_architectural_styles_type_general_feature != "")
        txt_main_architectural_styles_type_general_feature.InnerText = places_details_obj_to_save.main_architectural_styles_type_general_feature;
        else
            txt_main_architectural_styles_type_general_feature.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.main_architectural_styles_type_notes != null && places_details_obj_to_save.main_architectural_styles_type_notes != "")
        txt_main_architectural_styles_type_notes.InnerText = places_details_obj_to_save.main_architectural_styles_type_notes;
        else
            txt_main_architectural_styles_type_notes.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (CDataConverter.ConvertToInt(places_details_obj_to_save.current_function) > 0)
        {
            string id = places_details_obj_to_save.current_function.ToString();
            rbl_current_function.Items.FindByValue(id).Selected = true;
            lbl_current_function.InnerText = rbl_current_function.SelectedItem.Text;
        }
        else
            lbl_current_function.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.current_function_notes != null && places_details_obj_to_save.current_function_notes != "")
        txt_current_function_notes.InnerText = places_details_obj_to_save.current_function_notes;
        else
            txt_current_function_notes.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.current_address != null && places_details_obj_to_save.current_address != "")
        txt_current_address.InnerText = places_details_obj_to_save.current_address;
        else
            txt_current_address.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.current_address_desc != null && places_details_obj_to_save.current_address_desc != "")
        txt_current_address_desc.InnerText = places_details_obj_to_save.current_address_desc;
        else
            txt_current_address_desc.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.current_address_notes != null && places_details_obj_to_save.current_address_notes != "")
        txt_current_address_notes.InnerText = places_details_obj_to_save.current_address_notes;
        else
            txt_current_address_notes.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.current_state != null && places_details_obj_to_save.current_state != "")
        txt_current_state.InnerText = places_details_obj_to_save.current_state;
        else
            txt_current_state.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.restoration_current_state != null && places_details_obj_to_save.restoration_current_state != "")
        txt_restoration_current_state.InnerText = places_details_obj_to_save.restoration_current_state;
        else
            txt_restoration_current_state.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.restoration_current_state_person != null && places_details_obj_to_save.restoration_current_state_person != "")
        txt_restoration_current_state_person.InnerText = places_details_obj_to_save.restoration_current_state_person;
        else
            txt_restoration_current_state_person.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.restoration_current_state_participants != null && places_details_obj_to_save.restoration_current_state_participants != "")
        txt_restoration_current_state_participants.InnerText = places_details_obj_to_save.restoration_current_state_participants;
        else
            txt_restoration_current_state_participants.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.restoration_current_state_note != null && places_details_obj_to_save.restoration_current_state_note != "")
        txt_restoration_current_state_note.InnerText = places_details_obj_to_save.restoration_current_state_note;
        else
            txt_restoration_current_state_note.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.current_location_longitude != null && places_details_obj_to_save.current_location_longitude != "")
        txt_current_location_longitude.InnerText = places_details_obj_to_save.current_location_longitude;
        else
            txt_current_location_longitude.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.current_location_latitude != null && places_details_obj_to_save.current_location_latitude != "")
        txt_current_location_latitude.InnerText = places_details_obj_to_save.current_location_latitude;
        else
            txt_current_location_latitude.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.current_location_desc != null && places_details_obj_to_save.current_location_desc != "")
        txt_current_location_desc.InnerText = places_details_obj_to_save.current_location_desc;
        else
            txt_current_location_desc.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
        if (places_details_obj_to_save.current_location_note != null && places_details_obj_to_save.current_location_note != "")
        txt_current_location_note.InnerText = places_details_obj_to_save.current_location_note;
        else
            txt_current_location_note.InnerText = (String)GetGlobalResourceObject("Master", "check_data");
    }
    

}
