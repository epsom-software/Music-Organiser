
(function () {
    function overwrite(functionName) {

        console["old_" + functionName] = console[functionName];

        console[functionName] = function (message) {
            alert(message);
            console["old_" + functionName](message);
        }
    }

    overwrite("debug");
    overwrite("error");
})();
