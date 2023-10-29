Imports System.Runtime.CompilerServices

Module Module1

    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim suma As Integer
        Console.WriteLine("Introduzca su primer numero: ")
        num1 = Console.ReadLine()
        If (num1 Mod 2 = 1) Then
            Console.WriteLine("Numero Impar, continue con el siguiente...")
        Else
            Console.WriteLine("Numero Par, por favor ingresar otro numero")

        End If

        Console.WriteLine("Introduzca su segundo numero: ")
        num2 = Console.ReadLine()

        If (num2 Mod 2 = 1) Then
            Console.WriteLine("Numero Impar, continue con el siguiente...")
        Else
            Console.WriteLine("Numero Par, por favor ingresar otro numero")
        End If

        suma = num1 + num2

        Console.WriteLine("La suma de los numeros impares es: " & suma)
        Console.ReadLine()
    End Sub

End Module
