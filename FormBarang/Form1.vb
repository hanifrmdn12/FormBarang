Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbokode.Items.Add("B001")
        cbokode.Items.Add("B002")
        cbokode.Items.Add("B003")
    End Sub

    Sub ProsesPakai_If()
        If cbokode.Text = "B001" Then
            txtnama.Text = "Aqua 300ml"
            txtharga.Text = "3000"
        ElseIf cbokode.Text = "B002" Then
            txtnama.Text = "Le Mineral 300ml"
            txtharga.Text = "4000"
        ElseIf cbokode.Text = "B003" Then
            txtnama.Text = "Teh Pucuk 300ml"
            txtharga.Text = "3000"
        End If
    End Sub

    Private Sub cbokode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbokode.SelectedIndexChanged
        Select Case cbokode.Text
            Case "B001"
                txtnama.Text = "Aqua 300ml"
                txtharga.Text = "3000"
            Case "B002"
                txtnama.Text = "Le Mineral 300ml"
                txtharga.Text = "4000"
            Case "B001"
                txtnama.Text = "Teh Pucuk 300ml"
                txtharga.Text = "3000"
        End Select
    End Sub

    Private Sub txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged
        'txttotal.Text = Val(txtharga.Text) * Val(txtjumlah.Text)
    End Sub

    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txttotal.Text = Val(txtharga.Text) * Val(txtjumlah.Text)
        End If
    End Sub
End Class
