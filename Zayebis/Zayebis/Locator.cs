using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Zayebis.Person;
using Zayebis.Person.Implementation;
using Zayebis.ViewModel;

namespace Zayebis
{
    public class Locator
    {
        public Locator()
        {
            ServiceLocator.SetLocatorProvider(()=> SimpleIoc.Default);

            //View models 
            SimpleIoc.Default.Register<MainViewModel>();

            //Services
            SimpleIoc.Default.Register<IPeopleService, PeopleService>();

        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
        "CA1822:MarkMembersAsStatic",
        Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main { get { return ServiceLocator.Current.GetInstance<MainViewModel>(); } }

    }
}
