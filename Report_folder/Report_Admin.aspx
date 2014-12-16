<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="Report_Admin.aspx.cs" Inherits="Reports_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Report_folder/Report_Report_Statistical_no_ Elements.aspx">تقرير احصائى بعدد العناصر وحالتها</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Report_folder/Report_References.aspx">تقرير المراجع التى تم ادخالها</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/Report_folder/StaticalyReportDataEntry.aspx">تقرير اجمالى استمارات مدخل البيانات</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/Report_folder/Report_ReplicatesElements.aspx">تقرير مكررات العناصر</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton6" runat="server" PostBackUrl="~/Report_folder/QualityControlDataBased.aspx">تقرير اجمالى استمارات مراجع البيانات التى تم اعتمادها من المراجعة النهائية</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton7" runat="server" PostBackUrl="~/Report_folder/ReportRelation_Elements.aspx">تقرير بالعناصر المرتبطة بعنصر معين</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton8" runat="server" PostBackUrl="~/Report_folder/FeaturesHonor.aspx">تقرير ملامح تكريم الشخصية</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton9" runat="server" PostBackUrl="~/Report_folder/TotalFrequencyOFerrorsData.aspx">تقرير اجمالى مرات تكرار اخطاء مدخل البيانات</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton10" runat="server" PostBackUrl="~/Report_folder/DetailedReportOFParticularInputOFtheforms.aspx">تقرير تفصيلى بالاستمارات لمدخل معين</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton11" runat="server" PostBackUrl="~/Report_folder/TotalFrequencyOFerrorsFiles.aspx">تقرير اجمالى مرات تكرار اخطاء مدخل ملفات</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton12" runat="server" PostBackUrl="~/Report_folder/Keywords.aspx">تقرير الكلمات الدالة</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton13" runat="server" PostBackUrl="~/Report_folder/charachter_type.aspx">تقرير نوع الشخصية</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton14" runat="server" PostBackUrl="~/Report_folder/important_activities.aspx">تقرير اهم انشطة الشخصية</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton16" runat="server" PostBackUrl="~/Report_folder/observing_data_entry.aspx">تقرير اجمالى استمارات مدخل البيانات التى تم قبولها من مراجع معين</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton17" runat="server" PostBackUrl="~/Report_folder/important_achievement.aspx">تقرير اهم انجازات الشخصية</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton18" runat="server" PostBackUrl="~/Report_folder/total_err_of_DE.aspx">تقرير اجمالى اخطاء مدخل البيانات</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton20" runat="server" PostBackUrl="~/Report_folder/total_err_of_FE.aspx">تقرير اجمالى اخطاء مدخل ملفات</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton21" PostBackUrl="~/Report_folder/Report2_readyToPublish_connected.aspx"
        runat="server">تقرير العناصر الجاهزة للنشر و العناصر المرتبطة بها</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton22" PostBackUrl="~/Report_folder/statistics_data_QA.aspx"
        runat="server">تقرير احصائى لمراقب جودة للبيانات</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton24" PostBackUrl="~/Report_folder/characters_writtenAbout.aspx"
        runat="server">تقرير قالوا عن الشخصية</asp:LinkButton><br />
    <asp:LinkButton ID="LinkButton15" runat="server" PostBackUrl="~/Report_folder/total_error_of_file_observer.aspx">تقرير اجمالى اخطاء مراقب جودة ملفات</asp:LinkButton>
    <br />
    <asp:LinkButton ID="LinkButton19" PostBackUrl="~/Report_folder/report_workLife.aspx" runat="server">تقرير المناصب التى تولتها الشخصيه</asp:LinkButton><br />
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Report_folder/Elements_moetamed.aspx">تقرير العناصر المعتمدة فى فترة معينة</asp:LinkButton><br />
    <br />
    <br />
</asp:Content>
