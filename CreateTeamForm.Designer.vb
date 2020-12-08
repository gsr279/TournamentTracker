<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTeamForm
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
        Me.TeamNameValue = New System.Windows.Forms.TextBox()
        Me.TeamNameLabel = New System.Windows.Forms.Label()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.AddTeamMemberButton = New System.Windows.Forms.Button()
        Me.SelectTeamMemberDropBox = New System.Windows.Forms.ComboBox()
        Me.SelectTeamMemeberLabel = New System.Windows.Forms.Label()
        Me.AddNewMemberGroupBox = New System.Windows.Forms.GroupBox()
        Me.FirstNameValue = New System.Windows.Forms.TextBox()
        Me.FIrstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameValue = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.EmailValue = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.CellPhoneValue = New System.Windows.Forms.TextBox()
        Me.CellPhoneLabel = New System.Windows.Forms.Label()
        Me.CreateMemberButton = New System.Windows.Forms.Button()
        Me.TeamMembersListBox = New System.Windows.Forms.ListBox()
        Me.DeleteSelectedMembersButton = New System.Windows.Forms.Button()
        Me.CreateTeamButton = New System.Windows.Forms.Button()
        Me.AddNewMemberGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TeamNameValue
        '
        Me.TeamNameValue.Location = New System.Drawing.Point(27, 80)
        Me.TeamNameValue.Name = "TeamNameValue"
        Me.TeamNameValue.Size = New System.Drawing.Size(307, 35)
        Me.TeamNameValue.TabIndex = 13
        '
        'TeamNameLabel
        '
        Me.TeamNameLabel.AccessibleName = "RoundLabel"
        Me.TeamNameLabel.AutoSize = True
        Me.TeamNameLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TeamNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TeamNameLabel.Location = New System.Drawing.Point(27, 40)
        Me.TeamNameLabel.Name = "TeamNameLabel"
        Me.TeamNameLabel.Size = New System.Drawing.Size(151, 37)
        Me.TeamNameLabel.TabIndex = 12
        Me.TeamNameLabel.Text = "Team Name"
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.headerLabel.Location = New System.Drawing.Point(27, 14)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(128, 30)
        Me.headerLabel.TabIndex = 11
        Me.headerLabel.Text = "Create Team"
        '
        'AddTeamMemberButton
        '
        Me.AddTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.AddTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.AddTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.AddTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTeamMemberButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddTeamMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.AddTeamMemberButton.Location = New System.Drawing.Point(92, 222)
        Me.AddTeamMemberButton.Name = "AddTeamMemberButton"
        Me.AddTeamMemberButton.Size = New System.Drawing.Size(188, 38)
        Me.AddTeamMemberButton.TabIndex = 22
        Me.AddTeamMemberButton.Text = "Add Member"
        Me.AddTeamMemberButton.UseVisualStyleBackColor = True
        '
        'SelectTeamMemberDropBox
        '
        Me.SelectTeamMemberDropBox.AccessibleName = "SelectTeamDropDown"
        Me.SelectTeamMemberDropBox.FormattingEnabled = True
        Me.SelectTeamMemberDropBox.Location = New System.Drawing.Point(27, 169)
        Me.SelectTeamMemberDropBox.Name = "SelectTeamMemberDropBox"
        Me.SelectTeamMemberDropBox.Size = New System.Drawing.Size(307, 38)
        Me.SelectTeamMemberDropBox.TabIndex = 21
        '
        'SelectTeamMemeberLabel
        '
        Me.SelectTeamMemeberLabel.AccessibleName = "SelectTeamLabel"
        Me.SelectTeamMemeberLabel.AutoSize = True
        Me.SelectTeamMemeberLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SelectTeamMemeberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.SelectTeamMemeberLabel.Location = New System.Drawing.Point(27, 129)
        Me.SelectTeamMemeberLabel.Name = "SelectTeamMemeberLabel"
        Me.SelectTeamMemeberLabel.Size = New System.Drawing.Size(253, 37)
        Me.SelectTeamMemeberLabel.TabIndex = 20
        Me.SelectTeamMemeberLabel.Text = "Select Team Member"
        '
        'AddNewMemberGroupBox
        '
        Me.AddNewMemberGroupBox.Controls.Add(Me.CreateMemberButton)
        Me.AddNewMemberGroupBox.Controls.Add(Me.CellPhoneValue)
        Me.AddNewMemberGroupBox.Controls.Add(Me.CellPhoneLabel)
        Me.AddNewMemberGroupBox.Controls.Add(Me.EmailValue)
        Me.AddNewMemberGroupBox.Controls.Add(Me.EmailLabel)
        Me.AddNewMemberGroupBox.Controls.Add(Me.LastNameValue)
        Me.AddNewMemberGroupBox.Controls.Add(Me.LastNameLabel)
        Me.AddNewMemberGroupBox.Controls.Add(Me.FirstNameValue)
        Me.AddNewMemberGroupBox.Controls.Add(Me.FIrstNameLabel)
        Me.AddNewMemberGroupBox.Location = New System.Drawing.Point(27, 266)
        Me.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox"
        Me.AddNewMemberGroupBox.Size = New System.Drawing.Size(344, 296)
        Me.AddNewMemberGroupBox.TabIndex = 23
        Me.AddNewMemberGroupBox.TabStop = False
        Me.AddNewMemberGroupBox.Text = "Add New Member"
        '
        'FirstNameValue
        '
        Me.FirstNameValue.Location = New System.Drawing.Point(149, 46)
        Me.FirstNameValue.Name = "FirstNameValue"
        Me.FirstNameValue.Size = New System.Drawing.Size(158, 35)
        Me.FirstNameValue.TabIndex = 10
        '
        'FIrstNameLabel
        '
        Me.FIrstNameLabel.AccessibleName = "RoundLabel"
        Me.FIrstNameLabel.AutoSize = True
        Me.FIrstNameLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FIrstNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FIrstNameLabel.Location = New System.Drawing.Point(6, 46)
        Me.FIrstNameLabel.Name = "FIrstNameLabel"
        Me.FIrstNameLabel.Size = New System.Drawing.Size(138, 37)
        Me.FIrstNameLabel.TabIndex = 9
        Me.FIrstNameLabel.Text = "First Name"
        '
        'LastNameValue
        '
        Me.LastNameValue.Location = New System.Drawing.Point(149, 90)
        Me.LastNameValue.Name = "LastNameValue"
        Me.LastNameValue.Size = New System.Drawing.Size(158, 35)
        Me.LastNameValue.TabIndex = 12
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AccessibleName = "RoundLabel"
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LastNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LastNameLabel.Location = New System.Drawing.Point(6, 90)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(135, 37)
        Me.LastNameLabel.TabIndex = 11
        Me.LastNameLabel.Text = "Last Name"
        '
        'EmailValue
        '
        Me.EmailValue.Location = New System.Drawing.Point(149, 140)
        Me.EmailValue.Name = "EmailValue"
        Me.EmailValue.Size = New System.Drawing.Size(158, 35)
        Me.EmailValue.TabIndex = 14
        '
        'EmailLabel
        '
        Me.EmailLabel.AccessibleName = "RoundLabel"
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EmailLabel.Location = New System.Drawing.Point(6, 140)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(78, 37)
        Me.EmailLabel.TabIndex = 13
        Me.EmailLabel.Text = "Email"
        '
        'CellPhoneValue
        '
        Me.CellPhoneValue.Location = New System.Drawing.Point(149, 190)
        Me.CellPhoneValue.Name = "CellPhoneValue"
        Me.CellPhoneValue.Size = New System.Drawing.Size(158, 35)
        Me.CellPhoneValue.TabIndex = 16
        '
        'CellPhoneLabel
        '
        Me.CellPhoneLabel.AccessibleName = "RoundLabel"
        Me.CellPhoneLabel.AutoSize = True
        Me.CellPhoneLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CellPhoneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CellPhoneLabel.Location = New System.Drawing.Point(6, 190)
        Me.CellPhoneLabel.Name = "CellPhoneLabel"
        Me.CellPhoneLabel.Size = New System.Drawing.Size(139, 37)
        Me.CellPhoneLabel.TabIndex = 15
        Me.CellPhoneLabel.Text = "Cell Phone"
        '
        'CreateMemberButton
        '
        Me.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateMemberButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreateMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CreateMemberButton.Location = New System.Drawing.Point(65, 240)
        Me.CreateMemberButton.Name = "CreateMemberButton"
        Me.CreateMemberButton.Size = New System.Drawing.Size(188, 38)
        Me.CreateMemberButton.TabIndex = 23
        Me.CreateMemberButton.Text = "Create Member"
        Me.CreateMemberButton.UseVisualStyleBackColor = True
        '
        'TeamMembersListBox
        '
        Me.TeamMembersListBox.AccessibleDescription = ""
        Me.TeamMembersListBox.AccessibleName = ""
        Me.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TeamMembersListBox.FormattingEnabled = True
        Me.TeamMembersListBox.ItemHeight = 30
        Me.TeamMembersListBox.Location = New System.Drawing.Point(377, 80)
        Me.TeamMembersListBox.Name = "TeamMembersListBox"
        Me.TeamMembersListBox.Size = New System.Drawing.Size(313, 482)
        Me.TeamMembersListBox.TabIndex = 24
        '
        'DeleteSelectedMembersButton
        '
        Me.DeleteSelectedMembersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.DeleteSelectedMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DeleteSelectedMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DeleteSelectedMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteSelectedMembersButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteSelectedMembersButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.DeleteSelectedMembersButton.Location = New System.Drawing.Point(696, 248)
        Me.DeleteSelectedMembersButton.Name = "DeleteSelectedMembersButton"
        Me.DeleteSelectedMembersButton.Size = New System.Drawing.Size(110, 78)
        Me.DeleteSelectedMembersButton.TabIndex = 25
        Me.DeleteSelectedMembersButton.Text = "Delete Selected"
        Me.DeleteSelectedMembersButton.UseVisualStyleBackColor = True
        '
        'CreateTeamButton
        '
        Me.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateTeamButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreateTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CreateTeamButton.Location = New System.Drawing.Point(251, 582)
        Me.CreateTeamButton.Name = "CreateTeamButton"
        Me.CreateTeamButton.Size = New System.Drawing.Size(232, 38)
        Me.CreateTeamButton.TabIndex = 26
        Me.CreateTeamButton.Text = "Create Team"
        Me.CreateTeamButton.UseVisualStyleBackColor = True
        '
        'CreateTeamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 651)
        Me.Controls.Add(Me.CreateTeamButton)
        Me.Controls.Add(Me.DeleteSelectedMembersButton)
        Me.Controls.Add(Me.TeamMembersListBox)
        Me.Controls.Add(Me.AddNewMemberGroupBox)
        Me.Controls.Add(Me.AddTeamMemberButton)
        Me.Controls.Add(Me.SelectTeamMemberDropBox)
        Me.Controls.Add(Me.SelectTeamMemeberLabel)
        Me.Controls.Add(Me.TeamNameValue)
        Me.Controls.Add(Me.TeamNameLabel)
        Me.Controls.Add(Me.headerLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "CreateTeamForm"
        Me.Text = "Create Team"
        Me.AddNewMemberGroupBox.ResumeLayout(False)
        Me.AddNewMemberGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TeamNameValue As TextBox
    Friend WithEvents TeamNameLabel As Label
    Friend WithEvents headerLabel As Label
    Friend WithEvents AddTeamMemberButton As Button
    Friend WithEvents SelectTeamMemberDropBox As ComboBox
    Friend WithEvents SelectTeamMemeberLabel As Label
    Friend WithEvents AddNewMemberGroupBox As GroupBox
    Friend WithEvents FirstNameValue As TextBox
    Friend WithEvents FIrstNameLabel As Label
    Friend WithEvents LastNameValue As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents CellPhoneValue As TextBox
    Friend WithEvents CellPhoneLabel As Label
    Friend WithEvents EmailValue As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents CreateMemberButton As Button
    Friend WithEvents TeamMembersListBox As ListBox
    Friend WithEvents DeleteSelectedMembersButton As Button
    Friend WithEvents CreateTeamButton As Button
End Class
