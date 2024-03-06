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
    public class Background : StoryboardObjectGenerator
    {
        [Configurable]
        public bool cinemaScale = false;
        [Configurable]
        public bool highQualityScale = false;

        public override void Generate()
        {
		    GetLayer("").CreateSprite(Beatmap.BackgroundPath).Fade(0,0);

            int startTime = 8793;

            OsbSprite introBG = GetLayer("").CreateSprite("sb/light/fadein/0.jpg");
            introBG.Fade(OsbEasing.OutExpo,1779-200,1779,0, 1);
            if (cinemaScale)
                introBG.Scale(1779-200, 853.33f / 1120);
            if (highQualityScale)
                introBG.Scale(1779-200, 480.0f / 2160);
            introBG.Fade(startTime,0);

            // Intro Fade in
            OsbAnimation introFadeIn = GetLayer("").CreateAnimation("sb/light/fadein/.jpg",23,83.33333333333333,OsbLoopType.LoopOnce);
            introFadeIn.Fade(startTime, 1);
            introFadeIn.Fade(startTime + 2000, 0);
            if (cinemaScale)
                introFadeIn.Scale(startTime, 853.33f / 1120);
            if (highQualityScale)
                introFadeIn.Scale(startTime, 480.0f / 2160);
            int currentTime = startTime + 2000;
            OsbAnimation idle = GetLayer("").CreateAnimation("sb/light/idle/.jpg",48,83.33333333333333, OsbLoopType.LoopForever);
            idle.Fade(currentTime, 1);
            if (cinemaScale)
                idle.Scale(currentTime, 853.33f / 1120);
            if (highQualityScale)
                idle.Scale(currentTime, 480.0f / 2160);
            // 59472 is start of fade to kiai.. let's find nearest.
            //  
            idle.Fade(58793, 0);
            currentTime = 58793;
            OsbAnimation fadeToKiai = GetLayer("").CreateAnimation("sb/light/ftk/.jpg", 24,83.33333333333333,OsbLoopType.LoopOnce);
            fadeToKiai.Fade(currentTime, 1);
            fadeToKiai.Fade(currentTime + 2000, 0);
            if (cinemaScale)
                fadeToKiai.Scale(currentTime, 853.33f / 1120);
            if (highQualityScale)
                fadeToKiai.Scale(currentTime, 480.0f / 2160);
            currentTime += 2000;
            OsbAnimation kiaiIdle =  GetLayer("").CreateAnimation("sb/light/kidle/.jpg",48,83.33333333333333, OsbLoopType.LoopForever);
            kiaiIdle.Fade(currentTime, 1);
            if (cinemaScale)
                kiaiIdle.Scale(currentTime, 853.33f / 1120);
            if (highQualityScale)
                kiaiIdle.Scale(currentTime, 480.0f / 2160);
            // 88288
            currentTime = 88793;
            kiaiIdle.Fade(currentTime, 0);

            OsbAnimation fadeToNormal =  GetLayer("").CreateAnimation("sb/light/ftn/.jpg", 24,83.33333333333333,OsbLoopType.LoopOnce);
            if (cinemaScale)
                fadeToNormal.Scale(currentTime, 853.33f / 1120);
            if (highQualityScale)
                fadeToNormal.Scale(currentTime, 480.0f / 2160);
            fadeToNormal.Fade(currentTime, 1);
            fadeToNormal.Fade(currentTime + 2000, 0);

            currentTime += 2000;
            idle = GetLayer("").CreateAnimation("sb/light/idle/.jpg",48,83.33333333333333, OsbLoopType.LoopForever);
            idle.Fade(currentTime, 1);
            if (cinemaScale)
                idle.Scale(currentTime, 853.33f / 1120);
            if (highQualityScale)
                idle.Scale(currentTime, 480.0f / 2160);

            //124630 -> 122793
            currentTime = 122793;
            idle.Fade(currentTime, 0);

            fadeToKiai = GetLayer("").CreateAnimation("sb/light/ftk/.jpg", 24,83.33333333333333,OsbLoopType.LoopOnce);
            fadeToKiai.Fade(currentTime, 1);
            if (cinemaScale)
                fadeToKiai.Scale(currentTime, 853.33f / 1120);
            if (highQualityScale)
                fadeToKiai.Scale(currentTime, 480.0f / 2160);
            fadeToKiai.Fade(currentTime + 2000, 0);

            currentTime += 2000;
            kiaiIdle =  GetLayer("").CreateAnimation("sb/light/kidle/.jpg",48,83.33333333333333, OsbLoopType.LoopForever);
            kiaiIdle.Fade(currentTime, 1);
            if (cinemaScale)
                kiaiIdle.Scale(currentTime, 853.33f / 1120);
            if (highQualityScale)
                kiaiIdle.Scale(currentTime, 480.0f / 2160);
            // 182314 182775
            kiaiIdle.Fade(182775, 0);

            fadeToNormal =  GetLayer("").CreateAnimation("sb/light/ftn/.jpg", 24,83.33333333333333,OsbLoopType.LoopOnce);
            if (cinemaScale)
                fadeToNormal.Scale(182775, 853.33f / 1120);
            if (highQualityScale)
                fadeToNormal.Scale(182775, 480.0f / 2160);
            fadeToNormal.Fade(182775, 1);
            fadeToNormal.Fade(182775 + 2000, 0);

            idle = GetLayer("").CreateAnimation("sb/light/idle/.jpg",48,83.33333333333333, OsbLoopType.LoopForever);
            if (cinemaScale)
                idle.Scale(182775 + 2000, 853.33f / 1120);
            if (highQualityScale)
                idle.Scale(182775 + 2000, 480.0f / 2160);
            idle.Fade(182775 + 2000, 1);
            idle.Fade(195895,207631,1,0);


            OsbSprite flash = GetLayer("").CreateSprite("sb/light/kidle/1.jpg");
            flash.Additive(59704);
            if (cinemaScale)
                flash.Scale(59704, 853.33f / 1120);
            if (highQualityScale)
                flash.Scale(59704, 480.0f / 2160);
            flash.Fade(59704,60716,0.5,0);
            flash.Fade(74178,75648,0.5,0);
            flash.Fade(81417,83341,0.3,0);
            flash.Fade(124856,126101,0.5,0);
            flash.Fade(132096,134019,0.3,0); 
            flash.Fade(139336,140354,0.5,0);
            flash.Fade(146576,148499,0.3,0); 
            flash.Fade(153816,155512,0.85,0);
            flash.Fade(161055,161847,0.2,0);
            flash.Fade(168295,170218,0.85,0);
            flash.Fade(175535,176553,0.2,0);
            flash.Fade(179155,180173,0.1,0);
            flash.Fade(182775,186960,0.4,0);
        }
    }
}
