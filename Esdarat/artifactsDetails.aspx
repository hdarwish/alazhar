<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masterpage/InnerMaster.master"
    CodeFile="artifactsDetails.aspx.cs" Inherits="Esdarat_artifactsDetails2" %>

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
        <table cellpadding="0" cellspacing="0"  style="width: 100%" border="0"  runat="server"  id="tblchar" dir="<%$Resources:Master, dir%>">
            <tr>
                <td colspan="4" align="<%$Resources:Master, align%>"  runat="server">
                    
                        <div class="accordion_title" id="trname" runat="server">
                            <a href="#" class="text_Brown_10pt_bold">
                                <asp:Label ID="Labtitle" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty"  >
                            <span class="text_Dark_Brown_10pt"></span> 
                        </div>

                        <div class="accordion_title" id="TDname_maker" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                                <asp:Label ID="Label34" runat="server" Text="<%$ Resources:Master, name_maker %>"
                                    class="text_Brown_10pt_bold">
                                </asp:Label>
                                <asp:Label ID="txt_maker" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty" id="TDtxt_maker" runat="server">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div class="accordion_title" id="TDtrtype" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                                <asp:Label ID="Label26" runat="server" Text="<%$ Resources:Master, key_Asset_Type %>" class="text_Brown_10pt_bold">
                                </asp:Label>
                                <asp:Label ID="drop_style" runat="server"> </asp:Label>
                                <asp:DropDownList ID="drop_style_ddl" runat="server" DataTextField="title_ar" DataValueField="id"
                                    Visible="False">
                                </asp:DropDownList>
                            </a>
                        </div>
                        <div class="accordion_body_empty" id="TDdrop_style" runat="server">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div class="accordion_title" id="TDtrcolor" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                                <asp:Label ID="Label27" runat="server" Text="<%$ Resources:Master, key_Color %>" class="text_Brown_10pt_bold">
                                </asp:Label>
                                <asp:Label ID="drop_color" runat="server"> </asp:Label>
                                <asp:DropDownList ID="drop_color_ddl" runat="server" DataTextField="title_ar" DataValueField="id"
                                    Visible="False">
                                </asp:DropDownList>
                            </a>
                        </div>
                        <div class="accordion_body_empty" id="TDdrop_color" runat="server">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div class="accordion_title" id="TDtrtechinque" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                                <asp:Label ID="Label6" runat="server" Text="<%$ Resources:Master, key_technique %>" class="text_Brown_10pt_bold">
                                </asp:Label>
                                <asp:Label ID="drop_techinque" runat="server"> </asp:Label>
                                <asp:DropDownList ID="drop_techinque_ddl" runat="server" DataValueField="id" DataTextField="title_ar"
                                    Visible="False">
                                </asp:DropDownList>
                            </a>
                        </div>
                        <div class="accordion_body_empty" id="TDdrop_techinque" runat="server">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div class="accordion_title" id="TDtrraw" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                                <asp:Label ID="Label28" runat="server" Text="<%$ Resources:Master, key_Hull_Material %>" class="text_Brown_10pt_bold">
                                </asp:Label>
                                <asp:Label ID="drop_raw" runat="server"> </asp:Label>
                                <asp:DropDownList ID="drop_raw_ddl" runat="server" DataValueField="id" DataTextField="title_ar"
                                    Visible="False">
                                </asp:DropDownList>
                            </a>
                        </div>
                        <div class="accordion_body_empty" id="TDdrop_raw" runat="server">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>
                        <div id="accordion">
                        <div class="accordion_title" id="TDtrdimension" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                             <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                                <asp:Label ID="Label3" runat="server" Text="<%$ Resources:Master, key_Dimensions %>" class="text_Brown_10pt_bold">
                                </asp:Label>
                                <asp:Label ID="Label36" runat="server" Text="<%$ Resources:Master, Key_Length %>" class="text_Dark_Brown_10pt"
                                    Width="50px"></asp:Label>
                                <asp:Label ID="Label37" runat="server" Text="<%$ Resources:Master, Key_Display %>" class="text_Dark_Brown_10pt"
                                    Width="50px"></asp:Label>
                                <asp:Label ID="Label38" runat="server" Text="<%$ Resources:Master, key_Rise %>" class="text_Dark_Brown_10pt"
                                    Width="50px"></asp:Label>
                                <asp:Label ID="Label39" runat="server" Text="<%$ Resources:Master, key_Distance %>" class="text_Dark_Brown_10pt"
                                    Width="50px"></asp:Label>
                                <asp:Label ID="Label40" runat="server" Text="<%$ Resources:Master, key_Ocean %>" class="text_Dark_Brown_10pt"
                                    Width="50px"></asp:Label>
                                <asp:Label ID="Label41" runat="server" Text="<%$ Resources:Master, key_Weight %>" class="text_Dark_Brown_10pt"
                                    Width="50px"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body2" id="Dimension" runat="server">
                            <span class="text_Dark_Brown_10pt">&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                                <asp:Label ID="txt_length" runat="server" Width="45px"></asp:Label>
                                <asp:Label ID="txt_width" runat="server" Width="45px"></asp:Label>
                                <asp:Label ID="txt_height" runat="server" Width="45px"></asp:Label>
                                <asp:Label ID="txt_dimater" runat="server" Width="45px"></asp:Label>
                                <asp:Label ID="txt_perimeter" runat="server" Width="45px"></asp:Label>
                                <asp:Label ID="txt_wight" runat="server" Width="20px"></asp:Label>
                            </span>
                        </div>

                        <div class="accordion_title" id="Div1" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                             <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                                <asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, Key_Video_museum%>" class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body2" id="Div2" runat="server" >
                            <span class="text_Dark_Brown_10pt" runat="server" id="flashdiv">
                               </span>
                        </div>                


                        <div class="accordion_title" id="Tdb_desc" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                             <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                                <asp:Label ID="Label32" runat="server" Text="<%$ Resources:Master, b_desc %>" class="text_Brown_10pt_bold"></asp:Label>
                             
                            </a>
                        </div>
                        <div class="accordion_body" id="Tdbrief_desc" runat="server">
                            <span class="text_Dark_Brown_10pt"></span>
                               <asp:Label ID="brief_desc" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label>
                        </div>

                        <div class="accordion_title" id="Tddetails_desc" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                             <img id="img3"  src="../img/plus.jpg" onclick="toggle('img3')" alt="">
                                <asp:Label ID="Label33" runat="server" Text="<%$ Resources:Master, details_desc %>"
                                    class="text_Brown_10pt_bold">
                                </asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body2" id="Tddetails_desc2" runat="server">
                            <span class="text_Dark_Brown_10pt">
                            <a href="#" class="text_Brown_10pt" style="text-decoration: none;">
                                <asp:Label ID="details_desc" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label>
                            </a>
                            </span>
                        </div>

                        <div class="accordion_title" id="TDtrdimater" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                             <img id="img4"  src="../img/plus.jpg" onclick="toggle('img4')" alt="">
                                <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Master, key_Date_manufacture_configuration %> " class="text_Brown_10pt_bold">
                                </asp:Label>
                                <asp:Label ID="txt_hdate" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                                <asp:Label ID="Label18" runat="server" Text="هـ" class="text_Brown_10pt_bold"></asp:Label>
                                <asp:Label ID="txt_date" runat="server"></asp:Label>
                                <asp:Label ID="Label19" runat="server" Text="م" class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty" id="trdimater" runat="server">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div class="accordion_title" id="TDtrorg" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                             <img id="img5"  src="../img/plus.jpg" onclick="toggle('img5')" alt="">
                                <asp:Label ID="Label20" runat="server" Text="<%$ Resources:Master, source_side %>"
                                    class="text_Brown_10pt_bold">
                                </asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body2" id="trorg" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="Label21" runat="server" Text="<%$Resources:Master, source_side%>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                                <asp:Label ID="txt_org" runat="server"></asp:Label>
                                <asp:Label ID="Label22" runat="server" Text="<%$Resources:Master, org_country%>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                                <asp:Label ID="txt_country" runat="server"></asp:Label>
                                <asp:Label ID="Label23" runat="server" Text="<%$Resources:Master, org_city%>" class="text_Brown_10pt_bold"></asp:Label>
                                &nbsp;<asp:Label ID="txt_city" runat="server"></asp:Label>
                                <asp:Label ID="Label24" runat="server" Text="<%$Resources:Master, org_no%>" class="text_Brown_10pt_bold"></asp:Label>
                                <asp:Label ID="txt_save_no" runat="server"></asp:Label>
                                <asp:Label ID="Label25" runat="server" Text="<%$Resources:Master, org_notes%>" class="text_Brown_10pt_bold"></asp:Label>
                                <asp:Label ID="txt_org_notes" runat="server"></asp:Label>
                            </span>
                        </div>

                        <div class="accordion_title" id="Tdtrnotes" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                             <img id="img6"  src="../img/plus.jpg" onclick="toggle('img6')" alt="">
                                <asp:Label ID="Label12" runat="server" Text="<%$ Resources:Master, c_notes %>" class="text_Brown_10pt_bold">
                                </asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body2" id="trnotes" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_notes" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label></span>
                        </div>

                        <div class="accordion_title" id="TDtrtags" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                             <img id="img7"  src="../img/plus.jpg" onclick="toggle('img7')" alt="">
                                <asp:Label ID="Label13" runat="server" Text="<%$ Resources:Master, c_tags %>" class="text_Brown_10pt_bold">
                                </asp:Label>
                            </a>
                        </div>
                        <div class=".accordion_body_enfr" id="trtags" runat="server" align="<%$Resources:Master, align%>" >
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txt_tags" Width="100%" TextMode="MultiLine" runat="server" class="text_Dark_Brown_10pt"
                                    align="<%$Resources:Master, align%>" >
                                </asp:Label></span>
                        </div>

                        <div class="accordion_title" id="TDtrperiods" runat="server">
                            <a href="#" class="text_Brown_10pt_bold" style="text-decoration: none;">
                             <img id="img8"  src="../img/plus.jpg" onclick="toggle('img8')" alt="">
                                <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, key_eat_museum%>"
                                    class="text_Brown_10pt_bold">
                                </asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body2" id="trperiods" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="lbl_chk_periods" runat="server"></asp:Label>
                                <asp:CheckBoxList ID="chk_periods" runat="server" RepeatDirection="Horizontal" RepeatColumns="4"
                                    DataTextField="title" DataValueField="id" Visible="false">
                                </asp:CheckBoxList>
                            </span>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <%-- <script language="javascript" type="text/javascript">
         $("#accordion").accordion({ active: 2 });
    </script>--%>
</asp:Content>
