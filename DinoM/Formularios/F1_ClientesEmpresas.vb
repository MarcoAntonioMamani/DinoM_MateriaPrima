
Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports Modelo.MGlobal

Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid

Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.ToolTips
Imports DevComponents.DotNetBar.Controls
Imports Modelo

Public Class F1_ClientesEmpresas

    Dim _Inter As Integer = 0
#Region "Variables Locales"
#Region "MApas"
    Dim _Punto As Integer
    Dim _ListPuntos As List(Of PointLatLng)
    Dim _Overlay As GMapOverlay
    Dim _latitud As Double = 0
    Dim _longitud As Double = 0
#End Region
    Public bandera As Boolean = False
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim RutaTemporal As String = "C:\Temporal"
    Dim Modificado As Boolean = False
    Dim nameImg As String = "Default.jpg"
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public _Tipo As Integer
    Dim NumiVendedor As Integer
#End Region
#Region "Metodos Privados"

    Private Sub _prIniciarTodo()

        Me.Text = "CLIENTES"
        _prInicarMapa()

        _prMaxLength()

        _prCargarComboLibreria(cbDepartamento, 2, 3)
        _prCargarComboLibreria(cbCiudad, 2, 4)
        _prCargarComboLibreria(cbActividadComercial, 2, 5)
        _prCargarComboLibreria(cbCondicionesEntrega, 2, 6)
        _prCargarComboLibreria(cbTipoVenta, 2, 7)
        _prAsignarPermisos()
        _PMIniciarTodo()


        Dim blah As New Bitmap(New Bitmap(My.Resources.man_18), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico


    End Sub
    Private Sub P_IniciarMap()
        Gmc_Cliente.DragButton = MouseButtons.Left
        Gmc_Cliente.CanDragMap = True
        Gmc_Cliente.MapProvider = GMapProviders.GoogleMap
        If (_latitud <> 0 And _longitud <> 0) Then

            Gmc_Cliente.Position = New PointLatLng(_latitud, _longitud)
        Else

            _Overlay.Markers.Clear()
            Gmc_Cliente.Position = New PointLatLng(-17.3931784, -66.1738852)
        End If

        Gmc_Cliente.MinZoom = 0
        Gmc_Cliente.MaxZoom = 24
        Gmc_Cliente.Zoom = 15.5
        Gmc_Cliente.AutoScroll = True

        GMapProvider.Language = LanguageType.Spanish
    End Sub
    Public Sub _prInicarMapa()
        _Punto = 0
        '_ListPuntos = New List(Of PointLatLng)
        _Overlay = New GMapOverlay("points")
        Gmc_Cliente.Overlays.Add(_Overlay)
        P_IniciarMap()
    End Sub

    Public Sub _prStyleJanus()
        GroupPanelBuscador.Style.BackColor = Color.FromArgb(13, 71, 161)
        GroupPanelBuscador.Style.BackColor2 = Color.FromArgb(13, 71, 161)
        GroupPanelBuscador.Style.TextColor = Color.White
        JGrM_Buscador.RootTable.HeaderFormatStyle.FontBold = TriState.True
    End Sub

    Public Sub _prMaxLength()

        tbDireccion.MaxLength = 200
        tbTelefono01.MaxLength = 50
        tbEmail.MaxLength = 50

        tbNit.MaxLength = 20
    End Sub

    Private Sub _prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String, cod2 As String)
        Dim dt As New DataTable
        dt = L_prLibreriaClienteLGeneral(cod1, cod2)
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 70
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 200
            .DropDownList.Columns("ycdes3").Caption = "DESCRIPCION"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        If (dt.Rows.Count > 0) Then
            mCombo.SelectedIndex = 0
        End If
    End Sub
    Private Sub _prCargarComboLibreriaZona(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_prLibreriaClienteLGeneralZonas()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 500
            .DropDownList.Columns("ycdes3").Caption = "DESCRIPCION"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
    End Sub



    Private Sub _prAsignarPermisos()

        Dim dtRolUsu As DataTable = L_prRolDetalleGeneral(gi_userRol, _nameButton)

        Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        If add = False Then
            btnNuevo.Visible = False
        End If
        If modif = False Then
            btnModificar.Visible = False
        End If
        If del = False Then
            btnEliminar.Visible = False
        End If
    End Sub
    Private Sub _prCrearCarpetaTemporal()

        If System.IO.Directory.Exists(RutaTemporal) = False Then
            System.IO.Directory.CreateDirectory(RutaTemporal)
        Else
            Try
                My.Computer.FileSystem.DeleteDirectory(RutaTemporal, FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory(RutaTemporal)
                'My.Computer.FileSystem.DeleteDirectory(RutaTemporal, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                'System.IO.Directory.CreateDirectory(RutaTemporal)

            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Sub _prCrearCarpetaImagenes()
        Dim rutaDestino As String = RutaGlobal + "\Imagenes\Imagenes ClienteDino\"

        If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes ClienteDino\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Imagenes") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes")
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes ClienteDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes ClienteDino")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes ClienteDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes ClienteDino")

                End If
            End If
        End If
    End Sub

    Private Sub _prCrearCarpetaReportes()
        Dim rutaDestino As String = RutaGlobal + "\Reporte\Reporte ClienteDino\"

        If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte ClienteDino\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Reporte") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte")
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte ClienteDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte ClienteDino")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte ClienteDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte ClienteDino")

                End If
            End If
        End If
    End Sub

#End Region
#Region "METODOS SOBRECARGADOS"

    Public Overrides Sub _PMOHabilitar()
        tbCodigoOriginal.ReadOnly = False
        tbNombreEmpresa.ReadOnly = False
        tbDireccion.ReadOnly = False
        cbDepartamento.ReadOnly = False
        cbCiudad.ReadOnly = False
        tbTelefono01.ReadOnly = False
        tbEmail.ReadOnly = False
        tbPaginaWeb.ReadOnly = False
        tbNit.ReadOnly = False
        cbActividadComercial.ReadOnly = False
        tbHorarioAtencion.ReadOnly = False
        tbNombreContacto01.ReadOnly = False
        tbTelefono02.ReadOnly = False
        tbNombreContacto02.ReadOnly = False
        tbTelefonoCelular.ReadOnly = False
        cbCondicionesEntrega.ReadOnly = False
        tbTiempoCredito.IsInputReadOnly = False
        tbLimiteCredito.IsInputReadOnly = False
        tbItemsHabilitados.IsInputReadOnly = False
        cbTipoVenta.ReadOnly = False





        _prCrearCarpetaImagenes()
        _prCrearCarpetaTemporal()


        tbNombreEmpresa.Focus()
        ''  SuperTabItem1.Visible =True 
    End Sub

    Public Overrides Sub _PMOInhabilitar()

        tbNombreEmpresa.ReadOnly = True
        tbDireccion.ReadOnly = True
        cbDepartamento.ReadOnly = True
        cbCiudad.ReadOnly = True
        tbTelefono01.ReadOnly = True
        tbEmail.ReadOnly = True
        tbPaginaWeb.ReadOnly = True
        tbNit.ReadOnly = True
        cbActividadComercial.ReadOnly = True
        tbHorarioAtencion.ReadOnly = True
        tbNombreContacto01.ReadOnly = True
        tbTelefono02.ReadOnly = True
        tbNombreContacto02.ReadOnly = True
        tbTelefonoCelular.ReadOnly = True
        cbCondicionesEntrega.ReadOnly = True
        tbTiempoCredito.IsInputReadOnly = True
        tbLimiteCredito.IsInputReadOnly = True
        tbItemsHabilitados.IsInputReadOnly = True
        cbTipoVenta.ReadOnly = True

        _prStyleJanus()
        JGrM_Buscador.Focus()

        ' SuperTabItem1.Visible = False
    End Sub

    Public Overrides Sub _PMOLimpiar()
        tbCodigoOriginal.Clear()
        tbNombreEmpresa.Clear()
        tbDireccion.Clear()
        'cbDepartamento.ReadOnly = True
        'cbCiudad.ReadOnly = True
        SeleccionarPrimerItem(cbDepartamento)
        SeleccionarPrimerItem(cbCiudad)
        tbTelefono01.Clear()
        tbEmail.Clear()
        tbPaginaWeb.Clear()
        tbNit.Clear()
        'cbActividadComercial.ReadOnly = True
        SeleccionarPrimerItem(cbActividadComercial)
        tbHorarioAtencion.Clear()
        tbNombreContacto01.Clear()
        tbTelefono02.Clear()
        tbNombreContacto02.Clear()
        tbTelefonoCelular.Clear()
        SeleccionarPrimerItem(cbCondicionesEntrega)
        ''cbCondicionesEntrega.ReadOnly = True
        tbTiempoCredito.Value = 0
        tbLimiteCredito.Value = 0
        tbItemsHabilitados.Value = 0
        SeleccionarPrimerItem(cbTipoVenta)
        'cbTipoVenta.ReadOnly = True



        _Overlay.Markers.Clear()
        _latitud = 0
        _longitud = 0

        NumiVendedor = 0


    End Sub
    Public Sub SeleccionarPrimerItem(Mcombo As EditControls.MultiColumnCombo)
        If (CType(Mcombo.DataSource, DataTable).Rows.Count > 0) Then
            Mcombo.SelectedIndex = 0
        End If
    End Sub

    Public Overrides Sub _PMOLimpiarErrores()
        MEP.Clear()
        tbNombreEmpresa.BackColor = Color.White
        tbDireccion.BackColor = Color.White
    End Sub

    Public Overrides Function _PMOGrabarRegistro() As Boolean

        'ByRef Id As String, NombreEmpresa As String, Direccion As String, Departamento As Integer, Ciudad As Integer, Telefono01 As String, Email As String, PaginaWeb As String, Nit As String, ActividadComercial As Integer, HorarioAtencion As String, NombreContacto01 As String, Telefono02 As String, NombreContacto02 As String, TelefonoCelular As String, CondicionesEntrega As Integer, TiempoCredito As Integer, ItemsHabilitado As Integer, LimiteCredito As Double, TipoVenta As Integer, Latitud As Double, Longitud As Double
        Dim id As String = ""
        Dim res As Boolean = L_fnGrabarCLienteEmpresa(id, tbNombreEmpresa.Text, tbDireccion.Text, cbDepartamento.Value, cbCiudad.Value, tbTelefono01.Text, tbEmail.Text, tbPaginaWeb.Text, tbNit.Text, cbActividadComercial.Value, tbHorarioAtencion.Text, tbNombreContacto01.Text, tbTelefono02.Text, tbNombreContacto02.Text, tbTelefonoCelular.Text, cbCondicionesEntrega.Value, tbTiempoCredito.Value, tbItemsHabilitados.Value, tbLimiteCredito.Value, cbTipoVenta.Value, _latitud, _longitud)
        tbCodigoOriginal.Text = id


        If res Then


            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Cliente ".ToUpper + tbCodigoOriginal.Text + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            tbNombreEmpresa.Focus()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El producto no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
        If prof_venta = True Then
            codcli = tbCodigoOriginal.Text
            nomcli = tbNombreEmpresa.Text

            bandera = True
            prof_venta = False
            Me.Close()
            Return res = False
        End If
        Return res

    End Function

    Public Overrides Function _PMOModificarRegistro() As Boolean



        Dim res As Boolean = L_fnModificarCLienteEmpresa(tbCodigoOriginal.Text, tbNombreEmpresa.Text, tbDireccion.Text, cbDepartamento.Value, cbCiudad.Value, tbTelefono01.Text, tbEmail.Text, tbPaginaWeb.Text, tbNit.Text, cbActividadComercial.Value, tbHorarioAtencion.Text, tbNombreContacto01.Text, tbTelefono02.Text, tbNombreContacto02.Text, tbTelefonoCelular.Text, cbCondicionesEntrega.Value, tbTiempoCredito.Value, tbItemsHabilitados.Value, tbLimiteCredito.Value, cbTipoVenta.Value, _latitud, _longitud)
        If res Then


            nameImg = "Default.jpg"

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Cliente ".ToUpper + tbCodigoOriginal.Text + " modificado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter)
            _PMInhabilitar()
            _PMPrimerRegistro()
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "EL Cliente no pudo ser modificado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
        Return res
    End Function



    Public Function _fnActionNuevo() As Boolean
        Return tbCodigoOriginal.Text = String.Empty And tbDireccion.ReadOnly = False
    End Function

    Public Overrides Sub _PMOEliminarRegistro()

        Dim ef = New Efecto


        ef.tipo = 2
        ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
        ef.Header = "mensaje principal".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_fnEliminarClientes(tbCodigoOriginal.Text, mensajeError)
            If res Then


                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código de Cliente ".ToUpper + tbCodigoOriginal.Text + " eliminado con Exito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter)

                _PMFiltrar()
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, mensajeError, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            End If
        End If


    End Sub
    Public Overrides Function _PMOValidarCampos() As Boolean
        Dim _ok As Boolean = True
        MEP.Clear()

        If tbNombreEmpresa.Text = String.Empty Then
            tbNombreEmpresa.BackColor = Color.Red
            MEP.SetError(tbNombreEmpresa, "ingrese el nombre del Usuario!".ToUpper)
            _ok = False
        Else
            tbNombreEmpresa.BackColor = Color.White
            MEP.SetError(tbNombreEmpresa, "")
        End If
        If (cbDepartamento.SelectedIndex < 0) Then

            If (CType(cbDepartamento.DataSource, DataTable).Rows.Count > 0) Then
                cbDepartamento.SelectedIndex = 0
            End If
        End If
        If (cbCiudad.SelectedIndex < 0) Then

            If (CType(cbCiudad.DataSource, DataTable).Rows.Count > 0) Then
                cbCiudad.SelectedIndex = 0
            End If
        End If
        If (cbActividadComercial.SelectedIndex < 0) Then

            If (CType(cbActividadComercial.DataSource, DataTable).Rows.Count > 0) Then
                cbActividadComercial.SelectedIndex = 0
            End If
        End If

        If (cbCondicionesEntrega.SelectedIndex < 0) Then

            If (CType(cbCondicionesEntrega.DataSource, DataTable).Rows.Count > 0) Then
                cbCondicionesEntrega.SelectedIndex = 0
            End If
        End If
        If (cbTipoVenta.SelectedIndex < 0) Then

            If (CType(cbTipoVenta.DataSource, DataTable).Rows.Count > 0) Then
                cbTipoVenta.SelectedIndex = 0
            End If
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function

    Public Overrides Function _PMOGetTablaBuscador() As DataTable
        Dim dtBuscador As DataTable = L_fnGeneralClientesEmpresa()
        Return dtBuscador
    End Function

    Public Overrides Function _PMOGetListEstructuraBuscador() As List(Of Modelo.Celda)
        Dim listEstCeldas As New List(Of Modelo.Celda)
        'a.id, a.NombreEmpresa, a.Direccion, a.Departamento, a.Ciudad, a.Telefono01, a.Email,
        'a.PaginaWeb, a.Nit, a.ActividadComercial, a.HorariosAtencion, a.NombreContacto01, a.Telefono02, a.NombreContacto02,
        'a.TelefonoCelular, a.CondicionesEntrega, a.TiempoCredito, a.ItemsHabilitados, a.LimiteCredito, a.TipoVenta,
        'a.Latitud, a.Longitud 

        listEstCeldas.Add(New Modelo.Celda("id", True, "Código".ToUpper, 80))

        listEstCeldas.Add(New Modelo.Celda("NombreEmpresa", True, "Empresa".ToUpper, 200))
        listEstCeldas.Add(New Modelo.Celda("Direccion", True, "Direccion".ToUpper, 350))
        listEstCeldas.Add(New Modelo.Celda("Departamento", False))
        listEstCeldas.Add(New Modelo.Celda("Ciudad", False))
        listEstCeldas.Add(New Modelo.Celda("Telefono01", True, "Telefono".ToUpper, 150))

        listEstCeldas.Add(New Modelo.Celda("Email", False))
        listEstCeldas.Add(New Modelo.Celda("PaginaWeb", False))
        listEstCeldas.Add(New Modelo.Celda("Nit", False))
        listEstCeldas.Add(New Modelo.Celda("ActividadComercial", False))
        listEstCeldas.Add(New Modelo.Celda("HorariosAtencion", False))
        listEstCeldas.Add(New Modelo.Celda("NombreContacto01", False))
        listEstCeldas.Add(New Modelo.Celda("Telefono02", False))
        listEstCeldas.Add(New Modelo.Celda("NombreContacto02", False))


        listEstCeldas.Add(New Modelo.Celda("TelefonoCelular", False))
        listEstCeldas.Add(New Modelo.Celda("CondicionesEntrega", False))
        listEstCeldas.Add(New Modelo.Celda("TiempoCredito", False))
        listEstCeldas.Add(New Modelo.Celda("ItemsHabilitados", False))
        listEstCeldas.Add(New Modelo.Celda("LimiteCredito", False))
        listEstCeldas.Add(New Modelo.Celda("TipoVenta", False))


        listEstCeldas.Add(New Modelo.Celda("Latitud", False))
        listEstCeldas.Add(New Modelo.Celda("Longitud", False))

        Return listEstCeldas
    End Function

    Public Overrides Sub _PMOMostrarRegistro(_N As Integer)
        JGrM_Buscador.Row = _MPos
        'a.id, a.NombreEmpresa, a.Direccion, a.Departamento, a.Ciudad, a.Telefono01, a.Email,
        'a.PaginaWeb, a.Nit, a.ActividadComercial, a.HorariosAtencion, a.NombreContacto01, a.Telefono02, a.NombreContacto02,
        'a.TelefonoCelular, a.CondicionesEntrega, a.TiempoCredito, a.ItemsHabilitados, a.LimiteCredito, a.TipoVenta,
        'a.Latitud, a.Longitud 
        Dim dt As DataTable = CType(JGrM_Buscador.DataSource, DataTable)
        Try
            tbCodigoOriginal.Text = JGrM_Buscador.GetValue("Id").ToString
        Catch ex As Exception
            Exit Sub
        End Try
        With JGrM_Buscador
            tbCodigoOriginal.Text = .GetValue("Id").ToString
            tbNombreEmpresa.Text = .GetValue("NombreEmpresa").ToString
            tbDireccion.Text = .GetValue("Direccion").ToString
            cbDepartamento.Value = .GetValue("Departamento")
            cbCiudad.Value = .GetValue("Ciudad")
            tbTelefono01.Text = .GetValue("Telefono01").ToString
            tbEmail.Text = .GetValue("Email").ToString
            tbPaginaWeb.Text = .GetValue("PaginaWeb").ToString
            tbNit.Text = .GetValue("Nit").ToString
            cbActividadComercial.Value = .GetValue("ActividadComercial")
            tbHorarioAtencion.Text = .GetValue("HorariosAtencion").ToString
            tbNombreContacto01.Text = .GetValue("NombreContacto01").ToString
            tbTelefono02.Text = .GetValue("Telefono02").ToString
            tbNombreContacto02.Text = .GetValue("NombreContacto02").ToString
            tbTelefonoCelular.Text = .GetValue("TelefonoCelular").ToString
            cbCondicionesEntrega.Value = .GetValue("CondicionesEntrega")
            tbTiempoCredito.Value = .GetValue("TiempoCredito")
            tbItemsHabilitados.Value = .GetValue("ItemsHabilitados")
            tbLimiteCredito.Value = .GetValue("LimiteCredito")
            cbTipoVenta.Value = .GetValue("TipoVenta")
            _latitud = .GetValue("Latitud")
            _longitud = .GetValue("Longitud")



        End With

        _dibujarUbicacion(JGrM_Buscador.GetValue("NombreEmpresa").ToString, JGrM_Buscador.GetValue("Id").ToString)
        LblPaginacion.Text = Str(_MPos + 1) + "/" + JGrM_Buscador.RowCount.ToString

    End Sub

    Public Sub _dibujarUbicacion(_nombre As String, _ci As String)
        If (_latitud <> 0 And _longitud <> 0) Then
            Dim plg As PointLatLng = New PointLatLng(_latitud, _longitud)
            _Overlay.Markers.Clear()
            P_AgregarPunto(plg, _nombre, _ci)
        Else


            _Overlay.Markers.Clear()
            Gmc_Cliente.Position = New PointLatLng(-17.3931784, -66.1738852)
        End If
    End Sub
    Private Sub P_AgregarPunto(pointLatLng As PointLatLng, _nombre As String, _ci As String)
        If (Not IsNothing(_Overlay)) Then
            'añadir puntos
            'Dim markersOverlay As New GMapOverlay("markers")
            Dim marker As New GMarkerGoogle(pointLatLng, My.Resources.markerIcono)
            'añadir tooltip
            Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
            marker.ToolTip = New GMapBaloonToolTip(marker)
            marker.ToolTipMode = mode
            Dim ToolTipBackColor As New SolidBrush(Color.Blue)
            marker.ToolTip.Fill = ToolTipBackColor
            marker.ToolTip.Foreground = Brushes.White
            'If (Not _nombre.ToString = String.Empty) Then
            '    marker.ToolTipText = "CLIENTE: " + _nombre & vbNewLine & " CI:" + _ci
            'End If
            _Overlay.Markers.Add(marker)
            'mapa.Overlays.Add(markersOverlay)
            Gmc_Cliente.Position = pointLatLng
        End If
    End Sub
    Public Overrides Sub _PMOHabilitarFocus()

        'With MHighlighterFocus
        '    .SetHighlightOnFocus(tbCodigo, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(tbCodProd, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(tbStockMinimo, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(tbCodBarra, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)

        '    .SetHighlightOnFocus(tbDescPro, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(tbDescCort, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(cbgrupo1, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(cbgrupo2, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(cbgrupo3, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(cbgrupo4, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(cbUMed, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(swEstado, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(cbUniVenta, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(cbUnidMaxima, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        '    .SetHighlightOnFocus(tbConversion, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)


        'End With
    End Sub

#End Region



    Private Sub F1_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()

    End Sub

    Private Sub Gmc_Cliente_DoubleClick(sender As Object, e As EventArgs) Handles Gmc_Cliente.DoubleClick
        If (btnGrabar.Enabled = True) Then


            _Overlay.Markers.Clear()

            Dim gm As GMapControl = CType(sender, GMapControl)
            Dim hj As MouseEventArgs = CType(e, MouseEventArgs)
            Dim plg As PointLatLng = gm.FromLocalToLatLng(hj.X, hj.Y)
            _latitud = plg.Lat
            _longitud = plg.Lng
            ''  MsgBox("latitud:" + Str(plg.Lat) + "   Logitud:" + Str(plg.Lng))

            P_AgregarPunto(plg, "", "")

            '' _ListPuntos.Add(plg)
            'Btnx_ChekGetPoint.Visible = False
        End If
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        If (Gmc_Cliente.Zoom >= Gmc_Cliente.MinZoom) Then
            Gmc_Cliente.Zoom = Gmc_Cliente.Zoom - 1
        End If
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        If (Gmc_Cliente.Zoom <= Gmc_Cliente.MaxZoom) Then
            Gmc_Cliente.Zoom = Gmc_Cliente.Zoom + 1
        End If
    End Sub







    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If btnGrabar.Enabled = True Then
            _PMInhabilitar()
            _PMPrimerRegistro()

        Else

            If prof_venta = True Then


                bandera = False
                prof_venta = False
                Me.Close()
            Else
                '  Public _modulo As SideNavItem
                _modulo.Select()
                Me.Close()
            End If

        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

    End Sub

    Private Sub JGrM_Buscador_KeyDown(sender As Object, e As KeyEventArgs) Handles JGrM_Buscador.KeyDown
        If e.KeyData = Keys.Enter Then
            If (MPanelSup.Visible = True) Then
                JGrM_Buscador.GroupByBoxVisible = True
                MPanelSup.Visible = False
                JGrM_Buscador.UseGroupRowSelector = True

            Else
                JGrM_Buscador.GroupByBoxVisible = False
                JGrM_Buscador.UseGroupRowSelector = True
                MPanelSup.Visible = True
            End If
        End If
    End Sub
    Function _fnAccesible() As Boolean
        Return tbNombreEmpresa.ReadOnly = False

    End Function


    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        P_GenerarReporte()
    End Sub
    Private Sub P_GenerarReporte()
        'Dim dt As DataTable = L_fnReportecliente()

        'If Not IsNothing(P_Global.Visualizador) Then
        '    P_Global.Visualizador.Close()
        'End If

        'P_Global.Visualizador = New Visualizador

        'Dim objrep As New R_Clientes
        ''' GenerarNro(_dt)
        '''objrep.SetDataSource(Dt1Kardex)
        'objrep.SetDataSource(dt)

        'P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
        'P_Global.Visualizador.Show() 'Comentar
        'P_Global.Visualizador.BringToFront() 'Comentar



    End Sub

    Private Sub tbTelf2_TextChanged(sender As Object, e As EventArgs) Handles tbEmail.TextChanged

    End Sub

    Private Sub cbDepartamento_ValueChanged(sender As Object, e As EventArgs) Handles cbDepartamento.ValueChanged
        If cbDepartamento.SelectedIndex < 0 And cbDepartamento.Text <> String.Empty Then
            btnDepartamento.Visible = True
        Else
            btnDepartamento.Visible = False
        End If
    End Sub

    Private Sub cbCiudad_ValueChanged(sender As Object, e As EventArgs) Handles cbCiudad.ValueChanged
        If cbCiudad.SelectedIndex < 0 And cbCiudad.Text <> String.Empty Then
            btnCiudad.Visible = True
        Else
            btnCiudad.Visible = False
        End If
    End Sub

    Private Sub cbActividadComercial_ValueChanged(sender As Object, e As EventArgs) Handles cbActividadComercial.ValueChanged
        If cbActividadComercial.SelectedIndex < 0 And cbActividadComercial.Text <> String.Empty Then
            btnActividadComercial.Visible = True
        Else
            btnActividadComercial.Visible = False
        End If
    End Sub

    Private Sub cbCondicionesEntrega_ValueChanged(sender As Object, e As EventArgs) Handles cbCondicionesEntrega.ValueChanged
        If cbCondicionesEntrega.SelectedIndex < 0 And cbCondicionesEntrega.Text <> String.Empty Then
            btnCondicionesEntrega.Visible = True
        Else
            btnCondicionesEntrega.Visible = False
        End If
    End Sub

    Private Sub btnDepartamento_Click(sender As Object, e As EventArgs) Handles btnDepartamento.Click
        Dim numi As String = ""
        If L_prLibreriaGrabar(numi, "2", "3", cbDepartamento.Text, "") Then
            _prCargarComboLibreria(cbDepartamento, "2", "3")
            cbDepartamento.SelectedIndex = CType(cbDepartamento.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        Dim numi As String = ""
        If L_prLibreriaGrabar(numi, "2", "4", cbCiudad.Text, "") Then
            _prCargarComboLibreria(cbCiudad, "2", "4")
            cbCiudad.SelectedIndex = CType(cbCiudad.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btnActividadComercial_Click(sender As Object, e As EventArgs) Handles btnActividadComercial.Click
        Dim numi As String = ""
        If L_prLibreriaGrabar(numi, "2", "5", cbActividadComercial.Text, "") Then
            _prCargarComboLibreria(cbActividadComercial, "2", "5")
            cbActividadComercial.SelectedIndex = CType(cbActividadComercial.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btnCondicionesEntrega_Click(sender As Object, e As EventArgs) Handles btnCondicionesEntrega.Click
        Dim numi As String = ""
        If L_prLibreriaGrabar(numi, "2", "6", cbCondicionesEntrega.Text, "") Then
            _prCargarComboLibreria(cbCondicionesEntrega, "2", "6")
            cbCondicionesEntrega.SelectedIndex = CType(cbCondicionesEntrega.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Inter = _Inter + 1
        If _Inter = 1 Then
            Me.WindowState = FormWindowState.Maximized


        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
    End Sub
End Class