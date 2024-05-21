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
        cbokode = New ComboBox()
        txtnama = New TextBox()
        txttotal = New TextBox()
        txtjumlah = New TextBox()
        txtharga = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kode Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nama Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 2
        Label3.Text = "Jumlah Beli"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 3
        Label4.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 25)
        Label5.TabIndex = 4
        Label5.Text = "Total Harga"
        ' 
        ' cbokode
        ' 
        cbokode.FormattingEnabled = True
        cbokode.Location = New Point(200, 23)
        cbokode.Name = "cbokode"
        cbokode.Size = New Size(227, 33)
        cbokode.TabIndex = 5
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(200, 66)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(227, 31)
        txtnama.TabIndex = 6
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(200, 205)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(227, 31)
        txttotal.TabIndex = 7
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Location = New Point(200, 158)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.Size = New Size(227, 31)
        txtjumlah.TabIndex = 8
        ' 
        ' txtharga
        ' 
        txtharga.Location = New Point(200, 112)
        txtharga.Name = "txtharga"
        txtharga.Size = New Size(227, 31)
        txtharga.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(468, 282)
        Controls.Add(txtharga)
        Controls.Add(txtjumlah)
        Controls.Add(txttotal)
        Controls.Add(txtnama)
        Controls.Add(cbokode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbokode As ComboBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtharga As TextBox

End Class
