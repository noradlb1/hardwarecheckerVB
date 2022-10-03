Imports System.Management

Namespace hardwarechecker.Core
	Public NotInheritable Class HardwareId

		Private Sub New()
		End Sub

		Public Shared Function GetHardwareId() As String
			Dim searcher As New ManagementObjectSearcher("Select ProcessorId From Win32_processor")
			Dim result As ManagementObjectCollection = searcher.Get()
			Dim id As String = ""
			For Each mo As ManagementObject In result
				id = mo("ProcessorId").ToString()
				Exit For
			Next mo
			Return id
		End Function
	End Class
End Namespace
