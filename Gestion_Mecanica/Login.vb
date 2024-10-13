Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Dim connectionString As String = "server=localhost;database=taller;uid=root;pwd=;"
        Dim query As String = "SELECT Correo, Contraseña, Tipo FROM usuarios WHERE Correo=@correo AND Contraseña=@contraseña"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@correo", textboxUsuario.Text)
            command.Parameters.AddWithValue("@contraseña", textboxContrasena.Text)

            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim email As String = reader("Correo").ToString()
                Dim tipo As String = reader("Tipo").ToString()

                ' Mostrar mensaje de inicio de sesión exitoso
                MessageBox.Show("Ha iniciado sesión correctamente")

                ' Cierra el formulario de login
                Me.Hide()

                ' Abre el formulario Menu y pasa los datos
                Dim menuForm As New Menu(email, tipo)
                menuForm.Show()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos")
            End If
        End Using
    End Sub

End Class