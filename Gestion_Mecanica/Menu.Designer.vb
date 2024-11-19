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
        buttonClientes = New Button()
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
        buttonConsuRutSin = New Button()
        textBoxConsRutSin = New TextBox()
        labelTituConsSin = New Label()
        panelDetalleSiniestro = New Panel()
        panelAgreSis = New Panel()
        buttonCancelSin = New Button()
        buttonAgrSinConf = New Button()
        labelTituloAgrSin = New Label()
        comboBoxEstadSegAgrSin = New ComboBox()
        labelEstadSeguSin = New Label()
        comboBoxCompaAgrSin = New ComboBox()
        labelCompSin = New Label()
        dateTimePickerFecSin = New DateTimePicker()
        labelFechaSin = New Label()
        textBoxDetallAgrSin = New TextBox()
        labelDetaSin = New Label()
        textBoxTelAgrSin = New TextBox()
        labelTelAgrSis = New Label()
        textBoxApeMatAgrSin = New TextBox()
        labelApeMatAgrSin = New Label()
        textBoxApePatAgrSin = New TextBox()
        labelApelliPatAgrSin = New Label()
        comboBoxRutAgrSin = New ComboBox()
        textBoxNomAgrSin = New TextBox()
        labelNomAgrSin = New Label()
        labelRutAgrSin = New Label()
        panelDetalleSinSelec = New Panel()
        label13PanSin = New Label()
        labelDetalleSin = New Label()
        labelTituloDetalleSin = New Label()
        buttonCerrarPanDetSin = New Button()
        buttonFinalizado = New Button()
        buttonPendiente = New Button()
        buttonActivo = New Button()
        nomCompSin = New Label()
        labelNomCompDetSin = New Label()
        labelTituloCompDetSis = New Label()
        labelEstadoSeguSis = New Label()
        labelSegDetSin = New Label()
        pictureBoxEstadSin = New PictureBox()
        labelEstadDetSin = New Label()
        textBoxComuDetSis = New TextBox()
        textBoxTelDetSis = New TextBox()
        textBoxDireDetSis = New TextBox()
        textBoxRutDetSis = New TextBox()
        textBoxApeMatDetSis = New TextBox()
        textBoxApePatDetSis = New TextBox()
        textBoxNomDetSis = New TextBox()
        panelDatoDetSin = New Panel()
        labelComuDetSin = New Label()
        labelTelDetSin = New Label()
        labelDirPanSin = New Label()
        labelRutVerSin = New Label()
        labelApeMatVerSin = New Label()
        labelNomSin = New Label()
        labelApePatSin = New Label()
        tituloVerDetalleSiniestros = New Label()
        labelTituloSiniestros = New Label()
        dataGridViewSiniestro = New DataGridView()
        buttonEliminarSiniestro = New Button()
        buttonAgregarSiniestro = New Button()
        buttonVerDetallesSiniestro = New Button()
        panelGestionServicios = New Panel()
        panelClientes = New Panel()
        panelThreeCrudCli = New Panel()
        comboBoxBuscCli = New ComboBox()
        labelBuscTitRut = New Label()
        buttonLimpCli = New Button()
        buttonEditCli = New Button()
        buttonElimCli = New Button()
        buttonAgreCli = New Button()
        buttonVerCli = New Button()
        textBoxComuCli = New TextBox()
        textBoxTelefCli = New TextBox()
        textBoxDirecCli = New TextBox()
        textBoxApeMatCli = New TextBox()
        textBoxApePatCli = New TextBox()
        textBoxNomCli = New TextBox()
        textBoxRutCli = New TextBox()
        panelTitulClientes = New Panel()
        labelComunCli = New Label()
        labelTelefCli = New Label()
        labelDirecCli = New Label()
        labelApeMatCli = New Label()
        labelApePatCli = New Label()
        labelNomCli = New Label()
        labelRutCli = New Label()
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
        panelDetalleSiniestro.SuspendLayout()
        panelAgreSis.SuspendLayout()
        panelDetalleSinSelec.SuspendLayout()
        CType(pictureBoxEstadSin, ComponentModel.ISupportInitialize).BeginInit()
        panelDatoDetSin.SuspendLayout()
        CType(dataGridViewSiniestro, ComponentModel.ISupportInitialize).BeginInit()
        panelClientes.SuspendLayout()
        panelThreeCrudCli.SuspendLayout()
        panelTitulClientes.SuspendLayout()
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
        Panel1.Controls.Add(buttonClientes)
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
        ' buttonClientes
        ' 
        buttonClientes.Location = New Point(501, 0)
        buttonClientes.Name = "buttonClientes"
        buttonClientes.Size = New Size(114, 48)
        buttonClientes.TabIndex = 3
        buttonClientes.Text = "Clientes"
        buttonClientes.UseVisualStyleBackColor = True
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
        panelSiniestro.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        panelSiniestro.Controls.Add(panelDetalleSiniestro)
        panelSiniestro.Controls.Add(labelTituloSiniestros)
        panelSiniestro.Controls.Add(dataGridViewSiniestro)
        panelSiniestro.Controls.Add(buttonEliminarSiniestro)
        panelSiniestro.Controls.Add(buttonAgregarSiniestro)
        panelSiniestro.Controls.Add(buttonVerDetallesSiniestro)
        panelSiniestro.Controls.Add(labelTituConsSin)
        panelSiniestro.Controls.Add(textBoxConsRutSin)
        panelSiniestro.Controls.Add(buttonConsuRutSin)
        panelSiniestro.Location = New Point(8, 57)
        panelSiniestro.Name = "panelSiniestro"
        panelSiniestro.Size = New Size(790, 392)
        panelSiniestro.TabIndex = 2
        ' 
        ' buttonConsuRutSin
        ' 
        buttonConsuRutSin.Location = New Point(678, 30)
        buttonConsuRutSin.Name = "buttonConsuRutSin"
        buttonConsuRutSin.Size = New Size(75, 23)
        buttonConsuRutSin.TabIndex = 9
        buttonConsuRutSin.Text = "Consultar"
        buttonConsuRutSin.UseVisualStyleBackColor = True
        ' 
        ' textBoxConsRutSin
        ' 
        textBoxConsRutSin.Location = New Point(557, 30)
        textBoxConsRutSin.Name = "textBoxConsRutSin"
        textBoxConsRutSin.Size = New Size(100, 23)
        textBoxConsRutSin.TabIndex = 8
        ' 
        ' labelTituConsSin
        ' 
        labelTituConsSin.AutoSize = True
        labelTituConsSin.Location = New Point(451, 33)
        labelTituConsSin.Name = "labelTituConsSin"
        labelTituConsSin.Size = New Size(100, 15)
        labelTituConsSin.TabIndex = 7
        labelTituConsSin.Text = "Consultar por rut:"
        ' 
        ' panelDetalleSiniestro
        ' 
        panelDetalleSiniestro.BackColor = Color.Indigo
        panelDetalleSiniestro.Controls.Add(panelAgreSis)
        panelDetalleSiniestro.Controls.Add(panelDetalleSinSelec)
        panelDetalleSiniestro.Controls.Add(tituloVerDetalleSiniestros)
        panelDetalleSiniestro.Location = New Point(17, 11)
        panelDetalleSiniestro.Name = "panelDetalleSiniestro"
        panelDetalleSiniestro.Size = New Size(763, 293)
        panelDetalleSiniestro.TabIndex = 6
        panelDetalleSiniestro.Visible = False
        ' 
        ' panelAgreSis
        ' 
        panelAgreSis.Controls.Add(buttonCancelSin)
        panelAgreSis.Controls.Add(buttonAgrSinConf)
        panelAgreSis.Controls.Add(labelTituloAgrSin)
        panelAgreSis.Controls.Add(comboBoxEstadSegAgrSin)
        panelAgreSis.Controls.Add(labelEstadSeguSin)
        panelAgreSis.Controls.Add(comboBoxCompaAgrSin)
        panelAgreSis.Controls.Add(labelCompSin)
        panelAgreSis.Controls.Add(dateTimePickerFecSin)
        panelAgreSis.Controls.Add(labelFechaSin)
        panelAgreSis.Controls.Add(textBoxDetallAgrSin)
        panelAgreSis.Controls.Add(labelDetaSin)
        panelAgreSis.Controls.Add(textBoxTelAgrSin)
        panelAgreSis.Controls.Add(labelTelAgrSis)
        panelAgreSis.Controls.Add(textBoxApeMatAgrSin)
        panelAgreSis.Controls.Add(labelApeMatAgrSin)
        panelAgreSis.Controls.Add(textBoxApePatAgrSin)
        panelAgreSis.Controls.Add(labelApelliPatAgrSin)
        panelAgreSis.Controls.Add(comboBoxRutAgrSin)
        panelAgreSis.Controls.Add(textBoxNomAgrSin)
        panelAgreSis.Controls.Add(labelNomAgrSin)
        panelAgreSis.Controls.Add(labelRutAgrSin)
        panelAgreSis.Location = New Point(0, 3)
        panelAgreSis.Name = "panelAgreSis"
        panelAgreSis.Size = New Size(763, 292)
        panelAgreSis.TabIndex = 2
        panelAgreSis.Visible = False
        ' 
        ' buttonCancelSin
        ' 
        buttonCancelSin.Location = New Point(50, 260)
        buttonCancelSin.Name = "buttonCancelSin"
        buttonCancelSin.Size = New Size(75, 23)
        buttonCancelSin.TabIndex = 21
        buttonCancelSin.Text = "Cancelar"
        buttonCancelSin.UseVisualStyleBackColor = True
        ' 
        ' buttonAgrSinConf
        ' 
        buttonAgrSinConf.Location = New Point(654, 257)
        buttonAgrSinConf.Name = "buttonAgrSinConf"
        buttonAgrSinConf.Size = New Size(75, 23)
        buttonAgrSinConf.TabIndex = 20
        buttonAgrSinConf.Text = "Agregar"
        buttonAgrSinConf.UseVisualStyleBackColor = True
        ' 
        ' labelTituloAgrSin
        ' 
        labelTituloAgrSin.AutoSize = True
        labelTituloAgrSin.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        labelTituloAgrSin.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTituloAgrSin.ForeColor = SystemColors.Control
        labelTituloAgrSin.Location = New Point(281, 7)
        labelTituloAgrSin.Name = "labelTituloAgrSin"
        labelTituloAgrSin.Size = New Size(168, 25)
        labelTituloAgrSin.TabIndex = 19
        labelTituloAgrSin.Text = "Agregar Siniestro"
        ' 
        ' comboBoxEstadSegAgrSin
        ' 
        comboBoxEstadSegAgrSin.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxEstadSegAgrSin.FormattingEnabled = True
        comboBoxEstadSegAgrSin.Items.AddRange(New Object() {"Seguro Vigente", "Seguro Caducado"})
        comboBoxEstadSegAgrSin.Location = New Point(448, 163)
        comboBoxEstadSegAgrSin.Name = "comboBoxEstadSegAgrSin"
        comboBoxEstadSegAgrSin.Size = New Size(228, 23)
        comboBoxEstadSegAgrSin.TabIndex = 18
        ' 
        ' labelEstadSeguSin
        ' 
        labelEstadSeguSin.AutoSize = True
        labelEstadSeguSin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        labelEstadSeguSin.Location = New Point(353, 171)
        labelEstadSeguSin.Name = "labelEstadSeguSin"
        labelEstadSeguSin.Size = New Size(84, 15)
        labelEstadSeguSin.TabIndex = 17
        labelEstadSeguSin.Text = "Estado seguro:"
        ' 
        ' comboBoxCompaAgrSin
        ' 
        comboBoxCompaAgrSin.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxCompaAgrSin.FormattingEnabled = True
        comboBoxCompaAgrSin.Location = New Point(448, 125)
        comboBoxCompaAgrSin.Name = "comboBoxCompaAgrSin"
        comboBoxCompaAgrSin.Size = New Size(228, 23)
        comboBoxCompaAgrSin.TabIndex = 16
        ' 
        ' labelCompSin
        ' 
        labelCompSin.AutoSize = True
        labelCompSin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        labelCompSin.Location = New Point(372, 130)
        labelCompSin.Name = "labelCompSin"
        labelCompSin.Size = New Size(65, 15)
        labelCompSin.TabIndex = 15
        labelCompSin.Text = "Compañia:"
        ' 
        ' dateTimePickerFecSin
        ' 
        dateTimePickerFecSin.Location = New Point(448, 87)
        dateTimePickerFecSin.Name = "dateTimePickerFecSin"
        dateTimePickerFecSin.Size = New Size(228, 23)
        dateTimePickerFecSin.TabIndex = 14
        dateTimePickerFecSin.Value = New Date(2024, 11, 11, 0, 0, 0, 0)
        ' 
        ' labelFechaSin
        ' 
        labelFechaSin.AutoSize = True
        labelFechaSin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        labelFechaSin.Location = New Point(396, 94)
        labelFechaSin.Name = "labelFechaSin"
        labelFechaSin.Size = New Size(41, 15)
        labelFechaSin.TabIndex = 13
        labelFechaSin.Text = "Fecha:"
        ' 
        ' textBoxDetallAgrSin
        ' 
        textBoxDetallAgrSin.Location = New Point(448, 48)
        textBoxDetallAgrSin.Name = "textBoxDetallAgrSin"
        textBoxDetallAgrSin.Size = New Size(228, 23)
        textBoxDetallAgrSin.TabIndex = 12
        ' 
        ' labelDetaSin
        ' 
        labelDetaSin.AutoSize = True
        labelDetaSin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        labelDetaSin.Location = New Point(391, 56)
        labelDetaSin.Name = "labelDetaSin"
        labelDetaSin.Size = New Size(46, 15)
        labelDetaSin.TabIndex = 11
        labelDetaSin.Text = "Detalle:"
        ' 
        ' textBoxTelAgrSin
        ' 
        textBoxTelAgrSin.Enabled = False
        textBoxTelAgrSin.Location = New Point(137, 211)
        textBoxTelAgrSin.Name = "textBoxTelAgrSin"
        textBoxTelAgrSin.ReadOnly = True
        textBoxTelAgrSin.Size = New Size(121, 23)
        textBoxTelAgrSin.TabIndex = 10
        ' 
        ' labelTelAgrSis
        ' 
        labelTelAgrSis.AutoSize = True
        labelTelAgrSis.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        labelTelAgrSis.Location = New Point(60, 214)
        labelTelAgrSis.Name = "labelTelAgrSis"
        labelTelAgrSis.Size = New Size(55, 15)
        labelTelAgrSis.TabIndex = 9
        labelTelAgrSis.Text = "Telefono:"
        ' 
        ' textBoxApeMatAgrSin
        ' 
        textBoxApeMatAgrSin.Enabled = False
        textBoxApeMatAgrSin.Location = New Point(137, 171)
        textBoxApeMatAgrSin.Name = "textBoxApeMatAgrSin"
        textBoxApeMatAgrSin.ReadOnly = True
        textBoxApeMatAgrSin.Size = New Size(121, 23)
        textBoxApeMatAgrSin.TabIndex = 8
        ' 
        ' labelApeMatAgrSin
        ' 
        labelApeMatAgrSin.AutoSize = True
        labelApeMatAgrSin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        labelApeMatAgrSin.Location = New Point(50, 176)
        labelApeMatAgrSin.Name = "labelApeMatAgrSin"
        labelApeMatAgrSin.Size = New Size(65, 15)
        labelApeMatAgrSin.TabIndex = 7
        labelApeMatAgrSin.Text = "ApellidoM:"
        ' 
        ' textBoxApePatAgrSin
        ' 
        textBoxApePatAgrSin.Enabled = False
        textBoxApePatAgrSin.Location = New Point(137, 133)
        textBoxApePatAgrSin.Name = "textBoxApePatAgrSin"
        textBoxApePatAgrSin.ReadOnly = True
        textBoxApePatAgrSin.Size = New Size(121, 23)
        textBoxApePatAgrSin.TabIndex = 6
        ' 
        ' labelApelliPatAgrSin
        ' 
        labelApelliPatAgrSin.AutoSize = True
        labelApelliPatAgrSin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        labelApelliPatAgrSin.Location = New Point(54, 138)
        labelApelliPatAgrSin.Name = "labelApelliPatAgrSin"
        labelApelliPatAgrSin.Size = New Size(61, 15)
        labelApelliPatAgrSin.TabIndex = 5
        labelApelliPatAgrSin.Text = "ApellidoP:"
        ' 
        ' comboBoxRutAgrSin
        ' 
        comboBoxRutAgrSin.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxRutAgrSin.FormattingEnabled = True
        comboBoxRutAgrSin.Location = New Point(137, 46)
        comboBoxRutAgrSin.Name = "comboBoxRutAgrSin"
        comboBoxRutAgrSin.Size = New Size(121, 23)
        comboBoxRutAgrSin.TabIndex = 4
        ' 
        ' textBoxNomAgrSin
        ' 
        textBoxNomAgrSin.Enabled = False
        textBoxNomAgrSin.Location = New Point(137, 90)
        textBoxNomAgrSin.Name = "textBoxNomAgrSin"
        textBoxNomAgrSin.ReadOnly = True
        textBoxNomAgrSin.Size = New Size(121, 23)
        textBoxNomAgrSin.TabIndex = 3
        ' 
        ' labelNomAgrSin
        ' 
        labelNomAgrSin.AutoSize = True
        labelNomAgrSin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        labelNomAgrSin.Location = New Point(61, 97)
        labelNomAgrSin.Name = "labelNomAgrSin"
        labelNomAgrSin.Size = New Size(54, 15)
        labelNomAgrSin.TabIndex = 2
        labelNomAgrSin.Text = "Nombre:"
        ' 
        ' labelRutAgrSin
        ' 
        labelRutAgrSin.AutoSize = True
        labelRutAgrSin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        labelRutAgrSin.Location = New Point(87, 51)
        labelRutAgrSin.Name = "labelRutAgrSin"
        labelRutAgrSin.Size = New Size(28, 15)
        labelRutAgrSin.TabIndex = 0
        labelRutAgrSin.Text = "Rut:"
        ' 
        ' panelDetalleSinSelec
        ' 
        panelDetalleSinSelec.BackColor = Color.LightSlateGray
        panelDetalleSinSelec.Controls.Add(label13PanSin)
        panelDetalleSinSelec.Controls.Add(labelDetalleSin)
        panelDetalleSinSelec.Controls.Add(labelTituloDetalleSin)
        panelDetalleSinSelec.Controls.Add(buttonCerrarPanDetSin)
        panelDetalleSinSelec.Controls.Add(buttonFinalizado)
        panelDetalleSinSelec.Controls.Add(buttonPendiente)
        panelDetalleSinSelec.Controls.Add(buttonActivo)
        panelDetalleSinSelec.Controls.Add(nomCompSin)
        panelDetalleSinSelec.Controls.Add(labelNomCompDetSin)
        panelDetalleSinSelec.Controls.Add(labelTituloCompDetSis)
        panelDetalleSinSelec.Controls.Add(labelEstadoSeguSis)
        panelDetalleSinSelec.Controls.Add(labelSegDetSin)
        panelDetalleSinSelec.Controls.Add(pictureBoxEstadSin)
        panelDetalleSinSelec.Controls.Add(labelEstadDetSin)
        panelDetalleSinSelec.Controls.Add(textBoxComuDetSis)
        panelDetalleSinSelec.Controls.Add(textBoxTelDetSis)
        panelDetalleSinSelec.Controls.Add(textBoxDireDetSis)
        panelDetalleSinSelec.Controls.Add(textBoxRutDetSis)
        panelDetalleSinSelec.Controls.Add(textBoxApeMatDetSis)
        panelDetalleSinSelec.Controls.Add(textBoxApePatDetSis)
        panelDetalleSinSelec.Controls.Add(textBoxNomDetSis)
        panelDetalleSinSelec.Controls.Add(panelDatoDetSin)
        panelDetalleSinSelec.Location = New Point(23, 50)
        panelDetalleSinSelec.Name = "panelDetalleSinSelec"
        panelDetalleSinSelec.Size = New Size(706, 230)
        panelDetalleSinSelec.TabIndex = 1
        panelDetalleSinSelec.Visible = False
        ' 
        ' label13PanSin
        ' 
        label13PanSin.AutoSize = True
        label13PanSin.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label13PanSin.Location = New Point(469, 14)
        label13PanSin.Name = "label13PanSin"
        label13PanSin.Size = New Size(143, 25)
        label13PanSin.TabIndex = 25
        label13PanSin.Text = "Rut Compañia:"
        ' 
        ' labelDetalleSin
        ' 
        labelDetalleSin.AutoSize = True
        labelDetalleSin.Location = New Point(376, 95)
        labelDetalleSin.Name = "labelDetalleSin"
        labelDetalleSin.Size = New Size(131, 15)
        labelDetalleSin.TabIndex = 24
        labelDetalleSin.Text = "detalle choque ejemplo"
        ' 
        ' labelTituloDetalleSin
        ' 
        labelTituloDetalleSin.AutoSize = True
        labelTituloDetalleSin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTituloDetalleSin.Location = New Point(308, 90)
        labelTituloDetalleSin.Name = "labelTituloDetalleSin"
        labelTituloDetalleSin.Size = New Size(69, 21)
        labelTituloDetalleSin.TabIndex = 23
        labelTituloDetalleSin.Text = "Detalle:"
        ' 
        ' buttonCerrarPanDetSin
        ' 
        buttonCerrarPanDetSin.Location = New Point(615, 199)
        buttonCerrarPanDetSin.Name = "buttonCerrarPanDetSin"
        buttonCerrarPanDetSin.Size = New Size(75, 23)
        buttonCerrarPanDetSin.TabIndex = 22
        buttonCerrarPanDetSin.Text = "Cerrar"
        buttonCerrarPanDetSin.UseVisualStyleBackColor = True
        ' 
        ' buttonFinalizado
        ' 
        buttonFinalizado.Location = New Point(519, 179)
        buttonFinalizado.Name = "buttonFinalizado"
        buttonFinalizado.Size = New Size(75, 23)
        buttonFinalizado.TabIndex = 21
        buttonFinalizado.Text = "Finalizado"
        buttonFinalizado.UseVisualStyleBackColor = True
        ' 
        ' buttonPendiente
        ' 
        buttonPendiente.Location = New Point(519, 130)
        buttonPendiente.Name = "buttonPendiente"
        buttonPendiente.Size = New Size(75, 23)
        buttonPendiente.TabIndex = 20
        buttonPendiente.Text = "Pendiente"
        buttonPendiente.UseVisualStyleBackColor = True
        ' 
        ' buttonActivo
        ' 
        buttonActivo.Location = New Point(519, 155)
        buttonActivo.Name = "buttonActivo"
        buttonActivo.Size = New Size(75, 23)
        buttonActivo.TabIndex = 19
        buttonActivo.Text = "Activo"
        buttonActivo.UseVisualStyleBackColor = True
        ' 
        ' nomCompSin
        ' 
        nomCompSin.AutoSize = True
        nomCompSin.Location = New Point(396, 59)
        nomCompSin.Name = "nomCompSin"
        nomCompSin.Size = New Size(51, 15)
        nomCompSin.TabIndex = 18
        nomCompSin.Text = "Nombre"
        ' 
        ' labelNomCompDetSin
        ' 
        labelNomCompDetSin.AutoSize = True
        labelNomCompDetSin.Location = New Point(609, 21)
        labelNomCompDetSin.Name = "labelNomCompDetSin"
        labelNomCompDetSin.Size = New Size(25, 15)
        labelNomCompDetSin.TabIndex = 17
        labelNomCompDetSin.Text = "Rut"
        ' 
        ' labelTituloCompDetSis
        ' 
        labelTituloCompDetSis.AutoSize = True
        labelTituloCompDetSis.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTituloCompDetSis.Location = New Point(300, 54)
        labelTituloCompDetSis.Name = "labelTituloCompDetSis"
        labelTituloCompDetSis.Size = New Size(92, 21)
        labelTituloCompDetSis.TabIndex = 16
        labelTituloCompDetSis.Text = "Compañia:"
        ' 
        ' labelEstadoSeguSis
        ' 
        labelEstadoSeguSis.AutoSize = True
        labelEstadoSeguSis.Location = New Point(376, 21)
        labelEstadoSeguSis.Name = "labelEstadoSeguSis"
        labelEstadoSeguSis.Size = New Size(87, 15)
        labelEstadoSeguSis.TabIndex = 15
        labelEstadoSeguSis.Text = "Seguro Vigente"
        ' 
        ' labelSegDetSin
        ' 
        labelSegDetSin.AutoSize = True
        labelSegDetSin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelSegDetSin.Location = New Point(308, 17)
        labelSegDetSin.Name = "labelSegDetSin"
        labelSegDetSin.Size = New Size(68, 21)
        labelSegDetSin.TabIndex = 14
        labelSegDetSin.Text = "Seguro:"
        ' 
        ' pictureBoxEstadSin
        ' 
        pictureBoxEstadSin.Location = New Point(448, 151)
        pictureBoxEstadSin.Name = "pictureBoxEstadSin"
        pictureBoxEstadSin.Size = New Size(63, 42)
        pictureBoxEstadSin.TabIndex = 13
        pictureBoxEstadSin.TabStop = False
        ' 
        ' labelEstadDetSin
        ' 
        labelEstadDetSin.AutoSize = True
        labelEstadDetSin.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelEstadDetSin.Location = New Point(324, 155)
        labelEstadDetSin.Name = "labelEstadDetSin"
        labelEstadDetSin.Size = New Size(111, 30)
        labelEstadDetSin.TabIndex = 12
        labelEstadDetSin.Text = "Pendiente"
        ' 
        ' textBoxComuDetSis
        ' 
        textBoxComuDetSis.Enabled = False
        textBoxComuDetSis.Location = New Point(132, 190)
        textBoxComuDetSis.Name = "textBoxComuDetSis"
        textBoxComuDetSis.Size = New Size(158, 23)
        textBoxComuDetSis.TabIndex = 11
        ' 
        ' textBoxTelDetSis
        ' 
        textBoxTelDetSis.Enabled = False
        textBoxTelDetSis.Location = New Point(132, 161)
        textBoxTelDetSis.Name = "textBoxTelDetSis"
        textBoxTelDetSis.Size = New Size(158, 23)
        textBoxTelDetSis.TabIndex = 10
        ' 
        ' textBoxDireDetSis
        ' 
        textBoxDireDetSis.Enabled = False
        textBoxDireDetSis.Location = New Point(132, 134)
        textBoxDireDetSis.Name = "textBoxDireDetSis"
        textBoxDireDetSis.Size = New Size(158, 23)
        textBoxDireDetSis.TabIndex = 9
        ' 
        ' textBoxRutDetSis
        ' 
        textBoxRutDetSis.Enabled = False
        textBoxRutDetSis.Location = New Point(132, 105)
        textBoxRutDetSis.Name = "textBoxRutDetSis"
        textBoxRutDetSis.Size = New Size(158, 23)
        textBoxRutDetSis.TabIndex = 8
        ' 
        ' textBoxApeMatDetSis
        ' 
        textBoxApeMatDetSis.Enabled = False
        textBoxApeMatDetSis.Location = New Point(132, 76)
        textBoxApeMatDetSis.Name = "textBoxApeMatDetSis"
        textBoxApeMatDetSis.Size = New Size(158, 23)
        textBoxApeMatDetSis.TabIndex = 7
        ' 
        ' textBoxApePatDetSis
        ' 
        textBoxApePatDetSis.Enabled = False
        textBoxApePatDetSis.Location = New Point(132, 48)
        textBoxApePatDetSis.Name = "textBoxApePatDetSis"
        textBoxApePatDetSis.Size = New Size(158, 23)
        textBoxApePatDetSis.TabIndex = 6
        ' 
        ' textBoxNomDetSis
        ' 
        textBoxNomDetSis.Enabled = False
        textBoxNomDetSis.Location = New Point(132, 19)
        textBoxNomDetSis.Name = "textBoxNomDetSis"
        textBoxNomDetSis.Size = New Size(158, 23)
        textBoxNomDetSis.TabIndex = 5
        ' 
        ' panelDatoDetSin
        ' 
        panelDatoDetSin.BackColor = Color.DarkTurquoise
        panelDatoDetSin.Controls.Add(labelComuDetSin)
        panelDatoDetSin.Controls.Add(labelTelDetSin)
        panelDatoDetSin.Controls.Add(labelDirPanSin)
        panelDatoDetSin.Controls.Add(labelRutVerSin)
        panelDatoDetSin.Controls.Add(labelApeMatVerSin)
        panelDatoDetSin.Controls.Add(labelNomSin)
        panelDatoDetSin.Controls.Add(labelApePatSin)
        panelDatoDetSin.Location = New Point(15, 8)
        panelDatoDetSin.Name = "panelDatoDetSin"
        panelDatoDetSin.Size = New Size(111, 207)
        panelDatoDetSin.TabIndex = 4
        ' 
        ' labelComuDetSin
        ' 
        labelComuDetSin.AutoSize = True
        labelComuDetSin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelComuDetSin.Location = New Point(28, 179)
        labelComuDetSin.Name = "labelComuDetSin"
        labelComuDetSin.Size = New Size(55, 15)
        labelComuDetSin.TabIndex = 7
        labelComuDetSin.Text = "Comuna:"
        ' 
        ' labelTelDetSin
        ' 
        labelTelDetSin.AutoSize = True
        labelTelDetSin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTelDetSin.Location = New Point(28, 154)
        labelTelDetSin.Name = "labelTelDetSin"
        labelTelDetSin.Size = New Size(59, 15)
        labelTelDetSin.TabIndex = 6
        labelTelDetSin.Text = "Telefono:"
        ' 
        ' labelDirPanSin
        ' 
        labelDirPanSin.AutoSize = True
        labelDirPanSin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelDirPanSin.Location = New Point(24, 128)
        labelDirPanSin.Name = "labelDirPanSin"
        labelDirPanSin.Size = New Size(63, 15)
        labelDirPanSin.TabIndex = 5
        labelDirPanSin.Text = "Direccion:"
        ' 
        ' labelRutVerSin
        ' 
        labelRutVerSin.AutoSize = True
        labelRutVerSin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelRutVerSin.Location = New Point(34, 103)
        labelRutVerSin.Name = "labelRutVerSin"
        labelRutVerSin.Size = New Size(34, 15)
        labelRutVerSin.TabIndex = 4
        labelRutVerSin.Text = "RUT:"
        ' 
        ' labelApeMatVerSin
        ' 
        labelApeMatVerSin.AutoSize = True
        labelApeMatVerSin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelApeMatVerSin.Location = New Point(5, 75)
        labelApeMatVerSin.Name = "labelApeMatVerSin"
        labelApeMatVerSin.Size = New Size(106, 15)
        labelApeMatVerSin.TabIndex = 3
        labelApeMatVerSin.Text = "Apellido Materno:"
        ' 
        ' labelNomSin
        ' 
        labelNomSin.AutoSize = True
        labelNomSin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelNomSin.Location = New Point(28, 13)
        labelNomSin.Name = "labelNomSin"
        labelNomSin.Size = New Size(56, 15)
        labelNomSin.TabIndex = 0
        labelNomSin.Text = "Nombre:"
        ' 
        ' labelApePatSin
        ' 
        labelApePatSin.AutoSize = True
        labelApePatSin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelApePatSin.Location = New Point(5, 42)
        labelApePatSin.Name = "labelApePatSin"
        labelApePatSin.Size = New Size(102, 15)
        labelApePatSin.TabIndex = 2
        labelApePatSin.Text = "Apellido Paterno:"
        ' 
        ' tituloVerDetalleSiniestros
        ' 
        tituloVerDetalleSiniestros.AutoSize = True
        tituloVerDetalleSiniestros.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tituloVerDetalleSiniestros.ForeColor = Color.White
        tituloVerDetalleSiniestros.Location = New Point(210, 0)
        tituloVerDetalleSiniestros.Name = "tituloVerDetalleSiniestros"
        tituloVerDetalleSiniestros.Size = New Size(306, 47)
        tituloVerDetalleSiniestros.TabIndex = 0
        tituloVerDetalleSiniestros.Text = "Detalle Siniestros"
        ' 
        ' labelTituloSiniestros
        ' 
        labelTituloSiniestros.AutoSize = True
        labelTituloSiniestros.BackColor = Color.Transparent
        labelTituloSiniestros.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTituloSiniestros.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        labelTituloSiniestros.Location = New Point(49, 16)
        labelTituloSiniestros.Name = "labelTituloSiniestros"
        labelTituloSiniestros.Size = New Size(150, 40)
        labelTituloSiniestros.TabIndex = 5
        labelTituloSiniestros.Text = "Siniestros"
        ' 
        ' dataGridViewSiniestro
        ' 
        dataGridViewSiniestro.BackgroundColor = Color.Indigo
        dataGridViewSiniestro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewSiniestro.Location = New Point(18, 72)
        dataGridViewSiniestro.Name = "dataGridViewSiniestro"
        dataGridViewSiniestro.RowHeadersWidth = 51
        dataGridViewSiniestro.Size = New Size(742, 231)
        dataGridViewSiniestro.TabIndex = 4
        ' 
        ' buttonEliminarSiniestro
        ' 
        buttonEliminarSiniestro.Location = New Point(641, 329)
        buttonEliminarSiniestro.Name = "buttonEliminarSiniestro"
        buttonEliminarSiniestro.Size = New Size(75, 23)
        buttonEliminarSiniestro.TabIndex = 3
        buttonEliminarSiniestro.Text = "buttonEliminarSiniestro"
        buttonEliminarSiniestro.UseVisualStyleBackColor = True
        ' 
        ' buttonAgregarSiniestro
        ' 
        buttonAgregarSiniestro.Location = New Point(346, 329)
        buttonAgregarSiniestro.Name = "buttonAgregarSiniestro"
        buttonAgregarSiniestro.Size = New Size(75, 23)
        buttonAgregarSiniestro.TabIndex = 2
        buttonAgregarSiniestro.Text = "Agregar"
        buttonAgregarSiniestro.UseVisualStyleBackColor = True
        ' 
        ' buttonVerDetallesSiniestro
        ' 
        buttonVerDetallesSiniestro.Location = New Point(65, 329)
        buttonVerDetallesSiniestro.Name = "buttonVerDetallesSiniestro"
        buttonVerDetallesSiniestro.Size = New Size(75, 23)
        buttonVerDetallesSiniestro.TabIndex = 1
        buttonVerDetallesSiniestro.Text = "Ver"
        buttonVerDetallesSiniestro.UseVisualStyleBackColor = True
        ' 
        ' panelGestionServicios
        ' 
        panelGestionServicios.Location = New Point(8, 57)
        panelGestionServicios.Name = "panelGestionServicios"
        panelGestionServicios.Size = New Size(790, 392)
        panelGestionServicios.TabIndex = 4
        ' 
        ' panelClientes
        ' 
        panelClientes.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        panelClientes.Controls.Add(panelThreeCrudCli)
        panelClientes.Controls.Add(textBoxComuCli)
        panelClientes.Controls.Add(textBoxTelefCli)
        panelClientes.Controls.Add(textBoxDirecCli)
        panelClientes.Controls.Add(textBoxApeMatCli)
        panelClientes.Controls.Add(textBoxApePatCli)
        panelClientes.Controls.Add(textBoxNomCli)
        panelClientes.Controls.Add(textBoxRutCli)
        panelClientes.Controls.Add(panelTitulClientes)
        panelClientes.Location = New Point(8, 57)
        panelClientes.Name = "panelClientes"
        panelClientes.Size = New Size(790, 392)
        panelClientes.TabIndex = 3
        ' 
        ' panelThreeCrudCli
        ' 
        panelThreeCrudCli.BackColor = Color.DarkSlateBlue
        panelThreeCrudCli.Controls.Add(comboBoxBuscCli)
        panelThreeCrudCli.Controls.Add(labelBuscTitRut)
        panelThreeCrudCli.Controls.Add(buttonLimpCli)
        panelThreeCrudCli.Controls.Add(buttonEditCli)
        panelThreeCrudCli.Controls.Add(buttonElimCli)
        panelThreeCrudCli.Controls.Add(buttonAgreCli)
        panelThreeCrudCli.Controls.Add(buttonVerCli)
        panelThreeCrudCli.Location = New Point(455, 20)
        panelThreeCrudCli.Name = "panelThreeCrudCli"
        panelThreeCrudCli.Size = New Size(248, 330)
        panelThreeCrudCli.TabIndex = 15
        ' 
        ' comboBoxBuscCli
        ' 
        comboBoxBuscCli.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxBuscCli.FormattingEnabled = True
        comboBoxBuscCli.Location = New Point(66, 33)
        comboBoxBuscCli.Name = "comboBoxBuscCli"
        comboBoxBuscCli.Size = New Size(121, 23)
        comboBoxBuscCli.TabIndex = 14
        ' 
        ' labelBuscTitRut
        ' 
        labelBuscTitRut.AutoSize = True
        labelBuscTitRut.Location = New Point(102, 8)
        labelBuscTitRut.Name = "labelBuscTitRut"
        labelBuscTitRut.Size = New Size(42, 15)
        labelBuscTitRut.TabIndex = 13
        labelBuscTitRut.Text = "Buscar"
        ' 
        ' buttonLimpCli
        ' 
        buttonLimpCli.Location = New Point(84, 263)
        buttonLimpCli.Name = "buttonLimpCli"
        buttonLimpCli.Size = New Size(75, 23)
        buttonLimpCli.TabIndex = 12
        buttonLimpCli.Text = "Limpiar"
        buttonLimpCli.UseVisualStyleBackColor = True
        ' 
        ' buttonEditCli
        ' 
        buttonEditCli.Location = New Point(22, 210)
        buttonEditCli.Name = "buttonEditCli"
        buttonEditCli.Size = New Size(75, 23)
        buttonEditCli.TabIndex = 11
        buttonEditCli.Text = "Editar"
        buttonEditCli.UseVisualStyleBackColor = True
        ' 
        ' buttonElimCli
        ' 
        buttonElimCli.Location = New Point(155, 211)
        buttonElimCli.Name = "buttonElimCli"
        buttonElimCli.Size = New Size(75, 23)
        buttonElimCli.TabIndex = 10
        buttonElimCli.Text = "Eliminar"
        buttonElimCli.UseVisualStyleBackColor = True
        ' 
        ' buttonAgreCli
        ' 
        buttonAgreCli.Location = New Point(155, 155)
        buttonAgreCli.Name = "buttonAgreCli"
        buttonAgreCli.Size = New Size(75, 23)
        buttonAgreCli.TabIndex = 9
        buttonAgreCli.Text = "Agregar"
        buttonAgreCli.UseVisualStyleBackColor = True
        ' 
        ' buttonVerCli
        ' 
        buttonVerCli.Location = New Point(22, 155)
        buttonVerCli.Name = "buttonVerCli"
        buttonVerCli.Size = New Size(75, 23)
        buttonVerCli.TabIndex = 8
        buttonVerCli.Text = "Ver"
        buttonVerCli.UseVisualStyleBackColor = True
        ' 
        ' textBoxComuCli
        ' 
        textBoxComuCli.Location = New Point(191, 283)
        textBoxComuCli.Name = "textBoxComuCli"
        textBoxComuCli.Size = New Size(166, 23)
        textBoxComuCli.TabIndex = 7
        ' 
        ' textBoxTelefCli
        ' 
        textBoxTelefCli.Location = New Point(192, 235)
        textBoxTelefCli.Name = "textBoxTelefCli"
        textBoxTelefCli.Size = New Size(165, 23)
        textBoxTelefCli.TabIndex = 6
        ' 
        ' textBoxDirecCli
        ' 
        textBoxDirecCli.Location = New Point(191, 192)
        textBoxDirecCli.Name = "textBoxDirecCli"
        textBoxDirecCli.Size = New Size(166, 23)
        textBoxDirecCli.TabIndex = 5
        ' 
        ' textBoxApeMatCli
        ' 
        textBoxApeMatCli.Location = New Point(191, 152)
        textBoxApeMatCli.Name = "textBoxApeMatCli"
        textBoxApeMatCli.Size = New Size(166, 23)
        textBoxApeMatCli.TabIndex = 4
        ' 
        ' textBoxApePatCli
        ' 
        textBoxApePatCli.Location = New Point(191, 111)
        textBoxApePatCli.Name = "textBoxApePatCli"
        textBoxApePatCli.Size = New Size(166, 23)
        textBoxApePatCli.TabIndex = 3
        ' 
        ' textBoxNomCli
        ' 
        textBoxNomCli.Location = New Point(191, 73)
        textBoxNomCli.Name = "textBoxNomCli"
        textBoxNomCli.Size = New Size(166, 23)
        textBoxNomCli.TabIndex = 2
        ' 
        ' textBoxRutCli
        ' 
        textBoxRutCli.Location = New Point(191, 34)
        textBoxRutCli.Name = "textBoxRutCli"
        textBoxRutCli.Size = New Size(166, 23)
        textBoxRutCli.TabIndex = 1
        ' 
        ' panelTitulClientes
        ' 
        panelTitulClientes.BackColor = Color.DarkSlateBlue
        panelTitulClientes.BorderStyle = BorderStyle.Fixed3D
        panelTitulClientes.Controls.Add(labelComunCli)
        panelTitulClientes.Controls.Add(labelTelefCli)
        panelTitulClientes.Controls.Add(labelDirecCli)
        panelTitulClientes.Controls.Add(labelApeMatCli)
        panelTitulClientes.Controls.Add(labelApePatCli)
        panelTitulClientes.Controls.Add(labelNomCli)
        panelTitulClientes.Controls.Add(labelRutCli)
        panelTitulClientes.Location = New Point(35, 20)
        panelTitulClientes.Name = "panelTitulClientes"
        panelTitulClientes.Size = New Size(137, 330)
        panelTitulClientes.TabIndex = 0
        ' 
        ' labelComunCli
        ' 
        labelComunCli.AutoSize = True
        labelComunCli.Location = New Point(36, 263)
        labelComunCli.Name = "labelComunCli"
        labelComunCli.Size = New Size(56, 15)
        labelComunCli.TabIndex = 6
        labelComunCli.Text = "Comuna:"
        ' 
        ' labelTelefCli
        ' 
        labelTelefCli.AutoSize = True
        labelTelefCli.Location = New Point(38, 217)
        labelTelefCli.Name = "labelTelefCli"
        labelTelefCli.Size = New Size(55, 15)
        labelTelefCli.TabIndex = 5
        labelTelefCli.Text = "Telefono:"
        ' 
        ' labelDirecCli
        ' 
        labelDirecCli.AutoSize = True
        labelDirecCli.Location = New Point(41, 176)
        labelDirecCli.Name = "labelDirecCli"
        labelDirecCli.Size = New Size(60, 15)
        labelDirecCli.TabIndex = 4
        labelDirecCli.Text = "Direccion:"
        ' 
        ' labelApeMatCli
        ' 
        labelApeMatCli.AutoSize = True
        labelApeMatCli.Location = New Point(18, 132)
        labelApeMatCli.Name = "labelApeMatCli"
        labelApeMatCli.Size = New Size(102, 15)
        labelApeMatCli.TabIndex = 3
        labelApeMatCli.Text = "Apellido Materno:"
        ' 
        ' labelApePatCli
        ' 
        labelApePatCli.AutoSize = True
        labelApePatCli.Location = New Point(18, 91)
        labelApePatCli.Name = "labelApePatCli"
        labelApePatCli.Size = New Size(98, 15)
        labelApePatCli.TabIndex = 2
        labelApePatCli.Text = "Apellido Paterno:"
        ' 
        ' labelNomCli
        ' 
        labelNomCli.AutoSize = True
        labelNomCli.Location = New Point(41, 52)
        labelNomCli.Name = "labelNomCli"
        labelNomCli.Size = New Size(54, 15)
        labelNomCli.TabIndex = 1
        labelNomCli.Text = "Nombre:"
        ' 
        ' labelRutCli
        ' 
        labelRutCli.AutoSize = True
        labelRutCli.Location = New Point(53, 15)
        labelRutCli.Name = "labelRutCli"
        labelRutCli.Size = New Size(28, 15)
        labelRutCli.TabIndex = 0
        labelRutCli.Text = "Rut:"
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
        Controls.Add(panelClientes)
        Controls.Add(panelUsuario)
        Controls.Add(panelGestionServicios)
        Controls.Add(panelVentaRepuestos)
        Controls.Add(panelRepuestos)
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
        panelSiniestro.PerformLayout()
        panelDetalleSiniestro.ResumeLayout(False)
        panelDetalleSiniestro.PerformLayout()
        panelAgreSis.ResumeLayout(False)
        panelAgreSis.PerformLayout()
        panelDetalleSinSelec.ResumeLayout(False)
        panelDetalleSinSelec.PerformLayout()
        CType(pictureBoxEstadSin, ComponentModel.ISupportInitialize).EndInit()
        panelDatoDetSin.ResumeLayout(False)
        panelDatoDetSin.PerformLayout()
        CType(dataGridViewSiniestro, ComponentModel.ISupportInitialize).EndInit()
        panelClientes.ResumeLayout(False)
        panelClientes.PerformLayout()
        panelThreeCrudCli.ResumeLayout(False)
        panelThreeCrudCli.PerformLayout()
        panelTitulClientes.ResumeLayout(False)
        panelTitulClientes.PerformLayout()
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
    Friend WithEvents buttonClientes As Button
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
    Friend WithEvents panelClientes As Panel
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
    Friend WithEvents buttonEliminarSiniestro As Button
    Friend WithEvents buttonAgregarSiniestro As Button
    Friend WithEvents buttonVerDetallesSiniestro As Button
    Friend WithEvents dataGridViewSiniestro As DataGridView
    Friend WithEvents labelTituloSiniestros As Label
    Friend WithEvents panelDetalleSiniestro As Panel
    Friend WithEvents panelDetalleSinSelec As Panel
    Friend WithEvents tituloVerDetalleSiniestros As Label
    Friend WithEvents panelDatoDetSin As Panel
    Friend WithEvents labelApePatSin As Label
    Friend WithEvents labelNomSin As Label
    Friend WithEvents labelApeMatVerSin As Label
    Friend WithEvents textBoxRutDetSis As TextBox
    Friend WithEvents textBoxApeMatDetSis As TextBox
    Friend WithEvents textBoxApePatDetSis As TextBox
    Friend WithEvents textBoxNomDetSis As TextBox
    Friend WithEvents labelRutVerSin As Label
    Friend WithEvents textBoxDireDetSis As TextBox
    Friend WithEvents labelDirPanSin As Label
    Friend WithEvents labelTelDetSin As Label
    Friend WithEvents textBoxComuDetSis As TextBox
    Friend WithEvents textBoxTelDetSis As TextBox
    Friend WithEvents labelComuDetSin As Label
    Friend WithEvents labelEstadDetSin As Label
    Friend WithEvents pictureBoxEstadSin As PictureBox
    Friend WithEvents labelSegDetSin As Label
    Friend WithEvents labelEstadoSeguSis As Label
    Friend WithEvents labelTituloCompDetSis As Label
    Friend WithEvents labelNomCompDetSin As Label
    Friend WithEvents nomCompSin As Label
    Friend WithEvents buttonFinalizado As Button
    Friend WithEvents buttonPendiente As Button
    Friend WithEvents buttonActivo As Button
    Friend WithEvents buttonCerrarPanDetSin As Button
    Friend WithEvents labelTituloDetalleSin As Label
    Friend WithEvents labelDetalleSin As Label
    Friend WithEvents label13PanSin As Label
    Friend WithEvents panelAgreSis As Panel
    Friend WithEvents textBoxNomAgrSin As TextBox
    Friend WithEvents labelTelefCli As Label
    Friend WithEvents labelRutAgrSin As Label
    Private labelNomAgrSin As Label
    Friend WithEvents textBoxTelAgrSin As TextBox
    Friend WithEvents labelTelAgrSis As Label
    Friend WithEvents textBoxApeMatAgrSin As TextBox
    Friend WithEvents labelApeMatAgrSin As Label
    Friend WithEvents textBoxApePatAgrSin As TextBox
    Friend WithEvents labelApelliPatAgrSin As Label
    Friend WithEvents comboBoxRutAgrSin As ComboBox
    Friend WithEvents labelCompSin As Label
    Friend WithEvents dateTimePickerFecSin As DateTimePicker
    Friend WithEvents labelFechaSin As Label
    Friend WithEvents textBoxDetallAgrSin As TextBox
    Friend WithEvents labelDetaSin As Label
    Friend WithEvents comboBoxCompaAgrSin As ComboBox
    Friend WithEvents comboBoxEstadSegAgrSin As ComboBox
    Friend WithEvents labelEstadSeguSin As Label
    Friend WithEvents labelTituloAgrSin As Label
    Friend WithEvents buttonCancelSin As Button
    Friend WithEvents buttonAgrSinConf As Button
    Friend WithEvents panelTitulClientes As Panel
    Friend WithEvents labelDirecCli As Label
    Friend WithEvents labelApeMatCli As Label
    Friend WithEvents labelApePatCli As Label
    Friend WithEvents labelNomCli As Label
    Friend WithEvents labelRutCli As Label
    Friend WithEvents labelComunCli As Label
    Friend WithEvents textBoxComuCli As TextBox
    Friend WithEvents textBoxTelefCli As TextBox
    Friend WithEvents textBoxDirecCli As TextBox
    Friend WithEvents textBoxApeMatCli As TextBox
    Friend WithEvents textBoxApePatCli As TextBox
    Friend WithEvents textBoxNomCli As TextBox
    Friend WithEvents textBoxRutCli As TextBox
    Friend WithEvents buttonElimCli As Button
    Friend WithEvents buttonAgreCli As Button
    Friend WithEvents buttonVerCli As Button
    Friend WithEvents buttonEditCli As Button
    Friend WithEvents comboBoxBuscCli As ComboBox
    Friend WithEvents labelBuscTitRut As Label
    Friend WithEvents buttonLimpCli As Button
    Friend WithEvents panelThreeCrudCli As Panel
    Friend WithEvents buttonConsuRutSin As Button
    Friend WithEvents textBoxConsRutSin As TextBox
    Friend WithEvents labelTituConsSin As Label
End Class
