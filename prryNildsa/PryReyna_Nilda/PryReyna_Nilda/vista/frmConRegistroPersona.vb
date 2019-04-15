Public Class frmConRegistroPersona
    Private ventana As ctrFormularios = New ctrFormularios

    Private Sub cargarGrid()
        dgConsulta.Rows.Clear()
        'dgConsulta.Rows.Add(objPersona.id, objPersona.cedula, objPersona.apellido, objPersona.nombre, objPersona.edad, objPersona.numHijos,
        '       objPersona.nivelAcademico, objPersona.genero, objPersona.sueldoFijo, objPersona.valorHora, objPersona.totalDescuento, objPersona.totalIngresos, objPersona.totalEgresos, objPersona.totalPagar)
        For i = 0 To contArray - 1 Step 1
            dgConsulta.Rows.Add(array(i).id, array(i).cedula, array(i).apellido, array(i).nombre, array(i).edad,
               array(i).numHijos, array(i).nivelAcademico, array(i).genero, array(i).sueldoFijo, array(i).valorHora, array(i).totalDescuento,
                     array(i).totalIngresos, array(i).totalEgresos, array(i).totalPagar)
        Next

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnNuevo_GotFocus(sender As Object, e As EventArgs) Handles btnNuevo.GotFocus
        If grabar.Equals("ok") Then
            dgConsulta.ClearSelection()
            cargarGrid()
            grabar = ""
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        grabar = "N"
        ventana.abrirFormulario(frmManRegistro)
    End Sub

    Private Sub dgConsulta_Click(sender As Object, e As EventArgs) Handles dgConsulta.Click
        Try
            If dgConsulta.CurrentCell.ColumnIndex = 14 Then
                dgConsulta.Rows.Remove(dgConsulta.CurrentRow)
                ventana.mensaje("Registro Eliminado")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmConRegistroPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgConsulta.ClearSelection()
        cargarGrid()
    End Sub

    Private Sub obtenerMayor()
        Dim mayor As Double
        mayor = array(0).totalPagar
        For i = 0 To contArray - 1 Step 1
            If array(i).totalPagar > mayor Then
                mayor = array(i).totalPagar
            End If
        Next
        txtMayor.Text = mayor
    End Sub
    Private Sub obtenerMenor()
        Dim menor As Double
        menor = array(0).totalPagar
        For i = 0 To contArray - 1 Step 1
            If array(i).totalPagar < menor Then
                menor = array(i).totalPagar
            End If
        Next
        txtMenor.Text = menor
    End Sub
    Private Sub obtenerTotal()
        Dim total As Double = 0

        For i = 0 To contArray - 1 Step 1

            total = array(i).totalPagar + total

        Next
        txtTotal.Text = total
    End Sub

    Private Sub btnMenor_Click(sender As Object, e As EventArgs) Handles btnMenor.Click
        obtenerMenor()
    End Sub

    Private Sub btnMayor_Click(sender As Object, e As EventArgs) Handles btnMayor.Click
        obtenerMayor()

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        obtenerTotal()
    End Sub
End Class