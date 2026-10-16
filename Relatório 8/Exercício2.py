class HeroiOverwatch:
    def __init__(self, codinome: str, funcao: str):
        self.codinome = codinome
        self.funcao = funcao

    def usar_suprema(self):
        print(f"{self.codinome} ({self.funcao}) usou a ult")

class HeroiTanque(HeroiOverwatch):
    def usar_suprema(self):
        print(f"{self.codinome} ({self.funcao}) vai na frente para proteger!")

class HeroiSuporte(HeroiOverwatch):
    def usar_suprema(self):
        print(f"{self.codinome} ({self.funcao}), ult utilizada para ajudar!")

    def curar_equipe(self):
        print(f"{self.codinome} esta curando a equipe!")

if __name__ == "__main__":
    herois: list[HeroiOverwatch] = [
        HeroiOverwatch("drogoz", "dano"),
        HeroiTanque("terminus", "tanque"),
        HeroiSuporte("pip", "suporte"),
    ]

    for heroi in herois:
        heroi.usar_suprema()
        if isinstance(heroi, HeroiSuporte):
            heroi.curar_equipe()
