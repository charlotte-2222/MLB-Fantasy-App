Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Public Class FrmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MLBAllPlayersDataSet.MLBEastPlayers' table. You can move, or remove it, as needed.
        Me.MLBEastPlayersTableAdapter.Fill(Me.MLBAllPlayersDataSet.MLBEastPlayers)
        'TODO: This line of code loads data into the 'MLBPlayersDataSet.WashingtonNationals' table. You can move, or remove it, as needed.
        txtTeamNameMain.Text = FrmMenu.txtTeamName.Text
        If FrmMenu.txtTeamName.Text = "" Then
            txtTeamNameMain.Text = "SCC All-Stars"
        End If
    End Sub


    Private Sub btnClosePlayerSelect_Click(sender As Object, e As EventArgs) Handles btnClosePlayerSelect.Click
        Me.WindowState = 1
    End Sub

    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click
        Dim selectItem = comsNames1.Text
        Try
            If Not (lstFantasy.Items.Contains(selectItem)) Then
                If Not lstFantasy.Items.Count = 26 Then
                    lstFantasy.Items.Add(selectItem.ToString())
                    If lstFantasy.Items.Count = 26 Then
                        lblNameCount.Text = "FULL!"
                    ElseIf lstFantasy.Items.Count = 0 Then
                        lblNameCount.Text = "empty...."
                    End If
                Else
                    MessageBox.Show("You can only have 26 players on your roster!")
                End If
            Else
                MessageBox.Show("You cannot have duplicate players!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error in running program")

        End Try


    End Sub

    Private Sub MLBEastPlayersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MLBEastPlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MLBAllPlayersDataSet)
    End Sub

    Private Sub btnRemovePlayer_Click(sender As Object, e As EventArgs) Handles btnRemovePlayer.Click
        Try
            lstFantasy.Items.RemoveAt(lstFantasy.SelectedIndex)
        Catch ex As Exception
            MessageBox.Show("Must highlight a player in your roster to remove them!")
        End Try
    End Sub

    Private Sub MLBEastPlayersDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles MLBEastPlayersDataGridView.SelectionChanged
        If (comsTeam.Text = "NY Mets") Then
            picYankees.Visible = False
            picMets.Visible = True
            picPhilly.Visible = False
            picRedSex.Visible = False
            picRays.Visible = False
            picBraves.Visible = False
            picMarlins.Visible = False
        ElseIf (comsTeam.Text = "Philadelphia Phillies") Then
            picYankees.Visible = False
            picMets.Visible = False
            picPhilly.Visible = True
            picRedSex.Visible = False
            picRays.Visible = False
            picBraves.Visible = False
            picMarlins.Visible = False
        ElseIf (comsTeam.Text = "Miami Marlins") Then
            picYankees.Visible = False
            picMets.Visible = False
            picPhilly.Visible = False
            picRedSex.Visible = False
            picRays.Visible = False
            picMarlins.Visible = True
            picBraves.Visible = False
        ElseIf (comsTeam.Text = "Boston RedSox") Then
            picYankees.Visible = False
            picMets.Visible = False
            picPhilly.Visible = False
            picRedSex.Visible = True
            picRays.Visible = False
            picMarlins.Visible = False
            picBraves.Visible = False
        ElseIf (comsTeam.Text = "Tampa Bay Rays") Then
            picYankees.Visible = False
            picMets.Visible = False
            picPhilly.Visible = False
            picRedSex.Visible = False
            picRays.Visible = True
            picMarlins.Visible = False
            picBraves.Visible = False
        ElseIf (comsTeam.Text = "NY Yankees") Then
            picYankees.Visible = True
            picMets.Visible = False
            picPhilly.Visible = False
            picRedSex.Visible = False
            picRays.Visible = False
            picMarlins.Visible = False
            picBraves.Visible = False
        ElseIf (comsTeam.Text = "Atlanta Braves") Then
            picYankees.Visible = False
            picMets.Visible = False
            picPhilly.Visible = False
            picRedSex.Visible = False
            picRays.Visible = False
            picMarlins.Visible = False
            picBraves.Visible = True
        End If

        If (comsTeam.Text = "Atlanta Braves") Then
            rb.Text = "Record: 10-12, 3rd place in NL_East (Schedule and Results)

Playoff Odds: 52.4% to make postseason, 5.2% to win World Series

Manager: Brian Snitker (10-12)

General Manager: Alex Anthopoulos (President, Baseball Ops & GM)

Farm Director: Ben Sestanovich

Scouting Director: Dana Brown

Ballpark: Truist Park

Attendance: 148,949 (5th of 15)

Park Factors: (Over 100 favors batters, under 100 favors pitchers.)
    Multi-year: Batting - 110, Pitching - 108
    One-year: Batting - 109, Pitching - 109

Pythagorean W-L: 10-12, 99 Runs, 110 Runs Allowed "
        ElseIf (comsTeam.Text = "NY Yankees") Then
            rb.Text = " Record: 9-13, 5th place in AL_East (Schedule and Results)

Playoff Odds: 63.3% to make postseason, 6.4% to win World Series

Manager: Aaron Boone (9-13)

General Manager: Brian Cashman (Senior VP & GM)

Farm Director: Kevin Reese

Scouting Director: Damon Oppenheimer

Ballpark: Yankee Stadium III

Attendance: 110,731 (4th of 15)

Park Factors: (Over 100 favors batters, under 100 favors pitchers.)
    Multi-year: Batting - 97, Pitching - 95
    One-year: Batting - 93, Pitching - 94

Pythagorean W-L: 10-12, 77 Runs, 87 Runs Allowed"
        ElseIf (comsTeam.Text = "Tampa Bay Rays") Then
            rb.Text = " Record: 11-12, 2nd place in AL_East (Schedule and Results)

Playoff Odds: 67.3% to make postseason, 7.0% to win World Series

Manager: Kevin Cash (11-12)

General Manager: Erik Neander (Senior VP, Baseball Ops & GM)

Farm Director: Jeff McLerran

Scouting Director: Rob Metzler

Ballpark: Tropicana Field

Attendance: 59,479 (14th of 15)

Park Factors: (Over 100 favors batters, under 100 favors pitchers.)
    Multi-year: Batting - 93, Pitching - 92
    One-year: Batting - 83, Pitching - 83

Pythagorean W-L: 11-12, 103 Runs, 109 Runs Allowed "
        ElseIf (comsTeam.Text = "Boston RedSox") Then
            rb.Text = " Record: 14-9, 1st place in AL_East (Schedule and Results)

Playoff Odds: 18.1% to make postseason, 0.8% to win World Series

Manager: Alex Cora (14-9)

General Manager: Brian O'Halloran

Farm Director: Brian Abraham

Scouting Director: Mike Rikard

Ballpark: Fenway Park

Attendance: 73,960 (12th of 15)

Park Factors: (Over 100 favors batters, under 100 favors pitchers.)
    Multi-year: Batting - 104, Pitching - 105
    One-year: Batting - 97, Pitching - 94

Pythagorean W-L: 13-10, 119 Runs, 99 Runs Allowed "
        ElseIf (comsTeam.Text = "Philadelphia Phillies") Then
            rb.Text = " Record: 14-9, 1st place in AL_East (Schedule and Results)

Playoff Odds: 18.1% to make postseason, 0.8% to win World Series

Manager: Alex Cora (14-9)

General Manager: Brian O'Halloran

Farm Director: Brian Abraham

Scouting Director: Mike Rikard

Ballpark: Fenway Park

Attendance: 73,960 (12th of 15)

Park Factors: (Over 100 favors batters, under 100 favors pitchers.)
    Multi-year: Batting - 104, Pitching - 105
    One-year: Batting - 97, Pitching - 94

Pythagorean W-L: 13-10, 119 Runs, 99 Runs Allowed "
        ElseIf (comsTeam.Text = "Miami Marlins") Then
            rb.Text = "Record: 10-12, 3rd place in NL_East (Schedule and Results)

Playoff Odds: 8.9% to make postseason, 0.4% to win World Series

Manager: Don Mattingly (10-12)

President: Derek Jeter (CEO)

General Manager: Kim Ng

Farm Director: Gary Denbo (Vice President, Player Development and Scouting)

Ballpark: loanDepot park

Attendance: 60,632 (13th of 15)

Park Factors: (Over 100 favors batters, under 100 favors pitchers.)
    Multi-year: Batting - 99, Pitching - 100
    One-year: Batting - 87, Pitching - 88

Pythagorean W-L: 12-10, 93 Runs, 84 Runs Allowed "
        ElseIf (comsTeam.Text = "NY Mets") Then
            rb.Text = "Record: 9-8, 1st place in NL_East (Schedule and Results)

Playoff Odds: 25.9% to make postseason, 1.3% to win World Series

Manager: Luis Rojas (9-8)

General Manager: Zack Scott (Acting GM)

Farm Director: Kevin Howard

Scouting Director: Marc Tramuta

Ballpark: Citi Field

Attendance: 56,007 (11th of 15)

Park Factors: (Over 100 favors batters, under 100 favors pitchers.)
    Multi-year: Batting - 95, Pitching - 95
    One-year: Batting - 82, Pitching - 82

Pythagorean W-L: 7-10, 56 Runs, 67 Runs Allowed"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("h:mm:stt") '<-- Clock to label
    End Sub

    Private Sub btnClrRoster_Click(sender As Object, e As EventArgs) Handles btnClrRoster.Click
        lstFantasy.Items.Clear()
        FrmTeam.lstTeam.Items.Clear()
    End Sub

End Class
