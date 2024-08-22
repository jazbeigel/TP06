using System;
namespace TP06.Models;
public class Deportista
{

    public int idDeportista { get; set;}
   public string Apellido { get; set; }
    public string Nombre  { get; set; }  
    public DateTime FechaNacimiento { get; set; }
    public int idPais  { get;  set; } 
    public int idDeporte  { get;  set; } 

    public Deportista () {}
    public Deportista (int IDdeportista, string apellido,string nombre, DateTime fechanacimiento, int IDpais, int IDdeporte)
        {
        idDeportista = IDdeportista;
        Apellido=apellido;
        Nombre = nombre;   
        FechaNacimiento= fechanacimiento;
        idPais = IDpais;
        idDeporte = IDdeporte;
        }
    
}
