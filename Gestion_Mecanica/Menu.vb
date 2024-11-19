Imports System.IO
Imports System.Net.Mail
Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar todos los paneles al inicio
        OcultarTodosLosPaneles()

        ' Mostrar solo el panelHome !
        panelHome.Visible = True
        CargarTiposEnComboBox()
        comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList
        CargarDatosEnDataGridView()
        LlenarComboBoxRut()
        LlenarComboBoxCompaAgrSin()
        LlenarComboBoxBuscCli()
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
        panelClientes.Visible = False
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

    Private Sub buttonClientes_Click(sender As Object, e As EventArgs) Handles buttonClientes.Click
        OcultarTodosLosPaneles()
        panelClientes.Visible = True
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

        ' Copiar el RUT ingresado en el TextBoxRutUsuario
        TextBoxRutUsuario.Text = rut

        Dim connectionString As String = "server=localhost;user id=root;password=;database=taller"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("SELECT Rut, Correo, Contraseña, Tipo FROM usuarios WHERE Rut = @Rut", connection)
            command.Parameters.AddWithValue("@Rut", rut)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Usuario encontrado
                    TextBoxRutUsuario.Text = reader("Rut").ToString()  ' Si el RUT está en la base de datos, también lo mostramos aquí
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


    'Fin del bloque de insertar la venta'


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
        Dim confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta venta?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then
            Return
        End If

        ' Obtener valores para restaurar el stock
        Dim nombreRepuesto = cmbNombreRepuesto.SelectedItem?.ToString
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
                Dim queryStock = "SELECT CantidadStock FROM Repuestos WHERE NombreRepuesto = @nombreRepuesto"
                Using cmdStock As New MySqlCommand(queryStock, connection)
                    cmdStock.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)
                    stockActual = Convert.ToInt32(cmdStock.ExecuteScalar)
                End Using

                ' Actualizar el stock añadiendo la cantidad vendida
                Dim nuevoStock = stockActual + CantidadVendida
                Dim updateStockQuery = "UPDATE Repuestos SET CantidadStock = @nuevoStock WHERE NombreRepuesto = @nombreRepuesto"
                Using updateCmd As New MySqlCommand(updateStockQuery, connection)
                    updateCmd.Parameters.AddWithValue("@nuevoStock", nuevoStock)
                    updateCmd.Parameters.AddWithValue("@nombreRepuesto", nombreRepuesto)
                    updateCmd.ExecuteNonQuery()
                End Using

                ' Eliminar la venta seleccionada
                Dim deleteQuery = "DELETE FROM ventasrepuestos WHERE VentaID = @ventaId"
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

    Private Sub CargarResumenVentas(Optional fechaInicio As DateTime? = Nothing, Optional fechaFin As DateTime? = Nothing, Optional repuesto As String = "", Optional rutCliente As String = "")
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Construir la consulta SQL base
                Dim query As String = "SELECT VentaID, FechaVenta, NombreRepuesto, CantidadVendida, Cliente, Total FROM ventasrepuestos WHERE 1=1"

                ' Agregar condiciones opcionales para la consulta SQL
                If fechaInicio.HasValue Then query &= " AND FechaVenta >= @fechaInicio"
                If fechaFin.HasValue Then query &= " AND FechaVenta <= @fechaFin"
                If Not String.IsNullOrEmpty(repuesto) Then query &= " AND NombreRepuesto = @repuesto"
                If Not String.IsNullOrEmpty(rutCliente) Then query &= " AND Cliente = @rutCliente"

                Using cmd As New MySqlCommand(query, connection)
                    ' Asignar valores a los parámetros solo si están presentes
                    If fechaInicio.HasValue Then cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Value)
                    If fechaFin.HasValue Then cmd.Parameters.AddWithValue("@fechaFin", fechaFin.Value)
                    If Not String.IsNullOrEmpty(repuesto) Then cmd.Parameters.AddWithValue("@repuesto", repuesto)
                    If Not String.IsNullOrEmpty(rutCliente) Then cmd.Parameters.AddWithValue("@rutCliente", rutCliente)

                    ' Ejecutar la consulta y cargar los datos en el DataGridView
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvResumenVentas.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las ventas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private selectedVentaId As Integer = -1

    Private Sub dgvResumenVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResumenVentas.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvResumenVentas.Rows(e.RowIndex)

                ' Verificar y asignar el valor de VentaID
                If Not IsDBNull(row.Cells("VentaID").Value) Then
                    selectedVentaId = Convert.ToInt32(row.Cells("VentaID").Value)
                End If

                ' Verificar y asignar el valor de NombreRepuesto
                cmbNombreRepuesto.Text = If(row.Cells("NombreRepuesto").Value IsNot DBNull.Value, row.Cells("NombreRepuesto").Value.ToString(), "")

                ' Verificar y asignar el valor de CantidadVendida
                txtCantidadVendida.Text = If(row.Cells("CantidadVendida").Value IsNot DBNull.Value, row.Cells("CantidadVendida").Value.ToString(), "")

                ' Verificar y asignar el valor de Cliente
                txtCliente.Text = If(row.Cells("Cliente").Value IsNot DBNull.Value, row.Cells("Cliente").Value.ToString(), "")

                ' Verificar y asignar el valor de FechaVenta
                If row.Cells("FechaVenta").Value IsNot DBNull.Value Then
                    dtpFechaVenta.Value = Convert.ToDateTime(row.Cells("FechaVenta").Value)
                Else
                    dtpFechaVenta.Value = DateTime.Now ' Fecha por defecto si no hay valor
                End If

                ' Verificar y asignar el valor de Total con formato de moneda
                txtTotal.Text = If(row.Cells("Total").Value IsNot DBNull.Value, Convert.ToDecimal(row.Cells("Total").Value).ToString("C"), "")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAplicarFiltros_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltros.Click
        ' Obtener los valores de los controles para filtrar
        Dim fechaInicio As DateTime? = If(dtpFechaInicio.Checked, dtpFechaInicio.Value, Nothing)
        Dim fechaFin As DateTime? = If(dtpFechaFin.Checked, dtpFechaFin.Value, Nothing)
        Dim repuesto As String = If(cmbFiltroRepuesto.SelectedItem?.ToString(), "")
        Dim rutCliente As String = If(cmbFiltroCliente.SelectedItem?.ToString(), "")

        ' Llamar a la función CargarResumenVentas con los filtros
        CargarResumenVentas(fechaInicio, fechaFin, repuesto, rutCliente)
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
        ' Restaurar los filtros en los ComboBox y DateTimePickers

        ' Limpiar los filtros en los ComboBox
        cmbFiltroRepuesto.SelectedIndex = -1 ' Desmarca el filtro de repuestos
        cmbFiltroCliente.SelectedIndex = -1 ' Desmarca el filtro de clientes

        ' Establecer y desmarcar las fechas en los DateTimePickers
        dtpFechaInicio.Value = DateTime.Now ' Puedes cambiar esta fecha a otra por defecto si lo prefieres
        dtpFechaInicio.Checked = False

        dtpFechaFin.Value = DateTime.Now ' Puedes cambiar esta fecha a otra por defecto si lo prefieres
        dtpFechaFin.Checked = False

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
    'Extras'
    ' Evento que se ejecuta cuando se cambia el texto en el txtCliente
    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
        ' Obtener el RUT del cliente ingresado
        Dim rutCliente As String = txtCliente.Text.Trim()

        ' Validar que el RUT no esté vacío antes de realizar la consulta
        If String.IsNullOrEmpty(rutCliente) Then
            lblDatosCliente.Text = "Ingrese un RUT para ver los detalles del cliente."
            Return
        End If

        ' Realizar la consulta para obtener los datos del cliente con el RUT ingresado
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna FROM clientes WHERE Rut = @rutCliente"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rutCliente", rutCliente)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Construir la cadena con la información del cliente
                            Dim clienteInfo As String = $"Datos Cliente:{Environment.NewLine}" &
                                                    $"Nombre Completo: {reader("Nombre")} {reader("ApellidoP")} {reader("ApellidoM")}{Environment.NewLine}" &
                                                    $"Dir: {reader("Direccion")}{Environment.NewLine}" &
                                                    $"Tel: {reader("Telefono")}{Environment.NewLine}" &
                                                    $"Comuna: {reader("Comuna")}"

                            ' Mostrar la información en el lblDatosCliente
                            lblDatosCliente.Text = clienteInfo
                        Else
                            lblDatosCliente.Text = "Cliente no encontrado con el RUT ingresado."
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener la información del cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar el panel de la boleta al iniciar el formulario
        pnlBoleta.Visible = False
    End Sub
    Private Sub btnGenerarBoleta_Click(sender As Object, e As EventArgs) Handles btnGenerarBoleta.Click
        ' Verificar si el panel de la boleta ya está visible
        If pnlBoleta.Visible Then
            ' Si está visible, oculta el panel y cambia el texto del botón a "Generar Boleta"
            pnlBoleta.Visible = False
            btnGenerarBoleta.Text = "Generar Boleta"
        Else
            ' Verificar que al menos una fila esté seleccionada en el DataGridView
            If dgvResumenVentas.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione una o más ventas en el listado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Obtener el RUT del cliente desde la primera fila seleccionada
            Dim clienteRut As String = dgvResumenVentas.SelectedRows(0).Cells("Cliente").Value.ToString()

            ' Proceder a generar la boleta
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Try
                    ' Obtener información del cliente
                    Dim clienteNombre As String = ""
                    Dim clienteDireccion As String = ""
                    Dim queryCliente As String = "SELECT Nombre, ApellidoP, ApellidoM, Direccion FROM clientes WHERE Rut = @rut"
                    Using cmdCliente As New MySqlCommand(queryCliente, connection)
                        cmdCliente.Parameters.AddWithValue("@rut", clienteRut)
                        Using reader As MySqlDataReader = cmdCliente.ExecuteReader()
                            If reader.Read() Then
                                clienteNombre = $"{reader("Nombre")} {reader("ApellidoP")} {reader("ApellidoM")}"
                                clienteDireccion = reader("Direccion").ToString()
                            Else
                                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                        End Using
                    End Using

                    ' Mostrar los datos del cliente en el label correspondiente
                    lblRutCliente_nombre.Text = $"Cliente: {clienteNombre}{Environment.NewLine}RUT: {clienteRut}"

                    ' Procesar las filas seleccionadas y calcular los totales
                    Dim totalSinIva As Decimal = 0
                    Dim ventas As New List(Of String)()

                    ' Encabezado "Producto" con espacio adicional
                    ventas.Add("Producto:" & Environment.NewLine)

                    For Each selectedRow As DataGridViewRow In dgvResumenVentas.SelectedRows
                        Dim nombreRepuesto = selectedRow.Cells("NombreRepuesto").Value.ToString()
                        Dim cantidadVendida = Convert.ToInt32(selectedRow.Cells("CantidadVendida").Value)
                        Dim totalItem = Convert.ToDecimal(selectedRow.Cells("Total").Value)
                        totalSinIva += totalItem

                        ' Agregar detalles del producto
                        ventas.Add($"  {nombreRepuesto} | Cantidad: {cantidadVendida} | Total Neto: {totalItem:C}")
                    Next

                    ' Mostrar los detalles del producto y sus valores en el lblProducto
                    lblProducto.Text = String.Join(Environment.NewLine, ventas)

                    ' Calcular el IVA y el total con IVA
                    Dim iva As Decimal = totalSinIva * 0.19D
                    Dim totalConIva As Decimal = totalSinIva + iva

                    ' Mostrar los totales en lblTotalBoleta
                    lblTotalBoleta.Text = $"Total sin IVA: {totalSinIva:C}{Environment.NewLine}" &
                      $"IVA (19%): {iva:C}{Environment.NewLine}" &
                      $"Total con IVA: {totalConIva:C}{Environment.NewLine}" &
                      $"{New String("-"c, 40)}"
                    ' Crear una línea divisoria con 40 guiones para separar secciones en la boleta
                    ' Se puede ajustar este número para variar la longitud de la línea según el diseño deseado


                    ' Hacer visible el panel de la boleta y cambiar el texto del botón a "Cerrar Boleta"
                    pnlBoleta.Visible = True
                    btnGenerarBoleta.Text = "Cerrar Boleta"

                Catch ex As Exception
                    MessageBox.Show("Error al generar la boleta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnEnviarBoleta_Click(sender As Object, e As EventArgs) Handles btnEnviarBoleta.Click

        Try
            ' Crear el contenido de la boleta usando información de los labels y controles dentro de gpBoleta
            Dim boletaContenido As New Text.StringBuilder()

            ' Añadir datos de la empresa y del cliente
            boletaContenido.AppendLine("Empresa: Gestión Mecánica")
            boletaContenido.AppendLine("RUT: 11111111-1")
            boletaContenido.AppendLine("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy"))
            boletaContenido.AppendLine("Dirección: Republica 100, Santiago")
            boletaContenido.AppendLine(New String("-"c, 40))
            boletaContenido.AppendLine("Información del Cliente:")
            boletaContenido.AppendLine("Nombre: " & lblRutCliente_nombre.Text)
            boletaContenido.AppendLine(New String("-"c, 40))

            ' Añadir información del producto
            boletaContenido.AppendLine(" ")
            boletaContenido.AppendLine(lblProducto.Text)
            boletaContenido.AppendLine(New String("-"c, 40))

            ' Añadir totales
            boletaContenido.AppendLine("Totales:")
            boletaContenido.AppendLine(lblTotalBoleta.Text)
            boletaContenido.AppendLine(New String("-"c, 40))




            Dim rutaArchivo As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "boleta.txt")

            ' Escribir el contenido de la boleta en el archivo de texto
            System.IO.File.WriteAllText(rutaArchivo, boletaContenido.ToString())

            ' Notificar al usuario sobre la ubicación del archivo guardado
            MessageBox.Show("La boleta ha sido guardada en un archivo de texto en Documentos.", "Boleta Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Abrir la ubicación del archivo para que el usuario pueda ver o imprimir el archivo
            Process.Start("explorer.exe", "/select," & rutaArchivo)



        Catch ex As Exception
            MessageBox.Show("Error al guardar la boleta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Bloqueo'

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar txtTotal como solo lectura al cargar el formulario
        txtTotal.ReadOnly = True
        txtId.ReadOnly = True
        txtMontoNeto.ReadOnly = True
        txtStock.ReadOnly = True

        cmbNombreRepuesto.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFiltroRepuesto.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFiltroCliente.DropDownStyle = ComboBoxStyle.DropDownList

        dgvResumenVentas.ReadOnly = True
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar el panel de registro de cliente al iniciar el formulario
        pnregistroCliente.Visible = False
    End Sub

    Private Sub btRegistrarCli_Click(sender As Object, e As EventArgs) Handles btRegistrarCli.Click
        ' Alternar la visibilidad del panel y llevarlo al frente si es visible
        pnregistroCliente.Visible = True
    End Sub

    Private Sub CargarDatosEnDataGridView()
        Dim connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT SiniestroID, Estado_Siniestro, Detalle, Fecha_Siniestro, RutCompania, Rut, Estado_seguro FROM siniestro"
                Dim command As New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Asigna la tabla como fuente de datos del DataGridView
                dataGridViewSiniestro.DataSource = table

                ' Ocultar la columna de SiniestroID
                If dataGridViewSiniestro.Columns("SiniestroID") IsNot Nothing Then
                    dataGridViewSiniestro.Columns("SiniestroID").Visible = False
                End If

                ' Llama a la función para asignar los iconos según el estado, si es necesario
                AsignarIconos()
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub AsignarIconos()
        ' Verifica si la columna "Icono" existe; si no, la crea
        If dataGridViewSiniestro.Columns("Icono") Is Nothing Then
            Dim iconColumn As New DataGridViewImageColumn()
            iconColumn.Name = "Icono"
            iconColumn.HeaderText = "Icono"
            dataGridViewSiniestro.Columns.Insert(0, iconColumn)
        End If

        ' Define la ruta donde están los iconos
        Dim imagePath As String = Path.Combine(Application.StartupPath, "images")

        ' Itera sobre cada fila y asigna el icono según el Estado_Siniestro
        For Each row As DataGridViewRow In dataGridViewSiniestro.Rows
            If row.Cells("Estado_Siniestro").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("Estado_Siniestro").Value.ToString()) Then
                Dim estadoSiniestro As String = row.Cells("Estado_Siniestro").Value.ToString().ToLower()
                Dim iconPath As String = Path.Combine(imagePath, $"{estadoSiniestro}.ico")

                If File.Exists(iconPath) Then
                    row.Cells("Icono").Value = New Bitmap(iconPath)
                End If
            End If
        Next
    End Sub

    Private Sub AplicarFiltro(filtro As String)
        ' Lógica para aplicar el filtro en el DataGridViewSiniestro
        ' Por ejemplo, puedes usar DataView para filtrar el DataTable
        Dim table As DataTable = CType(dataGridViewSiniestro.DataSource, DataTable)
        Dim view As New DataView(table)
        view.RowFilter = filtro
        dataGridViewSiniestro.DataSource = view

        ' Vuelve a asignar los iconos después de filtrar
        AsignarIconos()
    End Sub

    Private Sub dataGridViewSiniestro_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dataGridViewSiniestro.CellFormatting
        If dataGridViewSiniestro.Rows(e.RowIndex).Selected Then
            e.CellStyle.BackColor = Color.LightBlue  ' Color de fondo para la selección
            e.CellStyle.ForeColor = Color.Black      ' Color de texto para la selección
        End If
    End Sub

    Private Sub dataGridViewSiniestro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewSiniestro.CellClick
        ' Verifica que la fila seleccionada sea válida
        If e.RowIndex >= 0 Then
            ' Desmarca todas las filas antes de aplicar la nueva selección
            For Each row As DataGridViewRow In dataGridViewSiniestro.Rows
                row.Selected = False
            Next

            ' Selecciona solo la fila actual
            dataGridViewSiniestro.Rows(e.RowIndex).Selected = True

            ' Obtiene el valor de la columna "Detalle" y lo asigna al labelDetalleSin
            Dim detalle As String = dataGridViewSiniestro.Rows(e.RowIndex).Cells("Detalle").Value.ToString()
            labelDetalleSin.Text = detalle
        End If
    End Sub

    Private Sub dataGridViewSiniestro_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dataGridViewSiniestro.DataBindingComplete
        ' Llama a AsignarIconos() después de que los datos se hayan enlazado o filtrado
        AsignarIconos()
    End Sub

    Private Sub buttonVerDetallesSiniestro_Click(sender As Object, e As EventArgs) Handles buttonVerDetallesSiniestro.Click

        ' Verificar si hay una fila seleccionada en el DataGridView
        If dataGridViewSiniestro.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un siniestro para ver los detalles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener el Rut, Estado_Siniestro y RutCompania de la fila seleccionada
        Dim selectedRow As DataGridViewRow = dataGridViewSiniestro.SelectedRows(0)
        Dim rut As String = selectedRow.Cells("Rut").Value.ToString()
        Dim estadoSiniestro As String = selectedRow.Cells("Estado_Siniestro").Value.ToString().ToLower()
        Dim rutCompania As String = selectedRow.Cells("RutCompania").Value.ToString()

        ' Hacer visibles ambos paneles de detalles
        panelDetalleSinSelec.Visible = True
        panelDetalleSiniestro.Visible = True

        ' Mostrar el RutCompania en labelNomCompDetSin
        labelNomCompDetSin.Text = rutCompania

        ' Ruta de la imagen basada en el estado
        Dim iconPath As String = Path.Combine(Application.StartupPath, "images", $"{estadoSiniestro}.ico")

        ' Cargar la imagen en el PictureBox del panel si existe
        If File.Exists(iconPath) Then
            pictureBoxEstadSin.Image = Image.FromFile(iconPath)
            pictureBoxEstadSin.SizeMode = PictureBoxSizeMode.StretchImage ' Ajustar imagen al PictureBox
        Else
            MessageBox.Show("No se encontró el icono para el estado seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Cambiar el texto de labelEstadoSeguSis al valor de Estado_Siniestro
        labelEstadDetSin.Text = estadoSiniestro

        ' Realizar la consulta en la tabla clientes para obtener los datos asociados al Rut
        Dim connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"
        Using connection As New MySqlConnection(connectionString)
            Try
                ' Consultar la tabla clientes para obtener los datos del cliente
                Dim clienteQuery As String = "SELECT Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna FROM clientes WHERE Rut = @Rut"
                Dim clienteCommand As New MySqlCommand(clienteQuery, connection)
                clienteCommand.Parameters.AddWithValue("@Rut", rut)

                connection.Open()
                Dim clienteReader As MySqlDataReader = clienteCommand.ExecuteReader()

                If clienteReader.Read() Then
                    ' Rellenar los TextBox con los datos obtenidos de la consulta
                    textBoxNomDetSis.Text = clienteReader("Nombre").ToString()
                    textBoxApePatDetSis.Text = clienteReader("ApellidoP").ToString()
                    textBoxApeMatDetSis.Text = clienteReader("ApellidoM").ToString()
                    textBoxRutDetSis.Text = rut
                    textBoxDireDetSis.Text = clienteReader("Direccion").ToString()
                    textBoxTelDetSis.Text = clienteReader("Telefono").ToString()
                    textBoxComuDetSis.Text = clienteReader("Comuna").ToString()
                Else
                    MessageBox.Show("No se encontraron datos para el cliente con el Rut proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                clienteReader.Close()

                ' Consultar la tabla compañía para obtener la descripción de la compañía asociada
                Dim companiaQuery As String = "SELECT Descripcion FROM compania WHERE Rut = @RutCompania"
                Dim companiaCommand As New MySqlCommand(companiaQuery, connection)
                companiaCommand.Parameters.AddWithValue("@RutCompania", rutCompania)

                Dim companiaReader As MySqlDataReader = companiaCommand.ExecuteReader()
                If companiaReader.Read() Then
                    ' Mostrar la descripción de la compañía en nomCompSin
                    nomCompSin.Text = companiaReader("Descripcion").ToString()
                Else
                    MessageBox.Show("No se encontró la descripción de la compañía asociada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                companiaReader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al consultar los detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Ruta base para los iconos
    Private iconBasePath As String = Path.Combine(Application.StartupPath, "images")

    ' Función para actualizar el estado en la BD y cambiar la interfaz
    Private Sub CambiarEstadoSiniestro(nuevoEstado As String)
        ' Verificar si hay una fila seleccionada en el DataGridView
        If dataGridViewSiniestro.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un siniestro antes de cambiar el estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener el valor de Rut de la fila seleccionada para identificar el siniestro
        Dim selectedRow As DataGridViewRow = dataGridViewSiniestro.SelectedRows(0)
        Dim rut As String = selectedRow.Cells("Rut").Value.ToString()

        ' Ruta de la imagen del nuevo estado
        Dim iconPath As String = Path.Combine(iconBasePath, $"{nuevoEstado.ToLower()}.ico")

        ' Actualizar label y PictureBox
        labelEstadDetSin.Text = nuevoEstado
        If File.Exists(iconPath) Then
            pictureBoxEstadSin.Image = Image.FromFile(iconPath)
            pictureBoxEstadSin.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            MessageBox.Show("No se encontró el icono para el estado seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Actualizar en la base de datos usando Rut como criterio único
        Dim connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE siniestro SET Estado_Siniestro = @NuevoEstado WHERE Rut = @Rut"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@NuevoEstado", nuevoEstado)
            command.Parameters.AddWithValue("@Rut", rut)

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Estado del siniestro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se pudo actualizar el estado del siniestro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el estado del siniestro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Manejo de los botones para cambiar el estado

    Private Sub buttonPendiente_Click(sender As Object, e As EventArgs) Handles buttonPendiente.Click
        CambiarEstadoSiniestro("Pendiente")
    End Sub

    Private Sub buttonActivo_Click(sender As Object, e As EventArgs) Handles buttonActivo.Click
        CambiarEstadoSiniestro("Activo")
    End Sub

    Private Sub buttonFinalizado_Click(sender As Object, e As EventArgs) Handles buttonFinalizado.Click
        CambiarEstadoSiniestro("Finalizado")
    End Sub

    Private Sub buttonCerrarPanDetSin_Click(sender As Object, e As EventArgs) Handles buttonCerrarPanDetSin.Click
        ' Habilitar los botones nuevamente
        buttonAgregarSiniestro.Enabled = True
        buttonVerDetallesSiniestro.Enabled = True
        buttonEliminarSiniestro.Enabled = True

        ' Ocultar los paneles de detalles
        panelDetalleSinSelec.Visible = False
        panelDetalleSiniestro.Visible = False

        ' Actualizar el DataGridView
        CargarDatosEnDataGridView()
    End Sub

    Private Sub buttonAgregarSiniestro_Click(sender As Object, e As EventArgs) Handles buttonAgregarSiniestro.Click
        ' Mostrar una ventana emergente de confirmación
        Dim result As DialogResult = MessageBox.Show("Vas a agregar un nuevo siniestro, ¿quieres continuar?",
                                                 "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar la respuesta del usuario
        If result = DialogResult.Yes Then
            ' Mostrar el panelAgreSis
            panelAgreSis.Visible = True
            panelDetalleSiniestro.Visible = True

            ' Deshabilitar botones
            buttonAgregarSiniestro.Visible = False
            buttonVerDetallesSiniestro.Visible = False
            buttonEliminarSiniestro.Visible = False

        Else
            ' Si el usuario selecciona No, puedes ocultar el panel si es necesario
            panelAgreSis.Visible = False
            panelDetalleSiniestro.Visible = False

        End If
    End Sub

    Private Sub LlenarComboBoxRut()
        ' Conexión a la base de datos
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            Dim query As String = "SELECT Rut FROM clientes"
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Llenar el comboBox con cada Rut obtenido de la tabla clientes
                While reader.Read()
                    comboBoxRutAgrSin.Items.Add(reader("Rut").ToString())
                End While

            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los RUTs: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private mostrarMensajeSeleccionRut As Boolean = True

    Private Sub comboBoxRutAgrSin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxRutAgrSin.SelectedIndexChanged
        ' Solo mostrar el mensaje si se permite (controlado desde buttonAgrSinConf_Click)
        If comboBoxRutAgrSin.SelectedItem Is Nothing AndAlso mostrarMensajeSeleccionRut Then
            MessageBox.Show("Por favor, seleccione un RUT válido.")
            Return
        End If

        ' Si hay un RUT seleccionado, cargar los datos del cliente
        If comboBoxRutAgrSin.SelectedItem IsNot Nothing Then
            Dim selectedRut As String = comboBoxRutAgrSin.SelectedItem.ToString()
            CargarDatosCliente(selectedRut)
        End If
    End Sub



    Private Sub buttonAgrSinConf_Click(sender As Object, e As EventArgs) Handles buttonAgrSinConf.Click
        ' Desactivar la advertencia de selección de RUT durante esta operación
        mostrarMensajeSeleccionRut = False

        ' Verificar que todos los campos requeridos estén llenos
        If String.IsNullOrEmpty(textBoxDetallAgrSin.Text) Then
            MessageBox.Show("El campo 'Detalle' no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mostrarMensajeSeleccionRut = True ' Volver a activar el mensaje antes de salir
            Return
        End If

        ' Validar que cada ComboBox tenga elementos y una selección válida
        If comboBoxEstadSegAgrSin.Items.Count = 0 OrElse comboBoxEstadSegAgrSin.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un estado de seguro válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mostrarMensajeSeleccionRut = True
            Return
        End If

        If comboBoxCompaAgrSin.Items.Count = 0 OrElse comboBoxCompaAgrSin.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione una compañía válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mostrarMensajeSeleccionRut = True
            Return
        End If

        If comboBoxRutAgrSin.Items.Count = 0 OrElse comboBoxRutAgrSin.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un RUT válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mostrarMensajeSeleccionRut = True
            Return
        End If

        ' Proceder con la conexión a la base de datos y la inserción
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            Try
                connection.Open()
                Dim descripcionCompania As String = comboBoxCompaAgrSin.SelectedItem.ToString()

                ' Obtener RutCompania
                Using commandCompania As New MySqlCommand("SELECT Rut FROM compania WHERE Descripcion = @Descripcion", connection)
                    commandCompania.Parameters.AddWithValue("@Descripcion", descripcionCompania)
                    Dim rutCompania As String = commandCompania.ExecuteScalar()?.ToString()

                    If String.IsNullOrEmpty(rutCompania) Then
                        MessageBox.Show("Compañía seleccionada no encontrada en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrarMensajeSeleccionRut = True
                        Return
                    End If

                    ' Insertar siniestro con el Estado_Seguro de comboBoxEstadSegAgrSin
                    Using commandSiniestro As New MySqlCommand("INSERT INTO siniestro (Detalle, Estado_Siniestro, Estado_Seguro, Fecha_Siniestro, RutCompania, Rut) VALUES (@Detalle, @Estado_Siniestro, @Estado_Seguro, @Fecha_Siniestro, @RutCompania, @Rut)", connection)
                        commandSiniestro.Parameters.AddWithValue("@Detalle", textBoxDetallAgrSin.Text)
                        commandSiniestro.Parameters.AddWithValue("@Estado_Siniestro", "Pendiente")
                        commandSiniestro.Parameters.AddWithValue("@Estado_Seguro", comboBoxEstadSegAgrSin.SelectedItem.ToString()) ' Nuevo parámetro para Estado_Seguro
                        commandSiniestro.Parameters.AddWithValue("@Fecha_Siniestro", dateTimePickerFecSin.Value)
                        commandSiniestro.Parameters.AddWithValue("@RutCompania", rutCompania)
                        commandSiniestro.Parameters.AddWithValue("@Rut", comboBoxRutAgrSin.SelectedItem.ToString())

                        ' Ejecutar la inserción
                        Dim rowsAffected As Integer = commandSiniestro.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Siniestro agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Limpiar campos después de guardar
                            textBoxDetallAgrSin.Clear()
                            comboBoxEstadSegAgrSin.SelectedIndex = -1
                            comboBoxCompaAgrSin.SelectedIndex = -1
                            comboBoxRutAgrSin.SelectedIndex = -1
                            dateTimePickerFecSin.Value = DateTime.Now

                            ' Limpiar campos de información del cliente
                            textBoxNomAgrSin.Clear()
                            textBoxApePatAgrSin.Clear()
                            textBoxApeMatAgrSin.Clear()
                            textBoxTelAgrSin.Clear()

                            ' Ocultar el panel de agregar siniestro
                            panelAgreSis.Visible = False
                            panelDetalleSiniestro.Visible = False

                            buttonAgregarSiniestro.Visible = True
                            buttonVerDetallesSiniestro.Visible = True
                            buttonEliminarSiniestro.Visible = True

                            ' Actualizar el DataGridView después de guardar el siniestro
                            CargarDatosEnDataGridView()
                        Else
                            MessageBox.Show("No se pudo agregar el siniestro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al agregar el siniestro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' Reactivar la verificación de selección de RUT después de la operación
        mostrarMensajeSeleccionRut = True
    End Sub

    Private Sub buttonEliminarSiniestro_Click(sender As Object, e As EventArgs) Handles buttonEliminarSiniestro.Click
        ' Verificar que hay una fila seleccionada en el DataGridView
        If dataGridViewSiniestro.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un siniestro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirmación de eliminación
        Dim confirmResult As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el siniestro seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then
            Return
        End If

        ' Obtener el SiniestroID de la fila seleccionada
        Dim selectedRow As DataGridViewRow = dataGridViewSiniestro.SelectedRows(0)
        Dim siniestroID As Integer = Convert.ToInt32(selectedRow.Cells("SiniestroID").Value)

        ' Conexión a la base de datos para eliminar el registro
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            Dim query As String = "DELETE FROM siniestro WHERE SiniestroID = @SiniestroID"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@SiniestroID", siniestroID)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Siniestro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refrescar el DataGridView para mostrar los cambios
                        CargarDatosEnDataGridView()
                    Else
                        MessageBox.Show("No se pudo encontrar el siniestro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el siniestro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub CargarDatosCliente(rut As String)
        ' Conexión a la base de datos
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            Dim query As String = "SELECT Nombre, ApellidoP, ApellidoM, Telefono FROM clientes WHERE Rut = @Rut"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Rut", rut)

            Try
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Verificar si se encontró un resultado y llenar los TextBox
                    If reader.Read() Then
                        textBoxNomAgrSin.Text = If(reader("Nombre") IsNot DBNull.Value, reader("Nombre").ToString(), "")
                        textBoxApePatAgrSin.Text = If(reader("ApellidoP") IsNot DBNull.Value, reader("ApellidoP").ToString(), "")
                        textBoxApeMatAgrSin.Text = If(reader("ApellidoM") IsNot DBNull.Value, reader("ApellidoM").ToString(), "")
                        textBoxTelAgrSin.Text = If(reader("Telefono") IsNot DBNull.Value, reader("Telefono").ToString(), "")
                    Else
                        MessageBox.Show("No se encontraron datos para el RUT seleccionado.")
                        ' Limpiar los campos si no hay resultados
                        textBoxNomAgrSin.Clear()
                        textBoxApePatAgrSin.Clear()
                        textBoxApeMatAgrSin.Clear()
                        textBoxTelAgrSin.Clear()
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los datos del cliente: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LlenarComboBoxCompaAgrSin()
        ' Conexión a la base de datos
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            Dim query As String = "SELECT Descripcion FROM compania"
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Llenar el comboBox con cada Descripcion obtenido de la tabla compania
                While reader.Read()
                    comboBoxCompaAgrSin.Items.Add(reader("Descripcion").ToString())
                End While

            Catch ex As MySqlException
                MessageBox.Show("Error al cargar las descripciones de compañías: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub buttonCancelSin_Click(sender As Object, e As EventArgs) Handles buttonCancelSin.Click
        panelAgreSis.Visible = False
        panelDetalleSiniestro.Visible = False

        ' Habilitar los botones nuevamente
        buttonAgregarSiniestro.Visible = True
        buttonVerDetallesSiniestro.Visible = True
        buttonEliminarSiniestro.Visible = True

    End Sub

    Private Sub buttonVerCli_Click(sender As Object, e As EventArgs) Handles buttonVerCli.Click
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            Dim query As String = "SELECT Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna FROM clientes"
            Dim command As New MySqlCommand(query, connection)
            Dim clientesInfo As String = "Clientes:" & vbCrLf & vbCrLf

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Construir la cadena de texto para mostrar los datos de cada cliente de forma más ordenada
                While reader.Read()
                    clientesInfo &= "Rut: " & reader("Rut").ToString() & vbCrLf &
                                    "Nombre: " & reader("Nombre").ToString() & vbCrLf &
                                    "Apellido Paterno: " & reader("ApellidoP").ToString() & vbCrLf &
                                    "Apellido Materno: " & reader("ApellidoM").ToString() & vbCrLf &
                                    "Dirección: " & reader("Direccion").ToString() & vbCrLf &
                                    "Teléfono: " & reader("Telefono").ToString() & vbCrLf &
                                    "Comuna: " & reader("Comuna").ToString() & vbCrLf &
                                    "------------------------" & vbCrLf
                End While
                reader.Close()

                ' Mostrar todos los datos en un MessageBox
                MessageBox.Show(clientesInfo, "Datos de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As MySqlException
                MessageBox.Show("Error al consultar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub buttonAgreCli_Click(sender As Object, e As EventArgs) Handles buttonAgreCli.Click
        ' Verificar si todos los campos están completos
        If String.IsNullOrWhiteSpace(textBoxRutCli.Text) OrElse
           String.IsNullOrWhiteSpace(textBoxNomCli.Text) OrElse
           String.IsNullOrWhiteSpace(textBoxApePatCli.Text) OrElse
           String.IsNullOrWhiteSpace(textBoxApeMatCli.Text) OrElse
           String.IsNullOrWhiteSpace(textBoxDirecCli.Text) OrElse
           String.IsNullOrWhiteSpace(textBoxTelefCli.Text) OrElse
           String.IsNullOrWhiteSpace(textBoxComuCli.Text) Then

            MessageBox.Show("Todos los campos son obligatorios. Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Establecer la conexión a la base de datos MySQL
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            ' Consulta para verificar si el Rut ya existe en la base de datos
            Dim checkQuery As String = "SELECT COUNT(*) FROM clientes WHERE Rut = @Rut"
            Dim checkCommand As New MySqlCommand(checkQuery, connection)
            checkCommand.Parameters.AddWithValue("@Rut", textBoxRutCli.Text)

            Try
                ' Abrir la conexión y verificar si el Rut ya existe
                connection.Open()
                Dim rutExists As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                ' Si el Rut existe, mostrar advertencia y salir del procedimiento
                If rutExists > 0 Then
                    MessageBox.Show("El Rut ingresado ya existe en la base de datos. No se puede duplicar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Si el Rut no existe, preguntar si desea crear un nuevo usuario
                Dim result As DialogResult = MessageBox.Show("¿Deseas agregar un nuevo cliente con el Rut ingresado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' Si el usuario confirma, proceder con la inserción
                If result = DialogResult.Yes Then
                    ' Definir la consulta de inserción con parámetros
                    Dim insertQuery As String = "INSERT INTO clientes (Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna) " &
                                                "VALUES (@Rut, @Nombre, @ApellidoP, @ApellidoM, @Direccion, @Telefono, @Comuna)"
                    Dim insertCommand As New MySqlCommand(insertQuery, connection)

                    ' Asignar valores a los parámetros desde los TextBox
                    insertCommand.Parameters.AddWithValue("@Rut", textBoxRutCli.Text)
                    insertCommand.Parameters.AddWithValue("@Nombre", textBoxNomCli.Text)
                    insertCommand.Parameters.AddWithValue("@ApellidoP", textBoxApePatCli.Text)
                    insertCommand.Parameters.AddWithValue("@ApellidoM", textBoxApeMatCli.Text)
                    insertCommand.Parameters.AddWithValue("@Direccion", textBoxDirecCli.Text)
                    insertCommand.Parameters.AddWithValue("@Telefono", textBoxTelefCli.Text)
                    insertCommand.Parameters.AddWithValue("@Comuna", textBoxComuCli.Text)

                    ' Ejecutar el comando de inserción
                    Dim rowsAffected As Integer = insertCommand.ExecuteNonQuery()

                    ' Confirmar si se insertó el registro correctamente
                    If rowsAffected > 0 Then
                        MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LlenarComboBoxBuscCli()
                    Else
                        MessageBox.Show("No se pudo agregar el cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Catch ex As MySqlException
                MessageBox.Show("Error al agregar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub buttonLimpCli_Click(sender As Object, e As EventArgs) Handles buttonLimpCli.Click
        ' Limpiar todos los campos de texto relacionados con el cliente
        textBoxRutCli.Clear()
        textBoxNomCli.Clear()
        textBoxApePatCli.Clear()
        textBoxApeMatCli.Clear()
        textBoxDirecCli.Clear()
        textBoxTelefCli.Clear()
        textBoxComuCli.Clear()
    End Sub

    Private Sub comboBoxBuscCli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxBuscCli.SelectedIndexChanged
        ' Verificar que haya un Rut seleccionado
        If comboBoxBuscCli.SelectedItem Is Nothing Then
            Return
        End If

        ' Obtener el Rut seleccionado
        Dim selectedRut As String = comboBoxBuscCli.SelectedItem.ToString()

        ' Llenar el textBoxRutCli con el Rut seleccionado
        textBoxRutCli.Text = selectedRut

        ' Establecer la conexión a la base de datos MySQL
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            Dim query As String = "SELECT Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna FROM clientes WHERE Rut = @Rut"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Rut", selectedRut)

            Try
                ' Abrir la conexión y ejecutar la consulta
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Si se encontró el cliente, llenar los TextBox con sus datos
                If reader.Read() Then
                    textBoxNomCli.Text = reader("Nombre").ToString()
                    textBoxApePatCli.Text = reader("ApellidoP").ToString()
                    textBoxApeMatCli.Text = reader("ApellidoM").ToString()
                    textBoxDirecCli.Text = reader("Direccion").ToString()
                    textBoxTelefCli.Text = reader("Telefono").ToString()
                    textBoxComuCli.Text = reader("Comuna").ToString()
                Else
                    MessageBox.Show("No se encontraron datos para el Rut seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los datos del cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Variable de estado para controlar si estamos en modo de edición
    Private isEditing As Boolean = False

    Private Sub buttonEditCli_Click(sender As Object, e As EventArgs) Handles buttonEditCli.Click
        ' Verificar si estamos entrando o saliendo del modo de edición
        If Not isEditing Then
            ' Entrando en modo de edición
            ' Verificar si el Rut en textBoxRutCli existe en la base de datos
            Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
                Dim query As String = "SELECT COUNT(*) FROM clientes WHERE Rut = @Rut"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Rut", textBoxRutCli.Text)

                Try
                    connection.Open()
                    Dim rutExists As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If rutExists = 0 Then
                        MessageBox.Show("El Rut ingresado no existe. No se puede editar un cliente inexistente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Error al verificar el Rut: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End Using

            ' Confirmar si el usuario desea entrar en modo de edición
            Dim result As DialogResult = MessageBox.Show("¿Deseas editar el cliente con el Rut ingresado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If

            ' Bloquear los controles y habilitar el modo de edición
            buttonVerCli.Enabled = False
            buttonAgreCli.Enabled = False
            buttonElimCli.Enabled = False
            buttonLimpCli.Enabled = False
            comboBoxBuscCli.Enabled = False
            textBoxRutCli.Enabled = False

            isEditing = True
            buttonEditCli.Text = "Terminar Edición"
        Else
            ' Saliendo del modo de edición, guardando cambios
            ' Establecer la conexión y ejecutar la actualización
            Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
                Dim updateQuery As String = "UPDATE clientes SET Nombre = @Nombre, ApellidoP = @ApellidoP, ApellidoM = @ApellidoM, " &
                                        "Direccion = @Direccion, Telefono = @Telefono, Comuna = @Comuna WHERE Rut = @Rut"
                Dim updateCommand As New MySqlCommand(updateQuery, connection)

                ' Asignar valores a los parámetros desde los TextBox
                updateCommand.Parameters.AddWithValue("@Rut", textBoxRutCli.Text)
                updateCommand.Parameters.AddWithValue("@Nombre", textBoxNomCli.Text)
                updateCommand.Parameters.AddWithValue("@ApellidoP", textBoxApePatCli.Text)
                updateCommand.Parameters.AddWithValue("@ApellidoM", textBoxApeMatCli.Text)
                updateCommand.Parameters.AddWithValue("@Direccion", textBoxDirecCli.Text)
                updateCommand.Parameters.AddWithValue("@Telefono", textBoxTelefCli.Text)
                updateCommand.Parameters.AddWithValue("@Comuna", textBoxComuCli.Text)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()

                    ' Verificar si la actualización se realizó correctamente
                    If rowsAffected > 0 Then
                        MessageBox.Show("Cliente editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LlenarComboBoxBuscCli()
                    Else
                        MessageBox.Show("No se pudo editar el cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Error al editar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

            ' Desbloquear los controles y salir del modo de edición
            buttonVerCli.Enabled = True
            buttonAgreCli.Enabled = True
            buttonElimCli.Enabled = True
            buttonLimpCli.Enabled = True
            comboBoxBuscCli.Enabled = True
            textBoxRutCli.Enabled = True

            isEditing = False
            buttonEditCli.Text = "Editar Cliente"
        End If
    End Sub

    Private Sub buttonElimCli_Click(sender As Object, e As EventArgs) Handles buttonElimCli.Click
        ' Verificar si el Rut en textBoxRutCli está vacío
        If String.IsNullOrWhiteSpace(textBoxRutCli.Text) Then
            MessageBox.Show("Por favor, ingresa un Rut para eliminar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Establecer la conexión a la base de datos MySQL
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            ' Verificar si el Rut existe en la base de datos
            Dim checkQuery As String = "SELECT COUNT(*) FROM clientes WHERE Rut = @Rut"
            Dim checkCommand As New MySqlCommand(checkQuery, connection)
            checkCommand.Parameters.AddWithValue("@Rut", textBoxRutCli.Text)

            Try
                connection.Open()
                Dim rutExists As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If rutExists = 0 Then
                    MessageBox.Show("El Rut ingresado no existe en la base de datos. No se puede eliminar un cliente inexistente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Catch ex As MySqlException
                MessageBox.Show("Error al verificar el Rut: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            ' Confirmar si el usuario desea eliminar el cliente
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar el cliente con el Rut ingresado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If

            ' Eliminar el cliente
            Dim deleteQuery As String = "DELETE FROM clientes WHERE Rut = @Rut"
            Dim deleteCommand As New MySqlCommand(deleteQuery, connection)
            deleteCommand.Parameters.AddWithValue("@Rut", textBoxRutCli.Text)

            Try
                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()

                ' Verificar si la eliminación se realizó correctamente
                If rowsAffected > 0 Then
                    MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LlenarComboBoxBuscCli()

                    ' Limpiar los campos de texto después de la eliminación
                    textBoxRutCli.Clear()
                    textBoxNomCli.Clear()
                    textBoxApePatCli.Clear()
                    textBoxApeMatCli.Clear()
                    textBoxDirecCli.Clear()
                    textBoxTelefCli.Clear()
                    textBoxComuCli.Clear()
                Else
                    MessageBox.Show("No se pudo eliminar el cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As MySqlException
                MessageBox.Show("Error al eliminar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LlenarComboBoxBuscCli()
        ' Establecer la conexión a la base de datos MySQL
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            Dim query As String = "SELECT Rut FROM clientes"
            Dim command As New MySqlCommand(query, connection)

            Try
                ' Abrir la conexión y ejecutar la consulta
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Limpiar el comboBox antes de llenarlo para evitar duplicados
                comboBoxBuscCli.Items.Clear()

                ' Llenar el comboBox con cada Rut de la tabla clientes
                While reader.Read()
                    comboBoxBuscCli.Items.Add(reader("Rut").ToString())
                End While
                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los RUTs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private mostrandoTodos As Boolean = True ' Variable de estado para alternar entre los modos

    Private Sub buttonConsuRutSin_Click(sender As Object, e As EventArgs) Handles buttonConsuRutSin.Click
        If mostrandoTodos Then
            BuscarPorRut() ' Llamar a la función para buscar por RUT
            mostrandoTodos = False
            buttonConsuRutSin.Text = "Mostrar Todos" ' Cambiar texto del botón
        Else
            MostrarTodosLosDatos() ' Llamar a la función para mostrar todos los datos
            mostrandoTodos = True
            buttonConsuRutSin.Text = "Buscar por RUT" ' Cambiar texto del botón
        End If
    End Sub

    Private Sub BuscarPorRut()
        Dim rut As String = textBoxConsRutSin.Text.Trim()

        ' Verificar si el TextBox está vacío
        If String.IsNullOrEmpty(rut) Then
            MessageBox.Show("Por favor, ingresa un RUT para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Establecer la conexión a la base de datos
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            Dim query As String = "SELECT * FROM siniestro WHERE Rut = @Rut"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Rut", rut)

            Try
                ' Abrir la conexión y ejecutar la consulta
                connection.Open()
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                ' Llenar la tabla con los resultados
                adapter.Fill(table)

                ' Asignar los resultados al DataGridView
                dataGridViewSiniestro.DataSource = table

                ' Verificar si se encontraron resultados
                If table.Rows.Count = 0 Then
                    MessageBox.Show("No se encontraron registros para el RUT ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As MySqlException
                MessageBox.Show("Error al buscar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub MostrarTodosLosDatos()
        ' Establecer la conexión a la base de datos
        Using connection As New MySqlConnection("Server=localhost;Database=taller;Uid=root;Pwd=;")
            Dim query As String = "SELECT * FROM siniestro"
            Dim command As New MySqlCommand(query, connection)

            Try
                ' Abrir la conexión y ejecutar la consulta
                connection.Open()
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                ' Llenar la tabla con los resultados
                adapter.Fill(table)

                ' Asignar los resultados al DataGridView
                dataGridViewSiniestro.DataSource = table

                ' Limpiar el TextBox
                textBoxConsRutSin.Clear()

            Catch ex As MySqlException
                MessageBox.Show("Error al cargar todos los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


End Class