Imports System.ComponentModel
Imports CPU_Scheduling___Multi_Level_Queue.MainForm
Imports System
Imports System.Configuration

Public Class MainForm

    Public queueCount As Integer
    Public currentPage As String
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
        labelTitle.Text = currentPage
        InitializeQueues()
        initialSetup(datagridInitial, datagridLog, btnAddProcess, labelAveTurn, labelAveWait)

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

    Private Sub btnAddProcess_Click(sender As Object, e As EventArgs) Handles btnAddProcess.Click
        datagridInitial.Rows.Add("P" & currentRowNumber.ToString("D2"), "", "")
        currentRowNumber += 1
    End Sub

    Private Sub btnRemoveLast_Click(sender As Object, e As EventArgs) Handles btnRemoveLast.Click
        If datagridInitial.Rows.Count <> 0 Then
            datagridInitial.Rows.RemoveAt(datagridInitial.Rows.Count - 1)
            currentRowNumber -= 1
        Else
            currentRowNumber = 1
            MsgBox("There are no more rows to remove!", vbExclamation, "Warning")
        End If
    End Sub

    Private Sub btnClearProcess_Click(sender As Object, e As EventArgs) Handles btnClearProcess.Click
        initialSetup(datagridInitial, datagridLog, btnAddProcess, labelAveTurn, labelAveWait)

    End Sub

    Private Sub btnStartSimulation_Click(sender As Object, e As EventArgs) Handles btnStartSimulation.Click
        If cellValidation() Then
            Exit Sub
        End If

        InitializeProcesses()

        btnFinishSimulation.Enabled = False
        btnAddProcess.Enabled = False
        btnRemoveLast.Enabled = False
        btnClearProcess.Enabled = False
        btnStartSimulation.Enabled = False

        If ProcessQueues(0.6) = True Then

            MsgBox("CPU SCHEDULE FINISHED!", vbInformation, "PROCESS FINISHED")

            datagridInitial.ClearSelection()
            datagridLog.ClearSelection()
            btnFinishSimulation.Enabled = True
            btnAddProcess.Enabled = True
            btnRemoveLast.Enabled = True
            btnClearProcess.Enabled = True
            btnStartSimulation.Enabled = True
        End If


    End Sub

    Private Sub btnFinishSimulation_Click(sender As Object, e As EventArgs) Handles btnFinishSimulation.Click
        If cellValidation() Then
            Exit Sub
        End If

        InitializeProcesses()
        ProcessQueues(0)
        MsgBox("CPU SCHEDULE FINISHED!", vbInformation, "PROCESS FINISHED")

        datagridInitial.ClearSelection()
        datagridLog.ClearSelection()
    End Sub



    Private Sub wait(ByVal seconds As Integer)
        For j As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Function ProcessQueues(waitTime As Integer) As Boolean
        If datagridInitial.Rows.Count < 1 Then
            MsgBox("NO DATA TO SIMULATE!", vbCritical, "PROCESS FINISHED")
            Exit Function
        End If

        Dim currentTime As Integer = 0
        Dim queueIndex As Integer = 0
        Dim totalWaitingTime As Integer = 0
        Dim totalTurnAroundTime As Integer = 0

        For Each queue In multiLevelQueues
            queue.Processes = queue.Processes.OrderBy(Function(p) p.ArrivalTime).ThenBy(Function(p) p.ProcessID).ToList()
        Next

        labelAveWait.Text = ""
        labelAveTurn.Text = ""
        Dim currentColumn As Integer = 0

        While Not AllQueuesEmpty()

            If currentTime = 0 Then
                Dim firstProcess = multiLevelQueues _
        .SelectMany(Function(queue) queue.Processes) _
        .OrderBy(Function(process) process.ArrivalTime) _
        .ThenBy(Function(process) process.ProcessID) _
        .FirstOrDefault()

                Dim queueWithProcess = multiLevelQueues.FirstOrDefault(Function(queue) queue.Processes.Contains(firstProcess))
                Dim algorithm As String = queueWithProcess.Algorithm

                Dim processId As String = firstProcess.ProcessID
                Dim burstTime As Integer
                Dim arrivalTime As Integer = Integer.Parse(firstProcess.ArrivalTime)

                Dim waitingTime As Integer
                Dim turnAroundTime As Integer
                Dim completionTime As Integer
                Dim timeQuantum As Integer

                If algorithm = "FIRST COME FIRST SERVE" Then
                    burstTime = firstProcess.BurstTime
                ElseIf algorithm = "ROUND ROBIN" Then
                    timeQuantum = Integer.Parse(queueWithProcess.TimeQuantum)

                    If firstProcess.BurstTime >= timeQuantum Then
                        burstTime = Integer.Parse(queueWithProcess.TimeQuantum)
                    Else
                        burstTime = firstProcess.BurstTime
                    End If
                End If

                completionTime = arrivalTime + burstTime
                turnAroundTime = completionTime - arrivalTime
                waitingTime = 0
                totalWaitingTime += waitingTime
                totalTurnAroundTime += turnAroundTime

                addLog(firstProcess.ProcessID, arrivalTime, burstTime, completionTime, turnAroundTime, waitingTime)

                wait(waitTime)

                multiLevelQueues.ForEach(Sub(queue) queue.Processes.RemoveAll(Function(process) process.ProcessID = firstProcess.ProcessID))

                If algorithm = "ROUND ROBIN" Then
                    Dim newBurstTime As Integer = firstProcess.BurstTime - timeQuantum

                    MsgBox("BURST: " + firstProcess.BurstTime.ToString + " TIME QUANTUM: " + timeQuantum.ToString)
                    If newBurstTime > 0 Then
                        Dim process As New Process(processId, Integer.Parse(timeQuantum).ToString, newBurstTime.ToString)
                        If currentPage.ToUpper = "MULTI LEVEL QUEUE" Then
                            multiLevelQueues(multiLevelQueues.IndexOf(queueWithProcess)).Processes.Add(process)
                        ElseIf currentPage.ToUpper = "MULTI LEVEL FEEDBACK QUEUE" Then
                            If multiLevelQueues.IndexOf(queueWithProcess) + 1 > (multiLevelQueues.Count - 1) Then
                                multiLevelQueues(multiLevelQueues.IndexOf(queueWithProcess)).Processes.Add(process)
                            Else
                                multiLevelQueues(multiLevelQueues.IndexOf(queueWithProcess) + 1).Processes.Add(process)
                            End If

                        End If
                    End If
                End If

                If multiLevelQueues(multiLevelQueues.IndexOf(queueWithProcess)).Processes.Count <= 0 Then
                    multiLevelQueues.RemoveAt(0)
                End If

                currentTime += burstTime
            End If

#Region "for debugging"
            'just for debugging and checking
            'For Each queue In multiLevelQueues
            '    MsgBox("Queue No: " & queue.QueueNo.ToString())
            '    For i As Integer = 0 To queue.Processes.Count - 1
            '        MsgBox("Process ID: " & queue.Processes(i).ProcessID.ToString())
            '    Next
            'Next
            'Dim totalProcesses As Integer = multiLevelQueues.Sum(Function(queue) queue.Processes.Count)
            'MsgBox(multiLevelQueues.Count.ToString + totalProcesses.ToString)


#End Region
            If multiLevelQueues(queueIndex).Processes.Count > 0 Then
                Dim currentProcess = multiLevelQueues(queueIndex).Processes(0)
                Dim waitingTime As Integer
                Dim turnAroundTime As Integer
                Dim completionTime As Integer
                Dim timeQuantum As Integer

                Dim processId As String = currentProcess.ProcessID
                Dim origBurstTime As Integer
                Dim arrivalTime As Integer = currentProcess.ArrivalTime

                If multiLevelQueues(queueIndex).Algorithm = "FIRST COME FIRST SERVE" Then
                    origBurstTime = currentProcess.BurstTime
                ElseIf multiLevelQueues(queueIndex).Algorithm = "ROUND ROBIN" Then
                    timeQuantum = multiLevelQueues(queueIndex).TimeQuantum

                    If currentProcess.BurstTime >= timeQuantum Then
                        origBurstTime = timeQuantum
                    Else
                        origBurstTime = currentProcess.BurstTime
                    End If
                End If

                completionTime = currentTime + origBurstTime
                turnAroundTime = completionTime - arrivalTime
                waitingTime = currentTime

                totalWaitingTime += waitingTime
                totalTurnAroundTime += turnAroundTime
                addLog(currentProcess.ProcessID, currentTime, origBurstTime, completionTime, turnAroundTime, waitingTime)
                wait(waitTime)

                multiLevelQueues.ForEach(Sub(queue) queue.Processes.RemoveAll(Function(process) process.ProcessID = processId))

                If multiLevelQueues(queueIndex).Algorithm = "ROUND ROBIN" Then
                    Dim newBurstTime As Integer = currentProcess.BurstTime - timeQuantum
                    If newBurstTime > 0 Then
                        Dim process As New Process(processId, newBurstTime, newBurstTime.ToString)
                        If currentPage.ToUpper = "MULTI LEVEL QUEUE" Then
                            multiLevelQueues(queueIndex).Processes.Add(process)
                        ElseIf currentPage.ToUpper = "MULTI LEVEL FEEDBACK QUEUE" Then
                            If queueIndex + 1 > (multiLevelQueues.Count - 1) Then
                                multiLevelQueues(queueIndex).Processes.Add(process)
                            Else
                                multiLevelQueues(queueIndex + 1).Processes.Add(process)
                            End If

                        End If
                        End If
                End If



                currentTime = completionTime
            Else
                queueIndex += 1
            End If


            If multiLevelQueues(queueIndex).Processes.Count <= 0 Then
                multiLevelQueues.RemoveAt(queueIndex)
            End If

            If queueIndex = multiLevelQueues.Count Then
                Exit While
            End If

        End While

        labelAveWait.Text = (Math.Round(totalWaitingTime / datagridLog.Rows.Count, 2)).ToString("N2") & " ms"
        labelAveTurn.Text = (Math.Round(totalTurnAroundTime / datagridLog.Rows.Count, 2)).ToString("N2") & " ms"


        Return AllQueuesEmpty() = True
    End Function


    Private Function AllQueuesEmpty() As Boolean
        For Each queue In multiLevelQueues
            If queue.Processes.Count > 0 Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub addLog(processId As String, arrivalTime As Integer, burstTime As Integer, completionTime As Integer, turnAroundTime As Integer, waitingTime As Integer)
        datagridLog.Rows.Add(processId, arrivalTime.ToString, burstTime.ToString, completionTime.ToString, turnAroundTime.ToString, waitingTime.ToString)
    End Sub

    Private Sub DisplayLog(processes As List(Of Process))
        For Each process In processes
            datagridLog.Rows.Add(process.ProcessID, process.ArrivalTime, process.BurstTime, process.CompletionTime, process.TurnaroundTime, process.WaitingTime)
        Next
    End Sub
    Private Sub initialSetup(datagridInitial As DataGridView, datagridDestination As DataGridView, btnAdd As Button, labelTurn As Label, labelWait As Label)
        currentRowNumber = 1

        datagridInitial.Rows.Clear()
        datagridDestination.Rows.Clear()

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
            If Not Integer.TryParse(value, number) Then
                e.Cancel = True
                MsgBox("Please enter a valid number.", vbCritical, "Warning")
                Exit Sub
            ElseIf e.ColumnIndex = 3 AndAlso (number > queueCount OrElse number <= 0) Then
                e.Cancel = True
                MsgBox("INVALID QUEUE NUMBER" & vbCrLf & "QUEUE RANGE: 1 TO " & queueCount, vbCritical, "Warning")
            End If
        End If

    End Sub

End Class
