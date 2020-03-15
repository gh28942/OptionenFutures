Public Class Kurswert

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        Dim SVSFlagsAsync = 1
        SAPI.Speak("für Optionen auf einen Index-Future: Kurswert = Anzahl Kontrakte mal Indexpunktwert mal Future-Option für Optionen auf einen Zins-Future: Kurswert = Anzahl Kontrakte mal Kontraktnominal durch 100 mal Future-Option mal M durch 12 (M entspricht der Laufzeit der zugrundeliegenden Forward-Zinsperiode in Monaten) für Optionen auf einen Bond-Future: Kurswert = Anzahl Kontrakte mal Kontraktnominal durch 100 mal Future-Option", SVSFlagsAsync)
    End Sub
End Class