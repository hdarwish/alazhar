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

public partial class user_controls_manuscriptTab : System.Web.UI.UserControl
{
    public static int row_id1 = 0;
    public static int row_id2 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        getData();
        if (Session["user_type"] != null)
        {

            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {

                //btn_save_tamlekat.Visible = 
                //btn_save_tawkifat.Visible =
                //TamalokatGridView.Columns[5].Visible =
                //TawfikatGridView.Columns[5].Visible = false;
                Enabled();
            }
            
        }
    }
    public void getData()
    {
        SqlParameter[] sqlParams_tamalokat = new SqlParameter[] { new SqlParameter("@manuscript_id", CDataConverter.ConvertToInt(content_id.Value)) };
        DataTable dt_tamalokat = new DataTable();
        dt_tamalokat = DatabaseFunctions.SelectData(sqlParams_tamalokat, "tamalokat_Select_select");
        TamalokatGridView.DataSource = dt_tamalokat;
        TamalokatGridView.DataBind();


        SqlParameter[] sqlParams_tawkifat = new SqlParameter[] { new SqlParameter("@manuscript_id", CDataConverter.ConvertToInt(content_id.Value)) };
        DataTable dt_tawkifat = new DataTable();
        dt_tawkifat = DatabaseFunctions.SelectData(sqlParams_tawkifat, "tawkifat_Select_select");
        TawfikatGridView.DataSource = dt_tawkifat;
        TawfikatGridView.DataBind();

        if (menus_update.get_current_lang() == 1)
        {
            TamalokatGridView.Columns[4].Visible =
            TamalokatGridView.Columns[2].Visible = TamalokatGridView.Columns[1].Visible =
            TawfikatGridView.Columns[7].Visible =
            TawfikatGridView.Columns[5].Visible = TawfikatGridView.Columns[4].Visible =
            TawfikatGridView.Columns[2].Visible = TawfikatGridView.Columns[1].Visible =false;
        }
        if (menus_update.get_current_lang() == 2)
        {

            Label75.Visible = tawkifat_date.Visible = tawkifat_date_type.Visible = Label60.Visible = Label73.Visible =
                Label61.Visible = tmlkat_date.Visible = tmlkat_date_type.Visible =
           TamalokatGridView.Columns[6].Visible = TamalokatGridView.Columns[5].Visible = TamalokatGridView.Columns[3].Visible = TamalokatGridView.Columns[2].Visible =
            TawfikatGridView.Columns[9].Visible = TawfikatGridView.Columns[8].Visible = TawfikatGridView.Columns[6].Visible = TawfikatGridView.Columns[5].Visible =
            TawfikatGridView.Columns[2].Visible = 
             btn_save_tawkifat.Visible = btn_save_tamlekat.Visible = false;
            //RequiredFieldValidator26.Visible = RequiredFieldValidator27.Visible =
            // RequiredFieldValidator24.Visible = RequiredFieldValidator25.Visible = false;
        }
        if (menus_update.get_current_lang() == 3)
        {

            Label75.Visible = tawkifat_date.Visible = tawkifat_date_type.Visible = Label60.Visible = Label73.Visible =
                 Label61.Visible = tmlkat_date.Visible = tmlkat_date_type.Visible =
           TamalokatGridView.Columns[6].Visible = TamalokatGridView.Columns[5].Visible = TamalokatGridView.Columns[3].Visible = TamalokatGridView.Columns[1].Visible =
            TawfikatGridView.Columns[9].Visible = TawfikatGridView.Columns[8].Visible = TawfikatGridView.Columns[6].Visible = TawfikatGridView.Columns[4].Visible =
            TawfikatGridView.Columns[1].Visible = 
             btn_save_tawkifat.Visible = btn_save_tamlekat.Visible =false;
            //RequiredFieldValidator26.Visible = RequiredFieldValidator27.Visible =
            // RequiredFieldValidator24.Visible = RequiredFieldValidator25.Visible =  false;
        }


    }

    public void unvisable_all()
    {
        Tr1.Visible = Tr2.Visible =
            TamalokatGridView.Columns[5].Visible =
            TamalokatGridView.Columns[4].Visible =
            TawfikatGridView.Columns[8].Visible =
            TawfikatGridView.Columns[7].Visible = false;
    }

    public void dimmed()
    {
        foreach (System.Web.UI.HtmlControls.HtmlTableRow r in tblmanus.Rows)
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
                    if (control.GetType().ToString() == "System.Web.UI.WebControls.FileUpload")
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

    protected void btn_save_tamlekat_Click(object sender, EventArgs e)
    {
        tamalokat_DT tamalok =  tamalokat_DB.SelectByID(row_id1);
        
        tamalok.manuscript_id = Convert.ToInt16(content_id.Value);
        if (menus_update.get_current_lang() == 1)
        {
            tamalok.tmlkat_name = tmlkat_name.Text;
            tamalok.notes = txtnotes_tam.Text;
            tamalok.tmlkat_date = tmlkat_date.Text;
            tamalok.tmlkat_date_type = tmlkat_date_type.SelectedValue;
        }
        if (menus_update.get_current_lang() == 2)
        {
            tamalok.tmlkat_name_en = tmlkat_name.Text;
        }
        if (menus_update.get_current_lang() == 3)
        {
            tamalok.tmlkat_name_fr = tmlkat_name.Text;
        }
        int rslt = tamalokat_DB.Save(tamalok);
        getData();
        tmlkat_name.Text = "";
        btn_tamalokat_translate.Visible = false;
    }
    protected void btn_save_tawkifat_Click(object sender, EventArgs e)
    {

        tawkifat_DT tawkifat = tawkifat_DB.SelectByID(row_id2);
        tawkifat.manuscript_id = Convert.ToInt16(content_id.Value);
        if (menus_update.get_current_lang() == 1)
        {
            
            tawkifat.tawkifat_name = tawkifat_name.Text;
            tawkifat.tawkifat_on_name = tawkifat_on_name.Text;
            tawkifat.tawkifat_date = tawkifat_date.Text;
            tawkifat.tawkifat_date_type = tawkifat_date_type.SelectedValue;
            tawkifat.notes = txtnotes.Text;
 
        }
        if (menus_update.get_current_lang() == 2)
        {
            tawkifat.tawkifat_name_en = tawkifat_name.Text;
            tawkifat.tawkifat_on_name_en = tawkifat_on_name.Text;
        }
        if (menus_update.get_current_lang() == 3)
        {
            tawkifat.tawkifat_name_fr = tawkifat_name.Text;
            tawkifat.tawkifat_on_name_fr = tawkifat_on_name.Text;
        }
        
        int rslt = tawkifat_DB.Save(tawkifat);
        getData();
        btn_translate_tawkifat.Visible = false;
        tawkifat_name.Text =tawkifat_on_name.Text= "";
    }
    protected void TamalokatGridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "RemoveItem")
        {
            int i = tamalokat_DB.Delete(Convert.ToInt16(e.CommandArgument.ToString()));
            getData();
        }
        
    }
    protected void TawfikatGridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "RemoveItem")
        {
            int i = tawkifat_DB.Delete(Convert.ToInt16(e.CommandArgument.ToString()));
            getData();
        }
       
    }

    protected void btn_Translatetmaluk(object sender, EventArgs e)
    {
      
            row_id1 = CDataConverter.ConvertToInt(((Button)sender).CommandArgument);
            myRowIndex1.Value = ((Button)sender).CommandName;
            tamalokat_DT dt = tamalokat_DB.SelectByID(row_id1);
            if (menus_update.get_current_lang() == 2)
            {
                tmlkat_name.Text = dt.tmlkat_name_en;

            }
            if (menus_update.get_current_lang() == 3)
            {
                tmlkat_name.Text = dt.tmlkat_name_fr;
            }
            btn_tamalokat_translate.Visible = true;
    }
    protected void btn_Translatetawkif(object sender, EventArgs e)
    {
       
            row_id2 = CDataConverter.ConvertToInt(((Button)sender).CommandArgument);
            myRowIndex2.Value = ((Button)sender).CommandName;
            tawkifat_DT dt = tawkifat_DB.SelectByID(row_id2);
            if (menus_update.get_current_lang() == 2)
            {
                tawkifat_name.Text = dt.tawkifat_name_en;
                tawkifat_on_name.Text = dt.tawkifat_on_name_en;
            }
            if (menus_update.get_current_lang() == 3)
            {
                tawkifat_name.Text = dt.tawkifat_name_fr;
                tawkifat_on_name.Text = dt.tawkifat_on_name_fr;
            }

            btn_translate_tawkifat.Visible = true;
        
       
    }

   
}
