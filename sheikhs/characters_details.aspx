<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true"
    CodeFile="characters_details.aspx.cs" Inherits="sheikhs_characters_details" Title="Untitled Page" %>

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
                        <tr>
                            <td>
                                <asp:Label ID="LabName" runat="server" Text="" CssClass="" Font-Names="Arial" Font-Size="15px"
                                    Font-Bold="true"></asp:Label>
                                <asp:Label ID="LabBirthday" runat="server" Text="" Font-Bold="false" Font-Names="Arial"></asp:Label>
                                <asp:Label ID="lab_deathday" runat="server" Text="" Font-Bold="false" Font-Names="Arial"></asp:Label>
                            </td>
                        </tr>
                        <tr align="right">
                            <td align="right">
                                <asp:Label ID="Labtype" runat="server" Text="" CssClass="" Font-Size="14px" Width="300px"
                                    Font-Names="Arial"></asp:Label>
                            </td>
                        </tr>
                        <tr align="right">
                            <td colspan="4" valign="top" style="text-align: right">
                                <%--<asp:ImageButton ID="ImageButton1" runat="server" Width="100px" ImageAlign="Right"
                                                align="top" hspace="5"></asp:ImageButton>--%>
                                <%--<asp:Label ID="Label6" runat="server" Text="" Width="400px" Font-Names="arial"></asp:Label>--%>
                                <asp:ImageButton ID="Img" runat="server" ImageUrl="" Width="100px" hspace="5" vspace="15"
                                    ImageAlign="Right" Style="margin-bottom: 0px; margin-left: 10px" />
                                <p id="LabDetails" runat="server" dir="rtl" style="text-align: justify; font-size: 14px;
                                    width: 100%" class="text">
                                </p>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <%--<tr align="right">
                <td align="right">
                    <asp:Label ID="Label1" runat="server" Text="الوصف المختصر" Font-Bold="True" Font-Names="Arial"></asp:Label>
                </td>
            </tr>
            <tr align="right">
                <td dir="ltr">
                    <asp:Label ID="LabBrief" runat="server" Text="" CssClass="text" Font-Size="14px"></asp:Label>
                </td>
            </tr>--%>
            <tr align="right">
                <%--<td>
                    <asp:Label ID="Label3" runat="server" Text="الوصف تفصيلي" Font-Bold="true" Font-Names="Arial"></asp:Label>
                </td>--%>
            </tr>
            <%-- <tr align="right">
                <td>
                    <asp:Label ID="LabDetails" runat="server" Text="" CssClass="text" Font-Size="14px"
                        Width="100%"></asp:Label>
                </td>
            </tr>--%>
            <%--<tr align="right">
                <td>
                    <asp:Label ID="Label2" runat="server" Text="مشيخة الأزهر الشريف" CssClass="text" Font-Size="14px" Font-Bold="true"></asp:Label>
                </td>
            </tr>--%>
            <%-- <tr>
                <td align="right">
                    <asp:Label ID="LabAzhar" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>--%>
            <%--<tr>
            <td>الكلمات الدالة</td>
                <td align=right >
                    <asp:DataList ID="DataList6" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
                    
                        <ItemTemplate>
                        <ul> 
                         <asp:LinkButton ID="link_tags" runat="server"></asp:LinkButton>
                        </ul>
 
                        </ItemTemplate>
                      
                    </asp:DataList>
                </td>
            </tr>--%>
        </table>
    </div>
    <div style="text-align: right; width: 95%; height: 600px" dir="rtl ">
        <table cellpadding="3px" cellspacing="5px" align="right" width="100%">
            <tr align="right">
                <td dir="rtl">
                    <cc1:Accordion ID="Accordion5" runat="server" SelectedIndex="1" FadeTransitions="true"
                        FramesPerSecond="40" TransitionDuration="250" AutoSize="None" RequireOpenedPane="false"
                        SuppressHeaderPostbacks="true" CssClass="occordune">
                        <Panes>
                            <cc1:AccordionPane ID="AccordionPane6" runat="server">
                                <Header>
                                    <a href="">
                                        <asp:Label ID="Label12" runat="server" Text="مولده ونشأته" CssClass="text" Font-Underline="true"
                                            Font-Bold="true" Font-Size="15px"></asp:Label></a></Header>
                                <Content>
                                    <table runat="server">
                                        <tr runat="server">
                                            <td runat="server" style="text-align: justify" align="right">
                                                <asp:Label ID="LabBirthDetails" runat="server" CssClass="text" Font-Size="14px" Width="450px"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </Content>
                            </cc1:AccordionPane>
                        </Panes>
                    </cc1:Accordion>
                    <cc1:Accordion ID="Accordion6" runat="server" SelectedIndex="1" FadeTransitions="true"
                        FramesPerSecond="40" TransitionDuration="250" AutoSize="None" RequireOpenedPane="false"
                        SuppressHeaderPostbacks="true">
                        <Panes>
                            <cc1:AccordionPane ID="AccordionPane7" runat="server">
                                <Header>
                                    <a href="">
                                        <asp:Label ID="Label14" runat="server" Text="حياته العلمية" CssClass="text" Font-Underline="true"
                                            Font-Bold="true" Font-Size="15px"></asp:Label></a></Header>
                                <Content>
                                    <table runat="server">
                                        <tr runat="server">
                                            <td align="right" style="text-align: justify" runat="server">
                                                <asp:Label ID="LabScientific" runat="server" Text="" CssClass="text" Font-Size="14px" Width="450px"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </Content>
                            </cc1:AccordionPane>
                        </Panes>
                    </cc1:Accordion>
                    <cc1:Accordion ID="Accordion7" runat="server" SelectedIndex="1" FadeTransitions="true"
                        FramesPerSecond="40" TransitionDuration="250" AutoSize="None" RequireOpenedPane="false"
                        SuppressHeaderPostbacks="true">
                        <Panes>
                            <cc1:AccordionPane ID="AccordionPane8" runat="server" >
                                <Header>
                                    <a href="">
                                        <asp:Label ID="Label2" runat="server" Text="حياته العملية" CssClass="text" Font-Underline="true"
                                            Font-Bold="true" Font-Size="15px"></asp:Label></a></Header>
                                <Content>
                                    <table>
                                        <tr align="right">
                                            <td runat="server" align="right" style="text-align:justify">
                                                <asp:Label ID="lab_work_life" runat="server" Text="" CssClass="text" Font-Size="14px" Width="465px"></asp:Label><br />
                                                <asp:Label ID="Label1" runat="server" Visible="false" Text="كما شارك فى العديد من "
                                                    CssClass="text" Font-Size="14px"></asp:Label>
                                                <asp:HyperLink ID="HyperLink1" NavigateUrl="~/media/audio_tracks.aspx" runat="server"
                                                    Visible="false">
                                                    <asp:Label ID="Label3" runat="server" Text="البرامج الاذاعية" CssClass="text" Font-Size="14px"></asp:Label>
                                                </asp:HyperLink>
                                                <asp:Label ID="Label11" runat="server" Visible="false" Text=", و" CssClass="text"
                                                    Font-Size="14px"></asp:Label>
                                                <asp:HyperLink ID="HyperLink2" NavigateUrl="~/media/video_tracks.aspx" runat="server"
                                                    Visible="false">
                                                    <asp:Label ID="Label10" runat="server" Text="البرامج التلفزيونية" CssClass="text"
                                                        Font-Size="14px"></asp:Label>
                                                </asp:HyperLink>
                                            </td>
                                        </tr>
                                    </table>
                                </Content>
                            </cc1:AccordionPane>
                        </Panes>
                    </cc1:Accordion>
                    <cc1:Accordion ID="Accordion8" runat="server" SelectedIndex="1" FadeTransitions="true"
                        FramesPerSecond="40" TransitionDuration="250" AutoSize="None" RequireOpenedPane="false"
                        SuppressHeaderPostbacks="true">
                        <Panes>
                            <cc1:AccordionPane ID="AccordionPane9" runat="server">
                                <Header>
                                    <a href="">
                                        <asp:Label ID="Label13" runat="server" Text="الانشطة الاجتماعية والثقافية والسياسية والعسكرية ...الخ "
                                            Font-Bold="true" CssClass="text" Font-Underline="true" Font-Size="15px"></asp:Label>
                                    </a>
                                </Header>
                                <Content>
                                    <table id="Table5" runat="server" align="right">
                                        <tr align="right">
                                            <td style="text-align: justify" align=right  valign="top">
                                                <asp:Label ID="Lab_activity" runat="server" Text="" CssClass="text" Font-Size="14px" Width="465px"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </Content>
                            </cc1:AccordionPane>
                        </Panes>
                    </cc1:Accordion>
                    <cc1:Accordion ID="Accordion0" runat="server" SelectedIndex="1" FadeTransitions="true"
                        FramesPerSecond="40" TransitionDuration="250" AutoSize="None" RequireOpenedPane="false"
                        SuppressHeaderPostbacks="true">
                        <Panes>
                            <cc1:AccordionPane ID="AccordionPane1" runat="server">
                                <Header>
                                    <a href="">
                                        <asp:Label ID="lab" runat="server" Text="أهم المواقف والإنجازات" CssClass="text"
                                            Font-Underline="true" Font-Bold="true" Font-Size="15px"></asp:Label></a></Header>
                                <Content>
                                    <asp:DataList ID="DataList1" runat="server">
                                        <ItemTemplate>
                                            <table id="Table1" border="0" dir="rtl" runat="server" align="right" width="100%">
                                                <tr style="text-align: justify" valign="top">
                                                    <td align="right" style="text-align: justify" valign="top">
                                                    <p id="Labelid" runat="server" dir="rtl" style="text-align: justify; font-size: 14px;" class="text">
                                    
                                                        </p>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </Content>
                            </cc1:AccordionPane>
                        </Panes>
                    </cc1:Accordion>
                    <cc1:Accordion ID="Accordion1" runat="server" SelectedIndex="1" 
                        ContentCssClass="accordionContent" FadeTransitions="true" FramesPerSecond="40" 
                        TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
                        <Panes>
                            <cc1:AccordionPane ID="AccordionPane3" runat="server">
                                <Header>
                                    <a href="">
                                        <asp:Label ID="Label4" runat="server" Text="الأوسمة والتكريمات" CssClass="text" Font-Underline="true"
                                            Font-Bold="true" Font-Size="15px"></asp:Label></a></Header>
                                <Content>
                                    <table id="Table2" runat="server" align="right" border="0">
                                        <tr align="right" runat="server" style="text-align:justify">
                                            <td style="text-align: justify" dir="rtl" valign="top">
                                                <asp:DataList ID="DataList2" runat="server">
                                                    <ItemTemplate>
                                                         <p id="LinkID" runat="server" dir="rtl" style="text-align: justify; font-size: 14px;" class="text">
                                    
                                                        </p>
                                                                
                                                    </ItemTemplate>
                                                </asp:DataList>
                                            </td>
                                        </tr>
                                    </table>
                                </Content>
                            </cc1:AccordionPane>
                        </Panes>
                    </cc1:Accordion>
                    <cc1:Accordion ID="Accordion2" runat="server" SelectedIndex="1" HeaderCssClass="accordionHeader"
                        ContentCssClass="accordionContent" FadeTransitions="true" FramesPerSecond="40"
                        TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
                        <Panes>
                            <cc1:AccordionPane ID="AccordionPane2" runat="server">
                                <Header>
                                    <a href="">
                                        <asp:Label ID="Label6" runat="server" Text="التقريزات" CssClass="text" Font-Underline="true"
                                            Font-Bold="true" Font-Size="15px"></asp:Label></a></Header>
                                <Content>
                                    <table runat="server" id="TRDataList3" align="right">
                                        <tr>
                                            <td align="right" dir="rtl" valign="top">
                                                <asp:DataList ID="DataList3" runat="server" RepeatDirection="Vertical">
                                                    <ItemTemplate>
                                                    <p id="LinkID" runat="server" dir="rtl" style="text-align: justify; font-size: 14px;" class="text">
                                    
                                                        </p>
                                                    </ItemTemplate>
                                                </asp:DataList>
                                            </td>
                                        </tr>
                                    </table>
                                </Content>
                            </cc1:AccordionPane>
                        </Panes>
                    </cc1:Accordion>
                    <cc1:Accordion ID="Accordion3" runat="server" SelectedIndex="1" HeaderCssClass="accordionHeader"
                        ContentCssClass="accordionContent" FadeTransitions="true" FramesPerSecond="40"
                        TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
                        <Panes>
                            <cc1:AccordionPane ID="AccordionPane4" runat="server">
                                <Header>
                                    <a href="">
                                        <asp:Label ID="Label7" runat="server" Text="مؤلفاته" CssClass="text" Font-Underline="true"
                                            Font-Bold="true" Font-Size="15px"></asp:Label></a></Header>
                                <Content>
                                
                                    <table runat="server" id="written_book" align="right">
                                        <tr>
                                            <td align="right" dir="rtl" valign="top">
                                                <asp:DataList ID="DataList6" runat="server">
                                                    <ItemTemplate>
                                                        <table dir="rtl" runat="server" id="written_book">
                                                            <tr>
                                                                <td valign="top">
                                                                    -
                                                                </td>
                                                                <td valign="top" align="right" style="text-align:justify" runat="server">
                                                                    <asp:LinkButton ID="link_book" runat="server" CssClass="text" Font-Underline="true"
                                                                        Font-Size="14px" Width="465px"></asp:LinkButton>
                                                                </td>
                                                                <td>
                                                                    <br />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </asp:DataList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table runat="server" id="Table3" align="right">
                                        <tr>
                                            <td align="right" dir="rtl" valign="top">
                                                <asp:DataList ID="DataList4" runat="server" RepeatDirection="Vertical">
                                                    <ItemTemplate>
                                                        <table runat="server">
                                                            <tr valign="top">
                                                                <td valign="top">
                                                                    -
                                                                </td>
                                                                <td runat="server" align="right" style="text-align:justify ">
                                                                    <asp:Label ID="LinkID" runat="server" Font-Size="14px" 
                                                                        CssClass="text" Width="465px"></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </asp:DataList>
                                            </td>
                                        </tr>
                                    </table>
                                </Content>
                            </cc1:AccordionPane>
                        </Panes>
                    </cc1:Accordion>
                    <cc1:Accordion ID="Accordion4" runat="server" SelectedIndex="1" HeaderCssClass="accordionHeader"
                        ContentCssClass="accordionContent" FadeTransitions="true" FramesPerSecond="40"
                        TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
                        <Panes>
                            <cc1:AccordionPane ID="AccordionPane5" runat="server">
                                <Header>
                                    <a href="">
                                        <asp:Label ID="Label9" runat="server" Text="ماكتب عنه" CssClass="text" Font-Underline="true"
                                            Font-Bold="true" Font-Size="15px"></asp:Label></a></Header>
                                <Content>
                                    <table runat="server" id="Table4" align="right">
                                        <tr>
                                            <td align="right" dir="rtl" valign="top">
                                                <asp:DataList ID="DataList5" runat="server" RepeatDirection="Vertical">
                                                    <ItemTemplate>
                                                        <table>
                                                            <tr valign="top">
                                                                <td>
                                                                    -
                                                                </td>
                                                                <td runat="server" align="right" style="text-align:justify">
                                                                    <asp:Label ID="LinkID" runat="server" Width="465px" Font-Size="14px"
                                                                        CssClass="text" ></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </asp:DataList>
                                            </td>
                                        </tr>
                                    </table>
                                </Content>
                            </cc1:AccordionPane>
                        </Panes>
                    </cc1:Accordion>
                </td>
            </tr>
        </table>
    </div>
    
    <div id="accordion">
            <h3>
                Section 1</h3>
            <div>
                <p>
                    Mauris mauris ante, blandit et, ultrices a, suscipit eget, quam. Integer ut neque.
                    Vivamus nisi metus, molestie vel, gravida in, condimentum sit amet, nunc. Nam a
                    nibh. Donec suscipit eros. Nam mi. Proin viverra leo ut odio. Curabitur malesuada.
                    Vestibulum a velit eu ante scelerisque vulputate.
                </p>
            </div>
            <h3>
                Section 2</h3>
            <div>
                <p>
                    Sed non urna. Donec et ante. Phasellus eu ligula. Vestibulum sit amet purus. Vivamus
                    hendrerit, dolor at aliquet laoreet, mauris turpis porttitor velit, faucibus interdum
                    tellus libero ac justo. Vivamus non quam. In suscipit faucibus urna.
                </p>
            </div>
            <h3>
                Section 3</h3>
            <div>
                <p>
                    Nam enim risus, molestie et, porta ac, aliquam ac, risus. Quisque lobortis. Phasellus
                    pellentesque purus in massa. Aenean in pede. Phasellus ac libero ac tellus pellentesque
                    semper. Sed ac felis. Sed commodo, magna quis lacinia ornare, quam ante aliquam
                    nisi, eu iaculis leo purus venenatis dui.
                </p>
                <ul>
                    <li>List item one</li>
                    <li>List item two</li>
                    <li>List item three</li>
                </ul>
            </div>
            <h3>
                Section 4</h3>
            <div>
                <p>
                    Cras dictum. Pellentesque habitant morbi tristique senectus et netus et malesuada
                    fames ac turpis egestas. Vestibulum ante ipsum primis in faucibus orci luctus et
                    ultrices posuere cubilia Curae; Aenean lacinia mauris vel est.
                </p>
                <p>
                    Suspendisse eu nisl. Nullam ut libero. Integer dignissim consequat lectus. Class
                    aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.
                </p>
            </div>
        </div>
</asp:Content>
