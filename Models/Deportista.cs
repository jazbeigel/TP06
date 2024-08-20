using System;
namespace TP06.Models;
public class Deportista
{

   public string Apellido { get; private set; }
    public string Nombre  { get; private set; }  
    public DateTime FechaNacimiento { get; set; }

    public Deportista () {}
    public Deportista (string apellido,string nombre, DateTime fechanacimiento)
        {
        Apellido=apellido;
        Nombre = nombre;   
        FechaNacimiento= fechanacimiento;
        }
    
}
