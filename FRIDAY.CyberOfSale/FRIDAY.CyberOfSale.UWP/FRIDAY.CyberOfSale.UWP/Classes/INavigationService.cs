using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRIDAY.CyberOfSale.UWP.Classes
{
    public interface INavigationService
    {
        event EventHandler<bool> IsNavigatingChanged;

        event EventHandler Navigated;

        bool CanGoBack { get; }

        bool IsNavigating { get; }

        Task NavigateToPodcastsAsync();

        Task NavigateToFavoritesAsync();

        Task NavigateToDownloadsAsync();

        Task NavigateToNotesAsync();

        Task NavigateToNowPlayingAsync();

        Task NavigateToSettingsAsync();

        Task NavigateToFeedAsync(Feed feed);

        Task NavigateToEpisodeAsync(Episode episode);

        Task NavigateToPlayerAsync(Episode episode);

        Task NavigateToPlayerAsync(InkNote inkNote);

        Task NavigateToInkNoteAsync(InkNote inkNote);

        Task GoBackAsync();
    }
}
