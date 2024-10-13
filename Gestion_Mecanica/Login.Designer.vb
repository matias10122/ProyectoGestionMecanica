<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        tituloLogin = New Label()
        PictureBox1 = New PictureBox()
        labelUsuario = New Label()
        textboxUsuario = New TextBox()
        labelContrasena = New Label()
        textboxContrasena = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        buttonLogin = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' tituloLogin
        ' 
        tituloLogin.AutoSize = True
        tituloLogin.BackColor = Color.Transparent
        tituloLogin.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tituloLogin.Location = New Point(65, 9)
        tituloLogin.Name = "tituloLogin"
        tituloLogin.Size = New Size(160, 65)
        tituloLogin.TabIndex = 0
        tituloLogin.Text = "Login"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.llaveIcon
        PictureBox1.Location = New Point(88, 77)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 94)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' labelUsuario
        ' 
        labelUsuario.AutoSize = True
        labelUsuario.BackColor = SystemColors.MenuHighlight
        labelUsuario.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelUsuario.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        labelUsuario.Location = New Point(0, 2)
        labelUsuario.Name = "labelUsuario"
        labelUsuario.Size = New Size(65, 21)
        labelUsuario.TabIndex = 2
        labelUsuario.Text = "Usuario"
        ' 
        ' textboxUsuario
        ' 
        textboxUsuario.Location = New Point(0, 36)
        textboxUsuario.Name = "textboxUsuario"
        textboxUsuario.Size = New Size(221, 23)
        textboxUsuario.TabIndex = 3
        ' 
        ' labelContrasena
        ' 
        labelContrasena.AutoSize = True
        labelContrasena.BackColor = SystemColors.Highlight
        labelContrasena.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelContrasena.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        labelContrasena.Location = New Point(1, 2)
        labelContrasena.Name = "labelContrasena"
        labelContrasena.Size = New Size(92, 21)
        labelContrasena.TabIndex = 4
        labelContrasena.Text = "Contraseña"
        ' 
        ' textboxContrasena
        ' 
        textboxContrasena.Location = New Point(1, 39)
        textboxContrasena.Name = "textboxContrasena"
        textboxContrasena.PasswordChar = "*"c
        textboxContrasena.Size = New Size(221, 23)
        textboxContrasena.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.fondomotor
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(12, 177)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(262, 186)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumSpringGreen
        Panel2.Controls.Add(textboxUsuario)
        Panel2.Controls.Add(labelUsuario)
        Panel2.Location = New Point(17, 20)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(222, 60)
        Panel2.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.MediumSpringGreen
        Panel3.Controls.Add(textboxContrasena)
        Panel3.Controls.Add(labelContrasena)
        Panel3.Location = New Point(16, 98)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(225, 64)
        Panel3.TabIndex = 7
        ' 
        ' buttonLogin
        ' 
        buttonLogin.Location = New Point(30, 379)
        buttonLogin.Name = "buttonLogin"
        buttonLogin.Size = New Size(233, 44)
        buttonLogin.TabIndex = 7
        buttonLogin.Text = "Login"
        buttonLogin.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondoLogin01
        ClientSize = New Size(286, 450)
        Controls.Add(buttonLogin)
        Controls.Add(PictureBox1)
        Controls.Add(tituloLogin)
        Controls.Add(Panel1)
        ForeColor = Color.DodgerBlue
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tituloLogin As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelUsuario As Label
    Friend WithEvents textboxUsuario As TextBox
    Friend WithEvents labelContrasena As Label
    Friend WithEvents textboxContrasena As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents buttonLogin As Button
End Class
