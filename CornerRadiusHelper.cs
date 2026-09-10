using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace macOSClock
{
    /// <summary>
    /// 圆角附加属性 - 用于给 ComboBox 等控件设置圆角，不改变默认模板
    /// </summary>
    public static class CornerRadiusHelper
    {
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached(
                "CornerRadius",
                typeof(CornerRadius),
                typeof(CornerRadiusHelper),
                new PropertyMetadata(new CornerRadius(0), OnCornerRadiusChanged));

        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }

        private static void OnCornerRadiusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Control control)
            {
                // 控件加载后应用圆角
                control.Loaded += Control_Loaded;

                // 如果是 ComboBox，监听下拉展开事件，设置弹出内容的圆角
                if (control is ComboBox comboBox)
                {
                    comboBox.DropDownOpened += ComboBox_DropDownOpened;
                }

                // 如果已经加载，立即应用
                if (control.IsLoaded)
                {
                    ApplyCornerRadius(control, (CornerRadius)e.NewValue);
                }
            }
        }

        private static void Control_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is Control control)
            {
                control.Loaded -= Control_Loaded;
                var cornerRadius = GetCornerRadius(control);
                ApplyCornerRadius(control, cornerRadius);
            }
        }

        /// <summary>
        /// ComboBox 下拉展开时，设置弹出内容的圆角
        /// </summary>
        private static void ComboBox_DropDownOpened(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                var cornerRadius = GetCornerRadius(comboBox);

                // 延迟一帧，确保 Popup 内容已经加载
                comboBox.Dispatcher.BeginInvoke(new Action(() =>
                {
                    // 查找 Popup
                    var popup = FindChild<Popup>(comboBox);
                    if (popup != null && popup.Child != null)
                    {
                        // 递归设置 Popup 内容中所有 Border 的圆角
                        ApplyAllBorderCornerRadius(popup.Child, cornerRadius);
                    }
                }), System.Windows.Threading.DispatcherPriority.Render);
            }
        }

        /// <summary>
        /// 递归查找视觉树中的第一个指定类型元素
        /// </summary>
        private static T? FindChild<T>(DependencyObject parent) where T : DependencyObject
        {
            if (parent == null) return null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is T result)
                {
                    return result;
                }

                var found = FindChild<T>(child);
                if (found != null)
                {
                    return found;
                }
            }
            return null;
        }

        /// <summary>
        /// 递归查找视觉树中的 Border，设置圆角（只设置第一个）
        /// </summary>
        private static void ApplyCornerRadius(DependencyObject parent, CornerRadius cornerRadius)
        {
            if (parent == null) return;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is Border border)
                {
                    // 只设置第一个找到的 Border（通常是控件的外边框）
                    border.CornerRadius = cornerRadius;
                    return;
                }

                ApplyCornerRadius(child, cornerRadius);
            }
        }

        /// <summary>
        /// 递归设置所有 Border 的圆角（用于 Popup 内容）
        /// </summary>
        private static void ApplyAllBorderCornerRadius(DependencyObject parent, CornerRadius cornerRadius)
        {
            if (parent == null) return;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is Border border)
                {
                    border.CornerRadius = cornerRadius;
                }

                ApplyAllBorderCornerRadius(child, cornerRadius);
            }
        }
    }
}
