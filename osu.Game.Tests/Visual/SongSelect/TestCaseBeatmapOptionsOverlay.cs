﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;
using osu.Framework.Graphics.Sprites;
using osu.Game.Screens.Select.Options;
using osuTK.Graphics;
using osuTK.Input;

namespace osu.Game.Tests.Visual.SongSelect
{
    [Description("bottom beatmap details")]
    public class TestCaseBeatmapOptionsOverlay : OsuTestCase
    {
        public TestCaseBeatmapOptionsOverlay()
        {
            var overlay = new BeatmapOptionsOverlay();

            overlay.AddButton(@"Remove", @"from unplayed", FontAwesome.TimesCircleOutline, Color4.Purple, null, Key.Number1);
            overlay.AddButton(@"Clear", @"local scores", FontAwesome.Eraser, Color4.Purple, null, Key.Number2);
            overlay.AddButton(@"Edit", @"Beatmap", FontAwesome.Pencil, Color4.Yellow, null, Key.Number3);
            overlay.AddButton(@"Delete", @"Beatmap", FontAwesome.Trash, Color4.Pink, null, Key.Number4, float.MaxValue);

            Add(overlay);

            AddStep(@"Toggle", overlay.ToggleVisibility);
        }
    }
}
