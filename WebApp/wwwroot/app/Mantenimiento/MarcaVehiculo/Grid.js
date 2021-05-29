"use strict";
var MarcaVehiculoGrid;
(function (MarcaVehiculoGrid) {
    function OnClickEliminar() {
        ComfirmAlert("Desea Eliminar Este registro", "Si", "warning", "#3085d6", "#d33").then(function (result) {
            if (result.isConfirmed) {
                alert("si");
            }
        });
    }
    MarcaVehiculoGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(MarcaVehiculoGrid || (MarcaVehiculoGrid = {}));
//# sourceMappingURL=Grid.js.map