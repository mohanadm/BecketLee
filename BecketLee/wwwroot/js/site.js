﻿// ********************** site.js ************************//
(function () {
    

    //var $sidebarAndWrapper = $("#sidebar, #wrapper, #header, #disclaimerLink");
    //var $icon = $("#sidebarToggle i.fa");
    //var $navbarBrandDiv = $("#navbarBrand");

    //$("#sidebarToggle").on("click",
    //    function() {            
    //        $sidebarAndWrapper.toggleClass("hide-sidebar");

    //        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
    //            $icon.removeClass("fa fa-chevron-left");
    //            $icon.addClass("fa fa-chevron-right");
    //            $navbarBrandDiv.show();
    //        } else {
    //            $icon.removeClass("fa fa-chevron-right");
    //            $icon.addClass("fa fa-chevron-left");                
    //            $navbarBrandDiv.hide();
    //        }
    //    });

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

//    
//
//    $("#menu li a").on("click", function (e) {
//        
//        alert(href);
//        var $li = $(".active");
//        $li.removeClass("active");
//        $(this).find("li").addClass("active");
//        });


})();