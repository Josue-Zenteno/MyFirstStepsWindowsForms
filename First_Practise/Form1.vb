Public Class frmEquationSolver
    Private Eq As Equation
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Eq = New Equation(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text), Convert.ToDouble(txtC.Text))
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        Select Case Eq.Calculate
            Case Is > 0
                lblRoot1.Text = Eq.x1.ToString("#.##")
                lblRoot2.Text = Eq.x2.ToString("#.##")
                lblMessage.Text = "Two real roots"
            Case Is = 0
                lblRoot1.Text = Eq.x1.ToString("#.##")
                lblRoot2.Text = Eq.x2.ToString("#.##")
                lblMessage.Text = "Two real roots"
            Case Is < 0
                lblRoot1.Text = Eq.x1.ToString("#.##") & "+" & Eq.x2.ToString("#.##") & "i"
                lblRoot2.Text = Eq.x2.ToString("#.##") & "+" & Eq.x2.ToString("#.##") & "i"
                lblMessage.Text = "Two complex roots"
        End Select

    End Sub

    Private Sub txtA_Click(sender As Object, e As EventArgs) Handles txtA.Click
        txtA.Clear()
        txtA.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub txtB_Click(sender As Object, e As EventArgs) Handles txtB.Click
        txtB.Clear()
    End Sub

    Private Sub txtC_Click(sender As Object, e As EventArgs) Handles txtC.Click
        txtC.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmEquationSolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
