<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true" CodeFile="about_website.aspx.cs" Inherits="general_about_website" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

<table cellpadding="0" cellspacing="0">
<tr>
<td style="width:20px"></td>
    
<td valign="top" >
<table cellpadding="0" cellspacing="0">

<tr><td colspan="3" runat="server" align="<%$Resources:Master, align%>">
<span  class="<%$Resources:Master, pagetitle%>" id="tr1" runat="server">
<asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, aboutus%>"></asp:Label>
</span>
</td></tr>

<tr><td style="height:25px"></td></tr>

<tr><td>

<table cellpadding="0" cellspacing="0" runat="server" dir="<%$Resources:Master, dir%>">

<tr><td>
<span class="<%$Resources:Master, class%>" runat="server">
    <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, txt1%>"></asp:Label>
</span>
</td></tr>

<tr><td>
<span runat="server" class="<%$Resources:Master, class%>">
    <asp:Label ID="Label3" runat="server" Text="<%$Resources:Master, txt2%>"></asp:Label>
</span>
 </td></tr>

<tr><td style="height:10px"></td></tr>

<tr><td>
<span runat="server" class="<%$Resources:Master,  books_title_text%>">
 <li><asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, txt3%>"></asp:Label><br/></li>
   </span>
</td></tr>

<tr><td>
<span runat="server" class="<%$Resources:Master,  books_title_text%>">
<li> 
<asp:Label ID="Label5" runat="server" Text="<%$Resources:Master, txt4%>"></asp:Label><br/></li>
</span>
</td></tr>

<tr><td>
<span runat="server" class="<%$Resources:Master,  books_title_text%>">
<li><asp:Label ID="Label6" runat="server" Text="<%$Resources:Master, txt5%>"></asp:Label></li>
</span>
</td></tr>

<tr><td>
<span runat="server" class="<%$Resources:Master,  books_title_text%>">
<li>
<asp:Label ID="Label7" runat="server" Text="<%$Resources:Master, txt6%>"></asp:Label></li>
</span>
</td></tr>

<tr><td style="height:10px">&nbsp;</td></tr>

<tr><td style="padding-right:100px">
<span runat="server" class="<%$Resources:Master,  books_texts%>"> 
<asp:Label ID="Label8" runat="server" Text="<%$Resources:Master, txt7%>"></asp:Label>
</span>
</td></tr>

<tr><td style="padding-right:100px">
<span runat="server" class="<%$Resources:Master,  books_texts%>"> 
<asp:Label ID="Label9" runat="server" Text="<%$Resources:Master, txt8%>"></asp:Label> 
</span>
</td></tr>

<tr><td style="padding-right:100px">
<span runat="server" class="<%$Resources:Master,  books_texts%>">
<asp:Label ID="Label10" runat="server" Text="<%$Resources:Master, txt9%>"></asp:Label>
</span>
</td></tr>

<tr><td style="padding-right:150px">
<span runat="server" class="<%$Resources:Master,  books_texts%>">
<li><asp:Label ID="Label11" runat="server" Text="<%$Resources:Master, txt10%>"></asp:Label></li>
</span>
</td></tr>

<tr><td style="padding-right:150px">
<span  runat="server" class="<%$Resources:Master,  books_texts%>">
<li><asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, txt11%>"></asp:Label></li>
</span>
</td></tr>


<tr><td style="padding-right:150px">
<span runat="server" class="<%$Resources:Master,  books_texts%>">
<li><asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, txt12%>"></asp:Label>&nbsp;</li>
</span>
</td></tr>

<tr><td style="padding-right:100px">
<span runat="server" class="<%$Resources:Master,  books_texts%>">
 <asp:Label ID="Label14" runat="server" Text="<%$Resources:Master, txt13%>"></asp:Label>
 </span>
 </td></tr>

<tr><td style="padding-right:100px">
<span runat="server" class="<%$Resources:Master,  books_texts%>">
<asp:Label ID="Label15" runat="server" Text="<%$Resources:Master, txt14%>"></asp:Label>
    </span>
    </td></tr>

<tr><td style="padding-right:100px">
<span runat="server" class="<%$Resources:Master,  books_texts%>">
<asp:Label ID="Label16" runat="server" Text="<%$Resources:Master, txt15%>"></asp:Label>
</span>
</td></tr>

<tr><td style="height:15px"></td></tr>

<tr><td>
<span runat="server" class="<%$Resources:Master,  books_title_text%>">
<li><asp:Label ID="Label17" runat="server" Text="<%$Resources:Master, txt16%>"></asp:Label></li>
</span>
</td></tr>

<tr><td style="height:5px"></td></tr>

<tr><td>
<span runat="server" class="<%$Resources:Master,  books_title_text%>">
<li><asp:Label ID="Label18" runat="server" Text="<%$Resources:Master, txt17%>"></asp:Label></li>
</span>
</td></tr>

<tr><td style="height:5px"></td></tr>

<tr><td>
<span runat="server" class="<%$Resources:Master,  books_title_text%>">
<li><asp:Label ID="Label19" runat="server" Text="<%$Resources:Master, txt18%>"></asp:Label></li>
</span>
</td></tr>

<tr><td style="height:5px"></td></tr>

<tr><td>
<span runat="server" class="<%$Resources:Master,  books_title_text%>">
<li><asp:Label ID="Label20" runat="server" Text="<%$Resources:Master, txt19%>"></asp:Label></li>
</span>
</td></tr>

<tr><td style="height:5px"></td></tr>

<tr><td>
<span runat="server" class="<%$Resources:Master,  books_title_text%>">
<li><asp:Label ID="Label21" runat="server" Text="<%$Resources:Master, txt20%>"></asp:Label></li>
</span>
</td></tr>

</table>
</td>
</tr>
</table>
</td>
<td style="width:20px"></td>
</tr>
</table>
</asp:Content>

