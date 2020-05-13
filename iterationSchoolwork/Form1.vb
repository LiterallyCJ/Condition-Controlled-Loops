Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form1


    ' Make window draggable.
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2

    ' Get User32.dll and import the functions SendMessage, and ReleaseCapture.
    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer

    End Function

    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean

    End Function

    ' This is the event that triggers when the mouse is held down on the menu bar.
    Private Sub menuBar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown, menuBar.MouseDown

        ' Check if the button being held down is the left mouse button (primary click)
        If (e.Button = MouseButtons.Left) Then
            ' Copy how windows usually makes the form dragabble.
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    ' When the exit button is clicked, it closes the environment, hence closing the application entirely.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Environment.Exit(0)
    End Sub

    ' When the minimize button is clicked, the window state is changed to minimized.
    Private Sub MinimiseButton_Click(sender As Object, e As EventArgs) Handles minimiseButton.Click
        Me.WindowState = WindowState.Minimized
    End Sub


    ' ===================================== CALCULATIONS AND BUTTONS HERE ============================================ '


    ' Use the console class created earlier (defining and initialising)
    Dim Console As console
    Public money As Boolean

    ' Runs when the form loads.
    ' Define both money and Console.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console = New console(textConsole1)
        money = True
    End Sub

    ' If the user selects years, then money will be false and vise versa.
    Private Sub YearsButton_Click(sender As Object, e As EventArgs) Handles yearsButton.Click
        money = False
        inputBox1.Size = New Size(106, 20)

        ' Makes the input box's location match the label's location.
        inputBox1.Location = New Point(Label1.Location.X, Label1.Location.Y)
    End Sub

    Private Sub MoneyButton_Click(sender As Object, e As EventArgs) Handles moneyButton.Click
        money = True
        inputBox1.Size = New Size(134, 20)

        ' Moves the input box to only barely cover the label.
        inputBox1.Location = New Point(Label2.Location.X - 90, Label2.Location.Y)
    End Sub

    Sub saveToFile()
        Try
            ' Gets the software's location, and finds the "saves" folder.
            Dim savePath As String = Application.StartupPath + "\saves\"
            ' Gets the current date and time.
            Dim saveTemplate As String = DateTime.Now.ToString("yyyy.MM.dd HH mm ss")

            ' If the directory doesn't exist, it exits the subroutine and tells the user.
            If Not Directory.Exists(savePath) Then
                MsgBox("You don't have a saves folder.")
                Exit Sub
            End If

            ' Gives the directory and file extension for the file.
            Dim saveFile = savePath + saveTemplate + ".txt"

            ' Creates a new file and writes the text from the console into it.
            Dim sw As New StreamWriter(saveFile)
            sw.Write(textConsole1.Text)

            ' Closes the StreamWriter completely.
            sw.Close()
            sw.Dispose()

            ' Asks the user if they want to see the save folder.
            Dim openSaveLocation As DialogResult = MessageBox.Show($"Data saved to: {saveFile} {Environment.NewLine} Open save folder?", "Save success!", MessageBoxButtons.YesNo)

            ' If the user says yes, then it opens up the save folder.
            If openSaveLocation = DialogResult.Yes Then
                Process.Start(savePath.Substring(0, savePath.Length - 1))
            End If

            ' If there is an error with creating or writing to the file, this error occurs.
        Catch ex As IOException
            MsgBox("An error has occured whilst trying to save your output to a file.")
        End Try
    End Sub

    ' Gets the number of lines on the console.
    Sub updateLines()
        consoleLines.Text = textConsole1.Lines.Length.ToString()
    End Sub

    Sub calculate()

        Try

            ' Using the <console>.Clear method I created earlier.
            Console.Clear()

            ' Saves the starting money and interest rate from the textboxes in the form.
            Dim startingMoney As Double = Double.Parse(startingCash.Text)
            Dim interest As Double = Double.Parse(interestRate.Text) / 100

            ' Creates a new variable for current money, which is seperate from the starting money.
            Dim currentMoney As Double = startingMoney
            ' Creates a variable to track what year it is.
            Dim year As Integer = 0

            ' If the user picked to provide a maximum amount of money.
            If money = True Then
                Dim moneyMax As Double = Double.Parse(inputBox1.Text)

                ' This bit of code keeps on running until the current money surpasses that of the max money wanted.
                Do While currentMoney < moneyMax

                    ' This adds the current money multiplied by the interest rate to itself.
                    currentMoney += currentMoney * interest

                    ' This logs it to the console.
                    Console.Log($"Year {year}: £{Convert.ToInt32(currentMoney).ToString("N0")}")

                    year += 1
                Loop

                ' If the user wanted to provide a maximum year.
            Else
                Dim yearMax As Integer = Integer.Parse(inputBox1.Text)

                ' Add 1 to the year, since the program also displays the amount of money on year 0.
                yearMax += 1

                Do While year < yearMax
                    currentMoney += currentMoney * interest
                    Console.Log($"Year {year}: £{Convert.ToInt32(currentMoney).ToString("N0")}")

                    year += 1
                Loop

            End If

            updateLines()

        Catch ex As OverflowException
            Console.Log("Amount of money has surpassed £2,147,483,647!")
        End Try
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        calculate()
    End Sub

    Private Sub ClearOutputButton_Click(sender As Object, e As EventArgs) Handles clearOutputButton.Click
        Console.Clear()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        saveToFile()
    End Sub
End Class
