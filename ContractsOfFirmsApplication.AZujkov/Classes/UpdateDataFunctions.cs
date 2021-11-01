using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsOfFirmsApplication.AZujkov.Classes
{
    class UpdateDataFunctions : ConnectionWork
    {
        byte changedRecordsCount = 1;
        public bool ZeroForeignKeyUpdateRecordFunction(string query)
        {
            bool flagresult = false;
            ConnectToDataBase(query, flagresult, changedRecordsCount);
            return flagresult;
        }
        public bool OneForeignKeyUpdateRecordFunction(string query, string query1)
        {
            bool flagresult = false;
            ConnectToDataBase(query, flagresult, changedRecordsCount);
            ConnectToDataBase(query1, flagresult, changedRecordsCount);
            return flagresult;
        }
        public bool TwoForeignKeysUpdateRecordFunction(string query, string query1, string query2)
        {
            bool flagresult = false;
            ConnectToDataBase(query, flagresult, changedRecordsCount);
            ConnectToDataBase(query1, flagresult, changedRecordsCount);
            ConnectToDataBase(query2, flagresult, changedRecordsCount);
            return flagresult;
        }
    }
}
