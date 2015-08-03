namespace Calc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {       
        
        string IService1.AddNumber(double number1, double number2)
        {
            return (number1 + number2).ToString();
        }

        string IService1.DivNumber(double number1, double number2)
        {
            return (number1 / number2).ToString();
        }

        string IService1.MultNumber(double number1, double number2)
        {
            return (number1 * number2).ToString();
        }

        string IService1.SubNumber(double number1, double number2)
        {
            return (number1 - number2).ToString();
        }       
    }
}
