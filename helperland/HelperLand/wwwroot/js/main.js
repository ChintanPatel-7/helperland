$(document).ready(function () {
    $(window).scroll(function () {
        if (this.scrollY > 20) {
            $('.homePage.navbar').addClass("navbar-bg-color");
            $('.register-now-page.navbar').addClass("navbar-bg-color");
        }
        else {
            $('.homePage.navbar').removeClass("navbar-bg-color");
            $('.register-now-page.navbar').removeClass("navbar-bg-color");
        }
        if (this.scrollY > 500) {
            $('.scroll-up-btn').addClass("show");
        } else {
            $('.scroll-up-btn').removeClass("show");
        }
    })

    //collapse(hide navbar) when scrolling
    $(document).ready(function () {
        $(window).scroll(function () {

            $(".navbar .navbar-collapse").removeClass("show");
            $('.backblack').removeClass("open");

        });
    });

    //black backgroung on open side navbar
    $('.navbar-toggler').click(function () {
        $('.backblack').addClass("open");
    });
    $('.backblack').click(function () {
        $(".navbar .navbar-collapse").removeClass("show");
        $('.backblack').removeClass("open");
    });

    //prevent ouside click of model
    $('#loginModal').modal({
        backdrop: 'static',
        keyboard: false
    });

    // top Arrow
    $('.top-arrow').click(function () {
        $('html').animate({ scrollTop: 0 })
    });

    //$('#tbl-upcoming-service').DataTable({
    //    paging: false,
    //    bFilter: false,
    //    ordering: true,
    //    searching: false,
    //    info: false,
    //    "columnDefs": [
    //        { "orderable": false, "targets": 4 }
    //    ],
    //    responsive: true,
    //    "order": []
    //});

    //$('#tbl-service-history').DataTable({
    //    paging: true,
    //    "pagingType": "full_numbers",
    //    // bFilter: false,
    //    ordering: true,
    //    searching: false,
    //    info: true,
    //    "columnDefs": [
    //        { "orderable": false, "targets": 4 }
    //    ],
    //    "oLanguage": {
    //        "sInfo": "Total Records: _TOTAL_"
    //    },
    //    "dom": '<"top">rt<"bottom"lip><"clear">',
    //    responsive: true,
    //    "order": []
    //});

})