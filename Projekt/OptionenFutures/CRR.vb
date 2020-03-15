Public Class CRR
    Private Sub CRR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Input: 
            Dim Preis As Double = TextBox1.Text
            Dim untereGrenze As Double = TextBox2.Text
            Dim obereGrenze As Double = TextBox3.Text
            Dim R As Double = TextBox4.Text
            Dim T As Double = TextBox5.Text
            Dim ep As Double = TextBox6.Text

            'http://faculty.darden.virginia.edu/conroyb/derivatives/Binomial%20Option%20Pricing%20_f-0943_.pdf
            '75=Preis;
            '63=untereGrenze;
            '95=obereGrenze;   
            'R=0,06; 
            'T = Zinssatz = 0.0833
            'exercise price ep=65;

            '**negPayoff nP=untereGrenze-ep

            'P
            'COV=Call Option Value

            'eulersche Zahl
            Dim euler As Double = 2.7182818284590451

            Dim P As Double = (Preis * euler ^ (R * T) - untereGrenze) / (obereGrenze - untereGrenze)

            Dim nP As Double = untereGrenze - ep
            If (nP < 0) Then
                nP = 0
            End If

            Dim COV As Double = (P * (obereGrenze - ep) + (1 - P) * nP) * euler ^ (-R * T)

            MessageBox.Show("Call Optionswert = " & COV & "$ finanzieller Vorteil aus der sofortigen Ausübung der Option.")

        Catch ex As Exception
            MsgBox("Fehler - bitte korrekte Werte eingeben! " + vbNewLine + vbNewLine + ex.ToString)
        End Try
    End Sub

    'add text hint (PlaceHolder):
    Private Sub TextBox1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "75" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "75"
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub TextBox2_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "63" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox2_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "63"
            TextBox2.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub TextBox3_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        If TextBox3.Text = "95" Then
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox3_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        If TextBox3.Text = "" Then
            TextBox3.Text = "95"
            TextBox3.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub TextBox4_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.GotFocus
        If TextBox4.Text = "0,06" Then
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox4_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.LostFocus
        If TextBox4.Text = "" Then
            TextBox4.Text = "0,06"
            TextBox4.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub TextBox5_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.GotFocus
        If TextBox5.Text = "0,0833" Then
            TextBox5.Text = ""
            TextBox5.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox5_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If TextBox5.Text = "" Then
            TextBox5.Text = "0,0833"
            TextBox5.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub TextBox6_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.GotFocus
        If TextBox6.Text = "65" Then
            TextBox6.Text = ""
            TextBox6.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox6_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        If TextBox6.Text = "" Then
            TextBox6.Text = "65"
            TextBox6.ForeColor = Color.Gray
        End If
    End Sub
End Class