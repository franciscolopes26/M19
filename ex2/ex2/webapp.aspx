<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webapp.aspx.cs" Inherits="ex2.webapp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Tabuada</h1>
            <asp:DropDownList ID="ddlist" runat="server" OnSelectedIndexChanged="ddlist_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="btn1" runat="server" Height="21px" Text="mostrar tabuada" Width="62px" OnClick="btn1_Click" />

        </div>
        <asp:ListBox ID="lbox1" runat="server"></asp:ListBox>
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">X</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server">0</asp:TableCell>
                <asp:TableCell runat="server">=</asp:TableCell>
            </asp:TableRow>
            
        </asp:Table>
    </form>
</body>
</html>
