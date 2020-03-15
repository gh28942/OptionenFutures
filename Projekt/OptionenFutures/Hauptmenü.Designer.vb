<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hauptmenü
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hauptmenü))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinomialOptionPricingonlinePdfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrundlagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegrationBerechnungsgrundlagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunktionsumfangBewertungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KurswertermittlungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 135)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(551, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Optionen auf einen Index-Future"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 187)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(551, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Optionen auf einen Zins-Future"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 239)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(551, 44)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Optionen auf einen Bond-Future"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Grundlagen", "Integration / Berechnungsgrundlagen", " Interpolation", " Forward Rates", " Zerobondabzinsungsfaktoren", "Funktionsumfang / Bewertung"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 28)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(456, 288)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "© by GerH 2020"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(16, 34)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(551, 94)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Cox Ross Rubinstein"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(583, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BinomialOptionPricingonlinePdfToolStripMenuItem, Me.GrundlagenToolStripMenuItem, Me.IntegrationBerechnungsgrundlagenToolStripMenuItem, Me.FunktionsumfangBewertungToolStripMenuItem, Me.KurswertermittlungToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'BinomialOptionPricingonlinePdfToolStripMenuItem
        '
        Me.BinomialOptionPricingonlinePdfToolStripMenuItem.Name = "BinomialOptionPricingonlinePdfToolStripMenuItem"
        Me.BinomialOptionPricingonlinePdfToolStripMenuItem.Size = New System.Drawing.Size(339, 26)
        Me.BinomialOptionPricingonlinePdfToolStripMenuItem.Text = "Binomial option pricing (online pdf)"
        '
        'GrundlagenToolStripMenuItem
        '
        Me.GrundlagenToolStripMenuItem.Name = "GrundlagenToolStripMenuItem"
        Me.GrundlagenToolStripMenuItem.Size = New System.Drawing.Size(339, 26)
        Me.GrundlagenToolStripMenuItem.Text = "Grundlagen"
        '
        'IntegrationBerechnungsgrundlagenToolStripMenuItem
        '
        Me.IntegrationBerechnungsgrundlagenToolStripMenuItem.Name = "IntegrationBerechnungsgrundlagenToolStripMenuItem"
        Me.IntegrationBerechnungsgrundlagenToolStripMenuItem.Size = New System.Drawing.Size(339, 26)
        Me.IntegrationBerechnungsgrundlagenToolStripMenuItem.Text = "Integration / Berechnungsgrundlagen"
        '
        'FunktionsumfangBewertungToolStripMenuItem
        '
        Me.FunktionsumfangBewertungToolStripMenuItem.Name = "FunktionsumfangBewertungToolStripMenuItem"
        Me.FunktionsumfangBewertungToolStripMenuItem.Size = New System.Drawing.Size(339, 26)
        Me.FunktionsumfangBewertungToolStripMenuItem.Text = "Funktionsumfang / Bewertung"
        '
        'KurswertermittlungToolStripMenuItem
        '
        Me.KurswertermittlungToolStripMenuItem.Name = "KurswertermittlungToolStripMenuItem"
        Me.KurswertermittlungToolStripMenuItem.Size = New System.Drawing.Size(339, 26)
        Me.KurswertermittlungToolStripMenuItem.Text = "Kurswertermittlung"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(339, 26)
        Me.InfoToolStripMenuItem.Text = "Über Optionen auf Futures..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 314)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Optionen auf Futures berechnen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BinomialOptionPricingonlinePdfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrundlagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntegrationBerechnungsgrundlagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunktionsumfangBewertungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KurswertermittlungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
End Class
