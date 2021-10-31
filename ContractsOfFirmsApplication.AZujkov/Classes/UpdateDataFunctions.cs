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
        public bool FirmsUpdateRecordsFunction(string query)
        {
            bool flagresult = false;
            ConnectToDataBase(query, flagresult, changedRecordsCount);
            return flagresult;
        }
        public bool PeopleUpdateRecordsFunction(string query)
        {
            bool flagresult = false;
            ConnectToDataBase(query, flagresult, changedRecordsCount);
            return flagresult;
        }
        public bool PropertiesUpdateRecordsFunction(string query)
        {
            bool flagresult = false;
            ConnectToDataBase(query, flagresult, changedRecordsCount);
            return flagresult;
        }
    }
}
