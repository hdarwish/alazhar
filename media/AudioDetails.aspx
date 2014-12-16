<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="AudioDetails.aspx.cs" Inherits="Media_AudioDetails" Title="ذاكرة الأزهر" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
 <script language="javascript">

     function toggle(image_name) {
         var images = new Array();
         images[0] = "img0";
         images[1] = "img1";
         images[2] = "img2";
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
   
    <table id="Table1" dir="<%$ Resources:Master, dir%>" runat="server" width="100%" border="0">
        <tr>
            <td align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" runat="server" colspan="2">
                    <p runat="server" id="frame_url" style=" text-align: right">
                     <iframe id="audframe" runat="server" width="400" height="315"  frameborder="0" allowfullscreen></iframe>
                     </p>
            </td>
        </tr>
        <tr>
            <td align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" runat="server" colspan="2">
               
                  
                    <%--<div class="accordion_body_empty" id="Div2" runat="server">
                        <span class="text_Dark_Brown_10pt"></span>
                    </div>--%>
                    <div class="accordion_title" id="tr_title" runat="server">
                        <a href="#" class="text_Brown_10pt_bold" >
                            <asp:Label ID="Label9" runat="server" class="text_Brown_10pt_bold" ></asp:Label>
                        </a>
                    </div>  
                    <%--Text="<%$Resources:Master, lbl_Recording_title%>"--%>
                    <%-- id="traudiotit" runat="server">--%>
                    <div class="accordion_body_empty" >
                        <span class="text_Dark_Brown_10pt">
                          <%--  <asp:Label ID="audio_title" runat="server"></asp:Label>--%>
                        </span>
                    </div>



                    <%--<div class="accordion_title" id="trname" runat="server" >
                            <a href="#" class="text_Brown_10pt_bold">
                                <asp:Label ID="txt_name" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>--%>
                        <%--<div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>--%>



                    <div class="accordion_title" id="Tr5" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, recording_type%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcatagory" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="catagory" runat="server"></asp:Label>
                        </span>
                    </div>

                   
                    <div class="accordion_title" id="Tr2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label23" runat="server" Text="<%$Resources:Master, lbl_Recording_Title_number_episode%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="treposideno" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_eposideno" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="Tr4" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label3" runat="server" Text="<%$Resources:Master, duration%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trperiod" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="period" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr3" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, lbl_Recording_Guests_Post %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trguest" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="guest_name" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr10" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master, lbl_Recording_Guests_position %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trguestpos" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="guesst_position" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr6" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label15" runat="server" Text="<%$Resources:Master, lbl_Recording_Broadcaster_interviewer %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trinterviwer" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="interviwer_name" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="trrecorddate2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, recorded_radio%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trrecorddata" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_recorddatem" runat="server"></asp:Label>
                            <asp:Label ID="txt_recorddateh" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr13" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label5" runat="server" Text="<%$ Resources:Master, lbl_Recording_Source %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trresource" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_resource" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr15" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label6" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_name %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trresourcename" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_resourcename" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="trcountry2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label24" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_country %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcountry" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_sourcecountry" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="trsourcecity" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label7" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_city %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcity" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_city" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="trsaveno" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label10" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_Book_shelving_no %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trsaveno2" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Lab_saveno" runat="server"></asp:Label>
                        </span>
                    </div>

                     <div id="accordion">

                     <div class="accordion_title" id="Tr7" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                            <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, lbl_Recording_Description %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trdescrption" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_descrption" runat="server"></asp:Label>
                        </span>
                    </div>


                    <div class="accordion_title" id="trresourcenotes" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                            <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_notes %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trresourcenotes2" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Lab_res_notes" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr120" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                            <asp:Label ID="Label53" runat="server" Text="<%$ Resources:Master, lbl_Recording_notes %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trnotes" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="notes" runat="server"></asp:Label>
                        </span>
                    </div>
                </div>
            </td>
        </tr>
    </table>
     <%--<script language="javascript" type="text/javascript">
         $("#accordion").accordion({ active: 2 });
    </script>--%>
</asp:Content>
