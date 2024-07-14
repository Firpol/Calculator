Public Class Form1

    Dim Nachalo_vvoda_cifr As Boolean = True
    Dim Znak As String
    Dim pervoe, vtoroe As Double
    Private Sub Cifra_Click(sender As Object, e As EventArgs) Handles Button1.Click,
        Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click,
        Button7.Click, Button8.Click, Button9.Click, Button10.Click
        Dim Cifra As String = CType(sender, Button).Text
        If Cifra = 0 Then Nachalo_vvoda_cifr = False
        If Nachalo_vvoda_cifr = True Then
            TextBox1.Text = Cifra
            Nachalo_vvoda_cifr = False
            Exit Sub
        End If
        If Nachalo_vvoda_cifr = False Then TextBox1.Text = TextBox1.Text & Cifra

    End Sub
End Class
