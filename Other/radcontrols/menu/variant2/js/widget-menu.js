function Menu(menuType, menuItems, levels) {
	this.menuType = menuType;
	this.levels = levels;

	this.checkWindowWidth();
	this.draw(menuItems);

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

Menu.prototype.draw = function(menuItems) {

	var menuHTML = "";
	this.menuId = document.getElementById("widget-menu");
	this.menuId.className = "widget-" + this.menuType;

	for (var i = 0; i < menuItems.length; i++) {

		// Level 1 menu
		var menuL1 = menuItems[i];
		menuHTML += '<li>' + this.checkUrl(menuL1.url, menuL1.itemText, 1);
 
		if (menuL1.submenu) {
			menuHTML += '<ul class="submenu level1">';

			for (var j = 0; j < menuL1.submenu.length; j++) {

				// Level 2 menu
				var menuL2 = menuItems[i].submenu[j];
				menuHTML += '<li>' + this.checkUrl(menuL2.url, menuL2.itemText, 2);

				if (menuL2.submenu) {

					menuHTML += '<ul class="submenu level2">';

					for (var h = 0; h < menuL2.submenu.length; h++) {
						// Level 3 menu
						var menuL3 = menuItems[i].submenu[j].submenu[h];
						menuHTML += '<li>' + this.checkUrl(menuL3.url, menuL3.itemText);;

					}
					menuHTML += '</li></ul>';
				}
			}
			menuHTML += '</li></ul>';
		}
		menuHTML += '</li>';
	}
	this.menuId.innerHTML = menuHTML;
}

Menu.prototype.checkUrl = function(url, text, level) {
	if (url === '#' && level === 1) {
		return  '<a href="' + url + '" class="drop-down arrow-down">' + text + '</a>';
	} else if (url === '#' && level === 2) {
		return  '<a href="' + url + '" class="drop-down arrow-right">' + text + '</a>';
	} else {
		return '<a href="' + url + '">' + text + '</a>';
	}
}

Menu.prototype.checkWindowWidth = function() {
	windowWidth = $(window).width();
	if (windowWidth < 640) {
		this.menuType = "vertical";
	}
}