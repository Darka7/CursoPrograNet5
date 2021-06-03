using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity;
namespace WebApp.Pages.Mantenimiento.MarcaVehiculo
{
    public class GridModel : PageModel
    {
        [ViewData]
        public string Title => "Marcas Vehiculo";


        private readonly MarcaVehiculoService service;

        public GridModel(MarcaVehiculoService service)
        {
            this.service = service;
        }

        public IEnumerable<MarcaVehiculoEntity> Grid { get; set; } = new List<MarcaVehiculoEntity>();

        public string Mensaje { get; set; }

        public async Task<IActionResult> OnGetAsync(int? code)
        {
            try
            {
                Grid = await service.MarcaVehiculoGet();
                if (code.HasValue) {

                    Mensaje = code == 1 ? "Se elimino el registro!" : null;
                
                }

            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            return Page();

        }

        
        public async Task<IActionResult> OnGetBorrarDatosAsync(int id)
        {
            try
            {
                var result = await service.MarcaVehiculoDelete(id);

                return Redirect("../Grid?code=1");

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
            
        }

      


    }
}
