
var allProducts,
    quickAddButton = $("#quick-add-btn"),
    workdayId = $("#workday-id"),
    testButton = $(".addTask"),
    pulledSelectionList = document.getElementById("pulled-selection-holder"),
    inputName = document.getElementById("Name"),
    inputManufactLot = document.getElementById("ManufactLot"),
    inputOurLot = document.getElementById("OurLot");

$(document).ready(function () {
    // Get data with AJAX
    var pathUrl = "/api/productcontent";
    $.getJSON(pathUrl, function (results) {
        allProducts = results;
        for (var item in results) {
            var element = document.createElement("option");
            element.innerText = results[item].Name;
            pulledSelectionList.append(element);
        };
    });
});

$(quickAddButton).click(function () {
    var productSelected = pulledSelectionList.value;

    var productObject;

    for (var item in allProducts) {
        if (allProducts[item].Name === productSelected) {
            productObject = allProducts[item];
        }
    };


    var date = new Date();
    inputName.value = productObject.Name;
    inputManufactLot.value = productObject.ManufactLot;
    inputOurLot.value = productObject.OurLot + "-" + (date.getMonth() + 1) + date.getDate() + (date.getYear() - 100) + "C";
});








