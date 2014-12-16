<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master"
    AutoEventWireup="true" CodeFile="WebsiteMap.aspx.cs" Inherits="general_WebsiteMap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table id="Table1" runat="server" align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" style="padding-right:20px;padding-left:20px;height:500px"
        width="900 px" border="0">
        <tr>
            
            <td style="vertical-align:top">
                <table width="100%">
                    <tr id="Tr1" runat="server"  align="<%$Resources:Master, align%>"
                        valign="top">
                        <td id="Td1" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                            <span class="<%$Resources:Master, pagetitle%>" id="Span1" runat="server">
                            <asp:Label ID="Label53" runat="server" Text="<%$Resources:Master, plan%>"></asp:Label>
                            </span>
                        </td>
                    </tr>
                    <tr id="Tr2" runat="server" align="<%$Resources:Master, align%>" valign="top">
                        <td id="Td2" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                            <table width="100%" runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr runat="server" align="<%$Resources:Master, align%>" valign="top">
                                    <td runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton5" class="books_title_text" runat="server" PostBackUrl="~/general/Default.aspx"
                                            Text="<%$Resources:Master, title_main%>"></asp:LinkButton>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                            <table width="100%" runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr3" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                    <td id="Td3" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                       <asp:LinkButton ID="LinkButton4" class="books_title_text" runat="server" PostBackUrl="~/events/Default.aspx"
                                             Text="<%$Resources:Master, title_event%>"></asp:LinkButton>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                            <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr4" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                    <td id="Td4" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton1" class="books_title_text" runat="server" PostBackUrl="~/topics/Default.aspx"
                                    Text="<%$Resources:Master, title_topic%>"></asp:LinkButton>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                            <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr5" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                    <td id="Td5" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton2" class="books_title_text" runat="server" PostBackUrl="~/sheikhs/Default.aspx"
                                    Text="<%$Resources:Master, title_char%>"></asp:LinkButton>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                             
                            <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr6" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td6" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton9" class="books_title_text" runat="server" PostBackUrl="~/sheikhs/Default.aspx?type=1"
                                            Text="شيوخ الأزهر"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr7" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td7" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton10" class="books_title_text" runat="server" PostBackUrl="~/sheikhs/Default.aspx?type=2"
                                            Text="المفتون"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr8" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td8" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton11" class="books_title_text" runat="server" PostBackUrl="~/sheikhs/Default.aspx?type=3"
                                            Text="العلماء"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>
                                <table id="Table2" width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr24" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td id="Td24" runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td25" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton23" class="books_title_text" runat="server" PostBackUrl="~/sheikhs/Default.aspx?type=4"
                                            Text="الأعلام"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>
                            <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr9" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                    <td id="Td9" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                <asp:LinkButton ID="LinkButton3" class="books_title_text" runat="server" PostBackUrl="~/places/Default.aspx"
                                    Text="<%$Resources:Master, title_place%>"></asp:LinkButton>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                            <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr10" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                    <td id="Td10" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                <asp:LinkButton ID="LinkButton6" class="books_title_text" runat="server" PostBackUrl="~/Esdarat/list_document.aspx"
                                    Text="<%$Resources:Master, title_library%>"></asp:LinkButton>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>

                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr11" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td11" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                             
                                        <asp:LinkButton ID="LinkButton12" class="books_title_text" runat="server" PostBackUrl="~/Esdarat/listConferencePropceed.aspx"
                                            Text="<%$Resources:Master, title_conference%>"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr12" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td12" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton13" class="books_title_text" runat="server" PostBackUrl="~/Esdarat/list_characters_books.aspx"
                                            Text="<%$Resources:Master, title_book%>"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr13" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td13" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton14" class="books_title_text" runat="server" PostBackUrl="~/Esdarat/list_articles.aspx"
                                            Text="<%$Resources:Master, title_articles%>"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr14" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td14" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton15" class="books_title_text" runat="server" PostBackUrl="~/Esdarat/list_document.aspx"
                                            Text="<%$Resources:Master, title_docs%>"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>  
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr15" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td15" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton16" class="books_title_text" runat="server" PostBackUrl="~/Esdarat/listManuscript.aspx"
                                            Text="<%$Resources:Master, title_manuscript%>"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>   
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr16" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td16" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton17" class="books_title_text" runat="server" PostBackUrl="~/Elzakera/List_theses.aspx"
                                            Text="الأطروحات"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table> 
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr17" runat="server" align="<%$Resources:Master, align%>" valign="top" >
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td17" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton18" class="books_title_text" runat="server" PostBackUrl="~/Esdarat/listArtifacts.aspx"
                                            Text="<%$Resources:Master, title_artifacts%>"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>                                    
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr18" runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                   <td runat="server" align="<%$Resources:Master, align%>" valign="top" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td18" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton19" class="books_title_text" runat="server" PostBackUrl="~/Esdarat/listWebSites.aspx"
                                            Text="<%$Resources:Master, title_website%>"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table> 
                              <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr19" runat="server" align="<%$Resources:Master, align%>" valign="top">

                                    <td id="Td19" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                         <asp:LinkButton ID="LinkButton7" class="books_title_text" runat="server" PostBackUrl="~/general/Timeline.swf"
                                    Text="<%$Resources:Master, title_timeline%>"></asp:LinkButton>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>                                   
                              <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr20" runat="server" align="<%$Resources:Master, align%>" valign="top">

                                    <td id="Td20" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                     <asp:LinkButton ID="LinkButton8" class="books_title_text" runat="server" PostBackUrl="~/media/listPhotos.aspx"
                                    Text="<%$Resources:Master, title_media%>"></asp:LinkButton>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table> 
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr21" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td21" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                     <asp:LinkButton ID="LinkButton20" class="books_title_text" runat="server" PostBackUrl="~/media/listPhotos.aspx"
                                    Text="ألبوم الصور"></asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr22" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td22" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton21" runat="server" Text="<%$Resources:Master, title_audios%>"
                                        class="books_title_text" PostBackUrl="~/media/audio_list.aspx">
                                        </asp:LinkButton>
                                    </td>
                                    
                                </tr>
                            </table>                
                             <table width="100%"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                <tr id="Tr23" runat="server" align="<%$Resources:Master, align%>" valign="top">
                                   <td runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" style="width:20%">
                                        &nbsp;
                                    </td>
                                    <td id="Td23" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:LinkButton ID="LinkButton22" runat="server" class="books_title_text" 
                                            PostBackUrl="~/media/tvAudioList.aspx" Text="التسجيلات تليفزيونية"></asp:LinkButton>
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
