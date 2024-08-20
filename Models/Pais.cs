using System;
namespace TP06.Models;
public class Pais
{

   public string Bandera { get; private set; }
    public string Nombre  { get; private set; }  
    public DateTime FechaFundacion { get; set; }

    public Pais () {}
    public Pais (string bandera,string nombre, DateTime fechafundacion)
        {
        Bandera=bandera;
        Nombre = nombre;   
        FechaFundacion= fechafundacion;
        }
    
}


