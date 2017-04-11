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

var timeStampBtn = $(".time-input-btn"),
    toOzGalBtn = $("#to-ozGal"),
    toLbBtn = $("#to-lb"),
    typeBtn = $(".type-btn"),
    typeSelectHolder = $("#Size");


$(timeStampBtn).click(function () {
    var currentTime = new Date();
    this.previousElementSibling.value = currentTime.toLocaleTimeString().replace(/(.*)\D\d+/, '$1');;
})



$(document).ready(function () {
    var editSizeSelect = document.getElementById("Size"),
        productName = document.getElementById("Name"),
        productCategory;

    var searchPath = "/api/productContent/getProductInfo?productName=" + productName.value;

    $.getJSON(searchPath, function (searchResult) {
        productCategory = searchResult[0].Category;
        renderContent();
    });

    function renderContent() {
        var sizeList = sizeType.getList(productCategory);
        for (var size in sizeList) {
            var element = document.createElement("option");
            element.innerText = sizeList[size];
            editSizeSelect.appendChild(element);
        }
    }
})