Public Class Form1
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'CiputraDataSet1.person' table. You can move, or remove it, as needed.
    Me.PersonTableAdapter1.Fill(Me.CiputraDataSet1.person)

    DbPerson.PutDataSet(PersonTableAdapter1)
  End Sub

  Private Sub EditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorToolStripMenuItem.Click
    Dim form As New Form2()
    form.ShowDialog()
  End Sub
End Class
