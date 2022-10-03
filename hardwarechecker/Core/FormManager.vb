Imports hardwarechecker.UI.Forms
Imports System
Imports System.Windows.Forms

Namespace hardwarechecker.Core
	Public Class FormManager
		Inherits ApplicationContext

		Public CurrentForm As Form
		Public PreviousForm As Form

		Private FrmMain As Main

		Public Sub New()
			MyBase.New()
			InitializeForms()
			SetCurrentForm(FrmMain)
		End Sub

		Private Sub InitializeForms()
			FrmMain = New Main()
			AddHandler FrmMain.FormClosed, AddressOf OnFormClosed
		End Sub

		Private Sub SetCurrentForm(ByVal form As Form)
			If CurrentForm IsNot Nothing Then
				PreviousForm = CurrentForm

				If PreviousForm.Visible Then
					PreviousForm.Close()
				End If
			End If

			CurrentForm = form
			CurrentForm.Show()
		End Sub

		Private Sub OnFormClosed(ByVal sender As Object, ByVal e As EventArgs)
			If sender Is FrmMain Then
				MessageBox.Show("Please come again!", "hardwarechecker", MessageBoxButtons.OK, MessageBoxIcon.Information)
				ExitApplication()
			End If

			PreviousForm = DirectCast(sender, Form)
		End Sub

		Private Sub ExitApplication()
			If Application.MessageLoop Then
				Application.Exit()
			Else
				Environment.Exit(0)
			End If
		End Sub

		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			' unsubscribe from events
			RemoveHandler FrmMain.FormClosed, AddressOf OnFormClosed

			' dispose forms
			FrmMain.Dispose()

			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
