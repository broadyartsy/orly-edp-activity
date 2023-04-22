Public Class info
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles information.Click
        appoint.Show()
        Dim OBJ As New appoint
        OBJ.NameString = TextBox1.Text
        OBJ.OccupationString = TextBox2.Text
        OBJ.EmailString = TextBox3.Text
        OBJ.AddressString = TextBox4.Text
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub btnnext2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class