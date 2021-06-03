namespace MarcaVehiculoGrid {
    declare var MensajeGrid:string;

    if (MensajeGrid!="") {
        Toast.fire({
            icon: "success",
            title: MensajeGrid
        })
            .then(() => window.location.href = "Mantenimiento/MarcaVehiculo/Grid");
    }

   export  function OnClickEliminar(id) {

        ComfirmAlert("Desea Eliminar Este registro", "Si", "warning", "#3085d6", "#d33").then(result => {

            if (result.isConfirmed) {

                window.location.href = "Mantenimiento/MarcaVehiculo/Grid/BorrarDatos?id="+id;

            }
        });
          
    }

  

    $("#GridView").DataTable();

    
}