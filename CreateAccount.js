function userValid() {
    debugger;
    var UserName = document.getElementById("txtUserName").value;
    var Password = document.getElementById("txtPassword").value;
    var Mobile = document.getElementById("txtMobile").value;
    var Email = document.getElementById("txtEmail").value;
    var ReEnterPassword = document.getElementById("txtconfirmpassword").value
    emailExp = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([com\co\.\in])+$/; // to validate email id    

    

    if (UserName == '') {
        alert("Please Enter User Name.");
        return false;
    }
    if (Email == '') {
        alert("Please Enter EmailId.");
        return false;
    }
    if (Email != '')
    {
        if (!Email.match(emailExp))
        {
            alert("Invalid Email Id.");
            return false;
        }
    }

    if (Password == '') {
        alert("Please Enter Password.");
        return false;
    }
    if (Mobile == '') {
        alert("Please Enter Mobile Number.");
        return false;
    }
    if (ReEnterPassword == '') {
        alert("Please Enter Confirmpassword.");
        return false;
    }
    if (Password != ReEnterPassword) {
        alert("Please Check Your Confirmpassword.");
        return false;
    }
    
    return true;
}
function userLogin() {
    var UserName = document.getElementById("txtUserName").value;
    var Password = document.getElementById("txtPassword").value;

    if (UserName == '') {
        alert("Please Enter UserName!.");
        return false;
    }
    if (Password == '') {
        alert("Please Enter Passwoed!.")
    }
    return false;
}