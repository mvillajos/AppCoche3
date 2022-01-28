Imports System.Configuration.ConfigurationManager

Module API


    'Public Const NomServer = "localhost" '"192.168.1.104"
    'Public Const NomBD = "bdvehiculos2"

    'Public Const conexionBdVehiculos = "server=localhost;database=bdvehiculos2
    ';uid=mvillajos;pwd=marian2;"

    Public Const m_IvaGen = 0.21

    Friend Sub BDOpen(ByRef dbconnection As MySqlConnection)

        Dim strConexion As String

        strConexion = ConnectionStrings("bdvehiculos").ConnectionString

        'If nombreBaseDatos = "" Then Exit Sub


        'strConexion = "server=" & NomServer & ";" &
        '                "uid=mvillajos;pwd=marian2" &
        '                "database=" & nombreBaseDatos

        Try
            dbconnection = New MySqlConnection(strConexion)
            dbconnection.Open()

        Catch e As MySqlException
            MessageBox.Show("Error al crear la conexión:" & vbCrLf & e.Message)
        End Try


    End Sub

    Friend Sub BDClose(ByRef dbconnection As MySqlConnection)

        If dbconnection.State = ConnectionState.Open Then dbconnection.Close()
        dbconnection = Nothing

    End Sub

    Friend Sub setColHeader(ByRef grd As DataGridView, ByVal numCol As Integer,
        ByVal titulo As String, ByVal ancho As Integer, Optional ByVal Ocultar As Boolean = False)

        grd.Columns(numCol).HeaderText = titulo
        grd.Columns(numCol).Name = titulo
        If Ocultar Then
            grd.Columns(numCol).Visible = False
        Else
            grd.Columns(numCol).Width = ancho
            grd.Columns(numCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            grd.Columns(numCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

    End Sub

    Friend Sub setRowHeader(ByRef grd As DataGridView, ByVal numRow As Integer,
        ByVal titulo As String)

        grd.Rows(numRow).HeaderCell.Value = titulo
        grd.Rows(numRow).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        grd.Columns(numRow).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Public Sub SetGrdReadOnly(ByRef grd As DataGridView)
        grd.AllowUserToAddRows = False
        grd.AllowUserToDeleteRows = False
        grd.ReadOnly = True

    End Sub


    Friend Sub cargarCombo(ByRef combo As ComboBox, ByVal strsql As String,
   ByVal DisplayWhat As String, ByVal ValueWhat As String _
   , ByRef mibd As MySqlConnection)
        Dim dbDataset As DataSet
        Dim dbDataAdapter As MySqlDataAdapter

        dbDataset = New DataSet()
        dbDataAdapter = New MySqlDataAdapter(strsql, mibd)
        Try
            dbDataAdapter.Fill(dbDataset)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        With combo
            .DataSource = dbDataset.Tables(0)
            .DisplayMember = DisplayWhat
            .ValueMember = ValueWhat
        End With

        combo.SelectedIndex = -1

    End Sub


    Friend Sub CargarDataSet(ByRef bbdd As MySqlConnection,
             ByVal strsql As String, ByRef LocalDataSet As Data.DataSet,
             Optional ByVal nomTabla As String = "")

        Dim LocalDataAdapter As MySqlDataAdapter

        LocalDataAdapter = New MySqlDataAdapter(strsql, bbdd)
        Try
            If nomTabla <> "" Then
                LocalDataAdapter.Fill(LocalDataSet, nomTabla)
            Else
                LocalDataAdapter.Fill(LocalDataSet)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub


    Public Function FechaANSI_SQL(ByVal mifecha As String) As String
        Dim dtFecha As Date

        If Not IsDate(mifecha) And mifecha <> "" Then
            FechaANSI_SQL = "19000101"
        Else
            dtFecha = CDate(mifecha)
            FechaANSI_SQL = Year(mifecha) & Format(Month(mifecha), "00") & Format(Microsoft.VisualBasic.DateAndTime.Day(mifecha), "00")
        End If

    End Function


    Public Function LastDayMonth(ByVal Año As Integer, ByVal Mes As Integer) As Date
        Dim fecha As Date

        If Mes = 12 Then
            fecha = "01/01/" & (Año + 1)
        Else
            fecha = "01/" & (Mes + 1) & "/" & Año
        End If
        fecha = DateAdd(DateInterval.Day, -1, fecha)

        LastDayMonth = fecha

    End Function



    Public Function ValNulo(ByVal objValue As Object, ByVal tipoValor As String) As Object


        If Not IsDBNull(objValue) Then

            If UCase(tipoValor) = "TEXT" Then
                ValNulo = Trim(CStr(objValue))
            ElseIf UCase(tipoValor) = "NUM" Then
                ValNulo = Math.Round(objValue, 2)
            Else
                ValNulo = ""
            End If

        Else

            If UCase(tipoValor) = "TEXT" Then
                ValNulo = ""
            ElseIf UCase(tipoValor) = "NUM" Then
                ValNulo = 0
            Else
                ValNulo = ""
            End If

        End If


    End Function


    Public Function IsStrNum(ByVal paramStr As String) As Boolean
        Dim blnResul As Boolean

        blnResul = (paramStr <> "" And IsNumeric(paramStr))

        IsStrNum = blnResul

    End Function


End Module
