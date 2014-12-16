<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master"
    AutoEventWireup="true" CodeFile="about_website.aspx.cs" Inherits="general_about_website" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table cellpadding="0" cellspacing="0" dir="rtl">
        <tr>
            <td style="width: 20px">
            </td>
            <td valign="top">
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <td colspan="3" runat="server" align="<%$Resources:Master, align%>">
                            <span class="<%$Resources:Master, pagetitle%>" id="tr1" runat="server">
                                <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, aboutus%>"></asp:Label>
                            </span>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 25px">
                            <span id="Span1" class="<%$Resources:Master, links_des%>" runat="server"  dir="<%$Resources:Master, dir%>">
                                <asp:Label ID="Label22" runat="server" Text="<%$Resources:Master, txt1%>"></asp:Label>
                            </span>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="width: 20px">
            </td>
        </tr>
    </table>
</asp:Content>
