Public Class Equation
    'INPUT
    Property a As Double
    Property b As Double
    Property c As Double
    'OUTPUT
    Property x1 As Double
    Property x2 As Double

    Public Sub New(pa As Double, pb As Double, pc As Double)
        Me.a = pa
        Me.b = pb
        Me.c = pc
        'Tambien podemos hacerlos asi "Me.a = pa : Me.b = pb : Me.c = pc"
    End Sub

    Public Function Calculate() As Double

        Dim delta As Double
        delta = Math.Pow(Me.b, 2) - 4 * Me.a * Me.c

        Select Case delta
            Case Is > 0
                Me.x1 = (-Me.b + delta) / (2 * Me.a)
                Me.x2 = (-Me.b - delta) / (2 * Me.a)
            Case Is = 0
                Me.x1 = (-Me.b) / (2 * Me.a)
            Case Is < 0
                Me.x1 = (-Me.b) / (2 * Me.a)
                Me.x2 = Math.Sqrt(-delta) / (2 * Me.a)
        End Select

        Return delta
    End Function


End Class
