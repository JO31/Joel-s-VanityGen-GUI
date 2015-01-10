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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnView = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDonate = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSPLIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblKBPS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCPU = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrivateKey = New System.Windows.Forms.TextBox()
        Me.txtPublicKey = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtPhrase = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rbGPU = New System.Windows.Forms.RadioButton()
        Me.rbCPU = New System.Windows.Forms.RadioButton()
        Me.CPUCounter = New System.Diagnostics.PerformanceCounter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbCase = New System.Windows.Forms.CheckBox()
        Me.cbKFind = New System.Windows.Forms.CheckBox()
        Me.cbOutput = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPUCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFile, Me.btnView, Me.btnDonate, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(450, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnFile
        '
        Me.btnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(37, 20)
        Me.btnFile.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(95, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnView
        '
        Me.btnView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutputToolStripMenuItem})
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(44, 20)
        Me.btnView.Text = "View"
        '
        'OutputToolStripMenuItem
        '
        Me.OutputToolStripMenuItem.Name = "OutputToolStripMenuItem"
        Me.OutputToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.OutputToolStripMenuItem.Text = "Output"
        '
        'btnDonate
        '
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(57, 20)
        Me.btnDonate.Text = "Donate"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTotal, Me.lblSPLIT, Me.lblKBPS, Me.lblCPU})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 216)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(450, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblTotal
        '
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 17)
        Me.lblTotal.Text = "<NULL>"
        '
        'lblSPLIT
        '
        Me.lblSPLIT.Name = "lblSPLIT"
        Me.lblSPLIT.Size = New System.Drawing.Size(10, 17)
        Me.lblSPLIT.Text = "|"
        '
        'lblKBPS
        '
        Me.lblKBPS.Name = "lblKBPS"
        Me.lblKBPS.Size = New System.Drawing.Size(52, 17)
        Me.lblKBPS.Text = "<NULL>"
        '
        'lblCPU
        '
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(321, 17)
        Me.lblCPU.Spring = True
        Me.lblCPU.Text = "CPU N/A%"
        Me.lblCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(533, 107)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(445, 108)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Private Key :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Public Key :"
        '
        'txtPrivateKey
        '
        Me.txtPrivateKey.Location = New System.Drawing.Point(82, 156)
        Me.txtPrivateKey.Name = "txtPrivateKey"
        Me.txtPrivateKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPrivateKey.ReadOnly = True
        Me.txtPrivateKey.Size = New System.Drawing.Size(358, 20)
        Me.txtPrivateKey.TabIndex = 5
        '
        'txtPublicKey
        '
        Me.txtPublicKey.Location = New System.Drawing.Point(82, 130)
        Me.txtPublicKey.Name = "txtPublicKey"
        Me.txtPublicKey.ReadOnly = True
        Me.txtPublicKey.Size = New System.Drawing.Size(358, 20)
        Me.txtPublicKey.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Phrase :"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 186)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(259, 23)
        Me.ProgressBar.TabIndex = 3
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(365, 186)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 11
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(284, 186)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtPhrase
        '
        Me.txtPhrase.Location = New System.Drawing.Point(82, 85)
        Me.txtPhrase.Name = "txtPhrase"
        Me.txtPhrase.Size = New System.Drawing.Size(251, 20)
        Me.txtPhrase.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 50)
        Me.Panel1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Joel's VanityGen GUI"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'rbGPU
        '
        Me.rbGPU.AutoSize = True
        Me.rbGPU.Location = New System.Drawing.Point(392, 86)
        Me.rbGPU.Name = "rbGPU"
        Me.rbGPU.Size = New System.Drawing.Size(48, 17)
        Me.rbGPU.TabIndex = 17
        Me.rbGPU.Text = "GPU"
        Me.rbGPU.UseVisualStyleBackColor = True
        '
        'rbCPU
        '
        Me.rbCPU.AutoSize = True
        Me.rbCPU.Checked = True
        Me.rbCPU.Location = New System.Drawing.Point(339, 86)
        Me.rbCPU.Name = "rbCPU"
        Me.rbCPU.Size = New System.Drawing.Size(47, 17)
        Me.rbCPU.TabIndex = 16
        Me.rbCPU.TabStop = True
        Me.rbCPU.Text = "CPU"
        Me.rbCPU.UseVisualStyleBackColor = True
        '
        'CPUCounter
        '
        Me.CPUCounter.CategoryName = "Processor"
        Me.CPUCounter.CounterName = "% Processor Time"
        Me.CPUCounter.InstanceName = "_Total"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'cbCase
        '
        Me.cbCase.AutoSize = True
        Me.cbCase.Checked = True
        Me.cbCase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCase.Location = New System.Drawing.Point(82, 109)
        Me.cbCase.Name = "cbCase"
        Me.cbCase.Size = New System.Drawing.Size(100, 17)
        Me.cbCase.TabIndex = 18
        Me.cbCase.Text = "Case Sensetive"
        Me.cbCase.UseVisualStyleBackColor = True
        '
        'cbKFind
        '
        Me.cbKFind.AutoSize = True
        Me.cbKFind.Location = New System.Drawing.Point(188, 109)
        Me.cbKFind.Name = "cbKFind"
        Me.cbKFind.Size = New System.Drawing.Size(88, 17)
        Me.cbKFind.TabIndex = 20
        Me.cbKFind.Text = "Keep Finding"
        Me.cbKFind.UseVisualStyleBackColor = True
        '
        'cbOutput
        '
        Me.cbOutput.AutoSize = True
        Me.cbOutput.Location = New System.Drawing.Point(282, 109)
        Me.cbOutput.Name = "cbOutput"
        Me.cbOutput.Size = New System.Drawing.Size(84, 17)
        Me.cbOutput.TabIndex = 21
        Me.cbOutput.Text = "Output Keys"
        Me.cbOutput.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Options :"
        '
        'SFD
        '
        Me.SFD.Filter = """TXT Files (*.txt*)|*.txt"
        Me.SFD.Title = "Save As"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 238)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbOutput)
        Me.Controls.Add(Me.cbKFind)
        Me.Controls.Add(Me.cbCase)
        Me.Controls.Add(Me.rbGPU)
        Me.Controls.Add(Me.rbCPU)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtPhrase)
        Me.Controls.Add(Me.txtPublicKey)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtPrivateKey)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Joel's VanityGen GUI (BETA)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPUCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDonate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblKBPS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCPU As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrivateKey As System.Windows.Forms.TextBox
    Friend WithEvents txtPublicKey As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtPhrase As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSPLIT As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents rbGPU As System.Windows.Forms.RadioButton
    Friend WithEvents rbCPU As System.Windows.Forms.RadioButton
    Friend WithEvents CPUCounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cbCase As System.Windows.Forms.CheckBox
    Friend WithEvents cbKFind As System.Windows.Forms.CheckBox
    Friend WithEvents cbOutput As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
