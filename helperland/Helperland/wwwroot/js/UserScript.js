$(document).ready(function () {

    //Customer --Service History Start

    $('#ServiceProviderRatingModel').modal({
        backdrop: 'static',
        keyboard: false
    });
    $('#ServiceProviderRatingModel').modal('show');

    $("#DisplayRatingServiceProviderInModel").val(3.3);

    $("#DisplayRatingServiceProviderInModel").rating({
        min: 0,
        max: 5,
        step: 0.1,
        size: "xs",
        stars: "5",
        showClear: false,
        showCaption: false,
        readonly: true
    });

    $(".rating-serviceProvider").rating({
        min: 0,
        max: 5,
        step: 0.5,
        size: "sm",
        stars: "5",
        showClear: false,
        showCaption: false
    });
});

//Customer -- Current Service Requests -- Dashboard Start

//Customer -- Current Service Requests -- Dashboard End