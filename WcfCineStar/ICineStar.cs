using System.Data;
using System.ServiceModel;
namespace WcfCineStar
{
    [ServiceContract]
    public interface ICineStar
    {
        [OperationContract]
        DataSet getCines();
    }
    }
