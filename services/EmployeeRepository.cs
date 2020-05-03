using BackendApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BackendApiDemo.services
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {

        private readonly BackendDatabaseContext _context;


        public EmployeeRepository(BackendDatabaseContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public Employee GetEmployee(int employeeId)
        {
            return _context.Employee.Where(e => e.EmployeeId == employeeId).FirstOrDefault();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employee.OrderBy(e => e.EmployeeId).ToList();
        }

        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }
                disposedValue = true;
            }
        }
        void IDisposable.Dispose()
        {
            Dispose(true);
        }
    }
}
