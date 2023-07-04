Public Class MainForm

    Public queueCount As Integer
    Public algorithm As String

    Public Property Queues As List(Of MainPopup.Queue)


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPopup.ShowDialog()

    End Sub

End Class
