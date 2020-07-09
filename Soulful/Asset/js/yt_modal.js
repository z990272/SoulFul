function videoShow(modal) {

    let _VideoId = modal.id;

    $.ajax({
        type: "POST",
        url: "/Home/GetData",
        data: { Id: _VideoId },
        dataType: "text",
        success: function (responce) {
            modalShow(responce)
        }
    });
}

function modalShow(data) {
    let body = document.querySelector('#modalContainer');
    body.innerHTML = null;

    let iframe = document.createElement('iframe');
    iframe.src = "https://www.youtube.com/embed/" + data

    body.appendChild(iframe);

    $('#myModal').modal('show');
}