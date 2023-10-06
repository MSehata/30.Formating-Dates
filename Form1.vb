Imports System.Reflection.Emit

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        txtGeneralDate.Text = Format(Now, "General Date")
        txtLongDate.Text = Format(Now, "Long Date")
        txtShortDate.Text = Format(Now, "short Date")
        txtLongTime.Text = Format(Now, "Long Time")
        txtShortTime.Text = Format(Now, "Short Time")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
