<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="Manuscripts.aspx.cs" Inherits="contactus" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ScriptManager ID="ScriptManager1" runat="server" />
<table cellpadding="0" width="840" border="0" cellspacing="0">


<tr>

<td colspan="3" style="padding-left:30px; padding-right:30px" align="right">

<asp:UpdatePanel  ID="UpdatePanel1"  runat="server">
                <ContentTemplate>
              <table  cellpadding="0" cellspacing="0">
              
<tr><td valign="top">

<table cellpadding="0" cellspacing="0">
<tr>
<td style="width:20px; background-color:#cdb484"></td>
<td align="right">
<table cellpadding="0" border="0"  bgcolor="#cdb484"  cellspacing="0">
<tr><td style="height:20px"></td></tr>
<tr><td align="right"><span class="text_search">الموضوعات الأساسية</span> </td></tr>
<tr><td style="height:20px"></td></tr>
<tr><td align="right" style="width:160px" >&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton1" runat="server"  CssClass="out_links4"  >علوم اللغة والأدب</asp:LinkButton>   &nbsp;&nbsp;<asp:Image
        ID="Image1" runat="server" ImageUrl="../images/p2.gif" /></td></tr>
<tr><td style="height:8px"></td></tr>

<tr><td align="right" style="width:200px" >
    <asp:LinkButton ID="LinkButton2" runat="server"  CssClass="out_links4"   >العلوم البحتة والتطبيقية </asp:LinkButton>   &nbsp;&nbsp;<asp:Image
        ID="Image2" runat="server" ImageUrl="../images/p2.gif" /></td></tr>
    
    <tr><td align="right" style="width:160px" >
    <asp:LinkButton ID="LinkButton3" runat="server"  CssClass="out_links4"   >  الطب - </asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td></tr>
    
    <tr><td style="height:3px"></td></tr>
        <tr><td align="right" style="width:160px" >
    <asp:LinkButton ID="LinkButton4" runat="server"  CssClass="out_links4"  > الكيمياء - </asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td></tr>
    
      <tr><td style="height:3px"></td></tr>
        <tr><td align="right" style="width:160px" >
    <asp:LinkButton ID="LinkButton5" runat="server"  CssClass="out_links4"  >  الفلك - </asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td></tr>
    <tr><td style="height:8px"></td></tr>
 <tr><td align="right" style="width:160px" >&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton6" runat="server"  CssClass="out_links4"  > الفنون والآداب</asp:LinkButton>   &nbsp;&nbsp;<asp:Image
        ID="Image3" runat="server" ImageUrl="../images/p2.gif" /></td></tr>

    
<tr><td style="height:20px"></td></tr>




</table></td>
<td style="width:20px; background-color:#cdb484"></td>
</tr>

<tr><td colspan="11" style="height:20px"></td></tr>
<tr>
<td style="width:20px; background-color:#cdb484"></td>
<td align="right">
<table cellpadding="0" border="0"  bgcolor="#cdb484"  cellspacing="0">
 
   
<tr><td>

  <table cellpadding="0" cellspacing="0">
    <tr>
    <td style=" width:20px; background-color:#cdb484"></td>
    <td valign="top"  style="  background-color:#cdb484">
      <table cellpadding="0" cellspacing="0">
      <tr><td style="height:20px"></td></tr>
      <tr><td align="right"><span class="text_search"> كلمة بحث</span> </td></tr>
      <tr><td style="height:5px"></td></tr>
      <tr><td><asp:TextBox ID="TextBox2" Width="150" runat="server"></asp:TextBox></td></tr>
         <tr><td style="height:5px"></td></tr>
          <tr><td align="right" dir="rtl"> 
              <asp:RadioButton ID="RadioButton1" Text="الكل" CssClass="RadioButton" runat="server" /></td></tr>
    
             <tr><td align="right" dir="rtl"> 
              <asp:RadioButton ID="RadioButton2" Text="العنوان" CssClass="RadioButton" runat="server" /></td></tr>
              
                     <tr><td align="right" dir="rtl"> 
              <asp:RadioButton ID="RadioButton3" Text="المؤلف" CssClass="RadioButton" runat="server" /></td></tr>
      <tr><td style="height:13px"></td></tr>
      <tr><td>
          &nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButton3"  runat="server" ImageUrl="../images/res.gif" />&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="../images/search.gif"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          </td></tr>
       <tr><td style="height:20px"></td></tr>
      </table>
    </td>
    <td style=" width:20px; background-color:#cdb484"></td>
    </tr>
    </table>

</td></tr>

</table></td>
<td style="width:20px; background-color:#cdb484"></td>
</tr>
</table> 
   </td>
<td style="width:20px" dir="rtl" valign="top"></td>

<td style="width:570px" dir="rtl" valign="top">
<div id="description" runat="server" >
<table cellpadding="0" cellspacing="0">

<tr><td dir="rtl">
<table cellpadding="0" cellspacing="0">

<tr dir="rtl">
<td style="width:21px"></td>
<td align="center" style=" width:100px">
<span style="font-family: Tahoma; font-size:13px; color:#815e28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList
    ID="DropDownList1" runat="server" CssClass=" drop_texts">
    <asp:ListItem Text="المؤلف">المؤلف</asp:ListItem>
    <asp:ListItem Text="العنوان">العنوان</asp:ListItem>
    </asp:DropDownList>
</span></td>
 <td style="width:15px"></td>
<td align="left" style="padding-left:30px;"  >
<table cellpadding="0" border="1" bordercolor="#815e28"  bordercolordark="white" cellspacing="0">
<tr>

<td style=" height:20px" >
<table cellpadding="0"  border="0"  dir="rtl" cellspacing="0">
<tr >   <td style="width:20px" align="center"><a href="#" class="char">أ</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ب</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ت</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ث</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ج</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ح</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">خ</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">د</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ذ</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ر</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ز</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">س</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ش</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ص</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ض</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ط</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ظ</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ع</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">غ</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ف</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ق</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ك</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ل</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">م</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ن</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">هـ</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">و</a></td>
        <td style="width:20px" align="center"><a href="#"  class="char">ي</a></td></tr>

</table></td></tr>

</table>


    </td>


</tr>

</table>
</td></tr>

<tr><td style="height:20px"></td></tr>
<tr><td><span class="pagetitle">المخطوطات</span>&nbsp;&nbsp;&nbsp;<span style=" font-family: tahoma; color: #000000;font-size: 14px;text-decoration: none; font-weight: bold;">الفلك</span></td></tr>
<tr><td style="height:15px"></td></tr>

<tr><td>

<table cellpadding="0" cellspacing="0">

<tr><td style="padding-right:50px"><img src="../images/p.jpg" border="0" style="vertical-align:middle " />&nbsp;&nbsp;<span class="Astronomy_title">منهاج الطالب لتعديل الكواكب</span></td></tr>

<tr><td style="padding-right:100px" ><span  class="Astronomy_des">ابن البناء المراكشي، أحمد بن محمد بن عثمان الأزدي العدوى </span></td></tr>

<tr><td style="height:20px"></td></tr>


<tr><td style="padding-right:50px"><img src="../images/p.jpg" border="0" style="vertical-align:middle " />&nbsp;&nbsp;<span class="Astronomy_title">طوالع البدور في تحويل السنين والشهور </span></td></tr>

<tr><td style="padding-right:100px" ><span  class="Astronomy_des">ابن الجيعان، أبو البقاء أحمد بن يحيى بن شاكر بن عبد الغنى </span></td></tr>

<tr><td style="height:20px"></td></tr>


<tr><td style="padding-right:50px"><img src="../images/p.jpg" border="0" style="vertical-align:middle " />&nbsp;&nbsp;<span class="Astronomy_title">محكمات الأبواب في جمل علم الأسطرلاب</span></td></tr>

<tr><td style="padding-right:100px" ><span  class="Astronomy_des">ابن الرقام، محمد بن إبراهيم بن علي الأوسي المرسي الأندلسي</span></td></tr>

<tr><td style="height:20px"></td></tr>


<tr><td style="padding-right:50px"><img src="../images/p.jpg" border="0" style="vertical-align:middle " />&nbsp;&nbsp;<span class="Astronomy_title">رسالة في العمل بالربع المجنح</span></td></tr>

<tr><td style="padding-right:100px" ><span  class="Astronomy_des">ابن السراج</span></td></tr>

<tr><td style="height:20px"></td></tr>

<tr><td style="padding-right:50px"><img src="../images/p.jpg" border="0" style="vertical-align:middle " />&nbsp;&nbsp;<span class="Astronomy_title">مختصر ابن السراج </span></td></tr>

<tr><td style="padding-right:100px" ><span  class="Astronomy_des">ابن السراج، شهاب الدين أبو العباس</span></td></tr>

<tr><td style="height:20px"></td></tr>


<tr><td style="padding-right:50px"><img src="../images/p.jpg" border="0" style="vertical-align:middle " />&nbsp;&nbsp;<span class="Astronomy_title">النفع العام في العمل بالربع التام لمواقيت الإسلام </span></td></tr>

<tr><td style="padding-right:100px" ><span  class="Astronomy_des">ابن الشاطر، على بن إبراهيم بن محمد الأنصاري المؤقت</span></td></tr>

<tr><td style="height:20px"></td></tr>

<tr><td style="padding-right:50px"><img src="../images/p.jpg" border="0" style="vertical-align:middle " />&nbsp;&nbsp;<span class="Astronomy_title">النفع العام في العمل بالربع التام لمواقيت الإسلام </span></td></tr>

<tr><td style="padding-right:100px" ><span  class="Astronomy_des">ابن الشاطر، على بن إبراهيم بن محمد الأنصاري المؤقت </span></td></tr>

<tr><td style="height:20px"></td></tr>

</table>

</td>
</tr>   </table></div>


  </td>  
</tr> 


              </table></ContentTemplate></asp:UpdatePanel></td></tr></table>
</asp:Content>

