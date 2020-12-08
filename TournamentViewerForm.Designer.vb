<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TournamentViewerForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.matchUpListBox = New System.Windows.Forms.ListBox()
        Me.TeamOneNameLabel = New System.Windows.Forms.Label()
        Me.TeamOneScoreLabel = New System.Windows.Forms.Label()
        Me.TeamOneScoreValue = New System.Windows.Forms.TextBox()
        Me.TeamTwoScoreValue = New System.Windows.Forms.TextBox()
        Me.TeamTwoScoreLabel = New System.Windows.Forms.Label()
        Me.TeamTwoNameLabel = New System.Windows.Forms.Label()
        Me.versusLabel = New System.Windows.Forms.Label()
        Me.ScoreButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.headerLabel.Location = New System.Drawing.Point(12, 21)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(129, 30)
        Me.headerLabel.TabIndex = 0
        Me.headerLabel.Text = "Tournament:"
        '
        'Label1
        '
        Me.Label1.AccessibleName = "tournamentName"
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(138, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "<none>"
        '
        'Label2
        '
        Me.Label2.AccessibleName = "RoundLabel"
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Round"
        '
        'ComboBox1
        '
        Me.ComboBox1.AccessibleName = "roundDropDown"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(195, 38)
        Me.ComboBox1.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AccessibleName = "UnplayedOnlyCheckBox"
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(105, 114)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(159, 34)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "UnPlayed Only"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'matchUpListBox
        '
        Me.matchUpListBox.AccessibleDescription = ""
        Me.matchUpListBox.AccessibleName = ""
        Me.matchUpListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.matchUpListBox.FormattingEnabled = True
        Me.matchUpListBox.ItemHeight = 30
        Me.matchUpListBox.Location = New System.Drawing.Point(12, 154)
        Me.matchUpListBox.Name = "matchUpListBox"
        Me.matchUpListBox.Size = New System.Drawing.Size(256, 182)
        Me.matchUpListBox.TabIndex = 5
        '
        'TeamOneNameLabel
        '
        Me.TeamOneNameLabel.AccessibleName = "RoundLabel"
        Me.TeamOneNameLabel.AutoSize = True
        Me.TeamOneNameLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TeamOneNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TeamOneNameLabel.Location = New System.Drawing.Point(283, 154)
        Me.TeamOneNameLabel.Name = "TeamOneNameLabel"
        Me.TeamOneNameLabel.Size = New System.Drawing.Size(168, 37)
        Me.TeamOneNameLabel.TabIndex = 6
        Me.TeamOneNameLabel.Text = "<Team One>"
        '
        'TeamOneScoreLabel
        '
        Me.TeamOneScoreLabel.AccessibleName = "RoundLabel"
        Me.TeamOneScoreLabel.AutoSize = True
        Me.TeamOneScoreLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TeamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TeamOneScoreLabel.Location = New System.Drawing.Point(283, 191)
        Me.TeamOneScoreLabel.Name = "TeamOneScoreLabel"
        Me.TeamOneScoreLabel.Size = New System.Drawing.Size(79, 37)
        Me.TeamOneScoreLabel.TabIndex = 7
        Me.TeamOneScoreLabel.Text = "Score"
        '
        'TeamOneScoreValue
        '
        Me.TeamOneScoreValue.Location = New System.Drawing.Point(359, 193)
        Me.TeamOneScoreValue.Name = "TeamOneScoreValue"
        Me.TeamOneScoreValue.Size = New System.Drawing.Size(100, 35)
        Me.TeamOneScoreValue.TabIndex = 8
        '
        'TeamTwoScoreValue
        '
        Me.TeamTwoScoreValue.Location = New System.Drawing.Point(359, 307)
        Me.TeamTwoScoreValue.Name = "TeamTwoScoreValue"
        Me.TeamTwoScoreValue.Size = New System.Drawing.Size(100, 35)
        Me.TeamTwoScoreValue.TabIndex = 11
        '
        'TeamTwoScoreLabel
        '
        Me.TeamTwoScoreLabel.AccessibleName = "RoundLabel"
        Me.TeamTwoScoreLabel.AutoSize = True
        Me.TeamTwoScoreLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TeamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TeamTwoScoreLabel.Location = New System.Drawing.Point(283, 307)
        Me.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel"
        Me.TeamTwoScoreLabel.Size = New System.Drawing.Size(79, 37)
        Me.TeamTwoScoreLabel.TabIndex = 10
        Me.TeamTwoScoreLabel.Text = "Score"
        '
        'TeamTwoNameLabel
        '
        Me.TeamTwoNameLabel.AccessibleName = "RoundLabel"
        Me.TeamTwoNameLabel.AutoSize = True
        Me.TeamTwoNameLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TeamTwoNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TeamTwoNameLabel.Location = New System.Drawing.Point(274, 267)
        Me.TeamTwoNameLabel.Name = "TeamTwoNameLabel"
        Me.TeamTwoNameLabel.Size = New System.Drawing.Size(164, 37)
        Me.TeamTwoNameLabel.TabIndex = 9
        Me.TeamTwoNameLabel.Text = "<Team Two>"
        '
        'versusLabel
        '
        Me.versusLabel.AccessibleName = "RoundLabel"
        Me.versusLabel.AutoSize = True
        Me.versusLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.versusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.versusLabel.Location = New System.Drawing.Point(347, 231)
        Me.versusLabel.Name = "versusLabel"
        Me.versusLabel.Size = New System.Drawing.Size(67, 37)
        Me.versusLabel.TabIndex = 12
        Me.versusLabel.Text = "-VS-"
        '
        'ScoreButton
        '
        Me.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScoreButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ScoreButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ScoreButton.Location = New System.Drawing.Point(445, 230)
        Me.ScoreButton.Name = "ScoreButton"
        Me.ScoreButton.Size = New System.Drawing.Size(100, 38)
        Me.ScoreButton.TabIndex = 13
        Me.ScoreButton.Text = "Score"
        Me.ScoreButton.UseVisualStyleBackColor = True
        '
        'TournamentViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(573, 407)
        Me.Controls.Add(Me.ScoreButton)
        Me.Controls.Add(Me.versusLabel)
        Me.Controls.Add(Me.TeamTwoScoreValue)
        Me.Controls.Add(Me.TeamTwoScoreLabel)
        Me.Controls.Add(Me.TeamTwoNameLabel)
        Me.Controls.Add(Me.TeamOneScoreValue)
        Me.Controls.Add(Me.TeamOneScoreLabel)
        Me.Controls.Add(Me.TeamOneNameLabel)
        Me.Controls.Add(Me.matchUpListBox)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.headerLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "TournamentViewerForm"
        Me.Text = "Tournament Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headerLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents matchUpListBox As ListBox
    Friend WithEvents TeamOneNameLabel As Label
    Friend WithEvents TeamOneScoreLabel As Label
    Friend WithEvents TeamOneScoreValue As TextBox
    Friend WithEvents TeamTwoScoreValue As TextBox
    Friend WithEvents TeamTwoScoreLabel As Label
    Friend WithEvents TeamTwoNameLabel As Label
    Friend WithEvents versusLabel As Label
    Friend WithEvents ScoreButton As Button
End Class
