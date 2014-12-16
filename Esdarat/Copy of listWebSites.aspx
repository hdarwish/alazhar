<%@ Page Language="C#"  MasterPageFile="~/masterpage/InnerMaster.master"  AutoEventWireup="true" CodeFile="Copy of listWebSites.aspx.cs" Inherits="Esdarat_listWebSites" Title="Untitled Page" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">   
     <table id="Table2" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" width="100%" runat="server" >  
        <tr id="Tr1" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <td id="Td5" runat="server" align="<%$Resources:Master, align%>" >
                <asp:ListView ID="DataList1" runat="server"  GroupItemCount="1" ItemPlaceholderID="itemPlaceholder" >
                     <LayoutTemplate>
                                    <table id="Table3" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server" width="100%" >
                                        <tr id="Tr2" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
                                            <td id="Td6" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
                                                <table cellpadding="2" runat="server" id="groupPlaceholderContainer" style="width: 100%;
                                                    height: 100%; border-width: thin" align="<%$Resources:Master, align%>">
                                                    <tr runat="server" id="groupPlaceholder" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                                        <td>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>                                       
                                    </table>
                     </LayoutTemplate>
                                <GroupTemplate> 
                                    <tr id="itemPlaceholderContainer" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <td id="itemPlaceholder" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        </td>
                                    </tr>
                                </GroupTemplate>
                    <ItemTemplate>                   
                            <tr valign="top"  align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
                                <td id="Td3" class="books_title" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                    <asp:LinkButton ID="LabWebSitetitle" CssClass="text" Font-Underline="true" Font-Bold="true"
                                        Font-Size="15px" runat="server" Text='<%#Eval("title").ToString().Length > 50 ? Eval("title").ToString().Substring(0,50)+"..." : Eval("title").ToString().Substring(0,Eval("title").ToString().Length) %>' ></asp:LinkButton>
                                </td>
                            </tr>                           
                            <tr valign="top" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
                                <td class="books_title_text" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" valign="top">
                                    <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, Responsible_Name2%>"></asp:Label>
                                    <asp:Label ID="Labres" runat="server" CssClass="books_texts"></asp:Label>
                                </td>
                            </tr>                     
                    </ItemTemplate> 
                </asp:ListView>               
            </td>
        </tr>                             
        <tr>
        <td  align="center"   runat="server">
                  <asp:DataPager ID="DataPager1" PagedControlID="DataList1" runat="server" PageSize="6"
                                            OnPreRender="ListPager1_PreRender">

                                        <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" 
                                                ShowPreviousPageButton="true" FirstPageText="<%$Resources:Master, first%>" PreviousPageText="<%$Resources:Master, prev%>" ShowNextPageButton="false"  />
    	                                        <asp:NumericPagerField   ButtonType="Button"  CurrentPageLabelCssClass="Label" />
    	                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="true"
    	                                         ShowNextPageButton="true" LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"  ShowPreviousPageButton="false" />
                                            </Fields>
                                       </asp:DataPager>
            </td>          
        </tr>
    </table>
</asp:Content>

