using System.Data;
using System.ServiceModel;
namespace WcfCineStar
{
    [ServiceContract]
    public interface ICineStar
    {
        [OperationContract]
        DataSet getCines();

        [OperationContract]
        DataSet getCine(string idCine);

        [OperationContract]
        DataSet getTarifas(string idCine);

        [OperationContract]
        DataSet getPeliculas(string idPelicula);

        [OperationContract]
        DataSet getPelicula(string idPelicula);

        [OperationContract]
        DataSet getCinePeliculas(string idCine);
    }
    }
