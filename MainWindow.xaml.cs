using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;

namespace macOSClock
{
    public partial class MainWindow : Window
    {
        private IntPtr _hwnd;
        private DispatcherTimer? _timer;
        private bool _isLoading = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _hwnd = new WindowInteropHelper(this).Handle;

            // 加载设置
            SettingsManager.Load();

            // 初始化下拉框
            InitLanguageComboBox();
            InitTimeZoneComboBox();

            // 应用主题
            ApplyTheme();

            // 应用语言
            ApplyLanguage();

            // 应用置顶
            TopmostToggle.IsChecked = SettingsManager.Settings.IsTopmost;
            this.Topmost = SettingsManager.Settings.IsTopmost;

            // 启动时钟
            StartClock();

            _isLoading = false;
        }

        private void Window_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            // 保存窗口位置
            SettingsManager.Settings.WindowLeft = this.Left;
            SettingsManager.Settings.WindowTop = this.Top;
            SettingsManager.Settings.IsTopmost = this.Topmost;
            SettingsManager.Save();
        }

        // ============ 初始化语言下拉框 ============
        private void InitLanguageComboBox()
        {
            LanguageComboBox.Items.Clear();
            foreach (var lang in LanguageManager.Languages)
            {
                LanguageComboBox.Items.Add(new ComboBoxItem
                {
                    Content = lang.Value,
                    Tag = lang.Key
                });
            }
            LanguageComboBox.SelectedIndex = GetLanguageIndex(LanguageManager.CurrentLang);
        }

        private int GetLanguageIndex(string langCode)
        {
            int index = 0;
            foreach (var lang in LanguageManager.Languages)
            {
                if (lang.Key == langCode) return index;
                index++;
            }
            return 0;
        }

        // ============ 初始化时区下拉框 ============
        private void InitTimeZoneComboBox()
        {
            TimeZoneComboBox.Items.Clear();

            string currentLang = LanguageManager.CurrentLang;
            System.Diagnostics.Debug.WriteLine($"[TimeZone] InitTimeZoneComboBox, CurrentLang={currentLang}");

            // 大洲分组名称多语言
            var groupNames = new Dictionary<string, string[]>
            {
                ["Asia"] = new[] { "亚洲", "亞洲", "Asia", "アジア", "아시아", "Asie", "Asien", "Asia", "Азия", "آسيا", "Ásia", "Asia", "เอเชีย", "Châu Á", "Asia", "Asya", "Azië", "Azja", "Asien" },
                ["Europe"] = new[] { "欧洲", "歐洲", "Europe", "ヨーロッパ", "유럽", "Europe", "Europa", "Europa", "Европа", "أوروبا", "Europa", "Europa", "ยุโรป", "Châu Âu", "Eropa", "Avrupa", "Europa", "Europa", "Europa" },
                ["America"] = new[] { "美洲", "美洲", "America", "アメリカ", "아메리카", "Amérique", "Amerika", "América", "Америка", "أمريكا", "América", "America", "อเมริกา", "Châu Mỹ", "Amerika", "Amerika", "Amerika", "Ameryka", "Amerika" },
                ["Oceania"] = new[] { "大洋洲", "大洋洲", "Oceania", "オセアニア", "오세아니아", "Océanie", "Ozeanien", "Oceanía", "Океания", "أوقيانوسيا", "Oceania", "Oceania", "โอเชียเนีย", "Châu Đại Dương", "Oseania", "Okyanusya", "Oceanië", "Oceania", "Oceanien" },
                ["Africa"] = new[] { "非洲", "非洲", "Africa", "アフリカ", "아프리카", "Afrique", "Afrika", "África", "Африка", "أفريقيا", "África", "Africa", "แอฟริกา", "Châu Phi", "Afrika", "Afrika", "Afrika", "Afryka", "Afrika" }
            };

            // 语言代码到索引的映射
            var langIndex = new Dictionary<string, int>
            {
                { "zh-CN", 0 }, { "zh-TW", 1 }, { "en", 2 }, { "ja", 3 }, { "ko", 4 },
                { "fr", 5 }, { "de", 6 }, { "es", 7 }, { "ru", 8 }, { "ar", 9 },
                { "pt", 10 }, { "it", 11 }, { "th", 12 }, { "vi", 13 }, { "id", 14 },
                { "tr", 15 }, { "nl", 16 }, { "pl", 17 }, { "sv", 18 }
            };

            int idx = langIndex.ContainsKey(currentLang) ? langIndex[currentLang] : 2; // 默认英文

            string[] groupOrder = { "Asia", "Europe", "America", "Oceania", "Africa" };

            for (int i = 0; i < groupOrder.Length; i++)
            {
                if (TimeZoneManager.TimeZones.TryGetValue(groupOrder[i], out var tzList))
                {
                    // 分组标题
                    string groupName = groupNames[groupOrder[i]][idx];
                    TimeZoneComboBox.Items.Add(new ComboBoxItem
                    {
                        Content = $"── {groupName} ──",
                        IsEnabled = false,
                        Foreground = new SolidColorBrush(Color.FromRgb(0x00, 0xE5, 0xFF)),
                        FontWeight = FontWeights.Bold,
                        FontSize = 11
                    });

                    foreach (var tz in tzList)
                    {
                        TimeZoneComboBox.Items.Add(new ComboBoxItem
                        {
                            Content = tz.GetDisplayName(currentLang),
                            Tag = tz.Id
                        });
                    }
                }
            }

            // 选中当前时区
            SelectTimeZone(TimeZoneManager.CurrentTimeZone);
        }

        private void SelectTimeZone(string tzId)
        {
            for (int i = 0; i < TimeZoneComboBox.Items.Count; i++)
            {
                if (TimeZoneComboBox.Items[i] is ComboBoxItem item && item.Tag?.ToString() == tzId)
                {
                    TimeZoneComboBox.SelectedIndex = i;
                    return;
                }
            }
            TimeZoneComboBox.SelectedIndex = 0;
        }

        // ============ 语言切换 ============
        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_isLoading) return;

            if (LanguageComboBox.SelectedItem is ComboBoxItem item && item.Tag != null)
            {
                LanguageManager.CurrentLang = item.Tag.ToString()!;
                ApplyLanguage();
                SettingsManager.Save();
            }
        }

        private void ApplyLanguage()
        {
            var lang = LanguageManager.CurrentLang;
            TitleText.Text = "\uF004; " + LanguageManager.Get("title");
            LangLabel.Text = LanguageManager.Get("language");
            TzLabel.Text = LanguageManager.Get("timezone");
            ThemeLabel.Text = lang.StartsWith("zh") ? "主题颜色" : "Theme Color";
            TopmostToggle.ToolTip = LanguageManager.Get("topmost");

            // 重新初始化时区下拉框（更新语言）
            _isLoading = true;
            InitTimeZoneComboBox();
            _isLoading = false;

            // 更新时区标签
            UpdateTimeZoneLabel();

            // 阿拉伯语RTL
            if (LanguageManager.IsRTL)
            {
                this.FlowDirection = FlowDirection.RightToLeft;
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
            }

            // 更新问候语
            UpdateGreeting();
        }

        // ============ 时区切换 ============
        private void TimeZoneComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_isLoading) return;

            if (TimeZoneComboBox.SelectedItem is ComboBoxItem item && item.Tag != null)
            {
                TimeZoneManager.CurrentTimeZone = item.Tag.ToString()!;
                UpdateTimeZoneLabel();
                SettingsManager.Save();
            }
        }

        private void UpdateTimeZoneLabel()
        {
            TimeZoneLabel.Text = $"{TimeZoneManager.GetCurrentTimeZoneName()} ({TimeZoneManager.GetCurrentUtcOffset()})";
        }

        // ============ 时钟逻辑 ============
        private void StartClock()
        {
            _timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(100) };
            _timer.Tick += (s, _) =>
            {
                var now = TimeZoneManager.GetCurrentTime();

                TimeText.Text = now.ToString("HH:mm:ss");

                try
                {
                    var culture = LanguageManager.GetCulture();
                    var dateFormat = LanguageManager.Get("dateFormat");
                    DateText.Text = now.ToString(dateFormat, culture);
                }
                catch
                {
                    DateText.Text = now.ToString("yyyy-MM-dd dddd");
                }

                double progress = now.Second / 60.0 + now.Millisecond / 60000.0;
                SecondProgress.Width = progress * 250;

                UpdateGreeting();
            };
            _timer.Start();
        }

        private void UpdateGreeting()
        {
            var now = TimeZoneManager.GetCurrentTime();
            int hour = now.Hour;

            string key;
            if (hour >= 5 && hour < 12)
                key = "greeting_morning";
            else if (hour >= 12 && hour < 14)
                key = "greeting_noon";
            else if (hour >= 14 && hour < 18)
                key = "greeting_afternoon";
            else if (hour >= 18 && hour < 21)
                key = "greeting_evening";
            else
                key = "greeting_night";

            GreetingText.Text = LanguageManager.Get(key);
        }

        // ============ 主题颜色 ============
        private void ColorAqua_Click(object sender, RoutedEventArgs e) => SetTheme("aqua");
        private void ColorCyan_Click(object sender, RoutedEventArgs e) => SetTheme("cyan");
        private void ColorPurple_Click(object sender, RoutedEventArgs e) => SetTheme("purple");
        private void ColorPink_Click(object sender, RoutedEventArgs e) => SetTheme("pink");
        private void ColorOrange_Click(object sender, RoutedEventArgs e) => SetTheme("orange");
        private void ColorGreen_Click(object sender, RoutedEventArgs e) => SetTheme("green");
        private void ColorBlue_Click(object sender, RoutedEventArgs e) => SetTheme("blue");
        private void ColorRed_Click(object sender, RoutedEventArgs e) => SetTheme("red");

        private void SetTheme(string themeName)
        {
            ThemeManager.CurrentTheme = themeName;
            ApplyTheme();
            SettingsManager.Save();
        }

        private void ApplyTheme()
        {
            var theme = ThemeManager.CurrentThemeInfo;

            // 更新Acrylic背景（固定深色模式）
            ApplyAcrylic(32, theme.ArgbColor);

            // 更新文字颜色（固定深色模式）
            var textColor = ThemeManager.TextColor;
            TimeText.Foreground = new SolidColorBrush(textColor);
            DateText.Foreground = new SolidColorBrush(ThemeManager.SecondaryTextColor);
            GreetingText.Foreground = new SolidColorBrush(ThemeManager.SecondaryTextColor);
            TitleText.Foreground = new SolidColorBrush(textColor);
            LangLabel.Foreground = new SolidColorBrush(ThemeManager.SecondaryTextColor);
            TzLabel.Foreground = new SolidColorBrush(ThemeManager.SecondaryTextColor);
            ThemeLabel.Foreground = new SolidColorBrush(ThemeManager.SecondaryTextColor);
            TimeZoneLabel.Foreground = new SolidColorBrush(ThemeManager.SecondaryTextColor);

            // 更新进度条颜色
            SecondProgress.Background = new SolidColorBrush(theme.AccentColor);

            // 更新卡片背景（固定深色模式）
            CardBackground.Background = new SolidColorBrush(Color.FromArgb(0x20, 0, 0, 0));

            // 更新选中的颜色点边框
            UpdateColorDotSelection();
        }

        private void UpdateColorDotSelection()
        {
            var buttons = new Dictionary<string, Button>
            {
                ["aqua"] = ColorAqua,
                ["cyan"] = ColorCyan,
                ["purple"] = ColorPurple,
                ["pink"] = ColorPink,
                ["orange"] = ColorOrange,
                ["green"] = ColorGreen,
                ["blue"] = ColorBlue,
                ["red"] = ColorRed
            };

            // 固定深色模式，未选中的颜色点边框透明
            foreach (var btn in buttons.Values)
            {
                btn.BorderBrush = Brushes.Transparent;
            }

            if (buttons.TryGetValue(ThemeManager.CurrentTheme, out var selectedBtn))
            {
                selectedBtn.BorderBrush = new SolidColorBrush(ThemeManager.TextColor);
            }
        }

        // ============ 置顶开关 ============
        private void TopmostToggle_Checked(object sender, RoutedEventArgs e)
        {
            this.Topmost = true;
            SettingsManager.Settings.IsTopmost = true;
        }

        private void TopmostToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Topmost = false;
            SettingsManager.Settings.IsTopmost = false;
        }

        // ============ 窗口控制 ============
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // ============ 窗口拖动 ============
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var element = e.OriginalSource as DependencyObject;
            while (element != null)
            {
                if (element is Button || element is ToggleButton || element is ComboBox)
                    return;
                element = VisualTreeHelper.GetParent(element);
            }

            try { this.DragMove(); } catch { }
        }

        // ============ 应用毛玻璃 ============
        private void ApplyAcrylic(byte opacity, int colorRgb)
        {
            try
            {
                if (_hwnd == IntPtr.Zero)
                    _hwnd = new WindowInteropHelper(this).Handle;

                int argb = (opacity << 24) | colorRgb;

                var accent = new AccentPolicy
                {
                    AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND,
                    GradientColor = argb,
                    AccentFlags = 0x20 | 0x40 | 0x80,
                    AnimationId = 0
                };

                var data = new WindowCompositionAttributeData
                {
                    Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
                    Data = Marshal.AllocHGlobal(Marshal.SizeOf(accent)),
                    DataSize = Marshal.SizeOf(accent)
                };

                Marshal.StructureToPtr(accent, data.Data, false);
                _ = SetWindowCompositionAttribute(_hwnd, ref data);
                Marshal.FreeHGlobal(data.Data);
            }
            catch { }
        }

        // ============ Win32 API ============
        [DllImport("user32.dll")]
        private static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        private enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_ENABLE_ACRYLICBLURBEHIND = 4,
            ACCENT_ENABLE_HOSTBACKDROP = 5
        }

        private enum WindowCompositionAttribute
        {
            WCA_ACCENT_POLICY = 19
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int DataSize;
        }
    }
}
