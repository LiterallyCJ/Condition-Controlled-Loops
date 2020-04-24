Public Class console
    Dim textConsole As TextBox

    Public Sub New(ByRef temp_textConsole As TextBox)
        textConsole = temp_textConsole
    End Sub

    Public Sub Log(ByVal input As String)
        textConsole.AppendText($"{Environment.NewLine}{input}")
    End Sub

    Public Sub Clear()
        textConsole.Clear()
    End Sub

End Class