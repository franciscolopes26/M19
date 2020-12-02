<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webapp.aspx.cs" Inherits="ex1_certo.webapp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            <asp:Button ID="btn1" runat="server" Text="Button" OnClick="btn1_Click" />
        </div>
        <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
