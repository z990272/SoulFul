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
function add(count_Id, ProductId) {
    var Add = count_Id.value;
    Add++;
    count_Id.value = Add;

    $.ajax({
        type: "POST",
        url: "/Shopping/AddCount",
        data: { ProductId: ProductId },
        dataType: "text",
    });
}
//Reduce
function reduce(count_Id, ProductId) {
    var Reduce = count_Id.value;
    if (Reduce > 1) {
        Reduce--;
        count_Id.value = Reduce;

        $.ajax({
            type: "POST",
            url: "/Shopping/ReduceCount",
            data: { ProductId: ProductId },
            dataType: "text",
        });

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

function RemoveProduct(Product_id, _albumId) {

    ReduceProductCount(_albumId);
    document.getElementById('ShowCartProduct').removeChild(Product_id);
    GetTotalAmount();

}
function GetTotalAmount() {
    var totalAmount = document.querySelector('.total p span');
    var temp = 0;
    document.querySelectorAll('.totalAmount').forEach(item => {
        temp += Number.parseFloat(item.textContent);
    });
    totalAmount.textContent = temp;
}

function Send() {
    let nameElement = document.querySelector('#name');
    let emailElement = document.querySelector('#email');
    let subjectElement = document.querySelector('#subject');
    let messageElement = document.querySelector('#message');
    let input = document.querySelector('#giveback').querySelectorAll('input');

    let name = nameElement.value;
    let email = emailElement.value;
    let subject = subjectElement.value;
    let message = messageElement.value;

    let dataisnull = false;

    input.forEach(item => {
        if (item.value == '' || item.value == null) {
            dataisnull = true;
        }
    })

    if (dataisnull) {
        alert("欄位不可為空白");
    }

    if (email.includes('@') == true) {

        $.ajax({
            type: "GET",
            url: "/GiveBack/CreateData",
            data: { Name: name, Email: email, Subject: subject, Message: message },
            dataType: "text",
            success: function (response) {
                alert("感謝回饋");
            }
        });
        input.forEach(item => {
            item.value = "";
        })

    }
    else {
        alert('email 必須為信箱格式');
    }
}

