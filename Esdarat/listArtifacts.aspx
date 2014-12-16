<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="listArtifacts.aspx.cs" Inherits="Esdarat_listArtifacts" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" 
      width="100%">
        <tr>
            <td id="Td1" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" >
                <asp:ListView ID="ListView1" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder">
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
                        <table id="Table1" dir="<%$Resources:Master, dir%>" runat="server" align="<%$Resources:Master, align%>" cellpadding="10">
                            <tr valign="top" align="<%$Resources:Master, align%>" runat="server">
                                <td id="Td1" rowspan="3" align="<%$Resources:Master, align%>" runat="server" style="width: auto">
                                    <a href="" runat="server" id="link_Image" class="books_title">
                                        <asp:Image ID="Image1" runat="server" align="<%$Resources:Master, align_img%>" Width="45 px" />
                                    </a>
                                </td>
                                <td runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                    <asp:LinkButton ID="Labbooktitle" CssClass="text" Font-Underline="true" Font-Bold="true"
                                        Font-Size="15px" runat="server"></asp:LinkButton>
                                </td>
                            </tr>
                            <tr    valign="top" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
                            <td  id="Td3" runat="server" style= "<%$Resources:Master, subTitle_align%>" class="books_title_text" align="<%$Resources:Master, align%>"
                                    dir="<%$Resources:Master, dir%>" >

                                    <asp:Label ID="Label2" runat="server"  Text="<%$Resources:Master, lbl_artifacts_maker%>"
                                     align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>"></asp:Label>
                                    <asp:Label ID="Labwriter" runat="server" Text="" CssClass="books_texts"
                                    align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:ListView>
                </td>
                </tr>
       <tr id="Trg" runat="server" align="<%$Resources:Master, align%>">
<td align="center" colspan="3" width="100%" dir="<%$Resources:Master, dir%>">
<table id="tableList" runat="server" visible="true" style="vertical-align: top"
width="100%" dir="<%$Resources:Master, dir%>">

<tr>
<td align="center">
<asp:DataPager ID="DataPager1" PagedControlID="ListView1" runat="server" PageSize="9"
OnPreRender="ListPager1_PreRender">
<Fields>
<asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
FirstPageText="<%$Resources:Master, st%>" PreviousPageText="<%$Resources:Master, prev%>" ShowNextPageButton="false" />
<asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
<asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="true" ShowNextPageButton="true"
LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>" ShowPreviousPageButton="false" />
</Fields>
</asp:DataPager>
</td>
</tr>
</table>
</td>
</tr>
    </table>
</asp:Content>
