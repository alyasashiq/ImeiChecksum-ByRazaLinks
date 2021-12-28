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
        Me.ImeiWrBox = New System.Windows.Forms.TextBox()
        Me.ImeiRdBox = New System.Windows.Forms.TextBox()
        Me.ImeiCheckSumBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImeiWrBox
        '
        Me.ImeiWrBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.ImeiWrBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImeiWrBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ImeiWrBox.Location = New System.Drawing.Point(25, 123)
        Me.ImeiWrBox.MaxLength = 14
        Me.ImeiWrBox.Multiline = True
        Me.ImeiWrBox.Name = "ImeiWrBox"
        Me.ImeiWrBox.Size = New System.Drawing.Size(97, 20)
        Me.ImeiWrBox.TabIndex = 0
        '
        'ImeiRdBox
        '
        Me.ImeiRdBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.ImeiRdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImeiRdBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ImeiRdBox.Location = New System.Drawing.Point(30, 149)
        Me.ImeiRdBox.Name = "ImeiRdBox"
        Me.ImeiRdBox.Size = New System.Drawing.Size(103, 20)
        Me.ImeiRdBox.TabIndex = 1
        '
        'ImeiCheckSumBox
        '
        Me.ImeiCheckSumBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.ImeiCheckSumBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImeiCheckSumBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ImeiCheckSumBox.Location = New System.Drawing.Point(119, 123)
        Me.ImeiCheckSumBox.Name = "ImeiCheckSumBox"
        Me.ImeiCheckSumBox.Size = New System.Drawing.Size(18, 20)
        Me.ImeiCheckSumBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(38, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Imei CheckSum"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ImeiChecksum.My.Resources.Resources._6F
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 286)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.Location = New System.Drawing.Point(38, 181)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(83, 23)
        Me.btnCopy.TabIndex = 6
        Me.btnCopy.Text = "Copy Imei"
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(69, 266)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 28)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Gisha", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(29, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "MOBILE PHONE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Gautami", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(41, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Develop By:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Iskoola Pota", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label3.Location = New System.Drawing.Point(43, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Raza Links"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(162, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImeiCheckSumBox)
        Me.Controls.Add(Me.ImeiRdBox)
        Me.Controls.Add(Me.ImeiWrBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImeiWrBox As System.Windows.Forms.TextBox
    Friend WithEvents ImeiRdBox As System.Windows.Forms.TextBox
    Friend WithEvents ImeiCheckSumBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
