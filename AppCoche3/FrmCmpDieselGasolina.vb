Public Class FrmCmpDieselGasolina
    Dim miBD As MySqlConnection
    Dim DepositoD As Single, DepositoG As Single

    Private Sub BtCalcKmAmortiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCalcKmAmortiza.Click
        Dim DifCosteCoche As Single
        Dim FuelCostConsumD As Single, FuelCostConsumG As Single
        Dim kmIgualCoste As Single

        If Val(txtCosteCocheD.Text) > 0 And Val(txtCosteCocheG.Text) > 0 _
        And Val(txtCosteFuelD.Text) > 0 And Val(txtCosteFuelG.Text) > 0 _
        And Val(txtConsumoD.Text) > 0 And Val(txtConsumoG.Text) > 0 Then

            DifCosteCoche = txtCosteCocheD.Text - txtCosteCocheG.Text
            FuelCostConsumD = (Replace(txtCosteFuelD.Text, ".", ",") * Replace(txtConsumoD.Text, ".", ",")) / 100
            FuelCostConsumG = (Replace(txtCosteFuelG.Text, ".", ",") * Replace(txtConsumoG.Text, ".", ",")) / 100
            kmIgualCoste = DifCosteCoche / (FuelCostConsumG - FuelCostConsumD)
            txtKmIgualCoste.Text = CInt(kmIgualCoste)

            txtGastoTotalD.Text = FuelCostConsumD * CSng(txtKmIgualCoste.Text)
            txtGastoTotalG.Text = FuelCostConsumG * CSng(txtKmIgualCoste.Text)

        End If



    End Sub

    Private Sub FrmCmpDieselGasolina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strSql As String

        Me.MdiParent = FrmMain

        BDOpen(miBD)

        strSql = "Select IdCoche, Marca + ' ' + Modelo + ' ' + SubModelo + ' ' + Motor as Coche" & _
        " From tbl_cochemodelo " & _
        " Where Combustible='G' "
        cargarCombo(cbCocheG, strSql, "Coche", "IdCoche", miBD)

        strSql = "Select IdCoche, Marca + ' ' + Modelo + ' ' + SubModelo + ' ' + Motor as Coche" & _
        " From tbl_cochemodelo " & _
        " Where Combustible='D' "
        cargarCombo(cbCocheD, strSql, "Coche", "IdCoche", miBD)

        Me.txtCosteFuelD.Text = "1"
        Me.txtCosteFuelG.Text = "1,1"

    End Sub

    Private Sub CalcularParamCoche(ByVal idCoche As String, ByRef Consumo As TextBox _
    , ByRef CosteCoche As TextBox, ByRef CosteSeg As TextBox, ByRef Impuesto As TextBox _
    , ByRef Deposito As Single, ByRef KmDeposito As TextBox, ByRef EuroDeposito As TextBox _
    , ByRef Coste1000km As TextBox, ByVal CosteFuel As String)
        Dim strSql As String
        Dim dbDataset As New DataSet
        Dim Fila As DataRow

        strSql = "Select * From tbl_cochemodelo Where IdCoche=" & idCoche
        CargarDataSet(miBD, strSql, dbDataset)
        If dbDataset.Tables(0).Rows.Count > 0 Then
            Fila = dbDataset.Tables(0).Rows(0)
            Consumo.Text = Fila.Item("ConsumoMedio")
            CosteCoche.Text = Fila.Item("Precio")
            CosteSeg.Text = Fila.Item("Seguro")
            Impuesto.Text = Fila.Item("Impuesto")
            Deposito = Fila.Item("Deposito")

            'x=(deposito*100)/consumoMedio
            KmDeposito.Text = CInt((Deposito * 100) / Consumo.Text)
            If CosteFuel <> "" Then
                EuroDeposito.Text = Math.Round(Deposito * CSng(CosteFuel), 2)
                Coste1000km.Text = Math.Round(CSng(CosteFuel) * (10 * CSng(Consumo.Text)), 2)
            End If


        End If
        dbDataset.Dispose()

    End Sub


    Private Sub cbCocheD_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCocheD.SelectionChangeCommitted

        If cbCocheD.SelectedIndex > -1 Then
            CalcularParamCoche(cbCocheD.SelectedValue, Me.txtConsumoD, Me.txtCosteCocheD _
            , Me.txtCosteSegD, Me.txtImpuestoD, Me.DepositoD, Me.txtKmDepositoD, Me.txtEuroDepositoD _
            , Me.txtCoste1000kmD, Me.txtCosteFuelD.Text)

        End If

    End Sub



   
    Private Sub cbCocheG_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCocheG.SelectionChangeCommitted

        If cbCocheG.SelectedIndex > -1 Then
            CalcularParamCoche(cbCocheG.SelectedValue, Me.txtConsumoG, Me.txtCosteCocheG _
            , Me.txtCosteSegG, Me.txtImpuestoG, Me.DepositoG, Me.txtKmDepositoG, Me.txtEuroDepositoG _
            , Me.txtCoste1000kmG, Me.txtCosteFuelG.Text)

        End If


    End Sub
End Class