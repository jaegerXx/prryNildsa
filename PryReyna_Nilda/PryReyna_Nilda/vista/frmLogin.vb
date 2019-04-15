Public Class frmLogin
    Private ventana As ctrFormularios = New ctrFormularios

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsuario.Text = "admin" And txtpPassword.Text = "123" Then
            limpiar()
            Me.Hide()
            ventana.abrirFormulario(New frmMenu)
        Else
            ventana.mensaje("Usuario y/o Contraseña Incorrecta")
        End If
    End Sub
    Private Sub limpiar()
        txtUsuario.Text = ""
        txtpPassword.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If ventana.mensajeConfirmar("¿Seguro desea Salir?") = True Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


End Class
