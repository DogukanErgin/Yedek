<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giris-sayfa.aspx.cs" Inherits="website.giris_sayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> TheSkeel sayfası </title>
    </head>
<body bgcolor ="432643">

    <p><big>deniyorum </big>Benim cv = <a href="özgeçmişim.aspx">özgeçmişim</a> </p>
    <form id="form1" runat="server">

        <div> 
            bu sayfa yeni basladi
            <h2>bu sayfa yeni basladi</h2>-----
        </div> 
        <asp:Panel ID="Panel1" runat="server">
            <asp:ImageButton ID="ImageButton1" runat="server" Height="145px" OnClick="ImageButton1_Click" Width="245px" ImageUrl="~/Resimler/indir.jfif" />
            
        </asp:Panel>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" BackColor="#CCFFCC" ForeColor="#009933" NavigateUrl="~/özgeçmişim.aspx">HyperLink</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" />
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile1.xml" OnTransforming="XmlDataSource1_Transforming"></asp:XmlDataSource>
            Reklammm</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
