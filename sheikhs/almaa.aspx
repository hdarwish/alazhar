<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="almaa.aspx.cs" Inherits="sheikhs_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellpadding="0" width="840" border="0" cellspacing="0">

<tr><td colspan="3" style="padding-right:23px" align="right"><span class=" pagetitle">العلماء والأعلام </span></td></tr>
<tr><td style="height:20px"></td></tr>
<tr>

<td align="left" style="padding-left:30px;">
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
 <td style="width:25px"></td>
<td align="center" style=" width:200px">
<span style="font-family: Tahoma; font-size:13px; color:#815e28">
عرض الكل
</span></td>
</tr>

<tr><td style=" height:20px"></td></tr>
<tr>

<td colspan="3" align="right">

<asp:UpdatePanel  ID="UpdatePanel1"  runat="server">
                <ContentTemplate>
              <table cellpadding="0" cellspacing="0">
<tr>
<td style="width:20px"></td>

<td align="left">
<table cellpadding="0" width="680"  border="0"  cellspacing="0">
<tr>
<td><asp:ImageButton ID="ImageButton2" OnClick="Button2_Click" ImageUrl="../images/icon_text.gif" runat="server" /></td>

<td><asp:ImageButton ID="ImageButton1" OnClick="Button1_Click" ImageUrl="../images/icon_images.gif" runat="server" /></td>
<td style="width:220px"></td>
<td><span  class="pagenext"><<</span></td>
<td style="width:5px"></td>
<td><span  class="pagenext"><</span></td>
<td style="width:5px"></td>
<td><span  class="pagenext">صفحة</span></td>
<td style="width:5px"></td>
<td><span  class="pagenext">></span></td>
<td style="width:5px"></td>
<td><span  class="pagenext">>></span></td>
<td style="width:250px"></td>
</tr>
</table>
</td>

<td style="width:70px"></td>

<td style=" padding-right:10px; padding-left:10px">
<asp:Label CssClass="pagenext" ID="Label2" runat="server" ></asp:Label>
</td>
<td><span  class="pagenext">العدد</span></td>
<td style="width:20px"></td>
</tr>

</table>
<div runat="server" id="lis" style="height:300px" >
<table cellpadding="0" cellspacing="0">
<tr><td style="padding-right:30px">
<table cellpadding="0" cellspacing="0">
    <asp:ListView ID="ListView1" runat="server">
   
    </asp:ListView>
<tr><td align='right'  style=" width:250px"><span class='sheikhs'></span>&nbsp;&nbsp;

<asp:Image ID="Image1" runat="server" ImageUrl="../images/p.jpg" /></td>


<td align='right'  style=" width:450px"><span class='sheikhs'>فضيلة الشيخ أحمد طه ريان</span>&nbsp;&nbsp;<asp:Image ID="Image2" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>فضيلة الشيخ أحمد عمر هاشم</span>&nbsp;&nbsp;<asp:Image ID="Image3" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>فضيلة الشيخ أحمد محمد عبد العال هريدي</span>&nbsp;&nbsp;<asp:Image ID="Image4" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>فضيلة الشيخ بكري الصدفي</span>&nbsp;&nbsp;<asp:Image ID="Image5" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>الرئيس بوتفليقة" رئيس الجزائر"</span>&nbsp;&nbsp;<asp:Image ID="Image6" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>السلطان حسن بلقيه" سلطان بروناى"</span>&nbsp;&nbsp;<asp:Image ID="Image7" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>فضيلة الشيخ حسنين محمد مخلوف</span>&nbsp;&nbsp;<asp:Image ID="Image8" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>الدكتور الحسينى هاشم</span>&nbsp;&nbsp;<asp:Image ID="Image9" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>الدكتور رؤوف شلبى</span>&nbsp;&nbsp;<asp:Image ID="Image10" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>الدكتور سعد فرهود</span>&nbsp;&nbsp;<asp:Image ID="Image27" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>فضيلة الشيخ صابرى عبد الرؤوف</span>&nbsp;&nbsp;<asp:Image ID="Image26" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><a href="Tantawy.aspx" class='sheikhs_links'>الشيخ طنطاوي الجوهري</a>&nbsp;&nbsp;<asp:Image ID="Image25" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>الدكتور عبد الجليل شلبى</span>&nbsp;&nbsp;<asp:Image ID="Image24" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>الشيخ عبد الجليل عيسى</span>&nbsp;&nbsp;<asp:Image ID="Image23" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>الدكتور عبد الرحمن العدوى</span>&nbsp;&nbsp;<asp:Image ID="Image22" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>فضيلة الشيخ عبد الرحمن قراعــة</span>&nbsp;&nbsp;<asp:Image ID="Image21" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>فضيلة الشيخ عبد الستار سعيد</span>&nbsp;&nbsp;<asp:Image ID="Image20" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>الدكتور عبد الفتاح بركة</span>&nbsp;&nbsp;<asp:Image ID="Image19" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>الإمام عبد القادر الرافعي</span>&nbsp;&nbsp;<asp:Image ID="Image18" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>فضيلة الشيخ عبد اللطيف عبد الغني حمزة</span>&nbsp;&nbsp;<asp:Image ID="Image16" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>الشيخ عبد الله دراز</span>&nbsp;&nbsp;<asp:Image ID="Image17" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>فضيلة الشيخ علام نصــار</span>&nbsp;&nbsp;<asp:Image ID="Image14" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>فضيلة الأستاذ الدكتور علي جمعة</span>&nbsp;&nbsp;<asp:Image ID="Image15" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr><td align='right'><span class='sheikhs'>فضيلة الشيخ محمد إسماعيل البرديسي</span>&nbsp;&nbsp;<asp:Image ID="Image13" runat="server" ImageUrl="../images/p.jpg" /></td>
<td align='right'><span class='sheikhs'>الدكتور محمد الطيب النجار</span>&nbsp;&nbsp;<asp:Image ID="Image12" runat="server" ImageUrl="../images/p.jpg" /></td></tr>

<tr>
<td></td>
<td align='right'><span class='sheikhs'>فضيلة الشيخ الدكتور محمد الغزالى</span>&nbsp;&nbsp;<asp:Image ID="Image11" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
</table>
</td></tr>
</table >
</div>

    <div id="sewar" runat="server" visible="false"  style="height:300px" >
                 <table cellpadding="0"  bgcolor="#cdb484" width="840"  cellspacing="0">
                 
                       <tr>
                        <td align="left" style="width:730px; background-color:#f6f2e2"></td>
 
    <td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" ><a href="Tantawy.aspx" class="gallery_images">
        <img src="images/photothumb01.jpg" width="100" border="0" /> 

        <br /><br />
الشيخ طنطاوي الجوهري
    </a></td>
          <td align="left" style="padding-left:30px; background-color:#f6f2e2"></td>
    </tr>
    </table>
</div>
                    
               
                </ContentTemplate>
              
                           </asp:UpdatePanel>
                           
                           

</td></tr>

<tr><td style=" height:20px"></td></tr>

</table>
</asp:Content>

