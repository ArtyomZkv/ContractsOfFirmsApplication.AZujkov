using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsOfFirmsApplication.AZujkov.Classes
{
    class DeleteDataFunctions : ConnectionWork
    {
        public bool BaseDeleteRecordFunciton(string query)
        {
            bool flagresult = false;
            ConnectToDataBase(query, flagresult);
            return flagresult;
        }
    }
}
