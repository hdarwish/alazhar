<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true" CodeFile="placesMoreDetails.aspx.cs" Inherits="places_placesMoreDetails" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <link href="../css/CSS.css" rel="stylesheet" type="text/css" />
    <link href="../css/StyleSheet.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="../css/tabview.css" />
    <link href="../css/div_1.css" rel="stylesheet" type="text/css" />
    <link href="../css/div_2.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="../CSS/custMenu.css" type="text/css">
    <link href="" runat="server" id="mainclass" rel="stylesheet" type="text/css" />
    <link href="../css/detailsCSS.css"  rel="stylesheet" type="text/css" />
   
    <script type="text/javascript" src="../Js/tabview.js"></script>
    <script language="javascript" type="text/javascript">
        function selected(divTextId, divSelectorId) {
            var divText;
            if (divTextId == "div100")
                divText=document.getElementById('<%=div100.ClientID%>');
            else if(divTextId == "div101")
                divText=document.getElementById('<%=div101.ClientID%>');
            else if(divTextId == "div102")
                divText=document.getElementById('<%=div102.ClientID%>');
            else if(divTextId == "div103")
                divText=document.getElementById('<%=div103.ClientID%>');
            else if(divTextId == "div104")
                divText=document.getElementById('<%=div104.ClientID%>');
            else if(divTextId == "div105")
                divText=document.getElementById('<%=div105.ClientID%>');
            else if(divTextId == "div106")
                divText=document.getElementById('<%=div106.ClientID%>');
            else if(divTextId == "div107")
                divText=document.getElementById('<%=div107.ClientID%>');
            else if(divTextId == "div108")
                divText=document.getElementById('<%=div108.ClientID%>');
            else if(divTextId == "div109")
                divText=document.getElementById('<%=div109.ClientID%>');
            else if(divTextId == "div110")
                divText=document.getElementById('<%=div110.ClientID%>');
            
            
            var divSelector = document.getElementById(divSelectorId);
            var div1 = document.getElementById('mainDesc');
            div1.className = "item";
            var div2 = document.getElementById('outDesc');
            div2.className = "item";
            var div3 = document.getElementById('insideDesc');
            div3.className = "item";
            var div4 = document.getElementById('decorationDesc');
            div4.className = "item";
            var div5 = document.getElementById('ArchitecturalStyleDesc');
            div5.className = "item";
            var div6 = document.getElementById('Building_materialsDesc');
            div6.className = "item";
            var div7 = document.getElementById('Fun_through_age');
            div7.className = "item";
            var div8 = document.getElementById('Places_Site');
            div8.className = "item";
            var div9 = document.getElementById('Places_restoration');
            div9.className = "item";
            var div10 = document.getElementById('Places_Pinpointing');
            div10.className = "item";
            var div11 = document.getElementById('notes');
            div11.className = "item";
            divSelector.className = "activeItem";

            var div111 = document.getElementById('<%=div100.ClientID%>');
            var div112 = document.getElementById('<%=div101.ClientID%>');
            var div113 = document.getElementById('<%=div102.ClientID%>');
            var div114 = document.getElementById('<%=div103.ClientID%>');
            var div115 = document.getElementById('<%=div104.ClientID%>');
            var div116 = document.getElementById('<%=div105.ClientID%>');
            var div117 = document.getElementById('<%=div106.ClientID%>');
            var div118 = document.getElementById('<%=div107.ClientID%>');
            var div119 = document.getElementById('<%=div108.ClientID%>');
            var div120 = document.getElementById('<%=div109.ClientID%>');
            var div121 = document.getElementById('<%=div110.ClientID%>');
            var ElementCssClass = document.getElementById('<%=div100.ClientID%>').className;
            if (ElementCssClass == "mainContentL" || ElementCssClass == "showContentL") {
                div111.className = "mainContentL";
                div112.className = "mainContentL";
                div113.className = "mainContentL";
                div114.className = "mainContentL";
                div115.className = "mainContentL";
                div116.className = "mainContentL";
                div117.className = "mainContentL";
                div118.className = "mainContentL";
                div119.className = "mainContentL";
                div120.className = "mainContentL";
                div121.className = "mainContentL";
                divText.className = "showContentL";
            }
            else {
                div111.className = "mainContent";
                div112.className = "mainContent";
                div113.className = "mainContent";
                div114.className = "mainContent";
                div115.className = "mainContent";
                div116.className = "mainContent";
                div117.className = "mainContent";
                div118.className = "mainContent";
                div119.className = "mainContent";
                div120.className = "mainContent";
                div121.className = "mainContent";
                divText.className = "showContent";
            }
            
        }
   
    </script>

    <input id="HiddenID" type="hidden" runat="server" />
    <input id="hidden_id" type="hidden" runat="server" />
    <input id="hidden_eve" type="hidden" runat="server" />
    <input id="hidden_top" type="hidden" runat="server" />
    <input id="hidden_plac" type="hidden" runat="server" />
    <table class="_page_body" align="<%$ Resources:Master, key_Differentalign %>"  runat="server">
    <tr>
    <td>
     <div id="mainheaderdiv" runat="server" class="mainHeader"  >
                    <a href="" runat="server" id="imBack" style="text-decoration:none;border-top-width: 0px;border-right-width: 0px;border-bottom-width: 0px;border-left-width: 0px;"  >
                        <img id="Img1" alt="رجوع" runat="server" src="<%$ Resources:Master, keyimg_back %>" width="75" height="34"  align="<%$ Resources:Master, key_Differentalign %>" />
                    </a>
                    <p id="mainTitle" runat="server">
                    </p>
                
                </div>
    </td>
    </tr>
    </table>



    
    <%--<div style="margin-top: 5px; text-align: center; width:60%;" align="center"
            runat="server" id="div_related_images">
           
            <div id="Div1" style="width: 65px; height: 70px; float: right; margin-right: 2px;"
                runat="server">
                <a href="" id="a_1_1" runat="server">
                    <asp:Image ID="img_1_1" AlternateText="" Width="65px" Height="70px" ToolTip="" runat="server" />
                </a>
            </div>
            <div id="Div2" style="width: 65px; height: 70px; float: right; margin-right: 5px;
                margin-left: 0px;" runat="server">
                <a href="" id="a_1_3" runat="server">
                    <asp:Image ID="img_1_3" AlternateText="" BorderWidth="0" Width="65px" Height="70px"
                        ToolTip="" runat="server" />
                </a>
            </div>
            <div id="Div3" runat="server" style="width: 65px; height: 70px; float: right; margin-right: 5px">
                <a href="" id="a_1_2" runat="server">
                    <asp:Image ID="img_1_2" AlternateText="" BorderWidth="0" Width="65px" Height="70px"
                        ToolTip="" runat="server" />
                </a>
            </div>
             <div id="Div4" runat="server" style="width: 65px; height: 70px; float: right; margin-right: 5px">
                <a href="" id="a_1_4" runat="server">
                    <asp:Image ID="img_1_4" AlternateText="" BorderWidth="0" Width="65px" Height="70px"
                        ToolTip="" runat="server" />
                </a>
            </div>
              <div id="Div5" runat="server" style="width: 65px; height: 70px; float: right; margin-right: 5px">
                <a href="" id="a_1_5" runat="server">
                    <asp:Image ID="img_1_5" AlternateText="" BorderWidth="0" Width="65px" Height="70px"
                        ToolTip="" runat="server" />
                </a>
            </div>  <div id="Div6" runat="server" style="width: 65px; height: 70px; float: right; margin-right: 5px">
                <a href="" id="a_1_6" runat="server">
                    <asp:Image ID="img_1_6" AlternateText="" BorderWidth="0" Width="65px" Height="70px"
                        ToolTip="" runat="server" />
                </a>
            </div>  <div id="Div7" runat="server" style="width: 65px; height: 70px; float: right; margin-right: 5px">
                <a href="" id="a_1_7" runat="server">
                    <asp:Image ID="img_1_7" AlternateText="" BorderWidth="0" Width="65px" Height="70px"
                        ToolTip="" runat="server" />
                </a>
            </div>  <div id="Div8" runat="server" style="width: 65px; height: 70px; float: right; margin-right: 5px">
                <a href="" id="a_1_8" runat="server">
                    <asp:Image ID="img_1_8" AlternateText="" BorderWidth="0" Width="65px" Height="70px"
                        ToolTip="" runat="server" />
                </a>
            </div> 
        </div>--%>




    <table border="0" width="100%" >
        <tr>
            <td >
               

                <div runat="server" id="div_1">
                <div id="sideBardiv" runat="server" class="sideBar" >
               
                    <div id="mainDesc" class="activeItem"  onmouseover="this.style.cursor='hand'" onclick="selected('div100','mainDesc');" >
                        <asp:Literal ID="Literal1" runat="server" Text="<%$ Resources:Master, Places_labels_detailDescription %>" />
                    </div>
                   
                    
                    <div id="outDesc" onmouseover="this.style.cursor='hand'" onclick="selected('div101','outDesc');"
                        class="item">
                        <asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:Master, Places_labels_buildingOutside %>" />
                    </div>
                    <div id="insideDesc" onmouseover="this.style.cursor='hand'" onclick="selected('div102','insideDesc');"
                        class="item">
                        <asp:Literal ID="Literal3" runat="server" Text="<%$ Resources:Master, Places_labels_buildingInside %>" />
                    </div>
                    <div id="decorationDesc" onmouseover="this.style.cursor='hand'" onclick="selected('div103','decorationDesc');"
                        class="item">
                        <asp:Literal ID="Literal4" runat="server" Text="<%$ Resources:Master, Places_decorations %>" />
                    </div>
                    <div id="ArchitecturalStyleDesc" onmouseover="this.style.cursor='hand'" onclick="selected('div104','ArchitecturalStyleDesc');"
                        class="item">
                        <asp:Literal ID="Literal5" runat="server" Text="<%$ Resources:Master, Places_Architectural %>" />
                    </div>
                    <div id="Building_materialsDesc" onmouseover="this.style.cursor='hand'" onclick="selected('div105','Building_materialsDesc');"
                        class="item">
                        <asp:Literal ID="Literal6" runat="server" Text="<%$ Resources:Master, Places_Building_materials %>" />
                    </div>
                    <div id="Fun_through_age" onmouseover="this.style.cursor='hand'" onclick="selected('div106','Fun_through_age');"
                        class="item">
                        <asp:Literal ID="Literal7" runat="server" Text="<%$ Resources:Master, Places_Fun_through_age %>" />
                    </div>
                    <div id="Places_Site" onmouseover="this.style.cursor='hand'" onclick="selected('div107','Places_Site');"
                        class="item">
                        <asp:Literal ID="Literal8" runat="server" Text="<%$ Resources:Master, Places_Site %>" />
                    </div>
                    <div id="Places_restoration" onmouseover="this.style.cursor='hand'" onclick="selected('div108','Places_restoration');"
                        class="item">
                        <asp:Literal ID="Literal9" runat="server" Text="<%$ Resources:Master, Places_restoration %>" />
                    </div>
                    <div id="Places_Pinpointing" onmouseover="this.style.cursor='hand'" onclick="selected('div109','Places_Pinpointing');"
                        class="item">
                        <asp:Literal ID="Literal10" runat="server" Text="<%$ Resources:Master, Places_Pinpointing %>" />
                    </div>
                    <div id="notes" onmouseover="this.style.cursor='hand'" onclick="selected('div110','notes');"
                        class="item">
                        <asp:Literal ID="Literal11" runat="server" Text="<%$ Resources:Master, Places_labels_notes %>" />
                    </div>
                </div>
                </div>
                <div id="div100" runat="server" class="showContent">
                    <asp:Literal ID="txt_description" runat="server"></asp:Literal>
                </div>
                <div id="div101" runat="server" class="mainContent">
                    <p id="P1" runat="server">
                        <asp:Literal ID="Literal12" runat="server" Text="<%$ Resources:Master, Places_entrances %>" />
                    </p>
                    <p id="txt_outside_entrances" runat="server">
                    </p>
                    <br />
                    <p id="P2" runat="server">
                        <asp:Literal ID="Literal13" runat="server" Text="<%$ Resources:Master, Places_Faces %>" />
                    </p>
                    <p id="txt_outside_interfaces" runat="server">
                    </p>
                    <br />
                    <p id="P3" runat="server">
                        <asp:Literal ID="Literal14" runat="server" Text="<%$ Resources:Master, Places_Windows %>" />
                    </p>
                    <p id="txt_outside_windows" runat="server">
                    </p>
                    <br />
                    <p id="P4" runat="server">
                        <asp:Literal ID="Literal15" runat="server" Text="<%$ Resources:Master, Places_Minarets %>" />
                    </p>
                    <p id="txt_outside_minarets" runat="server">
                    </p>
                    <br />
                    <p id="P5" runat="server">
                        <asp:Literal ID="Literal16" runat="server" Text="<%$ Resources:Master, Places_Dooms %>" />
                    </p>
                    <p id="txt_outside_domes" runat="server">
                    </p>
                </div>
                <div id="div102" runat="server" class="mainContent">
                    <p id="P6" runat="server">
                        <asp:Literal ID="Literal17" runat="server" Text=" <%$ Resources:Master, Places_Playground %>" />
                    </p>
                    <p id="txt_inside_yard" runat="server">
                    </p>
                    <br />
                    <p id="P8" runat="server">
                        <asp:Literal ID="Literal18" runat="server" Text=" <%$ Resources:Master, Places_Ceilings %>" />
                    </p>
                    <p id="txt_inside_roofs" runat="server">
                    </p>
                    <br />
                    <p id="P10" runat="server">
                        <asp:Literal ID="Literal19" runat="server" Text=" <%$ Resources:Master, Places_Awning %>" />
                    </p>
                    <p id="txt_inside_iwans" runat="server">
                    </p>
                    <br />
                    <p id="P12" runat="server">
                        <asp:Literal ID="Literal20" runat="server" Text=" <%$ Resources:Master, Places_Rooms_Halls %>" />
                    </p>
                    <p id="txt_inside_halls" runat="server">
                    </p>
                    <br />
                    <p id="P14" runat="server">
                        <asp:Literal ID="Literal21" runat="server" Text="<%$ Resources:Master, Places_Desks %>" />
                    </p>
                    <p id="txt_inside_seats" runat="server">
                    </p>
                    <br />
                    <p id="P7" runat="server">
                        <asp:Literal ID="Literal22" runat="server" Text=" <%$ Resources:Master, Places_Accessories %>" />
                    </p>
                    <p id="txt_inside_supplements" runat="server">
                    </p>
                    <br />
                    <p id="P11" runat="server">
                        <asp:Literal ID="Literal23" runat="server" Text=" <%$ Resources:Master, Places_Charity_room %>" />
                    </p>
                    <p id="txt_inside_sabeel_room" runat="server">
                    </p>
                </div>
                <div id="div103" runat="server" class="mainContent">
                    <p id="P9" runat="server">
                        <asp:Literal ID="Literal24" runat="server" Text="<%$ Resources:Master, Places_labels_writings %>" />
                    </p>
                    <p id="txt_literature" runat="server">
                    </p>
                    <br />
                    <p id="P15" runat="server">
                        <asp:Literal ID="Literal25" runat="server" Text="<%$ Resources:Master, Places_labels_geomDecorations %>" />
                    </p>
                    <p id="txt_geometric" runat="server">
                    </p>
                    <br />
                    <p id="P17" runat="server">
                        <asp:Literal ID="Literal26" runat="server" Text="<%$ Resources:Master, Places_labels_BotanDecorations %>" />
                    </p>
                    <p id="txt_floral" runat="server">
                    </p>
                </div>
                <div id="div104" runat="server" class="mainContent">
                    <p id="lbl_main_architectural_styles_type" runat="server">
                    </p>
                    <asp:RadioButtonList ID="rbl_main_architectural_styles_type" runat="server" Visible="false">
                    </asp:RadioButtonList>
                    <br />
                    <p id="P18" runat="server">
                        <asp:Literal ID="Literal27" runat="server" Text="<%$ Resources:Master, Places_labels_originalStyle %>" />
                    </p>
                    <p id="txt_main_architectural_styles_type_general_feature" runat="server">
                    </p>
                    <br />
                    <p id="P20" runat="server">
                        <asp:Literal ID="Literal28" runat="server" Text="<%$ Resources:Master, Places_labels_GNotes %>" />
                    </p>
                    <p id="txt_main_architectural_styles_type_notes" runat="server">
                    </p>
                </div>
                <div id="div105" runat="server" class="mainContent">
                <asp:CheckBoxList ID="rbl_building_raw_material" runat="server" Visible="false">
               
            </asp:CheckBoxList>
                <asp:RadioButtonList ID="rbl_building_raw_material_use" runat="server" Visible="false">
               
            </asp:RadioButtonList>
                  <asp:GridView ID="gv_building_material" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataKeyNames="id" ForeColor="#333333" GridLines="None" 
                Visible="false" Width="100%" >
                <HeaderStyle BackColor="#D9C69E"  ForeColor="White" 
                    HorizontalAlign="Center" />
                <Columns>
                    
                      <asp:TemplateField HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="<%$ Resources:Master, rwmat %>" 
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
                        HeaderStyle-HorizontalAlign="Center" HeaderText="<%$ Resources:Master, rwmatuse %>" 
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
                        HeaderStyle-HorizontalAlign="Center" HeaderText="<%$ Resources:Master, Plac_lab_siteNotes %>" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                  
                </Columns>
            </asp:GridView>
                </div>
                <div id="div106" runat="server" class="mainContent">
                    <p id="P21" runat="server">
                        
                        <asp:Literal ID="Literal40" runat="server" Text="<%$ Resources:Master, key_Current_Position %>"> 
                        </asp:Literal>
                        </p>
                    <p id="lbl_current_function" runat="server">

                    </p>
                    <asp:RadioButtonList ID="rbl_current_function" runat="server" Visible="false">
                    </asp:RadioButtonList>
                    <br />
                    <p id="P22" runat="server">
                        <asp:Literal ID="Literal29" runat="server" Text="<%$ Resources:Master, Places_lab_buildingJobNotes %>" />
                        
                    </p>
                    <p id="txt_current_function_notes" runat="server">
                    </p>
                    <br />
                    <asp:GridView ID="gv_function" runat="server" AutoGenerateColumns="False" CellPadding="4"
                        DataKeyNames="id" ForeColor="#333333" GridLines="None" Visible="true" Width="90%">
                        <HeaderStyle BackColor="#D9C69E" ForeColor="White" HorizontalAlign="Center" />
                        <Columns>
                            <asp:BoundField DataField="con_function" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" HeaderText="الوظيفة"
                                ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                ItemStyle-HorizontalAlign="Center" ShowHeader="true">
                                <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" />
                                <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="period_name" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" HeaderText="العصر"
                                ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                ItemStyle-HorizontalAlign="Center" ShowHeader="true">
                                <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" />
                                <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="function_note" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" HeaderText="ملاحظة"
                                ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                ItemStyle-HorizontalAlign="Center" ShowHeader="true">
                                <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" />
                                <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" />
                            </asp:BoundField>
                        </Columns>
                    </asp:GridView>
                </div>
                <div id="div107" runat="server" class="mainContent">
                    <p id="P13" runat="server">
                        <asp:Literal ID="Literal30" runat="server" Text="<%$ Resources:Master, Places_lab_currentLocation %>" />
                    </p>
                    <p id="txt_current_address" runat="server">
                    </p>
                    <br />
                    <p id="P16" runat="server">
                        <asp:Literal ID="Literal31" runat="server" Text="<%$ Resources:Master, Places_lab_detailedLocDescrp %>" />
                    </p>
                    <p id="txt_current_address_desc" runat="server">
                    </p>
                    <br />
                    <p id="P19" runat="server">
                        <asp:Literal ID="Literal32" runat="server" Text="<%$ Resources:Master, Places_lab_locNotes %>" />
                    </p>
                    <p id="txt_current_address_notes" runat="server">
                    </p>
                </div>
                <div id="div108" runat="server" class="mainContent">
                    <p id="P23" runat="server">
                        <asp:Literal ID="Literal33" runat="server" Text="<%$ Resources:Master, Plac_Lab_currCondiMonument %>" />
                    </p>
                    <p id="txt_current_state" runat="server">
                    </p>
                    <br />
                    <p id="P24" runat="server">
                        <asp:Literal ID="Literal34" runat="server" Text="<%$ Resources:Master, Plac_lab_currConditionRestoration %>" />
                    </p>
                    <p id="txt_restoration_current_state" runat="server">
                    </p>
                    <br />
                    <p id="P25" runat="server">
                        <asp:Literal ID="Literal35" runat="server" Text="<%$ Resources:Master, Plac_lab_respOfRestoration %>" />
                    </p>
                    <p id="txt_restoration_current_state_person" runat="server">
                    </p>
                    <br />
                    <p id="P26" runat="server">
                        <asp:Literal ID="Literal36" runat="server" Text="<%$ Resources:Master, Plac_lab_sharedRestoration %>" />
                    </p>
                    <p id="txt_restoration_current_state_participants" runat="server">
                    </p>
                    <br />
                    <p id="P27" runat="server">
                        <asp:Literal ID="Literal37" runat="server" Text="<%$ Resources:Master, Plac_lab_RestorationNotes %>" />
                    </p>
                    <p id="txt_restoration_current_state_note" runat="server">
                    </p>
                </div>
                <div id="div109" runat="server" class="mainContent">
                    <p id="P28" runat="server">
                      
                         <asp:Literal ID="Literal41" runat="server" Text="<%$ Resources:Master, key_Latitude_longitude_coordinates %>" />
                    </p>
                    <br />
                    <p id="P29" runat="server">
                        
                         <asp:Literal ID="Literal42" runat="server" Text="<%$ Resources:Master, key_longitude %>" />
                          </p>
                    <p id="txt_current_location_longitude" runat="server">
                    </p>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <p id="P30" runat="server">
                        
                        <asp:Literal ID="Literal43" runat="server" Text="<%$ Resources:Master, Key_Latitude %>" />
                    </p>
                    <p id="txt_current_location_latitude" runat="server">
                    </p>
                    <br />
                    <p id="P31" runat="server">
                        <asp:Literal ID="Literal38" runat="server" Text="<%$ Resources:Master, Plac_lab_siteWrittenDesc %>" />
                    </p>
                    <br />
                    <p id="txt_current_location_desc" runat="server">
                    </p>
                    <br />
                    <p id="P32" runat="server">
                        <asp:Literal ID="Literal39" runat="server" Text="<%$ Resources:Master, Plac_lab_siteNotes %>" />
                    </p>
                    <br />
                    <p id="txt_current_location_note" runat="server">
                    </p>
                </div>
                <div id="div110" runat="server" class="mainContent">
                    <p id="txtNotes" runat="server">
                    </p>
                </div>
                <br class="clearfloat" />
            </td>
        </tr>
    </table>
</asp:Content>