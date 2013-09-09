// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   PageCS.tt
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyToolkit.Paging;
using Newtonsoft.Json;
using WPAppStudio;
using WPAppStudio.Entities;
using WPAppStudio.Helpers;
using WPAppStudio.Ioc;
using WPAppStudio.Localization;
using WPAppStudio.Repositories;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.ViewModel;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.View
{
    /// <summary>
    /// Phone application page for Connection_List.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class Connection_List : PhoneApplicationPage
    {       
        /// <summary>
        /// Initializes the phone application page for Connection_List and all its components.
        /// </summary>
        public Connection_List()
        {
            InitializeComponent();        
			if (Resources.Contains("PanoramaConnection_List0AppBar"))
				PhonePage.SetApplicationBar(this, Resources["PanoramaConnection_List0AppBar"] as BindableApplicationBar);                            
		}
		
        private void panoramaConnection_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {		
			InitializeAppBarpanoramaConnection_List(PanoramaConnection_List.SelectedItem as PanoramaItem);
        }
		
		private void InitializeAppBarpanoramaConnection_List(PanoramaItem panoramaItem)        
        {
			if (Resources.Contains(panoramaItem.Name + "AppBar"))
			{
				PhonePage.SetApplicationBar(this, Resources[panoramaItem.Name + "AppBar"] as BindableApplicationBar);            
				ApplicationBar.IsVisible = true;
            }
		    else if(ApplicationBar != null)
		        ApplicationBar.IsVisible = false;
        }
 
        /// <summary>
        /// Called when the page becomes the active page.
        /// </summary>
        /// <param name="e">Contains information about the navigation done.</param>
        protected override  void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
		
            Connection_ListListControl.SelectedItem = null;
		}
    }
}