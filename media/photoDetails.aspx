<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="photoDetails.aspx.cs" Inherits="Esdarat_photoDetails" Title="photo Details" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <input id="HiddenID" type="hidden" runat="server" />
    <table    dir="<%$Resources:Master, dir%>" style="width: 100%" runat="server"><!--cellpadding="0px" cellspacing="0px" delet this to run the dir from the front -->
       <tr align="center" runat="server">
            <td  align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                <table  dir="<%$Resources:Master, dir%>" style="margin-right:5px;width: 100%" runat="server"><!--cellpadding="0px" cellspacing="0px" delet this to run the dir from the front -->
                    <tr>
                        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
                             <fieldset style="width: 98%;border-style:none">
                               
            
            <table style="width: 100%" border="0" cellspacing="0" runat="server" id="tblmanus" align="center">
  
    
   <tr>
                        <td style="background-color: #E7DEC1; height: 33px;" colspan="2" >
                            &nbsp;<asp:Label ID="Labtitle" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                        </td>
                      <td style="background-color: #E7DEC1;" align="left">
       <asp:Image ID="Image58" ImageUrl="../img/Row 1.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />
      </td>
                    </tr>                
                <tr runat="server" id="tr_title">
                    <td style="background-color: #E7DEC1; height: 33px;" colspan="2">
                        &nbsp;
                        <asp:Label ID="Label9" runat="server"  
                           
                            Text="<%$Resources:Master, lbl_photo_details%>" 
                            class="text_Brown_10pt_bold"></asp:Label>
                    </td>
                    <td style="background-color: #E7DEC1;" align="left">
       <asp:Image ID="Image2" ImageUrl="../img/Row 1.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />
      </td>
                    </tr>
                    <tr runat="server" id="trtitfromtit">
                    <td colspan="2" style="padding: 5px;">
                        <asp:label ID="lbl_RblMediaType" runat="server" ></asp:label>
                         <asp:RadioButtonList ID="RblMediaType" runat="server" RepeatColumns="4" 
            RepeatDirection="Horizontal" Width="100%"  DataTextField="title_ar" 
            DataValueField="id" Visible="false">
           
        </asp:RadioButtonList>
                    </td>
                      <td valign="middle" align="left" style="background-image: url('../img/Row 2.jpg'); background-repeat: repeat-y; background-position: left top">
       <%--<asp:Image ID="Image30" ImageUrl="../img/Row 2.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />--%>
      </td>
                    </tr>  
               <tr runat="server" id="tr_title2">
                    <td style="background-color: #E7DEC1; height: 33px;" colspan="2">
                        &nbsp;
                        <asp:Label ID="Label71" runat="server"  
                           Text="<%$Resources:Master, Image_description%> "
                            CssClass="text_Brown_10pt_bold"></asp:Label>
                    </td>
                     <td style="background-color: #E7DEC1;" align="left">
       <asp:Image ID="Image3" ImageUrl="../img/Row 1.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />
      </td>
                    </tr>
                    <tr runat="server" id="trtitfromintro">
                    <td colspan="2" style="padding: 5px;">
                        <asp:Label ID="txtDesc" runat="server"></asp:Label>
                       
                    </td>
                      <td valign="middle" align="left" style="background-image: url('../img/Row 2.jpg'); background-repeat: repeat-y; background-position: left top">
      <%-- <asp:Image ID="Image29" ImageUrl="../img/Row 2.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />--%>
      </td>
                </tr>
                 <tr id="Tr5" runat="server" dir="<%$Resources:Master, dir%>">
                    <td style="background-color: #E7DEC1; height: 33px;" colspan="2">
                        &nbsp;
                        <asp:Label ID="Label13" runat="server" 
                            Text="<%$Resources:Master, lbl_photo_Photographer%>"
                            CssClass="text_Brown_10pt_bold"></asp:Label>
                    </td>
                     <td style="background-color: #E7DEC1;" align="left">
       <asp:Image ID="Image4" ImageUrl="../img/Row 1.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />
      </td>
                     </tr>
                    <tr runat="server" id="trauthfromtit">
                    <td colspan="2" style="padding: 5px;">
                        <asp:Label ID="txtCommenterName" runat="server" ></asp:Label>
                                    
                    </td>
                     <td valign="middle" align="left" style="background-image: url('../img/Row 2.jpg'); background-repeat: repeat-y; background-position: left top">
       <%--<asp:Image ID="Image31" ImageUrl="../img/Row 2.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />--%>
      </td>
                </tr>
                 <tr id="Tr2" runat="server" dir="<%$Resources:Master, dir%>">
                    <td style="background-color: #E7DEC1; height: 33px;" colspan="2">
                        &nbsp;
                        <asp:Label ID="Label23" runat="server"  
                            Text="<%$Resources:Master, Date_photography_graphic%>"
                           
                            CssClass="text_Brown_10pt_bold"></asp:Label>
                    </td>
                     <td style="background-color: #E7DEC1;" align="left">
       <asp:Image ID="Image5" ImageUrl="../img/Row 1.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />
      </td>
                     </tr>
                    <tr runat="server" id="trauthfromintro">
                    <td style="padding: 5px;" colspan="2">
                       
                        &nbsp 
            <asp:Label ID="txtHijriDate" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="هـ" class="text_Brown_10pt_bold"></asp:Label>
 &nbsp - &nbsp
  <asp:Label ID="txtGorgDate" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="م" class="text_Brown_10pt_bold"></asp:Label>
                    </td>
                      <td valign="middle" align="left" style="background-image: url('../img/Row 2.jpg'); background-repeat: repeat-y; background-position: left top">
      <%-- <asp:Image ID="Image32" ImageUrl="../img/Row 2.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />--%>
      </td>
                </tr>
                <tr runat="server" id="tr6">
        <td style="background-color: #E7DEC1; height: 33px;" colspan="2">
            &nbsp;
            <asp:Label ID="Label15" runat="server"  
                Text="<%$Resources:Master, lbl_photo_Source_copyright%>" 
                CssClass="text_Brown_10pt_bold"></asp:Label>
        </td>
         <td style="background-color: #E7DEC1;" align="left">
       <asp:Image ID="Image6" ImageUrl="../img/Row 1.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />
      </td>
         </tr>
                    <tr runat="server" id="trlang">
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" valign="top" colspan="2" style="padding: 5px;">
          
            <asp:Label ID="txtresourceName" runat="server" ></asp:Label>
        </td>
         <td valign="middle" align="left" style="background-image: url('../img/Row 2.jpg'); background-repeat: repeat-y; background-position: left top">
       <%--<asp:Image ID="Image33" ImageUrl="../img/Row 2.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />--%>
      </td>
        
    </tr>
       <tr id="tr1" runat="server" dir="<%$Resources:Master, dir%>">
                    <td id="Td1" style="background-color: #E7DEC1; height: 33px;" nowrap="nowrap" 
                        dir="<%$Resources:Master, dir%>" runat="server" colspan="2">
                        &nbsp;
                        <asp:Label ID="Label1" runat="server" 
                           Text="<%$Resources:Master, Age_Image_belongs%>"
                             CssClass="text_Brown_10pt_bold"></asp:Label>
                    </td>
                     <td style="background-color: #E7DEC1;" align="left">
       <asp:Image ID="Image1" ImageUrl="../img/Row 1.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />
      </td>
                     </tr>
     <tr align="<%$Resources:Master, align%>" id="trperiods" runat="server">
     
        <td colspan="1" dir="<%$Resources:Master, dir%>" valign="top">
             <asp:Label ID="lbl_chk_periods" runat="server">
            </asp:Label><br />
             
             <asp:RadioButtonList ID="chk_periods" runat="server" RepeatColumns="3" 
            RepeatDirection="Horizontal"  DataTextField="title" 
                 DataValueField="id" Width="100%" Visible="false"></asp:RadioButtonList>
        </td>
       
    </tr>
     <tr id="tr_place" runat="server" dir="<%$Resources:Master, dir%>">
                    <td id="Td17" style="background-color: #E7DEC1; height: 33px;" nowrap="nowrap" 
                        dir="<%$Resources:Master, dir%>" runat="server" colspan="2">
                        &nbsp;
                        <asp:Label ID="Label11" runat="server" 
                            Text="<%$Resources:Master, lbl_photo_Notes%>"
                             CssClass="text_Brown_10pt_bold"></asp:Label>
                    </td>
                     <td style="background-color: #E7DEC1;" align="left">
       <asp:Image ID="Image7" ImageUrl="../img/Row 1.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />
      </td>
                     </tr>
                    <tr runat="server" id="trplace">
                    <td id="Td18" style="padding: 5px;" runat="server" dir="<%$Resources:Master, dir%>" 
                            align="<%$Resources:Master, align%>" colspan="2">
                        <asp:Label ID="txtNotes" runat="server"></asp:Label>
                    </td>
                      <td valign="middle" align="left" style="background-image: url('../img/Row 2.jpg'); background-repeat: repeat-y; background-position: left top">
       <%--<asp:Image ID="Image34" ImageUrl="../img/Row 2.jpg" runat="server" ImageAlign="Top" 
                Width="21px" />--%>
      </td>
                </tr>
                

                </table>
              </fieldset>
                        </td>
                    </tr>
   
    
                </table>
                           
            </td>
           </tr>
     </table> 
              
    
</asp:Content>
