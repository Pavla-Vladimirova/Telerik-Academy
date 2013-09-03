function onCheckBrowserTypeButtonClick(event, arguments) {
    var userWindow = window;
    var browser = userWindow.navigator.appCodeName;
    var browserType = "Mozilla";

    if (browserType) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}
