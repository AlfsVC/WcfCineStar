using System.Data;

namespace WcfCineStar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CineStarService : ICineStar
    {
        db.Db db = new db.Db("cnCineStar");
        public DataSet getCines()
        {
            db.Sentencia("sp_getCines ");
            return db.getDataSet();
        }
        public DataSet getCine(string idCine)
        {
            db.Sentencia("sp_getCine");
            db.Parametros(idCine);
            return db.getDataSet();
        }
        public DataSet getTarifas(string idCine)
        {
            db.Sentencia("sp_getCineTarifas");
            db.Parametros(idCine);
            return db.getDataSet();
        }
        public DataSet getPeliculas(string idPeliculas)
        {
            db.Sentencia("sp_getPeliculas");
            db.Parametros(idPeliculas);
            return db.getDataSet();
        }
        public DataSet getPelicula(string idPeliculas)
        {
            db.Sentencia("sp_getPelicula");
            db.Parametros(idPeliculas);
            return db.getDataSet();
        }
        public DataSet getCinePeliculas(string idCine)
        {
            db.Sentencia("sp_getCinePeliculas");
            db.Parametros(idCine);
            return db.getDataSet();
        }
    }
}
