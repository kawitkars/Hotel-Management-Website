// Write your JavaScript code.

//Pagination Script

//$(".next").click(function () {
//    var target = $(".nav-tabs li.active");
//    var sibbling;
//    if ($(this).text() === "Next") {
//        sibbling = target.next();
//    } else {
//        sibbling = target.prev();
//    }
//    if (sibbling.is("li")) {
//        sibbling.children("a").tab("show");
//    }
//});

//$(".previous").click(function () {
//    var target = $(".nav-tabs li.active");
//    var sibbling;
//    if ($(this).text() === "Previous") {
//        sibbling = target.prev();
//    } else {
//        sibbling = target.next();
//    }
//    if (sibbling.is("li")) {
//        sibbling.children("a").tab("show");
//    }
//});



//$("#PaymentBtn").click(function () {
//    var target = $(".nav-tabs li.active");
//    var sibbling;
//    if ($(this).val() === "Submit") {
//        sibbling = target.next();
//    } 
//    if (sibbling.is("li")) {
//        sibbling.children("a").tab("show");
//    }
//    });

$(document).ready(function () {
    $('a[data-toggle="tab"]').on('show.bs.tab', function (e) {
        localStorage.setItem('activeTab', $(e.target).attr('href'));
    });
    var activeTab = localStorage.getItem('activeTab');
    if (activeTab) {
        $('#booking-tabs a[href="' + activeTab + '"]').tab('show');
    }
});



$(function () {

    $('#next1').click(function (e) {
        e.preventDefault();
        $("#saveDateForm").submit();
        $('#booking-tabs a[href="#booking-choose-room"]').tab('show');
        $('#saveDateForm input').attr('disabled', 'disabled');
    });

    $('#next2').click(function (e) {
        e.preventDefault();
        $("#saveRoomForm").submit();
        $('#booking-tabs a[href="#booking-reservation"]').tab('show');
        $('#saveRoomForm input').attr('disabled', 'disabled');
    });

    $('#next3').click(function (e) {
        e.preventDefault();
        $("#submitCustomerData").submit();
        $('#booking-tabs a[href="#booking-confirmation"]').tab('show');
        $('#submitCustomerData input').attr('disabled', 'disabled');
    });

});

    $("#makeReservationNavTab").click(function () {
        //Remove tha active tab status key from localStorage
        localStorage.removeItem('activeTab');
}); 

    $('.datepicker').datepicker();

//$('#saveDateBtn').click(function () {
//    $("#saveForm").submit();
//});