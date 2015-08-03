using System.ServiceModel;

namespace Calc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string AddNumber(double number1, double number2);

        [OperationContract]
        string SubNumber(double number1, double number2);

        [OperationContract]
        string MultNumber(double number1, double number2);

        [OperationContract]
        string DivNumber(double number1, double number2);       
    }   
}
