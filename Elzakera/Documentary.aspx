<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="Documentary.aspx.cs" Inherits="contactus" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ScriptManager ID="ScriptManager1" runat="server" />
<asp:UpdatePanel  ID="UpdatePanel1"  runat="server">
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
    <asp:LinkButton ID="LinkButton1" runat="server"  CssClass="out_links4"  >إتفاقات دولية</asp:LinkButton></td></tr>
<tr><td style="height:8px"></td></tr>

<tr><td align="right" style="width:160px" >
    <asp:LinkButton ID="LinkButton2" runat="server"  CssClass="out_links4"   >قرارات تاريخية </asp:LinkButton></td></tr>
    
  
    <tr><td style="height:8px"></td></tr>
 <tr><td align="right" style="width:160px" >
    <asp:LinkButton ID="LinkButton6" runat="server"  CssClass="out_links4"  > وثائق تطوير الأزهر</asp:LinkButton></td></tr>

        <tr><td style="height:8px"></td></tr>
 <tr><td align="right" style="width:160px" >
    <asp:LinkButton ID="LinkButton3" runat="server"  CssClass="out_links4"  > أخري</asp:LinkButton></td></tr>

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
      <tr><td><asp:TextBox ID="TextBox1" Width="150" runat="server"></asp:TextBox></td></tr>
         <tr><td style="height:5px"></td></tr>
          <tr><td align="right"> مكان الحفظ </td></tr>
          
      <tr><td style="height:5px"></td></tr>
      <tr><td dir="rtl">
          <asp:DropDownList ID="DropDownList1" Width="158" runat="server">
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
            <asp:DropDownList ID="DropDownList2" Width="100" runat="server">
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
            <asp:DropDownList ID="DropDownList5" Width="100" runat="server">
            </asp:DropDownList>
        </td>
           <td style="width:10px"></td>
      
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
<tr><td><a href="Documentary_1.aspx" class="Documentary_des">تقرير أمين الدين بن الشرفي يحيي في وظيفة النظر والتحدث على وقف المرحوم أزدمر بن اق بردى نائب رشيد</a></td></tr>
<tr><td style="height:10px"></td></tr>
<tr><td dir="rtl"><span class="Documentary_date">3-7-992</span></td></tr>
</table>
</td>
<td style="width:20px"></td>
<td><img src="../images/Documentary/1.jpg" width="100" height="100" /></td></tr>

<tr><td style="height:10px"></td></tr>
<tr><td  colspan="3" style="height:1px; background-color:#815e28;"></td></tr>
<tr><td style="height:20px"></td></tr>



<tr>
<td  valign="top" >
<table cellpadding="0" cellspacing="0">
<tr><td><a href="#" class="Documentary_des">دعوي من نور الدين بن شمس الدين بن عبد القادر شيخ رواق بالجامع الأزهر على عبد الرازق بن سلام بن جعفر المعروف بالشندويلي بأن تعدى عليه بالفاظ قبيحة. </a></td></tr>
<tr><td style="height:10px"></td></tr>
<tr><td dir="rtl"><span class="Documentary_date">11-4- 987  </span></td></tr>
</table>
</td>
<td style="width:20px"></td>
<td><img src="../images/Documentary/CMServlet.jpg" width="100" height="100" /></td></tr>

<tr><td style="height:10px"></td></tr>
<tr><td  colspan="3" style="height:1px; background-color:#815e28;"></td></tr>
<tr><td style="height:20px"></td></tr>



<tr>
<td  valign="top" >
<table cellpadding="0" cellspacing="0">
<tr><td><a href="#" class="Documentary_des">عقد زواج جنرال مينو من زبيدة المصرية ابنة رشيد</a></td></tr>
<tr><td style="height:10px"></td></tr>
<tr><td dir="rtl"><span class="Documentary_date"></span></td></tr>
</table>
</td>
<td style="width:20px"></td>
<td><img src="../images/Documentary/3.jpg" width="100" height="100" /></td></tr>



</table>
</td></tr>

</table>

</td>
 
    
        <td style="width:20px"></td>
</tr>
</table>
</ContentTemplate></asp:UpdatePanel>
</asp:Content>