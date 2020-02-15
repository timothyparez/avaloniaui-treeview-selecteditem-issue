using System;
using System.Collections.ObjectModel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace TreeViewIssue.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<string> Items {get; set;} = new ObservableCollection<string>();
                
        [Reactive]
        public string SelectedItem {get; set;}
        public MainWindowViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                Items.Add($"Item {i:##}");                
            }
            
            this.WhenAnyValue(x => x.SelectedItem)
                .Subscribe(x => Console.WriteLine($"Changed: {x ?? "null"}"));
        }      
    }
}
