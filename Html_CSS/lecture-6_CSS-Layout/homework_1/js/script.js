$(function() {
$('ul.left_nav li').mouseover( function () {

     index = $('ul.left_nav li').index(this)+1;
	 $('ul.left_nav li').removeClass('left_nav_active');
	 $('ul.left_nav li a').removeClass('active_a');
     $('.news.active').removeClass('active');
     $('#news'+index).addClass('active');
	 $($(this)).addClass('left_nav_active');
	 $($(this).find('a')).addClass('active_a');
	 
});
});
