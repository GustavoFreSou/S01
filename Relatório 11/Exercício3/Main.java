public class Main {
    public static void main(String[] args) {
        Alienigena serpo = new Alienigena("et");
        EspiritoYoukai turbovovo = new EspiritoYoukai("gasparzinho");

        MapaDeAvistamentos mapa = new MapaDeAvistamentos();
        mapa.registrar("rua", turbovovo);
        mapa.registrar("milharal", serpo);

        mapa.investigar("rua");
        mapa.investigar("milharal");
        mapa.investigar("inatel");
    }
}