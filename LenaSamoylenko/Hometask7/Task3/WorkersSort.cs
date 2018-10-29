using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface IWorkersSort
    {
        List<Payment> SortWorkersInListByName(List<Payment> workers);
        List<Payment> SortWorkersInListBySalary(List<Payment> workers);
    }
}
