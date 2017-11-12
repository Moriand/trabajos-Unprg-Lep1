'ingresar puntaje de n alumnos y el que tenga mayor o igual a 320 es ingresante
Dim ptj, ap, dp, sum, fin As Integer
		fin = 0
		ap = 0
		dp = -1
		While fin<> 1
			Console.WriteLine("   ingrese puntaje --si desea terminar ingrese 1 ")
			ptj = CInt(Console.ReadLine())
			fin = ptj
			If ptj <=-1 Then
				Reset
			ElseIf ptj>=320 Then
				ap +=1
			ElseIf ptj < 320 Then
				dp +=1
				
				
			End If
			sum = ap+dp
		End While
		Console.WriteLine("--------------------------------")
		Console.WriteLine("--------------------------------")
		Console.WriteLine("    |la cantidad de aprobrados |")
		Console.ForegroundColor = ConsoleColor.Green
		Console.WriteLine("               {0}",ap)
		Console.ResetColor
		Console.ForegroundColor = ConsoleColor.Red
		Console.WriteLine("    | cantidad de desaprobados |")
		Console.ForegroundColor = ConsoleColor.Red
		Console.WriteLine("                {0}",dp)
		Console.ResetColor
		Console.WriteLine("--------------------------------")
		Console.WriteLine("    | procentaje de desaprobados |")
		Console.WriteLine("                {0}",(dp/sum)*100)
		Console.WriteLine("    | procentaje de aprobados |")
		Console.WriteLine("                {0}",(da/sum)*100)
		
		Console.ReadKey
