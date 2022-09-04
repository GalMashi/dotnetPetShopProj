

function filterText() {
    var rex = new RegExp($(".filterText").val().toLowerCase());
    if (rex == "/all/") { clearFilter() } else {
        $(".content").hide();
        $(".content").filter(function () {
            return rex.test($(this).text().toLowerCase());
        }).show();
    }
}

function clearFilter() {
    $(".filterText").val("");
    $(".content").show();
}
