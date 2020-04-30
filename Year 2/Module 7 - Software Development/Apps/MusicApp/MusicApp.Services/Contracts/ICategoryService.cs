using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Services.Contracts
{
    public interface ICategoryService
    {
        int CreateCategory(string name);
    }
}
