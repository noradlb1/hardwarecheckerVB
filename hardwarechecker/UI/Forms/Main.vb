Imports hardwarechecker.Core
Imports System
Imports System.Windows.Forms

Namespace hardwarechecker.UI.Forms
	Partial Public Class Main
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub buttonExitApplication_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonExitApplication.Click
			Close()
		End Sub

		Private Sub Main_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			textHardwareId.Text = HardwareId.GetHardwareId()
		End Sub

		Private Sub buttonCheckHardwareId_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCheckHardwareId.Click
			If AuthenticationManager.Authenticate(textServerUri.Text, textHardwareId.Text) Then
				MessageBox.Show("Successfully authenticated!", "hardwarechecker", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				MessageBox.Show("Failed to authenticate!", "hardwarechecker", MessageBoxButtons.OK, MessageBoxIcon.Error)

			End If
		End Sub
	End Class
End Namespace
