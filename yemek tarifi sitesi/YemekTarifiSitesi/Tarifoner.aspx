<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Tarifoner.aspx.cs" Inherits="YemekTarifiSitesi.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
        width: 100%;
        height: 24px;
    }
    .auto-style4 {
        height: 23px;
        margin-left: 80px;
    }
    .auto-style5 {
        height: 23px;
        text-align: right;
        text-decoration: underline;
        font-weight: bold;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style3">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Tarif Ad:</td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox1" runat="server" Width="280px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Malzemeler:</td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox2" runat="server" Height="80px" TextMode="MultiLine" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Yapılış:</td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox3" runat="server" Height="100px" TextMode="MultiLine" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Resim:</td>
        <td class="auto-style4">
            <asp:FileUpload ID="FileUpload1" runat="server" Width="280px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Tarifi Öneren:</td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox4" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Mail Adresi:</td>
        <td class="auto-style4">
            <asp:TextBox ID="TextBox5" runat="server" Width="280px" TextMode="Email"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Gönder---&gt;&gt;&gt;</td>
        <td class="auto-style4">
            &nbsp;<asp:Button ID="Button1" runat="server" Text="Tarif Öner" Width="150px" Height="30px" OnClick="Button1_Click" />
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <p class="auto-style3">
        KATEGORİLER </p><asp:DataList ID="DataList1" runat="server" Width="198px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged1">
        <ItemTemplate>
            <div style="border: thin dashed #800080">
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("KategoriAd") %>'></asp:Label>
                (
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("KategoriAdet") %>'></asp:Label>
                )</div>
        </ItemTemplate>
</asp:DataList>
   
    </asp:Content>