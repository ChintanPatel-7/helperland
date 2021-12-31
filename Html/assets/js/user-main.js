$(document).ready(function () {
    $('#tbl-upcoming-service').DataTable({
        paging: false,
        bFilter: false,
        ordering: true,
        searching: false,
        info: false,
        "columnDefs": [
            { "orderable": false, "targets": 4 }
        ],
        responsive: true
    });

    $('#tbl-service-history').DataTable({
        paging: true,
        "pagingType": "full_numbers",
        // bFilter: false,
        ordering: true,
        searching: false,
        info: true,
        "columnDefs": [
            { "orderable": false, "targets": 4 }
        ],
        "oLanguage": {
            "sInfo": "Total Records: _TOTAL_"
        },
        "dom": '<"top">rt<"bottom"lip><"clear">',
        responsive: true
    });

});