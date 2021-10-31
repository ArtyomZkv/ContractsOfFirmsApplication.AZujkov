using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace ContractsOfFirmsApplication.AZujkov.Classes
{
    class ConnectionWork
    {
        public string connectionString = @"Data Source = DESKTOP-HKUF1MT\SQLEXPRESS, Initial Catalog = ContractsOfFirmsDB," +
            "Intagrated Security = true";
        public void ConnectToDataBase(string query, bool flagresult, byte changedRecordsCount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == changedRecordsCount)
                    {
                        flagresult = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public UInt16 GetRowIdByOtherRow(string query, UInt16 rowId)
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
    }
}
