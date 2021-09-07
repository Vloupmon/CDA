"use strict"
var tableDataImport;
var table;
var tableDetailsData;
var tableDetails;

$("#xmlhttp").click(getXMLHttpRequest);
$("#jquery").on("click", jQueryRequest);
$("#fetch").on("click", fetchRequest);
$("#table_id").on("click", "button", function () {
    var parentRowData = table.row($(this).parent()).data();
    $('#exampleModal').modal('show');
    getDetails(parentRowData.id);
})
$("#closemodal").on("click",function(){
    tableDetails.clear().destroy();
})
$("#table_id").css("width","80%")
function getXMLHttpRequest() {
    var xmlHttpR = new XMLHttpRequest();
    xmlHttpR.open("GET", "https://jsonplaceholder.typicode.com/users");
    xmlHttpR.onreadystatechange = function () {
        if (xmlHttpR.readyState == 4 && xmlHttpR.status == 200) {
            console.log(xmlHttpR.responseText);
            tableDataImport = JSON.parse(xmlHttpR.responseText);
            createTable();
        }
    }
    xmlHttpR.send(null);
}
function jQueryRequest() {
    $.ajax({
        method: "GET",
        url: "https://jsonplaceholder.typicode.com/users",
    }).done(function (data) {
        console.log(data);
        tableDataImport = data;
        createTable();
    });
}
function fetchRequest() {
    fetch("https://jsonplaceholder.typicode.com/users")
        .then(function (response) {
            if (response.ok) {
                return response.json();
            }
        })
        .then(function (data) {
            tableDataImport = data;
            createTable();
        })
}
function createTable() {
    console.log(tableDataImport);
    table = $('#table_id').DataTable({
        data: tableDataImport,
        "columns": [
            { data: "id" },
            { data: "name" },
            { data: "username" }
        ],
        "columnDefs": [{
            "targets": 3,
            "data": null,
            "defaultContent": "<button type='button' class='btn btn-primary' data-toggle='modal' data-target='#exampleModal'>Details</button>"
        }]
    });
}
function getDetails(idInput) {
    $.ajax({
        method: "GET",
        url: `https://jsonplaceholder.typicode.com/posts?userId=${idInput}`,
    }).done(function (data) {
        console.log(data);
        tableDetailsData = data;
        createTableDetails();
    });
}
function createTableDetails(){
    tableDetails = $('#table_details').DataTable({
        data: tableDetailsData,
        "columns": [
            { data: "title" },
            { data: "body" }
        ],
        "autoWidth": false
    });
}
function createTable2() {
    $('#table_id').DataTable({
        "ajax": {
            url: "https://jsonplaceholder.typicode.com/posts?userid=1",
            "dataSrc": ""
        },
        "columns": [
            { data: "userId" },
            { data: "id" },
            { data: "title" },
            { data: "body" }
        ]
    });
}

