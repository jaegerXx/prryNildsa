Public Class frmManRegistro
    Private ventana As ctrFormularios = New ctrFormularios

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ventana.mensajeConfirmar("¿Seguro desea Salir?") = True Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frmManRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmConRegistroPersona.Hide()
        txtId.Text = codigo
        txtCedula.Focus()
        txtTotalDescuento.Text = "0"
        cboNiveAcademico.SelectedIndex = 0
        cboGenero.SelectedIndex = 0
        rdb0.Checked = True
    End Sub

    Private Sub GuardarDatos()
        Try
            objPersona = New clsPersona(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtEdad.Text), Convert.ToInt32(txtNumHijos.Text), CStr(txtCedula.Text), CStr(txtApellido.Text), CStr(txtNombre.Text), CStr(cboGenero.SelectedItem), CStr(cboNiveAcademico.SelectedItem), CDbl(txtSueldoFijo.Text), CDbl(txtValo.Text), (CDbl(txtTotalDescuento.Text)), CDbl(txtTotalPagar.Text), CDbl(txtTotalIngresos.Text), CDbl(txtTotalEgresos.Text))

            array(contArray) = objPersona
            contArray = contArray + 1
        Catch ex As Exception
            ventana.mensaje("Ingrese correctamente Los datos")
        End Try

    End Sub

    Private Sub VaciarTodo()
        txtId.Text = ""
        txtApellido.Text = ""
        txtNombre.Text = ""
        txtCedula.Text = ""
        txtEdad.Text = ""
        txtNumHijos.Text = ""
        txtSueldoFijo.Text = ""
        txtTotalDescuento.Text = ""
        txtTotalEgresos.Text = ""
        txtTotalIngresos.Text = ""
        txtTotalPagar.Text = ""
        txtAnticipo.Text = ""
        txtHoras100.Text = ""
        txtHoras50.Text = ""
        txtP100.Text = ""
        txtP50.Text = ""
        txtValo.Text = ""
        cboNiveAcademico.SelectedIndex = 0
        cboGenero.SelectedIndex = 0



    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not (txtApellido.TextLength > 0 And txtCedula.TextLength > 0 And txtEdad.TextLength > 0 And txtId.TextLength > 0 And txtNombre.TextLength > 0 And txtNumHijos.TextLength > 0 And
            txtSueldoFijo.TextLength > 0 And txtTotalDescuento.TextLength > 0 And txtTotalEgresos.TextLength > 0 And txtTotalIngresos.TextLength > 0 And
            txtTotalPagar.TextLength > 0 And txtAnticipo.TextLength > 0) Then
            ventana.mensaje("Complete todos los campos")
        Else
            If ventana.mensajeConfirmar("Desea grabar registro") Then
                If grabar = "N" Then
                    GuardarDatos()
                    codigo = codigo + 1
                    ventana.mensaje("Registro Guardado")
                End If
                grabar = "ok"
                VaciarTodo()

                Me.Close()

            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        VaciarTodo()
        Me.Dispose()
    End Sub

    Private Sub calcularHoras100()
        Try
            If txtHoras100.TextLength > 0 Then
                txtP100.Text = Math.Round(((CDbl(txtValo.Text)) * CDbl(txtHoras100.Text)), 2)
            End If
        Catch ex As Exception
            ventana.mensaje("Ingrese correctamente la Cantidad")
        End Try

    End Sub

    Private Sub calcularHoras50()
        Try
            If txtHoras50.TextLength > 0 Then
                txtP50.Text = Math.Round(((CDbl(txtValo.Text) / 2) * CDbl(txtHoras50.Text)), 2)

            End If
        Catch ex As Exception
            ventana.mensaje("Ingrese correctamente la Cantidad")
        End Try

    End Sub

    Private Sub calcularIngresos()

        Try
            If txtSueldoFijo.TextLength > 0 And txtP100.TextLength > 0 And txtP50.TextLength > 0 Then
                txtTotalIngresos.Text = Math.Round((CDbl(txtSueldoFijo.Text) + CDbl(txtP100.Text) + CDbl(txtP50.Text)), 2)
            End If

        Catch ex As Exception
            ventana.mensaje("Ingrese correctamente la Cantidad")
        End Try
    End Sub

    Private Sub calcularTotalDescuento()

        Try
            If txtTotalIngresos.TextLength > 0 Then
                If rdb0.Checked Then
                    txtTotalDescuento.Text = Math.Round((CDbl(txtTotalIngresos.Text) * 0), 2)
                End If
                If rdb5.Checked Then
                    txtTotalDescuento.Text = Math.Round((CDbl(txtTotalIngresos.Text) * 0.05), 2)
                End If
                If rdb10.Checked Then
                    txtTotalDescuento.Text = Math.Round((CDbl(txtTotalIngresos.Text) * 0.1), 2)
                End If
                If rdb15.Checked Then
                    txtTotalDescuento.Text = Math.Round((CDbl(txtTotalIngresos.Text) * 0.15), 2)
                End If

            End If
        Catch ex As Exception
            ventana.mensaje("Ingrese correctamente la Cantidad")
        End Try
    End Sub

    Private Sub calcularEgresos()

        Try
            If txtTotalDescuento.TextLength > 0 And txtAnticipo.TextLength > 0 Then
                txtTotalEgresos.Text = Math.Round((CDbl(txtTotalDescuento.Text) + CDbl(txtAnticipo.Text)), 2)
            End If
        Catch ex As Exception
            ventana.mensaje("Ingrese correctamente la Cantidad")
        End Try

    End Sub

    Private Sub calcularTotaPagar()

        Try
            If txtTotalEgresos.TextLength > 0 And txtTotalIngresos.TextLength > 0 Then
                txtTotalPagar.Text = Math.Round((CDbl(txtTotalIngresos.Text) - CDbl(txtTotalEgresos.Text)), 2)
            End If
        Catch ex As Exception
            ventana.mensaje("Ingrese correctamente la Cantidad")
        End Try
    End Sub

    Private Sub cargarvalorHora()

        If txtSueldoFijo.TextLength > 0 Then
            Dim vhora As Double
            vhora = Val(txtSueldoFijo.Text) / 30
            vhora = Math.Round((vhora / 8), 2)

            txtValo.Text = vhora
        End If
    End Sub

    Private Sub txtSueldoFijo_TextChanged(sender As Object, e As EventArgs) Handles txtSueldoFijo.TextChanged
        cargarvalorHora()
        calcularIngresos()
        calcularTotalDescuento()
        calcularEgresos()
        calcularTotaPagar()
    End Sub

    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
        ventana.val_num(e)
    End Sub

    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
        ventana.val_num(e)
    End Sub

    Private Sub txtNumHijos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumHijos.KeyPress
        ventana.val_num(e)
    End Sub

    Private Sub txtSueldoFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSueldoFijo.KeyPress
        ventana.val_num(e)
    End Sub

    Private Sub txtValo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValo.KeyPress
        ventana.val_num(e)
    End Sub

    Private Sub txtTotalDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalDescuento.KeyPress
        ventana.val_num(e)
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        ventana.val_letras(e)
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        ventana.val_letras(e)
    End Sub

    Private Sub txtHoras50_TextChanged(sender As Object, e As EventArgs) Handles txtHoras50.TextChanged
        calcularHoras50()
        calcularTotalDescuento()
        calcularEgresos()
        calcularTotaPagar()
    End Sub

    Private Sub txtHoras100_TextChanged(sender As Object, e As EventArgs) Handles txtHoras100.TextChanged
        calcularHoras100()
        calcularTotalDescuento()
        calcularEgresos()
        calcularTotaPagar()
    End Sub

    Private Sub txtP50_TextChanged(sender As Object, e As EventArgs) Handles txtP50.TextChanged
        calcularIngresos()
    End Sub

    Private Sub txtP100_TextChanged(sender As Object, e As EventArgs) Handles txtP100.TextChanged
        calcularIngresos()
    End Sub

    Private Sub txtTotalDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtTotalDescuento.TextChanged
        calcularTotalDescuento()
        calcularEgresos()
        calcularTotaPagar()
    End Sub

    Private Sub rdb0_CheckedChanged(sender As Object, e As EventArgs) Handles rdb0.CheckedChanged
        calcularTotalDescuento()
    End Sub

    Private Sub rdb5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb5.CheckedChanged
        calcularTotalDescuento()
    End Sub

    Private Sub rdb10_CheckedChanged(sender As Object, e As EventArgs) Handles rdb10.CheckedChanged
        calcularTotalDescuento()
    End Sub

    Private Sub rdb15_CheckedChanged(sender As Object, e As EventArgs) Handles rdb15.CheckedChanged
        calcularTotalDescuento()
    End Sub

    Private Sub txtAnticipo_TextChanged(sender As Object, e As EventArgs) Handles txtAnticipo.TextChanged
        calcularEgresos()
        calcularTotaPagar()
    End Sub

    Private Sub txtTotalIngresos_TextChanged(sender As Object, e As EventArgs) Handles txtTotalIngresos.TextChanged
        calcularTotaPagar()
    End Sub

    Private Sub txtTotalEgresos_TextChanged(sender As Object, e As EventArgs) Handles txtTotalEgresos.TextChanged
        calcularTotaPagar()
    End Sub

    Private Sub frmManRegistro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmConRegistroPersona.Visible = True
    End Sub
End Class