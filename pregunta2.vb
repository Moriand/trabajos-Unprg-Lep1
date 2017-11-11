"ingresar dos numeros comprendidos entre a y b, talque a>b

Dim numA,numB,snt,aun,des As Integer
		snt = 0
		
		des=0
		While snt<>2
			Console.WriteLine("      escriba su primer numero")
			numA = CInt(Console.ReadLine())
			Console.WriteLine("      ahora escriba su ssegundo numeero")
			numB = CInt(Console.Readline())
			If numA > numB Then
				Console.WriteLine("              los numeros entre {0} y {1} es",numA,numB)
				aun = numA
				
				For aun = numA To numB Step -1
					Console.WriteLine("                    -------- {0}   ----- ",aun)
					
					
				Next
			
			End If
			 Console.ForegroundColor = ConsoleColor.Green
			Do
					Console.WriteLine("desea intentar con otro numero?")
					Console.WriteLine("     1 = si")
					Console.WriteLine("     2 = no ")
					Console.ResetColor
					Console.ForegroundColor = ConsoleColor.Red
					snt = Console.ReadLine()
					Console.ResetColor
			Loop Until snt>= 1 And snt<= 2			
			
			End While
