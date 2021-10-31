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
        public bool UserUpdateRecordFunction(string query)
        {
            bool flagresult = false;
            ConnectToDataBase(query, flagresult, changedRecordsCount);
            return flagresult;
        }
    }
}
