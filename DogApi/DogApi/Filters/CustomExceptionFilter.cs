using IBusinessLogic.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DogApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            //TODO if needed
            if (context.Exception is UserNotFoundException)
            {
                context.Result = new ObjectResult(new { ErrorMessage = context.Exception.Message })
                {
                    StatusCode = 404
                };
            }
            //TODO if needed
            if (context.Exception is DogNotFoundException)
            {
                context.Result = new ObjectResult(new { ErrorMessage = context.Exception.Message })
                {
                    StatusCode = 404
                };
            }
            //TODO if needed
            if (context.Exception is AlreadyExistingDogException)
            {
                context.Result = new ObjectResult(new { ErrorMessage = context.Exception.Message })
                {
                    StatusCode = 400
                };
            }
        }
    }
}
