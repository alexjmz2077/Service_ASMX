<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina.aspx.cs" Inherits="Cliente.Pagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="Grilla" runat="server">
            </asp:GridView>
            <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" OnClick="BtnConsultar_Click" />
            <br />
        </div>
    </form>
</body>
</html>
