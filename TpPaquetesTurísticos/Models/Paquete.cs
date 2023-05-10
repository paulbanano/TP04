class Paquete{
    public static string Hotel {get; private set;}
    public static string Aereo {get; private set;}
    public static string Excursion {get; private set;}

    public Paquete(string hotel, string aereo, string excursion){
        Hotel = hotel;
        Aereo = aereo;
        Excursion = excursion;
    }
}