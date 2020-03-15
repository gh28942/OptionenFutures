Imports System

Public Class Hauptmenü

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        zinsf.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        indexf.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Bondf.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CRR.Show()
    End Sub

    Private Sub BinomialOptionPricingonlinePdfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinomialOptionPricingonlinePdfToolStripMenuItem.Click
        browserpdf.Show()
    End Sub

    Private Sub GrundlagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrundlagenToolStripMenuItem.Click
        Grundlagen.Show()
    End Sub

    Private Sub IntegrationBerechnungsgrundlagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegrationBerechnungsgrundlagenToolStripMenuItem.Click
        Integration.Show()
    End Sub

    Private Sub FunktionsumfangBewertungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunktionsumfangBewertungToolStripMenuItem.Click
        Funktionsumfang.Show()
    End Sub

    Private Sub KurswertermittlungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KurswertermittlungToolStripMenuItem.Click
        Kurswert.Show()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        info.Show()
    End Sub

End Class
