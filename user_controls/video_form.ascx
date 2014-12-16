<%@ Control Language="C#" AutoEventWireup="true" CodeFile="video_form.ascx.cs" Inherits="user_controls_video_form" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .style2
    {
    	margin-bottom:0px;
    	}
    </style>
<script type="text/javascript">
     function ShowPopup() {
         alert(" لم يتم حفظ تفاصيل الاستمارة هناك حقول لم يتم ادخالها ");
     }

     function ValidateAndShowPopup() {
         if (Page_ClientValidate('page') == false) {
             ShowPopup();
         }
     }
</script>

<asp:HiddenField id="content_id" Visible="false" runat="server"/>
<asp:HiddenField id="content_type" Visible="false" runat="server"/>
<table id="tblVideo" border="0" cellspacing="5" runat="server" dir='<%$Resources:Master, dir%>' width="760px" > 
 
    <tr>
    <td colspan="2" align="center" height="60px">
         <asp:Label ID="Label25" runat="server" Text=" إستمارة بيانات التسجيلات التلفزيونية " ForeColor="Black" Font-Bold="true" Font-Size="16px"></asp:Label>
    </td>
    <td > <a href="#" runat="server" id="id_href" target="_blank" visible="false" > 
        عرض الاستمارة
        </a></td>
   </tr>
   <tr runat="server" id="trTitle">
    <td  valign="top" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
         <asp:Label ID="lbl2" runat="server" Text="<%$Resources:Master, lbl_Recording_title%>"></asp:Label>
    </td>
    <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" valign="top" colspan="2">
        
        <asp:Label ID="txtTitle" runat="server" Font-Bold="True" Font-Size="14px" ></asp:Label>
        
    </td>
   
   </tr>
    <tr style="height: 36px" runat="server" id="trHighlight" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
    
    <td  valign="top" runat="server" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
         <asp:Label ID="lblHighlight" runat="server" Text='<%$Resources:Master, lblHighlight%>' ></asp:Label>
    </td>

    <td valign="top" runat="server" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
       <asp:CheckBox ID="chk_highlight" runat="server" Text="علي الموقع" />
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chk_pano" runat="server" Text="علي بانوراما التراث" />
    </td>
    
    <td>
    
    </td>
   </tr>
   
    <tr runat="server" id="trType">
    <td  valign="top">
         <asp:Label ID="lbl3" runat="server" Text="نوع العمل : "></asp:Label>
    </td>
    <td align="right">
        <asp:RadioButtonList ID="RblMediaType" runat="server" RepeatColumns="4" 
            RepeatDirection="Horizontal"  DataTextField="title" 
            DataValueField="id" Width="100%">
           
        </asp:RadioButtonList>
    </td>
    <td>
        
    </td>
    </tr>
    <tr runat="server" id="trDesc">
         <td  valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="lbl4" runat="server" Text="<%$Resources:Master, lbl_Recording_Description%>"></asp:Label>
         </td>
         <td>
            <asp:TextBox ID="txtDesc" runat="server"   TextMode="MultiLine" 
                 Height="60px" Width="100%"></asp:TextBox>
         </td>
         <td align="right" dir="rtl" valign="top">
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txtDesc" ValidationGroup="page"
                 Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    <tr runat="server" id="tr_url">
        <td width="100px" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="lbl7" runat="server" 
                Text="رابط العمل"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUrl" runat="server" Height="26px" Width="100%"></asp:TextBox>
        </td>
        <td align="right" dir="rtl" valign="top">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtUrl" ValidationGroup="page" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trName">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' >
            <asp:Label ID="lbl5" runat="server" Text="<%$Resources:Master, lbl_Recording_Title_number_episode %>"></asp:Label>
        </td>
        <td>
                <asp:TextBox ID="txtName" runat="server"  Height="26px" Width="100%" ></asp:TextBox>
    
        </td>
        <td>
        
    </td>
    </tr>
    <tr runat="server" id="trDuration">
        <td dir="rtl" >
            <asp:Label ID="lbl6" runat="server" Text="المدة : "></asp:Label>
        </td>
        <td align="right">
            &nbsp;<asp:DropDownList ID="ddlSec" runat="server" >
                <asp:ListItem Text="00" ></asp:ListItem><asp:ListItem Text="01" ></asp:ListItem>
                <asp:ListItem Text="02" ></asp:ListItem><asp:ListItem Text="03" ></asp:ListItem>
                <asp:ListItem Text="04" ></asp:ListItem><asp:ListItem Text="05" ></asp:ListItem>
                <asp:ListItem Text="06" ></asp:ListItem><asp:ListItem Text="07" ></asp:ListItem>
                <asp:ListItem Text="08" ></asp:ListItem><asp:ListItem Text="09" ></asp:ListItem>
                <asp:ListItem Text="10" ></asp:ListItem><asp:ListItem Text="11" ></asp:ListItem>
                <asp:ListItem Text="12" ></asp:ListItem><asp:ListItem Text="13" ></asp:ListItem>
                <asp:ListItem Text="14" ></asp:ListItem><asp:ListItem Text="15" ></asp:ListItem>
                <asp:ListItem Text="16" ></asp:ListItem><asp:ListItem Text="17" ></asp:ListItem>
                <asp:ListItem Text="18" ></asp:ListItem><asp:ListItem Text="19" ></asp:ListItem>
                <asp:ListItem Text="20" ></asp:ListItem><asp:ListItem Text="21" ></asp:ListItem>
                <asp:ListItem Text="22" ></asp:ListItem><asp:ListItem Text="23" ></asp:ListItem>
                <asp:ListItem Text="24" ></asp:ListItem><asp:ListItem Text="25" ></asp:ListItem>
                <asp:ListItem Text="26" ></asp:ListItem><asp:ListItem Text="27" ></asp:ListItem>
                <asp:ListItem Text="28" ></asp:ListItem><asp:ListItem Text="29" ></asp:ListItem>
                <asp:ListItem Text="30" ></asp:ListItem><asp:ListItem Text="31" ></asp:ListItem>
                <asp:ListItem Text="32" ></asp:ListItem><asp:ListItem Text="33" ></asp:ListItem>
                <asp:ListItem Text="34" ></asp:ListItem><asp:ListItem Text="35" ></asp:ListItem>
                <asp:ListItem Text="36" ></asp:ListItem><asp:ListItem Text="37" ></asp:ListItem>
                <asp:ListItem Text="38" ></asp:ListItem><asp:ListItem Text="39" ></asp:ListItem>
                <asp:ListItem Text="40" ></asp:ListItem><asp:ListItem Text="41" ></asp:ListItem>
                <asp:ListItem Text="42" ></asp:ListItem><asp:ListItem Text="43" ></asp:ListItem>
                <asp:ListItem Text="44" ></asp:ListItem><asp:ListItem Text="45" ></asp:ListItem>
                <asp:ListItem Text="46" ></asp:ListItem><asp:ListItem Text="47" ></asp:ListItem>
                <asp:ListItem Text="48" ></asp:ListItem><asp:ListItem Text="49" ></asp:ListItem>
                <asp:ListItem Text="50" ></asp:ListItem><asp:ListItem Text="51" ></asp:ListItem>
                <asp:ListItem Text="52" ></asp:ListItem><asp:ListItem Text="53" ></asp:ListItem>
                <asp:ListItem Text="54" ></asp:ListItem><asp:ListItem Text="55" ></asp:ListItem>
                <asp:ListItem Text="56" ></asp:ListItem><asp:ListItem Text="57" ></asp:ListItem>
                <asp:ListItem Text="58" ></asp:ListItem><asp:ListItem Text="59" ></asp:ListItem>
                
            </asp:DropDownList>
           &nbsp;
           <asp:Label ID="Label1" runat="server" Text="ثانية" ></asp:Label>
           
           <asp:DropDownList ID="ddlMin" runat="server" >
                <asp:ListItem Text="00" ></asp:ListItem><asp:ListItem Text="01" ></asp:ListItem>
                <asp:ListItem Text="02" ></asp:ListItem><asp:ListItem Text="03" ></asp:ListItem>
                <asp:ListItem Text="04" ></asp:ListItem><asp:ListItem Text="05" ></asp:ListItem>
                <asp:ListItem Text="06" ></asp:ListItem><asp:ListItem Text="07" ></asp:ListItem>
                <asp:ListItem Text="08" ></asp:ListItem><asp:ListItem Text="09" ></asp:ListItem>
                <asp:ListItem Text="10" ></asp:ListItem><asp:ListItem Text="11" ></asp:ListItem>
                <asp:ListItem Text="12" ></asp:ListItem><asp:ListItem Text="13" ></asp:ListItem>
                <asp:ListItem Text="14" ></asp:ListItem><asp:ListItem Text="15" ></asp:ListItem>
                <asp:ListItem Text="16" ></asp:ListItem><asp:ListItem Text="17" ></asp:ListItem>
                <asp:ListItem Text="18" ></asp:ListItem><asp:ListItem Text="19" ></asp:ListItem>
                <asp:ListItem Text="20" ></asp:ListItem><asp:ListItem Text="21" ></asp:ListItem>
                <asp:ListItem Text="22" ></asp:ListItem><asp:ListItem Text="23" ></asp:ListItem>
                <asp:ListItem Text="24" ></asp:ListItem><asp:ListItem Text="25" ></asp:ListItem>
                <asp:ListItem Text="26" ></asp:ListItem><asp:ListItem Text="27" ></asp:ListItem>
                <asp:ListItem Text="28" ></asp:ListItem><asp:ListItem Text="29" ></asp:ListItem>
                <asp:ListItem Text="30" ></asp:ListItem><asp:ListItem Text="31" ></asp:ListItem>
                <asp:ListItem Text="32" ></asp:ListItem><asp:ListItem Text="33" ></asp:ListItem>
                <asp:ListItem Text="34" ></asp:ListItem><asp:ListItem Text="35" ></asp:ListItem>
                <asp:ListItem Text="36" ></asp:ListItem><asp:ListItem Text="37" ></asp:ListItem>
                <asp:ListItem Text="38" ></asp:ListItem><asp:ListItem Text="39" ></asp:ListItem>
                <asp:ListItem Text="40" ></asp:ListItem><asp:ListItem Text="41" ></asp:ListItem>
                <asp:ListItem Text="42" ></asp:ListItem><asp:ListItem Text="43" ></asp:ListItem>
                <asp:ListItem Text="44" ></asp:ListItem><asp:ListItem Text="45" ></asp:ListItem>
                <asp:ListItem Text="46" ></asp:ListItem><asp:ListItem Text="47" ></asp:ListItem>
                <asp:ListItem Text="48" ></asp:ListItem><asp:ListItem Text="49" ></asp:ListItem>
                <asp:ListItem Text="50" ></asp:ListItem><asp:ListItem Text="51" ></asp:ListItem>
                <asp:ListItem Text="52" ></asp:ListItem><asp:ListItem Text="53" ></asp:ListItem>
                <asp:ListItem Text="54" ></asp:ListItem><asp:ListItem Text="55" ></asp:ListItem>
                <asp:ListItem Text="56" ></asp:ListItem><asp:ListItem Text="57" ></asp:ListItem>
                <asp:ListItem Text="58" ></asp:ListItem><asp:ListItem Text="59" ></asp:ListItem>
                
            </asp:DropDownList>
              &nbsp;
              <asp:Label ID="Label2" runat="server" Text="  دقيقة"></asp:Label>
               &nbsp;
            <asp:TextBox ID="txthours" runat="server" Width="40px" Text="00"/>
            &nbsp;
           <asp:Label ID="Label22" runat="server" Text="ساعة" ></asp:Label>
           
        </td>
        <td>
         
    </td>
    </tr>
    <tr runat="server" id="trGuest">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label3" runat="server" Text="<%$Resources:Master, lbl_Recording_Guests_Post %>"></asp:Label>
        </td>
        <td align="right">
            <asp:TextBox ID="txtGuestName" runat="server"  Height="26px" Width="100%" 
                 ></asp:TextBox>
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txtGuestName" ValidationGroup="page"
                Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    <tr runat="server" id="trGuestPosition">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' >
            <asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, lbl_Recording_Guests_position %>"></asp:Label>
        </td>
        <td align="right">
            <asp:TextBox ID="TextGuestDesc" runat="server"  Height="26px" Width="100%" ></asp:TextBox>
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="TextGuestDesc" ValidationGroup="page"
                Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    <tr runat="server" id="trCommenter">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label6" runat="server" 
                Text="<%$ Resources:Master, lbl_Recording_Broadcaster_interviewer %>" 
                Width="155px"></asp:Label>
        </td>
        <td align="right">
            <asp:TextBox ID="txtCommenterName" runat="server"  Height="26px" Width="100%" ></asp:TextBox>
        </td>
        <td>
         
    </td>
    </tr>
    <tr runat="server" id="trDate">
       <td dir="rtl"  class="">
            <asp:Label ID="Label5" runat="server" Text="تاريخ التسجيل أو الإذاعة : "></asp:Label>
        </td>
        <td align="right">
        <asp:Label ID="Label7" runat="server" Text="هجرى :"  
             Width="50px"    Height="23px"></asp:Label>
            <asp:TextBox ID="txtHijriDate" runat="server"  Height="20px"
                    />
                  
                
                 
        
             <br />
                <asp:Label ID="Label8" runat="server" Text="ميلادى :" 
               Width="50px"  Height="23px"></asp:Label>
              <asp:TextBox ID="txtGorgDate" runat="server"  Height="20px"
                    />
           
                   
             
                  
          
           
        
        </td>
        <td>
        
    </td>
    </tr>
    <tr runat="server" id="trResourceName">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'  class="" rowspan="1" valign="top">
            <asp:Label ID="Label9" runat="server" 
                Text="<%$ Resources:Master, lbl_Recording_Source %>" Height="26px"></asp:Label>
               
                <asp:Label ID="Label10" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_name %>"  Height="32px" Style="float:left"></asp:Label>
                <br />
            <br />
                <asp:Label ID="Label11" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_country %>"  Height="32px" Style="float:left"></asp:Label>
                <br />
            <br />
                <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_city %>"  Height="32px" Style="float:left"></asp:Label>
                <br />
            <br />
                <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_Book_shelving_no %>" 
                 Height="32px" Style="float:left"></asp:Label>
                <br />
                <asp:Label ID="Label14" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_notes %>" Height="50px"></asp:Label>
        </td>
        <td valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1">
            <asp:Label ID="Label110" runat="server" Height="26px" Visible="false"></asp:Label> 
             <asp:TextBox ID="txtresourceName" runat="server"  Height="26px" Width="100%"
                    />
                 
       <br />
                   
             <asp:TextBox ID="txtresourceCountry" runat="server"  Height="26px" Width="100%"
                    />
                  <br />
                    
             <asp:TextBox ID="txtresourceCity" runat="server"  Height="26px" Width="100%"
                   />
                   <br />
                     
             <asp:TextBox ID="txtSaveNo" runat="server"  Height="26px"
                   CssClass="style2" Width="100%" />
                  <br />
                     
             <asp:TextBox ID="txtResourceNote" runat="server"  Height="50px"
                   TextMode="MultiLine" Width="100%" />
                   
        </td>
       
    </tr>
    <tr runat="server" id="trNotes">
         <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
            <asp:Label ID="Label15" runat="server" Text="<%$Resources:Master, lbl_Recording_notes %>"></asp:Label>
        </td>
        <td align="right">
            <asp:TextBox ID="txtNotes" runat="server"   TextMode="MultiLine" 
                Height="60px" Width="100%"></asp:TextBox>
         </td>
         <td>
         
    </td>
    </tr>
    <tr runat="server" id="trLinkWords">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
            <asp:Label ID="Label16" runat="server" Text="<%$Resources:Master, lbl_Recording_keyword %>"></asp:Label>
        </td>
         <td valign="top">
            <asp:TextBox ID="txtLinkWords" runat="server"   
                 TextMode="MultiLine" Height="60px" Width="100%"></asp:TextBox>
            <asp:Label ID="lblDeclaration" runat="server" 
                 Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2" 
                 Font-Size="12px" ForeColor="Red" ></asp:Label>
         </td>
         <td align="right" dir="rtl" valign="top">
         <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txtLinkWords" ValidationGroup="page"
                 Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    <tr runat="server" id="trTimeLine">
        <td dir="rtl"  class="" rowspan="1" valign="top">
            <asp:Label ID="Label17" runat="server" 
                Text="العصر الذي يتناوله التسجيل ويدور حوله  : " Width="155px"></asp:Label>
        </td>
         <td align="right" colspan="1">
        <asp:RadioButtonList ID="rblTimeLine" runat="server" RepeatColumns="3" 
            RepeatDirection="Horizontal"  DataTextField="title" 
                 DataValueField="id" Width="100%">
            
          
        </asp:RadioButtonList>
         <asp:Label ID="Label18" runat="server" Text="ملاحظات  : " Width="100%" ></asp:Label>
         <asp:TextBox ID="txtTimelineNotes" runat="server" 
                    TextMode="MultiLine" Width="100%"   />
        
    </td>
       <td></td>
    </tr>
  
    <tr runat="server" id="trFormImage">
         <td dir="rtl" rowspan="1" valign="top">
            <asp:Label ID="Label19" runat="server" Text="الصورة المرفقة مع الاستمارة  : "></asp:Label>
        </td>
        <td align="right">
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" Width="100%" 
                >
            <asp:ListItem Text="مرفقة (ورقية / إلكترونية)"></asp:ListItem>
            <asp:ListItem Text="غير متاحة (سيتم توفيرها لاحقا)" Selected="True" ></asp:ListItem>
            <asp:ListItem Text="غير متاحة (استخدم الصورة الرمزية)"></asp:ListItem>
           
          
        </asp:RadioButtonList>
        </td>
        <td>
         
    </td>
    </tr>
    <tr runat="server" id="trFormDataCollectorName">
        <td dir="rtl"  class="" rowspan="1" valign="top">
               <asp:Label ID="Label20" runat="server" Text="اسم جامع بيانات الاستمارة  : " 
                 ></asp:Label>
        </td>
         <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
         
             <asp:TextBox ID="txtFormDataColectorName" runat="server"  
                    Height="26px" Width="100%"  />
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="page"
                ControlToValidate="txtFormDataColectorName" Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    <tr runat="server" id="trFormDataRevisionName">
          <td dir="rtl"  class="" rowspan="1" valign="top">
                <asp:Label ID="Label21" runat="server" Text="اسم مراجع بيانات الاستمارة  : " 
                 ></asp:Label>
        </td>
         <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
          
             <asp:TextBox ID="txtFormDataRevisionName" runat="server"  
                    Height="26px" Width="100%"  />
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="page"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    <%--<tr runat="server" id="trFormDataEntryName">
         <td dir="rtl"  class="" rowspan="1" valign="top">
                 <asp:Label ID="Label22" runat="server" 
                     Text="اسم مدخل بيانات الاستمارة على الحاسب الآلي  : " Width="155px" 
                 ></asp:Label>
        </td>
         <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
          
             <asp:TextBox ID="txtFormDataEntryName" runat="server"  
                    Height="26px" Width="100%"  />
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txtFormDataEntryName" ValidationGroup="page"
                Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    <tr runat="server" id="trFormDataEntryRevisionName">
          <td dir="rtl"  class="" rowspan="1" valign="top">
                  <asp:Label ID="Label23" runat="server" 
                      Text="اسم مراجع إدخال بيانات الاستمارة على الحاسب الآلي  : " Width="155px" 
                ></asp:Label>
        </td>
         <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
           
             <asp:TextBox ID="txtFormDataEntryRevisionName" runat="server" Width="100%"  />
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="page"
                ControlToValidate="txtFormDataEntryRevisionName" Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>--%>
    <tr runat="server" id="file_tr">
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>"  rowspan="1" valign="top" >
            <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master, Topics_upload %>"></asp:Label>
        </td>
        <td dir="ltr"  rowspan="1" valign="top" align="left">
            <%--<asp:Label ID="Label55" runat="server" Font-Size="14px" ForeColor="Red" 
                Width="40%"></asp:Label>--%>
            <asp:FileUpload ID="uploadfile" runat="server" Width="100%"  />
        
      
        </td>
        <td>
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px" ForeColor="Red"></asp:Label>
            
        </td>
    </tr>
   <%-- <tr>
    
        <td colspan="3">
           <cc1:FilteredTextBoxExtender ID="FilteredtxtHijriDate" runat="server" FilterType="Custom"
                    TargetControlID="txtHijriDate" ValidChars="0123456789/\"></cc1:FilteredTextBoxExtender>
                   <br /> <cc1:FilteredTextBoxExtender ID="FilteredtxtGorgDate" runat="server" FilterType="Custom"
                    TargetControlID="txtGorgDate" ValidChars="0123456789/\"></cc1:FilteredTextBoxExtender>
        </td>
    </tr>--%>
    <tr runat="server" id="trSave">
        <td align="center" colspan="3" height="60px" valign="middle">
            <asp:Button ID="btnsave" runat="server" Text="حفظ تفاصيل الاستمارة" ValidationGroup="page"
                onclick="btnsave_Click"  OnClientClick="ValidateAndShowPopup()"  />
        </td>
       
    </tr>
</table>