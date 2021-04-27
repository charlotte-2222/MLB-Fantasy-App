<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCT = New System.Windows.Forms.Label()
        Me.btnPrintText = New System.Windows.Forms.Button()
        Me.btnYourTeam = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnVwTeams = New System.Windows.Forms.Button()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLgDate = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(561, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(522, 330)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'lblCT
        '
        Me.lblCT.AutoSize = True
        Me.lblCT.BackColor = System.Drawing.Color.Transparent
        Me.lblCT.Font = New System.Drawing.Font("Franklin Gothic Heavy", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCT.ForeColor = System.Drawing.Color.White
        Me.lblCT.Location = New System.Drawing.Point(29, 584)
        Me.lblCT.Name = "lblCT"
        Me.lblCT.Size = New System.Drawing.Size(270, 47)
        Me.lblCT.TabIndex = 15
        Me.lblCT.Text = "Current Time:"
        '
        'btnPrintText
        '
        Me.btnPrintText.BackColor = System.Drawing.Color.White
        Me.btnPrintText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnPrintText.FlatAppearance.BorderSize = 2
        Me.btnPrintText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnPrintText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnPrintText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintText.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnPrintText.Location = New System.Drawing.Point(569, 525)
        Me.btnPrintText.Name = "btnPrintText"
        Me.btnPrintText.Size = New System.Drawing.Size(219, 40)
        Me.btnPrintText.TabIndex = 14
        Me.btnPrintText.Text = "Print Team to Text File" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnPrintText.UseVisualStyleBackColor = False
        '
        'btnYourTeam
        '
        Me.btnYourTeam.BackColor = System.Drawing.Color.White
        Me.btnYourTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnYourTeam.FlatAppearance.BorderSize = 2
        Me.btnYourTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnYourTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnYourTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYourTeam.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYourTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnYourTeam.Location = New System.Drawing.Point(364, 525)
        Me.btnYourTeam.Name = "btnYourTeam"
        Me.btnYourTeam.Size = New System.Drawing.Size(167, 40)
        Me.btnYourTeam.TabIndex = 13
        Me.btnYourTeam.Text = "Your Team"
        Me.btnYourTeam.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(826, 525)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 40)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnVwTeams
        '
        Me.btnVwTeams.BackColor = System.Drawing.Color.White
        Me.btnVwTeams.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnVwTeams.FlatAppearance.BorderSize = 2
        Me.btnVwTeams.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnVwTeams.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnVwTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVwTeams.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVwTeams.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnVwTeams.Location = New System.Drawing.Point(159, 525)
        Me.btnVwTeams.Name = "btnVwTeams"
        Me.btnVwTeams.Size = New System.Drawing.Size(167, 40)
        Me.btnVwTeams.TabIndex = 11
        Me.btnVwTeams.Text = "Build Roster"
        Me.btnVwTeams.UseVisualStyleBackColor = False
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.BackColor = System.Drawing.Color.Transparent
        Me.lblLogo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(12, 9)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(903, 47)
        Me.lblLogo.TabIndex = 10
        Me.lblLogo.Text = "Major League Baseball Fantasy League Creator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(471, 302)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 404)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 30)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Your Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(205, 408)
        Me.txtName.MaxLength = 20
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(128, 24)
        Me.txtName.TabIndex = 19
        '
        'txtTeamName
        '
        Me.txtTeamName.Font = New System.Drawing.Font("Segoe UI", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamName.Location = New System.Drawing.Point(304, 453)
        Me.txtTeamName.MaxLength = 20
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(184, 24)
        Me.txtTeamName.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(58, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 30)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Fantasy Team Name:"
        '
        'lblLgDate
        '
        Me.lblLgDate.AutoSize = True
        Me.lblLgDate.BackColor = System.Drawing.Color.Transparent
        Me.lblLgDate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLgDate.ForeColor = System.Drawing.Color.White
        Me.lblLgDate.Location = New System.Drawing.Point(306, 584)
        Me.lblLgDate.Name = "lblLgDate"
        Me.lblLgDate.Size = New System.Drawing.Size(248, 47)
        Me.lblLgDate.TabIndex = 22
        Me.lblLgDate.Text = "------date-------"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1106, 652)
        Me.Controls.Add(Me.lblLgDate)
        Me.Controls.Add(Me.txtTeamName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCT)
        Me.Controls.Add(Me.btnPrintText)
        Me.Controls.Add(Me.btnYourTeam)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnVwTeams)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents lblCT As Label
    Friend WithEvents btnPrintText As Button
    Friend WithEvents btnYourTeam As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnVwTeams As Button
    Friend WithEvents lblLogo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtTeamName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLgDate As Label
End Class
