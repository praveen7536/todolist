using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todolistwebapp.Model;
using todolistwebapp.Requests;

namespace todolistwebapp.Repositories
{
    public class TodolistRepository:ITodoListRepository
    {
        private readonly TodolistDbContext _db;
        public TodolistRepository(TodolistDbContext db)
        {
            this._db = db;

        }
        public bool Addtolist(Addtask request)
        {
            if(request !=null)
            {
                Lists l1 = new Lists();
                l1.Todo = request.Todo;
                l1.Iscomplete = request.Iscomplete;
                _db.lists.Add(l1);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public List<Lists> GettaskById(int id)
        {
            List<Lists> lists = new List<Lists>();
            lists = _db.lists.Where(a => a.Id == id).ToList();
            return lists;
        }
        public List<Lists> Deletetask(int id)
        {
            Lists l2 = _db.lists.Find(id);
            _db.lists.Remove(l2);
            _db.SaveChanges();
            return GettaskById(id);
            
        }
    }
}
