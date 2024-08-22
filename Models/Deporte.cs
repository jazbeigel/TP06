using System;
namespace TP06.Models;
public class Deporte
{
    public string Nombre  { get;  set; } 
    public int idDeporte  { get;  set; } 
    public string Foto  { get; set; }    
    public Deporte () {}
    public Deporte (string nombre, int IDdeporte, string foto)
        {
        Nombre = nombre;   
        idDeporte = IDdeporte;
        Foto = foto;
        }
    
}