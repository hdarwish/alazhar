<%@ Control Language="C#" AutoEventWireup="true" CodeFile="rightUC1.ascx.cs" Inherits="masterpage_rightUC1" %>
<link href="../css/CSS.css" rel="stylesheet" type="text/css" />
<%--<td nowrap width="130" align="right" valign="top">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
       
         <tr>
            <td nowrap class="right-menu" runat="server" id="events_tr2">
                <a href="~/events/Default.aspx" runat="server" id="events_page">
                    <asp:Label ID="events_count" runat="server" Text=""></asp:Label>&nbsp;الأحداث والمواقف</a>
            </td>
        </tr>
        <tr runat="server" id="events_tr" visible="false">
            <td nowrap align="right">
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <a href="" runat="server" id="Lab_event_title" class="out_links3"></a>
                    </ItemTemplate>
                    <SeparatorStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                        Font-Underline="True" HorizontalAlign="Center" />
                </asp:DataList>
            </td>
        </tr>
       
          <tr>
            <td nowrap class="right-menu" runat="server" id="topic_tr2">
                <a href="~/topics/Default.aspx" runat="server" id="subjects_page">
                    <asp:Label ID="topics_count" runat="server" Text=""></asp:Label>&nbsp;الموضوعات</a>
            </td>
        </tr>
        <tr runat="server" id="topic_tr" visible="false">
            <td nowrap align="right">
                <asp:DataList ID="DataList2" runat="server">
                    <ItemTemplate>
                        <a href="" runat="server" id="Lab_topic_title" class="out_links3"></a>
                    </ItemTemplate>
                    <SeparatorStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                        Font-Underline="True" HorizontalAlign="Center" />
                </asp:DataList>
            </td>
        </tr>
       
         <tr>
            <td nowrap class="right-menu" runat="server" id="chars_tr2">
                <a href="~/sheikhs/Default.aspx" runat="server" id="characters_page">
                    <asp:Label ID="char_count" runat="server" Text=""></asp:Label>&nbsp;الشخصيات</a>
            </td>
        </tr>
        <tr runat="server" id="chars_tr" visible="false">
            <td nowrap align="right">
                <asp:DataList ID="DataList3" runat="server">
                    <ItemTemplate>
                        <a href="" runat="server" id="Lab_char_title" class="out_links3"></a>
                    </ItemTemplate>
                    <SeparatorStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                        Font-Underline="True" HorizontalAlign="Center" />
                </asp:DataList>
            </td>
        </tr>
    
          <tr>
            <td nowrap class="right-menu" runat="server" id="arch_memory_tr2">
                <a href="~/general/memoristic.aspx" runat="server" id="memoristic_page">
                    <asp:Label ID="places_count" runat="server" Text=""></asp:Label>&nbsp;التراث المعمارى</a>
            </td>
        </tr>
        <tr runat="server" id="arch_memory_tr" visible="false">
            <td nowrap align="right">
                <asp:DataList ID="DataList4" runat="server">
                    <ItemTemplate>
                        <a href="" runat="server" id="Lab_arch_memory_title" class="out_links3"></a>
                    </ItemTemplate>
                    <SeparatorStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                        Font-Underline="True" HorizontalAlign="Center" />
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td nowrap class="right-menu">
                الخط الزمني
            </td>
        </tr>
    </table>
    <img src="../img/spacer.gif" width="1" height="14" /><table width="100%" border="0"
        cellspacing="0" cellpadding="0">
        <tr>
            <td nowrap class="right2-menu">
                قاموس المصطلحات
            </td>
        </tr>
        <tr>
            <td nowrap class="right2-menu">
                اضيف حديثا
            </td>
        </tr>
        <tr>
            <td nowrap class="right2-menu">
                الاكثر زيارة
            </td>
        </tr>
    </table>
</td>--%>
<div class="_inner_page_body_left_left" id="maindiv" runat="server">
    <div  style="padding: 0px; height: 28px; width: 223px; float: left; background-color: #DCCCA8;
        border: #cdba9c 1px solid">
        <div id="divheader" runat="server" style="width: 140px; height: 28px; background-color: #C78964; float: right">
            <div class="text_White_8pt_bold" style="margin-top: 8px">
                <asp:Literal ID="Literal9" runat="server" Text="<%$ Resources:Master, relate_elemnts%>"></asp:Literal></div>
        </div>
    </div>
    <%-- <div style="height:28px;width:224px;float:left;"></div>--%>
    <div style="width: 223px; height: 15px; background-color: #AF8555; float: left; border: #AF8555 1px solid;
        padding: 0px; margin: 0px;">
        <div id="trev2" runat="server" style="background-position: left center; float: left; background-image: url('../img/Arrow__.jpg');
            width: 100px; height: 15px; background-repeat: no-repeat;background-color: #F1E6C6;">
            <span runat="server" dir="<%$ Resources:Master, rev_dir%>" class="text_Dark_Brown_9pt_bold">
            <a href="~/events/Default.aspx" class="text_Dark_Brown_9pt_bold"  runat="server"
               id="events_page" style="text-decoration: none;margin-right:13px;margin-left:1px;text-align: center;white-space: nowrap;">
                <asp:Label ID="events_count" runat="server"  style="background-color:#F1E6C6;"></asp:Label>
                <asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:Master, more%>"></asp:Literal></a>
            </span>
        </div>
        <div id="trev1" runat="server" class="text_White_8pt_bold" style="float: right">
             <asp:Literal ID="Literal1" runat="server" Text="<%$ Resources:Master, title_event%>"></asp:Literal></div>
    </div>
    <div style="width: 223px; border-bottom: #DFD4B4 1px solid">
        <div style="margin-top: 10pt; margin-right: 5pt; text-align: right" class="text_Dark_Brown_10pt">
            <asp:DataList ID="DataList1" runat="server" Width="100%">
                <ItemTemplate>
                    <table width="100%" dir="<%$ Resources:Master, dir%>" id="tblevent" runat="server" visible="false" style="margin-top: 10px;">
                        <tr>
                            <td  runat="server" align="<%$ Resources:Master, align%>"  valign="middle">
                                <asp:Image ID="Image1" runat="server" ImageUrl="<%$ Resources:Master, dlarrow%>" />
                            </td>
                            <td  runat="server" align="<%$ Resources:Master, align%>" valign="top" style="width: 95%;">
                                <asp:LinkButton runat="server" ID="Lab_event_title" CssClass="sheikhs_links"></asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
    <div style="width: 223px; height: 15px; background-color: #AF8555; float: left; border: #AF8555 1px solid;
        padding: 0px; margin: 0px;">
        <div id="trch2" runat="server" style="background-position: left center; float: left; background-image: url('../img/Arrow__.jpg');
            width: 100px; height: 15px; background-repeat: no-repeat;background-color: #F1E6C6;">
            <span  runat="server" dir="<%$ Resources:Master, rev_dir%>"  class="text_Dark_Brown_9pt_bold">
            <a href="~/sheikhs/Default.aspx" class="text_Dark_Brown_9pt_bold"  runat="server"
                 id="characters_page" style="text-decoration: none;margin-right:13px;margin-left:1px;text-align: center;white-space: nowrap;">
                <asp:Label ID="char_count" runat="server" 
                style="background-color:#F1E6C6"></asp:Label>
                <asp:Literal ID="Literal4" runat="server" Text="<%$ Resources:Master, more%>"></asp:Literal></a>
            </span>
        </div>
        <div id="trch1" runat="server" class="text_White_8pt_bold" style="float: right">
            <asp:Literal ID="Literal3" runat="server" Text="<%$ Resources:Master, title_char%>"></asp:Literal></div>
    </div>
    <div style="width: 223px">
        <div style="margin-top: 10pt; margin-right: 5pt; text-align: right" class="text_Dark_Brown_10pt">
            <asp:DataList ID="DataList3" runat="server" Width="100%">
                <ItemTemplate>
                    <table width="100%" dir="<%$ Resources:Master, dir%>" id="tblchar" runat="server" visible="false" style="margin-top: 5px;">
                        <tr>
                            <td runat="server" align="<%$ Resources:Master, align%>" valign="middle">
                                <asp:Image ID="Image2" runat="server" ImageUrl="<%$ Resources:Master, dlarrow%>" />
                            </td>
                            <td runat="server" align="<%$ Resources:Master, align%>" valign="top" style="width: 95%;">
                                <asp:LinkButton runat="server" ID="Lab_char_title" CssClass="sheikhs_links"></asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
    <div style="width: 223px; height: 15px; background-color: #AF8555; float: left; border: #AF8555 1px solid;
        padding: 0px; margin: 0px;">
        <div id="trto2" runat="server"  style="background-position: left center; float: left; background-image: url('../img/Arrow__.jpg');
            width: 100px; height: 15px; background-repeat: no-repeat;background-color: #F1E6C6;">
            <span   runat="server" dir="<%$ Resources:Master, rev_dir%>"  class="text_Dark_Brown_9pt_bold">
            <a href="~/topics/Default.aspx" runat="server"
                id="subjects_page" class="text_Dark_Brown_9pt_bold" style="text-decoration: none;margin-right:13px;margin-left:1px;text-align: center;white-space: nowrap;">
                <asp:Label ID="topics_count" runat="server" style="background-color:#F1E6C6"></asp:Label>
                <asp:Literal ID="Literal6" runat="server" Text="<%$ Resources:Master, more%>"></asp:Literal>
                </a>
            </span>
        </div>
        <div id="trto1" runat="server" class="text_White_8pt_bold" style="float: right">
            <asp:Literal ID="Literal5" runat="server" Text="<%$ Resources:Master, title_topic%>"></asp:Literal>
            </div>
    </div>
    <div style="width: 223px; border-bottom: #DFD4B4 1px solid">
        <div style="margin-top: 10pt; margin-right: 5pt; text-align: right" class="text_Dark_Brown_10pt">
            <asp:DataList ID="DataList2" runat="server" Width="100%">
                <ItemTemplate>
                    <table width="100%" dir="<%$ Resources:Master, dir%>" id="tbltopics" runat="server" visible="false" style="margin-top: 10px;">
                        <tr>
                            <td  runat="server" align="<%$ Resources:Master, align%>"  valign="middle">
                                <asp:Image ID="Image3" runat="server" ImageUrl="<%$ Resources:Master, dlarrow%>" />
                            </td>
                            <td  runat="server" align="<%$ Resources:Master, align%>" valign="top" style="width: 95%;">
                                <asp:LinkButton runat="server" ID="Lab_topic_title" CssClass="sheikhs_links"></asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
    <div style="width: 223px; height: 15px; background-color: #AF8555; float: left; border: #AF8555 1px solid;
       padding: 0px; margin: 0px;">
        <div id="trpl2" runat="server" style="background-position: left center; float: left; background-image: url('../img/Arrow__.jpg');
            width: 100px; height: 15px; background-repeat: no-repeat;background-color:#F1E6C6">
            <span   runat="server" dir="<%$ Resources:Master, rev_dir%>"  class="text_Dark_Brown_9pt_bold">
            <a href="~/places/Default.aspx" runat="server" id="memoristic_page"
                class="text_Dark_Brown_9pt_bold" style="text-decoration: none;margin-right:13px;margin-left:1px;text-align: center;white-space: nowrap;">
                 
               
                <asp:Label ID="places_count" runat="server" style="background-color:#F1E6C6"></asp:Label>
                 <asp:Literal ID="Literal8" runat="server" Text="<%$ Resources:Master, more%>"></asp:Literal>
               </a>
            </span>
        </div>
        <div id="trpl1" runat="server" class="text_White_8pt_bold" style="float: right">
            <asp:Literal ID="Literal7" runat="server" Text="<%$ Resources:Master, title_place%>"></asp:Literal></div>
    </div>
    <div style="width: 223px; border-bottom: #DFD4B4 1px solid">
        <div style="margin-top: 10pt; margin-right: 5pt; text-align: right" class="text_Dark_Brown_10pt">
            <asp:DataList ID="DataList4" runat="server" Width="100%">
                <ItemTemplate>
                    <table width="100%" dir="<%$ Resources:Master, dir%>" id="tblplaces" runat="server" visible="false" style="margin-top: 10px;">
                        <tr>
                            <td  runat="server" align="<%$ Resources:Master, align%>" valign="middle">
                                <asp:Image ID="Image4" runat="server" ImageUrl="<%$ Resources:Master, dlarrow%>"  />
                            </td>
                            <td  runat="server" align="<%$ Resources:Master, align%>" valign="top" style="width: 95%;">
                                <asp:LinkButton runat="server" ID="Lab_arch_memory_title" CssClass="sheikhs_links"></asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</div>
