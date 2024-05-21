Public Class Form1
    Private Sub CboKode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboKode.SelectedIndexChanged
        If CboKode.Text = "K001" Then
            TxtNama.Text = "Buku"
            TxtHarga.Text = "25000"
            TxtSatuan.Text = "Lusin"
        ElseIf CboKode.Text = "K002" Then
            TxtNama.Text = "Penggaris"
            TxtHarga.Text = "15000"
            TxtSatuan.Text = "Lusin"
        ElseIf CboKode.Text = "K003" Then
            TxtNama.Text = "Penghapus"
            TxtHarga.Text = "15000"
            TxtSatuan.Text = "Lusin"
        End If
    End Sub

    Private Sub TxtJumlah_TextChanged(sender As Object, e As EventArgs) Handles TxtJumlah.TextChanged

    End Sub

    Private Sub TxtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJumlah.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtTotal.Text = Val(TxtHarga.Text) * Val(TxtJumlah.Text)
            Dim bonus As String = ""
            If TxtJumlah.Text > 5 Then
                bonus = "Permen"
            Else
                bonus = "-"
            End If
            TxtBonus.Text = bonus
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboKode.Items.Add("K001")
        CboKode.Items.Add("K002")
        CboKode.Items.Add("K003")
    End Sub
End Class
