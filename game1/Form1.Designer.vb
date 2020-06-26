<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BURG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BURG))
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.BtnLose = New System.Windows.Forms.Button()
        Me.Taunt = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheeseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LettuceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PickleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn1.Image = Global.game1.My.Resources.Resources.burger_king_mask
        Me.Btn1.Location = New System.Drawing.Point(96, 148)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 93)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "start &here"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(248, 311)
        Me.ProgressBar.MarqueeAnimationSpeed = 10
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar.Size = New System.Drawing.Size(307, 84)
        Me.ProgressBar.TabIndex = 4
        Me.ProgressBar.UseWaitCursor = True
        '
        'BtnLose
        '
        Me.BtnLose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLose.Location = New System.Drawing.Point(722, 23)
        Me.BtnLose.Name = "BtnLose"
        Me.BtnLose.Size = New System.Drawing.Size(66, 43)
        Me.BtnLose.TabIndex = 5
        Me.BtnLose.Text = "Maybe Here"
        Me.BtnLose.UseVisualStyleBackColor = False
        Me.BtnLose.Visible = False
        '
        'Taunt
        '
        Me.Taunt.AutoSize = True
        Me.Taunt.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Taunt.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Taunt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Taunt.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Taunt.Location = New System.Drawing.Point(227, 69)
        Me.Taunt.Name = "Taunt"
        Me.Taunt.Size = New System.Drawing.Size(40, 13)
        Me.Taunt.TabIndex = 6
        Me.Taunt.Text = "NOPE!"
        Me.ToolTip1.SetToolTip(Me.Taunt, "Try looking behind you")
        Me.Taunt.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheeseToolStripMenuItem, Me.LettuceToolStripMenuItem, Me.BaconToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 70)
        '
        'CheeseToolStripMenuItem
        '
        Me.CheeseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhiteToolStripMenuItem, Me.OrangeToolStripMenuItem, Me.BlueToolStripMenuItem})
        Me.CheeseToolStripMenuItem.Name = "CheeseToolStripMenuItem"
        Me.CheeseToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.CheeseToolStripMenuItem.Text = "cheese"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.WhiteToolStripMenuItem.Text = "white"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.OrangeToolStripMenuItem.Text = "orange"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.BlueToolStripMenuItem.Text = "blue"
        '
        'LettuceToolStripMenuItem
        '
        Me.LettuceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreenToolStripMenuItem})
        Me.LettuceToolStripMenuItem.Name = "LettuceToolStripMenuItem"
        Me.LettuceToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.LettuceToolStripMenuItem.Text = "lettuce"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PickleToolStripMenuItem})
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.GreenToolStripMenuItem.Text = "green"
        '
        'PickleToolStripMenuItem
        '
        Me.PickleToolStripMenuItem.Name = "PickleToolStripMenuItem"
        Me.PickleToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.PickleToolStripMenuItem.Text = "pickle"
        '
        'BaconToolStripMenuItem
        '
        Me.BaconToolStripMenuItem.Name = "BaconToolStripMenuItem"
        Me.BaconToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.BaconToolStripMenuItem.Text = "bacon"
        '
        'Btn2
        '
        Me.Btn2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn2.Image = Global.game1.My.Resources.Resources.burger_king_mask
        Me.Btn2.Location = New System.Drawing.Point(574, 148)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 93)
        Me.Btn2.TabIndex = 7
        Me.Btn2.Text = "or here"
        Me.ToolTip1.SetToolTip(Me.Btn2, "Click Me!")
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Lettuce", "Tomato", "Cheese", "Bacon"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(329, 148)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox1.TabIndex = 13
        '
        'BURG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Taunt)
        Me.Controls.Add(Me.BtnLose)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Btn1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BURG"
        Me.Text = "BURG 1.5"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents BtnLose As Button
    Friend WithEvents Taunt As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Btn2 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CheeseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LettuceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PickleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaconToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
