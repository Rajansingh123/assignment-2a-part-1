using System;
using System.Linq;

namespace assignment.Models
{
    public class EFTable_1Repository : ITable_1Repository
    {

        Model1 db = new Model1();

        public IQueryable<Table_3> Table_3 { get { return db.Table_3; } }

        public IQueryable<Table_1> Table_1 { get { return db.Table_1; } }

        public void Delete(Table_1 table_1)
        {
            db.Table_1.Remove(table_1);
            db.SaveChanges();
        }

        public Table_1 Save(Table_1 table_1)
        {
            if (table_1.Carid == 0 )
            {
                db.Table_1.Add(table_1);
            }
            else
                {
                db.Entry(table_1).State = System.Data.Entity.EntityState.Modified;
                }
            db.SaveChanges();
            return table_1;
        }
    }
}