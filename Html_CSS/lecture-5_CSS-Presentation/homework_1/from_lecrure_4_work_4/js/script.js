$(function (){  
$(".btn1").hover( 
function() { 
    $(this).children('div:nth-child(1)').addClass("btn1_left_hover");
    $(this).children('div:nth-child(2)').addClass("btn1_back_hover");
    $(this).children('div:nth-child(3)').addClass("btn1_right_hover");
}, function() {
    $(this).children('div:nth-child(1)').removeClass("btn1_left_hover");
    $(this).children('div:nth-child(2)').removeClass("btn1_back_hover");
    $(this).children('div:nth-child(3)').removeClass("btn1_right_hover");
});
$(".btn2").hover( 
function() { 
    $(this).children('div:nth-child(1)').addClass("btn2_left_hover");
    $(this).children('div:nth-child(2)').addClass("btn2_back_hover");
    $(this).children('div:nth-child(3)').addClass("btn2_right_hover");
}, function() {
    $(this).children('div:nth-child(1)').removeClass("btn2_left_hover");
    $(this).children('div:nth-child(2)').removeClass("btn2_back_hover");
    $(this).children('div:nth-child(3)').removeClass("btn2_right_hover");
});
});