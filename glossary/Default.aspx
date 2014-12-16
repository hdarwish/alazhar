<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master"
    AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="glossary_Default" %>

<%@ Register Src="WebUserControl.ascx" TagName="WebUserControl" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table width="100%" runat="server" dir="<%$Resources:Master, dir%>" align="center">
        <tr runat="server" dir="<%$Resources:Master, dir%>" >
           
            
            <td align="center" width="100%" colspan="3">
                <table id="Table1" runat="server" cellpadding="0" border="1" dir="<%$Resources:Master, dir%>" cellspacing="0" bordercolor="#815e28">
                    <tr>
                        <td>
                            <table id="Table2" runat="server" dir="<%$Resources:Master, dir%>">
                                <tr style="padding-left: 15px;padding-right: 15px" align="left">
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link1" runat="server" Text="<%$Resources:Master, ch1%>" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=1" CssClass="char"></asp:LinkButton>
                                    
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link2" runat="server" Text="<%$Resources:Master, ch2%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=2"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link3" runat="server" Text="<%$Resources:Master, ch3%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=3"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link4" runat="server" Text="<%$Resources:Master, ch4%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=4"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link5" runat="server" Text="<%$Resources:Master, ch5%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=5"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link6" runat="server" Text="<%$Resources:Master, ch6%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=6"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link7" runat="server" Text="<%$Resources:Master, ch7%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=7"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link8" runat="server" Text="<%$Resources:Master, ch8%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=8"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link9" runat="server" Text="<%$Resources:Master, ch9%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=9"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link10" runat="server" Text="<%$Resources:Master, ch10%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=10"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link11" runat="server" Text="<%$Resources:Master, ch11%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=11"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link12" runat="server" Text="<%$Resources:Master, ch12%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=12"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link13" runat="server" Text="<%$Resources:Master, ch13%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=13"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link14" runat="server" Text="<%$Resources:Master, ch14%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=14"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link15" runat="server" Text="<%$Resources:Master, ch15%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=15"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link16" runat="server" Text="<%$Resources:Master, ch16%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=16"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link17" runat="server" Text="<%$Resources:Master, ch17%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=17"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link18" runat="server" Text="<%$Resources:Master, ch18%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=18"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link19" runat="server" Text="<%$Resources:Master, ch19%>" CssClass="char" OnClick="Link_Click"  PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=19"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link20" runat="server" Text="<%$Resources:Master, ch20%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=20"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link21" runat="server" Text="<%$Resources:Master, ch21%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=21"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link22" runat="server" Text="<%$Resources:Master, ch22%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=22"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link23" runat="server" Text="<%$Resources:Master, ch23%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=23"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link24" runat="server" Text="<%$Resources:Master, ch24%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=24"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link25" runat="server" Text="<%$Resources:Master, ch25%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=25"></asp:LinkButton>
                                    </td>
                                    <td style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link26" runat="server" Text="<%$Resources:Master, ch26%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=26"></asp:LinkButton>
                                    </td>
                                    <td id="tdlnk27" runat="server" style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link27" runat="server" Text="<%$Resources:Master, ch27%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=27"></asp:LinkButton>
                                    </td>
                                    <td id="tdlnk28" runat="server" style="width: 12px" align="center">
                                        <asp:LinkButton ID="Link28" runat="server" Text="<%$Resources:Master, ch28%>" CssClass="char" OnClick="Link_Click" PostBackUrl="../glossary/glossary_details.aspx?gid=0&l=28"></asp:LinkButton>
                                    </td>
                                </tr>
                               
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            
            
             
        </tr>
           
     
        
        <tr align="right">
            <td>
                <uc1:WebUserControl ID="WebUserControl1" runat="server" />
            </td>
        </tr>
        
       <%-- <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl2" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab3" runat="server" Text="ت"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl3" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab4" runat="server" Text="ث"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl4" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab5" runat="server" Text="جـ"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl5" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab6" runat="server" Text="حـ"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl6" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab7" runat="server" Text="خـ"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl7" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab8" runat="server" Text="د"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab9" runat="server" Text="ذ"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl8" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab10" runat="server" Text="ز"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl9" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab11" runat="server" Text="ر"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl10" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab12" runat="server" Text="ز"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl11" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab13" runat="server" Text="س"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl12" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab14" runat="server" Text="ش"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl13" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab15" runat="server" Text="ص"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl14" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab16" runat="server" Text="ض"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl15" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab17" runat="server" Text="ط"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl16" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab18" runat="server" Text="ظ"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl17" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab19" runat="server" Text="ع"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl18" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab20" runat="server" Text="غ"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl19" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lab21" runat="server" Text="ف"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl20" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label22" runat="server" Text="ق"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl21" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lab23" runat="server" Text="ك"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl22" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lab24" runat="server" Text="ل"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl23" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lab25" runat="server" Text="م"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl24" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lab26" runat="server" Text="ن"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl25" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lab27" runat="server" Text="و"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WebUserControl ID="WebUserControl26" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lab28" runat="server" Text="هـ"></asp:Label>
            </td>
            <tr>
                <td>
                    <uc1:WebUserControl ID="WebUserControl28" runat="server" />
                </td>
            </tr>--%>
    </table>
    
    
</asp:Content>
