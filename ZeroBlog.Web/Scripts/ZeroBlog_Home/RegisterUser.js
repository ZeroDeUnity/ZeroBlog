jQuery(document).ready(function ($) {
    $(".scroll").click(function (event) {
        event.preventDefault();
        $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
    });

    $().UItoTop({ easingType: 'easeOutQuart' });

    new WOW().init();
});

var RegisterState = "0";//表示可以注册
var LoginState = "0";//表示可以注册

function validateLoginUserName() {
    var UserName = $("#LoginUserName").val();
    if (UserName.length > 0) {
        $("#LoginUserNameTitle").text("用户名");
        $("#LoginUserNameTitle").css("color", "#aaa");
        LoginState = "0";
    } else {
        $("#LoginUserNameTitle").text("用户名(必填)");
        $("#LoginUserNameTitle").css("color", "red");
        LoginState = "1";
    }
}

function validateLoginPwd() {
    var Pwd = $("#LoginPwd").val();
    if (Pwd.length > 0) {
        $("#LoginPwdTitle").text("用户密码");
        $("#LoginPwdTitle").css("color", "#aaa");
        LoginState = "0";
    } else {
        $("#LoginPwdTitle").text("用户密码(必填)");
        $("#LoginPwdTitle").css("color", "red");
        LoginState = "1";
    }
}

function validateUserName() {
    var UserName = $("#UserName").val();
    if (UserName.length>0) {
        $.ajax({
            type: "POST",//请求方式
            data: "UserName=" + UserName,//ajax请求传的数据
            //url: '@Url.Action("AjaxGetStuState")',//使用@Url.Action找出当前控制器内的ajax方法
            url: '/ZeroBlog_Home/ValidateUser',//使用@Url.Action找出当前控制器内的ajax方法
            success: function (res) {//返回参数,对其进行处理
                if (res == "1") {
                    $("#UserNameTitle").text("用户名已存在!");
                    $("#UserNameTitle").css("color", "red");
                    RegisterState = "1";
                } else {
                    $("#UserNameTitle").text("用户名(必填)");
                    $("#UserNameTitle").css("color", "#aaa");
                }
            }
        });
    } else {
        $("#UserNameTitle").text("用户名(必填)");
        $("#UserNameTitle").css("color", "#aaa");
        RegisterState = "1";
    }

}


function validatePwd() {
    var Pwd = $("#Pwd").val();
    if (Pwd.length > 0) {
        $("#PwdTitle").text("密码(必填)");
        $("#PwdTitle").css("color", "#aaa");
        RegisterState = "0";
    } else {
        $("#PwdTitle").text("密码(必填)");
        $("#PwdTitle").css("color", "red");
        RegisterState = "1";
    }
}

function validatePwd2() {
    var Pwd = $("#Pwd").val();
    var AgainPwd = $("#AgainPwd").val();
    if (AgainPwd.length > 0) {
        $("#AgainPwdTitle").text("确认密码(必填)");
        $("#AgainPwdTitle").css("color", "#aaa");

        if (Pwd == AgainPwd) {
            $("#AgainPwdTitle").text("确认密码(必填)");
            $("#AgainPwdTitle").css("color", "#aaa");
            RegisterState = "0";
        } else {
            $("#AgainPwdTitle").text("2次密码不一致!");
            $("#AgainPwdTitle").css("color", "red");
            RegisterState = "1";
        }

    } else {
        $("#AgainPwdTitle").text("确认密码(必填)");
        $("#AgainPwdTitle").css("color", "red");
        RegisterState = "1";
    }
}

function validateMailbox() {

    var email = $("#Mailbox").val();
    if (email.length>0) {
        var reg = /^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+((\.[a-zA-Z0-9_-]{2,3}){1,2})$/;
        if (!reg.test(email)) {
            $("#MailboxTitle").text("邮箱格式错误!");
            $("#MailboxTitle").css("color", "red");
            RegisterState = "1";
        } else {
            $("#MailboxTitle").text("邮箱");
            $("#MailboxTitle").css("color", "#aaa");
            RegisterState = "0";
        }
    } else {
        $("#MailboxTitle").text("邮箱");
        $("#MailboxTitle").css("color", "#aaa");
        RegisterState = "0";
    }

}

function Register() {
    var UserName = $("#UserName").val();
    var Pwd = $("#Pwd").val();
    var Email = $("#Mailbox").val();
    if (RegisterState=="1") {
        alert("请检查数据正确性");
        return;
    }
    $.ajax({
        type: "POST",//请求方式
        data: "User_Name=" + UserName + "&User_Pwd=" + Pwd + "&User_Sex=true" + "&MailBox=" + Email,//ajax请求传的数据
        //url: '@Url.Action("AjaxGetStuState")',//使用@Url.Action找出当前控制器内的ajax方法
        url: '/ZeroBlog_Home/RegisterUserFF',//使用@Url.Action找出当前控制器内的ajax方法
        success: function (res) {//返回参数,对其进行处理
            if (res == "注册成功") {
                //alert("注册成功!请登录!");

                location.href = '/ZeroBlog_Home/Index';//这是MVC控制器里视图的跳转
            } else {
                alert("注册失败!暂时无法注册");
                
            }
        }
    });
}

function Login() {
    var UserName = $("#LoginUserName").val();
    var Pwd = $("#LoginPwd").val();
    if (LoginState == "1") {
        alert("请检查数据正确性");
        return;
    }
    $.ajax({
        type: "POST",//请求方式
        data: "User_Name=" + UserName + "&User_Pwd=" + Pwd,//ajax请求传的数据
        //url: '@Url.Action("AjaxGetStuState")',//使用@Url.Action找出当前控制器内的ajax方法
        url: '/ZeroBlog_Home/Login',//使用@Url.Action找出当前控制器内的ajax方法
        success: function (res) {//返回参数,对其进行处理
            if (res == "成功") {
                //alert("注册成功!请登录!");

                location.href = '/ZeroBlog_Home/Index';//这是MVC控制器里视图的跳转
            } else {
                alert("登录失败!请联系博主:1506065358");

            }
        }
    });
}