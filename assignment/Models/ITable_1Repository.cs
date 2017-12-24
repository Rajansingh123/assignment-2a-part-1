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
        IQueryable<Table_1> Table_1 { get; }

        Table_1 Save(Table_1 table_3);
        void Delete(Table_1 table_3);

    }
}
