Public Class BerandaDispora

    Private Sub BerandaDispora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If WelcomeLabel.Left >= Me.Size.Width - WelcomeLabel.Width Then

            Timer1.Enabled = False
            Timer2.Enabled = True
        Else
            WelcomeLabel.Left = WelcomeLabel.Left + 10
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If WelcomeLabel.Left <= 0 Then

            Timer2.Enabled = False
            Timer1.Enabled = True
        Else
            WelcomeLabel.Left = WelcomeLabel.Left - 10
        End If
    End Sub

    Private Sub AtletToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtletToolStripMenuItem.Click
        Atlet.ShowDialog()
    End Sub
End Class