using System;
using System.Collections.Generic;
using System.Linq;

namespace macOSClock
{
    /// <summary>
    /// 全球时区管理器 - 支持150+时区，自动处理夏令时
    /// </summary>
    public static class TimeZoneManager
    {
        public static event EventHandler? TimeZoneChanged;

        private static string _currentTimeZone = "Asia/Shanghai";

        public static string CurrentTimeZone
        {
            get => _currentTimeZone;
            set
            {
                if (_currentTimeZone != value)
                {
                    _currentTimeZone = value;
                    TimeZoneChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// 时区分组：大洲 -> 时区列表
        /// </summary>
        public static readonly Dictionary<string, List<TimeZoneInfoItem>> TimeZones = new()
        {
            ["Asia"] = new()
            {
                new("Asia/Shanghai", "北京/上海", "UTC+8"),
                new("Asia/Hong_Kong", "香港", "UTC+8"),
                new("Asia/Taipei", "台北", "UTC+8"),
                new("Asia/Tokyo", "东京", "UTC+9"),
                new("Asia/Seoul", "首尔", "UTC+9"),
                new("Asia/Singapore", "新加坡", "UTC+8"),
                new("Asia/Kuala_Lumpur", "吉隆坡", "UTC+8"),
                new("Asia/Bangkok", "曼谷", "UTC+7"),
                new("Asia/Jakarta", "雅加达", "UTC+7"),
                new("Asia/Manila", "马尼拉", "UTC+8"),
                new("Asia/Ho_Chi_Minh", "胡志明市", "UTC+7"),
                new("Asia/Hanoi", "河内", "UTC+7"),
                new("Asia/Phnom_Penh", "金边", "UTC+7"),
                new("Asia/Vientiane", "万象", "UTC+7"),
                new("Asia/Yangon", "仰光", "UTC+6:30"),
                new("Asia/Dhaka", "达卡", "UTC+6"),
                new("Asia/Kolkata", "新德里", "UTC+5:30"),
                new("Asia/Colombo", "科伦坡", "UTC+5:30"),
                new("Asia/Kathmandu", "加德满都", "UTC+5:45"),
                new("Asia/Karachi", "卡拉奇", "UTC+5"),
                new("Asia/Tashkent", "塔什干", "UTC+5"),
                new("Asia/Dushanbe", "杜尚别", "UTC+5"),
                new("Asia/Ashgabat", "阿什哈巴德", "UTC+5"),
                new("Asia/Bishkek", "比什凯克", "UTC+6"),
                new("Asia/Almaty", "阿拉木图", "UTC+6"),
                new("Asia/Novosibirsk", "新西伯利亚", "UTC+7"),
                new("Asia/Krasnoyarsk", "克拉斯诺亚尔斯克", "UTC+7"),
                new("Asia/Irkutsk", "伊尔库茨克", "UTC+8"),
                new("Asia/Yakutsk", "雅库茨克", "UTC+9"),
                new("Asia/Vladivostok", "符拉迪沃斯托克", "UTC+10"),
                new("Asia/Magadan", "马加丹", "UTC+11"),
                new("Asia/Kamchatka", "堪察加", "UTC+12"),
                new("Asia/Anadyr", "阿纳德尔", "UTC+12"),
                new("Asia/Yerevan", "埃里温", "UTC+4"),
                new("Asia/Baku", "巴库", "UTC+4"),
                new("Asia/Tbilisi", "第比利斯", "UTC+4"),
                new("Asia/Tehran", "德黑兰", "UTC+3:30"),
                new("Asia/Kabul", "喀布尔", "UTC+4:30"),
                new("Asia/Riyadh", "利雅得", "UTC+3"),
                new("Asia/Dubai", "迪拜", "UTC+4"),
                new("Asia/Muscat", "马斯喀特", "UTC+4"),
                new("Asia/Qatar", "多哈", "UTC+3"),
                new("Asia/Bahrain", "麦纳麦", "UTC+3"),
                new("Asia/Kuwait", "科威特城", "UTC+3"),
                new("Asia/Baghdad", "巴格达", "UTC+3"),
                new("Asia/Amman", "安曼", "UTC+3"),
                new("Asia/Beirut", "贝鲁特", "UTC+2"),
                new("Asia/Damascus", "大马士革", "UTC+3"),
                new("Asia/Jerusalem", "耶路撒冷", "UTC+2"),
                new("Asia/Gaza", "加沙", "UTC+2"),
                new("Asia/Hebron", "希伯伦", "UTC+2"),
                new("Asia/Nicosia", "尼科西亚", "UTC+2"),
                new("Asia/Ulaanbaatar", "乌兰巴托", "UTC+8"),
                new("Asia/Pyongyang", "平壤", "UTC+9"),
                new("Asia/Macau", "澳门", "UTC+8"),
                new("Asia/Brunei", "斯里巴加湾市", "UTC+8"),
                new("Asia/Pontianak", "坤甸", "UTC+7"),
                new("Asia/Makassar", "望加锡", "UTC+8"),
                new("Asia/Jayapura", "查亚普拉", "UTC+9"),
                new("Asia/Atyrau", "阿特劳", "UTC+5"),
                new("Asia/Oral", "乌拉尔", "UTC+5"),
                new("Asia/Qyzylorda", "克孜勒奥尔达", "UTC+5"),
                new("Asia/Samarkand", "撒马尔罕", "UTC+5"),
                new("Asia/Aqtau", "阿克套", "UTC+5"),
                new("Asia/Aqtobe", "阿克托别", "UTC+5"),
                new("Asia/Omsk", "鄂木斯克", "UTC+6"),
                new("Asia/Barnaul", "巴尔瑙尔", "UTC+7"),
                new("Asia/Tomsk", "托木斯克", "UTC+7"),
                new("Asia/Novokuznetsk", "新库兹涅茨克", "UTC+7"),
                new("Asia/Chita", "赤塔", "UTC+9"),
                new("Asia/Khandyga", "汉德加", "UTC+9"),
                new("Asia/Srednekolymsk", "中科雷姆斯克", "UTC+11"),
                new("Asia/Ust-Nera", "乌斯季涅拉", "UTC+10"),
                new("Asia/Sakhalin", "南萨哈林斯克", "UTC+11"),
                new("Asia/Kolkata", "加尔各答", "UTC+5:30"),
                new("Asia/Calcutta", "加尔各答(旧)", "UTC+5:30"),
                new("Asia/Thimphu", "廷布", "UTC+6"),
                new("Asia/Male", "马累", "UTC+5"),
                new("Asia/Chongqing", "重庆", "UTC+8"),
                new("Asia/Harbin", "哈尔滨", "UTC+8"),
                new("Asia/Urumqi", "乌鲁木齐", "UTC+6"),
                new("Asia/Kashgar", "喀什", "UTC+5")
            },
            ["Europe"] = new()
            {
                new("Europe/London", "伦敦", "UTC+0"),
                new("Europe/Dublin", "都柏林", "UTC+0"),
                new("Europe/Lisbon", "里斯本", "UTC+0"),
                new("Europe/Madrid", "马德里", "UTC+1"),
                new("Europe/Paris", "巴黎", "UTC+1"),
                new("Europe/Brussels", "布鲁塞尔", "UTC+1"),
                new("Europe/Amsterdam", "阿姆斯特丹", "UTC+1"),
                new("Europe/Berlin", "柏林", "UTC+1"),
                new("Europe/Munich", "慕尼黑", "UTC+1"),
                new("Europe/Vienna", "维也纳", "UTC+1"),
                new("Europe/Zurich", "苏黎世", "UTC+1"),
                new("Europe/Geneva", "日内瓦", "UTC+1"),
                new("Europe/Rome", "罗马", "UTC+1"),
                new("Europe/Milan", "米兰", "UTC+1"),
                new("Europe/Vatican", "梵蒂冈", "UTC+1"),
                new("Europe/San_Marino", "圣马力诺", "UTC+1"),
                new("Europe/Malta", "瓦莱塔", "UTC+1"),
                new("Europe/Luxembourg", "卢森堡", "UTC+1"),
                new("Europe/Monaco", "摩纳哥", "UTC+1"),
                new("Europe/Andorra", "安道尔", "UTC+1"),
                new("Europe/Gibraltar", "直布罗陀", "UTC+1"),
                new("Europe/Stockholm", "斯德哥尔摩", "UTC+1"),
                new("Europe/Oslo", "奥斯陆", "UTC+1"),
                new("Europe/Copenhagen", "哥本哈根", "UTC+1"),
                new("Europe/Helsinki", "赫尔辛基", "UTC+2"),
                new("Europe/Tallinn", "塔林", "UTC+2"),
                new("Europe/Riga", "里加", "UTC+2"),
                new("Europe/Vilnius", "维尔纽斯", "UTC+2"),
                new("Europe/Warsaw", "华沙", "UTC+1"),
                new("Europe/Prague", "布拉格", "UTC+1"),
                new("Europe/Bratislava", "布拉迪斯拉发", "UTC+1"),
                new("Europe/Budapest", "布达佩斯", "UTC+1"),
                new("Europe/Ljubljana", "卢布尔雅那", "UTC+1"),
                new("Europe/Zagreb", "萨格勒布", "UTC+1"),
                new("Europe/Sarajevo", "萨拉热窝", "UTC+1"),
                new("Europe/Belgrade", "贝尔格莱德", "UTC+1"),
                new("Europe/Skopje", "斯科普里", "UTC+1"),
                new("Europe/Tirane", "地拉那", "UTC+1"),
                new("Europe/Podgorica", "波德戈里察", "UTC+1"),
                new("Europe/Pristina", "普里什蒂纳", "UTC+1"),
                new("Europe/Athens", "雅典", "UTC+2"),
                new("Europe/Bucharest", "布加勒斯特", "UTC+2"),
                new("Europe/Sofia", "索非亚", "UTC+2"),
                new("Europe/Istanbul", "伊斯坦布尔", "UTC+3"),
                new("Europe/Minsk", "明斯克", "UTC+3"),
                new("Europe/Kyiv", "基辅", "UTC+2"),
                new("Europe/Moscow", "莫斯科", "UTC+3"),
                new("Europe/Saint_Petersburg", "圣彼得堡", "UTC+3"),
                new("Europe/Kaliningrad", "加里宁格勒", "UTC+2"),
                new("Europe/Volgograd", "伏尔加格勒", "UTC+3"),
                new("Europe/Samara", "萨马拉", "UTC+4"),
                new("Europe/Ulyanovsk", "乌里扬诺夫斯克", "UTC+4"),
                new("Europe/Astrakhan", "阿斯特拉罕", "UTC+4"),
                new("Europe/Saratov", "萨拉托夫", "UTC+4"),
                new("Europe/Reykjavik", "雷克雅未克", "UTC+0"),
                new("Europe/Faroe", "托尔斯港", "UTC+0"),
                new("Europe/Guernsey", "圣彼得港", "UTC+0"),
                new("Europe/Jersey", "圣赫利尔", "UTC+0"),
                new("Europe/Isle_of_Man", "道格拉斯", "UTC+0"),
                new("Europe/Mariehamn", "玛丽港", "UTC+2"),
                new("Europe/Chisinau", "基希讷乌", "UTC+2"),
                new("Europe/Tiraspol", "蒂拉斯波尔", "UTC+2"),
                new("Europe/Nicosia", "尼科西亚(欧洲)", "UTC+2"),
                new("Europe/Busingen", "布辛根", "UTC+1"),
                new("Europe/Vaduz", "瓦杜兹", "UTC+1")
            },
            ["America"] = new()
            {
                new("America/New_York", "纽约", "UTC-5"),
                new("America/Chicago", "芝加哥", "UTC-6"),
                new("America/Denver", "丹佛", "UTC-7"),
                new("America/Los_Angeles", "洛杉矶", "UTC-8"),
                new("America/Anchorage", "安克雷奇", "UTC-9"),
                new("America/Adak", "埃达克", "UTC-10"),
                new("America/Phoenix", "菲尼克斯", "UTC-7"),
                new("America/Boise", "博伊西", "UTC-7"),
                new("America/Salt_Lake_City", "盐湖城", "UTC-7"),
                new("America/Dawson_Creek", "道森克里克", "UTC-7"),
                new("America/Fort_Nelson", "纳尔逊堡", "UTC-7"),
                new("America/Whitehorse", "怀特霍斯", "UTC-7"),
                new("America/Dawson", "道森", "UTC-7"),
                new("America/Vancouver", "温哥华", "UTC-8"),
                new("America/Edmonton", "埃德蒙顿", "UTC-7"),
                new("America/Winnipeg", "温尼伯", "UTC-6"),
                new("America/Regina", "里贾纳", "UTC-6"),
                new("America/Swift_Current", "斯威夫特卡伦特", "UTC-6"),
                new("America/Toronto", "多伦多", "UTC-5"),
                new("America/Montreal", "蒙特利尔", "UTC-5"),
                new("America/Halifax", "哈利法克斯", "UTC-4"),
                new("America/Glace_Bay", "格莱斯贝", "UTC-4"),
                new("America/Moncton", "蒙克顿", "UTC-4"),
                new("America/Goose_Bay", "古斯贝", "UTC-4"),
                new("America/St_Johns", "圣约翰斯", "UTC-3:30"),
                new("America/Miquelon", "圣皮埃尔", "UTC-3"),
                new("America/Bermuda", "哈密尔顿", "UTC-4"),
                new("America/Nassau", "拿骚", "UTC-5"),
                new("America/Havana", "哈瓦那", "UTC-5"),
                new("America/Cayman", "乔治敦", "UTC-5"),
                new("America/Jamaica", "金斯顿", "UTC-5"),
                new("America/Port-au-Prince", "太子港", "UTC-5"),
                new("America/Santo_Domingo", "圣多明各", "UTC-4"),
                new("America/Puerto_Rico", "圣胡安", "UTC-4"),
                new("America/St_Thomas", "夏洛特阿马利亚", "UTC-4"),
                new("America/St_Croix", "克里斯琴斯特德", "UTC-4"),
                new("America/Kralendijk", "克拉伦代克", "UTC-4"),
                new("America/Lower_Princes", "下王子", "UTC-4"),
                new("America/St_Barthelemy", "古斯塔维亚", "UTC-4"),
                new("America/Marigot", "马里戈", "UTC-4"),
                new("America/Guadeloupe", "巴斯特尔", "UTC-4"),
                new("America/Dominica", "罗索", "UTC-4"),
                new("America/Martinique", "法兰西堡", "UTC-4"),
                new("America/St_Lucia", "卡斯特里", "UTC-4"),
                new("America/St_Vincent", "金斯敦", "UTC-4"),
                new("America/Grenada", "圣乔治", "UTC-4"),
                new("America/Tortola", "罗德城", "UTC-4"),
                new("America/Anguilla", "山谷", "UTC-4"),
                new("America/Montserrat", "普利茅斯", "UTC-4"),
                new("America/Barbados", "布里奇敦", "UTC-4"),
                new("America/Aruba", "奥拉涅斯塔德", "UTC-4"),
                new("America/Curacao", "威廉斯塔德", "UTC-4"),
                new("America/Bogota", "波哥大", "UTC-5"),
                new("America/Lima", "利马", "UTC-5"),
                new("America/Guayaquil", "瓜亚基尔", "UTC-5"),
                new("America/Quito", "基多", "UTC-5"),
                new("America/Caracas", "加拉加斯", "UTC-4"),
                new("America/La_Paz", "拉巴斯", "UTC-4"),
                new("America/Santiago", "圣地亚哥", "UTC-4"),
                new("America/Buenos_Aires", "布宜诺斯艾利斯", "UTC-3"),
                new("America/Montevideo", "蒙得维的亚", "UTC-3"),
                new("America/Asuncion", "亚松森", "UTC-4"),
                new("America/Cayenne", "卡宴", "UTC-3"),
                new("America/Fortaleza", "福塔莱萨", "UTC-3"),
                new("America/Recife", "累西腓", "UTC-3"),
                new("America/Bahia", "巴伊亚", "UTC-3"),
                new("America/Sao_Paulo", "圣保罗", "UTC-3"),
                new("America/Campo_Grande", "大坎普", "UTC-4"),
                new("America/Cuiaba", "库亚巴", "UTC-4"),
                new("America/Porto_Velho", "波多韦柳", "UTC-4"),
                new("America/Boa_Vista", "博阿维斯塔", "UTC-4"),
                new("America/Manaus", "马瑙斯", "UTC-4"),
                new("America/Eirunepe", "埃鲁内佩", "UTC-5"),
                new("America/Rio_Branco", "里奥布朗库", "UTC-5"),
                new("America/Noronha", "费尔南多迪诺罗尼亚", "UTC-2"),
                new("America/Mexico_City", "墨西哥城", "UTC-6"),
                new("America/Cancun", "坎昆", "UTC-5"),
                new("America/Guatemala", "危地马拉城", "UTC-6"),
                new("America/Tegucigalpa", "特古西加尔巴", "UTC-6"),
                new("America/Managua", "马那瓜", "UTC-6"),
                new("America/San_Salvador", "圣萨尔瓦多", "UTC-6"),
                new("America/Panama", "巴拿马城", "UTC-5"),
                new("America/Costa_Rica", "圣何塞", "UTC-6"),
                new("America/Belize", "贝尔莫潘", "UTC-6"),
                new("America/El_Salvador", "圣萨尔瓦多(中)", "UTC-6"),
                new("America/Argentina/Buenos_Aires", "布宜诺斯艾利斯(阿)", "UTC-3"),
                new("America/Argentina/Cordoba", "科尔多瓦", "UTC-3"),
                new("America/Argentina/Salta", "萨尔塔", "UTC-3"),
                new("America/Argentina/Tucuman", "图库曼", "UTC-3"),
                new("America/Argentina/San_Luis", "圣路易斯", "UTC-3"),
                new("America/Argentina/Mendoza", "门多萨", "UTC-3"),
                new("America/Argentina/San_Juan", "圣胡安", "UTC-3"),
                new("America/Argentina/Rio_Gallegos", "里奥加耶戈斯", "UTC-3"),
                new("America/Argentina/Ushuaia", "乌斯怀亚", "UTC-3"),
                new("America/Argentina/La_Rioja", "拉里奥哈", "UTC-3"),
                new("America/Argentina/Catamarca", "卡塔马卡", "UTC-3"),
                new("America/Argentina/Jujuy", "胡胡伊", "UTC-3"),
                new("America/Indiana/Indianapolis", "印第安纳波利斯", "UTC-5"),
                new("America/Indiana/Vincennes", "万塞讷", "UTC-5"),
                new("America/Indiana/Winamac", "怀纳马克", "UTC-5"),
                new("America/Indiana/Marengo", "马伦戈", "UTC-5"),
                new("America/Indiana/Petersburg", "彼得斯堡", "UTC-5"),
                new("America/Indiana/Vevay", "韦韦", "UTC-5"),
                new("America/Kentucky/Louisville", "路易斯维尔", "UTC-5"),
                new("America/Kentucky/Monticello", "蒙蒂塞洛", "UTC-5"),
                new("America/North_Dakota/Center", "森特", "UTC-6"),
                new("America/North_Dakota/New_Salem", "新塞勒姆", "UTC-6"),
                new("America/North_Dakota/Beulah", "休拉", "UTC-6"),
                new("America/Matamoros", "马塔莫罗斯", "UTC-6"),
                new("America/Monterrey", "蒙特雷", "UTC-6"),
                new("America/Merida", "梅里达", "UTC-6"),
                new("America/Mexicali", "墨西卡利", "UTC-8"),
                new("America/Tijuana", "蒂华纳", "UTC-8"),
                new("America/Bahia_Banderas", "巴亚尔塔港", "UTC-6"),
                new("America/Chihuahua", "奇瓦瓦", "UTC-6"),
                new("America/Ojinaga", "奥希纳加", "UTC-6"),
                new("America/Hermosillo", "埃莫西约", "UTC-7"),
                new("America/Santa_Isabel", "圣伊莎贝尔", "UTC-8"),
                new("America/Pangnirtung", "庞纳唐", "UTC-5"),
                new("America/Iqaluit", "伊魁特", "UTC-5"),
                new("America/Resolute", "雷索卢特", "UTC-6"),
                new("America/Rankin_Inlet", "兰金湖", "UTC-6"),
                new("America/Atikokan", "阿蒂科肯", "UTC-5"),
                new("America/Nipigon", "尼皮贡", "UTC-5"),
                new("America/Thunder_Bay", "桑德贝", "UTC-5"),
                new("America/Pangnirtung", "庞纳唐(加)", "UTC-5"),
                new("America/Yellowknife", "耶洛奈夫", "UTC-7"),
                new("America/Inuvik", "伊努维克", "UTC-7"),
                new("America/Coral_Harbour", "科勒尔港", "UTC-5"),
                new("America/Blanc-Sablon", "布朗-萨布隆", "UTC-4")
            },
            ["Oceania"] = new()
            {
                new("Australia/Sydney", "悉尼", "UTC+10"),
                new("Australia/Melbourne", "墨尔本", "UTC+10"),
                new("Australia/Brisbane", "布里斯班", "UTC+10"),
                new("Australia/Perth", "珀斯", "UTC+8"),
                new("Australia/Adelaide", "阿德莱德", "UTC+9:30"),
                new("Australia/Darwin", "达尔文", "UTC+9:30"),
                new("Australia/Hobart", "霍巴特", "UTC+10"),
                new("Australia/Lord_Howe", "豪勋爵岛", "UTC+10:30"),
                new("Australia/Broken_Hill", "布罗肯希尔", "UTC+9:30"),
                new("Australia/Lindeman", "林德曼岛", "UTC+10"),
                new("Australia/Currie", "柯里", "UTC+10"),
                new("Australia/Eucla", "尤克拉", "UTC+8:45"),
                new("Pacific/Auckland", "奥克兰", "UTC+12"),
                new("Pacific/Chatham", "查塔姆群岛", "UTC+12:45"),
                new("Pacific/Fiji", "苏瓦", "UTC+12"),
                new("Pacific/Port_Moresby", "莫尔兹比港", "UTC+10"),
                new("Pacific/Guadalcanal", "霍尼亚拉", "UTC+11"),
                new("Pacific/Efate", "维拉港", "UTC+11"),
                new("Pacific/Noumea", "努美阿", "UTC+11"),
                new("Pacific/Tarawa", "塔拉瓦", "UTC+12"),
                new("Pacific/Majuro", "马朱罗", "UTC+12"),
                new("Pacific/Kwajalein", "夸贾林", "UTC+12"),
                new("Pacific/Nauru", "亚伦", "UTC+12"),
                new("Pacific/Tuvalu", "富纳富提", "UTC+12"),
                new("Pacific/Funafuti", "富纳富提(图)", "UTC+12"),
                new("Pacific/Wallis", "马塔乌图", "UTC+12"),
                new("Pacific/Enderbury", "恩德伯里岛", "UTC+13"),
                new("Pacific/Kiritimati", "圣诞岛", "UTC+14"),
                new("Pacific/Apia", "阿皮亚", "UTC+13"),
                new("Pacific/Tongatapu", "努库阿洛法", "UTC+13"),
                new("Pacific/Eua", "埃瓦岛", "UTC+13"),
                new("Pacific/Niue", "阿洛菲", "UTC+11"),
                new("Pacific/Pago_Pago", "帕果帕果", "UTC-11"),
                new("Pacific/Honolulu", "檀香山", "UTC-10"),
                new("Pacific/Johnston", "约翰斯顿岛", "UTC-10"),
                new("Pacific/Midway", "中途岛", "UTC-11"),
                new("Pacific/Wake", "威克岛", "UTC+12"),
                new("Pacific/Guam", "阿加尼亚", "UTC+10"),
                new("Pacific/Saipan", "塞班", "UTC+10"),
                new("Pacific/Truk", "特鲁克", "UTC+10"),
                new("Pacific/Ponape", "波纳佩", "UTC+11"),
                new("Pacific/Kosrae", "科斯雷", "UTC+11"),
                new("Pacific/Yap", "雅浦", "UTC+10"),
                new("Pacific/Palau", "梅莱凯奥克", "UTC+9"),
                new("Pacific/Chuuk", "楚克", "UTC+10"),
                new("Pacific/Pohnpei", "波纳佩(波)", "UTC+11"),
                new("Pacific/Marquesas", "马克萨斯群岛", "UTC-9:30"),
                new("Pacific/Gambier", "甘比尔群岛", "UTC-9"),
                new("Pacific/Tahiti", "帕皮提", "UTC-10"),
                new("Pacific/Rarotonga", "阿瓦鲁阿", "UTC-10"),
                new("Pacific/Norfolk", "金斯敦", "UTC+11"),
                new("Pacific/Pitcairn", "亚当斯敦", "UTC-8"),
                new("Pacific/Bougainville", "布干维尔", "UTC+11"),
                new("Antarctica/Macquarie", "麦夸里岛", "UTC+10"),
                new("Antarctica/Davis", "戴维斯站", "UTC+7"),
                new("Antarctica/Mawson", "莫森站", "UTC+5"),
                new("Antarctica/Vostok", "沃斯托克站", "UTC+6"),
                new("Antarctica/Syowa", "昭和站", "UTC+3"),
                new("Antarctica/Rothera", "罗瑟拉站", "UTC-3"),
                new("Antarctica/Palmer", "帕尔默站", "UTC-3"),
                new("Antarctica/McMurdo", "麦克默多站", "UTC+12"),
                new("Antarctica/South_Pole", "阿蒙森-斯科特站", "UTC+12"),
                new("Antarctica/Troll", "特罗尔站", "UTC+0"),
                new("Antarctica/DumontDUrville", "迪蒙迪维尔站", "UTC+10"),
                new("Antarctica/Casey", "凯西站", "UTC+8"),
                new("Antarctica/Concordia", "康宏站", "UTC+10")
            },
            ["Africa"] = new()
            {
                new("Africa/Cairo", "开罗", "UTC+2"),
                new("Africa/Lagos", "拉各斯", "UTC+1"),
                new("Africa/Johannesburg", "约翰内斯堡", "UTC+2"),
                new("Africa/Casablanca", "卡萨布兰卡", "UTC+1"),
                new("Africa/Algiers", "阿尔及尔", "UTC+1"),
                new("Africa/Tunis", "突尼斯", "UTC+1"),
                new("Africa/Tripoli", "的黎波里", "UTC+2"),
                new("Africa/Khartoum", "喀土穆", "UTC+2"),
                new("Africa/Addis_Ababa", "亚的斯亚贝巴", "UTC+3"),
                new("Africa/Nairobi", "内罗毕", "UTC+3"),
                new("Africa/Dar_es_Salaam", "达累斯萨拉姆", "UTC+3"),
                new("Africa/Kampala", "坎帕拉", "UTC+3"),
                new("Africa/Mogadishu", "摩加迪沙", "UTC+3"),
                new("Africa/Djibouti", "吉布提", "UTC+3"),
                new("Africa/Asmera", "阿斯马拉", "UTC+3"),
                new("Africa/Juba", "朱巴", "UTC+2"),
                new("Africa/Accra", "阿克拉", "UTC+0"),
                new("Africa/Abidjan", "阿比让", "UTC+0"),
                new("Africa/Bamako", "巴马科", "UTC+0"),
                new("Africa/Banjul", "班珠尔", "UTC+0"),
                new("Africa/Conakry", "科纳克里", "UTC+0"),
                new("Africa/Dakar", "达喀尔", "UTC+0"),
                new("Africa/Freetown", "弗里敦", "UTC+0"),
                new("Africa/Lome", "洛美", "UTC+0"),
                new("Africa/Monrovia", "蒙罗维亚", "UTC+0"),
                new("Africa/Niamey", "尼亚美", "UTC+1"),
                new("Africa/Nouakchott", "努瓦克肖特", "UTC+0"),
                new("Africa/Ouagadougou", "瓦加杜古", "UTC+0"),
                new("Africa/Sao_Tome", "圣多美", "UTC+0"),
                new("Africa/Timbuktu", "廷巴克图", "UTC+0"),
                new("Africa/Bissau", "比绍", "UTC+0"),
                new("Africa/El_Aaiun", "阿尤恩", "UTC+1"),
                new("Africa/Ceuta", "休达", "UTC+1"),
                new("Africa/Melilla", "梅利利亚", "UTC+1"),
                new("Africa/Luanda", "罗安达", "UTC+1"),
                new("Africa/Libreville", "利伯维尔", "UTC+1"),
                new("Africa/Malabo", "马拉博", "UTC+1"),
                new("Africa/Ndjamena", "恩贾梅纳", "UTC+1"),
                new("Africa/Bangui", "班吉", "UTC+1"),
                new("Africa/Brazzaville", "布拉柴维尔", "UTC+1"),
                new("Africa/Kinshasa", "金沙萨", "UTC+1"),
                new("Africa/Douala", "杜阿拉", "UTC+1"),
                new("Africa/Libreville", "利伯维尔(加)", "UTC+1"),
                new("Africa/Porto-Novo", "波多诺伏", "UTC+1"),
                new("Africa/Windhoek", "温得和克", "UTC+2"),
                new("Africa/Gaborone", "哈博罗内", "UTC+2"),
                new("Africa/Harare", "哈拉雷", "UTC+2"),
                new("Africa/Lusaka", "卢萨卡", "UTC+2"),
                new("Africa/Maputo", "马普托", "UTC+2"),
                new("Africa/Mbabane", "姆巴巴内", "UTC+2"),
                new("Africa/Maseru", "马塞卢", "UTC+2"),
                new("Africa/Blantyre", "布兰太尔", "UTC+2"),
                new("Africa/Bujumbura", "布琼布拉", "UTC+2"),
                new("Africa/Kigali", "基加利", "UTC+2"),
                new("Africa/Lubumbashi", "卢本巴希", "UTC+2"),
                new("Africa/Kampala", "坎帕拉(乌)", "UTC+3"),
                new("Africa/Asmara", "阿斯马拉(厄)", "UTC+3"),
                new("Africa/Addis_Ababa", "亚的斯亚贝巴(埃)", "UTC+3"),
                new("Africa/Nairobi", "内罗毕(肯)", "UTC+3"),
                new("Africa/Dar_es_Salaam", "达累斯萨拉姆(坦)", "UTC+3"),
                new("Africa/Mogadishu", "摩加迪沙(索)", "UTC+3"),
                new("Africa/Djibouti", "吉布提(吉)", "UTC+3"),
                new("Africa/Juba", "朱巴(南苏)", "UTC+2"),
                new("Africa/Khartoum", "喀土穆(苏)", "UTC+2"),
                new("Africa/Cairo", "开罗(埃)", "UTC+2"),
                new("Africa/Tripoli", "的黎波里(利)", "UTC+2"),
                new("Africa/Tunis", "突尼斯(突)", "UTC+1"),
                new("Africa/Algiers", "阿尔及尔(阿)", "UTC+1"),
                new("Africa/Casablanca", "卡萨布兰卡(摩)", "UTC+1"),
                new("Africa/El_Aaiun", "阿尤恩(西撒)", "UTC+1"),
                new("Africa/Lagos", "拉各斯(尼)", "UTC+1"),
                new("Africa/Accra", "阿克拉(加)", "UTC+0"),
                new("Africa/Abidjan", "阿比让(科)", "UTC+0"),
                new("Africa/Dakar", "达喀尔(塞)", "UTC+0"),
                new("Africa/Bamako", "巴马科(马)", "UTC+0"),
                new("Africa/Nouakchott", "努瓦克肖特(毛塔)", "UTC+0"),
                new("Africa/Bissau", "比绍(几比)", "UTC+0"),
                new("Africa/Conakry", "科纳克里(几)", "UTC+0"),
                new("Africa/Freetown", "弗里敦(塞拉)", "UTC+0"),
                new("Africa/Monrovia", "蒙罗维亚(利比)", "UTC+0"),
                new("Africa/Banjul", "班珠尔(冈)", "UTC+0"),
                new("Africa/Banjul", "班珠尔(冈比)", "UTC+0"),
                new("Atlantic/Madeira", "马德拉", "UTC+0"),
                new("Atlantic/Canary", "加那利群岛", "UTC+0"),
                new("Atlantic/Faroe", "法罗群岛", "UTC+0"),
                new("Atlantic/Jan_Mayen", "扬马延", "UTC+1"),
                new("Atlantic/Reykjavik", "雷克雅未克(冰)", "UTC+0"),
                new("Atlantic/South_Georgia", "南乔治亚岛", "UTC-2"),
                new("Atlantic/St_Helena", "圣赫勒拿", "UTC+0"),
                new("Atlantic/Azores", "亚速尔群岛", "UTC-1"),
                new("Atlantic/Cape_Verde", "佛得角", "UTC-1")
            }
        };

        /// <summary>
        /// 获取当前时区的当前时间（自动处理夏令时）
        /// </summary>
        public static DateTime GetCurrentTime()
        {
            try
            {
                var tz = TimeZoneInfo.FindSystemTimeZoneById(ConvertIanaToWindows(_currentTimeZone));
                return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tz);
            }
            catch
            {
                // 回退到本地时间
                return DateTime.Now;
            }
        }

        /// <summary>
        /// 获取当前时区的显示名称
        /// </summary>
        public static string GetCurrentTimeZoneName()
        {
            string currentLang = LanguageManager.CurrentLang;
            foreach (var group in TimeZones.Values)
            {
                var found = group.FirstOrDefault(tz => tz.Id == _currentTimeZone);
                if (found != null) return found.GetName(currentLang);
            }
            return _currentTimeZone;
        }

        /// <summary>
        /// 获取当前时区的UTC偏移
        /// </summary>
        public static string GetCurrentUtcOffset()
        {
            foreach (var group in TimeZones.Values)
            {
                var found = group.FirstOrDefault(tz => tz.Id == _currentTimeZone);
                if (found != null) return found.UtcOffset;
            }
            return "";
        }

        /// <summary>
        /// IANA时区ID转换为Windows时区ID
        /// </summary>
        private static string ConvertIanaToWindows(string ianaId)
        {
            // 常见IANA到Windows的映射
            var map = new Dictionary<string, string>
            {
                ["Asia/Shanghai"] = "China Standard Time",
                ["Asia/Hong_Kong"] = "China Standard Time",
                ["Asia/Taipei"] = "Taipei Standard Time",
                ["Asia/Tokyo"] = "Tokyo Standard Time",
                ["Asia/Seoul"] = "Korea Standard Time",
                ["Asia/Singapore"] = "Singapore Standard Time",
                ["Asia/Bangkok"] = "SE Asia Standard Time",
                ["Asia/Jakarta"] = "SE Asia Standard Time",
                ["Asia/Kolkata"] = "India Standard Time",
                ["Asia/Dubai"] = "Arabian Standard Time",
                ["Asia/Riyadh"] = "Arab Standard Time",
                ["Asia/Tehran"] = "Iran Standard Time",
                ["Asia/Jerusalem"] = "Israel Standard Time",
                ["Asia/Beirut"] = "Middle East Standard Time",
                ["Asia/Amman"] = "Jordan Standard Time",
                ["Asia/Baghdad"] = "Arabic Standard Time",
                ["Asia/Kuwait"] = "Arab Standard Time",
                ["Asia/Qatar"] = "Arab Standard Time",
                ["Asia/Bahrain"] = "Arab Standard Time",
                ["Asia/Muscat"] = "Arabian Standard Time",
                ["Asia/Kabul"] = "Afghanistan Standard Time",
                ["Asia/Karachi"] = "Pakistan Standard Time",
                ["Asia/Tashkent"] = "West Asia Standard Time",
                ["Asia/Yekaterinburg"] = "Ekaterinburg Standard Time",
                ["Asia/Novosibirsk"] = "N. Central Asia Standard Time",
                ["Asia/Krasnoyarsk"] = "North Asia Standard Time",
                ["Asia/Irkutsk"] = "North Asia East Standard Time",
                ["Asia/Yakutsk"] = "Yakutsk Standard Time",
                ["Asia/Vladivostok"] = "Vladivostok Standard Time",
                ["Asia/Magadan"] = "Magadan Standard Time",
                ["Asia/Kamchatka"] = "Russia Time Zone 11",
                ["Asia/Anadyr"] = "Russia Time Zone 11",
                ["Europe/London"] = "GMT Standard Time",
                ["Europe/Dublin"] = "GMT Standard Time",
                ["Europe/Lisbon"] = "GMT Standard Time",
                ["Europe/Paris"] = "Romance Standard Time",
                ["Europe/Madrid"] = "Romance Standard Time",
                ["Europe/Brussels"] = "Romance Standard Time",
                ["Europe/Amsterdam"] = "W. Europe Standard Time",
                ["Europe/Berlin"] = "W. Europe Standard Time",
                ["Europe/Vienna"] = "W. Europe Standard Time",
                ["Europe/Zurich"] = "W. Europe Standard Time",
                ["Europe/Rome"] = "W. Europe Standard Time",
                ["Europe/Milan"] = "W. Europe Standard Time",
                ["Europe/Stockholm"] = "W. Europe Standard Time",
                ["Europe/Oslo"] = "W. Europe Standard Time",
                ["Europe/Copenhagen"] = "Romance Standard Time",
                ["Europe/Helsinki"] = "FLE Standard Time",
                ["Europe/Tallinn"] = "FLE Standard Time",
                ["Europe/Riga"] = "FLE Standard Time",
                ["Europe/Vilnius"] = "FLE Standard Time",
                ["Europe/Warsaw"] = "Central European Standard Time",
                ["Europe/Prague"] = "Central Europe Standard Time",
                ["Europe/Budapest"] = "Central Europe Standard Time",
                ["Europe/Athens"] = "GTB Standard Time",
                ["Europe/Bucharest"] = "GTB Standard Time",
                ["Europe/Sofia"] = "FLE Standard Time",
                ["Europe/Istanbul"] = "Turkey Standard Time",
                ["Europe/Moscow"] = "Russian Standard Time",
                ["Europe/Saint_Petersburg"] = "Russian Standard Time",
                ["Europe/Kyiv"] = "FLE Standard Time",
                ["Europe/Minsk"] = "Belarus Standard Time",
                ["America/New_York"] = "Eastern Standard Time",
                ["America/Chicago"] = "Central Standard Time",
                ["America/Denver"] = "Mountain Standard Time",
                ["America/Los_Angeles"] = "Pacific Standard Time",
                ["America/Anchorage"] = "Alaskan Standard Time",
                ["America/Phoenix"] = "US Mountain Standard Time",
                ["America/Toronto"] = "Eastern Standard Time",
                ["America/Vancouver"] = "Pacific Standard Time",
                ["America/Mexico_City"] = "Central Standard Time (Mexico)",
                ["America/Buenos_Aires"] = "Argentina Standard Time",
                ["America/Sao_Paulo"] = "E. South America Standard Time",
                ["America/Santiago"] = "Pacific SA Standard Time",
                ["America/Lima"] = "SA Pacific Standard Time",
                ["America/Bogota"] = "SA Pacific Standard Time",
                ["America/Caracas"] = "Venezuela Standard Time",
                ["Australia/Sydney"] = "AUS Eastern Standard Time",
                ["Australia/Melbourne"] = "AUS Eastern Standard Time",
                ["Australia/Brisbane"] = "E. Australia Standard Time",
                ["Australia/Perth"] = "W. Australia Standard Time",
                ["Australia/Adelaide"] = "Cen. Australia Standard Time",
                ["Australia/Darwin"] = "AUS Central Standard Time",
                ["Australia/Hobart"] = "Tasmania Standard Time",
                ["Pacific/Auckland"] = "New Zealand Standard Time",
                ["Pacific/Fiji"] = "Fiji Standard Time",
                ["Pacific/Honolulu"] = "Hawaiian Standard Time",
                ["Pacific/Guam"] = "West Pacific Standard Time",
                ["Africa/Cairo"] = "Egypt Standard Time",
                ["Africa/Lagos"] = "W. Central Africa Standard Time",
                ["Africa/Johannesburg"] = "South Africa Standard Time",
                ["Africa/Casablanca"] = "Morocco Standard Time",
                ["Africa/Algiers"] = "W. Central Africa Standard Time",
                ["Africa/Nairobi"] = "E. Africa Standard Time",
                ["Africa/Addis_Ababa"] = "E. Africa Standard Time",
                ["Africa/Accra"] = "Greenwich Standard Time",
                ["Africa/Dakar"] = "Greenwich Standard Time"
            };

            if (map.TryGetValue(ianaId, out var windowsId))
                return windowsId;

            // 尝试直接使用IANA ID（.NET 6+支持）
            try
            {
                TimeZoneInfo.FindSystemTimeZoneById(ianaId);
                return ianaId;
            }
            catch
            {
                return "UTC";
            }
        }
    }

    /// <summary>
    /// 时区信息项
    /// </summary>
    public class TimeZoneInfoItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UtcOffset { get; set; }

        /// <summary>
        /// 英文名称（从 IANA ID 自动提取城市名）
        /// </summary>
        public string NameEn
        {
            get
            {
                // 从 IANA ID 中提取城市名，例如 Asia/Shanghai -> Shanghai
                var parts = Id.Split('/');
                if (parts.Length > 0)
                {
                    var city = parts[^1].Replace('_', ' ');
                    return city;
                }
                return Id;
            }
        }

        public TimeZoneInfoItem(string id, string name, string utcOffset)
        {
            Id = id;
            Name = name;
            UtcOffset = utcOffset;
        }

        public override string ToString() => $"{Name} ({UtcOffset})";

        /// <summary>
        /// 根据语言获取显示名称
        /// </summary>
        public string GetDisplayName(string lang)
        {
            var name = TimeZoneTranslations.GetName(Id, lang);
            return $"{name} ({UtcOffset})";
        }

        /// <summary>
        /// 根据语言获取纯名称（不含UTC偏移）
        /// </summary>
        public string GetName(string lang)
        {
            return TimeZoneTranslations.GetName(Id, lang);
        }
    }
}
