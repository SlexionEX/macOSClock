using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace macOSClock
{
    /// <summary>
    /// 主题管理器 - 8种霓虹色主题（固定深色模式）
    /// </summary>
    public static class ThemeManager
    {
        public static event EventHandler? ThemeChanged;

        private static string _currentTheme = "aqua";

        /// <summary>
        /// 当前主题名称
        /// </summary>
        public static string CurrentTheme
        {
            get => _currentTheme;
            set
            {
                if (_currentTheme != value)
                {
                    _currentTheme = value;
                    ThemeChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// 是否深色模式（固定为深色）
        /// </summary>
        public static bool IsDarkMode => true;

        /// <summary>
        /// 8种霓虹色主题
        /// </summary>
        public static readonly Dictionary<string, ThemeInfo> Themes = new()
        {
            ["aqua"] = new ThemeInfo
            {
                Name = "Aqua",
                NameZh = "水蓝",
                PrimaryColor = Color.FromRgb(0x20, 0xB2, 0xAA),
                AccentColor = Color.FromRgb(0x00, 0xE5, 0xFF),
                GlowColor = Color.FromRgb(0x00, 0xE5, 0xFF),
                ArgbColor = 0xAAB220
            },
            ["cyan"] = new ThemeInfo
            {
                Name = "Cyan",
                NameZh = "青色",
                PrimaryColor = Color.FromRgb(0x00, 0xCC, 0xCC),
                AccentColor = Color.FromRgb(0x00, 0xFF, 0xFF),
                GlowColor = Color.FromRgb(0x00, 0xFF, 0xFF),
                ArgbColor = 0xCCCC00
            },
            ["purple"] = new ThemeInfo
            {
                Name = "Purple",
                NameZh = "紫色",
                PrimaryColor = Color.FromRgb(0x9B, 0x59, 0xB6),
                AccentColor = Color.FromRgb(0xBF, 0x00, 0xFF),
                GlowColor = Color.FromRgb(0xBF, 0x00, 0xFF),
                ArgbColor = 0xB6599B
            },
            ["pink"] = new ThemeInfo
            {
                Name = "Pink",
                NameZh = "粉色",
                PrimaryColor = Color.FromRgb(0xFF, 0x69, 0xB4),
                AccentColor = Color.FromRgb(0xFF, 0x00, 0xFF),
                GlowColor = Color.FromRgb(0xFF, 0x00, 0xFF),
                ArgbColor = 0xB469FF
            },
            ["orange"] = new ThemeInfo
            {
                Name = "Orange",
                NameZh = "橙色",
                PrimaryColor = Color.FromRgb(0xFF, 0x8C, 0x00),
                AccentColor = Color.FromRgb(0xFF, 0xA5, 0x00),
                GlowColor = Color.FromRgb(0xFF, 0xA5, 0x00),
                ArgbColor = 0x008CFF
            },
            ["green"] = new ThemeInfo
            {
                Name = "Green",
                NameZh = "绿色",
                PrimaryColor = Color.FromRgb(0x00, 0xC8, 0x53),
                AccentColor = Color.FromRgb(0x00, 0xFF, 0x7F),
                GlowColor = Color.FromRgb(0x00, 0xFF, 0x7F),
                ArgbColor = 0x53C800
            },
            ["blue"] = new ThemeInfo
            {
                Name = "Blue",
                NameZh = "蓝色",
                PrimaryColor = Color.FromRgb(0x1E, 0x90, 0xFF),
                AccentColor = Color.FromRgb(0x00, 0x7A, 0xFF),
                GlowColor = Color.FromRgb(0x00, 0x7A, 0xFF),
                ArgbColor = 0xFF901E
            },
            ["red"] = new ThemeInfo
            {
                Name = "Red",
                NameZh = "红色",
                PrimaryColor = Color.FromRgb(0xFF, 0x3B, 0x30),
                AccentColor = Color.FromRgb(0xFF, 0x00, 0x00),
                GlowColor = Color.FromRgb(0xFF, 0x00, 0x00),
                ArgbColor = 0x303BFF
            }
        };

        /// <summary>
        /// 获取当前主题信息
        /// </summary>
        public static ThemeInfo CurrentThemeInfo =>
            Themes.TryGetValue(_currentTheme, out var info) ? info : Themes["aqua"];

        /// <summary>
        /// 获取当前主题的主色画刷
        /// </summary>
        public static SolidColorBrush PrimaryBrush => new(CurrentThemeInfo.PrimaryColor);

        /// <summary>
        /// 获取当前主题的强调色画刷
        /// </summary>
        public static SolidColorBrush AccentBrush => new(CurrentThemeInfo.AccentColor);

        /// <summary>
        /// 获取当前主题的发光色画刷
        /// </summary>
        public static SolidColorBrush GlowBrush => new(CurrentThemeInfo.GlowColor);

        /// <summary>
        /// 获取当前主题的ARGB颜色（用于Acrylic）
        /// </summary>
        public static int ArgbColor => CurrentThemeInfo.ArgbColor;

        /// <summary>
        /// 获取背景颜色（固定深色模式）
        /// </summary>
        public static Color BackgroundColor => Color.FromRgb(0x0A, 0x0A, 0x14);

        /// <summary>
        /// 获取文字颜色（固定深色模式）
        /// </summary>
        public static Color TextColor => Color.FromRgb(0xFF, 0xFF, 0xFF);

        /// <summary>
        /// 获取次要文字颜色（固定深色模式）
        /// </summary>
        public static Color SecondaryTextColor => Color.FromRgb(0xD8, 0xD8, 0xD8);

        /// <summary>
        /// 获取卡片背景颜色（固定深色模式）
        /// </summary>
        public static Color CardBackgroundColor => Color.FromArgb(0x20, 0xFF, 0xFF, 0xFF);

        /// <summary>
        /// 获取边框颜色（固定深色模式）
        /// </summary>
        public static Color BorderColor => Color.FromArgb(0x30, 0xFF, 0xFF, 0xFF);

        /// <summary>
        /// 切换到下一个主题
        /// </summary>
        public static void NextTheme()
        {
            var keys = new List<string>(Themes.Keys);
            var index = keys.IndexOf(_currentTheme);
            index = (index + 1) % keys.Count;
            CurrentTheme = keys[index];
        }
    }

    /// <summary>
    /// 主题信息
    /// </summary>
    public class ThemeInfo
    {
        public string Name { get; set; } = "";
        public string NameZh { get; set; } = "";
        public Color PrimaryColor { get; set; }
        public Color AccentColor { get; set; }
        public Color GlowColor { get; set; }
        public int ArgbColor { get; set; }

        public string DisplayName =>
            System.Globalization.CultureInfo.CurrentCulture.Name.StartsWith("zh")
                ? $"{NameZh} ({Name})"
                : Name;
    }
}
