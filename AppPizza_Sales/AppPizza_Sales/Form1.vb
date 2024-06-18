Imports System.IO

Public Class Form1
	Dim filePath As String
	Dim total As Decimal
	Public Sub New()
		InitializeComponent()
		total = 0

	End Sub
	Private Sub btnopenfile_Click(sender As Object, e As EventArgs) Handles btnopenfile.Click
		Dim openFileDialog As New OpenFileDialog()
		openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
		openFileDialog.Title = "Open a Text File"
		openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
		If openFileDialog.ShowDialog() <> DialogResult.OK Then
			MessageBox.Show("A file was not selected")
			Return
		End If
		filePath = openFileDialog.FileName
		Try
			Dim lines As String() = File.ReadAllLines(filePath)
			Dim dt As New DataTable()
			Dim headers As String() = lines(0).Split(","c)
			For Each header As String In headers
				dt.Columns.Add(header)
			Next

			For i As Integer = 1 To lines.Length - 1
				Dim row As String() = lines(i).Split(","c)
				dt.Rows.Add(row)

			Next
			' Agregar una nueva columna decimal para almacenar los valores de la columna 8.
			dt.Columns.Add("Price", GetType(Decimal))

			For Each dr As DataRow In dt.Rows
				Dim priceString As String = dr(8).ToString()
				Dim priceDecimal As Decimal = 0
				Decimal.TryParse(priceString, priceDecimal)
				dr("Price") = priceDecimal
			Next

			dt.Columns.RemoveAt(8)
			dgvDatapizzas.DataSource = dt

			MessageBox.Show("File loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			MessageBox.Show("An error occurred while loading the file. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try



	End Sub

	Private Sub btnCalcule_Click(sender As Object, e As EventArgs) Handles btnCalcule.Click

		Dim _date As String = txtdate.Text
		Dim precioTotal As Decimal = 0

		For Each fila As DataGridViewRow In dgvDatapizzas.Rows
			Dim daterow As String = fila.Cells(3).Value

			If daterow = _date Then
				Dim precio As Decimal = fila.Cells(8).Value
				precioTotal += precio
			End If
		Next
		lbtotal.Text = "The total is: " & precioTotal.ToString("0.00")


	End Sub
End Class
