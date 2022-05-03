/// <reference path="jquery-1.11.2.min.js" />

$(document).ready(function () {
    //$('[id$=trcashmode]').css({ "display": "none" });
    $('[id$=cashtab]').css({ "display": "none" });
    $('[id$=checktab]').css({ "display": "none" });
    $('[id$=credit_debit_tab]').css({ "display": "none" });
    $('[id$=ddl_cust_cash_mode]').change(function () {
        if ($('[id$=ddl_cust_cash_mode]').val() == "0") {
            $('[id$=cashtab]').css({ "display": "none" });
            $('[id$=checktab]').css({ "display": "none" });
            $('[id$=credit_debit_tab]').css({ "display": "none" });
            //$('[id$=tdcashmode]').css({ "display": "none" });
        }
        if ($('[id$=ddl_cust_cash_mode]').val() == "mod1") {
            //$('#trcashmode').css({ "display": "block" });                
            $('[id$=checktab]').css("display", "none");
            $('[id$=credit_debit_tab]').css("display", "none");
            $('[id$=cashtab]').css("display", "block");
            //$('#cashtab]').attr(colspan, 4);
            //$('#cashtab').attr("colspan", 4);"table[id*=cashtab] input"   $('#thatsmytd').attr('colspan','4');
            $('[id$=cashtab]').css({ "display": "block", "padding": "5px 10px 5px 10px", "border": "1px solid #6699cc" });
            return false;
        }
        if ($('[id$=ddl_cust_cash_mode]').val() == "mod2") {
            $('[id$=cashtab]').css("display", "none");
            $('[id$=credit_debit_tab]').css("display", "none");
            $('[id$=checktab]').css("display", "block");
            $('[id$=checktab]').attr("colspan", 4);
            $('[id$=checktab]').css({ "display": "block", "padding": "5px 10px 5px 10px", "border": "1px solid #6699cc" });
            return false;
        }
        if ($('[id$=ddl_cust_cash_mode]').val() == "mod3") {
            $('[id$=cashtab]').css("display", "none");
            $('[id$=checktab]').css("display", "none");
            $('[id$=credit_debit_tab]').css("display", "block");
            $('[id$=credit_debit_tab]').attr("colspan", 4);
            $('[id$=credit_debit_tab]').css({ "display": "block", "padding": "5px 10px 5px 10px", "border": "1px solid #6699cc" });
            return false;
        }

    });
});