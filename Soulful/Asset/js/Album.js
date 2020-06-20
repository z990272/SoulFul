function show(modal) {
    let id = modal.id;
    $('#modalQuickView_'.concat(id)).modal('show');



    $.ajax({
        type: "POST",
        url: "/Album/HitClick",
        data: { id: id},
        dataType: "text",
        success: function () {
            
        }
    });

}

