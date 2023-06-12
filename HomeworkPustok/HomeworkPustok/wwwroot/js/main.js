$(document).on("click", ".modal-btn", function (e) {
    let url=$(this).attr("href")
    fetch(url).then(response => response.text()).then(data => {
        $("#quickModal .modal-dialog").html(data)
    })

    $("#quickModal").modal("show")

})