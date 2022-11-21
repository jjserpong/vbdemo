Imports System.Data.OleDb
Imports System.Data.SqlClient

Module DbPerson
	Private adapt As ciputraDataSet1TableAdapters.personTableAdapter

	Public Sub PutDataSet(ByRef adapter As ciputraDataSet1TableAdapters.personTableAdapter)
		adapt = adapter
	End Sub

	Public Function InsertPerson(ByVal ID As String,
															 ByVal name As String,
															 ByVal lahir As Date) As Boolean
		Dim Str = "insert into person values('" _
			& ID & "','" & name & "','" &
			lahir.ToString("yyyy-MM-dd") & "')"
		Return Execute(Str) > 0
	End Function

	Public Function UpdatePerson(ByVal ID As String,
															 ByVal name As String,
															 ByVal lahir As Date) As Boolean
		Dim Str = "update person set name='" & name &
			"', lahir='" & lahir.ToString("yyyy-MM-dd") &
			"' where ID='" & ID & "'"
		Return Execute(Str) > 0
	End Function

	Public Function DeletePerson(ByVal ID As String) As Boolean
		Dim Str = "delete person where ID='" & ID & "'"
		Return Execute(Str) > 0
	End Function

	Private Function Execute(ByVal qry As String) As Integer
		Dim conn = adapt.Adapter.SelectCommand.Connection
		Dim rowCount As Integer
		Dim connstate = conn.State

		Try
			If connstate <> ConnectionState.Open Then conn.Open()
			Dim cmd = adapt.Adapter.UpdateCommand

			cmd.CommandText = qry
			cmd.CommandType = CommandType.Text
			cmd.CommandTimeout = 60
			rowCount = cmd.ExecuteNonQuery()
			Return rowCount
		Catch ex As Exception
			MessageBox.Show("ERROR:" & ex.Message)
			Return -1
		Finally
			If (connstate <> ConnectionState.Open) Then
				conn.Close()
			End If
		End Try
	End Function

End Module
