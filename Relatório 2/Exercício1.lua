print("Digite o expoente inicial:")
local m = tonumber(io.read())
print("Digite o expoente final:")
local n = tonumber(io.read())
print("Digite a base:")
local base = tonumber(io.read())

for i = m, n do
    print (base .. "^" .. i .. "=" .. base^i)

end
