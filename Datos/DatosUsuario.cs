﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Odbc;
using Common.Cache;

namespace Datos
{
    public class DatosUsuario:ConnectionToSql
    {
        public string user2;
        public string pass2;
        public bool login(string user, string pass)
        {
            using (OdbcConnection connection = getConnection())
            {
                connection.Open();
                using (OdbcCommand cmd = new OdbcCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM usuario where Nombre='"+user+"' AND contraseña='"+pass+"'";
                    
                    cmd.Parameters.AddWithValue("?user", user);
                    cmd.Parameters.AddWithValue("?pass", pass);

                    cmd.CommandType = CommandType.Text;
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //user2 = (reader["Nombre"].ToString());
                        //pass2 = (reader["Contraseña"].ToString());
                        while (reader.Read())
                        {
                            UserLoginCache.username = reader.GetString(0);
                            UserLoginCache.Telefono = reader.GetInt32(1);
                            UserLoginCache.Correo = reader.GetString(2);
                            UserLoginCache.Perfil = reader.GetString(4);
                        }
                        
                        
                        return true;
                    }
                    else
                        return false;
                }
                connection.Close();
            }
        }
    }
}
