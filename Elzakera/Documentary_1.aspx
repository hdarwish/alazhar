<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="Documentary_1.aspx.cs" Inherits="contactus" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ScriptManager ID="ScriptManager2" runat="server" />
<asp:UpdatePanel  ID="UpdatePanel2"  runat="server">
                <ContentTemplate>
<table cellpadding="0" cellspacing="0">


<tr>
   <td style="width:25px"></td>
    <td style="width:200px;  " valign="top"  >
    <table cellpadding="0" cellspacing="0">
    
    <tr>
<td style="width:20px; background-color:#cdb484"></td>
<td align="right">
<table cellpadding="0" border="0"  bgcolor="#cdb484"  cellspacing="0">

<tr><td style="height:20px"></td></tr>
<tr><td align="right" style="width:160px" >
    <asp:LinkButton ID="LinkButton4" runat="server"  CssClass="out_links4"  >إتفاقات دولية</asp:LinkButton></td></tr>
<tr><td style="height:8px"></td></tr>

<tr><td align="right" style="width:160px" >
    <asp:LinkButton ID="LinkButton5" runat="server"  CssClass="out_links4"   >قرارات تاريخية </asp:LinkButton></td></tr>
    
  
    <tr><td style="height:8px"></td></tr>
 <tr><td align="right" style="width:160px" >
    <asp:LinkButton ID="LinkButton7" runat="server"  CssClass="out_links4"  > وثائق تطوير الأزهر</asp:LinkButton></td></tr>

        <tr><td style="height:8px"></td></tr>
 <tr><td align="right" style="width:160px" >
    <asp:LinkButton ID="LinkButton8" runat="server"  CssClass="out_links4" 
         onclick="LinkButton8_Click"  > أخري</asp:LinkButton></td></tr>

<tr><td style="height:20px"></td></tr>




</table></td>
<td style="width:20px; background-color:#cdb484"></td>
</tr>

  <tr><td style="height:20px"></td></tr>
  
    <tr>
    <td style=" width:20px; background-color:#cdb484"></td>
    <td valign="top"  style="  background-color:#cdb484">
      <table cellpadding="0" cellspacing="0">
      <tr><td style="height:20px"></td></tr>
      <tr><td align="right"> كلمة بحث </td></tr>
      <tr><td style="height:5px"></td></tr>
      <tr><td><asp:TextBox ID="TextBox2" Width="150" runat="server"></asp:TextBox></td></tr>
         <tr><td style="height:5px"></td></tr>
          <tr><td align="right"> مكان الحفظ </td></tr>
          
      <tr><td style="height:5px"></td></tr>
      <tr><td dir="rtl">
          <asp:DropDownList ID="DropDownList3" Width="158" runat="server">
          </asp:DropDownList>
      </td></tr>
      
              <tr><td style="height:5px"></td></tr>
          <tr><td align="right">تاريخ الأنشاء </td></tr>
          
      <tr><td style="height:5px"></td></tr>
           <tr><td dir="rtl">
        <table cellpadding="0" cellspacing="0">
        <tr>
        <td style="width:50px">من</td>
        <td style="width:10px"></td>
        <td align="right"  style="width:150px">
            <asp:DropDownList ID="DropDownList4" Width="100" runat="server">
            </asp:DropDownList>
        </td>
         
        </tr>
        
        </table>
      </td></tr>
          <tr><td style="height:5px"></td></tr>
           <tr><td dir="rtl">
        <table cellpadding="0" cellspacing="0">
        <tr>
        <td style="width:50px">الى</td>
        <td style="width:10px"></td>
        <td align="right"  style="width:150px">
            <asp:DropDownList ID="DropDownList6" Width="100" runat="server">
            </asp:DropDownList>
        </td>
           <td style="width:10px"></td>
      
        </tr>
        
        </table>
      </td></tr>
      <tr><td style="height:13px"></td></tr>
      <tr><td>
          <asp:ImageButton ID="ImageButton3"  runat="server" ImageUrl="../images/res.gif" />&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="../images/search.gif"  />
          </td></tr>
       <tr><td style="height:20px"></td></tr>
      </table>
    </td>
    <td style=" width:20px; background-color:#cdb484"></td>
    </tr>
    </table>
    </td>
    <td style="width:20px"></td>
<td  style="width:570px" align="right" valign="top" >

<table cellpadding="0" cellspacing="0">

<tr>

<td colspan="4" align="right" ><span class="pagetitle">الذاكرة الوثائقية</span>&nbsp;&nbsp;&nbsp;<span style=" font-family: tahoma; color: #000000;font-size: 14px;text-decoration: none; font-weight: bold;">أخرى</span></td>
    <td style="width:20px"></td>
</tr>
<tr>    <td style="width:20px"></td><td style="height:25px"></td></tr>

<tr><td  valign="top" >
<table cellpadding="0" cellspacing="0">

<tr>
<td  valign="top" >
<table cellpadding="0" cellspacing="0">
<tr><td><span class="Documentary_title_sub">رقم الوثيقة :</span>&nbsp;&nbsp;&nbsp;<span class="Documentary_des_sub">1001-000054-1019</span></td></tr>
<tr><td style="height:10px"></td></tr>
<tr><td><span class="Documentary_title_sub">عنوان الوثيقة :</span>&nbsp;&nbsp;&nbsp;<span class="Documentary_des_sub" dir="rtl">دعوي من نور الدين بن شمس الدين بن عبد القادر شيخ رواق بالجامع الأزهر على عبد الرازق بن سلام بن جعفر المعروف بالشندويلي بأن تعدى عليه بالفاظ قبيحة. </span></td></tr>
<tr><td style="height:10px"></td></tr>

<tr><td><span class="Documentary_title_sub">تاريخ الإنشاء : </span>&nbsp;&nbsp;&nbsp;<span class="Documentary_des_sub" dir="rtl">11-4- 987   إلى   1-4-987</span></td></tr>
<tr><td style="height:10px"></td></tr>


<tr><td><span class="Documentary_title_sub">مستوى الوصف :   </span>&nbsp;&nbsp;&nbsp;<span class="Documentary_des_sub" dir="rtl">جزء من  سجل مبايعات محكمة الباب العالى من سنة 986هـ. </span></td></tr>
<tr><td style="height:10px"></td></tr>

<tr><td><span class="Documentary_title_sub">مُنشىء الوثيقة : </span>&nbsp;&nbsp;&nbsp;<span class="Documentary_des_sub" dir="rtl">محكمة الباب العالي. </span></td></tr>
<tr><td style="height:10px"></td></tr>

<tr><td ><span class="Documentary_title_sub">مكان الحفظ : </span>&nbsp;&nbsp;&nbsp;<span class="Documentary_des_sub" dir="rtl">دار الوثائق القومية . </span></td></tr>
<tr><td style="height:10px"></td></tr>
</table>
</td>
<td style="width:20px"></td>
<td><img src="../images/Documentary/1.jpg" width="150"  /></td></tr>







</table>
</td></tr>

</table>

</td>
 
    
        <td style="width:20px"></td>
</tr>
</table>
</ContentTemplate></asp:UpdatePanel>
</asp:Content>