using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Exceptions
{
    public class UserNotFoundException(string message) : Exception(message)
    {
    }
}
