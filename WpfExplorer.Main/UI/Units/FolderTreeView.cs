using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfExplorer.Main.UI.Units
{
    public class FolderTreeView : TreeView
    {
        public static readonly DependencyProperty SelectionCommandProperty =
            DependencyProperty.Register("SelectionComand", typeof(ICommand), typeof(FolderTreeView));

        static FolderTreeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FolderTreeView), 
                new FrameworkPropertyMetadata(typeof(FolderTreeView)));
        }

        public ICommand SelectionCommand
        {
            get => (ICommand)GetValue(SelectionCommandProperty);
            set => SetValue(SelectionCommandProperty, value);
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new FolderTreeItem();
        }
    }
}
