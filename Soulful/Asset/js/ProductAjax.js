function postValue(_albumId) {
    $.ajax({
        type: "POST",
        url: "/Shopping/GetCartCount",
        data: { ProductId: _albumId },
        dataType: "text",
        success: function (response) {
            $("#CartCount").text("Cart(" + response + ")");
            showProduct(_albumId);
        }
    });

}

function showProduct(_albumId) {
    $.ajax({
        type: "POST",
        url: "/Shopping/AddToCart",
        data: { ProductId: _albumId },
        dataType: "text",
        success: function (response) {
            $("#ProductShow").html(response);
        }
    });
}

var count = document.getElementById("count");


//Add
function add(count_Id) {
    var Add = count_Id.value;
    Add++;
    count_Id.value = Add;
}
//Reduce
function reduce(count_Id) {
    var Reduce = count_Id.value;
    if (Reduce > 1) {
        Reduce--;
        count_Id.value = Reduce;
    }
    else {
        count_Id.value = 1;
    }
}

function ReduceProductCount(_albumId) {
    $.ajax({
        type: "POST",
        url: "/Shopping/ReduceProductCount",
        data: { ProductId: _albumId },
        dataType: "text",
        success: function (response) {
            $("#CartCount").text("Cart(" + response + ")");
            showProduct(_albumId);
        }
    });
}

function RemoveProduct(_albumId) {
    $.ajax({
        type: "POST",
        url: "/Shopping/RemoveProduct",
        data: { ProductId: _albumId },
        dataType: "text",
        success: function (response) {
            $("#ProductShow").html(response);
        }
    });
}