﻿namespace Unigram
{
    public static partial class Constants
    {
        public static readonly int ApiId;
        public static readonly string ApiHash;

        public static readonly string AppCenterId;

        public const int TypingTimeout = 300;

        public static readonly string[] MediaTypes = new[] { ".jpg", ".jpeg", ".png", ".gif", ".mp4" };
        public static readonly string[] PhotoTypes = new[] { ".jpg", ".jpeg", ".png", ".gif" };

        public const string WallpaperFileName = "wallpaper.jpg";
        public const string WallpaperLocalFileName = "wallpaper.local.jpg";
        public const string WallpaperColorFileName = "wallpaper.color.jpg";
        public const int WallpaperLocalId = -1;

        public const int ChatListFilterAll = -1;

        public static readonly string[] TelegramHosts = new string[]
        {
            "telegram.me",
            "telegram.dog",
            "t.me",
            "telegra.ph"
            /*"telesco.pe"*/
        };

        public static readonly Windows.UI.Xaml.Media.FontFamily SymbolThemeFontFamily = new Windows.UI.Xaml.Media.FontFamily("ms-appx:///Assets/Fonts/SEGMDL2.TTF#Segoe MDL2 Assets"); // see App.xaml
    }
}
