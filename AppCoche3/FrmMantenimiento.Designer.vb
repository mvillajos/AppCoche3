<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimiento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TbPgManteni = New System.Windows.Forms.TabPage()
        Me.txtDescManteni = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtImpTotal = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtImpIVA = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtImpBruto = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtAjustarImportes = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_ImpTotal_Linea = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_ImpIVA_Linea = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_ImpBruto_Linea = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtIdLineaManteni = New System.Windows.Forms.TextBox()
        Me.BtLimpiarLinea = New System.Windows.Forms.Button()
        Me.BtGuardarLinea = New System.Windows.Forms.Button()
        Me.grdLineaManteni = New System.Windows.Forms.DataGridView()
        Me.txtDescLineaManteni = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbTipoPiez = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbTipoLinea = New System.Windows.Forms.ComboBox()
        Me.BtLimpiarManteni = New System.Windows.Forms.Button()
        Me.BtGuardarManteni = New System.Windows.Forms.Button()
        Me.txtIdManteni = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grdManteni = New System.Windows.Forms.DataGridView()
        Me.txtKm = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTipoManteni = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl2.SuspendLayout()
        Me.TbPgManteni.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdLineaManteni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdManteni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TbPgManteni)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(13, 6)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(891, 646)
        Me.TabControl2.TabIndex = 71
        '
        'TbPgManteni
        '
        Me.TbPgManteni.Controls.Add(Me.txtDescManteni)
        Me.TbPgManteni.Controls.Add(Me.Label9)
        Me.TbPgManteni.Controls.Add(Me.Label8)
        Me.TbPgManteni.Controls.Add(Me.txtImpTotal)
        Me.TbPgManteni.Controls.Add(Me.Label7)
        Me.TbPgManteni.Controls.Add(Me.txtImpIVA)
        Me.TbPgManteni.Controls.Add(Me.Label6)
        Me.TbPgManteni.Controls.Add(Me.txtImpBruto)
        Me.TbPgManteni.Controls.Add(Me.GroupBox2)
        Me.TbPgManteni.Controls.Add(Me.BtLimpiarManteni)
        Me.TbPgManteni.Controls.Add(Me.BtGuardarManteni)
        Me.TbPgManteni.Controls.Add(Me.txtIdManteni)
        Me.TbPgManteni.Controls.Add(Me.Label11)
        Me.TbPgManteni.Controls.Add(Me.grdManteni)
        Me.TbPgManteni.Controls.Add(Me.txtKm)
        Me.TbPgManteni.Controls.Add(Me.Label5)
        Me.TbPgManteni.Controls.Add(Me.Label2)
        Me.TbPgManteni.Controls.Add(Me.cbTipoManteni)
        Me.TbPgManteni.Controls.Add(Me.Label1)
        Me.TbPgManteni.Controls.Add(Me.txtFecha)
        Me.TbPgManteni.Controls.Add(Me.cbMes)
        Me.TbPgManteni.Controls.Add(Me.Label4)
        Me.TbPgManteni.Controls.Add(Me.txtAño)
        Me.TbPgManteni.Controls.Add(Me.Label3)
        Me.TbPgManteni.Location = New System.Drawing.Point(4, 25)
        Me.TbPgManteni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbPgManteni.Name = "TbPgManteni"
        Me.TbPgManteni.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbPgManteni.Size = New System.Drawing.Size(883, 617)
        Me.TbPgManteni.TabIndex = 0
        Me.TbPgManteni.Text = "Mantenimiento Vehículo"
        Me.TbPgManteni.UseVisualStyleBackColor = True
        '
        'txtDescManteni
        '
        Me.txtDescManteni.Location = New System.Drawing.Point(467, 41)
        Me.txtDescManteni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescManteni.Name = "txtDescManteni"
        Me.txtDescManteni.Size = New System.Drawing.Size(345, 22)
        Me.txtDescManteni.TabIndex = 110
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(413, 44)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "DESC."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(267, 80)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "IMP TOTAL"
        '
        'txtImpTotal
        '
        Me.txtImpTotal.Location = New System.Drawing.Point(353, 74)
        Me.txtImpTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImpTotal.Name = "txtImpTotal"
        Me.txtImpTotal.Size = New System.Drawing.Size(75, 22)
        Me.txtImpTotal.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(673, 80)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "IMP IVA"
        '
        'txtImpIVA
        '
        Me.txtImpIVA.Location = New System.Drawing.Point(740, 74)
        Me.txtImpIVA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImpIVA.Name = "txtImpIVA"
        Me.txtImpIVA.Size = New System.Drawing.Size(75, 22)
        Me.txtImpIVA.TabIndex = 105
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(467, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "IMP BRUTO"
        '
        'txtImpBruto
        '
        Me.txtImpBruto.Location = New System.Drawing.Point(560, 74)
        Me.txtImpBruto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImpBruto.Name = "txtImpBruto"
        Me.txtImpBruto.Size = New System.Drawing.Size(75, 22)
        Me.txtImpBruto.TabIndex = 103
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtAjustarImportes)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_ImpTotal_Linea)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_ImpIVA_Linea)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_ImpBruto_Linea)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtIdLineaManteni)
        Me.GroupBox2.Controls.Add(Me.BtLimpiarLinea)
        Me.GroupBox2.Controls.Add(Me.BtGuardarLinea)
        Me.GroupBox2.Controls.Add(Me.grdLineaManteni)
        Me.GroupBox2.Controls.Add(Me.txtDescLineaManteni)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.cbTipoPiez)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cbTipoLinea)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 295)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(839, 308)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LINEA MANTENIMIENTO"
        '
        'BtAjustarImportes
        '
        Me.BtAjustarImportes.Location = New System.Drawing.Point(605, 107)
        Me.BtAjustarImportes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtAjustarImportes.Name = "BtAjustarImportes"
        Me.BtAjustarImportes.Size = New System.Drawing.Size(153, 28)
        Me.BtAjustarImportes.TabIndex = 115
        Me.BtAjustarImportes.Text = "AJUSTAR IMP"
        Me.BtAjustarImportes.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 117)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 17)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "IMP TOTAL"
        '
        'txt_ImpTotal_Linea
        '
        Me.txt_ImpTotal_Linea.Location = New System.Drawing.Point(155, 111)
        Me.txt_ImpTotal_Linea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ImpTotal_Linea.Name = "txt_ImpTotal_Linea"
        Me.txt_ImpTotal_Linea.Size = New System.Drawing.Size(75, 22)
        Me.txt_ImpTotal_Linea.TabIndex = 113
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(455, 117)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "IMP IVA"
        '
        'txt_ImpIVA_Linea
        '
        Me.txt_ImpIVA_Linea.Location = New System.Drawing.Point(521, 111)
        Me.txt_ImpIVA_Linea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ImpIVA_Linea.Name = "txt_ImpIVA_Linea"
        Me.txt_ImpIVA_Linea.Size = New System.Drawing.Size(75, 22)
        Me.txt_ImpIVA_Linea.TabIndex = 111
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(261, 117)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 17)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "IMP BRUTO"
        '
        'txt_ImpBruto_Linea
        '
        Me.txt_ImpBruto_Linea.Location = New System.Drawing.Point(355, 111)
        Me.txt_ImpBruto_Linea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ImpBruto_Linea.Name = "txt_ImpBruto_Linea"
        Me.txt_ImpBruto_Linea.Size = New System.Drawing.Size(75, 22)
        Me.txt_ImpBruto_Linea.TabIndex = 109
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(77, 34)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 17)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "ID LINEA"
        '
        'txtIdLineaManteni
        '
        Me.txtIdLineaManteni.Location = New System.Drawing.Point(155, 31)
        Me.txtIdLineaManteni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdLineaManteni.Name = "txtIdLineaManteni"
        Me.txtIdLineaManteni.Size = New System.Drawing.Size(65, 22)
        Me.txtIdLineaManteni.TabIndex = 69
        '
        'BtLimpiarLinea
        '
        Me.BtLimpiarLinea.Location = New System.Drawing.Point(367, 144)
        Me.BtLimpiarLinea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtLimpiarLinea.Name = "BtLimpiarLinea"
        Me.BtLimpiarLinea.Size = New System.Drawing.Size(160, 28)
        Me.BtLimpiarLinea.TabIndex = 68
        Me.BtLimpiarLinea.Text = "LIMPIAR CAMPOS"
        Me.BtLimpiarLinea.UseVisualStyleBackColor = True
        '
        'BtGuardarLinea
        '
        Me.BtGuardarLinea.Location = New System.Drawing.Point(233, 144)
        Me.BtGuardarLinea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtGuardarLinea.Name = "BtGuardarLinea"
        Me.BtGuardarLinea.Size = New System.Drawing.Size(100, 28)
        Me.BtGuardarLinea.TabIndex = 67
        Me.BtGuardarLinea.Text = "GUARDAR"
        Me.BtGuardarLinea.UseVisualStyleBackColor = True
        '
        'grdLineaManteni
        '
        Me.grdLineaManteni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLineaManteni.Location = New System.Drawing.Point(0, 178)
        Me.grdLineaManteni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdLineaManteni.Name = "grdLineaManteni"
        Me.grdLineaManteni.Size = New System.Drawing.Size(831, 129)
        Me.grdLineaManteni.TabIndex = 66
        '
        'txtDescLineaManteni
        '
        Me.txtDescLineaManteni.Location = New System.Drawing.Point(508, 69)
        Me.txtDescLineaManteni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescLineaManteni.Name = "txtDescLineaManteni"
        Me.txtDescLineaManteni.Size = New System.Drawing.Size(249, 22)
        Me.txtDescLineaManteni.TabIndex = 63
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(393, 73)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 17)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "DESCRIPCION"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 76)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(140, 17)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "PIEZA / OPERACIÓN"
        '
        'cbTipoPiez
        '
        Me.cbTipoPiez.FormattingEnabled = True
        Me.cbTipoPiez.Location = New System.Drawing.Point(155, 69)
        Me.cbTipoPiez.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTipoPiez.Name = "cbTipoPiez"
        Me.cbTipoPiez.Size = New System.Drawing.Size(201, 24)
        Me.cbTipoPiez.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(412, 34)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 17)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "TIPO LINEA"
        '
        'cbTipoLinea
        '
        Me.cbTipoLinea.FormattingEnabled = True
        Me.cbTipoLinea.Location = New System.Drawing.Point(508, 27)
        Me.cbTipoLinea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTipoLinea.Name = "cbTipoLinea"
        Me.cbTipoLinea.Size = New System.Drawing.Size(219, 24)
        Me.cbTipoLinea.TabIndex = 0
        '
        'BtLimpiarManteni
        '
        Me.BtLimpiarManteni.Location = New System.Drawing.Point(353, 111)
        Me.BtLimpiarManteni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtLimpiarManteni.Name = "BtLimpiarManteni"
        Me.BtLimpiarManteni.Size = New System.Drawing.Size(160, 28)
        Me.BtLimpiarManteni.TabIndex = 100
        Me.BtLimpiarManteni.Text = "LIMPIAR CAMPOS"
        Me.BtLimpiarManteni.UseVisualStyleBackColor = True
        '
        'BtGuardarManteni
        '
        Me.BtGuardarManteni.Location = New System.Drawing.Point(220, 111)
        Me.BtGuardarManteni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtGuardarManteni.Name = "BtGuardarManteni"
        Me.BtGuardarManteni.Size = New System.Drawing.Size(100, 28)
        Me.BtGuardarManteni.TabIndex = 98
        Me.BtGuardarManteni.Text = "GUARDAR"
        Me.BtGuardarManteni.UseVisualStyleBackColor = True
        '
        'txtIdManteni
        '
        Me.txtIdManteni.Location = New System.Drawing.Point(47, 7)
        Me.txtIdManteni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdManteni.Name = "txtIdManteni"
        Me.txtIdManteni.Size = New System.Drawing.Size(59, 22)
        Me.txtIdManteni.TabIndex = 96
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 14)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 17)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "ID"
        '
        'grdManteni
        '
        Me.grdManteni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdManteni.Location = New System.Drawing.Point(8, 148)
        Me.grdManteni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdManteni.Name = "grdManteni"
        Me.grdManteni.Size = New System.Drawing.Size(864, 135)
        Me.grdManteni.TabIndex = 92
        '
        'txtKm
        '
        Me.txtKm.Location = New System.Drawing.Point(133, 74)
        Me.txtKm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKm.Name = "txtKm"
        Me.txtKm.Size = New System.Drawing.Size(105, 22)
        Me.txtKm.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 80)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "KM VEHICULO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "TIPO MANTENI"
        '
        'cbTipoManteni
        '
        Me.cbTipoManteni.FormattingEnabled = True
        Me.cbTipoManteni.Location = New System.Drawing.Point(133, 38)
        Me.cbTipoManteni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTipoManteni.Name = "cbTipoManteni"
        Me.cbTipoManteni.Size = New System.Drawing.Size(252, 24)
        Me.cbTipoManteni.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(553, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "FECHA"
        '
        'txtFecha
        '
        Me.txtFecha.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.txtFecha.Location = New System.Drawing.Point(620, 7)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(85, 22)
        Me.txtFecha.TabIndex = 80
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'cbMes
        '
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Location = New System.Drawing.Point(327, 7)
        Me.cbMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(192, 24)
        Me.cbMes.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(280, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "MES"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(180, 7)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(65, 22)
        Me.txtAño.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "AÑO"
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage4.Size = New System.Drawing.Size(883, 617)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "TabPage2"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'FrmMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 656)
        Me.Controls.Add(Me.TabControl2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmMantenimiento"
        Me.Text = "Mantenimiento"
        Me.TabControl2.ResumeLayout(False)
        Me.TbPgManteni.ResumeLayout(False)
        Me.TbPgManteni.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdLineaManteni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdManteni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TbPgManteni As System.Windows.Forms.TabPage
    Friend WithEvents BtLimpiarManteni As System.Windows.Forms.Button
    Friend WithEvents BtGuardarManteni As System.Windows.Forms.Button
    Friend WithEvents txtIdManteni As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents grdManteni As System.Windows.Forms.DataGridView
    Friend WithEvents txtKm As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipoManteni As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtIdLineaManteni As System.Windows.Forms.TextBox
    Friend WithEvents BtLimpiarLinea As System.Windows.Forms.Button
    Friend WithEvents BtGuardarLinea As System.Windows.Forms.Button
    Friend WithEvents grdLineaManteni As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescLineaManteni As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbTipoPiez As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbTipoLinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtImpTotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtImpIVA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtImpBruto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDescManteni As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_ImpTotal_Linea As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_ImpIVA_Linea As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_ImpBruto_Linea As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BtAjustarImportes As System.Windows.Forms.Button
End Class
