Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If System.IO.File.Exists("C:\Sb\1.wav") Then
            My.Computer.Audio.Play("C:\Sb\1.wav")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If System.IO.File.Exists("C:\Sb\2.wav") Then
            My.Computer.Audio.Play("C:\Sb\2.wav")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If System.IO.File.Exists("C:\Sb\3.wav") Then
            My.Computer.Audio.Play("C:\Sb\3.wav")
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        System.Windows.Forms.Application.ExitThread()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Process.Start("C:\Sb\Docs.txt")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If System.IO.File.Exists("C:\Sb\4.wav") Then
            My.Computer.Audio.Play("C:\Sb\4.wav")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If System.IO.File.Exists("C:\Sb\5.wav") Then
            My.Computer.Audio.Play("C:\Sb\5.wav")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If System.IO.File.Exists("C:\Sb\6.wav") Then
            My.Computer.Audio.Play("C:\Sb\6.wav")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If System.IO.File.Exists("C:\Sb\7.wav") Then
            My.Computer.Audio.Play("C:\Sb\7.wav")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If System.IO.File.Exists("C:\Sb\8.wav") Then
            My.Computer.Audio.Play("C:\Sb\8.wav")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If System.IO.File.Exists("C:\Sb\9.wav") Then
            My.Computer.Audio.Play("C:\Sb\9.wav")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If System.IO.File.Exists("C:\Sb\10.wav") Then
            My.Computer.Audio.Play("C:\Sb\10.wav")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If System.IO.File.Exists("C:\Sb\11.wav") Then
            My.Computer.Audio.Play("C:\Sb\11.wav")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If System.IO.File.Exists("C:\Sb\12.wav") Then
            My.Computer.Audio.Play("C:\Sb\12.wav")
        End If
    End Sub
End Class
