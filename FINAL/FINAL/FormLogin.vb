Imports System.Data.OleDb
Public Class FormLogin
    Dim con As New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String

        username = txtPassword.Text
        password = txtPassword.Text
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Documents\Visual Studio 2015\Projects\phase1(final)1.mdb"
        con.Open()
        Dim logincmd As OleDbCommand = New OleDbCommand("Select * From Phase1 Where [Username]='" & txtUsername.Text & "' and [Password]='" & txtUsername.Text & "'", con)
        Dim loginrd As OleDbDataReader = logincmd.ExecuteReader

        If (loginrd.Read() = True) Then
            Me.Hide()
            If (txtUsername.Text = "Admin") Then
                Form_Administrator.Show()
                MsgBox("Login Succes " & vbNewLine & "Login User : " & txtUsername.Text, MsgBoxStyle.Information)
            Else
                NonAdmin.Show()
                MsgBox("Login Succes " & vbNewLine & "Login User : " & txtUsername.Text, MsgBoxStyle.Information)

            End If


        Else
            MsgBox("Login Failed", MsgBoxStyle.Critical)
            txtPassword.Text = ""
            txtUsername.Text = ""
            CheckBox1.Checked = False

        End If

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_phase1_final_1DataSet.Phase1' table. You can move, or remove it, as needed.
        Me.Phase1TableAdapter.Fill(Me._phase1_final_1DataSet.Phase1)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (Me.CheckBox1.Checked = True) Then
            Me.txtPassword.PasswordChar = ""
        Else
            Me.txtPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
