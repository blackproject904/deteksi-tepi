Module Filtering
    Function rgb2gray(ByVal bmp As Bitmap, ByVal i As Integer, ByVal j As Integer) As Integer
        Dim r, g, b As Integer
        r = bmp.GetPixel(i, j).R
        g = bmp.GetPixel(i, j).G
        b = bmp.GetPixel(i, j).B
        Return (r + g + b) / 3
    End Function
End Module
