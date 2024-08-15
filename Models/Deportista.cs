using System;

public class Deportistas
{

   public string Apellido { get; private set; }
    public string Nombre  { get; private set; }  
    public DateTime FechaNacimiento { get; set; }

    public Deportistas () {}
    public Deportistas (string apellido,string nombre, DateTime fechanacimiento)
        {
        Apellido=apellido;
        Nombre = nombre;   
        FechaNacimiento= fechanacimiento;
        }
    
}
