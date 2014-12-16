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
using System.Text.RegularExpressions;
using System.Data.SqlClient;

public partial class administration_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Clear();
    }
    public void ULogin()
    {
        Regex regex = new Regex("[ء-ي]+");
        if ((regex.IsMatch(TextBox1.Text) || Regex.IsMatch(TextBox1.Text, @"^[a-zA-Z-\d]{1,40}$")) && (regex.IsMatch(TextBox2.Text) || Regex.IsMatch(TextBox2.Text, @"^[a-zA-Z-\d]{1,40}$")))

        {

            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@username", TextBox1.Text), new SqlParameter("@password", TextBox2.Text) };
            DataTable DT = DatabaseFunctions.SelectData(sqlParams, "get_user");
Response.Write(TextBox1.Text.ToString());
            if (DT.Rows.Count > 0)
            {
                Session["thename"] = DT.Rows[0]["name"];
                Session["username"] = DT.Rows[0]["username"];
                Session["password"] = DT.Rows[0]["password"];
                Session["user_type"] = DT.Rows[0]["user_type"];
                Session["user_id"] = DT.Rows[0]["id"];
                Response.Redirect("Default.aspx");
            }
            else
            {
                Label3.Text = "اسم المستخدم او كلمة المرور غير صحيحة";
            }
        }
        else
        {
            Label3.Text = "اسم المستخدم او كلمة المرور غير صحيحة";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ULogin();
    }
}
