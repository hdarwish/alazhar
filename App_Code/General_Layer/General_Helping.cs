using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections;

/// <summary>
/// Summary description for General_Helping
/// </summary>
public class General_Helping
{

    public void SmartBindDDL(DropDownList DropDownList, DataTable DataSource, String DataValueField, String DataTextField, String FristText)
    {
        DropDownList.DataValueField = DataValueField;
        DropDownList.DataTextField = DataTextField;
        DropDownList.DataSource = DataSource;
        DropDownList.DataBind();
        DropDownList.Items.Insert(0, FristText);
    }

    public static DataTable GetDataTable(string SQL)
    {

        return SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.Text, SQL).Tables[0];

    }


    public static int ExcuteQuery(string SQL)
    {
        return CDataConverter.ConvertToInt( SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.Text, SQL));

    }

   

}
