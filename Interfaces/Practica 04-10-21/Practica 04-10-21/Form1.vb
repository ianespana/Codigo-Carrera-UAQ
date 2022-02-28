Public Class frmCalculadora
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim num1, num2, num3, promedio As Double

        Dim situacion As String

        num1 = Val(tbNumero1.Text)
        num2 = Val(tbNumero2.Text)
        num3 = Val(tbNumero3.Text)

        promedio = (num1 * 3 + num2 * 4 + num3 * 2) / 9

        If (promedio >= 6.0) Then
            situacion = "Aprobado"
        Else
            situacion = "Reprobado"
        End If

        tbPromedio.Text = promedio
        tbSituacion.Text = situacion
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tbNumero1.Clear()
        tbNumero2.Clear()
        tbNumero3.Clear()
        tbPromedio.Clear()
        tbSituacion.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
