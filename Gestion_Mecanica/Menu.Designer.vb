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
        TextBoxRepuestoNombre = New TextBox()
        LabelRepuestoID = New Label()
        LabelRepuestoCantidad = New Label()
        LabelRepuestoPrecio = New Label()
        LabelRepuestoDescripcion = New Label()
        LabelRepuestoNombre = New Label()
        panelUsuario = New Panel()
        buttonMostrarUsuarios = New Button()
        ButtonGuardarUsuario = New Button()
        ButtonEliminarUsuario = New Button()
        ButtonEditar = New Button()
        TextBoxTipo = New TextBox()
        TextBoxCorreo = New TextBox()
        LabelTipo = New Label()
        LabelCorreo = New Label()
        TextBoxContraseña = New TextBox()
        LabelContraseña = New Label()
        TextBoxRutUsuario = New TextBox()
        LabelRut = New Label()
        LabelRutUsuario = New Label()
        TextBoxRut = New TextBox()
        buttonConsultarRut = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        panelRepuestos.SuspendLayout()
        panelUsuario.SuspendLayout()
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
        panelVentaRepuestos.Location = New Point(9, 76)
        panelVentaRepuestos.Margin = New Padding(3, 4, 3, 4)
        panelVentaRepuestos.Name = "panelVentaRepuestos"
        panelVentaRepuestos.Size = New Size(903, 523)
        panelVentaRepuestos.TabIndex = 1
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
        panelRepuestos.Controls.Add(TextBoxRepuestoNombre)
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
        ' ComboBoxRepuestos
        ' 
        ComboBoxRepuestos.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxRepuestos.FormattingEnabled = True
        ComboBoxRepuestos.Location = New Point(280, 95)
        ComboBoxRepuestos.Name = "ComboBoxRepuestos"
        ComboBoxRepuestos.Size = New Size(275, 28)
        ComboBoxRepuestos.TabIndex = 16
        ' 
        ' ButtonGuardarRepuesto
        ' 
        ButtonGuardarRepuesto.Location = New Point(602, 405)
        ButtonGuardarRepuesto.Name = "ButtonGuardarRepuesto"
        ButtonGuardarRepuesto.Size = New Size(122, 54)
        ButtonGuardarRepuesto.TabIndex = 15
        ButtonGuardarRepuesto.Text = "Guardar Repuesto"
        ButtonGuardarRepuesto.UseVisualStyleBackColor = True
        ' 
        ' ButtonEliminarRepuesto
        ' 
        ButtonEliminarRepuesto.Enabled = False
        ButtonEliminarRepuesto.Location = New Point(330, 405)
        ButtonEliminarRepuesto.Name = "ButtonEliminarRepuesto"
        ButtonEliminarRepuesto.Size = New Size(121, 56)
        ButtonEliminarRepuesto.TabIndex = 14
        ButtonEliminarRepuesto.Text = "Eliminar Repuesto"
        ButtonEliminarRepuesto.UseVisualStyleBackColor = True
        ' 
        ' ButtonEditarRepuesto
        ' 
        ButtonEditarRepuesto.Enabled = False
        ButtonEditarRepuesto.Location = New Point(68, 404)
        ButtonEditarRepuesto.Name = "ButtonEditarRepuesto"
        ButtonEditarRepuesto.Size = New Size(118, 56)
        ButtonEditarRepuesto.TabIndex = 13
        ButtonEditarRepuesto.Text = "Editar Repuesto"
        ButtonEditarRepuesto.UseVisualStyleBackColor = True
        ' 
        ' ButtonLimpiarRepuesto
        ' 
        ButtonLimpiarRepuesto.Location = New Point(706, 125)
        ButtonLimpiarRepuesto.Name = "ButtonLimpiarRepuesto"
        ButtonLimpiarRepuesto.Size = New Size(132, 56)
        ButtonLimpiarRepuesto.TabIndex = 12
        ButtonLimpiarRepuesto.Text = "Limpiar Campos"
        ButtonLimpiarRepuesto.UseVisualStyleBackColor = True
        ' 
        ' ButtonConsultarRepuesto
        ' 
        ButtonConsultarRepuesto.Location = New Point(706, 26)
        ButtonConsultarRepuesto.Name = "ButtonConsultarRepuesto"
        ButtonConsultarRepuesto.Size = New Size(132, 53)
        ButtonConsultarRepuesto.TabIndex = 11
        ButtonConsultarRepuesto.Text = "Consultar Repuesto"
        ButtonConsultarRepuesto.UseVisualStyleBackColor = True
        ' 
        ' TextBoxRepuestoDescripcion
        ' 
        TextBoxRepuestoDescripcion.Location = New Point(566, 333)
        TextBoxRepuestoDescripcion.Name = "TextBoxRepuestoDescripcion"
        TextBoxRepuestoDescripcion.Size = New Size(169, 27)
        TextBoxRepuestoDescripcion.TabIndex = 10
        ' 
        ' TextBoxRepuestoPrecio
        ' 
        TextBoxRepuestoPrecio.Location = New Point(298, 333)
        TextBoxRepuestoPrecio.Name = "TextBoxRepuestoPrecio"
        TextBoxRepuestoPrecio.Size = New Size(171, 27)
        TextBoxRepuestoPrecio.TabIndex = 9
        TextBoxRepuestoPrecio.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBoxRepuestoCantidad
        ' 
        TextBoxRepuestoCantidad.Location = New Point(53, 333)
        TextBoxRepuestoCantidad.Name = "TextBoxRepuestoCantidad"
        TextBoxRepuestoCantidad.Size = New Size(173, 27)
        TextBoxRepuestoCantidad.TabIndex = 8
        TextBoxRepuestoCantidad.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBoxBuscarRepuestoNombre
        ' 
        TextBoxBuscarRepuestoNombre.Location = New Point(243, 35)
        TextBoxBuscarRepuestoNombre.Name = "TextBoxBuscarRepuestoNombre"
        TextBoxBuscarRepuestoNombre.Size = New Size(199, 27)
        TextBoxBuscarRepuestoNombre.TabIndex = 7
        ' 
        ' TextBoxBuscarRepuestoID
        ' 
        TextBoxBuscarRepuestoID.Location = New Point(312, 161)
        TextBoxBuscarRepuestoID.Name = "TextBoxBuscarRepuestoID"
        TextBoxBuscarRepuestoID.Size = New Size(181, 27)
        TextBoxBuscarRepuestoID.TabIndex = 6
        ' 
        ' TextBoxRepuestoNombre
        ' 
        TextBoxRepuestoNombre.Location = New Point(475, 35)
        TextBoxRepuestoNombre.Name = "TextBoxRepuestoNombre"
        TextBoxRepuestoNombre.Size = New Size(192, 27)
        TextBoxRepuestoNombre.TabIndex = 5
        ' 
        ' LabelRepuestoID
        ' 
        LabelRepuestoID.AutoSize = True
        LabelRepuestoID.Location = New Point(107, 168)
        LabelRepuestoID.Name = "LabelRepuestoID"
        LabelRepuestoID.Size = New Size(115, 20)
        LabelRepuestoID.TabIndex = 4
        LabelRepuestoID.Text = "ID del Repuesto"
        ' 
        ' LabelRepuestoCantidad
        ' 
        LabelRepuestoCantidad.AutoSize = True
        LabelRepuestoCantidad.Location = New Point(81, 266)
        LabelRepuestoCantidad.Name = "LabelRepuestoCantidad"
        LabelRepuestoCantidad.Size = New Size(129, 20)
        LabelRepuestoCantidad.TabIndex = 3
        LabelRepuestoCantidad.Text = "Cantidad en Stock"
        ' 
        ' LabelRepuestoPrecio
        ' 
        LabelRepuestoPrecio.AutoSize = True
        LabelRepuestoPrecio.Location = New Point(344, 266)
        LabelRepuestoPrecio.Name = "LabelRepuestoPrecio"
        LabelRepuestoPrecio.Size = New Size(107, 20)
        LabelRepuestoPrecio.TabIndex = 2
        LabelRepuestoPrecio.Text = "Precio Unitario"
        ' 
        ' LabelRepuestoDescripcion
        ' 
        LabelRepuestoDescripcion.AutoSize = True
        LabelRepuestoDescripcion.Location = New Point(590, 266)
        LabelRepuestoDescripcion.Name = "LabelRepuestoDescripcion"
        LabelRepuestoDescripcion.Size = New Size(87, 20)
        LabelRepuestoDescripcion.TabIndex = 1
        LabelRepuestoDescripcion.Text = "Descripción"
        ' 
        ' LabelRepuestoNombre
        ' 
        LabelRepuestoNombre.AutoSize = True
        LabelRepuestoNombre.Location = New Point(71, 42)
        LabelRepuestoNombre.Name = "LabelRepuestoNombre"
        LabelRepuestoNombre.Size = New Size(155, 20)
        LabelRepuestoNombre.TabIndex = 0
        LabelRepuestoNombre.Text = "Nombre del Repuesto"
        ' 
        ' panelUsuario
        ' 
        panelUsuario.Controls.Add(buttonMostrarUsuarios)
        panelUsuario.Controls.Add(ButtonGuardarUsuario)
        panelUsuario.Controls.Add(ButtonEliminarUsuario)
        panelUsuario.Controls.Add(ButtonEditar)
        panelUsuario.Controls.Add(TextBoxTipo)
        panelUsuario.Controls.Add(TextBoxCorreo)
        panelUsuario.Controls.Add(LabelTipo)
        panelUsuario.Controls.Add(LabelCorreo)
        panelUsuario.Controls.Add(TextBoxContraseña)
        panelUsuario.Controls.Add(LabelContraseña)
        panelUsuario.Controls.Add(TextBoxRutUsuario)
        panelUsuario.Controls.Add(LabelRut)
        panelUsuario.Controls.Add(LabelRutUsuario)
        panelUsuario.Controls.Add(TextBoxRut)
        panelUsuario.Controls.Add(buttonConsultarRut)
        panelUsuario.Location = New Point(9, 76)
        panelUsuario.Margin = New Padding(3, 4, 3, 4)
        panelUsuario.Name = "panelUsuario"
        panelUsuario.Size = New Size(903, 523)
        panelUsuario.TabIndex = 8
        ' 
        ' buttonMostrarUsuarios
        ' 
        buttonMostrarUsuarios.Location = New Point(642, 72)
        buttonMostrarUsuarios.Name = "buttonMostrarUsuarios"
        buttonMostrarUsuarios.Size = New Size(180, 88)
        buttonMostrarUsuarios.TabIndex = 14
        buttonMostrarUsuarios.Text = "Ver Usuarios"
        buttonMostrarUsuarios.UseVisualStyleBackColor = True
        ' 
        ' ButtonGuardarUsuario
        ' 
        ButtonGuardarUsuario.Location = New Point(344, 403)
        ButtonGuardarUsuario.Name = "ButtonGuardarUsuario"
        ButtonGuardarUsuario.Size = New Size(147, 67)
        ButtonGuardarUsuario.TabIndex = 13
        ButtonGuardarUsuario.Text = "Guardar Usuario"
        ButtonGuardarUsuario.UseVisualStyleBackColor = True
        ' 
        ' ButtonEliminarUsuario
        ' 
        ButtonEliminarUsuario.BackColor = Color.Red
        ButtonEliminarUsuario.Location = New Point(540, 405)
        ButtonEliminarUsuario.Name = "ButtonEliminarUsuario"
        ButtonEliminarUsuario.Size = New Size(137, 67)
        ButtonEliminarUsuario.TabIndex = 12
        ButtonEliminarUsuario.Text = "Eliminar Usuario"
        ButtonEliminarUsuario.UseVisualStyleBackColor = False
        ' 
        ' ButtonEditar
        ' 
        ButtonEditar.Location = New Point(168, 403)
        ButtonEditar.Name = "ButtonEditar"
        ButtonEditar.Size = New Size(147, 71)
        ButtonEditar.TabIndex = 11
        ButtonEditar.Text = "Editar"
        ButtonEditar.UseVisualStyleBackColor = True
        ' 
        ' TextBoxTipo
        ' 
        TextBoxTipo.Location = New Point(566, 226)
        TextBoxTipo.Name = "TextBoxTipo"
        TextBoxTipo.Size = New Size(183, 27)
        TextBoxTipo.TabIndex = 10
        ' 
        ' TextBoxCorreo
        ' 
        TextBoxCorreo.Location = New Point(566, 310)
        TextBoxCorreo.Name = "TextBoxCorreo"
        TextBoxCorreo.Size = New Size(183, 27)
        TextBoxCorreo.TabIndex = 9
        ' 
        ' LabelTipo
        ' 
        LabelTipo.AutoSize = True
        LabelTipo.Location = New Point(501, 226)
        LabelTipo.Name = "LabelTipo"
        LabelTipo.Size = New Size(39, 20)
        LabelTipo.TabIndex = 8
        LabelTipo.Text = "Tipo"
        ' 
        ' LabelCorreo
        ' 
        LabelCorreo.AutoSize = True
        LabelCorreo.Location = New Point(501, 310)
        LabelCorreo.Name = "LabelCorreo"
        LabelCorreo.Size = New Size(54, 20)
        LabelCorreo.TabIndex = 7
        LabelCorreo.Text = "Correo"
        ' 
        ' TextBoxContraseña
        ' 
        TextBoxContraseña.Location = New Point(172, 310)
        TextBoxContraseña.Name = "TextBoxContraseña"
        TextBoxContraseña.Size = New Size(199, 27)
        TextBoxContraseña.TabIndex = 6
        ' 
        ' LabelContraseña
        ' 
        LabelContraseña.AutoSize = True
        LabelContraseña.Location = New Point(71, 310)
        LabelContraseña.Name = "LabelContraseña"
        LabelContraseña.Size = New Size(83, 20)
        LabelContraseña.TabIndex = 5
        LabelContraseña.Text = "Contraseña"
        ' 
        ' TextBoxRutUsuario
        ' 
        TextBoxRutUsuario.Location = New Point(172, 226)
        TextBoxRutUsuario.Name = "TextBoxRutUsuario"
        TextBoxRutUsuario.Size = New Size(199, 27)
        TextBoxRutUsuario.TabIndex = 4
        ' 
        ' LabelRut
        ' 
        LabelRut.AutoSize = True
        LabelRut.Location = New Point(123, 95)
        LabelRut.Name = "LabelRut"
        LabelRut.Size = New Size(31, 20)
        LabelRut.TabIndex = 3
        LabelRut.Text = "Rut"
        ' 
        ' LabelRutUsuario
        ' 
        LabelRutUsuario.AutoSize = True
        LabelRutUsuario.Location = New Point(53, 226)
        LabelRutUsuario.Name = "LabelRutUsuario"
        LabelRutUsuario.Size = New Size(110, 20)
        LabelRutUsuario.TabIndex = 2
        LabelRutUsuario.Text = "Rut del Usuario"
        ' 
        ' TextBoxRut
        ' 
        TextBoxRut.Location = New Point(204, 88)
        TextBoxRut.Name = "TextBoxRut"
        TextBoxRut.Size = New Size(204, 27)
        TextBoxRut.TabIndex = 1
        ' 
        ' buttonConsultarRut
        ' 
        buttonConsultarRut.Location = New Point(459, 72)
        buttonConsultarRut.Name = "buttonConsultarRut"
        buttonConsultarRut.Size = New Size(124, 67)
        buttonConsultarRut.TabIndex = 0
        buttonConsultarRut.Text = "Consultar"
        buttonConsultarRut.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondoLogin01
        ClientSize = New Size(914, 637)
        Controls.Add(panelRepuestos)
        Controls.Add(panelUsuario)
        Controls.Add(panelGestionServicios)
        Controls.Add(panelSiniestro)
        Controls.Add(panelVentaRepuestos)
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
        panelRepuestos.ResumeLayout(False)
        panelRepuestos.PerformLayout()
        panelUsuario.ResumeLayout(False)
        panelUsuario.PerformLayout()
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
    Friend WithEvents TextBoxTipo As TextBox
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
    Friend WithEvents TextBoxRepuestoNombre As TextBox
    Friend WithEvents ButtonGuardarRepuesto As Button
    Friend WithEvents ButtonEliminarRepuesto As Button
    Friend WithEvents ButtonEditarRepuesto As Button
    Friend WithEvents ButtonLimpiarRepuesto As Button
    Friend WithEvents ButtonConsultarRepuesto As Button
    Friend WithEvents ComboBoxRepuestos As ComboBox
End Class
