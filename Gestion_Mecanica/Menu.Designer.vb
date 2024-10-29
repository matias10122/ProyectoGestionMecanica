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
        panelVentaRepuestos.Location = New Point(8, 57)
        panelVentaRepuestos.Name = "panelVentaRepuestos"
        panelVentaRepuestos.Size = New Size(790, 392)
        panelVentaRepuestos.TabIndex = 1
        ' 
        ' panelSiniestro
        ' 
        panelSiniestro.Location = New Point(8, 57)
        panelSiniestro.Name = "panelSiniestro"
        panelSiniestro.Size = New Size(790, 392)
        panelSiniestro.TabIndex = 2
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
        LabelTipo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        LabelCorreo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        LabelContraseña.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        LabelRutUsuario.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        buttonConsultarRut.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        limpiarCamposGestionUsuarios.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        limpiarCamposGestionUsuarios.Location = New Point(534, 37)
        limpiarCamposGestionUsuarios.Name = "limpiarCamposGestionUsuarios"
        limpiarCamposGestionUsuarios.Size = New Size(94, 50)
        limpiarCamposGestionUsuarios.TabIndex = 15
        limpiarCamposGestionUsuarios.Text = "Limpiar Campos"
        limpiarCamposGestionUsuarios.UseVisualStyleBackColor = True
        ' 
        ' buttonMostrarUsuarios
        ' 
        buttonMostrarUsuarios.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondoLogin01
        ClientSize = New Size(800, 478)
        Controls.Add(panelUsuario)
        Controls.Add(panelRepuestos)
        Controls.Add(panelGestionServicios)
        Controls.Add(panelSiniestro)
        Controls.Add(panelVentaRepuestos)
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
End Class
