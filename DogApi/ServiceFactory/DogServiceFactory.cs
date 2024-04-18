﻿using BusinessLogic;
using DataAccess;
using DataAccess.Context;
using IBusinessLogic;
using IDataAccess;
using Microsoft.EntityFrameworkCore;
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
            //Agreguen el Scoped
            serviceCollection.AddScoped<IDogLogic, DogLogic>();
            serviceCollection.AddScoped<IDogRepository, DogRepository>();
        }
        public static void AddConnectionString(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<DbContext, DogContext>();
        }
    }
}
