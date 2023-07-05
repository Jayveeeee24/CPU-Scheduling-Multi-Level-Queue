Public Class MainForm

    Public queueCount As Integer
    Public algorithm As String
    Dim currentRowNumber As Int32 = 1

    Public Property Queues As List(Of MainPopup.Queue)



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler datagridInitial.DataError, AddressOf datagridInitial_DataError

        labelTitle.Text = algorithm
        initialSetup(datagridInitial, datagridLog, btnAddProcess, labelAveTurn, labelAveWait)

    End Sub
    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    Private Sub datagridInitial_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles datagridInitial.DataError
        e.Cancel = True
    End Sub

#Region "ALL BUTTONS"
#Region "dating code for add process"
    'Private Sub btnAddProcess_Click(sender As Object, e As EventArgs) Handles btnAddProcess.Click
    '    datagridInitial.Rows.Add("P" & currentRowNumber.ToString("D2"), "", "")
    '    currentRowNumber += 1

    '    ' Clear existing items in the "algorithm" column
    '    Dim algorithmColumnIndex As Integer = datagridInitial.Columns("queueNo").Index
    '    For Each row As DataGridViewRow In datagridInitial.Rows
    '        If Not row.IsNewRow Then
    '            Dim algorithmCell As DataGridViewComboBoxCell = CType(row.Cells(algorithmColumnIndex), DataGridViewComboBoxCell)
    '            algorithmCell.Items.Clear()
    '        End If
    '    Next

    '    ' Add algorithm numbers to the "algorithm" column
    '    For Each row As DataGridViewRow In datagridInitial.Rows
    '        If Not row.IsNewRow Then
    '            Dim algorithmCell As DataGridViewComboBoxCell = CType(row.Cells(algorithmColumnIndex), DataGridViewComboBoxCell)
    '            For i As Integer = 1 To queueCount
    '                algorithmCell.Items.Add(i)
    '            Next
    '        End If
    '    Next
    'End Sub
#End Region

    Private Sub btnAddProcess_Click(sender As Object, e As EventArgs) Handles btnAddProcess.Click
        datagridInitial.Rows.Add("P" & currentRowNumber.ToString("D2"), "", "")
        currentRowNumber += 1

        ' Clear existing items in the "algorithm" column
        Dim algorithmColumnIndex As Integer = datagridInitial.Columns("queueNo").Index
        Dim lastRowIndex As Integer = datagridInitial.Rows.Count - 1

        For Each row As DataGridViewRow In datagridInitial.Rows
            If row.Index = lastRowIndex Then
                Dim algorithmCell As DataGridViewComboBoxCell = CType(row.Cells(algorithmColumnIndex), DataGridViewComboBoxCell)

                ' Clear the selected value
                algorithmCell.Value = Nothing

                ' Clear and add algorithm numbers to the "algorithm" column
                algorithmCell.Items.Clear()
                For i As Integer = 1 To queueCount
                    algorithmCell.Items.Add(i)
                Next

                ' Begin editing the cell and set the value
                datagridInitial.BeginEdit(True)
                algorithmCell.Value = algorithmCell.Items(0)
            End If
        Next
    End Sub


    Private Sub btnRemoveLast_Click(sender As Object, e As EventArgs) Handles btnRemoveLast.Click
        If (datagridInitial.Rows.Count <> 0) Then
            datagridInitial.Rows.RemoveAt(datagridInitial.Rows.Count - 1)
            currentRowNumber -= 1
        Else
            currentRowNumber = 1
            MsgBox("There is no more rows to remove!", vbExclamation, "Warning")
        End If
    End Sub
    Private Sub btnClearProcess_Click(sender As Object, e As EventArgs) Handles btnClearProcess.Click
        initialSetup(datagridInitial, datagridLog, btnAddProcess, labelAveTurn, labelAveWait)
        tableGanttChart.Controls.Clear()
        tableGanttChart.ColumnStyles.Clear()
        tableGanttChart.ColumnCount = 0
    End Sub
    Private Sub btnStartSimulation_Click(sender As Object, e As EventArgs) Handles btnStartSimulation.Click

    End Sub
    Private Sub btnFinishSimulation_Click(sender As Object, e As EventArgs) Handles btnFinishSimulation.Click

    End Sub



#Region "FUNCTION HELPERS"
    Private Sub wait(ByVal seconds As Integer)
        For j As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Sub initialSetup(datagridInitial As DataGridView, datagridDestination As DataGridView, btnAdd As Button, labelTurn As Label, labelWait As Label)
        currentRowNumber = 1

        datagridInitial.Rows.Clear()
        datagridDestination.Rows.Clear()
        tableGanttChart.Controls.Clear()
        tableGanttChart.ColumnStyles.Clear()
        tableGanttChart.ColumnCount = 0

        For i As Integer = 0 To 2
            btnAdd.PerformClick()
        Next

        labelTurn.Text = ""
        labelWait.Text = ""

    End Sub
    Private Sub DataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles datagridInitial.EditingControlShowing
        ' Check if the current column is the desired ComboBox column
        If datagridInitial.CurrentCell.ColumnIndex = 3 Then
            Dim comboBox As ComboBox = TryCast(e.Control, ComboBox)

            AddHandler comboBox.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged
        End If
    End Sub
    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)
        Dim selectedValue As String = comboBox.SelectedItem.ToString()

    End Sub
#End Region



#End Region
End Class
