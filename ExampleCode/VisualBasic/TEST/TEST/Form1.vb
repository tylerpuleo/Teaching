Imports System.Net
Imports System
Imports System.IO


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sURL As String
        sURL = "http://rsense-dev.cs.uml.edu/api/v1/projects/683"

        Dim wrGETURL As WebRequest
        wrGETURL = WebRequest.Create(sURL)

        Dim myProxy As New WebProxy("myproxy", 80)
        myProxy.BypassProxyOnLocal = True

        'wrGETURL.Proxy = myProxy
        wrGETURL.Proxy = WebProxy.GetDefaultProxy()

        Dim objStream As Stream
        objStream = wrGETURL.GetResponse.GetResponseStream()

        Dim objReader As New StreamReader(objStream)
        Dim sLine As String = ""
        Dim i As Integer = 0

        Do While Not sLine Is Nothing
            i += 1
            sLine = objReader.ReadLine
            If Not sLine Is Nothing Then
                Console.WriteLine("{0}:{1}", i, sLine)
            End If
        Loop

        Console.ReadLine()

    End Sub

End Class
