$(document).ready(function(){
    $("#tabs li").click(function() {
        $("#tabs li").removeClass('active');
        $(this).addClass("active");
        $(".box-tabs").hide();
        var selected_tab = $(this).find("a").attr("href");
        $(selected_tab).show();
        return false;
    });
	$(".slider-text p").each(function(i,e) {
    var paragraph = $(e).text();
    var maxlength = 200;
    var strlength = paragraph.length;
		if (strlength > maxlength) {
			var introduction    = paragraph.substr(0,maxlength); // cut string
			var search          = introduction.lastIndexOf(" "); // find position of last space (last word cannot be cut)
			introduction        = introduction.substr(0, search); // cut string until last space
			introduction        = introduction + "..."; // add ... in the end
			$(e).text(introduction);
		}
	});
	$(".title h1 a").each(function(i,e) {
    var paragraph = $(e).text();
    var maxlength = 32;
    var strlength = paragraph.length;
		if (strlength > maxlength) {
			var introduction    = paragraph.substr(0,maxlength); // cut string
			var search          = introduction.lastIndexOf(" "); // find position of last space (last word cannot be cut)
			introduction        = introduction.substr(0, search); // cut string until last space
			introduction        = introduction + "..."; // add ... in the end
			$(e).text(introduction);
		}
	});
});