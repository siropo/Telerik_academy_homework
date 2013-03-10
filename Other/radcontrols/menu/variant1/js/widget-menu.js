function Menu(menuType, levels) {
	this.menuType = menuType;
	this.levels = levels;

	this.checkWindowWidth();
	this.menuId = document.getElementById("widget-menu");
	this.menuId.className = "widget-" + this.menuType;

	this.checkUrl();

	if (this.levels > 0) {
		this.attachHeandler();
	}
}

Menu.prototype.attachHeandler = function() {
	
    $('#widget-menu > li > .drop-down').click(function () { 
    		
    	if ($('+ .submenu', this).hasClass('selected')) {
    		$("#widget-menu a").parent().removeClass("active");
    		$('.drop-down + .submenu').removeClass('selected');
    	} else {
    		$("#widget-menu a").parent().removeClass("active");
    		$(this).parent().addClass("active");
    		$('.drop-down + .submenu').removeClass('selected');
    		$('+ .submenu', this).addClass("selected");
    	}
	    
    });

    $("html, body").click(function (e) { 
		var target = $(e.target);
		if (target.hasClass('drop-down') || target.hasClass('submenu')) {
	        return false;
	    }
	    $("#widget-menu a").parent().removeClass("active");
	    $('.submenu').removeClass('selected');
	}); 

	if (this.levels > 1) {
	    $("#widget-menu > li .submenu .drop-down").click(function () { 
			if ($('+ .submenu', this).hasClass('selected')) {
	    		$('.drop-down + .submenu .submenu').removeClass('selected');
	    	} else {
	    		$('.drop-down + .submenu .submenu').removeClass('selected');
	    		$('+ .submenu', this).addClass("selected");
	    	}
		});
	}
	
}

Menu.prototype.checkUrl = function() {
	$("#widget-menu > li > a[href$='#']").addClass("drop-down arrow-down");
	$("#widget-menu > li li a[href$='#']").addClass("drop-down arrow-right");
	$("#widget-menu > li > ul").addClass("submenu level1");
	$("#widget-menu li li > ul").addClass("submenu level2");
}

Menu.prototype.checkWindowWidth = function() {
	windowWidth = $(window).width();
	if (windowWidth < 640) {
		this.menuType = "vertical";
	}
}