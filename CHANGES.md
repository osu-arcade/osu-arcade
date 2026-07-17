# All tatakae! changes

purpose of this file: if anything breaks track down all changes we made from base osu! so we can find exactly what caused it faster than bisecting

format: \<change> \<file(s) where change was made>

- Adjust first boot screen to be operator-focused [FirstRunSetupOverlay.cs](./osu.Game/Overlays/FirstRunSetupOverlay.cs)
<!-- - Add global tatakae! overlay [TatakaeOverlay.cs](./osu.Game/Overlays/Tatakae/TatakaeOverlay.cs) -->
- Add global keybind to open special tatakae! screen [TatakaeScreen.cs](./osu.Game/Screens/Tatakae/TatakaeScreen.cs)
- Many settings changed or off by default [OsuConfigManager.cs](./osu.Game/Configuration/OsuConfigManager.cs)
- Add banner displaying current mode of operation [TatakaeModeBanner.cs](./osu.Game/Overlays/TatakaeModeBanner.cs) [TatakaeMode.cs](./osu.Game/Tatakae/Configuration/TatakaeMode.cs)
- Change main menu buttons to be one layer only [ButtonSystem.cs](./osu.Game/Screens/Menu/ButtonSystem.cs)
- Hide online menu banner [MainMenu.cs](./osu.Game/Screens/Menu/MainMenu.cs)
- Add translation key for "tutorial" [ButtonSystemStrings.cs](./osu.Game/Localisation/ButtonSystemStrings.cs)
- Hide a lot of settings sections from SettingsOverlay and hide options from specific sections [SettingsOverlay.cs](./osu.Game/Overlays/SettingsOverlay.cs) [GeneralSection.cs](./osu.Game/Overlays/Settings/Sections/GeneralSection.cs) [InputSection.cs](./osu.Game/Overlays/Settings/Sections/InputSection.cs) [OnlineSection.cs](./osu.Game/Overlays/Settings/Sections/OnlineSection.cs) [VolumeSettings.cs](./osu.Game/Overlays/Settings/Sections/Audio/VolumeSettings.cs) [BindingSettings.cs](./osu.Game/Overlays/Settings/Sections/Input/BindingSettings.cs)
