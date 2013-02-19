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
        Me.btnTopTotal = New System.Windows.Forms.Button()
        Me.btnTopDeposit = New System.Windows.Forms.Button()
        Me.btnTopWithdrawal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTopHistory = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtWalletTotal = New System.Windows.Forms.TextBox()
        Me.txtBankTotal = New System.Windows.Forms.TextBox()
        Me.rbBankDeposit = New System.Windows.Forms.RadioButton()
        Me.rbWalletDeposit = New System.Windows.Forms.RadioButton()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.txtWithdrawal = New System.Windows.Forms.TextBox()
        Me.rbWalletWithdrawal = New System.Windows.Forms.RadioButton()
        Me.rbBankWithdrawal = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        'btnTopTotal
        '
        Me.btnTopTotal.Location = New System.Drawing.Point(10, 12)
        Me.btnTopTotal.Name = "btnTopTotal"
        Me.btnTopTotal.Size = New System.Drawing.Size(75, 23)
        Me.btnTopTotal.TabIndex = 1
        Me.btnTopTotal.Text = "Total"
        Me.btnTopTotal.UseVisualStyleBackColor = True
        '
        'btnTopDeposit
        '
        Me.btnTopDeposit.Location = New System.Drawing.Point(91, 12)
        Me.btnTopDeposit.Name = "btnTopDeposit"
        Me.btnTopDeposit.Size = New System.Drawing.Size(75, 23)
        Me.btnTopDeposit.TabIndex = 2
        Me.btnTopDeposit.Text = "Deposit"
        Me.btnTopDeposit.UseVisualStyleBackColor = True
        '
        'btnTopWithdrawal
        '
        Me.btnTopWithdrawal.Location = New System.Drawing.Point(172, 12)
        Me.btnTopWithdrawal.Name = "btnTopWithdrawal"
        Me.btnTopWithdrawal.Size = New System.Drawing.Size(75, 23)
        Me.btnTopWithdrawal.TabIndex = 3
        Me.btnTopWithdrawal.Text = "Withdrawal"
        Me.btnTopWithdrawal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome to ATM!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your digital checkbook!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTopHistory
        '
        Me.btnTopHistory.Location = New System.Drawing.Point(254, 11)
        Me.btnTopHistory.Name = "btnTopHistory"
        Me.btnTopHistory.Size = New System.Drawing.Size(75, 23)
        Me.btnTopHistory.TabIndex = 5
        Me.btnTopHistory.Text = "History"
        Me.btnTopHistory.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 84)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Bank" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wallet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(147, 225)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 8
        '
        'txtWalletTotal
        '
        Me.txtWalletTotal.Location = New System.Drawing.Point(147, 183)
        Me.txtWalletTotal.Name = "txtWalletTotal"
        Me.txtWalletTotal.ReadOnly = True
        Me.txtWalletTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtWalletTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtWalletTotal.TabIndex = 7
        '
        'txtBankTotal
        '
        Me.txtBankTotal.Location = New System.Drawing.Point(147, 157)
        Me.txtBankTotal.Name = "txtBankTotal"
        Me.txtBankTotal.ReadOnly = True
        Me.txtBankTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBankTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtBankTotal.TabIndex = 6
        '
        'rbBankDeposit
        '
        Me.rbBankDeposit.AutoSize = True
        Me.rbBankDeposit.Location = New System.Drawing.Point(114, 165)
        Me.rbBankDeposit.Name = "rbBankDeposit"
        Me.rbBankDeposit.Size = New System.Drawing.Size(50, 17)
        Me.rbBankDeposit.TabIndex = 10
        Me.rbBankDeposit.Text = "Bank"
        Me.rbBankDeposit.UseVisualStyleBackColor = True
        Me.rbBankDeposit.Visible = False
        '
        'rbWalletDeposit
        '
        Me.rbWalletDeposit.AutoSize = True
        Me.rbWalletDeposit.Checked = True
        Me.rbWalletDeposit.Location = New System.Drawing.Point(170, 165)
        Me.rbWalletDeposit.Name = "rbWalletDeposit"
        Me.rbWalletDeposit.Size = New System.Drawing.Size(55, 17)
        Me.rbWalletDeposit.TabIndex = 11
        Me.rbWalletDeposit.TabStop = True
        Me.rbWalletDeposit.Text = "Wallet"
        Me.rbWalletDeposit.UseVisualStyleBackColor = True
        Me.rbWalletDeposit.Visible = False
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(114, 189)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(111, 20)
        Me.txtDeposit.TabIndex = 12
        Me.txtDeposit.Visible = False
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(114, 215)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(111, 23)
        Me.btnDeposit.TabIndex = 13
        Me.btnDeposit.Text = "Deposit Amount"
        Me.btnDeposit.UseVisualStyleBackColor = True
        Me.btnDeposit.Visible = False
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.Location = New System.Drawing.Point(114, 215)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(111, 23)
        Me.btnWithdrawal.TabIndex = 17
        Me.btnWithdrawal.Text = "Withdraw Amount"
        Me.btnWithdrawal.UseVisualStyleBackColor = True
        Me.btnWithdrawal.Visible = False
        '
        'txtWithdrawal
        '
        Me.txtWithdrawal.Location = New System.Drawing.Point(114, 189)
        Me.txtWithdrawal.Name = "txtWithdrawal"
        Me.txtWithdrawal.Size = New System.Drawing.Size(111, 20)
        Me.txtWithdrawal.TabIndex = 16
        Me.txtWithdrawal.Visible = False
        '
        'rbWalletWithdrawal
        '
        Me.rbWalletWithdrawal.AutoSize = True
        Me.rbWalletWithdrawal.Checked = True
        Me.rbWalletWithdrawal.Location = New System.Drawing.Point(170, 165)
        Me.rbWalletWithdrawal.Name = "rbWalletWithdrawal"
        Me.rbWalletWithdrawal.Size = New System.Drawing.Size(55, 17)
        Me.rbWalletWithdrawal.TabIndex = 15
        Me.rbWalletWithdrawal.TabStop = True
        Me.rbWalletWithdrawal.Text = "Wallet"
        Me.rbWalletWithdrawal.UseVisualStyleBackColor = True
        Me.rbWalletWithdrawal.Visible = False
        '
        'rbBankWithdrawal
        '
        Me.rbBankWithdrawal.AutoSize = True
        Me.rbBankWithdrawal.Location = New System.Drawing.Point(114, 165)
        Me.rbBankWithdrawal.Name = "rbBankWithdrawal"
        Me.rbBankWithdrawal.Size = New System.Drawing.Size(50, 17)
        Me.rbBankWithdrawal.TabIndex = 14
        Me.rbBankWithdrawal.Text = "Bank"
        Me.rbBankWithdrawal.UseVisualStyleBackColor = True
        Me.rbBankWithdrawal.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 403)
        Me.Controls.Add(Me.btnWithdrawal)
        Me.Controls.Add(Me.txtWithdrawal)
        Me.Controls.Add(Me.rbWalletWithdrawal)
        Me.Controls.Add(Me.rbBankWithdrawal)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.rbWalletDeposit)
        Me.Controls.Add(Me.rbBankDeposit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtWalletTotal)
        Me.Controls.Add(Me.txtBankTotal)
        Me.Controls.Add(Me.btnTopHistory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTopWithdrawal)
        Me.Controls.Add(Me.btnTopDeposit)
        Me.Controls.Add(Me.btnTopTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTopTotal As System.Windows.Forms.Button
    Friend WithEvents btnTopDeposit As System.Windows.Forms.Button
    Friend WithEvents btnTopWithdrawal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTopHistory As System.Windows.Forms.Button
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
    Friend WithEvents btnWithdrawal As System.Windows.Forms.Button
    Friend WithEvents txtWithdrawal As System.Windows.Forms.TextBox
    Friend WithEvents rbWalletWithdrawal As System.Windows.Forms.RadioButton
    Friend WithEvents rbBankWithdrawal As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
