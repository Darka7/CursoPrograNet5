namespace MarcaVehiculoGrid {



   export  function OnClickEliminar() {

        ComfirmAlert("Desea Eliminar Este registro", "Si", "warning", "#3085d6", "#d33").then(result => {

            if (result.isConfirmed) {

                alert("si")

            }
        });
          
    }



    $("#GridView").DataTable();

    
}