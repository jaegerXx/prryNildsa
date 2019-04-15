Public Class frmMenu
    Private ventana As ctrFormularios = New ctrFormularios

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        ventana.abrirFormulario(frmConRegistroPersona)
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        If ventana.mensajeConfirmar("¿Seguro desea Salir?") = True Then
            Me.Visible = False
            frmLogin.Show()
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnMinimizar_Click_1(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class