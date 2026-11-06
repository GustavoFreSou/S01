public class Mago extends Morador {
    private String feitico;

    public Mago(String nome, String feitico) {
        super(nome);
        this.feitico = feitico;
    }

    @Override
    public void apresentar() {
        System.out.println("eu sou o mago " + getNome()
                + " e tenho o poder de: " + feitico);
    }
}