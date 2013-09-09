// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSource.tt
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using WPAppStudio.Entities;
using WPAppStudio.Repositories.Base;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// RoomsRepoCollectionSchema data source.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class RoomsRepoCollection : IRoomsRepoCollection 
    {
		private readonly IJsonDataSource _jsonDataSource; 

		private const string DataServiceUrl = "http://dowapp.cloudapp.net/api/data?clientId={0}&appId={1}&datasourceName={2}";

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsRepoCollection" /> class.
        /// </summary>
        /// <param name="jsonDataSource">A JSON based data source.</param>
        public RoomsRepoCollection(IJsonDataSource jsonDataSource)
        {
            _jsonDataSource = jsonDataSource;
        }
		
        /// <summary>
        /// Retrieves the data from a dynamic data service (URL specified in DataServiceUrl) , in an observable collection of RoomsRepoCollectionSchema items.
        /// </summary>
        /// <returns>An observable collection of RoomsRepoCollectionSchema items.</returns>
        public async Task<ObservableCollection<RoomsRepoCollectionSchema>> GetData()
        {			
            return await LoadData();
        } 
		 
        private async Task<ObservableCollection<RoomsRepoCollectionSchema>> LoadData()
        {
            var items = await _jsonDataSource.LoadRemote<RoomsRepoCollectionSchema[]>(string.Format(DataServiceUrl, "7722","19c0e10c-8899-4903-a94b-2502963689cf", "RoomsRepoCollection"));
            return items != null ? new ObservableCollection<RoomsRepoCollectionSchema>(items.OrderBy(i=>i.Title)) : new ObservableCollection<RoomsRepoCollectionSchema>();
        }
	}	
}