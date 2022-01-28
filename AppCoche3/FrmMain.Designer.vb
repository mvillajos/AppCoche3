<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AmorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastoFuelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KmMensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AmorToolStripMenuItem, Me.GastoFuelToolStripMenuItem, Me.KmMensualToolStripMenuItem, Me.MantenimientoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AmorToolStripMenuItem
        '
        Me.AmorToolStripMenuItem.Name = "AmorToolStripMenuItem"
        Me.AmorToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.AmorToolStripMenuItem.Text = "Cmp Diesel-Gasolina"
        '
        'GastoFuelToolStripMenuItem
        '
        Me.GastoFuelToolStripMenuItem.Name = "GastoFuelToolStripMenuItem"
        Me.GastoFuelToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.GastoFuelToolStripMenuItem.Text = "Gasto Fuel"
        '
        'KmMensualToolStripMenuItem
        '
        Me.KmMensualToolStripMenuItem.Name = "KmMensualToolStripMenuItem"
        Me.KmMensualToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.KmMensualToolStripMenuItem.Text = "Km Mensual"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 499)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = "Gestión de Vehículos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AmorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastoFuelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KmMensualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
