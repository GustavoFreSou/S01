print("Digite a quantidade de elementos (N):")
local n = tonumber(io.read())
local elementos = {}

for i = 1, n do
    print("Digite o elemento " .. i .. ":")
    elementos[i] = tonumber(io.read())
end

print("Digite o valor limite (K):")
local k = tonumber(io.read())

function filtrar(tabela, limite)
    local resultado = {}
    for i = 1, #tabela do
        if tabela[i] > limite then
            table.insert(resultado, tabela[i])
        end
    end
    return resultado
end

local maiores = filtrar(elementos, k)

print("-- Elementos maiores que " .. k .. " --")
if #maiores > 0 then
    for i = 1, #maiores do
        print(maiores[i])
    end
else
    print("Nenhum elemento maior que o digitado " )
end
