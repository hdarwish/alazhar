<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true" CodeFile="glossary_details.aspx.cs" Inherits="glossary_glossary_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <input id="HiddenID2" type="hidden" runat="server" />
<table id="Table1" runat="server"  width="400px" dir="<%$Resources:Master, dir%>">
        <tr runat="server" dir="<%$Resources:Master, dir%>">
            <td colspan="2" width="100%">
               <%-- <asp:Label runat="server" Text="الشخصيات" Font-Bold="True" ForeColor="#CC0000"></asp:Label>--%>
                <asp:Label ID="check_mode" runat="server" Text=""  Visible="false" ></asp:Label>
                <asp:Label ID="lnk_char" runat="server"  Visible="false"></asp:Label>
            </td>
        </tr>
        <tr align="center" valign="top">
            <td align="center" width="100%" colspan="3">
                <table id="Table2" runat="server" cellpadding="0" border="1" dir="<%$Resources:Master, dir%>" cellspacing="0" bordercolor="#815e28">
                    <tr>
                        <td>
                            <table id="Table3" runat="server" dir="<%$Resources:Master, dir%>"  >
                                <tr style="padding-left: 15px;padding-right: 15px" align="left">
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link1" runat="server" Text="<%$Resources:Master, ch1%>" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=1" CssClass="char"></asp:LinkButton>
                                    
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link2" runat="server" Text="<%$Resources:Master, ch2%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=2"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link3" runat="server" Text="<%$Resources:Master, ch3%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=3"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link4" runat="server" Text="<%$Resources:Master, ch4%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=4"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link5" runat="server" Text="<%$Resources:Master, ch5%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=5"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link6" runat="server" Text="<%$Resources:Master, ch6%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=6"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link7" runat="server" Text="<%$Resources:Master, ch7%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=7"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link8" runat="server" Text="<%$Resources:Master, ch8%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=8"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link9" runat="server" Text="<%$Resources:Master, ch9%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=9"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link10" runat="server" Text="<%$Resources:Master, ch10%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=10"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link11" runat="server" Text="<%$Resources:Master, ch11%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=11"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link12" runat="server" Text="<%$Resources:Master, ch12%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=12"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link13" runat="server" Text="<%$Resources:Master, ch13%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=13"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link14" runat="server" Text="<%$Resources:Master, ch14%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=14"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link15" runat="server" Text="<%$Resources:Master, ch15%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=15"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link16" runat="server" Text="<%$Resources:Master, ch16%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=16"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link17" runat="server" Text="<%$Resources:Master, ch17%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=17"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link18" runat="server" Text="<%$Resources:Master, ch18%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=18"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link19" runat="server" Text="<%$Resources:Master, ch19%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=19"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link20" runat="server" Text="<%$Resources:Master, ch20%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=20"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link21" runat="server" Text="<%$Resources:Master, ch21%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=21"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link22" runat="server" Text="<%$Resources:Master, ch22%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=22"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link23" runat="server" Text="<%$Resources:Master, ch23%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=23"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link24" runat="server" Text="<%$Resources:Master, ch24%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=24"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link25" runat="server" Text="<%$Resources:Master, ch25%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=25"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link26" runat="server" Text="<%$Resources:Master, ch26%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=26"></asp:LinkButton>
                                    </td>
                                    <td id="tdlnk27" runat="server" style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link27" runat="server" Text="<%$Resources:Master, ch27%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=27"></asp:LinkButton>
                                    </td>
                                    <td id="tdlnk28" runat="server" style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link28" runat="server" Text="<%$Resources:Master, ch28%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=28"></asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            
            
            
            
           <%-- <td align="<%$Resources:Master, align%>"  style="display: inline" width="200px">
                <asp:ImageButton ID="CharList" runat="server" ImageUrl="../images/icon_text.gif"
                    OnClick="CharList_Click"  />
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="../images/icon_images.gif"
                    OnClick="ImageButton1_Click" />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">both</asp:LinkButton>
            </td>--%>
        </tr>
        
        <tr align="<%$Resources:Master, align%>">
            <td align="center" colspan="3" width="100%" dir="<%$Resources:Master, dir%>">
                <table id="tableList" runat="server"  visible="false" 
                    style="vertical-align: top" width="100%" dir="<%$Resources:Master, dir%>">
                    <tr><td></td></tr>
                    <tr id="char_filtertr" runat="server">
                    
                              
                                <td align="<%$Resources:Master, align%>" valign="top" style="width:90%;">
                                        <asp:Label ID="char_filterlab" runat="server" CssClass="books_title"  Width="250px" />
                                           <%-- <asp:LinkButton ID="Linklist1" runat="server" CssClass="sheikhs_links"  Width="250px"></asp:LinkButton>--%>
                                        </td>
                                </tr>
                                 
                                 
                                   
                    <tr id="Tr1" runat="server">
                        <td  width="100%" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                        
                            <asp:ListView ID="ListView1" runat="server"   GroupItemCount="1" ItemPlaceholderID="itemPlaceholder">
                                <LayoutTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <table cellpadding="2"   runat="server" id="groupPlaceholderContainer" style="width: 100%;
                                                    height: 100%; border-width: thin">
                                                    <tr runat="server" id="groupPlaceholder">
                                                        <td>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr id="Tr1" runat="server">
                                            <td id="Td1" runat="server">
                                            </td>
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                                <GroupTemplate>
                                    <tr id="itemPlaceholderContainer" runat="server">
                                        <td id="itemPlaceholder" runat="server">
                                        </td>
                                    </tr>
                                </GroupTemplate>
                                <ItemTemplate>
                                
                                    <tr id="Tr2" runat="server">
                                        <%--<td align="<%$Resources:Master, align%>" valign="middle">
                                            <asp:Image ID="Image2" runat="server" ImageUrl="../images/p.jpg" />
                                        </td>--%>
                                        <td align="<%$Resources:Master, align%>" valign="top" style="width:90%;">
                                        <asp:Label ID="Linklist1" runat="server" CssClass="books_title"  Width="250px" Font-Bold="True" />
                                           <%-- <asp:LinkButton ID="Linklist1" runat="server" CssClass="sheikhs_links"  Width="250px"></asp:LinkButton>--%>
                                       <hr />
                                        </td>
                                         
                                    </tr>
                                    
                                    <tr id="details" runat="server" width="61px" valign="top"  >
                                  <td align="<%$Resources:Master, align%>" valign="top" style="width:90%;" nowrap="false" >
                                    <asp:Label ID="defination" runat="server"  /> 
                                    </td>
                                    </tr>
                                    <tr><td> </td></tr>
                                    <tr><td> </td></tr>
                                    
                                    
                                </ItemTemplate>
                                <%--<EmptyDataTemplate>
                                    <asp:Label ID="Label1" runat="server" Text="لا توجد بيانات"></asp:Label></EmptyDataTemplate>--%>
                            </asp:ListView>
                              <br /> </td> </tr>
                              <tr><td align="center"><br />
                              <asp:DataPager ID="DataPager1" PagedControlID="ListView1" runat="server" PageSize="9"
                                            OnPreRender="ListPager1_PreRender">

                                       <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" 
                                                ShowPreviousPageButton="true" FirstPageText="<%$Resources:Master, st%>" PreviousPageText="<%$Resources:Master, prev%>" ShowNextPageButton="false"  />
    	                                        <asp:NumericPagerField   ButtonType="Button"  CurrentPageLabelCssClass="Label" />
    	                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="true"
    	                                         ShowNextPageButton="true" LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"  ShowPreviousPageButton="false" />
                                            </Fields>
                                        </asp:DataPager>
                        </td>
                    </tr>
                   
                </table>
               
            </td>
        </tr>
        <tr visible="false" runat="server" id="tr_error" align="<%$Resources:Master, align%>">
            <td colspan="3">
                <asp:Label ID="Label1" runat="server"  Text="<%$Resources:Master, no_data%>" CssClass="text"></asp:Label>
            </td>
        </tr>
    </table>
   
</asp:Content>

