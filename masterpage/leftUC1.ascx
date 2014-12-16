<%@ Control Language="C#" AutoEventWireup="true" CodeFile="leftUC1.ascx.cs" Inherits="masterpage_leftUC1" %>
<link href="../css/CSS.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .style1
    {
        height: 23px;
    }
</style>
<div class="inner_page_body_right" align = "<%$Resources:Master, align%>" id="mainDev" runat="server">
    <div id="div_show" runat="server" class="_inner_page_body_right_box_contaier" style="z-index: -30;
        height: 300px" align="center">
        <div id="divimg" runat="server" style="width: 149px; height: 24px; margin-left: 15px; background-image: url(../img/inner_texture.png);
            background-repeat: no-repeat; float: left">
        </div>
        <div id="divtext" runat="server" class="text_White_8pt_bold" style="display: table;width: 79px; height: 30px; background-color: #C2A182;
            background-repeat: no-repeat; float: left; border: 1px #99806A solid" nowrap="nowrap">
            <asp:Label ID="content_txt" runat="server" style="display: table-cell;vertical-align: middle;" Text="" class="text_White_8pt_bold"></asp:Label>
        </div>
        <div style="margin-top: 20px; text-align: center; width: 227px; height: 169px; margin-top: 30pt;"
            align="center">
            <asp:Image ID="Image1" runat="server" ImageUrl="../img/azhar-char.gif" Width="227px" Height="169px" />
        </div>
        <div style="margin-top: 5px; text-align: center; width: 240px;" align="center"
            runat="server" id="div_related_images">
            <img id="imgdivrelt" runat="server" src="../img/Bullet.png" style="float: right; margin-left: 0px;" alt=""/>
            <div id="Div1" style="width: 65px; height: 70px; float: right; margin-right: 2px;"
                runat="server">
                <a href="" id="a_1_1" runat="server">
                    <asp:Image ID="img_1_1" AlternateText="" Width="65px" Height="70px" ToolTip="" runat="server" />
                </a>
            </div>
            <div id="Div2" style="width: 65px; height: 70px; float: right; margin-right: 5px;
                margin-left: 0px;" runat="server">
                <a href="" id="a_1_3" runat="server">
                    <asp:Image ID="img_1_3" AlternateText="" BorderWidth="0" Width="65px" Height="70px"
                        ToolTip="" runat="server" />
                </a>
            </div>
            <div id="Div3" runat="server" style="width: 65px; height: 70px; float: right; margin-right: 5px">
                <a href="" id="a_1_2" runat="server">
                    <asp:Image ID="img_1_2" AlternateText="" BorderWidth="0" Width="65px" Height="70px"
                        ToolTip="" runat="server" />
                </a>
            </div>
        </div>
    </div>
    <div id="pdf_continer" style="width: 226px; height: 73px;" align="center" runat="server">
        <div id="pdf_icon" style="float: right; margin-left: -4pt;margin-top: 10px"  runat="server">
            <a href="" target="_blank" runat="server" id="link_pdf1">
                <asp:Image ID="Image2" runat="server" ImageUrl="../img/PDF Icon.png" align = "<%$Resources:Master, align%>"/>
            </a>
        </div>
        <div id="pdf_content" style="float: right; width: 165px; margin-top: 10px"   runat="server">
            <div id="top_arrows" style="height: 14px; width: 140px; background-image: url(../img/Unit.png);
                background-repeat: repeat-x">
            </div>
            <div id="pdf_conent_middle" runat="server"  class="text_Dark_Brown_10pt_bold" style="width: 160px; height: 32px; background-color: #EBE1C6;text-align: right">
                <div id="pdf_conent_middle_SUB" runat="server" style="padding-right: 10pt; padding-top: 5pt">
                    <asp:Label ID="lbl_veiw" runat="server" Text="عرض " /></div>
            </div>
            <div id="bottom_arrows" style="height: 14px; width: 140px; background-image: url(../img/Unit_v.png);
                background-repeat: repeat-x">
            </div>
        </div>
    </div>
    <div id="div_related" runat="server" class="_divrelated" >
        <div style="margin-top: 10px" class="_divrelated" id="retatedTo" runat="server">
            <img src="../img/Bullet.png" id="imgrelt" runat="server" class="_divrelated_img" />
            <span id="relatspan" runat="server" class="text_Dark_Brown_10pt_bold" style="float:right;">محتوى متعلق بالشخصية
            </span>
        </div>
        <%--<div  style="width:200px;margin-top:20px;float:right;text-align:right"></div>--%>
        <div style="float: right; margin-top: 15px;width: 100%;">
            <table width="100%" border="0" bgcolor="#D3D2BD">
                <tr>
                    <td rowspan="6" width="21px" style="background-image: url('../img/pattern_2.png');
                        background-repeat: repeat-y;">
                        &nbsp;
                    </td>
                    <td align="center" class="style1">
                        <table width="100%">
                            <tr dir="ltr">
                                <td align="center" width="50%">
                                    <div style="margin-top: 0px">
                                        <img src="../img/Icon%202.png" width="54" height="46" /></div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/Esdarat/list_characters_books.aspx"
                                            runat="server" id="books_link" style="text-decoration: none" class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="books_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold"></asp:Label>&nbsp;
                                             <asp:Literal ID="Literal1" runat="server" Text="<%$ Resources:Master, title_book%>"></asp:Literal>  </a>
                                        </span>
                                    </div>
                                </td>
                                <td align="center" width="50%">
                                    <div>
                                        <img src="../img/Icon%201.png" width="39" height="45" />
                                    </div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/Esdarat/list_document.aspx" runat="server"
                                            id="docs_link" style="text-decoration: none" class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="docs_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold"></asp:Label>&nbsp;
                                         <asp:Literal ID="lt1" runat="server" Text="<%$ Resources:Master, title_docs%>"></asp:Literal>  </a>
                                        </span>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <div>
                                        <img src="../img/Icon%204.png" width="53" height="49" />
                                    </div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/media/audio_list.aspx" runat="server"
                                            id="audios_link" style="text-decoration: none" class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="audios_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold"></asp:Label>&nbsp;
                                             <asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:Master, title_audios%>"></asp:Literal></a> 
                                            </span>
                                    </div>
                                </td>
                                <td align="center">
                                    <div>
                                        <img src="../img/Icon%203.png" width="56" height="51" />
                                    </div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/media/tvAudioList.aspx" runat="server"
                                            id="videos_link" style="text-decoration: none" class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="videos_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold"></asp:Label>&nbsp;
                                             <asp:Literal ID="Literal3" runat="server" Text="<%$ Resources:Master, title_video%>"></asp:Literal></a> </span>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <div>
                                        <img src="../img/Icon%208.jpg" width="52" height="62" />
                                    </div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/Esdarat/listArtifacts.aspx" runat="server"
                                            id="artifacts_link" style="text-decoration: none" class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="artifacts_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold">
                                            </asp:Label>&nbsp;</asp:Label>&nbsp;<asp:Literal ID="Literal5" runat="server" Text="<%$ Resources:Master, title_artifacts%>"></asp:Literal></a> 
                                            </span>
                                    </div>
                                </td>
                                <td align="center">
                                    <div>
                                        <img src="../img/Icon%205.png" width="69" height="55" />
                                    </div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/Esdarat/listManuscript.aspx" runat="server"
                                            id="manuscripts_link" style="text-decoration: none" class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="manuscripts_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold">
                                            </asp:Label>&nbsp;<asp:Literal ID="Literal4" runat="server" Text="<%$ Resources:Master, title_manuscript%>"></asp:Literal></a>
                                             </span>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <div>
                                        <img src="../img/Icon%206.png" width="55" height="54" />
                                    </div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/Esdarat/listConferencePropceed.aspx"
                                            runat="server" id="ConferenceProceedings_link" style="text-decoration: none"
                                            class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="ConferenceProceedings_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold">
                                            </asp:Label>&nbsp;<asp:Literal ID="Literal6" runat="server" Text="<%$ Resources:Master, title_conference%>"></asp:Literal></a> </span>
                                    </div>
                                </td>
                                <td align="center">
                                    <div>
                                        <img src="../img/Icon%207.png" width="56" height="54" />
                                    </div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/Esdarat/list_articles.aspx" runat="server"
                                            id="articles_link" style="text-decoration: none" class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="articles_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold">
                                            </asp:Label>&nbsp;<asp:Literal ID="Literal7" runat="server" Text="<%$ Resources:Master, title_articles%>"></asp:Literal></a> </span>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <div>
                                        <img src="../img/Icon%207.png" width="56" height="54" />
                                    </div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/Elzakera/list_theses.aspx" runat="server"
                                            id="theses_link" style="text-decoration: none" class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="theses_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold">
                                            </asp:Label>&nbsp;<asp:Literal ID="Literal8" runat="server" Text="<%$ Resources:Master, title_theses%>"></asp:Literal></a> </span>
                                    </div>
                                </td>
                                <td align="center">
                                    <div>
                                        <img src="../img/Icon%207.png" width="56" height="54" /></div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/Esdarat/listWebSites.aspx" runat="server"
                                            id="web_link" style="text-decoration: none" class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="web_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold">
                                            </asp:Label>&nbsp;<asp:Literal ID="Literal9" runat="server" Text="<%$ Resources:Master, title_website%>"></asp:Literal></a> </span>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" runat="server" align="center">
                                    <div>
                                        <img src="../img/Icon%207.png" width="56" height="54" />
                                    </div>
                                    <div>
                                        <span class="text_Dark_Brown_9pt_bold"><a href="~/media/listPhotos.aspx" runat="server"
                                            id="pics_link" style="text-decoration: none" class="text_Dark_Brown_9pt_bold">
                                            <asp:Label ID="pics_count" runat="server" Text="" class="text_Dark_Brown_9pt_bold">
                                            </asp:Label>&nbsp;<asp:Literal ID="Literal10" runat="server" Text="<%$ Resources:Master, title_photo%>"></asp:Literal></a> </span>
                                    </div>
                                </td>
                               
                            </tr>
                        </table>
                    </td>
                    <td rowspan="6" width="21px" style="background-image: url('../img/pattern_2.png');
                        background-repeat: repeat-y;">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </div>
    </div>
</div>
