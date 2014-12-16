<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="article_details.aspx.cs" Inherits="Esdarat_document_details" Title="Untitled Page" %>

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

    <input id="HiddenID" type="hidden" runat="server" />
    <table id="Table1" dir="<%$ Resources:Master, dir%>" runat="server" width="100%">
        <tr>
            <td align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" runat="server" colspan="2">
           <%-- <asp:Image ID="Image1" runat="server" Width="69" Height="55" />--%>
                
                    <div class="accordion_title" id="Div1" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Labtitle" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body_empty" id="Div2" runat="server">
                        <span class="text_Dark_Brown_10pt"></span>
                    </div>

                    <div class="accordion_title" id="tr1" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label11" runat="server" Text="<%$ Resources:Master, artilce_langauage%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="trlang">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_drop_lang" runat="server">
                            </asp:Label>
                            <asp:DropDownList ID="drop_lang" runat="server" DataValueField="id" DataTextField="title_ar"
                                Visible="False">
                            </asp:DropDownList>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_grid_name" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label15" runat="server" Text="<%$ Resources:Master, lbl_manuscript_Authorn%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr_grid">
                        <span class="text_Dark_Brown_10pt">
                            <asp:GridView runat="server" ID="gview_moalf" Visible="false" AutoGenerateColumns="False"
                                CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="id">
                                <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" BorderWidth="0"
                                    HorizontalAlign="Center" />
                                <Columns>
                                    <asp:BoundField DataField="name" ShowHeader="true" HeaderText="<%$ Resources:Master, author%>" ItemStyle-HorizontalAlign="Center"
                                        HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="name_ar" ShowHeader="true" HeaderText="<%$Resources:Master,txt_moalf%>"
                                        ItemStyle-HorizontalAlign="Center" ItemStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="name_ar" ShowHeader="true" HeaderText="<%$Resources:Master,txt_moalf%>"
                                        ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="author_role" ShowHeader="true" HeaderText="<%$ Resources:Master, author_roll%>"
                                        ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                                </Columns>
                            </asp:GridView>
                        </span>
                    </div>

                   

                    <div class="accordion_title" id="tr6" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Master, periodical_title%>" ></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr7">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Labpubtitle" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label3" runat="server" Text="<%$ Resources:Master, lbl_article_yearno_folder%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr8">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="labpubLocation" runat="server" Text=" "></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr12" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Master, parts_number%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="tr13">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_seriesno" runat="server" Text=" "></asp:Label>
                        </span>
                    </div>

                    <div id="accordion">

                    <div class="accordion_title" id="trpages" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                            <asp:Label ID="Label13" runat="server" Text="<%$ Resources:Master, workingPageNo%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="trpages1">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_no" runat="server" Text = '<%$ Resources:Master, timeline_hegryfrom%>'></asp:Label>
                            <%--&nbsp;&nbsp;&nbsp;&nbsp;<%$ Resources:Master, timeline_hegryfrom%>&nbsp;--%>
                            <asp:Label ID="txt_from" runat="server"></asp:Label>
                            
                           <%-- &nbsp;&nbsp;&nbsp;&nbsp;--%>
                            
                            <asp:Label ID="Label31" runat="server" Text="<%$ Resources:Master, timeline_hegryto%>"></asp:Label>
                           <%-- &nbsp;--%>
                            <asp:Label ID="txt_to" runat="server"></asp:Label>
                        </span>
                    </div>
                    <div class="accordion_title" id="tr4" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                            <asp:Label ID="Label5" runat="server" Text="<%$ Resources:Master, lbl_Recording_notes %>"
                                class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="trnotes">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Label14" runat="server"></asp:Label>
                        </span>
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
