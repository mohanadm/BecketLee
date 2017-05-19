/*********************** datePicker.js ************************/


(function () {
    $(function () {
        $(".datePicker").datepicker({
            format: "mm/dd/yyyy"
            , todayBtn: "linked"
            , language: "de"
            , autoclose: true
            
        });
    });
})();