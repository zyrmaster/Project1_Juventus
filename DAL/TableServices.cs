using DAL.Context;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TableServices
    {
        private DatabaseContext _dbContext;
        private List<Table> _lstTables;
        Table table = new Table();
        public TableServices()
        {
            _lstTables = new List<Table>();
            _dbContext = new DatabaseContext();
        }
        public int GetTotalNumberOfTables()
        {
            int totalCount = _dbContext.Tables.Count();
            return totalCount;
        }
        public Table GetTableById(int tableId)
        {
            return _dbContext.Tables.FirstOrDefault(c => c.Id == tableId);
        }
        public List<Table> GetAllTableList()
        {
            return _dbContext.Tables.ToList();
        }
        public int GetCountTables()
        {
            return _dbContext.Tables.ToList().Count();
        }
        public string GetStatusById(int tableId)
        {
            return _dbContext.Tables.Where(c=>c.Id==tableId).First().Status;
        }
        public int GetLastTableId() {
            return _dbContext.Tables.OrderBy(c=>c.Id).Last().Id;
        }
        public bool AddTable(Table table)
        {
            _dbContext.Tables.Add(table);
            _dbContext.SaveChanges();
            return true;
        }
        public bool DeleteTable(int tableId)
        {
            Table existingTable = _dbContext.Tables.FirstOrDefault(c => c.Id == tableId);

            if (existingTable != null)
            {
                _dbContext.Tables.Remove(existingTable);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateTable(Table table) { 
            var exitsTable = _dbContext.Tables.FirstOrDefault(c=>c.Id==table.Id);
            if(exitsTable != null)
            {
                exitsTable.Name = table.Name;
                exitsTable.Slot = table.Slot;
                exitsTable.Status = table.Status;
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public Table GetTableByName(string name) {
            return _dbContext.Tables.FirstOrDefault(t => t.Name == name);
        }
    }
}
