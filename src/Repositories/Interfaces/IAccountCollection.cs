// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IDataSource.tt
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// AccountCollection interface.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public interface IAccountCollection
    {
		ObservableCollection<AccountCollectionSchema> GetData();
		ObservableCollection<AccountCollectionSchema> Search(FilterSpecification filter);
    }
}
