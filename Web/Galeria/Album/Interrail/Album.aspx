<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Album.aspx.cs" Inherits="Interrail.Album" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/AlbumStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="MainData">
            <div id="Content">
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="date" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" ForeColor="Black" Text="Date"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="dateBox" runat="server" style="margin-left: 18px" Width="266px"></asp:TextBox>
                yyyy-mm-dd<br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Label ID="city" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" ForeColor="Black" Text="City"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="cityBox" runat="server" style="margin-left: 18px" Width="266px"></asp:TextBox>
                &nbsp;&nbsp;
                <br />
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Button ID="searchImg" runat="server" BackColor="#0066FF" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" ForeColor="White" Height="64px" OnClick="Button1_Click" Text="Search Image" Width="162px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="cancel" runat="server" BackColor="#0066FF" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" ForeColor="White" Height="64px" OnClick="Button4_Click" Text="Cancel" Width="162px" />
                <br />
            </div>
            <div id="Error">&nbsp;&nbsp;
                <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
                <br />&nbsp;&nbsp;&nbsp; </div>
        </div>
    </form>
</body>
</html>