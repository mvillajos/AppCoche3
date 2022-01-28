<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegGstFuel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtQuitarFiltro = New System.Windows.Forms.Button()
        Me.BtAplicaFiltro = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFechaFin = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFechaIni = New System.Windows.Forms.MaskedTextBox()
        Me.chkLlenado = New System.Windows.Forms.CheckBox()
        Me.txtIdGstFuel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtModificar = New System.Windows.Forms.Button()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.BtLimpiarCampos = New System.Windows.Forms.Button()
        Me.grdGstFuel = New System.Windows.Forms.DataGridView()
        Me.txtKmParcial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKmTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecioLitro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLitros = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grdGstFuelAnual = New System.Windows.Forms.DataGridView()
        Me.grdGstFuelMensual = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbCoche = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdGstFuel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.grdGstFuelAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGstFuelMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 50)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(831, 554)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.chkLlenado)
        Me.TabPage1.Controls.Add(Me.txtIdGstFuel)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.BtModificar)
        Me.TabPage1.Controls.Add(Me.BtAgregar)
        Me.TabPage1.Controls.Add(Me.BtLimpiarCampos)
        Me.TabPage1.Controls.Add(Me.grdGstFuel)
        Me.TabPage1.Controls.Add(Me.txtKmParcial)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtKmTotal)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtPrecioLitro)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtImporte)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtLitros)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtFecha)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(823, 525)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gasto fuel diario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtQuitarFiltro)
        Me.GroupBox1.Controls.Add(Me.BtAplicaFiltro)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtFechaIni)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(721, 50)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'BtQuitarFiltro
        '
        Me.BtQuitarFiltro.Location = New System.Drawing.Point(560, 14)
        Me.BtQuitarFiltro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtQuitarFiltro.Name = "BtQuitarFiltro"
        Me.BtQuitarFiltro.Size = New System.Drawing.Size(92, 28)
        Me.BtQuitarFiltro.TabIndex = 39
        Me.BtQuitarFiltro.Text = "No filter"
        Me.BtQuitarFiltro.UseVisualStyleBackColor = True
        '
        'BtAplicaFiltro
        '
        Me.BtAplicaFiltro.Location = New System.Drawing.Point(457, 15)
        Me.BtAplicaFiltro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtAplicaFiltro.Name = "BtAplicaFiltro"
        Me.BtAplicaFiltro.Size = New System.Drawing.Size(95, 28)
        Me.BtAplicaFiltro.TabIndex = 38
        Me.BtAplicaFiltro.Text = "Set filter"
        Me.BtAplicaFiltro.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(267, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "FECHAFIN"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.txtFechaFin.Location = New System.Drawing.Point(352, 17)
        Me.txtFechaFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFechaFin.Mask = "00/00/0000"
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(85, 22)
        Me.txtFechaFin.TabIndex = 36
        Me.txtFechaFin.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 23)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "FECHAINI"
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.txtFechaIni.Location = New System.Drawing.Point(145, 17)
        Me.txtFechaIni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFechaIni.Mask = "00/00/0000"
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(85, 22)
        Me.txtFechaIni.TabIndex = 34
        Me.txtFechaIni.ValidatingType = GetType(Date)
        '
        'chkLlenado
        '
        Me.chkLlenado.AutoSize = True
        Me.chkLlenado.Location = New System.Drawing.Point(244, 108)
        Me.chkLlenado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkLlenado.Name = "chkLlenado"
        Me.chkLlenado.Size = New System.Drawing.Size(64, 21)
        Me.chkLlenado.TabIndex = 17
        Me.chkLlenado.Text = "FULL"
        Me.chkLlenado.UseVisualStyleBackColor = True
        '
        'txtIdGstFuel
        '
        Me.txtIdGstFuel.Location = New System.Drawing.Point(116, 144)
        Me.txtIdGstFuel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdGstFuel.Name = "txtIdGstFuel"
        Me.txtIdGstFuel.Size = New System.Drawing.Size(45, 22)
        Me.txtIdGstFuel.TabIndex = 30
        Me.txtIdGstFuel.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "IDGSTFUEL"
        Me.Label7.Visible = False
        '
        'BtModificar
        '
        Me.BtModificar.Location = New System.Drawing.Point(487, 143)
        Me.BtModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtModificar.Name = "BtModificar"
        Me.BtModificar.Size = New System.Drawing.Size(100, 31)
        Me.BtModificar.TabIndex = 27
        Me.BtModificar.Text = "Modificar"
        Me.BtModificar.UseVisualStyleBackColor = True
        '
        'BtAgregar
        '
        Me.BtAgregar.Location = New System.Drawing.Point(353, 143)
        Me.BtAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(100, 31)
        Me.BtAgregar.TabIndex = 26
        Me.BtAgregar.Text = "Agregar"
        Me.BtAgregar.UseVisualStyleBackColor = True
        '
        'BtLimpiarCampos
        '
        Me.BtLimpiarCampos.Location = New System.Drawing.Point(187, 143)
        Me.BtLimpiarCampos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtLimpiarCampos.Name = "BtLimpiarCampos"
        Me.BtLimpiarCampos.Size = New System.Drawing.Size(127, 31)
        Me.BtLimpiarCampos.TabIndex = 24
        Me.BtLimpiarCampos.Text = "Limpiar campos"
        Me.BtLimpiarCampos.UseVisualStyleBackColor = True
        '
        'grdGstFuel
        '
        Me.grdGstFuel.AllowUserToAddRows = False
        Me.grdGstFuel.AllowUserToDeleteRows = False
        Me.grdGstFuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGstFuel.Location = New System.Drawing.Point(8, 180)
        Me.grdGstFuel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdGstFuel.Name = "grdGstFuel"
        Me.grdGstFuel.ReadOnly = True
        Me.grdGstFuel.Size = New System.Drawing.Size(804, 325)
        Me.grdGstFuel.TabIndex = 28
        '
        'txtKmParcial
        '
        Me.txtKmParcial.Location = New System.Drawing.Point(680, 105)
        Me.txtKmParcial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKmParcial.Name = "txtKmParcial"
        Me.txtKmParcial.Size = New System.Drawing.Size(72, 22)
        Me.txtKmParcial.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(587, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "KM PARCIAL"
        '
        'txtKmTotal
        '
        Me.txtKmTotal.Location = New System.Drawing.Point(411, 105)
        Me.txtKmTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKmTotal.Name = "txtKmTotal"
        Me.txtKmTotal.Size = New System.Drawing.Size(72, 22)
        Me.txtKmTotal.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "KM TOTAL"
        '
        'txtPrecioLitro
        '
        Me.txtPrecioLitro.Location = New System.Drawing.Point(679, 66)
        Me.txtPrecioLitro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioLitro.Name = "txtPrecioLitro"
        Me.txtPrecioLitro.Size = New System.Drawing.Size(72, 22)
        Me.txtPrecioLitro.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(557, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "PRECIO x LITRO"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(409, 66)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(72, 22)
        Me.txtImporte.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "IMPORTE"
        '
        'txtLitros
        '
        Me.txtLitros.Location = New System.Drawing.Point(157, 106)
        Me.txtLitros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLitros.Name = "txtLitros"
        Me.txtLitros.Size = New System.Drawing.Size(72, 22)
        Me.txtLitros.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "LITROS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "FECHA"
        '
        'txtFecha
        '
        Me.txtFecha.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.txtFecha.Location = New System.Drawing.Point(153, 66)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(85, 22)
        Me.txtFecha.TabIndex = 13
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdGstFuelAnual)
        Me.TabPage2.Controls.Add(Me.grdGstFuelMensual)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(823, 525)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resumen mes-año"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grdGstFuelAnual
        '
        Me.grdGstFuelAnual.AllowUserToAddRows = False
        Me.grdGstFuelAnual.AllowUserToDeleteRows = False
        Me.grdGstFuelAnual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGstFuelAnual.Location = New System.Drawing.Point(13, 337)
        Me.grdGstFuelAnual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdGstFuelAnual.Name = "grdGstFuelAnual"
        Me.grdGstFuelAnual.ReadOnly = True
        Me.grdGstFuelAnual.Size = New System.Drawing.Size(787, 135)
        Me.grdGstFuelAnual.TabIndex = 30
        '
        'grdGstFuelMensual
        '
        Me.grdGstFuelMensual.AllowUserToAddRows = False
        Me.grdGstFuelMensual.AllowUserToDeleteRows = False
        Me.grdGstFuelMensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGstFuelMensual.Location = New System.Drawing.Point(41, 22)
        Me.grdGstFuelMensual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdGstFuelMensual.Name = "grdGstFuelMensual"
        Me.grdGstFuelMensual.ReadOnly = True
        Me.grdGstFuelMensual.Size = New System.Drawing.Size(693, 289)
        Me.grdGstFuelMensual.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Coche"
        Me.Label10.Visible = False
        '
        'CmbCoche
        '
        Me.CmbCoche.FormattingEnabled = True
        Me.CmbCoche.Location = New System.Drawing.Point(88, 16)
        Me.CmbCoche.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbCoche.Name = "CmbCoche"
        Me.CmbCoche.Size = New System.Drawing.Size(277, 24)
        Me.CmbCoche.TabIndex = 2
        Me.CmbCoche.Visible = False
        '
        'FrmRegGstFuel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 629)
        Me.Controls.Add(Me.CmbCoche)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmRegGstFuel"
        Me.Text = "Gasto de combustible"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdGstFuel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grdGstFuelAnual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGstFuelMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chkLlenado As System.Windows.Forms.CheckBox
    Friend WithEvents txtIdGstFuel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtModificar As System.Windows.Forms.Button
    Friend WithEvents BtAgregar As System.Windows.Forms.Button
    Friend WithEvents BtLimpiarCampos As System.Windows.Forms.Button
    Friend WithEvents grdGstFuel As System.Windows.Forms.DataGridView
    Friend WithEvents txtKmParcial As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKmTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioLitro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLitros As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grdGstFuelMensual As System.Windows.Forms.DataGridView
    Friend WithEvents grdGstFuelAnual As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtQuitarFiltro As System.Windows.Forms.Button
    Friend WithEvents BtAplicaFiltro As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFechaIni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CmbCoche As System.Windows.Forms.ComboBox
End Class
