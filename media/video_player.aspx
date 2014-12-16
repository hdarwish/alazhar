
<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="video_player.aspx.cs" Inherits="videoPlayer" Title="Video Player" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div style="width:100%" dir="rtl" align="right">
    <h1 align="center" 
                    
        style="color: #6A6A6A; font-size: 14px; font-weight: bold; font-family: 'tahoma'; width:100%;">
				    
				     <asp:Label ID="lblTitle" runat="server" ForeColor="Black"  ></asp:Label>
				   
				</h1>
				
				<%--<div id="details" runat="server" align="right" dir="rtl">
				&nbsp;&nbsp;&nbsp;&nbsp; 
				     <asp:Label ID="Label8" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="lbl1" runat="server" Text="عنوان العمل : " Font-Bold="True" ></asp:Label>
				    &nbsp;<asp:Label ID="lblTitle" runat="server" ForeColor="Black"  ></asp:Label>
				   
				    
				   </div>--%>
				    <div style="width: 100%">
	<asp:Panel ID="PlayerPanel" runat="server" Visible="true" Width="100%">
            <center>

       <br />
      
        <object codebase="http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=5,1,52,701"
        standby="Loading Microsoft Windows® Media Player components..." 
        type="application/x-oleobject" style="width:425px; height:344px">
          <embed src='<%= Get_Path() %>'  width="425px" height="344px" >
        </object> 
        
      
        <%--<embed src='<%= Get_Path() %>' type="audio/x-pn-realaudio" width="300" height="50" autostart="false" controller="true" >
        </embed>--%>
            
        </center>
        </asp:Panel>
        </div>
       <br />
				  <%--<div id="Div1" runat="server" align="right" dir="rtl" 
        style="width: 100%">
				&nbsp;&nbsp;&nbsp;&nbsp;
				 <asp:Label ID="Label9" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label3" runat="server" Text="نوعه :" Font-Bold="True" ></asp:Label>
				    &nbsp;<asp:Label ID="lblCategory" runat="server" ForeColor="Black"  ></asp:Label>
				   
				    
				   </div>--%>
				   
				    <table cellpadding="0px" width="580px" dir="rtl">
				    <tr dir="rtl" valign="top">
                        <td  width="115px">
                        &nbsp;&nbsp;&nbsp;&nbsp;
                           <asp:Label ID="Label3" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label8" runat="server" Text="وصف العمل : " Font-Bold="True"  ></asp:Label>
                            &nbsp;
                            
                        </td>
                        <td align="right" dir="rtl"  width="400px">
                              <asp:Label ID="lblDesc" runat="server"  ></asp:Label>
                        </td>
                        
                    </tr>
                    
                    <tr id="trName" runat="server" dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2">
                       &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label16" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label19" runat="server" Text="اسم الحلقة :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				      <asp:Label ID="lblName" runat="server"  ></asp:Label>
				    </td>
				   
                    </tr>
                    
                    <tr dir="rtl" valign="top" >
                        <td align="right" dir="rtl" colspan="2">
                       &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label21" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label22" runat="server" Text="المدة :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lblDuration" runat="server"  ></asp:Label>
				    </td>
				    
                    </tr>
                      <tr dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2" >
                       &nbsp;&nbsp;&nbsp;&nbsp;
				     <asp:Label ID="Label1" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label2" runat="server" Text="مكان التسجيل: " 
                            Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lblplace" runat="server"  ></asp:Label>
				    </td>
				    
                    </tr>
                     <tr dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2" >
                       &nbsp;&nbsp;&nbsp;&nbsp;
				     <asp:Label ID="Label9" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label4" runat="server" Text=" تاريخ التسجيل: " 
                            Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lbldate" runat="server"   ></asp:Label>
				    </td>
				    
                    </tr>
                     <tr dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2">
                       &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label24" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label25" runat="server" Text="الضيف ومنصبه :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				      <asp:Label ID="lblJuest" runat="server"  ></asp:Label>
				    </td>
				    
                    </tr>
                    
                    
                     <tr id="trPresenter" runat="server" dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2">
                       &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label27" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label28" runat="server" Text="المذيع :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lblPresenter" runat="server"  ></asp:Label>
				    </td>
				  
                    </tr>
                    
                    
                      <tr dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2" >
                       &nbsp;&nbsp;&nbsp;&nbsp;
				     <asp:Label ID="Label30" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label31" runat="server" Text="المصدر/ جهة حقوق النشر : " 
                            Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lblResource" runat="server" Width="380px"  ></asp:Label>
				    </td>
				    
                    </tr>
				  </table>
				   
				<%--   <div align="right" dir="rtl" 
        style="width:125px;">
				   &nbsp;&nbsp;&nbsp;&nbsp;
				    <asp:Label ID="Label10" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label1" runat="server" Text="وصف العمل : " Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				     
				    </div>
				    <div id="divDesc" runat="server" style="text-align:right; width:450px; "> 
                   
                    
                    </div>
				     <div align="right" dir="rtl" style="width: 100%">
				     &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label11" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label4" runat="server" Text="اسم الحلقة :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				   
				    </div>
				     <div align="right" dir="rtl" style="width: 100%">
				     &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label12" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label5" runat="server" Text="المدة :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				     
				    </div>
				     <div align="right" dir="rtl" style="width: 100%">
				     &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label13" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label6" runat="server" Text="الضيف ومنصبه :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    
				    </div>
				     <div align="right" dir="rtl" style="width: 100%">
				     &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label14" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label7" runat="server" Text="المذيع :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    
				    </div>
				    <div align="right" dir="rtl" style="width: 100%">
				    &nbsp;&nbsp;&nbsp;&nbsp;
				     <asp:Label ID="Label15" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label2" runat="server" Text="المصدر/ جهة حقوق النشر : " 
                            Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				     
				    </div>--%>
				
        <table dir="rtl" width="100%" runat="server" visible="false">
        <tr>
            <td dir="rtl" valign="top" align="right" colspan="2" >
               &nbsp;&nbsp;
            <asp:Label ID="Label17" runat="server" Text="•" Font-Bold="True"></asp:Label>
                                &nbsp;
             <asp:Label ID="Label18" runat="server" Font-Bold="True" >الكلمات الدالة :</asp:Label>
            </td>
        </tr>
        <tr dir="ltr">
           
            <td align="right" colspan="1" dir="rtl" rowspan="1">
            <asp:DataList  ID="DLTags" runat="server" 
	            RepeatColumns="3" Width="561px" CellPadding="4" 
            Height="25px" HorizontalAlign="Right"  RepeatDirection="Horizontal" 
                    EnableViewState="False" Font-Strikeout="False" Font-Underline="False" >
             <ItemTemplate>
                 <a id="aTags" href="#" dir="rtl"  style="text-decoration: blink"> <%#Eval("title_ar")%></a>
                    </ItemTemplate>
                    <SelectedItemStyle Wrap="True" />
                    </asp:DataList>
                    
            </td>
        </tr>
    </table>
    
   </div>
  </asp:Content>