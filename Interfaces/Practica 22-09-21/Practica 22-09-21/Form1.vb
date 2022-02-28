Public Class frmOperaciones
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim num1, num2 As Double

        Dim suma, resta, mult, div, pot, raiz As Double

        num1 = Val(tbNumero1.Text)
        num2 = Val(tbNumero2.Text)

        suma = num1 + num2
        resta = num1 - num2
        mult = num1 * num2
        div = num1 / num2
        pot = Math.Pow(num1, num2)
        raiz = Math.Pow(num1, 1 / num2)

        tbSuma.Text = suma
        tbResta.Text = resta
        tbMult.Text = mult
        tbDiv.Text = div
        tbPot.Text = pot
        tbRaiz.Text = raiz
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tbNumero1.Clear()
        tbNumero2.Clear()
        tbSuma.Clear()
        tbResta.Clear()
        tbMult.Clear()
        tbDiv.Clear()
        tbPot.Clear()
        tbRaiz.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
