using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using WelcomeExtended.Loggers;
using WelcomeExtended.Others;

namespace WelcomeExtended
{
     class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*var user = new User
                {
                    Names = "John Smith",
                    Password = "password123",
                    Role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);

                var view = new UserView(viewModel);

                view.Display();

                view.DisplayError();*/

                UserData userData = new UserData();

                User student = new User()
                {
                    Names = "student",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT
                };

                User student2 = new User()
                {
                    Names = "Student2",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT
                };
                User teacher = new User()
                {
                    Names = "Teacher",
                    Password = "1234",
                    Role = UserRolesEnum.PROFESSOR
                };
                User admin = new User()
                {
                    Names = "Admin",
                    Password = "12345",
                    Role = UserRolesEnum.ADMIN
                };
                userData.AddUser(student);
                userData.AddUser(student2);
                userData.AddUser(teacher);
                userData.AddUser(admin);

                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Pass:");
                string pass = Console.ReadLine();

                userData.ValidateCredentials(name, pass);
                User getUser = userData.GetUserH(name, pass);

                Console.WriteLine(getUser.Print());
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Delegates.Log);
                log(e.Message);

            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}
