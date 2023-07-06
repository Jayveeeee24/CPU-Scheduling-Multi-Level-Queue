<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.labelAveWait = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelAveTurn = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.datagridLog = New System.Windows.Forms.DataGridView()
        Me.datagridInitial = New System.Windows.Forms.DataGridView()
        Me.processID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.arrivalTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.burstTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.queueNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRemoveLast = New System.Windows.Forms.Button()
        Me.btnFinishSimulation = New System.Windows.Forms.Button()
        Me.btnAddProcess = New System.Windows.Forms.Button()
        Me.btnStartSimulation = New System.Windows.Forms.Button()
        Me.btnClearProcess = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.arrival = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.burst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.completionTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.turnAroundTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waitingTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.datagridLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridInitial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.labelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.White
        Me.labelTitle.Location = New System.Drawing.Point(0, 0)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.labelTitle.Size = New System.Drawing.Size(1199, 42)
        Me.labelTitle.TabIndex = 2
        Me.labelTitle.Text = "MULTI LEVEL QUEUE"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 42)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.411765!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.58823!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1199, 594)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(10, 477)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1179, 114)
        Me.TableLayoutPanel4.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.labelAveWait)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(593, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 101)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AVERAGE WAITING TIME"
        '
        'labelAveWait
        '
        Me.labelAveWait.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelAveWait.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAveWait.ForeColor = System.Drawing.Color.Black
        Me.labelAveWait.Location = New System.Drawing.Point(3, 17)
        Me.labelAveWait.Name = "labelAveWait"
        Me.labelAveWait.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.labelAveWait.Size = New System.Drawing.Size(576, 81)
        Me.labelAveWait.TabIndex = 4
        Me.labelAveWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labelAveTurn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AVERAGE TURNAROUND TIME"
        '
        'labelAveTurn
        '
        Me.labelAveTurn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelAveTurn.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAveTurn.ForeColor = System.Drawing.Color.Black
        Me.labelAveTurn.Location = New System.Drawing.Point(3, 17)
        Me.labelAveTurn.Name = "labelAveTurn"
        Me.labelAveTurn.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.labelAveTurn.Size = New System.Drawing.Size(576, 81)
        Me.labelAveTurn.TabIndex = 3
        Me.labelAveTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.95977!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.04024!))
        Me.TableLayoutPanel2.Controls.Add(Me.datagridLog, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.datagridInitial, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(13, 58)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1173, 413)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'datagridLog
        '
        Me.datagridLog.AllowUserToAddRows = False
        Me.datagridLog.AllowUserToDeleteRows = False
        Me.datagridLog.AllowUserToResizeColumns = False
        Me.datagridLog.AllowUserToResizeRows = False
        Me.datagridLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridLog.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.datagridLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.arrival, Me.burst, Me.completionTime, Me.turnAroundTime, Me.waitingTime})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridLog.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridLog.Location = New System.Drawing.Point(422, 3)
        Me.datagridLog.Margin = New System.Windows.Forms.Padding(1, 3, 0, 3)
        Me.datagridLog.MultiSelect = False
        Me.datagridLog.Name = "datagridLog"
        Me.datagridLog.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridLog.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridLog.RowHeadersVisible = False
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        Me.datagridLog.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridLog.Size = New System.Drawing.Size(751, 407)
        Me.datagridLog.TabIndex = 12
        '
        'datagridInitial
        '
        Me.datagridInitial.AllowUserToAddRows = False
        Me.datagridInitial.AllowUserToDeleteRows = False
        Me.datagridInitial.AllowUserToResizeColumns = False
        Me.datagridInitial.AllowUserToResizeRows = False
        Me.datagridInitial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridInitial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridInitial.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.datagridInitial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridInitial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.datagridInitial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridInitial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.processID, Me.arrivalTime, Me.burstTime, Me.queueNo})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridInitial.DefaultCellStyle = DataGridViewCellStyle6
        Me.datagridInitial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridInitial.Location = New System.Drawing.Point(0, 3)
        Me.datagridInitial.Margin = New System.Windows.Forms.Padding(0, 3, 1, 3)
        Me.datagridInitial.MultiSelect = False
        Me.datagridInitial.Name = "datagridInitial"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridInitial.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.datagridInitial.RowHeadersVisible = False
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5)
        Me.datagridInitial.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.datagridInitial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridInitial.Size = New System.Drawing.Size(420, 407)
        Me.datagridInitial.TabIndex = 11
        '
        'processID
        '
        Me.processID.HeaderText = "Process ID"
        Me.processID.Name = "processID"
        Me.processID.ReadOnly = True
        Me.processID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'arrivalTime
        '
        Me.arrivalTime.HeaderText = "Arrival Time"
        Me.arrivalTime.Name = "arrivalTime"
        Me.arrivalTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'burstTime
        '
        Me.burstTime.HeaderText = "Burst Time"
        Me.burstTime.Name = "burstTime"
        Me.burstTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'queueNo
        '
        Me.queueNo.HeaderText = "Queue No"
        Me.queueNo.Name = "queueNo"
        Me.queueNo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(10, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1179, 55)
        Me.Panel2.TabIndex = 10
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 8
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.25404!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.67884!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnRemoveLast, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFinishSimulation, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAddProcess, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnStartSimulation, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnClearProcess, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1177, 53)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'btnRemoveLast
        '
        Me.btnRemoveLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemoveLast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRemoveLast.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRemoveLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnRemoveLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnRemoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveLast.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveLast.ForeColor = System.Drawing.Color.White
        Me.btnRemoveLast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveLast.Location = New System.Drawing.Point(160, 3)
        Me.btnRemoveLast.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnRemoveLast.Name = "btnRemoveLast"
        Me.btnRemoveLast.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnRemoveLast.Size = New System.Drawing.Size(141, 47)
        Me.btnRemoveLast.TabIndex = 32
        Me.btnRemoveLast.TabStop = False
        Me.btnRemoveLast.Text = "Remove Last"
        Me.btnRemoveLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemoveLast.UseVisualStyleBackColor = False
        '
        'btnFinishSimulation
        '
        Me.btnFinishSimulation.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFinishSimulation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFinishSimulation.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnFinishSimulation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnFinishSimulation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnFinishSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinishSimulation.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinishSimulation.ForeColor = System.Drawing.Color.White
        Me.btnFinishSimulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinishSimulation.Location = New System.Drawing.Point(751, 3)
        Me.btnFinishSimulation.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnFinishSimulation.Name = "btnFinishSimulation"
        Me.btnFinishSimulation.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnFinishSimulation.Size = New System.Drawing.Size(149, 47)
        Me.btnFinishSimulation.TabIndex = 35
        Me.btnFinishSimulation.TabStop = False
        Me.btnFinishSimulation.Text = "Finish Simulation"
        Me.btnFinishSimulation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFinishSimulation.UseVisualStyleBackColor = False
        '
        'btnAddProcess
        '
        Me.btnAddProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddProcess.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAddProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAddProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProcess.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProcess.ForeColor = System.Drawing.Color.White
        Me.btnAddProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddProcess.Location = New System.Drawing.Point(7, 3)
        Me.btnAddProcess.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnAddProcess.Name = "btnAddProcess"
        Me.btnAddProcess.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAddProcess.Size = New System.Drawing.Size(141, 47)
        Me.btnAddProcess.TabIndex = 31
        Me.btnAddProcess.TabStop = False
        Me.btnAddProcess.Text = "Add Process"
        Me.btnAddProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddProcess.UseVisualStyleBackColor = False
        '
        'btnStartSimulation
        '
        Me.btnStartSimulation.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStartSimulation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStartSimulation.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStartSimulation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnStartSimulation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnStartSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartSimulation.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartSimulation.ForeColor = System.Drawing.Color.White
        Me.btnStartSimulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStartSimulation.Location = New System.Drawing.Point(595, 3)
        Me.btnStartSimulation.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnStartSimulation.Name = "btnStartSimulation"
        Me.btnStartSimulation.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnStartSimulation.Size = New System.Drawing.Size(144, 47)
        Me.btnStartSimulation.TabIndex = 34
        Me.btnStartSimulation.TabStop = False
        Me.btnStartSimulation.Text = "Start Simulation"
        Me.btnStartSimulation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStartSimulation.UseVisualStyleBackColor = False
        '
        'btnClearProcess
        '
        Me.btnClearProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClearProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClearProcess.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClearProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnClearProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnClearProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearProcess.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearProcess.ForeColor = System.Drawing.Color.White
        Me.btnClearProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearProcess.Location = New System.Drawing.Point(313, 3)
        Me.btnClearProcess.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnClearProcess.Name = "btnClearProcess"
        Me.btnClearProcess.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnClearProcess.Size = New System.Drawing.Size(141, 47)
        Me.btnClearProcess.TabIndex = 32
        Me.btnClearProcess.TabStop = False
        Me.btnClearProcess.Text = "Clear Process"
        Me.btnClearProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearProcess.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Process ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'arrival
        '
        Me.arrival.HeaderText = "Time Executed"
        Me.arrival.Name = "arrival"
        Me.arrival.ReadOnly = True
        '
        'burst
        '
        Me.burst.HeaderText = "Burst Time"
        Me.burst.Name = "burst"
        Me.burst.ReadOnly = True
        '
        'completionTime
        '
        Me.completionTime.HeaderText = "Completion Time"
        Me.completionTime.Name = "completionTime"
        Me.completionTime.ReadOnly = True
        Me.completionTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'turnAroundTime
        '
        Me.turnAroundTime.HeaderText = "Turnaround Time"
        Me.turnAroundTime.Name = "turnAroundTime"
        Me.turnAroundTime.ReadOnly = True
        Me.turnAroundTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'waitingTime
        '
        Me.waitingTime.HeaderText = "Waiting Time"
        Me.waitingTime.Name = "waitingTime"
        Me.waitingTime.ReadOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 636)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.labelTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi Level Queue Simulator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.datagridLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridInitial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labelTitle As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents datagridLog As DataGridView
    Friend WithEvents datagridInitial As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnRemoveLast As Button
    Friend WithEvents btnFinishSimulation As Button
    Friend WithEvents btnAddProcess As Button
    Friend WithEvents btnStartSimulation As Button
    Friend WithEvents btnClearProcess As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents labelAveWait As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents labelAveTurn As Label
    Friend WithEvents processID As DataGridViewTextBoxColumn
    Friend WithEvents arrivalTime As DataGridViewTextBoxColumn
    Friend WithEvents burstTime As DataGridViewTextBoxColumn
    Friend WithEvents queueNo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents arrival As DataGridViewTextBoxColumn
    Friend WithEvents burst As DataGridViewTextBoxColumn
    Friend WithEvents completionTime As DataGridViewTextBoxColumn
    Friend WithEvents turnAroundTime As DataGridViewTextBoxColumn
    Friend WithEvents waitingTime As DataGridViewTextBoxColumn
End Class
