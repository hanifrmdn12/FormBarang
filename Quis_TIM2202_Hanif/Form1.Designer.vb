<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CboKode = New ComboBox()
        TxtNama = New TextBox()
        TxtHarga = New TextBox()
        TxtSatuan = New TextBox()
        TxtJumlah = New TextBox()
        TxtTotal = New TextBox()
        TxtBonus = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kode Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nama Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 2
        Label3.Text = "Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 25)
        Label4.TabIndex = 3
        Label4.Text = "Satuan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 25)
        Label5.TabIndex = 4
        Label5.Text = "Jumlah Beli"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(8, 260)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 25)
        Label6.TabIndex = 5
        Label6.Text = "Total Harga"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(8, 313)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 25)
        Label7.TabIndex = 6
        Label7.Text = "Bonus"
        ' 
        ' CboKode
        ' 
        CboKode.FormattingEnabled = True
        CboKode.Location = New Point(154, 12)
        CboKode.Name = "CboKode"
        CboKode.Size = New Size(182, 33)
        CboKode.TabIndex = 7
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(154, 61)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(182, 31)
        TxtNama.TabIndex = 8
        ' 
        ' TxtHarga
        ' 
        TxtHarga.Location = New Point(154, 110)
        TxtHarga.Name = "TxtHarga"
        TxtHarga.Size = New Size(182, 31)
        TxtHarga.TabIndex = 9
        ' 
        ' TxtSatuan
        ' 
        TxtSatuan.Location = New Point(154, 160)
        TxtSatuan.Name = "TxtSatuan"
        TxtSatuan.Size = New Size(182, 31)
        TxtSatuan.TabIndex = 10
        ' 
        ' TxtJumlah
        ' 
        TxtJumlah.Location = New Point(154, 207)
        TxtJumlah.Name = "TxtJumlah"
        TxtJumlah.Size = New Size(182, 31)
        TxtJumlah.TabIndex = 11
        ' 
        ' TxtTotal
        ' 
        TxtTotal.Location = New Point(154, 257)
        TxtTotal.Name = "TxtTotal"
        TxtTotal.Size = New Size(182, 31)
        TxtTotal.TabIndex = 12
        ' 
        ' TxtBonus
        ' 
        TxtBonus.Location = New Point(154, 310)
        TxtBonus.Name = "TxtBonus"
        TxtBonus.Size = New Size(182, 31)
        TxtBonus.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtBonus)
        Controls.Add(TxtTotal)
        Controls.Add(TxtJumlah)
        Controls.Add(TxtSatuan)
        Controls.Add(TxtHarga)
        Controls.Add(TxtNama)
        Controls.Add(CboKode)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "22110043_Hanif Ramadhan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CboKode As ComboBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtSatuan As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtBonus As TextBox

End Class
