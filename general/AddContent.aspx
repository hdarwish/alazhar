﻿<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master"
    AutoEventWireup="true" CodeFile="AddContent.aspx.cs" Inherits="general_AddContent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table style="width: 900px; padding-right: 20px; padding-left: 20px; height: 500px"
        id="tableList" runat="server" align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>">
        <tr>
            <td style="vertical-align: top">
                <table runat="server" width="100%">
                    <tr id="Tr1" runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                        valign="top">
                        <td>
                            <div id="Div1">
                                <span class="<%$Resources:Master, pagetitle%>" id="Span1" runat="server">
                                <asp:Label ID="Label53" runat="server" Text="<%$Resources:Master, AddContent%>" ></asp:Label>
                            </span>
                            </div>
                        </td>
                    </tr>
                    <tr runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                        valign="top">
                        <td>
                            <div id="Div2">
                                 <span id="Span2" class="<%$Resources:Master, links_des%>" runat="server"  dir="<%$Resources:Master, dir%>">
                                <asp:Label ID="Label54" runat="server" Text="<%$Resources:Master,lblContent%>"></asp:Label>
                                </span>
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
