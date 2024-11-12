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

    'Requerido por el Diseñador de Windows Forms !
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
        lblBoleta = New Label()
        btnGenerarBoleta = New Button()
        btnEliminarVenta = New Button()
        lblDatosCliente = New Label()
        btEditarVenta = New Button()
        btnRegistrarVenta = New Button()
        txtStock = New TextBox()
        txtId = New TextBox()
        lblStock = New Label()
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
        Panel1.Location = New Point(2, 3)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(910, 64)
        Panel1.TabIndex = 0
        ' 
        ' buttonUsuario
        ' 
        buttonUsuario.Location = New Point(114, 0)
        buttonUsuario.Margin = New Padding(3, 4, 3, 4)
        buttonUsuario.Name = "buttonUsuario"
        buttonUsuario.Size = New Size(103, 65)
        buttonUsuario.TabIndex = 7
        buttonUsuario.Text = "Gestion - Usuarios"
        buttonUsuario.UseVisualStyleBackColor = True
        ' 
        ' buttonHome
        ' 
        buttonHome.Location = New Point(0, 0)
        buttonHome.Margin = New Padding(3, 4, 3, 4)
        buttonHome.Name = "buttonHome"
        buttonHome.Size = New Size(107, 64)
        buttonHome.TabIndex = 6
        buttonHome.Text = "Home"
        buttonHome.UseVisualStyleBackColor = True
        ' 
        ' buttonRepuestos
        ' 
        buttonRepuestos.Location = New Point(211, 0)
        buttonRepuestos.Margin = New Padding(3, 4, 3, 4)
        buttonRepuestos.Name = "buttonRepuestos"
        buttonRepuestos.Size = New Size(111, 64)
        buttonRepuestos.TabIndex = 5
        buttonRepuestos.Text = "Respuestos"
        buttonRepuestos.UseVisualStyleBackColor = True
        ' 
        ' buttonGestionServicios
        ' 
        buttonGestionServicios.Location = New Point(699, 0)
        buttonGestionServicios.Margin = New Padding(3, 4, 3, 4)
        buttonGestionServicios.Name = "buttonGestionServicios"
        buttonGestionServicios.Size = New Size(130, 64)
        buttonGestionServicios.TabIndex = 4
        buttonGestionServicios.Text = "Gestion - solicitudes"
        buttonGestionServicios.UseVisualStyleBackColor = True
        ' 
        ' buttonSoliServicios
        ' 
        buttonSoliServicios.Location = New Point(573, 0)
        buttonSoliServicios.Margin = New Padding(3, 4, 3, 4)
        buttonSoliServicios.Name = "buttonSoliServicios"
        buttonSoliServicios.Size = New Size(130, 64)
        buttonSoliServicios.TabIndex = 3
        buttonSoliServicios.Text = "Solicitud de servicio"
        buttonSoliServicios.UseVisualStyleBackColor = True
        ' 
        ' buttonSiniestros
        ' 
        buttonSiniestros.Location = New Point(446, 0)
        buttonSiniestros.Margin = New Padding(3, 4, 3, 4)
        buttonSiniestros.Name = "buttonSiniestros"
        buttonSiniestros.Size = New Size(130, 64)
        buttonSiniestros.TabIndex = 2
        buttonSiniestros.Text = "Siniestros"
        buttonSiniestros.UseVisualStyleBackColor = True
        ' 
        ' buttonVentaRepuestos
        ' 
        buttonVentaRepuestos.Location = New Point(319, 0)
        buttonVentaRepuestos.Margin = New Padding(3, 4, 3, 4)
        buttonVentaRepuestos.Name = "buttonVentaRepuestos"
        buttonVentaRepuestos.Size = New Size(130, 64)
        buttonVentaRepuestos.TabIndex = 1
        buttonVentaRepuestos.Text = "Venta-Repuestos"
        buttonVentaRepuestos.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Image = My.Resources.Resources.acceso
        Button1.Location = New Point(824, 0)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 64)
        Button1.TabIndex = 0
        Button1.Text = "Log out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label1.Location = New Point(195, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 1
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(259, 4)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(640, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 20)
        Label3.TabIndex = 3
        Label3.Text = "Rol:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(678, 4)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
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
        Panel2.Location = New Point(2, 601)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(910, 39)
        Panel2.TabIndex = 5
        ' 
        ' panelHome
        ' 
        panelHome.BackgroundImage = My.Resources.Resources.fondomotor
        panelHome.BackgroundImageLayout = ImageLayout.Stretch
        panelHome.Location = New Point(9, 76)
        panelHome.Margin = New Padding(3, 4, 3, 4)
        panelHome.Name = "panelHome"
        panelHome.Size = New Size(903, 523)
        panelHome.TabIndex = 6
        ' 
        ' panelVentaRepuestos
        ' 
        panelVentaRepuestos.BackColor = Color.DarkSlateGray
        panelVentaRepuestos.Controls.Add(pnlBoleta)
        panelVentaRepuestos.Controls.Add(GroupBox2)
        panelVentaRepuestos.Controls.Add(GroupBox1)
        panelVentaRepuestos.Location = New Point(9, 76)
        panelVentaRepuestos.Margin = New Padding(3, 4, 3, 4)
        panelVentaRepuestos.Name = "panelVentaRepuestos"
        panelVentaRepuestos.Size = New Size(903, 523)
        panelVentaRepuestos.TabIndex = 1
        ' 
        ' pnlBoleta
        ' 
        pnlBoleta.Controls.Add(gpBoleta)
        pnlBoleta.Location = New Point(507, 3)
        pnlBoleta.Name = "pnlBoleta"
        pnlBoleta.Size = New Size(398, 504)
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
        gpBoleta.Location = New Point(11, 8)
        gpBoleta.Name = "gpBoleta"
        gpBoleta.Size = New Size(380, 481)
        gpBoleta.TabIndex = 8
        gpBoleta.TabStop = False
        gpBoleta.Text = "Boleta"
        ' 
        ' btnEnviarBoleta
        ' 
        btnEnviarBoleta.BackColor = SystemColors.ControlLight
        btnEnviarBoleta.Location = New Point(103, 417)
        btnEnviarBoleta.Name = "btnEnviarBoleta"
        btnEnviarBoleta.Size = New Size(138, 32)
        btnEnviarBoleta.TabIndex = 8
        btnEnviarBoleta.Text = "Descargar Boleta"
        btnEnviarBoleta.UseVisualStyleBackColor = False
        ' 
        ' lblGracias
        ' 
        lblGracias.AutoSize = True
        lblGracias.Location = New Point(43, 378)
        lblGracias.Name = "lblGracias"
        lblGracias.Size = New Size(241, 20)
        lblGracias.TabIndex = 7
        lblGracias.Text = "¡Gracias por comprar con nosotros!"
        ' 
        ' lblTotalBoleta
        ' 
        lblTotalBoleta.AutoSize = True
        lblTotalBoleta.Location = New Point(21, 300)
        lblTotalBoleta.Name = "lblTotalBoleta"
        lblTotalBoleta.Size = New Size(42, 20)
        lblTotalBoleta.TabIndex = 6
        lblTotalBoleta.Text = "Total"
        ' 
        ' lblProducto
        ' 
        lblProducto.AutoSize = True
        lblProducto.Location = New Point(14, 184)
        lblProducto.Name = "lblProducto"
        lblProducto.Size = New Size(70, 20)
        lblProducto.TabIndex = 5
        lblProducto.Text = "producto"
        ' 
        ' lblRutCliente_nombre
        ' 
        lblRutCliente_nombre.AutoSize = True
        lblRutCliente_nombre.Location = New Point(14, 118)
        lblRutCliente_nombre.Name = "lblRutCliente_nombre"
        lblRutCliente_nombre.Size = New Size(55, 20)
        lblRutCliente_nombre.TabIndex = 4
        lblRutCliente_nombre.Text = "Cliente"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(224, 56)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 20)
        Label11.TabIndex = 3
        Label11.Text = "Giro: Automotiz"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(16, 81)
        Label10.Name = "Label10"
        Label10.Size = New Size(173, 20)
        Label10.TabIndex = 2
        Label10.Text = "Dirección: Republica 100"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(18, 54)
        Label9.Name = "Label9"
        Label9.Size = New Size(116, 20)
        Label9.TabIndex = 1
        Label9.Text = "Rut: 11111111-1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(114, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(149, 23)
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
        GroupBox2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        GroupBox2.Location = New Point(501, 11)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(392, 496)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' btnVer
        ' 
        btnVer.Location = New Point(323, 246)
        btnVer.Name = "btnVer"
        btnVer.Size = New Size(45, 44)
        btnVer.TabIndex = 20
        btnVer.Text = "VER"
        btnVer.UseVisualStyleBackColor = True
        ' 
        ' btnRestaurarFiltros
        ' 
        btnRestaurarFiltros.Location = New Point(132, 448)
        btnRestaurarFiltros.Name = "btnRestaurarFiltros"
        btnRestaurarFiltros.Size = New Size(185, 29)
        btnRestaurarFiltros.TabIndex = 20
        btnRestaurarFiltros.Text = "Restaurar"
        btnRestaurarFiltros.UseVisualStyleBackColor = True
        ' 
        ' btnAplicarFiltros
        ' 
        btnAplicarFiltros.Location = New Point(132, 413)
        btnAplicarFiltros.Name = "btnAplicarFiltros"
        btnAplicarFiltros.Size = New Size(185, 29)
        btnAplicarFiltros.TabIndex = 19
        btnAplicarFiltros.Text = "Filtrar"
        btnAplicarFiltros.UseVisualStyleBackColor = True
        ' 
        ' cmbFiltroCliente
        ' 
        cmbFiltroCliente.FormattingEnabled = True
        cmbFiltroCliente.Location = New Point(130, 375)
        cmbFiltroCliente.Name = "cmbFiltroCliente"
        cmbFiltroCliente.Size = New Size(187, 28)
        cmbFiltroCliente.TabIndex = 14
        ' 
        ' cmbFiltroRepuesto
        ' 
        cmbFiltroRepuesto.FormattingEnabled = True
        cmbFiltroRepuesto.Location = New Point(130, 332)
        cmbFiltroRepuesto.Name = "cmbFiltroRepuesto"
        cmbFiltroRepuesto.Size = New Size(187, 28)
        cmbFiltroRepuesto.TabIndex = 13
        ' 
        ' dtpFechaFin
        ' 
        dtpFechaFin.Location = New Point(130, 293)
        dtpFechaFin.Name = "dtpFechaFin"
        dtpFechaFin.Size = New Size(187, 27)
        dtpFechaFin.TabIndex = 12
        ' 
        ' dtpFechaInicio
        ' 
        dtpFechaInicio.Location = New Point(130, 253)
        dtpFechaInicio.Name = "dtpFechaInicio"
        dtpFechaInicio.Size = New Size(187, 27)
        dtpFechaInicio.TabIndex = 11
        ' 
        ' lblrepuesto
        ' 
        lblrepuesto.AutoSize = True
        lblrepuesto.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblrepuesto.Location = New Point(36, 340)
        lblrepuesto.Name = "lblrepuesto"
        lblrepuesto.Size = New Size(75, 20)
        lblrepuesto.TabIndex = 10
        lblrepuesto.Text = "Repuesto"
        ' 
        ' lblTermino
        ' 
        lblTermino.AutoSize = True
        lblTermino.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTermino.Location = New Point(36, 298)
        lblTermino.Name = "lblTermino"
        lblTermino.Size = New Size(67, 20)
        lblTermino.TabIndex = 9
        lblTermino.Text = "Termino"
        ' 
        ' lblInicio
        ' 
        lblInicio.AutoSize = True
        lblInicio.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblInicio.Location = New Point(36, 260)
        lblInicio.Name = "lblInicio"
        lblInicio.Size = New Size(47, 20)
        lblInicio.TabIndex = 8
        lblInicio.Text = "Inicio"
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblCliente.Location = New Point(36, 383)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(57, 20)
        lblCliente.TabIndex = 7
        lblCliente.Text = "Cliente"
        ' 
        ' dgvResumenVentas
        ' 
        dgvResumenVentas.BackgroundColor = Color.FromArgb(CByte(111), CByte(181), CByte(172))
        dgvResumenVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResumenVentas.Location = New Point(6, 37)
        dgvResumenVentas.Name = "dgvResumenVentas"
        dgvResumenVentas.RowHeadersWidth = 51
        dgvResumenVentas.Size = New Size(362, 199)
        dgvResumenVentas.TabIndex = 2
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(97, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(169, 25)
        Label17.TabIndex = 1
        Label17.Text = "Resumen de venta"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.CadetBlue
        GroupBox1.Controls.Add(lblBoleta)
        GroupBox1.Controls.Add(btnGenerarBoleta)
        GroupBox1.Controls.Add(btnEliminarVenta)
        GroupBox1.Controls.Add(lblDatosCliente)
        GroupBox1.Controls.Add(btEditarVenta)
        GroupBox1.Controls.Add(btnRegistrarVenta)
        GroupBox1.Controls.Add(txtStock)
        GroupBox1.Controls.Add(txtId)
        GroupBox1.Controls.Add(lblStock)
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
        GroupBox1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        GroupBox1.Location = New Point(14, 11)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(481, 496)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' lblBoleta
        ' 
        lblBoleta.AutoSize = True
        lblBoleta.Location = New Point(38, 12)
        lblBoleta.Name = "lblBoleta"
        lblBoleta.Size = New Size(71, 20)
        lblBoleta.TabIndex = 23
        lblBoleta.Text = "lblBoleta"
        ' 
        ' btnGenerarBoleta
        ' 
        btnGenerarBoleta.Location = New Point(382, 429)
        btnGenerarBoleta.Name = "btnGenerarBoleta"
        btnGenerarBoleta.Size = New Size(93, 29)
        btnGenerarBoleta.TabIndex = 22
        btnGenerarBoleta.Text = "Boleta"
        btnGenerarBoleta.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarVenta
        ' 
        btnEliminarVenta.Location = New Point(382, 383)
        btnEliminarVenta.Name = "btnEliminarVenta"
        btnEliminarVenta.Size = New Size(93, 29)
        btnEliminarVenta.TabIndex = 21
        btnEliminarVenta.Text = "Eliminar "
        btnEliminarVenta.UseVisualStyleBackColor = True
        ' 
        ' lblDatosCliente
        ' 
        lblDatosCliente.AutoSize = True
        lblDatosCliente.Location = New Point(17, 353)
        lblDatosCliente.Name = "lblDatosCliente"
        lblDatosCliente.Size = New Size(106, 20)
        lblDatosCliente.TabIndex = 20
        lblDatosCliente.Text = "Datos Cliente:"
        ' 
        ' btEditarVenta
        ' 
        btEditarVenta.Location = New Point(382, 344)
        btEditarVenta.Name = "btEditarVenta"
        btEditarVenta.Size = New Size(93, 29)
        btEditarVenta.TabIndex = 19
        btEditarVenta.Text = "Editar "
        btEditarVenta.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarVenta
        ' 
        btnRegistrarVenta.Location = New Point(382, 303)
        btnRegistrarVenta.Name = "btnRegistrarVenta"
        btnRegistrarVenta.Size = New Size(93, 29)
        btnRegistrarVenta.TabIndex = 18
        btnRegistrarVenta.Text = "Registrar "
        btnRegistrarVenta.UseVisualStyleBackColor = True
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(399, 90)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(56, 27)
        txtStock.TabIndex = 17
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(399, 50)
        txtId.Name = "txtId"
        txtId.Size = New Size(56, 27)
        txtId.TabIndex = 16
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblStock.Location = New Point(352, 97)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(47, 20)
        lblStock.TabIndex = 15
        lblStock.Text = "Stock"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblID.Location = New Point(358, 57)
        lblID.Name = "lblID"
        lblID.Size = New Size(25, 20)
        lblID.TabIndex = 14
        lblID.Text = "ID"
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(177, 305)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(147, 27)
        txtTotal.TabIndex = 13
        ' 
        ' lblmensajeIVA
        ' 
        lblmensajeIVA.AutoSize = True
        lblmensajeIVA.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblmensajeIVA.Location = New Point(166, 267)
        lblmensajeIVA.Name = "lblmensajeIVA"
        lblmensajeIVA.Size = New Size(190, 17)
        lblmensajeIVA.TabIndex = 12
        lblmensajeIVA.Text = "Esta compra esta sujeto a IVA"
        ' 
        ' txtMontoNeto
        ' 
        txtMontoNeto.Location = New Point(177, 237)
        txtMontoNeto.Name = "txtMontoNeto"
        txtMontoNeto.Size = New Size(151, 27)
        txtMontoNeto.TabIndex = 11
        ' 
        ' dtpFechaVenta
        ' 
        dtpFechaVenta.Location = New Point(177, 193)
        dtpFechaVenta.Name = "dtpFechaVenta"
        dtpFechaVenta.Size = New Size(151, 27)
        dtpFechaVenta.TabIndex = 10
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(177, 149)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(151, 27)
        txtCliente.TabIndex = 9
        ' 
        ' txtCantidadVendida
        ' 
        txtCantidadVendida.Location = New Point(177, 105)
        txtCantidadVendida.Name = "txtCantidadVendida"
        txtCantidadVendida.Size = New Size(151, 27)
        txtCantidadVendida.TabIndex = 8
        ' 
        ' cmbNombreRepuesto
        ' 
        cmbNombreRepuesto.FormattingEnabled = True
        cmbNombreRepuesto.Location = New Point(177, 57)
        cmbNombreRepuesto.Name = "cmbNombreRepuesto"
        cmbNombreRepuesto.Size = New Size(151, 28)
        cmbNombreRepuesto.TabIndex = 7
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTotal.Location = New Point(17, 305)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(93, 20)
        lblTotal.TabIndex = 6
        lblTotal.Text = "Monto total"
        ' 
        ' lblNomRepuesto
        ' 
        lblNomRepuesto.AutoSize = True
        lblNomRepuesto.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNomRepuesto.Location = New Point(17, 65)
        lblNomRepuesto.Name = "lblNomRepuesto"
        lblNomRepuesto.Size = New Size(158, 20)
        lblNomRepuesto.TabIndex = 5
        lblNomRepuesto.Text = "Nombre del repuesto"
        ' 
        ' lblCntVender
        ' 
        lblCntVender.AutoSize = True
        lblCntVender.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblCntVender.Location = New Point(17, 108)
        lblCntVender.Name = "lblCntVender"
        lblCntVender.Size = New Size(135, 20)
        lblCntVender.TabIndex = 4
        lblCntVender.Text = "Cantidad a vender"
        ' 
        ' lblRut
        ' 
        lblRut.AutoSize = True
        lblRut.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblRut.Location = New Point(17, 152)
        lblRut.Name = "lblRut"
        lblRut.Size = New Size(86, 20)
        lblRut.TabIndex = 3
        lblRut.Text = "Rut Cliente"
        ' 
        ' lblFecVenta
        ' 
        lblFecVenta.AutoSize = True
        lblFecVenta.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblFecVenta.Location = New Point(17, 200)
        lblFecVenta.Name = "lblFecVenta"
        lblFecVenta.Size = New Size(113, 20)
        lblFecVenta.TabIndex = 2
        lblFecVenta.Text = "Fecha de venta"
        ' 
        ' lblNeto
        ' 
        lblNeto.AutoSize = True
        lblNeto.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNeto.Location = New Point(17, 240)
        lblNeto.Name = "lblNeto"
        lblNeto.Size = New Size(92, 20)
        lblNeto.TabIndex = 1
        lblNeto.Text = "Monto neto"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(173, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(219, 25)
        Label7.TabIndex = 0
        Label7.Text = "Registro de nueva venta"
        ' 
        ' panelSiniestro
        ' 
        panelSiniestro.Location = New Point(9, 76)
        panelSiniestro.Margin = New Padding(3, 4, 3, 4)
        panelSiniestro.Name = "panelSiniestro"
        panelSiniestro.Size = New Size(903, 523)
        panelSiniestro.TabIndex = 2
        ' 
        ' panelGestionServicios
        ' 
        panelGestionServicios.Location = New Point(9, 76)
        panelGestionServicios.Margin = New Padding(3, 4, 3, 4)
        panelGestionServicios.Name = "panelGestionServicios"
        panelGestionServicios.Size = New Size(903, 523)
        panelGestionServicios.TabIndex = 4
        ' 
        ' panelSoliServicios
        ' 
        panelSoliServicios.Location = New Point(9, 76)
        panelSoliServicios.Margin = New Padding(3, 4, 3, 4)
        panelSoliServicios.Name = "panelSoliServicios"
        panelSoliServicios.Size = New Size(903, 523)
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
        panelRepuestos.Location = New Point(9, 76)
        panelRepuestos.Margin = New Padding(3, 4, 3, 4)
        panelRepuestos.Name = "panelRepuestos"
        panelRepuestos.Size = New Size(903, 523)
        panelRepuestos.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(278, 168)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 20
        Label6.Text = "Nombre"
        ' 
        ' TextBoxNombreVer
        ' 
        TextBoxNombreVer.Location = New Point(366, 161)
        TextBoxNombreVer.Name = "TextBoxNombreVer"
        TextBoxNombreVer.Size = New Size(217, 27)
        TextBoxNombreVer.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(459, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 18
        Label5.Text = "Ver todo los repuesto"
        ' 
        ' ComboBoxRepuestos
        ' 
        ComboBoxRepuestos.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxRepuestos.FormattingEnabled = True
        ComboBoxRepuestos.Location = New Point(402, 44)
        ComboBoxRepuestos.Name = "ComboBoxRepuestos"
        ComboBoxRepuestos.Size = New Size(275, 28)
        ComboBoxRepuestos.TabIndex = 16
        ' 
        ' ButtonGuardarRepuesto
        ' 
        ButtonGuardarRepuesto.BackColor = SystemColors.HotTrack
        ButtonGuardarRepuesto.Location = New Point(555, 420)
        ButtonGuardarRepuesto.Name = "ButtonGuardarRepuesto"
        ButtonGuardarRepuesto.Size = New Size(158, 68)
        ButtonGuardarRepuesto.TabIndex = 15
        ButtonGuardarRepuesto.Text = "Guardar"
        ButtonGuardarRepuesto.UseVisualStyleBackColor = False
        ' 
        ' ButtonEliminarRepuesto
        ' 
        ButtonEliminarRepuesto.BackColor = Color.Red
        ButtonEliminarRepuesto.Enabled = False
        ButtonEliminarRepuesto.Location = New Point(293, 420)
        ButtonEliminarRepuesto.Name = "ButtonEliminarRepuesto"
        ButtonEliminarRepuesto.Size = New Size(161, 68)
        ButtonEliminarRepuesto.TabIndex = 14
        ButtonEliminarRepuesto.Text = "Eliminar "
        ButtonEliminarRepuesto.UseVisualStyleBackColor = False
        ' 
        ' ButtonEditarRepuesto
        ' 
        ButtonEditarRepuesto.BackColor = Color.Olive
        ButtonEditarRepuesto.Enabled = False
        ButtonEditarRepuesto.Location = New Point(31, 420)
        ButtonEditarRepuesto.Name = "ButtonEditarRepuesto"
        ButtonEditarRepuesto.Size = New Size(170, 68)
        ButtonEditarRepuesto.TabIndex = 13
        ButtonEditarRepuesto.Text = "Editar"
        ButtonEditarRepuesto.UseVisualStyleBackColor = False
        ' 
        ' ButtonLimpiarRepuesto
        ' 
        ButtonLimpiarRepuesto.BackColor = SystemColors.ControlDarkDark
        ButtonLimpiarRepuesto.Location = New Point(731, 143)
        ButtonLimpiarRepuesto.Name = "ButtonLimpiarRepuesto"
        ButtonLimpiarRepuesto.Size = New Size(133, 92)
        ButtonLimpiarRepuesto.TabIndex = 12
        ButtonLimpiarRepuesto.Text = "Limpiar Campos"
        ButtonLimpiarRepuesto.UseVisualStyleBackColor = False
        ' 
        ' ButtonConsultarRepuesto
        ' 
        ButtonConsultarRepuesto.BackColor = SystemColors.ActiveCaption
        ButtonConsultarRepuesto.Location = New Point(731, 23)
        ButtonConsultarRepuesto.Name = "ButtonConsultarRepuesto"
        ButtonConsultarRepuesto.Size = New Size(133, 92)
        ButtonConsultarRepuesto.TabIndex = 11
        ButtonConsultarRepuesto.Text = "Consultar"
        ButtonConsultarRepuesto.UseVisualStyleBackColor = False
        ' 
        ' TextBoxRepuestoDescripcion
        ' 
        TextBoxRepuestoDescripcion.Location = New Point(539, 343)
        TextBoxRepuestoDescripcion.Name = "TextBoxRepuestoDescripcion"
        TextBoxRepuestoDescripcion.Size = New Size(209, 27)
        TextBoxRepuestoDescripcion.TabIndex = 10
        TextBoxRepuestoDescripcion.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxRepuestoPrecio
        ' 
        TextBoxRepuestoPrecio.Location = New Point(278, 343)
        TextBoxRepuestoPrecio.Name = "TextBoxRepuestoPrecio"
        TextBoxRepuestoPrecio.Size = New Size(213, 27)
        TextBoxRepuestoPrecio.TabIndex = 9
        TextBoxRepuestoPrecio.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxRepuestoCantidad
        ' 
        TextBoxRepuestoCantidad.Location = New Point(40, 343)
        TextBoxRepuestoCantidad.Name = "TextBoxRepuestoCantidad"
        TextBoxRepuestoCantidad.Size = New Size(187, 27)
        TextBoxRepuestoCantidad.TabIndex = 8
        TextBoxRepuestoCantidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxBuscarRepuestoNombre
        ' 
        TextBoxBuscarRepuestoNombre.Location = New Point(187, 44)
        TextBoxBuscarRepuestoNombre.Name = "TextBoxBuscarRepuestoNombre"
        TextBoxBuscarRepuestoNombre.Size = New Size(199, 27)
        TextBoxBuscarRepuestoNombre.TabIndex = 7
        ' 
        ' TextBoxBuscarRepuestoID
        ' 
        TextBoxBuscarRepuestoID.Location = New Point(71, 161)
        TextBoxBuscarRepuestoID.Name = "TextBoxBuscarRepuestoID"
        TextBoxBuscarRepuestoID.Size = New Size(181, 27)
        TextBoxBuscarRepuestoID.TabIndex = 6
        ' 
        ' LabelRepuestoID
        ' 
        LabelRepuestoID.AutoSize = True
        LabelRepuestoID.Location = New Point(31, 164)
        LabelRepuestoID.Name = "LabelRepuestoID"
        LabelRepuestoID.Size = New Size(28, 20)
        LabelRepuestoID.TabIndex = 4
        LabelRepuestoID.Text = " ID"
        ' 
        ' LabelRepuestoCantidad
        ' 
        LabelRepuestoCantidad.AutoSize = True
        LabelRepuestoCantidad.Location = New Point(46, 291)
        LabelRepuestoCantidad.Name = "LabelRepuestoCantidad"
        LabelRepuestoCantidad.Size = New Size(129, 20)
        LabelRepuestoCantidad.TabIndex = 3
        LabelRepuestoCantidad.Text = "Cantidad en Stock"
        ' 
        ' LabelRepuestoPrecio
        ' 
        LabelRepuestoPrecio.AutoSize = True
        LabelRepuestoPrecio.Location = New Point(335, 291)
        LabelRepuestoPrecio.Name = "LabelRepuestoPrecio"
        LabelRepuestoPrecio.Size = New Size(54, 20)
        LabelRepuestoPrecio.TabIndex = 2
        LabelRepuestoPrecio.Text = "Precio "
        ' 
        ' LabelRepuestoDescripcion
        ' 
        LabelRepuestoDescripcion.AutoSize = True
        LabelRepuestoDescripcion.Location = New Point(590, 291)
        LabelRepuestoDescripcion.Name = "LabelRepuestoDescripcion"
        LabelRepuestoDescripcion.Size = New Size(77, 20)
        LabelRepuestoDescripcion.TabIndex = 1
        LabelRepuestoDescripcion.Text = "Proveedor"
        ' 
        ' LabelRepuestoNombre
        ' 
        LabelRepuestoNombre.AutoSize = True
        LabelRepuestoNombre.Location = New Point(14, 48)
        LabelRepuestoNombre.Name = "LabelRepuestoNombre"
        LabelRepuestoNombre.Size = New Size(167, 20)
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
        panelUsuario.Location = New Point(9, 76)
        panelUsuario.Margin = New Padding(3, 4, 3, 4)
        panelUsuario.Name = "panelUsuario"
        panelUsuario.Size = New Size(903, 523)
        panelUsuario.TabIndex = 8
        ' 
        ' comboBoxTipo
        ' 
        comboBoxTipo.FormattingEnabled = True
        comboBoxTipo.Location = New Point(566, 223)
        comboBoxTipo.Margin = New Padding(3, 4, 3, 4)
        comboBoxTipo.Name = "comboBoxTipo"
        comboBoxTipo.Size = New Size(183, 28)
        comboBoxTipo.TabIndex = 16
        ' 
        ' ButtonGuardarUsuario
        ' 
        ButtonGuardarUsuario.Location = New Point(366, 403)
        ButtonGuardarUsuario.Name = "ButtonGuardarUsuario"
        ButtonGuardarUsuario.Size = New Size(147, 67)
        ButtonGuardarUsuario.TabIndex = 13
        ButtonGuardarUsuario.Text = "Guardar Usuario"
        ButtonGuardarUsuario.UseVisualStyleBackColor = True
        ' 
        ' ButtonEliminarUsuario
        ' 
        ButtonEliminarUsuario.BackColor = Color.Transparent
        ButtonEliminarUsuario.Location = New Point(633, 403)
        ButtonEliminarUsuario.Name = "ButtonEliminarUsuario"
        ButtonEliminarUsuario.Size = New Size(137, 67)
        ButtonEliminarUsuario.TabIndex = 12
        ButtonEliminarUsuario.Text = "Eliminar Usuario"
        ButtonEliminarUsuario.UseVisualStyleBackColor = False
        ' 
        ' ButtonEditar
        ' 
        ButtonEditar.Location = New Point(107, 403)
        ButtonEditar.Name = "ButtonEditar"
        ButtonEditar.Size = New Size(147, 71)
        ButtonEditar.TabIndex = 11
        ButtonEditar.Text = "Editar"
        ButtonEditar.UseVisualStyleBackColor = True
        ' 
        ' TextBoxCorreo
        ' 
        TextBoxCorreo.Location = New Point(566, 309)
        TextBoxCorreo.Name = "TextBoxCorreo"
        TextBoxCorreo.Size = New Size(183, 27)
        TextBoxCorreo.TabIndex = 9
        ' 
        ' LabelTipo
        ' 
        LabelTipo.AutoSize = True
        LabelTipo.BackColor = Color.Transparent
        LabelTipo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTipo.ForeColor = SystemColors.ControlLight
        LabelTipo.Location = New Point(515, 227)
        LabelTipo.Name = "LabelTipo"
        LabelTipo.Size = New Size(40, 20)
        LabelTipo.TabIndex = 8
        LabelTipo.Text = "Tipo"
        ' 
        ' LabelCorreo
        ' 
        LabelCorreo.AutoSize = True
        LabelCorreo.BackColor = Color.Transparent
        LabelCorreo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelCorreo.ForeColor = SystemColors.ControlLight
        LabelCorreo.Location = New Point(501, 309)
        LabelCorreo.Name = "LabelCorreo"
        LabelCorreo.Size = New Size(56, 20)
        LabelCorreo.TabIndex = 7
        LabelCorreo.Text = "Correo"
        ' 
        ' TextBoxContraseña
        ' 
        TextBoxContraseña.Location = New Point(171, 309)
        TextBoxContraseña.Name = "TextBoxContraseña"
        TextBoxContraseña.Size = New Size(199, 27)
        TextBoxContraseña.TabIndex = 6
        ' 
        ' LabelContraseña
        ' 
        LabelContraseña.AutoSize = True
        LabelContraseña.BackColor = Color.Transparent
        LabelContraseña.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelContraseña.ForeColor = SystemColors.ControlLight
        LabelContraseña.Location = New Point(71, 309)
        LabelContraseña.Name = "LabelContraseña"
        LabelContraseña.Size = New Size(88, 20)
        LabelContraseña.TabIndex = 5
        LabelContraseña.Text = "Contraseña"
        ' 
        ' TextBoxRutUsuario
        ' 
        TextBoxRutUsuario.Enabled = False
        TextBoxRutUsuario.Location = New Point(171, 227)
        TextBoxRutUsuario.Name = "TextBoxRutUsuario"
        TextBoxRutUsuario.Size = New Size(199, 27)
        TextBoxRutUsuario.TabIndex = 4
        ' 
        ' LabelRutUsuario
        ' 
        LabelRutUsuario.AutoSize = True
        LabelRutUsuario.BackColor = Color.Transparent
        LabelRutUsuario.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelRutUsuario.ForeColor = SystemColors.Control
        LabelRutUsuario.Location = New Point(48, 231)
        LabelRutUsuario.Name = "LabelRutUsuario"
        LabelRutUsuario.Size = New Size(117, 20)
        LabelRutUsuario.TabIndex = 2
        LabelRutUsuario.Text = "Rut del Usuario"
        ' 
        ' TextBoxRut
        ' 
        TextBoxRut.Location = New Point(203, 88)
        TextBoxRut.Name = "TextBoxRut"
        TextBoxRut.Size = New Size(204, 27)
        TextBoxRut.TabIndex = 1
        ' 
        ' buttonConsultarRut
        ' 
        buttonConsultarRut.BackColor = Color.Transparent
        buttonConsultarRut.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonConsultarRut.Location = New Point(459, 72)
        buttonConsultarRut.Name = "buttonConsultarRut"
        buttonConsultarRut.Size = New Size(123, 67)
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
        panelEncabezadoUsuario.Location = New Point(0, 23)
        panelEncabezadoUsuario.Margin = New Padding(3, 4, 3, 4)
        panelEncabezadoUsuario.Name = "panelEncabezadoUsuario"
        panelEncabezadoUsuario.Size = New Size(899, 167)
        panelEncabezadoUsuario.TabIndex = 15
        ' 
        ' limpiarCamposGestionUsuarios
        ' 
        limpiarCamposGestionUsuarios.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        limpiarCamposGestionUsuarios.Location = New Point(610, 49)
        limpiarCamposGestionUsuarios.Margin = New Padding(3, 4, 3, 4)
        limpiarCamposGestionUsuarios.Name = "limpiarCamposGestionUsuarios"
        limpiarCamposGestionUsuarios.Size = New Size(107, 67)
        limpiarCamposGestionUsuarios.TabIndex = 15
        limpiarCamposGestionUsuarios.Text = "Limpiar Campos"
        limpiarCamposGestionUsuarios.UseVisualStyleBackColor = True
        ' 
        ' buttonMostrarUsuarios
        ' 
        buttonMostrarUsuarios.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonMostrarUsuarios.Location = New Point(736, 51)
        buttonMostrarUsuarios.Name = "buttonMostrarUsuarios"
        buttonMostrarUsuarios.Size = New Size(128, 65)
        buttonMostrarUsuarios.TabIndex = 14
        buttonMostrarUsuarios.Text = "Ver Todos los Usuarios"
        buttonMostrarUsuarios.UseVisualStyleBackColor = True
        ' 
        ' LabelRut
        ' 
        LabelRut.AutoSize = True
        LabelRut.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelRut.ForeColor = Color.Green
        LabelRut.Location = New Point(74, 53)
        LabelRut.Name = "LabelRut"
        LabelRut.Size = New Size(98, 60)
        LabelRut.TabIndex = 3
        LabelRut.Text = "Rut"
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondoLogin01
        ClientSize = New Size(914, 637)
        Controls.Add(panelVentaRepuestos)
        Controls.Add(panelRepuestos)
        Controls.Add(panelUsuario)
        Controls.Add(panelGestionServicios)
        Controls.Add(panelSiniestro)
        Controls.Add(panelSoliServicios)
        Controls.Add(panelHome)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
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
End Class
