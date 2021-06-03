"use strict";
var MarcaVehiculoGrid;
(function (MarcaVehiculoGrid) {
    if (MensajeGrid != "") {
        Toast.fire({
            icon: "success",
            title: MensajeGrid
        })
            .then(function () { return window.location.href = "Mantenimiento/MarcaVehiculo/Grid"; });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea Eliminar Este registro", "Si", "warning", "#3085d6", "#d33").then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Mantenimiento/MarcaVehiculo/Grid/BorrarDatos?id=" + id;
            }
        });
    }
    MarcaVehiculoGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(MarcaVehiculoGrid || (MarcaVehiculoGrid = {}));
//# sourceMappingURL=Grid.js.map