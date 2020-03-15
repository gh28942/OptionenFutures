Public Class indexf

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim anzKon As Double = TextBox1.Text
            Dim ipw As Double = TextBox2.Text
            Dim FutOpt As Double = TextBox3.Text

            'Kurswert = Anzahl Kontrakte * Indexpunktwert * Future-Option 
            Dim erg As Double = anzKon * ipw * FutOpt

            MessageBox.Show("Kurswert: " & erg)

        Catch ex As Exception
            MsgBox("Fehler - bitte korrekte Werte eingeben! " + vbNewLine + vbNewLine + ex.ToString)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class