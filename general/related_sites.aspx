<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true" CodeFile="related_sites.aspx.cs" Inherits="general_related_sites" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<table cellpadding="0" cellspacing="0">
<tr>
<td style="width:20px"></td>
<td><table cellpadding="0" cellspacing="0">

<tr><td  runat="server" align="<%$Resources:Master, align%>">
<span runat="server" class="<%$Resources:Master, pagetitle%>">
    <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, website_links%>"></asp:Label>
</span>
</td></tr>
<tr>


<td>
<table cellpadding="0" cellspacing="0" runat="server" dir="<%$Resources:Master, dir%>">

<tr><td style="height:30px"></td></tr>

<tr><td valign="top">

<table cellpadding="0" cellspacing="0" runat="server" dir="<%$Resources:Master, dir%>">
<tr><td runat="server" align="<%$Resources:Master, align%>">
<span class="<%$Resources:Master, links_rel%>" runat="server" dir="<%$Resources:Master, dir%>">
 <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, txt21%>"></asp:Label>
</span>
</td></tr>

<tr><td style="height:10px"></td></tr>
<tr>
<td runat="server" align="<%$Resources:Master, align%>">
<span class="<%$Resources:Master, links_des%>" runat="server"  dir="<%$Resources:Master, dir%>">
<asp:Label ID="Label3" runat="server" Text="<%$Resources:Master, txt22%>"></asp:Label>
 </span>
 </td></tr>

<tr><td style="height:10px"></td></tr>

<tr><td runat="server" align="<%$Resources:Master, align%>"  dir="<%$Resources:Master, dir%>">
<span class="<%$Resources:Master, links_url_text%>"  dir="<%$Resources:Master, dir%>" runat="server">
<asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, txt23%>"></asp:Label>
</span>
&nbsp;&nbsp;&nbsp;
<a href="http://www.dar-alifta.org" target="_blank" runat="server" class="<%$Resources:Master, links_url%>">www.dar-alifta.org</a>
</td></tr>

</table>
</td>

<td style="width:20px"></td>

<td valign="top" runat="server"  align="<%$Resources:Master, align%>"><img src="../images/links/dar%20eliftaa-logo.jpg" width="120" runat="server" /></td>
</tr>

<tr><td style="height:30px"></td></tr>

<tr>
<td valign="top" >
<table cellpadding="0" cellspacing="0" runat="server" dir="<%$Resources:Master, dir%>" >
<tr>
<td align="<%$Resources:Master, align%>" runat="server">
<span class="<%$Resources:Master,  links_rel%>" runat="server" dir="<%$Resources:Master, dir%>">
 <asp:Label ID="Label5" runat="server" Text="<%$Resources:Master, txt24%>"></asp:Label>
</span>
</td></tr>

<tr><td style="height:10px"></td></tr>
<tr>
<td align="<%$Resources:Master, align%>" runat="server">
<span class="<%$Resources:Master,  links_des%>" dir="<%$Resources:Master, dir%>" runat="server">
<asp:Label ID="Label6" runat="server" Text="<%$Resources:Master, txt25%>"></asp:Label>
 </span></td></tr>
<tr><td style="height:10px"></td></tr>
<tr>
<td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
<span class="<%$Resources:Master, links_url_text%>" runat="server" dir="<%$Resources:Master, dir%>">
<asp:Label ID="Label7" runat="server" Text="<%$Resources:Master, txt23%>"></asp:Label> 
 </span>&nbsp;&nbsp;&nbsp;<a href="http://www.alazhar.gov.eg" runat="server" target="_blank" class="<%$Resources:Master,  links_url%>">www.alazhar.gov.eg</a>
 </td></tr>
</table>
</td>

<td style="width:20px"></td>
<td valign="top" runat="server" dir="<%$Resources:Master, dir%>"><img src="../images/links/educational_azhar_logo.jpg" width="120" runat="server" dir="<%$Resources:Master, dir%>" /></td></tr>

<tr><td style="height:30px"></td></tr>


<tr>
<td valign="top" >
<table cellpadding="0" cellspacing="0" runat="server" dir="<%$Resources:Master, dir%>">
<tr>
<td align="<%$Resources:Master, align%>" runat="server">
<span class="<%$Resources:Master,  links_rel%>" runat="server" dir="<%$Resources:Master, dir%>">
 <asp:Label ID="Label8" runat="server" Text="<%$Resources:Master, txt26%>"></asp:Label>
</span>
</td></tr>

<tr><td style="height:10px"></td></tr>

<tr>
<td align="<%$Resources:Master, align%>" runat="server">
<span class="<%$Resources:Master,  links_des%>" runat="server" dir="<%$Resources:Master, dir%>">
<asp:Label ID="Label9" runat="server" Text="<%$Resources:Master, txt27%>"></asp:Label>
 </span>
 </td></tr>

<tr><td style="height:10px"></td></tr>

<tr>
<td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
<span class="<%$Resources:Master, links_url_text%>" runat="server"  dir="<%$Resources:Master, dir%>">
 <asp:Label ID="Label10" runat="server" Text="<%$Resources:Master, txt23%>"></asp:Label>
 </span>&nbsp;&nbsp;&nbsp;<a href="http://www.azhar.edu.eg" target="_blank" runat="server" class="<%$Resources:Master,  links_url%>">www.azhar.edu.eg</a>
 </td></tr>

</table>
</td>
<td style="width:20px"></td>
<td valign="top" runat="server" dir="<%$Resources:Master, dir%>"><img src="../images/links/azhar_univ.jpg" width="120" runat="server" dir="<%$Resources:Master, dir%>" /></td>
</tr>

<tr><td style="height:30px"></td></tr>

<tr>
<td valign="top" >
<table cellpadding="0" cellspacing="0" runat="server" dir="<%$Resources:Master, dir%>">
<tr>
<td align="<%$Resources:Master, align%>" runat="server">
<span class="<%$Resources:Master,  links_rel%>" runat="server" dir="<%$Resources:Master, dir%>">
<asp:Label ID="Label11" runat="server" Text="<%$Resources:Master, txt28%>"></asp:Label>
 </span>
</td></tr>

<tr><td style="height:10px"></td></tr>

<tr>
<td align="<%$Resources:Master, align%>" runat="server">
<span class="<%$Resources:Master,  links_des%>" dir="<%$Resources:Master, dir%>" runat="server">
<asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, txt29%>"></asp:Label>
 </span>
 </td></tr>

<tr><td style="height:10px"></td></tr>

<tr>
<td align="<%$Resources:Master, align%>"  dir="<%$Resources:Master, dir%>" runat="server">
<span class="<%$Resources:Master, links_url_text%>"  dir="<%$Resources:Master, dir%>" runat="server"> 
 <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, txt23%>"></asp:Label>
</span>&nbsp;&nbsp;&nbsp;<a href="http://www.islamic-council.com" target="_blank" class="<%$Resources:Master,  links_url%>" runat="server">www.islamic-council.com</a></td></tr>
</table>
</td>
<td style="width:20px"></td>
<td valign="top" runat="server" dir="<%$Resources:Master, dir%>"><img src="../images/links/first_magles.jpg" width="120" runat="server" dir="<%$Resources:Master, dir%>" /></td></tr>

<tr><td style="height:30px"></td></tr>

</table>
</td>
</tr>
</table></td>
<td style="width:20px"></td></tr>
</table>
</asp:Content>

