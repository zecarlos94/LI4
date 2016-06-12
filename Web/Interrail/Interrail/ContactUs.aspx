<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Interrail.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/ContactUsStyle.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #Content {
            width: 544px;
        }
    </style>
</head>
<body style="height: 502px; width: 616px; margin-left: 360px">
    <form id="form1" runat="server">
        <div id="MainData">
            <div id="Content">
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" ForeColor="Black" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="EmailBox" runat="server" style="margin-left: 1px" Width="319px"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" ForeColor="Black" Text="Subject"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="SubjectBox" runat="server" style="margin-left: 15px" Width="319px"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" ForeColor="Black" Text="Message"></asp:Label>
                &nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="MessageBox" runat="server" style="margin-left: 55px" Width="323px" Height="172px"></asp:TextBox>
                <br />&nbsp;&nbsp;&nbsp;<br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#0066FF" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" ForeColor="White" Height="64px" OnClick="Button1_Click" Text="Sent Message" Width="162px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#0066FF" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" ForeColor="White" Height="64px" OnClick="Button2_Click" Text="Cancel" Width="162px" />
            </div>
            <div id="Error">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
                <br />
&nbsp;&nbsp;&nbsp; </div>
        </div>
    </form>
</body>
</html>
