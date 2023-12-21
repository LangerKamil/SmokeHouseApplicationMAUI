using CommunityToolkit.Mvvm.ComponentModel;

namespace SmokeHouseApplication.Common.Models.BaseModels
{
    public partial class BaseViewModel : ObservableObject
    {
        #region Fields
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(this.IsNotBussy))]
        private bool isBussy;

        [ObservableProperty]
        private string title;
        #endregion

        #region Properties
        public bool IsNotBussy => !this.IsBussy;
        #endregion
    }
}
