Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wsh
        wsh = CreateObject("WScript.Shell")
        wsh.run("C:\Users\tylerpuleo\Documents\VBSCRIPT\VbsJson.vbs", 1, 0)
    End Sub
End Class
