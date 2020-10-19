Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO


Public Class F0_ProduccionProducto

    Dim _Inter As Integer = 0

#Region "Variables Globales"
    Dim _CodProveedor As Integer = 0
    Dim _numiCatCosto As Integer = 0
    Public _nameButton As String
    Public _tab As SuperTabItem
    Dim _PorcentajeUtil As Double = 0 '' En esta varible obtendre de la libreria el porcentaje de utilidad para la venta 
    Dim _estadoPor As Integer ''En esta variable me dira si sera visible o no las columnas de porcentaje de utilidad y precio de venta
    Public _detalleCompras As DataTable
    Dim TablaImagenes As DataTable
    Dim TablaInventario As DataTable
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim RutaTemporal As String = "C:\Temporal"
    Dim Modificado As Boolean = False
    Dim nameImg As String = "Default.jpg"
#End Region

#Region "Metodos Privados"
    Private Sub _IniciarTodo()
        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)

        _prCargarComboLibreria(cbGrupo, 20, 1)
        _prCargarComboLibreria(cbSubGrupo, 20, 2)
        _prCargarComboLibreria(cbUnidad, 20, 3)

        _prCargarComboLibreria(cbUnidad, 20, 3)
        _prCargarComboLibreria(cbEmpaqueUnidad, 20, 3)
        _prCargarComboLibreria(cbMateriaUnidad, 20, 3)


        ' Me.WindowState = FormWindowState.Maximized
        _prCargarCompra()
        _prInhabiliitar()

        _prAsignarPermisos()
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

    Sub _prCrearCarpetaImagenes()
        Dim rutaDestino As String = RutaGlobal + "\Imagenes\Imagenes ProductoDino\"

        If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes ProductoDino\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Imagenes") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes")
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes ProductoDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes ProductoDino")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes ProductoDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes ProductoDino")

                End If
            End If
        End If
    End Sub
    Private Sub _fnMoverImagenRuta(Folder As String, name As String)
        'copio la imagen en la carpeta del sistema
        If (Not name.Equals("Default.jpg") And File.Exists(RutaTemporal + name)) Then

            Dim img As New Bitmap(New Bitmap(RutaTemporal + name), 500, 300)

            UsImg.pbImage.Image.Dispose()
            UsImg.pbImage.Image = Nothing
            Try
                My.Computer.FileSystem.CopyFile(RutaTemporal + name,
     Folder + name, overwrite:=True)

            Catch ex As System.IO.IOException


            End Try



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


    Private Sub _prInhabiliitar()
        tbCodigo.ReadOnly = True

        tbId.ReadOnly = True
        tbCodigo.ReadOnly = True
        tbDescripcion.ReadOnly = True
        cbUnidad.ReadOnly = True
        cbGrupo.ReadOnly = True
        cbSubGrupo.ReadOnly = True

        tbPeso.IsInputReadOnly = True
        tbObservacion.ReadOnly = True
        tbPrecioA.IsInputReadOnly = True
        tbPrecioB.IsInputReadOnly = True
        tbPrecioC.IsInputReadOnly = True

        btMateriaAgregar.Visible = False
        btnfisicaAgregar.Visible = False
        btnCalidadAgregar.Visible = False
        btnMaquinariaAgregar.Visible = False
        btnEmpaqueAgregar.Visible = False
        btnMaquinariaAgregar.Visible = False
        btnMoldeAgregar.Visible = False
        btnHerramentalAgregar.Visible = False
        BtAdicionar.Visible = False



        ''''''''''
        btnModificar.Enabled = True
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnEliminar.Enabled = True
        PanelNavegacion.Enabled = True


    End Sub
    Private Sub _prhabilitar()
        BtAdicionar.Visible = True
        tbCodigo.ReadOnly = False
        tbDescripcion.ReadOnly = False
        cbUnidad.ReadOnly = False
        cbGrupo.ReadOnly = False
        cbSubGrupo.ReadOnly = False
        btUnidad.Visible = False
        btGrupo.Visible = False
        btSubGrupo.Visible = False
        tbPeso.IsInputReadOnly = False
        tbObservacion.ReadOnly = False
        tbPrecioA.IsInputReadOnly = False
        tbPrecioB.IsInputReadOnly = False
        tbPrecioC.IsInputReadOnly = False
        btMateriaAgregar.Visible = True
        btnfisicaAgregar.Visible = True
        btnCalidadAgregar.Visible = True
        btnMaquinariaAgregar.Visible = True
        btnEmpaqueAgregar.Visible = True
        btnMaquinariaAgregar.Visible = True
        btnMoldeAgregar.Visible = True
        btnHerramentalAgregar.Visible = True


        btMateriaUnidad.Visible = False


        btnGrabar.Enabled = True
    End Sub
    Public Sub _prFiltrar()
        'cargo el buscador
        Dim _Mpos As Integer
        _prCargarCompra()
        If grCompra.RowCount > 0 Then
            _Mpos = 0
            grCompra.Row = _Mpos
        Else
            _Limpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
    Private Sub _Limpiar()
        tbCodigo.Clear()
        tbDescripcion.Clear()
        tbId.Clear()




        tbPeso.Value = 0
        tbObservacion.Clear()
        tbPrecioA.Value = 0
        tbPrecioB.Value = 0
        tbPrecioC.Value = 0




        _prCargarMaquinaria(-1)
        _prCargarEmpaque(-1)
        _prCargarDosificacion(-1)
        _prCargarMolde(-1)
        _prCargarHerramental(-1)
        _prCargarCaracterisiticaCalidad(-1)
        _prCargarCaracterisiticaFisica(-1)
        MSuperTabControl.SelectedTabIndex = 0


    End Sub
    Public Sub _prMostrarRegistro(_N As Integer)
        'a.Id , a.Codigo, a.Descripcion, a.Unidad, uni.ycdes3 As UnidadDescripcion, a.Grupo,
        'gr.ycdes3 As GrupoDescripcion, a.SubGrupo, Sub() .ycdes3 as SubGrupoDescripcion, a.Peso, a.Observaciones,
        'a.PrecioA, a.PrecioB, a.PrecioC, a.Imagen, a.Usuario  

        With grCompra
            tbCodigo.Text = .GetValue("Codigo")
            tbId.Text = .GetValue("Id")
            tbDescripcion.Text = .GetValue("Descripcion").ToString
            cbUnidad.Value = .GetValue("Unidad")
            cbGrupo.Value = .GetValue("Grupo")
            cbSubGrupo.Value = .GetValue("SubGrupo")
            tbPeso.Value = .GetValue("Peso")
            tbObservacion.Text = .GetValue("Observaciones").ToString
            tbPrecioA.Value = .GetValue("PrecioA")
            tbPrecioB.Value = .GetValue("PrecioB")
            tbPrecioC.Value = .GetValue("PrecioC")

        End With
        Dim name As String = grCompra.GetValue("Imagen")
        If name.Equals("Default.jpg") Or Not File.Exists(RutaGlobal + "\Imagenes\Imagenes ProductoDino" + name) Then

            Dim im As New Bitmap(My.Resources.pantalla)
            UsImg.pbImage.Image = im
        Else
            If (File.Exists(RutaGlobal + "\Imagenes\Imagenes ProductoDino" + name)) Then
                Dim Bin As New MemoryStream
                Dim im As New Bitmap(New Bitmap(RutaGlobal + "\Imagenes\Imagenes ProductoDino" + name))
                im.Save(Bin, System.Drawing.Imaging.ImageFormat.Jpeg)
                UsImg.pbImage.SizeMode = PictureBoxSizeMode.StretchImage
                UsImg.pbImage.Image = Image.FromStream(Bin)
                Bin.Dispose()

            End If
        End If
        _prCargarMaquinaria(grCompra.GetValue("Id"))
        _prCargarEmpaque(grCompra.GetValue("Id"))
        _prCargarDosificacion(grCompra.GetValue("Id"))
        _prCargarMolde(grCompra.GetValue("Id"))
        _prCargarHerramental(grCompra.GetValue("Id"))
        _prCargarCaracterisiticaCalidad(grCompra.GetValue("Id"))
        _prCargarCaracterisiticaFisica(grCompra.GetValue("Id"))

        LblPaginacion.Text = Str(grCompra.Row + 1) + "/" + grCompra.RowCount.ToString

    End Sub


    Private Sub _prCargarCaracterisiticaFisica(_numi As String)
        Dim dt As New DataTable
        dt = L_fnDetalleCaracterisiticaFisica(_numi)
        grCaracterisiticaFisicas.DataSource = dt
        grCaracterisiticaFisicas.RetrieveStructure()
        grCaracterisiticaFisicas.AlternatingColors = True
        ' a.Id ,a.ProductoId ,a.Caracterisitica  ,a.Valor  ,1 as estado
        With grCaracterisiticaFisicas.RootTable.Columns("Id")
            .Width = 100
            .Caption = "Codigo"
            .Visible = True
        End With
        With grCaracterisiticaFisicas.RootTable.Columns("Caracterisitica")
            .Width = 500
            .Caption = "Caracteristica"
            .Visible = True
        End With

        With grCaracterisiticaFisicas.RootTable.Columns("Valor")
            .Width = 400
            .Caption = "Valor"
            .Visible = True
        End With
        With grCaracterisiticaFisicas.RootTable.Columns("ProductoId")
            .Width = 100
            .Visible = False
        End With
        With grCaracterisiticaFisicas.RootTable.Columns("estado")
            .Width = 100
            .Visible = False
        End With

        With grCaracterisiticaFisicas
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007

        End With
    End Sub

    Private Sub _prCargarCaracterisiticaCalidad(_numi As String)
        Dim dt As New DataTable
        dt = L_fnDetalleCaracterisiticaCalidad(_numi)
        grCaracteristicaCalidad.DataSource = dt
        grCaracteristicaCalidad.RetrieveStructure()
        grCaracteristicaCalidad.AlternatingColors = True
        ' a.Id ,a.ProductoId ,a.Atributo ,a.Descripcion ,1 as estado
        With grCaracteristicaCalidad.RootTable.Columns("Id")
            .Width = 100
            .Caption = "Codigo"
            .Visible = True
        End With

        With grCaracteristicaCalidad.RootTable.Columns("Atributo")
            .Width = 500
            .Caption = "Atributo"
            .Visible = True
        End With

        With grCaracteristicaCalidad.RootTable.Columns("Descripcion")
            .Width = 400
            .Caption = "Descripcion"
            .Visible = True
        End With
        With grCaracteristicaCalidad.RootTable.Columns("ProductoId")
            .Width = 100
            .Visible = False
        End With
        With grCaracteristicaCalidad.RootTable.Columns("estado")
            .Width = 100
            .Visible = False
        End With

        With grCaracteristicaCalidad
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007

        End With
    End Sub
    Private Sub _prCargarHerramental(_numi As String)
        Dim dt As New DataTable
        dt = L_fnDetalleHerramental(_numi)
        grHerramental.DataSource = dt
        grHerramental.RetrieveStructure()
        grHerramental.AlternatingColors = True
        'a.Id , a.ProductoId, a.Caracterisitica, a.Valor, 1 as estado L_fnDetalleMolde

        With grHerramental.RootTable.Columns("ProductoId")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With
        With grHerramental.RootTable.Columns("estado")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With

        With grHerramental
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            .Size = MaximumSize
            .AutoSizeColumns()
        End With
    End Sub

    Private Sub _prCargarMolde(_numi As String)
        Dim dt As New DataTable
        dt = L_fnDetalleMolde(_numi)
        grMolde.DataSource = dt
        grMolde.RetrieveStructure()
        grMolde.AlternatingColors = True
        'a.Id , a.ProductoId, a.Caracterisitica, a.Valor, 1 as estado L_fnDetalleDosificacion

        With grMolde.RootTable.Columns("ProductoId")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With
        With grMolde.RootTable.Columns("estado")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With

        With grMolde
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            .Size = MaximumSize
            .AutoSizeColumns()
        End With
    End Sub

    Private Sub _prCargarDosificacion(_numi As String)
        Dim dt As New DataTable
        dt = L_fnDetalleDosificacion(_numi)
        grDosificacion.DataSource = dt
        grDosificacion.RetrieveStructure()
        grDosificacion.AlternatingColors = True
        'a.Id ,a.ProductoId ,a.Cantidad ,a.Unidad,uni.ycdes3 as UnidadDescripcion ,1 as estado L_fnDetalleEmpaque
        With grDosificacion.RootTable.Columns("Unidad")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With
        With grDosificacion.RootTable.Columns("ProductoId")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With
        With grDosificacion.RootTable.Columns("estado")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With

        With grDosificacion
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            .Size = MaximumSize
            .AutoSizeColumns()
        End With
    End Sub
    Private Sub _prCargarEmpaque(_numi As String)
        Dim dt As New DataTable
        dt = L_fnDetalleEmpaque(_numi)
        grEmpaque.DataSource = dt
        grEmpaque.RetrieveStructure()
        grEmpaque.AlternatingColors = True
        'a.Id ,a.ProductoId ,a.Cantidad ,a.Unidad,uni.ycdes3 as UnidadDescripcion ,1 as estado L_fnDetalleMaquinaria
        With grEmpaque.RootTable.Columns("Unidad")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With
        With grEmpaque.RootTable.Columns("ProductoId")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With
        With grEmpaque.RootTable.Columns("estado")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With

        With grEmpaque
            .GroupByBoxVisible = False
            .Size = MaximumSize
            .AutoSizeColumns()
            'diseño de la grilla.
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prCargarMaquinaria(_numi As String)
        Dim dt As New DataTable
        dt = L_fnDetalleMaquinaria(_numi)
        grMaquinaria.DataSource = dt
        grMaquinaria.RetrieveStructure()
        grMaquinaria.AlternatingColors = True
        'a.Id ,a.ProductoId ,a.Cantidad ,a.Unidad,uni.ycdes3 as UnidadDescripcion ,1 as estado L_fnDetalleMaquinaria

        With grMaquinaria.RootTable.Columns("ProductoId")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With
        With grMaquinaria.RootTable.Columns("estado")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With

        With grMaquinaria
            .GroupByBoxVisible = False
            .Size = MaximumSize
            .AutoSizeColumns()

            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With

    End Sub

    Private Sub _prCargarCompra()
        Dim dt As New DataTable
        dt = L_fnListPRoductos()
        grCompra.DataSource = dt
        grCompra.RetrieveStructure()
        grCompra.AlternatingColors = True
        'a.Id , a.Codigo, a.Descripcion, a.Unidad, uni.ycdes3 As UnidadDescripcion, a.Grupo,
        'gr.ycdes3 As GrupoDescripcion, a.SubGrupo, Sub() .ycdes3 as SubGrupoDescripcion, a.Peso, a.Observaciones,
        'a.PrecioA, a.PrecioB, a.PrecioC, a.Imagen, a.Usuario 

        With grCompra.RootTable.Columns("Id")
            .Width = 90
            .Visible = False
        End With
        With grCompra.RootTable.Columns("Imagen")
            .Width = 90
            .Visible = False
        End With
        With grCompra.RootTable.Columns("Unidad")
            .Width = 90
            .Visible = False
        End With
        With grCompra.RootTable.Columns("Grupo")
            .Width = 90
            .Visible = False
        End With
        With grCompra.RootTable.Columns("SubGrupo")
            .Width = 90
            .Visible = False
        End With
        With grCompra.RootTable.Columns("GrupoDescripcion")
            .Width = 100
            .Caption = "Grupo"
            .Visible = True

        End With
        With grCompra.RootTable.Columns("SubGrupoDescripcion")
            .Width = 100
            .Caption = "SubGrupo"
            .Visible = True

        End With
        With grCompra.RootTable.Columns("UnidadDescripcion")
            .Width = 100
            .Caption = "Unidad"
            .Visible = True

        End With


        With grCompra
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With


    End Sub



    Public Function _fnSiguienteNumi(Gr As GridEX)
        Dim dt As DataTable = CType(Gr.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("Id=MAX(Id)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("Id")
        End If
        Return 0
    End Function
    Public Function _fnAccesible()
        Return tbObservacion.ReadOnly = False
    End Function




    Public Sub _prEliminarFila()
        'If (grdetalle.Row >= 0) Then
        '    If (grdetalle.RowCount >= 2) Then
        '        Dim estado As Integer = grdetalle.GetValue("estado")
        '        Dim pos As Integer = -1
        '        Dim lin As Integer = grdetalle.GetValue("cbnumi")
        '        _fnObtenerFilaDetalle(pos, lin)
        '        If (estado = 0) Then
        '            CType(grdetalle.DataSource, DataTable).Rows(pos).Item("estado") = -2

        '        End If
        '        If (estado = 1) Then
        '            CType(grdetalle.DataSource, DataTable).Rows(pos).Item("estado") = -1
        '        End If
        '        grdetalle.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(grdetalle.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))
        '        _prCalcularPrecioTotal()
        '        grdetalle.Select()
        '        grdetalle.Col = 5
        '        grdetalle.Row = grdetalle.RowCount - 1
        '    End If
        'End If


    End Sub


    Public Sub _GuardarNuevo()

        'L_fnGrabarProductoNew(id As String, Codigo As String, Descripcion As String, Unidad As Integer, Grupo As Integer, SubGrupo As Integer, Peso As Double, Observaciones As String, PrecioA As Double, PrecioB As Double, PRecioC As Double, Imagen As String)
        'grmaquinari As DataTable, grEmpaque As DataTable, grDosificacion As DataTable, grMolde As DataTable, grHerramental As DataTable, grCalidad As DataTable, grfisica As DataTable, grImagen As DataTable
        Dim res As Boolean = L_fnGrabarProductoNew(tbId.Text, tbCodigo.Text, tbDescripcion.Text, cbUnidad.Value, cbGrupo.Value, cbSubGrupo.Value, tbPeso.Value, tbObservacion.Text, tbPrecioA.Value, tbPrecioB.Value, tbPrecioC.Value, nameImg, CType(grMaquinaria.DataSource, DataTable), CType(grEmpaque.DataSource, DataTable), CType(grDosificacion.DataSource, DataTable), CType(grMolde.DataSource, DataTable), CType(grHerramental.DataSource, DataTable), CType(grCaracteristicaCalidad.DataSource, DataTable), CType(grCaracterisiticaFisicas.DataSource, DataTable), TablaImagenes)


        If res Then
            Modificado = False
            _fnMoverImagenRuta(RutaGlobal + "\Imagenes\Imagenes ProductoDino", nameImg)
            nameImg = "Default.jpg"

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Producto ".ToUpper + tbCodigo.Text + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            tbCodigo.Focus()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El producto no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If




    End Sub
    Private Sub _prGuardarModificado()
        Dim res As Boolean


        Dim nameImage As String = grCompra.GetValue("Imagen")
        If (Modificado = False) Then
            res = L_fnModificarProductoNew(tbId.Text, tbCodigo.Text, tbDescripcion.Text, cbUnidad.Value, cbGrupo.Value, cbSubGrupo.Value, tbPeso.Value, tbObservacion.Text, tbPrecioA.Value, tbPrecioB.Value, tbPrecioC.Value, nameImage, CType(grMaquinaria.DataSource, DataTable), CType(grEmpaque.DataSource, DataTable), CType(grDosificacion.DataSource, DataTable), CType(grMolde.DataSource, DataTable), CType(grHerramental.DataSource, DataTable), CType(grCaracteristicaCalidad.DataSource, DataTable), CType(grCaracterisiticaFisicas.DataSource, DataTable), TablaImagenes)
        Else
            res = L_fnModificarProductoNew(tbId.Text, tbCodigo.Text, tbDescripcion.Text, cbUnidad.Value, cbGrupo.Value, cbSubGrupo.Value, tbPeso.Value, tbObservacion.Text, tbPrecioA.Value, tbPrecioB.Value, tbPrecioC.Value, nameImg, CType(grMaquinaria.DataSource, DataTable), CType(grEmpaque.DataSource, DataTable), CType(grDosificacion.DataSource, DataTable), CType(grMolde.DataSource, DataTable), CType(grHerramental.DataSource, DataTable), CType(grCaracteristicaCalidad.DataSource, DataTable), CType(grCaracterisiticaFisicas.DataSource, DataTable), TablaImagenes)
        End If


        If res Then
            If (Modificado = True) Then
                _fnMoverImagenRuta(RutaGlobal + "\Imagenes\Imagenes ProductoDino", nameImg)
                Modificado = False
            End If
            nameImg = "Default.jpg"

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Producto ".ToUpper + tbCodigo.Text + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            tbCodigo.Focus()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El producto no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If

    End Sub
    Private Sub _prSalir()
        If btnGrabar.Enabled = True Then
            _prInhabiliitar()
            If grCompra.RowCount > 0 Then

                _prMostrarRegistro(0)

            End If
        Else

            'Me.Close()
            _tab.Close()

        End If
    End Sub

    Public Sub _PrimerRegistro()
        Dim _MPos As Integer
        If grCompra.RowCount > 0 Then
            _MPos = 0
            ''   _prMostrarRegistro(_MPos)
            grCompra.Row = _MPos
        End If
    End Sub
#End Region


#Region "Eventos Formulario"
    Private Sub F0_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _IniciarTodo()

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _Limpiar()
        _prhabilitar()

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = True
        PanelNavegacion.Enabled = False

        'btnNuevo.Enabled = False
        'btnModificar.Enabled = False
        'btnEliminar.Enabled = False
        'GPanelProductos.Visible = False
        '_prhabilitar()

        '_Limpiar()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _prSalir()

    End Sub




    Function _ValidarCampos() As Boolean

        Dim _ok As Boolean = True
        MEP.Clear()
        If tbDescripcion.Text = String.Empty Then
            tbDescripcion.Focus()
            ToastNotification.Show(Me, "Campo Descripcion Requerido!!!",
                                       My.Resources.WARNING, 2000,
                                       eToastGlowColor.Red,
                                       eToastPosition.BottomLeft)
            _ok = False

        End If

        Return _ok

    End Function
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If _ValidarCampos() = False Then
            Exit Sub
        End If

        If (tbCodigo.Text = String.Empty) Then
            _GuardarNuevo()
        Else
            If (tbCodigo.Text <> String.Empty) Then
                _prGuardarModificado()
                ''    _prInhabiliitar()

            End If
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (grCompra.RowCount > 0) Then
            _prhabilitar()
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnGrabar.Enabled = True

            PanelNavegacion.Enabled = False

        End If


    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim ef = New Efecto


        ef.tipo = 2
        ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
        ef.Header = "mensaje principal".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_fnEliminarProductoNew(tbCodigo.Text, mensajeError)
            If res Then


                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código de Producto ".ToUpper + tbCodigo.Text + " eliminado con Exito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter)

                _prFiltrar()

            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, mensajeError, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            End If
        End If

    End Sub

    Private Sub grVentas_SelectionChanged(sender As Object, e As EventArgs) Handles grCompra.SelectionChanged

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim _pos As Integer = grCompra.Row
        If _pos < grCompra.RowCount - 1 Then
            _pos = grCompra.Row + 1
            '' _prMostrarRegistro(_pos)
            grCompra.Row = _pos
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Dim _pos As Integer = grCompra.Row
        If grCompra.RowCount > 0 Then
            _pos = grCompra.RowCount - 1
            ''  _prMostrarRegistro(_pos)
            grCompra.Row = _pos
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim _MPos As Integer = grCompra.Row
        If _MPos > 0 And grCompra.RowCount > 0 Then
            _MPos = _MPos - 1
            ''  _prMostrarRegistro(_MPos)
            grCompra.Row = _MPos
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        _PrimerRegistro()
    End Sub
    Private Sub grVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles grCompra.KeyDown

    End Sub

    Private Sub cbUnidad_ValueChanged(sender As Object, e As EventArgs) Handles cbUnidad.ValueChanged
        If cbUnidad.SelectedIndex < 0 And cbUnidad.Text <> String.Empty Then
            btUnidad.Visible = True
        Else
            btUnidad.Visible = False
        End If
    End Sub

    Private Sub cbGrupo_ValueChanged(sender As Object, e As EventArgs) Handles cbGrupo.ValueChanged
        If cbGrupo.SelectedIndex < 0 And cbGrupo.Text <> String.Empty Then
            btGrupo.Visible = True
        Else
            btGrupo.Visible = False
        End If
    End Sub

    Private Sub cbSubGrupo_ValueChanged(sender As Object, e As EventArgs) Handles cbSubGrupo.ValueChanged
        If cbSubGrupo.SelectedIndex < 0 And cbSubGrupo.Text <> String.Empty Then
            btSubGrupo.Visible = True
        Else
            btSubGrupo.Visible = False
        End If
    End Sub

    Private Sub btUnidad_Click(sender As Object, e As EventArgs) Handles btUnidad.Click
        Dim numi As String = ""

        If L_prLibreriaGrabar(numi, "20", "3", cbUnidad.Text, "") Then
            _prCargarComboLibreria(cbUnidad, "20", "3")
            cbUnidad.SelectedIndex = CType(cbUnidad.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btGrupo_Click(sender As Object, e As EventArgs) Handles btGrupo.Click
        Dim numi As String = ""
        If L_prLibreriaGrabar(numi, "20", "1", cbGrupo.Text, "") Then
            _prCargarComboLibreria(cbGrupo, "20", "1")
            cbGrupo.SelectedIndex = CType(cbGrupo.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btSubGrupo_Click(sender As Object, e As EventArgs) Handles btSubGrupo.Click
        Dim numi As String = ""
        If L_prLibreriaGrabar(numi, "20", "2", cbSubGrupo.Text, "") Then
            _prCargarComboLibreria(cbSubGrupo, "20", "2")
            cbSubGrupo.SelectedIndex = CType(cbSubGrupo.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub cbMateriaUnidad_ValueChanged(sender As Object, e As EventArgs) Handles cbMateriaUnidad.ValueChanged
        If cbMateriaUnidad.SelectedIndex < 0 And cbMateriaUnidad.Text <> String.Empty Then
            btMateriaUnidad.Visible = True
        Else
            btMateriaUnidad.Visible = False
        End If
    End Sub

    Private Sub btMateriaUnidad_Click(sender As Object, e As EventArgs) Handles btMateriaUnidad.Click
        Dim numi As String = ""

        If L_prLibreriaGrabar(numi, "20", "3", cbMateriaUnidad.Text, "") Then
            _prCargarComboLibreria(cbMateriaUnidad, "20", "3")
            cbMateriaUnidad.SelectedIndex = CType(cbMateriaUnidad.DataSource, DataTable).Rows.Count - 1


        End If
    End Sub

    Private Sub cbEmpaqueUnidad_ValueChanged(sender As Object, e As EventArgs) Handles cbEmpaqueUnidad.ValueChanged
        If cbEmpaqueUnidad.SelectedIndex < 0 And cbEmpaqueUnidad.Text <> String.Empty Then
            btnEmpaqueUnidad.Visible = True
        Else
            btnEmpaqueUnidad.Visible = False
        End If
    End Sub

    Private Sub btnEmpaqueUnidad_Click(sender As Object, e As EventArgs) Handles btnEmpaqueUnidad.Click
        Dim numi As String = ""

        If L_prLibreriaGrabar(numi, "20", "3", cbEmpaqueUnidad.Text, "") Then
            _prCargarComboLibreria(cbEmpaqueUnidad, "20", "3")
            cbEmpaqueUnidad.SelectedIndex = CType(cbEmpaqueUnidad.DataSource, DataTable).Rows.Count - 1


        End If
    End Sub

    Private Sub btnfisicaAgregar_Click(sender As Object, e As EventArgs) Handles btnfisicaAgregar.Click
        _prAddDetalleVentaCaracteristicaFisica()
    End Sub
    Private Sub _prAddDetalleVentaCaracteristicaFisica()
        '    Select Case a.Id ,a.ProductoId ,a.Atributo ,a.Descripcion ,1 As estado
        'From ProductoCaracteristicaCalidad As a
        If (tbFisicaCaracteristica.Text <> "" And tbFisicaValor.Text <> "") Then


            CType(grCaracterisiticaFisicas.DataSource, DataTable).Rows.Add(_fnSiguienteNumi(grCaracterisiticaFisicas) + 1, 0, tbFisicaCaracteristica.Text, tbFisicaValor.Text, 0)
            tbFisicaCaracteristica.Clear()
            tbFisicaValor.Clear()
            tbFisicaCaracteristica.Focus()

        Else
            ToastNotification.Show(Me, "Rellenar todos los campos de Caracteristica Fisica..!!!",
                                    My.Resources.WARNING, 2000,
                                    eToastGlowColor.Red,
                                    eToastPosition.BottomLeft)
        End If

    End Sub

    Private Sub btnCalidadAgregar_Click(sender As Object, e As EventArgs) Handles btnCalidadAgregar.Click
        If (tbCalidadAtributo.Text <> "" And tbCalidadDescripcion.Text <> "") Then




            CType(grCaracteristicaCalidad.DataSource, DataTable).Rows.Add(_fnSiguienteNumi(grCaracteristicaCalidad) + 1, 0, tbCalidadAtributo.Text, tbCalidadDescripcion.Text, 0)
            tbCalidadAtributo.Clear()
            tbCalidadDescripcion.Clear()
            tbCalidadAtributo.Focus()

        Else
            ToastNotification.Show(Me, "Rellenar todos los campos de Caracteristica Calidad..!!!",
                                    My.Resources.WARNING, 2000,
                                    eToastGlowColor.Red,
                                    eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub btMateriaAgregar_Click(sender As Object, e As EventArgs) Handles btMateriaAgregar.Click
        If (tbMateriaCantidad.Text <> "" And cbMateriaUnidad.Value > 0) Then


            'a.Id , a.ProductoId, a.Cantidad, a.Unidad, uni.ycdes3 As UnidadDescripcion , 1 as estado

            CType(grDosificacion.DataSource, DataTable).Rows.Add(_fnSiguienteNumi(grDosificacion) + 1, 0, tbMateriaCantidad.Text, cbMateriaUnidad.Value, cbMateriaUnidad.Text, 0)
            tbMateriaCantidad.Clear()
            tbMateriaCantidad.Focus()

        Else
            ToastNotification.Show(Me, "Rellenar todos los campos de Dosificacion Materia..!!!",
                                    My.Resources.WARNING, 2000,
                                    eToastGlowColor.Red,
                                    eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub btnEmpaqueAgregar_Click(sender As Object, e As EventArgs) Handles btnEmpaqueAgregar.Click
        If (tbEmpaqueMedida.Text <> "" And cbEmpaqueUnidad.Value > 0) Then


            'a.Id , a.ProductoId, a.Cantidad, a.Unidad, uni.ycdes3 As UnidadDescripcion , 1 as estado

            CType(grEmpaque.DataSource, DataTable).Rows.Add(_fnSiguienteNumi(grEmpaque) + 1, 0, tbEmpaqueMedida.Text, cbEmpaqueUnidad.Value, cbEmpaqueUnidad.Text, 0)

            tbEmpaqueMedida.Clear()
            tbEmpaqueMedida.Focus()

        Else
            ToastNotification.Show(Me, "Rellenar todos los campos de Dosificacion Materia..!!!",
                                    My.Resources.WARNING, 2000,
                                    eToastGlowColor.Red,
                                    eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub btnMaquinariaAgregar_Click(sender As Object, e As EventArgs) Handles btnMaquinariaAgregar.Click
        If (tbMaquinariaMedida.Text <> "") Then


            'a.Id , a.ProductoId, a.Cantidad, a.Unidad, uni.ycdes3 As UnidadDescripcion , 1 as estado

            CType(grMaquinaria.DataSource, DataTable).Rows.Add(_fnSiguienteNumi(grMaquinaria) + 1, 0, tbMaquinariaMedida.Text, 0)

            tbMaquinariaMedida.Clear()
            tbMaquinariaMedida.Focus()

        Else
            ToastNotification.Show(Me, "Rellenar todos los campos de Dosificacion Materia..!!!",
                                    My.Resources.WARNING, 2000,
                                    eToastGlowColor.Red,
                                    eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub btnMoldeAgregar_Click(sender As Object, e As EventArgs) Handles btnMoldeAgregar.Click
        If (tbMoldeCodigo.Text <> "") Then


            'a.Id , a.ProductoId, a.Cantidad, a.Unidad, uni.ycdes3 As UnidadDescripcion , 1 as estado

            CType(grMolde.DataSource, DataTable).Rows.Add(_fnSiguienteNumi(grMolde) + 1, 0, tbMoldeCodigo.Text, 0)
            tbMoldeCodigo.Clear()
        Else
            ToastNotification.Show(Me, "Rellenar todos los campos de Dosificacion Materia..!!!",
                                    My.Resources.WARNING, 2000,
                                    eToastGlowColor.Red,
                                    eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub btnHerramentalAgregar_Click(sender As Object, e As EventArgs) Handles btnHerramentalAgregar.Click
        If (tbHerramentalCampo.Text <> "" And tbHerramentalCodigo.Text <> "") Then


            'a.Id , a.ProductoId, a.Cantidad, a.Unidad, uni.ycdes3 As UnidadDescripcion , 1 as estado

            CType(grHerramental.DataSource, DataTable).Rows.Add(_fnSiguienteNumi(grHerramental) + 1, 0, tbHerramentalCampo.Text, tbHerramentalCodigo.Text, 0)

            tbHerramentalCampo.Clear()
            tbHerramentalCodigo.Clear()


        Else
            ToastNotification.Show(Me, "Rellenar todos los campos de Dosificacion Materia..!!!",
                                    My.Resources.WARNING, 2000,
                                    eToastGlowColor.Red,
                                    eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub BtAdicionar_Click(sender As Object, e As EventArgs) Handles BtAdicionar.Click
        _fnCopiarImagenRutaDefinida()
    End Sub
    Private Function _fnCopiarImagenRutaDefinida() As String
        'copio la imagen en la carpeta del sistema

        Dim file As New OpenFileDialog()
        file.Filter = "Ficheros JPG o JPEG o PNG|*.jpg;*.jpeg;*.png" &
                      "|Ficheros GIF|*.gif" &
                      "|Ficheros BMP|*.bmp" &
                      "|Ficheros PNG|*.png" &
                      "|Ficheros TIFF|*.tif"
        If file.ShowDialog() = DialogResult.OK Then
            Dim ruta As String = file.FileName


            If file.CheckFileExists = True Then
                Dim img As New Bitmap(New Bitmap(ruta))
                Dim imgM As New Bitmap(New Bitmap(ruta))
                Dim Bin As New MemoryStream
                imgM.Save(Bin, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim a As Object = file.GetType.ToString
                If (tbId.Text = "") Then

                    Dim mayor As Integer
                    mayor = grCompra.GetTotal(grCompra.RootTable.Columns("Id"), AggregateFunction.Max)
                    nameImg = "\Imagen_" + Str(mayor + 1).Trim + ".jpg"
                    UsImg.pbImage.SizeMode = PictureBoxSizeMode.StretchImage
                    UsImg.pbImage.Image = Image.FromStream(Bin)

                    img.Save(RutaTemporal + nameImg, System.Drawing.Imaging.ImageFormat.Jpeg)
                    img.Dispose()
                Else

                    nameImg = "\Imagen_" + Str(tbCodigo.Text).Trim + ".jpg"


                    UsImg.pbImage.Image = Image.FromStream(Bin)
                    img.Save(RutaTemporal + nameImg, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Modificado = True
                    img.Dispose()

                End If
            End If

            Return nameImg
        End If

        Return "default.jpg"
    End Function

#End Region


End Class