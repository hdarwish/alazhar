<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="listWebSites.aspx.cs" Inherits="Esdarat_listWebSites" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server"
        cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td id="Td5" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>"
                runat="server">
                <asp:ListView ID="DataList1" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder">
                    <LayoutTemplate>
                        <table>
                            <tr>
                                <td>
                                    <table cellpadding="2" runat="server" id="groupPlaceholderContainer" style="width: 100%;
                                        height: 100%; border-width: thin">
                                        <tr runat="server" id="groupPlaceholder">
                                            <td>
                                            </td>
                                        </tr>
                                    </table>
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
                        <table align="<%$Resources:Master, align%>" runat="server">
                            <tr align="<%$Resources:Master, align%>" runat="server">
                                <td id="Td3" class="text" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>"
                                    runat="server">
                                    <asp:LinkButton ID="LabWebSitetitle" CssClass="text" Font-Underline="true" Font-Bold="true"
                                        Font-Size="15px" runat="server" Text='<%#Eval("title").ToString().Length > 50 ? Eval("title").ToString().Substring(0,50)+"..." : Eval("title").ToString().Substring(0,Eval("title").ToString().Length) %>'></asp:LinkButton>
                                </td>
                            </tr>
                            <tr valign="top" runat="server">
                                <td class="books_title_text" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>"
                                    runat="server" valign="top">
                                    <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, Responsible_Name2%>"></asp:Label>
                                    <asp:Label ID="Labres" runat="server" CssClass="books_texts"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:ListView>
            </td>
        </tr>
        <tr id="Trg" runat="server" align="<%$Resources:Master, align%>">
            <td align="center" colspan="3" width="100%" dir="<%$Resources:Master, dir%>">
                <table id="tableList" runat="server" visible="true" style="vertical-align: top" width="100%"
                    dir="<%$Resources:Master, dir%>">
                    <tr>
                        <td>
                            <asp:DataPager ID="DataPager1" PagedControlID="DataList1" runat="server" PageSize="6"
                                OnPreRender="ListPager1_PreRender">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="<%$Resources:Master, first%>" PreviousPageText="<%$Resources:Master, prev%>"
                                        ShowNextPageButton="false" />
                                    <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="true" ShowNextPageButton="true"
                                        LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                        ShowPreviousPageButton="false" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                    <%-- <td align="center"  dir="<%$Resources:Master, dir%>">
                  <asp:DataPager ID="DataPager1" PagedControlID="DataList1" runat="server" PageSize="6"
                                            OnPreRender="ListPager1_PreRender">

                                        <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" 
                                                ShowPreviousPageButton="true" FirstPageText="الأولى" PreviousPageText="السابقة" ShowNextPageButton="false"  />
    	                                        <asp:NumericPagerField   ButtonType="Button"  CurrentPageLabelCssClass="Label" />
    	                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="true"
    	                                         ShowNextPageButton="true" LastPageText="الأخيرة" NextPageText="التالية"  ShowPreviousPageButton="false" />
                                            </Fields>
                                        </asp:DataPager>
            </td>--%>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
