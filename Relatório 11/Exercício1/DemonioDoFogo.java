public class DemonioDoFogo extends Morador {

    public DemonioDoFogo(String nome) {
        super(nome);
    }

    @Override
    public void apresentar() {
        System.out.println("eu sou " + getNome()
                + ", a mulher do novo gta");
    }
}