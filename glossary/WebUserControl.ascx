<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs"
    Inherits="glossary_WebUserControl" %>
<table width="400px" style="padding-right:0px" align="center" runat="server" dir="<%$Resources:Master, dir%>">
   
                 
                    <tr valign="top" width="400px" runat="server" dir="<%$Resources:Master, dir%>">
                        <td align="right"  runat="server" dir="<%$Resources:Master, dir%>">
                           
                             <asp:ListView ID="ListView2" runat="server"  GroupItemCount="1" ItemPlaceholderID="itemPlaceholder">
                                <LayoutTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <table cellpadding="2" runat="server" id="groupPlaceholderContainer" style="width: 90%;
                                                    height: 100%; border-width: thin">
                                                    <tr runat="server" id="groupPlaceholder">
                                                        <td>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr id="Tr3" runat="server">
                                           <td id="Td1" runat="server">
                                            </td>
                                            <td id="Td2" runat="server">
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
                                 
                                    
                                        <td valign="top" id="Td1" style="width: 200px; padding-top: 5px;
                                                padding-left: 5px; padding-right: 5px; padding-bottom: 5px" runat="server" align="right">
                                                <asp:Image ID="Image2" runat="server" ImageUrl="../images/p.jpg" />
                                              
                                                <asp:LinkButton ID="Linklist3"  runat="server" CssClass="sheikhs_links"></asp:LinkButton>
                                            </td>
                                          
                                </ItemTemplate>
                                <%--<EmptyDataTemplate>
                                    <asp:Label ID="Label1" runat="server" Text="لا توجد بيانات"></asp:Label></EmptyDataTemplate>--%>
                            </asp:ListView>
        </td>
    </tr>
   <%-- <tr runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:DataList ID="ListView1" runat="server" RepeatColumns="3" Width="600" RepeatDirection="Horizontal">
                <ItemTemplate>
                    <asp:LinkButton ID="Labtitle" CssClass="sheikhs_links" Font-Underline="true" Font-Bold="true"
                        Font-Size="15px" runat="server"></asp:LinkButton>
                </ItemTemplate>
                <ItemStyle BackColor="Beige" Width="200" HorizontalAlign="<%$Resources:Master, align%>" />
            </asp:DataList>
        </td>
    </tr>--%>
    
                              
                              <tr><td align="center"><br /> <asp:DataPager ID="DataPager1" PagedControlID="ListView2" runat="server" PageSize="9"
                                            OnPreRender="ListPager1_PreRender">

                                        <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" 
                                                ShowPreviousPageButton="true" FirstPageText="<%$Resources:Master, st%>" PreviousPageText="<%$Resources:Master, prev%>" ShowNextPageButton="false"  />
    	                                        <asp:NumericPagerField   ButtonType="Button"  CurrentPageLabelCssClass="Label" />
    	                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="true"
    	                                         ShowNextPageButton="true" LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"  ShowPreviousPageButton="false" />
                                            </Fields>
                                        </asp:DataPager></td></tr>
                          
    <tr visible="false" runat="server" id="tr_error" align="<%$Resources:Master, align%>">
        <td colspan="3">
            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, no_data%>" CssClass="text"></asp:Label>
        </td>
    </tr>
</table>
