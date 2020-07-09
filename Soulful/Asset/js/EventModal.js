function show(modal) {

    let _EventId = modal.id;
    $.ajax({
        type: "POST",
        url: "/Event/GetData",
        data: { Id : _EventId },
        dataType: "text",
        success: function (responce) {
            modalShow(JSON.parse(responce))
        }
    });
}

function modalShow(data) {
    let body = document.querySelector('#modalContainer');
    body.innerHTML = null;

    let img = document.createElement('img');
    img.src = data.Pic;

    let h4 = document.createElement('h4');
    h4.innerText = data.Name;

    let h5 = document.createElement('h5');
    h5.innerText = data.Singer;

    let date = document.createElement('h6');
    date.innerText = data.Date;

    let address = document.createElement('h6');
    address.innerText = data.Address;
    address.style.fontSize = '18px';

    let p = document.createElement('p');
    p.innerText = data.About;

    body.appendChild(img);
    body.appendChild(h4);
    body.appendChild(h5);
    body.appendChild(date);
    body.appendChild(address);
    body.appendChild(p);

    $('#myModal').modal('show');
}


