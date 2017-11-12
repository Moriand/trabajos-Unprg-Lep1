'ingresar notas y terminar cuando se ingresa 0 y calcula el promedio
Dim nota,sum,a As Integer
		Dim promedio As Double
		nota = 1		
		sum = 0
		a = 0
		
		While nota <> 0
			Console.WriteLine("      escribe tu nota") 
			nota = CInt(Console.ReadLine())
			If nota<>0 Then
				sum +=nota
				a +=1
			End If		
			
		End While
		promedio = ((sum)/a)
		Console.WriteLine("----------------------------------------")
		Console.ForegroundColor = ConsoleColor.Green
		Console.WriteLine("          el promedio es {0}", promedio)
		Console.ResetColor
