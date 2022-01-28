<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegKmsMes
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
        Me.BtLimpiar = New System.Windows.Forms.Button()
        Me.grdKmMes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdKm = New System.Windows.Forms.TextBox()
        Me.txtKmParcial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKmFinal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.grdKmAño = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtQuitarFiltro = New System.Windows.Forms.Button()
        Me.BtAplicaFiltro = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFechaFin = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaIni = New System.Windows.Forms.MaskedTextBox()
        CType(Me.grdKmMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdKmAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtLimpiar
        '
        Me.BtLimpiar.Location = New System.Drawing.Point(233, 132)
        Me.BtLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtLimpiar.Name = "BtLimpiar"
        Me.BtLimpiar.Size = New System.Drawing.Size(100, 28)
        Me.BtLimpiar.TabIndex = 0
        Me.BtLimpiar.Text = "Limpiar"
        Me.BtLimpiar.UseVisualStyleBackColor = True
        '
        'grdKmMes
        '
        Me.grdKmMes.AllowUserToAddRows = False
        Me.grdKmMes.AllowUserToDeleteRows = False
        Me.grdKmMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdKmMes.Location = New System.Drawing.Point(16, 167)
        Me.grdKmMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdKmMes.Name = "grdKmMes"
        Me.grdKmMes.ReadOnly = True
        Me.grdKmMes.Size = New System.Drawing.Size(815, 289)
        Me.grdKmMes.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(447, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "IDKM"
        Me.Label1.Visible = False
        '
        'txtIdKm
        '
        Me.txtIdKm.Location = New System.Drawing.Point(500, 97)
        Me.txtIdKm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdKm.Name = "txtIdKm"
        Me.txtIdKm.Size = New System.Drawing.Size(65, 22)
        Me.txtIdKm.TabIndex = 31
        Me.txtIdKm.Visible = False
        '
        'txtKmParcial
        '
        Me.txtKmParcial.Location = New System.Drawing.Point(333, 97)
        Me.txtKmParcial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKmParcial.Name = "txtKmParcial"
        Me.txtKmParcial.Size = New System.Drawing.Size(72, 22)
        Me.txtKmParcial.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(227, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "KM PARCIAL"
        '
        'txtKmFinal
        '
        Me.txtKmFinal.Location = New System.Drawing.Point(127, 97)
        Me.txtKmFinal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKmFinal.Name = "txtKmFinal"
        Me.txtKmFinal.Size = New System.Drawing.Size(72, 22)
        Me.txtKmFinal.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "KM FINAL"
        '
        'BtGuardar
        '
        Me.BtGuardar.Location = New System.Drawing.Point(373, 132)
        Me.BtGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(100, 28)
        Me.BtGuardar.TabIndex = 38
        Me.BtGuardar.Text = "Guardar"
        Me.BtGuardar.UseVisualStyleBackColor = True
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(127, 63)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(65, 22)
        Me.txtAño.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "AÑO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "MES"
        '
        'cbMes
        '
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Location = New System.Drawing.Point(273, 63)
        Me.cbMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(139, 24)
        Me.cbMes.TabIndex = 42
        '
        'grdKmAño
        '
        Me.grdKmAño.AllowUserToAddRows = False
        Me.grdKmAño.AllowUserToDeleteRows = False
        Me.grdKmAño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdKmAño.Location = New System.Drawing.Point(67, 466)
        Me.grdKmAño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdKmAño.Name = "grdKmAño"
        Me.grdKmAño.ReadOnly = True
        Me.grdKmAño.Size = New System.Drawing.Size(653, 154)
        Me.grdKmAño.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtQuitarFiltro)
        Me.GroupBox1.Controls.Add(Me.BtAplicaFiltro)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFechaIni)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(721, 50)
        Me.GroupBox1.TabIndex = 44
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(267, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "FECHAFIN"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "FECHAINI"
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
        'FrmRegKmsMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 636)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdKmAño)
        Me.Controls.Add(Me.cbMes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtGuardar)
        Me.Controls.Add(Me.txtKmParcial)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKmFinal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdKm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdKmMes)
        Me.Controls.Add(Me.BtLimpiar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmRegKmsMes"
        Me.Text = "Km realizados"
        CType(Me.grdKmMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdKmAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtLimpiar As System.Windows.Forms.Button
    Friend WithEvents grdKmMes As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdKm As System.Windows.Forms.TextBox
    Friend WithEvents txtKmParcial As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKmFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtGuardar As System.Windows.Forms.Button
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents grdKmAño As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFechaIni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BtAplicaFiltro As System.Windows.Forms.Button
    Friend WithEvents BtQuitarFiltro As System.Windows.Forms.Button
End Class
