$(document).ready(function () {
    showEmployeeData();
});
 
function showEmployeeData() {
    var url = $('#urlEmployeData').val();
    $.ajax({
        
        url: url,
        type: 'Get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var object = '';
            console.log(result);
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.id + '</td>';
                object += '<td>' + item.name + '</td>';
                object += '<td>' + item.city + '</td>';
                object += '<td>' + item.state + '</td>';
                object += '<td>' + item.salary + '</td>';
                object += '<td><a href="#" class="btn btn-primary" onclick="Edit(' + item.id + ');">Edit</a> || <a href="#" class="btn btn-danger" onclick="Delete(' + item.id + ');">Delete</a></td>';
                object += '</tr>';
            });
            $('#table_date').html(object)
        }, error: function () {
            alert("Data yüklenemedi")
        }
    });
};
 
$("#btnAddEpmloye").click(() => {
    ClearTextBox();
    $("#employeeModel").modal('show');
    $("#empId").hide();
   // $("#AddEmploye").css('display', 'block');
   // $("#btnUpdate").css('display', 'none');
    $("#employeeHeading").text('Add Employee');
});
 
AddEmploye = () => {
    var objData = {
        Name: $('#Name').val(),
        City: $('#city').val(),
        State: $('#state').val(),
        Salary: $('#salary').val()
    }
    $.ajax({
        url: '/EmployeControler/AddEmploye',
        type: 'Post',
        data: objData,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function () {
            alert('kayıt başarılı');
            ClearTextBox();
            showEmployeeData();
            HideModalPopUp();
        },
        eror: () => {
            alert('Kayıt Başarısız');
        }
    })
}
 
HideModalPopUp = () => {
    $('#employeeModel').modal('hide');
}
tamKapat = () => {
    HideModalPopUp();
    ClearTextBox();
}
 
function ClearTextBox() {
    $('#empId').val('');
    $('#Name').val('');
    $('#city').val('');
    $('#state').val('');
    $('#salary').val('');

}
 
Delete = (id) => {
    if (confirm('Silemk istedigine emin misin')) {
        $.ajax({
            url:'/EmployeControler/Delete?id=' + id,
            success: () => {
                alert("silme işlemi başarılı")
                showEmployeeData();
            },
            eror: function () {
                alert("silme işlemi yapılamadı")
            }
        })
    }
}
 
function Edit(id) {
    $.ajax({
        url: '/EmployeControler/Edit/' + id, 
        type: 'Get',
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',
        success: function (response) {
            $('#employeeModel').modal('show');
            $('#EmployeeID').val(response.id);
            $('#Name').val(response.name);
            $('#city').val(response.city);
            $('#state').val(response.state);
            $('#salary').val(response.salary);
            $("#AddEmploye").css('display', 'none');
            $("#btnUpdate").css('display', 'block');
            $("#employeeHeading").text('Update Employee');
        },
        eror: function () {
            alert("veriler gelemdi");
        }
    })
}
 
function updateEmployee () {
    var objdata = {
        Id: $('#EmployeeID').val(),
        Name: $('#Name').val(),
        City: $('#city').val(),
        State: $('#state').val(),
        Salary: $('#salary').val()
    }
    console.log(objdata)

    $.ajax({
        url: '/EmployeControler/Update', 
        type: 'Post',
        data: objdata,
        contentType:'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function () {
            alert("Veriler güncellendi");
            showEmployeeData();
            ClearTextBox();
        },
        error: function () {
            alert("Güncelleme başarısız");
        }
    })
}