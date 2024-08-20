using System;
namespace TP06.Models;
public class Deporte
{
    public string Nombre  { get; private set; }  
    public Deporte () {}
    public Deporte (string nombre)
        {
        Nombre = nombre;   
        }
    
}