using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorServiceLibrary
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        User CheckAuthentications(string userNm, string userPass);
        [OperationContract]
        void addUser();
        [OperationContract]
        double ADD(int userId, double num1 , double num2);
        [OperationContract]
        double Subtract(int userId, double num1, double num2);
        [OperationContract]
        double Divided(int userId, double num1, double num2);
        [OperationContract]
        double Multiplay(int userId, double num1, double num2);
     



    }
}
