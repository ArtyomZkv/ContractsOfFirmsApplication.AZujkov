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
        public ArrayList GetAllRecords(string connectionString, string query, ArrayList allRecords)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        foreach (DbDataRecord result in reader)
                        {
                            allRecords.Add(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return allRecords;
        }
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
        public UInt16 GetRowIdByOtherRow (string query, UInt16 rowId)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        rowId = (ushort)reader.GetInt16(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return rowId;
        }
    }
}
