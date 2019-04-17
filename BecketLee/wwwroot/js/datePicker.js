/*********************** datePicker.js ************************/


(function () {

    "use strict";
    
    $(function () {
        $("#StartDate").datepicker({
            format: "mm/dd/yyyy"
            , todayBtn: "linked"
            , language: "de"
            , todayHighlight: true
            , autoClose: true
            , useCurrent: true
                        
        });
    });

    $(function () {
        $("#EndDate").datepicker({
            format: "mm/dd/yyyy"
            , todayBtn: "linked"
            , language: "de"
            , todayHighlight: true
            , autoClose: true
            , useCurrent: true

        });
    });


})();