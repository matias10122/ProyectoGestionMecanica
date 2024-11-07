<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        buttonUsuario = New Button()
        buttonHome = New Button()
        buttonRepuestos = New Button()
        buttonGestionServicios = New Button()
        buttonSoliServicios = New Button()
        buttonSiniestros = New Button()
        buttonVentaRepuestos = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        panelHome = New Panel()
        panelVentaRepuestos = New Panel()
        pnregistroCliente = New Panel()
        pnlBoleta = New Panel()
        gpBoleta = New GroupBox()
        btnEnviarBoleta = New Button()
        lblGracias = New Label()
        lblTotalBoleta = New Label()
        lblProducto = New Label()
        lblRutCliente_nombre = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        GroupBox2 = New GroupBox()
        btnVer = New Button()
        btnRestaurarFiltros = New Button()
        btnAplicarFiltros = New Button()
        cmbFiltroCliente = New ComboBox()
        cmbFiltroRepuesto = New ComboBox()
        dtpFechaFin = New DateTimePicker()
        dtpFechaInicio = New DateTimePicker()
        lblrepuesto = New Label()
        lblTermino = New Label()
        lblInicio = New Label()
        lblCliente = New Label()
        dgvResumenVentas = New DataGridView()
        Label17 = New Label()
        GroupBox1 = New GroupBox()
        btRegistrarCli = New Button()
        txtStock = New TextBox()
        lblBoleta = New Label()
        lblStock = New Label()
        btnGenerarBoleta = New Button()
        btnEliminarVenta = New Button()
        lblDatosCliente = New Label()
        btEditarVenta = New Button()
        btnRegistrarVenta = New Button()
        txtId = New TextBox()
        lblID = New Label()
        txtTotal = New TextBox()
        lblmensajeIVA = New Label()
        txtMontoNeto = New TextBox()
        dtpFechaVenta = New DateTimePicker()
        txtCliente = New TextBox()
        txtCantidadVendida = New TextBox()
        cmbNombreRepuesto = New ComboBox()
        lblTotal = New Label()
        lblNomRepuesto = New Label()
        lblCntVender = New Label()
        lblRut = New Label()
        lblFecVenta = New Label()
        lblNeto = New Label()
        Label7 = New Label()
        panelSiniestro = New Panel()
        tableLayoutPanelSiniestro = New TableLayoutPanel()
        panelGestionServicios = New Panel()
        panelSoliServicios = New Panel()
        panelRepuestos = New Panel()
        Label6 = New Label()
        TextBoxNombreVer = New TextBox()
        Label5 = New Label()
        ComboBoxRepuestos = New ComboBox()
        ButtonGuardarRepuesto = New Button()
        ButtonEliminarRepuesto = New Button()
        ButtonEditarRepuesto = New Button()
        ButtonLimpiarRepuesto = New Button()
        ButtonConsultarRepuesto = New Button()
        TextBoxRepuestoDescripcion = New TextBox()
        TextBoxRepuestoPrecio = New TextBox()
        TextBoxRepuestoCantidad = New TextBox()
        TextBoxBuscarRepuestoNombre = New TextBox()
        TextBoxBuscarRepuestoID = New TextBox()
        LabelRepuestoID = New Label()
        LabelRepuestoCantidad = New Label()
        LabelRepuestoPrecio = New Label()
        LabelRepuestoDescripcion = New Label()
        LabelRepuestoNombre = New Label()
        panelUsuario = New Panel()
        comboBoxTipo = New ComboBox()
        ButtonGuardarUsuario = New Button()
        ButtonEliminarUsuario = New Button()
        ButtonEditar = New Button()
        TextBoxCorreo = New TextBox()
        LabelTipo = New Label()
        LabelCorreo = New Label()
        TextBoxContraseña = New TextBox()
        LabelContraseña = New Label()
        TextBoxRutUsuario = New TextBox()
        LabelRutUsuario = New Label()
        TextBoxRut = New TextBox()
        buttonConsultarRut = New Button()
        panelEncabezadoUsuario = New Panel()
        limpiarCamposGestionUsuarios = New Button()
        buttonMostrarUsuarios = New Button()
        LabelRut = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        panelVentaRepuestos.SuspendLayout()
        pnlBoleta.SuspendLayout()
        gpBoleta.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvResumenVentas, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        panelSiniestro.SuspendLayout()
        panelRepuestos.SuspendLayout()
        panelUsuario.SuspendLayout()
        panelEncabezadoUsuario.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(buttonUsuario)
        Panel1.Controls.Add(buttonHome)
        Panel1.Controls.Add(buttonRepuestos)
        Panel1.Controls.Add(buttonGestionServicios)
        Panel1.Controls.Add(buttonSoliServicios)
        Panel1.Controls.Add(buttonSiniestros)
        Panel1.Controls.Add(buttonVentaRepuestos)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(796, 48)
        Panel1.TabIndex = 0
        ' 
        ' buttonUsuario
        ' 
        buttonUsuario.Location = New Point(100, 0)
        buttonUsuario.Name = "buttonUsuario"
        buttonUsuario.Size = New Size(90, 49)
        buttonUsuario.TabIndex = 7
        buttonUsuario.Text = "Gestion - Usuarios"
        buttonUsuario.UseVisualStyleBackColor = True
        ' 
        ' buttonHome
        ' 
        buttonHome.Location = New Point(0, 0)
        buttonHome.Name = "buttonHome"
        buttonHome.Size = New Size(94, 48)
        buttonHome.TabIndex = 6
        buttonHome.Text = "Home"
        buttonHome.UseVisualStyleBackColor = True
        ' 
        ' buttonRepuestos
        ' 
        buttonRepuestos.Location = New Point(185, 0)
        buttonRepuestos.Name = "buttonRepuestos"
        buttonRepuestos.Size = New Size(97, 48)
        buttonRepuestos.TabIndex = 5
        buttonRepuestos.Text = "Respuestos"
        buttonRepuestos.UseVisualStyleBackColor = True
        ' 
        ' buttonGestionServicios
        ' 
        buttonGestionServicios.Location = New Point(612, 0)
        buttonGestionServicios.Name = "buttonGestionServicios"
        buttonGestionServicios.Size = New Size(114, 48)
        buttonGestionServicios.TabIndex = 4
        buttonGestionServicios.Text = "Gestion - solicitudes"
        buttonGestionServicios.UseVisualStyleBackColor = True
        ' 
        ' buttonSoliServicios
        ' 
        buttonSoliServicios.Location = New Point(501, 0)
        buttonSoliServicios.Name = "buttonSoliServicios"
        buttonSoliServicios.Size = New Size(114, 48)
        buttonSoliServicios.TabIndex = 3
        buttonSoliServicios.Text = "Solicitud de servicio"
        buttonSoliServicios.UseVisualStyleBackColor = True
        ' 
        ' buttonSiniestros
        ' 
        buttonSiniestros.Location = New Point(390, 0)
        buttonSiniestros.Name = "buttonSiniestros"
        buttonSiniestros.Size = New Size(114, 48)
        buttonSiniestros.TabIndex = 2
        buttonSiniestros.Text = "Siniestros"
        buttonSiniestros.UseVisualStyleBackColor = True
        ' 
        ' buttonVentaRepuestos
        ' 
        buttonVentaRepuestos.Location = New Point(279, 0)
        buttonVentaRepuestos.Name = "buttonVentaRepuestos"
        buttonVentaRepuestos.Size = New Size(114, 48)
        buttonVentaRepuestos.TabIndex = 1
        buttonVentaRepuestos.Text = "Venta-Repuestos"
        buttonVentaRepuestos.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Image = My.Resources.Resources.acceso
        Button1.Location = New Point(721, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 48)
        Button1.TabIndex = 0
        Button1.Text = "Log out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label1.Location = New Point(171, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 1
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(227, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(560, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(27, 15)
        Label3.TabIndex = 3
        Label3.Text = "Rol:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(593, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 4
        Label4.Text = "Label4"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(2, 451)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(796, 29)
        Panel2.TabIndex = 5
        ' 
        ' panelHome
        ' 
        panelHome.BackgroundImage = My.Resources.Resources.fondomotor
        panelHome.BackgroundImageLayout = ImageLayout.Stretch
        panelHome.Location = New Point(8, 57)
        panelHome.Name = "panelHome"
        panelHome.Size = New Size(790, 392)
        panelHome.TabIndex = 6
        ' 
        ' panelVentaRepuestos
        ' 
        panelVentaRepuestos.BackColor = Color.DarkSlateGray
        panelVentaRepuestos.Controls.Add(pnregistroCliente)
        panelVentaRepuestos.Controls.Add(pnlBoleta)
        panelVentaRepuestos.Controls.Add(GroupBox2)
        panelVentaRepuestos.Controls.Add(GroupBox1)
        panelVentaRepuestos.Location = New Point(8, 57)
        panelVentaRepuestos.Name = "panelVentaRepuestos"
        panelVentaRepuestos.Size = New Size(790, 392)
        panelVentaRepuestos.TabIndex = 1
        ' 
        ' pnregistroCliente
        ' 
        pnregistroCliente.Location = New Point(0, 8)
        pnregistroCliente.Margin = New Padding(3, 2, 3, 2)
        pnregistroCliente.Name = "pnregistroCliente"
        pnregistroCliente.Size = New Size(781, 295)
        pnregistroCliente.TabIndex = 24
        ' 
        ' pnlBoleta
        ' 
        pnlBoleta.Controls.Add(gpBoleta)
        pnlBoleta.Location = New Point(444, 2)
        pnlBoleta.Margin = New Padding(3, 2, 3, 2)
        pnlBoleta.Name = "pnlBoleta"
        pnlBoleta.Size = New Size(348, 378)
        pnlBoleta.TabIndex = 24
        ' 
        ' gpBoleta
        ' 
        gpBoleta.BackColor = Color.MintCream
        gpBoleta.Controls.Add(btnEnviarBoleta)
        gpBoleta.Controls.Add(lblGracias)
        gpBoleta.Controls.Add(lblTotalBoleta)
        gpBoleta.Controls.Add(lblProducto)
        gpBoleta.Controls.Add(lblRutCliente_nombre)
        gpBoleta.Controls.Add(Label11)
        gpBoleta.Controls.Add(Label10)
        gpBoleta.Controls.Add(Label9)
        gpBoleta.Controls.Add(Label8)
        gpBoleta.Location = New Point(10, 6)
        gpBoleta.Margin = New Padding(3, 2, 3, 2)
        gpBoleta.Name = "gpBoleta"
        gpBoleta.Padding = New Padding(3, 2, 3, 2)
        gpBoleta.Size = New Size(332, 361)
        gpBoleta.TabIndex = 8
        gpBoleta.TabStop = False
        gpBoleta.Text = "Boleta"
        ' 
        ' btnEnviarBoleta
        ' 
        btnEnviarBoleta.BackColor = SystemColors.ControlLight
        btnEnviarBoleta.Location = New Point(90, 313)
        btnEnviarBoleta.Margin = New Padding(3, 2, 3, 2)
        btnEnviarBoleta.Name = "btnEnviarBoleta"
        btnEnviarBoleta.Size = New Size(121, 24)
        btnEnviarBoleta.TabIndex = 8
        btnEnviarBoleta.Text = "Descargar Boleta"
        btnEnviarBoleta.UseVisualStyleBackColor = False
        ' 
        ' lblGracias
        ' 
        lblGracias.AutoSize = True
        lblGracias.Location = New Point(38, 284)
        lblGracias.Name = "lblGracias"
        lblGracias.Size = New Size(192, 15)
        lblGracias.TabIndex = 7
        lblGracias.Text = "¡Gracias por comprar con nosotros!"
        ' 
        ' lblTotalBoleta
        ' 
        lblTotalBoleta.AutoSize = True
        lblTotalBoleta.Location = New Point(18, 225)
        lblTotalBoleta.Name = "lblTotalBoleta"
        lblTotalBoleta.Size = New Size(32, 15)
        lblTotalBoleta.TabIndex = 6
        lblTotalBoleta.Text = "Total"
        ' 
        ' lblProducto
        ' 
        lblProducto.AutoSize = True
        lblProducto.Location = New Point(12, 138)
        lblProducto.Name = "lblProducto"
        lblProducto.Size = New Size(56, 15)
        lblProducto.TabIndex = 5
        lblProducto.Text = "producto"
        ' 
        ' lblRutCliente_nombre
        ' 
        lblRutCliente_nombre.AutoSize = True
        lblRutCliente_nombre.Location = New Point(12, 88)
        lblRutCliente_nombre.Name = "lblRutCliente_nombre"
        lblRutCliente_nombre.Size = New Size(44, 15)
        lblRutCliente_nombre.TabIndex = 4
        lblRutCliente_nombre.Text = "Cliente"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(196, 42)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 15)
        Label11.TabIndex = 3
        Label11.Text = "Giro: Automotiz"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(14, 61)
        Label10.Name = "Label10"
        Label10.Size = New Size(136, 15)
        Label10.TabIndex = 2
        Label10.Text = "Dirección: Republica 100"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(16, 40)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 15)
        Label9.TabIndex = 1
        Label9.Text = "Rut: 11111111-1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(100, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(126, 19)
        Label8.TabIndex = 0
        Label8.Text = "Gestión Mecánica"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.DarkCyan
        GroupBox2.Controls.Add(btnVer)
        GroupBox2.Controls.Add(btnRestaurarFiltros)
        GroupBox2.Controls.Add(btnAplicarFiltros)
        GroupBox2.Controls.Add(cmbFiltroCliente)
        GroupBox2.Controls.Add(cmbFiltroRepuesto)
        GroupBox2.Controls.Add(dtpFechaFin)
        GroupBox2.Controls.Add(dtpFechaInicio)
        GroupBox2.Controls.Add(lblrepuesto)
        GroupBox2.Controls.Add(lblTermino)
        GroupBox2.Controls.Add(lblInicio)
        GroupBox2.Controls.Add(lblCliente)
        GroupBox2.Controls.Add(dgvResumenVentas)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBox2.Location = New Point(438, 8)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(343, 372)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' btnVer
        ' 
        btnVer.Location = New Point(283, 184)
        btnVer.Margin = New Padding(3, 2, 3, 2)
        btnVer.Name = "btnVer"
        btnVer.Size = New Size(39, 33)
        btnVer.TabIndex = 20
        btnVer.Text = "VER"
        btnVer.UseVisualStyleBackColor = True
        ' 
        ' btnRestaurarFiltros
        ' 
        btnRestaurarFiltros.Location = New Point(116, 336)
        btnRestaurarFiltros.Margin = New Padding(3, 2, 3, 2)
        btnRestaurarFiltros.Name = "btnRestaurarFiltros"
        btnRestaurarFiltros.Size = New Size(162, 22)
        btnRestaurarFiltros.TabIndex = 20
        btnRestaurarFiltros.Text = "Restaurar"
        btnRestaurarFiltros.UseVisualStyleBackColor = True
        ' 
        ' btnAplicarFiltros
        ' 
        btnAplicarFiltros.Location = New Point(116, 310)
        btnAplicarFiltros.Margin = New Padding(3, 2, 3, 2)
        btnAplicarFiltros.Name = "btnAplicarFiltros"
        btnAplicarFiltros.Size = New Size(162, 22)
        btnAplicarFiltros.TabIndex = 19
        btnAplicarFiltros.Text = "Filtrar"
        btnAplicarFiltros.UseVisualStyleBackColor = True
        ' 
        ' cmbFiltroCliente
        ' 
        cmbFiltroCliente.FormattingEnabled = True
        cmbFiltroCliente.Location = New Point(114, 281)
        cmbFiltroCliente.Margin = New Padding(3, 2, 3, 2)
        cmbFiltroCliente.Name = "cmbFiltroCliente"
        cmbFiltroCliente.Size = New Size(164, 23)
        cmbFiltroCliente.TabIndex = 14
        ' 
        ' cmbFiltroRepuesto
        ' 
        cmbFiltroRepuesto.FormattingEnabled = True
        cmbFiltroRepuesto.Location = New Point(114, 249)
        cmbFiltroRepuesto.Margin = New Padding(3, 2, 3, 2)
        cmbFiltroRepuesto.Name = "cmbFiltroRepuesto"
        cmbFiltroRepuesto.Size = New Size(164, 23)
        cmbFiltroRepuesto.TabIndex = 13
        ' 
        ' dtpFechaFin
        ' 
        dtpFechaFin.Location = New Point(114, 220)
        dtpFechaFin.Margin = New Padding(3, 2, 3, 2)
        dtpFechaFin.Name = "dtpFechaFin"
        dtpFechaFin.Size = New Size(164, 23)
        dtpFechaFin.TabIndex = 12
        ' 
        ' dtpFechaInicio
        ' 
        dtpFechaInicio.Location = New Point(114, 190)
        dtpFechaInicio.Margin = New Padding(3, 2, 3, 2)
        dtpFechaInicio.Name = "dtpFechaInicio"
        dtpFechaInicio.Size = New Size(164, 23)
        dtpFechaInicio.TabIndex = 11
        ' 
        ' lblrepuesto
        ' 
        lblrepuesto.AutoSize = True
        lblrepuesto.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblrepuesto.Location = New Point(32, 255)
        lblrepuesto.Name = "lblrepuesto"
        lblrepuesto.Size = New Size(60, 15)
        lblrepuesto.TabIndex = 10
        lblrepuesto.Text = "Repuesto"
        ' 
        ' lblTermino
        ' 
        lblTermino.AutoSize = True
        lblTermino.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTermino.Location = New Point(32, 224)
        lblTermino.Name = "lblTermino"
        lblTermino.Size = New Size(53, 15)
        lblTermino.TabIndex = 9
        lblTermino.Text = "Termino"
        ' 
        ' lblInicio
        ' 
        lblInicio.AutoSize = True
        lblInicio.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblInicio.Location = New Point(32, 195)
        lblInicio.Name = "lblInicio"
        lblInicio.Size = New Size(37, 15)
        lblInicio.TabIndex = 8
        lblInicio.Text = "Inicio"
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCliente.Location = New Point(32, 287)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(46, 15)
        lblCliente.TabIndex = 7
        lblCliente.Text = "Cliente"
        ' 
        ' dgvResumenVentas
        ' 
        dgvResumenVentas.BackgroundColor = Color.FromArgb(CByte(111), CByte(181), CByte(172))
        dgvResumenVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResumenVentas.Location = New Point(5, 28)
        dgvResumenVentas.Margin = New Padding(3, 2, 3, 2)
        dgvResumenVentas.Name = "dgvResumenVentas"
        dgvResumenVentas.RowHeadersWidth = 51
        dgvResumenVentas.Size = New Size(317, 149)
        dgvResumenVentas.TabIndex = 2
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(85, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(138, 20)
        Label17.TabIndex = 1
        Label17.Text = "Resumen de venta"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.CadetBlue
        GroupBox1.Controls.Add(btRegistrarCli)
        GroupBox1.Controls.Add(txtStock)
        GroupBox1.Controls.Add(lblBoleta)
        GroupBox1.Controls.Add(lblStock)
        GroupBox1.Controls.Add(btnGenerarBoleta)
        GroupBox1.Controls.Add(btnEliminarVenta)
        GroupBox1.Controls.Add(lblDatosCliente)
        GroupBox1.Controls.Add(btEditarVenta)
        GroupBox1.Controls.Add(btnRegistrarVenta)
        GroupBox1.Controls.Add(txtId)
        GroupBox1.Controls.Add(lblID)
        GroupBox1.Controls.Add(txtTotal)
        GroupBox1.Controls.Add(lblmensajeIVA)
        GroupBox1.Controls.Add(txtMontoNeto)
        GroupBox1.Controls.Add(dtpFechaVenta)
        GroupBox1.Controls.Add(txtCliente)
        GroupBox1.Controls.Add(txtCantidadVendida)
        GroupBox1.Controls.Add(cmbNombreRepuesto)
        GroupBox1.Controls.Add(lblTotal)
        GroupBox1.Controls.Add(lblNomRepuesto)
        GroupBox1.Controls.Add(lblCntVender)
        GroupBox1.Controls.Add(lblRut)
        GroupBox1.Controls.Add(lblFecVenta)
        GroupBox1.Controls.Add(lblNeto)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBox1.Location = New Point(12, 8)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(421, 372)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' btRegistrarCli
        ' 
        btRegistrarCli.Location = New Point(158, 322)
        btRegistrarCli.Margin = New Padding(3, 2, 3, 2)
        btRegistrarCli.Name = "btRegistrarCli"
        btRegistrarCli.Size = New Size(81, 22)
        btRegistrarCli.TabIndex = 24
        btRegistrarCli.Text = "Cliente"
        btRegistrarCli.UseVisualStyleBackColor = True
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(349, 70)
        txtStock.Margin = New Padding(3, 2, 3, 2)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(50, 23)
        txtStock.TabIndex = 17
        ' 
        ' lblBoleta
        ' 
        lblBoleta.AutoSize = True
        lblBoleta.Location = New Point(33, 9)
        lblBoleta.Name = "lblBoleta"
        lblBoleta.Size = New Size(56, 15)
        lblBoleta.TabIndex = 23
        lblBoleta.Text = "lblBoleta"
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStock.Location = New Point(302, 73)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(39, 15)
        lblStock.TabIndex = 15
        lblStock.Text = "Stock"
        ' 
        ' btnGenerarBoleta
        ' 
        btnGenerarBoleta.Location = New Point(334, 322)
        btnGenerarBoleta.Margin = New Padding(3, 2, 3, 2)
        btnGenerarBoleta.Name = "btnGenerarBoleta"
        btnGenerarBoleta.Size = New Size(81, 22)
        btnGenerarBoleta.TabIndex = 22
        btnGenerarBoleta.Text = "Boleta"
        btnGenerarBoleta.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarVenta
        ' 
        btnEliminarVenta.Location = New Point(334, 287)
        btnEliminarVenta.Margin = New Padding(3, 2, 3, 2)
        btnEliminarVenta.Name = "btnEliminarVenta"
        btnEliminarVenta.Size = New Size(81, 22)
        btnEliminarVenta.TabIndex = 21
        btnEliminarVenta.Text = "Eliminar "
        btnEliminarVenta.UseVisualStyleBackColor = True
        ' 
        ' lblDatosCliente
        ' 
        lblDatosCliente.AutoSize = True
        lblDatosCliente.Location = New Point(15, 265)
        lblDatosCliente.Name = "lblDatosCliente"
        lblDatosCliente.Size = New Size(84, 15)
        lblDatosCliente.TabIndex = 20
        lblDatosCliente.Text = "Datos Cliente:"
        ' 
        ' btEditarVenta
        ' 
        btEditarVenta.Location = New Point(334, 258)
        btEditarVenta.Margin = New Padding(3, 2, 3, 2)
        btEditarVenta.Name = "btEditarVenta"
        btEditarVenta.Size = New Size(81, 22)
        btEditarVenta.TabIndex = 19
        btEditarVenta.Text = "Editar "
        btEditarVenta.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarVenta
        ' 
        btnRegistrarVenta.Location = New Point(334, 227)
        btnRegistrarVenta.Margin = New Padding(3, 2, 3, 2)
        btnRegistrarVenta.Name = "btnRegistrarVenta"
        btnRegistrarVenta.Size = New Size(81, 22)
        btnRegistrarVenta.TabIndex = 18
        btnRegistrarVenta.Text = "Registrar "
        btnRegistrarVenta.UseVisualStyleBackColor = True
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(349, 38)
        txtId.Margin = New Padding(3, 2, 3, 2)
        txtId.Name = "txtId"
        txtId.Size = New Size(50, 23)
        txtId.TabIndex = 16
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblID.Location = New Point(313, 43)
        lblID.Name = "lblID"
        lblID.Size = New Size(20, 15)
        lblID.TabIndex = 14
        lblID.Text = "ID"
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(155, 229)
        txtTotal.Margin = New Padding(3, 2, 3, 2)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(129, 23)
        txtTotal.TabIndex = 13
        ' 
        ' lblmensajeIVA
        ' 
        lblmensajeIVA.AutoSize = True
        lblmensajeIVA.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblmensajeIVA.Location = New Point(145, 200)
        lblmensajeIVA.Name = "lblmensajeIVA"
        lblmensajeIVA.Size = New Size(158, 13)
        lblmensajeIVA.TabIndex = 12
        lblmensajeIVA.Text = "Esta compra esta sujeto a IVA"
        ' 
        ' txtMontoNeto
        ' 
        txtMontoNeto.Location = New Point(155, 178)
        txtMontoNeto.Margin = New Padding(3, 2, 3, 2)
        txtMontoNeto.Name = "txtMontoNeto"
        txtMontoNeto.Size = New Size(133, 23)
        txtMontoNeto.TabIndex = 11
        ' 
        ' dtpFechaVenta
        ' 
        dtpFechaVenta.Location = New Point(155, 145)
        dtpFechaVenta.Margin = New Padding(3, 2, 3, 2)
        dtpFechaVenta.Name = "dtpFechaVenta"
        dtpFechaVenta.Size = New Size(133, 23)
        dtpFechaVenta.TabIndex = 10
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(155, 112)
        txtCliente.Margin = New Padding(3, 2, 3, 2)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(133, 23)
        txtCliente.TabIndex = 9
        ' 
        ' txtCantidadVendida
        ' 
        txtCantidadVendida.Location = New Point(155, 79)
        txtCantidadVendida.Margin = New Padding(3, 2, 3, 2)
        txtCantidadVendida.Name = "txtCantidadVendida"
        txtCantidadVendida.Size = New Size(133, 23)
        txtCantidadVendida.TabIndex = 8
        ' 
        ' cmbNombreRepuesto
        ' 
        cmbNombreRepuesto.FormattingEnabled = True
        cmbNombreRepuesto.Location = New Point(155, 43)
        cmbNombreRepuesto.Margin = New Padding(3, 2, 3, 2)
        cmbNombreRepuesto.Name = "cmbNombreRepuesto"
        cmbNombreRepuesto.Size = New Size(133, 23)
        cmbNombreRepuesto.TabIndex = 7
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTotal.Location = New Point(15, 229)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(73, 15)
        lblTotal.TabIndex = 6
        lblTotal.Text = "Monto total"
        ' 
        ' lblNomRepuesto
        ' 
        lblNomRepuesto.AutoSize = True
        lblNomRepuesto.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNomRepuesto.Location = New Point(15, 49)
        lblNomRepuesto.Name = "lblNomRepuesto"
        lblNomRepuesto.Size = New Size(126, 15)
        lblNomRepuesto.TabIndex = 5
        lblNomRepuesto.Text = "Nombre del repuesto"
        ' 
        ' lblCntVender
        ' 
        lblCntVender.AutoSize = True
        lblCntVender.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCntVender.Location = New Point(15, 81)
        lblCntVender.Name = "lblCntVender"
        lblCntVender.Size = New Size(107, 15)
        lblCntVender.TabIndex = 4
        lblCntVender.Text = "Cantidad a vender"
        ' 
        ' lblRut
        ' 
        lblRut.AutoSize = True
        lblRut.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblRut.Location = New Point(15, 114)
        lblRut.Name = "lblRut"
        lblRut.Size = New Size(69, 15)
        lblRut.TabIndex = 3
        lblRut.Text = "Rut Cliente"
        ' 
        ' lblFecVenta
        ' 
        lblFecVenta.AutoSize = True
        lblFecVenta.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblFecVenta.Location = New Point(15, 150)
        lblFecVenta.Name = "lblFecVenta"
        lblFecVenta.Size = New Size(91, 15)
        lblFecVenta.TabIndex = 2
        lblFecVenta.Text = "Fecha de venta"
        ' 
        ' lblNeto
        ' 
        lblNeto.AutoSize = True
        lblNeto.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNeto.Location = New Point(15, 180)
        lblNeto.Name = "lblNeto"
        lblNeto.Size = New Size(73, 15)
        lblNeto.TabIndex = 1
        lblNeto.Text = "Monto neto"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(151, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(178, 20)
        Label7.TabIndex = 0
        Label7.Text = "Registro de nueva venta"
        ' 
        ' panelSiniestro
        ' 
        panelSiniestro.Controls.Add(tableLayoutPanelSiniestro)
        panelSiniestro.Location = New Point(8, 57)
        panelSiniestro.Name = "panelSiniestro"
        panelSiniestro.Size = New Size(790, 392)
        panelSiniestro.TabIndex = 2
        ' 
        ' tableLayoutPanelSiniestro
        ' 
        tableLayoutPanelSiniestro.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
        tableLayoutPanelSiniestro.ColumnCount = 8
        tableLayoutPanelSiniestro.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.3103447F))
        tableLayoutPanelSiniestro.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.5172415F))
        tableLayoutPanelSiniestro.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.1379318F))
        tableLayoutPanelSiniestro.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.4827585F))
        tableLayoutPanelSiniestro.ColumnStyles.Add(New ColumnStyle())
        tableLayoutPanelSiniestro.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.4137936F))
        tableLayoutPanelSiniestro.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.4482765F))
        tableLayoutPanelSiniestro.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12F))
        tableLayoutPanelSiniestro.Location = New Point(12, 17)
        tableLayoutPanelSiniestro.Name = "tableLayoutPanelSiniestro"
        tableLayoutPanelSiniestro.RowCount = 6
        tableLayoutPanelSiniestro.RowStyles.Add(New RowStyle(SizeType.Percent, 35.8490562F))
        tableLayoutPanelSiniestro.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        tableLayoutPanelSiniestro.RowStyles.Add(New RowStyle(SizeType.Absolute, 44F))
        tableLayoutPanelSiniestro.RowStyles.Add(New RowStyle())
        tableLayoutPanelSiniestro.RowStyles.Add(New RowStyle(SizeType.Percent, 64.15094F))
        tableLayoutPanelSiniestro.RowStyles.Add(New RowStyle(SizeType.Absolute, 47F))
        tableLayoutPanelSiniestro.Size = New Size(729, 244)
        tableLayoutPanelSiniestro.TabIndex = 0
        ' 
        ' panelGestionServicios
        ' 
        panelGestionServicios.Location = New Point(8, 57)
        panelGestionServicios.Name = "panelGestionServicios"
        panelGestionServicios.Size = New Size(790, 392)
        panelGestionServicios.TabIndex = 4
        ' 
        ' panelSoliServicios
        ' 
        panelSoliServicios.Location = New Point(8, 57)
        panelSoliServicios.Name = "panelSoliServicios"
        panelSoliServicios.Size = New Size(790, 392)
        panelSoliServicios.TabIndex = 3
        ' 
        ' panelRepuestos
        ' 
        panelRepuestos.Controls.Add(Label6)
        panelRepuestos.Controls.Add(TextBoxNombreVer)
        panelRepuestos.Controls.Add(Label5)
        panelRepuestos.Controls.Add(ComboBoxRepuestos)
        panelRepuestos.Controls.Add(ButtonGuardarRepuesto)
        panelRepuestos.Controls.Add(ButtonEliminarRepuesto)
        panelRepuestos.Controls.Add(ButtonEditarRepuesto)
        panelRepuestos.Controls.Add(ButtonLimpiarRepuesto)
        panelRepuestos.Controls.Add(ButtonConsultarRepuesto)
        panelRepuestos.Controls.Add(TextBoxRepuestoDescripcion)
        panelRepuestos.Controls.Add(TextBoxRepuestoPrecio)
        panelRepuestos.Controls.Add(TextBoxRepuestoCantidad)
        panelRepuestos.Controls.Add(TextBoxBuscarRepuestoNombre)
        panelRepuestos.Controls.Add(TextBoxBuscarRepuestoID)
        panelRepuestos.Controls.Add(LabelRepuestoID)
        panelRepuestos.Controls.Add(LabelRepuestoCantidad)
        panelRepuestos.Controls.Add(LabelRepuestoPrecio)
        panelRepuestos.Controls.Add(LabelRepuestoDescripcion)
        panelRepuestos.Controls.Add(LabelRepuestoNombre)
        panelRepuestos.Location = New Point(8, 57)
        panelRepuestos.Name = "panelRepuestos"
        panelRepuestos.Size = New Size(790, 392)
        panelRepuestos.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(243, 126)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 20
        Label6.Text = "Nombre"
        ' 
        ' TextBoxNombreVer
        ' 
        TextBoxNombreVer.Location = New Point(320, 121)
        TextBoxNombreVer.Margin = New Padding(3, 2, 3, 2)
        TextBoxNombreVer.Name = "TextBoxNombreVer"
        TextBoxNombreVer.Size = New Size(190, 23)
        TextBoxNombreVer.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(402, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 15)
        Label5.TabIndex = 18
        Label5.Text = "Ver todo los repuesto"
        ' 
        ' ComboBoxRepuestos
        ' 
        ComboBoxRepuestos.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxRepuestos.FormattingEnabled = True
        ComboBoxRepuestos.Location = New Point(352, 33)
        ComboBoxRepuestos.Margin = New Padding(3, 2, 3, 2)
        ComboBoxRepuestos.Name = "ComboBoxRepuestos"
        ComboBoxRepuestos.Size = New Size(241, 23)
        ComboBoxRepuestos.TabIndex = 16
        ' 
        ' ButtonGuardarRepuesto
        ' 
        ButtonGuardarRepuesto.BackColor = SystemColors.HotTrack
        ButtonGuardarRepuesto.Location = New Point(486, 315)
        ButtonGuardarRepuesto.Margin = New Padding(3, 2, 3, 2)
        ButtonGuardarRepuesto.Name = "ButtonGuardarRepuesto"
        ButtonGuardarRepuesto.Size = New Size(138, 51)
        ButtonGuardarRepuesto.TabIndex = 15
        ButtonGuardarRepuesto.Text = "Guardar"
        ButtonGuardarRepuesto.UseVisualStyleBackColor = False
        ' 
        ' ButtonEliminarRepuesto
        ' 
        ButtonEliminarRepuesto.BackColor = Color.Red
        ButtonEliminarRepuesto.Enabled = False
        ButtonEliminarRepuesto.Location = New Point(256, 315)
        ButtonEliminarRepuesto.Margin = New Padding(3, 2, 3, 2)
        ButtonEliminarRepuesto.Name = "ButtonEliminarRepuesto"
        ButtonEliminarRepuesto.Size = New Size(141, 51)
        ButtonEliminarRepuesto.TabIndex = 14
        ButtonEliminarRepuesto.Text = "Eliminar "
        ButtonEliminarRepuesto.UseVisualStyleBackColor = False
        ' 
        ' ButtonEditarRepuesto
        ' 
        ButtonEditarRepuesto.BackColor = Color.Olive
        ButtonEditarRepuesto.Enabled = False
        ButtonEditarRepuesto.Location = New Point(27, 315)
        ButtonEditarRepuesto.Margin = New Padding(3, 2, 3, 2)
        ButtonEditarRepuesto.Name = "ButtonEditarRepuesto"
        ButtonEditarRepuesto.Size = New Size(149, 51)
        ButtonEditarRepuesto.TabIndex = 13
        ButtonEditarRepuesto.Text = "Editar"
        ButtonEditarRepuesto.UseVisualStyleBackColor = False
        ' 
        ' ButtonLimpiarRepuesto
        ' 
        ButtonLimpiarRepuesto.BackColor = SystemColors.ControlDarkDark
        ButtonLimpiarRepuesto.Location = New Point(640, 107)
        ButtonLimpiarRepuesto.Margin = New Padding(3, 2, 3, 2)
        ButtonLimpiarRepuesto.Name = "ButtonLimpiarRepuesto"
        ButtonLimpiarRepuesto.Size = New Size(116, 69)
        ButtonLimpiarRepuesto.TabIndex = 12
        ButtonLimpiarRepuesto.Text = "Limpiar Campos"
        ButtonLimpiarRepuesto.UseVisualStyleBackColor = False
        ' 
        ' ButtonConsultarRepuesto
        ' 
        ButtonConsultarRepuesto.BackColor = SystemColors.ActiveCaption
        ButtonConsultarRepuesto.Location = New Point(640, 17)
        ButtonConsultarRepuesto.Margin = New Padding(3, 2, 3, 2)
        ButtonConsultarRepuesto.Name = "ButtonConsultarRepuesto"
        ButtonConsultarRepuesto.Size = New Size(116, 69)
        ButtonConsultarRepuesto.TabIndex = 11
        ButtonConsultarRepuesto.Text = "Consultar"
        ButtonConsultarRepuesto.UseVisualStyleBackColor = False
        ' 
        ' TextBoxRepuestoDescripcion
        ' 
        TextBoxRepuestoDescripcion.Location = New Point(472, 257)
        TextBoxRepuestoDescripcion.Margin = New Padding(3, 2, 3, 2)
        TextBoxRepuestoDescripcion.Name = "TextBoxRepuestoDescripcion"
        TextBoxRepuestoDescripcion.Size = New Size(183, 23)
        TextBoxRepuestoDescripcion.TabIndex = 10
        TextBoxRepuestoDescripcion.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxRepuestoPrecio
        ' 
        TextBoxRepuestoPrecio.Location = New Point(243, 257)
        TextBoxRepuestoPrecio.Margin = New Padding(3, 2, 3, 2)
        TextBoxRepuestoPrecio.Name = "TextBoxRepuestoPrecio"
        TextBoxRepuestoPrecio.Size = New Size(187, 23)
        TextBoxRepuestoPrecio.TabIndex = 9
        TextBoxRepuestoPrecio.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxRepuestoCantidad
        ' 
        TextBoxRepuestoCantidad.Location = New Point(35, 257)
        TextBoxRepuestoCantidad.Margin = New Padding(3, 2, 3, 2)
        TextBoxRepuestoCantidad.Name = "TextBoxRepuestoCantidad"
        TextBoxRepuestoCantidad.Size = New Size(164, 23)
        TextBoxRepuestoCantidad.TabIndex = 8
        TextBoxRepuestoCantidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxBuscarRepuestoNombre
        ' 
        TextBoxBuscarRepuestoNombre.Location = New Point(164, 33)
        TextBoxBuscarRepuestoNombre.Margin = New Padding(3, 2, 3, 2)
        TextBoxBuscarRepuestoNombre.Name = "TextBoxBuscarRepuestoNombre"
        TextBoxBuscarRepuestoNombre.Size = New Size(175, 23)
        TextBoxBuscarRepuestoNombre.TabIndex = 7
        ' 
        ' TextBoxBuscarRepuestoID
        ' 
        TextBoxBuscarRepuestoID.Location = New Point(62, 121)
        TextBoxBuscarRepuestoID.Margin = New Padding(3, 2, 3, 2)
        TextBoxBuscarRepuestoID.Name = "TextBoxBuscarRepuestoID"
        TextBoxBuscarRepuestoID.Size = New Size(159, 23)
        TextBoxBuscarRepuestoID.TabIndex = 6
        ' 
        ' LabelRepuestoID
        ' 
        LabelRepuestoID.AutoSize = True
        LabelRepuestoID.Location = New Point(27, 123)
        LabelRepuestoID.Name = "LabelRepuestoID"
        LabelRepuestoID.Size = New Size(21, 15)
        LabelRepuestoID.TabIndex = 4
        LabelRepuestoID.Text = " ID"
        ' 
        ' LabelRepuestoCantidad
        ' 
        LabelRepuestoCantidad.AutoSize = True
        LabelRepuestoCantidad.Location = New Point(40, 218)
        LabelRepuestoCantidad.Name = "LabelRepuestoCantidad"
        LabelRepuestoCantidad.Size = New Size(103, 15)
        LabelRepuestoCantidad.TabIndex = 3
        LabelRepuestoCantidad.Text = "Cantidad en Stock"
        ' 
        ' LabelRepuestoPrecio
        ' 
        LabelRepuestoPrecio.AutoSize = True
        LabelRepuestoPrecio.Location = New Point(293, 218)
        LabelRepuestoPrecio.Name = "LabelRepuestoPrecio"
        LabelRepuestoPrecio.Size = New Size(43, 15)
        LabelRepuestoPrecio.TabIndex = 2
        LabelRepuestoPrecio.Text = "Precio "
        ' 
        ' LabelRepuestoDescripcion
        ' 
        LabelRepuestoDescripcion.AutoSize = True
        LabelRepuestoDescripcion.Location = New Point(516, 218)
        LabelRepuestoDescripcion.Name = "LabelRepuestoDescripcion"
        LabelRepuestoDescripcion.Size = New Size(61, 15)
        LabelRepuestoDescripcion.TabIndex = 1
        LabelRepuestoDescripcion.Text = "Proveedor"
        ' 
        ' LabelRepuestoNombre
        ' 
        LabelRepuestoNombre.AutoSize = True
        LabelRepuestoNombre.Location = New Point(12, 36)
        LabelRepuestoNombre.Name = "LabelRepuestoNombre"
        LabelRepuestoNombre.Size = New Size(132, 15)
        LabelRepuestoNombre.TabIndex = 0
        LabelRepuestoNombre.Text = "Buscar por nombre o ID"
        ' 
        ' panelUsuario
        ' 
        panelUsuario.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        panelUsuario.Controls.Add(comboBoxTipo)
        panelUsuario.Controls.Add(ButtonGuardarUsuario)
        panelUsuario.Controls.Add(ButtonEliminarUsuario)
        panelUsuario.Controls.Add(ButtonEditar)
        panelUsuario.Controls.Add(TextBoxCorreo)
        panelUsuario.Controls.Add(LabelTipo)
        panelUsuario.Controls.Add(LabelCorreo)
        panelUsuario.Controls.Add(TextBoxContraseña)
        panelUsuario.Controls.Add(LabelContraseña)
        panelUsuario.Controls.Add(TextBoxRutUsuario)
        panelUsuario.Controls.Add(LabelRutUsuario)
        panelUsuario.Controls.Add(TextBoxRut)
        panelUsuario.Controls.Add(buttonConsultarRut)
        panelUsuario.Controls.Add(panelEncabezadoUsuario)
        panelUsuario.Location = New Point(8, 57)
        panelUsuario.Name = "panelUsuario"
        panelUsuario.Size = New Size(790, 392)
        panelUsuario.TabIndex = 8
        ' 
        ' comboBoxTipo
        ' 
        comboBoxTipo.FormattingEnabled = True
        comboBoxTipo.Location = New Point(495, 167)
        comboBoxTipo.Name = "comboBoxTipo"
        comboBoxTipo.Size = New Size(161, 23)
        comboBoxTipo.TabIndex = 16
        ' 
        ' ButtonGuardarUsuario
        ' 
        ButtonGuardarUsuario.Location = New Point(320, 302)
        ButtonGuardarUsuario.Margin = New Padding(3, 2, 3, 2)
        ButtonGuardarUsuario.Name = "ButtonGuardarUsuario"
        ButtonGuardarUsuario.Size = New Size(129, 50)
        ButtonGuardarUsuario.TabIndex = 13
        ButtonGuardarUsuario.Text = "Guardar Usuario"
        ButtonGuardarUsuario.UseVisualStyleBackColor = True
        ' 
        ' ButtonEliminarUsuario
        ' 
        ButtonEliminarUsuario.BackColor = Color.Transparent
        ButtonEliminarUsuario.Location = New Point(554, 302)
        ButtonEliminarUsuario.Margin = New Padding(3, 2, 3, 2)
        ButtonEliminarUsuario.Name = "ButtonEliminarUsuario"
        ButtonEliminarUsuario.Size = New Size(120, 50)
        ButtonEliminarUsuario.TabIndex = 12
        ButtonEliminarUsuario.Text = "Eliminar Usuario"
        ButtonEliminarUsuario.UseVisualStyleBackColor = False
        ' 
        ' ButtonEditar
        ' 
        ButtonEditar.Location = New Point(94, 302)
        ButtonEditar.Margin = New Padding(3, 2, 3, 2)
        ButtonEditar.Name = "ButtonEditar"
        ButtonEditar.Size = New Size(129, 53)
        ButtonEditar.TabIndex = 11
        ButtonEditar.Text = "Editar"
        ButtonEditar.UseVisualStyleBackColor = True
        ' 
        ' TextBoxCorreo
        ' 
        TextBoxCorreo.Location = New Point(495, 232)
        TextBoxCorreo.Margin = New Padding(3, 2, 3, 2)
        TextBoxCorreo.Name = "TextBoxCorreo"
        TextBoxCorreo.Size = New Size(161, 23)
        TextBoxCorreo.TabIndex = 9
        ' 
        ' LabelTipo
        ' 
        LabelTipo.AutoSize = True
        LabelTipo.BackColor = Color.Transparent
        LabelTipo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTipo.ForeColor = SystemColors.ControlLight
        LabelTipo.Location = New Point(451, 170)
        LabelTipo.Name = "LabelTipo"
        LabelTipo.Size = New Size(31, 15)
        LabelTipo.TabIndex = 8
        LabelTipo.Text = "Tipo"
        ' 
        ' LabelCorreo
        ' 
        LabelCorreo.AutoSize = True
        LabelCorreo.BackColor = Color.Transparent
        LabelCorreo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelCorreo.ForeColor = SystemColors.ControlLight
        LabelCorreo.Location = New Point(438, 232)
        LabelCorreo.Name = "LabelCorreo"
        LabelCorreo.Size = New Size(45, 15)
        LabelCorreo.TabIndex = 7
        LabelCorreo.Text = "Correo"
        ' 
        ' TextBoxContraseña
        ' 
        TextBoxContraseña.Location = New Point(150, 232)
        TextBoxContraseña.Margin = New Padding(3, 2, 3, 2)
        TextBoxContraseña.Name = "TextBoxContraseña"
        TextBoxContraseña.Size = New Size(175, 23)
        TextBoxContraseña.TabIndex = 6
        ' 
        ' LabelContraseña
        ' 
        LabelContraseña.AutoSize = True
        LabelContraseña.BackColor = Color.Transparent
        LabelContraseña.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelContraseña.ForeColor = SystemColors.ControlLight
        LabelContraseña.Location = New Point(62, 232)
        LabelContraseña.Name = "LabelContraseña"
        LabelContraseña.Size = New Size(69, 15)
        LabelContraseña.TabIndex = 5
        LabelContraseña.Text = "Contraseña"
        ' 
        ' TextBoxRutUsuario
        ' 
        TextBoxRutUsuario.Enabled = False
        TextBoxRutUsuario.Location = New Point(150, 170)
        TextBoxRutUsuario.Margin = New Padding(3, 2, 3, 2)
        TextBoxRutUsuario.Name = "TextBoxRutUsuario"
        TextBoxRutUsuario.Size = New Size(175, 23)
        TextBoxRutUsuario.TabIndex = 4
        ' 
        ' LabelRutUsuario
        ' 
        LabelRutUsuario.AutoSize = True
        LabelRutUsuario.BackColor = Color.Transparent
        LabelRutUsuario.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelRutUsuario.ForeColor = SystemColors.Control
        LabelRutUsuario.Location = New Point(42, 173)
        LabelRutUsuario.Name = "LabelRutUsuario"
        LabelRutUsuario.Size = New Size(92, 15)
        LabelRutUsuario.TabIndex = 2
        LabelRutUsuario.Text = "Rut del Usuario"
        ' 
        ' TextBoxRut
        ' 
        TextBoxRut.Location = New Point(178, 66)
        TextBoxRut.Margin = New Padding(3, 2, 3, 2)
        TextBoxRut.Name = "TextBoxRut"
        TextBoxRut.Size = New Size(179, 23)
        TextBoxRut.TabIndex = 1
        ' 
        ' buttonConsultarRut
        ' 
        buttonConsultarRut.BackColor = Color.Transparent
        buttonConsultarRut.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonConsultarRut.Location = New Point(402, 54)
        buttonConsultarRut.Margin = New Padding(3, 2, 3, 2)
        buttonConsultarRut.Name = "buttonConsultarRut"
        buttonConsultarRut.Size = New Size(108, 50)
        buttonConsultarRut.TabIndex = 0
        buttonConsultarRut.Text = "Consultar"
        buttonConsultarRut.UseVisualStyleBackColor = False
        ' 
        ' panelEncabezadoUsuario
        ' 
        panelEncabezadoUsuario.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        panelEncabezadoUsuario.Controls.Add(limpiarCamposGestionUsuarios)
        panelEncabezadoUsuario.Controls.Add(buttonMostrarUsuarios)
        panelEncabezadoUsuario.Controls.Add(LabelRut)
        panelEncabezadoUsuario.Location = New Point(0, 17)
        panelEncabezadoUsuario.Name = "panelEncabezadoUsuario"
        panelEncabezadoUsuario.Size = New Size(787, 125)
        panelEncabezadoUsuario.TabIndex = 15
        ' 
        ' limpiarCamposGestionUsuarios
        ' 
        limpiarCamposGestionUsuarios.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        limpiarCamposGestionUsuarios.Location = New Point(534, 37)
        limpiarCamposGestionUsuarios.Name = "limpiarCamposGestionUsuarios"
        limpiarCamposGestionUsuarios.Size = New Size(94, 50)
        limpiarCamposGestionUsuarios.TabIndex = 15
        limpiarCamposGestionUsuarios.Text = "Limpiar Campos"
        limpiarCamposGestionUsuarios.UseVisualStyleBackColor = True
        ' 
        ' buttonMostrarUsuarios
        ' 
        buttonMostrarUsuarios.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonMostrarUsuarios.Location = New Point(644, 38)
        buttonMostrarUsuarios.Margin = New Padding(3, 2, 3, 2)
        buttonMostrarUsuarios.Name = "buttonMostrarUsuarios"
        buttonMostrarUsuarios.Size = New Size(112, 49)
        buttonMostrarUsuarios.TabIndex = 14
        buttonMostrarUsuarios.Text = "Ver Todos los Usuarios"
        buttonMostrarUsuarios.UseVisualStyleBackColor = True
        ' 
        ' LabelRut
        ' 
        LabelRut.AutoSize = True
        LabelRut.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelRut.ForeColor = Color.Green
        LabelRut.Location = New Point(65, 40)
        LabelRut.Name = "LabelRut"
        LabelRut.Size = New Size(78, 47)
        LabelRut.TabIndex = 3
        LabelRut.Text = "Rut"
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondoLogin01
        ClientSize = New Size(800, 478)
        Controls.Add(panelSiniestro)
        Controls.Add(panelVentaRepuestos)
        Controls.Add(panelUsuario)
        Controls.Add(panelRepuestos)
        Controls.Add(panelGestionServicios)
        Controls.Add(panelSoliServicios)
        Controls.Add(panelHome)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        panelVentaRepuestos.ResumeLayout(False)
        pnlBoleta.ResumeLayout(False)
        gpBoleta.ResumeLayout(False)
        gpBoleta.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvResumenVentas, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        panelSiniestro.ResumeLayout(False)
        panelRepuestos.ResumeLayout(False)
        panelRepuestos.PerformLayout()
        panelUsuario.ResumeLayout(False)
        panelUsuario.PerformLayout()
        panelEncabezadoUsuario.ResumeLayout(False)
        panelEncabezadoUsuario.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents buttonGestionServicios As Button
    Friend WithEvents buttonSoliServicios As Button
    Friend WithEvents buttonSiniestros As Button
    Friend WithEvents buttonVentaRepuestos As Button
    Friend WithEvents buttonRepuestos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents buttonHome As Button
    Friend WithEvents panelHome As Panel
    Friend WithEvents panelSoliServicios As Panel
    Friend WithEvents panelSiniestro As Panel
    Friend WithEvents panelVentaRepuestos As Panel
    Friend WithEvents panelRepuestos As Panel
    Friend WithEvents panelGestionServicios As Panel
    Friend WithEvents buttonUsuario As Button
    Friend WithEvents panelUsuario As Panel
    Friend WithEvents LabelRutUsuario As Label
    Friend WithEvents TextBoxRut As TextBox
    Friend WithEvents buttonConsultarRut As Button
    Friend WithEvents LabelRut As Label
    Friend WithEvents TextBoxRutUsuario As TextBox
    Friend WithEvents LabelContraseña As Label
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents LabelTipo As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents ButtonEliminarUsuario As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonGuardarUsuario As Button
    Friend WithEvents buttonMostrarUsuarios As Button
    Friend WithEvents LabelRepuestoID As Label
    Friend WithEvents LabelRepuestoCantidad As Label
    Friend WithEvents LabelRepuestoPrecio As Label
    Friend WithEvents LabelRepuestoDescripcion As Label
    Friend WithEvents LabelRepuestoNombre As Label
    Friend WithEvents TextBoxRepuestoDescripcion As TextBox
    Friend WithEvents TextBoxRepuestoPrecio As TextBox
    Friend WithEvents TextBoxRepuestoCantidad As TextBox
    Friend WithEvents TextBoxBuscarRepuestoNombre As TextBox
    Friend WithEvents TextBoxBuscarRepuestoID As TextBox
    Friend WithEvents ButtonGuardarRepuesto As Button
    Friend WithEvents ButtonEliminarRepuesto As Button
    Friend WithEvents ButtonEditarRepuesto As Button
    Friend WithEvents ButtonLimpiarRepuesto As Button
    Friend WithEvents ButtonConsultarRepuesto As Button
    Friend WithEvents ComboBoxRepuestos As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNombreVer As TextBox
    Friend WithEvents panelEncabezadoUsuario As Panel
    Friend WithEvents comboBoxTipo As ComboBox
    Friend WithEvents limpiarCamposGestionUsuarios As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblNomRepuesto As Label
    Friend WithEvents lblCntVender As Label
    Friend WithEvents lblRut As Label
    Friend WithEvents lblFecVenta As Label
    Friend WithEvents lblNeto As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbNombreRepuesto As ComboBox
    Friend WithEvents txtCantidadVendida As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblmensajeIVA As Label
    Friend WithEvents txtMontoNeto As TextBox
    Friend WithEvents dtpFechaVenta As DateTimePicker
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnRegistrarVenta As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dgvResumenVentas As DataGridView
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents lblrepuesto As Label
    Friend WithEvents lblTermino As Label
    Friend WithEvents lblInicio As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents cmbFiltroCliente As ComboBox
    Friend WithEvents cmbFiltroRepuesto As ComboBox
    Friend WithEvents btnRestaurarFiltros As Button
    Friend WithEvents btnAplicarFiltros As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents lblDatosCliente As Label
    Friend WithEvents btEditarVenta As Button
    Friend WithEvents btnEliminarVenta As Button
    Friend WithEvents btnGenerarBoleta As Button
    Friend WithEvents lblBoleta As Label
    Friend WithEvents pnlBoleta As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblGracias As Label
    Friend WithEvents lblTotalBoleta As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblRutCliente_nombre As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents gpBoleta As GroupBox
    Friend WithEvents btnEnviarBoleta As Button
    Friend WithEvents pnregistroCliente As Panel
    Friend WithEvents btRegistrarCli As Button
    Friend WithEvents tableLayoutPanelSiniestro As TableLayoutPanel
End Class
