﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testTimeLine.aspx.cs" Inherits="sheikhs_testTimeLine" %>

<%@ Register src="TimeLineShow.ascx" tagname="TimeLineShow" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td>
                
                <uc1:TimeLineShow ID="TimeLineShow1" runat="server" />
                                           
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
