$(document).ready(function () {
    $('.submit').click(function(event) { 
        event.preventDefault(); 
        var nombre = $('.nombre').val();
        var apellido = $('.apellido').val();
        var edad = $('.edad').val();

        if(nombre.length <3){
            document.getElementById('error-name').innerHTML="Por favor ingrese nombre";
        }
        if(apellido.length <3){
            document.getElementById('error-lastname').innerHTML="Por favor, introduce un apellido con almenos 3 caracteres";
        }
    });
});