<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_ClientesEmpresas
    Inherits Modelo.ModeloF1

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_ClientesEmpresas))
        Dim cbCiudad_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbDepartamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbTipoVenta_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbCondicionesEntrega_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbActividadComercial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbNit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.tbPaginaWeb = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.btnCiudad = New DevComponents.DotNetBar.ButtonX()
        Me.cbCiudad = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.btnDepartamento = New DevComponents.DotNetBar.ButtonX()
        Me.cbDepartamento = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.tbNombreEmpresa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbTelefono01 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tbDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.tbCodigoOriginal = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.Gmc_Cliente = New GMap.NET.WindowsForms.GMapControl()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.cbTipoVenta = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.tbLimiteCredito = New DevComponents.Editors.DoubleInput()
        Me.tbItemsHabilitados = New DevComponents.Editors.IntegerInput()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.tbTiempoCredito = New DevComponents.Editors.IntegerInput()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.btnCondicionesEntrega = New DevComponents.DotNetBar.ButtonX()
        Me.cbCondicionesEntrega = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.btnActividadComercial = New DevComponents.DotNetBar.ButtonX()
        Me.cbActividadComercial = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.tbTelefonoCelular = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.tbNombreContacto02 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.tbTelefono02 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.tbNombreContacto01 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.tbHorarioAtencion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabPrincipal.SuspendLayout()
        Me.SuperTabControlPanelRegistro.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.MPanelSup.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.GroupPanelBuscador.SuspendLayout()
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cbCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.cbTipoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLimiteCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItemsHabilitados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTiempoCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCondicionesEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbActividadComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.MenuBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabPrincipal.ControlBox.MenuBox, Me.SuperTabPrincipal.ControlBox.CloseBox})
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelBuscador, 0)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelRegistro, 0)
        '
        'SuperTabControlPanelBuscador
        '
        Me.SuperTabControlPanelBuscador.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanelBuscador.Size = New System.Drawing.Size(1765, 897)
        '
        'SuperTabControlPanelRegistro
        '
        Me.SuperTabControlPanelRegistro.Size = New System.Drawing.Size(1765, 897)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(1765, 89)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        '
        'PanelInferior
        '
        Me.PanelInferior.Size = New System.Drawing.Size(1765, 44)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        '
        'BubbleBarUsuario
        '
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'btnSalir
        '
        '
        'btnGrabar
        '
        '
        'btnEliminar
        '
        '
        'btnNuevo
        '
        '
        'PanelToolBar2
        '
        Me.PanelToolBar2.Location = New System.Drawing.Point(1658, 0)
        '
        'MPanelSup
        '
        Me.MPanelSup.Controls.Add(Me.TableLayoutPanel1)
        Me.MPanelSup.Size = New System.Drawing.Size(1765, 420)
        Me.MPanelSup.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Size = New System.Drawing.Size(1765, 764)
        '
        'GroupPanelBuscador
        '
        Me.GroupPanelBuscador.Location = New System.Drawing.Point(0, 420)
        Me.GroupPanelBuscador.Size = New System.Drawing.Size(1765, 344)
        '
        '
        '
        Me.GroupPanelBuscador.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColorGradientAngle = 90
        Me.GroupPanelBuscador.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderBottomWidth = 1
        Me.GroupPanelBuscador.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderLeftWidth = 1
        Me.GroupPanelBuscador.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderRightWidth = 1
        Me.GroupPanelBuscador.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderTopWidth = 1
        Me.GroupPanelBuscador.Style.CornerDiameter = 4
        Me.GroupPanelBuscador.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelBuscador.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelBuscador.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelBuscador.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanelBuscador.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'JGrM_Buscador
        '
        Me.JGrM_Buscador.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.JGrM_Buscador.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGrM_Buscador.Size = New System.Drawing.Size(1759, 317)
        '
        'btnImprimir
        '
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(1498, 0)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 420.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1765, 420)
        Me.TableLayoutPanel1.TabIndex = 236
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupPanel1.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(580, 412)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 227
        Me.GroupPanel1.Text = "DATOS GENERALES"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.tbNit)
        Me.Panel1.Controls.Add(Me.LabelX15)
        Me.Panel1.Controls.Add(Me.tbPaginaWeb)
        Me.Panel1.Controls.Add(Me.LabelX6)
        Me.Panel1.Controls.Add(Me.LabelX10)
        Me.Panel1.Controls.Add(Me.btnCiudad)
        Me.Panel1.Controls.Add(Me.cbCiudad)
        Me.Panel1.Controls.Add(Me.LabelX2)
        Me.Panel1.Controls.Add(Me.btnDepartamento)
        Me.Panel1.Controls.Add(Me.cbDepartamento)
        Me.Panel1.Controls.Add(Me.LabelX19)
        Me.Panel1.Controls.Add(Me.tbNombreEmpresa)
        Me.Panel1.Controls.Add(Me.tbEmail)
        Me.Panel1.Controls.Add(Me.tbTelefono01)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Controls.Add(Me.tbDireccion)
        Me.Panel1.Controls.Add(Me.LabelX3)
        Me.Panel1.Controls.Add(Me.LabelX5)
        Me.Panel1.Controls.Add(Me.LabelX4)
        Me.Panel1.Controls.Add(Me.tbCodigoOriginal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 385)
        Me.Panel1.TabIndex = 234
        '
        'tbNit
        '
        '
        '
        '
        Me.tbNit.Border.Class = "TextBoxBorder"
        Me.tbNit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbNit.Location = New System.Drawing.Point(225, 317)
        Me.tbNit.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNit.MaxLength = 50
        Me.tbNit.Name = "tbNit"
        Me.tbNit.PreventEnterBeep = True
        Me.tbNit.Size = New System.Drawing.Size(287, 26)
        Me.tbNit.TabIndex = 8
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX15.Location = New System.Drawing.Point(17, 317)
        Me.LabelX15.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX15.Size = New System.Drawing.Size(151, 28)
        Me.LabelX15.TabIndex = 248
        Me.LabelX15.Text = "Nit:"
        '
        'tbPaginaWeb
        '
        '
        '
        '
        Me.tbPaginaWeb.Border.Class = "TextBoxBorder"
        Me.tbPaginaWeb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbPaginaWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPaginaWeb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbPaginaWeb.Location = New System.Drawing.Point(225, 283)
        Me.tbPaginaWeb.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPaginaWeb.MaxLength = 50
        Me.tbPaginaWeb.Name = "tbPaginaWeb"
        Me.tbPaginaWeb.PreventEnterBeep = True
        Me.tbPaginaWeb.Size = New System.Drawing.Size(287, 26)
        Me.tbPaginaWeb.TabIndex = 7
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX6.Location = New System.Drawing.Point(17, 283)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX6.Size = New System.Drawing.Size(151, 28)
        Me.LabelX6.TabIndex = 246
        Me.LabelX6.Text = "Pagina Web:"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX10.Location = New System.Drawing.Point(17, 179)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX10.Size = New System.Drawing.Size(155, 28)
        Me.LabelX10.TabIndex = 243
        Me.LabelX10.Text = "Ciudad:"
        '
        'btnCiudad
        '
        Me.btnCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCiudad.BackColor = System.Drawing.Color.Transparent
        Me.btnCiudad.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnCiudad.Image = Global.DinoM.My.Resources.Resources.add
        Me.btnCiudad.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btnCiudad.Location = New System.Drawing.Point(519, 181)
        Me.btnCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(37, 28)
        Me.btnCiudad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCiudad.TabIndex = 244
        Me.btnCiudad.Visible = False
        '
        'cbCiudad
        '
        cbCiudad_DesignTimeLayout.LayoutString = resources.GetString("cbCiudad_DesignTimeLayout.LayoutString")
        Me.cbCiudad.DesignTimeLayout = cbCiudad_DesignTimeLayout
        Me.cbCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCiudad.Location = New System.Drawing.Point(225, 181)
        Me.cbCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCiudad.Name = "cbCiudad"
        Me.cbCiudad.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbCiudad.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbCiudad.SelectedIndex = -1
        Me.cbCiudad.SelectedItem = Nothing
        Me.cbCiudad.Size = New System.Drawing.Size(270, 26)
        Me.cbCiudad.TabIndex = 4
        Me.cbCiudad.TabStop = False
        Me.cbCiudad.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(17, 145)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(155, 28)
        Me.LabelX2.TabIndex = 240
        Me.LabelX2.Text = "Departamento:"
        '
        'btnDepartamento
        '
        Me.btnDepartamento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDepartamento.BackColor = System.Drawing.Color.Transparent
        Me.btnDepartamento.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnDepartamento.Image = Global.DinoM.My.Resources.Resources.add
        Me.btnDepartamento.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btnDepartamento.Location = New System.Drawing.Point(519, 147)
        Me.btnDepartamento.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDepartamento.Name = "btnDepartamento"
        Me.btnDepartamento.Size = New System.Drawing.Size(37, 28)
        Me.btnDepartamento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDepartamento.TabIndex = 241
        Me.btnDepartamento.Visible = False
        '
        'cbDepartamento
        '
        cbDepartamento_DesignTimeLayout.LayoutString = resources.GetString("cbDepartamento_DesignTimeLayout.LayoutString")
        Me.cbDepartamento.DesignTimeLayout = cbDepartamento_DesignTimeLayout
        Me.cbDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamento.Location = New System.Drawing.Point(225, 147)
        Me.cbDepartamento.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbDepartamento.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbDepartamento.SelectedIndex = -1
        Me.cbDepartamento.SelectedItem = Nothing
        Me.cbDepartamento.Size = New System.Drawing.Size(270, 26)
        Me.cbDepartamento.TabIndex = 3
        Me.cbDepartamento.TabStop = False
        Me.cbDepartamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX19.Location = New System.Drawing.Point(16, 45)
        Me.LabelX19.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX19.Size = New System.Drawing.Size(151, 28)
        Me.LabelX19.TabIndex = 238
        Me.LabelX19.Text = "Nombre Empresa:"
        '
        'tbNombreEmpresa
        '
        '
        '
        '
        Me.tbNombreEmpresa.Border.Class = "TextBoxBorder"
        Me.tbNombreEmpresa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNombreEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbNombreEmpresa.Location = New System.Drawing.Point(225, 45)
        Me.tbNombreEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNombreEmpresa.Name = "tbNombreEmpresa"
        Me.tbNombreEmpresa.PreventEnterBeep = True
        Me.tbNombreEmpresa.Size = New System.Drawing.Size(323, 26)
        Me.tbNombreEmpresa.TabIndex = 1
        '
        'tbEmail
        '
        '
        '
        '
        Me.tbEmail.Border.Class = "TextBoxBorder"
        Me.tbEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbEmail.Location = New System.Drawing.Point(225, 249)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.tbEmail.MaxLength = 50
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.PreventEnterBeep = True
        Me.tbEmail.Size = New System.Drawing.Size(287, 26)
        Me.tbEmail.TabIndex = 6
        '
        'tbTelefono01
        '
        '
        '
        '
        Me.tbTelefono01.Border.Class = "TextBoxBorder"
        Me.tbTelefono01.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTelefono01.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbTelefono01.Location = New System.Drawing.Point(225, 215)
        Me.tbTelefono01.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTelefono01.Name = "tbTelefono01"
        Me.tbTelefono01.PreventEnterBeep = True
        Me.tbTelefono01.Size = New System.Drawing.Size(287, 26)
        Me.tbTelefono01.TabIndex = 5
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(17, 12)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(129, 20)
        Me.LabelX1.TabIndex = 224
        Me.LabelX1.Text = "Código Original:"
        '
        'tbDireccion
        '
        '
        '
        '
        Me.tbDireccion.Border.Class = "TextBoxBorder"
        Me.tbDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbDireccion.Location = New System.Drawing.Point(225, 79)
        Me.tbDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDireccion.Multiline = True
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.PreventEnterBeep = True
        Me.tbDireccion.Size = New System.Drawing.Size(331, 60)
        Me.tbDireccion.TabIndex = 2
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(17, 76)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX3.Size = New System.Drawing.Size(197, 28)
        Me.LabelX3.TabIndex = 226
        Me.LabelX3.Text = "Direccion:"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(17, 249)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX5.Size = New System.Drawing.Size(151, 28)
        Me.LabelX5.TabIndex = 231
        Me.LabelX5.Text = "Email:"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(16, 215)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX4.Size = New System.Drawing.Size(151, 28)
        Me.LabelX4.TabIndex = 229
        Me.LabelX4.Text = "Telefono:"
        '
        'tbCodigoOriginal
        '
        '
        '
        '
        Me.tbCodigoOriginal.Border.Class = "TextBoxBorder"
        Me.tbCodigoOriginal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigoOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigoOriginal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCodigoOriginal.Location = New System.Drawing.Point(225, 11)
        Me.tbCodigoOriginal.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCodigoOriginal.Name = "tbCodigoOriginal"
        Me.tbCodigoOriginal.PreventEnterBeep = True
        Me.tbCodigoOriginal.Size = New System.Drawing.Size(84, 26)
        Me.tbCodigoOriginal.TabIndex = 0
        Me.tbCodigoOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.SuperTabControl1)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(1180, 4)
        Me.GroupPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(581, 412)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 229
        Me.GroupPanel3.Text = "INFORMACION ADICIONAL"
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.SelectedTabIndex = 2
        Me.SuperTabControl1.Size = New System.Drawing.Size(575, 385)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 223
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem2})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.ButtonX4)
        Me.SuperTabControlPanel2.Controls.Add(Me.ButtonX3)
        Me.SuperTabControlPanel2.Controls.Add(Me.Gmc_Cliente)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(575, 359)
        Me.SuperTabControlPanel2.TabIndex = 2
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Image = Global.DinoM.My.Resources.Resources.iconacercar
        Me.ButtonX4.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonX4.Location = New System.Drawing.Point(60, 304)
        Me.ButtonX4.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(40, 37)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 5
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.MHighlighterFocus.SetHighlightOnFocus(Me.ButtonX3, True)
        Me.ButtonX3.Image = Global.DinoM.My.Resources.Resources.iconalejar
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonX3.Location = New System.Drawing.Point(9, 304)
        Me.ButtonX3.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(40, 37)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 4
        '
        'Gmc_Cliente
        '
        Me.Gmc_Cliente.Bearing = 0!
        Me.Gmc_Cliente.CanDragMap = True
        Me.Gmc_Cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gmc_Cliente.EmptyTileColor = System.Drawing.Color.Navy
        Me.Gmc_Cliente.GrayScaleMode = False
        Me.Gmc_Cliente.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.Gmc_Cliente.LevelsKeepInMemmory = 5
        Me.Gmc_Cliente.Location = New System.Drawing.Point(0, 0)
        Me.Gmc_Cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.Gmc_Cliente.MarkersEnabled = True
        Me.Gmc_Cliente.MaxZoom = 2
        Me.Gmc_Cliente.MinZoom = 2
        Me.Gmc_Cliente.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.Gmc_Cliente.Name = "Gmc_Cliente"
        Me.Gmc_Cliente.NegativeMode = False
        Me.Gmc_Cliente.PolygonsEnabled = True
        Me.Gmc_Cliente.RetryLoadTile = 0
        Me.Gmc_Cliente.RoutesEnabled = True
        Me.Gmc_Cliente.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.Gmc_Cliente.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Gmc_Cliente.ShowTileGridLines = False
        Me.Gmc_Cliente.Size = New System.Drawing.Size(575, 359)
        Me.Gmc_Cliente.TabIndex = 0
        Me.Gmc_Cliente.Zoom = 0R
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Ubicacion"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Panel4)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(592, 4)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(580, 412)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedShadow
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 228
        Me.GroupPanel2.Text = "DATOS COMPLEMENTARIOS"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.LabelX20)
        Me.Panel4.Controls.Add(Me.cbTipoVenta)
        Me.Panel4.Controls.Add(Me.LabelX18)
        Me.Panel4.Controls.Add(Me.tbLimiteCredito)
        Me.Panel4.Controls.Add(Me.tbItemsHabilitados)
        Me.Panel4.Controls.Add(Me.LabelX17)
        Me.Panel4.Controls.Add(Me.tbTiempoCredito)
        Me.Panel4.Controls.Add(Me.LabelX16)
        Me.Panel4.Controls.Add(Me.LabelX14)
        Me.Panel4.Controls.Add(Me.btnCondicionesEntrega)
        Me.Panel4.Controls.Add(Me.cbCondicionesEntrega)
        Me.Panel4.Controls.Add(Me.LabelX13)
        Me.Panel4.Controls.Add(Me.btnActividadComercial)
        Me.Panel4.Controls.Add(Me.cbActividadComercial)
        Me.Panel4.Controls.Add(Me.LabelX11)
        Me.Panel4.Controls.Add(Me.tbTelefonoCelular)
        Me.Panel4.Controls.Add(Me.LabelX12)
        Me.Panel4.Controls.Add(Me.tbNombreContacto02)
        Me.Panel4.Controls.Add(Me.LabelX9)
        Me.Panel4.Controls.Add(Me.tbTelefono02)
        Me.Panel4.Controls.Add(Me.LabelX8)
        Me.Panel4.Controls.Add(Me.tbNombreContacto01)
        Me.Panel4.Controls.Add(Me.LabelX7)
        Me.Panel4.Controls.Add(Me.tbHorarioAtencion)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(574, 385)
        Me.Panel4.TabIndex = 216
        '
        'LabelX20
        '
        Me.LabelX20.AutoSize = True
        Me.LabelX20.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX20.Location = New System.Drawing.Point(14, 346)
        Me.LabelX20.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX20.Size = New System.Drawing.Size(155, 20)
        Me.LabelX20.TabIndex = 269
        Me.LabelX20.Text = "T.Venta Habilitado:"
        '
        'cbTipoVenta
        '
        Me.cbTipoVenta.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbTipoVenta_DesignTimeLayout.LayoutString = resources.GetString("cbTipoVenta_DesignTimeLayout.LayoutString")
        Me.cbTipoVenta.DesignTimeLayout = cbTipoVenta_DesignTimeLayout
        Me.cbTipoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoVenta.Location = New System.Drawing.Point(206, 342)
        Me.cbTipoVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTipoVenta.Name = "cbTipoVenta"
        Me.cbTipoVenta.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTipoVenta.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTipoVenta.SelectedIndex = -1
        Me.cbTipoVenta.SelectedItem = Nothing
        Me.cbTipoVenta.Size = New System.Drawing.Size(270, 26)
        Me.cbTipoVenta.TabIndex = 10
        Me.cbTipoVenta.TabStop = False
        Me.cbTipoVenta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX18
        '
        Me.LabelX18.AutoSize = True
        Me.LabelX18.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX18.Location = New System.Drawing.Point(14, 317)
        Me.LabelX18.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX18.Size = New System.Drawing.Size(120, 20)
        Me.LabelX18.TabIndex = 267
        Me.LabelX18.Text = "Limite Credito:"
        '
        'tbLimiteCredito
        '
        '
        '
        '
        Me.tbLimiteCredito.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbLimiteCredito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbLimiteCredito.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbLimiteCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLimiteCredito.Increment = 1.0R
        Me.tbLimiteCredito.Location = New System.Drawing.Point(206, 309)
        Me.tbLimiteCredito.Name = "tbLimiteCredito"
        Me.tbLimiteCredito.Size = New System.Drawing.Size(150, 24)
        Me.tbLimiteCredito.TabIndex = 9
        '
        'tbItemsHabilitados
        '
        '
        '
        '
        Me.tbItemsHabilitados.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbItemsHabilitados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbItemsHabilitados.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbItemsHabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbItemsHabilitados.Location = New System.Drawing.Point(206, 277)
        Me.tbItemsHabilitados.Name = "tbItemsHabilitados"
        Me.tbItemsHabilitados.Size = New System.Drawing.Size(150, 24)
        Me.tbItemsHabilitados.TabIndex = 8
        '
        'LabelX17
        '
        Me.LabelX17.AutoSize = True
        Me.LabelX17.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX17.Location = New System.Drawing.Point(14, 281)
        Me.LabelX17.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX17.Size = New System.Drawing.Size(138, 20)
        Me.LabelX17.TabIndex = 264
        Me.LabelX17.Text = "Items Habilitado:"
        '
        'tbTiempoCredito
        '
        '
        '
        '
        Me.tbTiempoCredito.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbTiempoCredito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTiempoCredito.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbTiempoCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTiempoCredito.Location = New System.Drawing.Point(206, 245)
        Me.tbTiempoCredito.Name = "tbTiempoCredito"
        Me.tbTiempoCredito.Size = New System.Drawing.Size(150, 24)
        Me.tbTiempoCredito.TabIndex = 7
        '
        'LabelX16
        '
        Me.LabelX16.AutoSize = True
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX16.Location = New System.Drawing.Point(14, 249)
        Me.LabelX16.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX16.Size = New System.Drawing.Size(128, 20)
        Me.LabelX16.TabIndex = 262
        Me.LabelX16.Text = "Tiempo Credito:"
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX14.Location = New System.Drawing.Point(14, 211)
        Me.LabelX14.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX14.Size = New System.Drawing.Size(118, 20)
        Me.LabelX14.TabIndex = 261
        Me.LabelX14.Text = "Cond. Entrega:"
        '
        'btnCondicionesEntrega
        '
        Me.btnCondicionesEntrega.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCondicionesEntrega.BackColor = System.Drawing.Color.Transparent
        Me.btnCondicionesEntrega.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnCondicionesEntrega.Image = Global.DinoM.My.Resources.Resources.add
        Me.btnCondicionesEntrega.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btnCondicionesEntrega.Location = New System.Drawing.Point(500, 207)
        Me.btnCondicionesEntrega.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCondicionesEntrega.Name = "btnCondicionesEntrega"
        Me.btnCondicionesEntrega.Size = New System.Drawing.Size(37, 28)
        Me.btnCondicionesEntrega.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCondicionesEntrega.TabIndex = 260
        Me.btnCondicionesEntrega.Visible = False
        '
        'cbCondicionesEntrega
        '
        cbCondicionesEntrega_DesignTimeLayout.LayoutString = resources.GetString("cbCondicionesEntrega_DesignTimeLayout.LayoutString")
        Me.cbCondicionesEntrega.DesignTimeLayout = cbCondicionesEntrega_DesignTimeLayout
        Me.cbCondicionesEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCondicionesEntrega.Location = New System.Drawing.Point(206, 207)
        Me.cbCondicionesEntrega.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCondicionesEntrega.Name = "cbCondicionesEntrega"
        Me.cbCondicionesEntrega.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbCondicionesEntrega.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbCondicionesEntrega.SelectedIndex = -1
        Me.cbCondicionesEntrega.SelectedItem = Nothing
        Me.cbCondicionesEntrega.Size = New System.Drawing.Size(270, 26)
        Me.cbCondicionesEntrega.TabIndex = 6
        Me.cbCondicionesEntrega.TabStop = False
        Me.cbCondicionesEntrega.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX13
        '
        Me.LabelX13.AutoSize = True
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX13.Location = New System.Drawing.Point(14, 8)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX13.Size = New System.Drawing.Size(121, 20)
        Me.LabelX13.TabIndex = 258
        Me.LabelX13.Text = "Act. Comercial:"
        '
        'btnActividadComercial
        '
        Me.btnActividadComercial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnActividadComercial.BackColor = System.Drawing.Color.Transparent
        Me.btnActividadComercial.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnActividadComercial.Image = Global.DinoM.My.Resources.Resources.add
        Me.btnActividadComercial.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btnActividadComercial.Location = New System.Drawing.Point(500, 4)
        Me.btnActividadComercial.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActividadComercial.Name = "btnActividadComercial"
        Me.btnActividadComercial.Size = New System.Drawing.Size(37, 28)
        Me.btnActividadComercial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnActividadComercial.TabIndex = 257
        Me.btnActividadComercial.Visible = False
        '
        'cbActividadComercial
        '
        cbActividadComercial_DesignTimeLayout.LayoutString = resources.GetString("cbActividadComercial_DesignTimeLayout.LayoutString")
        Me.cbActividadComercial.DesignTimeLayout = cbActividadComercial_DesignTimeLayout
        Me.cbActividadComercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActividadComercial.Location = New System.Drawing.Point(206, 4)
        Me.cbActividadComercial.Margin = New System.Windows.Forms.Padding(4)
        Me.cbActividadComercial.Name = "cbActividadComercial"
        Me.cbActividadComercial.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbActividadComercial.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbActividadComercial.SelectedIndex = -1
        Me.cbActividadComercial.SelectedItem = Nothing
        Me.cbActividadComercial.Size = New System.Drawing.Size(270, 26)
        Me.cbActividadComercial.TabIndex = 0
        Me.cbActividadComercial.TabStop = False
        Me.cbActividadComercial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX11.Location = New System.Drawing.Point(14, 178)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX11.Size = New System.Drawing.Size(136, 20)
        Me.LabelX11.TabIndex = 255
        Me.LabelX11.Text = "Telefono Celular:"
        '
        'tbTelefonoCelular
        '
        '
        '
        '
        Me.tbTelefonoCelular.Border.Class = "TextBoxBorder"
        Me.tbTelefonoCelular.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTelefonoCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefonoCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbTelefonoCelular.Location = New System.Drawing.Point(206, 173)
        Me.tbTelefonoCelular.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTelefonoCelular.MaxLength = 50
        Me.tbTelefonoCelular.Name = "tbTelefonoCelular"
        Me.tbTelefonoCelular.PreventEnterBeep = True
        Me.tbTelefonoCelular.Size = New System.Drawing.Size(287, 26)
        Me.tbTelefonoCelular.TabIndex = 5
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX12.Location = New System.Drawing.Point(14, 144)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX12.Size = New System.Drawing.Size(168, 20)
        Me.LabelX12.TabIndex = 253
        Me.LabelX12.Text = "Nombre Contacto 02:"
        '
        'tbNombreContacto02
        '
        '
        '
        '
        Me.tbNombreContacto02.Border.Class = "TextBoxBorder"
        Me.tbNombreContacto02.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNombreContacto02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreContacto02.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbNombreContacto02.Location = New System.Drawing.Point(206, 139)
        Me.tbNombreContacto02.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNombreContacto02.MaxLength = 50
        Me.tbNombreContacto02.Name = "tbNombreContacto02"
        Me.tbNombreContacto02.PreventEnterBeep = True
        Me.tbNombreContacto02.Size = New System.Drawing.Size(287, 26)
        Me.tbNombreContacto02.TabIndex = 4
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX9.Location = New System.Drawing.Point(14, 110)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX9.Size = New System.Drawing.Size(136, 20)
        Me.LabelX9.TabIndex = 251
        Me.LabelX9.Text = "Telefono Celular:"
        '
        'tbTelefono02
        '
        '
        '
        '
        Me.tbTelefono02.Border.Class = "TextBoxBorder"
        Me.tbTelefono02.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTelefono02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono02.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbTelefono02.Location = New System.Drawing.Point(206, 105)
        Me.tbTelefono02.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTelefono02.MaxLength = 50
        Me.tbTelefono02.Name = "tbTelefono02"
        Me.tbTelefono02.PreventEnterBeep = True
        Me.tbTelefono02.Size = New System.Drawing.Size(287, 26)
        Me.tbTelefono02.TabIndex = 3
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX8.Location = New System.Drawing.Point(14, 76)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX8.Size = New System.Drawing.Size(166, 20)
        Me.LabelX8.TabIndex = 249
        Me.LabelX8.Text = "Nombre Contacto 01:"
        '
        'tbNombreContacto01
        '
        '
        '
        '
        Me.tbNombreContacto01.Border.Class = "TextBoxBorder"
        Me.tbNombreContacto01.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNombreContacto01.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreContacto01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbNombreContacto01.Location = New System.Drawing.Point(206, 71)
        Me.tbNombreContacto01.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNombreContacto01.MaxLength = 50
        Me.tbNombreContacto01.Name = "tbNombreContacto01"
        Me.tbNombreContacto01.PreventEnterBeep = True
        Me.tbNombreContacto01.Size = New System.Drawing.Size(287, 26)
        Me.tbNombreContacto01.TabIndex = 2
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX7.Location = New System.Drawing.Point(14, 42)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX7.Size = New System.Drawing.Size(144, 20)
        Me.LabelX7.TabIndex = 247
        Me.LabelX7.Text = "Horario Atencion:"
        '
        'tbHorarioAtencion
        '
        '
        '
        '
        Me.tbHorarioAtencion.Border.Class = "TextBoxBorder"
        Me.tbHorarioAtencion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbHorarioAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHorarioAtencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbHorarioAtencion.Location = New System.Drawing.Point(206, 37)
        Me.tbHorarioAtencion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbHorarioAtencion.MaxLength = 50
        Me.tbHorarioAtencion.Name = "tbHorarioAtencion"
        Me.tbHorarioAtencion.PreventEnterBeep = True
        Me.tbHorarioAtencion.Size = New System.Drawing.Size(287, 26)
        Me.tbHorarioAtencion.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'F1_ClientesEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "F1_ClientesEmpresas"
        Me.Opacity = 0R
        Me.Text = "F1_ClientesEmpresas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.SuperTabPrincipal, 0)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabPrincipal.ResumeLayout(False)
        Me.SuperTabControlPanelRegistro.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.MPanelSup.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.GroupPanelBuscador.ResumeLayout(False)
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.cbTipoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLimiteCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItemsHabilitados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTiempoCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCondicionesEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbActividadComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNombreEmpresa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbTelefono01 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbCodigoOriginal As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Gmc_Cliente As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCiudad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbCiudad As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnDepartamento As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbDepartamento As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents tbNit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbPaginaWeb As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbHorarioAtencion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnActividadComercial As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbActividadComercial As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbTelefonoCelular As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNombreContacto02 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbTelefono02 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNombreContacto01 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCondicionesEntrega As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbCondicionesEntrega As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents tbItemsHabilitados As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbTiempoCredito As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbLimiteCredito As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbTipoVenta As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Timer1 As Timer
End Class
