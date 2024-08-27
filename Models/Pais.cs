using System;
namespace TP06.Models;
public class Pais
{
    public int idPais  { get;  set; } 
    public string Bandera { get; set; }
    public string Nombre  { get; set; }  
    public DateTime FechaFundacion { get; set; }

    public Pais () {}
    public Pais (int IDpais, string bandera,string nombre, DateTime fechafundacion)
        {
        idPais = IDpais;
        Bandera = bandera;
        Nombre = nombre;   
        FechaFundacion= fechafundacion;
        }
    
}


