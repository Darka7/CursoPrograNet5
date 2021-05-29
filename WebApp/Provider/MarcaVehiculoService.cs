using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Entity;
namespace WebApp
{
    public class MarcaVehiculoService
    {
        private readonly HttpClient client;

        public MarcaVehiculoService(HttpClient _client )
        {
            client = _client;
        }


        #region MarcaVehiculo

        public async Task<IEnumerable<MarcaVehiculoEntity>> MarcaVehiculoGet()
        {

            var result = await client.ServicioGetAsync<IResult<MarcaVehiculoEntity>>("api/MarcaVehiculo");

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result.Data;

        }


        public async Task<MarcaVehiculoEntity> MarcaVehiculoGetById(int id)
        {

            var result = await client.ServicioGetAsync<MarcaVehiculoEntity>($"api/MarcaVehiculo/{id}");

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }


        public async Task<DBEntity> MarcaVehiculoPost(MarcaVehiculoEntity entity)
        {

            var result = await client.ServicioPostAsync<MarcaVehiculoEntity, DBEntity>("api/MarcaVehiculo", entity);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }


        public async Task<DBEntity> MarcaVehiculoPut(MarcaVehiculoEntity entity)
        {

            var result = await client.ServicioPutAsync<MarcaVehiculoEntity, DBEntity>("api/MarcaVehiculo", entity);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }


        public async Task<DBEntity> MarcaVehiculoDelete(int id)
        {

            var result = await client.ServicioDeleteAsync<DBEntity>($"api/MarcaVehiculo/{id}");

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }

        #endregion



    }
}
