<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="list_characters_books.aspx.cs" Inherits="Esdarat_list_characters_books"
    Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table id="tableList" cellpadding="0" cellspacing="0" width="400px" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
        <tr id="Tr1" align="<%$Resources:Master, align%>" runat="server">
            <td style="height: 10px" align="<%$Resources:Master, align%>" runat="server">
                <asp:ListView ID="ListView1" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder">
                    <LayoutTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <table cellpadding="0" runat="server" id="groupPlaceholderContainer" style="width: 100%;
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
                        <table width="100%" >
                        <tr runat="server" valign="top"> 
                        <td  runat="server" dir="<%$Resources:Master, dir%>" valign="top">
                        <table  runat="server" width="100%" >
                            <tr  runat="server" valign="top">                             
                                <td  runat="server" dir="<%$Resources:Master, dir%>"  width="20%">
                                    <asp:ImageButton ID="Img_book" runat="server" ImageUrl="~/img/Icon 2.png" Width="60px" />
                                </td>
                              
                                <td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>" width="80%">
                                    <table runat="server" >
                                        <tr valign="top" runat="server" >
                                            <td class="<%$Resources:Master, class%>" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>" >
                                                <asp:LinkButton ID="Labbooktitle" CssClass="text" Font-Underline="true" Font-Bold="true"
                                                    Font-Size="15px" runat="server" ></asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr valign="top" runat="server" id="tr_res">
                                            <td colspan="2" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>" valign="top">
                                                <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_name%>" CssClass="books_title_text"></asp:Label>
                                                <asp:Label ID="Labres" runat="server" CssClass="books_texts"></asp:Label>
                                            </td>
                                            <td colspan="2" class="books_text" align="<%$Resources:Master, align%>"></td>
                                        </tr>
                                        <tr valign="top" runat="server" id="tr_location"  >
                                            <td colspan="2" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>" valign="top">
                                                <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, Lbl_book_Publication_Place%>" CssClass="books_title_text"></asp:Label>
                                                <asp:Label ID="Labwriter" runat="server" CssClass="books_texts"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                        </td>
                        </tr>
                        </table>
                    </ItemTemplate>                    
                </asp:ListView>
                <tr id="Trg" runat="server" align="<%$Resources:Master, align%>">
<td align="center" colspan="3" width="100%" dir="<%$Resources:Master, dir%>">
<table id="table1" runat="server" visible="true" style="vertical-align: top"
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
            </td>
        </tr>        
    </table>
</asp:Content>
