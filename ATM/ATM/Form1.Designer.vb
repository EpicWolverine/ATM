<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UDontNeedNoHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtWalletTotal = New System.Windows.Forms.TextBox()
        Me.txtBankTotal = New System.Windows.Forms.TextBox()
        Me.rbBankDeposit = New System.Windows.Forms.RadioButton()
        Me.rbWalletDeposit = New System.Windows.Forms.RadioButton()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.rbBankWithdraw = New System.Windows.Forms.RadioButton()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtWithdraw = New System.Windows.Forms.TextBox()
        Me.rbWalletWithdraw = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UDontNeedNoHelpToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'UDontNeedNoHelpToolStripMenuItem
        '
        Me.UDontNeedNoHelpToolStripMenuItem.Name = "UDontNeedNoHelpToolStripMenuItem"
        Me.UDontNeedNoHelpToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.UDontNeedNoHelpToolStripMenuItem.Text = "u don't need no help"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 84)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Bank" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wallet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Location = New System.Drawing.Point(134, 109)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 8
        '
        'txtWalletTotal
        '
        Me.txtWalletTotal.BackColor = System.Drawing.Color.White
        Me.txtWalletTotal.Location = New System.Drawing.Point(134, 67)
        Me.txtWalletTotal.Name = "txtWalletTotal"
        Me.txtWalletTotal.ReadOnly = True
        Me.txtWalletTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtWalletTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtWalletTotal.TabIndex = 7
        '
        'txtBankTotal
        '
        Me.txtBankTotal.BackColor = System.Drawing.Color.White
        Me.txtBankTotal.Location = New System.Drawing.Point(134, 41)
        Me.txtBankTotal.Name = "txtBankTotal"
        Me.txtBankTotal.ReadOnly = True
        Me.txtBankTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBankTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtBankTotal.TabIndex = 6
        '
        'rbBankDeposit
        '
        Me.rbBankDeposit.AutoSize = True
        Me.rbBankDeposit.Location = New System.Drawing.Point(101, 49)
        Me.rbBankDeposit.Name = "rbBankDeposit"
        Me.rbBankDeposit.Size = New System.Drawing.Size(50, 17)
        Me.rbBankDeposit.TabIndex = 10
        Me.rbBankDeposit.Text = "Bank"
        Me.rbBankDeposit.UseVisualStyleBackColor = True
        '
        'rbWalletDeposit
        '
        Me.rbWalletDeposit.AutoSize = True
        Me.rbWalletDeposit.Checked = True
        Me.rbWalletDeposit.Location = New System.Drawing.Point(157, 49)
        Me.rbWalletDeposit.Name = "rbWalletDeposit"
        Me.rbWalletDeposit.Size = New System.Drawing.Size(55, 17)
        Me.rbWalletDeposit.TabIndex = 11
        Me.rbWalletDeposit.TabStop = True
        Me.rbWalletDeposit.Text = "Wallet"
        Me.rbWalletDeposit.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(101, 73)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(111, 20)
        Me.txtDeposit.TabIndex = 12
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(101, 99)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(111, 23)
        Me.btnDeposit.TabIndex = 13
        Me.btnDeposit.Text = "Deposit Amount"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.ItemSize = New System.Drawing.Size(79, 18)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(320, 196)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtBankTotal)
        Me.TabPage1.Controls.Add(Me.txtWalletTotal)
        Me.TabPage1.Controls.Add(Me.txtTotal)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(312, 170)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Total"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rbBankDeposit)
        Me.TabPage2.Controls.Add(Me.rbWalletDeposit)
        Me.TabPage2.Controls.Add(Me.txtDeposit)
        Me.TabPage2.Controls.Add(Me.btnDeposit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(312, 170)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Deposit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.rbBankWithdraw)
        Me.TabPage3.Controls.Add(Me.btnWithdrawal)
        Me.TabPage3.Controls.Add(Me.RadioButton2)
        Me.TabPage3.Controls.Add(Me.txtWithdraw)
        Me.TabPage3.Controls.Add(Me.rbWalletWithdraw)
        Me.TabPage3.Controls.Add(Me.RadioButton4)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(312, 170)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Withdraw"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'rbBankWithdraw
        '
        Me.rbBankWithdraw.AutoSize = True
        Me.rbBankWithdraw.Location = New System.Drawing.Point(101, 49)
        Me.rbBankWithdraw.Name = "rbBankWithdraw"
        Me.rbBankWithdraw.Size = New System.Drawing.Size(50, 17)
        Me.rbBankWithdraw.TabIndex = 22
        Me.rbBankWithdraw.Text = "Bank"
        Me.rbBankWithdraw.UseVisualStyleBackColor = True
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.Location = New System.Drawing.Point(101, 99)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(111, 23)
        Me.btnWithdrawal.TabIndex = 25
        Me.btnWithdrawal.Text = "Withdraw Amount"
        Me.btnWithdrawal.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(101, 49)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.Text = "Bank"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtWithdraw
        '
        Me.txtWithdraw.Location = New System.Drawing.Point(101, 73)
        Me.txtWithdraw.Name = "txtWithdraw"
        Me.txtWithdraw.Size = New System.Drawing.Size(111, 20)
        Me.txtWithdraw.TabIndex = 24
        '
        'rbWalletWithdraw
        '
        Me.rbWalletWithdraw.AutoSize = True
        Me.rbWalletWithdraw.Checked = True
        Me.rbWalletWithdraw.Location = New System.Drawing.Point(157, 49)
        Me.rbWalletWithdraw.Name = "rbWalletWithdraw"
        Me.rbWalletWithdraw.Size = New System.Drawing.Size(55, 17)
        Me.rbWalletWithdraw.TabIndex = 19
        Me.rbWalletWithdraw.TabStop = True
        Me.rbWalletWithdraw.Text = "Wallet"
        Me.rbWalletWithdraw.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(157, 49)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton4.TabIndex = 23
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Wallet"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(111, 20)
        Me.TextBox2.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(101, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Deposit Amount"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TextBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(312, 170)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "History"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(3, 6)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(303, 161)
        Me.TextBox3.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 195)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATM"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtWalletTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtBankTotal As System.Windows.Forms.TextBox
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UDontNeedNoHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rbBankDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents rbWalletDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents rbBankWithdraw As System.Windows.Forms.RadioButton
    Friend WithEvents btnWithdrawal As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtWithdraw As System.Windows.Forms.TextBox
    Friend WithEvents rbWalletWithdraw As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
