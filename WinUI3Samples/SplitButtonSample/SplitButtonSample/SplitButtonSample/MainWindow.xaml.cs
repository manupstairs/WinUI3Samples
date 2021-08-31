using Microsoft.UI.Xaml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SplitButtonSample
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private List<Person> PersonList { get; set; }
        public IEnumerable<IGrouping<string, Person>> PersonGroup { get; set; }

        public MainWindow()
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

    public class Person
    {
        public string Name { get; set; }
    }
}
