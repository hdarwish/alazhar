<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="tvaudioDetailss.aspx.cs" Inherits="media_tvaudioDetailss" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <input id="HiddenID" type="hidden" runat="server" />
    <table id="Table1" dir="<%$ Resources:Master, dir%>" runat="server" width="100%"
        border="0">
        <tr>
            <td  colspan="2">
                <p runat="server" id="frame_url" style="text-align: right">
                <iframe id="vidframe" runat="server" width="400" height="315"  frameborder="0" allowfullscreen></iframe>
                </p>
            </td>
        </tr>
        <tr>
            <td  colspan="2">
                
                    <div class="accordion_title" id="tr_title" runat="server">
                        <span class="text_Dark_Brown_10pt"><asp:Label class="text_Brown_10pt_bold" ID="lblfromtitle" runat="server"></asp:Label></span>
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label9" runat="server" Text="<%$ Resources:Master, lbl_Recording_title %>"
                                class="text_Brown_10pt_bold" Visible="False"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>
                    
                    <div class="accordion_title" id="tr_title2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label24" runat="server" Text="<%$ Resources:Master, workType %>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trworkType" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblworkType" runat="server"></asp:Label>
                        </span>
                    </div>

                    

                    <div class="accordion_title" id="Tr2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label71" runat="server" Text="<%$Resources:Master, lbl_Recording_Title_number_episode %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trname" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblnameanddesc" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr6" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label72" runat="server" Text="<%$Resources:Master, duration%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trduration" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="label155" runat="server" Text="<%$Resources:Master, Minutes%>"></asp:Label>
                            <asp:Label ID="lblMin" runat="server" Font-Bold="True"></asp:Label>
                            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, second%>"></asp:Label>
                            <asp:Label ID="lblSec" runat="server" Font-Bold="True"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_place" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, lbl_Recording_Guests_Post %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trguestName" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblguestName" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_copier" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label23" runat="server" Text="<%$Resources:Master, lbl_Recording_Guests_position %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trguestTitle" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblguesttitle" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_date" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label15" runat="server" Text="<%$ Resources:Master, lbl_Recording_Broadcaster_interviewer %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trintroName" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblCommenterName" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr8" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label11" runat="server" Text="<%$ Resources:Master, recDate %>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trDate" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Label7" runat="server" Text="هجرى :" Height="23px"></asp:Label>
                            <asp:Label ID="lblHijriDate" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="Label8" runat="server" Text="ميلادى :" Height="23px"></asp:Label>
                            <asp:Label ID="lblGorgDate" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr10" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label32" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_name %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trsourcaName" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblsourceName" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="trcountry2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label14" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_country%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trCountry" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblcountry" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr1" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="label455" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_city %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trCity" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblCity" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr12" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label33" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_Book_shelving_no %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trsaveNo" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblsaveNo" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div id="accordion">
                    <div class="accordion_title" id="Tr5" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                            <asp:Label ID="Label25" runat="server" Text="<%$Resources:Master, lbl_Recording_Description%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trworkDesc" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbldesc" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr13" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                         <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                            <asp:Label ID="Label37" runat="server" Text="<%$Resources:Master, lbl_Recording_Source_notes %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trmeasure" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblsNotes" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr14" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                         <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                            <asp:Label ID="Label38" runat="server" Text="<%$Resources:Master, lbl_Recording_notes %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trNotes" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblNotes" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr15" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                         <img id="img3"  src="../img/plus.jpg" onclick="toggle('img3')" alt="">
                            <asp:Label ID="Label40" runat="server" Text="<%$Resources:Master, Time%> " CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trelement" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblElemnt" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr4" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                         <img id="img4"  src="../img/plus.jpg" onclick="toggle('img4')" alt="">
                            <asp:Label ID="Label3" runat="server" Text="<%$Resources:Master, Notes About Recoding Time%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trgeneralNotes" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblTimelineNotes" runat="server"></asp:Label>
                        </span>
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
