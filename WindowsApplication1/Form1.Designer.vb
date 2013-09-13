<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.grpSysInfo = New System.Windows.Forms.GroupBox()
        Me.lblVirtualMemoryLabel = New System.Windows.Forms.Label()
        Me.lblVirtualMemory = New System.Windows.Forms.Label()
        Me.lblPlatformTypeLabel = New System.Windows.Forms.Label()
        Me.lblPlatformType = New System.Windows.Forms.Label()
        Me.lblOSNameLabel = New System.Windows.Forms.Label()
        Me.lblOSName = New System.Windows.Forms.Label()
        Me.lblOSVersionLabel = New System.Windows.Forms.Label()
        Me.lblOSVersion = New System.Windows.Forms.Label()
        Me.grpSysInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Location = New System.Drawing.Point(12, 64)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(387, 13)
        Me.lblIntro.TabIndex = 0
        Me.lblIntro.Text = "This is a simple application to tell information about your current computer/syst" & _
    "em"
        '
        'btnFetch
        '
        Me.btnFetch.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFetch.Location = New System.Drawing.Point(139, 96)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(151, 23)
        Me.btnFetch.TabIndex = 1
        Me.btnFetch.Text = "Fetch System Information"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'grpSysInfo
        '
        Me.grpSysInfo.Controls.Add(Me.lblOSVersion)
        Me.grpSysInfo.Controls.Add(Me.lblOSVersionLabel)
        Me.grpSysInfo.Controls.Add(Me.lblOSName)
        Me.grpSysInfo.Controls.Add(Me.lblOSNameLabel)
        Me.grpSysInfo.Controls.Add(Me.lblPlatformType)
        Me.grpSysInfo.Controls.Add(Me.lblPlatformTypeLabel)
        Me.grpSysInfo.Controls.Add(Me.lblVirtualMemory)
        Me.grpSysInfo.Controls.Add(Me.lblVirtualMemoryLabel)
        Me.grpSysInfo.Location = New System.Drawing.Point(13, 13)
        Me.grpSysInfo.Name = "grpSysInfo"
        Me.grpSysInfo.Size = New System.Drawing.Size(389, 141)
        Me.grpSysInfo.TabIndex = 2
        Me.grpSysInfo.TabStop = False
        Me.grpSysInfo.Text = "System Information"
        Me.grpSysInfo.Visible = False
        '
        'lblVirtualMemoryLabel
        '
        Me.lblVirtualMemoryLabel.AutoSize = True
        Me.lblVirtualMemoryLabel.Location = New System.Drawing.Point(17, 30)
        Me.lblVirtualMemoryLabel.Name = "lblVirtualMemoryLabel"
        Me.lblVirtualMemoryLabel.Size = New System.Drawing.Size(79, 13)
        Me.lblVirtualMemoryLabel.TabIndex = 0
        Me.lblVirtualMemoryLabel.Text = "Virtual Memory:"
        Me.lblVirtualMemoryLabel.Visible = False
        '
        'lblVirtualMemory
        '
        Me.lblVirtualMemory.AutoSize = True
        Me.lblVirtualMemory.Location = New System.Drawing.Point(102, 30)
        Me.lblVirtualMemory.Name = "lblVirtualMemory"
        Me.lblVirtualMemory.Size = New System.Drawing.Size(12, 13)
        Me.lblVirtualMemory.TabIndex = 1
        Me.lblVirtualMemory.Text = "x"
        Me.lblVirtualMemory.Visible = False
        '
        'lblPlatformTypeLabel
        '
        Me.lblPlatformTypeLabel.AutoSize = True
        Me.lblPlatformTypeLabel.Location = New System.Drawing.Point(17, 57)
        Me.lblPlatformTypeLabel.Name = "lblPlatformTypeLabel"
        Me.lblPlatformTypeLabel.Size = New System.Drawing.Size(75, 13)
        Me.lblPlatformTypeLabel.TabIndex = 2
        Me.lblPlatformTypeLabel.Text = "Platform Type:"
        Me.lblPlatformTypeLabel.Visible = False
        '
        'lblPlatformType
        '
        Me.lblPlatformType.AutoSize = True
        Me.lblPlatformType.Location = New System.Drawing.Point(102, 57)
        Me.lblPlatformType.Name = "lblPlatformType"
        Me.lblPlatformType.Size = New System.Drawing.Size(12, 13)
        Me.lblPlatformType.TabIndex = 3
        Me.lblPlatformType.Text = "x"
        Me.lblPlatformType.Visible = False
        '
        'lblOSNameLabel
        '
        Me.lblOSNameLabel.AutoSize = True
        Me.lblOSNameLabel.Location = New System.Drawing.Point(17, 83)
        Me.lblOSNameLabel.Name = "lblOSNameLabel"
        Me.lblOSNameLabel.Size = New System.Drawing.Size(56, 13)
        Me.lblOSNameLabel.TabIndex = 4
        Me.lblOSNameLabel.Text = "OS Name:"
        Me.lblOSNameLabel.Visible = False
        '
        'lblOSName
        '
        Me.lblOSName.AutoSize = True
        Me.lblOSName.Location = New System.Drawing.Point(102, 83)
        Me.lblOSName.Name = "lblOSName"
        Me.lblOSName.Size = New System.Drawing.Size(12, 13)
        Me.lblOSName.TabIndex = 5
        Me.lblOSName.Text = "x"
        Me.lblOSName.Visible = False
        '
        'lblOSVersionLabel
        '
        Me.lblOSVersionLabel.AutoSize = True
        Me.lblOSVersionLabel.Location = New System.Drawing.Point(17, 109)
        Me.lblOSVersionLabel.Name = "lblOSVersionLabel"
        Me.lblOSVersionLabel.Size = New System.Drawing.Size(63, 13)
        Me.lblOSVersionLabel.TabIndex = 6
        Me.lblOSVersionLabel.Text = "OS Version:"
        Me.lblOSVersionLabel.Visible = False
        '
        'lblOSVersion
        '
        Me.lblOSVersion.AutoSize = True
        Me.lblOSVersion.Location = New System.Drawing.Point(102, 109)
        Me.lblOSVersion.Name = "lblOSVersion"
        Me.lblOSVersion.Size = New System.Drawing.Size(12, 13)
        Me.lblOSVersion.TabIndex = 7
        Me.lblOSVersion.Text = "x"
        Me.lblOSVersion.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 168)
        Me.Controls.Add(Me.grpSysInfo)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.lblIntro)
        Me.Name = "Form1"
        Me.Text = "System Information Fetcher"
        Me.grpSysInfo.ResumeLayout(False)
        Me.grpSysInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntro As System.Windows.Forms.Label
    Friend WithEvents btnFetch As System.Windows.Forms.Button
    Friend WithEvents grpSysInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblVirtualMemoryLabel As System.Windows.Forms.Label
    Friend WithEvents lblOSVersion As System.Windows.Forms.Label
    Friend WithEvents lblOSVersionLabel As System.Windows.Forms.Label
    Friend WithEvents lblOSName As System.Windows.Forms.Label
    Friend WithEvents lblOSNameLabel As System.Windows.Forms.Label
    Friend WithEvents lblPlatformType As System.Windows.Forms.Label
    Friend WithEvents lblPlatformTypeLabel As System.Windows.Forms.Label
    Friend WithEvents lblVirtualMemory As System.Windows.Forms.Label

End Class
