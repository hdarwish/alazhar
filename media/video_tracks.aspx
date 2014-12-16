

<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="video_tracks.aspx.cs" Inherits="video_Tracks" Title="Video Tracks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="Div1" runat="server" align="center" style="width: 100%">
    <h1 align="center" 
                    style="color: #6A6A6A; font-size: 14px; font-weight: bold; font-family: 'tahoma';">
				    
				    التسجيلات التلفزيونية
				   
				</h1>
				<div align="center" 
                    
            style="height: 40px; width: 512px; vertical-align: middle;">
				<div align="center" id="divFilter" runat="server"
            style="height: 30px; float:left;">
				  
				
				    <asp:RadioButtonList ID="rbl1" runat="server" RepeatDirection="Horizontal" 
                Width="409px" TextAlign="Left" AutoPostBack="True" 
                onselectedindexchanged="rbl1_SelectedIndexChanged" >
				    <asp:ListItem  Text="الذاكرة المعمارية" Value="4"></asp:ListItem>
				    <asp:ListItem  Text="الموضوعات" Value="3"></asp:ListItem>
				    <asp:ListItem  Text="الاحداث" Value="2"></asp:ListItem>
				    <asp:ListItem  Text="الشخصيات" Value="1"></asp:ListItem>
				    <asp:ListItem Selected="True" Text="الكل" Value="0"></asp:ListItem>
				    
				</asp:RadioButtonList>
				
			
				
				</div>
				<div id="divlbl" runat="server" style="height: 30px; text-align: left; vertical-align: middle; line-height: 25px;"> 
					<asp:Label ID="lbl1" Text=": التصنيف " runat="server" Font-Bold="True" 
                        Font-Size="16px" ></asp:Label>
				</div>
				</div>
           <%-- <div id="Div2" runat="server"  
        style="border-style: solid; border-width: 1px;width:590px; height: 25px;">
				    <asp:Label ID="lbl213" runat="server" Text="اسم العمل" width="525px" Font-Bold="true"> </asp:Label>
				     <asp:Label ID="Label2" runat="server" Text="|" width="5px" 
                        Font-Size="Larger" Font-Bold="True"></asp:Label>&nbsp&nbsp
				     <asp:Label ID="Label1" runat="server" Text="مشاهدة" width="40px" 
                        Font-Bold="True"></asp:Label>
				</div>--%>
				<div id="Div3" runat="server"  style="width:595px;vertical-align:middle">
        <asp:DataList  ID="DLVideo" runat="server" RepeatDirection="Vertical" 
	            RepeatColumns="1"    GridLines="Both" HorizontalAlign="Right" >
							    <ItemTemplate>
							    
							 
							   <div style="height:25px;text-align:right;width:590px;vertical-align:middle">
		                             <%--<span> 
		                              <a href='<%# "video_player.aspx?playvideoid=" + Eval("id") %>' rel="enclosure" >
                                            <img  width="100" height="100" src="upload/Videos/Illusion.png">
                                            <br />
                                            <%#Eval("file_name")%>
                                          </a>
		                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>--%>
                            
                           
		                        
		                           <a href='<%# "video_player.aspx?playvideoid=" + Eval("id") %>'  style="text-decoration: none;" >
                                      &nbsp;&nbsp;&nbsp;&nbsp;<img  style="vertical-align:bottom;border-width:0px"  width="25px" height="25px" src="../images/button_play_red.png">
                                          </a>
                                        &nbsp;
                                         <asp:Label ID="lblname" runat="server" Text='<%#Eval("title")%> ' width="500px" > </asp:Label>
                                        &nbsp;
                                        <img  style="vertical-align:text-top;border-width:0px"  src="../images/bullet.png" >
		                        </div>
		                       
                             </ItemTemplate>
							    </asp:DataList >
				</div>

                  <br />
                        <div runat="server">
                               <asp:label id="lblCurrentPage" runat="server"></asp:label>
                           </div>
                           <div>
                        
                    <asp:button id="cmdNext" runat="server" text=" التالى " onclick="cmdNext_Click"></asp:button>
<asp:button id="cmdPrev" runat="server" text=" السابق " onclick="cmdPrev_Click"></asp:button>

                           </div>

                   
               
              
         <%-- <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT [file_name], [extension] FROM [content_media] where [content_type]=3"></asp:SqlDataSource>
			--%>			
    </div>
  </asp:Content>
