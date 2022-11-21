Imports System.Data.SqlClient
Public Class Form2
  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    DbPerson.InsertPerson(TxtID.Text, TxtName.Text, DtpLahir.Value)
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    DbPerson.UpdatePerson(TxtID.Text, TxtName.Text, DtpLahir.Value)
  End Sub

  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    DbPerson.DeletePerson(TxtID.Text)
  End Sub
End Class