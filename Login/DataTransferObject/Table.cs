using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataTransferObject
{
    public class Table
    {
        private int iD;
        private string name;
        private string tableStatus;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string TableStatus { get => tableStatus; set => tableStatus = value; }

        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.TableStatus = status;
        }

        public Table(DataRow row)
        {
            this.ID = (int) row["id"];
            this.Name = row["name"].ToString();
            this.TableStatus = row["tableStatus"].ToString();
        }
    }
}
