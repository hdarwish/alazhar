<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="general_Default"
    MaintainScrollPositionOnPostback="true" Title="ذاكرة الأزهر"  %>

<%@ Register Src="~/masterpage/topMenu.ascx" TagName="topmenu" TagPrefix="tm1" %>
<%@ Register Src="TimeLineShow.ascx" TagName=" Show" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ذاكرة الأزهر الشريف</title>
    <%--<link href="../CSS/CSS.css" rel="stylesheet" type="text/css" />--%>
    <link rel="stylesheet" id="css_gen" type="text/css" runat="server" media="screen, projection" />
    <link href="../CSS/StyleSheet.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="../css/tabview.css" />
    <link href="../CSS/div.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/div.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="../CSS/custMenu.css" type="text/css">

    <script type="text/javascript" src="../Js/tabview.js"></script>

    <script type="text/javascript">
        function click_div(orderId, divid) {
            var i = 0;
            var x = document.getElementById(divid);
            var div = document.createElement("div");
            div = document.getElementsByName(divid);

            for (j = 0; j < 8; j++) {
                if (document.getElementById('row' + j)) {
                    if (document.getElementById('row' + j).className == "divtabL")
                    { document.getElementById('row' + j).className = "divtabL"; }
                    else { document.getElementById('row' + j).className = "divtab"; }
                }
                if (document.getElementById('tit' + j))
                    document.getElementById('tit' + j).className = "divtabtitle";
            }
            if (document.getElementById('row' + orderId)) {
                if (document.getElementById('row' + orderId).className == "divtab")
                { document.getElementById('row' + orderId).className = "divtabsel"; }
                else { document.getElementById('row' + orderId).className = "divtab"; }
            }
            if (document.getElementById('tit' + orderId))
                document.getElementById('tit' + orderId).className = "divtabtitlesel";
            for (i = 0; i < 8; i++) {
                if (x == document.getElementById('div' + i)) {
                    if (x.style.display == 'none') {
                        document.getElementById('div' + i).style.display = 'block';

                    }

                }
                else { document.getElementById('div' + i).style.display = 'none'; }

            }

            function main_div(divid) {
                var x = document.getElementById(divid);
                if (x == divb)
                    document.getElementById(div0).style.display = 'block';

            }

        }
	   
    </script>

</head>
<body class="bg">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <input id="hidden_id" type="hidden" runat="server" />
    <input id="hidden_eve" type="hidden" runat="server" />
    <input id="hidden_top" type="hidden" runat="server" />
    <input id="hidden_plac" type="hidden" runat="server" />
    <div class="top">
    </div>
    <center runat="server">
        <div class="container" runat="server">
            <div class="top_menu" runat="server">
                <div class="top_menu_left" runat="server" id="divtop_menu_left">
                    <table class="top_menu_left" runat="server">
                        <tr runat="server">
                            <td class="text_header" runat="server">
                                <a href="#" class="text_header" runat="server">
                                    <asp:LinkButton ID="LinkButton4" class="text_header" runat="server" PostBackUrl="~/glossary/Default.aspx"
                                        ValidationGroup="LangLinks" Text="<%$Resources:Master, title_glossray%>"></asp:LinkButton>
                                    <%--<asp:Label ID="Label45" runat="server" Text="<%$Resources:Master, title_glossray%>"></asp:Label>--%>
                                </a>
                            </td>
                            <td>
                                <img src="../img/mostl7.jpg" />
                            </td>
                            <td class="text_header" runat="server">
                                <a href="contactus.aspx" class="text_header" runat="server">
                                    <asp:Label ID="Label46" runat="server" Text="<%$Resources:Master, link_contactus%>"></asp:Label>
                                </a>
                            </td>
                            <td>
                                <img src="../img/call.jpg" />
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="top_menu_right" runat="server" id="divtop_menu_right">
                    <table width="95%" height="46" border="0" cellpadding="2" cellspacing="2">
                        <tr>
                            <td id="frtd" runat="server">
                                <asp:LinkButton ID="LinkButton1" Visible="False" runat="server" Style="color: #e9d3b9; font-family: tahoma;
                                    font-size: 11px; text-decoration: none; text-align: center;" OnClick="FrLinkButton_Click"
                                    ValidationGroup="LangLinks">Francais</asp:LinkButton>
                            </td>
                            <td id="frensep" runat="server" style="width: 20px;">
                            </td>
                            <td id="entd" runat="server">
                                <asp:LinkButton ID="LinkButton2" Visible="False" Style="color: #e9d3b9; font-family: tahoma; font-size: 11px;
                                    text-decoration: none; text-align: center;" runat="server" OnClick="EnLinkButton_Click"
                                    ValidationGroup="LangLinks">English</asp:LinkButton>
                            </td>
                            <td id="arensep" runat="server" style="width: 21px;">
                            </td>
                            <td id="artd" runat="server">
                                <asp:LinkButton ID="LinkButton3" Style="color: #e9d3b9; font-family: tahoma; font-size: 11px;
                                    text-decoration: none; text-align: center;" runat="server" OnClick="ArLinkButton_Click"
                                    ValidationGroup="LangLinks">عربي</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <div class="_page" runat="server">
                <div class="_page_banner" runat="server">
                    <div class="_page_banner_search">
                        <div style="margin-top: 2">
                            <asp:LinkButton ID="Button1" BorderStyle="None" Style='<%$Resources: Master, btnsrshbg%>'
                                CssClass="text_search_btn" runat="server" OnClick="Button1_Click">
                                <asp:Label ID="srshlit" runat="server" Style="display: block; height: 25px; vertical-align: middle;
                                    margin-top: 5px" Text='<%$Resources:Master, srsh%>'></asp:Label>
                            </asp:LinkButton>
                        </div>
                        <div runat="server" style='<%$Resources: Master, srshbg%>'>
                            <asp:TextBox runat="server" ID="txt_sr2" Style='<%$Resources: Master, txtsrshbg%>'
                                CssClass="text_search"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div style="height: 15px; float: left; width: 976px;">
                </div>
                <div runat="server" id="tbl_menu">
                    <tm1:topmenu ID="topmenu1" runat="server" dir="<%$Resources:Master, dir%>" />
                </div>
                <div style="padding-right: 16px; width: 900px;" runat="server" visible="false" id="tbl_en_menu">
                    <ul id="Ul1" runat="server">
                        <li><a href="#">
                            <asp:Label ID="Label41" runat="server" Text="<%$Resources:Master, title_media%>"></asp:Label></a>
                            <ul id="Ul3" dir="<%$Resources:Master, dir%>" style="text-align: left" runat="server">
                                <li id="Li9" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../media/listPhotos.aspx" runat="server">
                                        <asp:Label ID="Label42" runat="server" Text="<%$Resources:Master, title_photo%>"></asp:Label>
                                    </a></li>
                                <li id="Li10" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../media/audio_list.aspx">
                                        <asp:Label ID="Label43" runat="server" Text="<%$Resources:Master,title_audio%>"></asp:Label>
                                    </a></li>
                                <li id="Li11" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../media/tvAudioList.aspx">
                                        <asp:Label ID="Label44" runat="server" Text="<%$Resources:Master, title_video%>"></asp:Label>
                                    </a></li>
                            </ul>
                        </li>
                        <li><a href="#">
                            <asp:Label ID="Label40" runat="server" Text="<%$Resources:Master, title_timeline%>"></asp:Label>
                        </a></li>
                        <li><a href="#">
                            <asp:Label ID="Label34" runat="server" Text="<%$Resources:Master, title_library%>"></asp:Label>
                        </a>
                            <ul id="Ul2" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                runat="server">
                                <li id="Li4" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../Esdarat/list_characters_books.aspx">
                                        <asp:Label ID="Label35" runat="server" Text="<%$Resources:Master, title_book%>"></asp:Label>
                                    </a></li>
                                <li id="Li5" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../Esdarat/list_articles.aspx">
                                        <asp:Label ID="Label36" runat="server" Text="<%$Resources:Master, title_article%>"></asp:Label>
                                    </a></li>
                                <li id="Li6" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../Esdarat/list_document.aspx">
                                        <asp:Label ID="Label37" runat="server" Text="<%$Resources:Master, title_document%>"></asp:Label>
                                    </a></li>
                                <li id="Li7" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../Elzakera/List_theses.aspx">
                                        <asp:Label ID="Label38" runat="server" Text="<%$Resources:Master, title_theses%>"></asp:Label>
                                    </a></li>
                                <li id="Li8" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../Esdarat/listConferencePropceed.aspx">
                                        <asp:Label ID="Label39" runat="server" Text="<%$Resources:Master, title_conference%>"></asp:Label>
                                    </a></li>
                            </ul>
                        </li>
                        <li><a href="#">
                            <asp:Label ID="Label33" runat="server" Text="<%$Resources:Master, title_place%>"></asp:Label>
                        </a></li>
                        <li><a href="../sheikhs/Default.aspx">
                            <asp:Label ID="Label29" runat="server" Text="<%$Resources:Master, title_char%>"></asp:Label></a>
                            <ul dir="rtl" style="text-align: right;">
                                <li id="Li1" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../sheikhs/Default.aspx?type=3">
                                        <asp:Label ID="Label30" runat="server" Text="<%$Resources:Master, title_scholar%>"></asp:Label>
                                    </a></li>
                                <li id="Li2" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../sheikhs/Default.aspx?type=2">
                                        <asp:Label ID="Label31" runat="server" Text="<%$Resources:Master, title_mufti%>"></asp:Label></a>
                                </li>
                                <li id="Li3" dir="<%$Resources:Master, dir%>" style="text-align: <%$Resources:Master, align%>"
                                    runat="server"><a href="../sheikhs/Default.aspx?type=1">
                                        <asp:Label ID="Label32" runat="server" Text="<%$Resources:Master, title_alazhar%>"></asp:Label></a>
                                </li>
                            </ul>
                        </li>
                        <li><a href="../topics/Default.aspx">
                            <asp:Label ID="Label28" runat="server" Text="<%$Resources:Master, title_topic%>"></asp:Label>
                        </a></li>
                        <li><a href="../events/Default.aspx">
                            <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master, title_event%>"></asp:Label></a>
                        </li>
                        <li><a href="../Default.aspx">
                            <asp:Label ID="Label26" runat="server" Text="<%$Resources:Master, title_main%>"></asp:Label></a></li>
                    </ul>
                </div>
                <div style="height: 20px; float: left; width: 976px;">
                </div>
                <div class="_page_body" runat="server" style="float: <%$Resources:Master, dir%>">
                    <div class="_page_body_left" runat="server">
                        <div class="_page_body_left_box_contaier" runat="server" align="<%$Resources:Master, align_img%>">
                            <div class="TabView" id="TabView" style="float: <%$Resources:Master, align_img%>"
                                runat="server">
                                <!-- *** Tabs ************************************************************** -->
                                <div runat="server" id="divtabs" class="Tabs" style="width: 321px; float: right;">
                                    <a style="width: 167px;" id="diva" runat="server">
                                        <asp:Literal ID="ltr1" runat="server" Text="<%$Resources:Master, spsub%>" />
                                    </a><a style="width: 150px" href="#" id="divb">
                                        <asp:Literal ID="Literal1" runat="server" Text="<%$Resources:Master, mostseen%>" /></a>
                                </div>
                                <!-- *** Pages ************************************************************* -->
                                <div class="Pages" id="dvpages" style="width: 630px; height: 299px; float: right;
                                    background-color: #F3EEDB" runat="server">
                                    <div class="Page" id="dvpage" runat="server">
                                        <div class="Pad" id="divpad" runat="server">
                                            <div dir="rtl" style="width: 388px; float: right; display: none" id="div0" runat="server">
                                                <!-- *** Page1 Start *** -->
                                                <table id="Table0" style="float: right; vertical-align: top; padding-top: 0;" runat="server"
                                                    cellpadding="3" cellspacing="4">
                                                    <tr align="right">
                                                        <td align="right" valign="top" >
                                                            <%--    <p runat="server" style="font: tahoma;vertical-align:top"  id="palign"> </p>--%>
                                                            <img style="width: 100px; padding-left: 5px; padding-right: 2px; float: right" id="td_img"
                                                                runat="server" />
                                                        </td>
                                                        <td valign="top">
                                                            <asp:Label Style="width: 260px; float: right; text-align: right; vertical-align: top"
                                                                ID="title2" runat="server" Font-Size="17px" Font-Bold="true" ForeColor="#c87340"
                                                                Font-Names="tahoma"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:Label ID="td_brief" Style="float: right; text-align: right; padding-top: 5px"
                                                                runat="server" Font-Size="13px" Font-Names="tahoma" ForeColor="#302618"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <a style="width: 100px; float: left; text-align: left" id="hmore" runat="server"
                                                                class="a" visible="false">
                                                                <asp:Literal ID="latr1" runat="server" Text="<%$Resources:Master, more%>"></asp:Literal>
                                                            </a>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <div dir="rtl" style="width: 388px; float: right; display: none" id="div1" runat="server">
                                                <!-- *** Page1 Start *** -->
                                                
                                                 <table id="Table1" style="float: right; vertical-align: top; padding-top: 0;" runat="server"
                                                    cellpadding="3" cellspacing="4">
                                                    <tr align="right">
                                                        <td align="right" valign="top" runat="server" id="td1">
                                                            <img style="width: 100px; padding-left: 5px; padding-right: 2px; float: right" id="Img4"
                                                                src="~/img/Azhar_Mosque.jpg" runat="server" />
                                                        </td>
                                                        <td valign="top">
                                                              <asp:Label ID="Label1" Style="width: 260px; float: right; text-align: right; vertical-align: top"
                                                                runat="server" Font-Size="13" Font-Bold="true" ForeColor="#C37D54" Font-Names="tahoma"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                               <asp:Label ID="PplaceBrief" Style="float: right; text-align: right; padding-top: 5px"
                                                                runat="server" Font-Size="10" Font-Names="tahoma"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                                <a style="width: 100px; float: left; text-align: left" id="A1" runat="server" class="a"
                                                                href="#" visible="true">
                                                                <asp:Literal ID="Literal3" runat="server" Text="<%$Resources:Master, more%>"></asp:Literal></a>
                                                        </td>
                                                    </tr>
                                                </table>
                                                
                                                
                                            </div>
                                            <div dir="rtl" style="width: 388px; float: right; display: none" id="div2" runat="server">
                                                <!-- *** Page1 Start *** -->
                                                
                                                 <table id="Table3" style="float: right; vertical-align: top; padding-top: 0;" runat="server"
                                                    cellpadding="3" cellspacing="4">
                                                    <tr align="right">
                                                        <td align="right" valign="top" runat="server" id="td2">
                                                            <img style="width: 100px; padding-left: 5px; padding-right: 2px; float: right" id="Img8"
                                                                    runat="server" />
                                                        </td>
                                                        <td valign="top">
                                                              <asp:Label ID="event_link2" runat="server" Font-Size="13" Font-Bold="true" ForeColor="#C37D54"
                                                                    Font-Names="tahoma" Style="width: 260px; float: right; text-align: right; vertical-align: top"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                               <asp:Label ID="PEventsBrief" Style="float: right; text-align: right; padding-top: 5px"
                                                                    runat="server" Font-Size="10" Font-Names="tahoma"></asp:Label> 
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                               <a style="width: 100px; float: left; text-align: left" id="A8" runat="server" class="a"
                                                                    href="" visible="true">
                                                                    <asp:Literal ID="Literal4" runat="server" Text="<%$Resources:Master, more%>"></asp:Literal></a>  
                                                        </td>
                                                    </tr>
                                                </table>
                                                
                                            </div>
                                            <div dir="rtl" style="width: 388px; float: right; display: none" id="div3" runat="server">
                                                <!-- *** Page1 Start *** -->
                                               
                                                 <table id="Table4" style="float: right; vertical-align: top; padding-top: 0;" runat="server"
                                                    cellpadding="3" cellspacing="4">
                                                    <tr align="right">
                                                        <td align="right" valign="top" runat="server" id="td3">
                                                             <img style="width: 100px; padding-left: 5px; padding-right: 2px; float: right" id="Img3"
                                                                    src="~/img/kanon1961.jpg" runat="server" />
                                                        </td>
                                                        <td valign="top">
                                                               <asp:Label ID="Label2" runat="server" Style="width: 260px; float: right; text-align: right;
                                                                    vertical-align: top" Font-Size="13" Font-Bold="true" ForeColor="#C37D54" Font-Names="tahoma"></asp:Label> 
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                             <asp:Label ID="PTopicsBrief" Style="float: right; text-align: right; padding-top: 5px"
                                                                    runat="server" Font-Size="10" Font-Names="tahoma"></asp:Label> 
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <a style="width: 100px; float: left; text-align: left" id="A3" runat="server" class="a"
                                                                    href="#" visible="true">
                                                                    <asp:Literal ID="Literal5" runat="server" Text="<%$Resources:Master, more%>"></asp:Literal></a>  
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <div runat="server" id="div_page1" style="width: 242px; float: left; height: 16px">
                                                <div id="content1" align="right" runat="server">
                                                    <div id="row0" class="divtabsel" runat="server">
                                                        <div class="divtabtitlesel" id="tit0" runat="server">
                                                            <asp:Label ID="Label53" runat="server" Font-Size="10px" Font-Names="tahoma" Text="<%$Resources:Master, title_char%>"></asp:Label>
                                                        </div>
                                                        <div style="height: 72px; width: 210px; cursor: hand; margin-right: 10px; float: right;"
                                                            id="dvchar2" align="right" runat="server" class="lnkbutton" onclick="click_div('0','div0');">
                                                            <asp:Label ID="title1" runat="server" Font-Size="12px" Font-Bold="true" ForeColor="#52442E"
                                                                Font-Names="tahoma" Text=""></asp:Label>
                                                        </div>
                                                    </div>
                                                    <div id="row1" class="divtab" runat="server">
                                                        <div id="tit1" class="divtabtitle" runat="server">
                                                            <asp:Label ID="Label54" runat="server" Font-Size="10px" Font-Names="tahoma" nowrap="false"
                                                                Text="<%$Resources:Master, title_place%>"></asp:Label>
                                                        </div>
                                                        <br />
                                                        <div id="dvplace2" runat="server" style="float: right; cursor: hand" class="lnkbutton"
                                                            onclick="click_div('1','div1');">
                                                            <asp:Label ID="place_title" Font-Size="12px" Text="" Font-Names="tahoma" Font-Bold="true"
                                                                ForeColor="#52442E" runat="server" Font-Underline="false"></asp:Label>
                                                        </div>
                                                    </div>
                                                    <div id="row2" class="divtab" runat="server">
                                                        <div id="tit2" class="divtabtitle" runat="server">
                                                            <asp:Label ID="Label55" runat="server" Font-Size="10px" Font-Names="tahoma" Text="<%$Resources:Master, title_event%>"></asp:Label>
                                                        </div>
                                                        <br />
                                                        <div id="dvevent2" runat="server" class="lnkbutton" style="cursor: hand; margin-right: 2px"
                                                            onclick="click_div('2','div2');">
                                                            <asp:Label ID="event_link" runat="server" Font-Size="12px" Font-Names="tahoma" Font-Bold="true"
                                                                ForeColor="#52442E" Text="" Font-Underline="false"></asp:Label>
                                                        </div>
                                                    </div>
                                                    <div id="row3" class="divtab" runat="server" style="height: 86px">
                                                        <div id="tit3" class="divtabtitle" runat="server">
                                                            <asp:Label ID="lbl_subhed" runat="server" Font-Size="10px" ForeColor="White" Font-Names="tahoma"
                                                                Text="<%$Resources:Master, title_topic%>" Font-Underline="false"></asp:Label>
                                                        </div>
                                                        <br />
                                                        <div id="dvtopics2" runat="server" class="lnkbutton" onclick="click_div('3','div3');"
                                                            style="cursor: hand;">
                                                            <asp:Label ID="topic_title" Font-Size="12px" Font-Names="tahoma" Font-Bold="true"
                                                                ForeColor="#52442E" Text="" runat="server" Font-Underline="false" Width="100%"></asp:Label>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- *** Page1 End ***** -->
                                        </div>
                                    </div>
                                    <!-- *** Page2 Start *** -->
                                    <div class="Page" id="dvpage1" runat="server">
                                        <div class="Pad" id="divpad1" runat="server">
                                            <div dir="rtl" style="width: 388px; float: right; display: none" id="div4" runat="server">
                                                <!-- *** Page1 Start *** -->
                                                
                                                  <table id="Table2" style="float: right; vertical-align: top; padding-top: 0;" runat="server"
                                                    cellpadding="3" cellspacing="4">
                                                    <tr align="right">
                                                        <td align="right" valign="top" runat="server" id="td4">
                                                              <img style="width: 100px; padding-left: 5px; padding-right: 2px; float: right" id="Img2"
                                                                    runat="server" />
                                                        </td>
                                                        <td valign="top">
                                                             <asp:Label ID="Label3" runat="server" Font-Size="13" Font-Bold="true" Font-Names="tahoma"
                                                                    Style="width: 260px; float: right; text-align: right; vertical-align: top" ForeColor="#C37D54"></asp:Label>  
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                             <asp:Label ID="mchar_brief" runat="server" Style="text-align: right; padding-top: 5px"
                                                                    Font-Size="10" Font-Names="tahoma"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                             <a style="width: 100px; float: left; text-align: left" id="A4" runat="server" class="a"
                                                                    href="#" visible="true">
                                                                    <asp:Literal ID="Literal6" runat="server" Text="<%$Resources:Master, more%>"></asp:Literal></a>
                                                        </td>
                                                    </tr>
                                                </table>
                                                
                                            </div>
                                            <div dir="rtl" style="width: 388px; float: right; display: none" id="div5" runat="server"
                                                cellpadding="5" cellspacing="5">
                                                <!-- *** Page1 Start *** -->
                                             
                                                 <table id="Table5" style="float: right; vertical-align: top; padding-top: 0;" runat="server"
                                                    cellpadding="3" cellspacing="4">
                                                    <tr align="right">
                                                        <td align="right" valign="top" runat="server" id="td5">
                                                            <img style="width: 100px; padding-left: 5px; padding-right: 2px; float: right" id="Img5"
                                                                    src="~/img/place1.png" runat="server" />   
                                                        </td>
                                                        <td valign="top">
                                                            <asp:Label ID="Label4" runat="server" Text="" Font-Size="13" Font-Bold="true" Font-Names="tahoma"
                                                                    Style="width: 260px; float: right; text-align: right; vertical-align: top" ForeColor="#C37D54"></asp:Label>  
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:Label ID="Pplacesvisited" Style="float: right; text-align: right; padding-top: 5px"
                                                                    runat="server" Font-Size="10" Font-Names="tahoma"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <a style="width: 100px; float: left; text-align: left" id="A5" runat="server" class="a"
                                                                    href="#" visible="true">
                                                                    <asp:Literal ID="Literal7" runat="server" Text="<%$Resources:Master, more%>"></asp:Literal></a>
                                                        </td>
                                                    </tr>
                                                </table>
                                                
                                            </div>
                                            <div dir="rtl" style="width: 388px; float: right; display: none" id="div6" runat="server">
                                                <!-- *** Page1 Start *** -->
                                          
                                                
                                                 <table id="Table6" style="float: right; vertical-align: top; padding-top: 0;" runat="server"
                                                    cellpadding="3" cellspacing="4">
                                                    <tr align="right">
                                                        <td align="right" valign="top" runat="server" id="td6">
                                                           <img style="width: 100px; padding-left: 5px; padding-right: 2px; float: right" id="Img6"
                                                                    src="" runat="server" />
                                                        </td>
                                                        <td valign="top">
                                                            <asp:Label ID="Label5" runat="server" Font-Size="13" Font-Bold="true" Font-Names="tahoma"
                                                                    Style="width: 260px; float: right; text-align: right; vertical-align: top" ForeColor="#C37D54"
                                                                    Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                             <asp:Label ID="pEventsvisited" Style="float: right; text-align: right; padding-top: 5px"
                                                                    runat="server" Font-Size="10" Font-Names="tahoma"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <a style="width: 100px; float: left; text-align: left" id="A6" runat="server" class="a"
                                                                    href="" visible="true">
                                                                    <asp:Literal ID="Literal8" runat="server" Text="<%$Resources:Master, more%>"></asp:Literal></a>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <div dir="rtl" style="width: 388px; float: right; display: none" id="div7" runat="server">
                                                <!-- *** Page1 Start *** -->
                                                
                                                 <table id="Table7" style="float: right; vertical-align: top; padding-top: 0;" runat="server"
                                                    cellpadding="3" cellspacing="4">
                                                    <tr align="right">
                                                        <td align="right" valign="top" runat="server" id="td7">
                                                         <img style="width: 100px; padding-left: 5px; padding-right: 2px; float: right" id="Img7"
                                                                    src="~/img/sub.jpg" runat="server" />
                                                        </td>
                                                        <td valign="top">
                                                             <asp:Label ID="Label6" runat="server" Text="" Font-Size="13" Font-Bold="true" Font-Names="tahoma"
                                                                    Style="width: 260px; float: right; text-align: right; vertical-align: top" ForeColor="#C37D54"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                          <asp:Label ID="ptopvisited" Style="float: right; text-align: right; padding-top: 5px"
                                                                    runat="server" Font-Size="10" Font-Names="tahoma"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                          <a style="width: 100px; float: left; text-align: left" id="A7" runat="server" class="a"
                                                                    href="#" visible="true">
                                                                    <asp:Literal ID="Literal9" runat="server" Text="<%$Resources:Master, more%>"></asp:Literal></a>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <div runat="server" id="div_page2" style="width: 242px; float: left; height: 16px">
                                                <div id="m_content" runat="server">
                                                    <div id="row4" runat="server" class="divtabsel">
                                                        <div class="divtabtitlesel" id="tit4" runat="server">
                                                            <asp:Label ID="Label56" runat="server" Font-Size="10px" Font-Names="tahoma" Text="<%$Resources:Master, title_char%>"></asp:Label>
                                                        </div>
                                                        <div id="Div8" style="height: 72px; width: 210px; cursor: hand; margin-right: 10px;
                                                            float: right;" align="right" runat="server" class="lnkbutton" onclick="click_div('4','div4');">
                                                            <asp:Label ID="mchar_title" runat="server" Font-Size="12px" Font-Names="tahoma" ForeColor="#52442E"
                                                                Font-Bold="true" Text="" Font-Overline="false"></asp:Label>
                                                        </div>
                                                    </div>
                                                    <div id="row5" class="divtab" runat="server">
                                                        <div id="tit5" runat="server" class="divtabtitle">
                                                            <asp:Label ID="Label57" runat="server" Font-Size="10px" Font-Names="tahoma" Text="<%$Resources:Master, title_place%>"></asp:Label>
                                                        </div>
                                                        <br />
                                                        <div id="Div9" runat="server" style="float: right; cursor: hand" class="lnkbutton"
                                                            onclick="click_div('5','div5');">
                                                            <asp:Label ID="mplac_title" Text="" Font-Size="12px" Font-Names="tahoma" ForeColor="#52442E"
                                                                Font-Bold="true" runat="server" Font-Underline="false"></asp:Label>
                                                        </div>
                                                    </div>
                                                    <div id="row6" class="divtab" runat="server">
                                                        <div id="tit6" runat="server" class="divtabtitle">
                                                            <asp:Label ID="Label58" runat="server" Font-Size="10px" Font-Names="tahoma" Text="<%$Resources:Master, title_event%>"></asp:Label>
                                                        </div>
                                                        <br />
                                                        <div id="divev" runat="server" class="lnkbutton" style="cursor: hand; float: right;" align="right"
                                                            onclick="click_div('6','div6');">
                                                            <asp:Label ID="mevent_title" runat="server" Text="" Font-Size="12px" Font-Names="tahoma"
                                                                ForeColor="#52442E" Font-Bold="true" Font-Underline="false"></asp:Label>
                                                        </div>
                                                    </div>
                                                    <div id="row7" class="divtab" runat="server" style="height: 86px">
                                                        <div id="tit7" runat="server" class="divtabtitle" style="vertical-align: top">
                                                            <asp:Label ID="Label7" runat="server" Font-Size="10px" Font-Names="tahoma" Text="<%$Resources:Master, title_topic%>"></asp:Label>
                                                        </div>
                                                        <br />
                                                        <div id="Div10" runat="server" class="lnkbutton" onclick="click_div('7','div7');"
                                                            style="cursor: hand; float: right; margin-top: -2px; margin-right: 0px">
                                                            <asp:Label ID="mtopic_title" Text="" Font-Size="12px" Font-Names="tahoma" ForeColor="#52442E"
                                                                Font-Bold="true" runat="server" Font-Underline="false"></asp:Label>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- *** Page2 End ***** -->
                                    </div>
                                </div>

                                <script type="text/javascript">

                                    tabview_initialize('TabView');

                                </script>

                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <p runat="server" width="800px" height="120px">
                            <a href="ver 25.swf" target="_blank" class="books_title">
                                <asp:Image ID="Image1" runat="server" ImageUrl="../img/flash_pic.png" />
                            </a>
                        </p>
                        <br />
                        <br />
                        <div id="dvfromlib" style="bottom: 0; text-align: right; float: right; direction: rtl"
                            runat="server">
                            <div class="text_Dark_Brown_10pt_bold">
                                <img src="../img/Bullet.png" />
                                <asp:Label ID="Literal2" runat="server" Height="21px" Style="vertical-align: top"
                                    Text="<%$Resources:Master, fromlibrary%>" /></div>
                            <br />
                            <div id="slider" style="width: 632px; height: 152px; float: right" align="center">
                                <div id="nav_arrow_right" style="width: 22px; height: 152px; float: right; background-color: #D5D0BA">
                                </div>
                                <div id="contentb" style="width: 196px; height: 152px; float: right; background-color: #E5E3D4">
                                    <table width="196" height="152" border="0" cellpadding="0" runat="server" align="<%$Resources:Master, align%>"
                                        cellspacing="0">
                                        <tr runat="server">
                                            <td valign="top" style="height: 44px; padding-top: 2px" runat="server" align="<%$Resources:Master, align%>">
                                                <div runat="server" align="<%$Resources:Master, align%>" class="text_orange_8pt_bold">
                                                    <asp:Label ID="Label62" runat="server" Text="<%$Resources:Master, from_book%>"></asp:Label>
                                                </div>
                                                <br />
                                                <div align="<%$Resources:Master, align%>" class="text_Dark_Brown_10pt_bold" runat="server"
                                                    id="div_title" style="margin-top: -13pt" dir="rtl">
                                                </div>
                                            </td>
                                            <td style="height: 44px; padding-top: 2px;" align="<%$Resources:Master, align%>"
                                                runat="server">
                                                <div align="center" runat="server" style="margin: 0px; padding: 0px;">
                                                    <img src="../img/Icon%202.png" style="padding: 0px; margin: 0px" /></div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" valign="top" align="right">
                                                <div align="<%$Resources:Master, align%>" class="text_Dark_Brown_10pt" runat="server"
                                                    id="div_content" style="padding: 5px; vertical-align: top">
                                                </div>
                                            </td>
                                        </tr>
                                        <tr style="height: 50px">
                                            <td colspan="2" valign="top" align="left">
                                                <strong><a id="A2" runat="server" class="a">
                                                    <asp:Label ID="Label65" runat="server" Text="<%$Resources:Master, more%>"></asp:Label>
                                                </a></strong>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div id="contenta" style="width: 196px; height: 152px; float: right; background-color: #DCD9C6">
                                    <table width="196" height="152" border="0" cellpadding="0" cellspacing="0" runat="server"
                                        align="<%$Resources:Master, align%>">
                                        <tr runat="server" align="<%$Resources:Master, align%>">
                                            <td valign="top" runat="server" align="<%$Resources:Master, align%>" style="height: 44px;
                                                padding-top: 2px; margin-right: 2px">
                                                <div runat="server" align="<%$Resources:Master, align%>" class="text_orange_8pt_bold">
                                                    <asp:Label ID="Label63" runat="server" Text="<%$Resources:Master, from_doc%>"></asp:Label>
                                                </div>
                                                <br />
                                                <div align="<%$Resources:Master, align%>" class="text_Dark_Brown_10pt_bold" runat="server"
                                                    id="div_title1" style="margin-top: -13pt" dir="rtl">
                                                </div>
                                            </td>
                                            <td style="height: 44px; padding-top: 2px" runat="server" align="<%$Resources:Master, align%>">
                                                <div align="center" style="margin: 0px; padding: 0px;">
                                                    <img src="../img/Icon 1.png" style="padding: 0px; margin: 0px" /></div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" valign="top">
                                                <div align="right" class="text_Dark_Brown_10pt" runat="server" id="div_content1"
                                                    style="padding: 5px; margin: 2px; vertical-align: top">
                                                    &nbsp;
                                                </div>
                                            </td>
                                        </tr>
                                        <tr style="height: 50px">
                                            <td colspan="2" valign="top" align="left">
                                                <strong><a href="" id="link_more2" runat="server" class="a">
                                                    <asp:Label ID="Label66" runat="server" Text="<%$Resources:Master, more%>"></asp:Label></a></strong>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div id="contentm" style="width: 196px; height: 152px; float: right; background-color: #D5D0BA">
                                    <table width="196" height="152" border="0" cellpadding="0" cellspacing="0">
                                        <tr align="<%$Resources:Master, align%>" runat="server">
                                            <td valign="top" style="height: 44px; margin-right: 2px" runat="server" align="<%$Resources:Master, align%>">
                                                <div align="<%$Resources:Master, align%>" class="text_orange_8pt_bold" runat="server">
                                                    <asp:Label ID="Label64" runat="server" Text="<%$Resources:Master, from_manuscript%>"></asp:Label>
                                                </div>
                                                <br />
                                                <div align="<%$Resources:Master, align%>" class="text_Dark_Brown_10pt_bold" runat="server"
                                                    id="div_title2" style="margin-top: -13pt" dir="rtl">
                                                </div>
                                            </td>
                                            <td style="height: 44px">
                                                <div align="center" style="margin: 0px; padding: 0px;">
                                                    <img src="../img/Icon%205.png" style="padding: 0px; margin: 0px" /></div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" valign="top">
                                                <div align="<%$Resources:Master, align%>" class="text_Dark_Brown_10pt" runat="server"
                                                    id="div_content2" style="padding: 5px; margin: 2px; vertical-align: top">
                                                </div>
                                            </td>
                                        </tr>
                                        <tr style="height: 50px">
                                            <td colspan="2" valign="top" align="left">
                                                <strong><a href="" id="link_more" runat="server" class="a">
                                                    <asp:Label ID="Label67" runat="server" Text="<%$Resources:Master, more%>"></asp:Label></a></strong>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div id="nav_arrow_left" style="width: 22px; height: 152px; float: right; background-color: #C9C4A6">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id="Div11" style="float: <%$Resources:Master, align_img%>" runat="server">
                        <div class="_page_body_right" runat="server" style="float: <%$Resources:Master, align_img%>">
                            <div class="_page_body_right_box_contaier" style="height: 252px; float: <%$Resources:Master, align%>"
                                runat="server">
                                <div class="TabView" id="TabView_3" style="float: <%$Resources:Master, align%>; margin-right: 15px"
                                    runat="server">
                                    <!-- *** Tabs ************************************************************** -->
                                    <div class="Tabs" style="width: 237px;" runat="server">
                                        <a style="width: 46px;" id="pictab" runat="server">
                                            <asp:Label ID="Label61" runat="server" Text="<%$Resources:Master, title_photo%>"></asp:Label>
                                        </a><a style="width: 120px" id="vidtab" runat="server">
                                            <asp:Label ID="Label59" runat="server" Text="<%$Resources:Master, title_video%>"></asp:Label>
                                        </a><a style="width: 65px" id="audtab" runat="server">
                                            <asp:Label ID="Label60" runat="server" Text="<%$Resources:Master,title_audio%>"></asp:Label>
                                        </a>
                                    </div>
                                    <!-- *** Pages ************************************************************* -->
                                    <div class="Pages" style="width: 235px; height: 197px; background-color: #E6DCC1;
                                        margin-right: 0" runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                        <div class="Page" style="width: 235px;" runat="server">
                                            <div class="Pad" style="width: 235px" runat="server" dir="<%$Resources:Master, dir%>"
                                                align="<%$Resources:Master, align%>">
                                                <!-- *** Page1 Start *** -->
                                                <div style="width: 235px; height: 152px; margin-top: 20px" runat="server" align="center">
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_1_1" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_1_1" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div id="Div14" runat="server" style="width: 70px; height: 70px; display: inline"
                                                        float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_1_2" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_1_2" AlternateText="" BorderWidth="0" Width="70px" Height="70px"
                                                                ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align_img%>">
                                                        <a href="" id="a_1_3" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_1_3" AlternateText="" BorderWidth="0" Width="70px" Height="70px"
                                                                ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div runat="server" style="width: 70px; height: 70px; display: inline" float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_1_4" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_1_4" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div id="Div15" style="width: 70px; height: 70px; display: inline" runat="server"
                                                        float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_1_5" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_1_5" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" float="<%$Resources:Master, align_img%>"
                                                        runat="server">
                                                        <a href="" id="a_1_6" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_1_6" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                </div>
                                                <div runat="server" align="<%$Resources:Master, align_img%>" style="border: 0; padding-left: 5px;
                                                    padding-top: 2px">
                                                    <a href="../media/listPhotos.aspx" id="">
                                                        <img id="imgpics" runat="server" src="<%$Resources:Master, imgbtn%>" style="border: 0"
                                                            alt="المزيد" />
                                                    </a>
                                                </div>
                                                <!-- *** Page1 End ***** -->
                                            </div>
                                        </div>
                                        <!-- *** Page2 Start *** -->
                                        <div class="Page" style="width: 235px;">
                                            <div class="Pad" style="width: 235px" runat="server" dir="<%$Resources:Master, dir%>"
                                                align="<%$Resources:Master, align%>">
                                                <div runat="server" style="width: 235px; height: 152px; margin-top: 20px" align="center">
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_2_1" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_2_1" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_2_2" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_2_2" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align_img%>">
                                                        <a href="" id="a_2_3" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_2_3" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_2_4" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_2_4" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_2_5" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_2_5" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align_img%>">
                                                        <a href="" id="a_2_6" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_2_6" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                </div>
                                                <div runat="server" align="<%$Resources:Master, align_img%>" style="border: 0; padding-left: 5px;
                                                    padding-top: 2px">
                                                    <a href="../media/tvAudioList.aspx" id="A12">
                                                        <img id="imgvids" runat="server" src="<%$Resources:Master, imgbtn%>" style="border: 0"
                                                            alt="المزيد" />
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- *** Page2 End ***** -->
                                        <div class="Page" style="width: 235px;">
                                            <div class="Pad" style="width: 235px" runat="server" dir="<%$Resources:Master, dir%>"
                                                align="<%$Resources:Master, align%>">
                                                <!-- *** Page3 Start *** -->
                                                <div style="width: 235px; height: 152px; margin-top: 20px" align="center">
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_3_1" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_3_1" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_3_2" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_3_2" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align_img%>">
                                                        <a href="" id="a_3_3" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_3_3" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_3_4" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_3_4" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align%>">
                                                        <a href="" id="a_3_5" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_3_5" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                    <div style="width: 70px; height: 70px; display: inline" runat="server" float="<%$Resources:Master, align_img%>">
                                                        <a href="" id="a_3_6" runat="server" style="text-decoration:none">
                                                            <asp:Image ID="img_3_6" AlternateText="" Width="70px" Height="70px" ToolTip="" runat="server" />
                                                        </a>
                                                    </div>
                                                </div>
                                                <div runat="server" align="<%$Resources:Master, align_img%>" style="border: 0; padding-left: 5px;
                                                    padding-top: 2px">
                                                    <a href="../media/audio_list.aspx" id="A13">
                                                        <img id="imgauds" runat="server" src="<%$Resources:Master, imgbtn%>" style="border: 0"
                                                            alt="المزيد" />
                                                    </a>
                                                </div>
                                                <!-- *** Page3 End ***** -->
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div style="margin-top: 10px; float: left; width: 90%">
                                    <div style="margin-top: 1px; float: right; margin-right: 24px; z-index: 10">
                                        <img src="../img/portlet_texter.jpg" />
                                    </div>
                                    <%--<div>
                                    <img src="../img/more1.png" /></div>--%>
                                </div>

                                <script type="text/javascript">
                                    tabview_initialize('TabView_3');
                                </script>

                            </div>
                            <div class="_page_body_right_box_contaier_empty" style="margin-top: 20px">
                                <div style="width: 253px; height: 89px; cursor: hand; text-align: center; margin-left: 10px">
                                    <a style="width: 100px" id="A10" runat="server" class="a" href="#" visible="true">
                                        <img src="<%$ Resources:Master, img_gawla%>" style="border: 0" runat="server" id="img_gawla" />
                                    </a>
                                </div>
                                <div style="margin-top: 20px; cursor: hand">
                                    <a style="width: 100px" id="A9" runat="server" class="a" href="../places/Default.aspx"
                                        visible="true">
                                        <img src="<%$ Resources:Master, img_zakera%>" style="border: 0" runat="server" id="img_zakera" />
                                    </a>
                                </div>
                            </div>
                            <div class="_page_body_right_box_contaier_empty" style="margin-top: 28px">
                                <div style="width: 268px; height: 168px; text-align: center; margin-left: 10px; cursor: hand">
                                    <a style="width: 100px" id="A11" runat="server" class="a" href="../Esdarat/listArtifacts.aspx"
                                        visible="true">
                                        <%--<img src="../img/qeta3.jpg" style="border: 0" />--%>
                                        <img src="<%$ Resources:Master, img_qeta3 %>" style="border: 0" runat="server" id="img_qeta3" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="_page_body_bottom">
                    <table width="95%" height="90%" border="0" runat="server" cellpadding="2" cellspacing="2"
                        style='<%$Resources: Master, tbldir%>'>
                        <tr>
                            <td style="width: 104px">
                                <div align="center">
                                    <a href="#" class="footer_text_dark">
                                        <asp:Label ID="Label9" runat="server" Text="<%$Resources:Master, privacypolicy%>"></asp:Label>
                                    </a>
                                </div>
                            </td>
                            <td style="width: 104px">
                                <div align="center">
                                    <a href="#" class="footer_text_dark">
                                        <asp:Label ID="Label10" runat="server" Text="<%$Resources:Master, terms%>"></asp:Label>
                                    </a>
                                </div>
                            </td>
                            <td>
                                <div align="center">
                                    <a href="#">
                                        <img src="../img/clutnat_logo.png" width="59" height="32" border="0" /></a></div>
                            </td>
                            <td>
                                <div align="center">
                                    <a href="#">
                                        <img src="../img/azhar_mtbaa.png" width="47" height="46" border="0" /></a></div>
                            </td>
                            <td>
                                <div align="center">
                                    <a href="#">
                                        <img src="../img/eagle_logo.png" width="31" height="43" border="0" /></a></div>
                            </td>
                            <td>
                                <div align="center">
                                    <a href="#">
                                        <img src="../img/azhar_logo.png" width="55" height="55" border="0" /></a></div>
                            </td>
                            <td>
                                <div align="center" class="footer_text_dark">
                                    <asp:Label ID="Labelrgth" runat="server" Text="<%$Resources:Master, rights1%>"></asp:Label>
                                </div>
                                <div align="center" class="footer_text_dark">
                                    <asp:Label ID="Label8" runat="server" Text="<%$Resources:Master, rights2%>"></asp:Label>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </center>
    <div class="footer">
        <center>
            <div style="width: 766px;">
                <table width="95%" border="0" cellspacing="2" cellpadding="2" runat="server" style='<%$Resources: Master, tbldir%>'>
                    <tr>
                        <td>
                            <div class="footer_text" runat="server">
                                <a href="WebsiteMap.aspx" class="footer_text" runat="server">
                                    <asp:Label ID="Label52" runat="server" Text="<%$Resources:Master, website_map%>"></asp:Label></a>
                            </div>
                        </td>
                        <td>
                            <div class="footer_text" runat="server">
                                <a href="#" class="footer_text">
                                    <asp:Label ID="Label51" runat="server" Text="<%$Resources:Master,add_content_link%>"></asp:Label></a>
                            </div>
                        </td>
                        <td>
                            <div class="footer_text" runat="server">
                                <a href="FAQ.aspx" class="footer_text">
                                    <asp:Label ID="Label50" runat="server" Text="<%$Resources:Master, Q&A%>"></asp:Label></a>
                            </div>
                        </td>
                        <td>
                            <div class="footer_text" runat="server">
                                <a href="theCo_org.aspx" class="footer_text">
                                    <asp:Label ID="Label49" runat="server" Text="<%$Resources:Master, co_org%>"></asp:Label></a>
                            </div>
                        </td>
                        <td>
                            <div id="Div13" class="footer_text" runat="server">
                                <a id="A15" href="related_sites.aspx" class="footer_text" runat="server">
                                    <asp:Label ID="Label48" runat="server" Text="<%$Resources:Master, website_links%>"></asp:Label>
                                </a>
                            </div>
                        </td>
                        <td>
                            <div id="Div12" class="footer_text" runat="server">
                                <a id="A14" href="about_website.aspx" class="footer_text" runat="server">
                                    <asp:Label ID="Label47" runat="server" Text="<%$Resources:Master, aboutus%>"></asp:Label>
                                </a>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
        </center>
    </div>
    </form>
</body>
</html>
