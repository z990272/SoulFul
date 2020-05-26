let header_area = document.querySelector(".header-area");
window.addEventListener('scroll', isFixed, false);
function isFixed() {
    header_area.style.backgroundColor = "#000000";
    window.removeEventListener('scroll', isFixed, false);
}