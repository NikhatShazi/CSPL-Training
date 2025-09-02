﻿///<reference path="../lib/jquery/dist/jquery.js" />

var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').dataTable({
        "ajax": {
            "url": "/books/getall/",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "name", "width": "20%" },
            { "data": "author", "width": "20%" },
            { "data": "isbn", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                        <a href="/Books/upsert?id=${data}" class='btn btn-success text-white' style = 'cursor:pointer; width:100px;' >
                            Edit
                        </a>
                        &nbsp;
                    <a class='btn btn-danger text-white' style='cursor:pointer; width:70px;'
                    Onclick=Delete('/books/Delete?id='+${data})>
                        Delete
                    </a>
                        </div>`;
                }, "Width": "40%"

            }
        ],
        "language": {
            "emptyTable": "no data found."
        },
        "width": "100%"
    });
}


function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover",
        icon: "warning",
        buttons: true,
        dangerMode: true

    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message, "Success");
                        //dataTable.ajax.reload();
                        location.reload();
                    }
                    else {
                        toastr.error(data.message,"Error!");
                    }
                }
            });

        }
    });
}

