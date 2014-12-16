<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="audio_player.aspx.cs" Inherits="audioPlayer" Title="Audio Player" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
    <style type="text/css">
        .style16
        {
            width: 141px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div style="width:100%" dir="rtl" align="right">
    <h1 align="center" 
                    
        style="color: #6A6A6A; font-size: 14px; font-weight: bold; font-family: 'tahoma'; width:100%;" 
        dir="rtl">
				    
			<asp:Label ID="lblTitle" runat="server" ForeColor="Black"  ></asp:Label>
				      
				   
				</h1>
				 <div style="width:100%">
    <asp:Panel ID="PlayerPanel" runat="server" Visible="true">
            <center>

      <br />
      
        <embed src='<%= Get_Path() %>'  width="300" height="50" autostart="false" controller="true" >
        </embed>
            
        </center>
        </asp:Panel>
    </div>
    <br />
				 <%-- <div id="Div1" runat="server" align="right" dir="rtl" style="width:100%">
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
                           <asp:Label ID="Label10" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label1" runat="server" Text="وصف العمل : " Font-Bold="True"  ></asp:Label>
                            &nbsp;
                            
                        </td>
                        <td align="right" dir="rtl"  width="400px">
                             <asp:Label ID="lblDesc" runat="server"  ></asp:Label>
                        </td>
                        
                    </tr>
                    
                    <tr dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2">
                       &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label11" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label4" runat="server" Text="اسم الحلقة :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lblName" runat="server"  ></asp:Label>
				    </td>
				   
                    </tr>
                    
                    <tr dir="rtl" valign="top" >
                        <td align="right" dir="rtl" colspan="2">
                       &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label12" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label5" runat="server" Text="المدة :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lblDuration" runat="server"  ></asp:Label>
				    </td>
				    
                    </tr>
                    
                     <tr dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2">
                       &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label13" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label6" runat="server" Text="الضيف ومنصبه :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				     <asp:Label ID="lblJuest" runat="server"  ></asp:Label>
				    </td>
				    
                    </tr>
                    
                    
                     <tr id="trPresenter" runat="server" dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2">
                       &nbsp;&nbsp;&nbsp;&nbsp;
				      <asp:Label ID="Label14" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label7" runat="server" Text="المذيع :" Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lblPresenter" runat="server"  ></asp:Label>
				    </td>
				  
                    </tr>
                    
                    
                      <tr dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2" >
                       &nbsp;&nbsp;&nbsp;&nbsp;
				     <asp:Label ID="Label15" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label2" runat="server" Text="المصدر/ جهة حقوق النشر : " 
                            Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lblResource" runat="server"  ></asp:Label>
				    </td>
				    
                    </tr>
                    <tr dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2" >
                       &nbsp;&nbsp;&nbsp;&nbsp;
				     <asp:Label ID="Label3" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label8" runat="server" Text="مكان التسجيل: " 
                            Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lblplace" runat="server" Text="" ></asp:Label>
				    </td>
				    
                    </tr>
                     <tr dir="rtl" valign="top">
                        <td align="right" dir="rtl" colspan="2" >
                       &nbsp;&nbsp;&nbsp;&nbsp;
				     <asp:Label ID="Label9" runat="server" Text="•" Font-Bold="True"></asp:Label>
                        &nbsp;
				    <asp:Label ID="Label16" runat="server" Text=" تاريخ التسجيل: " 
                            Font-Bold="True"  ></asp:Label>
				    
				    &nbsp;
				    <asp:Label ID="lbldate" runat="server"   ></asp:Label>
				    </td>
				    
                    </tr>
				  </table>
				
                        
				
				
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
    
    <%-- <asp:DataList  ID="DLAudioAttached" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >--%>
    <div style="text-align:left;display:none;width:100%" align="center">
    <p>Events :     <asp:DataList  ID="DataList1" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aEvent" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Subjects :</p>
         <asp:DataList  ID="DataList2" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Architecture :</p>
         <asp:DataList  ID="DataList3" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Artifacts :</p>
         <asp:DataList  ID="DataList4" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Videos :</p>
         <asp:DataList  ID="DataList5" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Audios :</p>
         <asp:DataList  ID="DataList6" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Docs :</p>
         <asp:DataList  ID="DataList7" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Articles :</p>
         <asp:DataList  ID="DataList8" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Books :</p>
         <asp:DataList  ID="DataList9" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Images :</p>
         <asp:DataList  ID="DataList10" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Manuscripts :</p>
         <asp:DataList  ID="DataList11" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Thesises :</p>
         <asp:DataList  ID="DataList12" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Periodicals :</p>
         <asp:DataList  ID="DataList13" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Conferenses :</p>
         <asp:DataList  ID="DataList14" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    <div style="text-align:left;display:none" align="center">
    <p>Research in a conference :</p>
         <asp:DataList  ID="DataList15" runat="server" 
	            RepeatColumns="3" Width="595px" CellPadding="4" GridLines="Horizontal" 
            Height="50px" HorizontalAlign="Center" 
             
             onitemdatabound="DLAudioAttached_ItemDataBound" >
							    <ItemTemplate>
							    
							 
							   <div id="divCharacters" style="text-align:center">
		                          
		                             
		                              <a id="aCharacters" href='<%# "characters_details.aspx?id=" + Eval("content_id") %>' rel="enclosure" >
                                            
                                            <br />
                                            <%#Eval("name")%>
                                          </a>
		                      
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
    </div>
    </div>
    </asp:Content>