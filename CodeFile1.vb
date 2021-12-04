Imports System.IO
Imports System.Text

Module Module1

    Public Sub Main()
        Dim inoutstringe As String = "Folllow instructions on github in docs.txt"
        Dim fileReader As String
        fileReader = "should"
        If Not System.IO.Directory.Exists("C:\Sb") Then
            System.IO.Directory.CreateDirectory("C:\Sb")
        End If
        If Not System.IO.File.Exists("C:\Sb\Docs.txt") Then
            System.IO.File.Create("C:\Sb\Docs.txt")
        End If
        If Not fileReader = My.Computer.FileSystem.ReadAllText("C:\Sb\Docs.txt") Then
            My.Computer.FileSystem.WriteAllText("C:\Sb\Docs.txt", inoutstringe, True)
        End If

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1)
    End Sub

End Module