using GIGI.FACT.DATOS;
using GIGIS.FACT.ENTITY.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GIGISFACT.WEBSERVICE.Controllers
{
    [RoutePrefix("api/RegistroEmpresa")]
    
    public class RegistroEmpresaController : ApiController
    {
        private DADepartamentos dadeaprtamentos;

        private DARegistroEmpresa daregistroempresa;

        public RegistroEmpresaController()
        {
            dadeaprtamentos = new DADepartamentos();
            daregistroempresa = new DARegistroEmpresa();
        }


        [HttpPost]
        [Route("listarDepartamentos")]
        public IHttpActionResult listarDepartamentos(ENRegistroEmpresa paramss)
        {
             
            try
            {
                var rpt = dadeaprtamentos.listarDepartamentos(paramss);
                return Ok(rpt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("listarMoneda")]
        public IHttpActionResult listarMoneda(ENRegistroEmpresa paramss)
        {
            try
            {
                var rpt = dadeaprtamentos.listarMoneda(paramss);
                return Ok(rpt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("listarTImpuestos")]
        public IHttpActionResult listarTImpuestos(ENRegistroEmpresa paramss)
        {
            try
            {
                var rpt = dadeaprtamentos.listarTImpuestos(paramss);
                return Ok(rpt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpPost]
        [Route("listarPImpuestos")]
        public IHttpActionResult listarPImpuestos(ENRegistroEmpresa paramss)
        {
            try
            {
                var rpt = dadeaprtamentos.listarPImpuestos(paramss);
                return Ok(rpt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("validarRegistro")]
        public IHttpActionResult validarRegistro(ENRegistroEmpresa paramss)
        {
            try
            {
                var rpt = daregistroempresa.validarRegistro(paramss);
                return Ok(rpt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
