$(document).ready(function () {
    $("#btnSearch").attr('type', 'button');
    var listIdService = document.getElementById("listIdService");
    var listIdConvenient = document.getElementById("listIdConvenient");
    idServices = [];
    idConvenients = [];
    var i;
    for (i = 0; i < listIdService.length; i++){
        idServices.push(listIdService.options[i].text);
    }
    for (i = 0; i < listIdConvenient.length; i++) {
        idConvenients.push(listIdConvenient.options[i].text);
    }

});

$("#btnSearch").click(function (){
    var i;
    idService_select = [];
    idConvenient_select = [];
    for (i = 0; i < idServices.length; i++) {
        var e = document.getElementById("service+" + idServices[i]);
        if (e.checked) {
            idService_select.push(idServices[i]);
        }
    }
    for (i = 0; i < idConvenients.length; i++) {
        var e = document.getElementById("convenient+" + idConvenients[i]);
        if (e.checked) {
            idConvenient_select.push(idConvenients[i]);
        }
    }

    $.ajax({
        method: "get",
        url: "Hotel2/SearchEngine",
        data: { idService_select: idService_select, idConvenient_select: idConvenient_select }
    }).done();
});