$(document).ready(function () {
    $("#submit").click(function () {
        console.log('ABCD');
        $.ajax({
            type: "POST",
            url: "/default/NumbertoWord",
            data: JSON.stringify({ name: $("#name").val(), number: $("#number").val() }),
            contentType: "application/json; charset=utf-8",
            dataType: "text",
            success: function (Result) {
                $("#resultdiv").html(Result);
            },
            failure: function(Result)
            {
                console.log(Result);
            }
        });
    });
});


//var current = null;
//document.querySelector('#email').addEventListener('focus', function (e) {
//    if (current) current.pause();
//    current = anime({
//        targets: 'path',
//        strokeDashoffset: {
//            value: 0,
//            duration: 700,
//            easing: 'easeOutQuart'
//        },
//        strokeDasharray: {
//            value: '240 1386',
//            duration: 700,
//            easing: 'easeOutQuart'
//        }
//    });
//});
//document.querySelector('#password').addEventListener('focus', function (e) {
//    if (current) current.pause();
//    current = anime({
//        targets: 'path',
//        strokeDashoffset: {
//            value: -336,
//            duration: 700,
//            easing: 'easeOutQuart'
//        },
//        strokeDasharray: {
//            value: '240 1386',
//            duration: 700,
//            easing: 'easeOutQuart'
//        }
//    });
//});
//document.querySelector('#submit').addEventListener('focus', function (e) {
//    if (current) current.pause();
//    current = anime({
//        targets: 'path',
//        strokeDashoffset: {
//            value: -730,
//            duration: 700,
//            easing: 'easeOutQuart'
//        },
//        strokeDasharray: {
//            value: '530 1386',
//            duration: 700,
//            easing: 'easeOutQuart'
//        }
//    });
//});