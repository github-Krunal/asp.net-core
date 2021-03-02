using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Routes
{
    public static class CustomRoutes
    {
        private  const  string _baseApi = "api/";

        public const  string _registration = _baseApi + "registartion";
        public const string _registrationGetAll = _baseApi + "getAllRegistraion";
        public const string _single_registration = _baseApi + "getSingleRegistration/{id}";

    }
}
