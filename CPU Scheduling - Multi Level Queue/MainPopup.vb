﻿Public Class MainPopup


    Public Class Queue
        Public Property QueueNo As String
        Public Property Algorithm As String
        Public Property TimeQuantum As Integer
    End Class
    Dim queues As New List(Of MainPopup.Queue)()


    Private Sub MainPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comboChooseMultiLevel.SelectedIndex = 0
    End Sub

    Private Sub txtQueueCount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQueueCount.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub btnAddQueue_Click(sender As Object, e As EventArgs) Handles btnAddQueue.Click
        datagridQueue.Rows.clear
        If txtQueueCount.Text.Trim = "" Then
            MsgBox("Please input a valid queue count!", vbCritical, "Warning")
            Exit Sub
        End If

        If Integer.Parse(txtQueueCount.Text) > 5 Then
            MsgBox("MAX QUEUE COUNT IS 5!", vbCritical, "Warning")
            Exit Sub
        End If

        For i As Integer = 0 To Integer.Parse(txtQueueCount.Text) - 1
            datagridQueue.Rows.Add((i + 1), "", "")
        Next
        txtQueueCount.Text = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        datagridQueue.Rows.Clear()
    End Sub

    Private Sub DataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles datagridQueue.EditingControlShowing
        If TypeOf e.Control Is ComboBox Then
            Dim comboBox As ComboBox = DirectCast(e.Control, ComboBox)
            AddHandler comboBox.SelectedIndexChanged, AddressOf AlgorithmComboBox_SelectedIndexChanged

        End If
    End Sub
    Private Sub datagridQueue_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles datagridQueue.EditingControlShowing
        If datagridQueue.CurrentCell.ColumnIndex = datagridQueue.Columns("timeQuantum").Index Then
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                AddHandler textBox.KeyPress, AddressOf TimeQuantumTextBox_KeyPress
            End If
        End If
    End Sub

    Private Sub TimeQuantumTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub AlgorithmComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)
        Dim currentCell As DataGridViewCell = datagridQueue.CurrentCell

        If currentCell.ColumnIndex = 1 Then ' Assuming "algorithm" column index is 0
            Dim timeQuantumColumnIndex As Integer = currentCell.ColumnIndex + 1 ' Assuming "timeQuantum" column is next to "algorithm" column

            If comboBox.SelectedIndex = 0 Then ' Assuming the first index needs to be disabled
                datagridQueue.Rows(currentCell.RowIndex).Cells(timeQuantumColumnIndex).ReadOnly = True
                datagridQueue.Rows(currentCell.RowIndex).Cells(timeQuantumColumnIndex).Style.BackColor = Color.LightGray
            Else
                datagridQueue.Rows(currentCell.RowIndex).Cells(timeQuantumColumnIndex).ReadOnly = False
                datagridQueue.Rows(currentCell.RowIndex).Cells(timeQuantumColumnIndex).Style.BackColor = Color.White
            End If
        End If
    End Sub


    Private Sub btnSaveQueue_Click(sender As Object, e As EventArgs) Handles btnSaveQueue.Click
        For Each row As DataGridViewRow In datagridQueue.Rows
            Dim queueNoCell As DataGridViewCell = row.Cells("queueNo")
            Dim algorithmCell As DataGridViewComboBoxCell = TryCast(row.Cells("algorithm"), DataGridViewComboBoxCell)
            Dim timeQuantumCell As DataGridViewCell = row.Cells("timeQuantum")

            If algorithmCell IsNot Nothing AndAlso algorithmCell.Value IsNot Nothing AndAlso algorithmCell.Value.ToString = "ROUND ROBIN" AndAlso
               (timeQuantumCell.Value Is Nothing OrElse String.IsNullOrEmpty(timeQuantumCell.Value.ToString())) Then
                MessageBox.Show("Please enter a value for the time quantum.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If algorithmCell.Value.ToString = "" Then
                MessageBox.Show("Please select a value for the algorithm.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim queue As New Queue()
            queue.QueueNo = queueNoCell.Value.ToString()
            queue.Algorithm = algorithmCell.Value.ToString()
            queue.TimeQuantum = 0
            If algorithmCell.Value.ToString = "ROUND ROBIN" Then
                queue.TimeQuantum = Integer.Parse(timeQuantumCell.Value.ToString())
            End If

            queues.Add(queue)
        Next

        MainForm.currentPage = comboChooseMultiLevel.Text
        MainForm.queueCount = queues.Count
        MainForm.Queues = queues
        Me.Hide()
        MainForm.Show()
    End Sub

End Class