using System.Data.SqlClient;
using Dapper;
namespace TP06.Models;

public class BD{

    private static string _connectionString = @"Server=localhost; 
    DataBase=JJOO TP6; Trusted_Connection=True;";

    public static void AgregarDeportista(Deportista dep) {
        string SQL = "INSERT INTO Deportistas( Apellido, Nombre, FechaNacimiento, Foto, idPais, idDeporte) VALUES (@pApellido, @pNombre, @pFechaDeNacimiento, @pFoto, @pidPais, @pidDeporte)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute (SQL, new {pApellido = dep.Apellido, pNombre = dep.Nombre, pFechaDeNacimiento = dep.FechaNacimiento, pFoto = dep.Foto, pidPais = dep.idPais, pidDeporte = dep.idDeporte});
        }
    }
    public static void EliminarDeportista(int idDeportista)  {
    int eliminado=0;
    string sql = " DELETE FROM DEPORTISTAS WHERE idDeportista = @Id";
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        eliminado = db.Execute(sql, new { Id = idDeportista});
    }
        
    }
    public static Deporte VerInfoDeporte(int idDeporte) {
        Deporte miDeporte = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM DEPORTES WHERE idDeporte = @id";
            miDeporte = db.QueryFirstOrDefault<Deporte>(sql, new { id = idDeporte});
        }
        return miDeporte;
        
    }
    public static Pais VerInfoPais(int idPais) {
        Pais miPais = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM PAISES WHERE idPais = @id";
            miPais = db.QueryFirstOrDefault<Pais>(sql, new { id = idPais});
        }
        return miPais;
    }
    public static Deportista VerInfoDeportista(int idDeportista) {
        
        Deportista miDeportista = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Deportistas WHERE idDeportista = @id";
            miDeportista = db.QueryFirstOrDefault<Deportista>(sql, new { id = idDeportista});
        }
        return miDeportista;
    }
    public static List<Pais> ListarPaises() {
            List<Pais> paises = new List<Pais>();
            
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql= " SELECT * FROM Paises";
                paises = db.Query<Pais>(sql).ToList();
            }
            return paises;
    }
    public static List<Deportista> ListarDeportistasxDeporte(int idDeporte) {
        List<Deportista> deportistas = new List<Deportista>();
            
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql= " SELECT * FROM Deportistas WHERE idDeporte=@idDeporte";
                deportistas=db.Query<Deportista>(sql, new { idDeporte = idDeporte}).ToList();
            }
        return deportistas;
    }
    public static List<Deportista> ListarDeportistasxPais(int idPais) {
        List<Deportista> deportistas = new List<Deportista>();
          
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql= " SELECT * FROM Deportistas WHERE idPais=@idPais";
                deportistas=db.Query<Deportista>(sql, new { idPais = idPais}).ToList();
            }
        return deportistas;
    }
    public static List<Deporte> ListarDeporte() {
            
            List<Deporte> deportes = null;
            
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql= " SELECT * FROM Deportes";
                deportes = db.Query<Deporte>(sql).ToList();
            }
            return deportes;
    }

    

}


