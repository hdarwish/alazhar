<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErrorPage.aspx.cs" Inherits="general_ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:Gray;color:White;text-align:center">
        <strong>
            <br />
            <br />
             نأسف لحدوث عطل ما, نرجو اعادة المحاولة فيما بعد</strong>
             <br />
            <br />
            <asp:LinkButton ID="linkmain" runat="server" Text="الرئيسية" PostBackUrl="~/general/Default.aspx"></asp:LinkButton>
    </div>
    </form>
</body>
</html>
