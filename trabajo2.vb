Dim a as integer
Dim b as string
Dim rest as integer
rest = 0
While rest <>2
Console.writeline("escribe numero ")
a = CStr(Console.ReadLine())
if a >= 1 then
Console.writeline("su numero invertido es ")
b = StrReverse(a)
Console.writeline("{0}",b)
End if
Do
 Console.writeline("deseas intentarlo nuevamente? 1= si 2= no")
 rest = Console.ReadLine()
Loop Until rest>=1 And rest<=2

  
End While