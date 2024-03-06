using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Foreground : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    OsbAnimation grain = GetLayer("").CreateAnimation("sb/grain/.jpg", 12, 83.33333333333333, OsbLoopType.LoopForever);
            grain.Fade(0, 0.125);
            // grain.Scale(0, 853.33f / 1120);
            grain.Fade(208449,0);
            grain.Additive(0);


            OsbAnimation vanim = GetLayer("").CreateAnimation("sb/vanim/vint.jpeg", 61, 83.33333333333333, OsbLoopType.LoopForever);
            vanim.Fade(0, 0.125);
            // vanim.Scale(0, 853.33f / 1278.0F);
            vanim.Fade(208449,0);
            vanim.Additive(0);
            
        }
    }
}
