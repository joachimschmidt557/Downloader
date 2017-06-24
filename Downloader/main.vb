Imports System.Net
Imports System.ComponentModel

Public Class Main
    Dim downloadDirectory As IO.DirectoryInfo
    Dim isMainWindow As Boolean = False
    Dim downloadFinishedNotification As New DownloadFinished
    Dim downloadedFile As String
    Dim SW As Stopwatch
    Dim isDownloadRunning As Boolean = False

    Private Sub main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isDownloadRunning = True Then
            If MsgBox("Do you really want to close? All running Downloads will be canceled. ", MsgBoxStyle.OkCancel, "Close") = MsgBoxResult.Ok Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Height = 158
        Label.Visible = False
        TextBoxPath.Visible = False
        TextBoxPath.Text = "D:\Downloader\"
        BytesLabel.Text = "No Download running"
    End Sub

    Private Sub DownloadButton_Click(sender As System.Object, e As System.EventArgs) Handles DownloadButton.Click

        StartDownload()

    End Sub

    Private Sub StartDownload()
        Try
            'If DownloadDirectory.Exists = True Then
            If TextBox.Text <> "" And TextBoxPath.Text <> "" Then
                'Disable all buttons first
                DownloadButton.Enabled = False
                'ButtonSettings.Enabled = False
                TextBoxPath.Enabled = False
                TextBox.Enabled = False
                'Now Declare
                Dim s As New WebClient
                AddHandler s.DownloadProgressChanged, AddressOf DownloadProgressChanged
                AddHandler s.DownloadFileCompleted, AddressOf Finished
                'Now Evaluate
                Dim shortfilename As String
                Dim localfile As String
                shortfilename = EvaluateInternetSourceFile(TextBox.Text)
                localfile = EvaluateLocalFile(shortfilename)
                'Now show the local file in the  settings button
                'ButtonSettings.Text = localfile
                downloadedFile = localfile
                'Now check the internet connection
                If CheckForInternetConnection() = False Then
                    MsgBox("There is no internet connection. ", MsgBoxStyle.Exclamation, "Error")
                    Exit Sub
                End If
                'Start the Stopwatch
                SW = Stopwatch.StartNew
                'Show balloon
                NotifyIcon.ShowBalloonTip(2000, "Downloader", "Your download is starting.", ToolTipIcon.Info)
                'Now Download
                isDownloadRunning = True
                s.DownloadFileAsync(New Uri(TextBox.Text), localfile)
            Else
                isDownloadRunning = False
                MsgBox("An input is missing!", MsgBoxStyle.Exclamation, "Downloader")
            End If
            'Else
            'DownloadDirectory.Create()
            'MsgBox("Please Restart the Download. ")
            'End If
        Catch ex As Exception
            MsgBox("An error occured. " + Environment.NewLine + "Details: " + ex.ToString, MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub

    Private Sub ButtonSettings_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSettings.Click
        If Label.Visible = True Then
            Label.Visible = False
            TextBoxPath.Visible = False
            Me.Height = 158
        Else
            Label.Visible = True
            TextBoxPath.Visible = True
            Me.Height = 246
        End If
    End Sub

    Public Function EvaluateInternetSourceFile(ByVal longName As String) As String
        Dim fnPeices() As String = longName.Split("/")
        Dim filename As String = ""
        filename = fnPeices(fnPeices.Length - 1)
        Return filename
    End Function

    Public Function EvaluateLocalFile(ByVal filename As String) As String
        Dim localfilea As String = ""
        localfilea = TextBoxPath.Text + filename
        Return localfilea
    End Function

    Public Sub DownloadProgressChanged(sender As System.Object, e As DownloadProgressChangedEventArgs)
        Dim Speed As Integer
        'Show progress
        ProgressBar.Value = e.ProgressPercentage
        'Show percentage
        DownloadButton.Text = e.ProgressPercentage.ToString + "%"
        '... in window title
        Me.Text = "Downloader - " + e.ProgressPercentage.ToString + "%"
        'Calculate speed
        Speed = CInt(e.BytesReceived / SW.ElapsedMilliseconds)
        'Update NotifyIcon
        NotifyIcon.Text = "Downloader" + Environment.NewLine + e.ProgressPercentage.ToString + "%"
        'Show speed & Bytes transferred & bytes remaining
        BytesLabel.Text = e.BytesReceived.ToString + " Bytes of " + e.TotalBytesToReceive.ToString + " Bytes @" + Speed.ToString + "KB/sec"
    End Sub

    Public Sub Finished(sender As System.Object, e As AsyncCompletedEventArgs)
        'Set downloadrunning to false
        isDownloadRunning = False
        'Reset everything
        DownloadButton.Enabled = True
        DownloadButton.Text = "Download"
        ButtonSettings.Enabled = True
        TextBox.Enabled = True
        TextBoxPath.Enabled = True
        'Show window text
        Me.Text = "Downloader - Finished"
        BytesLabel.Text = "No download running"
        'Update NotifyIcon
        NotifyIcon.Text = "Downloader" + Environment.NewLine + "Download finished"
        'Show download notification
        If downloadFinishedNotification.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Process.Start(downloadedFile)
            Catch ex As Exception
                MsgBox("An error occured. " + Environment.NewLine + "Details: " + ex.ToString, MsgBoxStyle.Critical, "Error!")
            End Try
        End If
    End Sub

    Private Sub ButtonNew_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNew.Click
        Try
            Process.Start(Application.ExecutablePath)
        Catch ex As Exception
            MsgBox("An error occured. " + Environment.NewLine + ex.ToString)
        End Try
    End Sub

    Public Function CheckForInternetConnection() As Boolean
        If isMainWindow = False Then
            Me.Text = "Downloader - Checking internet connection..."
        Else
            Me.Text = "Main Downloader - Checking internet connection..."
        End If
        If My.Computer.Network.IsAvailable = False Then
            Return False
        End If
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Sub ButtonSelect_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSelect.Click
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBoxPath.Text = FolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub OpenDownloaderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenDownloaderToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub DownloadFromClipboardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DownloadFromClipboardToolStripMenuItem.Click
        If Clipboard.ContainsText() Then
            TextBox.Text = Clipboard.GetText()
            StartDownload()
        Else
            MsgBox("An error occured. " + Environment.NewLine + "Details: There is no text in the clipboard. ", MsgBoxStyle.Critical, "Error!")
        End If
    End Sub

    Private Sub ExitDownloaderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitDownloaderToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
