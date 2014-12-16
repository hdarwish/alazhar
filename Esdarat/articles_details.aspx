<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true"
    CodeFile="articles_details.aspx.cs" Inherits="Esdarat_articles_details" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <input id="HiddenID" type="hidden" runat="server" />
    <table cellpadding="0px" cellspacing="5px" width="580px" dir="rtl">
        <tr align="right">
            <td align="right" dir="rtl">
                <table cellpadding="0px" cellspacing="5px" dir="rtl">
                    <tr>
                        <td>
                            <asp:Label ID="Labtitle" runat="server" CssClass="books_title"></asp:Label>
                        </td>
                        <td align="right" style="width: auto">
                            <a href="" target="_blank" runat="server" id="link_pdf1" class="books_title">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/esdarat/file11_pdf.png" />
                            </a>
                        </td>
                    </tr>
                    </table> 
            </td>
        </tr>
    
    <%-- <tr>
            <td width="100%" style="height: 80%" align="right" colspan="2" align="center">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/book.jpg" BorderStyle="Ridge" />
            </td>
        </tr>--%>
    <tr align="right">
        <td colspan="2">
            <fieldset dir="rtl" style="width: 530px">
                <table>
                 <tr runat="server" id="Tr1">
                        <td align="right" dir="rtl" colspan="2">
                            <asp:Label ID="Label2" runat="server" Text=" المؤلف :" CssClass="books_title"></asp:Label>
                            <asp:Label ID="lblAuthor" runat="server" Text=" " CssClass="books_text"></asp:Label>
                        </td>
                    </tr>
                    <tr runat="server" id="doclang">
                        <td align="right" dir="rtl" colspan="2">
                            <asp:Label ID="Label6" runat="server" Text=" لغة المقالة :" CssClass="books_title"></asp:Label>
                            <asp:Label ID="Lablang" runat="server" Text=" " CssClass="books_text"></asp:Label>
                        </td>
                    </tr>
                    <tr runat="server" id="pubtitle">
                        <td align="right" colspan="2">
                            <asp:Label ID="Label1" runat="server" Text="اسم الدورية: " CssClass="books_title"></asp:Label>
                            <asp:Label ID="Labpubtitle" runat="server" CssClass="books_text"></asp:Label>
                        </td>
                    </tr>
                    <tr runat="server" id="pubLocation">
                        <td align="right" dir="rtl" colspan="2">
                            <asp:Label ID="Label4" runat="server" Text="رقم المجلد أو السنة :" CssClass="books_title"></asp:Label>
                            <asp:Label ID="labpubLocation" runat="server" Text=" " CssClass="books_text"></asp:Label>
                        </td>
                    </tr>
                    <tr runat="server" id="pubdate">
                        <td align="right" dir="rtl" colspan="2">
                            <asp:Label ID="Label7" runat="server" Text="رقم العدد أو الجزء :" CssClass="books_title"></asp:Label>
                            <asp:Label ID="lblseriesno" runat="server" Text=" " CssClass="books_text"></asp:Label>
                        </td>
                    </tr>
                    <tr runat="server" id="pageno">
                        <td align="right" colspan="2">
                            <asp:Label ID="Label8" runat="server" Text=" عدد الصفحات  :" CssClass="books_title"> </asp:Label>
                            <asp:Label ID="labpageno" runat="server" CssClass="books_text"></asp:Label>
                        </td>
                    </tr>
                    <%-- <tr runat="server" id="folderno">
            <td align="right" colspan="2">
                <asp:Label ID="Label10" runat="server" Text="عدد المجلدات :" CssClass="books_title"> </asp:Label>
                <asp:Label ID="labfolderno" runat="server" CssClass="books_text"></asp:Label>
            </td>
        </tr>
        <%--<td align="right" dir="rtl" class="style1">
                <asp:Label ID="Labwriter" runat="server" Text=" لغة الكتاب " CssClass="books_title_text"></asp:Label>
            </td>--%>
                    <%--<tr runat="server" id="dirsub">
            <td align="right" colspan="2">
                <asp:Label ID="Label3" runat="server" Text=" الموضوع المباشر :" CssClass="books_title"> </asp:Label>
                <asp:Label ID="labdirsub" runat="server" CssClass="books_text"></asp:Label>
            </td>
          
        </tr>--%>
                    <%-- <tr runat="server" id="publishno">
            <td align="right" colspan="2">
                <asp:Label ID="Label17" runat="server" Text="الطبعة : " CssClass="books_title"></asp:Label>
                <asp:Label ID="labpublishno" runat="server" CssClass="books_text"></asp:Label>
            </td>
        </tr>--%>
                    <%--  <tr runat="server" id="nores">
            <td align="right" dir="rtl" colspan="2">
                <asp:Label ID="Label5" runat="server" Text="رقم الطلب في المصدر :" CssClass="books_title"> </asp:Label>
                <asp:Label ID="labnores" runat="server" CssClass="books_text"></asp:Label>
            </td>
        </tr>--%>
                    <%-- <tr>
                                    <td align="right" dir="rtl" colspan="2">
                                        <asp:Label ID="Label4" runat="server" Text="الكلمات الدالة" CssClass="books_title"> </asp:Label>
                                        <asp:Label ID="labtags" runat="server" CssClass="books_text"></asp:Label>
                                    </td>
                                </tr>--%>
                    <%--<tr>
            <td align="right" colspan="2">
                <asp:Label ID="Labbrief" runat="server" CssClass="books_title" Width="100%"></asp:Label>
            </td>
        </tr>--%>
                    <%--  <tr runat="server" id="isbn">
            <td align="right" dir="rtl" colspan="2">
                <asp:Label ID="Label12" runat="server" Text="الترقيم الدولي  : " CssClass="books_title"> </asp:Label>
                <asp:Label ID="labisbn" runat="server" CssClass="books_text"></asp:Label>
            </td>
        </tr>--%>
                    <%-- <tr runat="server" id="resource">
            <td align="right" dir="rtl" colspan="2">
                <asp:Label ID="Label2" runat="server" Text="من مقتنيات:" Font-Bold="true" font-Size="14px" ForeColor="#898566"  CssClass="books_title"> </asp:Label>
                <asp:Label ID="Labresource" runat="server" CssClass="books_text" ForeColor="#898566" ></asp:Label>
            </td>
        </tr>--%>
                </table>
            </fieldset>
        </td>
    </tr>
    </table>
</asp:Content>
