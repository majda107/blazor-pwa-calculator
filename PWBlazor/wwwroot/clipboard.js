function getClipboard() {
    return navigator.clipboard.readText();
}

function copyClipboard(text) {
    navigator.clipboard.writeText(text);
}