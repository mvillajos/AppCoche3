Public Class FrmMain

    Private Sub AmorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmorToolStripMenuItem.Click
        FrmCmpDieselGasolina.Show()
    End Sub


    Private Sub GastoFuelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GastoFuelToolStripMenuItem.Click
        FrmRegGstFuel.Show()
    End Sub

    Private Sub KmMensualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KmMensualToolStripMenuItem.Click
        FrmRegKmsMes.Show()
    End Sub


    Private Sub MantenimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoToolStripMenuItem.Click
        FrmMantenimiento.Show()
    End Sub
End Class
