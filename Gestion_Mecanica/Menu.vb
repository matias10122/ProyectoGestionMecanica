Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar todos los paneles al inicio
        OcultarTodosLosPaneles()

        ' Mostrar solo el panelHome al inicio
        panelHome.Visible = True

        ' Guardar la imagen original para evitar transparencia al rotar
        If cajaImagenHome.Image IsNot Nothing Then
            originalImage = New Bitmap(cajaImagenHome.Image)
        End If

        ' Iniciar el Timer después de asignar la imagen original
        Timer1.Start()
    End Sub

    Private originalImage As Bitmap ' Imagen original para evitar transparencia
    Private angle As Integer = 0
    Private rotationSpeed As Double = 5 ' Velocidad extremadamente lenta
    Private rotationDirection As Integer = 1 ' 1 para derecha, -1 para izquierda
    Private rotationTimer As Integer = 0 ' Temporizador para controlar los 3 segundos de rotación
    Private isPaused As Boolean = False ' Indica si está en pausa
    Private pauseTimer As Integer = 0 ' Temporizador para la duración de la pausa

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Si está en pausa, solo incrementa el temporizador de pausa
        If isPaused Then
            pauseTimer += Timer1.Interval

            ' Si han pasado 2 segundos (2000 ms), termina la pausa
            If pauseTimer >= 2000 Then
                isPaused = False
                pauseTimer = 0
            End If
        Else
            ' Incrementa el ángulo en la dirección y velocidad actuales
            angle += rotationSpeed * rotationDirection
            If angle >= 360 OrElse angle <= -360 Then angle = 0

            ' Actualiza el temporizador de rotación
            rotationTimer += Timer1.Interval

            ' Cambia la dirección y velocidad cada 3 segundos (3000 ms) y activa la pausa
            If rotationTimer >= 3000 Then
                rotationDirection *= -1 ' Cambia la dirección
                isPaused = True ' Activa la pausa
                rotationTimer = 0 ' Reinicia el temporizador de rotación
            End If
        End If

        ' Llama al método para rotar la imagen, solo si no está en pausa
        If Not isPaused Then
            RotateImage()
        End If
    End Sub

    Private Sub RotateImage()
        If originalImage IsNot Nothing Then
            ' Crear un nuevo bitmap para la rotación basado en la imagen original
            Dim rotatedBmp As New Bitmap(originalImage.Width, originalImage.Height)

            Using g As Graphics = Graphics.FromImage(rotatedBmp)
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality

                ' Centro de la imagen para rotar
                g.TranslateTransform(rotatedBmp.Width / 2, rotatedBmp.Height / 2)
                g.RotateTransform(angle)
                g.TranslateTransform(-rotatedBmp.Width / 2, -rotatedBmp.Height / 2)
                g.DrawImage(originalImage, New Point(0, 0)) ' Usar siempre la imagen original
            End Using

            ' Liberar la imagen previa y asignar la rotada
            If cajaImagenHome.Image IsNot Nothing Then cajaImagenHome.Image.Dispose()
            cajaImagenHome.Image = rotatedBmp
        End If
    End Sub

    Private Sub OcultarTodosLosPaneles()
        ' Oculta todos los paneles
        panelHome.Visible = False
        panelRepuestos.Visible = False
        panelVentaRepuestos.Visible = False
        panelSiniestro.Visible = False
        panelSoliServicios.Visible = False
        panelGestionServicios.Visible = False
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

    ' Otras funciones del formulario Menu
End Class