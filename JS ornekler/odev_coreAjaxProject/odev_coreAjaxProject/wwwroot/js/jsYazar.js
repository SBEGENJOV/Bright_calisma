$(document).ready(function () {
    showYazarData();
});

function showYazarData() {
    var url = $('#urlYazarData').val();
    $.ajax({
        url: url,
        type: 'Get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.yazarID + '</td>';
                object += '<td>' + item.yazarAdSoyad + '</td>';
                object += '<td>' + item.yazarMemleket + '</td>';
                object += '<td>' + item.yazarYas + '</td>';
                object += '<td>' + item.yazarKitapYaz + '</td>';
                object += '<td><a href="#" class="btn btn-primary" onclick="edit(' + item.yazarID + ');">Edit</a> || <a href="#" class="btn btn-danger" onclick="Delete(' + item.yazarID + ');">Delete</a></td>';
                object += '</tr>';
            });
            $('#table_date').html(object)
        }//, error: function () {
        //    alert("Data yüklenemedi")
        //}
    });
}

$("#btnAddYazar").click(function () {
    $("#yazarModal").modal('toggle');
    $("#yazarIDdiv").hide();
    $("#AddYazar").css('display', 'block');
    $("#updateYazar").css('display', 'none');
    $("#ustModal").text('Yeni Yazar Ekle');
});

function ClearAl() {
    $("#yazarID").val("");
    $("#yazarAd").val("");
    $("#yazarMemleket").val("");
    $("#yazarYas").val("");
    $("#yazarKS").val("");
}

HideModalPopUp = () => {
    $('#yazarModal').modal('hide');
}

function yazarAdd() {
    var objdata = {
        YazarAdSoyad: $("#yazarAd").val(),
        YazarMemleket: $("#yazarMemleket").val(),
        YazarYas: $("#yazarYas").val(),
        YazarKitapYaz: $("#yazarKS").val()
    }
    $.ajax({
        url: "/Yazar/Add",
        type: "post",
        data: objdata,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: "json",

        success: function () {
            alert("Kayıt başarılı");
            HideModalPopUp();
            showYazarData();
        },
        error: function () {
            alert("Işlem gerçekleşemedi");
        }
    })
}

function edit(id) {
    $.ajax({
        url: "/Yazar/Edit/" + id,
        type: "get",
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',

        success: function (response) {
            $("#yazarModal").modal('show');
            $("#yazarID").val(response.yazarID);
            $("#yazarAd").val(response.yazarAdSoyad);
            $("#yazarMemleket").val(response.yazarMemleket);
            $("#yazarYas").val(response.yazarYas);
            $("#yazarKS").val(response.yazarKitapYaz);
           // $("#yazarIDdiv").hide();
            $("#addBtn").css('display', 'none');
            $("#updateBtn").css('display', 'block');
            $("#ustModal").text('Yazar Güncelle');
        },
        error: function () {
            alert("Veriler gelmedi, Hata Oluştu")
        }
    })
}

function update() {
    var objdata = {
        YazarID: $("#yazarID").val(),
        YazarAdSoyad: $("#yazarAd").val(),
        YazarMemleket: $("#yazarMemleket").val(),
        YazarYas: $("#yazarYas").val(),
        YazarKitapYaz: $("#yazarKS").val()
    }
    $.ajax({
        url: "/Yazar/Edit/",
        type: "post",
        data: objdata,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function () {
            alert("İşlem Başarılı, Güncelleme Tamam")
            HideModalPopUp();
            ClearAl();
            showYazarData();
        },
        Error: function () {
            alert("Güncellem işlemi başarısız")
        }
    })
}

function Delete(id) {
    if (confirm("Silmek İstediginize Emin Misiniz")) {
        $.ajax({
            url: "/Yazar/Delete/" + id,
            success: function () {
                alert("Silme işlemi başarılı");
                showYazarData();
            },
            Error: function () {
                alert("Silme Yapılamadı");
            }
        })
    }
}

