﻿    using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SegurosFYP.BusinessLogic.Services;
using SegurosFYP.Common.Models;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PolizaController : Controller
    {
        private readonly SalesServices _salesServices;
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public PolizaController(SalesServices salesServices, GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _salesServices = salesServices;
            _mapper = mapper;
        }

        [HttpGet("List")]
        public IActionResult Index()
        {
            var list = _salesServices.ListPoliz();
            return Ok(list);
        }
        [HttpGet("Details")]
        public IActionResult Details(int Poliz_Id)
        {
            var list = _salesServices.Details(Poliz_Id);
            return Ok(list);
        }
        [HttpGet("CargarCliente")]
        public IActionResult CargarCliente(int Poliz_Id)
        {
            var list = _salesServices.CargarCliente(Poliz_Id);
            return Ok(list);
        }
        [HttpGet("CargarConyugue")]
        public IActionResult CargarConyugue(int Poliz_Id)
        {
            var list = _salesServices.CargarConyugue(Poliz_Id);
            return Ok(list);
        }
        [HttpGet("CargarDependientes")]
        public IActionResult CargarDependientes(int Poliz_Id)
        {
            var list = _salesServices.CargarDependientes(Poliz_Id);
            return Ok(list);
        }
        [HttpGet("CargarTipoPlan")]
        public IActionResult CargarTipoPlan(int Poliz_Id)
        {
            var list = _salesServices.CargarTipoPlan(Poliz_Id);
            return Ok(list);
        }
        [HttpGet("CargarEmpleado")]
        public IActionResult CargarEmpleado(int Poliz_Id)
        {
            var list = _salesServices.CargarEmpleado(Poliz_Id);
            return Ok(list);
        }
        [HttpPost("InsertIdentificacion")]
        public IActionResult InsertIdentificacion(IdentificacionPolizaViewModel item)
        {
            //var result = Ok();
            for (int i = 0; i < item.quantity; i++)
            {
                //var model = _mapper.Map<tbIdentificaciones>(item);
                var modelo = new tbIdentificaciones()
                {
                    Tiden_Id = item.Tiden_Id[i],
                    Ident_NumeroIdentificacion = item.Ident_NumeroIdentificacion[i],
                    Ident_FechaNacimiento = item.Ident_FechaNacimiento[i],
                    Ident_LugarNacimiento = item.Ident_LugarNacimiento[i]
                };
                var list = _generalServices.InsertIdent(modelo);
            }
            return Ok();
        }
        [HttpPost("InsertCliente")]
        public IActionResult InsertCliente(PersonaDependienteViewModel item)
        {
            var cantIdent = _generalServices.NumerationIdent(item.quantity);

            int contador = 0;
            foreach (var ident in cantIdent)
            {
                if (contador == 0)
                {
                    var numeracion = _salesServices.NumerationPoliz();

                    //var model = _mapper.Map<tbPersonas>(item);
                    var modelo = new tbPersonas()
                    {
                        Perso_PrimerNombre = item.Perso_PrimerNombre[0],
                        Perso_SegundoNombre = item.Perso_SegundoNombre[0],
                        Perso_PrimerApellido = item.Perso_PrimerApellido[0],
                        Perso_SegundoApellido = item.Perso_SegundoApellido[0],
                        Perso_Sexo = item.Perso_Sexo[0],
                        Ident_Id = ident.Ident_Id,

                        Estci_Id = item.Estci_Id,
                        Perso_Telefono = item.Perso_Telefono,
                        Perso_CorreoElectronico = item.Perso_CorreoElectronico,
                        Perso_Direccion = item.Perso_Direccion,
                        Munic_Id = item.Munic_Id,
                        Paise_Id = item.Paise_Id,

                        DniFrenteUrl = item.DniFrenteUrl,
                        DniAtrasUrl = item.DniAtrasUrl,

                        Poliz_Id = numeracion.Data + 1,
                        Paren_Id = 1,
                    };
                    var list = _generalServices.InsertPerso(modelo);
                }
                contador += 1;
            }
            return Ok();
        }
        [HttpPost("InsertPariente")]
        public IActionResult InsertPariente(PersonaDependienteViewModel item)
        {
            var cantIdent = _generalServices.NumerationIdent(item.quantity);

            int identcontador = 0;
            int contador = 0;
            foreach(var ident in cantIdent)
            {
                if (identcontador != 0)
                { 
                    var numeracion = _salesServices.NumerationPoliz();

                    //var model = _mapper.Map<tbPersonas>(item);
                    var modelo = new tbPersonas()
                    {
                        Perso_PrimerNombre = item.Perso_PrimerNombre[contador],
                        Perso_SegundoNombre = item.Perso_SegundoNombre[contador],
                        Perso_PrimerApellido = item.Perso_PrimerApellido[contador],
                        Perso_SegundoApellido = item.Perso_SegundoApellido[contador],
                        Perso_Sexo = item.Perso_Sexo[contador],
                        Ident_Id = ident.Ident_Id,

                        Estci_Id = item.Estci_Id,
                        Perso_Telefono = item.Perso_Telefono,
                        Perso_CorreoElectronico = item.Perso_CorreoElectronico,
                        Perso_Direccion = item.Perso_Direccion,
                        Munic_Id = item.Munic_Id,
                        Paise_Id = item.Paise_Id,

                        Poliz_Id = numeracion.Data + 1,
                        Paren_Id = item.Paren_Id[contador],
                    };
                    var list = _generalServices.InsertPerso(modelo);
                    contador += 1;
                }
                identcontador += 1;
            }
            return Ok();
        }
        [HttpPost("InsertInformacionMedica")]
        public IActionResult InsertInformacionMedica(InformacionMedicaViewModel item)
        {
            //var model = _mapper.Map<tbInformacionMedica>(item);
            var modelo = new tbInformacionMedica()
            {
                Perso_Id = item.Perso_Id,
                Inmed_PesoKgs = item.Inmed_PesoKgs,
                Inmed_EstaturaMtrs = item.Inmed_EstaturaMtrs,
                Inmed_TipoSangre = item.Inmed_TipoSangre,
                Inmed_ReaccionesAlergicas = item.Inmed_ReaccionesAlergicas,
                Inmed_AumentoDisminucion = item.Inmed_AumentoDisminucion,
                Inmed_AumentoDisminucionPeso = item.Inmed_AumentoDisminucionPeso,
                Inmed_IngiereBebidasAlcoholicas = item.Inmed_IngiereBebidasAlcoholicas,
                Inmed_TipoAlcohol = item.Inmed_TipoAlcohol,
                Inmed_IngiereCantidad = item.Inmed_IngiereCantidad,
                Inmed_IngiereFrecuencia = item.Inmed_IngiereFrecuencia,
                Inmed_DrogasEstimulantes = item.Inmed_DrogasEstimulantes,
                Inmed_TipoDrogasEstimulantes = item.Inmed_TipoDrogasEstimulantes,
                Inmed_DrogasEstimulantesCantidad = item.Inmed_DrogasEstimulantesCantidad,
                Inmed_DrogasEstimulantesFrecuencia = item.Inmed_DrogasEstimulantesFrecuencia,
                Inmed_Fumar = item.Inmed_Fumar,
                Inmed_FumarCantidad = item.Inmed_FumarCantidad,
                Inmed_FumarFrecuencia = item.Inmed_FumarFrecuencia,
                Inmed_Enfermedad1 = item.Inmed_Enfermedad1,
                Inmed_Enfermedad2 = item.Inmed_Enfermedad2,
                Inmed_Enfermedad3 = item.Inmed_Enfermedad3,
                Inmed_Enfermedad4 = item.Inmed_Enfermedad4,
                Inmed_Enfermedad5 = item.Inmed_Enfermedad5,
                Inmed_Enfermedad6 = item.Inmed_Enfermedad6,
                Inmed_Enfermedad7 = item.Inmed_Enfermedad7,
                Inmed_Enfermedad8 = item.Inmed_Enfermedad8,
                Inmed_Enfermedad9 = item.Inmed_Enfermedad9,
            };
            var list = _generalServices.InsertInmed(modelo);
            return Ok(list);
        }
        [HttpPost("InsertPoliza")]
        public IActionResult InsertPoliza(PolizaViewModel item)
        {
            var numeroIdentificacion = _generalServices.NumerationPerso(item.quantity);

            //var model = _mapper.Map<tbPolizas>(item);
            var modelo = new tbPolizas()
            {
                Clien_Id = numeroIdentificacion.Data,
                Tipos_Id = item.Tipos_Id,
                Emple_Id = item.Emple_Id,
                Poliz_Cuotas = item.Poliz_Cuotas,
                Poliz_EstadoCuotasPoliza = false,
            };
            var list = _salesServices.InsertPoliz(modelo);
            return Ok(list);
        }
    }
}
