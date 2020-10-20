<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquationSolver
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
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblRoot1 = New System.Windows.Forms.Label()
        Me.lblRoot2 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblRoot1lol = New System.Windows.Forms.Label()
        Me.lblRoot2lol = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtB.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.ForeColor = System.Drawing.SystemColors.Control
        Me.txtB.Location = New System.Drawing.Point(70, 271)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 21)
        Me.txtB.TabIndex = 2
        Me.txtB.Text = "Parameter B"
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Tomato
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Bahnschrift", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculate.Location = New System.Drawing.Point(217, 209)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(173, 150)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblRoot1
        '
        Me.lblRoot1.AutoSize = True
        Me.lblRoot1.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoot1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRoot1.Location = New System.Drawing.Point(177, 426)
        Me.lblRoot1.Name = "lblRoot1"
        Me.lblRoot1.Size = New System.Drawing.Size(0, 21)
        Me.lblRoot1.TabIndex = 4
        '
        'lblRoot2
        '
        Me.lblRoot2.AutoSize = True
        Me.lblRoot2.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoot2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRoot2.Location = New System.Drawing.Point(177, 468)
        Me.lblRoot2.Name = "lblRoot2"
        Me.lblRoot2.Size = New System.Drawing.Size(0, 21)
        Me.lblRoot2.TabIndex = 5
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMessage.Location = New System.Drawing.Point(82, 507)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 24)
        Me.lblMessage.TabIndex = 6
        '
        'lblRoot1lol
        '
        Me.lblRoot1lol.AutoSize = True
        Me.lblRoot1lol.Font = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoot1lol.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRoot1lol.Location = New System.Drawing.Point(80, 420)
        Me.lblRoot1lol.Name = "lblRoot1lol"
        Me.lblRoot1lol.Size = New System.Drawing.Size(82, 29)
        Me.lblRoot1lol.TabIndex = 7
        Me.lblRoot1lol.Text = "Root1 :"
        '
        'lblRoot2lol
        '
        Me.lblRoot2lol.AutoSize = True
        Me.lblRoot2lol.Font = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoot2lol.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRoot2lol.Location = New System.Drawing.Point(80, 465)
        Me.lblRoot2lol.Name = "lblRoot2lol"
        Me.lblRoot2lol.Size = New System.Drawing.Size(86, 29)
        Me.lblRoot2lol.TabIndex = 8
        Me.lblRoot2lol.Text = "Root2 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(64, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 68)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Spicy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Equation Solver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(142, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Ax^2+Bx+C = 0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(57, 291)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(130, 1)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(130, 1)
        Me.Panel2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(57, 351)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(130, 1)
        Me.Panel3.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(130, 1)
        Me.Panel4.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(57, 233)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(130, 1)
        Me.Panel5.TabIndex = 13
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(130, 1)
        Me.Panel6.TabIndex = 12
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.ForeColor = System.Drawing.SystemColors.Control
        Me.txtA.Location = New System.Drawing.Point(70, 210)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 21)
        Me.txtA.TabIndex = 14
        Me.txtA.Text = "Parameter A"
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtC.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.ForeColor = System.Drawing.SystemColors.Control
        Me.txtC.Location = New System.Drawing.Point(70, 328)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 21)
        Me.txtC.TabIndex = 15
        Me.txtC.Text = "Parameter C"
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Tomato
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(395, 14)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(27, 28)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Tomato
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinimize.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMinimize.Location = New System.Drawing.Point(359, 14)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(27, 28)
        Me.btnMinimize.TabIndex = 17
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'frmEquationSolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 597)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRoot2lol)
        Me.Controls.Add(Me.lblRoot1lol)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblRoot2)
        Me.Controls.Add(Me.lblRoot1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEquationSolver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows form example practise 1"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.WhiteSmoke
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtB As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblRoot1 As Label
    Friend WithEvents lblRoot2 As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblRoot1lol As Label
    Friend WithEvents lblRoot2lol As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
End Class
