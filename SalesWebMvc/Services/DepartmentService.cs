using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        // Aqui faz de modo sincrono que bloqueia a aplicação ate uma resposta seja dada.
        /*public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }*/

        // Aqui faz de modo asincrono que deixa aplicação liberada para outras atividades.
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
