$(document).ready(function () {
    //validation library on jQuery
    $("#ChangePwd").validate({
        errorClass: 'error',
        rules: {
            oldPassword: {
                required: true
                //regexPassword: true
            },
            newPassword: {
                required: true,
                minlength: 4,
                maxlength: 20
                //regexPassword: true
            },
            re_newPassword: {
                required: true,
                minlength: 4,
                maxlength: 20
                //regexPassword: true
            },
        },
        messages: {
            oldPassword: {
                required: "Old Password can't be blank.",
                //regexPassword: "Password must be between 4 to 20 characters.",
            },
            newPassword: {
                required: "New password can't be blank.",
                minlength: "Password must be between 4 to 20 characters.",
                maxlength: "Password must be between 4 to 20 characters.",
                //regexPassword: "Password must be between 4 to 20 characters.",
            },
            re_newPassword: {
                required: "Password confirm can't be blank.",
                minlength: "Password must be between 4 to 20 characters.",
                maxlength: "Password must be between 4 to 20 characters.",
                //regexPassword: "Password must be between 4 to 20 characters.",
            }
        }
    });
});