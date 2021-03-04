
using Application.Models;

namespace Application.Helper
{
    public class PasswordValidation
    {
        public bool validation(Registration registration)
        {
            for (int i = 0; (i+2) < registration.Username.Length; i++)
            {
                if (registration.Password.Contains(registration.Username.Substring(i, 3)))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
