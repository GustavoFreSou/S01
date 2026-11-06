public class Main {
    public static void main(String[] args) {
        Morador mago = new Mago("davy jones", "jogar gta");
        Morador demonio = new DemonioDoFogo("lucy");

        mago.apresentar();
        demonio.apresentar();

        //Morador generico = new Morador("fulano");
    }
}