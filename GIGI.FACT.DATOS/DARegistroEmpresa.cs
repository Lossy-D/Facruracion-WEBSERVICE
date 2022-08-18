﻿using GIGIS.FACT.ENTITY.Parametros;
using GIGIS.FACT.ENTITY.Response;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIGI.FACT.DATOS
{
    public class DARegistroEmpresa
    {
        public ResponseRegistroEmpresa validarRegistro(ENRegistroEmpresa paramss)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                var lista = new List<ResponseRegistroEmpresa>();

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_validarRegistroEmpresa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@nombreempresa", paramss.nombreempresa));
                    cmd.Parameters.Add(new SqlParameter("@rtu", paramss.rtu));
                    cmd.Parameters.Add(new SqlParameter("@email", paramss.email));

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var resul = new ResponseRegistroEmpresa();
                            resul.response = Convert.ToString(rdr["response"]);
                            lista.Add(resul);
                        }
                    }
                }
                return lista.FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
