using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
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
                var user = new User
                {
                    Names = "John Smith",
                    Password = "password123",
                    Role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);

                var view = new UserView(viewModel);

                view.Display();
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
