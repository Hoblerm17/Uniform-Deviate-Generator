Imports System.IO
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim FilePath As String
        Dim StreamWriter1 As StreamWriter
        Dim a As Double
        Dim n As Integer
        Dim b As Double
        Dim X0 As Double
        Dim Xn As Double
        Dim T As Double
        Dim XnPlus1 As Double
        Dim UniformNumber As Double
        Dim i As Integer

        FilePath = "FilePath.txt"
        StreamWriter1 = New StreamWriter(FilePath)
        n = 1000
        T = 2 ^ 47
        a = 2 ^ 9 + 1
        b = 29741096258473
        X0 = 762939453125

        Label1.Text = Str(n)
        Label2.Text = Str(a)
        Label3.Text = Str(b)
        Label4.Text = Str(X0)

        Xn = X0
        For i = 1 To n
            'Enter Code Here
        Next

        StreamWriter1.Close()
        TextBox1.Text = "Done"

    End Sub

End Class
