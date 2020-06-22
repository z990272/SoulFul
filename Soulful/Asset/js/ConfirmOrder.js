var checkbox = document.querySelector('#check');
checkbox.addEventListener('click', function () {
    if (checkbox.checked) {
        $('#submit').attr("disabled", false);
        $('#submit').attr("readonly", "readonly");
    }
    else {
        $('#submit').attr("readonly", false);
        $('#submit').attr("disabled", "disabled");
    }
});

//function checked() {
//    if (checkbox.checked) {
//        ('#submit').attr("readonly", "readonly");
//    }
//}