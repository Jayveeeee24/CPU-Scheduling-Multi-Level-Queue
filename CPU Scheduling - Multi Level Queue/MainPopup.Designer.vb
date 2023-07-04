<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPopup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPopup))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.comboChooseMultiLevel = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.labelBldgNo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtQueueCount = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAddQueue = New System.Windows.Forms.Button()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveQueue = New System.Windows.Forms.Button()
        Me.datagridQueue = New System.Windows.Forms.DataGridView()
        Me.queueNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.algorrithm = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.timeQuantum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.datagridQueue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.24094!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.75906!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(972, 509)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.labelTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 117)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 51)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(970, 66)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.comboChooseMultiLevel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel2.Size = New System.Drawing.Size(477, 58)
        Me.Panel2.TabIndex = 0
        '
        'comboChooseMultiLevel
        '
        Me.comboChooseMultiLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboChooseMultiLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboChooseMultiLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.comboChooseMultiLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboChooseMultiLevel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comboChooseMultiLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboChooseMultiLevel.FormattingEnabled = True
        Me.comboChooseMultiLevel.Items.AddRange(New Object() {"Multi Level Queue", "Multi Level Feedback Queue"})
        Me.comboChooseMultiLevel.Location = New System.Drawing.Point(15, 15)
        Me.comboChooseMultiLevel.Name = "comboChooseMultiLevel"
        Me.comboChooseMultiLevel.Size = New System.Drawing.Size(447, 28)
        Me.comboChooseMultiLevel.TabIndex = 4
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.labelBldgNo, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel4, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(485, 1)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(484, 64)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'labelBldgNo
        '
        Me.labelBldgNo.AutoSize = True
        Me.labelBldgNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelBldgNo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBldgNo.Location = New System.Drawing.Point(3, 0)
        Me.labelBldgNo.Name = "labelBldgNo"
        Me.labelBldgNo.Size = New System.Drawing.Size(90, 64)
        Me.labelBldgNo.TabIndex = 103
        Me.labelBldgNo.Text = "QUEUE COUNT:"
        Me.labelBldgNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtQueueCount)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(96, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 18, 10, 18)
        Me.Panel3.Size = New System.Drawing.Size(290, 64)
        Me.Panel3.TabIndex = 0
        '
        'txtQueueCount
        '
        Me.txtQueueCount.BackColor = System.Drawing.Color.White
        Me.txtQueueCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQueueCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQueueCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQueueCount.ForeColor = System.Drawing.Color.Black
        Me.txtQueueCount.Location = New System.Drawing.Point(10, 18)
        Me.txtQueueCount.MaxLength = 100
        Me.txtQueueCount.Multiline = True
        Me.txtQueueCount.Name = "txtQueueCount"
        Me.txtQueueCount.Size = New System.Drawing.Size(270, 28)
        Me.txtQueueCount.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnAddQueue)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(386, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5, 12, 5, 12)
        Me.Panel4.Size = New System.Drawing.Size(48, 64)
        Me.Panel4.TabIndex = 104
        '
        'btnAddQueue
        '
        Me.btnAddQueue.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAddQueue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddQueue.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddQueue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAddQueue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAddQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddQueue.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddQueue.ForeColor = System.Drawing.Color.White
        Me.btnAddQueue.Image = Global.CPU_Scheduling___Multi_Level_Queue.My.Resources.Resources.add_white
        Me.btnAddQueue.Location = New System.Drawing.Point(5, 12)
        Me.btnAddQueue.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnAddQueue.Name = "btnAddQueue"
        Me.btnAddQueue.Size = New System.Drawing.Size(38, 40)
        Me.btnAddQueue.TabIndex = 105
        Me.btnAddQueue.TabStop = False
        Me.btnAddQueue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddQueue.UseVisualStyleBackColor = False
        '
        'labelTitle
        '
        Me.labelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.Black
        Me.labelTitle.Location = New System.Drawing.Point(0, 0)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.labelTitle.Size = New System.Drawing.Size(970, 51)
        Me.labelTitle.TabIndex = 2
        Me.labelTitle.Text = "CHOOSE AN ALGORITHM"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnSaveQueue, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.datagridQueue, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 122)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.20627!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.79373!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(964, 383)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btnSaveQueue
        '
        Me.btnSaveQueue.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSaveQueue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveQueue.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSaveQueue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnSaveQueue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnSaveQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveQueue.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveQueue.ForeColor = System.Drawing.Color.White
        Me.btnSaveQueue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveQueue.Location = New System.Drawing.Point(7, 337)
        Me.btnSaveQueue.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnSaveQueue.Name = "btnSaveQueue"
        Me.btnSaveQueue.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnSaveQueue.Size = New System.Drawing.Size(952, 43)
        Me.btnSaveQueue.TabIndex = 31
        Me.btnSaveQueue.TabStop = False
        Me.btnSaveQueue.Text = "SAVE"
        Me.btnSaveQueue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveQueue.UseVisualStyleBackColor = False
        '
        'datagridQueue
        '
        Me.datagridQueue.AllowUserToAddRows = False
        Me.datagridQueue.AllowUserToDeleteRows = False
        Me.datagridQueue.AllowUserToResizeColumns = False
        Me.datagridQueue.AllowUserToResizeRows = False
        Me.datagridQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridQueue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridQueue.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.datagridQueue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridQueue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridQueue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.queueNo, Me.algorrithm, Me.timeQuantum})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridQueue.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridQueue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridQueue.Location = New System.Drawing.Point(0, 3)
        Me.datagridQueue.Margin = New System.Windows.Forms.Padding(0, 3, 1, 3)
        Me.datagridQueue.MultiSelect = False
        Me.datagridQueue.Name = "datagridQueue"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridQueue.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridQueue.RowHeadersVisible = False
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        Me.datagridQueue.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridQueue.Size = New System.Drawing.Size(963, 328)
        Me.datagridQueue.TabIndex = 12
        '
        'queueNo
        '
        Me.queueNo.HeaderText = "Queue No"
        Me.queueNo.Name = "queueNo"
        Me.queueNo.ReadOnly = True
        Me.queueNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'algorrithm
        '
        Me.algorrithm.HeaderText = "Algorithm"
        Me.algorrithm.Items.AddRange(New Object() {"FIRST COME FIRST SERVE", "ROUND ROBIN"})
        Me.algorrithm.Name = "algorrithm"
        Me.algorrithm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.algorrithm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'timeQuantum
        '
        Me.timeQuantum.HeaderText = "Time Quantum"
        Me.timeQuantum.Name = "timeQuantum"
        '
        'MainPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 509)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainPopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Initial Setup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.datagridQueue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelTitle As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents comboChooseMultiLevel As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents datagridQueue As DataGridView
    Friend WithEvents btnSaveQueue As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtQueueCount As TextBox
    Friend WithEvents labelBldgNo As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnAddQueue As Button
    Friend WithEvents queueNo As DataGridViewTextBoxColumn
    Friend WithEvents algorrithm As DataGridViewComboBoxColumn
    Friend WithEvents timeQuantum As DataGridViewTextBoxColumn
End Class
