// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    if ($('title').text() == "¿Qué es el JWST? - JWST_PWEB" ||
        $('title').text() == "Electronica - JWST_PWEB" ||
        $('title').text() == "¿Quién fue James Webb? - JWST_PWEB" ||
        $('title').text() == "Espejos - JWST_PWEB" ){
        console.log('Artículo');
        $('.pie-pag').removeClass('fixed-bottom');
    }
    else if ($('title').text() == "Galería - JWST_PWEB") {
        $('aside').remove();
        function agregarImagenes(img1 = "", img2 = "", img3 = "", img4 = ""){
            var blocki = `<div class="row">
                                            <div class="col-2">
                                                <img src="${img1}">
                                            </div>
                                            <div class="col-2">
                                                        <img src="${img2}">
                                            </div>
                                            <div class="col-2">
                                                        <img src="${img3}">
                                            </div>
                                            <div class="col-2">
                                                        <img src="${img4}">
                                            </div>
                                        </div>`;
        $('.contenido').append(blocki)
    }
    agregarImagenes("/pictures/_121342105_jw_telescope_deployment_spa_2x_640-nc.png", "/pictures/_122006151_jamesewebb.jpg", "/pictures/3.png", "/pictures/276i20p25cd81.webp");
    agregarImagenes("/pictures/1200px-JWST-HST-primary-mirrors-es.svg.png", "/pictures/8026703960_2b648fba38_b.jpg", "/pictures/26504730220_6093d4a042_b.jpg", "/pictures/Ariane_5_ECA_launch_article.jpg");
    agregarImagenes("/pictures/astro-APD_FleetNov2019-hw.001_print.jpg", "/pictures/Cohete-Ariane-5-con-el-telescopio-James-Webb.jpg", "/pictures/DUbetu8W0AERmOE.jpg", "/pictures/fgs1.jpg");
    agregarImagenes("/pictures/g-72-3100.jpg", "/pictures/ISIM_3_logical_region.jpg", "/pictures/itarappres1.jpg", "/pictures/james_webb___quien_fue_x6070213x.jpg_1150884414.webp");
    agregarImagenes("/pictures/James_Webb_NASA-scaled.jpg", "/pictures/JWST-HST-primary-mirrors.jpg", "/pictures/jwstartistconcept.jpg", "/pictures/lagpot2.gif");
    agregarImagenes("/pictures/miri.jpg", "/pictures/mirror32_med.jpg", "/pictures/nircam1.jpg", "/pictures/NIRSpec_CAD_sm.jpg");
    agregarImagenes("/pictures/o5X2R.png", "/pictures/TB-1018-p21_fig1.webp", "/pictures/webb.jpg");

    $('img[src=""]').remove();
        $('.aside').remove();

        $('img').click(function () {
            var $(this).next('a');
        });

    } else {
        $('aside').remove();
    }






});

/*
@section Scripts{
    <script>
        $(document).ready(function () {
            

            $('a.new-IF').click(function () {

            })
        });
    </script>
}

@section Scripts{
    <script>
        $(document).ready(function () {

            
        });
    </script>
}




@section Cards{
    <div class="col-3 aside">
        <br>
        <h2 class="aside-title">Datos reelevantes</h2>
        <br>
        <div class="cards">
        </div>
        <br>
        <a class="new-IF" asp-action="Create">Agregar nuevo</a>
    </div>
    }



 */