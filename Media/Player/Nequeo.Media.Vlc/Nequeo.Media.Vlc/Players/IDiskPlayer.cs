﻿//    nVLC
//    
//    Author:  Roman Ginzburg
//
//    nVLC is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    nVLC is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//    GNU General Public License for more details.
//     
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Nequeo.Media.Vlc.Enums;
using Nequeo.Media.Vlc.Rendering;
using Nequeo.Media.Vlc.Structures;

namespace Nequeo.Media.Vlc.Players
{
    /// <summary>
    /// DVD, VCD and Audio CD playback
    /// </summary>
    public interface IDiskPlayer : IVideoPlayer
    {
        /// <summary>
        /// Gets the number of chapters in the movie.
        /// </summary>
        int ChapterCount { get; }

        /// <summary>
        /// Gets or sets a chapter.
        /// </summary>
        int Chapter { get; set; }

        /// <summary>
        /// Gets or sets the movie title
        /// </summary>
        int Title { get; set; }

        /// <summary>
        /// Gets the number of titles in the movie.
        /// </summary>
        int TitleCount { get; }

        /// <summary>
        /// Gets the number of chapters for specified title.
        /// </summary>
        /// <param name="title">title</param>
        /// <returns>Number of chapters</returns>
        int GetChapterCountForTitle(int title);

        /// <summary>
        /// Sets the next chapter.
        /// </summary>
        void NextChapter();

        /// <summary>
        /// Sets the previous chapter.
        /// </summary>
        void PreviousChapter();

        /// <summary>
        /// Sets or gets the audio track.
        /// </summary>
        int AudioTrack { get; set; }

        /// <summary>
        /// Gets the number of audio tracks.
        /// </summary>
        int AudioTrackCount { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<TrackDescription> AudioTracksInfo { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<TrackDescription> VideoTracksInfo { get; }
        
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<TrackDescription> SubtitleTracksInfo { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<TrackDescription> TitleInfo { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        IEnumerable<TrackDescription> GetChapterDescription(int title);

        /// <summary>
        /// Gets or sets video subtitle
        /// </summary>
        int SubTitle { get; set; }

        /// <summary>
        /// Gets the number of video subtitles
        /// </summary>
        int SubTitleCount { get; }

        /// <summary>
        /// Get the number of video tracks.
        /// </summary>
        int VideoTrackCount { get; }

        /// <summary>
        /// Gets or sets video track.
        /// </summary>
        int VideoTrack { get; set; }

        /// <summary>
        /// Navigate through DVD menu
        /// </summary>
        void Navigate(NavigationMode mode);
    }
}
