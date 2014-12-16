<%@ Control Language="C#" AutoEventWireup="true" CodeFile="places_form.ascx.cs" Inherits="user_controls_places_form"  %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<asp:HiddenField id="content_id" Visible="false" runat="server"/>
<asp:HiddenField id="content_type" Visible="false" runat="server"/>
 <script type="text/javascript">
     function ShowPopup() {
         alert(" لم يتم حفظ تفاصيل الاستمارة هناك حقول لم يتم ادخالها ");
     }

     function ValidateAndShowPopup() {
         if (document.getElementById("<%=gv_building_material.ClientID %>")== null) {
             alert(" لم يتم ادخال خامات البناء ");
         }
         
         if (Page_ClientValidate('page') == false) {
             ShowPopup();
         }
     }
</script>
 <asp:TextBox ID="hiddintxtInputDiv33" runat="server" 
ForeColor="White"   BackColor="White" Height="26px"
BorderColor="#000CCC" BorderStyle="None" Width="5px" ></asp:TextBox>
 
 <script language="javascript" type="text/javascript"> 
    function show_hide_fun(controlID)
        {
           
          
              if(controlID=="Div33")
            {
                var param="<%=Div33.ClientID %>"
                var hiddenparam="<%=hiddintxtInputDiv33.ClientID %>";
            }
            
            
            
            var ctrID =  document.getElementById(param);
            var hiddinInputCtrID = document.getElementById(hiddenparam);
           
            if(ctrID.style.display == 'none')
               {
                ctrID.style.display = 'block';
                hiddinInputCtrID.value="1";
               } 
                
            else
            {
                ctrID.style.display = 'none';
                hiddinInputCtrID.value="0";
               
             }
             
            if(ctrID.id=='ctl00_ContentPlaceHolder1_ctl06_Div33')
             {
             document.getElementById("ctl00_ContentPlaceHolder1_ctl06_hiddintxtInputDiv33").Text="1";
             }


         }
         var atLeast = 1
         function Validate() {
             var CHK = document.getElementById("<%=rbl_building_raw_material.ClientID%>");
             var checkbox = CHK.getElementsByTagName("input");
             var counter = 0;
             for (var i = 0; i < checkbox.length; i++) {
                 if (checkbox[i].checked) {
                     counter++;
                 }
             }
             if (atLeast > counter) {
                 alert("Please select atleast " + atLeast + " item(s)");
                 return false;
             }
             return true;
         }
         function GetSelectedItem() 
         {
             var rblselectedval;
             
             var CHK = document.getElementById("<%=rbl_building_raw_material.ClientID%>");
             var checkbox = CHK.getElementsByTagName("input");
             var label = CHK.getElementsByTagName("label");
             for (var i = 0; i < checkbox.length; i++) 
             {
                 if (checkbox[i].checked) 
                 {
                     //alert("Selected = " + label[i].innerHTML);
                     rblselectedval =  label[i].innerHTML
                 }
             }
             var param = "<%=txt_building_raw_material_other.ClientID %>"

             var ctrID = document.getElementById(param);
             if (rblselectedval == 'أخرى:') 
             {
                 if (ctrID.style.display = 'none') 
                 {
                     ctrID.style.display = 'block';

                 }

                 else {
                     
                     ctrID.style.display = 'none';
 

                 }
             }
             else 
             {
                 ctrID.style.display = 'none';
             }
             
             return true;



         }

         function Get_material_useSelectedValue(rbl_building_raw_material_use) {
             var rblselectedval;
             for (var i = 0; i < rbl_building_raw_material_use.rows.length; ++i) {
                 for (var j = 0; j < rbl_building_raw_material_use.rows[i].cells.length; ++j) {
                     if (rbl_building_raw_material_use.rows[i].cells[j].firstChild != null) {
                         if (rbl_building_raw_material_use.rows[i].cells[j].firstChild.checked) {


                             rblselectedval = rbl_building_raw_material_use.rows[i].cells[j].firstChild.value;
                             // alert(rblselectedval);
                         }
                     }
                 }
             }
             var param = "<%=txt_building_raw_material_use_other.ClientID %>"

             var ctrID = document.getElementById(param);
             if (rblselectedval == 3) {
                 ctrID.style.display = 'block';

             }

             else {
                 ctrID.value = "";
                 ctrID.style.display = 'none';


             }
             
         }
         function GetRadioButtonListSelectedValue(rbl_place_type) 
         {
             var rblselectedval;
             for (var i = 0; i < rbl_place_type.rows.length; ++i) 
             {
                 for (var j = 0; j < rbl_place_type.rows[i].cells.length; ++j) 
                 {
                     if (rbl_place_type.rows[i].cells[j].firstChild != null) 
                     {
                         if (rbl_place_type.rows[i].cells[j].firstChild.checked) 
                         {


                             rblselectedval = rbl_place_type.rows[i].cells[j].firstChild.value;
                            // alert(rblselectedval);
                         } 
                     }
                 }
             }
             var param = "<%=txt_place_type_another.ClientID %>"

             var ctrID = document.getElementById(param);
             if (rblselectedval == 19) 
             {
                 ctrID.style.display = 'block';

             }

             else 
             {
                 ctrID.style.display = 'none';


             }

         }
         function GetRBLmain_archSelectedValue(rbl_main_architectural_styles_type) {
             var rblselectedval;

             for (var i = 0; i < rbl_main_architectural_styles_type.rows.length; ++i) {
                 for (var j = 0; j < rbl_main_architectural_styles_type.rows[i].cells.length; ++j) {
                     if (rbl_main_architectural_styles_type.rows[i].cells[j].firstChild != null) {
                         if (rbl_main_architectural_styles_type.rows[i].cells[j].firstChild.checked) {


                             rblselectedval = rbl_main_architectural_styles_type.rows[i].cells[j].firstChild.value;
                             // alert(rblselectedval);
                         }
                     }
                 }
             }
             var param = "<%=txt_main_architectural_styles_type_other.ClientID %>"

             var ctrID = document.getElementById(param);
             if (rblselectedval == 12) {
                 ctrID.style.display = 'block';

             }

             else {
                 ctrID.style.display = 'none';


             }

         }
         function GetRBLSelectedValue(rbl) {
             var rblselectedval;
            
             for (var i = 0; i < rbl.rows.length; ++i) {
                 for (var j = 0; j < rbl.rows[i].cells.length; ++j) {
                     if (rbl.rows[i].cells[j].firstChild != null) {
                         if (rbl.rows[i].cells[j].firstChild.checked) {


                             rblselectedval = rbl.rows[i].cells[j].firstChild.value;
                             // alert(rblselectedval);
                         }
                     }
                 }
             }
             var param=""
             if (rbl.id == 'ctl00_ContentPlaceHolder1_TabContainer1_TabPanel1_ctl01_rbl_current_function')
                  param = "<%=txt_current_function_other.ClientID %>"
             else if (rbl.id == 'ctl00_ContentPlaceHolder1_TabContainer1_TabPanel1_ctl01_rbl_function_through_age')
                  param = "<%=txt_fun_through_age_other.ClientID %>"

              if (param != "") {
                  var ctrID = document.getElementById(param);
                  if (rblselectedval == 19) {
                      ctrID.style.display = 'block';

                  }

                  else {
                      ctrID.value = "";
                      ctrID.style.display = 'none';


                  } 
              }

         }
         
      
        
       
    </script>
    <%-- <input type="hidden" id="hiddinInputDiv1" runat="server" />
    <input type="hidden" id="hiddinInputDiv2" runat="server" />
    <input type="hidden" id="hiddinInputDiv3" runat="server" />
    <input type="hidden" id="hiddinInputDiv4" runat="server" />
    <input type="hidden" id="hiddinInputDiv5" runat="server" />
    <input type="hidden" id="hiddinInputDiv6" runat="server" />--%>
    
    
<table id="tblPlaces" style="width:750px" border="0" cellspacing="5" runat="server" dir='<%$Resources:Master, dir%>' > 
  
 
   
   
    <tr>
    <td colspan="2" align="center" height="60px">
     
         <asp:Label ID="Label25" runat="server" Text="<%$Resources:Master, Places_head %>" 
             ForeColor="Black"  Font-Size="16px"></asp:Label>
            
    </td>
    <td style="width:200px"> <a href="#" runat="server" id="id_href" target="_blank" visible="false">
        عرض الاستمارة
       
        </a></td>
   </tr>
     <tr style="height: 56px" runat="server" id="trName">
    <td valign="top" align="right">
         <asp:Label ID="lbl2" runat="server" Text="<%$Resources:Master, Places_labels_plcaeName %>" 
             Width="160px" ></asp:Label>
    </td>
    <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' valign="top" colspan="2">
        
        
        <asp:TextBox ID="txt_name" runat="server" Font-Size="14px" Font-Bold="true" Height="19px" Width="600px"></asp:TextBox>	
	<asp:RequiredFieldValidator ControlToValidate="txt_name" ValidationGroup="page" runat="server" ErrorMessage="هذا الحقل يجب إدخاله" ID="rfv1"></asp:RequiredFieldValidator>
	
       
    </td>
   
   </tr>
   <tr style="height: 36px" runat="server" id="trHighlight" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
    
    <td valign="top" runat="server" dir='<%$Resources:Master, dir%>' 
           align='<%$Resources:Master, align%>'>
         <asp:Label ID="lblHighlight" runat="server" 
             Text='<%$ Resources:Master, lblHighlight %>' ></asp:Label>
    </td>

    <td  valign="top" runat="server" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
  
            <asp:CheckBox ID="chk_highlight" runat="server" Text="علي الموقع" />
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chk_pano" runat="server" Text="علي بانوراما التراث" />
          
    </td>
    
    <td>
    
    </td>
   </tr>
 
   
   <tr style="height: 50px" runat="server" id="trPlaceType">
    <td valign="top" align="center">
         <asp:Label ID="lbl3" runat="server" Text="نوع الأثر أو المبنى أو المكان : " 
             ></asp:Label>
    </td>
    <td align="right">
        
        <asp:RadioButtonList ID="rbl_place_type" RepeatColumns="4" 
            RepeatDirection="Horizontal" Width="100%" runat="server" onclick="GetRadioButtonListSelectedValue(this);">

         
</asp:RadioButtonList>
        <%--<br />
        <asp:Label ID="lbl__place_type_another" runat="server" Text="اخرى :" Height="26px" 
             Width="9%"></asp:Label>--%>
        <asp:TextBox ID="txt_place_type_another" runat="server"  
            Width="89%" Height="19px" style="display:none" ></asp:TextBox>
    </td>
   
       <td width="150px" align="right" valign="top">
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="rbl_place_type" ValidationGroup="page"
             Font-Size="14px"></asp:RequiredFieldValidator>
    </td> 
    
    </tr>
   <tr runat="server" id="trCreationDate">
       <td dir="rtl" align="right" valign="top">
            <asp:Label ID="Label5" runat="server" Text="تاريخ الإنشاء : " ></asp:Label>
        </td>
        <td align="right">
        <asp:Label ID="Label7" runat="server" Text="هجرى :" Width="40px" 
                Height="23px"></asp:Label>
            <asp:TextBox ID="txt_creation_hijr_date" runat="server"  Height="20px"
                   Width="80px" />
                   
                   <%-- <cc1:FilteredTextBoxExtender ID="FilteredtxtHijriDate" runat="server" FilterType="Custom"
                    TargetControlID="txt_creation_hijr_date" ValidChars="0123456789/\"></cc1:FilteredTextBoxExtender>--%>
                 
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
                <asp:Label ID="Label8" runat="server" Text="ميلادى :" Width="42px" 
                Height="23px"></asp:Label>
              <asp:TextBox ID="txt_creation_georg_date" runat="server"  Height="20px"
                   Width="80px" />
                
                   <%-- <cc1:FilteredTextBoxExtender ID="FilteredtxtGorgDate" runat="server" FilterType="Custom"
                    TargetControlID="txt_creation_georg_date" ValidChars="0123456789/\"></cc1:FilteredTextBoxExtender>--%>
                   
             
               
          
           
        
        </td>
        <td>
        
    </td>
    </tr>
   <tr runat="server" id="trEndCreationDate">
       <td dir="rtl" align="right" valign="top">
            <asp:Label ID="Label26" runat="server" Text="تاريخ الانتهاء من الإنشاء : " 
                ></asp:Label>
        </td>
        <td align="right">
        <asp:Label ID="Label28" runat="server" Text="هجرى :" Width="40px" 
                Height="23px"></asp:Label>
            <asp:TextBox ID="txt_end_creation_hijr_date" runat="server"  Height="20px"
                   Width="80px" />
                   
           <%--         <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Custom"
                    TargetControlID="txt_end_creation_hijr_date" ValidChars="0123456789/\"></cc1:FilteredTextBoxExtender>--%>
                 
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
                <asp:Label ID="Label30" runat="server" Text="ميلادى :" Width="42px" 
                Height="23px"></asp:Label>
              <asp:TextBox ID="txt_end_creation_georg_date" runat="server"  Height="20px"
                   Width="80px" />
                
                   <%-- <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="Custom"
                    TargetControlID="txt_end_creation_georg_date" ValidChars="0123456789/\"></cc1:FilteredTextBoxExtender>--%>
                   
             
              
          
           
        
        </td>
        <td>
        
    </td>
    </tr>
   <tr runat="server" id="trBrief">
         <td valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="lbl4" runat="server" Text="<%$ Resources:Master, Places_labels_briefDescription %>" ></asp:Label>
         </td>
         <td>
            
                   <fckeditorv2:fckeditor id="txt_brief" runat="server" basepath="~/fckeditor/"
                height="400px" Width="100%">
            </fckeditorv2:fckeditor>
         </td>
         <td align="right" dir="rtl" valign="top">
         
    </td>
    </tr>
   <tr runat="server" id="trDesc">
         <td valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label9" runat="server" Text="<%$ Resources:Master, Places_labels_detailDescription %>" ></asp:Label>
         </td>
         <td>
                  <fckeditorv2:fckeditor id="txt_description" runat="server" basepath="~/fckeditor/"
                height="400px" Width="100%">
            </fckeditorv2:fckeditor>
         </td>
         <td align="right" dir="rtl" valign="top">
        
    </td>
    </tr>
   <tr runat="server" id="trNotes">
         <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top" >
            <asp:Label ID="Label15" runat="server" Text="<%$ Resources:Master, Places_labels_notes %>" ></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtNotes" runat="server" Width="100%"  TextMode="MultiLine" 
                Height="60px"></asp:TextBox>
         </td>
         <td>
         
    </td>
    </tr>
   <tr runat="server" id="trLinkWords">
        <td rowspan="1" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label16" runat="server" Text="<%$ Resources:Master, Places_labels_keyWords %>" 
                ></asp:Label>
        </td>
         <td>
            <asp:TextBox ID="txtLinkWords" runat="server" Width="100%"  
                 TextMode="MultiLine" Height="60px"></asp:TextBox>
            <asp:Label ID="lblDeclaration" runat="server" 
                 Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2" 
                 Font-Size="12px" ForeColor="Red"  Width="100%" ></asp:Label>
         </td>
         <td align="right" dir="rtl" valign="top">
         <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txtLinkWords" ValidationGroup="page"
                 Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
   <tr runat="server" id="trPlanning">
         <td  rowspan="1" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label4" runat="server" Text="<%$ Resources:Master, Places_labels_generalOutline %>" ></asp:Label>
        </td>
        <td>
            &nbsp;</td>
         <td>
         
    </td>
    </tr>
    
   <tr runat="server" id="trOutside">
         <td rowspan="1" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label6" runat="server" Text="<%$ Resources:Master, Places_labels_buildingOutside %>" 
                 style="margin-left: 0px; margin-right: 0px"  ></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
            <asp:Label ID="Label32" runat="server" Text="<%$ Resources:Master, Places_entrances %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_outside_entrances" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                <br />
                  <asp:Label ID="Label10" runat="server" Text="<%$ Resources:Master, Places_Faces %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_outside_interfaces" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                <br />
                  <asp:Label ID="Label11" runat="server" Text="<%$ Resources:Master, Places_Windows %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_outside_windows" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                <br />
                  <asp:Label ID="Label12" runat="server" Text="<%$ Resources:Master, Places_Minarets %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_outside_minarets" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                <br />
                  <asp:Label ID="Label13" runat="server" Text="<%$ Resources:Master, Places_Dooms %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_outside_domes" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                
         </td>
         <td>
         
    </td>
    </tr>
   
   <tr runat="server" id="trInside">
         <td rowspan="1" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label14" runat="server" 
                 Text="<%$ Resources:Master, Places_labels_buildingInside %>" 
                 style="margin-left: 0px; margin-right: 0px"  ></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
            <asp:Label ID="Label33" runat="server" Text="<%$ Resources:Master, Places_Playground %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_inside_yard" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                <br />
                  <asp:Label ID="Label34" runat="server" Text="<%$ Resources:Master, Places_Ceilings %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_inside_roofs" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                <br />
                  <asp:Label ID="Label35" runat="server" Text="<%$ Resources:Master, Places_Awning %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_inside_iwans" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                <br />
                  <asp:Label ID="Label36" runat="server" Text="<%$ Resources:Master, Places_Rooms_Halls %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_inside_halls" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                <br />
                  <asp:Label ID="Label37" runat="server" Text="<%$ Resources:Master, Places_Desks %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_inside_seats" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                 <br />
                  <asp:Label ID="Label38" runat="server" Text="<%$ Resources:Master, Places_Accessories %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_inside_supplements" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                 <br />
                  <asp:Label ID="Label39" runat="server" Text="<%$ Resources:Master, Places_Charity_room %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_inside_sabeel_room" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
         </td>
         <td>
         
    </td>
    </tr>
   
   <tr runat="server" id="trDecoration">
         <td rowspan="1" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label40" runat="server" Text="<%$ Resources:Master, Places_decorations %>"
                  Width="115px"></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' valign="top">
            <asp:Label ID="Label41" runat="server" Text="<%$ Resources:Master, Places_labels_writings %>" Height="26px" 
                Width="100%"></asp:Label>
       <asp:TextBox ID="txt_literature" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                <br />
                <asp:Label ID="Label42" runat="server" Text="<%$ Resources:Master, Places_labels_geomDecorations %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_geometric" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
                <br />
                <asp:Label ID="Label43" runat="server" Text="<%$ Resources:Master, Places_labels_BotanDecorations %>" Height="26px" 
                Width="100%"></asp:Label>
         <asp:TextBox ID="txt_floral" runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
              
                </td>
         <td>
         
    </td>
    </tr>

   <tr runat="server" id="trArchitecture">
         <td rowspan="1" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label44" runat="server" Text="<%$ Resources:Master, Places_Architectural %>"
                 ></asp:Label>
        </td>
        <td>
            &nbsp;</td>
         <td>
         
    </td>
    </tr>
  
   <tr runat="server" id="trMainArchitecture">
         <td rowspan="1" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label45" runat="server" Text="<%$ Resources:Master, Places_Main_style %>"
                  Width="115px"></asp:Label>
        </td>
        <td valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:RadioButtonList ID="rbl_main_architectural_styles_type" runat="server" RepeatColumns="3" 
            RepeatDirection="Horizontal" Width="100%" onclick="GetRBLmain_archSelectedValue(this);">
        
          
        </asp:RadioButtonList>
              <br />
        <%--<asp:Label ID="lbl_main_architectural_styles_type_other" runat="server" 
                Text="اخرى :" Height="26px" 
             Width="100%"></asp:Label>--%>
             <asp:TextBox ID="txt_main_architectural_styles_type_other" runat="server" 
                 Width="100%" Height="26px" style="display:none"></asp:TextBox>
                 <br />
                 <br />
            <asp:Label ID="Label46" runat="server" Height="26px" 
                Text="<%$ Resources:Master, Places_labels_originalStyle %>" Width="100%"></asp:Label>
                <br />
           <asp:TextBox ID="txt_main_architectural_styles_type_general_feature" 
                runat="server" Height="52px" Width="100%" 
                TextMode="MultiLine" ></asp:TextBox>
            <br />
            <asp:Label ID="Label47" runat="server" Height="26px" Text="<%$ Resources:Master, Places_labels_GNotes %>" 
                Width="60px"></asp:Label>
            <asp:TextBox ID="txt_main_architectural_styles_type_notes" runat="server" 
                Height="26px" Width="395px"></asp:TextBox>
            <br />
         </td>
        <td align="right" dir="rtl" valign="top">
        <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="rbl_main_architectural_styles_type" ValidationGroup="page"
                 Font-Size="14px"></asp:RequiredFieldValidator>
                 <br />
                    <br />
                    <br />
                    <br />
                  
                    <br />
                    <br />
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txt_main_architectural_styles_type_general_feature" ValidationGroup="page"
                 Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    
   
    
   <tr runat="server" id="trMaterial">
         <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
            <asp:Label ID="Label57" runat="server" Text="<%$ Resources:Master, Places_Building_materials %>" ></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' valign="top">
            <asp:Label ID="Label58" runat="server" Text="- المادة الخام : " Width="100%"></asp:Label>
            <asp:CheckBoxList ID="rbl_building_raw_material" runat="server" RepeatColumns="3" ValidationGroup="raw_material"
                RepeatDirection="Horizontal" Width="100%" OnClick="return GetSelectedItem()">
               
            </asp:CheckBoxList>
            <br />
           <%-- <asp:Label ID="lbl_building_raw_material_other" runat="server" Height="26px" Text="اخرى :" 
                 Width="9%"></asp:Label>--%>
            <asp:TextBox ID="txt_building_raw_material_other" runat="server" 
                 Width="89%" Height="26px" style="display:none"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label60" runat="server" Text="- موضع استخدام المادة الخام : " 
                Width="100%"></asp:Label>
            <asp:RadioButtonList ID="rbl_building_raw_material_use" runat="server" ValidationGroup="raw_material"
                RepeatDirection="Horizontal" Width="100%" onclick="Get_material_useSelectedValue(this);">
               
            </asp:RadioButtonList>
            
           <%-- <asp:Label ID="lbl_building_raw_material_use_other" runat="server" 
                Height="26px" Text="اخرى :" 
                 Width="9%"></asp:Label>--%>
            <asp:TextBox ID="txt_building_raw_material_use_other" runat="server" 
                 Width="89%" Height="26px" style="display:none"></asp:TextBox>
            <br />
             <br />
            <asp:Label ID="Label63" runat="server" Height="26px" Text="<%$ Resources:Master, Places_lab_buildingNotes %>" 
                Width="60px"></asp:Label>
            <asp:TextBox ID="txt_building_raw_material_notes" runat="server" Height="26px" 
                Width="395px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_save_building_material" runat="server" OnClick="btn_save_building_material_click" 
                style="margin-right: 145px" Text="أضف خامة بناء" ValidationGroup="raw_material" 
                OnClientClick ="return Validate()"/>
            <br />
            <br />
            <asp:GridView ID="gv_building_material" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataKeyNames="id" ForeColor="#333333" GridLines="None" 
                Visible="false" Width="100%" >
                <HeaderStyle BackColor="#D9C69E"  ForeColor="White" 
                    HorizontalAlign="Center" />
                <Columns>
                    
                      <asp:TemplateField HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="المادة الخام" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <ItemTemplate>
                         <asp:Label ID="lblConTitle" runat="server"></asp:Label>
                     </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:TemplateField>
                    
                    
                    <asp:BoundField DataField="con_elemnt" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="موضع استخدام المادة الخام" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="building_raw_material_notes" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="ملاحظة" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="تعديل" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgEdit0" runat="server" 
                                CommandArgument='<%# Eval("id") %>' CommandName="building_material"
                                ImageUrl="~/images/Edit.jpg" OnClick="imgEdit_Click" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgDelete0" runat="server" 
                                CommandArgument='<%# Eval("id") %>' CommandName="building_material"
                                ImageUrl="~/images/delete.gif" OnClick="imgDelete_Click" 
                                OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
             <asp:TextBox ID="txt_building_material_id" runat="server" Height="26px"  
            ForeColor="white"   BackColor="white" 
            BorderColor="#000CCC" BorderStyle="None" Width="300px" ></asp:TextBox>
            <asp:TextBox ID="txt_building_material_validating" runat="server" Visible="false"></asp:TextBox>
           
         </td>
         <td align="right" dir="rtl" valign="top">
          <br />
          <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server"  
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="rbl_building_raw_material" ValidationGroup="raw_material"
                                     Font-Size="14px" ></asp:RequiredFieldValidator>  --%>
                                    <br />
                                    <br />
                                  <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" 
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="rbl_building_raw_material_use" ValidationGroup="raw_material"
                                     Font-Size="14px"></asp:RequiredFieldValidator>  
    </td>
    </tr>
   
   <tr runat="server" id="trFunction">
         <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
            <asp:Label ID="Label62" runat="server" Text="<%$ Resources:Master, Places_fun %>"
                  ></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'  valign="top">
            <asp:Label ID="Label64" runat="server" Text="- الوظيفة الحالية : " Width="100%"></asp:Label>
            <asp:RadioButtonList ID="rbl_current_function" runat="server" RepeatColumns="3" 
                RepeatDirection="Horizontal" Width="100%" onclick="GetRBLSelectedValue(this);">
                
            </asp:RadioButtonList>
            <br />
           <%-- <asp:Label ID="lbl_current_function_other" runat="server" Height="26px" Text="اخرى :" 
                 Width="9%"></asp:Label>--%>
            <asp:TextBox ID="txt_current_function_other" runat="server"  
                Width="89%" Height="26px" style="display:none"></asp:TextBox>
            <br />
            <br />
              <asp:Label ID="Label66" runat="server" Height="26px" Text="<%$ Resources:Master, Places_lab_buildingJobNotes %>" 
                Width="60px"></asp:Label>
            <asp:TextBox ID="txt_current_function_notes" runat="server" Height="26px" 
                Width="395px"></asp:TextBox>
            
         </td>
         <td align="right" dir="rtl" valign="top">
          <br />
                 <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="rbl_current_function" ValidationGroup="page"
                 Font-Size="14px"></asp:RequiredFieldValidator>
                
    </td>
    </tr>
    
   <tr runat="server" id="trSubFunction">
    <td colspan="3">
         <fieldset>
                    <legend><a id="A3" href="javascript:void(3)" style="text-decoration: none;" runat="server"
                        onclick="show_hide_fun('Div33');">
                        <%--'<%=Div1.ClientID%>'--%>
                        <asp:Label ID="Label18" runat="server"  ForeColor="#996633" Text="<%$ Resources:Master, Places_Fun_through_age %>"></asp:Label></a>
                    </legend>
                    <div style="display: none;" id="Div33" runat="server">
                            <table width="100%" runat="server" id="tblSubFunction">
                        
                      <tr>
        
        <td align="right" dir="rtl" valign="top" colspan="2">
          <asp:Label ID="Label71" runat="server" Text="- العصر : "
            Width="100%" Height="26px"></asp:Label>
            &nbsp;&nbsp;
       <asp:DropDownList ID="ddl_function_age" runat="server" Width="90%" ValidationGroup="function"></asp:DropDownList>
        <br />
        <br />
            <asp:Label ID="Label68" runat="server" Text="- الوظيفة : " Width="100%"></asp:Label><br />
            &nbsp;&nbsp;<asp:RadioButtonList ID="rbl_function_through_age" runat="server" RepeatColumns="3" ValidationGroup="function"
                RepeatDirection="Horizontal" Width="90%" onclick="GetRBLSelectedValue(this);" >
               
            </asp:RadioButtonList>
            <br />
            <asp:TextBox ID="txt_fun_through_age_other" runat="server"  
                Width="89%" Height="26px" style="display:none"></asp:TextBox>
            <br />
            <br />
              <asp:Label ID="Label70" runat="server" Height="26px" Text="- ملاحظة : " 
                Width="90%"></asp:Label><br />
           &nbsp;&nbsp; <asp:TextBox ID="txt_function_note" runat="server" Height="26px" Width="90%"></asp:TextBox>
             <br />
            <br />
            <asp:Button ID="btn_save_function" runat="server" OnClick="btn_save_function_click" 
                style="margin-right: 175px" Text="أضف وظيفة" ValidationGroup="function"/>
            <br />
            <br />
            <asp:GridView ID="gv_function" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataKeyNames="id" ForeColor="#333333" GridLines="None" 
                Visible="false" Width="90%">
                <HeaderStyle BackColor="#D9C69E"  ForeColor="White" 
                    HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="con_function" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="الوظيفة" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="period_name" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="العصر" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="function_note" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="ملاحظة" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="تعديل" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgEdit0" runat="server" 
                                CommandArgument='<%# Eval("id") %>'  CommandName="function"
                                ImageUrl="~/images/Edit.jpg" OnClick="imgEdit_Click" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgDelete0" runat="server" 
                                CommandArgument='<%# Eval("id") %>'  CommandName="function"
                                ImageUrl="~/images/delete.gif" OnClick="imgDelete_Click" 
                                OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
             <asp:TextBox ID="txt_function_id" runat="server" Height="26px"  
            ForeColor="white"   BackColor="white" 
            BorderColor="#000CCC" BorderStyle="None" Width="300px" ></asp:TextBox>
         </td>
         <td align="right" dir="rtl" valign="top"> <br />
            <br />
           <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server"  InitialValue=".. اختر عصر .."
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="ddl_function_age" ValidationGroup="function"
                                     Font-Size="14px" ></asp:RequiredFieldValidator>  
                                    <br />
                                    <br />
                                    <br /> <br />
                                    <br />
                                    <br />
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="rbl_function_through_age" ValidationGroup="function"
                                     Font-Size="14px"></asp:RequiredFieldValidator>  
    </td>
    </tr>
                        </table>
                    </div>
                </fieldset>
    </td>
   </tr>
    
   <tr runat="server" id="trAddress">
         <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
            <asp:Label ID="Label72" runat="server"  Text="<%$ Resources:Master, Places_Site %>" 
                  ></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' valign="top">
            <asp:Label ID="Label73" runat="server" Text="<%$ Resources:Master, Places_lab_currentLocation %>" Width="100%" 
                Height="26px"></asp:Label>
          <br />
            <asp:TextBox ID="txt_current_address" runat="server" Height="52px" 
                Width="100%" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
           <asp:Label ID="Label74" runat="server" Text="<%$ Resources:Master, Places_lab_detailedLocDescrp %>" 
                Width="100%" Height="26px"></asp:Label>
          <br />
            <asp:TextBox ID="txt_current_address_desc" runat="server" Height="75px" 
                Width="100%" TextMode="MultiLine"></asp:TextBox>
            <br />
           <br />
              <asp:Label ID="Label75" runat="server" Height="26px" Text="<%$ Resources:Master, Places_lab_locNotes %> " 
                Width="60px"></asp:Label>
            <asp:TextBox ID="txt_current_address_notes" runat="server" Height="26px" 
                Width="395px"></asp:TextBox>
            
         </td>
         <td align="right" dir="rtl" valign="top"><br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txt_current_address" ValidationGroup="page"
                 Font-Size="14px"></asp:RequiredFieldValidator>
                 <br />
                    <br />
                    <br />
                    <br />
                      <br />
                       <br />
                 <br /> <br />
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txt_current_address_desc" ValidationGroup="page"
                 Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    
   
   
   <tr runat="server" id="trRestoration">
         <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
            <asp:Label ID="Label90" runat="server" 
                Text="<%$ Resources:Master, Places_restoration %>" 
                 Width="115px"></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' valign="top">
            <asp:Label ID="Label91" runat="server" 
                Text="<%$ Resources:Master, Plac_Lab_currCondiMonument %>" Width="100%" 
                Height="30px"></asp:Label>
          <br />
            <asp:TextBox ID="txt_current_state" runat="server" Height="52px" 
                Width="100%" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
           <asp:Label ID="Label92" runat="server" Text="<%$ Resources:Master, Plac_lab_currConditionRestoration %> " 
                Width="100%" Height="26px"></asp:Label>
          <br />
            <asp:TextBox ID="txt_restoration_current_state" runat="server" Height="75px" 
                Width="100%" TextMode="MultiLine"></asp:TextBox>
              <br />
            <br />
            
            <asp:Label ID="Label94" runat="server" Height="26px" 
                Text="<%$ Resources:Master, Plac_lab_respOfRestoration %>" Width="100%"></asp:Label>
            <br />
            <asp:TextBox ID="txt_restoration_current_state_person" runat="server" 
                Width="100%" Height="26px"></asp:TextBox>
            <br />
            <br />
           <asp:Label ID="Label95" runat="server" Text="<%$ Resources:Master, Plac_lab_sharedRestoration %>" 
                Width="100%" Height="30px"></asp:Label>
          <br />
            <asp:TextBox ID="txt_restoration_current_state_participants" runat="server" Height="75px" 
                Width="100%" TextMode="MultiLine"></asp:TextBox>
              <br />
            <br />
           
              <asp:Label ID="Label93" runat="server" Height="26px" Text="<%$ Resources:Master, Plac_lab_RestorationNotes %>" 
                Width="60px"></asp:Label>
            <asp:TextBox ID="txt_restoration_current_state_note" runat="server" 
                Height="26px" Width="395px"></asp:TextBox>
            
         </td>
         <td>
         
    </td>
    </tr>
    

    
   <tr runat="server" id="trLocation">
         <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
            <asp:Label ID="Label107" runat="server" 
                 Text="<%$ Resources:Master, Places_Pinpointing %>" 
                 Width="115px"></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' valign="top">
            
           <asp:Label ID="Label109" runat="server" Text="- إحداثيات الطول والعرض : " 
                Width="75%" Height="26px"></asp:Label>
                
          <br />
          <asp:Label ID="Label113" runat="server" Text="- خط الطول : " 
                Width="15%" Height="26px"></asp:Label>
                      <asp:TextBox ID="txt_current_location_longitude" runat="server" 
                Width="25%" Height="26px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Label ID="Label114" runat="server" Text="- خط العرض : " 
                Width="17%" Height="26px" ></asp:Label>
                      <asp:TextBox ID="txt_current_location_latitude" runat="server" 
                Width="25%" Height="26px"></asp:TextBox>
            <br />
              <br />
          
           <asp:Label ID="Label111" runat="server" Text="<%$ Resources:Master, Plac_lab_siteWrittenDesc %>" 
                Width="100%" Height="26px"></asp:Label>
          <br />
            <asp:TextBox ID="txt_current_location_desc" runat="server" Height="75px" 
                Width="100%" TextMode="MultiLine"></asp:TextBox>
              <br />
            <br />
           
              <asp:Label ID="Label112" runat="server" Height="26px" Text="<%$ Resources:Master, Plac_lab_siteNotes %>" 
                Width="60px"></asp:Label>
            <asp:TextBox ID="txt_current_location_note" runat="server" Height="26px" 
                Width="395px"></asp:TextBox>
            
         </td>
      <td align="right" dir="rtl" valign="top">
        <br />
                 <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
            ErrorMessage="هذان الحقلان يجب إدخالهما" ControlToValidate="txt_current_location_longitude" ValidationGroup="page"
                 Font-Size="14px"></asp:RequiredFieldValidator>
                 <br />
                
                    <br />
                    <br />
                 <br />
                 <br />
                 
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txt_current_location_desc" ValidationGroup="page"
                 Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    
   <tr runat="server" id="trFormPic">
         <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
            <asp:Label ID="Label19" runat="server" Text="الصورة المرفقة مع الاستمارة  : " 
                 ></asp:Label>
        </td>
        <td align="right">
            <asp:RadioButtonList ID="rbl_form_pic_state" runat="server" RepeatColumns="1" 
                Width="100%">
            <asp:ListItem Value="1" Text="مرفقة (ورقية / إلكترونية)"></asp:ListItem>
                <asp:ListItem Value="2" Text="غير متاحة (سيتم توفيرها لاحقا)" Selected="True"></asp:ListItem>
                <asp:ListItem Value="0" Text="غير متاحة (استخدم الصورة الرمزية)"></asp:ListItem>
           
          
        </asp:RadioButtonList>
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" 
                ControlToValidate="rbl_form_pic_state" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
    </td>
    </tr>
   
   <tr runat="server" id="trFormDataCollectorName">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
          <asp:Label ID="Label20" runat="server" Text="اسم جامع بيانات الاستمارة  : " 
                 Width="150px" Height="26px" ></asp:Label>
         </td>
         <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
           
             <asp:TextBox ID="txtFormDataColectorName" runat="server"  
                   Width="100%" Height="26px"  />
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="page"
                ControlToValidate="txtFormDataColectorName" Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
     
   <tr runat="server" id="trFormDataRevisionName">
         <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
         <asp:Label ID="Label21" runat="server" Text="اسم مراجع بيانات الاستمارة  : " 
                 Width="155px" Height="26px" ></asp:Label>
         </td>
         <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
           
             <asp:TextBox ID="txtFormDataRevisionName" runat="server"  
                   Width="100%" Height="26px"  />
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="page"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
     
   <%--<tr runat="server" id="trFormDataEntryName">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
          <asp:Label ID="Label22" runat="server" 
                Text="اسم مدخل بيانات الاستمارة على الحاسب الآلي  : " ></asp:Label>
         </td>
         <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
           
             <asp:TextBox ID="txtFormDataEntryName" runat="server"  
                   Width="100%" Height="32px"  />
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txtFormDataEntryName" ValidationGroup="page"
                Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    
   <tr runat="server" id="trFormDataEntryRevisionName">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1" valign="top">
          <asp:Label ID="Label24" runat="server" 
                Text="اسم مراجع إدخال بيانات الاستمارة على الحاسب الآلي  : " ></asp:Label>
         </td>
         <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
           
             <asp:TextBox ID="txtFormDataEntryRevisionName" runat="server"  
                   Width="100%" Height="32px"  />
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="page"
                ControlToValidate="txtFormDataEntryRevisionName" Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>--%>
    
   <tr runat="server" id="file_tr">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'  rowspan="1" valign="top">
            <asp:Label ID="Label27" runat="server" Text="<%$ Resources:Master, Topics_upload %>"  ></asp:Label>
        </td>
        <td dir="ltr" rowspan="1" valign="top" align="left">
         <%--<asp:Label ID="Label555" runat="server" Font-Size="14px" ForeColor="Red" 
                Width="40%"></asp:Label>--%>
            <asp:FileUpload ID="uploadfile" runat="server" Width="100%" />
      
       
        </td>
        <td>
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px" ForeColor="Red"></asp:Label>
            
        </td>
    </tr>
     
    <tr runat="server" id="trSave">
        <td align="center" colspan="3" height="60px" valign="middle">
            <asp:Button ID="btnsave" runat="server" Text="حفظ تفاصيل الاستمارة" 
                onclick="btnsave_Click" ValidationGroup="page" OnClientClick="ValidateAndShowPopup()"/>
        </td>
       
    </tr>
</table>
