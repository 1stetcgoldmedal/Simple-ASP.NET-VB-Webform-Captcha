Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Public Class Captcha
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Clear()
        Response.ContentType = "image/jpeg"
        Dim Captcha As String = RandomString(New Random().Next(5, 10), True, True, True, True)
        Session("Captcha") = Captcha

        Dim bit As Bitmap = New Bitmap(250, 50)
        Dim g = Graphics.FromImage(bit)
        g.Clear(Color.White)
        Dim x = New Rectangle(0, 0, 250, 50)
        g.FillRectangle(New HatchBrush(HatchStyle.Cross, Color.LightGray, Color.White), x)
        g.SmoothingMode = SmoothingMode.AntiAlias

        g.DrawString(Captcha, New Font("Times New Roman", 24, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, New PointF(30, 10))
        g.Save()
        Dim stream As New MemoryStream
        bit.Save(Response.OutputStream, ImageFormat.Jpeg)
    End Sub
    Dim R As New Random
    Function RandomString(Length As Integer, sle As Boolean, cle As Boolean, num As Boolean, special As Boolean) As String
        Dim str As New StringBuilder
        If sle = True Then
            str.Append("abcdefghijklmnopqrstuvwxyz")
        End If
        If cle = True Then
            str.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        End If
        If num = True Then
            str.Append("0123456789")
        End If
        If special = True Then
            str.Append("!@#$%^&*()-_=+/<>{}[]`~.;:'""")
        End If
        Dim returnstring As New StringBuilder
        For i As Integer = 0 To Length
            returnstring.Append(str.ToString.Substring(R.Next(0, str.Length), 1))
        Next
        Return returnstring.ToString
    End Function
End Class