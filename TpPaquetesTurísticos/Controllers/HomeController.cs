using Microsoft.AspNetCore.Mvc;

namespace TpPaquetesTurísticos.Controllers;

public class HomeController : Controller
{ 
    public IActionResult Index(){
    ViewBag.dicPaquetes = ORTWorld.dicPaquetes;
    return View();
    }
    public IActionResult SelectPaquete(){
    ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
    ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
    ViewBag.ListaAereos = ORTWorld.ListaAereos;
    ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
    return View();
    }

    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion){
    Destino -=1;
    Hotel -= 1;
    Aereo-= 1;
    Excursion -= 1;
    Paquete paqueteN = new Paquete (ORTWorld.ListaHoteles[Hotel], ORTWorld.ListaAereos[Aereo], ORTWorld.ListaExcursiones[Excursion]);
    ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino],paqueteN);
    if(Aereo < 0 && Hotel < 0 && Excursion <0 || Aereo > 10 && Hotel > 10 && Excursion > 10){
        ViewBag.Error = "lo recibido no es correcto, vuelva a ingresar";
        return View("SelectPaquete");
    }
    else{
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        return View("Index");
    }
    
    }
}
