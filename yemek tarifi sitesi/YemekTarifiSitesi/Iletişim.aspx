<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Iletişim.aspx.cs" Inherits="YemekTarifiSitesi.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <script type="text/javascript">
       function SubmitForm() {
           var theform;
           if (window.navigator.appName.toUpperCase().indexOf("NETSCAPE") > -1) {
               theform = document.forms["form1"];
           }
           else {
               theform = document.forms.form1;
           }
           theform.__EVENTTARGET = "btn";
           theform.__EVENTARGUMENT = "";
           theform.submit();
       }
   </script>  
    
    <style type="text/css">
        .auto-style11 {
            width: 100%;
            height: 274px;
        }
        .auto-style12 {
            height: 30px;
        }
        .auto-style13 {
            height: 40px;
        }
        .auto-style14 {
            height: 33px;
        }
    </style>
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <table class="auto-style11">
        <tr>
            <td class="auto-style16">
                  <input  class="textbox6"type="text" id="username" name="username" placeholder="websitesi adı" />
        <input type="button" id="btn" onclick="SubmitForm()" value="GO" />

    <style>
        .textbox6 {
            padding: 1px 20px;
            border: 0;
            height: 25px;
            width: 275px;
            border-radius: 10px;
            -moz-border-radius: 10px;
            -webkit-border-radius: 10px;
            box-shadow: 1px 1px 0 0 #FFF, 5px 5px 40px 2px #BBB inset;
            -moz-box-shadow: 1px 1px 0 0 #FFF, 5px 5px 40px 2px #BBB inset;
            -webkit-box-shadow: 1px 1px 0 0 #FFF, 5px 5px 40px 2px #BBB inset;
            -webkit-background-clip: padding-box;
            outline: 0;
        }
    </style>
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style17"></td>
            <td class="auto-style14"></td>
        </tr>
        <tr>
            <td class="auto-style18">
                <asp:TextBox ID="TextBox1" CssClass="auto-style22" runat="server" OnTextChanged="TextBox1_TextChanged" placeholder="websitesi adını giriniz" Height="69px" TextMode="MultiLine" Width="241px" ></asp:TextBox>
                  <style>
        .textbox {
            background-color:aqua;
                      border-style: none;
                          border-color: inherit;
                          border-width: 0;
                          padding: 1px 20px;
                          border-radius: 10px;
                          -moz-border-radius: 10px;
                          -webkit-border-radius: 10px;
                          box-shadow: 1px 1px 0 0 #FFF, 5px 5px 40px 2px #BBB inset;
                          -moz-box-shadow: 1px 1px 0 0 #FFF, 5px 5px 40px 2px #BBB inset;
                          -webkit-box-shadow: 1px 1px 0 0 #FFF, 5px 5px 40px 2px #BBB inset;
                          -webkit-background-clip: padding-box;
                          outline: 0;
        }
                      .auto-style15 {
                          height: 187px;
                      }
                      .auto-style16 {
                          height: 30px;
                          width: 341px;
                      }
                      .auto-style17 {
                          height: 33px;
                          width: 341px;
                      }
                      .auto-style18 {
                          height: 40px;
                          width: 341px;
                      }
                      .auto-style19 {
                          height: 187px;
                          width: 341px;
                      }
                      .auto-style20 {
                          height: 59px;
                          width: 341px;
                      }
                      .auto-style21 {
                          height: 59px;
                      }
    </style>
  
          </td>
            <td class="auto-style13">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" Width="39px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:TextBox ID="TextBox2" CssClass="textbox2" runat="server" TextMode="MultiLine" Height="67px" Width="294px"></asp:TextBox>
               <style>
                .textbox2 {
  
  padding:8px 20px;

  border: 1px solid #eee;

  border-left: 3px solid;

  border-left-color:salmon; 

  border-radius: 5px;

  transition: border-color .8s ease-out;
    border-bottom: 2px solid red;
      background-color: #3CBC8D;

      color: pink;
}
                .textbox2:focus{

  outline:none;

  border: 1px solid #eee;

  border-left: 3px solid #888;
 

}
                   .auto-style22 {
                       border-radius: 10px;
                       -moz-border-radius: 10px;
                       -webkit-border-radius: 10px;
                       box-shadow: 1px 1px 0 0 #FFF, 5px 5px 40px 2px #BBB inset;
                       -moz-box-shadow: 1px 1px 0 0 #FFF, 5px 5px 40px 2px #BBB inset;
                       -webkit-box-shadow: 1px 1px 0 0 #FFF, 5px 5px 40px 2px #BBB inset;
                       -webkit-background-clip: padding-box;
                       outline-width: 0;
                       outline-style: none;
                       outline-color: invert;
                       border-style: none;
                       border-color: inherit;
                       border-width: 0;
                       padding: 1px 20px;
                       background-color: aqua;
                   }
                   </style>
            </td>
            <td class="auto-style21"></td>
        </tr>
        <tr>
            <td class="auto-style19">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="178px">
                     <asp:ListItem Text ="SEÇ MK" Value = ""></asp:ListItem>
        <asp:ListItem Text ="One" Value ="1"></asp:ListItem>
        <asp:ListItem Text ="Two" Value ="2"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style15">&nbsp;</td>
        </tr>
    </table>
 
</asp:Content>


<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
 
    <p>
        ss</p>
</asp:Content>



