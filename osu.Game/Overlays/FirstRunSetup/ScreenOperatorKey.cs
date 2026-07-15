// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Localisation;
using osu.Game.Graphics;
using osu.Game.Graphics.Containers;
using osu.Game.Localisation;
using osu.Game.Overlays.Settings.Sections.Input;

namespace osu.Game.Overlays.FirstRunSetup
{
    [LocalisableDescription(typeof(FirstRunSetupOverlayStrings), nameof(FirstRunSetupOverlayStrings.Behaviour))]
    public partial class ScreenOperatorKey : WizardScreen
    {

        [BackgroundDependencyLoader]
        private void load(OsuColour colours)
        {
            Content.Children = new Drawable[]
            {
                new OsuTextFlowContainer(cp => cp.Font = OsuFont.Default.With(size: CONTENT_FONT_SIZE))
                {
                    Text = @"Please set the key used to operate (enter maintenance and adjust arcade-only settings) on the system.

If using a cabinet setup, this key should be bound to a button located behind the keyhole.

If using a keyboard setup, do not set this to a key or combination that will be easy for users to accidentally press. We recommend setting it to a combination like Ctrl+Shift+Alt+ScrLk.",
                    RelativeSizeAxes = Axes.X,
                    AutoSizeAxes = Axes.Y
                },
                new OsuTextFlowContainer(cp => cp.Font = OsuFont.Torus.With(size: HEADER_FONT_SIZE))
                {
                    Text = "BE CAREFUL WHEN SELECTING AN OPERATOR KEY! IT WILL BE NECESSARY TO EXIT USERMODE.",
                    RelativeSizeAxes = Axes.X,
                    AutoSizeAxes = Axes.Y
                },
                new GlobalKeyBindingsSubsection("", Input.Bindings.GlobalActionCategory.Tatakae)
            };
        }
    }
}
