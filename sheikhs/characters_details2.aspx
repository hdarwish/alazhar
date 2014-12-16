<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true"
    CodeFile="characters_details2.aspx.cs" Inherits="sheikhs_characters_details" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   
   
    <input id="HiddenID" type="hidden" runat="server" value="0" />
    <div dir="rtl" style="width: 95%; vertical-align: top">
        <table cellpadding="3px" cellspacing="2px" align="right" width="95%">
            <tr dir="rtl">
                <td colspan="2" align="right" class="style2">
                    <table dir="rtl" style="text-align: right" cellpadding="0">
                    <tr><td><asp:Label ID="LabBirthday" runat="server" Text="" Font-Bold="true"></asp:Label></td></tr>
                 
                        <tr>
                            <td>
                                <asp:ImageButton ID="Img" runat="server" ImageUrl="" Width="100px" />
                            </td>
                            <td>
                                <asp:Label ID="LabName" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr align="right">
                <td align="right">
                    <asp:Label ID="Labtype" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr align="right">
                <td align="right">
                    <asp:Label ID="Label1" runat="server" Text="الوصف المختصر"></asp:Label>
                </td>
            </tr>
            <tr align="right">
                <td dir="ltr">
                    <asp:Label ID="LabBrief" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr align="right">
                <td>
                    <asp:Label ID="Label3" runat="server" Text="الوصف تفصيلي"></asp:Label>
                </td>
            </tr>
            <tr align="right">
                <td>
                    <asp:Label ID="LabDetails" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr align="right">
                <td>
                    <asp:Label ID="Label8" runat="server" Text="حياته العلمية"></asp:Label>
                </td>
            </tr>
            <tr align="right">
                <td>
                    <asp:Label ID="LabScientific" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr align="right">
                <td>
                    <asp:Label ID="Label5" runat="server" Text="مولده ونشأته"></asp:Label>
                </td>
            </tr>
            <tr align="right">
                <td>
                    <asp:Label ID="LabBirthDetails" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr align="right">
                <td>
                    <asp:Label ID="Label2" runat="server" Text="مشيخة الأزهر الشريف"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="LabAzhar" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <div style="text-align: right; width: 100%" dir="rtl ">
        <table cellpadding="3px" cellspacing="7px" align="right" width="100%">
            <tr>
                <td>
                    <ul dir="rtl">
                        <li dir="rtl">
                            <cc1:Accordion ID="Accordion0" runat="server" SelectedIndex="1" HeaderCssClass="accordionHeader"
                                ContentCssClass="accordionContent" FadeTransitions="true" FramesPerSecond="40"
                                TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
                                <Panes>
                                    <cc1:AccordionPane ID="AccordionPane1" runat="server">
                                        <Header>
                                            <a href="">
                                                <asp:Label ID="lab" runat="server" Text="أهم المواقف والإنجازات"></asp:Label></a></Header>
                                        <Content>
                                            <table id="Table1" dir="rtl" runat="server" align="right" width="100%">
                                                <tr style="text-align: right">
                                                    <td align="right">
                                                        <asp:DataList ID="DataList1" runat="server" RepeatDirection="Vertical">
                                                            <ItemTemplate>
                                                                <ul dir="rtl">
                                                                    <li>
                                                                        <asp:LinkButton ID="LinkID" Width="230px" runat="server"></asp:LinkButton>
                                                                    </li>
                                                                </ul>
                                                            </ItemTemplate>
                                                        </asp:DataList>
                                                    </td>
                                                </tr>
                                            </table>
                                        </Content>
                                    </cc1:AccordionPane>
                                </Panes>
                            </cc1:Accordion>
                        </li>
                       </ul>
                       <ul dir="rtl">
                        <li dir="rtl">
                            <cc1:Accordion ID="Accordion1" runat="server" SelectedIndex="1" HeaderCssClass="accordionHeader"
                                ContentCssClass="accordionContent" FadeTransitions="true" FramesPerSecond="40"
                                TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
                                <Panes>
                                    <cc1:AccordionPane ID="AccordionPane3" runat="server">
                                        <Header>
                                            <a href="">
                                                <asp:Label ID="Label4" runat="server" Text="الأوسمة والتكريمات"></asp:Label></a></Header>
                                        <Content>
                                            <table id="Table2" runat="server" align="right">
                                                <tr align="right">
                                                    <td style="text-align: right" dir="rtl">
                                                        <asp:DataList ID="DataList2" runat="server" RepeatDirection="Vertical">
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="LinkID" runat="server"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:DataList>
                                                    </td>
                                                </tr>
                                            </table>
                                        </Content>
                                    </cc1:AccordionPane>
                                </Panes>
                            </cc1:Accordion>
                        </li>
                        </ul>
                        <ul dir="rtl">
                        <li dir="rtl">
                            <cc1:Accordion ID="Accordion2" runat="server" SelectedIndex="1" HeaderCssClass="accordionHeader"
                                ContentCssClass="accordionContent" FadeTransitions="true" FramesPerSecond="40"
                                TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
                                <Panes>
                                    <cc1:AccordionPane ID="AccordionPane2" runat="server">
                                        <Header>
                                            <a href="">
                                                <asp:Label ID="Label6" runat="server" Text="التقريزات"></asp:Label></a></Header>
                                        <Content>
                                            <table runat="server" id="TRDataList3" align="right">
                                                <tr>
                                                    <td align="right" dir="rtl">
                                                        <asp:DataList ID="DataList3" runat="server" RepeatDirection="Vertical">
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="LinkID" runat="server"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:DataList>
                                                    </td>
                                                </tr>
                                            </table>
                                        </Content>
                                    </cc1:AccordionPane>
                                </Panes>
                            </cc1:Accordion>
                        </li>
                    </ul>
                    <ul dir="rtl">
                     <li dir="rtl">
                            <cc1:Accordion ID="Accordion3" runat="server" SelectedIndex="1" HeaderCssClass="accordionHeader"
                                ContentCssClass="accordionContent" FadeTransitions="true" FramesPerSecond="40"
                                TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
                                <Panes>
                                    <cc1:AccordionPane ID="AccordionPane4" runat="server">
                                        <Header>
                                            <a href="">
                                                <asp:Label ID="Label7" runat="server" Text="مؤلفاته"></asp:Label></a></Header>
                                        <Content>
                                            <table runat="server" id="Table3" align="right">
                                                <tr>
                                                    <td align="right" dir="rtl">
                                                        <asp:DataList ID="DataList4" runat="server" RepeatDirection="Vertical">
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="LinkID" runat="server"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:DataList>
                                                    </td>
                                                </tr>
                                            </table>
                                        </Content>
                                    </cc1:AccordionPane>
                                </Panes>
                            </cc1:Accordion>
                        </li>
                    </ul>
                    
                    <ul dir="rtl">
                     <li dir="rtl">
                            <cc1:Accordion ID="Accordion4" runat="server" SelectedIndex="1" HeaderCssClass="accordionHeader"
                                ContentCssClass="accordionContent" FadeTransitions="true" FramesPerSecond="40"
                                TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
                                <Panes>
                                    <cc1:AccordionPane ID="AccordionPane5" runat="server">
                                        <Header>
                                            <a href="">
                                                <asp:Label ID="Label9" runat="server" Text="مؤلفات عنه"></asp:Label></a></Header>
                                        <Content>
                                            <table runat="server" id="Table4" align="right">
                                                <tr>
                                                    <td align="right" dir="rtl">
                                                        <asp:DataList ID="DataList5" runat="server" RepeatDirection="Vertical">
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="LinkID" runat="server"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:DataList>
                                                    </td>
                                                </tr>
                                            </table>
                                        </Content>
                                    </cc1:AccordionPane>
                                </Panes>
                            </cc1:Accordion>
                        </li>
                    </ul>
                </td>
            </tr>
        </table>
    </div>
   
</asp:Content>
