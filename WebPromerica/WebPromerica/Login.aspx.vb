Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Se oculta el mensaje de error al iniciar proyecto y también mensaje de inicio de sesión. 
        lblMensajeError.Visible = False
        lblInicioSesion.Visible = False
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Se valida que el usuario y contraseña no estén vacíos al querer iniciar sesión. 
        If (txtPassword.Text.Length = 0 Or txtPassword.Text = "") Or (txtUsuario.Text.Length = 0 Or txtUsuario.Text = "") Then
            lblMensajeError.Visible = True
            lblInicioSesion.Visible = False
        Else
            lblInicioSesion.Visible = True
            lblMensajeError.Visible = False
        End If
        txtUsuario.Text = Nothing
        txtPassword.Text = Nothing
    End Sub
End Class