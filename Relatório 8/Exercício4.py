from abc import ABC, abstractmethod

class IUnidadeDeRede(ABC):

    @abstractmethod
    def executar_invasao(self):
        pass

class Cyberdeck:
    def __init__(self, modelo: str):
        self.modelo = modelo

class OperadorNetrunner(IUnidadeDeRede):
    def __init__(self, nome: str, modelo_cyberdeck: str):
        self.nome = nome
        self.cyberdeck = Cyberdeck(modelo_cyberdeck)

    def executar_invasao(self):
        print(f"{self.nome} usa o cyberdeck {self.cyberdeck.modelo} e esta quebrando o gelo (ICE) de um servidor.")

class DroneDeVigilancia(IUnidadeDeRede):
    def __init__(self, codigo: str):
        self.codigo = codigo

    def executar_invasao(self):
        print(f"drone {self.codigo} esta interceptando o sinal da rede.")

class CelulaHacker:
    def __init__(self, nome: str, membros: list[IUnidadeDeRede]):
        self.nome = nome
        self.membros = membros

    def iniciar_ataque(self):
        print(f"celula {self.nome} iniciando ataque!")
        for membro in self.membros:
            membro.executar_invasao()

if __name__ == "__main__":
    netrunner = OperadorNetrunner("V", "Militech Mk.5")
    drone = DroneDeVigilancia("DRN-077")

    celula = CelulaHacker("Afterlife", [netrunner, drone])
    celula.iniciar_ataque()

    
    
    #unidade = IUnidadeDeRede()
