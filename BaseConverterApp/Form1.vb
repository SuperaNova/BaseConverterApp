Imports System.Windows.Forms

Public Class TitlePage

    Private Sub _myCoolForms_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Me.Hide()
        ConverterPage.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub TitlePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
