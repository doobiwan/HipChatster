// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   AppCS.tt
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Scheduler;
using Microsoft.Phone.Shell;
using WPAppStudio.Services;
using WPAppStudio.ViewModel;

namespace WPAppStudio
{
    /// <summary>
    /// Application management.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class App
    {
        /// <summary>
        /// Application execution entry point.
        /// </summary>
		public App()
        {
            // Global handler for uncaught exceptions. 
            UnhandledException += Application_UnhandledException;

            // Standard Silverlight initialization
            InitializeComponent();

            InitializePhoneApplication();
        }

        /// <summary>
        /// Gets/Sets the phone application UI root frame.
        /// </summary>
        public static PhoneApplicationFrame RootFrame { get; private set; }

        private void Application_Launching(object sender, LaunchingEventArgs e)
        {            
        }

        private void Application_Activated(object sender, ActivatedEventArgs e)
        {            
        }

        private void Application_Deactivated(object sender, DeactivatedEventArgs e)
        {
        }

        private void Application_Closing(object sender, ClosingEventArgs e)
        {
        }

        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }
        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }
        }

        private bool _phoneApplicationInitialized;

        private void InitializePhoneApplication()
        {
            if (_phoneApplicationInitialized)
                return;

            RootFrame = new TransitionFrame();
            RootFrame.Navigated += CompleteInitializePhoneApplication;

            RootFrame.NavigationFailed += RootFrame_NavigationFailed;

            _phoneApplicationInitialized = true;
        }
		

        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
			if (RootVisual != RootFrame)
                RootVisual = RootFrame;

            RootFrame.Navigated -= CompleteInitializePhoneApplication;
        }
    }
}
