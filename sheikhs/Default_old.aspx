<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="Default_old.aspx.cs" Inherits="sheikhs_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" width="840" border="0" cellspacing="0">
  
<tr><td colspan="3" style="padding-right:23px" align="right"><span class=" pagetitle">مشايخ الأزهر </span></td></tr>

<tr>

<td colspan="3" align="right">

<asp:UpdatePanel  ID="UpdatePanel1"  runat="server">
                <ContentTemplate>
              <table cellpadding="0" cellspacing="0">
<tr>
<td style="width:20px"></td>

<td align="left">
<table cellpadding="0" width="720"  border="0"  cellspacing="0">
<tr>
<td><asp:ImageButton ID="ImageButton1" OnClick="Button1_Click" ImageUrl="../images/icon_text.gif" AlternateText="قائمة بأسماء شيوخ الأزهر"  runat="server" /></td>
<td><asp:ImageButton ID="ImageButton2" OnClick="Button2_Click" ImageUrl="../images/icon_images.gif"  runat="server" AlternateText="قائمة بصور شيوخ الأزهر" /></td>
<td style="width:820px"></td>
<td></td>
</tr>
</table>
</td>

<td style="width:70px"></td>

<td>
<asp:Label CssClass="pagenext" ID="Label2" runat="server" ></asp:Label>
</td>
<td></td>
<td style="width:20px"></td>
</tr>
<tr><td style="height:2px"></td></tr>
</table>
<dir id="list" runat="server"  visible="false" >
  <table cellpadding="0"   cellspacing="0">
  <tr>
     
      <td style="padding-left:30px; padding-right:30px; background-color:#f6f2e2; ">
      
      <table cellpadding='0'   border='0'  cellspacing='0'>


        <tr>
        <td align='right' style=" width:350px" ><span class='sheikhs'>الشيخ إبراهيم بن محمد بن شهاب الدين البرماوي الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image1" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right' style=" width:450px"><span class='sheikhs'>الشيخ محمد عبد الله الخرشي المالكي</span>&nbsp;&nbsp;<asp:Image ID="Image2" runat="server" ImageUrl="../images/p.jpg" /></td>
        </tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ عبد الباقي القليني المالكي</span>&nbsp;&nbsp;<asp:Image ID="Image4" runat="server" ImageUrl="../images/p.jpg" /></td>
                <td align='right'><span class='sheikhs'>الشيخ محمد النشرتي المالكي</span>&nbsp;&nbsp;<asp:Image ID="Image3" runat="server" ImageUrl="../images/p.jpg" /></td>
</tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ إبراهيم موسى الفيومي المالكي</span>&nbsp;&nbsp;<asp:Image ID="Image6" runat="server" ImageUrl="../images/p.jpg" /></td>
                <td align='right'><span class='sheikhs'>الشيخ محمد شنن المالكي</span>&nbsp;&nbsp;<asp:Image ID="Image5" runat="server" ImageUrl="../images/p.jpg" /></td>

</tr>
        
        <tr>
        
        <td align='right'><span class='sheikhs'>الشيخ محمد سالم الحفني الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image8" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ عبدالله الشبراوي الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image7" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ أحمد بن عبد المنعم الدمنهوري الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image10" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ عبد الرؤوف السجيني الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image9" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        
        <td align='right'><span class='sheikhs'>الشيخ عبدالله الشرقاوي الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image12" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ أحمد العروسي الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image11" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ  محمد أحمد العروسي الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image14" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ محمد الشنواني الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image13" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ حسن بن محمد العطار</span>&nbsp;&nbsp;<asp:Image ID="Image46" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ أحمد بن علي الدمهوجي الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image45" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ أحمد عبد الجواد السفطي الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image44" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ حسن القويسني الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image47" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ مصطفى العروسي</span>&nbsp;&nbsp;<asp:Image ID="Image48" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ إبراهيم الباجوري الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image43" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ شمس الدين الإنبابي الشافعي</span>&nbsp;&nbsp;<asp:Image ID="Image41" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ محمد المهدي العباسي الحنفي</span>&nbsp;&nbsp;<asp:Image ID="Image42" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ عبد الرحمن القطب الحنفي النواوي</span>&nbsp;&nbsp;<asp:Image ID="Image39" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ حسونة النواوي الحنفي</span>&nbsp;&nbsp;<asp:Image ID="Image40" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>السيد علي بن محمد الببلاوي</span>&nbsp;&nbsp;<asp:Image ID="Image37" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ سليم البشري المالكي</span>&nbsp;&nbsp;<asp:Image ID="Image38" runat="server" ImageUrl="../images/p.jpg" /></td>
        </tr>
        
        <tr>
       <td align='right'><span class='sheikhs'>الشيخ حسونة بن عبد الله النواوي</span>&nbsp;&nbsp;<asp:Image ID="Image35" runat="server" ImageUrl="../images/p.jpg" /></td>
               <td align='right'><span class='sheikhs'>الشيخ عبد الرحمن الشربيني</span>&nbsp;&nbsp;<asp:Image ID="Image36" runat="server" ImageUrl="../images/p.jpg" /></td>
</tr>
       
        <tr>
        
        <td align='right'><span class='sheikhs'>الشيخ محمد أبو الفضل الجيزاوي</span>&nbsp;&nbsp;<asp:Image ID="Image33" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ سليم البشري المالكي</span>&nbsp;&nbsp;<asp:Image ID="Image34" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ محمد الأحمدي الظواهري</span>&nbsp;&nbsp;<asp:Image ID="Image31" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ محمد مصطفى المراغي الحنفي</span>&nbsp;&nbsp;<asp:Image ID="Image32" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ مصطفى عبد الرازق</span>&nbsp;&nbsp;<asp:Image ID="Image29" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ محمد مصطفى المراغي</span>&nbsp;&nbsp;<asp:Image ID="Image30" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
       <td align='right'><span class='sheikhs'>الشيخ عبد المجيد سليم</span>&nbsp;&nbsp;<asp:Image ID="Image27" runat="server" ImageUrl="../images/p.jpg" /></td>
       <td align='right'><span class='sheikhs'>الشيخ محمد مأمون الشناوي</span>&nbsp;&nbsp;<asp:Image ID="Image28" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
       
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ عبد المجيد سليم</span>&nbsp;&nbsp;<asp:Image ID="Image26" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ إبراهيم حمروش</span>&nbsp;&nbsp;<asp:Image ID="Image25" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
       <td align='right'><span class='sheikhs'>الشيخ عبد الرحمن تاج</span>&nbsp;&nbsp;<asp:Image ID="Image24" runat="server" ImageUrl="../images/p.jpg" /></td>
       <td align='right'><span class='sheikhs'>الشيخ محمد الخضر حسين</span>&nbsp;&nbsp;<asp:Image ID="Image23" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
       
        <tr>
        <td align='right'><span class='sheikhs'>الشيخ حسن مأمون</span>&nbsp;&nbsp;<asp:Image ID="Image22" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الشيخ محمود  شتلوت</span>&nbsp;&nbsp;<asp:Image ID="Image21" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>الدكتور عبد الحليم محمود</span>&nbsp;&nbsp;<asp:Image ID="Image19" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الدكتور محمد الفحام</span>&nbsp;&nbsp;<asp:Image ID="Image20" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><span class='sheikhs'>فضيلة الإمام الأكبر الشيخ جاد الحق علي جاد الحق</span>&nbsp;&nbsp;<asp:Image ID="Image17" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>الدكتور محمد عبد الرحمن بيصار</span>&nbsp;&nbsp;<asp:Image ID="Image18" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        
        <tr>
        <td align='right'><a href="Ahmed_eltayeb.aspx" class='sheikhs_links'>فضيلة الإمام الأكبر الدكتور أحمد الطيب</a>&nbsp;&nbsp;<asp:Image ID="Image15" runat="server" ImageUrl="../images/p.jpg" /></td>
        <td align='right'><span class='sheikhs'>فضيلة الإمام الأكبر الدكتور محمد سيد طنطاوي</span>&nbsp;&nbsp;<asp:Image ID="Image16" runat="server" ImageUrl="../images/p.jpg" /></td></tr>
        </table>
      
      </td>
      </tr>
                 </table>
</dir>
                  
                    
               <div id="sewar" runat="server" visible="false">
                 <table cellpadding="0"  bgcolor="#cdb484" width="840" cellspacing="0">
                 <tr>    <td align="center"  colspan="11" style="width:840px;background-color:#f5f2e1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" ><a href="Ahmed_eltayeb.aspx" class="gallery_images_links">
        <img src="../images/sheikhs/1.jpg" border="0"  width="100" height="130" />

        <br /><br />
الشيخ أحمد الطيب
    </a></td></tr>
    <tr><td colspan="11" style="height:11px;background-color:#f5f2e1"></td></tr>
                    
                    
                       <tr dir="rtl">
    <td align="left" style="padding-left:30px; background-color:#f6f2e2"></td>
     <td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" >
 <span class="gallery_images">
     <img src="../images/sheikhs/6.jpg" width="100"  height="130" />
    <br /><br />
محمد الفحام
    </span>
 </td>
    <td style="width:10px"></td>

      <td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" >
  <span class="gallery_images">
   <img src="../images/sheikhs/5.jpg"  width="100" height="130" />
     <br /><br />
عبد الحليم محمود
     </span>
 </td>
     <td style="width:10px"></td>
 <td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" >
 <span class="gallery_images">
     <img src="../images/sheikhs/4.jpg" width="100" />
    <br /><br />
     
 محمد عبد الرحمن بيصار
    </span>
 </td>
 
    <td style="width:10px"></td>

  <td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" >
 <span class="gallery_images">
     <img src="../images/sheikhs/3.jpg" width="100"  height="130"  />
    <br /><br />
جاد الحق علي جاد الحق
    </span>
 </td>
    <td style="width:10px"></td>
<td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" ><a href="Ahmed_eltayeb.aspx" class="gallery_images_links">
        <img src="../images/sheikhs/2.jpg" border="0"  width="100" height="130" />

        <br /><br />
 محمد سيد طنطاوي
    </a></td>
 <td align="left" style="padding-left:30px; background-color:#f6f2e2"></td>
    </tr>
    <tr>
         <td align="left" style="padding-left:30px; background-color:#f6f2e2">
        <td colspan="9"  style=" height:10px"></td>
    <td align="left" style="padding-left:30px; background-color:#f6f2e2"></td>
    </tr>
                 
    <tr>
    <td align="left" style="padding-left:30px; background-color:#f6f2e2"></td>
    <td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" ><span class="gallery_images">
        <img src="../images/sheikhs/11.jpg" width="100" height="130"  /><br /><br />
    عبد المجيد سليم
    </span></td>
    <td style="width:10px"></td>
 <td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" >
     <span class="gallery_images">
     <img src="../images/sheikhs/10.jpg" width="100" height="130"  /><br /><br /> محمد الخضر حسين</span></td>
     
     <td style="width:10px"></td>
 <td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" >
 <span class="gallery_images">
     <img src="../images/sheikhs/9.jpg"  width="100" height="130"  /><br /><br />عبد الرحمن تاج</span>
 </td>
 
    <td style="width:10px"></td>
 <td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" >
  <span class="gallery_images">
      <img src="../images/sheikhs/8.jpg" height="130"   width="100" /><br /><br /> محمود شتلوت</span>
 </td>
 
    <td style="width:10px"></td>
 <td style="width:150px;background-color:#ede4c1; padding-top:5px; padding-left:5px; padding-right:5px; padding-bottom:5px" align="center" >
 <span class="gallery_images">

     <img src="../images/sheikhs/7.jpg" width="100" height="130"   /><br /><br />حسن مأمون</span>
 </td>
 <td align="left" style="padding-left:30px; background-color:#f6f2e2"></td>
    </tr>
    
        <tr>
         <td align="left" style="padding-left:30px; background-color:#f6f2e2"></td>
        <td colspan="9"  style=" height:10px"></td>
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

