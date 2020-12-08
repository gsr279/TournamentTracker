<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTournamentForm
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
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.TournamentNameValue = New System.Windows.Forms.TextBox()
        Me.TournamenNametLabel = New System.Windows.Forms.Label()
        Me.EntryFeeValue = New System.Windows.Forms.TextBox()
        Me.EntryFeeLabel = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CreateNewTeamLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AddTeamButton = New System.Windows.Forms.Button()
        Me.CreatePrizeButton = New System.Windows.Forms.Button()
        Me.TournamentPlayersListBox = New System.Windows.Forms.ListBox()
        Me.TournamentPlayersLabel = New System.Windows.Forms.Label()
        Me.DeleteSelectedPlayersButton = New System.Windows.Forms.Button()
        Me.DeleteSelectedPrizeButton = New System.Windows.Forms.Button()
        Me.PrizesLabel = New System.Windows.Forms.Label()
        Me.PrizesListBox = New System.Windows.Forms.ListBox()
        Me.CreateTournamentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.headerLabel.Location = New System.Drawing.Point(16, 9)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(195, 30)
        Me.headerLabel.TabIndex = 1
        Me.headerLabel.Text = "Create Tournament:"
        '
        'TournamentNameValue
        '
        Me.TournamentNameValue.Location = New System.Drawing.Point(16, 95)
        Me.TournamentNameValue.Name = "TournamentNameValue"
        Me.TournamentNameValue.Size = New System.Drawing.Size(259, 35)
        Me.TournamentNameValue.TabIndex = 10
        '
        'TournamenNametLabel
        '
        Me.TournamenNametLabel.AccessibleName = "RoundLabel"
        Me.TournamenNametLabel.AutoSize = True
        Me.TournamenNametLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TournamenNametLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TournamenNametLabel.Location = New System.Drawing.Point(16, 55)
        Me.TournamenNametLabel.Name = "TournamenNametLabel"
        Me.TournamenNametLabel.Size = New System.Drawing.Size(218, 37)
        Me.TournamenNametLabel.TabIndex = 9
        Me.TournamenNametLabel.Text = "TournamentName"
        '
        'EntryFeeValue
        '
        Me.EntryFeeValue.Location = New System.Drawing.Point(146, 144)
        Me.EntryFeeValue.Name = "EntryFeeValue"
        Me.EntryFeeValue.Size = New System.Drawing.Size(110, 35)
        Me.EntryFeeValue.TabIndex = 12
        Me.EntryFeeValue.Text = "0"
        '
        'EntryFeeLabel
        '
        Me.EntryFeeLabel.AccessibleName = "RoundLabel"
        Me.EntryFeeLabel.AutoSize = True
        Me.EntryFeeLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EntryFeeLabel.Location = New System.Drawing.Point(16, 144)
        Me.EntryFeeLabel.Name = "EntryFeeLabel"
        Me.EntryFeeLabel.Size = New System.Drawing.Size(124, 37)
        Me.EntryFeeLabel.TabIndex = 11
        Me.EntryFeeLabel.Text = "Entry Fee"
        '
        'ComboBox1
        '
        Me.ComboBox1.AccessibleName = "SelectTeamDropDown"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 238)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(259, 38)
        Me.ComboBox1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AccessibleName = "SelectTeamLabel"
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(16, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 37)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Select Team"
        '
        'CreateNewTeamLinkLabel
        '
        Me.CreateNewTeamLinkLabel.AutoSize = True
        Me.CreateNewTeamLinkLabel.Location = New System.Drawing.Point(154, 205)
        Me.CreateNewTeamLinkLabel.Name = "CreateNewTeamLinkLabel"
        Me.CreateNewTeamLinkLabel.Size = New System.Drawing.Size(121, 30)
        Me.CreateNewTeamLinkLabel.TabIndex = 15
        Me.CreateNewTeamLinkLabel.TabStop = True
        Me.CreateNewTeamLinkLabel.Text = "Create New"
        '
        'AddTeamButton
        '
        Me.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTeamButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.AddTeamButton.Location = New System.Drawing.Point(46, 282)
        Me.AddTeamButton.Name = "AddTeamButton"
        Me.AddTeamButton.Size = New System.Drawing.Size(188, 38)
        Me.AddTeamButton.TabIndex = 16
        Me.AddTeamButton.Text = "Add Team"
        Me.AddTeamButton.UseVisualStyleBackColor = True
        '
        'CreatePrizeButton
        '
        Me.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreatePrizeButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreatePrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CreatePrizeButton.Location = New System.Drawing.Point(46, 355)
        Me.CreatePrizeButton.Name = "CreatePrizeButton"
        Me.CreatePrizeButton.Size = New System.Drawing.Size(188, 38)
        Me.CreatePrizeButton.TabIndex = 17
        Me.CreatePrizeButton.Text = "Create Prize"
        Me.CreatePrizeButton.UseVisualStyleBackColor = True
        '
        'TournamentPlayersListBox
        '
        Me.TournamentPlayersListBox.AccessibleDescription = ""
        Me.TournamentPlayersListBox.AccessibleName = ""
        Me.TournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TournamentPlayersListBox.FormattingEnabled = True
        Me.TournamentPlayersListBox.ItemHeight = 30
        Me.TournamentPlayersListBox.Location = New System.Drawing.Point(299, 95)
        Me.TournamentPlayersListBox.Name = "TournamentPlayersListBox"
        Me.TournamentPlayersListBox.Size = New System.Drawing.Size(302, 152)
        Me.TournamentPlayersListBox.TabIndex = 18
        '
        'TournamentPlayersLabel
        '
        Me.TournamentPlayersLabel.AccessibleName = "RoundLabel"
        Me.TournamentPlayersLabel.AutoSize = True
        Me.TournamentPlayersLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TournamentPlayersLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TournamentPlayersLabel.Location = New System.Drawing.Point(310, 55)
        Me.TournamentPlayersLabel.Name = "TournamentPlayersLabel"
        Me.TournamentPlayersLabel.Size = New System.Drawing.Size(165, 37)
        Me.TournamentPlayersLabel.TabIndex = 19
        Me.TournamentPlayersLabel.Text = "Team/Players"
        '
        'DeleteSelectedPlayersButton
        '
        Me.DeleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.DeleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DeleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DeleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteSelectedPlayersButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteSelectedPlayersButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.DeleteSelectedPlayersButton.Location = New System.Drawing.Point(618, 144)
        Me.DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton"
        Me.DeleteSelectedPlayersButton.Size = New System.Drawing.Size(110, 78)
        Me.DeleteSelectedPlayersButton.TabIndex = 20
        Me.DeleteSelectedPlayersButton.Text = "Delete Selected"
        Me.DeleteSelectedPlayersButton.UseVisualStyleBackColor = True
        '
        'DeleteSelectedPrizeButton
        '
        Me.DeleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DeleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteSelectedPrizeButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.DeleteSelectedPrizeButton.Location = New System.Drawing.Point(618, 338)
        Me.DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton"
        Me.DeleteSelectedPrizeButton.Size = New System.Drawing.Size(112, 72)
        Me.DeleteSelectedPrizeButton.TabIndex = 23
        Me.DeleteSelectedPrizeButton.Text = "Delete Selected"
        Me.DeleteSelectedPrizeButton.UseVisualStyleBackColor = True
        '
        'PrizesLabel
        '
        Me.PrizesLabel.AccessibleName = "RoundLabel"
        Me.PrizesLabel.AutoSize = True
        Me.PrizesLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PrizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.PrizesLabel.Location = New System.Drawing.Point(299, 260)
        Me.PrizesLabel.Name = "PrizesLabel"
        Me.PrizesLabel.Size = New System.Drawing.Size(165, 37)
        Me.PrizesLabel.TabIndex = 22
        Me.PrizesLabel.Text = "Team/Players"
        '
        'PrizesListBox
        '
        Me.PrizesListBox.AccessibleDescription = ""
        Me.PrizesListBox.AccessibleName = ""
        Me.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrizesListBox.FormattingEnabled = True
        Me.PrizesListBox.ItemHeight = 30
        Me.PrizesListBox.Location = New System.Drawing.Point(299, 300)
        Me.PrizesListBox.Name = "PrizesListBox"
        Me.PrizesListBox.Size = New System.Drawing.Size(302, 152)
        Me.PrizesListBox.TabIndex = 21
        '
        'CreateTournamentButton
        '
        Me.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateTournamentButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CreateTournamentButton.Location = New System.Drawing.Point(202, 479)
        Me.CreateTournamentButton.Name = "CreateTournamentButton"
        Me.CreateTournamentButton.Size = New System.Drawing.Size(232, 38)
        Me.CreateTournamentButton.TabIndex = 24
        Me.CreateTournamentButton.Text = "Create Tournament"
        Me.CreateTournamentButton.UseVisualStyleBackColor = True
        '
        'CreateTournamentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 565)
        Me.Controls.Add(Me.CreateTournamentButton)
        Me.Controls.Add(Me.DeleteSelectedPrizeButton)
        Me.Controls.Add(Me.PrizesLabel)
        Me.Controls.Add(Me.PrizesListBox)
        Me.Controls.Add(Me.DeleteSelectedPlayersButton)
        Me.Controls.Add(Me.TournamentPlayersLabel)
        Me.Controls.Add(Me.TournamentPlayersListBox)
        Me.Controls.Add(Me.CreatePrizeButton)
        Me.Controls.Add(Me.AddTeamButton)
        Me.Controls.Add(Me.CreateNewTeamLinkLabel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EntryFeeValue)
        Me.Controls.Add(Me.EntryFeeLabel)
        Me.Controls.Add(Me.TournamentNameValue)
        Me.Controls.Add(Me.TournamenNametLabel)
        Me.Controls.Add(Me.headerLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "CreateTournamentForm"
        Me.Text = "Create Tournament"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headerLabel As Label
    Friend WithEvents TournamentNameValue As TextBox
    Friend WithEvents TournamenNametLabel As Label
    Friend WithEvents EntryFeeValue As TextBox
    Friend WithEvents EntryFeeLabel As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CreateNewTeamLinkLabel As LinkLabel
    Friend WithEvents AddTeamButton As Button
    Friend WithEvents CreatePrizeButton As Button
    Friend WithEvents TournamentPlayersListBox As ListBox
    Friend WithEvents TournamentPlayersLabel As Label
    Friend WithEvents DeleteSelectedPlayersButton As Button
    Friend WithEvents DeleteSelectedPrizeButton As Button
    Friend WithEvents PrizesLabel As Label
    Friend WithEvents PrizesListBox As ListBox
    Friend WithEvents CreateTournamentButton As Button
End Class
