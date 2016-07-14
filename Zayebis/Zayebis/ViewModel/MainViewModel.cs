using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Zayebis.Person;

namespace Zayebis.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        private readonly IPeopleService _peopleService;
        ObservableCollection<Model.Person> People { get; set; }
        public MainViewModel(IPeopleService peopleService)
        {
            if (peopleService == null)
                throw new ArgumentException();
            _peopleService = peopleService;
        }
        public async Task Init()
        {
            if (People == null) return;
            People = new ObservableCollection<Model.Person>(await _peopleService.GetPeople());
        }
    }
}