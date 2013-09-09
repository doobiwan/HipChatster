// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   UnityContainer.tt
using Microsoft.Practices.Unity;
using WPAppStudio.Ioc.Interfaces;
using WPAppStudio.Repositories;
using WPAppStudio.Repositories.Base;
using WPAppStudio.Services;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.ViewModel;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Ioc
{
    //
    // Unity 2.1
    // http://msdn.microsoft.com/en-us/library/hh237493.aspx
    //
    // patterns & practices - Unity
    // http://unity.codeplex.com/
    //
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class Container : IContainer
    {
        private readonly IUnityContainer _currentContainer;

        public Container()
        {
            _currentContainer = new UnityContainer();

            _currentContainer.RegisterType<ILiveTileService, LiveTileService>();
			_currentContainer.RegisterType<ILockScreenService, LockScreenService>();
            _currentContainer.RegisterType<IDialogService, DialogService>();
            _currentContainer.RegisterType<IReminderService, ReminderService>();
            _currentContainer.RegisterType<IShareService, ShareService>();
            _currentContainer.RegisterType<ISpeechService, SpeechService>();
            _currentContainer.RegisterType<INavigationService, NavigationService>();
			_currentContainer.RegisterType<IJsonDataSource, JsonDataSource>();
			_currentContainer.RegisterType<IXmlDataSource, XmlDataSource>();
			_currentContainer.RegisterType<IYoutubeDataSource, YoutubeDataSource>();
			
            _currentContainer.RegisterType<IRooms_ListViewModel, Rooms_ListViewModel>();
            _currentContainer.RegisterType<IPeople_DetailViewModel, People_DetailViewModel>();
            _currentContainer.RegisterType<IRooms_DetailViewModel, Rooms_DetailViewModel>();
            _currentContainer.RegisterType<IConnection_ListViewModel, Connection_ListViewModel>();
            _currentContainer.RegisterType<IConnection_DetailViewModel, Connection_DetailViewModel>();
            _currentContainer.RegisterType<IAccount_ListViewModel, Account_ListViewModel>();
            _currentContainer.RegisterType<IAccount_DetailViewModel, Account_DetailViewModel>();
			
			if (!System.ComponentModel.DesignerProperties.IsInDesignTool)
            {
				_currentContainer.RegisterType<IRoomsRepoCollection, RoomsRepoCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IPeopleCollection, PeopleCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IConnectionCollection, ConnectionCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IAccountCollection, AccountCollection>(new ContainerControlledLifetimeManager());
			}
			else
			{
				_currentContainer.RegisterType<IRoomsRepoCollection, FakeRoomsRepoCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IPeopleCollection, FakePeopleCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IConnectionCollection, FakeConnectionCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IAccountCollection, FakeAccountCollection>(new ContainerControlledLifetimeManager());
			
			}	
        }

        public T Resolve<T>()
        {
            return _currentContainer.Resolve<T>();
        }
    }
}
