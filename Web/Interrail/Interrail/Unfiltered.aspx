<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Unfiltered.aspx.cs" Inherits="Interrail.Unfiltered" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 80px">
        <asp:DropDownList ID="ddlImages" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="FetchImage">
            <asp:ListItem Text="Select Image" Value="0" />
        </asp:DropDownList>
        <hr />
        <asp:Image ID="Image1" height="512" Width="512" runat="server" Visible="false" />
         <br />
         <br />
        <br />
&nbsp;<asp:Button ID="cancel" runat="server" BackColor="#0066FF" Font-Bold="True" Font-Names="Calibri" Font-Size="Larger" ForeColor="White" Height="64px" OnClick="Button1_Click" Text="Cancel" Width="162px" />
    </div>
    </form>
</body>
</html>
