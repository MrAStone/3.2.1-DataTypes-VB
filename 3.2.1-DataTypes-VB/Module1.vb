Module Module1

    Sub Main()
        ' Integer
        ' Default value 0
        Dim myNumber As Integer
        Dim myNumber2 As Integer = 20
        Dim myNumber3 As Integer = 10
        'Real - Different options - Any is acceptable
        ' Only difference is precision
        ' Default value 0
        Dim myDecimal As Decimal
        Dim mySingle As Single
        Dim myDouble As Double
        'Boolean
        ' Default value False
        Dim myBoolean As Boolean
        myBoolean = True
        'Character
        ' Default value "" (null)
        Dim myChar As Char
        myChar = "A"
        myChar = "ABC" ' will trim to first character only so stores A
        ' String
        ' Default value "" (null)
        Dim myString As String
        myString = "This is a string"
        myString = "" ' sets the value back to null

    End Sub

End Module
