<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		dgvDatapizzas = New DataGridView()
		btnCalcule = New Button()
		lbtotal = New Label()
		btnopenfile = New Button()
		txtdate = New TextBox()
		Label1 = New Label()
		CType(dgvDatapizzas, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' dgvDatapizzas
		' 
		dgvDatapizzas.AllowUserToDeleteRows = False
		dgvDatapizzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvDatapizzas.Location = New Point(22, 72)
		dgvDatapizzas.Name = "dgvDatapizzas"
		dgvDatapizzas.ReadOnly = True
		dgvDatapizzas.RowHeadersWidth = 51
		dgvDatapizzas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvDatapizzas.Size = New Size(1199, 578)
		dgvDatapizzas.TabIndex = 0
		' 
		' btnCalcule
		' 
		btnCalcule.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		btnCalcule.Location = New Point(1311, 256)
		btnCalcule.Name = "btnCalcule"
		btnCalcule.Size = New Size(130, 55)
		btnCalcule.TabIndex = 2
		btnCalcule.Text = "Calculate"
		btnCalcule.UseVisualStyleBackColor = True
		' 
		' lbtotal
		' 
		lbtotal.AutoSize = True
		lbtotal.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lbtotal.Location = New Point(1266, 351)
		lbtotal.Name = "lbtotal"
		lbtotal.Size = New Size(0, 31)
		lbtotal.TabIndex = 3
		' 
		' btnopenfile
		' 
		btnopenfile.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		btnopenfile.Location = New Point(22, 12)
		btnopenfile.Name = "btnopenfile"
		btnopenfile.Size = New Size(130, 55)
		btnopenfile.TabIndex = 4
		btnopenfile.Text = "Open File"
		btnopenfile.UseVisualStyleBackColor = True
		' 
		' txtdate
		' 
		txtdate.Font = New Font("Segoe UI", 15.0F)
		txtdate.Location = New Point(1277, 197)
		txtdate.Name = "txtdate"
		txtdate.Size = New Size(206, 41)
		txtdate.TabIndex = 5
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label1.Location = New Point(1277, 132)
		Label1.Name = "Label1"
		Label1.Size = New Size(197, 62)
		Label1.TabIndex = 6
		Label1.Text = "Format to enter " & vbCrLf & ChrW(8220) & "year-month-day" & ChrW(8221)
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(1555, 673)
		Controls.Add(Label1)
		Controls.Add(txtdate)
		Controls.Add(btnopenfile)
		Controls.Add(lbtotal)
		Controls.Add(btnCalcule)
		Controls.Add(dgvDatapizzas)
		Name = "Form1"
		Text = "Form1"
		CType(dgvDatapizzas, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents dgvDatapizzas As DataGridView
	Friend WithEvents btnCalcule As Button
	Friend WithEvents lbtotal As Label
	Friend WithEvents btnopenfile As Button
	Friend WithEvents txtdate As TextBox
	Friend WithEvents Label1 As Label

End Class
