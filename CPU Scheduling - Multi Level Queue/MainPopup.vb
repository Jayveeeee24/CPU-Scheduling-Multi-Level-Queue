Public Class MainPopup
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
        If txtQueueCount.Text.Trim = "" Then
            MsgBox("Please input a valid queue count!", vbCritical, "Warning")
            Exit Sub
        End If

        For i As Integer = 0 To Integer.Parse(txtQueueCount.Text) - 1
            datagridQueue.Rows.Add("Q" & (i + 1), "", "")
        Next
        AddHandler datagridQueue.EditingControlShowing, AddressOf DataGridView_EditingControlShowing

    End Sub

    Private Sub DataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        If TypeOf e.Control Is ComboBox Then
            Dim comboBox As ComboBox = DirectCast(e.Control, ComboBox)
            comboBox.SelectedIndex = 0

            AddHandler comboBox.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged
        End If
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)


        If comboBox.SelectedIndex = 0 Then

        Else

        End If

    End Sub

    Private Sub btnSaveQueue_Click(sender As Object, e As EventArgs) Handles btnSaveQueue.Click

    End Sub
End Class