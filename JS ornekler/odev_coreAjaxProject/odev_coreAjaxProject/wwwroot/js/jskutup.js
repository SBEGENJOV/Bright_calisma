$(document).ready(function () {
    showKutupData();
});

function showKutupData() {
    var url = $('#urlKutupData').val();
    $.ajax({
        url: url,
        type: 'Get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.kutuphaneID + '</td>';
                object += '<td>' + item.kutuphaneAd + '</td>';
                object += '<td>' + item.kutuphaneKonum + '</td>';
                object += '<td>' + item.kutuphaneMasaSay + '</td>';
                object += '<td>' + item.kutuphaneYonetici + '</td>';
                object += '<td><a href="#" class="btn btn-primary" onclick="edit(' + item.kutuphaneID + ');">Edit</a> || <a href="#" class="btn btn-danger" onclick="Delete(' + item.kutuphaneID + ');">Delete</a></td>';
                object += '</tr>';
            });
            $('#table_date').html(object)
        }//, error: function () {
        //    alert("Data yüklenemedi")
        //}
    });
}

$("#btnAddKutup").click(function () {
    $("#kutupModal").modal('toggle');
    $("#kutupIDdiv").hide();
    $("#AddKutup").css('display', 'block');
    $("#updateKutup").css('display', 'none');
    $("#ustModal").text('Yeni Kütüphane Ekle');
});

function ClearAl() {
    $("#kutupID").val("");
    $("#kutupAd").val("");
    $("#kutupKonum").val("");
    $("#kutupMasSay").val("");
    $("#kutupYonetici").val("");
}

HideModalPopUp = () => {
    $('#kutupModal').modal('hide');
}

function kutupAdd() {
    var objdata = {
        kutuphaneAd: $("#kutupAd").val(),
        kutuphaneKonum: $("#kutupKonum").val(),
        kutuphaneMasaSay: $("#kutupMasSay").val(),
        kutuphaneYonetici: $("#kutupYonetici").val()
    }
    $.ajax({
        url: "/Kutuphane/Add",
        type: "post",
        data: objdata,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: "json",

        success: function () {
            alert("Kayıt başarılı");
            HideModalPopUp();
            showKutupData();
        },
        error: function () {
            alert("Işlem gerçekleşemedi");
        }
    })
}

function edit(id) {
    $.ajax({
        url: "/Kutuphane/Edit/" + id,
        type: "get",
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',

        success: function (response) {
            $("#kutupModal").modal('show');
            $("#kutupID").val(response.kutuphaneID);
            $("#kutupAd").val(response.kutuphaneAd);
            $("#kutupKonum").val(response.kutuphaneKonum);
            $("#kutupMasSay").val(response.kutuphaneMasaSay);
            $("#kutupYonetici").val(response.kutuphaneYonetici);
            // $("#yazarIDdiv").hide();
            $("#addBtn").css('display', 'none');
            $("#updateBtn").css('display', 'block');
            $("#ustModal").text('Kütüphane Güncelle');
        },
        error: function () {
            alert("Veriler gelmedi, Hata Oluştu")
        }
    })
}

function update() {
    var objdata = {
        kutuphaneID: $("#kutupID").val(),
        kutuphaneAd: $("#kutupAd").val(),
        kutuphaneKonum: $("#kutupKonum").val(),
        kutuphaneMasaSay: $("#kutupMasSay").val(),
        kutuphaneYonetici: $("#kutupYonetici").val()
    }
    $.ajax({
        url: "/Kutuphane/Edit/",
        type: "post",
        data: objdata,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function () {
            alert("İşlem Başarılı, Güncelleme Tamam")
            HideModalPopUp();
            ClearAl();
            showKutupData();
        },
        Error: function () {
            alert("Güncellem işlemi başarısız")
        }
    })
}

function Delete(id) {
    if (confirm("Silmek İstediginize Emin Misiniz")) {
        $.ajax({
            url: "/Kutuphane/Delete/" + id,
            success: function () {
                alert("Silme işlemi başarılı");
                showKutupData();
            },
            Error: function () {
                alert("Silme Yapılamadı");
            }
        })
    }
}

