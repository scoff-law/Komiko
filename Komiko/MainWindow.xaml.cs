using System.Windows;
using Komiko.Contracts.Engines;
using Komiko.Helpers;

namespace Komiko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ILibraryEngine _libraryEngine;

        public MainWindow(ILibraryEngine libraryEngine)
        {
            _libraryEngine = libraryEngine;
            InitializeComponent();
            var paths = ComicHelper.SortByName(_libraryEngine.GetComics(), true);
            foreach (var path in paths)
            {
                this.Files.Items.Add(path);
            }
            
        }
    }
}
