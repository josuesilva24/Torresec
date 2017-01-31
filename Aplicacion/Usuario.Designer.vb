<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCo = New System.Windows.Forms.TextBox()
        Me.txtAp = New System.Windows.Forms.TextBox()
        Me.txtNm = New System.Windows.Forms.TextBox()
        Me.txtU = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.limpiarButton = New System.Windows.Forms.Button()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.guardarButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdDpt = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmdDpt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCo)
        Me.GroupBox1.Controls.Add(Me.txtAp)
        Me.GroupBox1.Controls.Add(Me.txtNm)
        Me.GroupBox1.Controls.Add(Me.txtU)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 113)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'txtCo
        '
        Me.txtCo.Location = New System.Drawing.Point(73, 77)
        Me.txtCo.Name = "txtCo"
        Me.txtCo.Size = New System.Drawing.Size(161, 20)
        Me.txtCo.TabIndex = 8
        Me.txtCo.Tag = ""
        Me.txtCo.UseSystemPasswordChar = True
        '
        'txtAp
        '
        Me.txtAp.Location = New System.Drawing.Point(285, 51)
        Me.txtAp.Name = "txtAp"
        Me.txtAp.Size = New System.Drawing.Size(155, 20)
        Me.txtAp.TabIndex = 7
        '
        'txtNm
        '
        Me.txtNm.Location = New System.Drawing.Point(73, 51)
        Me.txtNm.Name = "txtNm"
        Me.txtNm.Size = New System.Drawing.Size(161, 20)
        Me.txtNm.TabIndex = 6
        '
        'txtU
        '
        Me.txtU.Location = New System.Drawing.Point(73, 24)
        Me.txtU.Name = "txtU"
        Me.txtU.Size = New System.Drawing.Size(161, 20)
        Me.txtU.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'limpiarButton
        '
        Me.limpiarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.limpiarButton.BackColor = System.Drawing.Color.White
        Me.limpiarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.limpiarButton.Image = CType(resources.GetObject("limpiarButton.Image"), System.Drawing.Image)
        Me.limpiarButton.Location = New System.Drawing.Point(454, 156)
        Me.limpiarButton.Name = "limpiarButton"
        Me.limpiarButton.Size = New System.Drawing.Size(72, 63)
        Me.limpiarButton.TabIndex = 413
        Me.limpiarButton.Text = "Limpiar"
        Me.limpiarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.limpiarButton.UseVisualStyleBackColor = False
        '
        'cancelarButton
        '
        Me.cancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelarButton.BackColor = System.Drawing.Color.White
        Me.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelarButton.Image = CType(resources.GetObject("cancelarButton.Image"), System.Drawing.Image)
        Me.cancelarButton.Location = New System.Drawing.Point(376, 156)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(72, 63)
        Me.cancelarButton.TabIndex = 411
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cancelarButton.UseVisualStyleBackColor = False
        '
        'guardarButton
        '
        Me.guardarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guardarButton.BackColor = System.Drawing.Color.White
        Me.guardarButton.Image = CType(resources.GetObject("guardarButton.Image"), System.Drawing.Image)
        Me.guardarButton.Location = New System.Drawing.Point(298, 156)
        Me.guardarButton.Name = "guardarButton"
        Me.guardarButton.Size = New System.Drawing.Size(72, 63)
        Me.guardarButton.TabIndex = 410
        Me.guardarButton.Text = "Guardar"
        Me.guardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.guardarButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Departamento"
        '
        'cmdDpt
        '
        Me.cmdDpt.FormattingEnabled = True
        Me.cmdDpt.Location = New System.Drawing.Point(347, 24)
        Me.cmdDpt.Name = "cmdDpt"
        Me.cmdDpt.Size = New System.Drawing.Size(93, 21)
        Me.cmdDpt.TabIndex = 10
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(538, 231)
        Me.Controls.Add(Me.limpiarButton)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.guardarButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UsuarioE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCo As System.Windows.Forms.TextBox
    Friend WithEvents txtAp As System.Windows.Forms.TextBox
    Friend WithEvents txtNm As System.Windows.Forms.TextBox
    Friend WithEvents txtU As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Private WithEvents limpiarButton As System.Windows.Forms.Button
    Private WithEvents cancelarButton As System.Windows.Forms.Button
    Private WithEvents guardarButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdDpt As System.Windows.Forms.ComboBox
End Class
