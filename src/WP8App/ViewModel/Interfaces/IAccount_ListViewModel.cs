// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.Collections.ObjectModel;
using System.Windows.Input;
using WPAppStudio.Controls;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// Account_List ViewModel interface.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public interface IAccount_ListViewModel
    {		
        /// <summary>
        /// Gets/Sets the Account_ListListControlCollection property.
        /// </summary>
		ObservableCollection<AccountCollectionSchema> Account_ListListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the SelectedAccount_ListListControlCollection property.
        /// </summary>
		AccountCollectionSchema SelectedAccount_ListListControlCollection { get; set; }

	}
}
