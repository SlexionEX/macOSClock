using System;
using System.IO;
using System.Text.Json;

namespace macOSClock
{
    /// <summary>
    /// 设置管理器 - 持久化用户设置到本地JSON文件
    /// </summary>
    public static class SettingsManager
    {
        private static readonly string SettingsDir =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Slexion", "macOSClock");

        private static readonly string SettingsPath = Path.Combine(SettingsDir, "settings.json");

        private static AppSettings? _settings;

        /// <summary>
        /// 当前设置
        /// </summary>
        public static AppSettings Settings => _settings ??= Load();

        /// <summary>
        /// 加载设置
        /// </summary>
        public static AppSettings Load()
        {
            try
            {
                if (File.Exists(SettingsPath))
                {
                    var json = File.ReadAllText(SettingsPath);
                    var settings = JsonSerializer.Deserialize<AppSettings>(json);
                    if (settings != null)
                    {
                        _settings = settings;
                        ApplySettings(settings);
                        return settings;
                    }
                }
            }
            catch
            {
                // 加载失败，使用默认设置
            }

            _settings = new AppSettings();
            return _settings;
        }

        /// <summary>
        /// 保存设置
        /// </summary>
        public static void Save()
        {
            try
            {
                if (!Directory.Exists(SettingsDir))
                {
                    Directory.CreateDirectory(SettingsDir);
                }

                // 从管理器同步当前值
                if (_settings != null)
                {
                    _settings.Language = LanguageManager.CurrentLang;
                    _settings.TimeZone = TimeZoneManager.CurrentTimeZone;
                    _settings.Theme = ThemeManager.CurrentTheme;
                }

                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(_settings, options);
                File.WriteAllText(SettingsPath, json);
            }
            catch
            {
                // 保存失败，静默处理
            }
        }

        /// <summary>
        /// 应用设置到各个管理器
        /// </summary>
        private static void ApplySettings(AppSettings settings)
        {
            LanguageManager.CurrentLang = settings.Language;
            TimeZoneManager.CurrentTimeZone = settings.TimeZone;
            ThemeManager.CurrentTheme = settings.Theme;
        }

        /// <summary>
        /// 重置为默认设置
        /// </summary>
        public static void Reset()
        {
            _settings = new AppSettings();
            ApplySettings(_settings);
            Save();
        }

        /// <summary>
        /// 获取设置文件路径
        /// </summary>
        public static string GetSettingsPath() => SettingsPath;
    }

    /// <summary>
    /// 应用设置数据类
    /// </summary>
    public class AppSettings
    {
        public string Language { get; set; } = "zh-CN";
        public string TimeZone { get; set; } = "Asia/Shanghai";
        public string Theme { get; set; } = "aqua";
        public bool IsTopmost { get; set; } = false;
        public double WindowWidth { get; set; } = 420;
        public double WindowHeight { get; set; } = 400;
        public double WindowLeft { get; set; } = double.NaN;
        public double WindowTop { get; set; } = double.NaN;
    }
}
