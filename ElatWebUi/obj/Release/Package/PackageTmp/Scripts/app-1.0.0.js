$(document).ready(function () {
    $(document).foundation();

    $('.lnk-menu-oferta').click(function () {
        $('.oferta-descripcion').each(function (i,element) {
            $(this).addClass('oculto');
        });
        //
        $('#' + $(this).data('id')).removeClass('oculto');
    });
});
