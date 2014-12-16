<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="lookups_main_page.aspx.cs" Inherits="administration_lookups_main_page" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" dir="rtl">
    <tr >
        <td height="60px" colspan="3">
            <asp:Label ID="Label1" runat="server" Text="شاشة عرض إدخال الأكواد" 
                Font-Bold="True" Font-Size="18px"></asp:Label>
        </td>
        
    </tr>
    <tr>
    <td align="right" dir="rtl"  width="120px" height="30px">
           <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
            <asp:LinkButton ID="lbtnColors" runat="server" Text="الألوان" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=col"></asp:LinkButton>
          </li>
 
</ul>

        </td>
        <td align="right" dir="rtl" width="120px" >
        <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
            <asp:LinkButton ID="LinkButton1" runat="server" Text="العلاقات" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=rel"></asp:LinkButton>
          </li>
 
</ul>
        </td>
        <td align="right" dir="rtl" width="120px" >
        <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton7" runat="server" Text="الأسلوب الفنى" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=techniques"></asp:LinkButton>
     </li>
 
</ul>
    </td>
      
    </tr>
       
    <tr dir="rtl">
     
     <td align="right" dir="rtl" height="30px">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton3" runat="server" Text="الشكل المادى" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=materials"></asp:LinkButton>
     </li>
 
</ul></td>
     <td align="right" dir="rtl">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton11" runat="server" Text="الطراز الأساسى للأثر" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=places_styles"></asp:LinkButton>
     </li>
 
</ul></td>
     
      <td align="right" dir="rtl">
      <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton19" runat="server" Text="نوع الإجازة" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=license_type"></asp:LinkButton>
     </li>
 
</ul></td>
   
   
     
    </tr>
    <tr>
     <td align="right" dir="rtl" height="30px">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton14" runat="server" Text="العصر" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=periods"></asp:LinkButton>
     </li>
 
</ul></td>
     <td align="right" dir="rtl">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton17" runat="server" Text="النسخة تحتوى على" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=copy_contains"></asp:LinkButton>
     </li>
 
</ul></td>
     <td align="right" dir="rtl">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton18" runat="server" Text="النسخة بها" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=copy_has"></asp:LinkButton>
    </td>
    </tr>
    <tr>
       <td align="right" dir="rtl" height="30px">
       <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton16" runat="server" Text="حالة النسخ" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=copy_status"></asp:LinkButton>
     </li>
 
</ul></td>
     <td align="right" dir="rtl">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton6" runat="server" Text="دور المؤلف" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=authors_role"></asp:LinkButton>
     </li>
 
</ul></td>
    <td align="right" dir="rtl">
    <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton15" runat="server" Text="لغة المخطوط" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=languages"></asp:LinkButton>
     </li>
 
</ul></td>
    </tr>
    <tr>
     <td align="right" dir="rtl" height="30px">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton8" runat="server" Text="مادة الصنع" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=raw_material"></asp:LinkButton>
    </li>
 
</ul> </td>
     <td align="right" dir="rtl">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton4" runat="server" Text="مضمون الوثيقة" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=styles"></asp:LinkButton>
     </li>
 
</ul></td>
    <td align="right" dir="rtl">
    <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton13" runat="server" Text="موضع استخدام المادة الخام" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=raw_material_use"></asp:LinkButton>
     </li>
 
</ul></td>
    </tr>
    <tr>
      <td align="right" dir="rtl" height="30px">
      <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton2" runat="server" Text="نوع الاثر" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=places_types"></asp:LinkButton>
    </li>
 
</ul> </td>
     <td align="right" dir="rtl">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton5" runat="server" Text="نوع / مصدر المؤلف" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=author_type"></asp:LinkButton>
    </li>
 
</ul> </td>
     <td align="right" dir="rtl">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton9" runat="server" Text="نوع العمل" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=content_media_type"></asp:LinkButton>
     </li>
 
</ul></td>
    </tr>
    <tr dir="rtl">
     <td align="right" dir="rtl" height="30px">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton10" runat="server" Text="نوع الصورة" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=content_images_types"></asp:LinkButton>
     </li>
 
</ul></td>
   

<td align="right" dir="rtl" colspan="2">
     <ul style="font-size: large; margin-bottom: 0px;">
    <li dir="rtl" style="text-indent: -15px; font-size: 18px;">
    <asp:LinkButton id="linkbutton12" runat="server" Text="العنصر المعمارى الخاص بهذا الطراز" PostBackUrl="~/administration/lookup_grd_veiw.aspx?id=architechture_elemnts"></asp:LinkButton>
     </li>
 
</ul></td>
    </tr>
   
  
</table>

</asp:Content>

