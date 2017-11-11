"determinar si numero son capicua 
Dim num,num1 As String
		Dim snd As Integer
		snd = 0
		While snd <> 2
			Console.WriteLine("escribir numeros")
			num = CStr(Console.ReadLine)
			num1 = StrReverse(num)
			
			If num = -1 Then
				Reset
				
			ElseIf  num1 = num Then
				Console.ForegroundColor = ConsoleColor.Magenta
				Console.WriteLine("  si es capicua")
				Console.ResetColor
			Elseif num1 <>num Then
				Console.WriteLine("   no es capicua")
			ElseIf num = "-1" Then
				Console.ForegroundColor = ConsoleColor.Cyan
				Console.WriteLine("   el programa va terminar por ingresar -1")
				Console.ResetColor
			End If
			
			Do
				Console.ForegroundColor = ConsoleColor.Green
				Console.WriteLine("desea intentar con otro numero?")
				Console.WriteLine("     1 = si")
				Console.WriteLine("     2 = no ")
				Console.ResetColor
				Console.ForegroundColor = ConsoleColor.Red
				snd = Console.ReadLine()
		Console.ResetColor
			Loop Until snd>=1 And snd<=2 Or num = -1 
		
		End While
		
