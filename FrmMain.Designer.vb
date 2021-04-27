<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lstFantasy = New System.Windows.Forms.ListBox()
        Me.lblRost = New System.Windows.Forms.Label()
        Me.lblNameCount = New System.Windows.Forms.Label()
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.btnClosePlayerSelect = New System.Windows.Forms.Button()
        Me.btnRemovePlayer = New System.Windows.Forms.Button()
        Me.comsNames1 = New System.Windows.Forms.ComboBox()
        Me.MLBEastPlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MLBAllPlayersDataSet = New ZachChilders_CPT_206_A01_S_FinalProject.MLBAllPlayersDataSet()
        Me.MLBEastPlayersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picMets = New System.Windows.Forms.PictureBox()
        Me.picBraves = New System.Windows.Forms.PictureBox()
        Me.picPhilly = New System.Windows.Forms.PictureBox()
        Me.picRays = New System.Windows.Forms.PictureBox()
        Me.picMarlins = New System.Windows.Forms.PictureBox()
        Me.picYankees = New System.Windows.Forms.PictureBox()
        Me.picRedSex = New System.Windows.Forms.PictureBox()
        Me.comsTeam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblCT = New System.Windows.Forms.Label()
        Me.btnClrRoster = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTeamNameMain = New System.Windows.Forms.Label()
        Me.MLBEastPlayersTableAdapter = New ZachChilders_CPT_206_A01_S_FinalProject.MLBAllPlayersDataSetTableAdapters.MLBEastPlayersTableAdapter()
        Me.TableAdapterManager = New ZachChilders_CPT_206_A01_S_FinalProject.MLBAllPlayersDataSetTableAdapters.TableAdapterManager()
        Me.rb = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.MLBEastPlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MLBAllPlayersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MLBEastPlayersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBraves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhilly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMarlins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYankees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRedSex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstFantasy
        '
        Me.lstFantasy.FormattingEnabled = True
        Me.lstFantasy.Location = New System.Drawing.Point(871, 163)
        Me.lstFantasy.Name = "lstFantasy"
        Me.lstFantasy.Size = New System.Drawing.Size(210, 446)
        Me.lstFantasy.TabIndex = 1
        '
        'lblRost
        '
        Me.lblRost.AutoSize = True
        Me.lblRost.BackColor = System.Drawing.Color.Transparent
        Me.lblRost.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRost.ForeColor = System.Drawing.Color.White
        Me.lblRost.Location = New System.Drawing.Point(866, 126)
        Me.lblRost.Name = "lblRost"
        Me.lblRost.Size = New System.Drawing.Size(107, 34)
        Me.lblRost.TabIndex = 17
        Me.lblRost.Text = "Roster:"
        '
        'lblNameCount
        '
        Me.lblNameCount.AutoSize = True
        Me.lblNameCount.BackColor = System.Drawing.Color.Transparent
        Me.lblNameCount.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameCount.ForeColor = System.Drawing.Color.White
        Me.lblNameCount.Location = New System.Drawing.Point(966, 127)
        Me.lblNameCount.Name = "lblNameCount"
        Me.lblNameCount.Size = New System.Drawing.Size(121, 34)
        Me.lblNameCount.TabIndex = 18
        Me.lblNameCount.Text = "empty...."
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.BackColor = System.Drawing.Color.White
        Me.btnAddPlayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnAddPlayer.FlatAppearance.BorderSize = 2
        Me.btnAddPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnAddPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPlayer.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlayer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAddPlayer.Location = New System.Drawing.Point(420, 232)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(167, 40)
        Me.btnAddPlayer.TabIndex = 19
        Me.btnAddPlayer.Text = "Add Player"
        Me.btnAddPlayer.UseVisualStyleBackColor = False
        '
        'btnClosePlayerSelect
        '
        Me.btnClosePlayerSelect.BackColor = System.Drawing.Color.White
        Me.btnClosePlayerSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnClosePlayerSelect.FlatAppearance.BorderSize = 2
        Me.btnClosePlayerSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnClosePlayerSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnClosePlayerSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClosePlayerSelect.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClosePlayerSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClosePlayerSelect.Location = New System.Drawing.Point(656, 541)
        Me.btnClosePlayerSelect.Name = "btnClosePlayerSelect"
        Me.btnClosePlayerSelect.Size = New System.Drawing.Size(202, 40)
        Me.btnClosePlayerSelect.TabIndex = 20
        Me.btnClosePlayerSelect.Text = "Close Player Select"
        Me.btnClosePlayerSelect.UseVisualStyleBackColor = False
        '
        'btnRemovePlayer
        '
        Me.btnRemovePlayer.BackColor = System.Drawing.Color.White
        Me.btnRemovePlayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnRemovePlayer.FlatAppearance.BorderSize = 2
        Me.btnRemovePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnRemovePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnRemovePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemovePlayer.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovePlayer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnRemovePlayer.Location = New System.Drawing.Point(643, 232)
        Me.btnRemovePlayer.Name = "btnRemovePlayer"
        Me.btnRemovePlayer.Size = New System.Drawing.Size(167, 40)
        Me.btnRemovePlayer.TabIndex = 21
        Me.btnRemovePlayer.Text = "Remove Player"
        Me.btnRemovePlayer.UseVisualStyleBackColor = False
        '
        'comsNames1
        '
        Me.comsNames1.BackColor = System.Drawing.Color.White
        Me.comsNames1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MLBEastPlayersBindingSource, "Player Names", True))
        Me.comsNames1.ForeColor = System.Drawing.Color.Black
        Me.comsNames1.FormattingEnabled = True
        Me.comsNames1.Location = New System.Drawing.Point(444, 180)
        Me.comsNames1.Name = "comsNames1"
        Me.comsNames1.Size = New System.Drawing.Size(123, 21)
        Me.comsNames1.TabIndex = 27
        '
        'MLBEastPlayersBindingSource
        '
        Me.MLBEastPlayersBindingSource.DataMember = "MLBEastPlayers"
        Me.MLBEastPlayersBindingSource.DataSource = Me.MLBAllPlayersDataSet
        '
        'MLBAllPlayersDataSet
        '
        Me.MLBAllPlayersDataSet.DataSetName = "MLBAllPlayersDataSet"
        Me.MLBAllPlayersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MLBEastPlayersDataGridView
        '
        Me.MLBEastPlayersDataGridView.AllowUserToAddRows = False
        Me.MLBEastPlayersDataGridView.AllowUserToDeleteRows = False
        Me.MLBEastPlayersDataGridView.AutoGenerateColumns = False
        Me.MLBEastPlayersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.MLBEastPlayersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.MLBEastPlayersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MLBEastPlayersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.MLBEastPlayersDataGridView.DataSource = Me.MLBEastPlayersBindingSource
        Me.MLBEastPlayersDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MLBEastPlayersDataGridView.Location = New System.Drawing.Point(10, 46)
        Me.MLBEastPlayersDataGridView.Name = "MLBEastPlayersDataGridView"
        Me.MLBEastPlayersDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MLBEastPlayersDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MLBEastPlayersDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.MLBEastPlayersDataGridView.Size = New System.Drawing.Size(356, 566)
        Me.MLBEastPlayersDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Player Names"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Player Names"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Team Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Team Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(421, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Selected Player:"
        '
        'picMets
        '
        Me.picMets.Image = CType(resources.GetObject("picMets.Image"), System.Drawing.Image)
        Me.picMets.Location = New System.Drawing.Point(504, 11)
        Me.picMets.Name = "picMets"
        Me.picMets.Size = New System.Drawing.Size(182, 124)
        Me.picMets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMets.TabIndex = 30
        Me.picMets.TabStop = False
        Me.picMets.Visible = False
        '
        'picBraves
        '
        Me.picBraves.Image = CType(resources.GetObject("picBraves.Image"), System.Drawing.Image)
        Me.picBraves.Location = New System.Drawing.Point(504, 11)
        Me.picBraves.Name = "picBraves"
        Me.picBraves.Size = New System.Drawing.Size(182, 124)
        Me.picBraves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBraves.TabIndex = 31
        Me.picBraves.TabStop = False
        Me.picBraves.Visible = False
        '
        'picPhilly
        '
        Me.picPhilly.Image = CType(resources.GetObject("picPhilly.Image"), System.Drawing.Image)
        Me.picPhilly.Location = New System.Drawing.Point(504, 11)
        Me.picPhilly.Name = "picPhilly"
        Me.picPhilly.Size = New System.Drawing.Size(182, 124)
        Me.picPhilly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPhilly.TabIndex = 32
        Me.picPhilly.TabStop = False
        Me.picPhilly.Visible = False
        '
        'picRays
        '
        Me.picRays.Image = CType(resources.GetObject("picRays.Image"), System.Drawing.Image)
        Me.picRays.Location = New System.Drawing.Point(504, 11)
        Me.picRays.Name = "picRays"
        Me.picRays.Size = New System.Drawing.Size(182, 124)
        Me.picRays.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRays.TabIndex = 33
        Me.picRays.TabStop = False
        Me.picRays.Visible = False
        '
        'picMarlins
        '
        Me.picMarlins.Image = CType(resources.GetObject("picMarlins.Image"), System.Drawing.Image)
        Me.picMarlins.Location = New System.Drawing.Point(504, 11)
        Me.picMarlins.Name = "picMarlins"
        Me.picMarlins.Size = New System.Drawing.Size(182, 124)
        Me.picMarlins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMarlins.TabIndex = 34
        Me.picMarlins.TabStop = False
        Me.picMarlins.Visible = False
        '
        'picYankees
        '
        Me.picYankees.Image = CType(resources.GetObject("picYankees.Image"), System.Drawing.Image)
        Me.picYankees.Location = New System.Drawing.Point(504, 11)
        Me.picYankees.Name = "picYankees"
        Me.picYankees.Size = New System.Drawing.Size(182, 124)
        Me.picYankees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYankees.TabIndex = 35
        Me.picYankees.TabStop = False
        Me.picYankees.Visible = False
        '
        'picRedSex
        '
        Me.picRedSex.Image = CType(resources.GetObject("picRedSex.Image"), System.Drawing.Image)
        Me.picRedSex.Location = New System.Drawing.Point(504, 11)
        Me.picRedSex.Name = "picRedSex"
        Me.picRedSex.Size = New System.Drawing.Size(182, 124)
        Me.picRedSex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRedSex.TabIndex = 36
        Me.picRedSex.TabStop = False
        Me.picRedSex.Visible = False
        '
        'comsTeam
        '
        Me.comsTeam.BackColor = System.Drawing.Color.White
        Me.comsTeam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MLBEastPlayersBindingSource, "Team Name", True))
        Me.comsTeam.ForeColor = System.Drawing.Color.Black
        Me.comsTeam.FormattingEnabled = True
        Me.comsTeam.Location = New System.Drawing.Point(651, 180)
        Me.comsTeam.Name = "comsTeam"
        Me.comsTeam.Size = New System.Drawing.Size(123, 21)
        Me.comsTeam.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(638, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 25)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Selected Team:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 34)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Select your team:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Franklin Gothic Heavy", 25.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(657, 584)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(88, 39)
        Me.lblTime.TabIndex = 41
        Me.lblTime.Text = "time"
        '
        'lblCT
        '
        Me.lblCT.AutoSize = True
        Me.lblCT.BackColor = System.Drawing.Color.Transparent
        Me.lblCT.Font = New System.Drawing.Font("Franklin Gothic Heavy", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCT.ForeColor = System.Drawing.Color.White
        Me.lblCT.Location = New System.Drawing.Point(395, 579)
        Me.lblCT.Name = "lblCT"
        Me.lblCT.Size = New System.Drawing.Size(270, 47)
        Me.lblCT.TabIndex = 40
        Me.lblCT.Text = "Current Time:"
        '
        'btnClrRoster
        '
        Me.btnClrRoster.BackColor = System.Drawing.Color.White
        Me.btnClrRoster.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnClrRoster.FlatAppearance.BorderSize = 2
        Me.btnClrRoster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnClrRoster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnClrRoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClrRoster.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrRoster.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClrRoster.Location = New System.Drawing.Point(379, 541)
        Me.btnClrRoster.Name = "btnClrRoster"
        Me.btnClrRoster.Size = New System.Drawing.Size(202, 40)
        Me.btnClrRoster.TabIndex = 42
        Me.btnClrRoster.Text = "Clear Entire Roster"
        Me.btnClrRoster.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(748, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 34)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Team name:"
        '
        'txtTeamNameMain
        '
        Me.txtTeamNameMain.AutoSize = True
        Me.txtTeamNameMain.BackColor = System.Drawing.Color.Transparent
        Me.txtTeamNameMain.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamNameMain.ForeColor = System.Drawing.Color.White
        Me.txtTeamNameMain.Location = New System.Drawing.Point(745, 47)
        Me.txtTeamNameMain.Name = "txtTeamNameMain"
        Me.txtTeamNameMain.Size = New System.Drawing.Size(134, 34)
        Me.txtTeamNameMain.TabIndex = 44
        Me.txtTeamNameMain.Text = "PROCESS"
        '
        'MLBEastPlayersTableAdapter
        '
        Me.MLBEastPlayersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MLBEastPlayersTableAdapter = Me.MLBEastPlayersTableAdapter
        Me.TableAdapterManager.OrderByTeamName = Nothing
        Me.TableAdapterManager.UpdateOrder = ZachChilders_CPT_206_A01_S_FinalProject.MLBAllPlayersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'rb
        '
        Me.rb.Location = New System.Drawing.Point(379, 316)
        Me.rb.Name = "rb"
        Me.rb.Size = New System.Drawing.Size(479, 209)
        Me.rb.TabIndex = 45
        Me.rb.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(374, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 25)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Selected team Statistics:"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1092, 632)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rb)
        Me.Controls.Add(Me.txtTeamNameMain)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClrRoster)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comsTeam)
        Me.Controls.Add(Me.picRedSex)
        Me.Controls.Add(Me.picYankees)
        Me.Controls.Add(Me.picMarlins)
        Me.Controls.Add(Me.picRays)
        Me.Controls.Add(Me.picPhilly)
        Me.Controls.Add(Me.picBraves)
        Me.Controls.Add(Me.picMets)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MLBEastPlayersDataGridView)
        Me.Controls.Add(Me.comsNames1)
        Me.Controls.Add(Me.btnRemovePlayer)
        Me.Controls.Add(Me.btnClosePlayerSelect)
        Me.Controls.Add(Me.btnAddPlayer)
        Me.Controls.Add(Me.lblNameCount)
        Me.Controls.Add(Me.lblRost)
        Me.Controls.Add(Me.lstFantasy)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MLB Fantasy League"
        CType(Me.MLBEastPlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MLBAllPlayersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MLBEastPlayersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBraves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhilly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMarlins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYankees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRedSex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFantasy As ListBox
    Friend WithEvents lblRost As Label
    Friend WithEvents lblNameCount As Label
    Friend WithEvents btnAddPlayer As Button
    Friend WithEvents btnClosePlayerSelect As Button
    Friend WithEvents btnRemovePlayer As Button
    Friend WithEvents comsNames1 As ComboBox
    Friend WithEvents MLBAllPlayersDataSet As MLBAllPlayersDataSet
    Friend WithEvents MLBEastPlayersBindingSource As BindingSource
    Friend WithEvents MLBEastPlayersTableAdapter As MLBAllPlayersDataSetTableAdapters.MLBEastPlayersTableAdapter
    Friend WithEvents TableAdapterManager As MLBAllPlayersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MLBEastPlayersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents picMets As PictureBox
    Friend WithEvents picBraves As PictureBox
    Friend WithEvents picPhilly As PictureBox
    Friend WithEvents picRays As PictureBox
    Friend WithEvents picMarlins As PictureBox
    Friend WithEvents picYankees As PictureBox
    Friend WithEvents picRedSex As PictureBox
    Friend WithEvents comsTeam As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblCT As Label
    Friend WithEvents btnClrRoster As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTeamNameMain As Label
    Friend WithEvents rb As RichTextBox
    Friend WithEvents Label5 As Label
End Class
