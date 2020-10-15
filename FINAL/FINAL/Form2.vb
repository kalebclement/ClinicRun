Public Class Form2
    Private Sub Phase2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Phase2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._phase1_final_1DataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_phase1_final_1DataSet.Phase2' table. You can move, or remove it, as needed.
        Me.Phase2TableAdapter.Fill(Me._phase1_final_1DataSet.Phase2)

    End Sub

    Private Sub PlaceLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProgramTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProgramTextBox.TextChanged

    End Sub

    Private Sub btnAdde_Click(sender As Object, e As EventArgs) Handles btnAdde.Click
        Phase2BindingSource.AddNew()
    End Sub

    Private Sub btnSavee_Click(sender As Object, e As EventArgs) Handles btnSavee.Click
        On Error GoTo SaveErr
        Phase2BindingSource.EndEdit()
        Phase2TableAdapter.Update(_phase1_final_1DataSet.Phase2)
        MessageBox.Show("New Record Added")
SaveErr:
    End Sub

    Private Sub Phase2BindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnDele_Click(sender As Object, e As EventArgs) Handles btnDele.Click
        Phase2BindingSource.RemoveCurrent()
    End Sub

    Private Sub btnNexte_Click(sender As Object, e As EventArgs) Handles btnNexte.Click
        Phase2BindingSource.MoveNext()
    End Sub

    Private Sub btnPreve_Click(sender As Object, e As EventArgs) Handles btnPreve.Click
        Phase2BindingSource.MovePrevious()
    End Sub
End Class