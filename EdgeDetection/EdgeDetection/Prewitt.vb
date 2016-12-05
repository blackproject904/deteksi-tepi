Public Class Prewitt
    Public F(1000, 1000), G(1000, 1000) As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bmp1, bmp2 As New Bitmap(PictureBox1.Image)
        Dim x As Integer
        For i = 0 To bmp1.Width - 1
            For j = 0 To bmp1.Height - 1
                x = rgb2gray(bmp1, i, j)
                bmp2.SetPixel(i, j, Color.FromArgb(x, x, x))
            Next
            PictureBox2.Image = bmp2
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim bmp1 As New Bitmap(PictureBox2.Image)
        Dim bmp2 As New Bitmap(bmp1.Width, bmp1.Height)
        Dim x As Integer
        For i = 0 To bmp1.Width - 1
            For j = 0 To bmp1.Height - 1
                F(i, j) = rgb2gray(bmp1, i, j)
            Next
        Next
        For j = 1 To bmp1.Width - 1
            For i = 1 To bmp1.Height - 1
                G(i, j) = Math.Sqrt((F(j - 1, i - 1) + F(j, i - 1) + F(j + 1, i - 1) -
                                     F(j, i) - F(j, i + 1) - F(j + 1, i + 1)) ^ 2 +
                                    (F(j + 1, i - 1) + F(j + 1, i) + F(j + 1, i + 1) -
                                    F(j - 1, i - 1) - F(j - 1, i) - F(j - 1, i + 1)) ^ 2)
                x = G(i, j)
                If x > 255 Then
                    x = 255
                End If
                bmp2.SetPixel(j, i, Color.FromArgb(x, x, x))
            Next
            PictureBox3.Image = bmp2
        Next
    End Sub
End Class
