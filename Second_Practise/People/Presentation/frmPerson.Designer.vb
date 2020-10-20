<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPersons
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnOpenDB = New System.Windows.Forms.Button()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.lstPersons = New System.Windows.Forms.ListBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDBSelect = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.pnlID = New System.Windows.Forms.Panel()
        Me.pnlName = New System.Windows.Forms.Panel()
        Me.lblSign = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOpenDB
        '
        Me.btnOpenDB.BackColor = System.Drawing.Color.Tomato
        Me.btnOpenDB.Enabled = False
        Me.btnOpenDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpenDB.Location = New System.Drawing.Point(66, 320)
        Me.btnOpenDB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpenDB.Name = "btnOpenDB"
        Me.btnOpenDB.Size = New System.Drawing.Size(232, 39)
        Me.btnOpenDB.TabIndex = 0
        Me.btnOpenDB.Text = "Connect!"
        Me.btnOpenDB.UseVisualStyleBackColor = False
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "OpenFileDialog1"
        '
        'lstPersons
        '
        Me.lstPersons.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lstPersons.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstPersons.ForeColor = System.Drawing.Color.Black
        Me.lstPersons.FormattingEnabled = True
        Me.lstPersons.ItemHeight = 21
        Me.lstPersons.Location = New System.Drawing.Point(53, 92)
        Me.lstPersons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstPersons.Name = "lstPersons"
        Me.lstPersons.Size = New System.Drawing.Size(260, 189)
        Me.lstPersons.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.Location = New System.Drawing.Point(441, 117)
        Me.txtID.Margin = New System.Windows.Forms.Padding(1)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(157, 21)
        Me.txtID.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(441, 179)
        Me.txtName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(157, 21)
        Me.txtName.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Tomato
        Me.btnAdd.Enabled = False
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Location = New System.Drawing.Point(369, 263)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 66)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Tomato
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Location = New System.Drawing.Point(492, 263)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 66)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Tomato
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(492, 342)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(1)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 66)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Tomato
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Location = New System.Drawing.Point(369, 342)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 66)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 119)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PersonID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(370, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'btnDBSelect
        '
        Me.btnDBSelect.BackColor = System.Drawing.Color.Tomato
        Me.btnDBSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDBSelect.Location = New System.Drawing.Point(66, 370)
        Me.btnDBSelect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDBSelect.Name = "btnDBSelect"
        Me.btnDBSelect.Size = New System.Drawing.Size(232, 39)
        Me.btnDBSelect.TabIndex = 10
        Me.btnDBSelect.Text = "Choose DB"
        Me.btnDBSelect.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Tomato
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(619, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Tomato
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinimize.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(588, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimize.TabIndex = 12
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'pnlID
        '
        Me.pnlID.BackColor = System.Drawing.Color.White
        Me.pnlID.Location = New System.Drawing.Point(429, 142)
        Me.pnlID.Name = "pnlID"
        Me.pnlID.Size = New System.Drawing.Size(180, 1)
        Me.pnlID.TabIndex = 13
        '
        'pnlName
        '
        Me.pnlName.BackColor = System.Drawing.Color.White
        Me.pnlName.Location = New System.Drawing.Point(429, 204)
        Me.pnlName.Name = "pnlName"
        Me.pnlName.Size = New System.Drawing.Size(180, 1)
        Me.pnlName.TabIndex = 14
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSign.Location = New System.Drawing.Point(597, 430)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(44, 20)
        Me.lblSign.TabIndex = 15
        Me.lblSign.Text = "Spicy"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(243, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(182, 36)
        Me.lblTitle.TabIndex = 16
        Me.lblTitle.Text = "Data Access"
        '
        'frmPersons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(659, 467)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSign)
        Me.Controls.Add(Me.pnlName)
        Me.Controls.Add(Me.pnlID)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDBSelect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lstPersons)
        Me.Controls.Add(Me.btnOpenDB)
        Me.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Databases - Project2"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenDB As Button
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents lstPersons As ListBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDBSelect As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents pnlID As Panel
    Friend WithEvents pnlName As Panel
    Friend WithEvents lblSign As Label
    Friend WithEvents lblTitle As Label
End Class
