$(document).ready(function () {

    // this will get the full URL at the address bar
    var url = window.location.href;
    // hightlight active link
    $("#navLinks li a").each(function () {
        // checks if its the same on the address bar
        if (url == (this.href)) {
            $(this).addClass("active");
        }
    });

    $(window).scroll(function () {
        if (this.scrollY > 20) {
            $('.transparentNavbar.navbar').addClass("navbar-bg-color");
        }
        else {
            $('.transparentNavbar.navbar').removeClass("navbar-bg-color");
        }
        if (this.scrollY > 500) {
            $('.scroll-up-btn').addClass("show");
        } else {
            $('.scroll-up-btn').removeClass("show");
        }
    })

    //collapse(hide navbar) when scrolling
    $(window).scroll(function () {

        $(".navbar .navbar-collapse").removeClass("show");
        $('.backblack').removeClass("open");

    });

    //black backgroung on open side navbar
    $('.navbar-toggler').click(function () {
        $('.backblack').addClass("open");
    });
    $('.backblack').click(function () {
        $(".navbar .navbar-collapse").removeClass("show");
        $('.backblack').removeClass("open");
    });

    //on model open   close sidebar(navbar) for smaller devices
    $(".modal").on('show.bs.modal', function () {
        $(".navbar .navbar-collapse").removeClass("show");
        $('.backblack').removeClass("open");
    });

    // top Arrow
    $('.top-arrow').click(function () {
        $('html').animate({ scrollTop: 0 })
    });

    //Attachment name in input countect us
    $('#inputAttachment').change(function (e) {
        var fileName = e.target.files[0].name;
        document.getElementById("lblAttachmentName").innerHTML = fileName;
    });
    //on click of input type file --> label is set to null/empty...
    $('#inputAttachment').click(function () {
        document.getElementById("lblAttachmentName").innerHTML = "";
    });

})