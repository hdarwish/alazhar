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

public partial class user_controls_docs_authors : System.Web.UI.UserControl
{
    public static int row_id = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGrid();
            filldrop_char();
            filldrop_role();
            filldrop_author_type();
            // tr_author_type.Visible = false;
            if (content_type.Value == "10")
            {
                //filldrop_author_type();
                //tr_author_type.Visible = true;

            }
        }
        if (Session["user_type"] != null)
        {
            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
            {
               // btn_moalf.Visible = false;
                btn_moalf_ar.Visible = false;
                Enabled();
            }
            if (Session["user_type"].ToString() == "5")
            {
                btn_moalf_ar.Visible = false;
                //btn_moalf.Visible = false;
                tr_author_type.Visible = false;
                trmoalf.Visible = false;
                trtrgma.Visible = false;

                if (menus_update.get_current_lang() == 1)
                {
                    gview_moalf.Columns[2].Visible = false;
                    gview_moalf.Columns[3].Visible = false;
                    gview_moalf.Columns[6].Visible = false;
                    gview_moalf.Columns[7].Visible = false;
                }


                if (menus_update.get_current_lang() == 2)
                {
                    gview_moalf.Columns[3].Visible = false;
                    gview_moalf.Columns[4].Visible = false;
                    gview_moalf.Columns[6].Visible = false;
                    gview_moalf.Columns[7].Visible = false;
                }

                if (menus_update.get_current_lang() == 3)
                {
                    gview_moalf.Columns[3].Visible = false;
                    gview_moalf.Columns[4].Visible = false;
                    gview_moalf.Columns[6].Visible = false;
                    gview_moalf.Columns[7].Visible = false;

                }
            }
            if (Session["user_type"].ToString() == "4" || Session["user_type"].ToString() == "8")
            {

                if (content_type.Value == "10")
                {
                    //filldrop_author_type();
                    //tr_author_type.Visible = true;

                }
                //else { tr_author_type.Visible = false; }

                if (menus_update.get_current_lang() == 1)
                {
                    trtrgma.Visible = false;
                    gview_moalf.Columns[2].Visible = false;
                    gview_moalf.Columns[3].Visible = false;
                    gview_moalf.Columns[6].Visible = false;
                    gview_moalf.Columns[7].Visible = true;
                }
                else
                {
                    if (gview_moalf.Rows.Count > 0)
                    {
                        trtrgma.Visible = true;
                    }
                    else { trtrgma.Visible = false; }
                    tr_grid.Visible = true;
                    trmoalf.Visible = false;
                    gview_moalf.Columns[0].Visible = true;
                    gview_moalf.Columns[1].Visible = true;


                    gview_moalf.Columns[5].Visible = false;
                    gview_moalf.Columns[6].Visible = true;
                    gview_moalf.Columns[7].Visible = false;
                    if (menus_update.get_current_lang() == 2)
                    {
                        if (gview_moalf.Rows.Count > 0)
                        {
                            trtrgma.Visible = true;

                        }
                        else { trtrgma.Visible = false; btn_moalf_ar.Visible = false; }
                        gview_moalf.Columns[2].Visible = true;
                        gview_moalf.Columns[3].Visible = false;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        if (gview_moalf.Rows.Count > 0)
                        {
                            trtrgma.Visible = true;
                          
                        }
                        else { trtrgma.Visible = false; btn_moalf_ar.Visible = false; }
                        gview_moalf.Columns[2].Visible = false;
                        gview_moalf.Columns[3].Visible = true;
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
               // btn_moalf.Visible = false;
                btn_moalf_ar.Visible = false;
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
                            btn.BorderColor = System.Drawing.Color.Black;
                            btn.ForeColor = System.Drawing.Color.Red;
                            btn.Focus();
                        }



                    }
                }
            }
        }
    }
    public void filldrop_author_type()
    {
        DataTable dt = author_type_DB.SelectAll();
        drop_author_type.DataSource = dt;
        drop_author_type.DataBind();
        ListItem litem = new ListItem("-- اختر نوع اسم المؤلف--", "0");
        litem.Selected = true;
        drop_author_type.Items.Insert(0, litem);
    }
    private void filldrop_author()
    {
        //    DataTable dt = authors_details_DB.SelectAll();
        //    drop_author.DataSource = dt;
        //    drop_author.DataBind();
        //    ListItem litem = new ListItem("-- اختر اسم المؤلف --", "0");
        //    litem.Selected = true;
        //    drop_author.Items.Insert(0, litem);
    }
    private void filldrop_char()
    {
        DataTable dt = characters_details_DB.SelectBylang_ID(menus_update.get_current_lang());
        drop_char.DataSource = dt;
        drop_char.DataBind();
        ListItem litem = new ListItem("--  اختر اسم المؤلف من الشخصيات  --", "0");
        litem.Selected = true;
        drop_char.Items.Insert(0, litem);
    }
    private void filldrop_role()
    {
        DataTable dt = authors_role_DB.SelectAll();
        drop_role.DataSource = dt;
        drop_role.DataBind();
        ListItem litem = new ListItem("-- اختر دور المؤلف--", "0");
        litem.Selected = true;
        drop_role.Items.Insert(0, litem);
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {
            drop_char.Enabled = false;
        }
        else { drop_char.Enabled = true; }
    }
    protected void btn_moalf_Click(object sender, EventArgs e)
    {
        //if (txt_enmoalf.Text != "")
        //{
        //    authors_details_DT author_details_new = authors_details_DB.SelectByID(row_id);
        //    //authors_details_DT author_details_new = new authors_details_DT();
        //    author_details_new.id = author_details_new.id;
        //    author_details_new.author_id = row_id;
        //    author_details_new.name = txt_enmoalf.Text;
        //    author_details_new.details = null;
        //    author_details_new.address = null;
        //    author_details_new.title = null;
        //    author_details_new.lang_id = menus_update.get_current_lang();
        //    int res = authors_details_DB.Save(author_details_new);
        //    if (content_type.Value == "14")
        //    {
        //        General_Helping.ExcuteQuery("update docs_authors set doc_type = 1 where docs_authors.id= " + author_details_new.author_id);
        //    }
        //}
        //txt_enmoalf.Text = "";
        //FillGrid();
    }
    public void FillGrid()
    {
        DataTable dt = new DataTable();
        if (content_type.Value == "14")
        {
            //if (CDataConverter.ConvertToInt(menus_update.get_current_lang()) == 1)
            //{
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt(content_id.Value)),
           new SqlParameter("@lang_id", 1) };
            dt = new DataTable();
            dt = DatabaseFunctions.SelectData(sqlParams, "authorstitle_conference_select");
            gview_moalf.Visible = true;
            gview_moalf.DataSource = dt;
            gview_moalf.DataBind();

            /////////////////////////////////////////////////////////////////////
            if (CDataConverter.ConvertToInt(menus_update.get_current_lang()) > 1)
            {
                SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt(content_id.Value)) ,
                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                DataTable dt2 = new DataTable();
                dt2 = DatabaseFunctions.SelectData(sqlParams1, "authorstitle_conference_select");
                for (int f = 0; f < dt.Rows.Count; f++)
                {
                    if (dt.Rows[f]["is_character"].ToString() == "1")
                    {
                        dt.Rows[f].Delete();
                    }
                    else
                    {
                        DataRow[] foundRows;

                        foundRows = dt2.Select("author_id = '" + dt.Rows[f]["author_id"].ToString() + "'");
                        if (foundRows.Length > 0)
                        {
                            dt.Rows[f]["name_ar"] = foundRows[0][1].ToString();
                        }
                    }
                }
                gview_moalf.Visible = true;
                gview_moalf.DataSource = dt;
                gview_moalf.DataBind();
            }
        }
        else
        {


            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt(content_id.Value)),
           new SqlParameter("@lang_id", 1) };
            //dt = new DataTable();
            dt = DatabaseFunctions.SelectData(sqlParams, "authorstitle_select");
            gview_moalf.Visible = true;
            gview_moalf.DataSource = dt;
            gview_moalf.DataBind();

            /////////////////////////////////////////////////////////////////////
            if (CDataConverter.ConvertToInt(menus_update.get_current_lang()) > 1)
            {
                SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt(content_id.Value)) ,
            new SqlParameter("@lang_id", menus_update.get_current_lang())};
                DataTable dt2 = new DataTable();
                dt2 = DatabaseFunctions.SelectData(sqlParams1, "authorstitle_select");
                for (int f = 0; f < dt.Rows.Count; f++)
                {
                    if (dt.Rows[f]["is_character"].ToString() == "1")
                    {
                        dt.Rows[f].Delete();
                    }
                    else
                    {
                        DataRow[] foundRows;

                        foundRows = dt2.Select("author_id = '" + dt.Rows[f]["author_id"].ToString() + "'");
                        if (foundRows.Length > 0)
                        {
                            dt.Rows[f]["name_ar"] = foundRows[0][2].ToString();
                        }
                    }
                }
                gview_moalf.Visible = true;
                gview_moalf.DataSource = dt;
                gview_moalf.DataBind();
            }
        }


        //gview_moalf.DataSource = dt;
        //gview_moalf.DataBind();

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
    protected void drop_char_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drop_char.SelectedValue != "0")
        { //drop_author.Enabled = false;
            TextBox1.Enabled = false;
        }
        else
        { //drop_author.Enabled = true;
            TextBox1.Enabled = true;
        }


    }

    protected void btn_moalf_ar_Click(object sender, EventArgs e)
    {
        int id = 0;

        if (menus_update.get_current_lang() == 1)
        {
            if (CDataConverter.ConvertToInt(drop_char.SelectedValue) > 0)
            {
                docs_authors_DT authors_doc_dt = new docs_authors_DT();
                authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
                authors_doc_dt.author_id = CDataConverter.ConvertToInt(drop_char.SelectedValue);
                authors_doc_dt.is_character = 1;
                authors_doc_dt.relation_title_ar = "";

                authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_author_type.SelectedValue);
                authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
                authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
                if (content_type.Value == "14")
                {
                    General_Helping.ExcuteQuery("update docs_authors set doc_type = 1 where docs_authors.id= " + authors_doc_dt.id);
                }
                id = authors_doc_dt.id;
            }
            if (TextBox1.Text != "")
            {
                authors_DT authors_new = new authors_DT();
                authors_new.id = 0;
                authors_new.notes = "";
                int created_id = authors_DB.Save(authors_new);
                authors_details_DT author_details_new = new authors_details_DT();
                author_details_new.id = 0;
                author_details_new.author_id = created_id;
                author_details_new.name = TextBox1.Text;
                author_details_new.details = null;
                author_details_new.address = null;
                author_details_new.title = null;
                author_details_new.lang_id = menus_update.get_current_lang();
author_details_new.name_fromtitle=null;
author_details_new.name_fromheader=null;
                int res = authors_details_DB.Save(author_details_new);

                if( res > 0)
                {
                    docs_authors_DT authors_doc_dt = new docs_authors_DT();
                    authors_doc_dt.id = 0;
                    authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
                    authors_doc_dt.author_id = author_details_new.author_id;
                    authors_doc_dt.is_character = 0;
                    authors_doc_dt.relation_title_ar = "";
                    authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_author_type.SelectedValue);
                    authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
                    authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
                    id = authors_doc_dt.id;
                    if (content_type.Value == "14")
                    {
                        General_Helping.ExcuteQuery("update docs_authors set doc_type = 1 where docs_authors.id= " + authors_doc_dt.id);
                    }

                }

            }

            //if (CDataConverter.ConvertToInt(drop_author.SelectedValue) > 0)
            //{
            //    docs_authors_DT authors_doc_dt = new docs_authors_DT();
            //    //// HiddenField or session [doc_id] ////
            //    authors_doc_dt.doc_id = CDataConverter.ConvertToInt(content_id.Value);
            //    authors_doc_dt.author_id = CDataConverter.ConvertToInt(drop_author.SelectedValue); ;
            //    authors_doc_dt.is_character = 0;
            //    authors_doc_dt.role_id = CDataConverter.ConvertToInt(drop_role.SelectedValue);
            //    // authors_doc_dt.author_type_id = CDataConverter.ConvertToInt(drop_type.SelectedValue);
            //    authors_doc_dt.relation_title_ar = "";
            //    authors_doc_dt.id = docs_authors_DB.Save(authors_doc_dt);
            //    id = authors_doc_dt.id;
            //}
            if (id > 0)
            {
                //FillGrid();


            }
            FillGrid();
            TextBox1.Text = "";
drop_char.Enabled = true; 
        }
        if (menus_update.get_current_lang() == 2 || menus_update.get_current_lang() == 3)
        {

            if (txt_enmoalf.Text != "")
            {
                authors_details_DT author_details_new = authors_details_DB.SelectByID(row_id);
                //authors_details_DT author_details_new = new authors_details_DT();
                author_details_new.id = author_details_new.id;
                author_details_new.author_id = row_id;
                author_details_new.name = txt_enmoalf.Text;
                author_details_new.details = null;
                author_details_new.address = null;
                author_details_new.title = null;
                author_details_new.lang_id = menus_update.get_current_lang();
                int res = authors_details_DB.Save(author_details_new);
                if (content_type.Value == "14")
                {
                    General_Helping.ExcuteQuery("update docs_authors set doc_type = 1 where docs_authors.id= " + author_details_new.author_id);
                }
            }
            txt_enmoalf.Text = "";
            FillGrid();

        }

    }
    public void imgDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        if (Session["user_type"].ToString() == "5")
        { ShowAlertMessage("عفواً لايمكنك الحذف"); }
        else
        {
            int id = CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument);
            if (id > 0)
            {
                docs_authors_DB.Delete(id);
                FillGrid();

            }
        }

    }
    protected void btn_translate_Click(object sender, EventArgs e)
    {
        //%#Container.DataItemIndex + 1%>

        if (Session["user_type"].ToString() == "5")
        { ShowAlertMessage("عفواً لايمكنك الترجمة"); }
        else
        {
            if (content_type.Value != "0")
            {
                if (content_id.Value != "0")
                    row_id = CDataConverter.ConvertToInt(((Button)sender).CommandArgument);
                myRowIndex1.Value = ((Button)sender).CommandName;

               
                authors_details_DT dt = authors_details_DB.SelectByID(row_id);
                txt_enmoalf.Text = dt.name;
                //trsave.Visible = true;
                btn_moalf_ar.Visible = true;
                trtrgma.Visible = true;
                //tbl_translate.Visible = true;
                
                // tbl_all.Visible = false;
            }
        }
    }

}
