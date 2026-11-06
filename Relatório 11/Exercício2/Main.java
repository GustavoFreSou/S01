public class Main {
    public static void main(String[] args) {
        ItemDoCardapio cafe = new ItemDoCardapio("cafe com leite", 12.0);
        ItemDoCardapio curry = new ItemDoCardapio("bolo de cenoura", 30.0);
        ComboLeblanc combo = new ComboLeblanc("como bolo + cafe com leite", 40.0);

        CafeLeblanc leblanc = new CafeLeblanc();
        leblanc.adicionar(cafe);
        leblanc.adicionar(curry);
        leblanc.adicionar(combo);

        leblanc.mostrarCardapio();
    }
}