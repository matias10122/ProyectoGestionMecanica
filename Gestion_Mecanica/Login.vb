Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Dim connectionString As String = "server=localhost;user id=root;database=taller"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM usuarios WHERE Correo = @Correo AND Contraseña = @Contraseña"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Correo", textboxUsuario.Text)
            command.Parameters.AddWithValue("@Contraseña", textboxContrasena.Text)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Ha iniciado sesión correctamente")
                Dim menuForm As New Menu()
                Me.Hide() ' Cierra el formulario de login
                menuForm.ShowDialog() ' Abre el formulario de menú
                Me.Close()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos")
            End If

            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error de conexión: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub





End Class