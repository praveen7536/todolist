using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todolistwebapp.Model;
using todolistwebapp.Requests;

namespace todolistwebapp.Repositories
{
    public interface ITodoListRepository
    {
        bool Addtolist(Addtask request);
        List<Lists> GettaskById(int id);
        List<Lists> Deletetask(int id);


    }
}
