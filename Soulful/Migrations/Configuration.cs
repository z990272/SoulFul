namespace Soulful.Migrations
{
    using Soulful.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Soulful.Models.SoulfulContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Soulful.Models.SoulfulContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Singer.AddOrUpdate(x => x.Singer_id,
             new Singer { Singer_id = 1, Name = "劉若英", Gender = "Woman", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 2, Name = "吳青峰", Gender = "Man", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 3, Name = "E.SO瘦子", Gender = "Man", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 4, Name = "華晨宇", Gender = "Man", Country = "CHN", Language_id = 4 },
             new Singer { Singer_id = 5, Name = "RADWIMPS", Gender = "Group", Country = "JPN", Language_id = 1 },
             new Singer { Singer_id = 6, Name = "伯賢(EXO)", Gender = "Man", Country = "Korean", Language_id = 2 },
             new Singer { Singer_id = 7, Name = "Dua Lipa 杜娃黎波", Gender = "Woman", Country = "UK", Language_id = 3 },
             new Singer { Singer_id = 8, Name = "LADY GAGA 女神卡卡", Gender = "Woman", Country = "USA", Language_id = 3 },
             new Singer { Singer_id = 9, Name = "KEITA橘慶太", Gender = "Man", Country = "JPN", Language_id = 1 },
             new Singer { Singer_id = 10, Name = "伍佰", Gender = "Man", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 11, Name = "ALAN WALKER", Gender = "Man", Country = "USA", Language_id = 3 },
             new Singer { Singer_id = 12, Name = "蔡依林", Gender = "Woman", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 13, Name = "ONE OK ROCK", Gender = "Group", Country = "JPN", Language_id = 1 },
             new Singer { Singer_id = 14, Name = "年輕歲月", Gender = "Group", Country = "USA", Language_id = 3 },
             new Singer { Singer_id = 15, Name = "安懂", Gender = "Man", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 16, Name = "BiSH", Gender = "Group", Country = "JPN", Language_id = 1 },
             new Singer { Singer_id = 17, Name = "Jason Mraz", Gender = "Man", Country = "USA", Language_id = 3 },
             new Singer { Singer_id = 18, Name = "Taylor Swift", Gender = "Woman", Country = "USA", Language_id = 3 }
             );

            context.Language.AddOrUpdate(x => x.Language_id,
                new Language { Language_id = 1, Language_type = "Japanese" },
                new Language { Language_id = 2, Language_type = "Korean" },
                new Language { Language_id = 3, Language_type = "English" },
                new Language { Language_id = 4, Language_type = "Chinese" },
                new Language { Language_id = 5, Language_type = "Russian" },
                new Language { Language_id = 6, Language_type = "French" },
                new Language { Language_id = 7, Language_type = "Latin" }
                );

            context.Album.AddOrUpdate(x => x.Album_id,
                 new Album { Album_id = 1, Singer_id = 1, Datetime = new DateTime(2015, 09, 22), Album_Name = "我要你好好的", Pic = "劉若英-我要你好好的.jpg", Price = 419, Company = "相信音樂", About = "無論去到哪裡、經歷了什麼，請你一定要記得，你並不孤單。因為，我一直在這裡。我要你好好的。" },
                 new Album { Album_id = 2, Singer_id = 2, Datetime = new DateTime(2020, 05, 15), Album_Name = "太空人", Pic = "Spaceman.jpg", Price = 2020, Company = "UNI/環球", About = "2020.05.15 太空日誌宇宙航行的時間，與地球是有時差的。在《太空人》的宇宙裡，我們一起經歷了專輯發行、抵達《太空備忘記》每顆星球、看見《太空人》線上影展一部部美如藝術品般的音樂錄影帶，也經歷突如其來隕石般的不可預期、黑洞距離的拉扯......過程裡，我們曾停航，當中的我們，有些只能遙望著，但卻因為音樂能夠繼續閃爍，感受每次的流淚歌頌......。現在，我們再次重拾一切的原點，那是音樂的本質。" },
                 new Album { Album_id = 3, Singer_id = 3, Datetime = new DateTime(2020, 07, 10), Album_Name = "Outta body靈魂出竅", Pic = "瘦子ESO-靈魂出竅.jpg", Price = 458, Company = "滾石唱片", About = "瘦子E.SO從頑童出道至今，走過精彩光輝的音樂歷程也替華語市場帶來豐富多元的嘻哈新局面有人說饒舌歌手是社會觀察家，透過音樂唱出世俗紅塵的大小事音樂是他們的生命歷程，五感則是他們的靈感來源不論你認識的是《Just Believe》那個因夢想而偉大的他還是《脫罪》中深思沉靜的成熟內斂的青年 ; 亦或是《地痞》裡訴說自我始終如一態度十足的 瘦子E.SO但不論是哪個角色，哪個他，經歷歲月的洗鍊，在頑童單飛不解散後他對生命有了更深的體悟頂著金曲光環，背負多人的期待，2020 瘦子E.SO 將帶給大家全新的思維角度與音樂感受，宣告大家我的改變即是我的音樂歷程上的新開端，在這個新的十年，他將帶給大家更多新觀點，更不忘初心的用音樂闡述更多關於他對於愛的議題" },
                 new Album { Album_id = 4, Singer_id = 4, Datetime = new DateTime(2020, 06, 15), Album_Name = "新世界", Pic = "華晨宇-新世界.jpg", About = "因果輪迴，生命探索，花花宇宙，唱出自我打破舊規則，開創新世界華語樂壇新生代領軍唱作人華晨宇第四張全新創作專輯，新世界ＮＥＷ ＷＯＲＬＤ改造音樂新三觀，引領華流新格局", Price = 668, Company = "SONY MUSIC" },
                 new Album { Album_id = 5, Singer_id = 5, Datetime = new DateTime(2019, 12, 11), Album_Name = "天氣之子", Pic = "RADWIMPS.jpg", Price = 1599, Company = "UNI(環球)" },
                 new Album { Album_id = 6, Singer_id = 6, Datetime = new DateTime(2019, 09, 06), Album_Name = "DELIGHT", Pic = "伯賢-DELIGHT.jpg", Price = 509, Company = "SM ENTERTAINMENT" },
                 new Album { Album_id = 7, Singer_id = 7, Datetime = new DateTime(2020, 04, 07), Album_Name = "流行先鋒", Pic = "杜娃黎波-流行先鋒.jpg", About = "集性感、時尚、智慧於一身，唱作俱佳的危險系繆思女神橫掃全球。打從BBC「2016年度之聲」、NME Awards「最佳新人」，一路到葛萊美和全英音樂獎的「最佳新人」全面征服，還讓英倫天團Coldplay、國際巨星Bruno Mars傾心不已，成為巡演的指定嘉賓！傲人締造Spotify史上專輯串流量最多的女歌手、YouTube平台大破10億點擊量的最年輕藝人！", Price = 439, Company = "WARNER MUSIC" },
                 new Album { Album_id = 8, Singer_id = 8, Datetime = new DateTime(2020, 06, 03), Album_Name = "Chromatica (Standard Edtion)神彩", Pic = "LADYGAGA.jpg", About = "每一個世代都需要一位能夠引領潮流、顛覆世代的前衛人物作為指標，成為當代人們情感出口與追循目標；1960-70年代「大衛鮑伊David Bowie」雌雄莫辨的陰柔形象、80-90年代「瑪丹娜Madonna」將女性主義提升到全球皆知；進入21世紀，全球樂壇最具指標性人物非「女神卡卡LADY GAGA」莫屬，她不斷在音樂、流行、藝術等領域帶動風潮，躍升當代最重要的流行文化唯一巨星。2020年，LADY GAGA再次帶著全新作品回到樂壇，以她最擅長的流行舞曲預備再創音樂新領域。", Price = 399, Company = "UNI(環球)" },
                 new Album { Album_id = 9, Singer_id = 9, Datetime = new DateTime(2020, 05, 15), Album_Name = "inK", Pic = "KEITA-inK.jpg", About = "w-inds.主唱 - 橘慶太KEITA推出睽違4年、收錄14首精彩樂曲的第3張個人專輯.w - inds.裡負責主唱，同時也身兼歌曲製作的橘慶太，以SOLO PROJECT “KEITA”的名義，透過許多海外流行音樂要素，並受到眾多音樂人及創作者的關注。KEITA以身為歌手／作曲者嘗試探索多樣的可能性，推出睽違4年的第3張個人專輯。專輯《inK》的意思代表KEITA自我本身，收錄2019年數位發行的12首歌曲外，另外追加收錄2首新曲〈Tokyo Night Fighter〉、〈Someday〉。本張專輯KEITA不只挑戰全部樂曲的作詞、作編曲，另外也參與了混音及後期處理，是一張由KEITA完整打造的個人專輯。台壓初回盤DVD收錄寫給母親的新曲〈Someday〉的製作過程，約40分鐘的幕後花絮，將可看到KEITA私下與工作人員開會、拍攝專輯封面以及在錄音室製作樂曲的各種花絮。DVD附中文字幕。", Company = "洧誠國際有限公司", Price = 369 }
                 );

            context.Song.AddOrUpdate(x => x.Song_id,
                new Song { Song_id = 1, Album_id = 1, Song_name = "我懂了" },
                new Song { Song_id = 2, Album_id = 1, Song_name = "相看兩不厭" },
                new Song { Song_id = 3, Album_id = 1, Song_name = "寫信回家" },
                new Song { Song_id = 4, Album_id = 1, Song_name = "我要你好好的" },
                new Song { Song_id = 5, Album_id = 1, Song_name = "我敢在你懷裡孤獨" },
                new Song { Song_id = 6, Album_id = 1, Song_name = "陪伴者" },
                new Song { Song_id = 7, Album_id = 1, Song_name = "十年後" },
                new Song { Song_id = 8, Album_id = 1, Song_name = "一路走下去" },
                new Song { Song_id = 9, Album_id = 1, Song_name = "在宇宙流浪" },
                new Song { Song_id = 10, Album_id = 1, Song_name = "念念" },
                new Song { Song_id = 11, Album_id = 1, Song_name = "歲月靜好" },
                new Song { Song_id = 12, Album_id = 2, Song_name = "譯夢機" },
                new Song { Song_id = 13, Album_id = 2, Song_name = "回音收集員" },
                new Song { Song_id = 14, Album_id = 2, Song_name = "巴別塔慶典" },
                new Song { Song_id = 15, Album_id = 2, Song_name = "太空人" },
                new Song { Song_id = 16, Album_id = 2, Song_name = "傷風" },
                new Song { Song_id = 17, Album_id = 2, Song_name = "失憶鎮" },
                new Song { Song_id = 18, Album_id = 2, Song_name = "太空" },
                new Song { Song_id = 19, Album_id = 2, Song_name = "水仙花之死" },
                new Song { Song_id = 20, Album_id = 2, Song_name = "男孩莊周" },
                new Song { Song_id = 21, Album_id = 2, Song_name = "太空船" },
                new Song { Song_id = 22, Album_id = 2, Song_name = "線的記憶" },
                new Song { Song_id = 23, Album_id = 2, Song_name = "Outsider" },
                new Song { Song_id = 24, Album_id = 3, Song_name = "Intro" },
                new Song { Song_id = 25, Album_id = 3, Song_name = "Don’t Worry About Me" },
                new Song { Song_id = 26, Album_id = 3, Song_name = "Follow You" },
                new Song { Song_id = 27, Album_id = 3, Song_name = "Hello Beautiful" },
                new Song { Song_id = 28, Album_id = 3, Song_name = "CHANGE" },
                new Song { Song_id = 29, Album_id = 3, Song_name = "稱讚她的美" },
                new Song { Song_id = 30, Album_id = 3, Song_name = "I Wish I Was There" },
                new Song { Song_id = 31, Album_id = 3, Song_name = "Money Bag" },
                new Song { Song_id = 32, Album_id = 3, Song_name = "So Good To Me" },
                new Song { Song_id = 33, Album_id = 3, Song_name = "Something I Don’t Need " },
                new Song { Song_id = 34, Album_id = 3, Song_name = "她沒在看我" },
                new Song { Song_id = 35, Album_id = 3, Song_name = "伯父" },
                new Song { Song_id = 36, Album_id = 3, Song_name = "Wait" },
                new Song { Song_id = 37, Album_id = 3, Song_name = "伯父" },
                new Song { Song_id = 38, Album_id = 3, Song_name = "太陽" },
                new Song { Song_id = 39, Album_id = 4, Song_name = "鬥牛" },
                new Song { Song_id = 40, Album_id = 4, Song_name = "好想愛這個世界啊" },
                new Song { Song_id = 41, Album_id = 4, Song_name = "瘋人院" },
                new Song { Song_id = 42, Album_id = 4, Song_name = "與火星的孩子對話" },
                new Song { Song_id = 43, Album_id = 4, Song_name = "七重人格" },
                new Song { Song_id = 44, Album_id = 4, Song_name = "神樹" },
                new Song { Song_id = 45, Album_id = 4, Song_name = "降臨" },
                new Song { Song_id = 46, Album_id = 4, Song_name = "新世界" },
                new Song { Song_id = 47, Album_id = 5, Song_name = "陽菜、救出" },
                new Song { Song_id = 48, Album_id = 5, Song_name = "K&A初訪問" },
                new Song { Song_id = 49, Album_id = 5, Song_name = "K&A入社式" },
                new Song { Song_id = 50, Album_id = 5, Song_name = "花火大會" },
                new Song { Song_id = 51, Album_id = 5, Song_name = "首都危機" },
                new Song { Song_id = 52, Album_id = 6, Song_name = "Delight Time" },
                new Song { Song_id = 53, Album_id = 6, Song_name = "Paradise" },
                new Song { Song_id = 54, Album_id = 6, Song_name = "Mega Yak" },
                new Song { Song_id = 55, Album_id = 7, Song_name = "Future Nostalgia" },
                new Song { Song_id = 56, Album_id = 7, Song_name = "Don't Start Now" },
                new Song { Song_id = 57, Album_id = 7, Song_name = "Cool" },
                new Song { Song_id = 58, Album_id = 7, Song_name = "Physical" },
                new Song { Song_id = 59, Album_id = 7, Song_name = "Levitating" },
                new Song { Song_id = 60, Album_id = 7, Song_name = "Pretty Please" },
                new Song { Song_id = 61, Album_id = 7, Song_name = "Hallucinate" },
                new Song { Song_id = 62, Album_id = 7, Song_name = "Love Again" },
                new Song { Song_id = 63, Album_id = 7, Song_name = "Break My Heart" },
                new Song { Song_id = 64, Album_id = 7, Song_name = "Good In Bed" },
                new Song { Song_id = 65, Album_id = 7, Song_name = "Boys Will Be Boys" },
                new Song { Song_id = 66, Album_id = 8, Song_name = "Chromatica I神彩I" },
                new Song { Song_id = 67, Album_id = 8, Song_name = "Alice艾莉絲" },
                new Song { Song_id = 68, Album_id = 8, Song_name = "Stupid Love癡癡的愛" },
                new Song { Song_id = 69, Album_id = 8, Song_name = "Rain On Me讓雨降臨 ft. Ariana Grande亞莉安娜" },
                new Song { Song_id = 70, Album_id = 8, Song_name = "Free Woman自主女性" },
                new Song { Song_id = 71, Album_id = 8, Song_name = "Fun Tonight 歡樂夜晚" },
                new Song { Song_id = 72, Album_id = 8, Song_name = "Chromatica II 神彩II" },
                new Song { Song_id = 73, Album_id = 8, Song_name = "911 求救" },
                new Song { Song_id = 74, Album_id = 8, Song_name = "Plastic Doll塑膠公仔" },
                new Song { Song_id = 75, Album_id = 8, Song_name = "Sour Candy 酸糖 ft. BLACKPINK" },
                new Song { Song_id = 76, Album_id = 8, Song_name = "Enigma 密碼" },
                new Song { Song_id = 77, Album_id = 8, Song_name = "Replay 重播" },
                new Song { Song_id = 78, Album_id = 8, Song_name = "Chromatica III神彩III" },
                new Song { Song_id = 79, Album_id = 8, Song_name = "Sine From Above 天上弦音 ft. Elton John艾爾頓強" },
                new Song { Song_id = 80, Album_id = 8, Song_name = "1000 Doves 千鴿" },
                new Song { Song_id = 81, Album_id = 8, Song_name = "Babylon 巴比倫" },
                new Song { Song_id = 82, Album_id = 9, Song_name = "Don't Leave Me Alone" },
                new Song { Song_id = 83, Album_id = 9, Song_name = "Be On The Stage" },
                new Song { Song_id = 84, Album_id = 9, Song_name = "Around N Around" },
                new Song { Song_id = 85, Album_id = 9, Song_name = "Lonely Night" },
                new Song { Song_id = 86, Album_id = 9, Song_name = "I Gotta Feeling feat. ISH-ONE, GASHIMA" },
                new Song { Song_id = 87, Album_id = 9, Song_name = "Tokyo Night Fighter" },
                new Song { Song_id = 88, Album_id = 9, Song_name = "Too Young To Die" },
                new Song { Song_id = 89, Album_id = 9, Song_name = "Live For Yourself" },
                new Song { Song_id = 90, Album_id = 9, Song_name = "Hopeless Place" },
                new Song { Song_id = 91, Album_id = 9, Song_name = "Y.E.S" },
                new Song { Song_id = 92, Album_id = 9, Song_name = "Nothing Lasts Forever" },
                new Song { Song_id = 93, Album_id = 9, Song_name = "Give Me Somemore" },
                new Song { Song_id = 94, Album_id = 9, Song_name = "Angel" },
                new Song { Song_id = 95, Album_id = 9, Song_name = "Someday" }

                );

            context.Style.AddOrUpdate(x => x.Style_id,
                new Style { Style_id = 1, Style_type = "流行", Album_id = 1 },
                new Style { Style_id = 2, Style_type = "國語", Album_id = 1 },
                new Style { Style_id = 3, Style_type = "CD", Album_id = 1 },
                new Style { Style_id = 4, Style_type = "流行", Album_id = 2 },
                new Style { Style_id = 5, Style_type = "國語", Album_id = 2 },
                new Style { Style_id = 6, Style_type = "CD", Album_id = 2 },
                new Style { Style_id = 7, Style_type = "流行", Album_id = 3 },
                new Style { Style_id = 8, Style_type = "國語", Album_id = 3 },
                new Style { Style_id = 9, Style_type = "CD", Album_id = 3 },
                new Style { Style_id = 10, Style_type = "流行", Album_id = 4 },
                new Style { Style_id = 11, Style_type = "國語", Album_id = 4 },
                new Style { Style_id = 12, Style_type = "CD", Album_id = 4 },
                new Style { Style_id = 13, Style_type = "日文", Album_id = 5 },
                new Style { Style_id = 14, Style_type = "CD", Album_id = 5 },
                new Style { Style_id = 15, Style_type = "Soundtrack", Album_id = 5 },
                new Style { Style_id = 16, Style_type = "抒情", Album_id = 5 },
                new Style { Style_id = 17, Style_type = "流行", Album_id = 5 },
                new Style { Style_id = 18, Style_type = "韓文", Album_id = 6 },
                new Style { Style_id = 19, Style_type = "CD", Album_id = 6 },
                new Style { Style_id = 20, Style_type = "流行", Album_id = 6 },
                new Style { Style_id = 21, Style_type = "英文", Album_id = 7 },
                new Style { Style_id = 22, Style_type = "CD", Album_id = 7 },
                new Style { Style_id = 23, Style_type = "流行", Album_id = 7 },
                new Style { Style_id = 24, Style_type = "英文", Album_id = 8 },
                new Style { Style_id = 25, Style_type = "CD", Album_id = 8 },
                new Style { Style_id = 26, Style_type = "流行", Album_id = 8 },
                new Style { Style_id = 27, Style_type = "日文", Album_id = 9 },
                new Style { Style_id = 28, Style_type = "CD", Album_id = 9 },
                new Style { Style_id = 29, Style_type = "抒情", Album_id = 9 },
                new Style { Style_id = 30, Style_type = "流行", Album_id = 9 }
                );

            context.Event.AddOrUpdate(x => x.Event_id,
                new Event { Event_id = 1, Name = "伍佰＆ChinaBlue 2020 RockStar演唱會-台中站", Singer_id = 10, Datetime = new DateTime(2021, 01, 23), Pic = "ChinaBlue_2020RockSta.jpg", Adress = "台中圓滿戶外劇場", About = "還記得2018年「台灣限定透南風演唱會」與大家一起在圓滿戶外劇場大合唱的感動，伍佰 & China Blue ROCK STAR大型巡迴演唱會繼2019高雄站，2020即將前進台中！伍佰與China Blue將重新開啟你對搖滾樂的視野與認知。橫跨歷年專輯的曲目，讓你窺見伍佰各時期大膽前衛的風格轉變，以及伍佰之所以成為搖滾巨星的核心力量。" },
                new Event { Event_id = 2, Name = "ALAN WALKER 2020 LIVE IN TAIPEI", Singer_id = 11, Datetime = new DateTime(2020, 12, 09), Pic = "AlanWalker.jpg", Adress = "新北大都會公園幸福水漾園區", About = "百大DJ第27名— 蒙面天才ALAN WALKER 暌違三年終於來台英國挪威混血DJ - Alan Walker(艾倫 · 沃克)以「Faded」一曲紅遍全球，歌曲已有超過26億Youtube觀看次數。將於4月18日於新北大都會公園，跟歌迷見面。帶著經典EDM神曲「Faded」﹑「Alone」﹑「Sing Me To Sleep」﹑「Darkside」﹑「The Spectre」等多首破億魔性單曲，將無限顛覆所有電音迷的EDM聽覺﹑視覺體驗，帶給各位專屬的現場魅力！" },
                new Event { Event_id = 3, Name = "ONE OK ROCK EYE OF THE STORM ASIA TOUR 2020 IN TAIWAN", Singer_id = 13, Datetime = new DateTime(2020, 011, 04), Pic = "ONEOKROCK .jpg", Adress = "台北小巨蛋", About = "ONE OK ROCK風暴強烈席捲2020年11月4日、6日、7日 三天稱霸台北小巨蛋！日本搖滾天團ONE OK ROCK稱霸世界第二章開啟！各位粉絲久違2年昂首期盼的最新「暴風眼」亞洲巡迴最終站就在台灣" },
                new Event { Event_id = 4, Name = "蔡依林 Ugly Beauty 2019-2020 世界巡迴演唱會 高雄站", Singer_id = 12, Datetime = new DateTime(2020, 09, 04), Pic = "UglyBeauty.jpeg", Adress = "高雄巨蛋", About = "台北站六場場場都給”長輩”各種不同驚喜的Jolin，在最終場尾末仍不忘拋驚喜震撼彈宣布要在5 / 9、5 / 10兩天於高雄巨蛋再加兩場演出，主辦單位特別宣布高雄加場將於1 / 18中午12:16在開始售票！#「蔡依林Ugly Beauty 2019-2020 世界巡迴演唱會 高雄站」2020/9/4 再加場#歌迷注意！Jolin「消極掰幫」以斧頭號召在高雄場相認！" },
                new Event { Event_id = 5, Name = "GREEN DAY LIVE IN TAIPEI 2021 年輕歲月2021台北演唱會", Singer_id = 14, Datetime = new DateTime(2021, 03, 16), Pic = "GreenDay.jpg", Adress = "台北小巨蛋", About = "有生之年系列再一發成軍33年 終於等到美國大白癡!美國龐克教父年輕歲月 明年3月唱進小巨蛋90年代指標性龐克樂團 全球唱片銷量逾7500萬葛萊美獎五度認證 名列搖滾名人堂" },
                new Event { Event_id = 6, Name = "2020 安懂新歌發表會《順著海流》", Singer_id = 15, Datetime = new DateTime(2021, 06, 27), Pic = "順著海流.jpg", Adress = "河岸留言西門紅樓展演館", About = "順著「海洋音樂祭」的黑潮，安懂帶著滿滿家鄉的祝福，從台東的部落流浪到了台北。每天潛沉在自己的世界，愉快地寫著歌、唱著歌，偶爾探出頭換個氣，交交朋友，看看這片自己徜徉的音樂海洋。這張 「順著海流」專輯，記錄著安懂的心情，安懂的思念，安懂的感恩，及安懂的成長。這段屬於安懂的故事，希望和你們分享，也希望「順著海流」能夠陪大家去到更遠的地方。" }
                );

            context.News.AddOrUpdate(x => x.News_id,
                new News { News_id = 1, Singer_id = 16, About = "不拿樂器的龐克搖滾樂團BiSH，在5/21宣布預計在日本7個城市舉辦的單獨Live House巡迴演唱會「BiSH'S GASP!!GOLD!!GHOST!!GALAXY!!GARBAGE!! TOUR」及第一次舉辦的樂團對決巡迴演唱會「BiSH’S 5G are MAKiNG LOVE TOUR」，為防範新冠病毒擴大感染，全部公演停止舉辦。目前無法確定延期日程，日後將公告退票辦法。", Pic = "BisH.jpg", News_title = "BiSH宣佈巡迴公演全部停辦 " },
                new News { News_id = 2, Singer_id = 17, About = "「音樂大玩童」Jason Mraz 傑森瑪耶茲繼2018年發行專輯《Know. 懂得愛》後，睽違兩年推出新作品〈Look For The Good〉，同名新專輯也預計將在6月發行，融入全新音樂風格的傑森瑪耶茲相當值得期待！傑森瑪耶茲與台灣緣分深厚，他曾四度來台，包括受邀參加金曲獎與金曲歌王林俊傑合唱〈I’m Yours〉、首次來台便完售的台大體育館演唱會，以及兩次攻蛋經驗，他的〈I’m Yours〉、〈Lucky〉等金曲在台灣也長年傳唱，可以說是台灣最愛的西洋情歌天王。傑森在去年來台時，更因收到來自華納音樂以再生紙與回收吸管製作的多白金唱片，而感動在社群網站上寫下「台灣很了解我」的字句，表達對台灣的喜愛。", Pic = "Jason Mraz.jpg", News_title = "傑森瑪耶茲『轉行』回收場開怪手？" },
                new News { News_id = 3, Singer_id = 18, About = "原本預定將在本月底在全美音樂獎(American Music Awards)上應邀演出，並且會在典禮上被授予「近十年最佳藝人(Artist of the Decade Award)」獎項的流行天后泰勒絲，原先已經準備好在頒獎典禮當天演出她近十年的熱門單曲串燒，然而泰勒絲卻突然接到知名經紀人Scooter Braun及前唱片公司老闆Scott Brochetta的通知，在她明年十一月自己重錄這些專輯的新版本之前，將禁止她公開演出這些舊專輯的曲目，除非泰勒絲同意立即停止重新錄製舊專輯的計劃，並且停止繼續公開談論Scott Brochetta以及Scooter Braun。", Pic = "Taylor Swift.jpg", News_title = " Taylor Swift全美音樂獎演出遭前東家阻撓 發表公開聲明嚴肅痛斥：正視創作者權益" }

               );
        }
    }
}
