Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net.Mail

'Zachary Childers CPT-206-A01S
'Final Project 
'MLB-Roster-Creator
'864-680-4022

Public Class FrmMenu
    Private Sub btnYourTeam_Click(sender As Object, e As EventArgs) Handles btnYourTeam.Click
        If Not FrmMain.WindowState = 0 Then
            FrmTeam.Show()
        End If
        If FrmMain.WindowState = 0 Then
            MessageBox.Show("Please finish filling your roster, then hit the 'Close Player Select' button", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnVwTeams_Click(sender As Object, e As EventArgs) Handles btnVwTeams.Click
        FrmMain.Show()
        If FrmMain.WindowState = 1 Then
            FrmMain.WindowState = 0
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Thanks for playing in the league!",
                        "Goodbye!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
        Application.Exit()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' lblTime.Text = DateTime.Now.ToString("h:mm:s tt,") '<-- Clock to label
        lblLgDate.Text = DateTime.Now.ToString("F")
    End Sub



    Private Sub btnPrintText_Click(sender As Object, e As EventArgs) Handles btnPrintText.Click
        Try
            Dim Path As String
            Path = CreateObject("WScript.Shell").SpecialFolders("Desktop") & "\"

            Dim userName = txtName.Text
            Dim teamName = txtTeamName.Text

            If txtName.Text = "" Or txtTeamName.Text = "" Then
                userName = "UnknownManager"
                teamName = "SCC All-Stars"
            Else
                userName = txtName.Text
                teamName = txtTeamName.Text
            End If


            If FrmMain.lstFantasy.Items.Count() > 0 Then
                Using sr As StreamWriter = IO.File.CreateText(Path & $"{userName.Trim()}_{teamName.Trim()}.txt")
                    sr.WriteLine("SCC Fantasy League 2021")
                    sr.WriteLine($"Team: " + teamName.ToString())
                    sr.WriteLine($"Manager: " + userName.ToString())
                    sr.WriteLine("----------------------------")
                    For Each S As String In FrmMain.lstFantasy.Items
                        sr.WriteLine(S)
                    Next
                    MessageBox.Show("Succesfully converted your roster to a text file! We saved it to your desktop.",
                                    "Saved!",
                                    MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                End Using

            Else
                If FrmMain.lstFantasy.Items.Count = 0 Then
                    MessageBox.Show("Not able to write to file. Make sure your roster has players.",
                            "ERROR!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                End If
            End If
        Catch
            MessageBox.Show("Not able to write to file. Make sure your roster has players.",
                            "ERROR!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub
End Class