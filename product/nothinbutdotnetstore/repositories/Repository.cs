using System.Collections.Generic;
using nothinbutdotnetstore.model;

namespace nothinbutdotnetstore.repositories
{
    public interface Repository
    {
       IEnumerable<Department>  get_all_main_departments();
        IEnumerable<Department> get_all_departments_within_department();
    }
}