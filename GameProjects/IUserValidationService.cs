using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
