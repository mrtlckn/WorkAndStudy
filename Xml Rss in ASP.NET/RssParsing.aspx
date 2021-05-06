<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RssParsing.aspx.cs" Inherits="WebApplication15.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 800px;
            height: 253px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <h3>&nbsp;<img class="auto-style1" src="image/New-York-Times-Logo8x6_0.png" /></h3><br />
         <asp:Button ID="btnWorld" runat="server" Text="World"  OnClick="btnSubmit_Click"/>
        <asp:Button ID="bntTech" runat="server" OnClick="Button1_Click" Text="Technology" Width="118px" />
        <asp:Button ID="btnSport" runat="server" OnClick="btnSport_Click" Text="Sports" Width="117px" />
        <asp:Button ID="btnScience" runat="server" OnClick="btnScience_Click" Text="Science" />
        <asp:Button ID="btnHealth" runat="server" OnClick="Button2_Click" Text="Health" />
        <asp:Button ID="btnTravel" runat="server" OnClick="Button1_Click1" Text="Travel" />
        <asp:Button ID="btnArts" runat="server" OnClick="btnArts_Click" Text="Arts" />
        <asp:Button ID="btnJobs" runat="server" OnClick="btnJobs_Click" Text="Jobs" />
        <br /><br /><br />
    <h3>Here are the latest news</h3><br />
    <div style="max-height: 350px; overflow: auto">
        <asp:GridView ID="gvRss" runat="server" AutoGenerateColumns="false" ShowHeader="false" Width="90%">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table width="100%" border="0" cellpadding="0" cellspacing="5">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="cbxAddNews" runat="server" />
                                </td>
                                <td>
                                    <h3 style="color: #3E7CFF"><%#Eval("Title") %></h3>
                                </td>
                                <td width="200px">
                                    <%#Eval("PublishDate") %>
                                </td>
                                
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <hr />
                                    <%#Eval("Description") %>
                                </td>
                                 
                                

                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td align="right">
                                    <a href='<%#Eval("Link") %>' target="_blank">Read More...</a>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
