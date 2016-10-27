Public Class Form1
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("c:\users\hs131455\documents\visual studio 2013\Projects\WindowsApplication1\WindowsApplication1\Resources\My.Zelda.wav",
                AudioPlayMode.BackgroundLoop)
    End Sub
End Class
Public Class 