<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="manuscriptDetails.aspx.cs" Inherits="Esdarat_manuscriptDetails" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
<script language="javascript">

    function toggle(image_name) {
        var images = new Array();
        images[0] = "img0";
        images[1] = "img1";
        images[2] = "img2";
        images[3] = "img3";
        images[4] = "img4";
        images[5] = "img5";
        images[6] = "img6";
        images[7] = "img7";
        images[8] = "img8";
        images[9] = "img9";
        images[10] = "img10";
        images[11] = "img11";
        images[12] = "img12";
        images[13] = "img13";
        images[14] = "img14";
        images[15] = "img15";
        images[16] = "img16";
        images[17] = "img17";
        images[18] = "img18";
        images[19] = "img19";

        for (var i = 0; i < images.length; i++) {
            if (document.getElementById(images[i]).id != image_name) {
                document.getElementById(images[i]).src = "../img/plus.jpg";
            }
            else {
                document.getElementById(image_name).src = "../img/minus.jpg";
            }
        }
    }
</script>

    <input id="HiddenID" type="hidden" runat="server" />
    <table style="width: 100%" border="0" cellspacing="0" runat="server" id="tblmanus"
        align="center">
        <tr>
            <td>
                
                    <div class="accordion_title" id="tr" runat="server">
                        <a href="" class="text_Brown_10pt_bold">
                            <asp:Label ID="Labtitle" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body_empty">
                        <span class="text_Dark_Brown_10pt"></span>
                    </div>

                    <div class="accordion_title" id="tr_title" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label9" runat="server" class="text_Brown_10pt_bold" Text="<%$ Resources:Master, lbl_titleFromTitle %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trtitfromtit" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_fromtitle" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr_title2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label71" runat="server" class="text_Brown_10pt_bold" Text="<%$ Resources:Master, lbl_titleFromIntro %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trtitfromintro" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_title_intro" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="Tr5" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label13" runat="server" class="text_Brown_10pt_bold" Text="<%$ Resources:Master, lbl_authorFromTitle %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trauthfromtit" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="author" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="Tr2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label23" runat="server" class="text_Brown_10pt_bold" Text="<%$ Resources:Master, lbl_authorFromIntro %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trauthfromintro" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_author_mokdma" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr6" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label15" runat="server" class="text_Brown_10pt_bold" Text="<%$ Resources:Master, lbl_manuscript_lang %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trlang" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:RadioButtonList ID="man_lang" runat="server" RepeatDirection="Horizontal" DataTextField="title_ar"
                                DataValueField="id" Visible="false">
                            </asp:RadioButtonList>
                            <asp:Label ID="lbl_man_lang" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr_place" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label11" runat="server" class="text_Brown_10pt_bold" Text="<%$ Resources:Master, lbl_manuscript_Transcribing_place %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trplace" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="copy_place" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr_copier" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label14" runat="server" class="text_Brown_10pt_bold" Text="<%$ Resources:Master, lbl_manuscript_Transcriber %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcopier" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="copier" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr_date" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label24" runat="server" class="text_Brown_10pt_bold" Text="<%$ Resources:Master, lbl_manuscript_Transcribing_date %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trdates" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="copy_date" runat="server"></asp:Label>&nbsp;&nbsp;
                            <asp:Label ID="lbl_copy_date_type" runat="server"></asp:Label>
                            <asp:RadioButtonList ID="copy_date_type" runat="server" RepeatDirection="Horizontal"
                                Visible="false">
                                <asp:ListItem Value="h" Text="<%$Resources:Master, timeline_h %>"></asp:ListItem>
                                <asp:ListItem Value="m" Text="<%$Resources:Master, timeline_m %>"></asp:ListItem>
                            </asp:RadioButtonList>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr14" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label37" runat="server" Text="<%$ Resources:Master, lbl_ruler %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trruler" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="ruler" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div id="accordion">
                    <div class="accordion_title" id="tr8" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                            <asp:Label ID="Label25" runat="server" Text="<%$ Resources:Master, lbl_copyStatus %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcopystate" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:RadioButtonList ID="copy_state" runat="server" Visible="false" DataTextField="title_ar"
                                DataValueField="id">
                            </asp:RadioButtonList>
                            <asp:Label ID="lbl_copy_state" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr9" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                            <asp:Label ID="Label27" runat="server" Text="<%$ Resources:Master, lbl_manuscriptGroupNo %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trgroupno" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="collection_no" runat="server"></asp:Label>
                        </span>
                    </div>

                    

                    <div class="accordion_title" id="tr11" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                            <asp:Label ID="Label31" runat="server" Text="<%$ Resources:Master, lbl_partsNo %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trpartno" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="parts_no" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr12" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img3"  src="../img/plus.jpg" onclick="toggle('img3')" alt="">
                            <asp:Label ID="Label32" runat="server" Text="<%$ Resources:Master, lbl_mogalad %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trfolderno" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="folders_no" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr10" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img4"  src="../img/plus.jpg" onclick="toggle('img4')" alt="">
                            <asp:Label ID="Label28" runat="server" Text="<%$ Resources:Master, lbl_manuscript_papers %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trfromto" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Label29" runat="server" Text="<%$Resources:Master, timeline_mdatefrom %>"></asp:Label>
                            <asp:Label ID="papers_from" runat="server"></asp:Label><br />
                            <asp:Label ID="Label30" runat="server" Text="<%$Resources:Master, timeline_mdateto %>"></asp:Label>
                            <asp:Label ID="papers_to" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr13" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img5"  src="../img/plus.jpg" onclick="toggle('img5')" alt="">
                            <asp:Label ID="Label33" runat="server" Text="<%$ Resources:Master, lbl_manuscriptSize %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trlength" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Label34" runat="server" Text="<%$Resources:Master, lbl_length %>"></asp:Label>
                            <asp:Label ID="length" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="Label35" runat="server" Text="<%$Resources:Master, lbl_width %>"></asp:Label>
                            <asp:Label ID="width" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="Label36" runat="server" Text="<%$Resources:Master, lbl_somk %>"></asp:Label>
                            <asp:Label ID="height" runat="server"></asp:Label>
                        </span>
                    </div>



                    <div class="accordion_title" id="tr15" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img6"  src="../img/plus.jpg" onclick="toggle('img6')" alt="">
                            <asp:Label ID="Label38" runat="server" Text="<%$ Resources:Master, lbl_copyContains %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcopycontains" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:CheckBoxList ID="copy_contains" runat="server" Visible="false" DataTextField="title_ar"
                                DataValueField="id">
                            </asp:CheckBoxList>
                            <asp:Label ID="lbl_copy_contains" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr16" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img7"  src="../img/plus.jpg" onclick="toggle('img7')" alt="">
                            <asp:Label ID="Label40" runat="server" Text="<%$ Resources:Master, lbl_fontType %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trfonttype" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:RadioButtonList ID="font_type" runat="server" RepeatDirection="Horizontal" RepeatColumns="3"
                                Visible="false">
                                <asp:ListItem Value="1">معتاد</asp:ListItem>
                                <asp:ListItem Value="2">رقعة</asp:ListItem>
                                <asp:ListItem Value="3">نسخ</asp:ListItem>
                                <asp:ListItem Value="4">تعليق</asp:ListItem>
                                <asp:ListItem Value="5">مغربي</asp:ListItem>
                                <asp:ListItem Value="6">ديواني</asp:ListItem>
                                <asp:ListItem Value="7">كوفي</asp:ListItem>
                                <asp:ListItem Value="8">ثلث</asp:ListItem>
                                <asp:ListItem Value="9">فارسي</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:Label ID="lbl_font_type" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr17" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img8"  src="../img/plus.jpg" onclick="toggle('img8')" alt="">
                            <asp:Label ID="Label42" runat="server" Text="<%$ Resources:Master, lbl_copyHas %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcopyhas" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:CheckBoxList ID="copy_has" runat="server" RepeatDirection="Horizontal" DataTextField="title_ar"
                                DataValueField="id" Visible="false">
                            </asp:CheckBoxList>
                            <asp:Label ID="lbl_copy_has" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr18" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img9"  src="../img/plus.jpg" onclick="toggle('img9')" alt="">
                            <asp:Label ID="Label22" runat="server" Text="<%$ Resources:Master, lbl_manuscript_Preface %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trintro" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="introduction" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr19" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img10"  src="../img/plus.jpg" onclick="toggle('img10')" alt="">
                            <asp:Label ID="Label44" runat="server" Text="<%$ Resources:Master, lbl_manuscript_Conclusion %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trconclusion" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="conclusion" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr20" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img11"  src="../img/plus.jpg" onclick="toggle('img11')" alt=""/>
                            <asp:Label ID="Label45" runat="server" Text="<%$ Resources:Master, lbl_manuscript_Place_preservation %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="Tr21" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Label46" runat="server" Text="<%$Resources:Master, lbl_manuscript_Place_preservation_country %>"></asp:Label>
                            &nbsp;<asp:Label ID="country" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="Label47" runat="server" Text="<%$Resources:Master, lbl_manuscript_Place_preservation_City %>"></asp:Label>
                            &nbsp;<asp:Label ID="town" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr119" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img12"  src="../img/plus.jpg" onclick="toggle('img12')" alt=""/>
                            <asp:Label ID="Label48" runat="server" Text="<%$ Resources:Master, lbl_saveno %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="saveorg" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Label49" runat="server" Text="<%$Resources:Master, lbl_generalNo%>"></asp:Label>
                            <asp:Label ID="general_no" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="Label5" runat="server" Text="<%$Resources:Master, lbl_generalNo%>"></asp:Label>
                            <asp:Label ID="Label6" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="Label50" runat="server" Text="<%$Resources:Master, lbl_privateNo%>"></asp:Label>
                            <asp:Label ID="special_no" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="Label51" runat="server" Text="<%$Resources:Master, lbl_art%>"></asp:Label>
                            <asp:Label ID="the_art" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="Label52" runat="server" Text="<%$Resources:Master, lbl_privateLib%>"></asp:Label>
                            <asp:Label ID="special_lib" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="trnotes" runat="server" dir="<%$ Resources:Master, dir %>">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img13"  src="../img/plus.jpg" onclick="toggle('img13')" alt=""/>
                            <asp:Label ID="Label53" runat="server" Text="<%$ Resources:Master, lbl_manuscript_notes %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="tr120" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="notes" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tregaza" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img14"  src="../img/plus.jpg" onclick="toggle('img14')" alt="">
                            <asp:Label ID="Label54" runat="server" Text="<%$ Resources:Master, lbl_allowanceType %>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trlicense" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:RadioButtonList ID="license_type" runat="server" Visible="false" DataTextField="title_ar"
                                DataValueField="id">
                            </asp:RadioButtonList>
                            <asp:Label ID="lbl_license_type" runat="server"></asp:Label>
                            <asp:Label ID="Label55" runat="server" Text="<%$Resources:Master, lbl_another %>"
                                Visible="False"></asp:Label>
                            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="other_license_type" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="trolddates" runat="server">
                        <span class="text_Dark_Brown_10pt">
                        <img id="img15"  src="../img/plus.jpg" onclick="toggle('img15')" alt="">
                            <asp:Label ID="Label56" runat="server" Text="<%$ Resources:Master, lbl_oldestAllowanceDate %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </span>
                    </div>
                    <div class="accordion_body" id="troldest" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="oldest_license_date_m" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="oldest_license_date_h" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="trsamaa" runat="server">
                        <span class="text_Dark_Brown_10pt">
                        <img id="img16"  src="../img/plus.jpg" onclick="toggle('img16')" alt="">                        
                            <asp:Label ID="Label59" runat="server" Text="<%$ Resources:Master, lbl_Hearings %>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </span>                       
                    </div>
                    <div class="accordion_body" id="trhearings" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:RadioButtonList ID="listinging" runat="server" RepeatDirection="Horizontal"  
                                Visible="false">
                                <asp:ListItem Value="1" Text="نعم"></asp:ListItem>
                                <asp:ListItem Value="2" Text="لا"></asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:Label ID="lbl_listinging" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="troldhearings" runat="server">
                        <span class="text_Dark_Brown_10pt">
                        <img id="img17"  src="../img/plus.jpg" onclick="toggle('img17')" alt="">
                            <asp:Label ID="Label62" runat="server" Text="<%$ Resources:Master, lbl_oldsetHearingsDate %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </span>
                    </div>
                    <div class="accordion_body" id="troldhearingsdate" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="listinging_date_m" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="listinging_date_h" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr1" runat="server">
                        <span class="text_Dark_Brown_10pt">
                        <img id="img18"  src="../img/plus.jpg" onclick="toggle('img18')" alt="">
                            <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Master, Acquisitions %>" class="text_Brown_10pt_bold"></asp:Label>
                        </span>
                    </div>
                    <div class="accordion_body" id="trgid1" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:GridView ID="TamalokatGridView" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                ForeColor="#333333" GridLines="None" AllowPaging="True" DataKeyNames="id" Width="100%">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <RowStyle BackColor="#F6F2E2" />
                                <Columns>
                                    <asp:BoundField DataField="tmlkat_name" HeaderText="<%$ Resources:Master, name%>" ItemStyle-HorizontalAlign="Center"
                                        HeaderStyle-HorizontalAlign="Center" SortExpression="tmlkat_name">
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tmlkat_name_en" HeaderText="<%$ Resources:Master, name%>" ItemStyle-HorizontalAlign="Center"
                                        HeaderStyle-HorizontalAlign="Center" SortExpression="tmlkat_name">
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tmlkat_name_fr" HeaderText="<%$ Resources:Master, name%>" ItemStyle-HorizontalAlign="Center"
                                        HeaderStyle-HorizontalAlign="Center" SortExpression="tmlkat_name">
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tmlkat_date" HeaderText="<%$ Resources:Master, The date of acquisition %>" ItemStyle-HorizontalAlign="Center"
                                        HeaderStyle-HorizontalAlign="Center" SortExpression="tmlkat_date">
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                </Columns>
                                <PagerStyle BackColor="#D9C69E" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" HorizontalAlign="Right" />
                            </asp:GridView>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr3" runat="server">
                        <span class="text_Dark_Brown_10pt">
                        <img id="img19"  src="../img/plus.jpg" onclick="toggle('img19')" alt="">
                            <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Master, Endowments%>" class="text_Brown_10pt_bold"></asp:Label>
                        </span>
                    </div>
                    <div class="accordion_body" id="tr_grid_tawfikat" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:GridView ID="TawfikatGridView" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                ForeColor="#333333" GridLines="None" AllowPaging="True" DataKeyNames="id" Width="100%">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <RowStyle BackColor="#F6F2E2" />
                                <Columns>
                                    <asp:BoundField DataField="tawkifat_name" HeaderText="<%$ Resources:Master, name%>" ItemStyle-HorizontalAlign="Center"
                                        HeaderStyle-HorizontalAlign="Center" SortExpression="tawkifat_name">
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tawkifat_name_en" HeaderText="<%$ Resources:Master, name%>" ItemStyle-HorizontalAlign="Center"
                                        HeaderStyle-HorizontalAlign="Center" SortExpression="tawkifat_name">
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tawkifat_name_fr" HeaderText="<%$ Resources:Master, name%>" ItemStyle-HorizontalAlign="Center"
                                        HeaderStyle-HorizontalAlign="Center" SortExpression="tawkifat_name">
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tawkifat_date" HeaderText="<%$ Resources:Master, The date of Endowments %>" ItemStyle-HorizontalAlign="Center"
                                        HeaderStyle-HorizontalAlign="Center" SortExpression="tawkifat_date">
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                </Columns>
                                <PagerStyle BackColor="#D9C69E" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" HorizontalAlign="Right" />
                            </asp:GridView>
                        </span>
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
