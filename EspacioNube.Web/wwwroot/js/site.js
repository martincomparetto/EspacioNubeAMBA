// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const BuscarProfesionales = () => {
    const especialidadID = $('#especialidades').val();
    const url = `http://localhost:65083/Profesionales/GetByEspecialidad?especialidadID=${especialidadID}`;

    let data = {
        type: "GET",
        url: url,
        success: (respuesta) => {
            let tabla = $("#tablaProfesionales");
            tabla.empty();
            tabla.append(`
                    <tr>
                        <th>Nombre</th>
                        <th>Apellido</th>
                        <th>Matricula</th>
                    </tr>
                `);
            for (let index = 0; index < respuesta.length; index++) {
                tabla.append(`
                    <tr>
                        <td>${respuesta[index].nombre}</td>
                        <td>${respuesta[index].apellido}</td>
                        <td>${respuesta[index].matricula}</td>
                    </tr>
                `);
            }
        },
        error: () => {

        }
    };

    $.ajax(data);

}
