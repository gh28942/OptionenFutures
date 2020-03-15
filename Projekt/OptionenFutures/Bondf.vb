Public Class Bondf

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim anzKon As Double = TextBox1.Text
            Dim KontNom As Double = TextBox2.Text
            Dim FutOpt As Double = TextBox3.Text

            Dim erg As Double = anzKon * KontNom / 100 * FutOpt

            MessageBox.Show("Kurswert: " & erg)

        Catch ex As Exception
            MsgBox("Fehler - bitte korrekte Werte eingeben! " + vbNewLine + vbNewLine + ex.ToString)
        End Try
    End Sub
End Class