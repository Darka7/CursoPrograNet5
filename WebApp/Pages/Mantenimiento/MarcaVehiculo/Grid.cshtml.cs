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

       
        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                Grid = await service.MarcaVehiculoGet();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            return Page();

        }


    }
}
