<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cmain.aspx.cs" Inherits="Cmain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css"/>
    <title>Practica I</title>
    <style type="text/css">
        .auto-style1 {
            left: 170px;
            top: 70px;
            height: 236px;
            width: 423px;
        }
        .auto-style2 {
            height: 167px;
            width: 173px;
        }
    </style>
</head>
<body style="height: 227px; width: 771px;">
    <form id="form1" runat="server">
        <h1>Convertidor De Unidades</h1>
        <div class="auto-style2">
        <asp:Label ID="Label1" runat="server" Text="Inserte Valores:"></asp:Label>
        <br />
        <asp:TextBox class="corvetextbox" ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Convertir" Width="125px" OnClick="Button1_Click" />
            <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Equivale A:"></asp:Label>
        <br />
        <asp:TextBox class="corvetextbox" ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    </div>
        <div id="divtop" class="auto-style1" >
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Onzas A Libras"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RadioButton6" runat="server" Text="Metros A Pies"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RadioButton10" runat="server" Text="Pesos A Dolares"/>
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Libras A Kilogramos"/>
            &nbsp;&nbsp;<asp:RadioButton ID="RadioButton7" runat="server" Text="Pulgadas A Pies"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton11" runat="server" Text="Euros A Pesos"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Libras A Onzas"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:RadioButton ID="RadioButton8" runat="server" Text="Metros A Kilometros"/>
            &nbsp;
            <asp:RadioButton ID="RadioButton12" runat="server" Text="Dolares A Pesos" />
            <br />
            <asp:RadioButton ID="RadioButton4" runat="server" Text="Libra A Gramos"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton9" runat="server" Text="Kilometros A Pulgadas" Checked="false"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:RadioButton ID="RadioButton5" runat="server" Text="Kilogramos A Onza"/>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
