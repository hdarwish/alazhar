<%@ Control Language="C#" AutoEventWireup="true" CodeFile="leftUC.ascx.cs" Inherits="masterpage_leftUC" %>
<style type="text/css">
    .style1
    {
        width: 150px;
    }
</style>
<table style="width: 160px">
    <tr id="trContent" runat="server">
        <td align="center" class="style1">
            <asp:Label ID="Label6" runat="server" Text="عناصر مرتبطة بالشخصية" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
        </td>
    </tr>
</table>
<table style="border-color: Black; border-width: thin; width: 160px" align="left" dir="ltr" cellspacing="5">
    <tr>
        <td align="right" class="style1">
            <a href="~/media/photo_gallery.aspx" runat="server" id="images_link" class="out_links3" style="text-decoration: none">
                
                <asp:Label ID="images_count" runat="server" Text=""></asp:Label>&nbsp; الصور</a>
        </td>
    </tr>
    <tr>
        <td align="right" class="style1">
            <a href="~/Esdarat/list_document.aspx" runat="server" id="docs_link" class="out_links3" style="text-decoration: none">
                
                <asp:Label ID="docs_count" runat="server" Text=""></asp:Label>&nbsp;الوثائق</a>
        </td>
    </tr>
    <tr>
        <td align="right" class="style1">
            <a href="" onclick="javascript : void(0);" runat="server" id="manuscripts_link" class="out_links3" style="text-decoration: none">
                
                <asp:Label ID="manuscripts_count" runat="server" Text=""></asp:Label>&nbsp;المخطوطات</a>
        </td>
    </tr>
    <tr>
        <td align="right" class="style1">
            <a href="~/Esdarat/list_characters_books.aspx" runat="server" id="books_link" class="out_links3" style="text-decoration: none">
                
                <asp:Label ID="books_count" runat="server" Text=""></asp:Label>&nbsp;الكتب الإلكترونية</a>
        </td>
    </tr>
    <tr>
        <td align="right" class="style1">
            <a href="~/Esdarat/list_articles.aspx" runat="server" id="articles_link" class="out_links3" style="text-decoration: none">
                
                <asp:Label ID="articles_count" runat="server" Text=""></asp:Label>&nbsp;المقالات</a>
        </td>
    </tr>
    <tr>
        <td align="right" class="style1">
            <a href="~/media/audio_tracks.aspx" runat="server" id="audios_link" class="out_links3" style="text-decoration: none">
                
                <asp:Label ID="audios_count" runat="server" Text=""></asp:Label>&nbsp;التسجيلات الاذاعية</a>
        </td>
    </tr>
    <tr>
        <td align="right" class="style1">
            <a href="~/media/video_tracks.aspx" runat="server" id="videos_link" class="out_links3" style="text-decoration: none">
                
                <asp:Label ID="videos_count" runat="server" Text=""></asp:Label>&nbsp;التسجيلات التلفزيونية</a>
        </td>
    </tr>
    <tr>
        <td align="right" class="style1">
            <a href="" onclick="javascript : void(0);" runat="server" id="artifacts_link" class="out_links3" style="text-decoration: none">
                
                <asp:Label ID="artifacts_count" runat="server" Text=""></asp:Label>&nbsp;القطع المتحفية</a>
        </td>
    </tr>
</table>
