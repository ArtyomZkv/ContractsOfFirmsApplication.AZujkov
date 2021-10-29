using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContractsOfFirmsApplication.AZujkov.Classes
{
    class ConnectionWorkAddFunctions : ConnectionWork
    {
        public UInt16 GetContractIdByAccount(string account, UInt16 contractId)
        {
            string query = string.Format("SELECT ContractId FROM Contracts WHERE Account = '{0}'", account);
            return GetRowIdByOtherRow(query, contractId);
        }
        public UInt16 GetUserIdByName(string firstName, string secondName, UInt16 userId)
        {
            string query = string.Format("SELECT UserId FROM Users WHERE FirstName = '{0}' and SecondName = '{1}'", firstName, secondName);
            return GetRowIdByOtherRow(query, userId);
        }
        public UInt16 GetPropertyIdByName(string name, UInt16 propId)
        {
            string query = string.Format("SELECT PropId FROM Properties where Name = '{0}'", name);
            return GetRowIdByOtherRow(query, propId);
        }
    }
}
