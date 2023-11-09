//---------------------------------------------------------------- Hesaplama işlemlerini yapan kısım --------------------------------------------------------
var islem;
function islemSonuc() {
    islem = document.getElementById("metin").value;
    if (islem == isNaN) {
        alert("hata işlemini gözden geçir");
    }
    else {
        document.getElementById("metin").value = eval(islem);
    }
}

//--------------------------------------------------- Buttonlara basıldıgında alana sayı ve işlemlerin gelmesini saglar. -------------------------------------------------
function bir() {
    var birr = document.getElementById("metin").value += 1;
}
function iki() {
    document.getElementById("metin").value += 2;
}
function uc() {
    document.getElementById("metin").value += 3;
}
function dort() {
    document.getElementById("metin").value += 4;
} function bes() {
    document.getElementById("metin").value += 5;
} function alti() {
    document.getElementById("metin").value += 6;
} function yedi() {
    document.getElementById("metin").value += 7;
} function sekiz() {
    document.getElementById("metin").value += 8;
} function dokuz() {
    document.getElementById("metin").value += 9;
}
function sifir() {
    document.getElementById("metin").value += 0;
}
function arti() {
    document.getElementById("metin").value += "+";
}
function eksi() {
    document.getElementById("metin").value += "-";
} function carp() {
    document.getElementById("metin").value += "*";
} function bol() {
    document.getElementById("metin").value += "/";
}
function temiz() {
    document.getElementById("metin").value = "";
}

//-----------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------- Klavyeden harf ve özel karekter girmesini engeller.---------------------------------------
function engelle() {
    if (event.keyCode == 8 || (event.keyCode >= 96 && event.keyCode <= 111)) {
        return;
    }
    // Tuş basımını `preventDefault()` yöntemini çağırarak engelleyin.
    event.preventDefault();
}
document.getElementById("metin").addEventListener("keydown", engelle);