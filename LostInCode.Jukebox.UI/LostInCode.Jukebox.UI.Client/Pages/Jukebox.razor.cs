using Microsoft.AspNetCore.Components.Web;

namespace LostInCode.Jukebox.UI.Client.Pages
{
    public partial class Jukebox
    {
        private class Track
        {
            public int Number { get; set; }
            public string Name { get; set; }
            public string Artist { get; set; }
            public string Duration { get; set; }
            public string AlbumArtUrl { get; set; }
            public bool IsPlaying { get; set; }
        }

        private Track currentTrack;
        private List<Track> playlist = new();
        private bool isPlaying = false;
        private bool showSearch = false;
        private string searchQuery = "";
        private double progressPercentage = 0;

        protected override void OnInitialized()
        {
            // Demo data - vervang dit later met Spotify API calls
            playlist = new List<Track>
        {
            new Track { Number = 1, Name = "Bohemian Rhapsody", Artist = "Queen", Duration = "5:55" },
            new Track { Number = 2, Name = "Stairway to Heaven", Artist = "Led Zeppelin", Duration = "8:02" },
            new Track { Number = 3, Name = "Hotel California", Artist = "Eagles", Duration = "6:30" },
            new Track { Number = 4, Name = "Imagine", Artist = "John Lennon", Duration = "3:03" },
            new Track { Number = 5, Name = "Billie Jean", Artist = "Michael Jackson", Duration = "4:54" },
        };
        }

        private void TogglePlayPause()
        {
            isPlaying = !isPlaying;
            // Hier komt je Spotify API call voor play/pause
        }

        private void NextTrack()
        {
            // Spotify API call voor next track
        }

        private void PreviousTrack()
        {
            // Spotify API call voor previous track
        }

        private void SelectTrack(Track track)
        {
            foreach (var t in playlist)
            {
                t.IsPlaying = false;
            }
            track.IsPlaying = true;
            currentTrack = track;
            isPlaying = true;
            // Spotify API call om dit nummer af te spelen
        }

        private void ToggleSearch()
        {
            showSearch = !showSearch;
            StateHasChanged();
        }

        private void OnSearchKeyUp(KeyboardEventArgs e)
        {
            // Hier komt je Spotify API search functionaliteit
        }
    }
}
