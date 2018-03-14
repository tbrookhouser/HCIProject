var machineName;

function clicked(status, name) {
        machineName = name;	
}

function nextClicked() {
    document.getElementById("cycleSelection").style.display = "none";
    document.getElementById("enterPin").style.display = "block";
}

function okClicked() {
    $('#' + machineName).removeClass("open");
    $('#' + machineName).addClass("inUse");
    $('#' + machineName).find(".machine-status").text("IN USE");
}

function doneClicked() {
    $('#' + machineName).removeClass("inUse");
    $('#' + machineName).addClass("open");
    $('#' + machineName).find(".machine-status").text("OPEN");
}