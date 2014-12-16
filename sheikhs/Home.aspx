<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true"
    CodeFile="home.aspx.cs" Inherits="sheikhs_home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <input id="HiddenID" type="hidden" value ="0" runat="server"/>
    <table width="100%" cellpadding="5px" cellspacing="5px">
        <tr>
        
            <td>
                
                <table align="right" style="width: 715px">
                    <tr>
                        <td align="justify"  colspan="2" style="text-align: right">
                            <asp:Label ID="Label2" runat="server" Text="عن المشروع" Font-Bold="True" ForeColor="#996633"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="justify"  colspan="2" style="text-align: right">
                            <asp:Label ID="Label1" runat="server" Text="يمثل تراث الأمة جزءاً هاماً من تاريخها ومن حضارتها، وتاريخ الأمة جزء أساسي من حاضرها ودافع قوي لنهضتها وشموخها وتقدمها، ولذا أصبح من الضروري للأمم العريقة ذات التاريخ الطويل المجيد أن تؤرخ لتاريخها، وأن تدعم هذا بتوثيق تراثها الحضاري والفكري والإبداعي في مختلف المجالات. 
ولما كان الأزهر الشريف هو الأمين على الدين الإسلامي، والمدافع عن ذاتيته. فهو بحق رمز الفكر والعلم جامعةً ومسجداً، ومجداً وتاريخاً، فالأزهر هو عرين الأمة الإسلامية ودرعها. وعلى هذا فلقد حرص الأزهر الشريف على توثيق هذا التاريخ العظيم، وما شهده من الأحداث المختلفة على مر العصور، والعمل على تعريف العالم أجمع بهذا الصرح العظيم الذي ضم في جوانبه المتعددة تاريخاً مجيداً، وتتولى مكتبة الأزهر حفظ وتوثيق ونشر هذا التراث العظيم
"
                                Font-Size="Medium"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <table cellpadding="5px" cellspacing="10px" align="center" width="85%">
                                <tr dir="rtl">
                                    <td colspan="4" align="right" class="style2">
                                        <asp:Label ID="Label6" runat="server" Text="نماذج مختارة" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td align="center" class="style3">
                                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td align="right">
                                        <asp:ImageButton ID="ImageButton1" runat="server" Width="100px"  />
                                        
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
