var machineName;

function clicked(status, name) {
    machineName = name;
    if (status === "open") {
        document.getElementById("reserveOverlay").style.visibility = "visible";
    }
}

function closeClicked(string) {
    document.getElementById(string).style.visibility = 'hidden';
}

function nextClicked() {
    document.getElementById("cycleSelection").style.display = "none";
    document.getElementById("enterPin").style.display = "block";
}

function okClicked() {
    $('#' + machineName).removeClass("open");
    $('#' + machineName).addClass("inUse");
    $('#' + machineName).find(".machine-status").text("IN USE");

    document.getElementById("cycleSelection").style.display = "block";
    document.getElementById("enterPin").style.display = "none";
}

function doneClicked() {
    $('#' + machineName).removeClass("inUse");
    $('#' + machineName).addClass("open");
    $('#' + machineName).find(".machine-status").text("OPEN");
}