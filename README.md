# macOSClock

仿 macOS 风格的 Windows 桌面时钟应用，支持全球时区、多语言、深色/浅色主题、高 DPI 适配。

## ✨ 功能特性

- 🌍 **全球时区**：支持 150+ 时区，实时同步各地区时间
- 🌐 **多语言**：简体中文、English，时区名称随界面语言自动切换
- 🌙 **深色/浅色主题**：自动检测系统主题，手动切换
- 🎨 **macOS 风格 UI**：圆角卡片、毛玻璃效果、平滑动画
- 🖱️ **可拖动窗口**：无边框窗口，鼠标拖动移动
- 📐 **高 DPI 适配**：支持 4K 屏幕、系统缩放 125%/150%
- ⚡ **轻量高效**：单文件发布，无需安装 .NET 运行时（可选自包含）

## 🖥️ 系统要求

- **操作系统**：Windows 10 / Windows 11（x64）
- **运行环境**：.NET 8.0 Desktop Runtime（或使用自包含发布版）
- **磁盘空间**：约 50MB（自包含版约 150MB）

## 🚀 编译方法

### 使用 Visual Studio

1. 安装 [Visual Studio 2022](https://visualstudio.microsoft.com/)（含 .NET 8.0 SDK 和 WPF 工作负载）
2. 打开 `macOSClock.csproj`
3. 菜单 `生成` → `生成解决方案`（或按 Ctrl+Shift+B）
4. 编译产物在 `bin/Debug/net8.0-windows/`

### 使用命令行

```bash
# 安装 .NET 8.0 SDK
# https://dotnet.microsoft.com/download

# 编译
dotnet build macOSClock.csproj --configuration Release

# 运行
dotnet run --project macOSClock.csproj

# 单文件发布（框架依赖）
dotnet publish macOSClock.csproj -c Release -r win-x64 --self-contained false /p:PublishSingleFile=true

# 单文件发布（自包含，无需安装 .NET）
dotnet publish macOSClock.csproj -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
```

## 📖 使用方法

1. 运行 `macOSClock.exe`
2. 顶部显示当前时间和问候语（早上好/下午好/晚上好）
3. 下拉框选择时区，实时显示该地区时间
4. 右上角按钮切换深色/浅色主题
5. 鼠标拖动窗口任意位置移动
6. 右键托盘图标退出（或点击窗口关闭按钮）

## 🛠️ 技术栈

- **语言**：C# 12.0
- **框架**：.NET 8.0（WPF）
- **UI 框架**：Windows Presentation Foundation (WPF)
- **主题引擎**：自定义 ThemeManager（深色/浅色动态切换）
- **国际化**：自定义 LanguageManager（运行时切换语言）
- **时区管理**：TimeZoneManager + TimeZoneTranslations（150+ 时区翻译）
- **窗口样式**：无边框自绘窗口、圆角、阴影
- **字体**：SlexionWindowButtons（自定义窗口按钮图标字体）

## 📁 项目结构

```
macOSClock/
├── App.xaml                  # 应用入口 XAML
├── App.xaml.cs               # 应用入口逻辑
├── AssemblyInfo.cs           # 程序集信息
├── macOSClock.csproj         # 项目配置
├── MainWindow.xaml           # 主窗口界面
├── MainWindow.xaml.cs        # 主窗口逻辑
├── ThemeManager.cs           # 主题管理（深色/浅色）
├── LanguageManager.cs        # 语言管理（中英切换）
├── TimeZoneManager.cs        # 时区管理（150+ 时区）
├── TimeZoneTranslations.cs   # 时区名称翻译
├── SettingsManager.cs        # 设置持久化
├── CornerRadiusHelper.cs     # 圆角辅助类
├── SlexionWindowButtons.ttf  # 窗口按钮图标字体
├── icon.ico                  # 应用图标
└── README.md                 # 项目说明
```

## 🎨 截图

（待补充）

## 📄 许可证

[MIT License](LICENSE)

## 🤝 贡献

欢迎提交 Issue 和 Pull Request！

1. Fork 本仓库
2. 创建特性分支 (`git checkout -b feature/AmazingFeature`)
3. 提交更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 开启 Pull Request

## ⚠️ 免责声明

本项目仅供学习和个人使用。macOS 是 Apple Inc. 的商标，本项目仅为风格模仿，不代表 Apple 官方产品。
