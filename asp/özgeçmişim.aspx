<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="özgeçmişim.aspx.cs" Inherits="website.özgeçmişim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> e yani
            anasayfaya dönmek için <a href ="giris-sayfa.aspx">buradan </a> <br /> 


           indexe gitmek için <a href="index.aspx">indexe gider</a>
        </div>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="ASP.Net" />
        <p>
            <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Viusal Basic" />
        </p>
        <p>
            <asp:CheckBox ID="CheckBox3" runat="server" Text="PHP" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Toplam ücret:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
