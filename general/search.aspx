<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master"
    AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="general_search_general" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../user_controls/main_elements.ascx" TagName="main_elements" TagPrefix="uc2" %>
<%@ Register Src="../user_controls/support_elements.ascx" TagName="support_elements"
    TagPrefix="uc3" %>
<%@ Register Src="../user_controls/char_moalfat.ascx" TagName="char_moalfat" TagPrefix="uc4" %>
<%@ Register Src="../user_controls/add_reference.ascx" TagName="add_reference" TagPrefix="uc5" %>
<%@ Register Src="../user_controls/timeline.ascx" TagName="timeline" TagPrefix="uc6" %>
<%@ Register Src="../user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>
<%@ Register Src="../user_controls/docs_authors.ascx" TagName="docs_authors" TagPrefix="uc8" %>
<%@ Register Src="../user_controls/places_translation.ascx" TagName="places_translation"
    TagPrefix="uc9" %>
<%@ Register Src="~/user_controls/manuscriptTab.ascx" TagName="manuscript_tab" TagPrefix="uc10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table width="900" border="0" cellspacing="0" cellpadding="0" dir="<%$Resources:Master, dir%>"
        align="<%$Resources:Master, align%>" style="padding-right: 2; margin-right: 20px;
        margin-left: 20px; margin-top: 20px; margin-bottom: 20px;" id="tbl_view" runat="server">
        <tr>
            <td colspan="8">
                <asp:Label ID="noresults1" runat="server" Visible="false">
                   
                </asp:Label>
                <asp:Label ID="noresults2" runat="server" Visible="false">
                   
                </asp:Label>
                <asp:Label ID="noresults3" runat="server" Visible="false">
                   
                </asp:Label>
            </td>
        </tr>
         <tr>
            <td colspan="8">
                <cc1:TabContainer ID="TabContainer2" runat="server" Width="98%" Height="1000">
                    <cc1:TabPanel ID="TabPanel1" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="<%$Resources:Master, main_items%>" MaintainScrollPosition="true">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="control_panel" runat="server">
                                <ContentTemplate>
                                    <table width="900" border="0" cellspacing="0" cellpadding="0" dir="<%$Resources:Master, dir%>"
                                        align="<%$Resources:Master, align%>" style="padding-right: 2; margin-right: 20px;
                                        margin-left: 20px; margin-top: 20px; margin-bottom: 20px;" id="Table12" runat="server">
                                        <tr visible="false" align="<%$Resources:Master, align%>" runat="server" id="tr3"
                                            bgcolor="#ECE4CF">
                                            <td>
                                                <asp:Label ID="Label8" Visible="true" runat="server" CssClass="text_Dark_Brown_10pt"
                                                    Text="<%$Resources:Master, search%>"></asp:Label>
                                                <asp:Label ID="lbl_src" Visible="true" runat="server" CssClass="text_Dark_Brown_10pt"
                                                    Text=""></asp:Label>
                                            </td>
                                        </tr>
                                        <tr visible="false" runat="server" id="tr_nodata">
                                            <td>
                                                <asp:Label ID="Label7" Font-Size="12" Visible="true" runat="server" CssClass="text_Dark_Brown_10pt"
                                                    Text="<%$Resources:Master, srch1%>"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_char0" runat="server">
                                            <td align="<%$Resources:Master, align%>">
                                                <asp:Label ID="Label4" runat="server" CssClass="text_Brown_10pt_bold" Text="<%$Resources:Master, title_char%>"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_char1" runat="server">
                                            <td>
                                                <asp:Label ID="Label3" runat="server" Text=" <%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_char" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_char2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_char" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                    OnPagePropertiesChanged="lstviewchar_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" width="">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td id="Td100" valign="top" align="<%$Resources:Master, align%>" runat="server">
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
                                                        <td id="Td2" align="<%$Resources:Master, align%>" runat="server">
                                                            <table id="Table1" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" runat="server"
                                                                align="<%$Resources:Master, align%>" width="600" style="padding-right: 0">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>">
                                                                    <td id="Td3" align="<%$Resources:Master, align%>" valign="middle" runat="server">
                                                                        <asp:Image ID="Image2" runat="server" hspace="5" vspace="2" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td4" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" CssClass="text_Dark_Brown_10pt"
                                                                            runat="server">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="lblnoresult" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_char" runat="server" PagedControlID="lstview_char" PageSize="10"
                                                    OnPreRender="DataPager_char_PreRender">
                                                    <%--  "DataPager1_PreRender"--%>
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
FirstPageText="الأولى" PreviousPageText="السابقة" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr id="tr_char3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="trtitle">
                                                <hr style="width: 150; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr visible="false" runat="server" id="tr4">
                                            <td>
                                                <asp:Label ID="Label13" Font-Size="12" Visible="true" runat="server" CssClass="text_Dark_Brown_10pt"
                                                    Text="... <%$Resources:Master, srch1%> ..."></asp:Label>
                                            </td>
                                        </tr>
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_event0" runat="server">
                                            <td id="Td5" align="<%$Resources:Master, align%>" runat="server">
                                                <asp:Label ID="Label6" runat="server" Text="<%$Resources:Master, title_event%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_event1" runat="server">
                                            <td>
                                                <asp:Label ID="Label90" runat="server" Text=" <%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_event" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_event2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_event" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                    OnPagePropertiesChanged="lstviewevent_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td id="Td6" valign="top" align="<%$Resources:Master, align%>" runat="server">
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
                                                        <td id="Td7" align="<%$Resources:Master, align%>" runat="server" style="padding-right: 0">
                                                            <table id="Table2" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                                                                runat="server">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td id="Td8" align="<%$Resources:Master, align%>" valign="middle" runat="server">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_event" runat="server" PagedControlID="lstview_event"
                                                    PageSize="10" OnPreRender="DataPager_event_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="الأولى" PreviousPageText="السابقة" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_event3" runat="server">
                                            <td align="right" runat="server" id="Td3">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr visible="false" runat="server" id="tr5">
                                            <td>
                                                <asp:Label ID="Label14" Font-Size="12" Visible="true" runat="server" CssClass="text_Dark_Brown_10pt"
                                                    Text="... <%$Resources:Master, srch1%> ..."></asp:Label>
                                            </td>
                                        </tr>
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_topics0" runat="server">
                                            <td id="Td9" align="<%$Resources:Master, align%>" runat="server">
                                                <asp:Label ID="Label9" runat="server" Text="<%$Resources:Master, title_topic%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_topics1" runat="server">
                                            <td>
                                                <asp:Label ID="Label10" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_topics" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_topics2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_topics" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                    OnPagePropertiesChanged="lstviewtopics_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td id="Td10" valign="top" align="<%$Resources:Master, align%>" runat="server">
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
                                                        <td id="Td11" align="<%$Resources:Master, align%>" runat="server" style="padding-right: 0">
                                                            <table id="Table3" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                                                                runat="server">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td id="Td12" align="<%$Resources:Master, align%>" valign="middle" runat="server">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_topics" runat="server" PagedControlID="lstview_topics"
                                                    PageSize="10" OnPreRender="DataPager_topics_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="الأولى" PreviousPageText="السابقة" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_topics3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="Td4">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr visible="false" runat="server" id="tr6">
                                            <td>
                                                <asp:Label ID="Label15" Font-Size="12" Visible="true" runat="server" CssClass="text_Dark_Brown_10pt"
                                                    Text="... <%$Resources:Master, srch1%> ..."></asp:Label>
                                            </td>
                                        </tr>
                                        <tr dir="<%$ Resources:Master, dir %>" id="tr_place0" runat="server">
                                            <td align="<%$ Resources:Master, align %>">
                                                <asp:Label ID="Label45" runat="server" Text="<%$ Resources:Master, key_Places %>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$ Resources:Master, align %>" id="tr_place1" runat="server">
                                            <td>
                                                <asp:Label ID="Label46" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_place" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$ Resources:Master, align %>" id="tr_place2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_place" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                    OnPagePropertiesChanged="lstviewplace_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td valign="top" align="<%$ Resources:Master, align %>">
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
                                                        <td id="Td23" align="<%$ Resources:Master, align %>" runat="server" style="padding-right: 0">
                                                            <table id="Table7" border="0" cellspacing="0" dir="<%$ Resources:Master, dir %>"
                                                                align="<%$ Resources:Master, align %>" runat="server">
                                                                <tr id="Tr2" runat="server" align="<%$ Resources:Master, align %>" style="padding-right: 0">
                                                                    <td align="<%$Resources:Master, align%>" valign="middle">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$ Resources:Master, align %>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label47" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_place" runat="server" PagedControlID="lstview_place"
                                                    PageSize="10" OnPreRender="DataPager_place_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="ÇáÃæáì" PreviousPageText="ÇáÓÇÈÞÉ" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_place3" runat="server">
                                            <td align="<%$ Resources:Master, align %>" runat="server" id="Td24">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel2" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="<%$Resources:Master, title_media%>" MaintainScrollPosition="true">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <table width="900" border="0" cellspacing="0" cellpadding="0" dir="<%$Resources:Master, dir%>"
                                        align="<%$Resources:Master, align%>" style="padding-right: 2; margin-right: 20px;
                                        margin-left: 20px; margin-top: 20px; margin-bottom: 20px;" id="Table13" runat="server">
                                        <tr dir="<%$ Resources:Master, dir %>" id="tr_artifacts0" runat="server">
                                            <td align="<%$ Resources:Master, align %>">
                                                <asp:Label ID="Label54" runat="server" Text="<%$ Resources:Master, key_Artifacts %>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$ Resources:Master, align %>" id="tr_artifacts1" runat="server">
                                            <td>
                                                <asp:Label ID="Label55" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_artifacts" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$ Resources:Master, align %>" id="tr_artifacts2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_artifacts" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                    OnPagePropertiesChanged="lstviewartifacts_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td valign="top" align="<%$ Resources:Master, align %>">
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
                                                        <td id="Td29" align="<%$ Resources:Master, align %>" runat="server" style="padding-right: 0">
                                                            <table id="Table10" border="0" runat="server" cellspacing="0" dir="<%$ Resources:Master, dir %>"
                                                                align="<%$ Resources:Master, align %>">
                                                                <tr id="Tr2" runat="server" align="<%$ Resources:Master, align %>" style="padding-right: 0">
                                                                    <td align="<%$Resources:Master, align%>" valign="middle">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$ Resources:Master, align %>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label56" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_artifacts" runat="server" PagedControlID="lstview_artifacts"
                                                    PageSize="10" OnPreRender="DataPager_artifacts_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="ÇáÃæáì" PreviousPageText="ÇáÓÇÈÞÉ" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_artifacts3" runat="server">
                                            <td align="<%$ Resources:Master, align %>" runat="server" id="Td30">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr dir="<%$ Resources:Master, dir %>" id="tr_tv0" runat="server">
                                            <td align="<%$ Resources:Master, align %>">
                                                <asp:Label ID="Label48" runat="server" Text="<%$ Resources:Master, key_Video %>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$ Resources:Master, align %>" id="tr_tv1" runat="server">
                                            <td>
                                                <asp:Label ID="Label49" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_tv" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$ Resources:Master, align %>" id="tr_tv2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_tv" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                    OnPagePropertiesChanged="lstviewtv_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td valign="top" align="<%$ Resources:Master, align %>">
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
                                                        <td id="Td25" align="<%$ Resources:Master, align %>" runat="server" style="padding-right: 0">
                                                            <table id="Table8" border="0" cellspacing="0" runat="server" dir="<%$ Resources:Master, dir %>"
                                                                align="<%$ Resources:Master, align %>">
                                                                <tr id="Tr2" runat="server" align="<%$ Resources:Master, align %>" style="padding-right: 0">
                                                                    <td align="<%$Resources:Master, align%>" valign="middle">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$ Resources:Master, align %>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label50" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_tv" runat="server" PagedControlID="lstview_tv" PageSize="10"
                                                 OnPreRender="DataPager_tv_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="ÇáÃæáì" PreviousPageText="ÇáÓÇÈÞÉ" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_tv3" runat="server">
                                            <td align="<%$ Resources:Master, align %>" runat="server" id="Td26">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr dir="<%$ Resources:Master, dir %>" id="tr_sound0" runat="server">
                                            <td align="<%$ Resources:Master, align %>">
                                                <asp:Label ID="Label51" runat="server" Text="<%$ Resources:Master, key_audio %>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$ Resources:Master, align %>" id="tr_sound1" runat="server">
                                            <td>
                                                <asp:Label ID="Label52" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_sound" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$ Resources:Master, align %>" id="tr_sound2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_sound" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                    OnPagePropertiesChanged="lstviewsound_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td valign="top" align="<%$ Resources:Master, align %>">
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
                                                        <td id="Td27" align="<%$ Resources:Master, align %>" runat="server" style="padding-right: 0">
                                                            <table id="Table9" border="0" runat="server" cellspacing="0" dir="<%$ Resources:Master, dir %>"
                                                                align="<%$ Resources:Master, align %>">
                                                                <tr id="Tr2" runat="server" align="<%$ Resources:Master, align %>" style="padding-right: 0">
                                                                    <td align="<%$Resources:Master, align%>" valign="middle">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$ Resources:Master, align %>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label53" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_sound" runat="server" PagedControlID="lstview_sound"
                                                    PageSize="10"   OnPreRender="DataPager_sound_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="ÇáÃæáì" PreviousPageText="ÇáÓÇÈÞÉ" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_sound3" runat="server">
                                            <td align="<%$ Resources:Master, align %>" runat="server" id="Td28">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_images0" runat="server">
                                            <td id="Td18" align="<%$Resources:Master, align%>" runat="server">
                                                <asp:Label ID="Label36" runat="server" Text="<%$Resources:Master, title_photo%>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_images1" runat="server">
                                            <td>
                                                <asp:Label ID="Label37" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_images" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_images2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_images" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                OnPagePropertiesChanged="lstviewimages_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td id="Td6" valign="top" align="<%$Resources:Master, align%>" runat="server">
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
                                                        <td id="Td7" align="<%$Resources:Master, align%>" runat="server" style="padding-right: 0">
                                                            <table id="Table2" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                                                                runat="server">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td id="Td8" align="<%$Resources:Master, align%>" valign="middle" runat="server">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                
                                                <asp:Label ID="Label39" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_images" runat="server" PagedControlID="lstview_images"
                                                    PageSize="10" OnPreRender="DataPager_images_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="الأولى" PreviousPageText="السابقة" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_images3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="Td19">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel3" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="<%$Resources:Master, title_library%>" MaintainScrollPosition="true">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <table width="900" border="0" cellspacing="0" cellpadding="0" dir="<%$Resources:Master, dir%>"
                                        align="<%$Resources:Master, align%>" style="padding-right: 2; margin-right: 20px;
                                        margin-left: 20px; margin-top: 20px; margin-bottom: 20px;" id="Table14" runat="server">
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_documents0" runat="server">
                                            <td align="<%$Resources:Master, align%>">
                                                <asp:Label ID="Label38" runat="server" Text="<%$Resources:Master, title_docs%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_documents1" runat="server">
                                            <td>
                                                <asp:Label ID="Label40" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_documents" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_documents2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_documents" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                OnPagePropertiesChanged="lstviewdocuments_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td valign="top" align="<%$Resources:Master, align%>">
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
                                                        <td id="Td31" align="<%$Resources:Master, align%>" style="padding-right: 0" runat="server">
                                                            <table id="Table6" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" runat="server"
                                                                align="<%$Resources:Master, align%>">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td align="<%$Resources:Master, align%>" valign="middle">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label41" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_documents" runat="server" PagedControlID="lstview_documents"
                                                    PageSize="10" OnPreRender="DataPager_documents_PreRender">
                                                    <Fields>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_documents3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="Td7">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_articles0" runat="server">
                                            <td align="<%$Resources:Master, align%>">
                                                <asp:Label ID="Label23" runat="server" Text="<%$Resources:Master, title_articles%>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_articles1" runat="server">
                                            <td>
                                                <asp:Label ID="Label28" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_articles" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_articles2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_articles" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                 OnPagePropertiesChanged="lstviewarticles_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td valign="top" align="<%$Resources:Master, align%>">
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
                                                        <td id="Td22" align="<%$Resources:Master, align%>" runat="server" style="padding-right: 0">
                                                            <table id="Table5" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" runat="server"
                                                                align="<%$Resources:Master, align%>">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td align="<%$Resources:Master, align%>" valign="middle">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label33" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_articles" runat="server" PagedControlID="lstview_articles"
                                                    PageSize="10" OnPreRender="DataPager_articles_PreRender">
                                                    <Fields>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_articles3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="Td6">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_books0" runat="server">
                                            <td align="<%$Resources:Master, align%>">
                                                <asp:Label ID="Label5" runat="server" Text="<%$Resources:Master, title_book%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_books1" runat="server">
                                            <td>
                                                <asp:Label ID="Label11" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_books" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_books2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_books" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                 OnPagePropertiesChanged="lstviewbooks_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td valign="top" align="<%$Resources:Master, align%>">
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
                                                        <td id="Td20" align="<%$Resources:Master, align%>" runat="server" style="padding-right: 0">
                                                            <table id="Table4" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" runat="server"
                                                                align="<%$Resources:Master, align%>">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td align="<%$Resources:Master, align%>" valign="middle">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label18" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_books" runat="server" PagedControlID="lstview_books"
                                                    PageSize="10" OnPreRender="DataPager_books_PreRender">
                                                    <Fields>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_books3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="Td21">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_manuscripts0" runat="server">
                                            <td id="Td10" align="<%$Resources:Master, align%>" runat="server">
                                                <asp:Label ID="Label21" runat="server" Text="<%$Resources:Master, title_manuscripts%>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_manuscripts1" runat="server">
                                            <td>
                                                <asp:Label ID="Label22" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_manuscripts" runat="server" Visible="false" Font-Bold="false"
                                                    ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_manuscripts2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_manuscripts" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                 OnPagePropertiesChanged="lstviewmanuscripts_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td id="Td6" valign="top" align="<%$Resources:Master, align%>" runat="server">
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
                                                        <td id="Td7" align="<%$Resources:Master, align%>" runat="server" style="padding-right: 0">
                                                            <table id="Table2" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                                                                runat="server">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td id="Td8" align="<%$Resources:Master, align%>" valign="middle" runat="server">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label24" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_manuscripts" runat="server" PagedControlID="lstview_manuscripts"
                                                    PageSize="10" OnPreRender="DataPager_manuscripts_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="الأولى" PreviousPageText="السابقة" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_manuscripts3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="Td11">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel4" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="<%$Resources:Master, more%>" MaintainScrollPosition="true">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                <ContentTemplate>
                                    <table width="900" border="0" cellspacing="0" cellpadding="0" dir="<%$Resources:Master, dir%>"
                                        align="<%$Resources:Master, align%>" style="padding-right: 2; margin-right: 20px;
                                        margin-left: 20px; margin-top: 20px; margin-bottom: 20px;" id="Table15" runat="server">
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_theses0" runat="server">
                                            <td id="Td13" align="<%$Resources:Master, align%>" runat="server">
                                                <asp:Label ID="Label16" runat="server" Text="<%$Resources:Master, title_theses%>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_theses1" runat="server">
                                            <td>
                                                <asp:Label ID="Label17" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_theses" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_theses2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_theses" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                 OnPagePropertiesChanged="lstviewtheses_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td id="Td6" valign="top" align="<%$Resources:Master, align%>" runat="server">
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
                                                        <td id="Td7" align="<%$Resources:Master, align%>" runat="server" style="padding-right: 0">
                                                            <table id="Table2" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                                                                runat="server">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td id="Td8" align="<%$Resources:Master, align%>" valign="middle" runat="server">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label19" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_theses" runat="server" PagedControlID="lstview_theses"
                                                    PageSize="10" OnPreRender="DataPager_theses_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="الأولى" PreviousPageText="السابقة" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_theses3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="Td14">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_conference_proceedings0" runat="server">
                                            <td id="Td12" align="<%$Resources:Master, align%>" runat="server">
                                                <asp:Label ID="Label26" runat="server" Text="<%$Resources:Master, title_conference%>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_conference_proceedings1" runat="server">
                                            <td>
                                                <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_conference_proceedings" runat="server" Visible="false" Font-Bold="false"
                                                    ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_conference_proceedings2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_conference_proceedings" runat="server" GroupItemCount="1"
                                                    ItemPlaceholderID="itemPlaceholder"
                                                     OnPagePropertiesChanged="lstviewconferenceproceedings_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td id="Td6" valign="top" align="<%$Resources:Master, align%>" runat="server">
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
                                                        <td id="Td7" align="<%$Resources:Master, align%>" runat="server" style="padding-right: 0">
                                                            <table id="Table2" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                                                                runat="server">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td id="Td8" align="<%$Resources:Master, align%>" valign="middle" runat="server">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label29" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_conference_proceedings" runat="server" PagedControlID="lstview_conference_proceedings"
                                                    PageSize="10" OnPreRender="DataPager_conference_proceedings_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="الأولى" PreviousPageText="السابقة" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_conference_proceedings3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="Td15">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_website0" runat="server">
                                            <td id="Td16" align="<%$Resources:Master, align%>" runat="server">
                                                <asp:Label ID="Label31" runat="server" Text="<%$Resources:Master, title_Sites%>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_website1" runat="server">
                                            <td>
                                                <asp:Label ID="Label32" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_website" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_website2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_website" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                 OnPagePropertiesChanged="lstviewwebsite_PagePropertiesChanged">
                                                
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td id="Td6" valign="top" align="<%$Resources:Master, align%>" runat="server">
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
                                                        <td id="Td7" align="<%$Resources:Master, align%>" runat="server" style="padding-right: 0">
                                                            <table id="Table2" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
                                                                runat="server">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td id="Td8" align="<%$Resources:Master, align%>" valign="middle" runat="server">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label34" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_website" runat="server" PagedControlID="lstview_website"
                                                    PageSize="10" OnPreRender="DataPager_website_PreRender">
                                                    <Fields>
                                                        <%-- <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                        FirstPageText="الأولى" PreviousPageText="السابقة" ShowNextPageButton="false" />--%>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_website3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="Td17">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                        <tr dir="<%$Resources:Master, dir%>" id="tr_glossary0" runat="server">
                                            <td align="<%$Resources:Master, align%>">
                                                <asp:Label ID="Label42" runat="server" Text="<%$Resources:Master, title_glossray%>"
                                                    CssClass="text_Brown_10pt_bold"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_glossary1" runat="server">
                                            <td>
                                                <asp:Label ID="Label43" runat="server" Text="<%$Resources:Master, Results%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                                                <asp:Label ID="lbl_glossary" runat="server" Visible="false" Font-Bold="false" ForeColor="brown"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr align="<%$Resources:Master, align%>" id="tr_glossary2" runat="server">
                                            <td style="padding-right: 0">
                                                <asp:ListView ID="lstview_glossary" runat="server" GroupItemCount="1" ItemPlaceholderID="itemPlaceholder"
                                                 OnPagePropertiesChanged="lstviewglossary_PagePropertiesChanged">
                                                    <LayoutTemplate>
                                                        <table id="Table1" runat="server" style="padding-right: 0">
                                                            <tr id="Tr1" runat="server">
                                                                <td id="Td1" runat="server">
                                                                    <table id="groupPlaceholderContainer" runat="server">
                                                                        <tr id="groupPlaceholder" runat="server">
                                                                            <td valign="top" align="<%$Resources:Master, align%>">
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
                                                        <td id="Td32" align="<%$Resources:Master, align%>" runat="server" style="padding-right: 0">
                                                            <table id="Table11" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" runat="server"
                                                                align="<%$Resources:Master, align%>">
                                                                <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" style="padding-right: 0">
                                                                    <td align="<%$Resources:Master, align%>" valign="middle">
                                                                        <asp:Image ID="Image2" hspace="5" vspace="2" runat="server" ImageUrl="../images/p.jpg" />
                                                                    </td>
                                                                    <td align="<%$Resources:Master, align%>" runat="server" id="Td2" style="cursor: hand">
                                                                        <asp:LinkButton ID="lnktitle" Width="600" Font-Underline="false" runat="server" CssClass="text_Dark_Brown_10pt">
                                                                        </asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <asp:Label ID="Label44" runat="server" Text="<%$Resources:Master, srch1%>" Visible="false"></asp:Label>
                                                <asp:DataPager ID="DataPager_glossary" runat="server" PagedControlID="lstview_glossary"
                                                    PageSize="10" OnPreRender="DataPager_glossary_PreRender">
                                                    <Fields>
                                                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="Label" />
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="false" ShowNextPageButton="true"
                                                            LastPageText="<%$Resources:Master, last%>" NextPageText="<%$Resources:Master, next%>"
                                                            ShowPreviousPageButton="false" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                        <tr style="padding-right: 0" id="tr_glossary3" runat="server">
                                            <td align="<%$Resources:Master, align%>" runat="server" id="Td8">
                                                <hr style="width: 10; color: Gray" />
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                </cc1:TabContainer>
            </td>
        </tr>
       
    </table>
</asp:Content>
