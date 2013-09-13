' System Information Grabber
' A simple program developed
' by George Barnick
' 12 September 2013

Public Class Form1

    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        lblIntro.Hide()
        btnFetch.Hide()
        grpSysInfo.Visible = True
        lblVirtualMemoryLabel.Visible = True
        lblVirtualMemory.Visible = True
        lblPlatformTypeLabel.Visible = True
        lblPlatformType.Visible = True
        lblOSNameLabel.Visible = True
        lblOSName.Visible = True
        lblOSVersionLabel.Visible = True
        lblOSVersion.Visible = True
        lblVirtualMemory.Text = (My.Computer.Info.TotalVirtualMemory \ 1024) \ 1024 & " GB"
        lblPlatformType.Text = My.Computer.Info.OSPlatform
        lblOSName.Text = My.Computer.Info.OSFullName
        lblOSVersion.Text = My.Computer.Info.OSVersion
    End Sub
End Class
