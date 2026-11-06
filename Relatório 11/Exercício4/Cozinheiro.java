import java.util.ArrayList;

public class Cozinheiro {
    private String nome;
    private Panela panela;
    private ArrayList<Monstro> ingredientes;

    public Cozinheiro(String nome, String materialDaPanela) {
        this.nome = nome;
        this.panela = new Panela(materialDaPanela);
        this.ingredientes = new ArrayList<>();
    }

    public void adicionarIngrediente(Monstro monstro) {
        ingredientes.add(monstro);
    }

    public void servirBanquete() {
        System.out.println("cozinheiro " + nome + " panela de " + panela.getMaterial());
        for (Monstro m : ingredientes) {
            System.out.println( m.getNome() + ": " + m.receita());
        }
    }

    // composicao: a panela e criada com new dentro do cozinheiro, nasce e morre com ele.
    // agregacao: os monstros sao criados fora e so recebidos prontos, existem sem o cozinheiro.
}
