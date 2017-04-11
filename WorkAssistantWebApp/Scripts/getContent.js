
var allProducts,
    quickAddButton = $("#quick-add-btn"),
    workdayId = $("#workday-id"),
    testButton = $(".addTask"),
    typeSelectHolder = $("#Size"),
    pulledSelectionList = document.getElementById("pulled-selection-holder"),
    inputName = document.getElementById("Name"),
    inputManufactLot = document.getElementById("ManufactLot"),
    inputOurLot = document.getElementById("OurLot"),
    productObject;


var sizeType = {
    'Ingredient': ['1/2 Lb', '1 Lb', '1.5 Lb', '2 Lb', '2.5 Lb', '3 Lb', '4 Lb', '5 Lb', '6 Lb', '7 Lb', '8 Lb', '12 Lb', '16 Lb', '20 Lb'],
    'Butter': ['1/2 Lb', '3 Lb', '4 Lb'],
    'Vegetable Oil': ['1 Oz', '4 Oz', '16 Oz', '1/2 Gal', '1 Gal', '8 Lb'],
    'Color': ['1/2 Oz', '1 Oz', '4 Oz', '1 Lb'],
    'Essential Oil': ['.06 Oz', '1/2 Oz', '1 Oz', '3.4 Oz', '4 Oz', '16 Oz', '32 Oz'],
    'Fragrant Oil': ['1/2 Oz', '3.4 Oz', '16 Oz', '32 Oz'],
    getList: function getList(category) {
        return (sizeType[category]);
    }

}

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

    displayOptions(productObject.Category);
    inputName.value = productObject.Name;
    inputManufactlot.value = productObject.MlnCurrent;
    inputOurlot.value = productObject.OurLot + "-" + stockDate.innerText + "C";
});


function displayOptions(category) {
    var sizeList = sizeType.getList(category);

    typeSelectHolder.empty();
    for (var size in sizeList) {
        var element = document.createElement("option");
        element.innerText = sizeList[size];
        typeSelectHolder.append(element);
    }
}












