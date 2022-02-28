Public Class frmEpilepsia
    Private num As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (num Mod 2 = 0) Then
            lbClaro.Visible = True
            lbOscuro.Visible = False
        Else
            lbClaro.Visible = False
            lbOscuro.Visible = True

        End If
        num = num + 1

    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEpilepsia.Click
        Timer1.Enabled = True
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnNoEpilepsia.Click
        Timer1.Enabled = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbAhora.Text = TimeOfDay
    End Sub
End Class
