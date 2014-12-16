<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="contactus" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellpadding="0" cellspacing="0">
<tr>

<td colspan="4" align="right" ><span class=" pagetitle">الذاكرة الصحفية</span></td>
    <td style="width:20px"></td>
</tr>
<tr>    <td style="width:20px"></td><td style="height:25px"></td></tr>

<tr>
   <td style="width:25px"></td>
    <td style="width:200px;  " valign="top"  >
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td style=" width:20px; background-color:#cdb484"></td>
    <td valign="top"  style="  background-color:#cdb484">
      <table cellpadding="0" cellspacing="0">
      <tr><td style="height:20px"></td></tr>
      <tr><td align="right"><span class="text_search"> كلمة بحث </span></td></tr>
      <tr><td style="height:5px"></td></tr>
      <tr><td><asp:TextBox ID="TextBox1" Width="150" runat="server"></asp:TextBox></td></tr>
         <tr><td style="height:5px"></td></tr>
          <tr><td align="right"><span class="text_search"> مكان النشر </span></td></tr>
          
      <tr><td style="height:5px"></td></tr>
      <tr><td dir="rtl">
          <asp:DropDownList ID="DropDownList1" Width="158" runat="server">
          </asp:DropDownList>
      </td></tr>
      
              <tr><td style="height:5px"></td></tr>
          <tr><td align="right"><span class="text_search"> تاريخ النشر </span></td></tr>
          
      <tr><td style="height:5px"></td></tr>
           <tr><td dir="rtl">
        <table cellpadding="0" cellspacing="0">
        <tr>
        <td><span class="text_search">من</span></td>
        <td style="width:10px"></td>
        <td>
            <asp:DropDownList ID="DropDownList2" Width="40" runat="server">
            </asp:DropDownList>
        </td>
           <td style="width:10px"></td>
         <td>
            <asp:DropDownList ID="DropDownList3" Width="40" runat="server">
            </asp:DropDownList>
        </td>
           <td style="width:10px"></td>
         <td>
            <asp:DropDownList ID="DropDownList4" Width="55" runat="server">
            </asp:DropDownList>
        </td>
        </tr>
        
        </table>
      </td></tr>
          <tr><td style="height:5px"></td></tr>
           <tr><td dir="rtl">
        <table cellpadding="0" cellspacing="0">
        <tr>
        <td><span class="text_search">الى</span></td>
        <td style="width:10px"></td>
        <td>
            <asp:DropDownList ID="DropDownList5" Width="40" runat="server">
            </asp:DropDownList>
        </td>
           <td style="width:10px"></td>
         <td>
            <asp:DropDownList ID="DropDownList6" Width="40" runat="server">
            </asp:DropDownList>
        </td>
           <td style="width:10px"></td>
         <td>
            <asp:DropDownList ID="DropDownList7" Width="55" runat="server">
            </asp:DropDownList>
        </td>
        </tr>
        
        </table>
      </td></tr>
      <tr><td style="height:13px"></td></tr>
      <tr><td>
          <asp:ImageButton ID="ImageButton1"  runat="server" ImageUrl="../images/res.gif" />&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="../images/search.gif"  />
          </td></tr>
       <tr><td style="height:20px"></td></tr>
      </table>
    </td>
    <td style=" width:20px; background-color:#cdb484"></td>
    </tr>
    </table>
    </td>
    <td style="width:20px"></td>
<td  style="width:570px" align="right" >

<table cellpadding="0" cellspacing="0">

<tr><td><img src="../images/news/khabar.sahafi.jpg" width="580" /></td></tr>
<tr><td style=" height:20px"></td></tr>
<tr><td align="right">
<table cellpadding="0" cellspacing="0">
<tr><td dir="rtl">
<span class="news_title" >عنوان المقال :</span>&nbsp;&nbsp;<span class="news_des" >شيخ الأزهر يدعو القضاة إلى الالتزام بمبادئ الدين الإسلامي ومراعة المصلحة العامة للمجتمع .</span> 
</td></tr>

<tr><td dir="rtl">
<span class="news_title" >كاتب المقال : </span>&nbsp;&nbsp;<span class="news_des" >-</span> 
</td></tr>


<tr><td dir="rtl">
<span class="news_title" >الموضوع :</span>&nbsp;&nbsp;<span class="news_des" >القضاء </span> 
</td></tr>


<tr><td dir="rtl">
<span class="news_title" >كلمات دالة : </span>&nbsp;&nbsp;<span class="news_des" > الأزهر ، القضاء، شيخ الأزهر</span> 
</td></tr>


<tr><td dir="rtl">
<span class="news_title" >مختصر المقال : </span>&nbsp;&nbsp;<span class="news_des" >دعوة من شيخ الأزهر إلى القضاة للالتزام بمبادئ الدين الإسلامي </span> 
</td></tr>

<tr><td dir="rtl">
<span class="news_title" >بيانات الجريدة : </span>&nbsp;&nbsp;<span class="news_des" >جريدة صوت الأزهر ع576 الجمعة 29شوال  1431هـ / 8 أكتوبر 2010م </span> 
</td></tr>
</table>
</td></tr>


</table>

</td>
 
    
        <td style="width:20px"></td>
</tr>
</table>

</asp:Content>