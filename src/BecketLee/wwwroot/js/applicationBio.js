﻿// ********************** applicationBio.js ************************//
(function ($) {
    function applicationBio() {
        var $this = this;

        function initilizeModel() {
            $("#modal-action-bio").on('loaded.bs.modal', function (e) {

            }).on('hidden.bs.modal', function (e) {
                $(this).removeData('bs.modal');
            });
        }

        $this.init = function () {
            initilizeModel();
        };
    }

    $(function () {
        var self = new applicationBio();
        self.init();
    });
})(jQuery);