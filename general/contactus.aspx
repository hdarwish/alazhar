<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="contactus.aspx.cs" Inherits="contactus" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <link href="../css/CSS.css" rel="stylesheet" type="text/css" />
    <link href="../css/StyleSheet.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="../css/tabview.css" />
    <link href="../css/div_1.css" rel="stylesheet" type="text/css" />
    <link href="../css/div_2.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="../CSS/custMenu.css" type="text/css">
    <link href="" runat="server" id="mainclass" rel="stylesheet" type="text/css" />
    <link href="../css/detailsCSS.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript" src="../Js/tabview.js"></script>

    <input id="HiddenID" type="hidden" runat="server" />
    <input id="hidden_id" type="hidden" runat="server" />
    <input id="hidden_eve" type="hidden" runat="server" />
    <input id="hidden_top" type="hidden" runat="server" />
    <input id="hidden_plac" type="hidden" runat="server" />
    <table cellpadding="0" cellspacing="0" runat="server" class="_page" dir="<%$ Resources:Master, dir %>">
        <tr runat="server" valign="top">
            <td style="width: 20px">
            </td>
            <td style="width: 400px" valign="top">
                <table cellpadding="0" cellspacing="0" runat="server">
                    <tr>
                        <td colspan="3">
                            <asp:Label ID="Label53" runat="server" Text="<%$ Resources:Master, key_AlAzhar %>"
                                class="text_Brown_10pt_bold"></asp:Label>
                            <span class="pagetitle"></span>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 25px">
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <span style="font-family: tahoma; color: #000000; font-size: 14px;">
                                <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Master, key_address %>"></asp:Label>
                            </span>
                        </td>
                        <td style="width: 5px">
                        </td>
                        <td>
                            <span style="font-family: tahoma; color: #815e28; font-size: 13px; text-decoration: none;">
                                <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Master, key_dece_address %>"></asp:Label>
                            </span>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 15px">
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span style="font-family: tahoma; color: #000000; font-size: 14px;">
                                <asp:Label ID="Label3" runat="server" Text="<%$ Resources:Master, key_phone %>"></asp:Label>
                            </span>
                        </td>
                        <td style="width: 5px">
                        </td>
                        <td>
                            <span style="font-family: tahoma; color: #815e28; font-size: 13px;">02-25902518 - 02-25925308</span>
                        </td>
                    </tr>
                    <tr>
                        <td nowrap>
                            <span style="font-family: tahoma; color: #000000; font-size: 14px;">
                                <asp:Label ID="Label4" runat="server" Text="<%$ Resources:Master, email %>"></asp:Label>
                            </span>
                        </td>
                        <td style="width: 5px">
                        </td>
                        <td>
                            <span style="font-family: tahoma; color: #815e28; font-size: 13px;"><a href="mailto:alazharmemory@gmail.com">alazharmemory@gmail.com</a></span>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <img src="../images/contactus.jpg" width="500" />
            </td>
        </tr>
    </table>
</asp:Content>
