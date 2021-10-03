Imports System.Drawing
Imports System.Drawing.Image
Public Class Index
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.Form.HasKeys Then
            If Not String.IsNullOrWhiteSpace(Request.Form.Get("captcha")) Then
                If String.Equals(Request.Form.Get("captcha"), Session("Captcha")) Then
                    L1.Text = ("Correct")
                Else
                    L1.Text = ("Wrong")
                End If
            End If
        End If
    End Sub

End Class