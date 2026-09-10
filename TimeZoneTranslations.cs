using System.Collections.Generic;

namespace macOSClock
{
    /// <summary>
    /// 时区多语言翻译资源（MUI）- 简中/繁中/英文，其他语言用英文回退
    /// </summary>
    public static class TimeZoneTranslations
    {
        /// <summary>
        /// 时区翻译字典：[时区ID] = [语言代码, 翻译名称]
        /// </summary>
        public static readonly Dictionary<string, Dictionary<string, string>> Translations = new()
        {
            ["Africa/Abidjan"] = new()
            {
                { "zh-CN", "阿比让" },
                { "zh-TW", "阿比让" },
                { "en", "Abidjan" }
            },
            ["Africa/Accra"] = new()
            {
                { "zh-CN", "阿克拉" },
                { "zh-TW", "阿克拉" },
                { "en", "Accra" }
            },
            ["Africa/Addis_Ababa"] = new()
            {
                { "zh-CN", "亚的斯亚贝巴" },
                { "zh-TW", "亚的斯亚贝巴" },
                { "en", "Addis Ababa" }
            },
            ["Africa/Algiers"] = new()
            {
                { "zh-CN", "阿尔及尔" },
                { "zh-TW", "阿尔及尔" },
                { "en", "Algiers" }
            },
            ["Africa/Asmara"] = new()
            {
                { "zh-CN", "阿斯马拉(厄)" },
                { "zh-TW", "阿斯马拉(厄)" },
                { "en", "Asmara" }
            },
            ["Africa/Asmera"] = new()
            {
                { "zh-CN", "阿斯马拉" },
                { "zh-TW", "阿斯马拉" },
                { "en", "Asmera" }
            },
            ["Africa/Bamako"] = new()
            {
                { "zh-CN", "巴马科" },
                { "zh-TW", "巴马科" },
                { "en", "Bamako" }
            },
            ["Africa/Bangui"] = new()
            {
                { "zh-CN", "班吉" },
                { "zh-TW", "班吉" },
                { "en", "Bangui" }
            },
            ["Africa/Banjul"] = new()
            {
                { "zh-CN", "班珠尔" },
                { "zh-TW", "班珠尔" },
                { "en", "Banjul" }
            },
            ["Africa/Bissau"] = new()
            {
                { "zh-CN", "比绍" },
                { "zh-TW", "比绍" },
                { "en", "Bissau" }
            },
            ["Africa/Blantyre"] = new()
            {
                { "zh-CN", "布兰太尔" },
                { "zh-TW", "布兰太尔" },
                { "en", "Blantyre" }
            },
            ["Africa/Brazzaville"] = new()
            {
                { "zh-CN", "布拉柴维尔" },
                { "zh-TW", "布拉柴维尔" },
                { "en", "Brazzaville" }
            },
            ["Africa/Bujumbura"] = new()
            {
                { "zh-CN", "布琼布拉" },
                { "zh-TW", "布琼布拉" },
                { "en", "Bujumbura" }
            },
            ["Africa/Cairo"] = new()
            {
                { "zh-CN", "开罗" },
                { "zh-TW", "开罗" },
                { "en", "Cairo" }
            },
            ["Africa/Casablanca"] = new()
            {
                { "zh-CN", "卡萨布兰卡" },
                { "zh-TW", "卡萨布兰卡" },
                { "en", "Casablanca" }
            },
            ["Africa/Ceuta"] = new()
            {
                { "zh-CN", "休达" },
                { "zh-TW", "休达" },
                { "en", "Ceuta" }
            },
            ["Africa/Conakry"] = new()
            {
                { "zh-CN", "科纳克里" },
                { "zh-TW", "科纳克里" },
                { "en", "Conakry" }
            },
            ["Africa/Dakar"] = new()
            {
                { "zh-CN", "达喀尔" },
                { "zh-TW", "达喀尔" },
                { "en", "Dakar" }
            },
            ["Africa/Dar_es_Salaam"] = new()
            {
                { "zh-CN", "达累斯萨拉姆" },
                { "zh-TW", "达累斯萨拉姆" },
                { "en", "Dar es Salaam" }
            },
            ["Africa/Djibouti"] = new()
            {
                { "zh-CN", "吉布提" },
                { "zh-TW", "吉布提" },
                { "en", "Djibouti" }
            },
            ["Africa/Douala"] = new()
            {
                { "zh-CN", "杜阿拉" },
                { "zh-TW", "杜阿拉" },
                { "en", "Douala" }
            },
            ["Africa/El_Aaiun"] = new()
            {
                { "zh-CN", "阿尤恩" },
                { "zh-TW", "阿尤恩" },
                { "en", "El Aaiun" }
            },
            ["Africa/Freetown"] = new()
            {
                { "zh-CN", "弗里敦" },
                { "zh-TW", "弗里敦" },
                { "en", "Freetown" }
            },
            ["Africa/Gaborone"] = new()
            {
                { "zh-CN", "哈博罗内" },
                { "zh-TW", "哈博罗内" },
                { "en", "Gaborone" }
            },
            ["Africa/Harare"] = new()
            {
                { "zh-CN", "哈拉雷" },
                { "zh-TW", "哈拉雷" },
                { "en", "Harare" }
            },
            ["Africa/Johannesburg"] = new()
            {
                { "zh-CN", "约翰内斯堡" },
                { "zh-TW", "约翰内斯堡" },
                { "en", "Johannesburg" }
            },
            ["Africa/Juba"] = new()
            {
                { "zh-CN", "朱巴" },
                { "zh-TW", "朱巴" },
                { "en", "Juba" }
            },
            ["Africa/Kampala"] = new()
            {
                { "zh-CN", "坎帕拉" },
                { "zh-TW", "坎帕拉" },
                { "en", "Kampala" }
            },
            ["Africa/Khartoum"] = new()
            {
                { "zh-CN", "喀土穆" },
                { "zh-TW", "喀土穆" },
                { "en", "Khartoum" }
            },
            ["Africa/Kigali"] = new()
            {
                { "zh-CN", "基加利" },
                { "zh-TW", "基加利" },
                { "en", "Kigali" }
            },
            ["Africa/Kinshasa"] = new()
            {
                { "zh-CN", "金沙萨" },
                { "zh-TW", "金沙萨" },
                { "en", "Kinshasa" }
            },
            ["Africa/Lagos"] = new()
            {
                { "zh-CN", "拉各斯" },
                { "zh-TW", "拉各斯" },
                { "en", "Lagos" }
            },
            ["Africa/Libreville"] = new()
            {
                { "zh-CN", "利伯维尔" },
                { "zh-TW", "利伯维尔" },
                { "en", "Libreville" }
            },
            ["Africa/Lome"] = new()
            {
                { "zh-CN", "洛美" },
                { "zh-TW", "洛美" },
                { "en", "Lome" }
            },
            ["Africa/Luanda"] = new()
            {
                { "zh-CN", "罗安达" },
                { "zh-TW", "罗安达" },
                { "en", "Luanda" }
            },
            ["Africa/Lubumbashi"] = new()
            {
                { "zh-CN", "卢本巴希" },
                { "zh-TW", "卢本巴希" },
                { "en", "Lubumbashi" }
            },
            ["Africa/Lusaka"] = new()
            {
                { "zh-CN", "卢萨卡" },
                { "zh-TW", "卢萨卡" },
                { "en", "Lusaka" }
            },
            ["Africa/Malabo"] = new()
            {
                { "zh-CN", "马拉博" },
                { "zh-TW", "马拉博" },
                { "en", "Malabo" }
            },
            ["Africa/Maputo"] = new()
            {
                { "zh-CN", "马普托" },
                { "zh-TW", "马普托" },
                { "en", "Maputo" }
            },
            ["Africa/Maseru"] = new()
            {
                { "zh-CN", "马塞卢" },
                { "zh-TW", "马塞卢" },
                { "en", "Maseru" }
            },
            ["Africa/Mbabane"] = new()
            {
                { "zh-CN", "姆巴巴内" },
                { "zh-TW", "姆巴巴内" },
                { "en", "Mbabane" }
            },
            ["Africa/Melilla"] = new()
            {
                { "zh-CN", "梅利利亚" },
                { "zh-TW", "梅利利亚" },
                { "en", "Melilla" }
            },
            ["Africa/Mogadishu"] = new()
            {
                { "zh-CN", "摩加迪沙" },
                { "zh-TW", "摩加迪沙" },
                { "en", "Mogadishu" }
            },
            ["Africa/Monrovia"] = new()
            {
                { "zh-CN", "蒙罗维亚" },
                { "zh-TW", "蒙罗维亚" },
                { "en", "Monrovia" }
            },
            ["Africa/Nairobi"] = new()
            {
                { "zh-CN", "内罗毕" },
                { "zh-TW", "内罗毕" },
                { "en", "Nairobi" }
            },
            ["Africa/Ndjamena"] = new()
            {
                { "zh-CN", "恩贾梅纳" },
                { "zh-TW", "恩贾梅纳" },
                { "en", "Ndjamena" }
            },
            ["Africa/Niamey"] = new()
            {
                { "zh-CN", "尼亚美" },
                { "zh-TW", "尼亚美" },
                { "en", "Niamey" }
            },
            ["Africa/Nouakchott"] = new()
            {
                { "zh-CN", "努瓦克肖特" },
                { "zh-TW", "努瓦克肖特" },
                { "en", "Nouakchott" }
            },
            ["Africa/Ouagadougou"] = new()
            {
                { "zh-CN", "瓦加杜古" },
                { "zh-TW", "瓦加杜古" },
                { "en", "Ouagadougou" }
            },
            ["Africa/Porto-Novo"] = new()
            {
                { "zh-CN", "波多诺伏" },
                { "zh-TW", "波多诺伏" },
                { "en", "Porto-Novo" }
            },
            ["Africa/Sao_Tome"] = new()
            {
                { "zh-CN", "圣多美" },
                { "zh-TW", "圣多美" },
                { "en", "Sao Tome" }
            },
            ["Africa/Timbuktu"] = new()
            {
                { "zh-CN", "廷巴克图" },
                { "zh-TW", "廷巴克图" },
                { "en", "Timbuktu" }
            },
            ["Africa/Tripoli"] = new()
            {
                { "zh-CN", "的黎波里" },
                { "zh-TW", "的黎波里" },
                { "en", "Tripoli" }
            },
            ["Africa/Tunis"] = new()
            {
                { "zh-CN", "突尼斯" },
                { "zh-TW", "突尼斯" },
                { "en", "Tunis" }
            },
            ["Africa/Windhoek"] = new()
            {
                { "zh-CN", "温得和克" },
                { "zh-TW", "温得和克" },
                { "en", "Windhoek" }
            },
            ["America/Adak"] = new()
            {
                { "zh-CN", "埃达克" },
                { "zh-TW", "埃達克" },
                { "en", "Adak" }
            },
            ["America/Anchorage"] = new()
            {
                { "zh-CN", "安克雷奇" },
                { "zh-TW", "安克雷奇" },
                { "en", "Anchorage" }
            },
            ["America/Anguilla"] = new()
            {
                { "zh-CN", "山谷" },
                { "zh-TW", "山谷" },
                { "en", "Anguilla" }
            },
            ["America/Argentina/Buenos_Aires"] = new()
            {
                { "zh-CN", "布宜诺斯艾利斯(阿)" },
                { "zh-TW", "布宜诺斯艾利斯(阿)" },
                { "en", "Buenos Aires" }
            },
            ["America/Argentina/Catamarca"] = new()
            {
                { "zh-CN", "卡塔马卡" },
                { "zh-TW", "卡塔马卡" },
                { "en", "Catamarca" }
            },
            ["America/Argentina/Cordoba"] = new()
            {
                { "zh-CN", "科尔多瓦" },
                { "zh-TW", "科尔多瓦" },
                { "en", "Cordoba" }
            },
            ["America/Argentina/Jujuy"] = new()
            {
                { "zh-CN", "胡胡伊" },
                { "zh-TW", "胡胡伊" },
                { "en", "Jujuy" }
            },
            ["America/Argentina/La_Rioja"] = new()
            {
                { "zh-CN", "拉里奥哈" },
                { "zh-TW", "拉里奥哈" },
                { "en", "La Rioja" }
            },
            ["America/Argentina/Mendoza"] = new()
            {
                { "zh-CN", "门多萨" },
                { "zh-TW", "门多萨" },
                { "en", "Mendoza" }
            },
            ["America/Argentina/Rio_Gallegos"] = new()
            {
                { "zh-CN", "里奥加耶戈斯" },
                { "zh-TW", "里奥加耶戈斯" },
                { "en", "Rio Gallegos" }
            },
            ["America/Argentina/Salta"] = new()
            {
                { "zh-CN", "萨尔塔" },
                { "zh-TW", "萨尔塔" },
                { "en", "Salta" }
            },
            ["America/Argentina/San_Juan"] = new()
            {
                { "zh-CN", "圣胡安" },
                { "zh-TW", "聖胡安" },
                { "en", "San Juan" }
            },
            ["America/Argentina/San_Luis"] = new()
            {
                { "zh-CN", "圣路易斯" },
                { "zh-TW", "圣路易斯" },
                { "en", "San Luis" }
            },
            ["America/Argentina/Tucuman"] = new()
            {
                { "zh-CN", "图库曼" },
                { "zh-TW", "图库曼" },
                { "en", "Tucuman" }
            },
            ["America/Argentina/Ushuaia"] = new()
            {
                { "zh-CN", "乌斯怀亚" },
                { "zh-TW", "乌斯怀亚" },
                { "en", "Ushuaia" }
            },
            ["America/Aruba"] = new()
            {
                { "zh-CN", "奥拉涅斯塔德" },
                { "zh-TW", "奥拉涅斯塔德" },
                { "en", "Aruba" }
            },
            ["America/Asuncion"] = new()
            {
                { "zh-CN", "亚松森" },
                { "zh-TW", "亚松森" },
                { "en", "Asuncion" }
            },
            ["America/Atikokan"] = new()
            {
                { "zh-CN", "阿蒂科肯" },
                { "zh-TW", "阿蒂科肯" },
                { "en", "Atikokan" }
            },
            ["America/Bahia"] = new()
            {
                { "zh-CN", "巴伊亚" },
                { "zh-TW", "巴伊亚" },
                { "en", "Bahia" }
            },
            ["America/Bahia_Banderas"] = new()
            {
                { "zh-CN", "巴亚尔塔港" },
                { "zh-TW", "巴亚尔塔港" },
                { "en", "Bahia Banderas" }
            },
            ["America/Barbados"] = new()
            {
                { "zh-CN", "布里奇敦" },
                { "zh-TW", "布里奇敦" },
                { "en", "Barbados" }
            },
            ["America/Belize"] = new()
            {
                { "zh-CN", "贝尔莫潘" },
                { "zh-TW", "贝尔莫潘" },
                { "en", "Belize" }
            },
            ["America/Bermuda"] = new()
            {
                { "zh-CN", "哈密尔顿" },
                { "zh-TW", "哈密爾頓" },
                { "en", "Bermuda" }
            },
            ["America/Blanc-Sablon"] = new()
            {
                { "zh-CN", "布朗-萨布隆" },
                { "zh-TW", "布朗-萨布隆" },
                { "en", "Blanc-Sablon" }
            },
            ["America/Boa_Vista"] = new()
            {
                { "zh-CN", "博阿维斯塔" },
                { "zh-TW", "博阿维斯塔" },
                { "en", "Boa Vista" }
            },
            ["America/Bogota"] = new()
            {
                { "zh-CN", "波哥大" },
                { "zh-TW", "波哥大" },
                { "en", "Bogota" }
            },
            ["America/Boise"] = new()
            {
                { "zh-CN", "博伊西" },
                { "zh-TW", "博伊西" },
                { "en", "Boise" }
            },
            ["America/Buenos_Aires"] = new()
            {
                { "zh-CN", "布宜诺斯艾利斯" },
                { "zh-TW", "布宜诺斯艾利斯" },
                { "en", "Buenos Aires" }
            },
            ["America/Campo_Grande"] = new()
            {
                { "zh-CN", "大坎普" },
                { "zh-TW", "大坎普" },
                { "en", "Campo Grande" }
            },
            ["America/Cancun"] = new()
            {
                { "zh-CN", "坎昆" },
                { "zh-TW", "坎昆" },
                { "en", "Cancun" }
            },
            ["America/Caracas"] = new()
            {
                { "zh-CN", "加拉加斯" },
                { "zh-TW", "加拉加斯" },
                { "en", "Caracas" }
            },
            ["America/Cayenne"] = new()
            {
                { "zh-CN", "卡宴" },
                { "zh-TW", "卡宴" },
                { "en", "Cayenne" }
            },
            ["America/Cayman"] = new()
            {
                { "zh-CN", "乔治敦" },
                { "zh-TW", "喬治敦" },
                { "en", "Cayman" }
            },
            ["America/Chicago"] = new()
            {
                { "zh-CN", "芝加哥" },
                { "zh-TW", "芝加哥" },
                { "en", "Chicago" }
            },
            ["America/Chihuahua"] = new()
            {
                { "zh-CN", "奇瓦瓦" },
                { "zh-TW", "奇瓦瓦" },
                { "en", "Chihuahua" }
            },
            ["America/Coral_Harbour"] = new()
            {
                { "zh-CN", "科勒尔港" },
                { "zh-TW", "科勒尔港" },
                { "en", "Coral Harbour" }
            },
            ["America/Costa_Rica"] = new()
            {
                { "zh-CN", "圣何塞" },
                { "zh-TW", "圣何塞" },
                { "en", "Costa Rica" }
            },
            ["America/Cuiaba"] = new()
            {
                { "zh-CN", "库亚巴" },
                { "zh-TW", "库亚巴" },
                { "en", "Cuiaba" }
            },
            ["America/Curacao"] = new()
            {
                { "zh-CN", "威廉斯塔德" },
                { "zh-TW", "威廉斯塔德" },
                { "en", "Curacao" }
            },
            ["America/Dawson"] = new()
            {
                { "zh-CN", "道森" },
                { "zh-TW", "道森" },
                { "en", "Dawson" }
            },
            ["America/Dawson_Creek"] = new()
            {
                { "zh-CN", "道森克里克" },
                { "zh-TW", "道森克里克" },
                { "en", "Dawson Creek" }
            },
            ["America/Denver"] = new()
            {
                { "zh-CN", "丹佛" },
                { "zh-TW", "丹佛" },
                { "en", "Denver" }
            },
            ["America/Dominica"] = new()
            {
                { "zh-CN", "罗索" },
                { "zh-TW", "羅索" },
                { "en", "Dominica" }
            },
            ["America/Edmonton"] = new()
            {
                { "zh-CN", "埃德蒙顿" },
                { "zh-TW", "埃德蒙頓" },
                { "en", "Edmonton" }
            },
            ["America/Eirunepe"] = new()
            {
                { "zh-CN", "埃鲁内佩" },
                { "zh-TW", "埃鲁内佩" },
                { "en", "Eirunepe" }
            },
            ["America/El_Salvador"] = new()
            {
                { "zh-CN", "圣萨尔瓦多(中)" },
                { "zh-TW", "圣萨尔瓦多(中)" },
                { "en", "El Salvador" }
            },
            ["America/Fort_Nelson"] = new()
            {
                { "zh-CN", "纳尔逊堡" },
                { "zh-TW", "納爾遜堡" },
                { "en", "Fort Nelson" }
            },
            ["America/Fortaleza"] = new()
            {
                { "zh-CN", "福塔莱萨" },
                { "zh-TW", "福塔莱萨" },
                { "en", "Fortaleza" }
            },
            ["America/Glace_Bay"] = new()
            {
                { "zh-CN", "格莱斯贝" },
                { "zh-TW", "格萊斯貝" },
                { "en", "Glace Bay" }
            },
            ["America/Goose_Bay"] = new()
            {
                { "zh-CN", "古斯贝" },
                { "zh-TW", "古斯貝" },
                { "en", "Goose Bay" }
            },
            ["America/Grenada"] = new()
            {
                { "zh-CN", "圣乔治" },
                { "zh-TW", "圣乔治" },
                { "en", "Grenada" }
            },
            ["America/Guadeloupe"] = new()
            {
                { "zh-CN", "巴斯特尔" },
                { "zh-TW", "巴斯特爾" },
                { "en", "Guadeloupe" }
            },
            ["America/Guatemala"] = new()
            {
                { "zh-CN", "危地马拉城" },
                { "zh-TW", "危地马拉城" },
                { "en", "Guatemala" }
            },
            ["America/Guayaquil"] = new()
            {
                { "zh-CN", "瓜亚基尔" },
                { "zh-TW", "瓜亚基尔" },
                { "en", "Guayaquil" }
            },
            ["America/Halifax"] = new()
            {
                { "zh-CN", "哈利法克斯" },
                { "zh-TW", "哈利法克斯" },
                { "en", "Halifax" }
            },
            ["America/Havana"] = new()
            {
                { "zh-CN", "哈瓦那" },
                { "zh-TW", "哈瓦那" },
                { "en", "Havana" }
            },
            ["America/Hermosillo"] = new()
            {
                { "zh-CN", "埃莫西约" },
                { "zh-TW", "埃莫西约" },
                { "en", "Hermosillo" }
            },
            ["America/Indiana/Indianapolis"] = new()
            {
                { "zh-CN", "印第安纳波利斯" },
                { "zh-TW", "印第安纳波利斯" },
                { "en", "Indianapolis" }
            },
            ["America/Indiana/Marengo"] = new()
            {
                { "zh-CN", "马伦戈" },
                { "zh-TW", "马伦戈" },
                { "en", "Marengo" }
            },
            ["America/Indiana/Petersburg"] = new()
            {
                { "zh-CN", "彼得斯堡" },
                { "zh-TW", "彼得斯堡" },
                { "en", "Petersburg" }
            },
            ["America/Indiana/Vevay"] = new()
            {
                { "zh-CN", "韦韦" },
                { "zh-TW", "韦韦" },
                { "en", "Vevay" }
            },
            ["America/Indiana/Vincennes"] = new()
            {
                { "zh-CN", "万塞讷" },
                { "zh-TW", "万塞讷" },
                { "en", "Vincennes" }
            },
            ["America/Indiana/Winamac"] = new()
            {
                { "zh-CN", "怀纳马克" },
                { "zh-TW", "怀纳马克" },
                { "en", "Winamac" }
            },
            ["America/Inuvik"] = new()
            {
                { "zh-CN", "伊努维克" },
                { "zh-TW", "伊努维克" },
                { "en", "Inuvik" }
            },
            ["America/Iqaluit"] = new()
            {
                { "zh-CN", "伊魁特" },
                { "zh-TW", "伊魁特" },
                { "en", "Iqaluit" }
            },
            ["America/Jamaica"] = new()
            {
                { "zh-CN", "金斯顿" },
                { "zh-TW", "金斯頓" },
                { "en", "Jamaica" }
            },
            ["America/Kentucky/Louisville"] = new()
            {
                { "zh-CN", "路易斯维尔" },
                { "zh-TW", "路易斯维尔" },
                { "en", "Louisville" }
            },
            ["America/Kentucky/Monticello"] = new()
            {
                { "zh-CN", "蒙蒂塞洛" },
                { "zh-TW", "蒙蒂塞洛" },
                { "en", "Monticello" }
            },
            ["America/Kralendijk"] = new()
            {
                { "zh-CN", "克拉伦代克" },
                { "zh-TW", "克拉倫代克" },
                { "en", "Kralendijk" }
            },
            ["America/La_Paz"] = new()
            {
                { "zh-CN", "拉巴斯" },
                { "zh-TW", "拉巴斯" },
                { "en", "La Paz" }
            },
            ["America/Lima"] = new()
            {
                { "zh-CN", "利马" },
                { "zh-TW", "利马" },
                { "en", "Lima" }
            },
            ["America/Los_Angeles"] = new()
            {
                { "zh-CN", "洛杉矶" },
                { "zh-TW", "洛杉磯" },
                { "en", "Los Angeles" }
            },
            ["America/Lower_Princes"] = new()
            {
                { "zh-CN", "下王子" },
                { "zh-TW", "下王子" },
                { "en", "Lower Princes" }
            },
            ["America/Managua"] = new()
            {
                { "zh-CN", "马那瓜" },
                { "zh-TW", "马那瓜" },
                { "en", "Managua" }
            },
            ["America/Manaus"] = new()
            {
                { "zh-CN", "马瑙斯" },
                { "zh-TW", "马瑙斯" },
                { "en", "Manaus" }
            },
            ["America/Marigot"] = new()
            {
                { "zh-CN", "马里戈" },
                { "zh-TW", "馬里戈" },
                { "en", "Marigot" }
            },
            ["America/Martinique"] = new()
            {
                { "zh-CN", "法兰西堡" },
                { "zh-TW", "法蘭西堡" },
                { "en", "Martinique" }
            },
            ["America/Matamoros"] = new()
            {
                { "zh-CN", "马塔莫罗斯" },
                { "zh-TW", "马塔莫罗斯" },
                { "en", "Matamoros" }
            },
            ["America/Merida"] = new()
            {
                { "zh-CN", "梅里达" },
                { "zh-TW", "梅里达" },
                { "en", "Merida" }
            },
            ["America/Mexicali"] = new()
            {
                { "zh-CN", "墨西卡利" },
                { "zh-TW", "墨西卡利" },
                { "en", "Mexicali" }
            },
            ["America/Mexico_City"] = new()
            {
                { "zh-CN", "墨西哥城" },
                { "zh-TW", "墨西哥城" },
                { "en", "Mexico City" }
            },
            ["America/Miquelon"] = new()
            {
                { "zh-CN", "圣皮埃尔" },
                { "zh-TW", "聖皮埃爾" },
                { "en", "Miquelon" }
            },
            ["America/Moncton"] = new()
            {
                { "zh-CN", "蒙克顿" },
                { "zh-TW", "蒙克頓" },
                { "en", "Moncton" }
            },
            ["America/Monterrey"] = new()
            {
                { "zh-CN", "蒙特雷" },
                { "zh-TW", "蒙特雷" },
                { "en", "Monterrey" }
            },
            ["America/Montevideo"] = new()
            {
                { "zh-CN", "蒙得维的亚" },
                { "zh-TW", "蒙得维的亚" },
                { "en", "Montevideo" }
            },
            ["America/Montreal"] = new()
            {
                { "zh-CN", "蒙特利尔" },
                { "zh-TW", "蒙特利爾" },
                { "en", "Montreal" }
            },
            ["America/Montserrat"] = new()
            {
                { "zh-CN", "普利茅斯" },
                { "zh-TW", "普利茅斯" },
                { "en", "Montserrat" }
            },
            ["America/Nassau"] = new()
            {
                { "zh-CN", "拿骚" },
                { "zh-TW", "拿騷" },
                { "en", "Nassau" }
            },
            ["America/New_York"] = new()
            {
                { "zh-CN", "纽约" },
                { "zh-TW", "紐約" },
                { "en", "New York" }
            },
            ["America/Nipigon"] = new()
            {
                { "zh-CN", "尼皮贡" },
                { "zh-TW", "尼皮贡" },
                { "en", "Nipigon" }
            },
            ["America/Noronha"] = new()
            {
                { "zh-CN", "费尔南多迪诺罗尼亚" },
                { "zh-TW", "费尔南多迪诺罗尼亚" },
                { "en", "Noronha" }
            },
            ["America/North_Dakota/Beulah"] = new()
            {
                { "zh-CN", "休拉" },
                { "zh-TW", "休拉" },
                { "en", "Beulah" }
            },
            ["America/North_Dakota/Center"] = new()
            {
                { "zh-CN", "森特" },
                { "zh-TW", "森特" },
                { "en", "Center" }
            },
            ["America/North_Dakota/New_Salem"] = new()
            {
                { "zh-CN", "新塞勒姆" },
                { "zh-TW", "新塞勒姆" },
                { "en", "New Salem" }
            },
            ["America/Ojinaga"] = new()
            {
                { "zh-CN", "奥希纳加" },
                { "zh-TW", "奥希纳加" },
                { "en", "Ojinaga" }
            },
            ["America/Panama"] = new()
            {
                { "zh-CN", "巴拿马城" },
                { "zh-TW", "巴拿马城" },
                { "en", "Panama" }
            },
            ["America/Pangnirtung"] = new()
            {
                { "zh-CN", "庞纳唐" },
                { "zh-TW", "庞纳唐" },
                { "en", "Pangnirtung" }
            },
            ["America/Phoenix"] = new()
            {
                { "zh-CN", "菲尼克斯" },
                { "zh-TW", "菲尼克斯" },
                { "en", "Phoenix" }
            },
            ["America/Port-au-Prince"] = new()
            {
                { "zh-CN", "太子港" },
                { "zh-TW", "太子港" },
                { "en", "Port-au-Prince" }
            },
            ["America/Porto_Velho"] = new()
            {
                { "zh-CN", "波多韦柳" },
                { "zh-TW", "波多韦柳" },
                { "en", "Porto Velho" }
            },
            ["America/Puerto_Rico"] = new()
            {
                { "zh-CN", "圣胡安" },
                { "zh-TW", "聖胡安" },
                { "en", "Puerto Rico" }
            },
            ["America/Quito"] = new()
            {
                { "zh-CN", "基多" },
                { "zh-TW", "基多" },
                { "en", "Quito" }
            },
            ["America/Rankin_Inlet"] = new()
            {
                { "zh-CN", "兰金湖" },
                { "zh-TW", "兰金湖" },
                { "en", "Rankin Inlet" }
            },
            ["America/Recife"] = new()
            {
                { "zh-CN", "累西腓" },
                { "zh-TW", "累西腓" },
                { "en", "Recife" }
            },
            ["America/Regina"] = new()
            {
                { "zh-CN", "里贾纳" },
                { "zh-TW", "里賈納" },
                { "en", "Regina" }
            },
            ["America/Resolute"] = new()
            {
                { "zh-CN", "雷索卢特" },
                { "zh-TW", "雷索卢特" },
                { "en", "Resolute" }
            },
            ["America/Rio_Branco"] = new()
            {
                { "zh-CN", "里奥布朗库" },
                { "zh-TW", "里奥布朗库" },
                { "en", "Rio Branco" }
            },
            ["America/Salt_Lake_City"] = new()
            {
                { "zh-CN", "盐湖城" },
                { "zh-TW", "鹽湖城" },
                { "en", "Salt Lake City" }
            },
            ["America/San_Salvador"] = new()
            {
                { "zh-CN", "圣萨尔瓦多" },
                { "zh-TW", "圣萨尔瓦多" },
                { "en", "San Salvador" }
            },
            ["America/Santa_Isabel"] = new()
            {
                { "zh-CN", "圣伊莎贝尔" },
                { "zh-TW", "圣伊莎贝尔" },
                { "en", "Santa Isabel" }
            },
            ["America/Santiago"] = new()
            {
                { "zh-CN", "圣地亚哥" },
                { "zh-TW", "圣地亚哥" },
                { "en", "Santiago" }
            },
            ["America/Santo_Domingo"] = new()
            {
                { "zh-CN", "圣多明各" },
                { "zh-TW", "聖多明各" },
                { "en", "Santo Domingo" }
            },
            ["America/Sao_Paulo"] = new()
            {
                { "zh-CN", "圣保罗" },
                { "zh-TW", "圣保罗" },
                { "en", "Sao Paulo" }
            },
            ["America/St_Barthelemy"] = new()
            {
                { "zh-CN", "古斯塔维亚" },
                { "zh-TW", "古斯塔維亞" },
                { "en", "St Barthelemy" }
            },
            ["America/St_Croix"] = new()
            {
                { "zh-CN", "克里斯琴斯特德" },
                { "zh-TW", "克里斯琴斯特德" },
                { "en", "St Croix" }
            },
            ["America/St_Johns"] = new()
            {
                { "zh-CN", "圣约翰斯" },
                { "zh-TW", "聖約翰斯" },
                { "en", "St Johns" }
            },
            ["America/St_Lucia"] = new()
            {
                { "zh-CN", "卡斯特里" },
                { "zh-TW", "卡斯特里" },
                { "en", "St Lucia" }
            },
            ["America/St_Thomas"] = new()
            {
                { "zh-CN", "夏洛特阿马利亚" },
                { "zh-TW", "夏洛特阿馬利亞" },
                { "en", "St Thomas" }
            },
            ["America/St_Vincent"] = new()
            {
                { "zh-CN", "金斯敦" },
                { "zh-TW", "金斯敦" },
                { "en", "St Vincent" }
            },
            ["America/Swift_Current"] = new()
            {
                { "zh-CN", "斯威夫特卡伦特" },
                { "zh-TW", "斯威夫特卡倫特" },
                { "en", "Swift Current" }
            },
            ["America/Tegucigalpa"] = new()
            {
                { "zh-CN", "特古西加尔巴" },
                { "zh-TW", "特古西加尔巴" },
                { "en", "Tegucigalpa" }
            },
            ["America/Thunder_Bay"] = new()
            {
                { "zh-CN", "桑德贝" },
                { "zh-TW", "桑德贝" },
                { "en", "Thunder Bay" }
            },
            ["America/Tijuana"] = new()
            {
                { "zh-CN", "蒂华纳" },
                { "zh-TW", "蒂华纳" },
                { "en", "Tijuana" }
            },
            ["America/Toronto"] = new()
            {
                { "zh-CN", "多伦多" },
                { "zh-TW", "多倫多" },
                { "en", "Toronto" }
            },
            ["America/Tortola"] = new()
            {
                { "zh-CN", "罗德城" },
                { "zh-TW", "罗德城" },
                { "en", "Tortola" }
            },
            ["America/Vancouver"] = new()
            {
                { "zh-CN", "温哥华" },
                { "zh-TW", "溫哥華" },
                { "en", "Vancouver" }
            },
            ["America/Whitehorse"] = new()
            {
                { "zh-CN", "怀特霍斯" },
                { "zh-TW", "懷特霍斯" },
                { "en", "Whitehorse" }
            },
            ["America/Winnipeg"] = new()
            {
                { "zh-CN", "温尼伯" },
                { "zh-TW", "溫尼伯" },
                { "en", "Winnipeg" }
            },
            ["America/Yellowknife"] = new()
            {
                { "zh-CN", "耶洛奈夫" },
                { "zh-TW", "耶洛奈夫" },
                { "en", "Yellowknife" }
            },
            ["Antarctica/Casey"] = new()
            {
                { "zh-CN", "凯西站" },
                { "zh-TW", "凯西站" },
                { "en", "Casey" }
            },
            ["Antarctica/Concordia"] = new()
            {
                { "zh-CN", "康宏站" },
                { "zh-TW", "康宏站" },
                { "en", "Concordia" }
            },
            ["Antarctica/Davis"] = new()
            {
                { "zh-CN", "戴维斯站" },
                { "zh-TW", "戴维斯站" },
                { "en", "Davis" }
            },
            ["Antarctica/DumontDUrville"] = new()
            {
                { "zh-CN", "迪蒙迪维尔站" },
                { "zh-TW", "迪蒙迪维尔站" },
                { "en", "DumontDUrville" }
            },
            ["Antarctica/Macquarie"] = new()
            {
                { "zh-CN", "麦夸里岛" },
                { "zh-TW", "麦夸里岛" },
                { "en", "Macquarie" }
            },
            ["Antarctica/Mawson"] = new()
            {
                { "zh-CN", "莫森站" },
                { "zh-TW", "莫森站" },
                { "en", "Mawson" }
            },
            ["Antarctica/McMurdo"] = new()
            {
                { "zh-CN", "麦克默多站" },
                { "zh-TW", "麦克默多站" },
                { "en", "McMurdo" }
            },
            ["Antarctica/Palmer"] = new()
            {
                { "zh-CN", "帕尔默站" },
                { "zh-TW", "帕尔默站" },
                { "en", "Palmer" }
            },
            ["Antarctica/Rothera"] = new()
            {
                { "zh-CN", "罗瑟拉站" },
                { "zh-TW", "罗瑟拉站" },
                { "en", "Rothera" }
            },
            ["Antarctica/South_Pole"] = new()
            {
                { "zh-CN", "阿蒙森-斯科特站" },
                { "zh-TW", "阿蒙森-斯科特站" },
                { "en", "South Pole" }
            },
            ["Antarctica/Syowa"] = new()
            {
                { "zh-CN", "昭和站" },
                { "zh-TW", "昭和站" },
                { "en", "Syowa" }
            },
            ["Antarctica/Troll"] = new()
            {
                { "zh-CN", "特罗尔站" },
                { "zh-TW", "特罗尔站" },
                { "en", "Troll" }
            },
            ["Antarctica/Vostok"] = new()
            {
                { "zh-CN", "沃斯托克站" },
                { "zh-TW", "沃斯托克站" },
                { "en", "Vostok" }
            },
            ["Asia/Almaty"] = new()
            {
                { "zh-CN", "阿拉木图" },
                { "zh-TW", "阿拉木圖" },
                { "en", "Almaty" }
            },
            ["Asia/Amman"] = new()
            {
                { "zh-CN", "安曼" },
                { "zh-TW", "安曼" },
                { "en", "Amman" }
            },
            ["Asia/Anadyr"] = new()
            {
                { "zh-CN", "阿纳德尔" },
                { "zh-TW", "阿納德爾" },
                { "en", "Anadyr" }
            },
            ["Asia/Aqtau"] = new()
            {
                { "zh-CN", "阿克套" },
                { "zh-TW", "阿克套" },
                { "en", "Aqtau" }
            },
            ["Asia/Aqtobe"] = new()
            {
                { "zh-CN", "阿克托别" },
                { "zh-TW", "阿克托別" },
                { "en", "Aqtobe" }
            },
            ["Asia/Ashgabat"] = new()
            {
                { "zh-CN", "阿什哈巴德" },
                { "zh-TW", "阿什哈巴德" },
                { "en", "Ashgabat" }
            },
            ["Asia/Atyrau"] = new()
            {
                { "zh-CN", "阿特劳" },
                { "zh-TW", "阿特勞" },
                { "en", "Atyrau" }
            },
            ["Asia/Baghdad"] = new()
            {
                { "zh-CN", "巴格达" },
                { "zh-TW", "巴格達" },
                { "en", "Baghdad" }
            },
            ["Asia/Bahrain"] = new()
            {
                { "zh-CN", "麦纳麦" },
                { "zh-TW", "麥納麥" },
                { "en", "Bahrain" }
            },
            ["Asia/Baku"] = new()
            {
                { "zh-CN", "巴库" },
                { "zh-TW", "巴庫" },
                { "en", "Baku" }
            },
            ["Asia/Bangkok"] = new()
            {
                { "zh-CN", "曼谷" },
                { "zh-TW", "曼谷" },
                { "en", "Bangkok" }
            },
            ["Asia/Barnaul"] = new()
            {
                { "zh-CN", "巴尔瑙尔" },
                { "zh-TW", "巴爾瑙爾" },
                { "en", "Barnaul" }
            },
            ["Asia/Beirut"] = new()
            {
                { "zh-CN", "贝鲁特" },
                { "zh-TW", "貝魯特" },
                { "en", "Beirut" }
            },
            ["Asia/Bishkek"] = new()
            {
                { "zh-CN", "比什凯克" },
                { "zh-TW", "比什凱克" },
                { "en", "Bishkek" }
            },
            ["Asia/Brunei"] = new()
            {
                { "zh-CN", "斯里巴加湾市" },
                { "zh-TW", "斯里巴加灣市" },
                { "en", "Brunei" }
            },
            ["Asia/Calcutta"] = new()
            {
                { "zh-CN", "加尔各答(旧)" },
                { "zh-TW", "加爾各答(旧)" },
                { "en", "Calcutta" }
            },
            ["Asia/Chita"] = new()
            {
                { "zh-CN", "赤塔" },
                { "zh-TW", "赤塔" },
                { "en", "Chita" }
            },
            ["Asia/Chongqing"] = new()
            {
                { "zh-CN", "重庆" },
                { "zh-TW", "重慶" },
                { "en", "Chongqing" }
            },
            ["Asia/Colombo"] = new()
            {
                { "zh-CN", "科伦坡" },
                { "zh-TW", "科倫坡" },
                { "en", "Colombo" }
            },
            ["Asia/Damascus"] = new()
            {
                { "zh-CN", "大马士革" },
                { "zh-TW", "大馬士革" },
                { "en", "Damascus" }
            },
            ["Asia/Dhaka"] = new()
            {
                { "zh-CN", "达卡" },
                { "zh-TW", "達卡" },
                { "en", "Dhaka" }
            },
            ["Asia/Dubai"] = new()
            {
                { "zh-CN", "迪拜" },
                { "zh-TW", "迪拜" },
                { "en", "Dubai" }
            },
            ["Asia/Dushanbe"] = new()
            {
                { "zh-CN", "杜尚别" },
                { "zh-TW", "杜尚別" },
                { "en", "Dushanbe" }
            },
            ["Asia/Gaza"] = new()
            {
                { "zh-CN", "加沙" },
                { "zh-TW", "加沙" },
                { "en", "Gaza" }
            },
            ["Asia/Hanoi"] = new()
            {
                { "zh-CN", "河内" },
                { "zh-TW", "河內" },
                { "en", "Hanoi" }
            },
            ["Asia/Harbin"] = new()
            {
                { "zh-CN", "哈尔滨" },
                { "zh-TW", "哈爾濱" },
                { "en", "Harbin" }
            },
            ["Asia/Hebron"] = new()
            {
                { "zh-CN", "希伯伦" },
                { "zh-TW", "希伯倫" },
                { "en", "Hebron" }
            },
            ["Asia/Ho_Chi_Minh"] = new()
            {
                { "zh-CN", "胡志明市" },
                { "zh-TW", "胡志明市" },
                { "en", "Ho Chi Minh" }
            },
            ["Asia/Hong_Kong"] = new()
            {
                { "zh-CN", "香港" },
                { "zh-TW", "香港" },
                { "en", "Hong Kong" }
            },
            ["Asia/Irkutsk"] = new()
            {
                { "zh-CN", "伊尔库茨克" },
                { "zh-TW", "伊爾庫茨克" },
                { "en", "Irkutsk" }
            },
            ["Asia/Jakarta"] = new()
            {
                { "zh-CN", "雅加达" },
                { "zh-TW", "雅加達" },
                { "en", "Jakarta" }
            },
            ["Asia/Jayapura"] = new()
            {
                { "zh-CN", "查亚普拉" },
                { "zh-TW", "查亞普拉" },
                { "en", "Jayapura" }
            },
            ["Asia/Jerusalem"] = new()
            {
                { "zh-CN", "耶路撒冷" },
                { "zh-TW", "耶路撒冷" },
                { "en", "Jerusalem" }
            },
            ["Asia/Kabul"] = new()
            {
                { "zh-CN", "喀布尔" },
                { "zh-TW", "喀布爾" },
                { "en", "Kabul" }
            },
            ["Asia/Kamchatka"] = new()
            {
                { "zh-CN", "堪察加" },
                { "zh-TW", "堪察加" },
                { "en", "Kamchatka" }
            },
            ["Asia/Karachi"] = new()
            {
                { "zh-CN", "卡拉奇" },
                { "zh-TW", "卡拉奇" },
                { "en", "Karachi" }
            },
            ["Asia/Kashgar"] = new()
            {
                { "zh-CN", "喀什" },
                { "zh-TW", "喀什" },
                { "en", "Kashgar" }
            },
            ["Asia/Kathmandu"] = new()
            {
                { "zh-CN", "加德满都" },
                { "zh-TW", "加德滿都" },
                { "en", "Kathmandu" }
            },
            ["Asia/Khandyga"] = new()
            {
                { "zh-CN", "汉德加" },
                { "zh-TW", "漢德加" },
                { "en", "Khandyga" }
            },
            ["Asia/Kolkata"] = new()
            {
                { "zh-CN", "新德里" },
                { "zh-TW", "新德里" },
                { "en", "Kolkata" }
            },
            ["Asia/Krasnoyarsk"] = new()
            {
                { "zh-CN", "克拉斯诺亚尔斯克" },
                { "zh-TW", "克拉斯諾亞爾斯克" },
                { "en", "Krasnoyarsk" }
            },
            ["Asia/Kuala_Lumpur"] = new()
            {
                { "zh-CN", "吉隆坡" },
                { "zh-TW", "吉隆坡" },
                { "en", "Kuala Lumpur" }
            },
            ["Asia/Kuwait"] = new()
            {
                { "zh-CN", "科威特城" },
                { "zh-TW", "科威特城" },
                { "en", "Kuwait" }
            },
            ["Asia/Macau"] = new()
            {
                { "zh-CN", "澳门" },
                { "zh-TW", "澳門" },
                { "en", "Macau" }
            },
            ["Asia/Magadan"] = new()
            {
                { "zh-CN", "马加丹" },
                { "zh-TW", "馬加丹" },
                { "en", "Magadan" }
            },
            ["Asia/Makassar"] = new()
            {
                { "zh-CN", "望加锡" },
                { "zh-TW", "望加錫" },
                { "en", "Makassar" }
            },
            ["Asia/Male"] = new()
            {
                { "zh-CN", "马累" },
                { "zh-TW", "馬累" },
                { "en", "Male" }
            },
            ["Asia/Manila"] = new()
            {
                { "zh-CN", "马尼拉" },
                { "zh-TW", "馬尼拉" },
                { "en", "Manila" }
            },
            ["Asia/Muscat"] = new()
            {
                { "zh-CN", "马斯喀特" },
                { "zh-TW", "馬斯喀特" },
                { "en", "Muscat" }
            },
            ["Asia/Nicosia"] = new()
            {
                { "zh-CN", "尼科西亚" },
                { "zh-TW", "尼科西亞" },
                { "en", "Nicosia" }
            },
            ["Asia/Novokuznetsk"] = new()
            {
                { "zh-CN", "新库兹涅茨克" },
                { "zh-TW", "新庫茲涅茨克" },
                { "en", "Novokuznetsk" }
            },
            ["Asia/Novosibirsk"] = new()
            {
                { "zh-CN", "新西伯利亚" },
                { "zh-TW", "新西伯利亞" },
                { "en", "Novosibirsk" }
            },
            ["Asia/Omsk"] = new()
            {
                { "zh-CN", "鄂木斯克" },
                { "zh-TW", "鄂木斯克" },
                { "en", "Omsk" }
            },
            ["Asia/Oral"] = new()
            {
                { "zh-CN", "乌拉尔" },
                { "zh-TW", "烏拉爾" },
                { "en", "Oral" }
            },
            ["Asia/Phnom_Penh"] = new()
            {
                { "zh-CN", "金边" },
                { "zh-TW", "金邊" },
                { "en", "Phnom Penh" }
            },
            ["Asia/Pontianak"] = new()
            {
                { "zh-CN", "坤甸" },
                { "zh-TW", "坤甸" },
                { "en", "Pontianak" }
            },
            ["Asia/Pyongyang"] = new()
            {
                { "zh-CN", "平壤" },
                { "zh-TW", "平壤" },
                { "en", "Pyongyang" }
            },
            ["Asia/Qatar"] = new()
            {
                { "zh-CN", "多哈" },
                { "zh-TW", "多哈" },
                { "en", "Qatar" }
            },
            ["Asia/Qyzylorda"] = new()
            {
                { "zh-CN", "克孜勒奥尔达" },
                { "zh-TW", "克孜勒奧爾達" },
                { "en", "Qyzylorda" }
            },
            ["Asia/Riyadh"] = new()
            {
                { "zh-CN", "利雅得" },
                { "zh-TW", "利雅得" },
                { "en", "Riyadh" }
            },
            ["Asia/Sakhalin"] = new()
            {
                { "zh-CN", "南萨哈林斯克" },
                { "zh-TW", "南薩哈林斯克" },
                { "en", "Sakhalin" }
            },
            ["Asia/Samarkand"] = new()
            {
                { "zh-CN", "撒马尔罕" },
                { "zh-TW", "撒馬爾罕" },
                { "en", "Samarkand" }
            },
            ["Asia/Seoul"] = new()
            {
                { "zh-CN", "首尔" },
                { "zh-TW", "首爾" },
                { "en", "Seoul" }
            },
            ["Asia/Shanghai"] = new()
            {
                { "zh-CN", "北京/上海" },
                { "zh-TW", "北京/上海" },
                { "en", "Shanghai" }
            },
            ["Asia/Singapore"] = new()
            {
                { "zh-CN", "新加坡" },
                { "zh-TW", "新加坡" },
                { "en", "Singapore" }
            },
            ["Asia/Srednekolymsk"] = new()
            {
                { "zh-CN", "中科雷姆斯克" },
                { "zh-TW", "中科雷姆斯克" },
                { "en", "Srednekolymsk" }
            },
            ["Asia/Taipei"] = new()
            {
                { "zh-CN", "台北" },
                { "zh-TW", "台北" },
                { "en", "Taipei" }
            },
            ["Asia/Tashkent"] = new()
            {
                { "zh-CN", "塔什干" },
                { "zh-TW", "塔什干" },
                { "en", "Tashkent" }
            },
            ["Asia/Tbilisi"] = new()
            {
                { "zh-CN", "第比利斯" },
                { "zh-TW", "第比利斯" },
                { "en", "Tbilisi" }
            },
            ["Asia/Tehran"] = new()
            {
                { "zh-CN", "德黑兰" },
                { "zh-TW", "德黑蘭" },
                { "en", "Tehran" }
            },
            ["Asia/Thimphu"] = new()
            {
                { "zh-CN", "廷布" },
                { "zh-TW", "廷布" },
                { "en", "Thimphu" }
            },
            ["Asia/Tokyo"] = new()
            {
                { "zh-CN", "东京" },
                { "zh-TW", "東京" },
                { "en", "Tokyo" }
            },
            ["Asia/Tomsk"] = new()
            {
                { "zh-CN", "托木斯克" },
                { "zh-TW", "托木斯克" },
                { "en", "Tomsk" }
            },
            ["Asia/Ulaanbaatar"] = new()
            {
                { "zh-CN", "乌兰巴托" },
                { "zh-TW", "烏蘭巴托" },
                { "en", "Ulaanbaatar" }
            },
            ["Asia/Urumqi"] = new()
            {
                { "zh-CN", "乌鲁木齐" },
                { "zh-TW", "烏魯木齊" },
                { "en", "Urumqi" }
            },
            ["Asia/Ust-Nera"] = new()
            {
                { "zh-CN", "乌斯季涅拉" },
                { "zh-TW", "烏斯季涅拉" },
                { "en", "Ust-Nera" }
            },
            ["Asia/Vientiane"] = new()
            {
                { "zh-CN", "万象" },
                { "zh-TW", "萬象" },
                { "en", "Vientiane" }
            },
            ["Asia/Vladivostok"] = new()
            {
                { "zh-CN", "符拉迪沃斯托克" },
                { "zh-TW", "符拉迪沃斯托克" },
                { "en", "Vladivostok" }
            },
            ["Asia/Yakutsk"] = new()
            {
                { "zh-CN", "雅库茨克" },
                { "zh-TW", "雅庫茨克" },
                { "en", "Yakutsk" }
            },
            ["Asia/Yangon"] = new()
            {
                { "zh-CN", "仰光" },
                { "zh-TW", "仰光" },
                { "en", "Yangon" }
            },
            ["Asia/Yerevan"] = new()
            {
                { "zh-CN", "埃里温" },
                { "zh-TW", "埃里溫" },
                { "en", "Yerevan" }
            },
            ["Atlantic/Azores"] = new()
            {
                { "zh-CN", "亚速尔群岛" },
                { "zh-TW", "亚速尔群岛" },
                { "en", "Azores" }
            },
            ["Atlantic/Canary"] = new()
            {
                { "zh-CN", "加那利群岛" },
                { "zh-TW", "加那利群岛" },
                { "en", "Canary" }
            },
            ["Atlantic/Cape_Verde"] = new()
            {
                { "zh-CN", "佛得角" },
                { "zh-TW", "佛得角" },
                { "en", "Cape Verde" }
            },
            ["Atlantic/Faroe"] = new()
            {
                { "zh-CN", "法罗群岛" },
                { "zh-TW", "法罗群岛" },
                { "en", "Faroe" }
            },
            ["Atlantic/Jan_Mayen"] = new()
            {
                { "zh-CN", "扬马延" },
                { "zh-TW", "扬马延" },
                { "en", "Jan Mayen" }
            },
            ["Atlantic/Madeira"] = new()
            {
                { "zh-CN", "马德拉" },
                { "zh-TW", "马德拉" },
                { "en", "Madeira" }
            },
            ["Atlantic/Reykjavik"] = new()
            {
                { "zh-CN", "雷克雅未克(冰)" },
                { "zh-TW", "雷克雅未克(冰)" },
                { "en", "Reykjavik" }
            },
            ["Atlantic/South_Georgia"] = new()
            {
                { "zh-CN", "南乔治亚岛" },
                { "zh-TW", "南乔治亚岛" },
                { "en", "South Georgia" }
            },
            ["Atlantic/St_Helena"] = new()
            {
                { "zh-CN", "圣赫勒拿" },
                { "zh-TW", "圣赫勒拿" },
                { "en", "St Helena" }
            },
            ["Australia/Adelaide"] = new()
            {
                { "zh-CN", "阿德莱德" },
                { "zh-TW", "阿德莱德" },
                { "en", "Adelaide" }
            },
            ["Australia/Brisbane"] = new()
            {
                { "zh-CN", "布里斯班" },
                { "zh-TW", "布里斯班" },
                { "en", "Brisbane" }
            },
            ["Australia/Broken_Hill"] = new()
            {
                { "zh-CN", "布罗肯希尔" },
                { "zh-TW", "布罗肯希尔" },
                { "en", "Broken Hill" }
            },
            ["Australia/Currie"] = new()
            {
                { "zh-CN", "柯里" },
                { "zh-TW", "柯里" },
                { "en", "Currie" }
            },
            ["Australia/Darwin"] = new()
            {
                { "zh-CN", "达尔文" },
                { "zh-TW", "达尔文" },
                { "en", "Darwin" }
            },
            ["Australia/Eucla"] = new()
            {
                { "zh-CN", "尤克拉" },
                { "zh-TW", "尤克拉" },
                { "en", "Eucla" }
            },
            ["Australia/Hobart"] = new()
            {
                { "zh-CN", "霍巴特" },
                { "zh-TW", "霍巴特" },
                { "en", "Hobart" }
            },
            ["Australia/Lindeman"] = new()
            {
                { "zh-CN", "林德曼岛" },
                { "zh-TW", "林德曼岛" },
                { "en", "Lindeman" }
            },
            ["Australia/Lord_Howe"] = new()
            {
                { "zh-CN", "豪勋爵岛" },
                { "zh-TW", "豪勋爵岛" },
                { "en", "Lord Howe" }
            },
            ["Australia/Melbourne"] = new()
            {
                { "zh-CN", "墨尔本" },
                { "zh-TW", "墨尔本" },
                { "en", "Melbourne" }
            },
            ["Australia/Perth"] = new()
            {
                { "zh-CN", "珀斯" },
                { "zh-TW", "珀斯" },
                { "en", "Perth" }
            },
            ["Australia/Sydney"] = new()
            {
                { "zh-CN", "悉尼" },
                { "zh-TW", "悉尼" },
                { "en", "Sydney" }
            },
            ["Europe/Amsterdam"] = new()
            {
                { "zh-CN", "阿姆斯特丹" },
                { "zh-TW", "阿姆斯特丹" },
                { "en", "Amsterdam" }
            },
            ["Europe/Andorra"] = new()
            {
                { "zh-CN", "安道尔" },
                { "zh-TW", "安道爾" },
                { "en", "Andorra" }
            },
            ["Europe/Astrakhan"] = new()
            {
                { "zh-CN", "阿斯特拉罕" },
                { "zh-TW", "阿斯特拉罕" },
                { "en", "Astrakhan" }
            },
            ["Europe/Athens"] = new()
            {
                { "zh-CN", "雅典" },
                { "zh-TW", "雅典" },
                { "en", "Athens" }
            },
            ["Europe/Belgrade"] = new()
            {
                { "zh-CN", "贝尔格莱德" },
                { "zh-TW", "貝爾格萊德" },
                { "en", "Belgrade" }
            },
            ["Europe/Berlin"] = new()
            {
                { "zh-CN", "柏林" },
                { "zh-TW", "柏林" },
                { "en", "Berlin" }
            },
            ["Europe/Bratislava"] = new()
            {
                { "zh-CN", "布拉迪斯拉发" },
                { "zh-TW", "布拉迪斯拉發" },
                { "en", "Bratislava" }
            },
            ["Europe/Brussels"] = new()
            {
                { "zh-CN", "布鲁塞尔" },
                { "zh-TW", "布魯塞爾" },
                { "en", "Brussels" }
            },
            ["Europe/Bucharest"] = new()
            {
                { "zh-CN", "布加勒斯特" },
                { "zh-TW", "布加勒斯特" },
                { "en", "Bucharest" }
            },
            ["Europe/Budapest"] = new()
            {
                { "zh-CN", "布达佩斯" },
                { "zh-TW", "布達佩斯" },
                { "en", "Budapest" }
            },
            ["Europe/Busingen"] = new()
            {
                { "zh-CN", "布辛根" },
                { "zh-TW", "布辛根" },
                { "en", "Busingen" }
            },
            ["Europe/Chisinau"] = new()
            {
                { "zh-CN", "基希讷乌" },
                { "zh-TW", "基希訥烏" },
                { "en", "Chisinau" }
            },
            ["Europe/Copenhagen"] = new()
            {
                { "zh-CN", "哥本哈根" },
                { "zh-TW", "哥本哈根" },
                { "en", "Copenhagen" }
            },
            ["Europe/Dublin"] = new()
            {
                { "zh-CN", "都柏林" },
                { "zh-TW", "都柏林" },
                { "en", "Dublin" }
            },
            ["Europe/Faroe"] = new()
            {
                { "zh-CN", "托尔斯港" },
                { "zh-TW", "托爾斯港" },
                { "en", "Faroe" }
            },
            ["Europe/Geneva"] = new()
            {
                { "zh-CN", "日内瓦" },
                { "zh-TW", "日內瓦" },
                { "en", "Geneva" }
            },
            ["Europe/Gibraltar"] = new()
            {
                { "zh-CN", "直布罗陀" },
                { "zh-TW", "直布羅陀" },
                { "en", "Gibraltar" }
            },
            ["Europe/Guernsey"] = new()
            {
                { "zh-CN", "圣彼得港" },
                { "zh-TW", "聖彼得港" },
                { "en", "Guernsey" }
            },
            ["Europe/Helsinki"] = new()
            {
                { "zh-CN", "赫尔辛基" },
                { "zh-TW", "赫爾辛基" },
                { "en", "Helsinki" }
            },
            ["Europe/Isle_of_Man"] = new()
            {
                { "zh-CN", "道格拉斯" },
                { "zh-TW", "道格拉斯" },
                { "en", "Isle of Man" }
            },
            ["Europe/Istanbul"] = new()
            {
                { "zh-CN", "伊斯坦布尔" },
                { "zh-TW", "伊斯坦布爾" },
                { "en", "Istanbul" }
            },
            ["Europe/Jersey"] = new()
            {
                { "zh-CN", "圣赫利尔" },
                { "zh-TW", "聖赫利爾" },
                { "en", "Jersey" }
            },
            ["Europe/Kaliningrad"] = new()
            {
                { "zh-CN", "加里宁格勒" },
                { "zh-TW", "加里寧格勒" },
                { "en", "Kaliningrad" }
            },
            ["Europe/Kyiv"] = new()
            {
                { "zh-CN", "基辅" },
                { "zh-TW", "基輔" },
                { "en", "Kyiv" }
            },
            ["Europe/Lisbon"] = new()
            {
                { "zh-CN", "里斯本" },
                { "zh-TW", "里斯本" },
                { "en", "Lisbon" }
            },
            ["Europe/Ljubljana"] = new()
            {
                { "zh-CN", "卢布尔雅那" },
                { "zh-TW", "盧布爾雅那" },
                { "en", "Ljubljana" }
            },
            ["Europe/London"] = new()
            {
                { "zh-CN", "伦敦" },
                { "zh-TW", "倫敦" },
                { "en", "London" }
            },
            ["Europe/Luxembourg"] = new()
            {
                { "zh-CN", "卢森堡" },
                { "zh-TW", "盧森堡" },
                { "en", "Luxembourg" }
            },
            ["Europe/Madrid"] = new()
            {
                { "zh-CN", "马德里" },
                { "zh-TW", "馬德里" },
                { "en", "Madrid" }
            },
            ["Europe/Malta"] = new()
            {
                { "zh-CN", "瓦莱塔" },
                { "zh-TW", "瓦萊塔" },
                { "en", "Malta" }
            },
            ["Europe/Mariehamn"] = new()
            {
                { "zh-CN", "玛丽港" },
                { "zh-TW", "瑪麗港" },
                { "en", "Mariehamn" }
            },
            ["Europe/Milan"] = new()
            {
                { "zh-CN", "米兰" },
                { "zh-TW", "米蘭" },
                { "en", "Milan" }
            },
            ["Europe/Minsk"] = new()
            {
                { "zh-CN", "明斯克" },
                { "zh-TW", "明斯克" },
                { "en", "Minsk" }
            },
            ["Europe/Monaco"] = new()
            {
                { "zh-CN", "摩纳哥" },
                { "zh-TW", "摩納哥" },
                { "en", "Monaco" }
            },
            ["Europe/Moscow"] = new()
            {
                { "zh-CN", "莫斯科" },
                { "zh-TW", "莫斯科" },
                { "en", "Moscow" }
            },
            ["Europe/Munich"] = new()
            {
                { "zh-CN", "慕尼黑" },
                { "zh-TW", "慕尼黑" },
                { "en", "Munich" }
            },
            ["Europe/Nicosia"] = new()
            {
                { "zh-CN", "尼科西亚(欧洲)" },
                { "zh-TW", "尼科西亞(欧洲)" },
                { "en", "Nicosia" }
            },
            ["Europe/Oslo"] = new()
            {
                { "zh-CN", "奥斯陆" },
                { "zh-TW", "奧斯陸" },
                { "en", "Oslo" }
            },
            ["Europe/Paris"] = new()
            {
                { "zh-CN", "巴黎" },
                { "zh-TW", "巴黎" },
                { "en", "Paris" }
            },
            ["Europe/Podgorica"] = new()
            {
                { "zh-CN", "波德戈里察" },
                { "zh-TW", "波德戈里察" },
                { "en", "Podgorica" }
            },
            ["Europe/Prague"] = new()
            {
                { "zh-CN", "布拉格" },
                { "zh-TW", "布拉格" },
                { "en", "Prague" }
            },
            ["Europe/Pristina"] = new()
            {
                { "zh-CN", "普里什蒂纳" },
                { "zh-TW", "普里什蒂納" },
                { "en", "Pristina" }
            },
            ["Europe/Reykjavik"] = new()
            {
                { "zh-CN", "雷克雅未克" },
                { "zh-TW", "雷克雅未克" },
                { "en", "Reykjavik" }
            },
            ["Europe/Riga"] = new()
            {
                { "zh-CN", "里加" },
                { "zh-TW", "里加" },
                { "en", "Riga" }
            },
            ["Europe/Rome"] = new()
            {
                { "zh-CN", "罗马" },
                { "zh-TW", "羅馬" },
                { "en", "Rome" }
            },
            ["Europe/Saint_Petersburg"] = new()
            {
                { "zh-CN", "圣彼得堡" },
                { "zh-TW", "聖彼得堡" },
                { "en", "Saint Petersburg" }
            },
            ["Europe/Samara"] = new()
            {
                { "zh-CN", "萨马拉" },
                { "zh-TW", "薩馬拉" },
                { "en", "Samara" }
            },
            ["Europe/San_Marino"] = new()
            {
                { "zh-CN", "圣马力诺" },
                { "zh-TW", "聖馬力諾" },
                { "en", "San Marino" }
            },
            ["Europe/Sarajevo"] = new()
            {
                { "zh-CN", "萨拉热窝" },
                { "zh-TW", "薩拉熱窩" },
                { "en", "Sarajevo" }
            },
            ["Europe/Saratov"] = new()
            {
                { "zh-CN", "萨拉托夫" },
                { "zh-TW", "薩拉托夫" },
                { "en", "Saratov" }
            },
            ["Europe/Skopje"] = new()
            {
                { "zh-CN", "斯科普里" },
                { "zh-TW", "斯科普里" },
                { "en", "Skopje" }
            },
            ["Europe/Sofia"] = new()
            {
                { "zh-CN", "索非亚" },
                { "zh-TW", "索非亞" },
                { "en", "Sofia" }
            },
            ["Europe/Stockholm"] = new()
            {
                { "zh-CN", "斯德哥尔摩" },
                { "zh-TW", "斯德哥爾摩" },
                { "en", "Stockholm" }
            },
            ["Europe/Tallinn"] = new()
            {
                { "zh-CN", "塔林" },
                { "zh-TW", "塔林" },
                { "en", "Tallinn" }
            },
            ["Europe/Tirane"] = new()
            {
                { "zh-CN", "地拉那" },
                { "zh-TW", "地拉那" },
                { "en", "Tirane" }
            },
            ["Europe/Tiraspol"] = new()
            {
                { "zh-CN", "蒂拉斯波尔" },
                { "zh-TW", "蒂拉斯波爾" },
                { "en", "Tiraspol" }
            },
            ["Europe/Ulyanovsk"] = new()
            {
                { "zh-CN", "乌里扬诺夫斯克" },
                { "zh-TW", "烏里揚諾夫斯克" },
                { "en", "Ulyanovsk" }
            },
            ["Europe/Vaduz"] = new()
            {
                { "zh-CN", "瓦杜兹" },
                { "zh-TW", "瓦杜茲" },
                { "en", "Vaduz" }
            },
            ["Europe/Vatican"] = new()
            {
                { "zh-CN", "梵蒂冈" },
                { "zh-TW", "梵蒂岡" },
                { "en", "Vatican" }
            },
            ["Europe/Vienna"] = new()
            {
                { "zh-CN", "维也纳" },
                { "zh-TW", "維也納" },
                { "en", "Vienna" }
            },
            ["Europe/Vilnius"] = new()
            {
                { "zh-CN", "维尔纽斯" },
                { "zh-TW", "維爾紐斯" },
                { "en", "Vilnius" }
            },
            ["Europe/Volgograd"] = new()
            {
                { "zh-CN", "伏尔加格勒" },
                { "zh-TW", "伏爾加格勒" },
                { "en", "Volgograd" }
            },
            ["Europe/Warsaw"] = new()
            {
                { "zh-CN", "华沙" },
                { "zh-TW", "華沙" },
                { "en", "Warsaw" }
            },
            ["Europe/Zagreb"] = new()
            {
                { "zh-CN", "萨格勒布" },
                { "zh-TW", "薩格勒布" },
                { "en", "Zagreb" }
            },
            ["Europe/Zurich"] = new()
            {
                { "zh-CN", "苏黎世" },
                { "zh-TW", "蘇黎世" },
                { "en", "Zurich" }
            },
            ["Pacific/Apia"] = new()
            {
                { "zh-CN", "阿皮亚" },
                { "zh-TW", "阿皮亚" },
                { "en", "Apia" }
            },
            ["Pacific/Auckland"] = new()
            {
                { "zh-CN", "奥克兰" },
                { "zh-TW", "奥克兰" },
                { "en", "Auckland" }
            },
            ["Pacific/Bougainville"] = new()
            {
                { "zh-CN", "布干维尔" },
                { "zh-TW", "布干维尔" },
                { "en", "Bougainville" }
            },
            ["Pacific/Chatham"] = new()
            {
                { "zh-CN", "查塔姆群岛" },
                { "zh-TW", "查塔姆群岛" },
                { "en", "Chatham" }
            },
            ["Pacific/Chuuk"] = new()
            {
                { "zh-CN", "楚克" },
                { "zh-TW", "楚克" },
                { "en", "Chuuk" }
            },
            ["Pacific/Efate"] = new()
            {
                { "zh-CN", "维拉港" },
                { "zh-TW", "维拉港" },
                { "en", "Efate" }
            },
            ["Pacific/Enderbury"] = new()
            {
                { "zh-CN", "恩德伯里岛" },
                { "zh-TW", "恩德伯里岛" },
                { "en", "Enderbury" }
            },
            ["Pacific/Eua"] = new()
            {
                { "zh-CN", "埃瓦岛" },
                { "zh-TW", "埃瓦岛" },
                { "en", "Eua" }
            },
            ["Pacific/Fiji"] = new()
            {
                { "zh-CN", "苏瓦" },
                { "zh-TW", "苏瓦" },
                { "en", "Fiji" }
            },
            ["Pacific/Funafuti"] = new()
            {
                { "zh-CN", "富纳富提(图)" },
                { "zh-TW", "富纳富提(图)" },
                { "en", "Funafuti" }
            },
            ["Pacific/Gambier"] = new()
            {
                { "zh-CN", "甘比尔群岛" },
                { "zh-TW", "甘比尔群岛" },
                { "en", "Gambier" }
            },
            ["Pacific/Guadalcanal"] = new()
            {
                { "zh-CN", "霍尼亚拉" },
                { "zh-TW", "霍尼亚拉" },
                { "en", "Guadalcanal" }
            },
            ["Pacific/Guam"] = new()
            {
                { "zh-CN", "阿加尼亚" },
                { "zh-TW", "阿加尼亚" },
                { "en", "Guam" }
            },
            ["Pacific/Honolulu"] = new()
            {
                { "zh-CN", "檀香山" },
                { "zh-TW", "檀香山" },
                { "en", "Honolulu" }
            },
            ["Pacific/Johnston"] = new()
            {
                { "zh-CN", "约翰斯顿岛" },
                { "zh-TW", "约翰斯顿岛" },
                { "en", "Johnston" }
            },
            ["Pacific/Kiritimati"] = new()
            {
                { "zh-CN", "圣诞岛" },
                { "zh-TW", "圣诞岛" },
                { "en", "Kiritimati" }
            },
            ["Pacific/Kosrae"] = new()
            {
                { "zh-CN", "科斯雷" },
                { "zh-TW", "科斯雷" },
                { "en", "Kosrae" }
            },
            ["Pacific/Kwajalein"] = new()
            {
                { "zh-CN", "夸贾林" },
                { "zh-TW", "夸贾林" },
                { "en", "Kwajalein" }
            },
            ["Pacific/Majuro"] = new()
            {
                { "zh-CN", "马朱罗" },
                { "zh-TW", "马朱罗" },
                { "en", "Majuro" }
            },
            ["Pacific/Marquesas"] = new()
            {
                { "zh-CN", "马克萨斯群岛" },
                { "zh-TW", "马克萨斯群岛" },
                { "en", "Marquesas" }
            },
            ["Pacific/Midway"] = new()
            {
                { "zh-CN", "中途岛" },
                { "zh-TW", "中途岛" },
                { "en", "Midway" }
            },
            ["Pacific/Nauru"] = new()
            {
                { "zh-CN", "亚伦" },
                { "zh-TW", "亚伦" },
                { "en", "Nauru" }
            },
            ["Pacific/Niue"] = new()
            {
                { "zh-CN", "阿洛菲" },
                { "zh-TW", "阿洛菲" },
                { "en", "Niue" }
            },
            ["Pacific/Norfolk"] = new()
            {
                { "zh-CN", "金斯敦" },
                { "zh-TW", "金斯敦" },
                { "en", "Norfolk" }
            },
            ["Pacific/Noumea"] = new()
            {
                { "zh-CN", "努美阿" },
                { "zh-TW", "努美阿" },
                { "en", "Noumea" }
            },
            ["Pacific/Pago_Pago"] = new()
            {
                { "zh-CN", "帕果帕果" },
                { "zh-TW", "帕果帕果" },
                { "en", "Pago Pago" }
            },
            ["Pacific/Palau"] = new()
            {
                { "zh-CN", "梅莱凯奥克" },
                { "zh-TW", "梅莱凯奥克" },
                { "en", "Palau" }
            },
            ["Pacific/Pitcairn"] = new()
            {
                { "zh-CN", "亚当斯敦" },
                { "zh-TW", "亚当斯敦" },
                { "en", "Pitcairn" }
            },
            ["Pacific/Pohnpei"] = new()
            {
                { "zh-CN", "波纳佩(波)" },
                { "zh-TW", "波纳佩(波)" },
                { "en", "Pohnpei" }
            },
            ["Pacific/Ponape"] = new()
            {
                { "zh-CN", "波纳佩" },
                { "zh-TW", "波纳佩" },
                { "en", "Ponape" }
            },
            ["Pacific/Port_Moresby"] = new()
            {
                { "zh-CN", "莫尔兹比港" },
                { "zh-TW", "莫尔兹比港" },
                { "en", "Port Moresby" }
            },
            ["Pacific/Rarotonga"] = new()
            {
                { "zh-CN", "阿瓦鲁阿" },
                { "zh-TW", "阿瓦鲁阿" },
                { "en", "Rarotonga" }
            },
            ["Pacific/Saipan"] = new()
            {
                { "zh-CN", "塞班" },
                { "zh-TW", "塞班" },
                { "en", "Saipan" }
            },
            ["Pacific/Tahiti"] = new()
            {
                { "zh-CN", "帕皮提" },
                { "zh-TW", "帕皮提" },
                { "en", "Tahiti" }
            },
            ["Pacific/Tarawa"] = new()
            {
                { "zh-CN", "塔拉瓦" },
                { "zh-TW", "塔拉瓦" },
                { "en", "Tarawa" }
            },
            ["Pacific/Tongatapu"] = new()
            {
                { "zh-CN", "努库阿洛法" },
                { "zh-TW", "努库阿洛法" },
                { "en", "Tongatapu" }
            },
            ["Pacific/Truk"] = new()
            {
                { "zh-CN", "特鲁克" },
                { "zh-TW", "特鲁克" },
                { "en", "Truk" }
            },
            ["Pacific/Tuvalu"] = new()
            {
                { "zh-CN", "富纳富提" },
                { "zh-TW", "富纳富提" },
                { "en", "Tuvalu" }
            },
            ["Pacific/Wake"] = new()
            {
                { "zh-CN", "威克岛" },
                { "zh-TW", "威克岛" },
                { "en", "Wake" }
            },
            ["Pacific/Wallis"] = new()
            {
                { "zh-CN", "马塔乌图" },
                { "zh-TW", "马塔乌图" },
                { "en", "Wallis" }
            },
            ["Pacific/Yap"] = new()
            {
                { "zh-CN", "雅浦" },
                { "zh-TW", "雅浦" },
                { "en", "Yap" }
            }
        };

        /// <summary>
        /// 获取时区的多语言名称
        /// </summary>
        public static string GetName(string timeZoneId, string lang)
        {
            if (Translations.TryGetValue(timeZoneId, out var langDict))
            {
                // 中文语言优先查找对应翻译
                if (lang.StartsWith("zh"))
                {
                    if (langDict.TryGetValue(lang, out var zhValue)) return zhValue;
                    if (langDict.TryGetValue("zh-CN", out var zhCnValue)) return zhCnValue;
                }
                // 其他语言统一用英文
                if (langDict.TryGetValue("en", out var enValue)) return enValue;
            }
            // 没有翻译的时区，从 IANA ID 提取英文城市名
            var parts = timeZoneId.Split('/');
            if (parts.Length > 0)
            {
                return parts[^1].Replace('_', ' ');
            }
            return timeZoneId;
        }
    }
}