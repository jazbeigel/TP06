using System.Data.SqlClient;
using Dapper;
namespace TP06.Models;

public class BD{

private static string _connectionString = @"Sever=localhost; 
DataBase=NombreBase; Trusted_Connection=True;";
public static void AgregarDeportista(Deportista dep) {
    string SQL = "INSERT INTO Deportista(idDeportista, Apellido, Nombre, FechaDeNacimiento, Foto, idPais, idDeporte) VALUES (@pidDeportista, @pApellido, @pNombre, @pFechaDeNacimiento, @pFoto, @pidPais, @pidDeporte)";
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        //EMPEZAR DESDE ACA 
        db.Execute (SQL, new {pDeporte});
    }
}
public static void EliminarDeportista(int idDeportista)  {
    
}
public static Deporte VerInfoDeporte(int idDeporte) {
    
}
public static Pais VerInfoPais(int idPais) {
    
}
public static Deportista VerInfoDeportista(int idDeportista) {
    
}
public static List<Pais> ListarPaises() {
    
}
public static List<Deportista> ListarDeportistas(int idDeporte) {
    
}
public static List<Deportista> ListarDeportistas1(int idPais) {
    
}

}


