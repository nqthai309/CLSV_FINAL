import { Alert } from "bootstrap";
$(document).ready(function () {
    $("#btnSend").attr('type', 'button');
})

$('#btnSend').click(function () {
    var content = $('contentComment').val();
    var idAcccount = $('user_id').val();
    if (content === "" || idAcccount == null) {
        alert("Chưa điền nội dung bình luận hoặc chưa đăng nhập");
    } else {
        $.ajax({
            method: "get",
            url: "/Hotel2/SendComment",
            data: { idAcccount: idAcccount, content: content },
        }).done(function (respone) {
            if (respone == -1) {
                alert("bạn chỉ có thể đánh giá khi đã sử dụng khách sạn!");
            } else {
                alert("Gửi bình luận thành công");
                location.reload();
            }
        });
    }

});