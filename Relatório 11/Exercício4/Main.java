public class Main {
    public static void main(String[] args) {
        Slime slime = new Slime("slime");
        Mandragora mandragora = new Mandragora("mandragora");

        Cozinheiro senshi = new Cozinheiro("fogaca", "inox");
        senshi.adicionarIngrediente(slime);
        senshi.adicionarIngrediente(mandragora);

        senshi.servirBanquete();
    }
}