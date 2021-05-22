using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using Entity;
namespace WebApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaVehiculoController : ControllerBase
    {
        private readonly IMarcaVehiculoService marcaVehiculoService;

        public MarcaVehiculoController(IMarcaVehiculoService _marcaVehiculoService)
        {
            marcaVehiculoService = _marcaVehiculoService;
        }

        [HttpGet]
        public async Task<IResult<MarcaVehiculoEntity>> Get()
        {

            try
            {
                return new(await marcaVehiculoService.Get());
            }
            catch (Exception ex)
            {

                return new() { CodeError= ex.HResult,MsgError=ex.Message };
            }
        }

        [HttpGet("{id}")]
        public async Task<MarcaVehiculoEntity> GetById(int id)
        {

            try
            {
                return await marcaVehiculoService.GetById( new () { MarcaVehiculoId=id}   );
            }
            catch (Exception ex)
            {

                return new() { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }


        [HttpPost]
        public async Task<DBEntity> Create(MarcaVehiculoEntity entity)
        {

            try
            {
                return await marcaVehiculoService.Create(entity);
            }
            catch (Exception ex)
            {

                return new() { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }


        [HttpPut]
        public async Task<DBEntity> Update(MarcaVehiculoEntity entity)
        {

            try
            {
                return await marcaVehiculoService.Update(entity);
            }
            catch (Exception ex)
            {

                return new() { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpDelete("{id}")]
        public async Task<DBEntity> Delete(int id)
        {

            try
            {
                return await marcaVehiculoService.Delete(new() { MarcaVehiculoId=id });
            }
            catch (Exception ex)
            {

                return new() { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }


    }
}
