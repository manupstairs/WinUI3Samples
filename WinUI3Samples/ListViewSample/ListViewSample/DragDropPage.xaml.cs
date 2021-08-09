using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ListViewSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DragDropPage : Page, INotifyPropertyChanged
    {
        public List<Person> PersonList { get; set; }

        private Person DragPerson { get; set; }

        private Person selectedPerson;

        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                if (selectedPerson != value)
                {
                    selectedPerson = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name= null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public DragDropPage()
        {
            this.InitializeComponent();

            this.PersonList = new List<Person>
            {
                new Person{ Name = "Abe"},
                new Person{ Name = "Alice"},
                new Person{ Name = "Bell"},
                new Person{ Name = "Ben"},
                new Person{ Name = "Bob"},
                new Person{ Name = "Fox"},
                new Person{ Name = "Gray"},
                new Person{ Name = "James"},
                new Person{ Name = "Jane"},
                new Person{ Name = "Roy"},
                new Person{ Name = "Vincent"}
            };
        }

        private async void ComboBox_Drop(object sender, DragEventArgs e)
        {
            if (e.DataView.Contains(StandardDataFormats.Text))
            {
                var name = await e.DataView.GetTextAsync();
                this.SelectedPerson = this.PersonList.FirstOrDefault(p => p.Name == name);
            }
        }

        private void ComboBox_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private void TextBlock_DragStarting(UIElement sender, DragStartingEventArgs args)
        {
            DragPerson = (sender as TextBlock).DataContext as Person;
            args.Data.SetData(StandardDataFormats.Text, DragPerson.Name);
        }
    }
}
