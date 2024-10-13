Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        ' Cadena de conexión a MySQL sin usuario ni contraseña
        Dim connectionString As String = "server=localhost;database=taller;uid=root;pwd=;"

        ' Abrir conexión a la base de datos
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                ' Consulta SQL para verificar si el correo y la contraseña coinciden con un usuario en la base de datos
                Dim query As String = "SELECT * FROM usuarios WHERE Correo = @correo AND Contraseña = @contrasena"
                Dim command As New MySqlCommand(query, connection)

                ' Pasar los valores ingresados en los textboxes como parámetros
                command.Parameters.AddWithValue("@correo", textboxUsuario.Text)
                command.Parameters.AddWithValue("@contrasena", textboxContrasena.Text)

                ' Ejecutar la consulta
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    MessageBox.Show("Ha iniciado sesión correctamente.")
                Else
                    MessageBox.Show("Usuario o contraseña no válidos.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error de conexión: " & ex.Message)
            End Try
        End Using
    End Sub




End Class