function logInCheck() {
    if (this.fname != "admin" && this.fpass != "1234") {
        return false
    } else {
        window.location.replace("/Admin/Home");
    }
}

function logInCheck2() {
    var rexUser = new RegExp($(".username").val());
    var rexPass = new RegExp($(".password").val());
    if (rexUser == (/"admin"/) && rexPass == (/"1234"/)) {
        window.location.replace("/Admin/Home");
    } else {
        return false;
    }
}