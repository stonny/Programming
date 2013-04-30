    function onClickIdentfyBrowser(event, arguments) {
        var currentWindow = window;
        var browserName = currentWindow.navigator.appCodeName;
        var isMozzilla = (browserName == "Mozilla");
        if (isMozzilla) {
            alert("Yes");
        } else {
            alert("No");
        }
    }
