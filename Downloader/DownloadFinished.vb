Public Class DownloadFinished

    Private Sub DownloadFinished_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        Me.Activate()
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        'Me.TopMost = True
    End Sub

    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles ButtonClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonOpen_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpen.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class