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
            db.Sentencia("sp_getCines");
            return db.getDataSet();
        }
    }
}
