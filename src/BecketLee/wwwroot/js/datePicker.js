/*********************** datePicker.js ************************/


(function () {

    "use strict";
    
    $(function () {
        $("#StartDate").datepicker({
            format: "mm/dd/yyyy"
            , todayBtn: "linked"
            , language: "de"
            , todayHighlight: true
            , container: $("#eventForm")
            , autoclose: true
            , useCurrent: true
                        
        });
    });

    $('#StartDate').change(function () {
        console.log($('#StartDate').val());
    });

    $(function () {
        $("#EndDate").datepicker({
            format: "mm/dd/yyyy"
            , todayBtn: "linked"
            , language: "de"
            , todayHighlight: true
            , container: $("#eventForm")
            , autoclose: true
            , useCurrent: true

        });
    });
    $('#EndDate').change(function () {
        console.log($('#EndDate').val());
    });


})();