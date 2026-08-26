print("Digite a quantidade de elementos (N):")
local n = tonumber(io.read())
local contador = 0
local elementos = {}

for i = 1, n do
    print("Digite o " .. i .. ":")
    elementos[i] = tonumber(io.read())

end

print("Digite o número X a ser buscado:")
local x = tonumber(io.read())

for i = 1, n do
    if elementos[i] == x then
        contador = contador + 1
    end
    
end

if contador > 0 then
    print("O número " .. x .. " aparece " .. contador .. " vez(es) na tabela.")
else
    print("Numero não encontrado")
end
