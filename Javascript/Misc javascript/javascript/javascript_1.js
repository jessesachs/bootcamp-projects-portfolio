function byclassname() {
    var funny = document.getElementsByClassName("big_writing");
    document.getElementById("small_writing").innerHTML = funny;
    fill_rectangle();
}

function fill_rectangle() {
    const myCanvas = document.getElementById("myCanvas");
    const ctx = myCanvas.getContext("2d");
    
    ctx.fillRect(20, 20, 150, 100);


    // Create a Gradient
    const grd = ctx.createLinearGradient(0, 0, 170, 0);
    grd.addColorStop(0, "black");
    grd.addColorStop(1, "white");

    // Draw a filled Rectangle
    ctx.fillStyle = grd;
    ctx.fillRect(20, 20, 150, 100);
}