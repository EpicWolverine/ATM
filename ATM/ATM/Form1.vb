Imports System.Text
Imports System.IO

Public Class Form1

    Inherits System.Windows.Forms.Form
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Dim ResourceFilePath As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FilePath()
        Dim a, b As String
        Dim sr As New System.IO.StreamReader(ResourceFilePath & "\total.txt")

        Dim s As System.Text.StringBuilder
        a = sr.ReadLine
        s = New System.Text.StringBuilder(a)
        'add 0s
        If InStr(a.ToString, ".") = 0 Then
            s.Insert(s.Length, ".00")
        End If
        If InStr(a.ToString, ".1") <> 0 And InStr(a.ToString, ".11") = 0 And InStr(a.ToString, ".12") = 0 And InStr(a.ToString, ".13") = 0 And InStr(a.ToString, ".14") = 0 And InStr(a.ToString, ".15") = 0 And InStr(a.ToString, ".16") = 0 And InStr(a.ToString, ".17") = 0 And InStr(a.ToString, ".18") = 0 And InStr(a.ToString, ".19") = 0 Then
            s.Replace(".1", ".10")
        End If
        If InStr(a.ToString, ".2") <> 0 And InStr(a.ToString, ".21") = 0 And InStr(a.ToString, ".22") = 0 And InStr(a.ToString, ".23") = 0 And InStr(a.ToString, ".24") = 0 And InStr(a.ToString, ".25") = 0 And InStr(a.ToString, ".26") = 0 And InStr(a.ToString, ".27") = 0 And InStr(a.ToString, ".28") = 0 And InStr(a.ToString, ".29") = 0 Then
            s.Replace(".2", ".20")
        End If
        If InStr(a.ToString, ".3") <> 0 And InStr(a.ToString, ".31") = 0 And InStr(a.ToString, ".32") = 0 And InStr(a.ToString, ".33") = 0 And InStr(a.ToString, ".34") = 0 And InStr(a.ToString, ".35") = 0 And InStr(a.ToString, ".36") = 0 And InStr(a.ToString, ".37") = 0 And InStr(a.ToString, ".38") = 0 And InStr(a.ToString, ".39") = 0 Then
            s.Replace(".3", ".30")
        End If
        If InStr(a.ToString, ".4") <> 0 And InStr(a.ToString, ".41") = 0 And InStr(a.ToString, ".42") = 0 And InStr(a.ToString, ".43") = 0 And InStr(a.ToString, ".44") = 0 And InStr(a.ToString, ".45") = 0 And InStr(a.ToString, ".46") = 0 And InStr(a.ToString, ".47") = 0 And InStr(a.ToString, ".48") = 0 And InStr(a.ToString, ".49") = 0 Then
            s.Replace(".4", ".40")
        End If
        If InStr(a.ToString, ".5") <> 0 And InStr(a.ToString, ".51") = 0 And InStr(a.ToString, ".52") = 0 And InStr(a.ToString, ".53") = 0 And InStr(a.ToString, ".54") = 0 And InStr(a.ToString, ".55") = 0 And InStr(a.ToString, ".56") = 0 And InStr(a.ToString, ".57") = 0 And InStr(a.ToString, ".58") = 0 And InStr(a.ToString, ".59") = 0 Then
            s.Replace(".5", ".50")
        End If
        If InStr(a.ToString, ".6") <> 0 And InStr(a.ToString, ".61") = 0 And InStr(a.ToString, ".62") = 0 And InStr(a.ToString, ".63") = 0 And InStr(a.ToString, ".64") = 0 And InStr(a.ToString, ".65") = 0 And InStr(a.ToString, ".66") = 0 And InStr(a.ToString, ".67") = 0 And InStr(a.ToString, ".68") = 0 And InStr(a.ToString, ".69") = 0 Then
            s.Replace(".6", ".60")
        End If
        If InStr(a.ToString, ".7") <> 0 And InStr(a.ToString, ".71") = 0 And InStr(a.ToString, ".72") = 0 And InStr(a.ToString, ".73") = 0 And InStr(a.ToString, ".74") = 0 And InStr(a.ToString, ".75") = 0 And InStr(a.ToString, ".76") = 0 And InStr(a.ToString, ".77") = 0 And InStr(a.ToString, ".78") = 0 And InStr(a.ToString, ".79") = 0 Then
            s.Replace(".7", ".70")
        End If
        If InStr(a.ToString, ".8") <> 0 And InStr(a.ToString, ".81") = 0 And InStr(a.ToString, ".82") = 0 And InStr(a.ToString, ".83") = 0 And InStr(a.ToString, ".84") = 0 And InStr(a.ToString, ".85") = 0 And InStr(a.ToString, ".86") = 0 And InStr(a.ToString, ".87") = 0 And InStr(a.ToString, ".88") = 0 And InStr(a.ToString, ".89") = 0 Then
            s.Replace(".8", ".80")
        End If
        If InStr(a.ToString, ".9") <> 0 And InStr(a.ToString, ".91") = 0 And InStr(a.ToString, ".92") = 0 And InStr(a.ToString, ".93") = 0 And InStr(a.ToString, ".94") = 0 And InStr(a.ToString, ".95") = 0 And InStr(a.ToString, ".96") = 0 And InStr(a.ToString, ".97") = 0 And InStr(a.ToString, ".98") = 0 And InStr(a.ToString, ".99") = 0 Then
            s.Replace(".9", ".90")
        End If
        a = s.ToString
        txtBankTotal.Text = "$" & a

        b = sr.ReadLine
        s = New System.Text.StringBuilder(b)
        'add 0s
        If InStr(b.ToString, ".") = 0 Then
            s.Insert(s.Length, ".00")
        End If
        If InStr(b.ToString, ".1") <> 0 And InStr(b.ToString, ".11") = 0 And InStr(b.ToString, ".12") = 0 And InStr(b.ToString, ".13") = 0 And InStr(b.ToString, ".14") = 0 And InStr(b.ToString, ".15") = 0 And InStr(b.ToString, ".16") = 0 And InStr(b.ToString, ".17") = 0 And InStr(b.ToString, ".18") = 0 And InStr(b.ToString, ".19") = 0 Then
            s.Replace(".1", ".10")
        End If
        If InStr(b.ToString, ".2") <> 0 And InStr(b.ToString, ".21") = 0 And InStr(b.ToString, ".22") = 0 And InStr(b.ToString, ".23") = 0 And InStr(b.ToString, ".24") = 0 And InStr(b.ToString, ".25") = 0 And InStr(b.ToString, ".26") = 0 And InStr(b.ToString, ".27") = 0 And InStr(b.ToString, ".28") = 0 And InStr(b.ToString, ".29") = 0 Then
            s.Replace(".2", ".20")
        End If
        If InStr(b.ToString, ".3") <> 0 And InStr(b.ToString, ".31") = 0 And InStr(b.ToString, ".32") = 0 And InStr(b.ToString, ".33") = 0 And InStr(b.ToString, ".34") = 0 And InStr(b.ToString, ".35") = 0 And InStr(b.ToString, ".36") = 0 And InStr(b.ToString, ".37") = 0 And InStr(b.ToString, ".38") = 0 And InStr(b.ToString, ".39") = 0 Then
            s.Replace(".3", ".30")
        End If
        If InStr(b.ToString, ".4") <> 0 And InStr(b.ToString, ".41") = 0 And InStr(b.ToString, ".42") = 0 And InStr(b.ToString, ".43") = 0 And InStr(b.ToString, ".44") = 0 And InStr(b.ToString, ".45") = 0 And InStr(b.ToString, ".46") = 0 And InStr(b.ToString, ".47") = 0 And InStr(b.ToString, ".48") = 0 And InStr(b.ToString, ".49") = 0 Then
            s.Replace(".4", ".40")
        End If
        If InStr(b.ToString, ".5") <> 0 And InStr(b.ToString, ".51") = 0 And InStr(b.ToString, ".52") = 0 And InStr(b.ToString, ".53") = 0 And InStr(b.ToString, ".54") = 0 And InStr(b.ToString, ".55") = 0 And InStr(b.ToString, ".56") = 0 And InStr(b.ToString, ".57") = 0 And InStr(b.ToString, ".58") = 0 And InStr(b.ToString, ".59") = 0 Then
            s.Replace(".5", ".50")
        End If
        If InStr(b.ToString, ".6") <> 0 And InStr(b.ToString, ".61") = 0 And InStr(b.ToString, ".62") = 0 And InStr(b.ToString, ".63") = 0 And InStr(b.ToString, ".64") = 0 And InStr(b.ToString, ".65") = 0 And InStr(b.ToString, ".66") = 0 And InStr(b.ToString, ".67") = 0 And InStr(b.ToString, ".68") = 0 And InStr(b.ToString, ".69") = 0 Then
            s.Replace(".6", ".60")
        End If
        If InStr(b.ToString, ".7") <> 0 And InStr(b.ToString, ".71") = 0 And InStr(b.ToString, ".72") = 0 And InStr(b.ToString, ".73") = 0 And InStr(b.ToString, ".74") = 0 And InStr(b.ToString, ".75") = 0 And InStr(b.ToString, ".76") = 0 And InStr(b.ToString, ".77") = 0 And InStr(b.ToString, ".78") = 0 And InStr(b.ToString, ".79") = 0 Then
            s.Replace(".7", ".70")
        End If
        If InStr(b.ToString, ".8") <> 0 And InStr(b.ToString, ".81") = 0 And InStr(b.ToString, ".82") = 0 And InStr(b.ToString, ".83") = 0 And InStr(b.ToString, ".84") = 0 And InStr(b.ToString, ".85") = 0 And InStr(b.ToString, ".86") = 0 And InStr(b.ToString, ".87") = 0 And InStr(b.ToString, ".88") = 0 And InStr(b.ToString, ".89") = 0 Then
            s.Replace(".8", ".80")
        End If
        If InStr(b.ToString, ".9") <> 0 And InStr(b.ToString, ".91") = 0 And InStr(b.ToString, ".92") = 0 And InStr(b.ToString, ".93") = 0 And InStr(b.ToString, ".94") = 0 And InStr(b.ToString, ".95") = 0 And InStr(b.ToString, ".96") = 0 And InStr(b.ToString, ".97") = 0 And InStr(b.ToString, ".98") = 0 And InStr(b.ToString, ".99") = 0 Then
            s.Replace(".9", ".90")
        End If
        b = s.ToString
        txtWalletTotal.Text = "$" & b
        sr.Close()

        Dim c As Single = CSng(a) + CSng(b)
        s = New System.Text.StringBuilder(c.ToString)
        'add 0s
        If InStr(c.ToString, ".") = 0 Then
            s.Insert(s.Length, ".00")
        End If
        If InStr(c.ToString, ".1") <> 0 And InStr(c.ToString, ".11") = 0 And InStr(c.ToString, ".12") = 0 And InStr(c.ToString, ".13") = 0 And InStr(c.ToString, ".14") = 0 And InStr(c.ToString, ".15") = 0 And InStr(c.ToString, ".16") = 0 And InStr(c.ToString, ".17") = 0 And InStr(c.ToString, ".18") = 0 And InStr(c.ToString, ".19") = 0 Then
            s.Replace(".1", ".10")
        End If
        If InStr(c.ToString, ".2") <> 0 And InStr(c.ToString, ".21") = 0 And InStr(c.ToString, ".22") = 0 And InStr(c.ToString, ".23") = 0 And InStr(c.ToString, ".24") = 0 And InStr(c.ToString, ".25") = 0 And InStr(c.ToString, ".26") = 0 And InStr(c.ToString, ".27") = 0 And InStr(c.ToString, ".28") = 0 And InStr(c.ToString, ".29") = 0 Then
            s.Replace(".2", ".20")
        End If
        If InStr(c.ToString, ".3") <> 0 And InStr(c.ToString, ".31") = 0 And InStr(c.ToString, ".32") = 0 And InStr(c.ToString, ".33") = 0 And InStr(c.ToString, ".34") = 0 And InStr(c.ToString, ".35") = 0 And InStr(c.ToString, ".36") = 0 And InStr(c.ToString, ".37") = 0 And InStr(c.ToString, ".38") = 0 And InStr(c.ToString, ".39") = 0 Then
            s.Replace(".3", ".30")
        End If
        If InStr(c.ToString, ".4") <> 0 And InStr(c.ToString, ".41") = 0 And InStr(c.ToString, ".42") = 0 And InStr(c.ToString, ".43") = 0 And InStr(c.ToString, ".44") = 0 And InStr(c.ToString, ".45") = 0 And InStr(c.ToString, ".46") = 0 And InStr(c.ToString, ".47") = 0 And InStr(c.ToString, ".48") = 0 And InStr(c.ToString, ".49") = 0 Then
            s.Replace(".4", ".40")
        End If
        If InStr(c.ToString, ".5") <> 0 And InStr(c.ToString, ".51") = 0 And InStr(c.ToString, ".52") = 0 And InStr(c.ToString, ".53") = 0 And InStr(c.ToString, ".54") = 0 And InStr(c.ToString, ".55") = 0 And InStr(c.ToString, ".56") = 0 And InStr(c.ToString, ".57") = 0 And InStr(c.ToString, ".58") = 0 And InStr(c.ToString, ".59") = 0 Then
            s.Replace(".5", ".50")
        End If
        If InStr(c.ToString, ".6") <> 0 And InStr(c.ToString, ".61") = 0 And InStr(c.ToString, ".62") = 0 And InStr(c.ToString, ".63") = 0 And InStr(c.ToString, ".64") = 0 And InStr(c.ToString, ".65") = 0 And InStr(c.ToString, ".66") = 0 And InStr(c.ToString, ".67") = 0 And InStr(c.ToString, ".68") = 0 And InStr(c.ToString, ".69") = 0 Then
            s.Replace(".6", ".60")
        End If
        If InStr(c.ToString, ".7") <> 0 And InStr(c.ToString, ".71") = 0 And InStr(c.ToString, ".72") = 0 And InStr(c.ToString, ".73") = 0 And InStr(c.ToString, ".74") = 0 And InStr(c.ToString, ".75") = 0 And InStr(c.ToString, ".76") = 0 And InStr(c.ToString, ".77") = 0 And InStr(c.ToString, ".78") = 0 And InStr(c.ToString, ".79") = 0 Then
            s.Replace(".7", ".70")
        End If
        If InStr(c.ToString, ".8") <> 0 And InStr(c.ToString, ".81") = 0 And InStr(c.ToString, ".82") = 0 And InStr(c.ToString, ".83") = 0 And InStr(c.ToString, ".84") = 0 And InStr(c.ToString, ".85") = 0 And InStr(c.ToString, ".86") = 0 And InStr(c.ToString, ".87") = 0 And InStr(c.ToString, ".88") = 0 And InStr(c.ToString, ".89") = 0 Then
            s.Replace(".8", ".80")
        End If
        If InStr(c.ToString, ".9") <> 0 And InStr(c.ToString, ".91") = 0 And InStr(c.ToString, ".92") = 0 And InStr(c.ToString, ".93") = 0 And InStr(c.ToString, ".94") = 0 And InStr(c.ToString, ".95") = 0 And InStr(c.ToString, ".96") = 0 And InStr(c.ToString, ".97") = 0 And InStr(c.ToString, ".98") = 0 And InStr(c.ToString, ".99") = 0 Then
            s.Replace(".9", ".90")
        End If
        txtTotal.Text = "$" & s.ToString
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    'Deposit
    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        If txtDeposit.Text = "Deposited!" Then
            MsgBox("Ummmm....." & vbCrLf & "What should I deposit?")
            Exit Sub
        End If

        Dim s As System.Text.StringBuilder
        s = New System.Text.StringBuilder(txtDeposit.Text)
        s.Replace("$", "") 'remove $ if there is one

        'get values from file
        FilePath()
        Dim a, b As String
        Dim sr As New System.IO.StreamReader(ResourceFilePath & "\total.txt")
        a = sr.ReadLine 'Bank
        b = sr.ReadLine 'Wallet
        sr.Close()

        If rbBankDeposit.Checked = True Then 'if depositing in the bank
            Dim c As Decimal
            Try
                c = CDec(a) + CDec(s.ToString) 'add the cash
            Catch really As OverflowException
                MsgBox("Do you seriously expect me to believe that you have more than $79,228,162,514,264,337,593,543,950,335???")
                txtDeposit.Text = ""
                Exit Sub
            End Try
            Dim sw As New System.IO.StreamWriter(ResourceFilePath & "\total.txt") 'write to file
            sw.WriteLine(c.ToString)
            sw.WriteLine(b.ToString)
            sw.Close()
        ElseIf rbWalletDeposit.Checked = True Then 'if depositing in the wallet
            Dim c As Decimal
            Try
                c = CDec(b) + CDec(s.ToString) 'add the cash
            Catch really As OverflowException
                MsgBox("Do you seriously expect me to believe that you have more than $79,228,162,514,264,337,593,543,950,335???")
                txtDeposit.Text = ""
                Exit Sub
            End Try
            Dim sw As New System.IO.StreamWriter(ResourceFilePath & "\total.txt") 'write to file
            sw.WriteLine(a.ToString)
            sw.WriteLine(c.ToString)
            sw.Close()
        End If

        txtDeposit.Text = "Deposited!"
        Timer1.Start()
    End Sub

    'Withdrawal
    Private Sub btnWithdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtWithdraw.Text = "Withdrawed!" Then
            MsgBox("Ummmm....." & vbCrLf & "What should I withdraw?")
            Exit Sub
        End If

        Dim s As System.Text.StringBuilder
        s = New System.Text.StringBuilder(txtWithdraw.Text)
        s.Replace("$", "") 'remove $ if there is one

        'get values from file
        FilePath()
        Dim a, b As String
        Dim sr As New System.IO.StreamReader(ResourceFilePath & "\total.txt")
        a = sr.ReadLine 'Bank
        b = sr.ReadLine 'Wallet
        sr.Close()

        If rbBankWithdraw.Checked = True Then 'if Withdrawing in the bank
            Dim c As Single = CSng(a) - CSng(s.ToString) 'take out the cash
            Dim sw As New System.IO.StreamWriter(ResourceFilePath & "\total.txt") 'write to file
            sw.WriteLine(c.ToString)
            sw.WriteLine(b.ToString)
            sw.Close()
        ElseIf rbWalletWithdraw.Checked = True Then 'if Withdrawing in the wallet
            Dim c As Single = CSng(b) - CSng(s.ToString) 'take out the cash
            Dim sw As New System.IO.StreamWriter(ResourceFilePath & "\total.txt") 'write to file
            sw.WriteLine(a.ToString)
            sw.WriteLine(c.ToString)
            sw.Close()
        End If

        txtWithdraw.Text = "Withdrawed!"
        Timer1.Start()
    End Sub

    'History



    Sub FilePath()
        ' Determine the Resource File Path
        If System.Diagnostics.Debugger.IsAttached() Then
            'Debugging mode
            ResourceFilePath = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\resources\")
        Else
            'Published mode
            ResourceFilePath = Application.StartupPath & "\resources\"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtDeposit.Text = ""
        txtWithdraw.Text = ""
        Timer1.Stop()
    End Sub
End Class
