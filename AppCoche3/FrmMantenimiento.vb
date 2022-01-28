Public Class FrmMantenimiento

    Dim miBD As MySqlConnection

    Const m_IdCocheActual = 4

    Private Sub InitColsGrdManteni(ByRef grd As DataGridView)

        SetGrdReadOnly(grd)
        grd.ColumnCount = 13

        setColHeader(grd, 0, "ID", 30, True)
        setColHeader(grd, 1, "Coche", 70)
        setColHeader(grd, 2, "Año", 40)
        setColHeader(grd, 3, "Mes", 40)
        setColHeader(grd, 4, "numMes", 30, True)
        setColHeader(grd, 5, "Fecha", 70)
        setColHeader(grd, 6, "IdTipoManteni", 30, True)
        setColHeader(grd, 7, "TipoManteni", 100)
        setColHeader(grd, 8, "Descripcion", 150)
        setColHeader(grd, 9, "KmVehic", 50)
        setColHeader(grd, 10, "ImpTotal", 50)
        setColHeader(grd, 11, "ImpBruto", 50)
        setColHeader(grd, 12, "IVA", 40)

    End Sub

    Private Sub InitColsGrdLineaManteni(ByRef grd As DataGridView)

        SetGrdReadOnly(grd)
        grd.ColumnCount = 9

        setColHeader(grd, 0, "IdLinea", 30, True)
        setColHeader(grd, 1, "IdTipoLinea", 30, True)
        setColHeader(grd, 2, "TipoLinea", 130)
        setColHeader(grd, 3, "IdTipoPiezaOperacion", 30, True)
        setColHeader(grd, 4, "PiezaOperacion", 130)
        setColHeader(grd, 5, "Descripcion", 150)
        setColHeader(grd, 6, "ImpTotal", 50)
        setColHeader(grd, 7, "ImpBruto", 50)
        setColHeader(grd, 8, "IVA", 50)

    End Sub

    Private Sub RellenarLineaManteni(ByRef grd As DataGridView, ByVal idManteni As String)
        Dim strSql As String
        Dim dbDatos As DataSet, Fila As DataRow
        Dim intFila As Integer, numReg As Integer

        grd.Rows.Clear()
        InitColsGrdLineaManteni(grd)

        If Not IsStrNum(idManteni) Then
            MsgBox("No se puede determinar el campo IdMantenimiento")
            Exit Sub
        End If

        strSql = "Select idLineaManteni, tbl_lineamantenimiento.IdTipoLinea, tbl_tipolinea.tipolinea" _
        & ", tbl_lineamantenimiento.IdTipoPiezaOperacion, tbl_tipopiezaoperacion.tipoPiezaOperacion" _
        & ", Descripcion, Imp_Total, Imp_Bruto, Imp_IVA" _
        & " From tbl_lineamantenimiento Left Join tbl_tipopiezaoperacion" _
        & " On tbl_lineamantenimiento.IdTipoPiezaOperacion=tbl_tipopiezaoperacion.idTipoPiezaOperacion" _
        & " left join tbl_tipolinea" _
        & " On tbl_lineamantenimiento.IdTipoLinea=tbl_tipolinea.IdtipoLinea" _
        & " Where idMantenimiento=" & idManteni & ";"

        dbDatos = New Data.DataSet
        CargarDataSet(miBD, strSql, dbDatos)

        If dbDatos.Tables(0).Rows.Count > 0 Then
            intFila = 0

            For numReg = 0 To dbDatos.Tables(0).Rows.Count - 1
                grd.Rows.Add()
                Fila = dbDatos.Tables(0).Rows.Item(numReg)

                grd.Rows(intFila).Cells("IdLinea").Value = Fila("IdLineaManteni")
                grd.Rows(intFila).Cells("IdTipoLinea").Value = Fila("IdTipoLinea")
                grd.Rows(intFila).Cells("TipoLinea").Value = Fila("TipoLinea")
                grd.Rows(intFila).Cells("IdTipoPiezaOperacion").Value = Fila("IdTipoPiezaOperacion")
                grd.Rows(intFila).Cells("PiezaOperacion").Value = Fila("TipoPiezaOperacion")
                grd.Rows(intFila).Cells("Descripcion").Value = Fila("Descripcion")
                grd.Rows(intFila).Cells("ImpTotal").Value = Fila("Imp_Total")
                grd.Rows(intFila).Cells("ImpBruto").Value = Fila("Imp_Bruto")
                grd.Rows(intFila).Cells("IVA").Value = Fila("Imp_IVA")

                intFila = intFila + 1
            Next

        End If


    End Sub

    Private Sub RellenarManteni(ByRef grd As DataGridView)
        Dim strSql As String
        Dim dbDatos As DataSet, Fila As DataRow
        Dim intFila As Integer, numReg As Integer

        grd.Rows.Clear()
        InitColsGrdManteni(grd)

        strSql = "Select tbl_vehiculos.modelo, idMantenimiento, Mes, Anyo, Fecha, TipoManteni" _
        & ", tbl_tipomantenimiento.TipoMantenimiento, Descripcion, KmVehiculo" _
        & " , ImporteTotal, ImporteBruto, Imp_IVA" _
        & " From tbl_mantenimiento left join tbl_tipomantenimiento " _
        & " On tbl_mantenimiento.TipoManteni=tbl_tipomantenimiento.idTipoManteni " _
        & " left join tbl_vehiculos " _
        & " On tbl_mantenimiento.IdVehiculo=tbl_vehiculos.IdVehiculo " _
        & " Where tbl_mantenimiento.idVehiculo in (2, 4) " _
        & " Order By str_to_date(replace(fecha,'/','-'), '%d-%m-%Y') Desc;"

        'strSql = "Select tbl_mantenimiento.idMantenimiento" _
        '& ", Mes, Año, Fecha" _
        '& ", TipoManteni, tbl_tipoMantenimiento.TipoMantenimiento" _
        '& ", tbl_mantenimiento.Descripcion, KmVehiculo" _
        '& ", sum(tbl_lineaMantenimiento.Imp_total) as Suma_ImpTotal" _
        '& ", sum(tbl_lineaMantenimiento.Imp_Bruto) as Suma_ImpBruto" _
        '& ", sum(tbl_lineaMantenimiento.Imp_IVA) as Suma_ImpIVA" _
        '& " From tbl_mantenimiento left join tbl_tipoMantenimiento" _
        '& " On tbl_mantenimiento.TipoManteni=tbl_tipomantenimiento.idTipoManteni" _
        '& " Left Join tbl_lineamantenimiento" _
        '& " On tbl_mantenimiento.idMantenimiento=tbl_lineamantenimiento.idMantenimiento" _
        '& " Where idVehiculo = 2" _
        '& " Group By tbl_mantenimiento.idMantenimiento" _
        '& ", Mes, Año, Fecha" _
        '& ", TipoManteni, tbl_tipoMantenimiento.TipoMantenimiento" _
        '& ", tbl_mantenimiento.Descripcion, KmVehiculo" _
        '& " Order By Año Desc, Mes Desc;"

        dbDatos = New Data.DataSet
        CargarDataSet(miBD, strSql, dbDatos)

        If dbDatos.Tables(0).Rows.Count > 0 Then
            intFila = 0

            For numReg = 0 To dbDatos.Tables(0).Rows.Count - 1
                grd.Rows.Add()
                Fila = dbDatos.Tables(0).Rows.Item(numReg)

                grd.Rows(intFila).Cells("Coche").Value = ValNulo(Fila("Modelo"), "text")
                grd.Rows(intFila).Cells("ID").Value = Fila("IdMantenimiento")
                grd.Rows(intFila).Cells("Año").Value = Fila("Anyo")
                If Fila("Mes") >= 1 And Fila("Mes") <= 12 Then _
                grd.Rows(intFila).Cells("Mes").Value = UCase(MonthName(Fila("Mes"), True))

                grd.Rows(intFila).Cells("numMes").Value = Fila("Mes")
                grd.Rows(intFila).Cells("Fecha").Value = ValNulo(Fila("Fecha"), "text")
                grd.Rows(intFila).Cells("IdTipoManteni").Value = Fila("TipoManteni")
                grd.Rows(intFila).Cells("tipoManteni").Value = ValNulo(Fila("TipoMantenimiento"), "text")
                grd.Rows(intFila).Cells("Descripcion").Value = ValNulo(Fila("Descripcion"), "text")
                grd.Rows(intFila).Cells("KmVehic").Value = ValNulo(Fila("KmVehiculo"), "text")
                grd.Rows(intFila).Cells("ImpTotal").Value = ValNulo(Fila("ImporteTotal"), "text")
                grd.Rows(intFila).Cells("ImpBruto").Value = ValNulo(Fila("ImporteBruto"), "text")
                grd.Rows(intFila).Cells("IVA").Value = ValNulo(Fila("Imp_IVA"), "text")

                intFila = intFila + 1
            Next

        End If

    End Sub

    Private Sub FrmMantenimiento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        BDClose(miBD)
    End Sub

    Private Sub FrmMantenimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mes As Integer
        Dim strSql As String

        Me.MdiParent = FrmMain

        BDOpen(miBD)

        For mes = 1 To 12
            cbMes.Items.Add(UCase(MonthName(mes)))
        Next

        Me.txtAño.Text = Year(Today)
        Me.cbMes.SelectedIndex = Month(Today) - 1

        strSql = "Select * from tbl_tipomantenimiento Order By TipoMantenimiento;"
        cargarCombo(Me.cbTipoManteni, strSql, "TipoMantenimiento", "IdTipoManteni", miBD)

        'tipo Linea
        strSql = "Select * From tbl_tipolinea Order By TipoLinea;"
        cargarCombo(Me.cbTipoLinea, strSql, "TipoLinea", "IdTipoLinea", miBD)

        'tipo PiezaOperacion
        strSql = "Select * From tbl_tipopiezaoperacion Order By TipoPiezaOperacion;"
        cargarCombo(Me.cbTipoPiez, strSql, "TipoPiezaOperacion", "IdTipoPiezaOperacion", miBD)

        RellenarManteni(Me.grdManteni)
        InitColsGrdLineaManteni(Me.grdLineaManteni)

    End Sub


    Private Sub BtLimpiarManteni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLimpiarManteni.Click

        Me.txtIdManteni.Text = ""
        Me.txtAño.Text = ""
        Me.cbMes.SelectedIndex = -1
        Me.txtFecha.Text = "__/__/____"
        Me.cbTipoManteni.SelectedIndex = -1
        Me.txtDescManteni.Text = ""
        Me.txtKm.Text = ""
        Me.txtImpTotal.Text = ""
        Me.txtImpBruto.Text = ""
        Me.txtImpIVA.Text = ""

    End Sub


    Private Sub BtLimpiarLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLimpiarLinea.Click

        Me.txtIdLineaManteni.Text = ""
        Me.cbTipoLinea.SelectedIndex = -1
        Me.cbTipoPiez.SelectedIndex = -1
        Me.txtDescLineaManteni.Text = ""
        Me.txt_ImpTotal_Linea.Text = ""
        Me.txt_ImpBruto_Linea.Text = ""
        Me.txt_ImpIVA_Linea.Text = ""

    End Sub

    Private Sub BtGuardarLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGuardarLinea.Click
        Dim strSql As String
        Dim miComando As MySqlCommand
        Dim nreg As Integer

        If Not IsStrNum(Me.txtIdManteni.Text) Then
            MsgBox("Error, no se puede determinar el valor de IdMantenimiento")
            Exit Sub
        End If

        If Me.txtIdLineaManteni.Text = "" Then

            strSql = "INSERT INTO tbl_lineamantenimiento " _
            & " (IdMantenimiento, IdTipoLinea, IdTipoPiezaOperacion " _
            & " , Descripcion, Imp_Total, Imp_Bruto, Imp_IVA) " _
            & " VALUES (" _
            & Me.txtIdManteni.Text

            If Me.cbTipoLinea.SelectedIndex = -1 Then
                strSql = strSql & ", NULL "
            Else
                strSql = strSql & ", " & Me.cbTipoLinea.SelectedValue
            End If

            If Me.cbTipoPiez.SelectedIndex = -1 Then
                strSql = strSql & ", NULL "
            Else
                strSql = strSql & ", " & Me.cbTipoPiez.SelectedValue
            End If

            strSql = strSql & ", '" & Me.txtDescLineaManteni.Text & "'" _
            & ", " & Replace(Me.txt_ImpTotal_Linea.Text, ",", ".") _
            & ", " & Replace(Me.txt_ImpBruto_Linea.Text, ",", ".") _
            & ", " & Replace(Me.txt_ImpIVA_Linea.Text, ",", ".") & ")"

        Else

            strSql = "UPDATE tbl_lineamantenimiento " _
            & " SET IdTipoLinea=" & Me.cbTipoLinea.SelectedValue

            If Me.cbTipoPiez.SelectedIndex = -1 Then
                strSql &= " , IdTipoPiezaOperacion=NULL"
            Else
                strSql &= " , IdTipoPiezaOperacion=" & Me.cbTipoPiez.SelectedValue
            End If

            strSql &= ", Descripcion='" & Me.txtDescLineaManteni.Text & "'" _
            & ", Imp_Total=" & Replace(Me.txt_ImpTotal_Linea.Text, ",", ".") _
            & ", Imp_Bruto=" & Replace(Me.txt_ImpBruto_Linea.Text, ",", ".") _
            & ", Imp_IVA=" & Replace(Me.txt_ImpIVA_Linea.Text, ",", ".") _
            & " WHERE idlineamanteni=" & Me.txtIdLineaManteni.Text

        End If

        miComando = New MySqlCommand(strSql, miBD)
        nreg = miComando.ExecuteNonQuery()

        If nreg > 0 Then
            RellenarLineaManteni(Me.grdLineaManteni, Me.txtIdManteni.Text)
            MsgBox("Registro insertado/actualizado correctamente")
        Else
            MsgBox("No se ha insertado/actualizado ningún registro")
        End If


    End Sub

    
    Private Sub BtGuardarManteni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGuardarManteni.Click
        Dim strSql As String
        Dim miComando As MySqlCommand
        Dim nreg As Integer

        If Me.txtIdManteni.Text = "" Then
            strSql = "Insert Into tbl_mantenimiento " _
                & " (IdVehiculo, Mes, anyo, Fecha " _
                & ",Descripcion, TipoManteni, KmVehiculo" _
                & ",ImporteTotal, ImporteBruto, Imp_IVA) " _
                & " VALUES ( " & m_IdCocheActual _
                & ", " & cbMes.SelectedIndex + 1 _
                & ", " & Me.txtAño.Text _
                & ", '" & Me.txtFecha.Text & "'" _
                & ", '" & Me.txtDescManteni.Text & "'" _
                & ", " & Me.cbTipoManteni.SelectedValue

            If IsStrNum(txtKm.Text) Then
                strSql = strSql & ", " & Replace(Me.txtKm.Text, ",", ".")
            Else
                strSql = strSql & ", Null"
            End If

            strSql = strSql & ", " & Replace(Me.txtImpTotal.Text, ",", ".")

            If IsStrNum(txtImpBruto.Text) Then
                strSql = strSql & ", " & Replace(Me.txtImpBruto.Text, ",", ".")
            Else
                strSql = strSql & ", Null"
            End If

            If IsStrNum(txtImpIVA.Text) Then
                strSql = strSql & ", " & Replace(Me.txtImpIVA.Text, ",", ".")
            Else
                strSql = strSql & ", Null"
            End If

            strSql = strSql & ")"
        Else
            strSql = "Update tbl_mantenimiento " _
              & " Set Mes=" & cbMes.SelectedIndex + 1 _
              & " , anyo=" & Me.txtAño.Text _
              & " , Fecha='" & Me.txtFecha.Text & "'" _
              & " , Descripcion='" & Me.txtDescManteni.Text & "'" _
              & " , TipoManteni=" & Me.cbTipoManteni.SelectedValue
            If IsStrNum(txtKm.Text) Then
                strSql = strSql & ", KmVehiculo=" & Replace(Me.txtKm.Text, ",", ".")
            Else
                strSql = strSql & ", KmVehiculo=Null"
            End If

            strSql = strSql & " , ImporteTotal=" & Replace(Me.txtImpTotal.Text, ",", ".")

            If IsStrNum(txtImpBruto.Text) Then
                strSql = strSql & ", ImporteBruto=" & Replace(Me.txtImpBruto.Text, ",", ".")
            Else
                strSql = strSql & ", ImporteBruto=Null"
            End If

            If IsStrNum(txtImpIVA.Text) Then
                strSql = strSql & ", Imp_IVA=" & Replace(Me.txtImpIVA.Text, ",", ".")
            Else
                strSql = strSql & ", Imp_IVA=Null"
            End If

            strSql = strSql & " Where IdMantenimiento=" & Me.txtIdManteni.Text

        End If

        miComando = New MySqlCommand(strSql, miBD)
        nreg = miComando.ExecuteNonQuery()

        If nreg > 0 Then
            RellenarManteni(Me.grdManteni)
            MsgBox("Registro guardado correctamente")
        Else
            MsgBox("No se ha guardado ningún registro")
        End If


    End Sub

    Private Sub grdManteni_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdManteni.RowHeaderMouseClick
        Dim filas As DataGridViewSelectedRowCollection

        filas = grdManteni.SelectedRows

        BtLimpiarLinea_Click(sender, e)

        Me.txtIdManteni.Text = ValNulo(filas(0).Cells("ID").Value, "TEXT")
        Me.txtAño.Text = ValNulo(filas(0).Cells("Año").Value, "TEXT")
        If Not IsDBNull(filas(0).Cells("numMes").Value) Then
            Me.cbMes.SelectedIndex = filas(0).Cells("numMes").Value - 1
        End If

        If Not IsDBNull(filas(0).Cells("Fecha").Value) Then
            Me.txtFecha.Text = filas(0).Cells("Fecha").Value
        End If

        If Not IsDBNull(filas(0).Cells("IdTipoManteni").Value) Then
            Me.cbTipoManteni.SelectedValue = filas(0).Cells("IdTipoManteni").Value
        End If

        Me.txtDescManteni.Text = ValNulo(filas(0).Cells("Descripcion").Value, "TEXT")
        Me.txtKm.Text = ValNulo(filas(0).Cells("KmVehic").Value, "TEXT")
        Me.txtImpTotal.Text = ValNulo(filas(0).Cells("ImpTotal").Value, "TEXT")
        Me.txtImpBruto.Text = ValNulo(filas(0).Cells("ImpBruto").Value, "TEXT")
        Me.txtImpIVA.Text = ValNulo(filas(0).Cells("IVA").Value, "TEXT")

        RellenarLineaManteni(Me.grdLineaManteni, Me.txtIdManteni.Text)

    End Sub



    Private Sub grdLineaManteni_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdLineaManteni.RowHeaderMouseClick
        Dim filas As DataGridViewSelectedRowCollection

        filas = grdLineaManteni.SelectedRows

        BtLimpiarLinea_Click(sender, e)

        Me.txtIdLineaManteni.Text = ValNulo(filas(0).Cells("IdLinea").Value, "TEXT")

        If Not IsDBNull(filas(0).Cells("IdTipoLinea").Value) Then
            Me.cbTipoLinea.SelectedValue = filas(0).Cells("IdTipoLinea").Value
        End If

        If Not IsDBNull(filas(0).Cells("IdTipoPiezaOperacion").Value) Then
            Me.cbTipoPiez.SelectedValue = filas(0).Cells("IdTipoPiezaOperacion").Value
        End If

        Me.txtDescLineaManteni.Text = ValNulo(filas(0).Cells("Descripcion").Value, "TEXT")
        Me.txt_ImpTotal_Linea.Text = ValNulo(filas(0).Cells("ImpTotal").Value, "NUM")
        Me.txt_ImpBruto_Linea.Text = ValNulo(filas(0).Cells("ImpBruto").Value, "NUM")
        Me.txt_ImpIVA_Linea.Text = ValNulo(filas(0).Cells("IVA").Value, "NUM")



    End Sub


    Private Sub BtAjustarImportes_Click(sender As Object, e As EventArgs) Handles BtAjustarImportes.Click
        Dim ImpBruto As Single
        Dim ImpTotal As Single
        Dim ImpIva As Single

        If IsStrNum(Me.txt_ImpBruto_Linea.Text) Then
            ImpBruto = CSng(Replace(txt_ImpBruto_Linea.Text, ".", ","))
            ImpIva = ImpBruto * m_IvaGen
            ImpTotal = ImpBruto + ImpIva

            txt_ImpIVA_Linea.Text = Math.Round(ImpIva, 2)
            txt_ImpTotal_Linea.Text = Math.Round(ImpTotal, 2)

        ElseIf IsStrNum(Me.txt_ImpTotal_Linea.Text) Then
            ImpTotal = CSng(Replace(txt_ImpTotal_Linea.Text, ".", ","))
            ImpBruto = ImpTotal / (1 + m_IvaGen)
            ImpIva = ImpTotal - ImpBruto

            txt_ImpBruto_Linea.Text = Math.Round(ImpTotal, 2)
            txt_ImpIVA_Linea.Text = Math.Round(ImpIva, 2)
        Else
            MsgBox("Debe indicar Imp Bruto o Imp Total")
        End If



    End Sub



End Class