Dim consumo,tconsumo As Double
		Dim bono,sbono, fin As Integer
		fin=0
		bono=0
		tconsumo=0
		While fin<>2
			For index=1 To 20 
			Console.WriteLine("Ingresar tu consumo n°{0}",index)
			consumo = CDbl(Console.Readline())
			If consumo >= 50 Then
				bono +=1
			Else
				tconsumo +=consumo
				sbono +=1
				
				
			End If
			Next
			
			Console.ForegroundColor = ConsoleColor.Red
			Do
				
			    Console.writeLine("si desea terminar ingrese 2, de lo contrario ingrese 1")
			    fin= Console.ReadLine()
			    
			Loop Until fin>=1 And fin<=2
			Console.ResetColor
		End While
		Console.ForegroundColor= ConsoleColor.Yellow
		Console.WriteLine("Cantidad de clientes con bono {0}",bono)
		Console.ForegroundColor = ConsoleColor.Green
		Console.WriteLine("cantidad de clientes sin bono {0} ",sbono)
		Console.ResetColor
		Console.ForegroundColor = ConsoleColor.DarkBlue
		Console.WriteLine("Monto total {0} ", tconsumo)
		Console.ReadKey(True)
