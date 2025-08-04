using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;

namespace VistaMadrid.MP.EF
{
    public class BaseModelo
    {
        protected BDVistaMadridEntidades _db;

        public BaseModelo(string connectionString = null)
        {
            Instanciar(connectionString);
        }

        protected void Instanciar(string connectionString = null)
        {
            _db = new BDVistaMadridEntidades(); // Para usar el connectionString solo si se tiene múltiples cadenas
        }

        public object RetornaValorSQL(string querySQL, CommandType commandType = CommandType.Text, List<SqlParameter> sqlParameters = null)
        {
            using (var context = new BDVistaMadridEntidades())
            {
                var connection = context.Database.Connection;
                var connectionState = connection.State;
                var dataSet = new DataSet();
                SqlDataAdapter dataAdapter = null;

                try
                {
                    if (connectionState != ConnectionState.Open)
                        connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = querySQL;
                        command.CommandType = commandType;

                        if (sqlParameters != null)
                        {
                            foreach (var param in sqlParameters)
                                command.Parameters.Add(param);
                        }

                        dataAdapter = new SqlDataAdapter((SqlCommand)command);
                        dataAdapter.Fill(dataSet);
                    }

                    if (dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0)
                        return null;

                    return dataSet.Tables[0].Rows[0][0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (connectionState != ConnectionState.Open)
                        connection.Close();

                    dataAdapter?.Dispose();
                    dataSet?.Dispose();
                }
            }
        }

        protected int EjecutarConsultaNoValores(string querySQL)
        {
            using (var context = new BDVistaMadridEntidades())
            {
                var connection = context.Database.Connection;
                var connectionState = connection.State;

                try
                {
                    if (connectionState != ConnectionState.Open)
                        connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = querySQL;
                        command.CommandType = CommandType.Text;
                        return command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (connectionState != ConnectionState.Open)
                        connection.Close();
                }
            }
        }
    }
}
