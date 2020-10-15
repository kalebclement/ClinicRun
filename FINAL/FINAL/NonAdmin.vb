Public Class NonAdmin


    Private Sub NonAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        'TODO: This line of code loads data into the '_phase1_final_1DataSet.Phase1' table. You can move, or remove it, as needed.
        Me.Phase1TableAdapter.Fill(Me._phase1_final_1DataSet.Phase1)
        Dim dv As DataView
        dv = New DataView(ds.Tables(0), "type = 'Program KB'", "type Desc", DataViewRowState.CurrentRows)
        DataGridView1.DataSource = dv
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        On Error GoTo SaveErr
        Phase1BindingSource.EndEdit()
        Phase1TableAdapter.Update(_phase1_final_1DataSet.Phase1)
        MessageBox.Show("Success !")
SaveErr:
        Exit Sub
    End Sub

    Private Sub btnClosen_Click(sender As Object, e As EventArgs) Handles btnClosen.Click
        Application.Exit()
    End Sub
End Class