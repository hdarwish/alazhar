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
using Microsoft.Reporting.WebForms;
using System.Collections.Generic;
using System.IO;


public partial class Elements_moetamed : BasePage
{
    public static string id = "";
    private string sql_Connection = Database.ConnectionString;
    General_Helping Obj_General_Helping = new General_Helping();
    // static int smartvalue = 0;




    protected void Page_Load(object sender, EventArgs e)
    {
        // meeting comment 15-09-2014

        if (!IsPostBack)
        {

            //fill_data();
            ViewReport.Visible = true;

        }

    }





    ////////////////////////////////////////////////////////////////////////////////////




    protected void object_type_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void ViewReport_Click(object sender, EventArgs e)
    {
        string t1;
        string t2;

        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
       
        List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "";

        reportPath = "/Azhar_report/Elements_Etemaed";
        ReportViewer1.ServerReport.ReportPath = reportPath;
        if (string.IsNullOrEmpty(txtDateFrom.Text) && string.IsNullOrEmpty(txtDateTo.Text))
        {
            t1 = DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", null).ToString("dd/MM/yyyy");
            t2 = DateTime.MaxValue.ToString("dd/MM/yyyy");

        }
        else if (string.IsNullOrEmpty(txtDateFrom.Text))
        {
            if (Dates.Dates_operations.date_validate(txtDateTo.Text.Trim()) != "")
            {
                t1 = DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", null).ToString("dd/MM/yyyy");

                t2 = Dates.Dates_operations.date_validate(txtDateTo.Text.Trim());
                // sql += " AND convert(VARCHAR(50),f.File_date,103) < = '" + t2.ToString() + "'";
            }
            else
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('ادخل التاريخ بطريقة صحيحة')</script>");

                txtDateFrom.Text = "";
                txtDateTo.Text = "";

                return;
            }

        }

        else if (string.IsNullOrEmpty(txtDateTo.Text))
        {
            if (Dates.Dates_operations.date_validate(txtDateFrom.Text.Trim()) != "")
            {
                t2 = DateTime.MaxValue.ToString("dd/MM/yyyy");
                t1 = Dates.Dates_operations.date_validate(txtDateFrom.Text.Trim());
                // sql += " AND convert(datetime,f.File_date,103) > = '" + t1.ToString() + "'";
            }
            else
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('ادخل التاريخ بطريقة صحيحة')</script>");

                txtDateFrom.Text = "";
                txtDateTo.Text = "";

                return;
            }
        }

        else
        {
            if (Dates.Dates_operations.date_validate(txtDateTo.Text.Trim()) != "" && Dates.Dates_operations.date_validate(txtDateFrom.Text.Trim()) != "")
            {

                t2 = Dates.Dates_operations.date_validate(txtDateTo.Text.Trim());
                t1 = Dates.Dates_operations.date_validate(txtDateFrom.Text.Trim());
                // sql += " AND convert(datetime,f.File_date,103) > = '" + t1.ToString() + "'";
                // sql += " AND convert(datetime,f.File_date,103) < = '" + t2.ToString() + "'";
            }
            else
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('ادخل التاريخ بطريقة صحيحة')</script>");

                txtDateFrom.Text = "";
                txtDateTo.Text = "";

                return;
            }

        }

        DateTime date3 = DateTime.ParseExact(t1, "dd/MM/yyyy", null);
        DateTime date4 = DateTime.ParseExact(t2, "dd/MM/yyyy", null);
        if (date4.Subtract(date3).Days < 0)
        {
          
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('التاريخ الموجود بحقل الي تاريخ يجب ان يكون أكبر من او يساوي التاريخ الموجود بحقل من تاريخ')</script>");
            return;
        }

        parameters.Add(new ReportParameter("Start_date", t1));
        parameters.Add(new ReportParameter("end_date", t2));
        // parameters.Add(param);
        ReportViewer1.ServerReport.SetParameters(parameters);



        ReportViewer1.ServerReport.ReportPath = reportPath;


        ReportViewer1.ProcessingMode = ProcessingMode.Remote;


        ReportViewer1.ShowParameterPrompts = false;

        ReportViewer1.ShowPromptAreaButton = false;

        ReportViewer1.ServerReport.Refresh();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        string elem_image = "";
        string elem_file = "";


        string t1;
        string t2;
        if (string.IsNullOrEmpty(txtDateFrom.Text) && string.IsNullOrEmpty(txtDateTo.Text))
        {
            t1 = DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", null).ToString("dd/MM/yyyy");
            t2 = DateTime.MaxValue.ToString("dd/MM/yyyy");

        }
        else if (string.IsNullOrEmpty(txtDateFrom.Text))
        {
            if (Dates.Dates_operations.date_validate(txtDateTo.Text.Trim()) != "")
            {
                t1 = DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", null).ToString("dd/MM/yyyy");

                t2 = Dates.Dates_operations.date_validate(txtDateTo.Text.Trim());
                // sql += " AND convert(VARCHAR(50),f.File_date,103) < = '" + t2.ToString() + "'";
            }
            else
            {

                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('ادخل التاريخ بطريقة صحيحة')</script>");

                txtDateFrom.Text = "";
                txtDateTo.Text = "";

                return;
            }

        }

        else if (string.IsNullOrEmpty(txtDateTo.Text))
        {
            if (Dates.Dates_operations.date_validate(txtDateFrom.Text.Trim()) != "")
            {
                t2 = DateTime.MaxValue.ToString("dd/MM/yyyy");
                t1 = Dates.Dates_operations.date_validate(txtDateFrom.Text.Trim());
                // sql += " AND convert(datetime,f.File_date,103) > = '" + t1.ToString() + "'";
            }
            else
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('ادخل التاريخ بطريقة صحيحة')</script>");

                txtDateFrom.Text = "";
                txtDateTo.Text = "";

                return;
            }
        }

        else
        {
            if (Dates.Dates_operations.date_validate(txtDateTo.Text.Trim()) != "" && Dates.Dates_operations.date_validate(txtDateFrom.Text.Trim()) != "")
            {

                t2 = Dates.Dates_operations.date_validate(txtDateTo.Text.Trim());
                t1 = Dates.Dates_operations.date_validate(txtDateFrom.Text.Trim());
                // sql += " AND convert(datetime,f.File_date,103) > = '" + t1.ToString() + "'";
                // sql += " AND convert(datetime,f.File_date,103) < = '" + t2.ToString() + "'";
            }
            else
            {
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('ادخل التاريخ بطريقة صحيحة')</script>");
                txtDateFrom.Text = "";
                txtDateTo.Text = "";

                return;
            }

        }

        DateTime date3 = DateTime.ParseExact(t1, "dd/MM/yyyy", null);
        DateTime date4 = DateTime.ParseExact(t2, "dd/MM/yyyy", null);
        if (date4.Subtract(date3).Days < 0)
        {
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('التاريخ الموجود بحقل الي تاريخ يجب ان يكون أكبر من او يساوي التاريخ الموجود بحقل من تاريخ')</script>");
            return;
        }


        SqlParameter[] sqlparam = new SqlParameter[] 
        {
            new SqlParameter("@Start_date", t1),
            new SqlParameter("@end_date", t2)  
           
        };

        dt = DatabaseFunctions.SelectData(sqlparam, "Proc_Elements_Moetamed");
        if (dt.Rows.Count > 0)
        {
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                elem_image = dt.Rows[x]["small_image"].ToString();
                if (!string.IsNullOrEmpty(elem_image))
                {

                    int indexof = elem_image.LastIndexOf('\\') + 1;

                    string noimage_name = elem_image.Substring(0, indexof);

                    string path = MapPath("~") + "\\Backup\\" + noimage_name;
                    string path0 = MapPath("~") + "\\" + elem_image;
                    string path1 = MapPath("~") + "\\Backup\\" + elem_image;

                    checkDir(path);

                    if (File.Exists(path0) == true)
                    {
                        //if (File.Exists(path1) == false)
                        {
                            try
                            {
                                File.Copy(path0, path1,true);
                            }
                            catch 
                            { }
                             
                        }
                    }
                }
                elem_file = dt.Rows[x]["file_name"].ToString();
                if (!string.IsNullOrEmpty(elem_file))
                {

                    int indexof = elem_file.LastIndexOf('\\') + 1;

                    string nof_name = elem_file.Substring(0, indexof);

                    string path = MapPath("~") + "\\Backup\\" + nof_name;
                    string path0 = MapPath("~") + "\\" + elem_file;
                    string path1 = MapPath("~") + "\\Backup\\" + elem_file;

                    checkDir(path);

                    if (File.Exists(path0) == true)
                    {

                        //if (File.Exists(path1) == false)
                        {
                            try
                            {
                                File.Copy(path0, path1,true);
                            }
                            catch { };
                        }
                    }
                }
                Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم الانتهاء ')</script>");
            }
        }
    }

    private Boolean checkDir(String path)
    {
        bool exist = true;
        DirectoryInfo dir = new DirectoryInfo(path);

        if (dir.Exists == false)
        {
            try
            {
                dir.Create();
            }
            catch { exist = false; };
            return exist;
        }
        else
        {
            exist = true;
            return exist;
        }

    }
}