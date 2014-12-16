<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="thesesDetails.aspx.cs" Inherits="Elzakera_thesesDetails" Title="ذاكرة الأزهر" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
   <script language="javascript">

       function toggle(image_name) {
           var images = new Array();
           images[0] = "img0";
           images[1] = "img1";
      
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
    <input id="HiddenID2" type="hidden" runat="server" />
    <table id="Table1" dir="<%$ Resources:Master, dir%>" runat="server" width="100%">
        <tr>
            <td align="right" dir="rtl" colspan="2" runat="server">
                                    
                    <div class="accordion_title" id="tr9" runat="server" >
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Labtitle" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                            </span>
                    </div>
                     <div class="accordion_body_empty">
                        <span class="text_Dark_Brown_10pt"></span>
                    </div>

                    <div class="accordion_title" id="Tr5" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, searcher_name%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body_empty" id="trauthfromtit" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="author" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="Tr7" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, supervisior %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trsupervisor" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_supervisior" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="Tr2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label23" runat="server" Text="<%$Resources:Master, supermoshark%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trsupervisor1" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_super" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="Tr4" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label3" runat="server" Text="<%$Resources:Master, supermoshark%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trsupervisor2" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_supervisor2" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr3" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, theses_type%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trthesestype" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="theses_type" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr10" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master, page_no%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trgroupno" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="collection_no" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr6" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label15" runat="server" Text="<%$Resources:Master, theses_lang%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trlang" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:RadioButtonList ID="man_lang" runat="server" RepeatDirection="Horizontal" DataTextField="title_ar"
                                DataValueField="id" Visible="false">
                            </asp:RadioButtonList>
                            <asp:Label ID="lbl_man_lang" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="trunversity" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, university%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="tr12" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_unversity" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr13" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label5" runat="server" Text="<%$Resources:Master, elkasm%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trsection" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_section" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr155" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label6" runat="server" Text="<%$Resources:Master, elkolia%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcollage" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_collage" runat="server"></asp:Label></span>
                    </div>

                    <div id="accordion">

                    <div class="accordion_title" id="tr_date" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                            <asp:Label ID="Label24" runat="server" Text="<%$ Resources:Master, lbl_manuscript_Transcribing_date %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trdates" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_copy_date_type" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr120" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                            <asp:Label ID="Label53" runat="server" Text="<%$ Resources:Master, lbl_manuscript_notes %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trnotes" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="notes" runat="server"></asp:Label></span>
                    </div>
                </div>                
            </td>
        </tr>
    </table>
</asp:Content>
