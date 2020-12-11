
Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX

Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid

Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.ToolTips
Imports DevComponents.DotNetBar.Controls
Public Class F1_Equipos02

    Dim _Inter As Integer = 0
#Region "Variables Locales"
#Region "MApas"
    Dim _Punto As Integer
    Dim _ListPuntos As List(Of PointLatLng)
    Dim _Overlay As GMapOverlay
    Dim _latitud As Double = 0
    Dim _longitud As Double = 0
#End Region
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim RutaTemporal As String = "C:\Temporal"
    Dim Modificado As Boolean = False
    Dim nameImg As String = "Default.jpg"
    Public _nameButton As String

    Dim gs_RutaImg As String = ""
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public _Tipo As Integer
    Dim TablaImagenes As DataTable
    Dim NumiVendedor As Integer
#End Region
#Region "Metodos Privados"

    Private Sub _prIniciarTodo()

        Me.Text = "EQUIPOS"


        _prMaxLength()

        _prCargarComboLibreria(cbGrupo, 22, 1)
        _prCargarComboLibreria(cbParametroTecnico, 22, 2)

        _prAsignarPermisos()
        _PMIniciarTodo()


        Dim blah As New Bitmap(New Bitmap(My.Resources.man_18), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico


    End Sub

    Sub _prEliminarContenidoImage()
        Try
            My.Computer.FileSystem.DeleteDirectory(gs_RutaImg, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub _prStyleJanus()
        GroupPanelBuscador.Style.BackColor = Color.FromArgb(13, 71, 161)
        GroupPanelBuscador.Style.BackColor2 = Color.FromArgb(13, 71, 161)
        GroupPanelBuscador.Style.TextColor = Color.White
        JGrM_Buscador.RootTable.HeaderFormatStyle.FontBold = TriState.True
    End Sub
    Private Sub _prCrearCarpetaImagenes(carpetaFinal As String)
        Dim rutaDestino As String = RutaGlobal + "\Imagenes\Imagenes Equipos\" + carpetaFinal + "\"

        If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes Equipos\" + carpetaFinal) = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Imagenes") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes")
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes Equipos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes Equipos")
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes Equipos\" + carpetaFinal + "\")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes Equipos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes Equipos")
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes Equipos\" + carpetaFinal + "\")
                Else
                    If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes Equipos\" + carpetaFinal) = False Then
                        System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes Equipos\" + carpetaFinal + "\")
                    End If

                End If
            End If
        End If
    End Sub


    Public Sub _prMaxLength()

        tbAtributo.MaxLength = 200
        tbdescripcion.MaxLength = 350

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
        cbGrupo.ComboStyle = ComboStyle.Combo
        cbParametroTecnico.ReadOnly = False
        tbNota.ReadOnly = False



        PanelDetalle.Visible = True
        PanelParametrosTecnicos.Visible = True
        tbNombre.ReadOnly = False

        btnDelete.Visible = True
        btnImagen.Visible = True
        _prCrearCarpetaImagenes()
        _prCrearCarpetaTemporal()

        grParametroTecnico.ContextMenuStrip = MenuEliminarParametros
        grDetalle.ContextMenuStrip = MenuEliminarDetalle


        cbGrupo.Focus()
        ''  SuperTabItem1.Visible =True 
    End Sub


    Public Overrides Sub _PMOInhabilitar()
        btnDelete.Visible = False
        btnImagen.Visible = False
        PanelParametrosTecnicos.Visible = False

        cbParametroTecnico.ReadOnly = True
        tbNota.ReadOnly = True
        tbNombre.ReadOnly = True
        cbGrupo.ComboStyle = ComboStyle.DropDownList
        PanelDetalle.Visible = False

        _prStyleJanus()
        JGrM_Buscador.Focus()
        grDetalle.ContextMenuStrip = Nothing
        grParametroTecnico.ContextMenuStrip = Nothing

        ' SuperTabItem1.Visible = False
    End Sub

    Public Overrides Sub _PMOLimpiar()
        tbCodigoOriginal.Clear()
        tbNota.Clear()
        tbNombre.Clear()

        SeleccionarPrimerItem(cbGrupo)
        SeleccionarPrimerItem(cbParametroTecnico)
        tbAtributo.Clear()
        tbdescripcion.Clear()

        TablaImagenes = L_fnDetalleImagenesEquipos(-1)
        _prCargarImagen()
        _prEliminarContenidoImage()
        _prCargarDetalle(-1)
        _prCargarDetalleParametrosTecnicos(-1)

        _latitud = 0
        _longitud = 0

        NumiVendedor = 0
        tbNombre.Focus()

        Dim dt As DataTable = L_fnGeneralEquipos()

        If (dt.Rows.Count > 0) Then
            Dim Id As Integer = dt.Rows(dt.Rows.Count - 1).Item("Id")
            _prCargarDetalleParametrosTecnicos(Str(Id))
            cbGrupo.Value = dt.Rows(dt.Rows.Count - 1).Item("Grupo")
            FiltrarParametros()
            _prCargarDetalle(Str(Id))
            FiltrarParametros()

        End If
    End Sub
    Public Sub _prCargarImagen()
        PanelListImagenes.Controls.Clear()

        pbImgProdu.Image = Nothing

        Dim i As Integer = 0
        For Each fila As DataRow In TablaImagenes.Rows
            Dim elemImg As UCLavadero = New UCLavadero
            Dim rutImg = fila.Item("lhima").ToString
            Dim estado As Integer = fila.Item("estado")

            If (estado = 0) Then
                elemImg.pbImg.SizeMode = PictureBoxSizeMode.StretchImage
                Dim bm As Bitmap = Nothing
                Dim by As Byte() = fila.Item("img")
                Dim ms As New MemoryStream(by)
                bm = New Bitmap(ms)


                elemImg.pbImg.Image = bm

                pbImgProdu.SizeMode = PictureBoxSizeMode.StretchImage
                pbImgProdu.Image = bm
                elemImg.pbImg.Tag = i
                elemImg.Dock = DockStyle.Top
                pbImgProdu.Tag = i
                AddHandler elemImg.pbImg.MouseEnter, AddressOf pbImg_MouseEnter

                PanelListImagenes.Controls.Add(elemImg)
                ms.Dispose()

            Else
                If (estado = 1) Then
                    Dim ruta As String = RutaGlobal + "\Imagenes\Imagenes Equipos\EquiposTodos" + rutImg
                    If (File.Exists(RutaGlobal + "\Imagenes\Imagenes Equipos\EquiposTodos" + rutImg)) Then
                        Dim bm As Bitmap = New Bitmap(RutaGlobal + "\Imagenes\Imagenes Equipos\EquiposTodos" + rutImg)
                        elemImg.pbImg.SizeMode = PictureBoxSizeMode.StretchImage
                        elemImg.pbImg.Image = bm
                        pbImgProdu.SizeMode = PictureBoxSizeMode.StretchImage
                        pbImgProdu.Image = bm
                        elemImg.pbImg.Tag = i
                        elemImg.Dock = DockStyle.Top
                        pbImgProdu.Tag = i
                        AddHandler elemImg.pbImg.MouseEnter, AddressOf pbImg_MouseEnter

                        PanelListImagenes.Controls.Add(elemImg)
                    End If

                End If
            End If




            i += 1
        Next

    End Sub

    Private Sub pbImg_MouseEnter(sender As Object, e As EventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)
        pbImgProdu.Image = pb.Image
        pbImgProdu.Tag = pb.Tag

    End Sub
    Public Sub SeleccionarPrimerItem(Mcombo As EditControls.MultiColumnCombo)
        If (CType(Mcombo.DataSource, DataTable).Rows.Count > 0) Then
            Mcombo.SelectedIndex = 0
        End If
    End Sub

    Public Overrides Sub _PMOLimpiarErrores()
        MEP.Clear()
        tbAtributo.BackColor = Color.White
        tbdescripcion.BackColor = Color.White
        tbNombre.BackColor = Color.White
    End Sub
    Public Sub _prGuardarImagenes(_ruta As String)
        PanelListImagenes.Controls.Clear()


        For i As Integer = 0 To TablaImagenes.Rows.Count - 1 Step 1
            Dim estado As Integer = TablaImagenes.Rows(i).Item("estado")
            If (estado = 0) Then

                Dim bm As Bitmap = Nothing
                Dim by As Byte() = TablaImagenes.Rows(i).Item("img")
                Dim ms As New MemoryStream(by)
                bm = New Bitmap(ms)
                Try
                    bm.Save(_ruta + TablaImagenes.Rows(i).Item("lhima"), System.Drawing.Imaging.ImageFormat.Jpeg)
                Catch ex As Exception

                End Try




            End If
            If (estado = -1) Then
                Try
                    Me.pbImgProdu.Image.Dispose()
                    Me.pbImgProdu.Image = Nothing
                    Application.DoEvents()
                    TablaImagenes.Rows(i).Item("img") = Nothing



                    If (File.Exists(_ruta + TablaImagenes.Rows(i).Item("lhima"))) Then
                        My.Computer.FileSystem.DeleteFile(_ruta + TablaImagenes.Rows(i).Item("lhima"))
                    End If

                Catch ex As Exception

                End Try
            End If
        Next
    End Sub
    Public Overrides Function _PMOGrabarRegistro() As Boolean

        ''(ByRef Id As String, Nombre As String, Grupo As Integer,
        'ParametrosTecnico As Integer, Notas As String, dtImagenes As DataTable, dtDetalle As DataTable)

        Dim res As Boolean = L_fnGrabarEquipo(tbCodigoOriginal.Text, tbNombre.Text, cbGrupo.Value, cbParametroTecnico.Value, tbNota.Text, TablaImagenes, CType(grDetalle.DataSource, DataTable), CType(grParametroTecnico.DataSource, DataTable))


        If res Then
            _prCrearCarpetaImagenes("EquiposTodos")
            _prGuardarImagenes(RutaGlobal + "\Imagenes\Imagenes Equipos\" + "EquiposTodos" + "\")

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Equipo ".ToUpper + tbCodigoOriginal.Text + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            tbNombre.Focus()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El Equipo no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
        Return res

    End Function

    Public Overrides Function _PMOModificarRegistro() As Boolean



        Dim res As Boolean = L_fnModificarEquipo(tbCodigoOriginal.Text, tbNombre.Text, cbGrupo.Value, cbParametroTecnico.Value, tbNota.Text, TablaImagenes, CType(grDetalle.DataSource, DataTable), CType(grParametroTecnico.DataSource, DataTable))
        If res Then


            nameImg = "Default.jpg"
            _prCrearCarpetaImagenes("EquiposTodos")
            _prGuardarImagenes(RutaGlobal + "\Imagenes\Imagenes Equipos\" + "EquiposTodos" + "\")
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Equipo ".ToUpper + tbCodigoOriginal.Text + " modificado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter)
            _PMInhabilitar()
            _PMPrimerRegistro()
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "EL Equipo no pudo ser modificado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
        Return res
    End Function



    Public Function _fnActionNuevo() As Boolean
        Return tbCodigoOriginal.Text = String.Empty And tbAtributo.ReadOnly = False
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
            Dim res As Boolean = L_fnEliminarEquipo(tbCodigoOriginal.Text, mensajeError)
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

        'If tbNombreEmpresa.Text = String.Empty Then
        '    tbNombreEmpresa.BackColor = Color.Red
        '    MEP.SetError(tbNombreEmpresa, "ingrese el nombre del Usuario!".ToUpper)
        '    _ok = False
        'Else
        '    tbNombreEmpresa.BackColor = Color.White
        '    MEP.SetError(tbNombreEmpresa, "")
        'End If
        'If (cbDepartamento.SelectedIndex < 0) Then

        '    If (CType(cbDepartamento.DataSource, DataTable).Rows.Count > 0) Then
        '        cbDepartamento.SelectedIndex = 0
        '    End If
        'End If

        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function

    Public Overrides Function _PMOGetTablaBuscador() As DataTable
        Dim dtBuscador As DataTable = L_fnGeneralEquipos()
        Return dtBuscador
    End Function

    Public Overrides Function _PMOGetListEstructuraBuscador() As List(Of Modelo.Celda)
        Dim listEstCeldas As New List(Of Modelo.Celda)
        'id,Nombre,Grupo,gr.ycdes3 as DescripcionGrupo,ParametrosTecnicos,
        'pr.ycdes3 as DescripcionParametros , Notas

        listEstCeldas.Add(New Modelo.Celda("id", True, "Código".ToUpper, 80))

        listEstCeldas.Add(New Modelo.Celda("Nombre", True, "Nombre".ToUpper, 400))
        listEstCeldas.Add(New Modelo.Celda("DescripcionGrupo", True, "Grupo".ToUpper, 150))
        listEstCeldas.Add(New Modelo.Celda("Grupo", False))
        listEstCeldas.Add(New Modelo.Celda("ParametrosTecnicos", False))
        listEstCeldas.Add(New Modelo.Celda("DescripcionParametros", True, "Parametros Tecnicos".ToUpper, 120))
        listEstCeldas.Add(New Modelo.Celda("Notas", True, "Notas", 250))



        Return listEstCeldas
    End Function

    Public Overrides Sub _PMOMostrarRegistro(_N As Integer)
        JGrM_Buscador.Row = _MPos
        'id,Nombre,Grupo,gr.ycdes3 as DescripcionGrupo,ParametrosTecnicos,
        'pr.ycdes3 as DescripcionParametros , Notas
        Dim dt As DataTable = CType(JGrM_Buscador.DataSource, DataTable)
        Try
            tbCodigoOriginal.Text = JGrM_Buscador.GetValue("Id").ToString
        Catch ex As Exception
            Exit Sub
        End Try
        With JGrM_Buscador
            tbCodigoOriginal.Text = .GetValue("Id").ToString
            _prCargarDetalleParametrosTecnicos(tbCodigoOriginal.Text)
            cbGrupo.Value = .GetValue("Grupo")
            FiltrarParametros()
            _prCargarDetalle(tbCodigoOriginal.Text)
            FiltrarParametros()
            tbNombre.Text = .GetValue("Nombre").ToString
            tbNota.Text = .GetValue("Notas").ToString

        End With
        If (grParametroTecnico.RowCount > 0) Then
            grParametroTecnico.Row = 0
            FiltrarDetalle(grParametroTecnico.GetValue("Id"))


        End If
        TablaImagenes = L_fnDetalleImagenes(tbCodigoOriginal.Text)
        _prCargarImagen()


        LblPaginacion.Text = Str(_MPos + 1) + "/" + JGrM_Buscador.RowCount.ToString

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











    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If btnGrabar.Enabled = True Then
            _PMInhabilitar()
            _PMPrimerRegistro()

        Else
            '  Public _modulo As SideNavItem
            _modulo.Select()
            Me.Close()
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
        Return tbAtributo.ReadOnly = False

    End Function


    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click


        tbNombre.Focus()
    End Sub

    Private Sub cbGrupo_ValueChanged(sender As Object, e As EventArgs) Handles cbGrupo.ValueChanged
        If cbGrupo.SelectedIndex < 0 And cbGrupo.Text <> String.Empty Then
            btGrupo.Visible = True
        Else
            gpTecnico.Text = "P.Tecnicos De " + cbGrupo.Text
            btGrupo.Visible = False
            FiltrarParametros()
        End If
    End Sub

    Private Sub cbParametroTecnico_ValueChanged(sender As Object, e As EventArgs) Handles cbParametroTecnico.ValueChanged
        If cbParametroTecnico.SelectedIndex < 0 And cbParametroTecnico.Text <> String.Empty Then
            btnParametroTecnico.Visible = True
        Else
            btnParametroTecnico.Visible = False
        End If
    End Sub

    Private Sub btGrupo_Click(sender As Object, e As EventArgs) Handles btGrupo.Click
        Dim numi As String = ""
        If L_prLibreriaGrabar(numi, "22", "1", cbGrupo.Text, "") Then
            _prCargarComboLibreria(cbGrupo, "22", "1")
            cbGrupo.SelectedIndex = CType(cbGrupo.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btnParametroTecnico_Click(sender As Object, e As EventArgs) Handles btnParametroTecnico.Click
        Dim numi As String = ""
        If L_prLibreriaGrabar(numi, "22", "2", cbParametroTecnico.Text, "") Then
            _prCargarComboLibreria(cbParametroTecnico, "22", "2")
            cbParametroTecnico.SelectedIndex = CType(cbParametroTecnico.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub _prCargarDetalle(_numi As String)
        Dim dt As New DataTable
        dt = L_fnDetalleEquipos(_numi)
        grDetalle.DataSource = dt
        grDetalle.RetrieveStructure()
        grDetalle.AlternatingColors = True
        'a.Id ,a.Atributo ,a.Descripcion ,a.EquiposId ,a.ParametroTecnicoId ,1 as estado
        With grDetalle.RootTable.Columns("Id")
            .Width = 100
            .Caption = "Id"
            .Visible = True
        End With

        With grDetalle.RootTable.Columns("Atributo")
            .Width = 300
            .Caption = "Atributo"
            .Visible = True
        End With

        With grDetalle.RootTable.Columns("Descripcion")
            .Width = 400
            .Caption = "Descripcion"
            .Visible = True
        End With
        With grDetalle.RootTable.Columns("EquiposId")
            .Width = 100
            .Caption = "EquiposId"
            .Visible = False
        End With
        With grDetalle.RootTable.Columns("ParametroTecnicoId")
            .Width = 100
            .Caption = "ParametroTecnicoId"
            .Visible = False
        End With

        With grDetalle.RootTable.Columns("estado")
            .Width = 100
            .Caption = "estado"
            .Visible = False
        End With

        With grDetalle
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007

        End With
    End Sub

    Private Sub _prCargarDetalleParametrosTecnicos(_numi As String)
        Dim dt As New DataTable
        dt = L_fnDetalleParametrosTenicos(_numi)
        grParametroTecnico.DataSource = dt
        grParametroTecnico.RetrieveStructure()
        grParametroTecnico.AlternatingColors = True
        'a.Id ,a.EquipoId,a.GrupoId,a.Parametro ,isnull((select ycdes3  from TY0031 where yccod1 =22 and yccod2 =2 and yccod3 =a.Parametro  ),'') as NombreParametro ,1 as Estado
        With grParametroTecnico.RootTable.Columns("Id")
            .Width = 100
            .Caption = "Id"
            .Visible = True
        End With
        With grParametroTecnico.RootTable.Columns("EquipoId")
            .Width = 100
            .Caption = "EquiposId"
            .Visible = False
        End With
        With grParametroTecnico.RootTable.Columns("GrupoId")
            .Width = 100
            .Caption = "EquiposId"
            .Visible = False
        End With
        With grParametroTecnico.RootTable.Columns("Parametro")
            .Width = 100
            .Caption = "EquiposId"
            .Visible = False
        End With


        With grParametroTecnico.RootTable.Columns("NombreParametro")
            .Width = 300
            .Caption = "Parametro Tenico"
            .Visible = True
        End With


        With grParametroTecnico.RootTable.Columns("estado")
            .Width = 100
            .Caption = "estado"
            .Visible = False
        End With

        With grParametroTecnico
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007

        End With
    End Sub

    Private Sub btnDetalleAgregar_Click(sender As Object, e As EventArgs) Handles btnDetalleAgregar.Click
        If (grParametroTecnico.Row >= 0) Then
            _prAddDetalleVenta()

        Else
            ToastNotification.Show(Me, "Seleccione un Parametro Tecnico..!!!",
                                  My.Resources.WARNING, 2000,
                                  eToastGlowColor.Red,
                                  eToastPosition.BottomLeft)
        End If


    End Sub

    Private Sub _prAddDetalleVenta()
        '  a.Id ,a.Atributo ,a.Descripcion ,a.EquiposId ,a.ParametroTecnicoId ,1 as estado
        If (tbAtributo.Text <> "" And tbdescripcion.Text <> "") Then


            CType(grDetalle.DataSource, DataTable).Rows.Add(_fnSiguienteNumi(grDetalle) + 1, tbAtributo.Text, tbdescripcion.Text, 0, grParametroTecnico.GetValue("Id"), 0)
            tbAtributo.Clear()
            tbdescripcion.Clear()
            tbAtributo.Focus()

        Else
            ToastNotification.Show(Me, "Rellenar todos los campos..!!!",
                                    My.Resources.WARNING, 2000,
                                    eToastGlowColor.Red,
                                    eToastPosition.BottomLeft)
        End If

    End Sub
    Public Function _fnSiguienteNumi(Gr As GridEX)
        Dim dt As DataTable = CType(Gr.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("Id=MAX(Id)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("Id")
        End If
        Return 0
    End Function

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        _fnCopiarImagenVariosRutaDefinida()
        _prCargarImagen()
    End Sub
    Private Function _fnCopiarImagenVariosRutaDefinida() As String
        'copio la imagen en la carpeta del sistema

        Dim file As New OpenFileDialog()
        'file.InitialDirectory = gs_RutaImg
        file.Filter = "Ficheros JPG o JPEG o PNG|*.jpg;*.jpeg;*.png" &
                      "|Ficheros GIF|*.gif" &
                      "|Ficheros BMP|*.bmp" &
                      "|Ficheros PNG|*.png" &
                      "|Ficheros TIFF|*.tif"
        If file.ShowDialog() = DialogResult.OK Then
            Dim ruta As String = file.FileName
            Dim nombre As String = ""

            If file.CheckFileExists = True Then
                Dim img As New Bitmap(New Bitmap(ruta), 1000, 800)
                Dim a As Object = file.GetType.ToString

                Dim da As String = Str(Now.Day).Trim + Str(Now.Month).Trim + Str(Now.Year).Trim + Str(Now.Hour).Trim + Str(Now.Minute).Trim + Str(Now.Second).Trim

                nombre = "\Imagen_" + da + ".jpg".Trim


                If (tbCodigoOriginal.Text = "") Then
                    Dim mstream = New MemoryStream()

                    img.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                    TablaImagenes.Rows.Add(0, 0, nombre, mstream.ToArray(), 0)
                    mstream.Dispose()
                    img.Dispose()

                Else
                    Dim mstream = New MemoryStream()

                    img.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    TablaImagenes.Rows.Add(0, tbCodigoOriginal.Text, nombre, mstream.ToArray(), 0)
                    mstream.Dispose()

                End If

                'img.Save(RutaTemporal + nombre, System.Drawing.Imaging.ImageFormat.Jpeg)




            End If
            Return nombre
        End If

        Return "default.jpg"
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim pos As Integer = CType(pbImgProdu.Tag, Integer)
        If (IsDBNull(TablaImagenes)) Then
            Return

        End If
        If (pos >= 0 And TablaImagenes.Rows.Count > 0) Then
            TablaImagenes.Rows(pos).Item("estado") = -1
            _prCargarImagen()
        End If
    End Sub

    Public Function ExisteParametro(GrupoId As Integer, ParametroId As Integer) As Boolean
        Dim dt As DataTable = CType(grParametroTecnico.DataSource, DataTable)

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1

            If (dt.Rows(i).Item("GrupoId") = GrupoId And dt.Rows(i).Item("Parametro") = ParametroId And dt.Rows(i).Item("estado") >= 0) Then

                Return True

            End If

        Next
        Return False

    End Function
    Public Sub FiltrarParametros()

        If (Not IsNothing(grParametroTecnico.DataSource)) Then
            Dim filter As GridEXFilterCondition = New Janus.Windows.GridEX.GridEXFilterCondition(grParametroTecnico.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0)

            filter.AddCondition(LogicalOperator.And, New Janus.Windows.GridEX.GridEXFilterCondition(grParametroTecnico.RootTable.Columns("GrupoId"), Janus.Windows.GridEX.ConditionOperator.Equal, cbGrupo.Value))


            grParametroTecnico.RootTable.FilterCondition = filter

            If (grParametroTecnico.RowCount > 0) Then
                grParametroTecnico.Row = 0
                FiltrarDetalle(grParametroTecnico.GetValue("Id"))
            Else
                FiltrarDetalle(-1)

            End If
        End If




    End Sub
    Private Sub btnParametroTecnicoAgregar_Click(sender As Object, e As EventArgs) Handles btnParametroTecnicoAgregar.Click

        If (cbGrupo.SelectedIndex < 0 Or cbGrupo.SelectedIndex < 0) Then
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "Debe Seleccionar un Grupo y un Parametro Tenico".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

            Return

        End If

        If (Not ExisteParametro(cbGrupo.Value, cbParametroTecnico.Value)) Then

            'a.Id , a.EquipoId, a.GrupoId, a.Parametro, isnull((select ycdes3  from TY0031 where yccod1 =22 And yccod2 =2 And yccod3 =a.Parametro  ),'') as NombreParametro ,1 as Estado

            If (tbCodigoOriginal.Text.Trim <> String.Empty) Then
                CType(grParametroTecnico.DataSource, DataTable).Rows.Add(_fnSiguienteNumi(grParametroTecnico) + 1, CInt(tbCodigoOriginal.Text), cbGrupo.Value, cbParametroTecnico.Value, cbParametroTecnico.Text, 0)

            Else
                CType(grParametroTecnico.DataSource, DataTable).Rows.Add(_fnSiguienteNumi(grParametroTecnico) + 1, 0, cbGrupo.Value, cbParametroTecnico.Value, cbParametroTecnico.Text, 0)
            End If




        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El Parametro Tecnico " + cbParametroTecnico.Text + " Del Grupo " + cbGrupo.Text + "  Ya esta Registrada".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

            Return
        End If

    End Sub

    Private Sub grParametroTecnico_SelectionChanged(sender As Object, e As EventArgs) Handles grParametroTecnico.SelectionChanged
        If (grParametroTecnico.Row >= 0) Then
            GroupPanel2.Text = "Información " + grParametroTecnico.GetValue("NombreParametro")

            FiltrarDetalle(grParametroTecnico.GetValue("Id"))
        End If
    End Sub
    Public Sub FiltrarDetalle(ParametroId As Integer)
        If (Not IsNothing(grDetalle.DataSource)) Then
            Dim filter As GridEXFilterCondition = New Janus.Windows.GridEX.GridEXFilterCondition(grDetalle.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0)

            filter.AddCondition(LogicalOperator.And, New Janus.Windows.GridEX.GridEXFilterCondition(grDetalle.RootTable.Columns("ParametroTecnicoId"), Janus.Windows.GridEX.ConditionOperator.Equal, ParametroId))


            grDetalle.RootTable.FilterCondition = filter
        End If

    End Sub

    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(grParametroTecnico.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(grParametroTecnico.DataSource, DataTable).Rows(i).Item("Id")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub

    Public Sub _fnObtenerFilaDetalle02(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(grDetalle.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(grDetalle.DataSource, DataTable).Rows(i).Item("Id")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        If (grParametroTecnico.Row >= 0) Then
            Dim estado As Integer = grParametroTecnico.GetValue("estado")
            Dim pos As Integer = -1
            Dim lin As Integer = grParametroTecnico.GetValue("Id")
            _fnObtenerFilaDetalle(pos, lin)
            If (estado = 0) Then
                CType(grParametroTecnico.DataSource, DataTable).Rows(pos).Item("estado") = -2
            End If
            If (estado = 1) Then
                CType(grParametroTecnico.DataSource, DataTable).Rows(pos).Item("estado") = -1
            End If

            Dim dt As DataTable = CType(grDetalle.DataSource, DataTable)

            For i As Integer = 0 To dt.Rows.Count - 1 Step 1

                If (dt.Rows(i).Item("ParametroTecnicoId") = CType(grParametroTecnico.DataSource, DataTable).Rows(pos).Item("Id")) Then
                    CType(grDetalle.DataSource, DataTable).Rows(i).Item("estado") = -1
                End If

            Next



            FiltrarParametros()
            If (grParametroTecnico.RowCount > 0) Then

                grParametroTecnico.Row = 0
                FiltrarDetalle(grParametroTecnico.GetValue("Id"))

            Else
                FiltrarDetalle(-1)
            End If



        End If

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If (grDetalle.Row >= 0) Then
            Dim estado As Integer = grDetalle.GetValue("estado")
            Dim pos As Integer = -1
            Dim lin As Integer = grDetalle.GetValue("Id")
            _fnObtenerFilaDetalle02(pos, lin)
            If (estado = 0) Then
                CType(grDetalle.DataSource, DataTable).Rows(pos).Item("estado") = -2
            End If
            If (estado = 1) Then
                CType(grDetalle.DataSource, DataTable).Rows(pos).Item("estado") = -1
            End If





            If (grParametroTecnico.Row >= 0) Then


                FiltrarDetalle(grParametroTecnico.GetValue("Id"))

            Else
                FiltrarDetalle(-1)
            End If



        End If
    End Sub
End Class