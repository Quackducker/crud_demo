<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.TextBoxNmae = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(114, 12)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(201, 56)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "Connect MySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'TextBoxNmae
        '
        Me.TextBoxNmae.Location = New System.Drawing.Point(114, 109)
        Me.TextBoxNmae.Name = "TextBoxNmae"
        Me.TextBoxNmae.Size = New System.Drawing.Size(349, 20)
        Me.TextBoxNmae.TabIndex = 1
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(114, 135)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(349, 20)
        Me.TextBoxAge.TabIndex = 2
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(114, 161)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(349, 20)
        Me.TextBoxEmail.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Email:"
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Location = New System.Drawing.Point(97, 222)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(217, 58)
        Me.ButtonInsert.TabIndex = 7
        Me.ButtonInsert.Text = "CREATE- (Insert data)"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.TextBoxNmae)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents TextBoxNmae As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonInsert As Button
End Class
