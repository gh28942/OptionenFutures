Public Class Integration

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        Dim SVSFlagsAsync = 1
        SAPI.Speak("Zur Bewertung handelbarer Optionen müssen die Geschäftsdaten und alternativ eine Parcoupon oder Zerocouponzinsstrukturkurve in der Geschäftswährung für den Auswertungstag vorgegeben werden. Weiterhin müssen für die Bewertung von Optionen auf Futures die entsprechenden Marktwerte zur Bewertung des Underlyings (zum Beispiel die Indexwerte einer Option auf Aktienindexfutures) vorgegeben werden. Falls die Anzeigewährung von der Geschäftswährung der Option abweicht, wird der entsprechende Währungskurs benötigt. Falls der Horizont zeitlich nach dem Auswertungstag liegt und falls die Geschäftswährung von der Anzeigewährung abweicht, muß zur Berechnung eines Terminwährungskurses zum Laufzeitende eine Parcoupon- bzw. Zerocouponzinsstrukturkurve in der Anzeigewährung (Geld- bzw. Briefsätze) vorgegeben werden. Zur Berechnung der Eingangsparameter kommen folgende Verfahren zum Einsatz: Interpolation, Forward Rates, Zerobondabzinsungsfaktoren", SVSFlagsAsync)
    End Sub
End Class