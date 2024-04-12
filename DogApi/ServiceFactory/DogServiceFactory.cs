﻿using BusinessLogic;
using DataAccess;
using IBusinessLogic;
using IDataAccess;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFactory
{
    public static class DogServiceFactory
    {
        public static void AddServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IDogLogic, DogLogic>();
            serviceCollection.AddScoped<IDogRepository, DogRepository>();
        }
    }
}
