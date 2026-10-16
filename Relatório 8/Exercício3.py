class Persona:
    def __init__(self, nome: str, arcano: str):
        self.nome = nome
        self.arcano = arcano

    def invocar(self):
        print(f"persona: {self.nome}  arcano: {self.arcano}")

class Aliado:
    def __init__(self, nomereal: str, codinome: str):
        self.nomereal = nomereal
        self.codinome = codinome

class Lider:
    def __init__(self, codinome: str):
        self.codinome = codinome
        self.persona = Persona("Arsène", "Louco")
        self._equipe = []

    def recrutar(self, aliado: Aliado):
        self._equipe.append(aliado)

    def infiltrar(self, palacio):
        print(f"{self.codinome} invadiu o palacio de {palacio}!")
        self.persona.invocar()
        print("equipe:")
        for aliado in self._equipe:
            print(f"{aliado.codinome} ({aliado.nomereal})")

if __name__ == "__main__":
    ryuji = Aliado("ryuji sakamoto", "skull")
    ann = Aliado("ann takamaki", "panther")

    joker = Lider("joker")
    joker.recrutar(ryuji)
    joker.recrutar(ann)
    joker.infiltrar("kamoshida")


#composicao: a persona é criada dentro do lider e só existe enquanto ele existir.
#agregacao: os aliados são criados fora e só são recrutados, existem sem o lider.
