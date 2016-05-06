$('#frmContacto').submit(function (e) {
    e.preventDefault();
    $.getJSON(
        '/Contacto/EnviarComentario',
        $('#frmContacto').serialize(),
        function (data) {
            alert(data);
    });
});