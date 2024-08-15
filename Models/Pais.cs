using System;

public class Pais
{

   public string Bandera { get; private set; }
    public string Nombre  { get; private set; }  
    public DateTime FechaNacimiento { get; set; }

    public Pais () {}
    public Pais (string bandera,string nombre, DateTime fechanacimiento)
        {
        Bandera=bandera;
        Nombre = nombre;   
        FechaNacimiento= fechanacimiento;
        }
    
}


