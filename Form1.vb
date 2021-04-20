Public Class Form1

    Private Sub S1()
        lblResult1.Text = "DDT4C"
    End Sub

    Private Sub btnPapar1_Click(sender As Object, e As EventArgs) Handles btnPapar1.Click
        S1()
    End Sub

    Private Sub S2()
        Dim strText As String
        strText = txtBox1.Text
        lblResult2.Text = strText
    End Sub

    Private Sub btnPapar2_Click(sender As Object, e As EventArgs) Handles btnPapar2.Click
        S2()
    End Sub

    Private Function F1()
        Return "Hello World"
    End Function

    Private Sub btnPapar3_Click(sender As Object, e As EventArgs) Handles btnPapar3.Click
        lblResult3.Text = F1()
    End Sub

    Private Function F2()
        Dim strText2 As String
        strText2 = txtBox2.Text
        Return strText2
    End Function

    Private Sub btnPapar4_Click(sender As Object, e As EventArgs) Handles btnPapar4.Click
        lblResult4.Text = F2()
    End Sub
End Class
