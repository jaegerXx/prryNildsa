<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManRegistro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtNumHijos = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboNiveAcademico = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtValo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSueldoFijo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTotalIngresos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtP100 = New System.Windows.Forms.TextBox()
        Me.txtHoras50 = New System.Windows.Forms.TextBox()
        Me.txtP50 = New System.Windows.Forms.TextBox()
        Me.txtHoras100 = New System.Windows.Forms.TextBox()
        Me.txtTotalDescuento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.rdb15 = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalEgresos = New System.Windows.Forms.TextBox()
        Me.rdb10 = New System.Windows.Forms.RadioButton()
        Me.txtAnticipo = New System.Windows.Forms.TextBox()
        Me.rdb0 = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rdb5 = New System.Windows.Forms.RadioButton()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(129, 30)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(57, 21)
        Me.txtId.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cedula"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Edad"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(229, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Registro De Personal/Pagos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Número de Hijos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(129, 65)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(143, 21)
        Me.txtCedula.TabIndex = 9
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(129, 99)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(143, 21)
        Me.txtApellido.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(129, 135)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(143, 21)
        Me.txtNombre.TabIndex = 11
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(129, 168)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(143, 21)
        Me.txtEdad.TabIndex = 12
        '
        'txtNumHijos
        '
        Me.txtNumHijos.Location = New System.Drawing.Point(128, 269)
        Me.txtNumHijos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumHijos.Name = "txtNumHijos"
        Me.txtNumHijos.Size = New System.Drawing.Size(143, 21)
        Me.txtNumHijos.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cboNiveAcademico)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cboGenero)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtId)
        Me.GroupBox2.Controls.Add(Me.txtNumHijos)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtEdad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtApellido)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCedula)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 48)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(314, 352)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Personales"
        '
        'cboNiveAcademico
        '
        Me.cboNiveAcademico.FormattingEnabled = True
        Me.cboNiveAcademico.Items.AddRange(New Object() {"Primaria", "Secudaria", "Tercer Nivel", "Cuarto Nivel"})
        Me.cboNiveAcademico.Location = New System.Drawing.Point(127, 232)
        Me.cboNiveAcademico.Name = "cboNiveAcademico"
        Me.cboNiveAcademico.Size = New System.Drawing.Size(144, 24)
        Me.cboNiveAcademico.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 237)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 16)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Nivel Académico"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboGenero
        '
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"Masculino", "Femenino", "GLBTI"})
        Me.cboGenero.Location = New System.Drawing.Point(128, 196)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(144, 24)
        Me.cboGenero.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(73, 199)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 16)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Género"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtValo)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtSueldoFijo)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtTotalIngresos)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtP100)
        Me.GroupBox3.Controls.Add(Me.txtHoras50)
        Me.GroupBox3.Controls.Add(Me.txtP50)
        Me.GroupBox3.Controls.Add(Me.txtHoras100)
        Me.GroupBox3.Location = New System.Drawing.Point(359, 53)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(337, 184)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rubro/Pagos"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(227, 153)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 16)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "$"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(89, 30)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 16)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "$"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(267, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 16)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "$"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(229, 105)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 16)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "$"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(229, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 16)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "$"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(207, 106)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 16)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "="
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValo
        '
        Me.txtValo.Enabled = False
        Me.txtValo.Location = New System.Drawing.Point(286, 25)
        Me.txtValo.Name = "txtValo"
        Me.txtValo.Size = New System.Drawing.Size(40, 21)
        Me.txtValo.TabIndex = 28
        Me.txtValo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(195, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Valor Hora"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(207, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 16)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "="
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Sueldo Fijo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSueldoFijo
        '
        Me.txtSueldoFijo.Location = New System.Drawing.Point(108, 27)
        Me.txtSueldoFijo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSueldoFijo.Name = "txtSueldoFijo"
        Me.txtSueldoFijo.Size = New System.Drawing.Size(61, 21)
        Me.txtSueldoFijo.TabIndex = 18
        Me.txtSueldoFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(66, 105)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 16)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Horas 100%"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalIngresos
        '
        Me.txtTotalIngresos.Enabled = False
        Me.txtTotalIngresos.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.txtTotalIngresos.Location = New System.Drawing.Point(245, 150)
        Me.txtTotalIngresos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalIngresos.Name = "txtTotalIngresos"
        Me.txtTotalIngresos.Size = New System.Drawing.Size(85, 21)
        Me.txtTotalIngresos.TabIndex = 26
        Me.txtTotalIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(130, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Total Ingresos"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(68, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 16)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Horas 50%"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtP100
        '
        Me.txtP100.Enabled = False
        Me.txtP100.Location = New System.Drawing.Point(247, 103)
        Me.txtP100.Name = "txtP100"
        Me.txtP100.Size = New System.Drawing.Size(47, 21)
        Me.txtP100.TabIndex = 20
        Me.txtP100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHoras50
        '
        Me.txtHoras50.Location = New System.Drawing.Point(161, 72)
        Me.txtHoras50.Name = "txtHoras50"
        Me.txtHoras50.Size = New System.Drawing.Size(40, 21)
        Me.txtHoras50.TabIndex = 17
        Me.txtHoras50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtP50
        '
        Me.txtP50.Enabled = False
        Me.txtP50.Location = New System.Drawing.Point(247, 73)
        Me.txtP50.Name = "txtP50"
        Me.txtP50.Size = New System.Drawing.Size(47, 21)
        Me.txtP50.TabIndex = 18
        Me.txtP50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHoras100
        '
        Me.txtHoras100.Location = New System.Drawing.Point(161, 103)
        Me.txtHoras100.Name = "txtHoras100"
        Me.txtHoras100.Size = New System.Drawing.Size(40, 21)
        Me.txtHoras100.TabIndex = 19
        Me.txtHoras100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDescuento
        '
        Me.txtTotalDescuento.Enabled = False
        Me.txtTotalDescuento.Location = New System.Drawing.Point(239, 20)
        Me.txtTotalDescuento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalDescuento.Name = "txtTotalDescuento"
        Me.txtTotalDescuento.Size = New System.Drawing.Size(88, 21)
        Me.txtTotalDescuento.TabIndex = 29
        Me.txtTotalDescuento.Text = "0"
        Me.txtTotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(117, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Total  Descuento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.rdb15)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.txtTotalDescuento)
        Me.GroupBox6.Controls.Add(Me.txtTotalEgresos)
        Me.GroupBox6.Controls.Add(Me.rdb10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.txtAnticipo)
        Me.GroupBox6.Controls.Add(Me.rdb0)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.rdb5)
        Me.GroupBox6.Location = New System.Drawing.Point(359, 247)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(337, 153)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Descuento"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(224, 126)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 16)
        Me.Label28.TabIndex = 42
        Me.Label28.Text = "$"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(223, 58)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 16)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "$"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(223, 21)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 16)
        Me.Label26.TabIndex = 40
        Me.Label26.Text = "$"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdb15
        '
        Me.rdb15.AutoSize = True
        Me.rdb15.Location = New System.Drawing.Point(54, 113)
        Me.rdb15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdb15.Name = "rdb15"
        Me.rdb15.Size = New System.Drawing.Size(47, 20)
        Me.rdb15.TabIndex = 30
        Me.rdb15.TabStop = True
        Me.rdb15.Text = "15%"
        Me.rdb15.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(133, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 19)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Total Egresos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalEgresos
        '
        Me.txtTotalEgresos.Enabled = False
        Me.txtTotalEgresos.ForeColor = System.Drawing.Color.Brown
        Me.txtTotalEgresos.Location = New System.Drawing.Point(239, 124)
        Me.txtTotalEgresos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalEgresos.Name = "txtTotalEgresos"
        Me.txtTotalEgresos.Size = New System.Drawing.Size(88, 21)
        Me.txtTotalEgresos.TabIndex = 27
        Me.txtTotalEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdb10
        '
        Me.rdb10.AutoSize = True
        Me.rdb10.Location = New System.Drawing.Point(54, 87)
        Me.rdb10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdb10.Name = "rdb10"
        Me.rdb10.Size = New System.Drawing.Size(47, 20)
        Me.rdb10.TabIndex = 17
        Me.rdb10.TabStop = True
        Me.rdb10.Text = "10%"
        Me.rdb10.UseVisualStyleBackColor = True
        '
        'txtAnticipo
        '
        Me.txtAnticipo.Location = New System.Drawing.Point(240, 55)
        Me.txtAnticipo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAnticipo.Name = "txtAnticipo"
        Me.txtAnticipo.Size = New System.Drawing.Size(87, 21)
        Me.txtAnticipo.TabIndex = 26
        Me.txtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdb0
        '
        Me.rdb0.AutoSize = True
        Me.rdb0.Checked = True
        Me.rdb0.Location = New System.Drawing.Point(53, 28)
        Me.rdb0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdb0.Name = "rdb0"
        Me.rdb0.Size = New System.Drawing.Size(41, 20)
        Me.rdb0.TabIndex = 15
        Me.rdb0.TabStop = True
        Me.rdb0.Text = "0%"
        Me.rdb0.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(160, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Anticipo"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdb5
        '
        Me.rdb5.AutoSize = True
        Me.rdb5.Location = New System.Drawing.Point(53, 59)
        Me.rdb5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdb5.Name = "rdb5"
        Me.rdb5.Size = New System.Drawing.Size(41, 20)
        Me.rdb5.TabIndex = 16
        Me.rdb5.TabStop = True
        Me.rdb5.Text = "5%"
        Me.rdb5.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Teal
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(362, 497)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnGuardar.TabIndex = 31
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Teal
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(256, 497)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(515, 445)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 19)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Total a Pagar"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.Enabled = False
        Me.txtTotalPagar.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtTotalPagar.Location = New System.Drawing.Point(629, 444)
        Me.txtTotalPagar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(66, 21)
        Me.txtTotalPagar.TabIndex = 31
        Me.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Maroon
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(693, 6)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(28, 28)
        Me.btnCerrar.TabIndex = 61
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.txtTotalPagar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 543)
        Me.Panel1.TabIndex = 62
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(614, 446)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 16)
        Me.Label29.TabIndex = 43
        Me.Label29.Text = "$"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnMinimizar)
        Me.Panel2.Controls.Add(Me.btnCerrar)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(725, 41)
        Me.Panel2.TabIndex = 62
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackColor = System.Drawing.Color.Maroon
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Location = New System.Drawing.Point(757, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(34, 30)
        Me.btnMinimizar.TabIndex = 11
        Me.btnMinimizar.Text = "___"
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'frmManRegistro
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(733, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmManRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistro"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtNumHijos As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSueldoFijo As TextBox
    Friend WithEvents txtTotalDescuento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rdb10 As RadioButton
    Friend WithEvents rdb0 As RadioButton
    Friend WithEvents rdb5 As RadioButton
    Friend WithEvents txtAnticipo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalIngresos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotalEgresos As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents cboGenero As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboNiveAcademico As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtValo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtP100 As TextBox
    Friend WithEvents txtHoras50 As TextBox
    Friend WithEvents txtP50 As TextBox
    Friend WithEvents txtHoras100 As TextBox
    Friend WithEvents rdb15 As RadioButton
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
End Class
