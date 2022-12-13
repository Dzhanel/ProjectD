let timers = document.querySelectorAll('[id^="flipdown-"]');

timers.forEach(element => {
    dateStr = element
        .getAttribute("data-event-date")
        .replace(/(.{2})\.(.{2})\.(.{4}) (.{2}):(.{2})/g, "$3-$2-$1 $4:$5");

    const date = new Date(dateStr);

    const timestampInSeconds = date.getTime() / 1000;
    var flipdown = new FlipDown(timestampInSeconds, element.id).start();

    flipdown.ifEnded(() => {

    })
})
