class ORTWorld{
    public static List<string> ListaDestinos {get; private set;} = new List <string>{
        "Medillin", "Misiones", "Mendoza", "Los Angeles", "Berlin", "Tel Aviv", "Amsterdam", "Roma", "Bariloche", "Tokyo"
    } ;
    public static List<string> ListaHoteles {get; private set;} = new List<string>{
        "Hotel1.jpg", "Hotel2.jpg", "Hotel3.jfif", "Hotel4.jfif", "Hotel5.jpg", "Hotel6.jpg", "Hotel7.jpg", "Hotel8.jpg", "Hotel9.jfif", "Hotel10.jpg" 
    } ;
    public static List<string> ListaAereos {get; private set;} = new List<string>{
        "Aerolinea1.jpeg", "Aerolinea2.png", "Aerolinea3.png", "Aerolinea4.png", "Aerolinea5.png", "Aerolinea6.png", "Aerolinea7.jpg", "Aerolinea8.png", "Aerolinea9.png", "Aerolinea10.png"};
    public static List<string> ListaExcursiones {get; private set;} = new List<string>{
        "Excursion1.jfif","Excursion2.jfif", "Excursion3.jpg", "Excursion4.jfif", "Excursion5.jpg", "Excursion6.jfif", "Excursion7.jfif", "Excursion8.jpeg", "Excursion9.jpg", "Excursion10.jpg"
        };
    public static Dictionary<string, Paquete> dicPaquetes {get; private set;}   
    
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
        bool ingresar = true;
        int posPaquete = 0;
        foreach(Paquete buscpaquete in dicPaquetes.Values){
            if(buscpaquete == paquete){
                ingresar = false;
            }
        }
        if(ingresar = false){
            return ingresar;
        }else{
            dicPaquetes.Add(destinoSeleccionado, paquete);
            return ingresar;
        }
        
    }
}