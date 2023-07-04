Public Class MainForm

    Public queueCount As Integer
    Public algorithm As String

    Public Property Queues As List(Of MainPopup.Queue)


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        labelTitle.Text = algorithm
    End Sub
    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

#Region "ALL BUTTONS"
    Private Sub btnAddProcess_Click(sender As Object, e As EventArgs) Handles btnAddProcess.Click

    End Sub
    Private Sub btnRemoveLast_Click(sender As Object, e As EventArgs) Handles btnRemoveLast.Click

    End Sub
    Private Sub btnClearProcess_Click(sender As Object, e As EventArgs) Handles btnClearProcess.Click

    End Sub
    Private Sub btnStartSimulation_Click(sender As Object, e As EventArgs) Handles btnStartSimulation.Click

    End Sub
    Private Sub btnFinishSimulation_Click(sender As Object, e As EventArgs) Handles btnFinishSimulation.Click

    End Sub


#End Region
End Class
