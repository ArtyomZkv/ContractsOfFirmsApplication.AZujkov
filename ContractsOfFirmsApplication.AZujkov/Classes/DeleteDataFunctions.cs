using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsOfFirmsApplication.AZujkov.Classes
{
    class DeleteDataFunctions : ConnectionWork
    {
        public bool DeleteRecordFunciton(string query, byte changedRecordsCount)
        {
            bool flagresult = false;
            ConnectToDataBase(query, flagresult, changedRecordsCount);
            return flagresult;
        }
    }
}
