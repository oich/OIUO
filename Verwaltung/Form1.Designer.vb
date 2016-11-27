<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.But_anlg = New System.Windows.Forms.Button()
        Me.TE_KundenNR = New System.Windows.Forms.TextBox()
        Me.TE_kunde = New System.Windows.Forms.TextBox()
        Me.TE_AuftragNR = New System.Windows.Forms.TextBox()
        Me.TE_bennenung = New System.Windows.Forms.TextBox()
        Me.TE_kontakt = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'But_anlg
        '
        Me.But_anlg.Location = New System.Drawing.Point(672, 77)
        Me.But_anlg.Name = "But_anlg"
        Me.But_anlg.Size = New System.Drawing.Size(75, 23)
        Me.But_anlg.TabIndex = 0
        Me.But_anlg.Text = "Anlegen"
        Me.But_anlg.UseVisualStyleBackColor = True
        '
        'TE_KundenNR
        '
        Me.TE_KundenNR.Location = New System.Drawing.Point(36, 77)
        Me.TE_KundenNR.Name = "TE_KundenNR"
        Me.TE_KundenNR.Size = New System.Drawing.Size(100, 20)
        Me.TE_KundenNR.TabIndex = 1
        '
        'TE_kunde
        '
        Me.TE_kunde.Location = New System.Drawing.Point(142, 77)
        Me.TE_kunde.Name = "TE_kunde"
        Me.TE_kunde.Size = New System.Drawing.Size(100, 20)
        Me.TE_kunde.TabIndex = 2
        '
        'TE_AuftragNR
        '
        Me.TE_AuftragNR.Location = New System.Drawing.Point(248, 77)
        Me.TE_AuftragNR.Name = "TE_AuftragNR"
        Me.TE_AuftragNR.Size = New System.Drawing.Size(100, 20)
        Me.TE_AuftragNR.TabIndex = 3
        '
        'TE_bennenung
        '
        Me.TE_bennenung.Location = New System.Drawing.Point(354, 77)
        Me.TE_bennenung.Name = "TE_bennenung"
        Me.TE_bennenung.Size = New System.Drawing.Size(100, 20)
        Me.TE_bennenung.TabIndex = 4
        '
        'TE_kontakt
        '
        Me.TE_kontakt.Location = New System.Drawing.Point(460, 77)
        Me.TE_kontakt.Name = "TE_kontakt"
        Me.TE_kontakt.Size = New System.Drawing.Size(100, 20)
        Me.TE_kontakt.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(566, 77)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 6
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(36, 104)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(206, 512)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(248, 104)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(206, 512)
        Me.ListView2.TabIndex = 8
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TE_kontakt)
        Me.Controls.Add(Me.TE_bennenung)
        Me.Controls.Add(Me.TE_AuftragNR)
        Me.Controls.Add(Me.TE_kunde)
        Me.Controls.Add(Me.TE_KundenNR)
        Me.Controls.Add(Me.But_anlg)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents But_anlg As Button
    Friend WithEvents TE_KundenNR As TextBox
    Friend WithEvents TE_kunde As TextBox
    Friend WithEvents TE_AuftragNR As TextBox
    Friend WithEvents TE_bennenung As TextBox
    Friend WithEvents TE_kontakt As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
End Class
