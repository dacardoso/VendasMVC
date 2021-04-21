using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Data;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMVCContext _context;
        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x=> x.Name).ToList();
        }

    }
}
