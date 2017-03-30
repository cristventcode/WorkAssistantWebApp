
$(document).ready(function () {

    var myVar = {
        pulledSelectionList: document.getElementById("pulled-selection-holder"),
        pathUrl: "/api/productcontent",
        quickAddButton: $("#quick-add-btn"),
        addedProductHolder: $("#added-product-holder"),
    };

    // Get data with AJAX
    $.getJSON(myVar.pathUrl, function (results) {
        console.log(results);
        for (var item in results) {
            var element = document.createElement("option");
            element.innerText = results[item];
            myVar.pulledSelectionList.append(element);
        };
    });

    $(myVar.quickAddButton).click(function () {
        myVar.addedProductHolder[0].innerHTML += myVar.pulledSelectionList.value + "<br>";

    });


});

