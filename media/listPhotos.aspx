<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="listPhotos.aspx.cs" Inherits="Esdarat_listPhotos" Title="قائمة الصور" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
   
    <table cellpadding="0px" cellspacing="5px" width="100%" style="table-layout: inherit">
        <tr>
            <td>
                <asp:ImageButton ID="backbtn" runat="server" ToolTip="مجموعة الصور السابقة" ImageAlign="Middle"
                    ImageUrl="~/img/arrow_left.png" OnClick="backbtn_Click" />
            </td>
            <td id="Td1" runat="server" style="left: inherit" align="center" dir="<%$Resources:Master, dir%>">
                <object type="application/x-shockwave-flash" width="900" height="720" id="D01" align="middle">
                    <param name="allowFullScreen" value="true" />
                    <param name="allowscriptaccess" value="always" />
                    <param name="movie" value="myDesign.swf" runat="server" id="emb1" />
                    <param name="quality" value="high" />
                    <param name="wmode" value="transparent" />
                </object>
            </td>
            <td>
                <asp:ImageButton ID="nextbtn" runat="server" ToolTip="مجموعة الصور التالية" ImageAlign="Middle"
                    ImageUrl="~/img/arrow_right.png" OnClick="nextbtn_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
