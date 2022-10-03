Imports System
Imports System.IO
Imports System.Net

Namespace hardwarechecker.Core
	Public NotInheritable Class AuthenticationManager

		Private Sub New()
		End Sub
		Private Shared Cookies As CookieContainer

		Shared Sub New()
			Cookies = New CookieContainer()
		End Sub

		Public Shared Function Authenticate(ByVal serverUri As String, ByVal hwid As String) As Boolean
			Dim uri As String = String.Format("{0}?hwid={1}", serverUri, hwid)
			Dim result As Boolean = False

			Dim request As HttpWebRequest = CType(WebRequest.Create(uri), HttpWebRequest)
			Dim response As HttpWebResponse = Nothing

			request.CookieContainer = Cookies

			Try
				response = CType(request.GetResponse(), HttpWebResponse)
			Catch wex As WebException
				response = CType(wex.Response, HttpWebResponse)
			Catch ex As Exception
				Return False ' probably no internet connection
			End Try

			If response IsNot Nothing Then
				If response.StatusCode = HttpStatusCode.OK Then
					Using nwStream As Stream = response.GetResponseStream()
						If nwStream.ReadByte() > 0 Then
							result = True
						End If
					End Using
				End If

				response.Close()
			End If

			Return result
		End Function
	End Class
End Namespace
