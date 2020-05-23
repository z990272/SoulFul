var charts_list_cover = document.getElementsByClassName("charts_list_cover");
var charts_list_song = document.getElementsByClassName("charts_list_song");
var charts_list_artist = document.getElementsByClassName('charts_list_artist');

function Chinese() {
    change('https://i.kfs.io/album/global/73521611,0v1/fit/160x160.jpg', '她沒在看我 (She Ain’t Watchin’)', '瘦子E.SO')
}

function English() {
    change('https://i.kfs.io/album/global/73358758,1v1/fit/160x160.jpg', 'Be Kind', 'Marshmello, Halsey')
}

function Japanese() {
    change('https://i.kfs.io/album/global/56892808,0v1/fit/160x160.jpg', '紅蓮華', 'LiSA')
}

function Korean() {
    change('https://i.kfs.io/album/global/74565160,0v1/fit/160x160.jpg', 'eight(Prod.&Feat. SUGA of BTS)', 'IU')
}

function Taiwanese() {
    change('https://i.kfs.io/album/global/39379998,0v1/fit/160x160.jpg', '浪流連', '茄子蛋')
}

function Cantonese() {
    change('https://i.kfs.io/album/tw/4497341,0v1/fit/160x160.jpg', '喜歡你', 'G.E.M.鄧紫棋')
}

function change(url, song_name, song_artist) {
    for (i = 0; i < 10; i++) {
        charts_list_cover[i].setAttribute('src', url);
        charts_list_song[i].innerHTML = song_name;
        charts_list_artist[i].innerHTML = song_artist;
    }
}