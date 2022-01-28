Public Class FrmRegGstFuel
    Dim miBD As MySqlConnection

    Private Sub FrmRegGstFuel_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        BDClose(miBD)
    End Sub

    Private Sub FrmRegGstFuel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim fechaHoy As Date
        Dim strSql As String
        Dim fechaAux As Date

        Me.MdiParent = FrmMain

        BDOpen(miBD)
        'InitColsGrdGstFuel(Me.grdGstFuel)
        fechaHoy = DateTime.Today
        fechaHoy = "01/" & Month(fechaHoy).ToString() & "/" & Year(fechaHoy).ToString()

        Me.txtFechaIni.Text = DateAdd("m", -3, fechaHoy).ToString("dd/MM/yyyy")

        fechaAux = DateAdd("m", 1, fechaHoy)
        fechaAux = DateAdd("d", -1, fechaAux)
        Me.txtFechaFin.Text = fechaAux.ToString("dd/MM/yyyy")


        strSql = "Select IdVehiculo, Concat(Marca, ' ', Modelo) as MarcaModelo From tbl_vehiculos " _
        & " Where IdVehiculo in (2, 4) " _
        & " Order by IdVehiculo desc "

        cargarCombo(Me.CmbCoche, strSql, "MarcaModelo", "IdVehiculo", miBD)

        RellenarGrdGstFuel(Me.grdGstFuel)

    End Sub

    Private Sub InitColsGrdGstFuel(ByRef grd As DataGridView)

        SetGrdReadOnly(grd)
        grd.ColumnCount = 10
        setColHeader(grd, 0, "idGstFuel", 30, True)
        setColHeader(grd, 1, "Coche", 80)
        setColHeader(grd, 2, "Fecha", 80)
        setColHeader(grd, 3, "Litros", 50)
        setColHeader(grd, 4, "Llenado", 50)
        setColHeader(grd, 5, "Importe", 60)
        setColHeader(grd, 6, "PrecioL", 45)
        setColHeader(grd, 7, "KmTotal", 70)
        setColHeader(grd, 8, "KmParcial", 60)
        setColHeader(grd, 9, "KmEstima", 60)

    End Sub

    Private Sub InitColsGrdGstFuelMeses(ByRef grd As DataGridView)

        SetGrdReadOnly(grd)
        grd.ColumnCount = 10
        setColHeader(grd, 0, "Coche", 80)
        setColHeader(grd, 1, "Año", 40)
        setColHeader(grd, 2, "Mes", 40)
        setColHeader(grd, 3, "TotLitros", 50)
        setColHeader(grd, 4, "TotImp", 50)
        setColHeader(grd, 5, "Refuel", 40)
        setColHeader(grd, 6, "MinKm", 60, True)
        setColHeader(grd, 7, "MaxKm", 60, True)
        setColHeader(grd, 8, "MinCost", 50)
        setColHeader(grd, 9, "MaxCost", 50)

    End Sub

    Private Sub InitColsGrdGstFuelAños(ByRef grd As DataGridView)

        SetGrdReadOnly(grd)
        grd.ColumnCount = 9
        setColHeader(grd, 0, "Coche", 80)
        setColHeader(grd, 1, "Año", 40)
        setColHeader(grd, 2, "TotLitros", 50)
        setColHeader(grd, 3, "TotImp", 50)
        setColHeader(grd, 4, "Refuel", 40)
        'setColHeader(grd, 4, "AvgLitros", 55)
        'setColHeader(grd, 5, "AvgImp", 50)
        setColHeader(grd, 5, "LitrosMes", 55)
        setColHeader(grd, 6, "ImpMes", 50)
        setColHeader(grd, 7, "MinCost", 50)
        setColHeader(grd, 8, "MaxCost", 50)

    End Sub

    Private Sub RellenarGrdGstFuelAños(ByRef grd As DataGridView)
        Dim strSql As String
        Dim dbDatos As DataSet, Fila As DataRow
        Dim intFila As Integer, numReg As Integer

        grd.Rows.Clear()
        InitColsGrdGstFuelAños(grd)

        strSql = "Select Year(Fecha) Anyo" & _
        ", Sum(Litros) TotLitros, Sum(Importe) TotImporte" & _
        ", count(*) as NumRepost" & _
        ", Min(PrecioLitro) MinPrecio, Max(PrecioLitro) MaxPrecio" & _
        ", Avg(Litros) AvgLitros, Avg(Importe) AvgImporte " & _
        ", SUM(Litros)/( Max(Month(Fecha)) - Min(Month(Fecha))+1) LitrosMes" & _
        ", SUM(Importe)/( Max(Month(Fecha)) - Min(Month(Fecha))+1) ImpMes" & _
        ", tbl_vehiculos.Modelo " & _
        " From tbl_reggstfuel inner join tbl_vehiculos " & _
        " on tbl_reggstfuel.IdVehiculo=tbl_vehiculos.IdVehiculo " & _
        " Where tbl_reggstfuel.idVehiculo in (2, 4) " & _
        " Group By Year(Fecha), tbl_vehiculos.Modelo " & _
        " Order By Year(Fecha) Desc, tbl_vehiculos.IdVehiculo Desc "

        dbDatos = New Data.DataSet
        CargarDataSet(miBD, strSql, dbDatos)

        If dbDatos.Tables(0).Rows.Count > 0 Then
            intFila = 0

            For numReg = 0 To dbDatos.Tables(0).Rows.Count - 1
                grd.Rows.Add()
                Fila = dbDatos.Tables(0).Rows.Item(numReg)

                grd.Rows(intFila).Cells("Coche").Value() = Fila("Modelo")
                grd.Rows(intFila).Cells("Año").Value() = Fila("Anyo")
                grd.Rows(intFila).Cells("TotLitros").Value() = Math.Round(Fila("TotLitros"), 1)
                grd.Rows(intFila).Cells("TotImp").Value() = Math.Round(Fila("TotImporte"), 1)
                grd.Rows(intFila).Cells("Refuel").Value = Fila("NumRepost")
                'grd.Rows(intFila).Cells("AvgLitros").Value() = Math.Round(Fila("AvgLitros"), 1)
                'grd.Rows(intFila).Cells("AvgImp").Value() = Math.Round(Fila("AvgImporte"), 1)
                grd.Rows(intFila).Cells("LitrosMes").Value() = Math.Round(Fila("LitrosMes"), 1)
                grd.Rows(intFila).Cells("ImpMes").Value() = Math.Round(Fila("ImpMes"), 1)
                grd.Rows(intFila).Cells("MinCost").Value() = Fila("MinPrecio")
                grd.Rows(intFila).Cells("MaxCost").Value() = Fila("MaxPrecio")

                intFila = intFila + 1
            Next

        End If

    End Sub

    Private Sub RellenarGrdGstFuelMeses(ByRef grd As DataGridView)
        Dim strSql As String
        Dim dbDatos As DataSet, Fila As DataRow
        Dim intFila As Integer, numReg As Integer

        grd.Rows.Clear()
        InitColsGrdGstFuelMeses(grd)

        strSql = "Select Year(Fecha) Anyo, Month(Fecha) NumMes" & _
        ", Sum(Litros) TotLitros, Sum(Importe) TotImporte, count(*) as NumRepost" & _
        ", Min(CuentaKmTotal) MinKm, Max(CuentaKmTotal) MaxKm" & _
        ", Min(PrecioLitro) MinPrecio, Max(PrecioLitro) MaxPrecio" & _
        ", tbl_vehiculos.Modelo " & _
        " From tbl_reggstfuel inner join tbl_vehiculos " & _
        " on tbl_reggstfuel.IdVehiculo=tbl_vehiculos.IdVehiculo " & _
        " Where tbl_reggstfuel.idVehiculo in (2, 4) " & _
        " Group By Year(Fecha), Month(Fecha), tbl_vehiculos.modelo " & _
        " Order By Year(Fecha) Desc, Month(Fecha) Desc"

        dbDatos = New Data.DataSet
        CargarDataSet(miBD, strSql, dbDatos)

        If dbDatos.Tables(0).Rows.Count > 0 Then
            intFila = 0

            For numReg = 0 To dbDatos.Tables(0).Rows.Count - 1
                grd.Rows.Add()
                Fila = dbDatos.Tables(0).Rows.Item(numReg)
                grd.Rows(intFila).Cells("Coche").Value = Fila("Modelo")
                grd.Rows(intFila).Cells("Año").Value() = Fila("Anyo")
                grd.Rows(intFila).Cells("Mes").Value() = UCase(MonthName(Fila("NumMes"), True))
                grd.Rows(intFila).Cells("TotLitros").Value() = Fila("TotLitros")
                grd.Rows(intFila).Cells("TotImp").Value() = Fila("TotImporte")
                grd.Rows(intFila).Cells("Refuel").Value = Fila("NumRepost")
                'grd.Rows(intFila).Cells("MinKm").Value() = Fila("MinKm")
                'grd.Rows(intFila).Cells("MaxKm").Value() = Fila("MaxKm")
                grd.Rows(intFila).Cells("MinCost").Value() = Fila("MinPrecio")
                grd.Rows(intFila).Cells("MaxCost").Value() = Fila("MaxPrecio")

                intFila = intFila + 1
            Next

        End If


    End Sub

    Private Sub RellenarGrdGstFuel(ByRef grd As DataGridView)
        Dim strSql As String
        Dim dbDatos As DataSet, Fila As DataRow
        Dim intFila As Integer, numReg As Integer

        grd.Rows.Clear()
        InitColsGrdGstFuel(grd)

        strSql = "Select * " & _
        " From vst_gstfuel " & _
        " Where IdVehiculo In (2, 4) "
        If IsDate(txtFechaIni.Text) Then
            strSql = strSql & " And  Fecha>='" & FechaANSI_SQL(txtFechaIni.Text) & "'"
        End If
        If IsDate(txtFechaFin.Text) Then
            strSql = strSql & " And Fecha<='" & FechaANSI_SQL(txtFechaFin.Text) & "'"
        End If
        strSql = strSql & " Order By Fecha Desc"

        dbDatos = New Data.DataSet
        CargarDataSet(miBD, strSql, dbDatos)

        If dbDatos.Tables(0).Rows.Count > 0 Then
            intFila = 0

            For numReg = 0 To dbDatos.Tables(0).Rows.Count - 1
                grd.Rows.Add()
                Fila = dbDatos.Tables(0).Rows.Item(numReg)
                grd.Rows(intFila).Cells("idGstFuel").Value() = Fila("idGstFuel")

                grd.Rows(intFila).Cells("Coche").Value() = Fila("Modelo")

                grd.Rows(intFila).Cells("Fecha").Value() = Fila("FechaFmt")
                grd.Rows(intFila).Cells("Litros").Value() = Fila("Litros")
                grd.Rows(intFila).Cells("Llenado").Value() = Fila("Llenado")
                grd.Rows(intFila).Cells("Importe").Value() = Fila("Importe")
                grd.Rows(intFila).Cells("PrecioL").Value() = Fila("PrecioLitro")
                grd.Rows(intFila).Cells("KmTotal").Value() = Fila("CuentaKmTotal")
                grd.Rows(intFila).Cells("KmParcial").Value() = Fila("DstParcial")
                grd.Rows(intFila).Cells("KmEstima").Value() = Math.Round(Fila("KmEstima"))

                intFila = intFila + 1
            Next

        End If


    End Sub

    Private Sub BtLimpiarCampos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLimpiarCampos.Click
        Me.txtIdGstFuel.Text = ""
        Me.txtFecha.Text = "__/__/____"
        Me.txtImporte.Text = ""
        Me.txtLitros.Text = ""
        Me.chkLlenado.Checked = False
        Me.txtPrecioLitro.Text = ""
        Me.txtKmParcial.Text = ""
        Me.txtKmTotal.Text = ""
    End Sub

    Private Sub BtAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAgregar.Click
        Dim strSql As String, resul As Integer
        Dim comando As MySqlCommand
        Dim returnObj As Object
        Dim Litros As Single, Importe As Single, PrecioLitro As Single

        'Validacion de datos
        If Not (txtFecha.Text <> "__/__/____" And IsDate(txtFecha.Text)) Then
            MsgBox("Fecha con formato incorrecto o fecha no válida")
            Exit Sub
        End If

        If Not (txtImporte.Text <> "" And IsNumeric(txtImporte.Text)) Then
            MsgBox("Importe está en blanco o no es número válido")
            Exit Sub
        End If

        If Not (txtLitros.Text <> "" And IsNumeric(txtLitros.Text)) Then
            MsgBox("Litros está en blanco o no es número válido")
            Exit Sub
        End If

        If Not (txtPrecioLitro.Text <> "" And IsNumeric(txtPrecioLitro.Text)) Then
            txtPrecioLitro.Text = Math.Round(txtImporte.Text / txtLitros.Text, 3)
        End If

        If Not (txtKmTotal.Text <> "" And IsNumeric(txtKmTotal.Text)) Then
            MsgBox("Kilometraje Total está en blanco o no es número válido")
            Exit Sub
        End If

        Litros = CSng(Replace(txtLitros.Text, ".", ","))
        Litros = Math.Round(Litros, 2)

        Importe = CSng(Replace(txtImporte.Text, ".", ","))
        Importe = Math.Round(Importe, 2)

        PrecioLitro = CSng(Replace(txtPrecioLitro.Text, ".", ","))
        PrecioLitro = Math.Round(PrecioLitro, 3)


        strSql = "INSERT INTO tbl_reggstfuel " &
        " (IdVehiculo, Fecha, Litros, Llenado, Importe, PrecioLitro, CuentaKmTotal, DstParcial)" &
        " VALUES (" & 4 &
        ", '" & FechaANSI_SQL(txtFecha.Text) & "'" &
        ", " & Litros.ToString.Replace(",", ".") &
        ", " & Math.Abs(CInt(Me.chkLlenado.Checked)) &
        ", " & Importe.ToString.Replace(",", ".") &
        ", " & PrecioLitro.ToString.Replace(",", ".") &
        ", " & txtKmTotal.Text
        If Trim(txtKmParcial.Text) = "" Then
            strSql = strSql & ", NULL"
        Else
            strSql = strSql & ", " & txtKmParcial.Text
        End If
        strSql = strSql & ")"


        comando = New MySqlCommand(strSql, miBD)
        resul = comando.ExecuteNonQuery()
        If resul > 0 Then
            strSql = "Call SP_GuardarKmParcialFuel (""" & FechaANSI_SQL(txtFecha.Text) & """" _
            & ", " & txtKmTotal.Text & ")"
            comando.CommandText = strSql
            resul = comando.ExecuteNonQuery()
            If resul = 0 Then
                MsgBox("No se ha podido actualizar el KmParcial del registro anterior")
            End If

            strSql = "Select * From vst_gstfuel " &
               " Where IdVehiculo=4" &
               " And Fecha='" & FechaANSI_SQL(txtFecha.Text) & "'" &
               " And Importe=" & Importe.ToString.Replace(",", ".")
            comando.CommandText = strSql
            returnObj = comando.ExecuteScalar()
            txtIdGstFuel.Text = returnObj.ToString
            RellenarGrdGstFuel(Me.grdGstFuel)
            MsgBox("Se ha insertado correctamente el gasto de fuel")
        End If

    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click

        Select Case TabControl1.SelectedIndex

            Case 0
                RellenarGrdGstFuel(Me.grdGstFuel)

            Case 1
                RellenarGrdGstFuelMeses(Me.grdGstFuelMensual)
                RellenarGrdGstFuelAños(Me.grdGstFuelAnual)

        End Select

    End Sub

    'Private Sub txtPrecioLitro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecioLitro.GotFocus
    '    Dim Importe As Single, Litros As Single

    '    If Me.txtImporte.Text <> "" And IsNumeric(Me.txtImporte.Text) _
    '    And Me.txtLitros.Text <> "" And IsNumeric(Me.txtLitros.Text) Then
    '        Importe = CSng(Replace(txtImporte.Text, ".", ","))
    '        Litros = CSng(Replace(txtLitros.Text, ".", ","))
    '        txtPrecioLitro.Text = Math.Round(Importe / Litros, 3)
    '    End If

    'End Sub

  
    Private Sub BtModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtModificar.Click
        Dim strSql As String
        Dim comando As MySqlCommand, n As Integer
        Dim Litros As Single, Importe As Single, PrecioLitro As Single

        If Not (Trim(Me.txtIdGstFuel.Text) <> "" And IsNumeric(Me.txtIdGstFuel.Text)) Then
            MsgBox("Error, el camop IdGstFuel no puede estar en blanco y debe ser numérico")
        Else

            Litros = CSng(Replace(txtLitros.Text, ".", ","))
            Litros = Math.Round(Litros, 2)

            Importe = CSng(Replace(txtImporte.Text, ".", ","))
            Importe = Math.Round(Importe, 2)

            PrecioLitro = CSng(Replace(txtPrecioLitro.Text, ".", ","))
            PrecioLitro = Math.Round(PrecioLitro, 3)


            strSql = "UPDATE tbl_reggstfuel " &
            " SET Fecha='" & FechaANSI_SQL(txtFecha.Text) & "'" &
            " , Litros=" & Litros.ToString.Replace(",", ".") &
            " , Llenado=" & Math.Abs(CInt(Me.chkLlenado.Checked)) &
            " , Importe=" & Importe.ToString.Replace(",", ".") &
            " , PrecioLitro=" & PrecioLitro.ToString.Replace(",", ".") &
            " , CuentaKmTotal=" & txtKmTotal.Text
            If Trim(txtKmParcial.Text) = "" Then
                strSql = strSql & ", DstParcial=NULL"
            Else
                strSql = strSql & ", DstParcial=" & txtKmParcial.Text
            End If
            strSql = strSql & " WHERE IdGstFuel=" & Me.txtIdGstFuel.Text

            comando = New MySqlCommand(strSql, miBD)
            n = comando.ExecuteNonQuery()
            If n > 0 Then
                strSql = "Call SP_GuardarKmParcialFuel (""" & FechaANSI_SQL(txtFecha.Text) & """" _
                & ", " & txtKmTotal.Text & ")"
                comando.CommandText = strSql
                n = comando.ExecuteNonQuery()
                If n = 0 Then
                    MsgBox("No se ha podido actualizar el KmParcial del registro anterior")
                End If

                RellenarGrdGstFuel(Me.grdGstFuel)
                MsgBox("Se ha actualizado el registro satisfactoriamente")
            Else
                MsgBox("No se han actualizado registros")
            End If

        End If


    End Sub

    Private Sub grdGstFuel_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdGstFuel.RowHeaderMouseClick
        Dim filas As DataGridViewSelectedRowCollection
        Dim Fecha As String

        filas = grdGstFuel.SelectedRows

        If Not IsDBNull(filas(0).Cells("IdGstFuel").Value) Then
            txtIdGstFuel.Text = filas(0).Cells("IdGstFuel").Value
        Else
            txtIdGstFuel.Text = ""
        End If

        If Not IsDBNull(filas(0).Cells("Fecha").Value) Then
            Fecha = filas(0).Cells("Fecha").Value
            Fecha = DateAndTime.Day(Fecha) & "/" & DateAndTime.Month(Fecha) _
            & "/" & DateAndTime.Year(Fecha)
            txtFecha.Text = Format(CDate(Fecha), "dd/MM/yyyy")
        Else
            txtFecha.Text = ""
        End If

        If Not IsDBNull(filas(0).Cells("Litros").Value) Then
            txtLitros.Text = filas(0).Cells("Litros").Value
        Else
            txtLitros.Text = ""
        End If

        If Not IsDBNull(filas(0).Cells("Llenado").Value) Then
            chkLlenado.Checked = CBool(filas(0).Cells("Llenado").Value)
        Else
            chkLlenado.Checked = 0
        End If

        If Not IsDBNull(filas(0).Cells("Importe").Value) Then
            txtImporte.Text = filas(0).Cells("Importe").Value
        Else
            txtImporte.Text = ""
        End If

        If Not IsDBNull(filas(0).Cells("PrecioL").Value) Then
            txtPrecioLitro.Text = filas(0).Cells("PrecioL").Value
        Else
            txtPrecioLitro.Text = ""
        End If

        If Not IsDBNull(filas(0).Cells("kmTotal").Value) Then
            txtKmTotal.Text = filas(0).Cells("kmTotal").Value
        Else
            txtKmTotal.Text = ""
        End If

        If Not IsDBNull(filas(0).Cells("KmParcial").Value) Then
            txtKmParcial.Text = filas(0).Cells("KmParcial").Value
        Else
            txtKmParcial.Text = ""
        End If



    End Sub

    Private Sub BtAplicaFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAplicaFiltro.Click
        RellenarGrdGstFuel(grdGstFuel)
    End Sub

    Private Sub BtQuitarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtQuitarFiltro.Click
        txtFechaIni.Text = "__/__/____"
        txtFechaFin.Text = "__/__/____"
        RellenarGrdGstFuel(grdGstFuel)
    End Sub

    Private Sub txtLitros_GotFocus(sender As Object, e As System.EventArgs) Handles txtLitros.GotFocus
        Dim Importe As Single, PrecioLitro As Single

        If Me.txtImporte.Text <> "" And IsNumeric(Me.txtImporte.Text) _
        And Me.txtPrecioLitro.Text <> "" And IsNumeric(Me.txtPrecioLitro.Text) Then
            Importe = CSng(Replace(txtImporte.Text, ".", ","))
            PrecioLitro = CSng(Replace(txtPrecioLitro.Text, ".", ","))
            'Importe = CSng(Replace(txtImporte.Text, ",", "."))
            'PrecioLitro = CSng(Replace(txtPrecioLitro.Text, ",", "."))
            txtLitros.Text = Math.Round(Importe / PrecioLitro, 2)

        End If

    End Sub

 
End Class