<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="administration_Default" Title="الرئيسية" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%">
        <tr>
            <td align="center">
                <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="#996633" Text="لوحة تحكم مشروع ذاكرة الأزهر"></asp:Label>
            </td>
        </tr>
        <tr align="center">
        
        <td> <asp:Label ID="lbl_pagetitle" runat="server" Font-Bold="True" ForeColor="#996633" Text=""></asp:Label></td>
        </tr>
        <tr runat="server" id="admin_tr" visible="false"  align="center">
            <td>
                <asp:LinkButton ID="LinkButton1" PostBackUrl="~/administration/objects_titles.aspx"
                    runat="server">اضافة/تعديل العناصر</asp:LinkButton><br />
                     <asp:LinkButton ID="LinkButton9" PostBackUrl="~/administration/objects_titles_replace.aspx"
                    runat="server">إستبدال العناصر</asp:LinkButton><br />
                <asp:LinkButton ID="LinkButton2" PostBackUrl="~/administration/objects_assign.aspx"
                    runat="server">إسناد العناصر</asp:LinkButton><br />
                <asp:LinkButton ID="LinkButton3" PostBackUrl="~/administration/researsher_view.aspx"
                    runat="server">المستخدمين</asp:LinkButton><br />
                <asp:LinkButton ID="LinkButton5" PostBackUrl="~/administration/lookups_main_page.aspx"
                    runat="server">شاشة عرض إدخال الأكواد</asp:LinkButton><br />
					
					<asp:LinkButton ID="ReportTrans" PostBackUrl="~/administration/ReportViewer.aspx"
                    runat="server">عرض تقارير الترجمة</asp:LinkButton><br />
                    <asp:LinkButton ID="LinkButton15" PostBackUrl="~/Report_folder/Report_Admin.aspx"
                    runat="server"> التقارير</asp:LinkButton><br />
            </td>
        </tr>
        <tr runat="server" id="final_revision_tr" visible="false"  align="center">
            <td>
                &nbsp;
                <asp:LinkButton ID="LinkButton10" Visible="false" PostBackUrl="~/administration/final_revision_home.aspx?operation=new"
                    runat="server">
                    لديك عدد (<asp:Label ID="final_new_count" runat="server" Text="5"></asp:Label>)
                    استمارة جديدة</asp:LinkButton><br />
                <asp:LinkButton ID="LinkButton11" Visible="false" PostBackUrl="~/administration/final_revision_home.aspx?operation=processed"
                    runat="server">
                    لديك عدد (<asp:Label ID="final_processed_count" runat="server" Text="5"></asp:Label>)
                    استمارة تم معالجتها</asp:LinkButton><br />
                <asp:LinkButton ID="LinkButton12" Visible="false" PostBackUrl="~/administration/final_revision_home.aspx?operation=refused"
                    runat="server">
                    لديك عدد (<asp:Label ID="final_refused_count" runat="server" Text="5"></asp:Label>)
                    استمارة تم رفضها من لجنة الاعتماد</asp:LinkButton><br />
            </td>
        </tr>
        <tr runat="server" id="file_entry_tr" visible="false"  align="center">
            <td>
                &nbsp;
                <asp:LinkButton ID="LinkButton4" Visible="false" PostBackUrl="~/administration/files_entry.aspx?operation=new"
                    runat="server">
                    لديك عدد (<asp:Label ID="files_new_count" runat="server" Text="5"></asp:Label>)ملف
                    جديد</asp:LinkButton><br />
                <asp:LinkButton ID="LinkButton7" Visible="false" PostBackUrl="~/administration/files_entry.aspx?operation=unfinished"
                    runat="server">
                    لديك عدد (<asp:Label ID="files_unfinished_count" runat="server" Text="5"></asp:Label>)
                    ملف غير مكتمل</asp:LinkButton><br />
                <%--<asp:LinkButton ID="LinkButton5" Visible="false" PostBackUrl="~/administration/files_entry.aspx?operation=processed" runat="server">لديك عدد (<asp:Label ID="files_processed_count" runat="server" Text="5"></asp:Label>) ملف تم معالجته</asp:LinkButton><br />--%>
                <asp:LinkButton ID="LinkButton14" Visible="false" PostBackUrl="~/administration/files_entry.aspx?operation=refused"
                    runat="server">
                    لديك عدد (<asp:Label ID="files_refused_count" runat="server" Text="5"></asp:Label>)
                    ملف تم رفضه من مراقب جودة الملفات</asp:LinkButton><br />
            </td>
        </tr>
        <tr runat="server" id="file_revision_tr" visible="false"  align="center">
            <td>
                &nbsp;
                <asp:LinkButton ID="LinkButton6" Visible="false" PostBackUrl="~/administration/files_revision.aspx?operation=new"
                    runat="server">
                    لديك عدد (<asp:Label ID="files_revision_new_count" runat="server" Text="5"></asp:Label>)ملف
                    جديد للمراجعة</asp:LinkButton><br />
                <asp:LinkButton ID="LinkButton8" Visible="false" PostBackUrl="~/administration/files_revision.aspx?operation=unfinished"
                    runat="server">
                    لديك عدد (<asp:Label ID="files_revision_unfinished_count" runat="server" Text="5"></asp:Label>)
                    ملف غير مكتمل المراجعة</asp:LinkButton><br />
                <%-- <asp:LinkButton ID="LinkButton9" Visible="false" PostBackUrl="~/administration/files_revision.aspx?operation=processed" runat="server">لديك عدد (<asp:Label ID="files_revision_processed_count" runat="server" Text="5"></asp:Label>) ملف تمت مراجعته </asp:LinkButton><br />--%>
                <asp:LinkButton ID="LinkButton18" Visible="false" PostBackUrl="~/administration/files_revision.aspx?operation=corrected"
                    runat="server">
                    لديك عدد (<asp:Label ID="files_revision_corrected_count" runat="server" Text="5"></asp:Label>)
                    ملف تم معالجته</asp:LinkButton><br />
                <asp:LinkButton ID="LinkButton13" Visible="false" PostBackUrl="~/administration/files_revision.aspx?operation=refused"
                    runat="server">
                    لديك عدد (<asp:Label ID="files_revision_refused_count" runat="server" Text="5"></asp:Label>)
                    ملف تم رفضه من لجنة الاعتماد
                </asp:LinkButton><br />
            </td>
        </tr>
        <tr runat="server" id="tr_formentry" visible="false"  align="center">
            <td>
                <asp:LinkButton ID="Link_New" Visible="false" PostBackUrl="~/administration/entry_form.aspx?operation=new"
                    runat="server">
                    لديك عدد (
                    <asp:Label ID="Lab_new" runat="server" Text=""></asp:Label>
                    ) استمارة جديدة</asp:LinkButton><br />
                <asp:LinkButton ID="Link_UN" Visible="false" PostBackUrl="~/administration/entry_form.aspx?operation=unfinished"
                    runat="server">
                    لديك عدد (
                    <asp:Label ID="Lab_UN" runat="server" Text=""></asp:Label>
                    ) غير مكتملة</asp:LinkButton><br />
                <asp:LinkButton ID="Link_error" Visible="false" PostBackUrl="~/administration/entry_form.aspx?operation=wrong"
                    runat="server">
                    لديك عدد (
                    <asp:Label ID="Lab_error" runat="server" Text=""></asp:Label>
                    ) استمارة تحتوي علي أخطاء
                </asp:LinkButton><br />
            </td>
        </tr>
        <tr runat="server" id="tr_quality" visible="false"  align="center">
            <td>
                <asp:LinkButton ID="LinkButton21" Visible="false" PostBackUrl="~/administration/quality_control_notes.aspx?operation=new"
                    runat="server">
                    لديك عدد (
                    <asp:Label ID="Label1" runat="server" Text="5"></asp:Label>
                    ) استمارة جديدة</asp:LinkButton><br />
                <asp:LinkButton ID="LinkButton22" Visible="false" PostBackUrl="~/administration/quality_control_notes.aspx?operation=processed"
                    runat="server">
                    لديك عدد (
                    <asp:Label ID="Label2" runat="server" Text="5"></asp:Label>
                    ) استمارة تم معالجة بياناتها</asp:LinkButton><br />
                <asp:LinkButton ID="LinkButton23" Visible="false" PostBackUrl="~/administration/quality_control_notes.aspx?operation=unfinished"
                    runat="server">
                    لديك عدد (
                    <asp:Label ID="Label3" runat="server" Text="5"></asp:Label>
                    ) غير مكتملة</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>
