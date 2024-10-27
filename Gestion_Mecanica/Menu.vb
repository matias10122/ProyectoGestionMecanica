Imports MySql.Data.MySqlClient

Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar todos los paneles al inicio
        OcultarTodosLosPaneles()

        ' Mostrar solo el panelHome al inicio
        panelHome.Visible = True
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
                    TextBoxTipo.Text = reader("Tipo").ToString()

                    ButtonGuardarUsuario.Enabled = False
                    ButtonEditar.Enabled = True
                    ButtonEliminarUsuario.Enabled = True
                    MessageBox.Show("Usted ha consultado un usuario de la base de datos. Puede Editarlo o Eliminarlo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Usuario no encontrado
                    TextBoxCorreo.Clear()
                    TextBoxContraseña.Clear()
                    TextBoxTipo.Clear()

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
            command.Parameters.AddWithValue("@Tipo", TextBoxTipo.Text.Trim())

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
                        TextBoxTipo.Clear()
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
        If String.IsNullOrEmpty(TextBoxRutUsuario.Text.Trim()) Then
            MessageBox.Show("Debe ingresar un Rut y consultar antes de poder realizar cambios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "server=localhost;user id=root;password=;database=taller"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("INSERT INTO usuarios (Rut, Correo, Contraseña, Tipo) VALUES (@Rut, @Correo, @Contraseña, @Tipo)", connection)
            command.Parameters.AddWithValue("@Rut", TextBoxRutUsuario.Text.Trim())
            command.Parameters.AddWithValue("@Correo", TextBoxCorreo.Text.Trim())
            command.Parameters.AddWithValue("@Contraseña", TextBoxContraseña.Text.Trim())
            command.Parameters.AddWithValue("@Tipo", TextBoxTipo.Text.Trim())

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Se ha guardado correctamente el Usuario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Limpiar los campos después de guardar
                    TextBoxRutUsuario.Clear()
                    TextBoxCorreo.Clear()
                    TextBoxContraseña.Clear()
                    TextBoxTipo.Clear()
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
        TextBoxRepuestoNombre.Clear()
        TextBoxRepuestoDescripcion.Clear() ' Aquí también se puede cambiar el nombre del TextBox para reflejar que ahora es el Proveedor.
        TextBoxRepuestoPrecio.Clear()
        TextBoxRepuestoCantidad.Clear()
        TextBoxBuscarRepuestoID.Clear()
        TextBoxBuscarRepuestoNombre.Clear()
        ComboBoxRepuestos.SelectedIndex = -1 ' Limpiar el ComboBox
        ButtonEditarRepuesto.Enabled = False
        ButtonEliminarRepuesto.Enabled = False
    End Sub

    Private Function ExecuteReader(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As MySqlDataReader
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(query, connection)

        If parameters IsNot Nothing Then
            For Each param In parameters
                command.Parameters.AddWithValue(param.Key, param.Value)
            Next
        End If

        connection.Open()
        Return command.ExecuteReader(CommandBehavior.CloseConnection) ' Cierra la conexión cuando se cierra el lector
    End Function

    Private Function ExecuteNonQuery(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                connection.Open()
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Private Sub CargarRepuestosEnComboBox()
        ComboBoxRepuestos.Items.Clear()

        Dim query As String = "SELECT NombreRepuesto FROM repuestos"
        Using reader As MySqlDataReader = ExecuteReader(query)
            While reader.Read()
                ComboBoxRepuestos.Items.Add(reader("NombreRepuesto").ToString())
            End While
        End Using
    End Sub

    Private Sub ButtonGuardarRepuesto_Click(sender As Object, e As EventArgs) Handles ButtonGuardarRepuesto.Click
        ' Validar campos obligatorios
        If Not ValidarCamposObligatorios() Then Return

        ' Validar duplicados
        Dim checkQuery As String = "SELECT COUNT(*) FROM repuestos WHERE NombreRepuesto = @Nombre"
        Dim checkParams As New Dictionary(Of String, Object) From {
        {"@Nombre", TextBoxRepuestoNombre.Text.Trim()}
    }

        Dim count As Integer = Convert.ToInt32(ExecuteReader(checkQuery, checkParams).Read())
        If count > 0 Then
            MessageBox.Show("Este repuesto ya está registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insertar nuevo repuesto
        Dim insertQuery As String = "INSERT INTO repuestos (NombreRepuesto, Proveedor, PrecioUnitario, CantidadStock) VALUES (@Nombre, @Proveedor, @Precio, @Cantidad)"
        Dim insertParams As New Dictionary(Of String, Object) From {
        {"@Nombre", TextBoxRepuestoNombre.Text.Trim()},
        {"@Proveedor", TextBoxRepuestoDescripcion.Text.Trim()}, ' Cambiar aquí
        {"@Precio", Convert.ToDecimal(TextBoxRepuestoPrecio.Text.Trim())},
        {"@Cantidad", Convert.ToInt32(TextBoxRepuestoCantidad.Text.Trim())}
    }

        If ExecuteNonQuery(insertQuery, insertParams) > 0 Then
            MessageBox.Show("Repuesto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            CargarRepuestosEnComboBox()
        End If
    End Sub

    Private Function ValidarCamposObligatorios() As Boolean
        If String.IsNullOrWhiteSpace(TextBoxRepuestoNombre.Text) OrElse
       String.IsNullOrWhiteSpace(TextBoxRepuestoDescripcion.Text) OrElse
       String.IsNullOrWhiteSpace(TextBoxRepuestoPrecio.Text) OrElse
       String.IsNullOrWhiteSpace(TextBoxRepuestoCantidad.Text) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub ButtonConsultarRepuesto_Click(sender As Object, e As EventArgs) Handles ButtonConsultarRepuesto.Click
        Dim idRepuesto As String = TextBoxBuscarRepuestoID.Text.Trim()
        Dim nombreRepuesto As String = TextBoxBuscarRepuestoNombre.Text.Trim()

        If String.IsNullOrEmpty(idRepuesto) AndAlso String.IsNullOrEmpty(nombreRepuesto) Then
            MessageBox.Show("Por favor, ingrese un ID o nombre de repuesto para consultar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "SELECT RepuestoID, NombreRepuesto, Proveedor, PrecioUnitario, CantidadStock FROM repuestos WHERE RepuestoID = @ID OR NombreRepuesto = @Nombre"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@ID", If(String.IsNullOrEmpty(idRepuesto), DBNull.Value, idRepuesto)}, ' Usa DBNull si está vacío
        {"@Nombre", If(String.IsNullOrEmpty(nombreRepuesto), DBNull.Value, nombreRepuesto)} ' Usa DBNull si está vacío
    }

        Using reader As MySqlDataReader = ExecuteReader(query, parameters)
            If reader.Read() Then
                TextBoxRepuestoNombre.Text = reader("NombreRepuesto").ToString()
                TextBoxRepuestoDescripcion.Text = reader("Proveedor").ToString() ' Cambiar aquí
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

    Private Sub ButtonEditarRepuesto_Click(sender As Object, e As EventArgs) Handles ButtonEditarRepuesto.Click
        Dim idRepuesto As String = TextBoxBuscarRepuestoID.Text.Trim()
        If String.IsNullOrEmpty(idRepuesto) Then
            MessageBox.Show("Por favor, consulte un repuesto antes de editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "UPDATE repuestos SET NombreRepuesto = @Nombre, Proveedor = @Proveedor, PrecioUnitario = @Precio, CantidadStock = @Cantidad WHERE RepuestoID = @ID"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@ID", idRepuesto},
        {"@Nombre", TextBoxRepuestoNombre.Text.Trim()},
        {"@Proveedor", TextBoxRepuestoDescripcion.Text.Trim()}, ' Cambiar aquí
        {"@Precio", Convert.ToDecimal(TextBoxRepuestoPrecio.Text.Trim())},
        {"@Cantidad", Convert.ToInt32(TextBoxRepuestoCantidad.Text.Trim())}
    }

        If ExecuteNonQuery(query, parameters) > 0 Then
            MessageBox.Show("Repuesto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            CargarRepuestosEnComboBox()
        Else
            MessageBox.Show("No se pudo actualizar el repuesto. Verifique el ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonEliminarRepuesto_Click(sender As Object, e As EventArgs) Handles ButtonEliminarRepuesto.Click
        Dim idRepuesto As String = TextBoxBuscarRepuestoID.Text.Trim()
        If String.IsNullOrEmpty(idRepuesto) Then
            MessageBox.Show("Por favor, consulte un repuesto antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "DELETE FROM repuestos WHERE RepuestoID = @ID"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@ID", idRepuesto}
    }

        If ExecuteNonQuery(query, parameters) > 0 Then
            MessageBox.Show("Repuesto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            CargarRepuestosEnComboBox()
        Else
            MessageBox.Show("No se pudo eliminar el repuesto. Verifique el ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonLimpiarRepuesto_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarRepuesto.Click
        LimpiarCampos() ' Llama al método para limpiar los campos.
    End Sub

End Class


