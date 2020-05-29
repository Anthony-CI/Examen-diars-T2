

$.ajax({
    type: 'Get',
    url: "/Pelicula/Mostar?query=" + $("#buscar").val()
}).done(function (response) {
    $("div#Tabla").html(response);
});
$("form.form-inline").on('submit', function (evento) {
    $.ajax({
        type: 'Get',
        url: "/Pelicula/Mostar?query=" + $("#buscar").val()
    }).done(function (response) {
        $("div#Tabla").html(response);
    });
    evento.preventDefault();
});