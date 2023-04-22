Imports System.IO
Imports System.Text

Public Class appoint
    Public Property NameString As String
    Public Property OccupationString As String
    Public Property EmailString As String
    Public Property AddressString As String

    Private Sub btnnext4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppointmentdbDataSet.appoint_table' table. You can move, or remove it, as needed.
        Me.Appoint_tableTableAdapter.Fill(Me.AppointmentdbDataSet.appoint_table)

        main.Text = NameString
        occupation.Text = OccupationString
        email.Text = EmailString
        address.Text = AddressString
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        info.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles appointment.Click
        Slip.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub firstname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub name_Click(sender As Object, e As EventArgs) Handles main.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub occupation_Click(sender As Object, e As EventArgs) Handles occupation.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles upload.Click
        DataGridView1.Rows.Clear()

        Try

            Dim fname As String = "C:\appointmentlist.csv"

            Dim reader As New StreamReader(fname, Encoding.Default)

            Dim sline As String = ""

            Dim colsexpected As Integer = 6

            Dim r As Integer = 0

            sline = reader.ReadLine

            Do
                sline = reader.ReadLine
                If sline Is Nothing Then Exit Do
                Dim words() As String = sline.Split(",")
                DataGridView1.Rows.Add()
                For i As Integer = 0 To 5
                    DataGridView1.Rows(r).Cells(i).Value = words(i)
                Next
                r = r + 1
            Loop
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class