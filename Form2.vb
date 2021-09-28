Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 5
        Timer1.Enabled = True
    End Sub

 Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    ProgressBar1.Increment(1)
    If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Close()
        Timer1.Stop()
    End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
