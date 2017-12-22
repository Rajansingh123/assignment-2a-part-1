using System;
using System.Linq;

namespace assignment.Models
{
    public class EFTable_1Repository : ITable_1Repository
    {

        Table_1 db = new Table_1();

        public IQueryable<Table_3> Table_3 { get { return db.Table_3; } }

        public void Delete(Table_3 table_3)
        {
            db.Table_3.Remove(table_3);
            db.Save()
        }

        public Table_3 Save(Table_3 table_3)
        {
            throw new NotImplementedException();
        }
    }
}