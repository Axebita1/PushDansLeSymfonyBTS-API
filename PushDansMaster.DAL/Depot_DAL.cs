﻿using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PushDansMaster.DAL
{
    //DAL class
    abstract class Depot_DAL<Type_DAL> : IDepot_DAL<Type_DAL>
    { 
        public string connectionString { get; set; }
            
        protected SqlConnection connection;
        protected SqlCommand command;
        
        public Depot_DAL()
        {
            //Get the sqlserver configuration
            var builder = new ConfigurationBuilder();
            var config = builder.AddJsonFile("appsettings.json", true, true).Build();

            connectionString = config.GetSection("ConnectionStrings:defailt").Value;
        }


        //Create the connection to the sql server
        protected void createConnection()
        {
            connection = new SqlConnection(connectionString);

            connection.Open();

            command = new SqlCommand();
            command.Connection = connection;

            connection.Close();
        }

        //Close the connection to the sql server
        protected void closeConnection()
        {
            command.Dispose();
            connection.Close();
            command.Dispose();
        }

        #region Abstract methods
        public abstract void delete(Type_DAL item);

        public abstract List<Type_DAL> getAll();

        public abstract Type_DAL getByID(int ID);

        public abstract Type_DAL insert(Type_DAL item);

        public abstract Type_DAL update(Type_DAL item);
        #endregion
    }
}
