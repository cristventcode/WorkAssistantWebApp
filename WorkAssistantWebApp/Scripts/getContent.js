
var allProducts,
    quickAddButton = $("#quick-add-btn"),
    workdayId = $("#workday-id"),
    testButton = $(".addTask"),
    pulledSelectionList = document.getElementById("pulled-selection-holder"),
    inputName = document.getElementById("Name"),
    inputManufactLot = document.getElementById("ManufactLot"),
    inputOurLot = document.getElementById("OurLot"),
    productObject;


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
    var productSelected = pulledSelectionList.value,
        stockDate = document.getElementById("stock-date");

    for (var item in allProducts) {
        if (productSelected === allProducts[item].Name) {
            productObject = allProducts[item];
        }
    };

    var date = new Date();

    var inputName = document.getElementById("Name"),
        inputManufactlot = document.getElementById("ManufactLot"),
        inputOurlot = document.getElementById("OurLot");

    inputName.value = productObject.Name;
    inputManufactlot.value = productObject.MlnCurrent;
    inputOurlot.value = productObject.OurLot + "-" + stockDate.innerText + "C";
});










