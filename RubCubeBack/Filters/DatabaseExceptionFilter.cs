using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Filters
{
    public class DatabaseExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is DbUpdateException dbEx &&
             dbEx.InnerException is PostgresException pgEx &&
             pgEx.SqlState == "23505")
            {
                context.Result = new ConflictObjectResult(new
                {
                    message = "Conflict: Email already exists.",
                });
                context.ExceptionHandled = true;
            }
        }
    }
}
