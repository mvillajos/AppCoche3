Public Class FrmRegKmsMes

    Dim miBD As MySqlConnection

    Private Sub InitColsGrdKmMensual(ByRef grd As DataGridView)

        SetGrdReadOnly(grd)
        grd.ColumnCount = 12
        setColHeader(grd, 0, "ID", 40, True)
        setColHeader(grd, 1, "Coche", 80)
        setColHeader(grd, 2, "Año", 40)
        setColHeader(grd, 3, "Mes", 40)
        setColHeader(grd, 4, "numMes", 0, True)
        setColHeader(grd, 5, "KmFinal", 60)
        setColHeader(grd, 6, "KmParcial", 60)
        setColHeader(grd, 7, "KmWeek", 50)
        setColHeader(grd, 8, "KmDay", 50)
        setColHeader(grd, 9, "FuelMes", 55)
        setColHeader(grd, 10, "FuelWeek", 55)
        setColHeader(grd, 11, "FuelDay", 55)

    End Sub

    Private Sub InitColsGrdKmAños(ByRef grd As DataGridView)

        SetGrdReadOnly(grd)
        grd.ColumnCount = 6
        setColHeader(grd, 0, "Coche", 80)
        setColHeader(grd, 1, "Año", 40)
        setColHeader(grd, 2, "KmAnual", 60)
        setColHeader(grd, 3, "KmInicial", 60)
        setColHeader(grd, 4, "KmFinal", 60)
        setColHeader(grd, 5, "AvgMes", 60)

    End Sub

    Private Sub RellenarGrdKmAños(ByRef grd As DataGridView)
        Dim strSql As String
        Dim dbDatos As DataSet, Fila As DataRow
        Dim intFila As Integer, numReg As Integer

        grd.Rows.Clear()
        InitColsGrdKmAños(grd)

        strSql = "Select tbl_vehiculos.Modelo, tbl_regkmanual.Anyo " & " , MIN(tbl_regkmanual.KmInicial) KmIni " _
       & " , MAX(tbl_regkmanual.KmFinal) KmFin, count(*) numMeses " _
        & " From tbl_regkmanual inner join tbl_vehiculos " _
        & " on tbl_regkmanual.idVehiculo=tbl_vehiculos.idVehiculo " & " Where tbl_regkmanual.idVehiculo in (2, 4) " _
        & " Group By  tbl_vehiculos.Modelo, Anyo" _
        & " Order By Anyo Desc, tbl_vehiculos.idVehiculo desc "

        dbDatos = New Data.DataSet
        CargarDataSet(miBD, strSql, dbDatos)

        If dbDatos.Tables(0).Rows.Count > 0 Then
            intFila = 0

            For numReg = 0 To dbDatos.Tables(0).Rows.Count - 1
                grd.Rows.Add()
                Fila = dbDatos.Tables(0).Rows.Item(numReg)

                grd.Rows(intFila).Cells("Coche").Value() = Fila("Modelo")

                grd.Rows(intFila).Cells("Año").Value() = Fila("Anyo")
                grd.Rows(intFila).Cells("KmAnual").Value() = Fila("KmFin") - Fila("KmIni")
                grd.Rows(intFila).Cells("KmInicial").Value() = Fila("KmIni")
                grd.Rows(intFila).Cells("KmFinal").Value() = Fila("KmFin")
                grd.Rows(intFila).Cells("AvgMes").Value() = CInt((Fila("KmFin") - Fila("KmIni")) / Fila("NumMeses"))

                intFila = intFila + 1
            Next

        End If


    End Sub


    Private Sub RellenarGrdKmMensual(ByRef grd As DataGridView)
        Dim strSql As String
        Dim dbDatos As DataSet, Fila As DataRow
        Dim intFila As Integer, numReg As Integer

        grd.Rows.Clear()
        InitColsGrdKmMensual(grd)

        strSql = "Select IdKmAnual, tbl_vehiculos.Modelo " _
        & ", Anyo, Mes " _
        & ", tbl_regkmanual.KmInicial, tbl_regkmanual.KmFinal " _
        & ", tbl_regkmanual.kmParcial " _
        & ", tbl_regkmanual.kmParcial/30 AvgDay " _
        & ", tbl_regkmanual.kmParcial*7/30 AvgWeek " _
        & ", tbl_regkmanual.kmParcial*(tbl_vehiculos.consumomedio/100) FuelTot " _
        & " , tbl_regkmanual.kmParcial*(tbl_vehiculos.consumomedio/100)/30 FuelDay " _
        & " , tbl_regkmanual.kmParcial*(tbl_vehiculos.consumomedio/100)*7/30 FuelWeek" _
        & " From tbl_regkmanual inner join tbl_vehiculos " _
        & " on tbl_regkmanual.idVehiculo=tbl_vehiculos.idVehiculo " _
        & " Where tbl_regkmanual.IdVehiculo in (2, 4) "
        If IsDate(txtFechaIni.Text) Then
            strSql = strSql & " And  str_to_date(concat(Anyo, '/', Mes,'/01'), '%Y/%m/%d')>='" & FechaANSI_SQL(txtFechaIni.Text) & "'"
        End If
        If IsDate(txtFechaFin.Text) Then
            strSql = strSql & " And str_to_date(concat(Anyo, '/', Mes,'/01'), '%Y/%m/%d')<='" & FechaANSI_SQL(txtFechaFin.Text) & "'"
        End If
        strSql = strSql & " Order by Anyo Desc, Mes Desc"

        dbDatos = New Data.DataSet
        CargarDataSet(miBD, strSql, dbDatos)

        If dbDatos.Tables(0).Rows.Count > 0 Then
            intFila = 0

            For numReg = 0 To dbDatos.Tables(0).Rows.Count - 1
                grd.Rows.Add()
                Fila = dbDatos.Tables(0).Rows.Item(numReg)
                grd.Rows(intFila).Cells("ID").Value() = Fila("IdKmAnual")
                grd.Rows(intFila).Cells("Coche").Value() = Fila("Modelo")
                grd.Rows(intFila).Cells("Año").Value() = Fila("Anyo")
                grd.Rows(intFila).Cells("Mes").Value() = UCase(MonthName(Fila("Mes"), True))
                grd.Rows(intFila).Cells("numMes").Value() = Fila("Mes")
                grd.Rows(intFila).Cells("KmFinal").Value() = Fila("KmFinal")
                grd.Rows(intFila).Cells("KmParcial").Value = Fila("KmParcial")
                grd.Rows(intFila).Cells("KmWeek").Value = Math.Round(Fila("AvgWeek"), 2)
                grd.Rows(intFila).Cells("KmDay").Value = Math.Round(Fila("AvgDay"), 2)
                If Not IsDBNull(Fila("FuelTot")) Then _
                    grd.Rows(intFila).Cells("FuelMes").Value = Math.Round(Fila("FuelTot"), 1)
                If Not IsDBNull(Fila("FuelWeek")) Then _
                    grd.Rows(intFila).Cells("FuelWeek").Value = Math.Round(Fila("FuelWeek"), 1)
                If Not IsDBNull(Fila("FuelDay")) Then _
                    grd.Rows(intFila).Cells("FuelDay").Value = Math.Round(Fila("FuelDay"), 1)

                intFila = intFila + 1
            Next

        End If

    End Sub

    Private Sub FrmRegKmsMes_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        BDClose(miBD)
    End Sub

    Private Sub FrmRegKmsMes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mes As Integer
        Dim fechaHoy As Date

        Dim fechaAux As Date

        Me.MdiParent = FrmMain
        fechaHoy = DateTime.Today
        fechaHoy = "01/" & Month(fechaHoy).ToString() & "/" & Year(fechaHoy).ToString()

        BDOpen(miBD)

        For mes = 1 To 12
            cbMes.Items.Add(UCase(MonthName(mes)))
        Next

        Me.txtAño.Text = Year(Today)
        Me.cbMes.SelectedIndex = Month(Today) - 1

        Me.txtFechaIni.Text = DateAdd("m", -12, fechaHoy).ToString("dd/MM/yyyy")

        fechaAux = DateAdd("m", 1, fechaHoy)
        fechaAux = DateAdd("d", -1, fechaAux)

        Me.txtFechaFin.Text = fechaAux.ToString("dd/MM/yyyy")

        RellenarGrdKmMensual(Me.grdKmMes)
        RellenarGrdKmAños(Me.grdKmAño)

    End Sub

    Private Sub BtLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLimpiar.Click
        Me.txtAño.Text = Year(Today)
        Me.cbMes.SelectedIndex = Month(Today) - 1
        'Me.txtFechaIni.Text = "__/__/____"
        Me.txtKmFinal.Text = ""
        Me.txtKmParcial.Text = ""
        Me.txtIdKm.Text = ""

    End Sub

    Private Sub grdKmMes_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdKmMes.RowHeaderMouseClick
        Dim filas As DataGridViewSelectedRowCollection


        filas = grdKmMes.SelectedRows

        Me.txtIdKm.Text = ValNulo(filas(0).Cells("ID").Value, "TEXT")
        Me.txtAño.Text = ValNulo(filas(0).Cells("Año").Value, "TEXT")
        If Not IsDBNull(filas(0).Cells("numMes").Value) Then _
            Me.cbMes.SelectedIndex = filas(0).Cells("numMes").Value - 1

        Me.txtKmFinal.Text = ValNulo(filas(0).Cells("KmFinal").Value, "TEXT")
        Me.txtKmParcial.Text = ValNulo(filas(0).Cells("KmParcial").Value, "TEXT")


    End Sub

    Private Sub BtGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtGuardar.Click
        Dim strSql As String
        Dim comando As MySqlCommand
        Dim resul As Integer

        strSql = "Call Sp_GuardarKmMes (" & cbMes.SelectedIndex + 1 _
        & "," & txtAño.Text & "," & Replace(txtKmFinal.Text, ",", ".") & ")"
        comando = New MySqlCommand(strSql, miBD)
        resul = comando.ExecuteNonQuery()
        RellenarGrdKmMensual(Me.grdKmMes)
        RellenarGrdKmAños(Me.grdKmAño)

    End Sub

    Private Sub BtAplicaFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAplicaFiltro.Click

        RellenarGrdKmMensual(Me.grdKmMes)

    End Sub

    Private Sub BtQuitarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtQuitarFiltro.Click
        txtFechaIni.Text = "__/__/____"
        txtFechaFin.Text = "__/__/____"
        RellenarGrdKmMensual(Me.grdKmMes)
    End Sub
End Class