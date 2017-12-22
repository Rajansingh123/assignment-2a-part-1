using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Models
{
    public interface ITable_1Repository
    {
        IQueryable<Table_3> Table_3 { get; }
        Table_3 Save(Table_3 table_3);
        void Delete(Table_3 table_3);
    }
}
