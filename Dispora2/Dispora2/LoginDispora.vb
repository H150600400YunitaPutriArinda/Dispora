Public Class FormBeranda

    Private Sub WelcomeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FormBeranda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        Timer3.Start()
    End Sub

    Private Sub CancButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KeluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarButton.Click
        End
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If TextBox1.Text = "dispora" And TextBox2.Text = "12345" Then
            ProgressBar1.Increment(10)
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Timer3.Stop()
                ProgressBar1.Value = 0
                MsgBox("Your Logged", MsgBoxStyle.Information)
                BerandaDispora.Show()
            End If
        Else
            Timer3.Start()
            ProgressBar1.Increment(10)
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Timer3.Stop()
                ProgressBar1.Value = 0
                MsgBox("Login Not Succes", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class
