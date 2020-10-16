Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.Controls
Public Class F0_ProductoMateriaPrima
#Region "Variables Locales"
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim RutaTemporal As String = "C:\Temporal"
    Dim Modificado As Boolean = False
    Dim nameImg As String = "Default.jpg"
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public Limpiar As Boolean = False  'Bandera para indicar si limpiar todos los datos o mantener datos ya registrados
    Dim _Inter As Integer = 0
#End Region
#Region "Metodos Privados"
    Private Sub _prIniciarTodo()
        Me.Text = "PRODUCTOS MATERIA PRIMA"
        _prMaxLength()
        _prCargarComboLibreria(cbgrupo1, 20, 1)
        _prCargarComboLibreria(cbgrupo2, 20, 2)
        _prCargarComboLibreria(cbgrupo3, 20, 3)
        _prAsignarPermisos()
        CargarGrillaProducto()
        Inhabilitar()
        Dim blah As New Bitmap(New Bitmap(My.Resources.producto), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico
    End Sub
    Private Sub CargarGrillaProducto()
        Dim dt As New DataTable
        dt = L_MostraProductosMateriaPrima()
        grProductos.DataSource = dt
        grProductos.RetrieveStructure()
        grProductos.AlternatingColors = True
        With grProductos.RootTable.Columns("Id")
            .Visible = False
        End With
        With grProductos.RootTable.Columns("Estado")
            .Caption = "Estado"
            .Width = 100
            .Visible = False
        End With
        With grProductos.RootTable.Columns("Descripcion")
            .Caption = "Descripcion"
            .Width = 450
            .Visible = True
        End With
        With grProductos.RootTable.Columns("Grupo1")
            .Visible = False
        End With
        With grProductos.RootTable.Columns("DescGrupo1")
            .Caption = "Grupo 1"
            .Width = 200
            .Visible = True
        End With
        With grProductos.RootTable.Columns("Grupo2")
            .Visible = False
        End With
        With grProductos.RootTable.Columns("DescGrupo2")
            .Caption = "Grupo 2"
            .Width = 200
            .Visible = True
        End With
        With grProductos.RootTable.Columns("Fecha")
            .Visible = False
        End With
        With grProductos.RootTable.Columns("Hora")
            .Visible = False
        End With
        With grProductos.RootTable.Columns("Usuario")
            .Visible = False
        End With
        With grProductos
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
        End With
    End Sub
    Private Sub CargarGrillaDetalle(IdProducto As Integer)
        Dim dt As New DataTable
        dt = L_MostraProductosMateriaPrimaDetalle(IdProducto)
        grdetalle.DataSource = dt
        grdetalle.RetrieveStructure()
        grdetalle.AlternatingColors = True

        With grdetalle.RootTable.Columns("Id")
            .Visible = False
        End With

        With grdetalle.RootTable.Columns("IdProductoMateriaPrima")
            .Visible = False
        End With
        With grdetalle.RootTable.Columns("Grupo3")
            .HeaderAlignment = TextAlignment.Center
            .Caption = "IdGrupo"
            .Width = 70
            .Visible = True
        End With
        With grdetalle.RootTable.Columns("DescGrupo3")
            .Caption = "Caracteristica"
            .HeaderAlignment = TextAlignment.Center
            .Width = 300
            .Visible = True
        End With
        With grdetalle.RootTable.Columns("Valor")
            .Caption = "Valor"
            .HeaderAlignment = TextAlignment.Center
            .Width = 400
            .Visible = True
        End With
        With grdetalle
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Public Sub _prMaxLength()
        cbgrupo1.MaxLength = 40
        cbgrupo2.MaxLength = 40
        cbgrupo3.MaxLength = 40
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
    Private Sub agregarFilaDetalle()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)

        CType(grdetalle.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, 0, cbgrupo3.Value, cbgrupo3.Text, tbValor.Text)
    End Sub
    Public Function _fnSiguienteNumi()
        Dim dt As DataTable = CType(grdetalle.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("Id=MAX(Id)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("Id")
        End If
        Return 1
    End Function
#End Region
    Public Function ValidarIngresoADetalle()
        If grdetalle.RowCount = 0 Then
            Return True
        End If
        Dim tProducto As DataTable = CType(grdetalle.DataSource, DataTable)
        For Each fila As DataRow In tProducto.Rows
            If cbgrupo3.Value = fila("Grupo3") Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Sub _prFiltrar()
        Dim _Mpos As Integer
        CargarGrillaProducto()
        If grProductos.RowCount > 0 Then
            _Mpos = 0
            grProductos.Row = _Mpos
        Else
            _LimpiarDatos()
            LblPaginacion.Text = "0/0"
        End If
    End Sub

#Region "METODOS SOBRECARGADOS"

    Public Sub Habilitar()
        tbDescPro.ReadOnly = False

        cbgrupo1.ReadOnly = False
        cbgrupo2.ReadOnly = False
        cbgrupo3.ReadOnly = False
        swEstado.IsReadOnly = False
        BtnAdicionar.Enabled = True
        tbValor.ReadOnly = False
        btnImprimir.Visible = False
        grdetalle.Enabled = True
    End Sub

    Public Sub Inhabilitar()
        tbCodigo.ReadOnly = True
        tbDescPro.ReadOnly = True
        cbgrupo1.ReadOnly = True
        cbgrupo2.ReadOnly = True
        cbgrupo3.ReadOnly = True
        swEstado.IsReadOnly = True
        BtnAdicionar.Enabled = False
        tbValor.ReadOnly = True
        btnImprimir.Visible = True
        grdetalle.Enabled = False
    End Sub
    Public Sub habilitarMenu()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGrabar.Enabled = True
        btnEliminar.Enabled = False
    End Sub
    Public Sub inHabilitarMenu()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGrabar.Enabled = False
        btnEliminar.Enabled = True
    End Sub
    Public Sub _LimpiarDatos()
        Try
            tbCodigo.Clear()
            tbDescPro.Clear()
            tbValor.Clear()
            If (Limpiar = False) Then
                _prSeleccionarCombo(cbgrupo1)
                _prSeleccionarCombo(cbgrupo2)
                _prSeleccionarCombo(cbgrupo3)
                swEstado.Value = True
            End If
            'ADD
            CargarGrillaDetalle(0)
            LimpiarErrores()
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub


    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               5000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)

    End Sub
    Private Sub MostrarMensajeOk(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.OK,
                               5000,
                               eToastGlowColor.Green,
                               eToastPosition.TopCenter)
    End Sub
    Private Sub MostrarMensajeExito(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.checked,
                               5000,
                               eToastGlowColor.Green,
                               eToastPosition.TopCenter)
    End Sub
    Public Sub _prSeleccionarCombo(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        If (CType(mCombo.DataSource, DataTable).Rows.Count > 0) Then
            mCombo.SelectedIndex = 0
        Else
            mCombo.SelectedIndex = -1
        End If
    End Sub


    Public Sub LimpiarErrores()
        MEP.Clear()
        tbDescPro.BackColor = Color.White
        cbgrupo1.BackColor = Color.White
        cbgrupo2.BackColor = Color.White
        cbgrupo3.BackColor = Color.White
        tbValor.BackColor = Color.White
    End Sub

    Public Sub _PMOGrabarRegistro()
        Dim resultado As Boolean = False
        Try

            Dim nuevo, modificar As Integer
            nuevo = 1
            modificar = 2
            Dim id As Integer = IIf(tbCodigo.Text = String.Empty, 0, tbCodigo.Text)
            'Se define el tipo de evento 
            Dim tipoEvento As Integer = IIf(id = 0, nuevo, modificar)

            Using ts As New Transactions.TransactionScope

                resultado = L_GuardarProductosMateriaPrima(id, IIf(swEstado.Value = 0, 1, 2), tbDescPro.Text, cbgrupo1.Value,
                                               cbgrupo2.Value, CType(grdetalle.DataSource, DataTable), tipoEvento)
                ts.Complete()
            End Using
            If resultado Then
                Dim mensaje = "Código de Materia Prima ".ToUpper + id.ToString() + IIf(tipoEvento = 1, " GRABADO", " MODIFICADO") + " con Exito.".ToUpper
                MostrarMensajeOk(mensaje)
                _prFiltrar()
                If tipoEvento = nuevo Then
                    Limpiar = True
                    _LimpiarDatos()
                    habilitarMenu()
                Else
                    Inhabilitar()
                    inHabilitarMenu()
                    _prCargarComboLibreria(cbgrupo3, 20, 3)
                End If
            Else
                Throw New Exception("Ocurrio un error inesperado, no se Grabo el registro")
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Function quitarUltimaFilaVacia(tabla As DataTable) As DataTable
        If tabla.Rows.Count > 0 Then
            If (tabla.Rows(tabla.Rows.Count - 1).Item("DescGrupo3").ToString() = String.Empty) Then
                tabla.Rows.RemoveAt(tabla.Rows.Count - 1)
                tabla.AcceptChanges()
            End If
        End If
        Return tabla
    End Function

    Public Function _fnActionNuevo() As Boolean
        Return tbCodigo.Text = String.Empty And tbDescPro.ReadOnly = False
    End Function

    Public Sub _PMOEliminarRegistro()
        Try
            Dim ef = New Efecto
            ef.tipo = 2
            ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
            ef.Header = "mensaje principal".ToUpper
            ef.ShowDialog()
            Dim bandera As Boolean = False
            bandera = ef.band
            If (bandera = True) Then
                Dim mensajeError As String = ""

                Dim res As Boolean = False
                Using ts As New Transactions.TransactionScope
                    res = L_EliminarProductosMateriaPrima(tbCodigo.Text, mensajeError)
                    ts.Complete()
                End Using
                If res Then
                    MostrarMensajeOk("Código de Producto ".ToUpper + tbCodigo.Text + " eliminado con Exito.".ToUpper)
                    _prFiltrar()
                Else
                    Throw New Exception(mensajeError)
                End If
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Function _PMOValidarCampos() As Boolean
        Dim _ok As Boolean = True
        MEP.Clear()
        If tbDescPro.Text = String.Empty Then
            tbDescPro.BackColor = Color.Red
            AddHandler tbDescPro.KeyDown, AddressOf TextBox_KeyDown
            MEP.SetError(tbDescPro, "ingrese el descripcion del producto!".ToUpper)
            _ok = False
        Else
            tbDescPro.BackColor = Color.White
            MEP.SetError(tbDescPro, "")
        End If

        If cbgrupo1.SelectedIndex < 0 Then
            cbgrupo1.BackColor = Color.Red
            MEP.SetError(cbgrupo1, "Selecciones grupo del producto!".ToUpper)
            _ok = False
        Else
            cbgrupo1.BackColor = Color.White
            MEP.SetError(cbgrupo1, "")
        End If

        If cbgrupo2.SelectedIndex < 0 Then
            cbgrupo2.BackColor = Color.Red
            MEP.SetError(cbgrupo2, "Selecciones grupo del producto!".ToUpper)
            _ok = False
        Else
            cbgrupo2.BackColor = Color.White
            MEP.SetError(cbgrupo2, "")
        End If

        If grdetalle.RowCount = 0 Then
            MEP.SetError(cbgrupo3, "Selecciones ingresar una caracteristica en el detalle!".ToUpper)
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function

    Public Sub _PMOMostrarRegistro()
        With grProductos
            tbCodigo.Text = .GetValue("Id").ToString
            tbDescPro.Text = .GetValue("Descripcion").ToString
            cbgrupo1.Value = .GetValue("Grupo1")
            cbgrupo2.Value = .GetValue("Grupo2")
            swEstado.Value = .GetValue("Estado")
            lbFecha.Text = CType(.GetValue("Fecha"), Date).ToString("dd/MM/yyyy")
            lbHora.Text = .GetValue("Hora").ToString
            lbUsuario.Text = .GetValue("Usuario").ToString
            CargarGrillaDetalle(tbCodigo.Text)
        End With
        LblPaginacion.Text = Str(grProductos.Row + 1) + "/" + grProductos.RowCount.ToString
    End Sub

#End Region
#Region "Eventos"
    Private Sub F0_ProductoMateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub cbgrupo3_ValueChanged(sender As Object, e As EventArgs) Handles cbgrupo3.ValueChanged
        If cbgrupo3.SelectedIndex < 0 And cbgrupo3.Text <> String.Empty Then
            btgrupo3.Visible = True
        Else
            btgrupo3.Visible = False
        End If
    End Sub

    Private Sub cbgrupo1_ValueChanged(sender As Object, e As EventArgs) Handles cbgrupo1.ValueChanged
        If cbgrupo1.SelectedIndex < 0 And cbgrupo1.Text <> String.Empty Then
            btgrupo1.Visible = True
        Else
            btgrupo1.Visible = False
        End If
    End Sub

    Private Sub cbgrupo2_ValueChanged(sender As Object, e As EventArgs) Handles cbgrupo2.ValueChanged
        If cbgrupo2.SelectedIndex < 0 And cbgrupo2.Text <> String.Empty Then
            btgrupo2.Visible = True
        Else
            btgrupo2.Visible = False
        End If
    End Sub


    Private Sub btgrupo3_Click(sender As Object, e As EventArgs) Handles btgrupo3.Click
        Dim numi As String = ""

        If L_prLibreriaGrabar(numi, "20", "3", cbgrupo3.Text, "") Then
            _prCargarComboLibreria(cbgrupo3, "20", "3")
            cbgrupo3.SelectedIndex = CType(cbgrupo3.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btgrupo1_Click(sender As Object, e As EventArgs) Handles btgrupo1.Click
        Dim numi As String = ""

        If L_prLibreriaGrabar(numi, "20", "1", cbgrupo1.Text, "") Then
            _prCargarComboLibreria(cbgrupo1, "20", "1")
            cbgrupo1.SelectedIndex = CType(cbgrupo1.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btgrupo2_Click(sender As Object, e As EventArgs) Handles btgrupo2.Click
        Dim numi As String = ""

        If L_prLibreriaGrabar(numi, "20", "2", cbgrupo2.Text, "") Then
            _prCargarComboLibreria(cbgrupo2, "20", "2")
            cbgrupo2.SelectedIndex = CType(cbgrupo2.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub grProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles grProductos.KeyDown
        'Try
        '    If e.KeyData = Keys.Escape Then
        '        grdetalle.CurrentRow.EndEdit()
        '        grdetalle.CurrentRow.Delete()
        '        grdetalle.Refetch()
        '        grdetalle.Refresh()
        '        grdetalle.UpdateData()
        '        Dim dtt As DataTable = CType(grdetalle.DataSource, DataTable)
        '        dtt.AcceptChanges()
        '        CType(grdetalle.DataSource, DataTable).Equals(dtt)
        '    End If
        'Catch ex As Exception
        '    MostrarMensajeError(ex.Message)
        'End Try
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        Dim tb As TextBoxX = CType(sender, TextBoxX)
        If tb.Text = String.Empty Then

        Else
            tb.BackColor = Color.White
            MEP.SetError(tb, "")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If btnGrabar.Enabled = True Then
            _prFiltrar()
            Inhabilitar()
            inHabilitarMenu()
        Else
            Me.Close()
        End If
    End Sub


    Private Sub grdetalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles grdetalle.EditingCell
        If (e.Column.Index = grdetalle.RootTable.Columns("DescGrupo3").Index Or
            e.Column.Index = grdetalle.RootTable.Columns("Valor").Index) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub grdetalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles grdetalle.CellEdited
        'If (e.Column.Index = grdetalle.RootTable.Columns("DescGrupo3").Index) Then
        '    If (grdetalle.GetValue("DescGrupo3").ToString.Length > 30) Then
        '        ToastNotification.Show(Me, "La descripción no tiene que ser mayor a 100 caracteres".ToUpper,
        '                              My.Resources.WARNING, 2000,
        '                              eToastGlowColor.Red,
        '                              eToastPosition.TopCenter
        '                              )
        '        grdetalle.SetValue("DescGrupo3", grdetalle.GetValue("DescGrupo3").ToString.Substring(0, 30))
        '        grdetalle.DataChanged = True
        '    End If
        '    ''Si el la ultima fila, agregar una fila nueva
        '    'If (grdetalle.Row = grdetalle.RowCount - 1) Then
        '    '    adicionarFilaDetalleProducto()
        '    'End If
        'End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Inter = _Inter + 1
        If _Inter = 1 Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        Try
            If ValidarIngresoADetalle() Then
                If tbValor.Text = String.Empty Then
                    Throw New Exception("Debe introducir un valor")
                End If
                agregarFilaDetalle()
            Else
                Throw New Exception("Ya existe el grupo introducido")
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        Dim _MPos As Integer
        If grProductos.RowCount > 0 Then
            _MPos = 0
            grProductos.Row = _MPos
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim _MPos As Integer = grProductos.Row
        If _MPos > 0 And grProductos.RowCount > 0 Then
            _MPos = _MPos - 1
            grProductos.Row = _MPos
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim _pos As Integer = grProductos.Row
        If _pos < grProductos.RowCount - 1 And _pos >= 0 Then
            _pos = grProductos.Row + 1
            grProductos.Row = _pos
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Dim _pos As Integer = grProductos.Row
        If grProductos.RowCount > 0 Then
            _pos = grProductos.RowCount - 1
            grProductos.Row = _pos
        End If
    End Sub

    Private Sub tsmiEliminarFilaDetalle_Click(sender As Object, e As EventArgs) Handles tsmiEliminarFilaDetalle.Click
        Try
            grdetalle.CurrentRow.EndEdit()
            grdetalle.CurrentRow.Delete()
            grdetalle.Refetch()
            grdetalle.Refresh()
            grdetalle.UpdateData()
            Dim dtt As DataTable = CType(grdetalle.DataSource, DataTable)
            dtt.AcceptChanges()
            CType(grdetalle.DataSource, DataTable).Equals(dtt)
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub grProductos_SelectionChanged(sender As Object, e As EventArgs) Handles grProductos.SelectionChanged
        If (grProductos.RowCount >= 0 And grProductos.Row >= 0) Then
            _PMOMostrarRegistro()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _LimpiarDatos()
        Habilitar()
        habilitarMenu()
        tbDescPro.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Habilitar()
        habilitarMenu()
        tbDescPro.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        _PMOEliminarRegistro()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If _PMOValidarCampos() Then
            _PMOGrabarRegistro()
        End If
    End Sub

    Private Sub grProductos_EditingCell(sender As Object, e As EditingCellEventArgs) Handles grProductos.EditingCell
        e.Cancel = True
    End Sub

    Private Sub grdetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles grdetalle.KeyDown
        Try
            If e.KeyData = Keys.Escape Then
                grdetalle.CurrentRow.EndEdit()
                grdetalle.CurrentRow.Delete()
                grdetalle.Refetch()
                grdetalle.Refresh()
                grdetalle.UpdateData()
                Dim dtt As DataTable = CType(grdetalle.DataSource, DataTable)
                dtt.AcceptChanges()
                CType(grdetalle.DataSource, DataTable).Equals(dtt)
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub lbgrupo3_Click(sender As Object, e As EventArgs) Handles lbgrupo3.Click

    End Sub

    Private Sub btnMaquinariaAgregar_Click(sender As Object, e As EventArgs) Handles btnMaquinariaAgregar.Click
        Try
            If ValidarIngresoADetalle() Then
                If tbValor.Text = String.Empty Then
                    Throw New Exception("Debe introducir un valor")
                End If
                agregarFilaDetalle()
            Else
                Throw New Exception("Ya existe el grupo introducido")
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
#End Region
End Class