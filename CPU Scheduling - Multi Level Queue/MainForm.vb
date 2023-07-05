Imports System.ComponentModel

Public Class MainForm

    Public queueCount As Integer
    Public multiLevel As String
    Dim currentRowNumber As Integer = 1
    Public multiLevelQueues As New List(Of Queue)

    Public Property Queues As List(Of MainPopup.Queue)

    Public Class Queue
        Public Property QueueNo As Integer
        Public Property Algorithm As String
        Public Property TimeQuantum As Integer
        Public Property Processes As List(Of Process)

        Public Sub New(queueNo As Integer, algorithm As String, timeQuantum As Integer)
            Me.QueueNo = queueNo
            Me.Algorithm = algorithm
            Me.TimeQuantum = timeQuantum
            Me.Processes = New List(Of Process)()
        End Sub
    End Class

    Public Class Process
        Public Property ProcessID As String
        Public Property ArrivalTime As Integer
        Public Property BurstTime As Integer
        Public Property CompletionTime As Integer
        Public Property TurnaroundTime As Integer
        Public Property WaitingTime As Integer

        Public Sub New(processID As String, arrivalTime As Integer, burstTime As Integer)
            Me.ProcessID = processID
            Me.ArrivalTime = arrivalTime
            Me.BurstTime = burstTime
        End Sub
    End Class


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelTitle.Text = multiLevel
        InitializeQueues()
        initialSetup(datagridInitial, datagridLog, btnAddProcess, labelAveTurn, labelAveWait)

        If multiLevelQueues.Count > 0 Then
            MsgBox("MULTILEVEL HAS ITEMS")
        End If

    End Sub
    Private Sub InitializeQueues()
        For Each queue In Queues
            multiLevelQueues.Add(New Queue(queue.QueueNo, queue.Algorithm, queue.TimeQuantum))
        Next
    End Sub
    Private Sub InitializeProcesses()
        For Each row As DataGridViewRow In datagridInitial.Rows
            Dim processID As String = row.Cells("processID").Value.ToString()
            Dim arrivalTime As Integer = Integer.Parse(row.Cells("arrivalTime").Value.ToString())
            Dim burstTime As Integer = Integer.Parse(row.Cells("burstTime").Value.ToString())

            Dim queueNo As Integer = Integer.Parse(row.Cells("queueNo").Value.ToString())
            Dim selectedQueue = multiLevelQueues.FirstOrDefault(Function(q) q.QueueNo = queueNo)
            If selectedQueue IsNot Nothing Then
                selectedQueue.Processes.Add(New Process(processID, arrivalTime, burstTime))
            End If
        Next
    End Sub
    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

#Region "ALL BUTTONS"

    Private Sub btnAddProcess_Click(sender As Object, e As EventArgs) Handles btnAddProcess.Click
        datagridInitial.Rows.Add("P" & currentRowNumber.ToString("D2"), "", "")
        currentRowNumber += 1

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
        If cellValidation() = True Then
            Exit Sub
        End If

        InitializeProcesses()

        datagridLog.Rows.Clear()
        ScheduleCPU(0.6)
        'If  = datagridInitial.Rows.Count - 1 Then
        '    MsgBox("CPU SCHEDULE FINISHED!", vbInformation, "PROCESS FINISHED")

        '    datagridInitial.ClearSelection()
        '    datagridLog.ClearSelection()

        '    Exit Sub
        'End If

    End Sub
    Private Sub btnFinishSimulation_Click(sender As Object, e As EventArgs) Handles btnFinishSimulation.Click
        If cellValidation() = True Then
            Exit Sub
        End If
        scheduleCPU(0)
        MsgBox("CPU SCHEDULE FINISHED!", vbInformation, "PROCESS FINISHED")

        datagridInitial.ClearSelection()
        datagridLog.ClearSelection()
    End Sub

#End Region


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

    Private Function cellValidation() As Boolean
        Dim allInitialValues(datagridInitial.RowCount, 3) As String

        'datagrid and cell validation
        For i As Integer = 0 To datagridInitial.RowCount - 1
            For j As Integer = 0 To datagridInitial.ColumnCount - 1
                allInitialValues(i, j) = datagridInitial.Rows(i).Cells.Item(j).FormattedValue
                If (datagridInitial.Rows(i).Cells.Item(j).FormattedValue Is Nothing Or datagridInitial.Rows(i).Cells.Item(j).FormattedValue = "" Or String.IsNullOrWhiteSpace(datagridInitial.Rows(i).Cells.Item(j).FormattedValue)) Then
                    MsgBox("Please provide complete values!", vbExclamation, "Null Data Input")
                    Return True
                End If
            Next

            For k As Integer = i + 1 To datagridInitial.RowCount - 1
                If (datagridInitial.Rows(i).Cells.Item(0).FormattedValue) = (datagridInitial.Rows(k).Cells.Item(0).FormattedValue) Then
                    MsgBox("Process ID should be unique in each row!", vbExclamation, "Duplicate Data")
                    Return True
                End If
            Next
        Next
        Return False
    End Function
    Private Sub datagridInitial_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles datagridInitial.CellValidating
        If (e.FormattedValue Is Nothing Or e.FormattedValue = "" Or String.IsNullOrWhiteSpace(e.FormattedValue)) Then
            MsgBox("Value cannot be null!", vbExclamation, "Null Data Input")
            e.Cancel = True
            Exit Sub
        End If

        Dim value As String = e.FormattedValue.ToString()
        Dim number As Integer
        If e.ColumnIndex >= 1 Then
            If Not Integer.TryParse(value, Number) Then
                e.Cancel = True
                MsgBox("Please enter a valid number.", vbCritical, "Warning")
                Exit Sub
            ElseIf e.ColumnIndex = 3 AndAlso (number > queueCount OrElse number <= 0) Then
                e.Cancel = True
                MsgBox("INVALID QUEUE NUMBER" & vbCrLf & "QUEUE RANGE: 1 TO " & queueCount, vbCritical, "Warning")
            End If
        End If

    End Sub


    Private Function ScheduleCPU(cpuUtilization As Double) As Integer
        Dim currentQueueIndex As Integer = 0
        Dim totalProcessCount As Integer = 0
        Dim totalProcessCompleted As Integer = 0

        ' Calculate the total process count across all queues
        For Each queue As Queue In multiLevelQueues
            totalProcessCount += queue.Processes.Count
        Next

        While totalProcessCompleted < totalProcessCount
            Dim currentQueue = multiLevelQueues(currentQueueIndex)

            Dim currentProcess As Process = Nothing

            If currentQueue.Processes.Count > 0 Then
                ' Get the next process based on the scheduling algorithm of the current queue
                If currentQueue.Algorithm = "FIRST COME FIRST SERVE" Then
                    currentProcess = currentQueue.Processes(0)
                    ' Remove the process from the front of the queue
                    currentQueue.Processes.RemoveAt(0)
                ElseIf currentQueue.Algorithm = "ROUND ROBIN" Then
                    ' Round-robin scheduling
                    currentProcess = currentQueue.Processes(0)
                    ' Remove the process from the front of the queue
                    currentQueue.Processes.RemoveAt(0)
                    ' Add the process back to the end of the queue if it still has remaining burst time
                    If currentProcess.BurstTime > currentQueue.TimeQuantum Then
                        currentProcess.BurstTime -= currentQueue.TimeQuantum
                        currentQueue.Processes.Add(currentProcess)

                        ' Add the preempted process to the log
                        Dim preemptedRow As String() = {currentProcess.ProcessID.ToString(), currentProcess.ArrivalTime.ToString(), currentProcess.BurstTime.ToString(), currentProcess.CompletionTime.ToString(), currentProcess.TurnaroundTime.ToString(), currentProcess.WaitingTime.ToString()}
                        datagridLog.Rows.Add(preemptedRow)
                    End If
                End If

                If currentProcess IsNot Nothing Then
                    totalProcessCompleted += 1

                    ' Update process properties
                    currentProcess.CompletionTime = currentProcess.ArrivalTime + currentProcess.BurstTime
                    currentProcess.TurnaroundTime = currentProcess.CompletionTime - currentProcess.ArrivalTime
                    currentProcess.WaitingTime = currentProcess.TurnaroundTime - currentProcess.BurstTime

                    ' Add the process to the log
                    Dim logRow As String() = {currentProcess.ProcessID.ToString(), currentProcess.ArrivalTime.ToString(), currentProcess.BurstTime.ToString(), currentProcess.CompletionTime.ToString(), currentProcess.TurnaroundTime.ToString(), currentProcess.WaitingTime.ToString()}
                    datagridLog.Rows.Add(logRow)
                End If
            End If

            ' Move to the next queue if the current queue is empty or all its processes are completed
            If currentQueue.Processes.Count = 0 OrElse (currentQueue.Processes.Count > 0 AndAlso currentQueue.Processes(0).BurstTime <= 0) Then
                currentQueueIndex += 1
            End If

            ' Wrap around to the first queue if we have reached the last queue
            If currentQueueIndex = multiLevelQueues.Count Then
                currentQueueIndex = 0
            End If
        End While

        Return totalProcessCompleted
    End Function





#End Region

End Class
