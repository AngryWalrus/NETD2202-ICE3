Public Class BURG
    Dim IncCount As Int16

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        IncCount = 10
        Taunt.Visible = False
        If ProgressBar.Value + IncCount < ProgressBar.Maximum Then
            ProgressBar.Value += IncCount
        End If
        If ProgressBar.Value > (ProgressBar.Maximum / 2) Then
            BtnLose.Visible = True
        End If
    End Sub

    Private Sub BtnLose_Click(sender As Object, e As EventArgs) Handles BtnLose.Click
        ProgressBar.Value = 0
        BtnLose.Visible = False
        Taunt.Visible = True
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If ProgressBar.Value > 40 Then
            ProgressBar.Value -= 10
        End If
    End Sub
End Class
