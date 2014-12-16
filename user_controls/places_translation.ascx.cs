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

public partial class user_controls_places_translation : System.Web.UI.UserControl
{
    General_Helping Obj_General_Helping = new General_Helping();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_type"] != null)
        {

            //TextBox tx = base.Controls[7].Page.Controls[7] as TextBox;
            //DropDownList myDropDown = mainPage.MyDropDown;
            // TextBox tx = (TextBox)mainPage.FindControl("HiddenPostback");

            //if (tx.Text == ""){
            
            if (!IsPostBack)
            {
                fillDDLsRBts();

               }
         
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {

              
                Enabled();
                
                
            }
            
           
           
        }
    }

    #region EventHandling
 
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


     btn_save_names_translated1.Visible=
         btn_save_names.Visible =
         txt_name_note.Visible =
         Label3.Visible =
         txt_name_in_age.Visible =
         Label2.Visible =
         ddl_name_age.Visible =
         lblages.Visible =
         Label55.Visible =
         rbl_architectural_styles_type.Visible =
         Label54.Visible =
         rbl_architectural_element.Visible =
         Label52.Visible =
         txt_architectural_styles_type_general_feature.Visible =
         Label53.Visible =
         txt_architectural_styles_type_notes.Visible =
         btn_save_style.Visible =
         btn_save_style_translate.Visible =
         Label77.Visible =
         Label81.Visible =
          txt_address_age_desc.Visible =
           Label80.Visible =
            txt_address_age_note.Visible =
             btn_save_address.Visible =
              btn_save_address_translate.Visible =
               Label79.Visible =
                ddl_architectural_evolution_age.Visible =
                 Label88.Visible =
                  Label84.Visible =
                  txt_architectural_evolution_hijri_date.Visible =
                  Label86.Visible =
                  txt_architectural_evolution_georg_date.Visible =
                  Label89.Visible =
                  txt_architectural_evolution_person.Visible =
                  Label82.Visible =
                  txt_architectural_evolution_desc.Visible =
                  Label83.Visible =
                  txt_architectural_evolution_note.Visible =
                  btn_save_evolution.Visible =
                  btn_save_evolution_translate.Visible =
                  Label82.Visible =
                  ddl_address_age.Visible =
                Label97.Visible = ddl_restoration_age.Visible = Label98.Visible =
                    Label99.Visible = txt_restoration_hijri_date.Visible =
                    Label101.Visible = txt_restoration_georg_date.Visible =
                    Label103.Visible = txt_restoration_person.Visible =
                        Label104.Visible = txt_restoration_participants.Visible =
                        Label106.Visible = txt_restoration_desc.Visible =
                            Label105.Visible = txt_restoration_note.Visible =
                     btn_save_restoration.Visible = btn_save_restoration_translate.Visible =
                     gv_names.Columns[7].Visible = gv_names.Columns[6].Visible = gv_names.Columns[5].Visible =
                     gv_architectural_styles.Columns[8].Visible = gv_architectural_styles.Columns[7].Visible = gv_architectural_styles.Columns[6].Visible =
                     gv_address.Columns[7].Visible = gv_address.Columns[6].Visible = gv_address.Columns[5].Visible =
                     gv_evolution.Columns[12].Visible = gv_evolution.Columns[11].Visible = gv_evolution.Columns[10].Visible =
                     gv_restoration.Columns[11].Visible = gv_restoration.Columns[10].Visible = gv_restoration.Columns[9].Visible =
                  false;
       

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
              new SqlParameter("@lang_id",menus_update.get_current_lang())};

                DataTable cont_fields = DatabaseFunctions.SelectData(sqlParamse, "contents_notes_fields_enabled");
                int i = cont_fields.Rows.Count;

                for (int x = 0; x < i; x++)
                {
                    string id = "";

                    if (cont_fields.Rows[x]["type"].ToString() == "Button")
                    {
                        id = cont_fields.Rows[x]["control_name"].ToString();
                        Button btn = (Button)this.FindControl(id);
                        if (btn != null)
                        {
                            btn.Visible = true;
                            btn.ForeColor = System.Drawing.Color.Red;
                            btn.Focus();
                        }

                    }
                }
            }
        }
    }
  
    protected void check_ocordion()
    {
        if (hiddintxtInputDiv11.Text == "1")
            Div11.Style.Add("display", "block");
        else
            Div11.Style.Add("display", "none");
        if (hiddintxtInputDiv22.Text == "1")
            Div22.Style.Add("display", "block");
        else
            Div22.Style.Add("display", "none");
      
        if (hiddintxtInputDiv44.Text == "1")
            Div44.Style.Add("display", "block");
        else
            Div44.Style.Add("display", "none");
        if (hiddintxtInputDiv55.Text == "1")
            Div55.Style.Add("display", "block");
        else
            Div55.Style.Add("display", "none");
        if (hiddintxtInputDiv66.Text == "1")
            Div66.Style.Add("display", "block");
        else
            Div66.Style.Add("display", "none");
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
        SqlParameter[] sqlParams_names = new SqlParameter[] { new SqlParameter("@place_id", CDataConverter.ConvertToInt(content_id.Value)) };
        DataTable dt_names = new DataTable();
        dt_names = DatabaseFunctions.SelectData(sqlParams_names, "place_names_select");
        if (dt_names.Rows.Count > 0)
        {
            tblOtherName.Visible = true;
            gv_names.Visible = true;
            gv_names.DataSource = dt_names;
            gv_names.DataBind();
            if (menus_update.get_current_lang() == 1)
            {
                gv_names.Columns[5].Visible =
                gv_names.Columns[2].Visible = gv_names.Columns[1].Visible = false;
            }
            if (menus_update.get_current_lang() == 2)
            {
               
                lblages.Visible = ddl_name_age.Visible = Label2.Visible =
               txt_name_in_age.Visible = Label3.Visible = txt_name_note.Visible =
                    gv_names.Columns[7].Visible = gv_names.Columns[6].Visible = 
                    gv_names.Columns[4].Visible = gv_names.Columns[3].Visible = gv_names.Columns[2].Visible =
                    RequiredFieldValidator1.Visible = RequiredFieldValidator18.Visible = btn_save_names.Visible = false;
            }
            if (menus_update.get_current_lang() == 3)
            {
               
                lblages.Visible = ddl_name_age.Visible = Label2.Visible =
              txt_name_in_age.Visible = Label3.Visible = txt_name_note.Visible =
                gv_names.Columns[7].Visible = gv_names.Columns[6].Visible = 
                gv_names.Columns[4].Visible = gv_names.Columns[3].Visible = gv_names.Columns[1].Visible =
                RequiredFieldValidator1.Visible = RequiredFieldValidator18.Visible = btn_save_names.Visible = false;
            }

        }
        //else
        //    tblOtherName.Visible = false;
        SqlParameter[] sqlParams_architecture_style = new SqlParameter[] { new SqlParameter("@place_id", CDataConverter.ConvertToInt(content_id.Value)) };
        DataTable dt_architecture_style = new DataTable();
        dt_architecture_style = DatabaseFunctions.SelectData(sqlParams_architecture_style, "place_architecture_style_select");
        if (dt_architecture_style.Rows.Count > 0)
        {
            tblSubArchitecture.Visible = true;
            gv_architectural_styles.Visible = true;
            gv_architectural_styles.DataSource = dt_architecture_style;
            gv_architectural_styles.DataBind();

            if (menus_update.get_current_lang() == 1)
            {
                gv_architectural_styles.Columns[6].Visible =
                gv_architectural_styles.Columns[2].Visible = gv_architectural_styles.Columns[1].Visible = false;
            }
            if (menus_update.get_current_lang() == 2)
            {
                Label55.Visible = rbl_architectural_styles_type.Visible = Label54.Visible = rbl_architectural_element.Visible =
                Label52.Visible = txt_architectural_styles_type_general_feature.Visible =
            Label53.Visible = txt_architectural_styles_type_notes.Visible =
                    gv_architectural_styles.Columns[8].Visible = gv_architectural_styles.Columns[7].Visible =
                    gv_architectural_styles.Columns[5].Visible = gv_architectural_styles.Columns[4].Visible =
                    gv_architectural_styles.Columns[3].Visible = gv_architectural_styles.Columns[2].Visible =
                    RequiredFieldValidator1.Visible = RequiredFieldValidator18.Visible = btn_save_style.Visible = false;
            }
            if (menus_update.get_current_lang() == 3)
            {
                Label55.Visible = rbl_architectural_styles_type.Visible = Label54.Visible = rbl_architectural_element.Visible =
               Label52.Visible = txt_architectural_styles_type_general_feature.Visible =
           Label53.Visible = txt_architectural_styles_type_notes.Visible =
                gv_architectural_styles.Columns[8].Visible = gv_architectural_styles.Columns[7].Visible =
                gv_architectural_styles.Columns[5].Visible = gv_architectural_styles.Columns[4].Visible =
                gv_architectural_styles.Columns[3].Visible = gv_architectural_styles.Columns[1].Visible =
                RequiredFieldValidator22.Visible = RequiredFieldValidator23.Visible = btn_save_style.Visible = false;
            }




        }
        //else
        //    tblSubArchitecture.Visible = false;
      
        SqlParameter[] sqlParams_address = new SqlParameter[] { new SqlParameter("@place_id", CDataConverter.ConvertToInt(content_id.Value)) };
        DataTable dt_address = new DataTable();
        dt_address = DatabaseFunctions.SelectData(sqlParams_address, "place_address_select");
        if (dt_address.Rows.Count > 0)
        {
            tblSubAddress.Visible = true;
            gv_address.Visible = true;
            gv_address.DataSource = dt_address;
            gv_address.DataBind();

            if (menus_update.get_current_lang() == 1)
            {
                gv_address.Columns[5].Visible =
               gv_address.Columns[2].Visible = gv_address.Columns[1].Visible = false;
            }
            if (menus_update.get_current_lang() == 2)
            {
                Label77.Visible = ddl_address_age.Visible = Label81.Visible =
                    txt_address_age_desc.Visible = Label80.Visible =
                    txt_address_age_note.Visible = btn_save_address.Visible =
                     gv_address.Columns[7].Visible = gv_address.Columns[6].Visible =
                     gv_address.Columns[4].Visible = gv_address.Columns[3].Visible = gv_address.Columns[2].Visible =
                     RequiredFieldValidator1.Visible = RequiredFieldValidator18.Visible = false;
            }
            if (menus_update.get_current_lang() == 3)
            {
                Label77.Visible = ddl_address_age.Visible = Label81.Visible =
                   txt_address_age_desc.Visible = Label80.Visible =
                   txt_address_age_note.Visible = btn_save_address.Visible =
                   gv_address.Columns[7].Visible = gv_address.Columns[6].Visible =
                    gv_address.Columns[4].Visible = gv_address.Columns[3].Visible = gv_address.Columns[1].Visible =
                    RequiredFieldValidator1.Visible = RequiredFieldValidator18.Visible = false;
            }

        }
        //else
        //    tblSubAddress.Visible = false;
        SqlParameter[] sqlParams_evolution = new SqlParameter[] { new SqlParameter("@place_id", CDataConverter.ConvertToInt(content_id.Value)) };
        DataTable dt_evolution = new DataTable();
        dt_evolution = DatabaseFunctions.SelectData(sqlParams_evolution, "place_evolution_select");
        if (dt_evolution.Rows.Count > 0)
        {
            tblEvolution.Visible = true;
            gv_evolution.Visible = true;
            gv_evolution.DataSource = dt_evolution;
            gv_evolution.DataBind();

            if (menus_update.get_current_lang() == 1)
            {
                gv_evolution.Columns[10].Visible =
                gv_evolution.Columns[8].Visible = gv_evolution.Columns[7].Visible =
                     gv_evolution.Columns[5].Visible = gv_evolution.Columns[4].Visible = false;

            }
            if (menus_update.get_current_lang() == 2)
            {
                Label79.Visible = ddl_architectural_evolution_age.Visible = Label88.Visible =
                    Label84.Visible = txt_architectural_evolution_hijri_date.Visible =
                    Label86.Visible = txt_architectural_evolution_georg_date.Visible =
                    Label89.Visible = txt_architectural_evolution_person.Visible =
                        Label82.Visible = txt_architectural_evolution_desc.Visible =
                        Label83.Visible = txt_architectural_evolution_note.Visible =
                      btn_save_evolution.Visible =
                       gv_evolution.Columns[12].Visible = gv_evolution.Columns[11].Visible =
                     gv_evolution.Columns[9].Visible = gv_evolution.Columns[8].Visible =
                   gv_evolution.Columns[5].Visible = gv_evolution.Columns[2].Visible =
                     gv_evolution.Columns[1].Visible = gv_evolution.Columns[0].Visible =
                      RequiredFieldValidator28.Visible = false;
            }
            if (menus_update.get_current_lang() == 3)
            {
                Label79.Visible = ddl_architectural_evolution_age.Visible = Label88.Visible =
                  Label84.Visible = txt_architectural_evolution_hijri_date.Visible =
                  Label86.Visible = txt_architectural_evolution_georg_date.Visible =
                  Label89.Visible = txt_architectural_evolution_person.Visible =
                      Label82.Visible = txt_architectural_evolution_desc.Visible =
                      Label83.Visible = txt_architectural_evolution_note.Visible =
                    btn_save_evolution.Visible =
                   gv_evolution.Columns[12].Visible = gv_evolution.Columns[11].Visible =
                   gv_evolution.Columns[9].Visible = gv_evolution.Columns[7].Visible =
                    gv_evolution.Columns[4].Visible = gv_evolution.Columns[2].Visible =
                  gv_evolution.Columns[1].Visible = gv_evolution.Columns[0].Visible =
                    RequiredFieldValidator28.Visible = false;
            }


        }
        //else
        //    tblEvolution.Visible = false;
        SqlParameter[] sqlParams_restoration = new SqlParameter[] { new SqlParameter("@place_id", CDataConverter.ConvertToInt(content_id.Value)) };
        DataTable dt_restoration = new DataTable();
        dt_restoration = DatabaseFunctions.SelectData(sqlParams_restoration, "place_restoration_select");
        if (dt_restoration.Rows.Count > 0)
        {
            tblSubRestoration.Visible = true;
            gv_restoration.Visible = true;
            gv_restoration.DataSource = dt_restoration;
            gv_restoration.DataBind();

            if (menus_update.get_current_lang() == 1)
            {
                gv_restoration.Columns[9].Visible =
                gv_restoration.Columns[8].Visible = gv_restoration.Columns[7].Visible =
                     gv_restoration.Columns[5].Visible = gv_restoration.Columns[4].Visible = false;

            }
            if (menus_update.get_current_lang() == 2)
            {
                Label97.Visible = ddl_restoration_age.Visible = Label98.Visible =
                    Label99.Visible = txt_restoration_hijri_date.Visible =
                    Label101.Visible = txt_restoration_georg_date.Visible =
                    Label103.Visible = txt_restoration_person.Visible =
                        Label104.Visible = txt_restoration_participants.Visible =
                        Label106.Visible = txt_restoration_desc.Visible =
                            Label105.Visible = txt_restoration_note.Visible =
                     btn_save_restoration.Visible =
                    gv_restoration.Columns[11].Visible = gv_restoration.Columns[10].Visible =
                    gv_restoration.Columns[8].Visible =
                     gv_restoration.Columns[5].Visible = gv_restoration.Columns[2].Visible =
                   gv_restoration.Columns[1].Visible = gv_restoration.Columns[0].Visible =
                      RequiredFieldValidator19.Visible = false;
            }
            if (menus_update.get_current_lang() == 3)
            {
                Label97.Visible = ddl_restoration_age.Visible = Label98.Visible =
                    Label99.Visible = txt_restoration_hijri_date.Visible =
                    Label101.Visible = txt_restoration_georg_date.Visible =
                    Label103.Visible = txt_restoration_person.Visible =
                        Label104.Visible = txt_restoration_participants.Visible =
                        Label106.Visible = txt_restoration_desc.Visible =
                            Label105.Visible = txt_restoration_note.Visible =
                     btn_save_restoration.Visible =
                    gv_restoration.Columns[11].Visible = gv_restoration.Columns[10].Visible =
                  gv_restoration.Columns[7].Visible =
                     gv_restoration.Columns[4].Visible = gv_restoration.Columns[2].Visible =
                   gv_restoration.Columns[1].Visible = gv_restoration.Columns[0].Visible =
                      RequiredFieldValidator19.Visible = false;
            }

        }
        //else
        //    tblSubRestoration.Visible = false;
    }
  
   
    public void fillDDLsRBts()
    {

        DataTable DT = General_Helping.GetDataTable("select id,title from periods");
        Obj_General_Helping.SmartBindDDL(ddl_name_age, DT, "id", "title", ".. اختر عصر ..");
        
        Obj_General_Helping.SmartBindDDL(ddl_address_age, DT, "id", "title", ".. اختر عصر ..");
        Obj_General_Helping.SmartBindDDL(ddl_architectural_evolution_age, DT, "id", "title", ".. اختر عصر ..");
        Obj_General_Helping.SmartBindDDL(ddl_restoration_age, DT, "id", "title", ".. اختر عصر ..");






        DataTable DT2 = General_Helping.GetDataTable("select id,title from periods");
        rbl_architectural_styles_type.DataSource = DT2;
        rbl_architectural_styles_type.DataTextField = "title";
        rbl_architectural_styles_type.DataValueField = "id";
        rbl_architectural_styles_type.DataBind();


        DataTable DT3 = General_Helping.GetDataTable("select id,title_ar from architechture_elemnts");
        rbl_architectural_element.DataSource = DT3;
        rbl_architectural_element.DataTextField = "title_ar";
        rbl_architectural_element.DataValueField = "id";
        rbl_architectural_element.DataBind();

      

    }

    #endregion

  

    #region Edit&Delete
    public void imgTranslate_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        if (((ImageButton)sender).CommandName == "names")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {


                //ViewState["hf_names"] = id.ToString()        

                txt_name_id.Visible = true;
                txt_name_id.Text = id.ToString();

                places_names_DT places_names_obj = places_names_DB.SelectByID(id);
                ddl_name_age.SelectedValue = places_names_obj.name_age.ToString();
                txt_name_in_age.Text = places_names_obj.name_in_age;
                txt_name_note.Text = places_names_obj.name_note;
                if (menus_update.get_current_lang() == 2)
                {
                    Label2.Visible =btn_save_names_translated1.Visible=
                      txt_name_in_age.Visible  = true;
                    txt_name_in_age.Text = places_names_obj.name_age_en;
                }
                if (menus_update.get_current_lang() == 3)
                {

                    btn_save_names_translated1.Visible = Label2.Visible = txt_name_in_age.Visible = true;
                    txt_name_in_age.Text = places_names_obj.name_age_fr;
                }

            }
        }
        else if (((ImageButton)sender).CommandName == "architectural_styles")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                txt_architectural_styles_id.Visible = true;
                txt_architectural_styles_id.Text = id.ToString();
                places_architecture_style_DT places_architecture_style_obj = places_architecture_style_DB.SelectByID(id);
                architechture_elemnts_DT architechture_elemnts_obj = architechture_elemnts_DB.SelectByID(id);
                if (CDataConverter.ConvertToInt(places_architecture_style_obj.architectural_styles_type) > 0)
                    rbl_architectural_styles_type.SelectedValue = places_architecture_style_obj.architectural_styles_type.ToString();
                if (CDataConverter.ConvertToInt(places_architecture_style_obj.architectural_element) > 0)
                    rbl_architectural_element.SelectedValue = places_architecture_style_obj.architectural_element.ToString();


                txt_architectural_styles_type_general_feature.Text = places_architecture_style_obj.architectural_styles_type_general_feature;
                if (menus_update.get_current_lang() == 2)
                {

                    Label52.Visible = txt_architectural_styles_type_general_feature.Visible = btn_save_style_translate.Visible = true;
                    txt_architectural_styles_type_general_feature.Text = places_architecture_style_obj.architectural_styles_type_general_feature_en;
                }
                if (menus_update.get_current_lang() == 3)
                {

                    Label52.Visible = txt_architectural_styles_type_general_feature.Visible = btn_save_style_translate.Visible = true;
                    txt_architectural_styles_type_general_feature.Text = places_architecture_style_obj.architectural_styles_type_general_feature_fr;
                }
                txt_architectural_styles_type_notes.Text = places_architecture_style_obj.architectural_styles_type_notes;
            }
        }
      
      
        else if (((ImageButton)sender).CommandName == "address")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                txt_address_id.Visible = true;
                txt_address_id.Text = id.ToString();
                places_address_DT places_address_obj = places_address_DB.SelectByID(id);
                ddl_address_age.SelectedValue = places_address_obj.address_age.ToString();
                txt_address_age_desc.Text = places_address_obj.address_age_desc;
                txt_address_age_note.Text = places_address_obj.address_age_note;

                if (menus_update.get_current_lang() == 2)
                {

                    Label81.Visible = txt_address_age_desc.Visible = btn_save_address_translate.Visible = true;
                    txt_address_age_desc.Text = places_address_obj.address_age_desc_en;
                }
                if (menus_update.get_current_lang() == 3)
                {

                    Label81.Visible = txt_address_age_desc.Visible = btn_save_address_translate.Visible = true;
                    txt_address_age_desc.Text = places_address_obj.address_age_desc_fr;
                }
            }
        }
        else if (((ImageButton)sender).CommandName == "evolution")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                txt_evolution_id.Visible = true;
                txt_evolution_id.Text = id.ToString();
                places_evolution_DT places_evolution_obj = places_evolution_DB.SelectByID(id);
                ddl_architectural_evolution_age.SelectedValue = places_evolution_obj.architectural_evolution_age.ToString();
                txt_architectural_evolution_hijri_date.Text = places_evolution_obj.architectural_evolution_hijri_date;
                txt_architectural_evolution_georg_date.Text = places_evolution_obj.architectural_evolution_georg_date;
                txt_architectural_evolution_person.Text = places_evolution_obj.architectural_evolution_person;
                txt_architectural_evolution_desc.Text = places_evolution_obj.architectural_evolution_desc;
                txt_architectural_evolution_note.Text = places_evolution_obj.architectural_evolution_note;
                if (menus_update.get_current_lang() == 2)
                {
                    txt_architectural_evolution_desc.Visible = Label89.Visible = Label82.Visible =
                    txt_architectural_evolution_person.Visible = btn_save_evolution_translate.Visible = true;
                    txt_architectural_evolution_desc.Text = places_evolution_obj.architectural_evolution_desc_en;
                    txt_architectural_evolution_person.Text = places_evolution_obj.architectural_evolution_person_en;
                }
                if (menus_update.get_current_lang() == 3)
                {
                    txt_architectural_evolution_desc.Visible = Label89.Visible = Label82.Visible =
                    txt_architectural_evolution_person.Visible = btn_save_evolution_translate.Visible = true;
                    txt_architectural_evolution_desc.Text = places_evolution_obj.architectural_evolution_desc_fr;
                    txt_architectural_evolution_person.Text = places_evolution_obj.architectural_evolution_person_fr;
                }
            }
        }
        else if (((ImageButton)sender).CommandName == "restoration")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                txt_restoration_id.Visible = true;
                txt_restoration_id.Text = id.ToString();
                places_restoration_DT places_restoration_obj = places_restoration_DB.SelectByID(id);
                ddl_restoration_age.SelectedValue = places_restoration_obj.restoration_age.ToString();
                txt_restoration_hijri_date.Text = places_restoration_obj.restoration_hijri_date;
                txt_restoration_georg_date.Text = places_restoration_obj.restoration_georg_date;
                txt_restoration_person.Text = places_restoration_obj.restoration_person;
                txt_restoration_participants.Text = places_restoration_obj.restoration_participants;
                txt_restoration_desc.Text = places_restoration_obj.restoration_desc;
                txt_restoration_note.Text = places_restoration_obj.restoration_note;
                if (menus_update.get_current_lang() == 2)
                {
                    Label103.Visible = Label104.Visible = Label106.Visible =
                    txt_restoration_desc.Visible = txt_restoration_participants.Visible =
                    txt_restoration_person.Visible = btn_save_restoration_translate.Visible = true;
                    txt_restoration_desc.Text = places_restoration_obj.restoration_desc_en;
                    txt_restoration_person.Text = places_restoration_obj.restoration_person_en;
                    txt_restoration_participants.Text = places_restoration_obj.restoration_participants_en;
                }
                if (menus_update.get_current_lang() == 3)
                {
                    Label103.Visible = Label104.Visible = Label106.Visible =
                    txt_restoration_desc.Visible = txt_restoration_participants.Visible =
                      txt_restoration_person.Visible = btn_save_restoration_translate.Visible = true;
                    txt_restoration_desc.Text = places_restoration_obj.restoration_desc_fr;
                    txt_restoration_person.Text = places_restoration_obj.restoration_person_fr;
                    txt_restoration_participants.Text = places_restoration_obj.restoration_participants_fr;
                }
            }
        }
        check_ocordion();
    }
    public void imgEdit_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        if (((ImageButton)sender).CommandName == "names")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {


                //ViewState["hf_names"] = id.ToString()        

                txt_name_id.Visible = true;
                txt_name_id.Text = id.ToString();

                places_names_DT places_names_obj = places_names_DB.SelectByID(id);
                ddl_name_age.SelectedValue = places_names_obj.name_age.ToString();
                txt_name_in_age.Text = places_names_obj.name_in_age;
                txt_name_note.Text = places_names_obj.name_note;
                btn_save_names.Text = "تعديل الإسم";
                if (menus_update.get_current_lang() == 2)
                {
                   
                    txt_name_in_age.Visible = true;
                    txt_name_in_age.Text = places_names_obj.name_age_en;
                }
                if (menus_update.get_current_lang() == 3)
                {
                    
                    txt_name_in_age.Visible =  true;
                    txt_name_in_age.Text = places_names_obj.name_age_fr;
                }

            }
        }
        else if (((ImageButton)sender).CommandName == "architectural_styles")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                txt_architectural_styles_id.Visible = true;
                txt_architectural_styles_id.Text = id.ToString();
                places_architecture_style_DT places_architecture_style_obj = places_architecture_style_DB.SelectByID(id);
                if (CDataConverter.ConvertToInt(places_architecture_style_obj.architectural_styles_type) > 0)
                    rbl_architectural_styles_type.SelectedValue = places_architecture_style_obj.architectural_styles_type.ToString();
                
                if (CDataConverter.ConvertToInt(places_architecture_style_obj.architectural_element) > 0)
                    rbl_architectural_element.SelectedValue = places_architecture_style_obj.architectural_element.ToString();

                txt_architectural_element_other.Text = places_architecture_style_obj.architectural_element_other;
                txt_architectural_styles_type_other.Text = places_architecture_style_obj.architectural_styles_type_other;
                txt_architectural_styles_type_general_feature.Text = places_architecture_style_obj.architectural_styles_type_general_feature;
                txt_architectural_styles_type_notes.Text = places_architecture_style_obj.architectural_styles_type_notes;
                btn_save_style.Text = "تعديل الطراز";
            }
        }
       
       
        else if (((ImageButton)sender).CommandName == "address")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                txt_address_id.Visible = true;
                txt_address_id.Text = id.ToString();
                places_address_DT places_address_obj = places_address_DB.SelectByID(id);
                ddl_address_age.SelectedValue = places_address_obj.address_age.ToString();
                txt_address_age_desc.Text = places_address_obj.address_age_desc;
                txt_address_age_note.Text = places_address_obj.address_age_note;
                btn_save_address.Text = "تعديل الموقع";
            }
        }
        else if (((ImageButton)sender).CommandName == "evolution")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                txt_evolution_id.Visible = true;
                txt_evolution_id.Text = id.ToString();
                places_evolution_DT places_evolution_obj = places_evolution_DB.SelectByID(id);
                ddl_architectural_evolution_age.SelectedValue = places_evolution_obj.architectural_evolution_age.ToString();
                txt_architectural_evolution_hijri_date.Text = places_evolution_obj.architectural_evolution_hijri_date;
                txt_architectural_evolution_georg_date.Text = places_evolution_obj.architectural_evolution_georg_date;
                txt_architectural_evolution_person.Text = places_evolution_obj.architectural_evolution_person;
                txt_architectural_evolution_desc.Text = places_evolution_obj.architectural_evolution_desc;
                txt_architectural_evolution_note.Text = places_evolution_obj.architectural_evolution_note;
                btn_save_evolution.Text = "تعديل التطور";

            }
        }
        else if (((ImageButton)sender).CommandName == "restoration")
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                txt_restoration_id.Visible = true;
                txt_restoration_id.Text = id.ToString();
                places_restoration_DT places_restoration_obj = places_restoration_DB.SelectByID(id);
                ddl_restoration_age.SelectedValue = places_restoration_obj.restoration_age.ToString();
                txt_restoration_hijri_date.Text = places_restoration_obj.restoration_hijri_date;
                txt_restoration_georg_date.Text = places_restoration_obj.restoration_georg_date;
                txt_restoration_person.Text = places_restoration_obj.restoration_person;
                txt_restoration_participants.Text = places_restoration_obj.restoration_participants;
                txt_restoration_desc.Text = places_restoration_obj.restoration_desc;
                txt_restoration_note.Text = places_restoration_obj.restoration_note;
                btn_save_restoration.Text = "تعديل الترميم";
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

    public void btn_save_names_click(object sender, EventArgs e)
    {



        places_names_DT places_names_obj_to_save = places_names_DB.SelectByID(CDataConverter.ConvertToInt(txt_name_id.Text));
        places_names_obj_to_save.id = CDataConverter.ConvertToInt(places_names_obj_to_save.id);
        places_names_obj_to_save.place_id = CDataConverter.ConvertToInt(content_id.Value);



        if (menus_update.get_current_lang() == 1)
        {
            places_names_obj_to_save.name_age = CDataConverter.ConvertToInt(ddl_name_age.SelectedValue);
            places_names_obj_to_save.name_in_age = txt_name_in_age.Text;
            places_names_obj_to_save.name_note = txt_name_note.Text;

        }
        if (menus_update.get_current_lang() == 2)
            places_names_obj_to_save.name_age_en = txt_name_in_age.Text; 
        if (menus_update.get_current_lang() == 3)
            places_names_obj_to_save.name_age_fr = txt_name_in_age.Text; 

        places_names_DB.Save(places_names_obj_to_save);




        log(24);
        txt_name_id.Text = "0";
        txt_name_id.Visible = false;
        ddl_name_age.SelectedItem.Selected = btn_save_names_translated1.Visible = false;
        txt_name_in_age.Text = txt_name_note.Text = "";
        //Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم حفظ بيانات الإستمارة بنجاح')</script>");
        fillGridVeiws();
        check_ocordion();
    }
    public void btn_save_style_click(object sender, EventArgs e)
    {
        places_architecture_style_DT places_architecture_style_obj_to_save = places_architecture_style_DB.SelectByID(CDataConverter.ConvertToInt(txt_architectural_styles_id.Text));
        places_architecture_style_obj_to_save.id = CDataConverter.ConvertToInt(places_architecture_style_obj_to_save.id);
        places_architecture_style_obj_to_save.place_id = CDataConverter.ConvertToInt(content_id.Value);



        if (menus_update.get_current_lang() == 1)
        {
            if (CDataConverter.ConvertToInt(rbl_architectural_styles_type.SelectedValue) > 0)
                places_architecture_style_obj_to_save.architectural_styles_type = CDataConverter.ConvertToInt(rbl_architectural_styles_type.SelectedValue);
            places_architecture_style_obj_to_save.architectural_styles_type_other = txt_architectural_styles_type_other.Text;
            if (CDataConverter.ConvertToInt(rbl_architectural_element.SelectedValue) > 0)
                places_architecture_style_obj_to_save.architectural_element = CDataConverter.ConvertToInt(rbl_architectural_element.SelectedValue);
            places_architecture_style_obj_to_save.architectural_element_other = txt_architectural_element_other.Text;
            places_architecture_style_obj_to_save.architectural_styles_type_general_feature = txt_architectural_styles_type_general_feature.Text;
            places_architecture_style_obj_to_save.architectural_styles_type_notes = txt_architectural_styles_type_notes.Text;

        }
        if (menus_update.get_current_lang() == 2)
            places_architecture_style_obj_to_save.architectural_styles_type_general_feature_en = txt_architectural_styles_type_general_feature.Text;
        if (menus_update.get_current_lang() == 3)
            places_architecture_style_obj_to_save.architectural_styles_type_general_feature_fr = txt_architectural_styles_type_general_feature.Text;

        places_architecture_style_DB.Save(places_architecture_style_obj_to_save);
        log(25);
        txt_architectural_styles_id.Text = "0";
        txt_architectural_styles_id.Visible = btn_save_style_translate.Visible = false;
        rbl_architectural_styles_type.SelectedIndex = rbl_architectural_element.SelectedIndex = -1;
        txt_architectural_styles_type_general_feature.Text = txt_architectural_styles_type_notes.Text = "";

        //Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم حفظ بيانات الإستمارة بنجاح')</script>");
        fillGridVeiws();
        check_ocordion();
        btn_save_style.Text = "أضف طراز";
    }
    
  
    public void btn_save_address_click(object sender, EventArgs e)
    {
        places_address_DT places_address_obj_to_save = places_address_DB.SelectByID(CDataConverter.ConvertToInt(txt_address_id.Text));
        places_address_obj_to_save.id = CDataConverter.ConvertToInt(places_address_obj_to_save.id);
        places_address_obj_to_save.place_id = CDataConverter.ConvertToInt(content_id.Value);

        if (menus_update.get_current_lang() == 1)
        {
            places_address_obj_to_save.address_age = CDataConverter.ConvertToInt(ddl_address_age.SelectedValue);
            places_address_obj_to_save.address_age_desc = txt_address_age_desc.Text;
            places_address_obj_to_save.address_age_note = txt_address_age_note.Text;
        }
        if (menus_update.get_current_lang() == 2)
            places_address_obj_to_save.address_age_desc_en = txt_address_age_desc.Text;
        if (menus_update.get_current_lang() == 3)
            places_address_obj_to_save.address_age_desc_fr = txt_address_age_desc.Text;

        places_address_DB.Save(places_address_obj_to_save);
        log(28);
        txt_address_id.Text = "0";
        txt_address_id.Visible = btn_save_address_translate.Visible = false;
        ddl_address_age.SelectedIndex = -1;
        txt_address_age_desc.Text = txt_address_age_note.Text = "";
        //Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم حفظ بيانات الإستمارة بنجاح')</script>");
        fillGridVeiws();
        check_ocordion();
    }
    public void btn_save_evolution_click(object sender, EventArgs e)
    {
        places_evolution_DT places_evolution_obj_to_save = places_evolution_DB.SelectByID(CDataConverter.ConvertToInt(txt_evolution_id.Text));
        places_evolution_obj_to_save.id = CDataConverter.ConvertToInt(places_evolution_obj_to_save.id);
        places_evolution_obj_to_save.place_id = CDataConverter.ConvertToInt(content_id.Value);

        if (menus_update.get_current_lang() == 1)
        {
            places_evolution_obj_to_save.architectural_evolution_age = CDataConverter.ConvertToInt(ddl_architectural_evolution_age.SelectedValue);
            places_evolution_obj_to_save.architectural_evolution_hijri_date = txt_architectural_evolution_hijri_date.Text;
            places_evolution_obj_to_save.architectural_evolution_georg_date = txt_architectural_evolution_georg_date.Text;
            places_evolution_obj_to_save.architectural_evolution_person = txt_architectural_evolution_person.Text;
            places_evolution_obj_to_save.architectural_evolution_desc = txt_architectural_evolution_desc.Text;
            places_evolution_obj_to_save.architectural_evolution_note = txt_architectural_evolution_note.Text;
        }
        if (menus_update.get_current_lang() == 2)
        {
            places_evolution_obj_to_save.architectural_evolution_person_en = txt_architectural_evolution_person.Text;
            places_evolution_obj_to_save.architectural_evolution_desc_en = txt_architectural_evolution_desc.Text;
        }
        if (menus_update.get_current_lang() == 3)
        {
            places_evolution_obj_to_save.architectural_evolution_person_fr = txt_architectural_evolution_person.Text;
            places_evolution_obj_to_save.architectural_evolution_desc_fr = txt_architectural_evolution_desc.Text;
        }
        places_evolution_DB.Save(places_evolution_obj_to_save);
        log(29);
        txt_evolution_id.Text = "0";
        txt_evolution_id.Visible = btn_save_evolution_translate.Visible = false;
        ddl_architectural_evolution_age.SelectedIndex = -1;
        txt_architectural_evolution_hijri_date.Text
            = txt_architectural_evolution_georg_date.Text
           = txt_architectural_evolution_person.Text
            = txt_architectural_evolution_desc.Text
           = txt_architectural_evolution_note.Text = "";
        //Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم حفظ بيانات الإستمارة بنجاح')</script>");
        fillGridVeiws();
        check_ocordion();


    }
    public void btn_save_restoration_click(object sender, EventArgs e)
    {
        places_restoration_DT places_restoration_obj_to_save = places_restoration_DB.SelectByID(CDataConverter.ConvertToInt(txt_restoration_id.Text));
        places_restoration_obj_to_save.id = CDataConverter.ConvertToInt(places_restoration_obj_to_save.id);
        places_restoration_obj_to_save.place_id = CDataConverter.ConvertToInt(content_id.Value);

        if (menus_update.get_current_lang() == 1)
        {
            places_restoration_obj_to_save.restoration_age = CDataConverter.ConvertToInt(ddl_restoration_age.SelectedValue);
            places_restoration_obj_to_save.restoration_hijri_date = txt_restoration_hijri_date.Text;
            places_restoration_obj_to_save.restoration_georg_date = txt_restoration_georg_date.Text;
            places_restoration_obj_to_save.restoration_person = txt_restoration_person.Text;
            places_restoration_obj_to_save.restoration_participants = txt_restoration_participants.Text;
            places_restoration_obj_to_save.restoration_desc = txt_restoration_desc.Text;
            places_restoration_obj_to_save.restoration_note = txt_restoration_note.Text;
        }
        if (menus_update.get_current_lang() == 2)
        {
            places_restoration_obj_to_save.restoration_person_en = txt_restoration_person.Text;
            places_restoration_obj_to_save.restoration_participants_en = txt_restoration_participants.Text;
            places_restoration_obj_to_save.restoration_desc_en = txt_restoration_desc.Text;
        }
        if (menus_update.get_current_lang() == 3)
        {
            places_restoration_obj_to_save.restoration_person_fr = txt_restoration_person.Text;
            places_restoration_obj_to_save.restoration_participants_fr = txt_restoration_participants.Text;
            places_restoration_obj_to_save.restoration_desc_fr = txt_restoration_desc.Text;
        }
        places_restoration_DB.Save(places_restoration_obj_to_save);
        log(30);
        txt_restoration_id.Text = "0";
        txt_restoration_id.Visible = btn_save_restoration_translate.Visible = false;
        ddl_restoration_age.SelectedIndex = -1;
        txt_restoration_hijri_date.Text = txt_restoration_georg_date.Text = txt_restoration_person.Text
             = txt_restoration_participants.Text = txt_restoration_desc.Text = txt_restoration_note.Text = "";
        //Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم حفظ بيانات الإستمارة بنجاح')</script>");
        fillGridVeiws();
        check_ocordion();
        btn_save_restoration.Text = "أضف ترميم";
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

   

    #endregion

}
