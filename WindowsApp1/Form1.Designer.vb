<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.PersonBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.CiputraDataSet1 = New WindowsApp1.ciputraDataSet1()
		Me.PersonTableAdapter1 = New WindowsApp1.ciputraDataSet1TableAdapters.personTableAdapter()
		Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.LahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PersonBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CiputraDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "&File"
		'
		'EditorToolStripMenuItem
		'
		Me.EditorToolStripMenuItem.Name = "EditorToolStripMenuItem"
		Me.EditorToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
		Me.EditorToolStripMenuItem.Text = "Editor"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
		Me.StatusStrip1.TabIndex = 1
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'DataGridView1
		'
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.LahirDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.PersonBindingSource1
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(800, 404)
		Me.DataGridView1.TabIndex = 2
		'
		'PersonBindingSource1
		'
		Me.PersonBindingSource1.DataMember = "person"
		Me.PersonBindingSource1.DataSource = Me.CiputraDataSet1
		'
		'CiputraDataSet1
		'
		Me.CiputraDataSet1.DataSetName = "ciputraDataSet1"
		Me.CiputraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'PersonTableAdapter1
		'
		Me.PersonTableAdapter1.ClearBeforeFill = True
		'
		'IDDataGridViewTextBoxColumn
		'
		Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
		Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
		Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
		'
		'NamaDataGridViewTextBoxColumn
		'
		Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "Nama"
		Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
		Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
		Me.NamaDataGridViewTextBoxColumn.Width = 300
		'
		'LahirDataGridViewTextBoxColumn
		'
		Me.LahirDataGridViewTextBoxColumn.DataPropertyName = "Lahir"
		Me.LahirDataGridViewTextBoxColumn.HeaderText = "Lahir"
		Me.LahirDataGridViewTextBoxColumn.Name = "LahirDataGridViewTextBoxColumn"
		Me.LahirDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.LahirDataGridViewTextBoxColumn.Width = 200
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PersonBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CiputraDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents EditorToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CiputraDataSet1 As ciputraDataSet1
	Friend WithEvents PersonBindingSource1 As BindingSource
	Friend WithEvents PersonTableAdapter1 As ciputraDataSet1TableAdapters.personTableAdapter
	Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents LahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
