// ********************** site.js ************************//
(function() {

    var $sidebarAndWrapper = $("#sidebar, #wrapper, #header, #disclaimerLink");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click",
        function() {

            $sidebarAndWrapper.toggleClass("hide-sidebar");

            if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
                $icon.removeClass("fa fa-chevron-left");
                $icon.addClass("fa fa-chevron-right");
            } else {
                $icon.removeClass("fa fa-chevron-right");
                $icon.addClass("fa fa-chevron-left");
            }
        });

    var $disclaimer = $("#disclaimerLink");
    $disclaimer.on("click", function() {
        openSimpleWindow("http://www.becket-lee.com/disclaimer.html", "Disclaimer", 550, 750);
    });

    function openSimpleWindow(url, title, hight, width ) {
        window.open(url, title, "statusbar=0,toolbar=0,menubar=0,addressbar=0 resizable=no, height=" + hight + ", width=" + width + "\"");
    }


})();