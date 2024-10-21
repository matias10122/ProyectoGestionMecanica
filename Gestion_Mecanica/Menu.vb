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
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se pudo actualizar el usuario. Verifique el RUT.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ButtonEliminarUsuario_Click(sender As Object, e As EventArgs) Handles ButtonEliminarUsuario.Click
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
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    End Sub
End Class