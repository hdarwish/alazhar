<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs"
    Inherits="user_controls_WebUserControl" %>
    
        <link rel="stylesheet" type="text/css" href="../css/tabview.css" />

<div>
    <div>
        <asp:UpdatePanel runat="server" ID="updat1">
            <ContentTemplate>
                <ajaxToolkit:TabContainer runat="server" ID="tab_continer">
                    <ajaxToolkit:TabPanel runat="server" ID="tab_panel" Width="237px">
                        <HeaderTemplate>
                            <table dir="rtl" class="Tabs" >
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label4" runat="server" CssClass="Label" Font-Size="11px" Text="الصور" />
                                    </td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <ContentTemplate>
                            <div style="width: 70px; height: 70px; float: left; margin-right: 10px;">
                                <img src="../img/pic1.jpg" /></div>
                            <div style="width: 70px; height: 70px; float: left; margin-right: 10px;">
                                <img src="img/img.png" /></div>
                            <div style="width: 70px; height: 70px; float: left">
                                <img src="img/img.png" /></div>
                            <div style="width: 70px; height: 70px; float: left; margin-right: 10px; margin-top: 10px">
                                <img src="img/img.png" /></div>
                            <div style="width: 70px; height: 70px; float: left; margin-right: 10px; margin-top: 10px">
                                <img src="img/img.png" /></div>
                            <div style="width: 70px; height: 70px; float: left; margin-top: 10px">
                                <img src="img/img.png" /></div>
                        </ContentTemplate>
                    </ajaxToolkit:TabPanel>
                    <ajaxToolkit:TabPanel runat="server" ID="TabPanel1"  Width="237px">
                        <HeaderTemplate>
                            <table dir="rtl">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label1" runat="server" CssClass="Label" Font-Size="11px" Text="تسجيلات تليفزيونية" />
                                    </td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <ContentTemplate>
                            <div style="width: 70px; height: 70px; float: left; margin-right: 10px;">
                                <img src="../img/pic1.jpg" /></div>
                            <div style="width: 70px; height: 70px; float: left; margin-right: 10px;">
                                <img src="img/img.png" /></div>
                            <div style="width: 70px; height: 70px; float: left">
                                <img src="img/img.png" /></div>
                            <div style="width: 70px; height: 70px; float: left; margin-right: 10px; margin-top: 10px">
                                <img src="img/img.png" /></div>
                            <img src="img/img.png" /></div>
                            <div style="width: 70px; height: 70px; float: left; margin-top: 10px">
                                <img src="img/img.png" /></div>
                        </ContentTemplate>
                    </ajaxToolkit:TabPanel>
                    
                    <ajaxToolkit:TabPanel runat="server" ID="TabPanel2"  Width="237px">
                        <HeaderTemplate>
                            <table dir="rtl">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label2" runat="server" CssClass="Label" Font-Size="11px" Text="إذاعية" />
                                    </td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <ContentTemplate>
                            <div style="width: 70px; height: 70px; float: left; margin-right: 10px;">
                                <img src="../img/pic1.jpg" /></div>
                            <div style="width: 70px; height: 70px; float: left; margin-right: 10px;">
                                <img src="img/img.png" /></div>
                            <div style="width: 70px; height: 70px; float: left">
                                <img src="img/img.png" /></div>
                            <div style="width: 70px; height: 70px; float: left; margin-right: 10px; margin-top: 10px">
                                <img src="img/img.png" /></div>
                            <img src="img/img.png" /></div>
                            <div style="width: 70px; height: 70px; float: left; margin-top: 10px">
                                <img src="img/img.png" /></div>
                        </ContentTemplate>
                    </ajaxToolkit:TabPanel>
                </ajaxToolkit:TabContainer>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</div>
