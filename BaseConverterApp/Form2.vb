Imports System.Buffers.Text
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms
Imports System.Numerics

Public Class ConverterPage

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ConverterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaseFrom.SelectedIndex = 0
        BaseTo.SelectedIndex = 0
    End Sub

    Private Sub BackTitleButton_Click(sender As Object, e As EventArgs) Handles BackTitleButton.Click
        Me.Hide()
        TitlePage.Show()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        InputValue.Clear()
        OutputValue.Clear()
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        If OutputValue.Text <> String.Empty Then
            Clipboard.SetText(OutputValue.Text)
        End If
    End Sub

    Private Sub PasteButton_Click(sender As Object, e As EventArgs) Handles PasteButton.Click
        Dim clipboardText As String = Clipboard.GetText()
        Dim input As String = ""

        For Each c As Char In clipboardText
            Select Case BaseFrom.SelectedIndex
                Case 0 ' Decimal
                    If Char.IsDigit(c) Then
                        input &= c
                    Else
                        MessageBox.Show("Invalid character detected. Paste cancelled.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                Case 1 ' Binary
                    If c = "0" Or c = "1" Then
                        input &= c
                    Else
                        MessageBox.Show("Invalid character detected. Paste cancelled.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                Case 2 ' Octal
                    If Char.IsDigit(c) And c <= "7" Then
                        input &= c
                    Else
                        MessageBox.Show("Invalid character detected. Paste cancelled.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                Case 3 ' Hexadecimal
                    If (Char.IsDigit(c) And c <= "7") Or
                   (Char.IsLetter(c) And (c >= "A" And c <= "F") Or (c >= "a" And c <= "f")) Then
                        input &= c
                    Else
                        MessageBox.Show("Invalid character detected. Paste cancelled.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
            End Select
        Next

        InputValue.Text = input
    End Sub


    Private Sub InputValue_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles InputValue.KeyPress
        Select Case BaseFrom.SelectedIndex
            Case 0 ' Decimal
                If Not (e.KeyChar >= "0" AndAlso e.KeyChar <= "9") And Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If
            Case 1 ' Binary
                If Not (e.KeyChar = "0" Or e.KeyChar = "1") And Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If
            Case 2 ' Octal
                If Not (e.KeyChar >= "0" AndAlso e.KeyChar <= "7") And Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If
            Case 3 ' Hexadecimal
                If Not (e.KeyChar >= "0" AndAlso e.KeyChar <= "9") AndAlso
                   Not (e.KeyChar >= "A" AndAlso e.KeyChar <= "F") AndAlso
                   Not (e.KeyChar >= "a" AndAlso e.KeyChar <= "f") And Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If
        End Select
    End Sub

    Private Sub BaseFrom_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles BaseFrom.SelectedIndexChanged
        InputValue.Clear()
    End Sub

    Private Sub BaseTo_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles BaseTo.SelectedIndexChanged
        OutputValue.Clear()
    End Sub

    Private Function ConvertBaseNToDecimal(inputString As String, baseN As BigInteger) As BigInteger
        If inputString Is Nothing Then
            Throw New ArgumentNullException("inputString")
        End If
        If baseN < 2 Or baseN > 36 Then
            Throw New ArgumentOutOfRangeException("baseN", "The base must be between 2 and 36, inclusive.")
        End If
        If inputString.Length = 0 Then
            Return 0
        End If

        Dim num As BigInteger = 0
        Dim power As BigInteger = 1

        For i As Integer = inputString.Length - 1 To 0 Step -1
            Dim charCode As Integer = AscW(inputString(i))

            If charCode >= 48 AndAlso charCode <= 57 Then
                ' Digit
                Dim digit As Integer = charCode - 48
                num += digit * power
                power *= baseN
            ElseIf Char.IsLetter(inputString(i)) Then
                Dim digit As Integer

                Select Case charCode
                    Case 65 To 90 ' A-Z
                        digit = charCode - 55
                    Case 97 To 122 ' a-z
                        digit = charCode - 87
                    Case Else
                        Return -1
                End Select

                num += digit * power
                power *= baseN
            Else
                Return -1
            End If
        Next
        Return num
    End Function

    Private Function HexToDecimal(hexVal As String) As BigInteger
        Dim len As Integer = hexVal.Length
        Dim dec_val As BigInteger = 0
        Dim base As BigInteger = 1

        For i As Integer = len - 1 To 0 Step -1
            Dim charCode As Long = AscW(hexVal.Chars(i))

            If charCode >= 48 AndAlso charCode <= 57 Then
                dec_val += (charCode - 48) * base
                base *= 16
            ElseIf charCode >= 65 AndAlso charCode <= 70 Then
                dec_val += (charCode - 55) * base
                base *= 16
            ElseIf charCode >= 97 AndAlso charCode <= 102 Then
                dec_val += (charCode - 87) * base
                base *= 16
            Else
                Return -1
            End If
        Next

        Return dec_val
    End Function

    Private Function DecimalToBase(decimalValue As Long, baseTo As Integer) As String
        Dim numerals = "0123456789ABCDEF"
        Dim remainder As Integer

        Dim output As String = ""

        While decimalValue > 0
            remainder = decimalValue Mod baseTo
            decimalValue = decimalValue \ baseTo
            output = String.Concat(numerals(remainder), output)
        End While

        Return output
    End Function

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        Dim input As String = InputValue.Text

        Dim baseFromIndex As Integer = BaseFrom.SelectedIndex
        Dim baseToIndex As Integer = BaseTo.SelectedIndex

        Dim trans_dec As BigInteger

        Select Case baseFromIndex
            Case 0
                trans_dec = ConvertBaseNToDecimal(input, 10)
            Case 1
                trans_dec = ConvertBaseNToDecimal(input, 2)
            Case 2
                trans_dec = ConvertBaseNToDecimal(input, 8)
            Case 3
                trans_dec = HexToDecimal(input)
            Case Else
                Throw New ArgumentException("Invalid baseFrom index")
        End Select

        ' Check for overflow
        If trans_dec < 0 Or trans_dec > BigInteger.Pow(2, 63) - 1 Then
            MessageBox.Show("The input number is too large. Please enter a smaller number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim inputCheck As Long
        If Not Long.TryParse(trans_dec.ToString(), inputCheck) OrElse inputCheck > Long.MaxValue OrElse inputCheck < Long.MinValue Then
            MessageBox.Show("The input number is too large. Please enter a smaller number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim output As String
        Select Case baseToIndex
            Case 0
                output = DecimalToBase(trans_dec, 10)
            Case 1
                output = DecimalToBase(trans_dec, 2)
            Case 2
                output = DecimalToBase(trans_dec, 8)
            Case 3
                output = DecimalToBase(trans_dec, 16)
            Case Else
                Throw New ArgumentException("Invalid baseTo index")
        End Select

        OutputValue.Text = output
    End Sub

End Class