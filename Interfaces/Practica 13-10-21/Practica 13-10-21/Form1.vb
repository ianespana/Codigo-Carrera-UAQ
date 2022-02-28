Public Class frmEstructuras
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim num As Integer

        Dim dia As String

        'Entrada de datos
        num = Val(tbNumero.Text)

        'Proceso

        Select Case (num)

            Case 1

                dia = "Lunes"

            Case 2

                dia = "Martes"

            Case 3

                dia = "Miércoles"

            Case 4

                dia = "Jueves"

            Case 5

                dia = "Viernes"

            Case 6
                dia = "Sabado"
            Case 7
                dia = "Domingo"
            Case Else
                dia = "ERROR, captura otro número"
        End Select
        'Salida de datos
        tbDia.Text = dia

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tbDia.Clear()
        tbNumero.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
