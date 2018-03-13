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
    document.getElementById("reserveOverlay").style.visibility = "hidden";
    document.getElementById("pinOverlay").style.visibility = "visible";
}

function okClicked() {
    document.getElementById('pinOverlay').style.visibility = "hidden";
    document.getElementById(machineName).classList.remove("open");
    document.getElementById(machineName).classList.add("inUse");
    document.getElementById("status_" + machineName).textContent = "IN USE";
}

function doneClicked() {
    $('#' + machineName).removeClass("inUse");
    $('#' + machineName).addClass("open");
    $('#' + machineName).find(".machine-status").text("OPEN");
}