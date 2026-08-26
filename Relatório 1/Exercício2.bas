Dim pin As Integer
Dim digito As Integer
pin = 4321
Input "DIGITE O PIN: ", digito

While digito <> pin
    Print "PIN invalido. Tente novamente."
    Input "DIGITE O PIN: ", digito
Wend

Print "Transacao autorizada!"
Sleep
