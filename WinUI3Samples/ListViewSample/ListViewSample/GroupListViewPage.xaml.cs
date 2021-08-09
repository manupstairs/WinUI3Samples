using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ListViewSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GroupListViewPage : Page
    {
        private List<Person> PersonList { get; set; }
        public IEnumerable<IGrouping<string, Person>> PersonGroup { get; set; }

        public GroupListViewPage()
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
            PersonGroup = PersonList.GroupBy(p => p.Name.First().ToString());
        }
    }
}
