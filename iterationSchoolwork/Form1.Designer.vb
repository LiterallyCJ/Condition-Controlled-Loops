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
        Me.menuBar = New System.Windows.Forms.Panel()
        Me.minimiseButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.textConsole1 = New System.Windows.Forms.TextBox()
        Me.yearsButton = New System.Windows.Forms.Button()
        Me.moneyButton = New System.Windows.Forms.Button()
        Me.inputBox1 = New System.Windows.Forms.TextBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.startingCash = New System.Windows.Forms.TextBox()
        Me.interestRate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.consoleLines = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.clearOutputButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.menuBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuBar
        '
        Me.menuBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.menuBar.Controls.Add(Me.minimiseButton)
        Me.menuBar.Controls.Add(Me.exitButton)
        Me.menuBar.Location = New System.Drawing.Point(0, 1)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(442, 33)
        Me.menuBar.TabIndex = 0
        '
        'minimiseButton
        '
        Me.minimiseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.minimiseButton.FlatAppearance.BorderSize = 0
        Me.minimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimiseButton.Location = New System.Drawing.Point(393, 3)
        Me.minimiseButton.Name = "minimiseButton"
        Me.minimiseButton.Size = New System.Drawing.Size(20, 20)
        Me.minimiseButton.TabIndex = 1
        Me.minimiseButton.Text = "_"
        Me.minimiseButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.exitButton.FlatAppearance.BorderSize = 0
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.Location = New System.Drawing.Point(419, 3)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(20, 20)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "x"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(12, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 5)
        Me.Panel2.TabIndex = 1
        '
        'textConsole1
        '
        Me.textConsole1.AcceptsReturn = True
        Me.textConsole1.AcceptsTab = True
        Me.textConsole1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.textConsole1.ForeColor = System.Drawing.Color.White
        Me.textConsole1.Location = New System.Drawing.Point(199, 61)
        Me.textConsole1.Multiline = True
        Me.textConsole1.Name = "textConsole1"
        Me.textConsole1.ReadOnly = True
        Me.textConsole1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textConsole1.ShortcutsEnabled = False
        Me.textConsole1.Size = New System.Drawing.Size(228, 371)
        Me.textConsole1.TabIndex = 2
        Me.textConsole1.TabStop = False
        Me.textConsole1.WordWrap = False
        '
        'yearsButton
        '
        Me.yearsButton.Location = New System.Drawing.Point(10, 6)
        Me.yearsButton.Name = "yearsButton"
        Me.yearsButton.Size = New System.Drawing.Size(75, 23)
        Me.yearsButton.TabIndex = 3
        Me.yearsButton.Text = "Years"
        Me.yearsButton.UseVisualStyleBackColor = True
        '
        'moneyButton
        '
        Me.moneyButton.Location = New System.Drawing.Point(91, 6)
        Me.moneyButton.Name = "moneyButton"
        Me.moneyButton.Size = New System.Drawing.Size(75, 23)
        Me.moneyButton.TabIndex = 4
        Me.moneyButton.Text = "Money"
        Me.moneyButton.UseVisualStyleBackColor = True
        '
        'inputBox1
        '
        Me.inputBox1.Location = New System.Drawing.Point(32, 37)
        Me.inputBox1.Name = "inputBox1"
        Me.inputBox1.Size = New System.Drawing.Size(134, 20)
        Me.inputBox1.TabIndex = 5
        '
        'startButton
        '
        Me.startButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.Location = New System.Drawing.Point(10, 191)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(156, 34)
        Me.startButton.TabIndex = 6
        Me.startButton.Text = "Begin"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "£"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(122, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "years"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Starting money:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Interest rate"
        '
        'startingCash
        '
        Me.startingCash.Location = New System.Drawing.Point(32, 92)
        Me.startingCash.Name = "startingCash"
        Me.startingCash.Size = New System.Drawing.Size(134, 20)
        Me.startingCash.TabIndex = 11
        '
        'interestRate
        '
        Me.interestRate.Location = New System.Drawing.Point(10, 147)
        Me.interestRate.Name = "interestRate"
        Me.interestRate.Size = New System.Drawing.Size(134, 20)
        Me.interestRate.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "£"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(145, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "%"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.interestRate)
        Me.Panel1.Controls.Add(Me.startingCash)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.inputBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.startButton)
        Me.Panel1.Controls.Add(Me.moneyButton)
        Me.Panel1.Controls.Add(Me.yearsButton)
        Me.Panel1.Location = New System.Drawing.Point(12, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 249)
        Me.Panel1.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.saveButton)
        Me.Panel3.Controls.Add(Me.consoleLines)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.clearOutputButton)
        Me.Panel3.Location = New System.Drawing.Point(12, 315)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(178, 116)
        Me.Panel3.TabIndex = 16
        '
        'consoleLines
        '
        Me.consoleLines.Location = New System.Drawing.Point(101, 44)
        Me.consoleLines.Name = "consoleLines"
        Me.consoleLines.ReadOnly = True
        Me.consoleLines.Size = New System.Drawing.Size(64, 20)
        Me.consoleLines.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Number of lines:"
        '
        'clearOutputButton
        '
        Me.clearOutputButton.Location = New System.Drawing.Point(10, 11)
        Me.clearOutputButton.Name = "clearOutputButton"
        Me.clearOutputButton.Size = New System.Drawing.Size(155, 24)
        Me.clearOutputButton.TabIndex = 0
        Me.clearOutputButton.Text = "Clear Output"
        Me.clearOutputButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(10, 78)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(154, 26)
        Me.saveButton.TabIndex = 3
        Me.saveButton.Text = "Save output to file"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(443, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.textConsole1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.menuBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.menuBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuBar As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents minimiseButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents textConsole1 As TextBox
    Friend WithEvents yearsButton As Button
    Friend WithEvents moneyButton As Button
    Friend WithEvents inputBox1 As TextBox
    Friend WithEvents startButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents startingCash As TextBox
    Friend WithEvents interestRate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents clearOutputButton As Button
    Friend WithEvents consoleLines As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents saveButton As Button
End Class
