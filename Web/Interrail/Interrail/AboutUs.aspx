<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="Interrail.AboutUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/AboutUsStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="MainData">
            <div id="ProjectTitle">
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="XX-Large" ForeColor="White" Text="Our work"></asp:Label>
            </div>
            <div id="ProjectContent">
                <div id="ProjectText">The &quot;TravellingAssistant&quot; project is innovative and aims to help thousands of people in their travels, by providing a set of tools to structure the best possible way the time used in these, avoiding discouragement situations caused by the impossibility of visiting all those magnificent places intended for, due to lack of time. Now it is possible to organize your time so you can do everything you want and more...</div>
            </div>
            <div id="TeamTitle">
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="XX-Large" ForeColor="White" Text="Who we are?"></asp:Label>
            </div>
            <div id="TeamContent">
                <div id="TeamText">Our team consists of four young students of the Computer Engineering course in University of Minho, as part of the Computer Labs IV discipline, which allowed us to explore a set of new tools and apply a software development process.<br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image1" runat="server" Height="86px" ImageUrl="~/images/A71751.jpg" Width="103px" />
&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image2" runat="server" Height="86px" ImageUrl="~/images/A72223.png" Width="103px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image3" runat="server" Height="86px" ImageUrl="~/images/A71223.png" Width="103px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image4" runat="server" Height="86px" ImageUrl="~/images/A70443.png" Width="103px" />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Font-Names="Calibri" Font-Size="Smaller" Text="André Pinto"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Font-Names="Calibri" Font-Size="Smaller" Text="Gustavo Gomes"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" Font-Names="Calibri" Font-Size="Smaller" Text="José Gonçalves"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label6" runat="server" Font-Names="Calibri" Font-Size="Smaller" Text="Tiago Carvalhais"></asp:Label>
                </div>
            </div>
            <div id="Error">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Overline="False" Font-Size="Larger" ForeColor="White" OnClick="LinkButton1_Click1">Back</asp:LinkButton>
                <br />
&nbsp;&nbsp;&nbsp; </div>
        </div>
    </form>
</body>
</html>


