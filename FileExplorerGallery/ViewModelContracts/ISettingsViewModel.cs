﻿using System.Windows.Input;

namespace FileExplorerGallery.ViewModelContracts
{
    public interface ISettingsViewModel
    {
        bool RunOnStartup { get; set; }

        bool AutomaticUpdates { get; set; }

        bool ShowingKeyboardCaptureOverlay { get; set; }

        int SlideshowDuration { get; set; }

        string ShortCut { get; }

        string ShortCutPreview { get; set; }

        string ApplicationVersion { get; }

        bool CheckingForUpdateInProgress { get; }

        ICommand ChangeShortcutCommand { get; }

        ICommand CheckForUpdatesCommand { get; }

        ICommand ConfirmShortcutCommand { get; }

        ICommand CancelShortcutCommand { get; }
    }
}
