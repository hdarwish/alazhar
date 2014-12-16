<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master"
    AutoEventWireup="true" CodeFile="characterdetails.aspx.cs" Inherits="sheikhs_characterdetails" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
    <div>
        <table cellpadding="0" style="width: 100%" border="0" cellspacing="0" runat="server"
            id="tblchar" dir="<%$ Resources:Master, dir%>">
            <tr>
                <td>
                    
                        <div class="accordion_title" id="trname" runat="server" >
                            <a href="#" class="text_Brown_10pt_bold">
                                <asp:Label ID="txt_name" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div class="accordion_title" id="trhbirthdate" runat="server" >
                            <a href="#" class="text_Brown_10pt_bold" >
                                <asp:Label ID="Label9" runat="server" Text="<%$ Resources:Master, birthdate%>" class="text_Brown_10pt_bold"></asp:Label>
                                <asp:Label ID="txt_hbirth_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                                <asp:Label ID="Label11" runat="server" Text="<%$ Resources:Master, timeline_h%>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                                &nbsp - &nbsp
                                <asp:Label ID="txt_birth_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                                <asp:Label ID="Label12" runat="server" Text="<%$ Resources:Master, timeline_m%>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div class="accordion_title" id="trhdeathdate" runat="server" >
                            <a href="#" class="text_Brown_10pt_bold">
                                <asp:Label ID="Label10" runat="server" Text="<%$ Resources:Master, deathdate%>" class="text_Brown_10pt_bold"></asp:Label>
                                <asp:Label ID="txt_hdeath_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                                <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Master, timeline_h%>" class="text_Brown_10pt_bold"></asp:Label>
                                &nbsp - &nbsp
                                <asp:Label ID="txt_death_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                                <asp:Label ID="Label13" runat="server" Text="<%$ Resources:Master, timeline_m%>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div class="accordion_title" id="trchartype" runat="server" >
                            <a href="#" class="text_Brown_10pt_bold">
                                <asp:Label ID="Label4" runat="server" Text="<%$ Resources:Master, chartype%>" class="text_Brown_10pt_bold"></asp:Label>
                                <asp:Label ID="lbl_char_type" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label>
                                <asp:RadioButtonList ID="rad_char_type" runat="server" RepeatDirection="Horizontal"
                                    DataTextField="<%$ Resources:Master, DBtitle%>" DataValueField="id" Visible="false">
                                </asp:RadioButtonList>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div class="accordion_title" id="trshohra" runat="server" >
                            <a href="#" class="text_Brown_10pt_bold">
                                <asp:Label ID="Label6" runat="server" Text="<%$ Resources:Master, Lbl_character_nick_name %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div class="accordion_title" id="trothername" runat="server" >
                            <a href="#" class="text_Brown_10pt_bold">
                                <asp:Label ID="txt_other_name" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        
                        <div class="accordion_title" id="tral2ab" runat="server" >
                            <a href="#" class="text_Brown_10pt_bold">
                                <asp:Label ID="Label8" runat="server" Text=" <%$ Resources:Master, Lbl_character_Titles %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>
                        
                        
                        <div class="accordion_title" id="trtitles" runat="server" >
                            <a href="#" class="text_Brown_10pt_bold">
                                <asp:Label ID="txt_titles" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div id="accordion">
                        <div class="accordion_title" id="trnabtha" runat="server"   >
                            <a href="#" class="text_Brown_10pt_bold">
                            <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                                <asp:Label ID="Label14" runat="server" Text="<%$ Resources:Master, Lbl_character_Abrief_description %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="trdetails" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_char_details" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label>
                            </span>
                        </div>

                        <div class="accordion_title" id="trnash2a" runat="server"   >
                            <a href="#" class="text_Brown_10pt_bold">
                            <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                                <asp:Label ID="Label15" runat="server" Text="<%$ Resources:Master, Lbl_character_Birth_upbringing %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="trbdetails" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_birth_details" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label>
                            </span>
                        </div>

                        <div class="accordion_title" id="trsci" runat="server"   >
                            <a href="#" class="text_Brown_10pt_bold">
                            <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                                <asp:Label ID="Label16" runat="server" Text="<%$ Resources:Master, Lbl_character_Educational_cultural %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="trscientific" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_scientific_life" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label>
                            </span>
                        </div>

                        <div class="accordion_title" id="trworkin" runat="server"   >
                            <a href="#" class="text_Brown_10pt_bold">
                            <img id="img3"  src="../img/plus.jpg" onclick="toggle('img3')" alt="">
                                <asp:Label ID="Label17" runat="server" Text="<%$ Resources:Master, Lbl_character_Posts_Jobs_occupied %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="trworklife" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_working_life" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label></span>
                        </div>
                        
                        <div class="accordion_title" id="tracti" runat="server"   >
                            <a href="#" class="text_Brown_10pt_bold">
                            <img id="img4"  src="../img/plus.jpg" onclick="toggle('img4')" alt="">
                                <asp:Label ID="Label18" runat="server" Text="<%$ Resources:Master, Lbl_character_social_cultural_activities %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="tractivities" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_activities" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label></span>
                        </div>
                        
                        <div class="accordion_title" id="trmalm" runat="server"  >
                            <a href="#" class="text_Brown_10pt_bold" >
                            <img id="img5"  src="../img/plus.jpg" onclick="toggle('img5')" alt="">
                                <asp:Label ID="Label19" runat="server" Text="<%$ Resources:Master, Lbl_character_Awards %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>                        
                        <div class="accordion_body" id="trawsma" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_awesma" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label></span>
                        </div>
                        
                        <div class="accordion_title" id="trach" runat="server"   >
                            <a href="#" class="text_Brown_10pt_bold" >
                            <img id="img6"  src="../img/plus.jpg" onclick="toggle('img6')" alt="">
                                <asp:Label ID="Label20" runat="server" Text="<%$ Resources:Master, Lbl_character_Achievements %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>                        
                        <div class="accordion_body" id="trachieve" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_achiev" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label></span>
                        </div>

                        <div class="accordion_title" id="trsaid" runat="server"   >
                            <a href="#"  class="text_Brown_10pt_bold"  >
                            <img id="img7"  src="../img/plus.jpg" onclick="toggle('img7')" alt="">
                                <asp:Label ID="Label21" runat="server" Text="<%$ Resources:Master, Lbl_character_said_about_him  %>"
                                    class="text_Brown_10pt_bold" ></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="trwhtwritten" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_written_about" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label></span>
                        </div>

                        <div class="accordion_title" id="trn" runat="server"   >
                            <a href="#" class="text_Brown_10pt_bold">
                            <img id="img8"  src="../img/plus.jpg" onclick="toggle('img8')" alt="">
                                <asp:Label ID="Label22" runat="server" Text="<%$ Resources:Master, Lbl_character_Notes  %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="trnotes" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_notes" runat="server" class="text_Dark_Brown_10pt"></asp:Label></span>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    </a>
</asp:Content>
