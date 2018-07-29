using System.Web.Security;
using UsedCarDealerWebApp.Infrastructure.Abstract;

namespace UsedCarDealerWebApp.Infrastructure.Concrete
{

    public class FormsAuthProvider : IAuthProvider
    {

        public bool Authenticate(string username, string password)
        {

            bool result = FormsAuthentication.Authenticate(username, password);
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }
    }
}
