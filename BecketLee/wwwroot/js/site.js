// ********************** site.js ************************//
(function () {
    

    var $disclaimer = $("#disclaimerLink");
    $disclaimer.on("click", function() {
        openSimpleWindow("http://www.becket-lee.com/disclaimer.html", "Disclaimer", 550, 750);
    });

    function openSimpleWindow(url, title, hight, width ) {
        window.open(url, title, "statusbar=0,toolbar=0,menubar=0,addressbar=0 resizable=no, height=" + hight + ", width=" + width + "\"");
    }

 
    $(window).on("load", function () {
        var url = window.location.pathname.toString();
        var $anchor = $('#menu a[href="' + url + '"]');
        $anchor.parent().addClass("active");           

    });



})();