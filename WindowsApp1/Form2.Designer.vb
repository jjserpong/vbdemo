<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtID = New System.Windows.Forms.TextBox()
		Me.TxtName = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.DtpLahir = New System.Windows.Forms.DateTimePicker()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(18, 12)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(22, 18)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "ID"
		'
		'TxtID
		'
		Me.TxtID.Location = New System.Drawing.Point(92, 9)
		Me.TxtID.Name = "TxtID"
		Me.TxtID.Size = New System.Drawing.Size(200, 24)
		Me.TxtID.TabIndex = 1
		'
		'TxtName
		'
		Me.TxtName.Location = New System.Drawing.Point(92, 39)
		Me.TxtName.Name = "TxtName"
		Me.TxtName.Size = New System.Drawing.Size(200, 24)
		Me.TxtName.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(18, 42)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(48, 18)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Nama"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(18, 72)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(40, 18)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Lahir"
		'
		'DtpLahir
		'
		Me.DtpLahir.Location = New System.Drawing.Point(92, 67)
		Me.DtpLahir.Name = "DtpLahir"
		Me.DtpLahir.Size = New System.Drawing.Size(200, 24)
		Me.DtpLahir.TabIndex = 5
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(21, 130)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 39)
		Me.Button1.TabIndex = 6
		Me.Button1.Text = "Tambah"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(102, 130)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 39)
		Me.Button2.TabIndex = 7
		Me.Button2.Text = "Ubah"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(183, 130)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 39)
		Me.Button3.TabIndex = 8
		Me.Button3.Text = "Hapus"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(311, 188)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.DtpLahir)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TxtName)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TxtID)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form2"
		Me.Text = "Form2"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpLahir As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
