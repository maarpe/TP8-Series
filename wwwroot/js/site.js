function MostrarActor(idS)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarActoresAjax',
            data: { idSerie: idS },
            success:
                function(response)
                {
                    $("#nombreActor").html(response.nombreActor);                
                }
             
        })
}

function MostrarMasInfo(idS)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarSinopsisAjax',
            data: { idSerie: idS },
            success:
                function(response)
                {
                    $("#sinopsis").html(response.sinopsis);                
                }
             
        })
}

function MostrarTemporadas(idS)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarTemporadasAjax',
            data: { idSerie: idS },
            success:
                function(response)
                {
                    $("#temporadas").html(response.temporadas);                
                }
             
        })
}