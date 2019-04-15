Public Class ctrFormularios

    'metodo reutilizable para abrir formuarios
    Public Sub abrirFormulario(formularioAbrir As Form)
        formularioAbrir.ShowDialog()
    End Sub
    '*********************sms global para grabar datos*******************************************************'
    Public Function mensajeConfirmar(menj As String) As Boolean
        If MessageBox.Show(menj, "Registro Personas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
    '*****************************sms global para confirma algo***********************************************'
    Public Sub mensaje(menj As String)
        MessageBox.Show(menj, "Registro Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    'validar
    Public Sub val_letras(e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
        ElseIf (Char.IsDigit(e.KeyChar) Or ((Asc(e.KeyChar) = Keys.Back) And (Asc(e.KeyChar) = 46))) Then
            e.Handled = True
        End If
    End Sub

    Public Sub val_num(e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
        ElseIf Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or ((Asc(e.KeyChar) = Keys.Back) Or (Asc(e.KeyChar) = 46))) Then
            e.Handled = True
        End If
    End Sub

End Class
