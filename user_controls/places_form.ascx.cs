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
using Dates;
using System.Data.SqlClient;

public partial class user_controls_places_form : System.Web.UI.UserControl
{
    General_Helping Obj_General_Helping = new General_Helping();
    places_DT places_obj_to_save = new places_DT();
    places_details_DT places_details_obj_to_save = new places_details_DT();
    //places_DT places_obj_to_select = places_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
    //places_details_DT places_details_obj_to_select = places_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
       
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
        
            if (content_id.Value != "")
            {

                //TextBox tx = base.Controls[7].Page.Controls[7] as TextBox;
                //DropDownList myDropDown = mainPage.MyDropDown;
               // TextBox tx = (TextBox)mainPage.FindControl("HiddenPostback");
               
                //if (tx.Text == ""){
                getData();
                fillDDLsRBts();
                filldata();
               
                fillGridVeiws();
                
                set_example_label();
                //}
                //tx.Text = "1";
                
                if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
                {
                    unvisible();
                    visable_translated_only();
                }
                if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
                {
                    btn_save_building_material.Visible = btn_save_function.Visible = false;
                    gv_building_material.Columns[4].Visible =
                    gv_building_material.Columns[3].Visible =
                    gv_function.Columns[4].Visible =
                    gv_function.Columns[3].Visible = false;
                    Dimmed();
                    Enabled();
                }
                if (Session["user_type"].ToString() == "5")
                {
                    btnsave.Visible =
                    btn_save_building_material.Visible = btn_save_function.Visible =
                    gv_building_material.Columns[4].Visible =
                    gv_building_material.Columns[3].Visible =
                    gv_function.Columns[4].Visible =
                    gv_function.Columns[3].Visible = false;
                    Dimmed();
                }

                //((administration_entry_form)this.Page).load_control();
            
        }
    }

    

    #region EventHandling
    private void set_example_label()
    {

        //if (CDataConverter.ConvertToInt(content_id.Value) > 0 && CDataConverter.ConvertToInt(content_type.Value) > 0)
        //{
        //    if (menus_update.get_current_lang() == 1)
        //        Label555.Text = content_type.Value + "_" + content_id.Value + "." + "doc/docx/pdf";
        //    else if (menus_update.get_current_lang() == 2)
        //        Label555.Text = content_type.Value + "_" + content_id.Value + "_en." + "doc/docx/pdf";
        //    else if (menus_update.get_current_lang() == 3)
        //        Label555.Text = content_type.Value + "_" + content_id.Value + "_fr." + "doc/docx/pdf";
        //}
        //else { Label555.Visible = false; }
    }
    public void log(int operation_id)
    {
        contents_log_DT clog = new contents_log_DT();
        clog.id = 0;
        clog.content_type = Convert.ToInt16(content_type.Value);
        clog.content_id = Convert.ToInt16(content_id.Value);
        clog.operation_id = operation_id;
        clog.user_id = Convert.ToInt16(Session["user_id"].ToString());
        clog.lang_id = menus_update.get_current_lang();
        clog.note_date = DateTime.Now.ToShortDateString();
        int rslut = contents_log_DB.Save(clog);
    }
    public void unvisible()
    {
       
        
        trDesc.Visible = false;
        trAddress.Visible = false;
        trFormDataCollectorName.Visible = false;
        //trFormDataEntryName.Visible = false;
        //trFormDataEntryRevisionName.Visible = false;
        trFormDataRevisionName.Visible = false;
        trArchitecture.Visible = false;
        trBrief.Visible = false;
        trCreationDate.Visible = false;
        trHighlight.Visible = false;
        trLinkWords.Visible = false;
        trName.Visible = false;
        trNotes.Visible = false;
        trDecoration.Visible = false;
        
        trEndCreationDate.Visible = false;
       
        trFormPic.Visible = false;
        trFunction.Visible = false;
        trInside.Visible = false;
        trLocation.Visible = false;
        trMainArchitecture.Visible = false;
        trMaterial.Visible = false;
       
        trOutside.Visible = false;
        trPlaceType.Visible = false;
        trPlanning.Visible = false;
        trRestoration.Visible = false;
      
        trSubFunction.Visible = false;
       
        trSave.Visible = false;
        if (menus_update.get_current_lang() != 1)
        {
            Label109.Visible = Label113.Visible = txt_current_location_longitude.Visible = Label114.Visible =
                txt_current_location_latitude.Visible =
                tblSubFunction.Visible = rbl_main_architectural_styles_type.Visible = RequiredFieldValidator6.Visible =
                RequiredFieldValidator10.Visible = RequiredFieldValidator5.Visible = RequiredFieldValidator7.Visible =
                Label64.Visible = rbl_current_function.Visible = false;
                //RequiredFieldValidator10.Visible = RequiredFieldValidator12.Visible =
                //RequiredFieldValidator13.Visible = RequiredFieldValidator14.Visible = RequiredFieldValidator15.Visible =
                //RequiredFieldValidator9.Visible = RequiredFieldValidator8.Visible = RequiredFieldValidator7.Visible =
               
         
            
        }
        
    }
    public void visable_translated_only()
    {
        if (Session["Lang"] != null && Session["Lang"].ToString() != "ar")
        {
           
            string[] arrv = new string[16];
            arrv[0] = "trName";
            arrv[1] = "trDesc";
            arrv[2] = "trSave";
            arrv[3] = "trBrief";
            arrv[4] = "trNotes";
            arrv[5] = "trLinkWords";
            arrv[6] = "trPlanning";
            arrv[7] = "trOutside";
            arrv[8] = "trInside";
            arrv[9] = "trDecoration";
            arrv[10] = "trArchitecture";
            arrv[11] = "trMainArchitecture";
            arrv[12] = "trFunction";
            arrv[13] = "trAddress";
            arrv[14] = "trRestoration";
            arrv[15] = "trLocation";



            for (int i = 0; i < 16; i++)
            {
                string x = arrv[i].ToString();
                HtmlTableRow tr = (HtmlTableRow)this.FindControl(x);
                tr.Visible = true;
                
            }
           
            foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblPlaces.Rows)
            {
                foreach (Control ctr in r.Cells)
                {
                    foreach (Control control in ctr.Controls)
                    {
                       if (control.GetType().ToString() == "System.Web.UI.WebControls.DropDownList")
                        {

                            ((DropDownList)control).Enabled = false;
                        }


                        else if (control.GetType().ToString() == "System.Web.UI.WebControls.RadioButtonList")
                        {

                            ((RadioButtonList)control).Enabled = false;
                        }
                       
                       
                    }
                }
            }
            
            
              
            
        }
    }
    public void Dimmed()
    {
        //Class1 clss = new Class1();
        //clss.Dimmed();
        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblPlaces.Rows)
        {
            foreach (Control ctr in r.Cells)
            {
                foreach (Control control in ctr.Controls)
                {
                    // foreach (Control childc in control.Controls )
                    //{
                    //    if (childc is TextBox)
                    //    {
                    // foreach(Control c2 in control.Controls)
                    //{

                    if (control.GetType().ToString() == "System.Web.UI.WebControls.TextBox")
                    {

                        ((TextBox)control).ReadOnly = true;
                    }

                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.CheckBox")
                    {

                        ((CheckBox)control).Enabled = false;
                    }

                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.DropDownList")
                    {

                        ((DropDownList)control).Enabled = false;
                    }


                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.RadioButtonList")
                    {

                        ((RadioButtonList)control).Enabled = false;
                    }
                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.CheckBoxList")
                    {

                        ((CheckBoxList)control).Enabled = false;
                    }
                    else if (control.GetType().ToString() == "System.Web.UI.WebControls.FileUpload")
                    {

                        ((FileUpload)control).Enabled = false;
                    }


                }
            }
        }
    }
        public void Enabled()
    {
        if (Session["user_type"] != null && Session["user_type"].ToString() == "4")
        {
            if (Request.QueryString["operation"].ToString() == "wrong")
            {
                SqlParameter[] sqlParamse = new SqlParameter[] {new SqlParameter ("@content_type",CDataConverter.ConvertToInt(content_type.Value)),
                new SqlParameter("@content_id",CDataConverter.ConvertToInt(content_id.Value)),
                new SqlParameter("@lang_id",CDataConverter.ConvertToInt(menus_update.get_current_lang()))};

                DataTable cont_fields = DatabaseFunctions.SelectData(sqlParamse, "contents_notes_fields_enabled");
                int i = cont_fields.Rows.Count;

                for (int x = 0; x < i; x++)
                {
                    string id = "";
                    if (cont_fields.Rows[x]["type"].ToString() == "TextBox")
                    {
                        //string id = Page.FindControl(cont_fields.Rows[x]["control_name"].ToString());
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        TextBox txtbox = (TextBox)this.FindControl(id);
                        txtbox.ReadOnly = false;
                        txtbox.ForeColor = System.Drawing.Color.Red;

                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "RadioButtonList")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        RadioButtonList rad = (RadioButtonList)this.FindControl(id);
                        rad.Enabled = true;
                        rad.ForeColor = System.Drawing.Color.Red;
                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "CheckBox")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        CheckBox chbox = (CheckBox)this.FindControl(id);
                        chbox.Enabled = true;
                        chbox.ForeColor = System.Drawing.Color.Red;
                        //chbox.Focus();

                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "DropDownList")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        DropDownList drop = (DropDownList)this.FindControl(id);
                        drop.Enabled = true;
                        drop.ForeColor = System.Drawing.Color.Red;
                        //chbox.Focus();

                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "Button")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        Button btn = (Button)this.FindControl(id);
                        if (btn != null)
                        {
                            btn.Visible = true;
                            btn.ForeColor = System.Drawing.Color.Red;
                            btn.Focus();
                            if(id=="btn_save_building_material")
                            {
                                txt_building_raw_material_notes.ReadOnly = false;
                                txt_building_raw_material_use_other.ReadOnly = false;
                                rbl_building_raw_material_use.Enabled = true;
                                rbl_building_raw_material.Enabled = true;
                                txt_building_raw_material_other.ReadOnly = false;
                                gv_building_material.Columns[4].Visible =
                                gv_building_material.Columns[3].Visible = true;
                            }
                            else if (id == "btn_save_function")
                            {
                                gv_function.Columns[4].Visible =
                                 gv_function.Columns[3].Visible = true;
                            }
                        }

                    }
                    if (cont_fields.Rows[x]["type"].ToString() == "FileUpload")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        FileUpload upfile = (FileUpload)this.FindControl(id);
                        upfile.Enabled = true;
                        //btn.ForeColor = System.Drawing.Color.Red;


                    }


                }
            }
        }

    }
        protected void rbl_place_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbl_place_type.SelectedIndex == rbl_place_type.Items.Count - 1)
            {
                txt_place_type_another.Visible = true;
                //lbl__place_type_another.Visible = true;
            }
            else
            {
                txt_place_type_another.Visible = false;
                //lbl__place_type_another.Visible = false;
            }
            check_ocordion();
        }
        protected void check_ocordion()
        {
           
           
            if (hiddintxtInputDiv33.Text == "1")
                Div33.Style.Add("display", "block");
            else
                Div33.Style.Add("display", "none");
           
          
           
        }
        protected void rbl_main_architectural_styles_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            check_ocordion();
        }
        protected void rbl_architectural_styles_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            check_ocordion();
        }
        protected void rbl_architectural_element_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            check_ocordion();
        }
        protected void rbl_building_raw_material_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            check_ocordion();
        }
        protected void rbl_building_raw_material_use_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            check_ocordion();
        }
        protected void rbl_current_function_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            check_ocordion();
        }
        protected void rbl_function_through_age_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            check_ocordion();
        }

    #endregion

    #region Fills

        public void fillGridVeiws()
    {
       
       
        SqlParameter[] sqlParams_building_material = new SqlParameter[] { new SqlParameter("@place_id", CDataConverter.ConvertToInt(content_id.Value)) };
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
                                                lbl.Text +=  rbl_building_raw_material.Items[i].Text + "- ";
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
            gv_building_material.Visible = false;
        SqlParameter[] sqlParams_function = new SqlParameter[] { new SqlParameter("@place_id", CDataConverter.ConvertToInt(content_id.Value)) };
        DataTable dt_function = new DataTable();
        dt_function = DatabaseFunctions.SelectData(sqlParams_function, "place_function_select");
        if (dt_function.Rows.Count > 0)
        {
            gv_function.Visible = true;
            gv_function.DataSource = dt_function;
            gv_function.DataBind();
        }
        else
            gv_function.Visible = false;
      
        
       
    }
        private void getData()
    {
          places_obj_to_save = places_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value));
         places_details_obj_to_save = places_details_DB.SelectByID(CDataConverter.ConvertToInt(content_id.Value), menus_update.get_current_lang());
        
    }
        public void filldata()
    {
      
       if (places_details_obj_to_save.place_id != 0)
        {

            if (places_obj_to_save.highlight == 1)
                chk_highlight.Checked = true;
            else chk_highlight.Checked = false;
            if (places_obj_to_save.highlight_panorama == 1)
                chk_pano.Checked = true;
            else chk_pano.Checked = false;
            txt_name.Text = places_details_obj_to_save.name;
            if ((CDataConverter.ConvertToInt(places_obj_to_save.place_type)) > 0)
                rbl_place_type.SelectedValue = places_obj_to_save.place_type.ToString();
            txt_place_type_another.Text = places_obj_to_save.place_type_another;
            txt_creation_hijr_date.Text = places_obj_to_save.creation_hijr_date;
            txt_creation_georg_date.Text = places_obj_to_save.creation_georg_date;
            txt_end_creation_hijr_date.Text = places_obj_to_save.end_creation_hijr_date;
            txt_end_creation_georg_date.Text = places_obj_to_save.end_creation_georg_date;
            txt_brief.Value = places_details_obj_to_save.brief;
            txt_description.Value = places_details_obj_to_save.description;
            txtNotes.Text = places_details_obj_to_save.notes;
            txtLinkWords.Text = places_details_obj_to_save.link_words;
            txt_outside_entrances.Text = places_details_obj_to_save.outside_entrances;
            txt_outside_interfaces.Text = places_details_obj_to_save.outside_interfaces;
            txt_outside_windows.Text = places_details_obj_to_save.outside_windows;
            txt_outside_minarets.Text = places_details_obj_to_save.outside_minarets;
            txt_outside_domes.Text = places_details_obj_to_save.outside_domes;
            txt_inside_yard.Text = places_details_obj_to_save.inside_yard;
            txt_inside_roofs.Text = places_details_obj_to_save.inside_roofs;
            txt_inside_iwans.Text = places_details_obj_to_save.inside_iwans;
            txt_inside_halls.Text = places_details_obj_to_save.inside_halls;
            txt_inside_seats.Text = places_details_obj_to_save.inside_seats;
            txt_inside_supplements.Text = places_details_obj_to_save.inside_supplements;
            txt_inside_sabeel_room.Text = places_details_obj_to_save.inside_sabeel_room;
            txt_literature.Text = places_details_obj_to_save.literature;
            txt_geometric.Text = places_details_obj_to_save.geometric;
            txt_floral.Text = places_details_obj_to_save.floral;
            if ((CDataConverter.ConvertToInt(places_details_obj_to_save.main_architectural_styles_type)) > 0)
                rbl_main_architectural_styles_type.SelectedValue = places_details_obj_to_save.main_architectural_styles_type.ToString();
            //txt_main_architectural_styles_type_other.Text = places_details_obj_to_select.main_architectural_styles_type_other;
            txt_main_architectural_styles_type_general_feature.Text = places_details_obj_to_save.main_architectural_styles_type_general_feature;
            txt_main_architectural_styles_type_notes.Text = places_details_obj_to_save.main_architectural_styles_type_notes;
            if ((CDataConverter.ConvertToInt(places_details_obj_to_save.current_function)) > 0)
            {
                rbl_current_function.SelectedValue = places_details_obj_to_save.current_function.ToString();
                if (rbl_current_function.SelectedValue == "19")
                    txt_current_function_other.Style.Add("display","block");
            }
            txt_current_function_other.Text = places_details_obj_to_save.current_function_other;
            txt_current_function_notes.Text = places_details_obj_to_save.current_function_notes;
            txt_current_address.Text = places_details_obj_to_save.current_address;
            txt_current_address_desc.Text = places_details_obj_to_save.current_address_desc;
            txt_current_address_notes.Text = places_details_obj_to_save.current_address_notes;
            txt_current_state.Text = places_details_obj_to_save.current_state;
            txt_restoration_current_state.Text = places_details_obj_to_save.restoration_current_state;
            txt_restoration_current_state_person.Text = places_details_obj_to_save.restoration_current_state_person;
            txt_restoration_current_state_participants.Text = places_details_obj_to_save.restoration_current_state_participants;
            txt_restoration_current_state_note.Text = places_details_obj_to_save.restoration_current_state_note;
            txt_current_location_longitude.Text = places_details_obj_to_save.current_location_longitude;
            txt_current_location_latitude.Text = places_details_obj_to_save.current_location_latitude;
            txt_current_location_desc.Text = places_details_obj_to_save.current_location_desc;
            txt_current_location_note.Text = places_details_obj_to_save.current_location_note;
            //if ((CDataConverter.ConvertToInt(places_details_obj_to_save.form_pic_state)) > 0)
            //    rbl_form_pic_state.SelectedIndex = (CDataConverter.ConvertToInt(places_details_obj_to_save.form_pic_state));
            rbl_form_pic_state.SelectedValue = places_obj_to_save.rblFormImage.ToString(); 
           txtFormDataColectorName.Text = places_details_obj_to_save.data_collector_name;
            txtFormDataRevisionName.Text = places_details_obj_to_save.data_revision_name;
            //txtFormDataEntryName.Text = places_details_obj_to_select.data_entry_name;
            //txtFormDataEntryRevisionName.Text = places_details_obj_to_select.data_entry_revision_name;
          

            if (menus_update.get_current_lang() == 1)
            {
                if (places_obj_to_save.form_file != "")
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + places_obj_to_save.form_file;
                }
                else id_href.Visible = false;

            }
            else if (menus_update.get_current_lang() == 2)
            {
                if (places_obj_to_save.form_file_en != "")
                {
                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + places_obj_to_save.form_file_en;
                }
                else id_href.Visible = false;
            }
            else if (menus_update.get_current_lang() == 3)
            {
                if (places_obj_to_save.form_file_fr != "")
                {
                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + places_obj_to_save.form_file_fr;
                }
                else id_href.Visible = false;
            }
            else id_href.Visible = false;
        }
    }
        public void fillDDLsRBts()
        {

            DataTable DT = General_Helping.GetDataTable("select id,title from periods");
           
            Obj_General_Helping.SmartBindDDL(ddl_function_age, DT, "id", "title", ".. اختر عصر ..");
            rbl_main_architectural_styles_type.DataSource=DT;
            rbl_main_architectural_styles_type.DataTextField = "title";
            rbl_main_architectural_styles_type.DataValueField = "id";
            rbl_main_architectural_styles_type.DataBind();
           
            
            
            DataTable DT1 = General_Helping.GetDataTable("select id,title_ar from places_types");
            rbl_place_type.DataSource = DT1;
            rbl_place_type.DataTextField = "title_ar";
            rbl_place_type.DataValueField = "id";
            rbl_place_type.DataBind();
           
            rbl_function_through_age.DataSource = DT1;
            rbl_function_through_age.DataTextField = "title_ar";
            rbl_function_through_age.DataValueField = "id";
            rbl_function_through_age.DataBind();
            rbl_current_function.DataSource = DT1;
            rbl_current_function.DataTextField = "title_ar";
            rbl_current_function.DataValueField = "id";
            rbl_current_function.DataBind();

           

         

            DataTable DT4 = General_Helping.GetDataTable("select id,title_ar from raw_material");
            rbl_building_raw_material.DataSource = DT4;
            rbl_building_raw_material.DataTextField = "title_ar";
            rbl_building_raw_material.DataValueField = "id";
            rbl_building_raw_material.DataBind();
            //for (int index = 0; index < rbl_building_raw_material.Items.Count; index++)
            //{
            //    ListItem item = rbl_building_raw_material.Items[index];
            //    string valueToSet = rbl_building_raw_material.Items[index].Value;
            //    item.Attributes.Add("JSvalue", valueToSet);//set client side attribute JSvalue
            //}


            DataTable DT5 = General_Helping.GetDataTable("select id,title_ar from raw_material_use");
            rbl_building_raw_material_use.DataSource = DT5;
            rbl_building_raw_material_use.DataTextField = "title_ar";
            rbl_building_raw_material_use.DataValueField = "id";
            rbl_building_raw_material_use.DataBind();
            
        }

    #endregion

    #region validate

        protected Boolean validGrids()
    {
        bool vaild = false;
        if (gv_building_material.Rows.Count > 0)
        {
            vaild = true;
        }

        return vaild;
    }
        protected Boolean vaildfile()
        {
            bool vaild = false;
            string filename = uploadfile.FileName;
            if (filename == "" && id_href.HRef != "#")
            {
                vaild = true;
                return vaild;
            }

            if (filename == "" && id_href.HRef == "#")
            {

                labfile.Visible = true;
                //labfile.ForeColor = System.Drawing.Color.Red;
                labfile.Text = "يجب إضافة ملف";
                vaild = false;
                return vaild;
            }

            else if (filename != "")
            {
                String[] FileNameDot = uploadfile.FileName.Split('.');
                if (FileNameDot.Length == 2)
                {
                    int id = CDataConverter.ConvertToInt(content_id.Value);
                    int cont_type = CDataConverter.ConvertToInt(content_type.Value);
                    string fileCode = cont_type.ToString() + "_" + id.ToString();
                    if (menus_update.get_current_lang() == 2)
                        fileCode = cont_type.ToString() + "_" + id.ToString() + "_en";
                    else if (menus_update.get_current_lang() == 3)
                        fileCode = cont_type.ToString() + "_" + id.ToString() + "_fr";
                    if (FileNameDot[1].ToString() != "doc" && FileNameDot[1].ToString() != "docx" && FileNameDot[1].ToString() != "pdf")
                    {
                        labfile.Visible = true;
                        labfile.Text = " امتداد الملف غير صحيح ";
                        vaild = false;
                        return vaild;
                    }
                    else if (FileNameDot[0].ToString() != fileCode)
                    {
                        labfile.Visible = true;
                        labfile.Text = " اسم الملف غير صحيح ";
                        vaild = false; return vaild;
                    }
                    else
                    {
                        saveFileSystem();
                        vaild = true; return vaild;
                    }
                }
                else
                {
                    labfile.Visible = true;
                    labfile.Text = " امتداد الملف غير صحيح ";
                    vaild = false; return vaild;
                }
            }
            return vaild;



        }
      
    
    #endregion

    #region Edit&Delete
        public void imgTranslate_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            
             if (((ImageButton)sender).CommandName == "building_material")
            {
                int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
                if (id > 0)
                {
                    txt_building_material_id.Visible = true;
                    txt_building_material_id.Text = id.ToString();
                    places_building_material_DT places_building_material_obj = places_building_material_DB.SelectByID(id);
                    if (CDataConverter.ConvertToInt(places_building_material_obj.building_raw_material) > 0)
                        rbl_building_raw_material.SelectedValue = places_building_material_obj.building_raw_material.ToString();

                    txt_building_raw_material_notes.Text = places_building_material_obj.building_raw_material_notes;
                }
            }
            else if (((ImageButton)sender).CommandName == "function")
            {
                int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
                if (id > 0)
                {
                    txt_function_id.Visible = true;
                    txt_function_id.Text = id.ToString();
                    places_function_DT places_function_obj = places_function_DB.SelectByID(id);
                    ddl_function_age.SelectedValue = places_function_obj.function_age.ToString();
                    if (CDataConverter.ConvertToInt(places_function_obj.function_through_age) > 0)
                        rbl_function_through_age.SelectedValue = places_function_obj.function_through_age.ToString();
                    txt_fun_through_age_other.Text = places_function_obj.function_through_age_other;
                    txt_function_note.Text = places_function_obj.function_note;
                }
            }
           
          
            check_ocordion();
        }
        public void imgEdit_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        
        
         if (((ImageButton)sender).CommandName == "building_material")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                btn_save_building_material.Text = "تعديل خامة بناء";
                txt_building_material_id.Visible = true;
                txt_building_material_id.Text = id.ToString();
                places_building_material_DT places_building_material_obj = places_building_material_DB.SelectByID(id);
                //if (CDataConverter.ConvertToInt(places_building_material_obj.building_raw_material) > 0)
                //    rbl_building_raw_material.SelectedValue = places_building_material_obj.building_raw_material.ToString();

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
                                        rbl_building_raw_material.Items[i].Selected = true;
                                    }
                                }
                            }
                        }
                    }
                    if (temp.Length > 1)
                    {
                        if (temp[1] != "")
                        {
                            txt_building_raw_material_other.Text = temp[1].ToString();
                        }
                    }

                }

                rbl_building_raw_material_use.SelectedValue = places_building_material_obj.building_raw_material_use.ToString();
                if (places_building_material_obj.building_raw_material_use_other!=null)
                txt_building_raw_material_use_other.Text = places_building_material_obj.building_raw_material_use_other.ToString();
                txt_building_raw_material_notes.Text = places_building_material_obj.building_raw_material_notes;
            }
        }
        else if (((ImageButton)sender).CommandName == "function")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                txt_function_id.Visible = true;
                txt_function_id.Text = id.ToString();
                places_function_DT places_function_obj = places_function_DB.SelectByID(id);
                ddl_function_age.SelectedValue = places_function_obj.function_age.ToString();
                if (CDataConverter.ConvertToInt(places_function_obj.function_through_age) > 0)
                    rbl_function_through_age.SelectedValue = places_function_obj.function_through_age.ToString();
                txt_fun_through_age_other.Text = places_function_obj.function_through_age_other;
                txt_function_note.Text = places_function_obj.function_note;
                btn_save_function.Text = "عدل وظيفة";
            }
        }
       
       
      
        check_ocordion();
    }
        public void imgDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            if (((ImageButton)sender).CommandName == "names")
            {
                int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
                if (id > 0)
                {
                    places_names_DB.Delete(id);
                    log(17);
                    fillGridVeiws();
                }
            }
            else if (((ImageButton)sender).CommandName == "architectural_styles")
            {
                int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
                if (id > 0)
                {
                    places_architecture_style_DB.Delete(id);
                    log(18);
                    fillGridVeiws();
                }
            }
            else if (((ImageButton)sender).CommandName == "building_material")
            {
                int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
                if (id > 0)
                {
                    places_building_material_DB.Delete(id);
                    log(19);
                    fillGridVeiws();
                    if(gv_building_material.Visible==false)
                    txt_building_material_validating = null;
                }
            }
            else if (((ImageButton)sender).CommandName == "function")
            {
                int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
                if (id > 0)
                {
                    places_function_DB.Delete(id);
                    log(20);
                    fillGridVeiws();
                }
            }
            else if (((ImageButton)sender).CommandName == "address")
            {
                int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
                if (id > 0)
                {
                    places_address_DB.Delete(id);
                    log(21);
                    fillGridVeiws();
                }
            }
            else if (((ImageButton)sender).CommandName == "evolution")
            {
                int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
                if (id > 0)
                {
                    places_evolution_DB.Delete(id);
                    log(22);
                    fillGridVeiws();
                }
            }
            else if (((ImageButton)sender).CommandName == "restoration")
            {
                int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
                if (id > 0)
                {
                    places_restoration_DB.Delete(id);
                    log(23);
                    fillGridVeiws();
                }
            }
            check_ocordion();
        }

    #endregion

    #region Save

     
      
        public void btn_save_building_material_click(object sender, EventArgs e)
        {
            places_building_material_DT places_building_material_obj_to_save = places_building_material_DB.SelectByID(CDataConverter.ConvertToInt(txt_building_material_id.Text));
            places_building_material_obj_to_save.id = CDataConverter.ConvertToInt(places_building_material_obj_to_save.id);
            places_building_material_obj_to_save.place_id = CDataConverter.ConvertToInt(content_id.Value);
            //if (CDataConverter.ConvertToInt(rbl_building_raw_material.SelectedValue) > 0)
            //    places_building_material_obj_to_save.building_raw_material = CDataConverter.ConvertToInt(rbl_building_raw_material.SelectedValue);


            string materials = "";
            for (int i = 0; i < rbl_building_raw_material.Items.Count; i++)
            {
                if (rbl_building_raw_material.Items[i].Selected == true)
                {
                    if (rbl_building_raw_material.Items[i].Value != "10")
                    {
                            materials += rbl_building_raw_material.Items[i].Value +"," ;
                        
                    }
                    else
                        materials += rbl_building_raw_material.Items[i].Value + "-";
                }
            }
            if (txt_building_raw_material_other != null)
            {
                if (txt_building_raw_material_other.Text != "")
                {
                    materials += txt_building_raw_material_other.Text;
                }
            }
            if (materials != "")
            {

                places_building_material_obj_to_save.building_raw_material_other = materials;
                
            }

            if (CDataConverter.ConvertToInt(rbl_building_raw_material_use.SelectedValue) > 0)
                places_building_material_obj_to_save.building_raw_material_use=CDataConverter.ConvertToInt(rbl_building_raw_material_use.SelectedValue);
            if (txt_building_raw_material_use_other!=null)
            places_building_material_obj_to_save.building_raw_material_use_other = txt_building_raw_material_use_other.Text;
            places_building_material_obj_to_save.building_raw_material_notes=txt_building_raw_material_notes.Text ;
            places_building_material_DB.Save(places_building_material_obj_to_save);
           
            log(26);
            txt_building_material_id.Text = "0";
            txt_building_material_id.Visible = false;
            rbl_building_raw_material.SelectedIndex = rbl_building_raw_material_use.SelectedIndex = -1;
            txt_building_raw_material_notes.Text = "";
            //Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم حفظ بيانات الإستمارة بنجاح')</script>");
            fillGridVeiws();
            check_ocordion();
            btn_save_building_material.Text = "أضف خامة بناء";
        }
        public void btn_save_function_click(object sender, EventArgs e)
        {
            places_function_DT places_function_obj_to_save = places_function_DB.SelectByID(CDataConverter.ConvertToInt(txt_function_id.Text));
            places_function_obj_to_save.id = CDataConverter.ConvertToInt(places_function_obj_to_save.id);
            places_function_obj_to_save.place_id = CDataConverter.ConvertToInt(content_id.Value);
            places_function_obj_to_save.function_age=CDataConverter.ConvertToInt(ddl_function_age.SelectedValue);
            if (CDataConverter.ConvertToInt(rbl_function_through_age.SelectedValue) > 0)
                places_function_obj_to_save.function_through_age=CDataConverter.ConvertToInt(rbl_function_through_age.SelectedValue) ;
            places_function_obj_to_save.function_through_age_other = txt_fun_through_age_other.Text;
            places_function_obj_to_save.function_note=txt_function_note.Text ;
            places_function_DB.Save(places_function_obj_to_save);
            log(27);
            txt_function_id.Text = "0";
            txt_function_id.Visible = false;
            ddl_function_age.SelectedIndex = rbl_function_through_age.SelectedIndex = -1;
            txt_function_note.Text = "";
            //Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم حفظ بيانات الإستمارة بنجاح')</script>");
            fillGridVeiws();
            check_ocordion();
            btn_save_function.Text = "أضف وظيفة";
        }
    
      
     
        public void btnsave_Click(object sender, EventArgs e)
        {
            if (validGrids() == false && menus_update.get_current_lang() == 1 )
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('يجب إدخال خامات البناء في الأثر أو المبنى ')</script>");
                return;
            }
            if (txt_brief.Value == "" || txt_description.Value == "")
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('يجب إدخال الوصف التفصيلى والوصف المختصر ')</script>");
                return;
            }
            getData();
            places_obj_to_save.id = Convert.ToInt16(content_id.Value);
            places_obj_to_save.highlight = CDataConverter.ConvertToInt(chk_highlight.Checked);
            places_obj_to_save.highlight_panorama = CDataConverter.ConvertToInt(chk_pano.Checked);
           // if (security_issues.check_date(txt_creation_georg_date.Text))
            places_obj_to_save.creation_georg_date = txt_creation_georg_date.Text;
            //if (security_issues.check_date(txt_creation_hijr_date.Text))
            places_obj_to_save.creation_hijr_date = txt_creation_hijr_date.Text;
           // if (security_issues.check_date(txt_end_creation_georg_date.Text))
            places_obj_to_save.end_creation_georg_date = txt_end_creation_georg_date.Text;
           // if (security_issues.check_date(txt_end_creation_hijr_date.Text))
            places_obj_to_save.end_creation_hijr_date = txt_end_creation_hijr_date.Text;
            if (CDataConverter.ConvertToInt(rbl_place_type.SelectedValue) > 0)
                places_obj_to_save.place_type = CDataConverter.ConvertToInt(rbl_place_type.SelectedValue);
            if (txt_place_type_another!=null)
            places_obj_to_save.place_type_another = txt_place_type_another.Text;
            places_obj_to_save.rblFormImage = CDataConverter.ConvertToInt(rbl_form_pic_state.SelectedValue);
            if (vaildfile())
            {
                if (places_obj_to_save.form_file != "" && menus_update.get_current_lang() == 1)
                {
                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + places_obj_to_save.form_file;
                }
                else if (places_obj_to_save.form_file_en != "" && menus_update.get_current_lang() == 2)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + places_obj_to_save.form_file_en;
                }
                else if (places_obj_to_save.form_file_fr != "" && menus_update.get_current_lang() == 3)
                {

                    id_href.Visible = true;
                    id_href.HRef = "~/upload/forms/" + places_obj_to_save.form_file_fr;
                }
               
            }
            else if (id_href.HRef == "#")
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('يجب إدخال ملف إستمارة الاثر المعمارى ')</script>");
                return;
            }
            places_DB.Save(places_obj_to_save);

            places_details_obj_to_save.place_id = Convert.ToInt16(content_id.Value);

            places_details_obj_to_save.name = txt_name.Text;
            places_details_obj_to_save.brief = txt_brief.Value;
            places_details_obj_to_save.description = txt_description.Value;
            places_details_obj_to_save.notes = txtNotes.Text;
            places_details_obj_to_save.link_words = txtLinkWords.Text;
            places_details_obj_to_save.outside_entrances = txt_outside_entrances.Text;
            places_details_obj_to_save.outside_interfaces = txt_outside_interfaces.Text;
            places_details_obj_to_save.outside_windows = txt_outside_windows.Text;
            places_details_obj_to_save.outside_minarets = txt_outside_minarets.Text;
            places_details_obj_to_save.outside_domes = txt_outside_domes.Text;
            places_details_obj_to_save.inside_yard = txt_inside_yard.Text;
            places_details_obj_to_save.inside_roofs = txt_inside_roofs.Text;
            places_details_obj_to_save.inside_iwans = txt_inside_iwans.Text;
            places_details_obj_to_save.inside_halls = txt_inside_halls.Text;
            places_details_obj_to_save.inside_seats = txt_inside_seats.Text;
            places_details_obj_to_save.inside_supplements = txt_inside_supplements.Text;
            places_details_obj_to_save.inside_sabeel_room = txt_inside_sabeel_room.Text;
            places_details_obj_to_save.literature = txt_literature.Text;
            places_details_obj_to_save.geometric = txt_geometric.Text;
            places_details_obj_to_save.floral = txt_floral.Text;
            if ((CDataConverter.ConvertToInt(rbl_main_architectural_styles_type.SelectedValue)) > 0)
                places_details_obj_to_save.main_architectural_styles_type = CDataConverter.ConvertToInt(rbl_main_architectural_styles_type.SelectedValue);
            
            places_details_obj_to_save.main_architectural_styles_type_general_feature = txt_main_architectural_styles_type_general_feature.Text;
            places_details_obj_to_save.main_architectural_styles_type_notes = txt_main_architectural_styles_type_notes.Text;
            if ((CDataConverter.ConvertToInt(rbl_current_function.SelectedValue)) > 0)
                places_details_obj_to_save.current_function = CDataConverter.ConvertToInt(rbl_current_function.SelectedValue);
            places_details_obj_to_save.current_function_other = txt_current_function_other.Text;
            places_details_obj_to_save.current_function_notes = txt_current_function_notes.Text;
            places_details_obj_to_save.current_address = txt_current_address.Text;
            places_details_obj_to_save.current_address_desc = txt_current_address_desc.Text;
            places_details_obj_to_save.current_address_notes = txt_current_address_notes.Text;
            places_details_obj_to_save.current_state = txt_current_state.Text;
            places_details_obj_to_save.restoration_current_state = txt_restoration_current_state.Text;
            places_details_obj_to_save.restoration_current_state_person = txt_restoration_current_state_person.Text;
            places_details_obj_to_save.restoration_current_state_participants = txt_restoration_current_state_participants.Text;
            places_details_obj_to_save.restoration_current_state_note = txt_restoration_current_state_note.Text;
            places_details_obj_to_save.current_location_longitude = txt_current_location_longitude.Text;
            places_details_obj_to_save.current_location_latitude = txt_current_location_latitude.Text;
            places_details_obj_to_save.current_location_desc = txt_current_location_desc.Text;
            places_details_obj_to_save.current_location_note = txt_current_location_note.Text;
            //if ((CDataConverter.ConvertToInt(rbl_form_pic_state.SelectedIndex)) > 0)
            //    places_details_obj_to_save.form_pic_state = CDataConverter.ConvertToInt(rbl_form_pic_state.SelectedIndex);
            places_details_obj_to_save.data_collector_name = txtFormDataColectorName.Text;
            places_details_obj_to_save.data_revision_name = txtFormDataRevisionName.Text;
            //places_details_obj_to_save.data_entry_name = txtFormDataEntryName.Text;
            //places_details_obj_to_save.data_entry_revision_name = txtFormDataEntryRevisionName.Text;
            places_details_obj_to_save.lang_id = menus_update.get_current_lang();
            
            
            places_details_DB.Save(places_details_obj_to_save);
            log(2);
            ShowAlertMessage("تم حفظ بيانات الإستمارة بنجاح");
            check_ocordion();
        }
        public static void ShowAlertMessage(string error)
        {

            Page page = HttpContext.Current.Handler as Page;
            if (page != null)
            {
                error = error.Replace("'", "\'");
                ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + error + "');", true);
            }
        }
      
        protected void saveFileSystem()
        {

            string savePath = MapPath("~") + "\\upload\\forms\\";

            string fileName = uploadfile.FileName;
            savePath += fileName;
            uploadfile.SaveAs(savePath);
            if (menus_update.get_current_lang() == 1)
                places_obj_to_save.form_file = fileName;
            else if (menus_update.get_current_lang() == 2)
                places_obj_to_save.form_file_en = fileName;
            else if (menus_update.get_current_lang() == 3)
                places_obj_to_save.form_file_fr = fileName;



        }
    
    #endregion




       
}
