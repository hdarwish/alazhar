<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true"
    CodeFile="topicsList.aspx.cs" Inherits="topics_topicsList" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellpadding="0" border="1" bordercolor="#815e28" bordercolordark="white" cellspacing="0">
        <tr>
            <td style="height: 20px">
                <table cellpadding="0" border="0" dir="rtl" cellspacing="0">
                    <tr>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link1" runat="server" Text="أ" OnClick="Link1_Click" CssClass="char"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link2" runat="server" Text="ب" CssClass="char" OnClick="Link2_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link3" runat="server" Text="ت" CssClass="char" OnClick="Link3_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link4" runat="server" Text="ث" CssClass="char" OnClick="Link4_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link5" runat="server" Text="ج" CssClass="char" OnClick="Link5_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link6" runat="server" Text="ح" CssClass="char" OnClick="Link6_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link7" runat="server" Text="خ" CssClass="char" OnClick="Link7_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link8" runat="server" Text="د" CssClass="char" OnClick="Link8_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link9" runat="server" Text="ذ" CssClass="char" OnClick="Link9_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link10" runat="server" Text="ر" CssClass="char" OnClick="Link10_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link11" runat="server" Text="ز" CssClass="char" OnClick="Link11_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link12" runat="server" Text="س" CssClass="char" OnClick="Link12_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link13" runat="server" Text="ش" CssClass="char" OnClick="Link13_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link14" runat="server" Text="ص" CssClass="char" OnClick="Link14_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link15" runat="server" Text="ض" CssClass="char" OnClick="Link15_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link16" runat="server" Text="ط" CssClass="char" OnClick="Link16_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link17" runat="server" Text="ظ" CssClass="char" OnClick="Link17_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link18" runat="server" Text="ع" CssClass="char" OnClick="Link18_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link19" runat="server" Text="غ" CssClass="char" OnClick="Link19_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link20" runat="server" Text="ف" CssClass="char" OnClick="Link20_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link21" runat="server" Text="ق" CssClass="char" OnClick="Link21_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link22" runat="server" Text="ك" CssClass="char" OnClick="Link22_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link23" runat="server" Text="ل" CssClass="char" OnClick="Link23_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link24" runat="server" Text="م" CssClass="char" OnClick="Link24_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link25" runat="server" Text="ن" CssClass="char" OnClick="Link25_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link26" runat="server" Text="هـ" CssClass="char" OnClick="Link26_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link27" runat="server" Text="و" CssClass="char" OnClick="Link27_Click"></asp:LinkButton>
                        </td>
                        <td style="width: 20px" align="center">
                            <asp:LinkButton ID="Link28" runat="server" Text="ي" CssClass="char" OnClick="Link28_Click"></asp:LinkButton>
                        </td>
                    </tr>
                    </table>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:ImageButton ID="BothImage" runat="server" Height="20px" ImageUrl="~/images/both.gif"
                    OnClick="ImageButton1_Click" Width="20px" />
                <asp:ImageButton ID="Imglist" runat="server" ImageUrl="../images/icon_images.gif"
                    OnClick="Imglist_Click" />
                <asp:ImageButton ID="CharList" runat="server" ImageUrl="../images/icon_text.gif"
                    OnClick="CharList_Click" />
            </td>
        </tr>
        <tr align="right">
            <td>
                <table id="tableList" runat="server">
                    <tr>
                        <td>
                            <asp:ListView ID="ListView1" runat="server">
                                <LayoutTemplate>
                                    <table cellpadding="2" runat="server" id="tableListView" style="width: 100%; height: 100%;
                                        border-width: thin">
                                        <tr runat="server" id="itemPlaceholder">
                                            <td>
                                            </td>
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="Linklist" runat="server" Text="" CssClass="sheikhs"></asp:LinkButton>
                                    
                                      
                                </ItemTemplate>
                            </asp:ListView>
                        </td>
                    </tr>
                </table>
                <table id="tableImage" runat="server">
                    <tr>
                        <td>
                            <asp:DataList ID="ListView2" runat="server" RepeatColumns="2" 
                                RepeatDirection="Horizontal">
                                <ItemTemplate>
                                    <asp:ImageButton ID="Imagelist" runat="server" Width="100%" />
                                </ItemTemplate>
                            </asp:DataList>
                            
                           <%-- <asp:ListView ID="ListView2" runat="server">
                                <LayoutTemplate>
                                    <table cellpadding="2" runat="server" id="table1" style="width: 100%; height: 100%;
                                        border-width: thin">
                                        <tr runat="server" id="itemPlaceholder">
                                            <td>
                                            </td>
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <asp:ImageButton ID="Imagelist" runat="server" Width="100%" />
                                </ItemTemplate>
                            </asp:ListView>--%>
                        </td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td>
                            <asp:DataList ID="DataList1" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="Linklist" runat="server" Text="" CssClass="sheikhs"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:DataList>
                            <asp:DataPager runat="server" ID="DataPager1" PageSize="2" PagedControlID="ListView1">
                                <Fields>
                                    <asp:NumericPagerField ButtonType="Link" ButtonCount="5" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
