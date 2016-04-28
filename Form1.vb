Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim salary As String
        Dim vat, sum As Double
        salary = TextBox1.Text
        If salary <= 10000 Then
            vat = 0%
        ElseIf salary <= 15000 Then
            vat = 7%
        ElseIf salary > 15000 Then
            vat = 12%
        Else
            vat = 0%
        End If
        sum = (salary * vat) / 100
        TextBox2.Text = sum
        TextBox3.Text = vat
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim mbr As MsgBoxResult
        mbr = MsgBox("ออกจากโปรแกรมหรือไม่?",
        MsgBoxStyle.OkCancel + _
        MsgBoxStyle.Question + _
        MsgBoxStyle.ApplicationModal, _
        "ออกจากโปรแกรม")
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ("")
        TextBox2.Text = ("")
        TextBox3.Text = ("")
    End Sub
End Class
