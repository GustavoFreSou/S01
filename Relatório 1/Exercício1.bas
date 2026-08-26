Dim peso As Integer
Dim meta As Integer
Dim ml As Integer
Print "--- META DE AGUA ---"
Input "QUAL O SEU PESO? ", peso
Input "QUANTIDADE DE AGUA INGERIDA (EM ML)? ", ml

meta = peso * 35

If ml >= meta Then
    Print "Meta atingida!"
Else
    Print "Meta nao atingida!"
End If
Sleep
