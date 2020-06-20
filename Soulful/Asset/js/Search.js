function OnInputSearch(input) {
    var value = input.value;

    $.ajax({
        type: "POST",
        url: "/Album/OnclickAlbums",
        data: { search: value },
        dataType: "text",
        success: function (response) {
            $('.product-area .row').html(response);
        },
        error: function (response) {
            alert("fail");
        }
    });
}