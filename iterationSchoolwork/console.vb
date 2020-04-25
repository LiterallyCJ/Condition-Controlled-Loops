' Create a new class "console".
Public Class console
    ' Store a textbox as 'textConsole'.
    Dim textConsole As TextBox

    ' Get a textbox for textConsole in initialisation.
    Public Sub New(ByRef temp_textConsole As TextBox)
        textConsole = temp_textConsole
    End Sub

    ' Adds text to the console, with a new line.
    Public Sub Log(ByVal input As String)
        textConsole.AppendText($"{Environment.NewLine}{input}")
    End Sub

    ' Clears the console.
    Public Sub Clear()
        textConsole.Clear()
    End Sub

End Class
