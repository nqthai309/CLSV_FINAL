$(document).ready(function () {
    $("#register").attr('type', 'button');
});

$("#username").keyup(function () {

    var user = $("#username").val();
    var pass = $("#password").val();
    $.ajax({
        method: "get",
        url: "/User/checkDangKy",
        data: { user: user, pass: pass }
    }).done(function (thongbao) {
        if (thongbao == "0") {
            var fullName = $("#full_name").val();
            var phone = $("#phone").val();
            var email = $("#email").val();
            var address = $("#address").val();
            var userName = $("#username").val();
            var passWord = $("#password").val();
            if (fullName == "" || phone == "" || email == "" || address == "" || userName == "" || passWord == "") {
                $("#divThongBao1").html("");
                $("#divThongBao2").html("Vui lòng điền đầy đủ thông tin");
                $("#register").attr('type', 'button');
            } else {
                $("#register").attr('type', 'submit');
                $("#divThongBao1").html("Tài Khoản Có Thể Đăng Ký !");
                $("#divThongBao2").html("");
                $("#register").html("Sign Up");
            }
            
        }
        else {
            $("#divThongBao2").html("Username bị trùng !");
            $("#register").attr('type', 'button');
            $("#divThongBao1").html("");
        }
    });
});
$("#full_name").keyup(function () {

    var user = $("#username").val();
    var pass = $("#password").val();
    $.ajax({
        method: "get",
        url: "/User/checkDangKy",
        data: { user: user, pass: pass }
    }).done(function (thongbao) {
        if (thongbao == "0") {
            var fullName = $("#full_name").val();
            var phone = $("#phone").val();
            var email = $("#email").val();
            var address = $("#address").val();
            var userName = $("#username").val();
            var passWord = $("#password").val();
            if (fullName == "" || phone == "" || email == "" || address == "" || userName == "" || passWord == "") {
                $("#divThongBao1").html("");
                $("#divThongBao2").html("Vui lòng điền đầy đủ thông tin");
                $("#register").attr('type', 'button');
            } else {
                $("#register").attr('type', 'submit');
                $("#divThongBao1").html("Tài Khoản Có Thể Đăng Ký !");
                $("#divThongBao2").html("");
                $("#register").html("Sign Up");
            }

        }
        else {
            $("#divThongBao2").html("Username bị trùng !");
            $("#register").attr('type', 'button');
            $("#divThongBao1").html("");
        }
    });
});
$("#phone").keyup(function () {

    var user = $("#username").val();
    var pass = $("#password").val();
    $.ajax({
        method: "get",
        url: "/User/checkDangKy",
        data: { user: user, pass: pass }
    }).done(function (thongbao) {
        if (thongbao == "0") {
            var fullName = $("#full_name").val();
            var phone = $("#phone").val();
            var email = $("#email").val();
            var address = $("#address").val();
            var userName = $("#username").val();
            var passWord = $("#password").val();
            if (fullName == "" || phone == "" || email == "" || address == "" || userName == "" || passWord == "") {
                $("#divThongBao1").html("");
                $("#divThongBao2").html("Vui lòng điền đầy đủ thông tin");
                $("#register").attr('type', 'button');
            } else {
                $("#register").attr('type', 'submit');
                $("#divThongBao1").html("Tài Khoản Có Thể Đăng Ký !");
                $("#divThongBao2").html("");
                $("#register").html("Sign Up");
            }

        }
        else {
            $("#divThongBao2").html("Username bị trùng !");
            $("#register").attr('type', 'button');
            $("#divThongBao1").html("");
        }
    });
});
$("#email").keyup(function () {

    var user = $("#username").val();
    var pass = $("#password").val();
    $.ajax({
        method: "get",
        url: "/User/checkDangKy",
        data: { user: user, pass: pass }
    }).done(function (thongbao) {
        if (thongbao == "0") {
            var fullName = $("#full_name").val();
            var phone = $("#phone").val();
            var email = $("#email").val();
            var address = $("#address").val();
            var userName = $("#username").val();
            var passWord = $("#password").val();
            if (fullName == "" || phone == "" || email == "" || address == "" || userName == "" || passWord == "") {
                $("#divThongBao1").html("");
                $("#divThongBao2").html("Vui lòng điền đầy đủ thông tin");
                $("#register").attr('type', 'button');
            } else {
                $("#register").attr('type', 'submit');
                $("#divThongBao1").html("Tài Khoản Có Thể Đăng Ký !");
                $("#divThongBao2").html("");
                $("#register").html("Sign Up");
            }

        }
        else {
            $("#divThongBao2").html("Username bị trùng !");
            $("#register").attr('type', 'button');
            $("#divThongBao1").html("");
        }
    });
});
$("#address").keyup(function () {

    var user = $("#username").val();
    var pass = $("#password").val();
    $.ajax({
        method: "get",
        url: "/User/checkDangKy",
        data: { user: user, pass: pass }
    }).done(function (thongbao) {
        if (thongbao == "0") {
            var fullName = $("#full_name").val();
            var phone = $("#phone").val();
            var email = $("#email").val();
            var address = $("#address").val();
            var userName = $("#username").val();
            var passWord = $("#password").val();
            if (fullName == "" || phone == "" || email == "" || address == "" || userName == "" || passWord == "") {
                $("#divThongBao1").html("");
                $("#divThongBao2").html("Vui lòng điền đầy đủ thông tin");
                $("#register").attr('type', 'button');
            } else {
                $("#register").attr('type', 'submit');
                $("#divThongBao1").html("Tài Khoản Có Thể Đăng Ký !");
                $("#divThongBao2").html("");
                $("#register").html("Sign Up");
            }

        }
        else {
            $("#divThongBao2").html("Username bị trùng !");
            $("#register").attr('type', 'button');
            $("#divThongBao1").html("");
        }
    });
});
$("#password").keyup(function () {

    var user = $("#username").val();
    var pass = $("#password").val();
    $.ajax({
        method: "get",
        url: "/User/checkDangKy",
        data: { user: user, pass: pass }
    }).done(function (thongbao) {
        if (thongbao == "0") {
            var fullName = $("#full_name").val();
            var phone = $("#phone").val();
            var email = $("#email").val();
            var address = $("#address").val();
            var userName = $("#username").val();
            var passWord = $("#password").val();
            if (fullName == "" || phone == "" || email == "" || address == "" || userName == "" || passWord == "") {
                $("#divThongBao1").html("");
                $("#divThongBao2").html("Vui lòng điền đầy đủ thông tin");
                $("#register").attr('type', 'button');
            } else {
                $("#register").attr('type', 'submit');
                $("#divThongBao1").html("Tài Khoản Có Thể Đăng Ký !");
                $("#divThongBao2").html("");
                $("#register").html("Sign Up");
            }

        }
        else {
            $("#divThongBao2").html("Username bị trùng !");
            $("#register").attr('type', 'button');
            $("#divThongBao1").html("");
        }
    });
});