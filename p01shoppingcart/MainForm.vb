Public Class MainForm

    Private total As Double = 0



    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button5.Text = "Camisa de algodon    $120"
        Button6.Text = "Blazer Mezcla de Lana   $240"
        Button7.Text = "Jersey Cuello Pico   $160"
        Button8.Text = "Polo Cuello Redondo   $70"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button5.Text = "Polo a Rayas Cuello Redondo $80"
        Button6.Text = "Chompa a Lana Cuello Redondo %150"
        Button7.Text = "Casaca de Jean  $220"
        Button8.Text = "Abrigo Mezcla Lana $270"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button5.Text = "Zapatos Oxford    $120"
        Button6.Text = "Zapatos Derby   $140"
        Button7.Text = "Botines   $160"
        Button8.Text = "Loafers   $80"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Button5.Text = "Reloj de Acero    $380"
        Button6.Text = "Cinturon de Cuero   $70"
        Button7.Text = "Billetera de cuero   $190"
        Button8.Text = "Gorra Clasica  $50"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        lblTituloProducto.Text = "Camisa de algodon"
        Label10.Text = "$ 120"
        Label12.Text = "XS  S  M  L  x"


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        lblTituloProducto.Text = "Blazer Mezcla de Lana"
        Label10.Text = "$ 240"
        Label12.Text = "XS  S  M  L  x"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        lblTituloProducto.Text = "Blazer Mezcla de Lana"
        Label10.Text = "$ 160"
        Label12.Text = "XS  S  M  L  x"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click


        total = total - 120
        lblTotal.Text = total


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        total = total + 120
        lblTotal.Text = total
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click


        total = total - 240
        lblTotal.Text = total
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click


        total = total + 240
        lblTotal.Text = total
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click


        total = total - 160
        lblTotal.Text = total
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click


        total = total + 160
        lblTotal.Text = total
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click


        total = total - 70
        lblTotal.Text = total
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click


        total = total + 70
        lblTotal.Text = total
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        lblTituloProducto.Text = "Blazer Mezcla de Lana"
        Label10.Text = "$ 70"
        Label12.Text = "XS  S  M  L  x"
    End Sub
End Class