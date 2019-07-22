using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
 
namespace CalculatorServiceLibrary
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CalculatorService : ICalculatorService
    {
        public double ADD(int userId, double num1, double num2)
        {
            using (UserContext context = new UserContext())
            {
                if(context.Users.FirstOrDefault(i => i.userID == userId)!=null);

                    {
                    return num1 + num2;

                }

              

            }
        }

        public void addUser()
        {


            using (UserContext context = new UserContext())
            {
                if (context.Users.FirstOrDefault(i => i.userName == "Mohamed" && i.password == "1234") == null )
                {
                    context.Users.Add(new User() { userName = "Mohamed", password = "1234", addAuth = true, multiAuth = true, divAuth = true, subAuth = true });

                    }
                if (context.Users.FirstOrDefault(i => i.userName == "Ahmed" && i.password == "1234") == null)
                {
                    context.Users.Add(new User() { userName = "Ahmed", password = "1234", addAuth = true, multiAuth =false, divAuth = false, subAuth = false });

                }




                context.SaveChanges();
            }

        }

        public User CheckAuthentications(string userNm, string userPass)
        {



            using (UserContext context = new UserContext())
            {
                var Curruser = context.Users.FirstOrDefault(i => i.userName == userNm && i.password == userPass);


                return Curruser;


              
            }

        }

        public double Divided(int userId, double num1, double num2)
        {
            using (UserContext context = new UserContext())
            {
                if (context.Users.FirstOrDefault(i => i.userID == userId) != null) ;

                {
                    return num1 / num2;

                }



            }
        }

        public double Multiplay(int userId, double num1, double num2)
        {
            using (UserContext context = new UserContext())
            {
                if (context.Users.FirstOrDefault(i => i.userID == userId) != null) ;

                {
                    return num1 * num2;

                }



            }
        }

        public double Subtract(int userId, double num1, double num2)
        {
            using (UserContext context = new UserContext())
            {
                if (context.Users.FirstOrDefault(i => i.userID == userId) != null) ;

                {
                    return num1 - num2;

                }



            }
        }
    }
}
 