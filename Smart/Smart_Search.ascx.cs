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



public partial class Smart_Search : System.Web.UI.UserControl
{

    public delegate void Delegate_Selected_Value(string strValue);

    public event Delegate_Selected_Value Value_Handler;


    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (CDataConverter.ConvertToInt(SelectedValue) > 0)
            Set_Color_Selected_Value();
        else
            Set_Color_Not_Selected_Value();


        // }

    }

    public int Items_Count
    {

        get
        {
            return Grdvew_Search.Rows.Count;
        }
    }

    public string Value_Field
    {

        get
        {
            //if (Query_Value_Field == "")
            return this.hidden_Value_Field.Text;
            //return Query_Value_Field;
        }
        set
        {
            // Query_Value_Field = value;
            this.hidden_Value_Field.Text = value;

        }

    }

    public string Text_Field
    {

        get
        {
            return this.hidden_Text_Field.Text;
        }
        set
        {
            this.hidden_Text_Field.Text = value;

        }

    }

    public string SelectedValue
    {

        get
        {
            return hidden_Value.Value;
        }
        set
        {
            hidden_Value.Value = value;
            txt_Id.Text = value;
            this.lbl_Value.Text = value;
            if (txt_Id.Text!="")
            Fil_Cntrl_by_txt_ID();
            Set_Color_Selected_Value();
            Div_Grid.Style.Add("display", "block");


        }

    }

    public string SelectedText
    {

        get
        {
            return txt_Name.Text;
        }
        set {
            txt_Name.Text = value;
        }
       
    }

    public bool Show_Code
    {

        set
        {
            if (value == true)
            {
                this.Div_Code.Visible =
                this.Grdvew_Search.Columns[0].Visible = true;
                Div_Grid.Style.Add("width", "350px");
            }
            else
            {
                this.Div_Code.Visible =
                this.Grdvew_Search.Columns[0].Visible = false;
                Div_Grid.Style.Add("width", "250px");
            }


        }
    }

    private void Set_Color_Selected_Value()
    {
        this.txt_Id.BackColor = System.Drawing.Color.FromName("#F2EDDB");
        this.txt_Name.BackColor = System.Drawing.Color.FromName("#F2EDDB");
    }

    private void Set_Color_Not_Selected_Value()
    {
        txt_Id.BackColor = System.Drawing.Color.FromName("#FFFFFF");
        txt_Name.BackColor = System.Drawing.Color.FromName("#FFFFFF");
    }

    public override void DataBind()
    {
        //Clear_Selected();
        Fil_Grid(Query,stored,stored_parameters);

    }

    public void Clear_Controls()
    {
        this.hidden_Value.Value =
             this.lbl_Value.Text =
        this.txt_Id.Text =
        this.SelectedValue =
        this.txt_Name.Text = "";
        if (Value_Handler != null)
            Value_Handler(txt_Id.Text);
        Set_Color_Not_Selected_Value();
        this.Grdvew_Search.DataSource = new DataTable();
        this.Grdvew_Search.DataBind();

    }

    public void Clear_Selected()
    {
        this.SelectedValue=
        this.hidden_Value.Value =
             this.lbl_Value.Text =
        this.txt_Id.Text =
        this.SelectedValue =
        this.txt_Name.Text = "";
        //if (Value_Handler != null)
        //    Value_Handler("");
        //Fil_Grid(Query, stored, stored_parameters);


    }
    protected void btn_Clear_Click(object sender, EventArgs e)
    {
        this.Clear_Selected();
    }


    public string Validation_Group
    {

        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.RequiredFieldValidator3.Visible = true;
                this.RequiredFieldValidator3.ValidationGroup = value;
            }
            else
                this.RequiredFieldValidator3.Visible = false;


        }
    }

    public string Query
    {
        get
        {
            return this.hiden_Query.Text;
        }
        set
        {
            //Select_Query = value;
            this.hiden_Query.Text = value;
            //if (string.IsNullOrEmpty(Txt_Original_Query.Text))
            //    Txt_Original_Query.Text = value;
        }
    }

    public string stored
    {
        get
        {
            return hidden_stored.Value;
        }
        set
        {
            //Select_Query = value;
            hidden_stored.Value = "";
            hidden_stored.Value = value;
            //if (string.IsNullOrEmpty(Txt_Original_Query.Text))
            //    Txt_Original_Query.Text = value;
        }
    }

    public string sql_Connection
    {
        get
        {
            return this.hiden_Con_Query.Text;
        }
        set
        {
            //sql_Connection = value;
            this.hiden_Con_Query.Text = value;
        }
    }


    public SqlParameter[] stored_parameters
    {
        get
        {
            
            string[] paramtercountarr=hidden_stored_parameters.Value.Split('#');
            SqlParameter[] sqlParamsArray = new SqlParameter[paramtercountarr.Length];
            
            for (int i = 0; i < paramtercountarr.Length; i++)
            {
                SqlParameter tempsqlparam = new SqlParameter();
                tempsqlparam.ParameterName= paramtercountarr[i].Split(',')[0].ToString();
                //sqlParamsArray[i]
                if (paramtercountarr[i].Split(',')[2].ToString().ToLower() == "system.int32")

                    tempsqlparam.Value = CDataConverter.ConvertToInt(paramtercountarr[i].Split(',')[1]);
               else
                    tempsqlparam.Value = paramtercountarr[i].Split(',')[1].ToString();

                sqlParamsArray[i] = tempsqlparam;
            }
            return sqlParamsArray;
        }
        set
        {

            hidden_stored_parameters.Value = "";
            string[,] paramArray = new string[value.Length, 3];
            for (int i = 0; i < paramArray.GetLength(0); i++)
            {
                paramArray[i, 0] = value[i].ParameterName.ToString();
                paramArray[i, 1] = value[i].Value.ToString();
                paramArray[i, 2] = value[i].Value.GetType().ToString();
                if (i != paramArray.GetLength(0) - 1)
                    hidden_stored_parameters.Value += paramArray[i, 0] + "," + paramArray[i, 1] + "," + paramArray[i, 2] + "#";
                else
                    hidden_stored_parameters.Value += paramArray[i, 0] + "," + paramArray[i, 1] + "," + paramArray[i, 2];
            }
             
        }
    }
   
    protected void btn_Search_Click(object sender, EventArgs e)
    {
        hidden_Searched.Value = "1";
        Search_Grid();

    }

    protected void txt_Id_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt_Id.Text) )
        {
            //Fil_Cntrl_by_txt_ID();
            this.lbl_Value.Text = hidden_Value.Value = txt_Id.Text ;
            
            this.SelectedValue = hidden_Value.Value;
            if (Value_Handler != null)
            {
                if (stored == "get_places_titles")
                    Value_Handler("4");
                else if (stored == "get_characters_titles")
                    Value_Handler("1");
                else if (stored == "get_events_titles")
                    Value_Handler("2");
                else if (stored == "get_topics_titles")
                    Value_Handler("3");
                else if (stored == "get_artifacts_titles")
                    Value_Handler("5");
                else if (stored == "get_video_titles")
                    Value_Handler("6");
                else if (stored == "get_audio_titles")
                    Value_Handler("7");
                else if (stored == "get_docs_titles")
                    Value_Handler("8");
                else if (stored == "get_articles_titles")
                    Value_Handler("9");
                else if (stored == "get_books_titles")
                    Value_Handler("10");
                else if (stored == "get_images_titles")
                    Value_Handler("11");
                else if (stored == "get_manuscripts_titles")
                    Value_Handler("12");
                else if (stored == "get_theses_titles")
                    Value_Handler("13");
                else if (stored == "get_conference_proceedings_titles")
                    Value_Handler("14");
                else if (stored == "get_website_titles")
                    Value_Handler("15");
                else if (stored == "get_glossary_titles")
                    Value_Handler("16");
            }
        }
        else
        {
            
            Clear_Controls();
            Fil_Grid(Query,stored,stored_parameters);
        }
    }
    protected void txt_Name_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txt_Name.Text))
        {
            Clear_Controls();
            Fil_Grid(Query, stored, stored_parameters);
        }
        else
        {
            hidden_Searched.Value = "1";
            Search_Grid();

        }
    }
  

    private void Fil_Cntrl_by_txt_ID()
    {
        try
        {
            if (!string.IsNullOrEmpty(Query))
             {
            if (!string.IsNullOrEmpty(txt_Id.Text))
            {
                string Sql_Query = "";
                if (Query.ToLower().Contains("where"))
                    Sql_Query = Query.ToLower() + " and ";
                else
                    Sql_Query = Query.ToLower() + " where ";



                Sql_Query += Value_Field + "  = " + txt_Id.Text;

                SqlConnection con = new SqlConnection(sql_Connection);
                SqlCommand comnd = new SqlCommand(Sql_Query, con);
                SqlDataAdapter obj = new SqlDataAdapter(comnd);
                DataTable Dt = new DataTable();
                obj.Fill(Dt);
                if (Dt.Rows.Count > 0)
                {
                    this.lbl_Value.Text = hidden_Value.Value = txt_Id.Text;
                    txt_Id.Text = txt_Id.Text;
                    txt_Name.Text = Dt.Rows[0][Text_Field.Trim().ToLower().ToString()].ToString();
                    if (Value_Handler != null)
                        Value_Handler(txt_Id.Text);
                    //Fil_Grid(Sql_Query);

                }
                else
                {
                    // Clear_Controls();
                    txt_Id.Text =
                        txt_Name.Text = "";
                }


            }

        }
            else if (!string.IsNullOrEmpty(stored))
            {
                if (txt_Id.Text != "--- البحث بالكود ----" && txt_Id.Text != "")
                {
                    DataTable searchDt = DatabaseFunctions.SelectData(stored_parameters, stored);

                    DataTable resultDT = searchDt.Clone();
                   
                    DataRow[] foundRows;
                    foundRows = searchDt.Select("" + Value_Field + " =" + txt_Id.Text+"" );
                        for (int i = 0; i < foundRows.Length; i++)
                        {

                            resultDT.ImportRow(foundRows[i]);
                            resultDT.AcceptChanges();
                        }
                        if (resultDT.Rows.Count > 0)
                        {
                            this.lbl_Value.Text = hidden_Value.Value = txt_Id.Text;
                            txt_Id.Text = txt_Id.Text;
                            
                            txt_Name.Text = resultDT.Rows[0][Text_Field.Trim().ToLower().ToString()].ToString();
                            //if (Value_Handler != null)
                            //    Value_Handler(txt_Id.Text);
                            

                        }
                        else
                        {
                            
                            txt_Id.Text =
                                txt_Name.Text = "";
                        }
                   
                   
                    
                }
            }
        }

        catch
        {
        }
    
    }

    private void Search_Grid()
    {
        string value = rdl_Search.SelectedValue;
        string Sql_Query = "";
        if (!string.IsNullOrEmpty(Query))
        {
            if (Query.ToLower().Contains("where"))
                Sql_Query = Query.ToLower() + " and ";
            else
                Sql_Query = Query.ToLower() + " where ";

            if (hidden_Searched.Value == "1")
            {
                if (txt_Id.Text != "")
                {
                    if (value == "1")
                        Sql_Query += Value_Field + "  Like N'%" + txt_Id.Text + "%' and ";
                    else if (value == "2")
                        Sql_Query += Value_Field + " Like N'%" + txt_Id.Text + "' and ";

                }
                if (txt_Name.Text != "")
                {
                    if (value == "1")
                        Sql_Query += Text_Field + "   Like N'%" + txt_Name.Text + "%'";
                    else if (value == "2")
                        Sql_Query += Text_Field + " Like N'" + txt_Name.Text + "%'";

                }
            }


            Sql_Query = Sql_Query.Trim();

            if (Sql_Query.Substring(Sql_Query.Length - 5, 5) == "where")
                Sql_Query = Sql_Query.Substring(0, Sql_Query.Length - 5);
            else if (Sql_Query.Substring(Sql_Query.Length - 3, 3) == "and")
                Sql_Query = Sql_Query.Substring(0, Sql_Query.Length - 3);

            Fil_Grid(Sql_Query, stored, stored_parameters);



            //Page.RegisterStartupScript("Sucess", "<script language=javascript></script>");
            Div_Grid.Style.Add("display", "none");
            //Div_Grid.Visible = true;
        }
        else if (!string.IsNullOrEmpty(stored) )
        {
            if (hidden_Searched.Value == "1")
            {
                DataTable searchDt = DatabaseFunctions.SelectData(stored_parameters, stored);

                DataTable resultDT = searchDt.Clone();
                DataRow[] foundRows;
                
                if (searchDt.Rows.Count > 0)
                {

                    if (txt_Id.Text != "--- البحث بالكود ----" && txt_Id.Text != "")
                    {
                        
                            foundRows = searchDt.Select(Value_Field + " = " +  txt_Id.Text + "");
                            for (int i = 0; i < foundRows.Length; i++)
                            {

                                resultDT.ImportRow(foundRows[i]);
                                resultDT.AcceptChanges();
                            }
                        
                        
                    }
                    else if (txt_Name.Text != "--- البحث بالإسم ----" && txt_Name.Text != "")
                    {
                        if (value == "1")
                        {
                            ArrayList Arr =  Utils.StringUtils.GetPermutations(txt_Name.Text);
                            string Txt_Query = "";
                            for (int i = 0; i < Arr.Count; i++)
                            {
                                if (i < Arr.Count-1)
                                    Txt_Query += Text_Field +" like '%" + Arr[i] + "%' or ";
                                else
                                    Txt_Query += Text_Field + " like '%" + Arr[i] + "%'";
                            }
                            //foundRows = searchDt.Select(Text_Field + " like '%" + txt_Name.Text + "%'");
                            foundRows = searchDt.Select( Txt_Query);
                           
                            for (int i = 0; i < foundRows.Length; i++)
                            {

                                resultDT.ImportRow(foundRows[i]);
                                resultDT.AcceptChanges();
                            }
                        }
                        else if (value == "2")
                        {
                            foundRows = searchDt.Select(Text_Field + " like '%" + txt_Name.Text + "'");
                            for (int i = 0; i < foundRows.Length; i++)
                            {

                                resultDT.ImportRow(foundRows[i]);
                                resultDT.AcceptChanges();
                            }
                        }
                    }
                    else if (txt_Name.Text == "--- البحث بالإسم ----" || txt_Name.Text != "")
                    {
                        Fil_Grid(Sql_Query, stored, stored_parameters);
                        return;
                    }


                   
                   
                }



                Grdvew_Search.DataSource = resultDT;
                Grdvew_Search.DataBind();
            }
        }
    }

    private void Fil_Grid(string Sql_Query, string spName, SqlParameter[] sparams)
    {

        if (!string.IsNullOrEmpty(Sql_Query))
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=M116-YOUSSEF;Initial Catalog=Test;Persist Security Info=True;User ID=sa;Password=sa");
                SqlConnection con = new SqlConnection(sql_Connection);
                SqlCommand comnd = new SqlCommand(Sql_Query, con);
                SqlDataAdapter obj = new SqlDataAdapter(comnd);
                DataTable Dt = new DataTable();
                obj.Fill(Dt);
                Grdvew_Search.DataSource = Dt;
                Grdvew_Search.DataBind();
                // Query = Txt_Original_Query.Text;
            }
            catch
            { }


        }
        else if (!string.IsNullOrEmpty(spName))
        {
            try
            {
                DataTable Dt =new DataTable();
                if (sparams.Length > 0)
                    Dt = DatabaseFunctions.SelectData(sparams, spName);
                else
                     Dt = DatabaseFunctions.SelectDataWithoutParams(spName);
                Grdvew_Search.DataSource = Dt;
                Grdvew_Search.DataBind();
               
                
            }
            catch
            { }
        }

    }

    protected void GrdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int Current_PageIndex = Grdvew_Search.PageIndex;
        int New_PageIndex = 0;
        if (e.CommandName == "Select")
        {
            string str = e.CommandArgument.ToString();
            string[] arrstr = str.Split(',');
            this.lbl_Value.Text = hidden_Value.Value = txt_Id.Text = arrstr[0].ToString();
            txt_Name.Text = arrstr[1].ToString();
            this.SelectedValue = hidden_Value.Value;
            if (Value_Handler != null)
            {
                if (stored == "get_places_titles")
                Value_Handler("4");
                else if (stored == "get_characters_titles")
                    Value_Handler("1");
                else if (stored == "get_events_titles")
                    Value_Handler("2");
                else if (stored == "get_topics_titles")
                    Value_Handler("3");
                else if (stored == "get_artifacts_titles")
                    Value_Handler("5");
                else if (stored == "get_video_titles")
                    Value_Handler("6");
                else if (stored == "get_audio_titles")
                    Value_Handler("7");
                else if (stored == "get_docs_titles")
                    Value_Handler("8");
                else if (stored == "get_articles_titles")
                    Value_Handler("9");
                else if (stored == "get_books_titles")
                    Value_Handler("10");
                else if (stored == "get_images_titles")
                    Value_Handler("11");
                else if (stored == "get_manuscripts_titles")
                    Value_Handler("12");
                else if (stored == "get_theses_titles")
                    Value_Handler("13");
                else if (stored == "get_conference_proceedings_titles")
                    Value_Handler("14");
                else if (stored == "get_website_titles")
                    Value_Handler("15");
                else if (stored == "get_glossary_titles")
                    Value_Handler("16");
               
            }
            //Div_Grid.Visible = false;
            hidden_Searched.Value = "2";
            Search_Grid();
            Div_Grid.Style.Add("display", "none");
            Set_Color_Selected_Value();

        }
        else if (e.CommandName == "nextPage")
        {
            if (Current_PageIndex != Grdvew_Search.PageCount)
                New_PageIndex = Current_PageIndex + 1;
        }
        else if (e.CommandName == "first")
        {
            New_PageIndex = 0;
        }
        else if (e.CommandName == "lastPage")
        {
            New_PageIndex = Grdvew_Search.PageCount;
        }
        else if (e.CommandName == "prev")
        {
            if (Current_PageIndex > 0)
                New_PageIndex = Current_PageIndex - 1;
        }

        if (e.CommandName != "Select")
        {
            Div_Grid.Style.Add("display", "block");
            Grdvew_Search.PageIndex = New_PageIndex;
            // Grdvew_Search.DataBind();
            Fil_Grid(Query, stored, stored_parameters);
        }
    }

    protected void Grdvew_Search_DataBound(object sender, EventArgs e)
    {
        try
        {
            GridViewRow pagerRow = Grdvew_Search.BottomPagerRow;

            Label lbl_Page_Info = (Label)pagerRow.Cells[0].FindControl("lbl_Page_Info");



            if (lbl_Page_Info != null)
            {
                int currentPage = Grdvew_Search.PageIndex + 1;

                lbl_Page_Info.Text = "صفحة " + currentPage.ToString() +
                " من " + Grdvew_Search.PageCount.ToString();
            }

        }
        catch (Exception ex)
        {

        }
    }

    public string Get_Valid_Group()
    {
        return "A";
    }


}