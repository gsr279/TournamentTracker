<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TournamentDashboardForm
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
        Me.TournamentDashboardLabel = New System.Windows.Forms.Label()
        Me.LoadExistingTournametDropDown = New System.Windows.Forms.ComboBox()
        Me.LoadExistingTournamentLabel = New System.Windows.Forms.Label()
        Me.LoadTournamentButton = New System.Windows.Forms.Button()
        Me.CreateTournamentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TournamentDashboardLabel
        '
        Me.TournamentDashboardLabel.AccessibleName = "RoundLabel"
        Me.TournamentDashboardLabel.AutoSize = True
        Me.TournamentDashboardLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TournamentDashboardLabel.Location = New System.Drawing.Point(58, 50)
        Me.TournamentDashboardLabel.Name = "TournamentDashboardLabel"
        Me.TournamentDashboardLabel.Size = New System.Drawing.Size(265, 37)
        Me.TournamentDashboardLabel.TabIndex = 14
        Me.TournamentDashboardLabel.Text = "Tournament Dashbord"
        '
        'LoadExistingTournametDropDown
        '
        Me.LoadExistingTournametDropDown.AccessibleName = "SelectTeamDropDown"
        Me.LoadExistingTournametDropDown.FormattingEnabled = True
        Me.LoadExistingTournametDropDown.Location = New System.Drawing.Point(37, 136)
        Me.LoadExistingTournametDropDown.Name = "LoadExistingTournametDropDown"
        Me.LoadExistingTournametDropDown.Size = New System.Drawing.Size(307, 38)
        Me.LoadExistingTournametDropDown.TabIndex = 23
        '
        'LoadExistingTournamentLabel
        '
        Me.LoadExistingTournamentLabel.AccessibleName = "SelectTeamLabel"
        Me.LoadExistingTournamentLabel.AutoSize = True
        Me.LoadExistingTournamentLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LoadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LoadExistingTournamentLabel.Location = New System.Drawing.Point(39, 96)
        Me.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel"
        Me.LoadExistingTournamentLabel.Size = New System.Drawing.Size(303, 37)
        Me.LoadExistingTournamentLabel.TabIndex = 22
        Me.LoadExistingTournamentLabel.Text = "Load Existing Tournament"
        '
        'LoadTournamentButton
        '
        Me.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadTournamentButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoadTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LoadTournamentButton.Location = New System.Drawing.Point(66, 203)
        Me.LoadTournamentButton.Name = "LoadTournamentButton"
        Me.LoadTournamentButton.Size = New System.Drawing.Size(248, 38)
        Me.LoadTournamentButton.TabIndex = 24
        Me.LoadTournamentButton.Text = "Load Tournament"
        Me.LoadTournamentButton.UseVisualStyleBackColor = True
        '
        'CreateTournamentButton
        '
        Me.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateTournamentButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CreateTournamentButton.Location = New System.Drawing.Point(66, 257)
        Me.CreateTournamentButton.Name = "CreateTournamentButton"
        Me.CreateTournamentButton.Size = New System.Drawing.Size(248, 38)
        Me.CreateTournamentButton.TabIndex = 25
        Me.CreateTournamentButton.Text = "Create Tournament"
        Me.CreateTournamentButton.UseVisualStyleBackColor = True
        '
        'TournamentDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(446, 379)
        Me.Controls.Add(Me.CreateTournamentButton)
        Me.Controls.Add(Me.LoadTournamentButton)
        Me.Controls.Add(Me.LoadExistingTournametDropDown)
        Me.Controls.Add(Me.LoadExistingTournamentLabel)
        Me.Controls.Add(Me.TournamentDashboardLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "TournamentDashboardForm"
        Me.Text = "Tournament Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TournamentDashboardLabel As Label
    Friend WithEvents LoadExistingTournametDropDown As ComboBox
    Friend WithEvents LoadExistingTournamentLabel As Label
    Friend WithEvents LoadTournamentButton As Button
    Friend WithEvents CreateTournamentButton As Button
End Class
