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
End Class
