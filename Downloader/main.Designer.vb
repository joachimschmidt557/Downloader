<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.GroupBoxDetails = New System.Windows.Forms.GroupBox()
        Me.BytesLabel = New System.Windows.Forms.Label()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenDownloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadFromClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitDownloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestinationFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBoxDetails.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(141, 38)
        Me.ProgressBar.MarqueeAnimationSpeed = 10
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(356, 56)
        Me.ProgressBar.TabIndex = 0
        '
        'DownloadButton
        '
        Me.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DownloadButton.Location = New System.Drawing.Point(12, 38)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(123, 56)
        Me.DownloadButton.TabIndex = 1
        Me.DownloadButton.Text = "Download"
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(12, 12)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(485, 20)
        Me.TextBox.TabIndex = 2
        '
        'ButtonSettings
        '
        Me.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonSettings.Location = New System.Drawing.Point(141, 100)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(356, 23)
        Me.ButtonSettings.TabIndex = 3
        Me.ButtonSettings.Text = "Settings"
        Me.ButtonSettings.UseVisualStyleBackColor = True
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Location = New System.Drawing.Point(98, 129)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxPath.TabIndex = 4
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(12, 129)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(86, 13)
        Me.Label.TabIndex = 5
        Me.Label.Text = "Download Path: "
        '
        'ButtonNew
        '
        Me.ButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonNew.Location = New System.Drawing.Point(12, 100)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(123, 23)
        Me.ButtonNew.TabIndex = 6
        Me.ButtonNew.Text = "New Downloader"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'GroupBoxDetails
        '
        Me.GroupBoxDetails.Controls.Add(Me.BytesLabel)
        Me.GroupBoxDetails.Location = New System.Drawing.Point(12, 156)
        Me.GroupBoxDetails.Name = "GroupBoxDetails"
        Me.GroupBoxDetails.Size = New System.Drawing.Size(484, 50)
        Me.GroupBoxDetails.TabIndex = 7
        Me.GroupBoxDetails.TabStop = False
        Me.GroupBoxDetails.Text = "Details"
        '
        'BytesLabel
        '
        Me.BytesLabel.AutoSize = True
        Me.BytesLabel.Location = New System.Drawing.Point(10, 21)
        Me.BytesLabel.Name = "BytesLabel"
        Me.BytesLabel.Size = New System.Drawing.Size(33, 13)
        Me.BytesLabel.TabIndex = 0
        Me.BytesLabel.Text = "Bytes"
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Location = New System.Drawing.Point(409, 129)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(87, 23)
        Me.ButtonSelect.TabIndex = 8
        Me.ButtonSelect.Text = "Select"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.Description = "Select a download location"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuStrip
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Downloader"
        Me.NotifyIcon.Visible = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDownloaderToolStripMenuItem, Me.DownloadFromClipboardToolStripMenuItem, Me.ExitDownloaderToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(213, 70)
        '
        'OpenDownloaderToolStripMenuItem
        '
        Me.OpenDownloaderToolStripMenuItem.Name = "OpenDownloaderToolStripMenuItem"
        Me.OpenDownloaderToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.OpenDownloaderToolStripMenuItem.Text = "Open Downloader"
        '
        'DownloadFromClipboardToolStripMenuItem
        '
        Me.DownloadFromClipboardToolStripMenuItem.Name = "DownloadFromClipboardToolStripMenuItem"
        Me.DownloadFromClipboardToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DownloadFromClipboardToolStripMenuItem.Text = "Download from Clipboard"
        '
        'ExitDownloaderToolStripMenuItem
        '
        Me.ExitDownloaderToolStripMenuItem.Name = "ExitDownloaderToolStripMenuItem"
        Me.ExitDownloaderToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ExitDownloaderToolStripMenuItem.Text = "Exit Downloader"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 218)
        Me.Controls.Add(Me.ButtonSelect)
        Me.Controls.Add(Me.GroupBoxDetails)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.TextBoxPath)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.ProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Downloader"
        Me.GroupBoxDetails.ResumeLayout(False)
        Me.GroupBoxDetails.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents DownloadButton As System.Windows.Forms.Button
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSettings As System.Windows.Forms.Button
    Friend WithEvents TextBoxPath As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents ButtonNew As System.Windows.Forms.Button
    Friend WithEvents GroupBoxDetails As System.Windows.Forms.GroupBox
    Friend WithEvents BytesLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonSelect As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenDownloaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadFromClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitDownloaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestinationFileDialog As SaveFileDialog
End Class
