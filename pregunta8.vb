"determinar si numero son capicua 
Dim num,num1 As String
		Dim snd As Integer
		snd = 0
		While snd <> 2
			Console.WriteLine("escribir numeros")
			num = CStr(Console.ReadLine)
			num1 = StrReverse(num)
			
			If num1 = num Then
				Console.WriteLine("  si es capicua")
			Else
				Console.WriteLine("   no es capicua")
			End If
			Console.ForegroundColor = ConsoleColor.Green
			Do
				Console.WriteLine("desea intentar con otro numero?")
				Console.WriteLine("     1 = si")
				Console.WriteLine("     2 = no ")
				Console.ResetColor
				Console.ForegroundColor = ConsoleColor.Red
				snd = Console.ReadLine()
Console.ResetColor
			Loop Until snd>=1 And snd<=2 
		
		End While
		
