// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    /*$('#movie-list').DataTable({
        "paging": false,
        "searching": false,
        "info": false,
        "columnDefs": [
            { "orderable": false, "targets": [1, 3, 4, 5] }
        ]
    })*/
    let imdb_id = $("#poster-container").data("imdb");
    console.log(imdb_id);
    if (imdb_id) {
        $.getJSON("https://www.omdbapi.com/?i=" + imdb_id + "&apikey=414cb67", function (data) {
            console.log(data);
            $("#poster").attr("src", data.Poster);
        });
    }
});