$(document).ready(function () {
    $("#btnThem").attr('type', 'button');
})

$('#btnThem').click(function () {
    var arrService = new Array();
    var lst = document.getElementById('DichVuDaThem');
    for (let i = 0; i < lst.options.length; i++) {
        arrService[i] = lst.options[i].value;
    }

    var location_id = $('#location_id').val();
    var hotel_name = $('#hotel_name').val();
    var image_url = $('#image_add').attr('src');
    var description = $('#description').val();
    var hotel_hotline = $('#hotel_hotline').val();
    var location_details = $('#location_details').val();
    var star = $('#star').val();

    $.ajax({
        method: "post",
        url: "/BackendHotel/AddHotelJS",
        data: {
            arrService: arrService, location_id: location_id, hotel_name: hotel_name, image_url: image_url, description: description,
            hotel_hotline: hotel_hotline, location_details: location_details, star: star
        }
    })

});