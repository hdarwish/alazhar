<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master"
    AutoEventWireup="true" CodeFile="Terms_of_use.aspx.cs" Inherits="general_Terms_of_use" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table style="width: 900px; padding-right: 20px; padding-left: 20px; height: 500px"
        id="tableList" runat="server" align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>">
        <tr>
            <td style="vertical-align: top">
                <table id="Table1" runat="server" width="100%">
                    <tr id="Tr1" runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                        valign="top">
                        <td>
                            <div id="Div1" dir="<%$Resources:Master, dir%>" runat="server">
                             <span class="<%$Resources:Master, pagetitle%>" id="Span1" runat="server">
                                <asp:Label ID="Label53" runat="server" Text="<%$Resources:Master, terms%>"></asp:Label>
                              </span>
                            </div>
                        </td>
                    </tr>
                    <tr id="Tr2" runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                        valign="top">
                        <td>
                            <div id="Div2" dir="<%$Resources:Master, dir%>" runat="server">
                                <span id="Span2" class="<%$Resources:Master, links_des%>" runat="server"  dir="<%$Resources:Master, dir%>">
                                <asp:Label ID="Label54" runat="server" Text="<%$Resources:Master,Terms_of_Use%>"></asp:Label>
                                </span>
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
