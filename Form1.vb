'Joel's VanityGen GUI
'Donate 1JoeLXS1u44xJJSau59T5X93NPBEJmr3Ho
'bitcointalk.org user Joel.
'Thanks to https://github.com/samr7/vanitygen


Imports System.IO

Public Class Form1
    Shared OS As Integer
    Shared CMDfile As String
    Shared RunSettings As String
    Shared Home As String = Application.StartupPath()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        txtPrivateKey.Text = Nothing
        txtPublicKey.Text = Nothing

        Dim IlegalChar As String = Nothing
        Dim Legalreplacement As String = Nothing

        If txtPhrase.Text.Contains("0") Then
            IlegalChar = ("0")
        ElseIf txtPhrase.Text.Contains("O") Then
            IlegalChar = ("O")
            Legalreplacement = ("o")
        ElseIf txtPhrase.Text.Contains("I") Then
            IlegalChar = ("I")
            Legalreplacement = ("i")
        ElseIf txtPhrase.Text.Contains("l") Then
            IlegalChar = ("l")
            Legalreplacement = ("L")
        End If
        If Not IlegalChar = Nothing Then
            MsgBox("Whoops you have entered an Illegal Base58 Char """ & IlegalChar & """" & vbCrLf & "You could always use """ & Legalreplacement & """", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If

        lblSPLIT.Text = "|"

        If BackgroundWorker1.IsBusy Then
            If MsgBox("VanityKey is currently running would you like to kill the process?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                KillProcesses()
            Else
                Exit Sub
            End If

        Else

            If rbGPU.Checked = True Then
                CMDfile = "oclvanitygen.exe"
            ElseIf rbCPU.Checked = True Then
                If OS = 64 Then
                    CMDfile = "vanitygen64.exe"
                ElseIf OS = 32 Then
                    CMDfile = "vanitygen.exe"
                End If
            End If

            SetSettings()
            
        End If
    End Sub

    Private Sub SetSettings()
        RunSettings = " -v"

        If cbCase.Checked = False Then RunSettings = String.Concat(RunSettings, " -i")
        If cbKFind.Checked = True Then RunSettings = String.Concat(RunSettings, " -k")
        If cbOutput.Checked = True Then

            Dim sfdFileName As String

            If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                sfdFileName = SFD.FileName
                RunSettings = String.Concat(RunSettings, " -o " & sfdFileName)
            End If

        End If
        txtPhrase.Enabled = False
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork


        Dim pr As Process
        Try
            Dim Output As String
            Dim proc As ProcessStartInfo = New ProcessStartInfo("cmd.exe")

            proc.CreateNoWindow = True
            proc.UseShellExecute = False
            proc.RedirectStandardInput = True
            proc.RedirectStandardOutput = True
            pr = Process.Start(proc)

            Dim phrase As String = txtPhrase.Text
            If rbCPU.Checked = True Then phrase = "1" & phrase
            pr.StandardInput.WriteLine("cd " & Home & "\ProgFiles\")
            pr.StandardInput.WriteLine(CMDfile & RunSettings & " " & phrase)
            pr.StandardInput.Close()

            Do
                Output = (pr.StandardOutput.ReadLine)
                If Not (Output Is Nothing) Then
                    SetText(Output)
                End If
            Loop Until Output Is Nothing
            pr.StandardOutput.Close()
        Catch ex As Exception
            pr.StandardOutput.Close()
        End Try

      
    End Sub

    Delegate Sub SetTextCallback(ByVal OutputLine As String)
    Private Sub SetText(ByVal OutputLine As String)
        Dim PublicKey As String
        Dim PrivateKey As String
        Dim StatLine As String
        Dim Prob As Decimal
        Dim PercentinX As String
        Dim StatPer As Integer
        Dim StatHours As String



        If Me.TextBox1.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)

            Me.Invoke(d, New Object() {OutputLine})
        Else
            Me.TextBox1.AppendText(OutputLine & Environment.NewLine)


            If OutputLine.ToString.Contains("Address: ") Then
                PublicKey = OutputLine.Replace("Address: ", Nothing)
                txtPublicKey.Text = PublicKey
            ElseIf OutputLine.ToString.Contains("Privkey: ") Then
                PrivateKey = OutputLine.Replace("Privkey: ", Nothing)
                txtPrivateKey.Text = PrivateKey
            ElseIf OutputLine.ToString.Contains("Kkey/s") Then

                StatLine = OutputLine.Replace("[", Nothing)
                Dim Stats() As String = StatLine.Split("]")

                Prob = Stats(2).ToString.Replace("Prob", Nothing).Replace("%", Nothing)
                PercentinX = Stats(3).Replace(" in ", Nothing)
                Dim Split() As String = PercentinX.Split("%")
                StatPer = Split(0)
                StatHours = Split(1)

                Select Case StatHours
                    Case StatHours.Contains("d")
                        StatHours.Replace("d", Nothing)
                        StatHours *= 2
                        StatHours = StatHours & "d"
                    Case StatHours.Contains("h")
                        StatHours.Replace("h", Nothing)
                        StatHours *= 2
                        StatHours = StatHours & "h"
                    Case StatHours.Contains("min")
                        StatHours.Replace("min", Nothing)
                        StatHours *= 2
                        StatHours = StatHours & "min"
                    Case StatHours.Contains("s")
                        StatHours.Replace("s", Nothing)
                        StatHours *= 2
                        StatHours = StatHours & "s"
                End Select


                lblKBPS.Text = Stats(0)
                lblTotal.Text = Stats(1).ToString.Replace("total", "Total")
                ProgressBar.Value = Prob
            End If
        End If
    End Sub

    Private Sub TextBox4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrivateKey.GotFocus
        txtPrivateKey.PasswordChar = Nothing
    End Sub

    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrivateKey.LostFocus
        txtPrivateKey.PasswordChar = "•"
    End Sub

    Private Sub KillProcesses()
        Try
            If (BackgroundWorker1.IsBusy = True) Then
                BackgroundWorker1.CancelAsync()
            End If

            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = CMDfile.ToString.Replace(".exe", Nothing) Then
                    prog.Kill()
                End If
            Next
        Catch ex As Exception

        End Try
        txtPhrase.Enabled = True
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        KillProcesses()
    End Sub

    Private Sub ResetLabels()
        lblTotal.Text = Nothing
        lblSPLIT.Text = Nothing
        lblKBPS.Text = Nothing
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable Then
            If MsgBox("This machine is currently connected to the internet!  We would not advise creating or storing BitCoin wallets on a machine which is connected to the internet as it poses a risk." & vbCrLf & vbCrLf & "Although we advise users to use the Generator offline we do allow the application to be run whilst connected to the internet." & vbCrLf & vbCrLf & "Would you like to continue?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
                Me.Close()
            End If
        Else
            MsgBox("Status : Offline", MsgBoxStyle.Information, "Online Status")
        End If


        ResetLabels()
        CheckFilesANDFolders()

        If My.Settings.strPOWER = "CPU" Then
            rbCPU.Checked = True
        ElseIf My.Settings.strPOWER = "GPU" Then
            rbGPU.Checked = True
        End If

        If System.Environment.Is64BitOperatingSystem = True Then
            OS = 64
        Else
            OS = 32
        End If

        BackgroundWorker1.WorkerSupportsCancellation = True

    End Sub

    Private Function FileFound(ByVal Dir As String)
        If (File.Exists(Dir)) Then
            Return True
        Else
            Return False
        End If
    End Function



    Private Sub CheckFilesANDFolders()

        Dim oclvanitygen As String = Home & "\ProgFiles\oclvanitygen.exe"
        Dim vanitygen As String = Home & "\ProgFiles\vanitygen.exe"
        Dim vanitygen64 As String = Home & "\ProgFiles\vanitygen64.exe"

        Dim ErrorMsg As String

        'Check Program Directory Exists
        If Not Directory.Exists(Home & "\ProgFiles") Then
            ErrorMsg = ("Missing Directory!" & vbCrLf & Home & "\ProgFiles\")
            MsgBox(ErrorMsg, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        'Check Program Files
        If FileFound(oclvanitygen) = False Then
            ErrorMsg = ("File Not Found!" & vbCrLf & "Executable : oclvanitygen.exe" & vbCrLf & "Location : " & Home & "\ProgFiles\")
            MsgBox(ErrorMsg, MsgBoxStyle.Critical, "Error")
        End If
        If FileFound(vanitygen) = False Then
            ErrorMsg = ("File Not Found!" & vbCrLf & "Executable : vanitygen.exe" & vbCrLf & "Location : " & Home & "\ProgFiles\")
            MsgBox(ErrorMsg, MsgBoxStyle.Critical, "Error")
        End If
        If FileFound(vanitygen64) = False Then
            ErrorMsg = ("File Not Found!" & vbCrLf & "Executable : vanitygen64.exe" & vbCrLf & "Location : " & Home & "\ProgFiles\")
            MsgBox(ErrorMsg, MsgBoxStyle.Critical, "Error")
        End If
    End Sub


    Private Sub rbGPU_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGPU.CheckedChanged
        If rbGPU.Checked = True Then My.Settings.strPOWER = "GPU"
    End Sub

    Private Sub rbCPU_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCPU.CheckedChanged
        If rbCPU.Checked = True Then My.Settings.strPOWER = "CPU"
       
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressBar.Value = ProgressBar.Maximum
        txtPhrase.Enabled = True
        ResetLabels()
    End Sub

    Private Sub DonateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDonate.Click
        Dialog1.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblCPU.Text = "CPU " & Math.Round(CPUCounter.NextValue, 1) & "%"
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKFind.CheckedChanged
        If cbKFind.Checked = True Then
            cbOutput.Checked = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SFD.Filter = "TXT Files (*.txt*)|*.txt"
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SFD.FileName, _
             "Pattern:" & txtPhrase.Text _
             & vbCrLf & _
             "Public Key:" & txtPublicKey.Text _
             & vbCrLf & _
             "Private Key: " & txtPrivateKey.Text, True)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If IsFormOpen(Form2) Then
            Form2.txtOutput.Text = Me.TextBox1.Text
            Form2.txtOutput.Select(Form2.txtOutput.TextLength, 0)
            Form2.txtOutput.ScrollToCaret()
        End If
    End Sub

    Public Function IsFormOpen(ByVal frm As Form) As Boolean
        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub OutputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutputToolStripMenuItem.Click
        Form2.Show()
        Form2.txtOutput.Text = Me.TextBox1.Text
        Form2.txtOutput.ScrollToCaret()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class
