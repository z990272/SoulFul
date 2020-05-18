let header_area = document.querySelector(".header-area");
window.addEventListener('scroll', isSticky, false);
function isSticky() {
    header_area.style.position = "sticky";
    header_area.style.backgroundColor = "#000000";
    header_area.style.top = "0";
    header_area.style.zIndex = "1000";
    window.removeEventListener('scroll', isSticky, false);
}