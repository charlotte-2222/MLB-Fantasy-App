<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTeam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTeam))
        Me.lstTeam = New System.Windows.Forms.ListBox()
        Me.picRedSex = New System.Windows.Forms.PictureBox()
        Me.playerName = New System.Windows.Forms.Label()
        Me.playerLeague = New System.Windows.Forms.Label()
        Me.btnEditRoster = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picRedSex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTeam
        '
        Me.lstTeam.FormattingEnabled = True
        Me.lstTeam.Location = New System.Drawing.Point(297, 59)
        Me.lstTeam.Name = "lstTeam"
        Me.lstTeam.Size = New System.Drawing.Size(210, 446)
        Me.lstTeam.TabIndex = 2
        '
        'picRedSex
        '
        Me.picRedSex.Image = CType(resources.GetObject("picRedSex.Image"), System.Drawing.Image)
        Me.picRedSex.Location = New System.Drawing.Point(25, 386)
        Me.picRedSex.Name = "picRedSex"
        Me.picRedSex.Size = New System.Drawing.Size(210, 119)
        Me.picRedSex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRedSex.TabIndex = 37
        Me.picRedSex.TabStop = False
        '
        'playerName
        '
        Me.playerName.AutoSize = True
        Me.playerName.BackColor = System.Drawing.Color.Transparent
        Me.playerName.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerName.ForeColor = System.Drawing.Color.White
        Me.playerName.Location = New System.Drawing.Point(12, 59)
        Me.playerName.Name = "playerName"
        Me.playerName.Size = New System.Drawing.Size(134, 34)
        Me.playerName.TabIndex = 38
        Me.playerName.Text = "PROCESS"
        '
        'playerLeague
        '
        Me.playerLeague.AutoSize = True
        Me.playerLeague.BackColor = System.Drawing.Color.Transparent
        Me.playerLeague.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerLeague.ForeColor = System.Drawing.Color.White
        Me.playerLeague.Location = New System.Drawing.Point(12, 6)
        Me.playerLeague.Name = "playerLeague"
        Me.playerLeague.Size = New System.Drawing.Size(244, 34)
        Me.playerLeague.TabIndex = 39
        Me.playerLeague.Text = "LEAGUE_PROCESS"
        '
        'btnEditRoster
        '
        Me.btnEditRoster.BackColor = System.Drawing.Color.White
        Me.btnEditRoster.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnEditRoster.FlatAppearance.BorderSize = 2
        Me.btnEditRoster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnEditRoster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnEditRoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditRoster.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRoster.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEditRoster.Location = New System.Drawing.Point(27, 314)
        Me.btnEditRoster.Name = "btnEditRoster"
        Me.btnEditRoster.Size = New System.Drawing.Size(202, 40)
        Me.btnEditRoster.TabIndex = 41
        Me.btnEditRoster.Text = "Edit Roster"
        Me.btnEditRoster.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(421, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'FrmTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(526, 522)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEditRoster)
        Me.Controls.Add(Me.playerLeague)
        Me.Controls.Add(Me.playerName)
        Me.Controls.Add(Me.picRedSex)
        Me.Controls.Add(Me.lstTeam)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTeam"
        Me.Text = "Team View"
        CType(Me.picRedSex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstTeam As ListBox
    Friend WithEvents picRedSex As PictureBox
    Friend WithEvents playerName As Label
    Friend WithEvents playerLeague As Label
    Friend WithEvents btnEditRoster As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
