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
             new Singer { Singer_id = 1, Name = "�B�Y�^", Gender = "Woman", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 2, Name = "�d�C�p", Gender = "Man", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 3, Name = "E.SO�G�l", Gender = "Man", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 4, Name = "�ر�t", Gender = "Man", Country = "CHN", Language_id = 4 },
             new Singer { Singer_id = 5, Name = "RADWIMPS", Gender = "Group", Country = "JPN", Language_id = 1 },
             new Singer { Singer_id = 6, Name = "�B��(EXO)", Gender = "Man", Country = "Korean", Language_id = 2 },
             new Singer { Singer_id = 7, Name = "Dua Lipa �������i", Gender = "Woman", Country = "UK", Language_id = 3 },
             new Singer { Singer_id = 8, Name = "LADY GAGA �k���d�d", Gender = "Woman", Country = "USA", Language_id = 3 },
             new Singer { Singer_id = 9, Name = "KEITA��y��", Gender = "Man", Country = "JPN", Language_id = 1 },
             new Singer { Singer_id = 10, Name = "���", Gender = "Man", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 11, Name = "ALAN WALKER", Gender = "Man", Country = "USA", Language_id = 3 },
             new Singer { Singer_id = 12, Name = "���̪L", Gender = "Woman", Country = "TWN", Language_id = 4 },
             new Singer { Singer_id = 13, Name = "ONE OK ROCK", Gender = "Group", Country = "JPN", Language_id = 1 },
             new Singer { Singer_id = 14, Name = "�~������", Gender = "Group", Country = "USA", Language_id = 3 },
             new Singer { Singer_id = 15, Name = "�w��", Gender = "Man", Country = "TWN", Language_id = 4 },
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
                 new Album { Album_id = 1, Singer_id = 1, Datetime = new DateTime(2015, 09, 22), Album_Name = "�ڭn�A�n�n��", Pic = "�B�Y�^-�ڭn�A�n�n��.jpg", Price = 419, Company = "�۫H����", About = "�L�ץh����̡B�g���F����A�ЧA�@�w�n�O�o�A�A�ä��t��C�]���A�ڤ@���b�o�̡C�ڭn�A�n�n���C" },
                 new Album { Album_id = 2, Singer_id = 2, Datetime = new DateTime(2020, 05, 15), Album_Name = "�ӪŤH", Pic = "Spaceman.jpg", Price = 2020, Company = "UNI/���y", About = "2020.05.15 �ӪŤ�x�t�z��檺�ɶ��A�P�a�y�O���ɮt���C�b�m�ӪŤH�n���t�z�̡A�ڭ̤@�_�g���F�M��o��B��F�m�ӪųƧѰO�n�C���P�y�B�ݨ��m�ӪŤH�n�u�W�v�i�@�������p���N�~�몺���ֿ��v�a�A�]�g����p��ӹk�ۯ몺���i�w���B�¬}�Z�����ԧ�......�L�{�̡A�ڭ̴�����A�����ڭ̡A���ǥu�໻��ۡA���o�]�����֯���~��{�{�A�P���C�����y�\�q�|......�C�{�b�A�ڭ̦A�����B�@�������I�A���O���֪�����C" },
                 new Album { Album_id = 3, Singer_id = 3, Datetime = new DateTime(2020, 07, 10), Album_Name = "Outta body�F��X¬", Pic = "�G�lESO-�F��X¬.jpg", Price = 458, Company = "�u�۰ۤ�", About = "�G�lE.SO�q�x���X�D�ܤ��A���L��m���������־��{�]���ػy�����a���״I�h�����H���s�������H���Ǧ޺q��O���|�[��a�A�z�L���ְۥX�@�U���Ъ��j�p�ƭ��֬O�L�̪��ͩR���{�A���P�h�O�L�̪��F�P�ӷ����קA�{�Ѫ��O�mJust Believe�n���Ӧ]�ڷQ�Ӱ��j���L�٬O�m��o�n���`��I�R���������Ī��C�~ ; ��άO�m�a�l�n�̶D���ۧکl�צp�@�A�פQ���� �G�lE.SO�����׬O���Ө���A���ӥL�A�g�����몺�~��A�b�x���歸���Ѵ���L��ͩR���F��`���鮩���۪��������A�I�t�h�H�����ݡA2020 �G�lE.SO �N�a���j�a���s��������׻P���ַP���A�ŧi�j�a�ڪ����ܧY�O�ڪ����־��{�W���s�}�ݡA�b�o�ӷs���Q�~�A�L�N�a���j�a��h�s�[�I�A�󤣧Ѫ�ߪ��έ����ĭz��h����L���R��ĳ�D" },
                 new Album { Album_id = 4, Singer_id = 4, Datetime = new DateTime(2020, 06, 15), Album_Name = "�s�@��", Pic = "�ر�t-�s�@��.jpg", About = "�]�G���j�A�ͩR�����A���t�z�A�ۥX�ۧڥ��}�³W�h�A�}�зs�@�ɵػy�־·s�ͥN��x�ۧ@�H�ر�t�ĥ|�i���s�Ч@�M��A�s�@�ɢܢӢ� ��ݢ�ڢҧ�y���ַs�T�[�A�޻�جy�s�槽", Price = 668, Company = "SONY MUSIC" },
                 new Album { Album_id = 5, Singer_id = 5, Datetime = new DateTime(2019, 12, 11), Album_Name = "�Ѯ𤧤l", Pic = "RADWIMPS.jpg", Price = 1599, Company = "UNI(���y)" },
                 new Album { Album_id = 6, Singer_id = 6, Datetime = new DateTime(2019, 09, 06), Album_Name = "DELIGHT", Pic = "�B��-DELIGHT.jpg", Price = 509, Company = "SM ENTERTAINMENT" },
                 new Album { Album_id = 7, Singer_id = 7, Datetime = new DateTime(2020, 04, 07), Album_Name = "�y����W", Pic = "�������i-�y����W.jpg", About = "���ʷP�B�ɩ|�B���z��@���A�ۧ@�ѨΪ��M�I�t�[��k������y�C���qBBC�u2016�~�פ��n�v�BNME Awards�u�̨ηs�H�v�A�@���츯�ܬ��M���^���ּ����u�̨ηs�H�v�������A�A�����^�ۤѹ�Coldplay�B��ڥ��PBruno Mars�ɤߤ��w�A�������t�����w�Ż��I�ƤH�l�ySpotify�v�W�M���y�q�̦h���k�q��BYouTube���x�j�}10���I���q���̦~�����H�I", Price = 439, Company = "WARNER MUSIC" },
                 new Album { Album_id = 8, Singer_id = 8, Datetime = new DateTime(2020, 06, 03), Album_Name = "Chromatica (Standard Edtion)���m", Pic = "LADYGAGA.jpg", About = "�C�@�ӥ@�N���ݭn�@�����޻��y�B�A�Х@�N���e�äH���@�����СA������N�H�̱��P�X�f�P�l�`�ؼСF1960-70�~�N�u�j���j��David Bowie�v�۶����몺���X�ζH�B80-90�~�N�u�����RMadonna�v�N�k�ʥD�q���ɨ���y�Ҫ��F�i�J21�@���A���y�־³̨���ЩʤH���D�u�k���d�dLADY GAGA�v���ݡA�o���_�b���֡B�y��B���N�����a�ʭ���A�D�ɷ�N�̭��n���y���ưߤ@���P�C2020�~�ALADY GAGA�A���a�ۥ��s�@�~�^��־¡A�H�o�̾ժ����y��R���w�ƦA�Э��ַs���C", Price = 399, Company = "UNI(���y)" },
                 new Album { Album_id = 9, Singer_id = 9, Datetime = new DateTime(2020, 05, 15), Album_Name = "inK", Pic = "KEITA-inK.jpg", About = "w-inds.�D�� - ��y��KEITA���X�̹H4�~�B����14����m�֦�����3�i�ӤH�M��.w - inds.�̭t�d�D�ۡA�P�ɤ]���ݺq���s�@����y�ӡA�HSOLO PROJECT ��KEITA�����W�q�A�z�L�\�h���~�y�歵�֭n���A�è��첳�h���֤H�γЧ@�̪����`�CKEITA�H�����q����@���̹��ձ����h�˪��i��ʡA���X�̹H4�~����3�i�ӤH�M��C�M��minK�n���N��N��KEITA�ۧڥ����A����2019�~�Ʀ�o�檺12���q���~�A�t�~�l�[����2���s���qTokyo Night Fighter�r�B�qSomeday�r�C���i�M��KEITA���u�D�ԥ����֦����@���B�@�s���A�t�~�]�ѻP�F�V���Ϋ���B�z�A�O�@�i��KEITA���㥴�y���ӤH�M��C�x����^�LDVD�����g�����˪��s���qSomeday�r���s�@�L�{�A��40����������ᵶ�A�N�i�ݨ�KEITA�p�U�P�u�@�H���}�|�B����M��ʭ��H�Φb�����ǻs�@�֦����U�تᵶ�CDVD������r���C", Company = "���۰�ڦ������q", Price = 369 }
                 );

            context.Song.AddOrUpdate(x => x.Song_id,
                new Song { Song_id = 1, Album_id = 1, Song_name = "�����F" },
                new Song { Song_id = 2, Album_id = 1, Song_name = "�۬ݨ⤣��" },
                new Song { Song_id = 3, Album_id = 1, Song_name = "�g�H�^�a" },
                new Song { Song_id = 4, Album_id = 1, Song_name = "�ڭn�A�n�n��" },
                new Song { Song_id = 5, Album_id = 1, Song_name = "�ڴ��b�A�h�̩t�W" },
                new Song { Song_id = 6, Album_id = 1, Song_name = "�����" },
                new Song { Song_id = 7, Album_id = 1, Song_name = "�Q�~��" },
                new Song { Song_id = 8, Album_id = 1, Song_name = "�@�����U�h" },
                new Song { Song_id = 9, Album_id = 1, Song_name = "�b�t�z�y��" },
                new Song { Song_id = 10, Album_id = 1, Song_name = "����" },
                new Song { Song_id = 11, Album_id = 1, Song_name = "�����R�n" },
                new Song { Song_id = 12, Album_id = 2, Song_name = "Ķ�ھ�" },
                new Song { Song_id = 13, Album_id = 2, Song_name = "�^��������" },
                new Song { Song_id = 14, Album_id = 2, Song_name = "�ڧO��y��" },
                new Song { Song_id = 15, Album_id = 2, Song_name = "�ӪŤH" },
                new Song { Song_id = 16, Album_id = 2, Song_name = "�˭�" },
                new Song { Song_id = 17, Album_id = 2, Song_name = "������" },
                new Song { Song_id = 18, Album_id = 2, Song_name = "�Ӫ�" },
                new Song { Song_id = 19, Album_id = 2, Song_name = "���P�ᤧ��" },
                new Song { Song_id = 20, Album_id = 2, Song_name = "�k�Ĳ��P" },
                new Song { Song_id = 21, Album_id = 2, Song_name = "�ӪŲ�" },
                new Song { Song_id = 22, Album_id = 2, Song_name = "�u���O��" },
                new Song { Song_id = 23, Album_id = 2, Song_name = "Outsider" },
                new Song { Song_id = 24, Album_id = 3, Song_name = "Intro" },
                new Song { Song_id = 25, Album_id = 3, Song_name = "Don��t Worry About Me" },
                new Song { Song_id = 26, Album_id = 3, Song_name = "Follow You" },
                new Song { Song_id = 27, Album_id = 3, Song_name = "Hello Beautiful" },
                new Song { Song_id = 28, Album_id = 3, Song_name = "CHANGE" },
                new Song { Song_id = 29, Album_id = 3, Song_name = "���g�o����" },
                new Song { Song_id = 30, Album_id = 3, Song_name = "I Wish I Was There" },
                new Song { Song_id = 31, Album_id = 3, Song_name = "Money Bag" },
                new Song { Song_id = 32, Album_id = 3, Song_name = "So Good To Me" },
                new Song { Song_id = 33, Album_id = 3, Song_name = "Something I Don��t Need " },
                new Song { Song_id = 34, Album_id = 3, Song_name = "�o�S�b�ݧ�" },
                new Song { Song_id = 35, Album_id = 3, Song_name = "�B��" },
                new Song { Song_id = 36, Album_id = 3, Song_name = "Wait" },
                new Song { Song_id = 37, Album_id = 3, Song_name = "�B��" },
                new Song { Song_id = 38, Album_id = 3, Song_name = "�Ӷ�" },
                new Song { Song_id = 39, Album_id = 4, Song_name = "����" },
                new Song { Song_id = 40, Album_id = 4, Song_name = "�n�Q�R�o�ӥ@�ɰ�" },
                new Song { Song_id = 41, Album_id = 4, Song_name = "�ƤH�|" },
                new Song { Song_id = 42, Album_id = 4, Song_name = "�P���P���Ĥl���" },
                new Song { Song_id = 43, Album_id = 4, Song_name = "�C���H��" },
                new Song { Song_id = 44, Album_id = 4, Song_name = "����" },
                new Song { Song_id = 45, Album_id = 4, Song_name = "���{" },
                new Song { Song_id = 46, Album_id = 4, Song_name = "�s�@��" },
                new Song { Song_id = 47, Album_id = 5, Song_name = "����B�ϥX" },
                new Song { Song_id = 48, Album_id = 5, Song_name = "K&A��X��" },
                new Song { Song_id = 49, Album_id = 5, Song_name = "K&A�J����" },
                new Song { Song_id = 50, Album_id = 5, Song_name = "����j�|" },
                new Song { Song_id = 51, Album_id = 5, Song_name = "�����M��" },
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
                new Song { Song_id = 66, Album_id = 8, Song_name = "Chromatica I���mI" },
                new Song { Song_id = 67, Album_id = 8, Song_name = "Alice�����" },
                new Song { Song_id = 68, Album_id = 8, Song_name = "Stupid Loveèè���R" },
                new Song { Song_id = 69, Album_id = 8, Song_name = "Rain On Me���B���{ ft. Ariana Grande�Ȳ��w�R" },
                new Song { Song_id = 70, Album_id = 8, Song_name = "Free Woman�ۥD�k��" },
                new Song { Song_id = 71, Album_id = 8, Song_name = "Fun Tonight �w�֩]��" },
                new Song { Song_id = 72, Album_id = 8, Song_name = "Chromatica II ���mII" },
                new Song { Song_id = 73, Album_id = 8, Song_name = "911 �D��" },
                new Song { Song_id = 74, Album_id = 8, Song_name = "Plastic Doll�콦���J" },
                new Song { Song_id = 75, Album_id = 8, Song_name = "Sour Candy �Ŀ} ft. BLACKPINK" },
                new Song { Song_id = 76, Album_id = 8, Song_name = "Enigma �K�X" },
                new Song { Song_id = 77, Album_id = 8, Song_name = "Replay ����" },
                new Song { Song_id = 78, Album_id = 8, Song_name = "Chromatica III���mIII" },
                new Song { Song_id = 79, Album_id = 8, Song_name = "Sine From Above �ѤW���� ft. Elton John�㺸�y�j" },
                new Song { Song_id = 80, Album_id = 8, Song_name = "1000 Doves �d�F" },
                new Song { Song_id = 81, Album_id = 8, Song_name = "Babylon �ڤ��" },
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
                new Style { Style_id = 1, Style_type = "�y��", Album_id = 1 },
                new Style { Style_id = 2, Style_type = "��y", Album_id = 1 },
                new Style { Style_id = 3, Style_type = "CD", Album_id = 1 },
                new Style { Style_id = 4, Style_type = "�y��", Album_id = 2 },
                new Style { Style_id = 5, Style_type = "��y", Album_id = 2 },
                new Style { Style_id = 6, Style_type = "CD", Album_id = 2 },
                new Style { Style_id = 7, Style_type = "�y��", Album_id = 3 },
                new Style { Style_id = 8, Style_type = "��y", Album_id = 3 },
                new Style { Style_id = 9, Style_type = "CD", Album_id = 3 },
                new Style { Style_id = 10, Style_type = "�y��", Album_id = 4 },
                new Style { Style_id = 11, Style_type = "��y", Album_id = 4 },
                new Style { Style_id = 12, Style_type = "CD", Album_id = 4 },
                new Style { Style_id = 13, Style_type = "���", Album_id = 5 },
                new Style { Style_id = 14, Style_type = "CD", Album_id = 5 },
                new Style { Style_id = 15, Style_type = "Soundtrack", Album_id = 5 },
                new Style { Style_id = 16, Style_type = "�籡", Album_id = 5 },
                new Style { Style_id = 17, Style_type = "�y��", Album_id = 5 },
                new Style { Style_id = 18, Style_type = "����", Album_id = 6 },
                new Style { Style_id = 19, Style_type = "CD", Album_id = 6 },
                new Style { Style_id = 20, Style_type = "�y��", Album_id = 6 },
                new Style { Style_id = 21, Style_type = "�^��", Album_id = 7 },
                new Style { Style_id = 22, Style_type = "CD", Album_id = 7 },
                new Style { Style_id = 23, Style_type = "�y��", Album_id = 7 },
                new Style { Style_id = 24, Style_type = "�^��", Album_id = 8 },
                new Style { Style_id = 25, Style_type = "CD", Album_id = 8 },
                new Style { Style_id = 26, Style_type = "�y��", Album_id = 8 },
                new Style { Style_id = 27, Style_type = "���", Album_id = 9 },
                new Style { Style_id = 28, Style_type = "CD", Album_id = 9 },
                new Style { Style_id = 29, Style_type = "�籡", Album_id = 9 },
                new Style { Style_id = 30, Style_type = "�y��", Album_id = 9 }
                );

            context.Event.AddOrUpdate(x => x.Event_id,
                new Event { Event_id = 1, Name = "��ա�ChinaBlue 2020 RockStar�t�۷|-�x����", Singer_id = 10, Datetime = new DateTime(2021, 01, 23), Pic = "ChinaBlue_2020RockSta.jpg", Adress = "�x���꺡��~�@��", About = "�ٰO�o2018�~�u�x�W���w�z�n���t�۷|�v�P�j�a�@�_�b�꺡��~�@���j�X�۪��P�ʡA��� & China Blue ROCK STAR�j�����j�t�۷|�~2019�������A2020�Y�N�e�i�x���I��ջPChina Blue�N���s�}�ҧA��n�u�֪������P�{���C�����~�M�誺���ءA���A�s����զU�ɴ��j�x�e�ê��������ܡA�H�Υ�դ��ҥH�����n�u���P���֤ߤO�q�C" },
                new Event { Event_id = 2, Name = "ALAN WALKER 2020 LIVE IN TAIPEI", Singer_id = 11, Datetime = new DateTime(2020, 12, 09), Pic = "AlanWalker.jpg", Adress = "�s�_�j���|���驯�֤��y���", About = "�ʤjDJ��27�W�X �X���Ѥ~ALAN WALKER ���H�T�~�ש�ӥx�^�ꮿ�²V��DJ - Alan Walker(��� �P �U�J)�H�uFaded�v�@�����M���y�A�q���w���W�L26��Youtube�[�ݦ��ơC�N��4��18���s�_�j���|����A��q�g�����C�a�۸g��EDM�����uFaded�v�N�uAlone�v�N�uSing Me To Sleep�v�N�uDarkside�v�N�uThe Spectre�v���h���}���]�ʳ榱�A�N�L���A�ЩҦ��q���g��EDMťı�N��ı����A�a���U��M�ݪ��{���y�O�I" },
                new Event { Event_id = 3, Name = "ONE OK ROCK EYE OF THE STORM ASIA TOUR 2020 IN TAIWAN", Singer_id = 13, Datetime = new DateTime(2020, 011, 04), Pic = "ONEOKROCK .jpg", Adress = "�x�_�p���J", About = "ONE OK ROCK���ɱj�P�u��2020�~11��4��B6��B7�� �T�Ѻ��Q�x�_�p���J�I�饻�n�u�ѹ�ONE OK ROCK���Q�@�ɲĤG���}�ҡI�U�쯻���[�H2�~�������ߪ��̷s�u�ɭ����v�Ȭw���j�̲ׯ��N�b�x�W" },
                new Event { Event_id = 4, Name = "���̪L Ugly Beauty 2019-2020 �@�ɨ��j�t�۷| ������", Singer_id = 12, Datetime = new DateTime(2020, 09, 04), Pic = "UglyBeauty.jpeg", Adress = "�������J", About = "�x�_�����������������������U�ؤ��P��ߪ�Jolin�A�b�̲׳����������ѩ���߾_�ټu�ť��n�b5 / 9�B5 / 10��ѩ󰪶����J�A�[����t�X�A�D����S�O�ť������[���N��1 / 18����12:16�b�}�l�Ⲽ�I#�u���̪LUgly Beauty 2019-2020 �@�ɨ��j�t�۷| �������v2020/9/4 �A�[��#�q�g�`�N�IJolin�u�����T���v�H���Y���l�b�������ۻ{�I" },
                new Event { Event_id = 5, Name = "GREEN DAY LIVE IN TAIPEI 2021 �~������2021�x�_�t�۷|", Singer_id = 14, Datetime = new DateTime(2021, 03, 16), Pic = "GreenDay.jpg", Adress = "�x�_�p���J", About = "���ͤ��~�t�C�A�@�o���x33�~ �ש󵥨����j��è!�����e�J�Ф��~������ ���~3��۶i�p���J90�~�N���Щ��e�J�ֹ� ���y�ۤ��P�q�O7500�U���ܬ������׻{�� �W�C�n�u�W�H��" },
                new Event { Event_id = 6, Name = "2020 �w���s�q�o��|�m���ۮ��y�n", Singer_id = 15, Datetime = new DateTime(2021, 06, 27), Pic = "���ۮ��y.jpg", Adress = "�e���d��������Ӯi�t�]", About = "���ۡu���v���ֲ��v���¼�A�w���a�ۺ����a�m�����֡A�q�x�F�������y����F�x�_�C�C�Ѽ�I�b�ۤv���@�ɡA�r�֦a�g�ۺq�B�۵ۺq�A�������X�Y���Ӯ�A���B�͡A�ݬݳo���ۤv�u�⪺���֮��v�C�o�i �u���ۮ��y�v�M��A�O���ۦw�����߱��A�w��������A�w�����P���A�Φw���������C�o�q�ݩ�w�����G�ơA�Ʊ�M�A�̤��ɡA�]�Ʊ�u���ۮ��y�v������j�a�h��󻷪��a��C" }
                );

            context.News.AddOrUpdate(x => x.News_id,
                new News { News_id = 1, Singer_id = 16, About = "�����־����e�J�n�u�ֹ�BiSH�A�b5/21�ť��w�p�b�饻7�ӫ����|�쪺��WLive House���j�t�۷|�uBiSH'S GASP!!GOLD!!GHOST!!GALAXY!!GARBAGE!! TOUR�v�βĤ@���|�쪺�ֹι�M���j�t�۷|�uBiSH��S 5G are MAKiNG LOVE TOUR�v�A�����d�s�a�f�r�X�j�P�V�A�������t�����|��C�ثe�L�k�T�w������{�A���N���i�h����k�C", Pic = "BisH.jpg", News_title = "BiSH�ŧG���j���t�������� " },
                new News { News_id = 2, Singer_id = 17, About = "�u���֤j�����vJason Mraz �Ǵ˺��C���~2018�~�o��M��mKnow. ���o�R�n��A�̹H��~���X�s�@�~�qLook For The Good�r�A�P�W�s�M��]�w�p�N�b6��o��A�ĤJ���s���֭��檺�Ǵ˺��C���۷�ȱo���ݡI�Ǵ˺��C���P�x�W�t���`�p�A�L���|�רӥx�A�]�A���ܰѥ[�������P�����q���L�T�ǦX�ۡqI��m Yours�r�B�����ӥx�K���⪺�x�j��|�]�t�۷|�A�H�Ψ⦸��J�g��A�L���qI��m Yours�r�B�qLucky�r�������b�x�W�]���~�ǰۡA�i�H���O�x�W�̷R����v���q�Ѥ��C�Ǵ˦b�h�~�ӥx�ɡA��]����Ӧ۵دǭ��֥H�A�ͯȻP�^���l�޻s�@���h�ժ��ۤ��A�ӷP�ʦb���s�����W�g�U�u�x�W�ܤF�ѧڡv���r�y�A��F��x�W���߷R�C", Pic = "Jason Mraz.jpg", News_title = "�Ǵ˺��C���y���z�^�����}�Ǥ�H" },
                new News { News_id = 3, Singer_id = 18, About = "�쥻�w�w�N�b���멳�b�������ּ�(American Music Awards)�W���ܺt�X�A�åB�|�b��§�W�Q�¤��u��Q�~�̨����H(Artist of the Decade Award)�v�������y��ѦZ���ǵ��A����w�g�ǳƦn�b�{����§��Ѻt�X�o��Q�~�������榱��N�A�M�Ӯ��ǵ��o��M���쪾�W�g���HScooter Braun�Ϋe�ۤ����q����Scott Brochetta���q���A�b�o���~�Q�@��ۤv�����o�ǱM�誺�s�������e�A�N�T��o���}�t�X�o���±M�誺���ءA���D���ǵ��P�N�ߧY����s���s�±M�誺�p���A�åB�����~�򤽶}�ͽ�Scott Brochetta�H��Scooter Braun�C", Pic = "Taylor Swift.jpg", News_title = " Taylor Swift�������ּ��t�X�D�e�F�a���� �o���}�n���Y�µh���G�����Ч@���v�q" }

               );
        }
    }
}
