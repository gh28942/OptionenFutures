Public Class Grundlagen

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        Dim SVSFlagsAsync = 1
        SAPI.Speak("Der Marktpreisrechner für Optionen auf Futures kommt lediglich im Zusammenhang mit der Sensitivitätsanalyse und dem Value-at-Risk-Ansatz der Risikoanalyse zum Einsatz. Die Bewertung der Optionen auf Futures erfolgt analog der Bewertung von Futures, da auch diese über ein Margin-Account abgewickelt werden. Es erfolgt daher nur der Ausweis von Änderungsrisiken für Future-style-Optionen.", SVSFlagsAsync)
    End Sub
End Class