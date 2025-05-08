<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookForm.aspx.cs" Inherits="BookApplication.BookForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 520px">
            <asp:Label ID="Label1" runat="server" Height="39px" Text="LIBRARY MANAGEMENT"></asp:Label>
            <br />
            <br />
        </div>
        <div style="margin-left: 360px">
            <asp:Label ID="Label2" runat="server" Text="BOOK ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="285px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="BOOK NAME"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="273px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="AUTHOR NAME"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="225px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="PUBLISHER"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="267px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="YEAR OF PUBLICATION"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="QUANTITY"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Width="229px"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" Width="137px" />
        </div>
    </form>
</body>
</html>
