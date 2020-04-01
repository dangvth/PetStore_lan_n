$(document).ready(function () {
    //validation library on jQuery
    $("#ChangePwd").validate({
        errorClass: 'error',
        rules: {
            fullName: {
                required: true
            },
            address: {
                required: true
            },
            email: {
                required: true,
                email: true
                //regexEmail: true
            },
            phone: {
                required: true,
                minlength: 10,
                maxlength: 10
                //regexPhone: true
            },
            ac_userName: {
                required: true
            },
            ac_pwd: {
                required: true,
                minlength: 4,
                maxlength: 16
                //regexPassword: true
            },
        },
        messages: {
            fullName: {
                required: "Full name can't be blank."
            },
            address: {
                required: "Address can't be blank.",
            },
            email: {
                required: "Email can't be blank.",
                email: "Email format is not valid",
                //regexEmail: "Email format is not valid",
            },
            phone: {
                required: "Phone can't be blank.",
                minlength: "Phone number must be 0 digits.",
                maxlength: "Phone number must be 0 digits.",
                //regexPhone: "Phone number must be 0 digits.",
            },
            ac_userName: {
                required: "Username can't be blank.",
            },
            ac_pwd: {
                required: "Password can't be blank.",
                minlength: "Password must be between 4 to 20 characters.",
                maxlength: "Password must be between 4 to 20 characters.",
                //regexPassword: "Password must be between 4 to 20 characters.",
            }
        }
    });
});