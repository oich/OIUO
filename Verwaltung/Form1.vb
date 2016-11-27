Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles But_anlg.Click
        Dim pfad As String
        Dim kn_nr As String
        Dim kunde As String
        Dim af_nr As String
        Dim af_bez As String
        Dim kon As String

        pfad = "d:\verwaltung\"

        kn_nr = TE_KundenNR.Text
        kunde = TE_kunde.Text
        af_nr = TE_AuftragNR.Text
        af_bez = TE_bennenung.Text
        kon = TE_kontakt.Text



        If System.IO.Directory.Exists(pfad & kn_nr & "_" & kunde) = False Then
            System.IO.Directory.CreateDirectory(pfad & kn_nr & "_" & kunde)
        End If

        If System.IO.Directory.Exists(pfad & kn_nr & "_" & kunde & "\" & kn_nr & "." & af_nr & "_" & af_bez & "_" & kon) = False Then
            System.IO.Directory.CreateDirectory(pfad & kn_nr & "_" & kunde & "\" & kn_nr & "." & af_nr & "_" & af_bez & "_" & kon)
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
