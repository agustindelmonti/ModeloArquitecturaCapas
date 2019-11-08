
//Al seleccionar una especialidad, busca todos los planes de esta
function GetPlanes(_especialidadid) {
    var procemessage = "<option value='0'> Buscando...</option>";
    $("#ddlplanes").html(procemessage).show();
    var url = "/Plan/GetPlanesByEspecialidad/";

    $.ajax({
        url: url,
        data: { especialidadid: _especialidadid },
        cache: false,
        type: "POST",
        success: function (data) {
            var markup = "<option value='0'>Seleccionar plan</option>";
            for (var x = 0; x < data.length; x++) {
                markup += "<option value=" + data[x].Value + ">" + data[x].Text + "</option>";
            }
            $("#ddlplanes").html(markup).show();
        },
        error: function (reponse) {
            alert("error : " + reponse);
        }
    });

}