
var colours = new Array('#f00', '#f06', '#f0f', '#f6f', '#f39', '#f9c'); // colours of the hearts
var minisize = 16; // smallest size of hearts in pixels
var maxisize = 28; // biggest size of hearts in pixels
var hearts = 66; // maximum number of hearts on screen
var over_or_under = "over"; // set to "over" for hearts to always be on top, or "under" to allow them to float behind other objects

/*****************************
*JavaScript Love Heart Cursor*
*  (c)2013+ mf2fm web-design *
*   http://www.mf2fm.com/rv  *
*  DON'T EDIT BELOW THIS BOX *
*****************************/
var x = ox = 400;
var y = oy = 300;
var swide = 800;
var shigh = 600;
var sleft = sdown = 0;
var herz = new Array();
var herzx = new Array();
var herzy = new Array();
var herzs = new Array();
var kiss = false;

if (typeof ('addRVLoadEvent') != 'function') function addRVLoadEvent(funky) {
    var oldonload = window.onload;
    if (typeof (oldonload) != 'function') window.onload = funky;
    else window.onload = function () {
        if (oldonload) oldonload();
        funky();
    }
}

addRVLoadEvent(mwah);

function mwah() {
    if (document.getElementById) {
        var i, heart;
        for (i = 0; i < hearts; i++) {
            heart = createDiv("auto", "auto");
            heart.style.visibility = "hidden";
            heart.style.zIndex = (over_or_under == "over") ? "1001" : "0";
            heart.style.color = colours[i % colours.length];
            heart.style.pointerEvents = "none";
            if (navigator.appName == "Microsoft Internet Explorer") heart.style.filter = "alpha(opacity=75)";
            else heart.style.opacity = 0.75;
            heart.appendChild(document.createTextNode(String.fromCharCode(9829)));
            document.body.appendChild(heart);
            herz[i] = heart;
            herzy[i] = false;
        }
        set_scroll();
        set_width();
        herzle();
    }
}

function herzle() {
    var c;
    if (Math.abs(x - ox) > 1 || Math.abs(y - oy) > 1) {
        ox = x;
        oy = y;
        for (c = 0; c < hearts; c++) if (herzy[c] === false) {
            herz[c].firstChild.nodeValue = String.fromCharCode(9829);
            herz[c].style.left = (herzx[c] = x - minisize / 2) + "px";
            herz[c].style.top = (herzy[c] = y - minisize) + "px";
            herz[c].style.fontSize = minisize + "px";
            herz[c].style.fontWeight = 'normal';
            herz[c].style.visibility = 'visible';
            herzs[c] = minisize;
            break;
        }
    }
    for (c = 0; c < hearts; c++) if (herzy[c] !== false) blow_me_a_kiss(c);
    setTimeout("herzle()", 40);
}

document.onmousedown = pucker;
document.onmouseup = function () { clearTimeout(kiss); };

function pucker() {
    ox = -1;
    oy = -1;
    kiss = setTimeout('pucker()', 100);
}

function blow_me_a_kiss(i) {
    herzy[i] -= herzs[i] / minisize + i % 2;
    herzx[i] += (i % 5 - 2) / 5;
    if (herzy[i] < sdown - herzs[i] || herzx[i] < sleft - herzs[i] || herzx[i] > sleft + swide - herzs[i]) {
        herz[i].style.visibility = "hidden";
        herzy[i] = false;
    }
    else if (herzs[i] > minisize + 2 && Math.random() < .5 / hearts) break_my_heart(i);
    else {
        if (Math.random() < maxisize / herzy[i] && herzs[i] < maxisize) herz[i].style.fontSize = (++herzs[i]) + "px";
        herz[i].style.top = herzy[i] + "px";
        herz[i].style.left = herzx[i] + "px";
    }
}

function break_my_heart(i) {
    var t;
    herz[i].firstChild.nodeValue = String.fromCharCode(9676);
    herz[i].style.fontWeight = 'bold';
    herzy[i] = false;
    for (t = herzs[i]; t <= maxisize; t++) setTimeout('herz[' + i + '].style.fontSize="' + t + 'px"', 60 * (t - herzs[i]));
    setTimeout('herz[' + i + '].style.visibility="hidden";', 60 * (t - herzs[i]));
}

document.onmousemove = mouse;
function mouse(e) {
    if (e) {
        y = e.pageY;
        x = e.pageX;
    }
    else {
        set_scroll();
        y = event.y + sdown;
        x = event.x + sleft;
    }
}

window.onresize = set_width;
function set_width() {
    var sw_min = 999999;
    var sh_min = 999999;
    if (document.documentElement && document.documentElement.clientWidth) {
        if (document.documentElement.clientWidth > 0) sw_min = document.documentElement.clientWidth;
        if (document.documentElement.clientHeight > 0) sh_min = document.documentElement.clientHeight;
    }
    if (typeof (self.innerWidth) == 'number' && self.innerWidth) {
        if (self.innerWidth > 0 && self.innerWidth < sw_min) sw_min = self.innerWidth;
        if (self.innerHeight > 0 && self.innerHeight < sh_min) sh_min = self.innerHeight;
    }
    if (document.body.clientWidth) {
        if (document.body.clientWidth > 0 && document.body.clientWidth < sw_min) sw_min = document.body.clientWidth;
        if (document.body.clientHeight > 0 && document.body.clientHeight < sh_min) sh_min = document.body.clientHeight;
    }
    if (sw_min == 999999 || sh_min == 999999) {
        sw_min = 800;
        sh_min = 600;
    }
    swide = sw_min;
    shigh = sh_min;
}

window.onscroll = set_scroll;
function set_scroll() {
    if (typeof (self.pageYOffset) == 'number') {
        sdown = self.pageYOffset;
        sleft = self.pageXOffset;
    }
    else if (document.body && (document.body.scrollTop || document.body.scrollLeft)) {
        sdown = document.body.scrollTop;
        sleft = document.body.scrollLeft;
    }
    else if (document.documentElement && (document.documentElement.scrollTop || document.documentElement.scrollLeft)) {
        sleft = document.documentElement.scrollLeft;
        sdown = document.documentElement.scrollTop;
    }
    else {
        sdown = 0;
        sleft = 0;
    }
}

function createDiv(height, width) {
    var div = document.createElement("div");
    div.style.position = "absolute";
    div.style.height = height;
    div.style.width = width;
    div.style.overflow = "hidden";
    div.style.backgroundColor = "transparent";
    return (div);
}

window.onFocus = (id) => {
    var obj = document.getElementById(id);
    obj.select();
} 

/*
	Landed by HTML5 UP
	html5up.net | @ajlkn
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
*/

(function ($) {

	var $window = $(window),
		$body = $('body');

	// Breakpoints.
	breakpoints({
		xlarge: ['1281px', '1680px'],
		large: ['981px', '1280px'],
		medium: ['737px', '980px'],
		small: ['481px', '736px'],
		xsmall: [null, '480px']
	});

	// Play initial animations on page load.
	$window.on('load', function () {
		window.setTimeout(function () {
			$body.removeClass('is-preload');
		}, 100);
	});

	// Touch mode.
	if (browser.mobile)
		$body.addClass('is-touch');

	// Scrolly links.
	$('.scrolly').scrolly({
		speed: 2000
	});

	// Dropdowns.
	$('#nav > ul').dropotron({
		alignment: 'right',
		hideDelay: 350
	});

	// Nav.

	//// Title Bar.
	//$(
	//	'<div id="titleBar">' +
	//	'<a href="#navPanel" class="toggle"></a>' +
	//	'<span class="title">' + $('#logo').html() + '</span>' +
	//	'</div>'
	//)
	//	.appendTo($body);

	// Panel.
	$(
		'<div id="navPanel">' +
		'<nav>' +
		$('#nav').navList() +
		'</nav>' +
		'</div>'
	)
		.appendTo($body)
		.panel({
			delay: 500,
			hideOnClick: true,
			hideOnSwipe: true,
			resetScroll: true,
			resetForms: true,
			side: 'left',
			target: $body,
			visibleClass: 'navPanel-visible'
		});

	// Parallax.
	// Disabled on IE (choppy scrolling) and mobile platforms (poor performance).
	if (browser.name == 'ie'
		|| browser.mobile) {

		$.fn._parallax = function () {

			return $(this);

		};

	}
	else {

		$.fn._parallax = function () {

			$(this).each(function () {

				var $this = $(this),
					on, off;

				on = function () {

					$this
						.css('background-position', 'center 0px');

					$window
						.on('scroll._parallax', function () {

							var pos = parseInt($window.scrollTop()) - parseInt($this.position().top);

							$this.css('background-position', 'center ' + (pos * -0.15) + 'px');

						});

				};

				off = function () {

					$this
						.css('background-position', '');

					$window
						.off('scroll._parallax');

				};

				breakpoints.on('<=medium', off);
				breakpoints.on('>medium', on);

			});

			return $(this);

		};

		$window
			.on('load resize', function () {
				$window.trigger('scroll');
			});

	}

	// Spotlights.
	var $spotlights = $('.spotlight');

	$spotlights
		._parallax()
		.each(function () {

			var $this = $(this),
				on, off;

			on = function () {

				var top, bottom, mode;

				// Use main <img>'s src as this spotlight's background.
				$this.css('background-image', 'url("' + $this.find('.image.main > img').attr('src') + '")');

				// Side-specific scrollex tweaks.
				if ($this.hasClass('top')) {

					mode = 'top';
					top = '-20%';
					bottom = 0;

				}
				else if ($this.hasClass('bottom')) {

					mode = 'bottom-only';
					top = 0;
					bottom = '20%';

				}
				else {

					mode = 'middle';
					top = 0;
					bottom = 0;

				}

				// Add scrollex.
				$this.scrollex({
					mode: mode,
					top: top,
					bottom: bottom,
					initialize: function (t) { $this.addClass('inactive'); },
					terminate: function (t) { $this.removeClass('inactive'); },
					enter: function (t) { $this.removeClass('inactive'); },

					// Uncomment the line below to "rewind" when this spotlight scrolls out of view.

					//leave:	function(t) { $this.addClass('inactive'); },

				});

			};

			off = function () {

				// Clear spotlight's background.
				$this.css('background-image', '');

				// Remove scrollex.
				$this.unscrollex();

			};

			breakpoints.on('<=medium', off);
			breakpoints.on('>medium', on);

		});

	// Wrappers.
	var $wrappers = $('.wrapper');

	$wrappers
		.each(function () {

			var $this = $(this),
				on, off;

			on = function () {

				$this.scrollex({
					top: 250,
					bottom: 0,
					initialize: function (t) { $this.addClass('inactive'); },
					terminate: function (t) { $this.removeClass('inactive'); },
					enter: function (t) { $this.removeClass('inactive'); },

					// Uncomment the line below to "rewind" when this wrapper scrolls out of view.

					//leave:	function(t) { $this.addClass('inactive'); },

				});

			};

			off = function () {
				$this.unscrollex();
			};

			breakpoints.on('<=medium', off);
			breakpoints.on('>medium', on);

		});

	// Banner.
	var $banner = $('#banner');

	$banner
		._parallax();

})(jQuery);