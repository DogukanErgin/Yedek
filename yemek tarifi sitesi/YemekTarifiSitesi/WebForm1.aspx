<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="YemekTarifiSitesi.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            font-size: large;
            text-align: center;
            color: #ffd800;
        }

        .auto-style11 {
            width: 100%;
        }
        .auto-style12 {
            height: 24px;
        }

    </style>
   
       <link href="StyleSheet1.css" rel="stylesheet" />
   
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:DataList ID="DataList2" runat="server" Width="395px">
        <ItemTemplate>
            <table class="auto-style11">
                <tr>
                    <td class="auto-style12" style="background-color: #66FFCC; text-align: center;">
                      <a href="YemekDetay.aspx?Yemekid=<%# Eval("Yemekid") %>"><asp:Label ID="Label3" runat="server" style="font-weight: 700; font-size: large; background-color: #FF9900; text-align: center;" Text='<%# Eval("YemekAd") %>'></asp:Label></a>
                    </td>
                </tr>
                <tr>
                    <td><strong>MALZEMELER:</strong><asp:Label ID="Label4" runat="server" Text='<%# Eval("yemekmalzeme") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><em>TARİF:</em><asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Eklenme Tarihi:<asp:Label ID="Label6" runat="server" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Puan----&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label7" runat="server" style="color: #000066; background-color: #99FF99" Text='<%# Eval("YemekPuan") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
  
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <p class="auto-style3">
        KATEGORİLER</p>
    <asp:DataList ID="DataList1" runat="server" Width="198px">
        <ItemTemplate>
            <div style="border: thin dashed #800080">
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("KategoriAd") %>'></asp:Label>
                (
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("KategoriAdet") %>'></asp:Label>
                )</div>
        </ItemTemplate>
</asp:DataList>
</asp:Content>