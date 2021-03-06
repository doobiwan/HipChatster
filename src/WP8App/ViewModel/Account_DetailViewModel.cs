// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using WPAppStudio;
using WPAppStudio.Controls;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;
using WPAppStudio.Localization;
using WPAppStudio.Repositories;
using WPAppStudio.Services;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.Shared;
using WPAppStudio.ViewModel.Base;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of Account_Detail ViewModel.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class Account_DetailViewModel : BindableBase, IAccount_DetailViewModel, INavigable
    {       

		private readonly IDialogService _dialogService;
		private readonly INavigationService _navigationService;
		private readonly ISpeechService _speechService;
		private readonly IShareService _shareService;
		private readonly ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Account_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public Account_DetailViewModel(IDialogService dialogService, INavigationService navigationService, ISpeechService speechService, IShareService shareService, ILiveTileService liveTileService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		

		private AccountCollectionSchema _currentAccountCollectionSchema;

        /// <summary>
        /// CurrentAccountCollectionSchema property.
        /// </summary>		
        public AccountCollectionSchema CurrentAccountCollectionSchema
        {
            get
            {
				return _currentAccountCollectionSchema;
            }
            set
            {
                SetProperty(ref _currentAccountCollectionSchema, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechAccount_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechAccount_DetailStaticControlCommandDelegate() 
        {
	
				_speechService.TextToSpeech(CurrentAccountCollectionSchema.Subtitle + " " + CurrentAccountCollectionSchema.Description);
        }
		

        private ICommand _textToSpeechAccount_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechAccount_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechAccount_DetailStaticControlCommand
        {
            get { return _textToSpeechAccount_DetailStaticControlCommand = _textToSpeechAccount_DetailStaticControlCommand ?? new DelegateCommand(TextToSpeechAccount_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareAccount_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareAccount_DetailStaticControlCommandDelegate() 
        {
	
				_shareService.Share(CurrentAccountCollectionSchema.Subtitle, CurrentAccountCollectionSchema.Description);
        }
		

        private ICommand _shareAccount_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareAccount_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareAccount_DetailStaticControlCommand
        {
            get { return _shareAccount_DetailStaticControlCommand = _shareAccount_DetailStaticControlCommand ?? new DelegateCommand(ShareAccount_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartAccount_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartAccount_DetailStaticControlCommandDelegate() 
        {
	
				_liveTileService.PinToStart(typeof(IAccount_DetailViewModel), CreateTileInfoAccount_DetailStaticControl());
        }
		

        private ICommand _pinToStartAccount_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartAccount_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartAccount_DetailStaticControlCommand
        {
            get { return _pinToStartAccount_DetailStaticControlCommand = _pinToStartAccount_DetailStaticControlCommand ?? new DelegateCommand(PinToStartAccount_DetailStaticControlCommandDelegate); }
        }
		public object NavigationContext
        {
            set
            {              
                if (!(value is AccountCollectionSchema)) { return; }
                
                CurrentAccountCollectionSchema = value as AccountCollectionSchema;
            }
        }
        /// <summary>
        /// Initializes a <see cref="TileInfo" /> object for the Account_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="TileInfo" /> object.</returns>
        public TileInfo CreateTileInfoAccount_DetailStaticControl()
        {
            var tileInfo = new TileInfo
            {
                CurrentId = CurrentAccountCollectionSchema.Id.ToString(),
                Title = CurrentAccountCollectionSchema.Subtitle,
                BackTitle = CurrentAccountCollectionSchema.Subtitle,
                BackContent = CurrentAccountCollectionSchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentAccountCollectionSchema.Image,
                BackBackgroundImagePath = CurrentAccountCollectionSchema.Image,
                LogoPath = "Logo-64afe68b-41c7-4545-a549-8de070ba8299.png"
            };
            return tileInfo;
        }
    }
}
