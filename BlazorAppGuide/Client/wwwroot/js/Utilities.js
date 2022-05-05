function DotNetStaticMethodTest() {
    DotNet.invokeMethodAsync("BlazorAppGuide.Client", "GetCurrentCount")
        .then(result => {
            console.log("Current count value is from javascript is " + result);
        });
}

function DotNetInstanceMethodTest(dotNetHelper) {
    dotNetHelper.invokeMethodAsync("IncrementCount");
}