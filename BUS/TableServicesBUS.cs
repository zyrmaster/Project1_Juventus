using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TableServicesBUS
    {
        TableServices tbsv = new TableServices();
        public int TableWith = 150;
        public int TableHeight = 150;
        public  int GetCountTable()
        {
            return tbsv.GetTotalNumberOfTables();
        }
        public List<Table> GetAllTableLst()
        {
            return tbsv.GetAllTableList();
        }
        public int GetLastTableIdBUS()
        {
            return tbsv.GetLastTableId();
        }
        public bool AddTableBUS(Table table)
        {
            return tbsv.AddTable(table);
        }
        public Table GetTableByName(string tableName)
        {
            return tbsv.GetTableByName(tableName);
        }
        public Table GetTableById(int id)
        {
            return tbsv.GetTableById(id);
        }
        public bool UpdateTableBUS(Table table)
        {
            return tbsv.UpdateTable(table);
        }
        public string GetStatusByIdBUS(int id)
        {
            return tbsv.GetStatusById(id);
        }
        public bool DeleteByIdBUS(int id)
        {
            return tbsv.DeleteTable(id);
        }
    }
}
