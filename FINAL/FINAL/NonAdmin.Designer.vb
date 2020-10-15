<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NonAdmin
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
        Me.components = New System.ComponentModel.Container()
        Me.Phase1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._phase1_final_1DataSet = New FINAL._phase1_final_1DataSet()
        Me.Phase1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Phase1TableAdapter = New FINAL._phase1_final_1DataSetTableAdapters.Phase1TableAdapter()
        Me.Phase1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New FINAL._phase1_final_1DataSetTableAdapters.TableAdapterManager()
        Me.Phase2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Phase2TableAdapter = New FINAL._phase1_final_1DataSetTableAdapters.Phase2TableAdapter()
        Me.TableAdapterManager1 = New FINAL._phase1_final_1DataSetTableAdapters.TableAdapterManager()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfEventDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClosen = New System.Windows.Forms.Button()
        CType(Me.Phase1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._phase1_final_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Phase1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Phase1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Phase2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Phase1BindingSource
        '
        Me.Phase1BindingSource.DataMember = "Phase1"
        Me.Phase1BindingSource.DataSource = Me._phase1_final_1DataSet
        '
        '_phase1_final_1DataSet
        '
        Me._phase1_final_1DataSet.DataSetName = "_phase1_final_1DataSet"
        Me._phase1_final_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Phase1BindingSource1
        '
        Me.Phase1BindingSource1.DataMember = "Phase1"
        Me.Phase1BindingSource1.DataSource = Me._phase1_final_1DataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(975, 309)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ProgramDataGridViewTextBoxColumn, Me.PlaceDataGridViewTextBoxColumn, Me.DateOfEventDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Phase2BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(955, 277)
        Me.DataGridView1.TabIndex = 0
        '
        'Phase1TableAdapter
        '
        Me.Phase1TableAdapter.ClearBeforeFill = True
        '
        'Phase1BindingSource2
        '
        Me.Phase1BindingSource2.DataMember = "Phase1"
        Me.Phase1BindingSource2.DataSource = Me._phase1_final_1DataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Phase1TableAdapter = Me.Phase1TableAdapter
        Me.TableAdapterManager.Phase2TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FINAL._phase1_final_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Phase1TableAdapter = Nothing
        Me.TableAdapterManager1.Phase2TableAdapter = Me.Phase2TableAdapter
        Me.TableAdapterManager1.UpdateOrder = FINAL._phase1_final_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 120
        '
        'ProgramDataGridViewTextBoxColumn
        '
        Me.ProgramDataGridViewTextBoxColumn.DataPropertyName = "Program"
        Me.ProgramDataGridViewTextBoxColumn.HeaderText = "Program"
        Me.ProgramDataGridViewTextBoxColumn.Name = "ProgramDataGridViewTextBoxColumn"
        Me.ProgramDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProgramDataGridViewTextBoxColumn.Width = 200
        '
        'PlaceDataGridViewTextBoxColumn
        '
        Me.PlaceDataGridViewTextBoxColumn.DataPropertyName = "Place"
        Me.PlaceDataGridViewTextBoxColumn.HeaderText = "Place"
        Me.PlaceDataGridViewTextBoxColumn.Name = "PlaceDataGridViewTextBoxColumn"
        Me.PlaceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlaceDataGridViewTextBoxColumn.Width = 400
        '
        'DateOfEventDataGridViewTextBoxColumn
        '
        Me.DateOfEventDataGridViewTextBoxColumn.DataPropertyName = "Date of Event"
        Me.DateOfEventDataGridViewTextBoxColumn.HeaderText = "Date of Event"
        Me.DateOfEventDataGridViewTextBoxColumn.Name = "DateOfEventDataGridViewTextBoxColumn"
        Me.DateOfEventDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateOfEventDataGridViewTextBoxColumn.Width = 120
        '
        'btnClosen
        '
        Me.btnClosen.Location = New System.Drawing.Point(892, 354)
        Me.btnClosen.Name = "btnClosen"
        Me.btnClosen.Size = New System.Drawing.Size(96, 44)
        Me.btnClosen.TabIndex = 15
        Me.btnClosen.Text = "Close"
        Me.btnClosen.UseVisualStyleBackColor = True
        '
        'NonAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 415)
        Me.Controls.Add(Me.btnClosen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NonAdmin"
        Me.Text = "NonAdmin"
        CType(Me.Phase1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._phase1_final_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Phase1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Phase1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Phase2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _phase1_final_1DataSet As _phase1_final_1DataSet
    Friend WithEvents Phase1BindingSource As BindingSource
    Friend WithEvents Phase1TableAdapter As _phase1_final_1DataSetTableAdapters.Phase1TableAdapter
    Friend WithEvents Phase1BindingSource1 As BindingSource
    Friend WithEvents Phase1BindingSource2 As BindingSource
    Friend WithEvents TableAdapterManager As _phase1_final_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Phase2BindingSource As BindingSource
    Friend WithEvents Phase2TableAdapter As _phase1_final_1DataSetTableAdapters.Phase2TableAdapter
    Friend WithEvents TableAdapterManager1 As _phase1_final_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfEventDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnClosen As Button
End Class
