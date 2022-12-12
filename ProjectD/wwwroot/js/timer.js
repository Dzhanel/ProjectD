
let timers = document.querySelectorAll('[id^="flipdown-"]');
timers.forEach(element => {
    /*let dateStr = '2022-12-13 0:00:00';*/
    dateStr = element.getAttribute("data-event-date");
    console.log(dateStr)
    const date = new Date(dateStr);

    const timestampInSeconds = date.getTime() / 1000;
    var flipdown = new FlipDown(timestampInSeconds, element.id).start();

    //flipdown.ifEnded(() => {
    //    console.log('Timer has ended');
    //});
})
