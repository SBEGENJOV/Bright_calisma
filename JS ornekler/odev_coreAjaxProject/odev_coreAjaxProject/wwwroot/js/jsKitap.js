$(document).ready(function () {
    showKitapData();
});

function showKitapData() {
    var url = $('#urlKitapData').val();
    $.ajax({
        url: url,
        type: 'Get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.kitapID + '</td>';
                object += '<td>' + item.kitapAd + '</td>';
                object += '<td>' + item.kitapYazar + '</td>';
                object += '<td>' + item.kitapYil + '</td>';
                object += '<td>' + item.kitapSayfa + '</td>';
                object += '<td><a href="#" class="btn btn-primary" onclick="edit(' + item.kitapID + ');">Edit</a> || <a href="#" class="btn btn-danger" onclick="Delete(' + item.kitapID + ');">Delete</a></td>';
                object += '</tr>';
            });
            $('#table_date').html(object)
        }//, error: function () {
        //    alert("Data yüklenemedi")
        //}
    });
}

$("#btnAddKitap").click(function () {
    $("#kitapModal").modal('toggle');
    $("#kitapIDdiv").hide();
    $("#AddKitap").css('display', 'block');
    $("#updateYazar").css('display', 'none');
    $("#ustModal").text('Yeni Kitap Ekle');
});

function ClearAl() {
    $("#kitapID").val("");
    $("#kitapAd").val("");
    $("#kitapYazar").val("");
    $("#kitapYil").val("");
    $("#kitapSayfa").val("");
}

HideModalPopUp = () => {
    ClearAl()
    $('#kitapModal').modal('hide');
}

function kitapAdd() {
    ClearAl()
    var objdata = {
        KitapAdSoyad: $("#kitapAd").val(),
        KitapYazar: $("#kitapYazar").val(),
        KitapYil: $("#kitapYil").val(),
        KitapSayfa: $("#kitapSayfa").val()
    }
    $.ajax({
        url: "/Kitap/Add",
        type: "post",
        data: objdata,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: "json",

        success: function () {
            alert("Kayıt başarılı");
            HideModalPopUp();
            showKitapData();
        },
        error: function () {
            alert("Işlem gerçekleşemedi");
        }
    })
}

function edit(id) {
    $.ajax({
        url: "/Kitap/Edit/" + id,
        type: "get",
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',

        success: function (response) {
            $("#kitapModal").modal('show');
            $("#kitapID").val(response.kitapID);
            $("#kitapAd").val(response.kitapAd);
            $("#kitapYazar").val(response.kitapYazar);
            $("#kitapYil").val(response.kitapYil);
            $("#kitapSayfa").val(response.kitapSayfa);
            // $("#yazarIDdiv").hide();
            $("#addBtn").css('display', 'none');
            $("#updateBtn").css('display', 'block');
            $("#ustModal").text('Kitap Güncelle');
        },
        error: function () {
            alert("Veriler gelmedi, Hata Oluştu")
        }
    })
}

function update() {
    var objdata = {
        KitapID: $("#kitapID").val(),
        KitapAd: $("#kitapAd").val(),
        KitapYazar: $("#kitapYazar").val(),
        KitapYil: $("#kitapYil").val(),
        KitapSayfa: $("#kitapSayfa").val()
    }
    $.ajax({
        url: "/Kitap/Edit/",
        type: "post",
        data: objdata,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function () {
            alert("İşlem Başarılı, Güncelleme Tamam")
            HideModalPopUp();
            ClearAl();
            showKitapData();
        },
        Error: function () {
            alert("Güncellem işlemi başarısız")
        }
    })
}

function Delete(id) {
    if (confirm("Silmek İstediginize Emin Misiniz")) {
        $.ajax({
            url: "/Kitap/Delete/" + id,
            success: function () {
                alert("Silme işlemi başarılı");
                showKitapData();
            },
            Error: function () {
                alert("Silme Yapılamadı");
            }
        })
    }
}

