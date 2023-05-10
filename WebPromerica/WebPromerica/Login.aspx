<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="WebPromerica.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login de Usuario Promerica</title>
    <style>
        body{
            background-color:beige
        }
    </style>
</head>
<body>
    <form id="loginPromerica" runat="server">
        <div>
            <table style="margin:auto;border:5px solid black"  id="tblDatos">
                <tr>
                   <td>
                        <asp:Label ID="Usuario" runat="server" Text="Usuario: "></asp:Label>
                    </td>
                    <td>
                        <asp:Textbox ID="txtUsuario" runat="server"></asp:Textbox>
                    </td>
                </tr>
                <tr>
                   <td>
                        <asp:Label ID="Label1" runat="server" Text="Contraseña: "></asp:Label>
                    </td>
                    <td>
                        <asp:Textbox ID="txtPassword" runat="server" TextMode="Password"></asp:Textbox>
                    </td>
                </tr>
                <tr>
                   <td></td>
                   <td>
                        <asp:Button Id="btnLogin" runat="server" text="Iniciar sesión" />
                    </td>
                    <td></td>
                </tr>
            </table>
            <table style="margin:auto" id="tblMensajeError">
                <tr>
                    <td>
                        <asp:Label ID="lblMensajeError" runat="server" Text="Para iniciar sesión debe ingresar usuario y contraseña." ForeColor="Red" />
                    </td>
                </tr>
            </table>
            <table style="margin:auto" id="tblInicioSesion">
                <tr>
                    <td>
                        <asp:Label ID="lblInicioSesion" runat="server" Text="HAS INICIADO SESIÓN" ForeColor="Blue" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
