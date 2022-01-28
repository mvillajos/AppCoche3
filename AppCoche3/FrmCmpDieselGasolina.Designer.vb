<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCmpDieselGasolina
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtGastoTotalD = New System.Windows.Forms.TextBox
        Me.txtCoste1000kmD = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtEuroDepositoD = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtKmDepositoD = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cbCocheD = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtImpuestoD = New System.Windows.Forms.TextBox
        Me.txtCosteSegD = New System.Windows.Forms.TextBox
        Me.txtConsumoD = New System.Windows.Forms.TextBox
        Me.txtCosteFuelD = New System.Windows.Forms.TextBox
        Me.txtCosteCocheD = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCoste1000kmG = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtEuroDepositoG = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtKmDepositoG = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtGastoTotalG = New System.Windows.Forms.TextBox
        Me.cbCocheG = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtImpuestoG = New System.Windows.Forms.TextBox
        Me.txtCosteSegG = New System.Windows.Forms.TextBox
        Me.txtConsumoG = New System.Windows.Forms.TextBox
        Me.txtCosteFuelG = New System.Windows.Forms.TextBox
        Me.txtCosteCocheG = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.BtCalcKmAmortiza = New System.Windows.Forms.Button
        Me.txtKmIgualCoste = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtGastoTotalD)
        Me.GroupBox1.Controls.Add(Me.txtCoste1000kmD)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtEuroDepositoD)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtKmDepositoD)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cbCocheD)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtImpuestoD)
        Me.GroupBox1.Controls.Add(Me.txtCosteSegD)
        Me.GroupBox1.Controls.Add(Me.txtConsumoD)
        Me.GroupBox1.Controls.Add(Me.txtCosteFuelD)
        Me.GroupBox1.Controls.Add(Me.txtCosteCocheD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 410)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Diesel"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 365)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Coste Total Fuel"
        '
        'txtGastoTotalD
        '
        Me.txtGastoTotalD.Location = New System.Drawing.Point(105, 360)
        Me.txtGastoTotalD.Name = "txtGastoTotalD"
        Me.txtGastoTotalD.Size = New System.Drawing.Size(95, 20)
        Me.txtGastoTotalD.TabIndex = 27
        '
        'txtCoste1000kmD
        '
        Me.txtCoste1000kmD.Location = New System.Drawing.Point(105, 325)
        Me.txtCoste1000kmD.Name = "txtCoste1000kmD"
        Me.txtCoste1000kmD.Size = New System.Drawing.Size(55, 20)
        Me.txtCoste1000kmD.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 329)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Coste x 1000 Km"
        '
        'txtEuroDepositoD
        '
        Me.txtEuroDepositoD.Location = New System.Drawing.Point(105, 290)
        Me.txtEuroDepositoD.Name = "txtEuroDepositoD"
        Me.txtEuroDepositoD.Size = New System.Drawing.Size(55, 20)
        Me.txtEuroDepositoD.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(30, 295)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "€ x Deposito"
        '
        'txtKmDepositoD
        '
        Me.txtKmDepositoD.Location = New System.Drawing.Point(105, 260)
        Me.txtKmDepositoD.Name = "txtKmDepositoD"
        Me.txtKmDepositoD.Size = New System.Drawing.Size(55, 20)
        Me.txtKmDepositoD.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 265)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Km x Deposito"
        '
        'cbCocheD
        '
        Me.cbCocheD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCocheD.FormattingEnabled = True
        Me.cbCocheD.Location = New System.Drawing.Point(45, 30)
        Me.cbCocheD.Name = "cbCocheD"
        Me.cbCocheD.Size = New System.Drawing.Size(215, 21)
        Me.cbCocheD.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Coche"
        '
        'txtImpuestoD
        '
        Me.txtImpuestoD.Location = New System.Drawing.Point(105, 220)
        Me.txtImpuestoD.Name = "txtImpuestoD"
        Me.txtImpuestoD.Size = New System.Drawing.Size(90, 20)
        Me.txtImpuestoD.TabIndex = 11
        '
        'txtCosteSegD
        '
        Me.txtCosteSegD.Location = New System.Drawing.Point(105, 180)
        Me.txtCosteSegD.Name = "txtCosteSegD"
        Me.txtCosteSegD.Size = New System.Drawing.Size(90, 20)
        Me.txtCosteSegD.TabIndex = 10
        '
        'txtConsumoD
        '
        Me.txtConsumoD.Location = New System.Drawing.Point(105, 140)
        Me.txtConsumoD.Name = "txtConsumoD"
        Me.txtConsumoD.Size = New System.Drawing.Size(90, 20)
        Me.txtConsumoD.TabIndex = 9
        '
        'txtCosteFuelD
        '
        Me.txtCosteFuelD.Location = New System.Drawing.Point(105, 105)
        Me.txtCosteFuelD.Name = "txtCosteFuelD"
        Me.txtCosteFuelD.Size = New System.Drawing.Size(90, 20)
        Me.txtCosteFuelD.TabIndex = 8
        '
        'txtCosteCocheD
        '
        Me.txtCosteCocheD.Location = New System.Drawing.Point(104, 66)
        Me.txtCosteCocheD.Name = "txtCosteCocheD"
        Me.txtCosteCocheD.Size = New System.Drawing.Size(90, 20)
        Me.txtCosteCocheD.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Impuesto local"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Coste seguro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Consumo medio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio litro fuel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Precio coche"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCoste1000kmG)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtEuroDepositoG)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtKmDepositoG)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtGastoTotalG)
        Me.GroupBox2.Controls.Add(Me.cbCocheG)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtImpuestoG)
        Me.GroupBox2.Controls.Add(Me.txtCosteSegG)
        Me.GroupBox2.Controls.Add(Me.txtConsumoG)
        Me.GroupBox2.Controls.Add(Me.txtCosteFuelG)
        Me.GroupBox2.Controls.Add(Me.txtCosteCocheG)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(305, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 410)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Gasolina"
        '
        'txtCoste1000kmG
        '
        Me.txtCoste1000kmG.Location = New System.Drawing.Point(105, 325)
        Me.txtCoste1000kmG.Name = "txtCoste1000kmG"
        Me.txtCoste1000kmG.Size = New System.Drawing.Size(55, 20)
        Me.txtCoste1000kmG.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 329)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Coste x 1000 Km"
        '
        'txtEuroDepositoG
        '
        Me.txtEuroDepositoG.Location = New System.Drawing.Point(105, 290)
        Me.txtEuroDepositoG.Name = "txtEuroDepositoG"
        Me.txtEuroDepositoG.Size = New System.Drawing.Size(55, 20)
        Me.txtEuroDepositoG.TabIndex = 30
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(30, 295)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "€ x Deposito"
        '
        'txtKmDepositoG
        '
        Me.txtKmDepositoG.Location = New System.Drawing.Point(105, 260)
        Me.txtKmDepositoG.Name = "txtKmDepositoG"
        Me.txtKmDepositoG.Size = New System.Drawing.Size(55, 20)
        Me.txtKmDepositoG.TabIndex = 28
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(25, 265)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 13)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Km x Deposito"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 365)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Coste Total Fuel"
        '
        'txtGastoTotalG
        '
        Me.txtGastoTotalG.Location = New System.Drawing.Point(105, 360)
        Me.txtGastoTotalG.Name = "txtGastoTotalG"
        Me.txtGastoTotalG.Size = New System.Drawing.Size(95, 20)
        Me.txtGastoTotalG.TabIndex = 21
        '
        'cbCocheG
        '
        Me.cbCocheG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCocheG.FormattingEnabled = True
        Me.cbCocheG.Location = New System.Drawing.Point(45, 30)
        Me.cbCocheG.Name = "cbCocheG"
        Me.cbCocheG.Size = New System.Drawing.Size(215, 21)
        Me.cbCocheG.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Coche"
        '
        'txtImpuestoG
        '
        Me.txtImpuestoG.Location = New System.Drawing.Point(105, 220)
        Me.txtImpuestoG.Name = "txtImpuestoG"
        Me.txtImpuestoG.Size = New System.Drawing.Size(90, 20)
        Me.txtImpuestoG.TabIndex = 11
        '
        'txtCosteSegG
        '
        Me.txtCosteSegG.Location = New System.Drawing.Point(105, 180)
        Me.txtCosteSegG.Name = "txtCosteSegG"
        Me.txtCosteSegG.Size = New System.Drawing.Size(90, 20)
        Me.txtCosteSegG.TabIndex = 10
        '
        'txtConsumoG
        '
        Me.txtConsumoG.Location = New System.Drawing.Point(105, 140)
        Me.txtConsumoG.Name = "txtConsumoG"
        Me.txtConsumoG.Size = New System.Drawing.Size(90, 20)
        Me.txtConsumoG.TabIndex = 9
        '
        'txtCosteFuelG
        '
        Me.txtCosteFuelG.Location = New System.Drawing.Point(105, 105)
        Me.txtCosteFuelG.Name = "txtCosteFuelG"
        Me.txtCosteFuelG.Size = New System.Drawing.Size(90, 20)
        Me.txtCosteFuelG.TabIndex = 8
        '
        'txtCosteCocheG
        '
        Me.txtCosteCocheG.Location = New System.Drawing.Point(104, 66)
        Me.txtCosteCocheG.Name = "txtCosteCocheG"
        Me.txtCosteCocheG.Size = New System.Drawing.Size(90, 20)
        Me.txtCosteCocheG.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Impuesto local"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Coste seguro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Consumo medio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Precio litro fuel"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Precio coche"
        '
        'BtCalcKmAmortiza
        '
        Me.BtCalcKmAmortiza.Location = New System.Drawing.Point(265, 457)
        Me.BtCalcKmAmortiza.Name = "BtCalcKmAmortiza"
        Me.BtCalcKmAmortiza.Size = New System.Drawing.Size(130, 25)
        Me.BtCalcKmAmortiza.TabIndex = 6
        Me.BtCalcKmAmortiza.Text = "Calcular Igual Coste"
        Me.BtCalcKmAmortiza.UseVisualStyleBackColor = True
        '
        'txtKmIgualCoste
        '
        Me.txtKmIgualCoste.Location = New System.Drawing.Point(150, 460)
        Me.txtKmIgualCoste.Name = "txtKmIgualCoste"
        Me.txtKmIgualCoste.Size = New System.Drawing.Size(95, 20)
        Me.txtKmIgualCoste.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(70, 465)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Km Igual Coste"
        '
        'FrmCmpDieselGasolina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 510)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtKmIgualCoste)
        Me.Controls.Add(Me.BtCalcKmAmortiza)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmCmpDieselGasolina"
        Me.Text = "FrmCmpDieselGasolina"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtImpuestoD As System.Windows.Forms.TextBox
    Friend WithEvents txtCosteSegD As System.Windows.Forms.TextBox
    Friend WithEvents txtConsumoD As System.Windows.Forms.TextBox
    Friend WithEvents txtCosteFuelD As System.Windows.Forms.TextBox
    Friend WithEvents txtCosteCocheD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtImpuestoG As System.Windows.Forms.TextBox
    Friend WithEvents txtCosteSegG As System.Windows.Forms.TextBox
    Friend WithEvents txtConsumoG As System.Windows.Forms.TextBox
    Friend WithEvents txtCosteFuelG As System.Windows.Forms.TextBox
    Friend WithEvents txtCosteCocheG As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtCalcKmAmortiza As System.Windows.Forms.Button
    Friend WithEvents txtKmIgualCoste As System.Windows.Forms.TextBox
    Friend WithEvents cbCocheD As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbCocheG As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtGastoTotalD As System.Windows.Forms.TextBox
    Friend WithEvents txtCoste1000kmD As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEuroDepositoD As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtKmDepositoD As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCoste1000kmG As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtEuroDepositoG As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtKmDepositoG As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtGastoTotalG As System.Windows.Forms.TextBox
End Class
