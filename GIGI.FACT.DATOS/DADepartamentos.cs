using GIGIS.FACT.ENTITY;
using GIGIS.FACT.ENTITY.Parametros;
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
    public class DADepartamentos
    {
        public List<ResponseDepartamento> listarDepartamentos(ENRegistroEmpresa paramss)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                var lista = new List<ResponseDepartamento>();
                using (SqlConnection  conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_listarDepartamentos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var resul = new ResponseDepartamento();
                            resul.idDepartamento = Convert.ToInt32(rdr["idDepartamento"]);
                            resul.departamento = Convert.ToString(rdr["departamento"]);
                            lista.Add(resul);
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ResponseMoneda> listarMoneda(ENRegistroEmpresa paramss)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                var lista = new List<ResponseMoneda>();

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_listarMoneda", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var resul = new ResponseMoneda();
                            resul.idmoneda = Convert.ToInt32(rdr["idmoneda"]);
                            resul.moneda = Convert.ToString(rdr["moneda"]);
                            lista.Add(resul);
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ResponseTImpuesto> listarTImpuestos(ENRegistroEmpresa paramss)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                var lista = new List<ResponseTImpuesto>();

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_listarTImpuestos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var resul = new ResponseTImpuesto();
                            resul.idtimpuestos = Convert.ToInt32(rdr["idtimpuestos"]);
                            resul.timpuestos = Convert.ToString(rdr["timpuestos"]);
                            lista.Add(resul);
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ResponsePImpuestos> listarPImpuestos(ENRegistroEmpresa paramss)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                var lista = new List<ResponsePImpuestos>();

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_listarPImpuestos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var resul = new ResponsePImpuestos();
                            resul.idpimpuestos = Convert.ToInt32(rdr["idpimpuestos"]);
                            resul.pimpuestos = Convert.ToInt32(rdr["pimpuestos"]);
                            lista.Add(resul);
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




    }
}
