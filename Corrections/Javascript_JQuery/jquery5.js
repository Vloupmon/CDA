$(document).ready(function () {

    $("p").click(function (event) {
        $("#trace").append(event.type + "  sur " + event.target + "\n");

    });

    $("*").mouseleave(function (event) {
        $("#trace").append(event.type + " depuis " + event.relatedTarget + "\n");

    });

    $("*").mouseenter(function (event) {
        $("#trace").append(event.type + " dans " + event.relatedTarget + "\n");

    });
    $("*").mousemove(function (event) {

        $("#trace").append(" move x= " + event.pageX + " y= " + event.pageY + "\n");
    });

    $("*").mousedown(function (event) {

        $("#trace").append("type : " + event.type + " x= " + event.pageX + " y= " + event.pageY + "\n");

    });

    $("*").keypress(function (event) {
        $("#trace").append("type : " + event.type + " touche : " + event.which + "\n");

    });


    $("*").keyup(function (event) {
        $("#trace").append("type : " + event.type + " touche : " + event.which + "\n");

    });
    $("*").mouseup(function (event) {

        $("#trace").append("type : " + event.type + " x= " + event.pageX + " y= " + event.pageY + "\n");

    })
});