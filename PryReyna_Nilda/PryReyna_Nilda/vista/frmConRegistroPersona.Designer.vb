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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Cedula, Me.Apellido, Me.Nombre, Me.Edad, Me.NumHijos, Me.nivelAcademico, Me.Genero, Me.sueldoFijo, Me.valorHora, Me.totalDescuento, Me.totalIngreso, Me.totalEgreso, Me.totalPagar, Me.Eliminar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgConsulta.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgConsulta.EnableHeadersVisualStyles = False
        Me.dgConsulta.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dgConsulta.Location = New System.Drawing.Point(9, 156)
        Me.dgConsulta.Margin = New System.Windows.Forms.Padding(2)
        Me.dgConsulta.Name = "dgConsulta"
        Me.dgConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsulta.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle2
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
End Class
