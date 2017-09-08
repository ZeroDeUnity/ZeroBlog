jQuery(document).ready(function ($) {
    $(".scroll").click(function (event) {
        event.preventDefault();
        $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
    });

    //设备宽度
    var s = window.screen;
    var width = q.width = s.width;
    var height = q.height;
    var yPositions = Array(300).join(0).split('');
    var ctx = q.getContext('2d');
    var draw = function () {
        ctx.fillStyle = 'rgba(0,0,0,.05)';
        ctx.fillRect(0, 0, width, height);
        ctx.fillStyle = 'green';/*代码颜色*/
        ctx.font = '10pt Georgia';
        yPositions.map(function (y, index) {
            text = String.fromCharCode(1e2 + Math.random() * 330);
            x = (index * 10) + 10;
            q.getContext('2d').fillText(text, x, y);
            if (y > Math.random() * 1e4) {
                yPositions[index] = 0;
            } else {
                yPositions[index] = y + 10;
            }
        });
    };
    RunMatrix();
    function RunMatrix() {
        Game_Interval = setInterval(draw, 30);
        $('body').oneTime('3s', function () {
            clearInterval(Game_Interval);
            //$("#daimadiv").css("display", "none");
            $("#q").css("height", "0");
            $("#daimadiv").css("height", "0");
        });

    }

    $().UItoTop({ easingType: 'easeOutQuart' });//在顶部时隐藏回到顶部导航栏

    new WOW().init();

});