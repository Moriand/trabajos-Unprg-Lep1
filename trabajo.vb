dim a as integer
dim formula as double
dim sent as integer

While sent <> 2
    
    console.writeline("desde que numero desea saber la sumatoria?")
    a = console.readline()
    if a <0 then
         console.writeline("por favor ingrese numeros mayores")
         a= console.readline()
    end if
    formula = (a-1)*4+1
    console.writeline("la sumatoria de {0}  es  {1}",a,formula)

    Do 
      console.writeline("Desea intentar con otro numero?")
      sent= console.readline()
      

    loop Until sent >= 1 And sent<= 2
    
End While

