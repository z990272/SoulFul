function show(modal) {
    let id = modal.id;

    $.ajax({
        type: "POST",
        url: "/Album/AlbumClick",
        data: { id: id},
        dataType: "text",
        success: function (responce) {
            modalShow(JSON.parse(responce))
        }
    });

}

function modalShow(data) {
    let img = document.querySelector('.carousel-item img');  
    img.src = data.Pic;

    let h4 = document.querySelector('.product-name strong');
    h4.innerText = data.Name;

    let h5 = document.querySelector('.card-header h5');
    h5.innerText = data.Album_Name;

    let p = document.querySelector('.card-body p');
    p.innerText = data.About;

    let price = document.querySelector('.card-body span');
    price.innerText = data.Price;

    let order = document.querySelector('.order button');
    order.setAttribute('onclick', 'postValue('+data.Album_id+')');


    $('#modalQuickView').modal('show');
}


