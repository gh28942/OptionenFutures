Public Class browserpdf

    Private Sub browserpdf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'previous URL (now deleted): http://faculty.darden.virginia.edu/conroyb/derivatives/Binomial%20Option%20Pricing%20_f-0943_.pdf
        WebBrowser1.Navigate("http://web.archive.org/web/20150218144800/http://faculty.darden.virginia.edu/conroyb/derivatives/Binomial%20Option%20Pricing%20_f-0943_.pdf")
    End Sub
End Class