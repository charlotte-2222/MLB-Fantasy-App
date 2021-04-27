Public Class FrmTeam

    Private Sub FrmTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim shit = FrmMain.lstFantasy.Items
        lstTeam.Items.AddRange(shit)
        playerName.Text = FrmMenu.txtName.Text
        If FrmMenu.txtName.Text = "" Then
            playerName.Text = "Unknown Manager"
        End If
        playerLeague.Text = FrmMenu.txtTeamName.Text
        If FrmMenu.txtTeamName.Text = "" Then
            playerLeague.Text = "SCC All-Stars"
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditRoster.Click
        Me.Close()
        If FrmMain.WindowState = 1 Then
            FrmMain.WindowState = 0
        Else
            FrmMain.Show()
        End If
    End Sub

    Private Sub btnCloseRosterView_Click(sender As Object, e As EventArgs)
        Me.WindowState = 1
    End Sub
End Class