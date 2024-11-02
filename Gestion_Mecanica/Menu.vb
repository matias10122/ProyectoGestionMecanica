﻿Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar todos los paneles al inicio
        OcultarTodosLosPaneles()

        ' Mostrar solo el panelHome al inicio
        panelHome.Visible = True
        CargarTiposEnComboBox()
        comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub CargarTiposEnComboBox()
        comboBoxTipo.Items.Clear()
        comboBoxTipo.Items.Add("Administrador")
        comboBoxTipo.Items.Add("Usuario")
        comboBoxTipo.Items.Add("Vendedor")
        comboBoxTipo.Items.Add("Mecanico")
        comboBoxTipo.Items.Add("Aseguradora")
        comboBoxTipo.Items.Add("Analista")
        comboBoxTipo.Items.Add("Gerente")
        ' Agrega más tipos según sea necesario
    End Sub

    Private Sub OcultarTodosLosPaneles()
        ' Oculta todos los paneles
        panelHome.Visible = False
        panelRepuestos.Visible = False
        panelVentaRepuestos.Visible = False
        panelSiniestro.Visible = False
        panelSoliServicios.Visible = False
        panelGestionServicios.Visible = False
        panelUsuario.Visible = False
    End Sub

    Private Sub buttonRepuestos_Click(sender As Object, e As EventArgs) Handles buttonRepuestos.Click
        OcultarTodosLosPaneles()
        panelRepuestos.Visible = True
    End Sub

    Private Sub buttonVentaRepuestos_Click(sender As Object, e As EventArgs) Handles buttonVentaRepuestos.Click
        OcultarTodosLosPaneles()
        panelVentaRepuestos.Visible = True
    End Sub

    Private Sub buttonSiniestros_Click(sender As Object, e As EventArgs) Handles buttonSiniestros.Click
        OcultarTodosLosPaneles()
        panelSiniestro.Visible = True
    End Sub

    Private Sub buttonSoliServicios_Click(sender As Object, e As EventArgs) Handles buttonSoliServicios.Click
        OcultarTodosLosPaneles()
        panelSoliServicios.Visible = True
    End Sub

    Private Sub buttonGestionServicios_Click(sender As Object, e As EventArgs) Handles buttonGestionServicios.Click
        OcultarTodosLosPaneles()
        panelGestionServicios.Visible = True
    End Sub

    Private Sub buttonHome_Click(sender As Object, e As EventArgs) Handles buttonHome.Click
        OcultarTodosLosPaneles()
        panelHome.Visible = True
    End Sub

    Public Sub New(ByVal usuario As String, ByVal tipoUsuario As String)
        ' Esta llamada es requerida por el diseñador.
        InitializeComponent()

        ' Asigna el correo y tipo de usuario a los labels correspondientes
        Label2.Text = usuario
        Label4.Text = tipoUsuario
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Cerrar el formulario actual (Menu)
        Me.Close()
        ' Mostrar el formulario de login
        Dim loginForm As New Login()
        loginForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles buttonConsultarRut.Click
        Dim rut As String = TextBoxRut.Text.Trim()
        If String.IsNullOrEmpty(rut) Then
            MessageBox.Show("Por favor, ingrese un RUT para consultar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "server=localhost;user id=root;password=;database=taller"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("SELECT Rut, Correo, Contraseña, Tipo FROM usuarios WHERE Rut = @Rut", connection)
            command.Parameters.AddWithValue("@Rut", rut)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Usuario encontrado
                    TextBoxRutUsuario.Text = reader("Rut").ToString()
                    TextBoxCorreo.Text = reader("Correo").ToString()
                    TextBoxContraseña.Text = reader("Contraseña").ToString()
                    comboBoxTipo.Text = reader("Tipo").ToString()  ' Cambiado de TextBoxTipo a comboBoxTipo

                    ButtonGuardarUsuario.Enabled = False
                    ButtonEditar.Enabled = True
                    ButtonEliminarUsuario.Enabled = True
                    MessageBox.Show("Usted ha consultado un usuario de la base de datos. Puede Editarlo o Eliminarlo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Usuario no encontrado
                    TextBoxCorreo.Clear()
                    TextBoxContraseña.Clear()
                    comboBoxTipo.SelectedIndex = -1  ' Cambiado de TextBoxTipo.Clear() a comboBoxTipo.SelectedIndex = -1

                    ButtonGuardarUsuario.Enabled = True
                    ButtonEditar.Enabled = False
                    ButtonEliminarUsuario.Enabled = False
                    MessageBox.Show("El usuario que acaba de Consultar no existe en la base de datos de nuestro sistema, puede agregar al nuevo usuario o simplemente consultar otro RUT.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al consultar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub buttonUsuario_Click(sender As Object, e As EventArgs) Handles buttonUsuario.Click
        OcultarTodosLosPaneles()
        panelUsuario.Visible = True
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        If String.IsNullOrEmpty(TextBoxRutUsuario.Text.Trim()) Then
            MessageBox.Show("Debe ingresar un Rut y consultar antes de poder realizar cambios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "server=localhost;user id=root;password=;database=taller"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("UPDATE usuarios SET Correo = @Correo, Contraseña = @Contraseña, Tipo = @Tipo WHERE Rut = @Rut", connection)
            command.Parameters.AddWithValue("@Rut", TextBoxRutUsuario.Text.Trim())
            command.Parameters.AddWithValue("@Correo", TextBoxCorreo.Text.Trim())
            command.Parameters.AddWithValue("@Contraseña", TextBoxContraseña.Text.Trim())
            command.Parameters.AddWithValue("@Tipo", comboBoxTipo.Text.Trim()) ' Reemplazado aquí

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Se ha editado correctamente el Usuario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se pudo actualizar el usuario. Verifique el RUT.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ButtonEliminarUsuario_Click(sender As Object, e As EventArgs) Handles ButtonEliminarUsuario.Click
        If String.IsNullOrEmpty(TextBoxRutUsuario.Text.Trim()) Then
            MessageBox.Show("Debe ingresar un Rut y consultar antes de poder realizar cambios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim connectionString As String = "server=localhost;user id=root;password=;database=taller"
            Using connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand("DELETE FROM usuarios WHERE Rut = @Rut", connection)
                command.Parameters.AddWithValue("@Rut", TextBoxRutUsuario.Text.Trim())

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Se ha eliminado correctamente el Usuario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Limpiar los campos después de eliminar
                        TextBoxRutUsuario.Clear()
                        TextBoxCorreo.Clear()
                        TextBoxContraseña.Clear()
                        comboBoxTipo.SelectedIndex = -1 ' Limpiar comboBoxTipo
                    Else
                        MessageBox.Show("No se pudo eliminar el usuario. Verifique el RUT.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    Private Sub ButtonGuardarUsuario_Click(sender As Object, e As EventArgs) Handles ButtonGuardarUsuario.Click
        Dim connectionString As String = "server=localhost;user id=root;password=;database=taller"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("INSERT INTO usuarios (Rut, Correo, Contraseña, Tipo) VALUES (@Rut, @Correo, @Contraseña, @Tipo)", connection)
            command.Parameters.AddWithValue("@Rut", TextBoxRutUsuario.Text.Trim())
            command.Parameters.AddWithValue("@Correo", TextBoxCorreo.Text.Trim())
            command.Parameters.AddWithValue("@Contraseña", TextBoxContraseña.Text.Trim())
            command.Parameters.AddWithValue("@Tipo", comboBoxTipo.Text.Trim()) ' Reemplazado aquí

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Se ha guardado correctamente el Usuario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Limpiar los campos después de guardar
                    TextBoxRutUsuario.Clear()
                    TextBoxCorreo.Clear()
                    TextBoxContraseña.Clear()
                    comboBoxTipo.SelectedIndex = -1 ' Limpiar comboBoxTipo
                Else
                    MessageBox.Show("No se pudo guardar el usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al guardar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub buttonMostrarUsuarios_Click(sender As Object, e As EventArgs) Handles buttonMostrarUsuarios.Click
        Dim connectionString As String = "server=localhost;user id=root;password=;database=taller"
        Dim usuariosList As New List(Of String)()

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("SELECT Rut, Correo FROM usuarios", connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim rut As String = reader("Rut").ToString()
                    Dim correo As String = reader("Correo").ToString()
                    usuariosList.Add($"RUT: {rut}, Correo: {correo}")
                End While

                If usuariosList.Count > 0 Then
                    Dim usuariosInfo As String = String.Join(Environment.NewLine, usuariosList)
                    MessageBox.Show(usuariosInfo, "Lista de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No hay usuarios registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al cargar los usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub TextBoxRut_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRut.TextChanged

    End Sub

    Private connectionString As String = "server=localhost;user id=root;password=;database=taller"

    Private Sub Repuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
        CargarRepuestosEnComboBox()
    End Sub

    Private Sub LimpiarCampos()
        TextBoxBuscarRepuestoNombre.Clear()
        TextBoxBuscarRepuestoID.Clear()
        TextBoxRepuestoDescripcion.Clear()
        TextBoxRepuestoPrecio.Clear()
        TextBoxRepuestoCantidad.Clear()
        ButtonEditarRepuesto.Enabled = False
        ButtonEliminarRepuesto.Enabled = False
        TextBoxNombreVer.Clear()
    End Sub

    Private Function ExecuteReader(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As MySqlDataReader
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(query, connection)

        If parameters IsNot Nothing Then
            For Each param In parameters
                command.Parameters.AddWithValue(param.Key, param.Value)
            Next
        End If

        Try
            connection.Open()
            Return command.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            MessageBox.Show("Error al ejecutar la consulta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connection.Close()
            Return Nothing
        End Try
    End Function

    Private Function ExecuteScalar(query As String, parameters As Dictionary(Of String, Object)) As Object
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                Try
                    connection.Open()
                    Return command.ExecuteScalar()
                Catch ex As Exception
                    MessageBox.Show("Error al ejecutar la consulta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                End Try
            End Using
        End Using
    End Function

    Private Function ExecuteNonQuery(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                Try
                    connection.Open()
                    Return command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error al ejecutar la consulta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return 0
                End Try
            End Using
        End Using
    End Function

    Private Sub CargarRepuestosEnComboBox()
        ComboBoxRepuestos.Items.Clear()

        Dim query As String = "SELECT NombreRepuesto FROM repuestos"
        Using reader As MySqlDataReader = ExecuteReader(query)
            If reader IsNot Nothing Then
                While reader.Read()
                    ComboBoxRepuestos.Items.Add(reader("NombreRepuesto").ToString())
                End While
            End If
        End Using
    End Sub

    Private Sub ButtonGuardarRepuesto_Click(sender As Object, e As EventArgs) Handles ButtonGuardarRepuesto.Click
        If Not ValidarCamposObligatorios() Then Return

        Dim checkQuery As String = "SELECT COUNT(*) FROM repuestos WHERE NombreRepuesto = @Nombre"
        Dim checkParams As New Dictionary(Of String, Object) From {
        {"@Nombre", TextBoxBuscarRepuestoNombre.Text.Trim()}
    }

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(checkQuery, checkParams))
        If count > 0 Then
            MessageBox.Show("Este repuesto ya está registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim insertQuery As String = "INSERT INTO repuestos (NombreRepuesto, Proveedor, PrecioUnitario, CantidadStock) VALUES (@Nombre, @Proveedor, @Precio, @Cantidad)"
        Dim insertParams As New Dictionary(Of String, Object) From {
        {"@Nombre", TextBoxBuscarRepuestoNombre.Text.Trim()},
        {"@Proveedor", TextBoxRepuestoDescripcion.Text.Trim()},
        {"@Precio", Convert.ToDecimal(TextBoxRepuestoPrecio.Text.Trim())},
        {"@Cantidad", Convert.ToInt32(TextBoxRepuestoCantidad.Text.Trim())}
    }

        If ExecuteNonQuery(insertQuery, insertParams) > 0 Then
            MessageBox.Show("Repuesto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            CargarRepuestosEnComboBox()
        End If
    End Sub

    Private Sub ButtonEditarRepuesto_Click(sender As Object, e As EventArgs) Handles ButtonEditarRepuesto.Click
        If Not ValidarCamposObligatorios() Then Return

        Dim query As String = "UPDATE repuestos SET RepuestoID = @ID, NombreRepuesto = @Nombre, Proveedor = @Proveedor, PrecioUnitario = @Precio, CantidadStock = @Cantidad WHERE RepuestoID = @ID OR NombreRepuesto = @Nombre"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@ID", TextBoxBuscarRepuestoID.Text.Trim()},
        {"@Nombre", TextBoxBuscarRepuestoNombre.Text.Trim()},
        {"@Proveedor", TextBoxRepuestoDescripcion.Text.Trim()},
        {"@Precio", Convert.ToDecimal(TextBoxRepuestoPrecio.Text.Trim())},
        {"@Cantidad", Convert.ToInt32(TextBoxRepuestoCantidad.Text.Trim())}
    }

        If ExecuteNonQuery(query, parameters) > 0 Then
            MessageBox.Show("Repuesto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            CargarRepuestosEnComboBox()
        Else
            MessageBox.Show("No se pudo actualizar el repuesto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonEliminarRepuesto_Click(sender As Object, e As EventArgs) Handles ButtonEliminarRepuesto.Click
        Dim query As String = "DELETE FROM repuestos WHERE (RepuestoID = @ID OR NombreRepuesto = @Nombre)"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@ID", TextBoxBuscarRepuestoID.Text.Trim()},
        {"@Nombre", TextBoxBuscarRepuestoNombre.Text.Trim()}
    }

        If ExecuteNonQuery(query, parameters) > 0 Then
            MessageBox.Show("Repuesto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            CargarRepuestosEnComboBox()
        Else
            MessageBox.Show("No se pudo eliminar el repuesto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonConsultarRepuesto_Click(sender As Object, e As EventArgs) Handles ButtonConsultarRepuesto.Click
        Dim nombreOId As String = TextBoxBuscarRepuestoNombre.Text.Trim()
        If String.IsNullOrEmpty(nombreOId) Then
            MessageBox.Show("Por favor, ingrese un ID o nombre de repuesto para consultar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "SELECT RepuestoID, NombreRepuesto, Proveedor, PrecioUnitario, CantidadStock FROM repuestos WHERE RepuestoID = @ID OR NombreRepuesto = @Nombre"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@ID", If(IsNumeric(nombreOId), nombreOId, DBNull.Value)},
        {"@Nombre", If(IsNumeric(nombreOId), DBNull.Value, nombreOId)}
    }

        Using reader As MySqlDataReader = ExecuteReader(query, parameters)
            If reader IsNot Nothing AndAlso reader.Read() Then
                TextBoxBuscarRepuestoID.Text = reader("RepuestoID").ToString()
                TextBoxBuscarRepuestoNombre.Text = reader("NombreRepuesto").ToString()
                TextBoxRepuestoDescripcion.Text = reader("Proveedor").ToString()
                TextBoxRepuestoPrecio.Text = reader("PrecioUnitario").ToString()
                TextBoxRepuestoCantidad.Text = reader("CantidadStock").ToString()
                ButtonEditarRepuesto.Enabled = True
                ButtonEliminarRepuesto.Enabled = True
            Else
                MessageBox.Show("Repuesto no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
            End If
        End Using
    End Sub

    Private Sub ButtonLimpiarRepuesto_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarRepuesto.Click
        LimpiarCampos()
    End Sub

    Private Function ValidarCamposObligatorios() As Boolean
        Dim precio As Decimal
        If Not Decimal.TryParse(TextBoxRepuestoPrecio.Text.Trim(), precio) Then
            MessageBox.Show("El campo Precio solo debe contener números.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxRepuestoPrecio.Focus()
            Return False
        End If

        Dim cantidad As Integer
        If Not Integer.TryParse(TextBoxRepuestoCantidad.Text.Trim(), cantidad) Then
            MessageBox.Show("El campo Cantidad solo debe contener números enteros.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxRepuestoCantidad.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(TextBoxBuscarRepuestoNombre.Text) OrElse
        String.IsNullOrWhiteSpace(TextBoxRepuestoDescripcion.Text) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' Sincronización del texto en TextBoxNombreVer
    Private Sub TextBoxBuscarRepuestoNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscarRepuestoNombre.TextChanged
        TextBoxNombreVer.Text = TextBoxBuscarRepuestoNombre.Text
    End Sub

    Private Sub LabelRut_Click(sender As Object, e As EventArgs) Handles LabelRut.Click

    End Sub


    Private Sub limpiarCamposGestionUsuarios_Click(sender As Object, e As EventArgs) Handles limpiarCamposGestionUsuarios.Click
        ' Limpiar los campos
        TextBoxRutUsuario.Clear()
        comboBoxTipo.SelectedIndex = -1 ' Desmarcar el ComboBox
        TextBoxContraseña.Clear()
        TextBoxCorreo.Clear()
        TextBoxRut.Clear()
    End Sub

    Private Sub ComboBoxRepuestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRepuestos.SelectedIndexChanged
        ' Al seleccionar un elemento en el ComboBox, muestra el nombre en el TextBox
        TextBoxBuscarRepuestoNombre.Text = ComboBoxRepuestos.SelectedItem.ToString()
    End Sub

    '-------------------------------------generar código venta-repuesto    02-11-2024----------------------------------------
    '-------------------------------------generar codigo venta-repuesto    02-11.2024----------------------------------------'

    'Codigo Jasna'


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar el ComboBox con los nombres de los repuestos
        CargarNombresRepuestos()
    End Sub


    ' Método para cargar los nombres de los repuestos en el ComboBox
    Private Sub CargarNombresRepuestos()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Consulta para obtener los nombres de los repuestos
                Dim sql As String = "SELECT NombreRepuesto FROM Repuestos"
                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbNombreRepuesto.Items.Clear() ' Limpiar el ComboBox antes de llenarlo
                        While reader.Read()
                            ' Agregar los nombres de los repuestos al ComboBox
                            cmbNombreRepuesto.Items.Add(reader("NombreRepuesto").ToString())
                        End While
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al cargar los repuestos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Evento para mostrar el precio unitario, ID y cantidad en txtMontoNeto, txtId, y txtStock al seleccionar un repuesto
    Private Sub cmbNombreRepuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombreRepuesto.SelectedIndexChanged
        ' Limpiar los campos si no hay un elemento seleccionado
        If cmbNombreRepuesto.SelectedItem Is Nothing Then
            LimpiarCamposRepuesto()
            Return
        End If

        ' Obtener y mostrar los detalles del repuesto seleccionado
        Dim nombreRepuesto As String = cmbNombreRepuesto.SelectedItem.ToString()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT PrecioUnitario, RepuestoID, CantidadStock FROM Repuestos WHERE NombreRepuesto = @nombreRepuesto"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtMontoNeto.Text = Convert.ToDecimal(reader("PrecioUnitario")).ToString("C")
                            txtId.Text = reader("RepuestoID").ToString()
                            txtStock.Text = reader("CantidadStock").ToString()
                        Else
                            LimpiarCamposRepuesto()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener el precio del repuesto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Sub para limpiar los campos
    Private Sub LimpiarCamposRepuesto()
        txtMontoNeto.Text = "0"
        txtId.Text = ""
        txtStock.Text = ""
    End Sub

    'En este Bloque se registra la venta realizada'
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnRegistrarVenta.Click
        ' Verificar que un repuesto esté seleccionado
        Dim nombreRepuesto As String = If(cmbNombreRepuesto.SelectedItem?.ToString(), "")
        If String.IsNullOrEmpty(nombreRepuesto) Then
            MessageBox.Show("Por favor, seleccione un repuesto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Verificar y convertir la cantidad vendida
        Dim CantidadVendida As Integer
        If Not Integer.TryParse(txtCantidadVendida.Text, CantidadVendida) Then
            MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Inicializar total
        Dim total As Decimal = 0
        txtTotal.Text = total.ToString("C")

        Using connection As New MySqlConnection(connectionString)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Consulta para obtener el precio unitario y verificar el stock
                Dim Query As String = "SELECT CantidadStock, PrecioUnitario FROM Repuestos WHERE NombreRepuesto = @nombreRepuesto"
                Using cmd As New MySqlCommand(Query, connection)
                    cmd.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim CantidadStock As Integer = Convert.ToInt32(reader("CantidadStock"))
                            Dim PrecioUnitario As Decimal = Convert.ToDecimal(reader("PrecioUnitario"))

                            ' Calcular el total
                            total = (CantidadVendida * PrecioUnitario) * 1.19
                            txtTotal.Text = total.ToString("C")

                            ' Verificar si hay suficiente stock
                            If CantidadStock >= CantidadVendida Then
                                ' Cerrar el reader para ejecutar nuevas consultas
                                reader.Close()

                                ' Insertar en ventasrepuestos directamente
                                Dim insertQuery As String = "INSERT INTO ventasrepuestos (NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total) VALUES (@nombreRepuesto, @cantidadVendida, @cliente, @fechaVenta, @total)"
                                Using insertCmd As New MySqlCommand(insertQuery, connection)
                                    insertCmd.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)
                                    insertCmd.Parameters.AddWithValue("@cantidadVendida", CantidadVendida)
                                    insertCmd.Parameters.AddWithValue("@cliente", txtCliente.Text.Trim())
                                    insertCmd.Parameters.AddWithValue("@fechaVenta", dtpFechaVenta.Value)
                                    insertCmd.Parameters.AddWithValue("@total", total)
                                    insertCmd.ExecuteNonQuery()
                                End Using

                                ' Actualizar el stock en la tabla de repuestos
                                Dim updateStockQuery As String = "UPDATE repuestos SET CantidadStock = CantidadStock - @cantidadVendida WHERE NombreRepuesto = @nombreRepuesto"
                                Using updateCmd As New MySqlCommand(updateStockQuery, connection)
                                    updateCmd.Parameters.AddWithValue("@cantidadVendida", CantidadVendida)
                                    updateCmd.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)
                                    updateCmd.ExecuteNonQuery()
                                End Using

                                ' Mostrar mensaje de éxito
                                Dim resumenVenta As String = $"Resumen de Venta:{Environment.NewLine}" &
                                                     $"Repuesto: {nombreRepuesto}{Environment.NewLine}" &
                                                     $"Cantidad Vendida: {CantidadVendida}{Environment.NewLine}" &
                                                     $"Cliente: {txtCliente.Text.Trim()}{Environment.NewLine}" &
                                                     $"Fecha de Venta: {dtpFechaVenta.Value.ToShortDateString()}{Environment.NewLine}" &
                                                     $"Total: {total.ToString("C")}"

                                MessageBox.Show(resumenVenta, "Venta Registrada Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                ' Limpiar los campos de texto después de mostrar el resumen
                                txtCantidadVendida.Text = ""
                                txtCliente.Text = ""
                                txtMontoNeto.Text = ""
                                txtStock.Text = ""
                                txtTotal.Text = ""
                                cmbNombreRepuesto.Text = ""
                                txtId.Text = ""

                                ' Actualizar el DataGridView con las ventas recientes
                                CargarResumenVentas()
                            Else
                                MessageBox.Show("Stock insuficiente para realizar la venta.")
                            End If
                        Else
                            MessageBox.Show("Repuesto no encontrado en el inventario.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al realizar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub  'Fin del bloque de insertar la venta'


    'Esta parte es para actualizar la compra'
    Private Sub btEditarVenta_Click(sender As Object, e As EventArgs) Handles btEditarVenta.Click
        If selectedVentaId = -1 Then
            MessageBox.Show("Seleccione una venta para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nombreRepuesto As String = If(cmbNombreRepuesto.SelectedItem?.ToString(), "")
        If String.IsNullOrEmpty(nombreRepuesto) Then
            MessageBox.Show("Por favor, seleccione un repuesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim CantidadVendidaNueva As Integer
        If Not Integer.TryParse(txtCantidadVendida.Text, CantidadVendidaNueva) Then
            MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim cliente As String = txtCliente.Text.Trim()
        If String.IsNullOrEmpty(cliente) Then
            MessageBox.Show("Ingrese el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim PrecioUnitario As Decimal
        If Not Decimal.TryParse(txtMontoNeto.Text.Replace("$", "").Trim(), PrecioUnitario) Then
            MessageBox.Show("El monto neto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim total As Decimal = (CantidadVendidaNueva * PrecioUnitario) * 1.19
        txtTotal.Text = total.ToString("C")

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Using transaction As MySqlTransaction = connection.BeginTransaction()
                Try
                    Dim cantidadVendidaOriginal As Integer
                    Dim stockActual As Integer

                    ' Obtener el stock actual y cantidad vendida original
                    Dim queryStock As String = "SELECT CantidadStock FROM Repuestos WHERE NombreRepuesto = @nombreRepuesto"
                    Using cmdStock As New MySqlCommand(queryStock, connection, transaction)
                        cmdStock.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)
                        stockActual = Convert.ToInt32(cmdStock.ExecuteScalar())
                    End Using

                    Dim queryVenta As String = "SELECT CantidadVendida FROM ventasrepuestos WHERE VentaID = @ventaId"
                    Using cmdVenta As New MySqlCommand(queryVenta, connection, transaction)
                        cmdVenta.Parameters.AddWithValue("@ventaId", selectedVentaId)
                        cantidadVendidaOriginal = Convert.ToInt32(cmdVenta.ExecuteScalar())
                    End Using

                    Dim cantidadRestaurar As Integer = CantidadVendidaNueva - cantidadVendidaOriginal
                    Dim nuevoStock As Integer = stockActual - cantidadRestaurar

                    ' Actualizar el stock
                    Dim queryUpdateStock As String = "UPDATE Repuestos SET CantidadStock = @nuevoStock WHERE NombreRepuesto = @nombreRepuesto"
                    Using cmdUpdateStock As New MySqlCommand(queryUpdateStock, connection, transaction)
                        cmdUpdateStock.Parameters.AddWithValue("@nuevoStock", nuevoStock)
                        cmdUpdateStock.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)
                        cmdUpdateStock.ExecuteNonQuery()
                    End Using

                    ' Actualizar la venta
                    Dim query As String = "UPDATE ventasrepuestos SET NombreRepuesto = @nombreRepuesto, CantidadVendida = @cantidadVendidaNueva, Cliente = @cliente, FechaVenta = @fechaVenta, Total = @total WHERE VentaID = @ventaId"
                    Using cmd As New MySqlCommand(query, connection, transaction)
                        cmd.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)
                        cmd.Parameters.AddWithValue("@cantidadVendidaNueva", CantidadVendidaNueva)
                        cmd.Parameters.AddWithValue("@cliente", cliente)
                        cmd.Parameters.AddWithValue("@fechaVenta", dtpFechaVenta.Value)
                        cmd.Parameters.AddWithValue("@total", total)
                        cmd.Parameters.AddWithValue("@ventaId", selectedVentaId)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            transaction.Commit()
                            MessageBox.Show("Venta actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarResumenVentas()
                            LimpiarCampos2()
                        Else
                            transaction.Rollback()
                            MessageBox.Show("No se pudo actualizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error al actualizar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LimpiarCampos2()
        txtId.Clear()
        cmbNombreRepuesto.SelectedIndex = -1
        txtCantidadVendida.Clear()
        txtCliente.Clear()
        txtMontoNeto.Clear()
        txtStock.Clear()
        txtTotal.Clear()
        selectedVentaId = -1
    End Sub

    Private Sub btnEliminarVenta_Click(sender As Object, e As EventArgs) Handles btnEliminarVenta.Click
        ' Verificar que una venta esté seleccionada para eliminar
        If selectedVentaId = -1 Then
            MessageBox.Show("Seleccione una venta para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirmar eliminación
        Dim confirmResult As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta venta?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then
            Return
        End If

        ' Obtener valores para restaurar el stock
        Dim nombreRepuesto As String = cmbNombreRepuesto.SelectedItem?.ToString()
        Dim CantidadVendida As Integer
        If Not Integer.TryParse(txtCantidadVendida.Text, CantidadVendida) Then
            MessageBox.Show("Cantidad vendida no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Realizar la eliminación y restaurar el stock
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Recuperar el stock actual del repuesto
                Dim stockActual As Integer
                Dim queryStock As String = "SELECT CantidadStock FROM Repuestos WHERE NombreRepuesto = @nombreRepuesto"
                Using cmdStock As New MySqlCommand(queryStock, connection)
                    cmdStock.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)
                    stockActual = Convert.ToInt32(cmdStock.ExecuteScalar())
                End Using

                ' Actualizar el stock añadiendo la cantidad vendida
                Dim nuevoStock As Integer = stockActual + CantidadVendida
                Dim updateStockQuery As String = "UPDATE Repuestos SET CantidadStock = @nuevoStock WHERE NombreRepuesto = @nombreRepuesto"
                Using updateCmd As New MySqlCommand(updateStockQuery, connection)
                    updateCmd.Parameters.AddWithValue("@nuevoStock", nuevoStock)
                    updateCmd.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)
                    updateCmd.ExecuteNonQuery()
                End Using

                ' Eliminar la venta seleccionada
                Dim deleteQuery As String = "DELETE FROM ventasrepuestos WHERE VentaID = @ventaId"
                Using deleteCmd As New MySqlCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@ventaId", selectedVentaId)
                    deleteCmd.ExecuteNonQuery()
                End Using

                ' Mostrar mensaje de éxito
                MessageBox.Show("Venta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Recargar el resumen de ventas y limpiar los campos después de la eliminación
                CargarResumenVentas()
                LimpiarCampos3()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub

    Private Sub LimpiarCampos3()
        txtId.Clear()
        cmbNombreRepuesto.SelectedIndex = -1
        txtCantidadVendida.Clear()
        txtCliente.Clear()
        txtMontoNeto.Clear()
        txtStock.Clear()
        txtTotal.Clear()
        selectedVentaId = -1
    End Sub



    '-------------------------------------------------------------------------------------------'



    'Este es el codigo de resumen de venta'


    'Mostrar el resumen de ventas'


    Private Sub frmRegistroVentaRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos en el DataGridView al abrir el formulario
        CargarResumenVentas()
    End Sub
    'Mostrar el resumen de ventas'

    Private Sub CargarResumenVentas(Optional fechaInicio As DateTime? = Nothing, Optional fechaFin As DateTime? = Nothing, Optional repuesto As String = "", Optional cliente As String = "")
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Incluir VentaID en la consulta para poder identificar la venta en la edición
                Dim query As String = "SELECT VentaID, FechaVenta, NombreRepuesto, CantidadVendida, Cliente, Total FROM ventasrepuestos WHERE 1=1"
                If fechaInicio.HasValue AndAlso fechaFin.HasValue Then query &= " AND FechaVenta BETWEEN @fechaInicio AND @fechaFin"
                If Not String.IsNullOrEmpty(repuesto) Then query &= " AND NombreRepuesto = @repuesto"
                If Not String.IsNullOrEmpty(cliente) Then query &= " AND Cliente LIKE @cliente"

                Using cmd As New MySqlCommand(query, connection)
                    If fechaInicio.HasValue AndAlso fechaFin.HasValue Then
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Value)
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin.Value)
                    End If
                    If Not String.IsNullOrEmpty(repuesto) Then cmd.Parameters.AddWithValue("@repuesto", repuesto)
                    If Not String.IsNullOrEmpty(cliente) Then cmd.Parameters.AddWithValue("@cliente", "%" & cliente & "%")

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvResumenVentas.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private selectedVentaId As Integer = -1

    Private Sub dgvResumenVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResumenVentas.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvResumenVentas.Rows(e.RowIndex)

            ' Cargar datos en los controles
            selectedVentaId = Convert.ToInt32(row.Cells("VentaID").Value)
            cmbNombreRepuesto.SelectedItem = row.Cells("NombreRepuesto").Value.ToString()
            txtCantidadVendida.Text = row.Cells("CantidadVendida").Value.ToString()
            txtCliente.Text = row.Cells("Cliente").Value.ToString()
            dtpFechaVenta.Value = Convert.ToDateTime(row.Cells("FechaVenta").Value)
            txtTotal.Text = row.Cells("Total").Value.ToString()
        End If

    End Sub

    Private Sub btnAplicarFiltros_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltros.Click
        ' Obtener los valores de los controles para filtrar
        Dim fechaInicio As DateTime? = If(dtpFechaInicio.Checked, dtpFechaInicio.Value, Nothing)
        Dim fechaFin As DateTime? = If(dtpFechaFin.Checked, dtpFechaFin.Value, Nothing)
        Dim repuesto As String = If(cmbFiltroRepuesto.SelectedItem?.ToString(), "")
        Dim cliente As String = If(cmbFiltroCliente.SelectedItem?.ToString(), "")

        ' Llamar a la función CargarResumenVentas con los filtros
        CargarResumenVentas(fechaInicio, fechaFin, repuesto, cliente)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar el ComboBox con los nombres de los repuestos
        CargarRepuestos()
    End Sub

    ' Método para cargar los nombres de los repuestos en el ComboBox
    Private Sub CargarRepuestos()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Consulta para obtener los nombres de los repuestos
                Dim sql As String = "SELECT NombreRepuesto FROM Repuestos"
                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbFiltroRepuesto.Items.Clear() ' Limpiar el ComboBox antes de llenarlo
                        cmbFiltroRepuesto.Items.Add("") ' Agregar línea en blanco
                        While reader.Read()
                            ' Agregar los nombres de los repuestos al ComboBox
                            Dim repuesto As String = reader("NombreRepuesto").ToString()
                            If Not cmbFiltroRepuesto.Items.Contains(repuesto) Then
                                cmbFiltroRepuesto.Items.Add(repuesto)
                            End If
                        End While
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al cargar los repuestos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar el ComboBox con los nombres de los clientes
        CargarCliente()
    End Sub

    ' Método para cargar los nombres de los clientes en el ComboBox
    Private Sub CargarCliente()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Consulta para obtener los nombres de los clientes
                ' Usamos DISTINCT para obtener solo nombres únicos de clientes.
                ' Esto evita duplicados en el ComboBox, mostrando cada cliente solo una vez,
                ' incluso si tiene múltiples registros en la tabla ventasrepuestos.
                Dim sql As String = "SELECT DISTINCT Cliente FROM ventasrepuestos"
                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbFiltroCliente.Items.Clear() ' Limpiar el ComboBox antes de llenarlo
                        cmbFiltroCliente.Items.Add("") ' Agregar línea en blanco

                        While reader.Read()
                            Dim cliente As String = reader("Cliente").ToString()
                            If Not cmbFiltroCliente.Items.Contains(cliente) Then
                                cmbFiltroCliente.Items.Add(cliente)
                            End If
                        End While
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al cargar los clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnRestaurarFiltros_Click(sender As Object, e As EventArgs) Handles btnRestaurarFiltros.Click
        ' restaurar los filtros y mostrar todos los registros

        ' Limpiar los filtros en los ComboBox y DateTimePickers
        cmbFiltroRepuesto.SelectedIndex = -1 ' Desmarca el filtro de repuestos
        cmbFiltroCliente.SelectedIndex = -1 ' Desmarca el filtro de clientes
        dtpFechaInicio.Checked = False ' Desmarca la fecha de inicio
        dtpFechaFin.Checked = False ' Desmarca la fecha de fin

        ' Llamar a la función para cargar todos los registros sin filtros
        CargarResumenVentas()
    End Sub

    'Codigo para que se expanda el DataGridView'

    Private originalSize As Size
    Private originalLocation As Point
    Private originalParent As Control
    Private isExpanded As Boolean = False

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        ' Verificar si ya está expandido o no
        If Not isExpanded Then
            ' Guardar el tamaño, la ubicación y el control padre originales
            originalSize = dgvResumenVentas.Size
            originalLocation = dgvResumenVentas.Location
            originalParent = dgvResumenVentas.Parent

            ' Cambiar el Parent del DataGridView al formulario para que esté sobre todos los controles
            Me.Controls.Add(dgvResumenVentas) ' Agregar al formulario principal
            dgvResumenVentas.BringToFront() ' Llevar al frente
            dgvResumenVentas.Location = New Point(14, 53) ' Nueva ubicación en la pantalla
            dgvResumenVentas.Size = New Size(450, 390) ' Tamaño expandido
            dgvResumenVentas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

            ' Cambiar el texto del botón y marcar como expandido
            btnVer.Text = "Cerrar"
            isExpanded = True
        Else
            ' Restaurar el DataGridView a su control padre original (GroupBox), tamaño y posición originales
            originalParent.Controls.Add(dgvResumenVentas) ' Regresar al control original
            dgvResumenVentas.Size = originalSize
            dgvResumenVentas.Location = originalLocation
            dgvResumenVentas.Anchor = AnchorStyles.Top Or AnchorStyles.Left

            ' Cambiar el texto del botón y marcar como no expandido
            btnVer.Text = "Ver"
            isExpanded = False
        End If
    End Sub


End Class