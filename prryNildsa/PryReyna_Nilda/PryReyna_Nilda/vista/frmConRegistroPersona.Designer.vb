<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConRegistroPersona
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgConsulta = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumHijos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nivelAcademico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sueldoFijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnMenor = New System.Windows.Forms.Button()
        Me.btnMayor = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtMayor = New System.Windows.Forms.TextBox()
        Me.txtMenor = New System.Windows.Forms.TextBox()
        CType(Me.dgConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Teal
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(9, 107)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(111, 30)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'dgConsulta
        '
        Me.dgConsulta.AllowUserToAddRows = False
        Me.dgConsulta.BackgroundColor = System.Drawing.Color.White
        Me.dgConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Cedula, Me.Apellido, Me.Nombre, Me.Edad, Me.NumHijos, Me.nivelAcademico, Me.Genero, Me.sueldoFijo, Me.valorHora, Me.totalDescuento, Me.totalIngreso, Me.totalEgreso, Me.totalPagar, Me.Eliminar})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgConsulta.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgConsulta.EnableHeadersVisualStyles = False
        Me.dgConsulta.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dgConsulta.Location = New System.Drawing.Point(9, 156)
        Me.dgConsulta.Margin = New System.Windows.Forms.Padding(2)
        Me.dgConsulta.Name = "dgConsulta"
        Me.dgConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsulta.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgConsulta.RowTemplate.Height = 24
        Me.dgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConsulta.Size = New System.Drawing.Size(882, 231)
        Me.dgConsulta.TabIndex = 59
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Width = 50
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "Cedula"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Width = 80
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Width = 80
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 80
        '
        'Edad
        '
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        Me.Edad.Width = 50
        '
        'NumHijos
        '
        Me.NumHijos.HeaderText = "Numero Hijos"
        Me.NumHijos.Name = "NumHijos"
        Me.NumHijos.Width = 56
        '
        'nivelAcademico
        '
        Me.nivelAcademico.HeaderText = "nive Académico"
        Me.nivelAcademico.Name = "nivelAcademico"
        Me.nivelAcademico.Width = 80
        '
        'Genero
        '
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        Me.Genero.Width = 80
        '
        'sueldoFijo
        '
        Me.sueldoFijo.HeaderText = "sueldo Fijo"
        Me.sueldoFijo.Name = "sueldoFijo"
        Me.sueldoFijo.Width = 70
        '
        'valorHora
        '
        Me.valorHora.HeaderText = "valor Hora"
        Me.valorHora.Name = "valorHora"
        Me.valorHora.Width = 50
        '
        'totalDescuento
        '
        Me.totalDescuento.HeaderText = "total descuento"
        Me.totalDescuento.Name = "totalDescuento"
        Me.totalDescuento.Width = 80
        '
        'totalIngreso
        '
        Me.totalIngreso.HeaderText = "total Ingreso"
        Me.totalIngreso.Name = "totalIngreso"
        Me.totalIngreso.Width = 80
        '
        'totalEgreso
        '
        Me.totalEgreso.HeaderText = "total Egreso"
        Me.totalEgreso.Name = "totalEgreso"
        Me.totalEgreso.Width = 80
        '
        'totalPagar
        '
        Me.totalPagar.HeaderText = "totalvPagar"
        Me.totalPagar.Name = "totalPagar"
        Me.totalPagar.Width = 80
        '
        'Eliminar
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle6
        Me.Eliminar.HeaderText = "Accion"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        Me.Eliminar.Width = 60
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Maroon
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(884, 3)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(26, 27)
        Me.btnCerrar.TabIndex = 60
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtMenor)
        Me.Panel1.Controls.Add(Me.txtMayor)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.btnTotal)
        Me.Panel1.Controls.Add(Me.btnMayor)
        Me.Panel1.Controls.Add(Me.btnMenor)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dgConsulta)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(912, 438)
        Me.Panel1.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(380, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(254, 35)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Consulta de personal"
        '
        'btnMenor
        '
        Me.btnMenor.BackColor = System.Drawing.Color.Teal
        Me.btnMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenor.ForeColor = System.Drawing.Color.White
        Me.btnMenor.Location = New System.Drawing.Point(685, 107)
        Me.btnMenor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMenor.Name = "btnMenor"
        Me.btnMenor.Size = New System.Drawing.Size(111, 30)
        Me.btnMenor.TabIndex = 63
        Me.btnMenor.Text = "Menor Sueldo"
        Me.btnMenor.UseVisualStyleBackColor = False
        '
        'btnMayor
        '
        Me.btnMayor.BackColor = System.Drawing.Color.Teal
        Me.btnMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMayor.ForeColor = System.Drawing.Color.White
        Me.btnMayor.Location = New System.Drawing.Point(437, 107)
        Me.btnMayor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMayor.Name = "btnMayor"
        Me.btnMayor.Size = New System.Drawing.Size(111, 30)
        Me.btnMayor.TabIndex = 64
        Me.btnMayor.Text = "Mayor Sueldo"
        Me.btnMayor.UseVisualStyleBackColor = False
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.Teal
        Me.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTotal.ForeColor = System.Drawing.Color.White
        Me.btnTotal.Location = New System.Drawing.Point(208, 107)
        Me.btnTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(111, 30)
        Me.btnTotal.TabIndex = 65
        Me.btnTotal.Text = "Total Sueldo"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(327, 113)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 66
        '
        'txtMayor
        '
        Me.txtMayor.Enabled = False
        Me.txtMayor.Location = New System.Drawing.Point(555, 113)
        Me.txtMayor.Name = "txtMayor"
        Me.txtMayor.Size = New System.Drawing.Size(100, 20)
        Me.txtMayor.TabIndex = 67
        '
        'txtMenor
        '
        Me.txtMenor.Enabled = False
        Me.txtMenor.Location = New System.Drawing.Point(803, 113)
        Me.txtMenor.Name = "txtMenor"
        Me.txtMenor.Size = New System.Drawing.Size(100, 20)
        Me.txtMenor.TabIndex = 68
        '
        'frmConRegistroPersona
        '
        Me.AcceptButton = Me.btnNuevo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(924, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConRegistroPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConRegistroPersona"
        CType(Me.dgConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Public WithEvents dgConsulta As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Cedula As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Edad As DataGridViewTextBoxColumn
    Friend WithEvents NumHijos As DataGridViewTextBoxColumn
    Friend WithEvents nivelAcademico As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents sueldoFijo As DataGridViewTextBoxColumn
    Friend WithEvents valorHora As DataGridViewTextBoxColumn
    Friend WithEvents totalDescuento As DataGridViewTextBoxColumn
    Friend WithEvents totalIngreso As DataGridViewTextBoxColumn
    Friend WithEvents totalEgreso As DataGridViewTextBoxColumn
    Friend WithEvents totalPagar As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnMayor As Button
    Friend WithEvents btnMenor As Button
    Friend WithEvents txtMenor As TextBox
    Friend WithEvents txtMayor As TextBox
    Friend WithEvents txtTotal As TextBox
End Class
