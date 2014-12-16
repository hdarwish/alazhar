<%@ Control Language="C#" AutoEventWireup="true" CodeFile="rightUC.ascx.cs" Inherits="masterpage_rightUC" %>
<table style="width:110px" border="0" cellspacing="5">
    <tr>
        <td nowrap align="right"> 
            <a href="~/events/Default.aspx" runat="server" id="events_page">الأحداث والمواقف</a>
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
        <td nowrap align="right">
         <a href="~/topics/Default.aspx" runat="server" id="subjects_page" 
            >الموضوعات </a>
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
        <td nowrap align="right">
         <a href="~/sheikhs/Default.aspx" runat="server" id="characters_page" 
                >الشخصيات</a>
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
        <td nowrap align="right">
         <a href="~/general/memoristic.aspx" runat="server" id="memoristic_page" 
                >التراث المعمارى</a>
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
        <td nowrap align="right">
         <a href="~/general/memoristic.aspx" runat="server" id="timeline_page" 
                >الخط الزمني</a>
        </td>
    </tr>
    <tr>
        <td nowrap align="right">&nbsp;
        </td>
    </tr>
    <tr>
        <td nowrap align="right" nowrap>
         <a href="~/general/memoristic.aspx" runat="server" id="dictionary_page" class="out_links3" style="text-decoration: none; font-weight: bold;" >قاموس المصطلحات</a>
        </td>
    </tr>
    <tr>
        <td nowrap align="right">
         <a href="~/general/memoristic.aspx" runat="server" id="latest_page" class="out_links3" style="text-decoration: none; font-weight: bold;">أضيف حديثاً</a>
        </td>
    </tr>
    <tr>
        <td nowrap align="right">
         <a href="~/general/memoristic.aspx" runat="server" id="most_visited_page" class="out_links3" style="text-decoration: none; font-weight: bold;">الأكثر زيارة</a>
        </td>
    </tr>
   <%-- <tr>
        <td nowrap align="right">
         <a href="~/general/memoristic.aspx" runat="server" id="support_page" class="out_links3" style="text-decoration: none">دعم الموقع</a>
        </td>
    </tr>--%>
</table>