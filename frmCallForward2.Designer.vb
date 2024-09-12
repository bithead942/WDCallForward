<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCallForward
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCallForward))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtForwardNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLastActivated = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLastChecked = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOccupied = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDeactivate = New System.Windows.Forms.Button()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.Event_Current_StateDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_Current_StateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WatchdogDataSet = New WindowsApplication1.WatchdogDataSet()
        Me.tCheckHouseOccupied = New System.Windows.Forms.Timer(Me.components)
        Me.Event_Current_StateTableAdapter = New WindowsApplication1.WatchdogDataSetTableAdapters.Event_Current_StateTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.WatchdogDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Event_Current_StateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Call Status:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(115, 4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(77, 13)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Not Forwarded"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Forward #:"
        '
        'txtForwardNo
        '
        Me.txtForwardNo.Location = New System.Drawing.Point(120, 213)
        Me.txtForwardNo.Name = "txtForwardNo"
        Me.txtForwardNo.Size = New System.Drawing.Size(63, 20)
        Me.txtForwardNo.TabIndex = 7
        Me.txtForwardNo.Text = "5445316"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLastActivated)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblLastChecked)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblOccupied)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnStop)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 112)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "House Occupied"
        '
        'lblLastActivated
        '
        Me.lblLastActivated.AutoSize = True
        Me.lblLastActivated.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastActivated.Location = New System.Drawing.Point(113, 95)
        Me.lblLastActivated.Name = "lblLastActivated"
        Me.lblLastActivated.Size = New System.Drawing.Size(75, 9)
        Me.lblLastActivated.TabIndex = 17
        Me.lblLastActivated.Text = "12/31/2011 10:00 PM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Last Activated:"
        '
        'lblLastChecked
        '
        Me.lblLastChecked.AutoSize = True
        Me.lblLastChecked.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastChecked.Location = New System.Drawing.Point(113, 77)
        Me.lblLastChecked.Name = "lblLastChecked"
        Me.lblLastChecked.Size = New System.Drawing.Size(75, 9)
        Me.lblLastChecked.TabIndex = 15
        Me.lblLastChecked.Text = "12/31/2011 10:00 PM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Last Checked:"
        '
        'lblOccupied
        '
        Me.lblOccupied.AutoSize = True
        Me.lblOccupied.Location = New System.Drawing.Point(126, 20)
        Me.lblOccupied.Name = "lblOccupied"
        Me.lblOccupied.Size = New System.Drawing.Size(25, 13)
        Me.lblOccupied.TabIndex = 13
        Me.lblOccupied.Text = "Yes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Occupied Status:"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(104, 41)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(88, 25)
        Me.btnStop.TabIndex = 11
        Me.btnStop.Text = "Stop Checking"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(10, 41)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(88, 25)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Start Checking"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDeactivate)
        Me.GroupBox2.Controls.Add(Me.btnActivate)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 65)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Call Forwarding Override"
        '
        'btnDeactivate
        '
        Me.btnDeactivate.Location = New System.Drawing.Point(104, 20)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.Size = New System.Drawing.Size(88, 37)
        Me.btnDeactivate.TabIndex = 15
        Me.btnDeactivate.Text = "Deactivate Call Forwarding"
        Me.btnDeactivate.UseVisualStyleBackColor = True
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(10, 20)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(88, 37)
        Me.btnActivate.TabIndex = 14
        Me.btnActivate.Text = "Activate Call Forwarding"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'Event_Current_StateDataGridView
        '
        Me.Event_Current_StateDataGridView.AutoGenerateColumns = False
        Me.Event_Current_StateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_Current_StateDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Event_Current_StateDataGridView.DataSource = Me.Event_Current_StateBindingSource
        Me.Event_Current_StateDataGridView.Location = New System.Drawing.Point(198, 7)
        Me.Event_Current_StateDataGridView.Name = "Event_Current_StateDataGridView"
        Me.Event_Current_StateDataGridView.Size = New System.Drawing.Size(16, 17)
        Me.Event_Current_StateDataGridView.TabIndex = 12
        Me.Event_Current_StateDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Row_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Row_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "House_Occupied"
        Me.DataGridViewTextBoxColumn2.HeaderText = "House_Occupied"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Event_Current_StateBindingSource
        '
        Me.Event_Current_StateBindingSource.DataMember = "Event_Current_State"
        Me.Event_Current_StateBindingSource.DataSource = Me.WatchdogDataSet
        '
        'WatchdogDataSet
        '
        Me.WatchdogDataSet.DataSetName = "WatchdogDataSet"
        Me.WatchdogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tCheckHouseOccupied
        '
        Me.tCheckHouseOccupied.Interval = 30000
        '
        'Event_Current_StateTableAdapter
        '
        Me.Event_Current_StateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Event_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.WatchdogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmCallForward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 238)
        Me.Controls.Add(Me.Event_Current_StateDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtForwardNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCallForward"
        Me.Text = "WDCallForward3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Event_Current_StateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtForwardNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOccupied As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeactivate As System.Windows.Forms.Button
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents WatchdogDataSet As WindowsApplication1.WatchdogDataSet
    Friend WithEvents Event_Current_StateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_Current_StateTableAdapter As WindowsApplication1.WatchdogDataSetTableAdapters.Event_Current_StateTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.WatchdogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Event_Current_StateDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tCheckHouseOccupied As System.Windows.Forms.Timer
    Friend WithEvents lblLastChecked As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblLastActivated As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
