let _readmore1 = document.querySelector("#readmore_button1");
let _readmore2 = document.querySelector("#readmore_button2");
let _readmore3 = document.querySelector("#readmore_button3");
let _modal_news_title = document.querySelector("#newsModalLabel");
let news_description = document.querySelector("#news_description");

_readmore1.addEventListener('click', () => {
    $('#newsModal').modal('toggle');
    _modal_news_title.innerHTML ="新聞標題";
    news_description.innerHTML ="文章內容";
})

_readmore2.addEventListener('click', () => {
    $('#newsModal').modal('toggle');
    _modal_news_title.innerHTML ="新聞標題";
    news_description.innerHTML ="文章內容";
})

_readmore3.addEventListener('click', () => {
    $('#newsModal').modal('toggle');
    _modal_news_title.innerHTML ="新聞標題";
    news_description.innerHTML ="文章內容";
})