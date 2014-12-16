<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="books_details.aspx.cs" Inherits="Esdarat_BooksDetails" Title="Untitled Page" %>
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
        images[8] = "img8";                //----------------------------------------no 10----------------------------------------------


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
      <table id="Table1" runat="server" width="100%" dir="<%$ Resources:Master, dir%>">
        <tr>
            <td align="<%$ Resources:Master, align%>" >
                                  
                    <div class="accordion_title" id="tr_fromtitle"  runat="server" >                        
                          <span class="text_Dark_Brown_10pt">                          
                           <asp:Label ID="lbl_fromtitle" runat="server" class="text_Brown_10pt_bold"></asp:Label>                       
                         </span>
                    </div> 
                    <div class="accordion_body_empty"  id="Div2" runat="server">
                        <span class="text_Dark_Brown_10pt"></span>                    
                    </div>   
                                    
                    <div class="accordion_title" id="tr_titleIntro" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label71" runat="server" Text="<%$ Resources:Master, lbl_titleFromIntro %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_titleIntro1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_fromheader" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_grid_name" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label15" runat="server" Text="<%$ Resources:Master, author%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_grid" >
                        <asp:GridView runat="server" ID="gview_moalf" Visible="false" AutoGenerateColumns="False"
                                        CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="id">
                                        <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" BorderWidth="0"
                                            HorizontalAlign="Center" Width="100%" />
                                        <Columns>
                                            <asp:BoundField DataField="name" ShowHeader="true" HeaderText="اسم المؤلف" ItemStyle-HorizontalAlign="Center"
                                                HeaderStyle-HorizontalAlign="Center" />
                                            <asp:BoundField DataField="name_ar" ShowHeader="true" HeaderText="<%$Resources:Master,txt_moalf%>"
                                                ItemStyle-HorizontalAlign="Center" ItemStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                                           <%-- <asp:BoundField DataField="name_ar" ShowHeader="true" HeaderText="<%$Resources:Master,txt_moalf%>"
                                                ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />--%>
                                            <asp:BoundField DataField="author_role" ShowHeader="true" HeaderText="دور المؤلف"
                                                ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                                            <asp:BoundField DataField="name_ar" ShowHeader="true" HeaderText="<%$Resources:Master,author_role%>"
                                                ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />    
                                        </Columns>
                                    </asp:GridView>
                                
                    </div>

                    <div class="accordion_title" id="tr_lang" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label18" runat="server" Text="<%$ Resources:Master, lbl_book_lang%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_lang2">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Lablang" runat="server" Text="English"></asp:Label>
                        </span>
                    </div>


                    <div class="accordion_title" id="tr_series" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label11" runat="server" Text="<%$ Resources:Master, Lbl_book_Series_name %>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_series1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_series" runat="server" Text=" "></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_seriesno" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label14" runat="server" Text="<%$ Resources:Master, Numbered in series %>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_seriesno1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_seriesno" runat="server" Text=""></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="printno" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label20" runat="server" Text="<%$ Resources:Master, Edition number %>" class="text_Brown_10pt_bold"> </asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="printno1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lblprintno" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_pageno" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label8" runat="server" Text="<%$ Resources:Master, Number of Pages %>" class="text_Brown_10pt_bold"> </asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_pageno1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="labpageno" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_partno" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label13" runat="server" Text="<%$ Resources:Master, Number of parts %>" class="text_Brown_10pt_bold"> </asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_partno1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_partno" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_folderno" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label10" runat="server" Text="<%$ Resources:Master, Number of folders %>" class="text_Brown_10pt_bold"> </asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_folderno1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="labfolderno" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div id="accordion" >
                    <div class="accordion_title" id="tr_pubtitle" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                         <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                            <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Master, Lbl_book_Publication_Publisher%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_pubtitle1">
                        <span class="text_Dark_Brown_10pt">
                            <table width="100%">
                                <tr runat="server" id="tr2" align="<%$Resources:Master, align%>">
                                    <td nowrap="nowrap" style="padding: 5px;">
                                        <asp:Label ID="Label19" Text="<%$Resources:Master, Name of publisher%>" runat="server"></asp:Label>
                                        <asp:Label ID="Labpubtitle" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr align="<%$Resources:Master, align%>" runat="server" id="tr_Location">
                                    <td nowrap="nowrap" style="padding: 5px;">
                                        <asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, Lbl_book_Publication_Place%>"></asp:Label>
                                        <asp:Label ID="labpubLocation" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr runat="server" id="tr_labdate">
                                    <td>
                                        <asp:Label ID="Label7" runat="server" Text="<%$Resources:Master, Lbl_book_Publication_year%>">
                                            <asp:Label ID="labdate" runat="server" Text=""></asp:Label>
                                        </asp:Label>
                                    </td>
                                </tr>
                                <tr runat="server" id="tr_labhdate">
                                    <td>
                                        <asp:Label ID="Label9" runat="server" Text="سنة النشر هـ:"></asp:Label>
                                        <asp:Label ID="labhdate" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </span>
                    </div>


                    <div class="accordion_title" id="tr20" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                            <asp:Label ID="Label45" runat="server" Text="<%$ Resources:Master, lbl_manuscript_Place_preservation %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="trsaveplace">
                        <span class="text_Dark_Brown_10pt">
                            <table width="100%">
                                <tr id="trsaveplace1" align="<%$Resources:Master, align%>" runat="server">
                                    <td nowrap="nowrap" style="padding: 5px;">
                                        <asp:Label ID="Label6" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_name%>"></asp:Label>
                                        &nbsp;<asp:Label ID="lbl_org_save" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr id="trsavecountry" align="<%$Resources:Master, align%>" runat="server">
                                    <td nowrap="nowrap" style="padding: 5px;">
                                        <asp:Label ID="Label46" runat="server" Text="<%$Resources:Master, lbl_manuscript_Place_preservation_country %>"></asp:Label>
                                        &nbsp;<asp:Label ID="country" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr id="trsaveCity" align="<%$Resources:Master, align%>" runat="server">
                                    <td nowrap="nowrap" style="padding: 5px;">
                                        <asp:Label ID="Label47" runat="server" Text="<%$Resources:Master, lbl_manuscript_Place_preservation_City %>"></asp:Label>
                                        &nbsp;<asp:Label ID="town" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr119" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                            <asp:Label ID="Label48" runat="server" Text="<%$ Resources:Master, lbl_saveno %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="saveorg">
                        <span class="text_Dark_Brown_10pt">
                            <table width="100%" cellspacing="0">
                                <tr runat="server" id="trgeneralno">
                                    <td class="style2" nowrap="nowrap" style="padding: 5px;">
                                        <asp:Label ID="Label49" runat="server" Text="<%$Resources:Master, lbl_generalNo%>"></asp:Label>
                                        <asp:Label ID="general_no" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr runat="server" id="trspecialno">
                                    <td class="style2" nowrap="nowrap" style="padding: 5px;">
                                        <asp:Label ID="Label50" runat="server" Text="<%$Resources:Master, lbl_privateNo%>"></asp:Label>
                                        <asp:Label ID="special_no" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr runat="server" id="trart">
                                    <td class="style2" nowrap="nowrap" style="padding: 5px;">
                                        <asp:Label ID="Label51" runat="server" Text="<%$Resources:Master, lbl_art%>"></asp:Label>
                                        <asp:Label ID="the_art" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr runat="server" id="splib">
                                    <td nowrap="nowrap" style="padding: 5px;">
                                        <asp:Label ID="Label52" runat="server" Text="<%$Resources:Master, lbl_privateLib%>"></asp:Label>
                                        <asp:Label ID="special_lib" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr12" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img3"  src="../img/plus.jpg" onclick="toggle('img3')" alt="">
                            <asp:Label ID="Label53" runat="server" Text="<%$ Resources:Master, lbl_manuscript_notes %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="trnotes">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="notes" runat="server" Text="<%$ Resources:Master, Lbl_document_Place_reservation_notes %>"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr5" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img4"  src="../img/plus.jpg" onclick="toggle('img4')" alt="">
                            <asp:Label ID="Label3" runat="server" Text="<%$ Resources:Master, Thread direct %>" class="text_Brown_10pt_bold"> </asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="dirsub">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="labdirsub" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_publisherno" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img5"  src="../img/plus.jpg" onclick="toggle('img5')" alt="">
                            <asp:Label ID="Label17" runat="server" align="<%$Resources:Master, align%>" Text="<%$ Resources:Master, Edition %>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_publisherno1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="labpublishno" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="request_no" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img6"  src="../img/plus.jpg" onclick="toggle('img6')" alt="">
                            <asp:Label ID="Label5" runat="server" Text="<%$ Resources:Master, No. demand at the source%>" class="text_Brown_10pt_bold"> </asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="nores">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="labnores" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="isbn" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img7"  src="../img/plus.jpg" onclick="toggle('img7')" alt="">
                            <asp:Label ID="Label12" runat="server" Text="<%$ Resources:Master, ISIN%>" class="text_Brown_10pt_bold"> </asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="isbn1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="labisbn" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="resource" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img8"  src="../img/plus.jpg" onclick="toggle('img8')" alt="">
                            <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Master, Collectibles%>" class="text_Brown_10pt_bold"> </asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="resource1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Labresource" runat="server" ForeColor=""></asp:Label>
                        </span>
                    </div>
                </div>
            </td>
        </tr>
      </table>
</asp:Content>
