<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ProgramLabel As System.Windows.Forms.Label
        Dim PlaceLabel As System.Windows.Forms.Label
        Dim Date_of_EventLabel As System.Windows.Forms.Label
        Me._phase1_final_1DataSet = New FINAL._phase1_final_1DataSet()
        Me.Phase2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Phase2TableAdapter = New FINAL._phase1_final_1DataSetTableAdapters.Phase2TableAdapter()
        Me.TableAdapterManager = New FINAL._phase1_final_1DataSetTableAdapters.TableAdapterManager()
        Me.ProgramTextBox = New System.Windows.Forms.TextBox()
        Me.PlaceTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_EventDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnAdde = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSavee = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnDele = New System.Windows.Forms.Button()
        Me.btnPreve = New System.Windows.Forms.Button()
        Me.btnNexte = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfEventDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProgramLabel = New System.Windows.Forms.Label()
        PlaceLabel = New System.Windows.Forms.Label()
        Date_of_EventLabel = New System.Windows.Forms.Label()
        CType(Me._phase1_final_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Phase2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_phase1_final_1DataSet
        '
        Me._phase1_final_1DataSet.DataSetName = "_phase1_final_1DataSet"
        Me._phase1_final_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Phase2BindingSource
        '
        Me.Phase2BindingSource.DataMember = "Phase2"
        Me.Phase2BindingSource.DataSource = Me._phase1_final_1DataSet
        '
        'Phase2TableAdapter
        '
        Me.Phase2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Phase1TableAdapter = Nothing
        Me.TableAdapterManager.Phase2TableAdapter = Me.Phase2TableAdapter
        Me.TableAdapterManager.UpdateOrder = FINAL._phase1_final_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProgramLabel
        '
        ProgramLabel.AutoSize = True
        ProgramLabel.Location = New System.Drawing.Point(76, 96)
        ProgramLabel.Name = "ProgramLabel"
        ProgramLabel.Size = New System.Drawing.Size(66, 17)
        ProgramLabel.TabIndex = 1
        ProgramLabel.Text = "Program:"
        '
        'ProgramTextBox
        '
        Me.ProgramTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Phase2BindingSource, "Program", True))
        Me.ProgramTextBox.Location = New System.Drawing.Point(180, 96)
        Me.ProgramTextBox.Name = "ProgramTextBox"
        Me.ProgramTextBox.Size = New System.Drawing.Size(273, 22)
        Me.ProgramTextBox.TabIndex = 2
        '
        'PlaceLabel
        '
        PlaceLabel.AutoSize = True
        PlaceLabel.Location = New System.Drawing.Point(76, 159)
        PlaceLabel.Name = "PlaceLabel"
        PlaceLabel.Size = New System.Drawing.Size(47, 17)
        PlaceLabel.TabIndex = 3
        PlaceLabel.Text = "Place:"
        AddHandler PlaceLabel.Click, AddressOf Me.PlaceLabel_Click
        '
        'PlaceTextBox
        '
        Me.PlaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Phase2BindingSource, "Place", True))
        Me.PlaceTextBox.Location = New System.Drawing.Point(180, 156)
        Me.PlaceTextBox.Multiline = True
        Me.PlaceTextBox.Name = "PlaceTextBox"
        Me.PlaceTextBox.Size = New System.Drawing.Size(273, 86)
        Me.PlaceTextBox.TabIndex = 4
        '
        'Date_of_EventLabel
        '
        Date_of_EventLabel.AutoSize = True
        Date_of_EventLabel.Location = New System.Drawing.Point(57, 247)
        Date_of_EventLabel.Name = "Date_of_EventLabel"
        Date_of_EventLabel.Size = New System.Drawing.Size(98, 17)
        Date_of_EventLabel.TabIndex = 5
        Date_of_EventLabel.Text = "Date of Event:"
        '
        'Date_of_EventDateTimePicker
        '
        Me.Date_of_EventDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Phase2BindingSource, "Date of Event", True))
        Me.Date_of_EventDateTimePicker.Location = New System.Drawing.Point(180, 277)
        Me.Date_of_EventDateTimePicker.Name = "Date_of_EventDateTimePicker"
        Me.Date_of_EventDateTimePicker.Size = New System.Drawing.Size(273, 22)
        Me.Date_of_EventDateTimePicker.TabIndex = 6
        '
        'btnAdde
        '
        Me.btnAdde.Location = New System.Drawing.Point(101, 299)
        Me.btnAdde.Name = "btnAdde"
        Me.btnAdde.Size = New System.Drawing.Size(86, 32)
        Me.btnAdde.TabIndex = 7
        Me.btnAdde.Text = "Add"
        Me.btnAdde.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNexte)
        Me.GroupBox1.Controls.Add(Me.btnPreve)
        Me.GroupBox1.Controls.Add(Me.btnDele)
        Me.GroupBox1.Controls.Add(Me.btnSavee)
        Me.GroupBox1.Controls.Add(Me.btnAdde)
        Me.GroupBox1.Controls.Add(Date_of_EventLabel)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1221, 381)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnSavee
        '
        Me.btnSavee.Location = New System.Drawing.Point(243, 297)
        Me.btnSavee.Name = "btnSavee"
        Me.btnSavee.Size = New System.Drawing.Size(80, 32)
        Me.btnSavee.TabIndex = 6
        Me.btnSavee.Text = "Save"
        Me.btnSavee.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ProgramDataGridViewTextBoxColumn, Me.PlaceDataGridViewTextBoxColumn, Me.DateOfEventDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Phase2BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(477, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(714, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'btnDele
        '
        Me.btnDele.Location = New System.Drawing.Point(380, 296)
        Me.btnDele.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDele.Name = "btnDele"
        Me.btnDele.Size = New System.Drawing.Size(84, 32)
        Me.btnDele.TabIndex = 13
        Me.btnDele.Text = "Delete"
        Me.btnDele.UseVisualStyleBackColor = True
        '
        'btnPreve
        '
        Me.btnPreve.Location = New System.Drawing.Point(170, 336)
        Me.btnPreve.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreve.Name = "btnPreve"
        Me.btnPreve.Size = New System.Drawing.Size(84, 32)
        Me.btnPreve.TabIndex = 9
        Me.btnPreve.Text = "Previous"
        Me.btnPreve.UseVisualStyleBackColor = True
        '
        'btnNexte
        '
        Me.btnNexte.Location = New System.Drawing.Point(309, 336)
        Me.btnNexte.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNexte.Name = "btnNexte"
        Me.btnNexte.Size = New System.Drawing.Size(86, 32)
        Me.btnNexte.TabIndex = 11
        Me.btnNexte.Text = "Next"
        Me.btnNexte.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'ProgramDataGridViewTextBoxColumn
        '
        Me.ProgramDataGridViewTextBoxColumn.DataPropertyName = "Program"
        Me.ProgramDataGridViewTextBoxColumn.HeaderText = "Program"
        Me.ProgramDataGridViewTextBoxColumn.Name = "ProgramDataGridViewTextBoxColumn"
        Me.ProgramDataGridViewTextBoxColumn.Width = 200
        '
        'PlaceDataGridViewTextBoxColumn
        '
        Me.PlaceDataGridViewTextBoxColumn.DataPropertyName = "Place"
        Me.PlaceDataGridViewTextBoxColumn.HeaderText = "Place"
        Me.PlaceDataGridViewTextBoxColumn.Name = "PlaceDataGridViewTextBoxColumn"
        Me.PlaceDataGridViewTextBoxColumn.Width = 300
        '
        'DateOfEventDataGridViewTextBoxColumn
        '
        Me.DateOfEventDataGridViewTextBoxColumn.DataPropertyName = "Date of Event"
        Me.DateOfEventDataGridViewTextBoxColumn.HeaderText = "Date of Event"
        Me.DateOfEventDataGridViewTextBoxColumn.Name = "DateOfEventDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 486)
        Me.Controls.Add(Me.Date_of_EventDateTimePicker)
        Me.Controls.Add(PlaceLabel)
        Me.Controls.Add(Me.PlaceTextBox)
        Me.Controls.Add(ProgramLabel)
        Me.Controls.Add(Me.ProgramTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me._phase1_final_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Phase2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _phase1_final_1DataSet As _phase1_final_1DataSet
    Friend WithEvents Phase2BindingSource As BindingSource
    Friend WithEvents Phase2TableAdapter As _phase1_final_1DataSetTableAdapters.Phase2TableAdapter
    Friend WithEvents TableAdapterManager As _phase1_final_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProgramTextBox As TextBox
    Friend WithEvents PlaceTextBox As TextBox
    Friend WithEvents Date_of_EventDateTimePicker As DateTimePicker
    Friend WithEvents btnAdde As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSavee As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDele As Button
    Friend WithEvents btnPreve As Button
    Friend WithEvents btnNexte As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfEventDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
