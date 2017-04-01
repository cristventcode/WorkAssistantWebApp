
$(document).ready(function () {
    // Get data with AJAX
    var pathUrl = "/api/productcontent";
    $.getJSON(pathUrl, function (results) {
        for (var item in results) {
            var element = document.createElement("option");
            element.innerText = results[item];
            pulledSelectionList.append(element);
        };
    });
});

var addPlusBtnEvent = function addPlusBtnEvent() {
    var plusBtn = document.getElementsByClassName("addTask");
    for (var x = 0; x < plusBtn.length; x++) {
        plusBtn[x].addEventListener("click", plusBtnEvent);
    }
};

var quickAddButton = $("#quick-add-btn"),
    workdayId = $("#workday-id"),
    testButton = $(".addTask"),
    pendingList = $("#pending-list"),
    resetPendingList = $("#reset-pending-list"),
    pulledSelectionList = document.getElementById("pulled-selection-holder"),
    inputTemplate = '<div class="input-group-addon addTask">+</div>' + '<input type="text" class="form-control" id="inlineFormInputGroup" placeholder="Username">'

$(quickAddButton).click(function () {
    var newListItem = document.createElement("div");
    newListItem.classList.add("input-group");
    //newListItem.classList.add("new-item-holder");
    newListItem.innerHTML = inputTemplate.replace(/"~~"/g, "new");
    newListItem.childNodes[1].value = pulledSelectionList.value;
    pendingList.append(newListItem);
    $("#pending-holder").removeClass("hidden");

    addPlusBtnEvent();
});

$(resetPendingList).click(function () {
    pendingList.empty();
    $("#pending-holder").addClass("hidden");
});


$(testButton).click(function () {
    alert("ok");
});

var plusBtnEvent = function plusBtnEvent() {
    var searchName = this.nextSibling.value;
    var pathUrl = "/api/productcontent/getProductInfo?productName=" + searchName;

    $.getJSON(pathUrl, function (responseData) {
        console.log(responseData);
    });
};


