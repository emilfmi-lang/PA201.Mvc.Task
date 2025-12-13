fetch("home/test")
    .then((response) => response.text())
    .then((data) => console.log(data)).
    catch((error) => console.error("Error:", error));

$(document).ready(function () {
    $(".bookModalIcon").click(function (e) {
        let url = $(this).attr("href");
        fetch(url)
            .then((response) => response.text())
            .then((data) => {
                $("#bookModal .modal-dialog").html(data);
                $("#bookModal").modal("show");

            })
    })


