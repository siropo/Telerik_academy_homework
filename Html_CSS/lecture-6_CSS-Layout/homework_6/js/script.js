$(function() {
		$("a.view").hover(function(event) {
			var href = $(this).attr("href");
			$("<img id='bigImage' src='" + href + "' alt='bigImage' \>'")
			.css("top", event.pageY + 5)
			.css("left", event.pageX + 5)
			.appendTo(".info");
		} , function() {
			$("#bigImage").remove();
		});
		$("a.view").mousemove(function(event) {
			$("#bigImage").css("top", event.pageY + 5).css("left", event.pageX + 5);
		});
	});