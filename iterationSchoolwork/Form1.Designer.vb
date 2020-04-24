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
        Me.menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuBar
        '
        Me.menuBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.menuBar.Controls.Add(Me.minimiseButton)
        Me.menuBar.Controls.Add(Me.exitButton)
        Me.menuBar.Location = New System.Drawing.Point(0, 1)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(442, 33)
        Me.menuBar.TabIndex = 0
        '
        'minimiseButton
        '
        Me.minimiseButton.Location = New System.Drawing.Point(393, 3)
        Me.minimiseButton.Name = "minimiseButton"
        Me.minimiseButton.Size = New System.Drawing.Size(20, 20)
        Me.minimiseButton.TabIndex = 1
        Me.minimiseButton.Text = "_"
        Me.minimiseButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(419, 3)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(20, 20)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "x"
        Me.exitButton.UseVisualStyleBackColor = True
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
        Me.textConsole1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
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
        Me.yearsButton.Location = New System.Drawing.Point(12, 61)
        Me.yearsButton.Name = "yearsButton"
        Me.yearsButton.Size = New System.Drawing.Size(75, 23)
        Me.yearsButton.TabIndex = 3
        Me.yearsButton.Text = "Years"
        Me.yearsButton.UseVisualStyleBackColor = True
        '
        'moneyButton
        '
        Me.moneyButton.Location = New System.Drawing.Point(93, 61)
        Me.moneyButton.Name = "moneyButton"
        Me.moneyButton.Size = New System.Drawing.Size(75, 23)
        Me.moneyButton.TabIndex = 4
        Me.moneyButton.Text = "Money"
        Me.moneyButton.UseVisualStyleBackColor = True
        '
        'inputBox1
        '
        Me.inputBox1.Location = New System.Drawing.Point(34, 90)
        Me.inputBox1.Name = "inputBox1"
        Me.inputBox1.Size = New System.Drawing.Size(134, 20)
        Me.inputBox1.TabIndex = 5
        '
        'startButton
        '
        Me.startButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.Location = New System.Drawing.Point(12, 246)
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
        Me.Label1.Location = New System.Drawing.Point(12, 91)
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
        Me.Label2.Location = New System.Drawing.Point(124, 92)
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
        Me.Label3.Location = New System.Drawing.Point(9, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Starting money:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Interest rate"
        '
        'startingCash
        '
        Me.startingCash.Location = New System.Drawing.Point(34, 147)
        Me.startingCash.Name = "startingCash"
        Me.startingCash.Size = New System.Drawing.Size(134, 20)
        Me.startingCash.TabIndex = 11
        '
        'interestRate
        '
        Me.interestRate.Location = New System.Drawing.Point(12, 202)
        Me.interestRate.Name = "interestRate"
        Me.interestRate.Size = New System.Drawing.Size(134, 20)
        Me.interestRate.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 149)
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
        Me.Label6.Location = New System.Drawing.Point(147, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "%"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(443, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.interestRate)
        Me.Controls.Add(Me.startingCash)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.moneyButton)
        Me.Controls.Add(Me.yearsButton)
        Me.Controls.Add(Me.textConsole1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.menuBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.menuBar.ResumeLayout(False)
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
End Class
