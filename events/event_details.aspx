<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="event_details.aspx.cs" Inherits="events_event_details" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <input id="HiddenID" type="hidden" runat="server" />
    <table cellpadding="0px" cellspacing="5px" width="580px" dir="rtl">
        
        <tr align="right">
            <td align="right" dir="rtl" colspan="2">
                <asp:Label ID="Labtitle" runat="server" CssClass="books_title"></asp:Label>
            </td>
        </tr>
       
      
        <tr runat="server" id="pubtitle">
            <td colspan="4" valign="top" style="text-align: right">
                <asp:ImageButton ID="Img" runat="server" ImageUrl="" Width="200px" hspace="5" vspace="15"
                    ImageAlign="Right" Style="margin-bottom: 0px; margin-left: 10px" />
                <%--<p id="Labdetails" runat="server" dir="rtl" style="text-align: justify; font-size: 14px;
                    width: 100%" class="text">
                </p>--%>
                <asp:Label id="Labdetails" runat="server" dir="rtl" style="text-align: justify; font-size: 14px;
                    width: 100%" class="text"></asp:Label> 
            </td>
        </tr>
        <tr runat="server" id="pubLocation">
            <td align="right" dir="rtl" colspan="2">
                <asp:Label ID="Label4" runat="server" Text=" تاريخ الحدث :" CssClass="books_title"></asp:Label>
                <asp:Label ID="labdate" runat="server" Text=" " CssClass="books_text"></asp:Label>
            </td>
        </tr>
        
    </table>
</asp:Content>

