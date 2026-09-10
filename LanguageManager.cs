using System;
using System.Collections.Generic;
using System.Globalization;

namespace macOSClock
{
    /// <summary>
    /// 多语言管理器 - 支持20种语言
    /// </summary>
    public static class LanguageManager
    {
        public static event EventHandler? LanguageChanged;

        private static string _currentLang = "zh-CN";

        public static string CurrentLang
        {
            get => _currentLang;
            set
            {
                if (_currentLang != value)
                {
                    _currentLang = value;
                    LanguageChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// 支持的语言列表
        /// </summary>
        public static readonly Dictionary<string, string> Languages = new()
        {
            { "zh-CN", "简体中文" },
            { "zh-TW", "繁體中文" },
            { "en", "English" },
            { "ja", "日本語" },
            { "ko", "한국어" },
            { "fr", "Français" },
            { "de", "Deutsch" },
            { "es", "Español" },
            { "ru", "Русский" },
            { "ar", "العربية" },
            { "pt", "Português" },
            { "it", "Italiano" },
            { "th", "ไทย" },
            { "vi", "Tiếng Việt" },
            { "id", "Bahasa Indonesia" },
            { "tr", "Türkçe" },
            { "nl", "Nederlands" },
            { "pl", "Polski" },
            { "sv", "Svenska" }
        };

        /// <summary>
        /// 翻译字典
        /// </summary>
        private static readonly Dictionary<string, Dictionary<string, string>> Translations = new()
        {
            ["zh-CN"] = new()
            {
                { "title", "时钟" },
                { "language", "语言" },
                { "timezone", "时区" },
                { "darkMode", "深色" },
                { "lightMode", "浅色" },
                { "topmost", "置顶" },
                { "greeting_morning", "🌅 早上好" },
                { "greeting_noon", "☀️ 中午好" },
                { "greeting_afternoon", "☀️ 下午好" },
                { "greeting_evening", "🌇 傍晚好" },
                { "greeting_night", "🌙 晚上好" },
                { "dateFormat", "yyyy年M月d日 dddd" }
            },
            ["zh-TW"] = new()
            {
                { "title", "時鐘" },
                { "language", "語言" },
                { "timezone", "時區" },
                { "darkMode", "深色" },
                { "lightMode", "淺色" },
                { "topmost", "置頂" },
                { "greeting_morning", "🌅 早安" },
                { "greeting_noon", "☀️ 午安" },
                { "greeting_afternoon", "☀️ 下午好" },
                { "greeting_evening", "🌇 傍晚好" },
                { "greeting_night", "🌙 晚安" },
                { "dateFormat", "yyyy年M月d日 dddd" }
            },
            ["en"] = new()
            {
                { "title", "Clock" },
                { "language", "Language" },
                { "timezone", "Timezone" },
                { "darkMode", "Dark" },
                { "lightMode", "Light" },
                { "topmost", "Topmost" },
                { "greeting_morning", "🌅 Good Morning" },
                { "greeting_noon", "☀️ Good Noon" },
                { "greeting_afternoon", "☀️ Good Afternoon" },
                { "greeting_evening", "🌇 Good Evening" },
                { "greeting_night", "🌙 Good Night" },
                { "dateFormat", "dddd, MMMM d, yyyy" }
            },
            ["ja"] = new()
            {
                { "title", "時計" },
                { "language", "言語" },
                { "timezone", "タイムゾーン" },
                { "darkMode", "ダーク" },
                { "lightMode", "ライト" },
                { "topmost", "最前面" },
                { "greeting_morning", "🌅 おはようございます" },
                { "greeting_noon", "☀️ こんにちは" },
                { "greeting_afternoon", "☀️ こんにちは" },
                { "greeting_evening", "🌇 こんばんは" },
                { "greeting_night", "🌙 おやすみなさい" },
                { "dateFormat", "yyyy年M月d日 dddd" }
            },
            ["ko"] = new()
            {
                { "title", "시계" },
                { "language", "언어" },
                { "timezone", "시간대" },
                { "darkMode", "다크" },
                { "lightMode", "라이트" },
                { "topmost", "항상 위" },
                { "greeting_morning", "🌅 좋은 아침" },
                { "greeting_noon", "☀️ 좋은 점심" },
                { "greeting_afternoon", "☀️ 좋은 오후" },
                { "greeting_evening", "🌇 좋은 저녁" },
                { "greeting_night", "🌙 좋은 밤" },
                { "dateFormat", "yyyy년 M월 d일 dddd" }
            },
            ["fr"] = new()
            {
                { "title", "Horloge" },
                { "language", "Langue" },
                { "timezone", "Fuseau" },
                { "darkMode", "Sombre" },
                { "lightMode", "Clair" },
                { "topmost", "Épingler" },
                { "greeting_morning", "🌅 Bonjour" },
                { "greeting_noon", "☀️ Bon Midi" },
                { "greeting_afternoon", "☀️ Bon Après-midi" },
                { "greeting_evening", "🌇 Bonsoir" },
                { "greeting_night", "🌙 Bonne Nuit" },
                { "dateFormat", "dddd d MMMM yyyy" }
            },
            ["de"] = new()
            {
                { "title", "Uhr" },
                { "language", "Sprache" },
                { "timezone", "Zeitzone" },
                { "darkMode", "Dunkel" },
                { "lightMode", "Hell" },
                { "topmost", "Immer oben" },
                { "greeting_morning", "🌅 Guten Morgen" },
                { "greeting_noon", "☀️ Guten Mittag" },
                { "greeting_afternoon", "☀️ Guten Nachmittag" },
                { "greeting_evening", "🌇 Guten Abend" },
                { "greeting_night", "🌙 Gute Nacht" },
                { "dateFormat", "dddd, d. MMMM yyyy" }
            },
            ["es"] = new()
            {
                { "title", "Reloj" },
                { "language", "Idioma" },
                { "timezone", "Zona Horaria" },
                { "darkMode", "Oscuro" },
                { "lightMode", "Claro" },
                { "topmost", "Siempre arriba" },
                { "greeting_morning", "🌅 Buenos Días" },
                { "greeting_noon", "☀️ Buen Mediodía" },
                { "greeting_afternoon", "☀️ Buenas Tardes" },
                { "greeting_evening", "🌇 Buenas Noches" },
                { "greeting_night", "🌙 Buenas Noches" },
                { "dateFormat", "dddd, d 'de' MMMM 'de' yyyy" }
            },
            ["ru"] = new()
            {
                { "title", "Часы" },
                { "language", "Язык" },
                { "timezone", "Часовой пояс" },
                { "darkMode", "Тёмная" },
                { "lightMode", "Светлая" },
                { "topmost", "Поверх всех" },
                { "greeting_morning", "🌅 Доброе утро" },
                { "greeting_noon", "☀️ Добрый день" },
                { "greeting_afternoon", "☀️ Добрый день" },
                { "greeting_evening", "🌇 Добрый вечер" },
                { "greeting_night", "🌙 Спокойной ночи" },
                { "dateFormat", "dddd, d MMMM yyyy 'г.'" }
            },
            ["ar"] = new()
            {
                { "title", "الساعة" },
                { "language", "اللغة" },
                { "timezone", "المنطقة الزمنية" },
                { "darkMode", "داكن" },
                { "lightMode", "فاتح" },
                { "topmost", "دائمًا في الأعلى" },
                { "greeting_morning", "🌅 صباح الخير" },
                { "greeting_noon", "☀️ ظهر الخير" },
                { "greeting_afternoon", "☀️ مساء الخير" },
                { "greeting_evening", "🌇 مساء الخير" },
                { "greeting_night", "🌙 ليلة سعيدة" },
                { "dateFormat", "dddd، d MMMM yyyy" }
            },
            ["pt"] = new()
            {
                { "title", "Relógio" },
                { "language", "Idioma" },
                { "timezone", "Fuso Horário" },
                { "darkMode", "Escuro" },
                { "lightMode", "Claro" },
                { "topmost", "Sempre no topo" },
                { "greeting_morning", "🌅 Bom Dia" },
                { "greeting_noon", "☀️ Bom Meio-dia" },
                { "greeting_afternoon", "☀️ Boa Tarde" },
                { "greeting_evening", "🌇 Boa Noite" },
                { "greeting_night", "🌙 Boa Noite" },
                { "dateFormat", "dddd, d 'de' MMMM 'de' yyyy" }
            },
            ["it"] = new()
            {
                { "title", "Orologio" },
                { "language", "Lingua" },
                { "timezone", "Fuso Orario" },
                { "darkMode", "Scuro" },
                { "lightMode", "Chiaro" },
                { "topmost", "Sempre in primo piano" },
                { "greeting_morning", "🌅 Buongiorno" },
                { "greeting_noon", "☀️ Buon Mezzogiorno" },
                { "greeting_afternoon", "☀️ Buon Pomeriggio" },
                { "greeting_evening", "🌇 Buonasera" },
                { "greeting_night", "🌙 Buonanotte" },
                { "dateFormat", "dddd d MMMM yyyy" }
            },
            ["th"] = new()
            {
                { "title", "นาฬิกา" },
                { "language", "ภาษา" },
                { "timezone", "เขตเวลา" },
                { "darkMode", "มืด" },
                { "lightMode", "สว่าง" },
                { "topmost", "อยู่บนสุด" },
                { "greeting_morning", "🌅 สวัสดีตอนเช้า" },
                { "greeting_noon", "☀️ สวัสดีตอนเที่ยง" },
                { "greeting_afternoon", "☀️ สวัสดีตอนบ่าย" },
                { "greeting_evening", "🌇 สวัสดีตอนเย็น" },
                { "greeting_night", "🌇 ราตรีสวัสดิ์" },
                { "dateFormat", "dddd d MMMM yyyy" }
            },
            ["vi"] = new()
            {
                { "title", "Đồng Hồ" },
                { "language", "Ngôn ngữ" },
                { "timezone", "Múi giờ" },
                { "darkMode", "Tối" },
                { "lightMode", "Sáng" },
                { "topmost", "Luôn trên cùng" },
                { "greeting_morning", "🌅 Chào buổi sáng" },
                { "greeting_noon", "☀️ Chào buổi trưa" },
                { "greeting_afternoon", "☀️ Chào buổi chiều" },
                { "greeting_evening", "🌇 Chào buổi tối" },
                { "greeting_night", "🌙 Chúc ngủ ngon" },
                { "dateFormat", "dddd, d 'tháng' M 'năm' yyyy" }
            },
            ["id"] = new()
            {
                { "title", "Jam" },
                { "language", "Bahasa" },
                { "timezone", "Zona Waktu" },
                { "darkMode", "Gelap" },
                { "lightMode", "Terang" },
                { "topmost", "Selalu di atas" },
                { "greeting_morning", "🌅 Selamat Pagi" },
                { "greeting_noon", "☀️ Selamat Siang" },
                { "greeting_afternoon", "☀️ Selamat Sore" },
                { "greeting_evening", "🌇 Selamat Malam" },
                { "greeting_night", "🌙 Selamat Tidur" },
                { "dateFormat", "dddd, d MMMM yyyy" }
            },
            ["tr"] = new()
            {
                { "title", "Saat" },
                { "language", "Dil" },
                { "timezone", "Saat Dilimi" },
                { "darkMode", "Koyu" },
                { "lightMode", "Açık" },
                { "topmost", "Her zaman üstte" },
                { "greeting_morning", "🌅 Günaydın" },
                { "greeting_noon", "☀️ İyi öğlenler" },
                { "greeting_afternoon", "☀️ İyi günler" },
                { "greeting_evening", "🌇 İyi akşamlar" },
                { "greeting_night", "🌙 İyi geceler" },
                { "dateFormat", "dd MMMM yyyy dddd" }
            },
            ["nl"] = new()
            {
                { "title", "Klok" },
                { "language", "Taal" },
                { "timezone", "Tijdzone" },
                { "darkMode", "Donker" },
                { "lightMode", "Licht" },
                { "topmost", "Altijd bovenaan" },
                { "greeting_morning", "🌅 Goedemorgen" },
                { "greeting_noon", "☀️ Goedemiddag" },
                { "greeting_afternoon", "☀️ Goedemiddag" },
                { "greeting_evening", "🌇 Goedenavond" },
                { "greeting_night", "🌙 Goedenacht" },
                { "dateFormat", "dddd d MMMM yyyy" }
            },
            ["pl"] = new()
            {
                { "title", "Zegar" },
                { "language", "Język" },
                { "timezone", "Strefa czasowa" },
                { "darkMode", "Ciemny" },
                { "lightMode", "Jasny" },
                { "topmost", "Zawsze na wierzchu" },
                { "greeting_morning", "🌅 Dzień dobry" },
                { "greeting_noon", "☀️ Dzień dobry" },
                { "greeting_afternoon", "☀️ Dzień dobry" },
                { "greeting_evening", "🌇 Dobry wieczór" },
                { "greeting_night", "🌙 Dobranoc" },
                { "dateFormat", "dddd, d MMMM yyyy" }
            },
            ["sv"] = new()
            {
                { "title", "Klocka" },
                { "language", "Språk" },
                { "timezone", "Tidszon" },
                { "darkMode", "Mörk" },
                { "lightMode", "Ljus" },
                { "topmost", "Alltid överst" },
                { "greeting_morning", "🌅 God morgon" },
                { "greeting_noon", "☀️ God middag" },
                { "greeting_afternoon", "☀️ God eftermiddag" },
                { "greeting_evening", "🌇 God kväll" },
                { "greeting_night", "🌙 God natt" },
                { "dateFormat", "dddd d MMMM yyyy" }
            }
        };

        /// <summary>
        /// 获取翻译文本
        /// </summary>
        public static string Get(string key)
        {
            if (Translations.TryGetValue(_currentLang, out var langDict) &&
                langDict.TryGetValue(key, out var value))
            {
                return value;
            }
            // 回退到英文
            if (Translations.TryGetValue("en", out var enDict) &&
                enDict.TryGetValue(key, out var enValue))
            {
                return enValue;
            }
            return key;
        }

        /// <summary>
        /// 获取当前语言的 CultureInfo（用于日期格式化）
        /// </summary>
        public static CultureInfo GetCulture()
        {
            try
            {
                return CultureInfo.GetCultureInfo(_currentLang);
            }
            catch
            {
                return CultureInfo.InvariantCulture;
            }
        }

        /// <summary>
        /// 是否为RTL语言（阿拉伯语等）
        /// </summary>
        public static bool IsRTL => _currentLang == "ar";
    }
}
