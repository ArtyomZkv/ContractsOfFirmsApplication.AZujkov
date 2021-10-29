﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContractsOfFirmsApplication.AZujkov.Classes
{
    class InsertDataFunctions : ConnectionWork
    {
        public bool AddNewContract(string jurName)
        {
            bool flagresult = false;
            string query = string.Format("INSERT INTO dbo.Firms (JurName) VALUES ('{0}')", jurName);
            ConnectToDataBase(query, flagresult);
            return flagresult;
        }
        public bool AddNewPerson(string firstName, string secondName)
        {
            bool flagresult = false;
            string query = string.Format("INSERT INTO dbo.People (FirstName, SecondName) VALUES ('{0}', '{1}')", firstName, secondName);
            ConnectToDataBase(query, flagresult);
            return flagresult;
        }
        public bool AddNewUser(string firstName, string secondName)
        {
            bool flagresult = false;
            string query = string.Format("INSERT INTO dbo.Users (FirstName, LastName) VALUES ('{0}', '{1}')", firstName, secondName);
            ConnectToDataBase(query, flagresult);
            return flagresult;
        }
        public bool AddNewProperties(string name)
        {
            bool flagresult = false;
            string query = string.Format("INSERT INTO dbo.Users (Name) VALUES ('{0}')", name);
            return flagresult;
        }
        public bool AddNewOrder(UInt16 contractId, DateTime createDate, UInt16 userId)
        {
            bool flagresult = false;
            string query = string.Format("INSERT INTO dbo.Orders (ContractId, CreateDate, UserId) VALUES ('{0}', '{1}', '{2}')", contractId, createDate, userId);
            return flagresult;
        }
        public void ConnectToDataBase(string query, bool flagresult)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
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
    }
}