Namespace hardwarechecker.UI.Forms
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.groupCheckHardwareId = New System.Windows.Forms.GroupBox()
			Me.buttonCheckHardwareId = New System.Windows.Forms.Button()
			Me.labelServerUri = New System.Windows.Forms.Label()
			Me.textServerUri = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.textHardwareId = New System.Windows.Forms.TextBox()
			Me.buttonExitApplication = New System.Windows.Forms.Button()
			Me.groupCheckHardwareId.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupCheckHardwareId
			' 
			Me.groupCheckHardwareId.Controls.Add(Me.textHardwareId)
			Me.groupCheckHardwareId.Controls.Add(Me.label1)
			Me.groupCheckHardwareId.Controls.Add(Me.textServerUri)
			Me.groupCheckHardwareId.Controls.Add(Me.labelServerUri)
			Me.groupCheckHardwareId.Controls.Add(Me.buttonExitApplication)
			Me.groupCheckHardwareId.Controls.Add(Me.buttonCheckHardwareId)
			Me.groupCheckHardwareId.Location = New System.Drawing.Point(24, 29)
			Me.groupCheckHardwareId.Name = "groupCheckHardwareId"
			Me.groupCheckHardwareId.Size = New System.Drawing.Size(315, 169)
			Me.groupCheckHardwareId.TabIndex = 0
			Me.groupCheckHardwareId.TabStop = False
			Me.groupCheckHardwareId.Text = "Check your hardware id"
			' 
			' buttonCheckHardwareId
			' 
			Me.buttonCheckHardwareId.Location = New System.Drawing.Point(209, 127)
			Me.buttonCheckHardwareId.Name = "buttonCheckHardwareId"
			Me.buttonCheckHardwareId.Size = New System.Drawing.Size(62, 23)
			Me.buttonCheckHardwareId.TabIndex = 0
			Me.buttonCheckHardwareId.Text = "Check"
			Me.buttonCheckHardwareId.UseVisualStyleBackColor = True
'			Me.buttonCheckHardwareId.Click += New System.EventHandler(Me.buttonCheckHardwareId_Click)
			' 
			' labelServerUri
			' 
			Me.labelServerUri.AutoSize = True
			Me.labelServerUri.Location = New System.Drawing.Point(222, 43)
			Me.labelServerUri.Name = "labelServerUri"
			Me.labelServerUri.Size = New System.Drawing.Size(54, 13)
			Me.labelServerUri.TabIndex = 1
			Me.labelServerUri.Text = "Server Uri"
			' 
			' textServerUri
			' 
			Me.textServerUri.AcceptsReturn = True
			Me.textServerUri.AcceptsTab = True
			Me.textServerUri.Location = New System.Drawing.Point(39, 40)
			Me.textServerUri.Name = "textServerUri"
			Me.textServerUri.Size = New System.Drawing.Size(165, 20)
			Me.textServerUri.TabIndex = 2
			Me.textServerUri.Text = "http://localhost/hwid.php"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(219, 79)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(65, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Hardware Id"
			' 
			' textHardwareId
			' 
			Me.textHardwareId.AcceptsReturn = True
			Me.textHardwareId.AcceptsTab = True
			Me.textHardwareId.Location = New System.Drawing.Point(39, 76)
			Me.textHardwareId.Name = "textHardwareId"
			Me.textHardwareId.Size = New System.Drawing.Size(165, 20)
			Me.textHardwareId.TabIndex = 2
			' 
			' buttonExitApplication
			' 
			Me.buttonExitApplication.Location = New System.Drawing.Point(141, 127)
			Me.buttonExitApplication.Name = "buttonExitApplication"
			Me.buttonExitApplication.Size = New System.Drawing.Size(62, 23)
			Me.buttonExitApplication.TabIndex = 0
			Me.buttonExitApplication.Text = "Exit"
			Me.buttonExitApplication.UseVisualStyleBackColor = True
'			Me.buttonExitApplication.Click += New System.EventHandler(Me.buttonExitApplication_Click)
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(369, 233)
			Me.Controls.Add(Me.groupCheckHardwareId)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.Name = "Main"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "hardwarechecker by gigajew"
'			Me.Load += New System.EventHandler(Me.Main_Load)
			Me.groupCheckHardwareId.ResumeLayout(False)
			Me.groupCheckHardwareId.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupCheckHardwareId As System.Windows.Forms.GroupBox
		Private textHardwareId As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private textServerUri As System.Windows.Forms.TextBox
		Private labelServerUri As System.Windows.Forms.Label
		Private WithEvents buttonExitApplication As System.Windows.Forms.Button
		Private WithEvents buttonCheckHardwareId As System.Windows.Forms.Button
	End Class
End Namespace