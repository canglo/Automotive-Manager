using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DataTier
{
    public abstract class Data
    {
        private OleDbConnection _connection;
        private OleDbDataAdapter _adapter;
        private OleDbCommandBuilder _commandBuilder;
        private DataSet _dataSet;
        private string _connectionString;
        private string _tableName;
        private string _selectQuery;

        public Data(string connectionString, string tableName, string selectQuery)
        {
            _connectionString = connectionString;
            _tableName = tableName;
            _selectQuery = selectQuery;

            _connection = new OleDbConnection(_connectionString);

            _connection.Open();

            if (_connection.State == ConnectionState.Open)
            {
                _adapter = new OleDbDataAdapter(_selectQuery, _connection);

                _dataSet = new DataSet();

                _adapter.Fill(_dataSet, _tableName);

                _commandBuilder = new OleDbCommandBuilder(_adapter);
            }
        }

        public DataTable GetAllRows()
        {
            DataTable dataTable = _dataSet.Tables[_tableName];

            return dataTable;
        }

        public void Update()
        {
            _adapter.Update(_dataSet.Tables[_tableName]);
        }

        public void Close()
        {
            _connection.Close();
        }

    }
}
