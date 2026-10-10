Public Class Form1
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Btn2.Click, Btn3.Click,
            Btn4.Click,
        Btn5.Click, Btn6.Click, Btn7.Click,
        Btn8.Click, Btn9.Click, Btn10.Click

        Dim BtnValue As Button = CType(sender, Button)
        TextBox1.Text &= BtnValue.Text


    End Sub

    Private Sub Btn1_Zero(sender As Object, e As EventArgs) Handles Btn1.Click
        If TextBox1.Text = String.Empty Then

        Else
            TextBox1.Text &= "0"
        End If

    End Sub

    Private Sub Button11_Decimal(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text = String.Empty Then
            TextBox1.Text &= "0."
        ElseIf Not TextBox1.Text.Contains(".") Then
            TextBox1.Text &= "."
        End If

    End Sub

    Private Sub Button12_Clear(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = String.Empty


    End Sub

    Private Sub Operators(sender As Object, e As EventArgs) Handles ButtonPlus.Click, ButtonMinus.Click,
        ButtonMultiply.Click, ButtonDivide.Click
        TextBox1.Text &= CType(sender, Button).Text


    End Sub

    Private Sub Button13_EqualsClick(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Dim expression As String = TextBox1.Text
            Dim result As Object
            Dim table As New DataTable
            result = table.Compute(expression, String.Empty)
            TextBox1.Text = result.ToString
        Catch ex As Exception
            TextBox1.Text = "Error in Expression"

        End Try


    End Sub
End Class
