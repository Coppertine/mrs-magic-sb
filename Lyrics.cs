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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace StorybrewScripts
{

    public class Lyrics : StoryboardObjectGenerator
    {
        [Configurable]
        public int BlurRadius = 5;

        [Configurable]
        public bool cinemaPositions = false;

        public FontGenerator font;
        public List<LyricTextures> fontLyrics;
        public StoryboardLayer layer;
        public override void Generate()
        {
            layer = GetLayer("");
            fontLyrics = new List<LyricTextures>();
            font = LoadFont("sb/f", new FontDescription
            {
                FontPath = "fonts/Caveat-VariableFont_wght.ttf",
                Color = Color4.White,
                Padding = new Vector2(15),
                FontSize = 60
            });

            // Mrs Magic, to and fro
            var line1Textures = GetTexture("Mrs Magic,");
            var line1_1Textures = GetTexture("to");
            var line1_2Textures = GetTexture("and");
            var line1_3Textures = GetTexture("fro");

            var line2Textures = GetTexture("Please");
            var line2_1Textures = GetTexture("give");
            var line2_2Textures = GetTexture("me");
            var line2_3Textures = GetTexture("one");
            var line2_4Textures = GetTexture("last");
            var line2_5Textures = GetTexture("show");

            var line3Textures = GetTexture("loosen");
            var line3_1Textures = GetTexture("my");
            var line3_2Textures = GetTexture("mind");
            var line3_3Textures = GetTexture("from");
            var line3_4Textures = GetTexture("within");

            var line4Textures = GetTexture("before");
            var line4_1Textures = GetTexture("it");
            var line4_2Textures = GetTexture("starts");
            var line4_3Textures = GetTexture("to");
            var line4_4Textures = GetTexture("wear");
            var line4_5Textures = GetTexture("and");
            var line4_6Textures = GetTexture("thin");

            var kiaiTextures = GetTexture("i");
            var kiai_1Textures = GetTexture("don't");
            var kiai_2Textures = GetTexture("know");
            var kiai_3Textures = GetTexture("what");
            var kiai_4Textures = GetTexture("i'm");
            var kiai_5Textures = GetTexture("doing");
            var kiai_6Textures = GetTexture("here");

            var line5_Textures = GetTexture("Mrs");
            var line5_1Textures = GetTexture("Magic");
            var line5_2Textures = GetTexture("radio");

            var line6_Textures = GetTexture("Give");
            var line6_1Textures = GetTexture("me");
            var line6_2Textures = GetTexture("one");
            var line6_3Textures = GetTexture("last");
            var line6_4Textures = GetTexture("chance");
            var line6_5Textures = GetTexture("to");
            var line6_6Textures = GetTexture("show");

            var line7_Textures = GetTexture("Tell");
            var line7_1Textures = GetTexture("you");
            var line7_2Textures = GetTexture("what");
            var line7_3Textures = GetTexture("lurks");
            var line7_4Textures = GetTexture("deep");
            var line7_5Textures = GetTexture("inside");
            
            var line8_Textures = GetTexture("Deep");
            var line8_1Textures = GetTexture("inside");
            var line8_2Textures = GetTexture("my");
            var line8_3Textures = GetTexture("battered");
            var line8_4Textures = GetTexture("mind");

            var kiai2_Textures = GetTexture("leaving");
            var kiai2_1Textures = GetTexture("me");
            var kiai2_2Textures = GetTexture("outside");

            var kiai2_3Textures = GetTexture("no,");
            var kiai2_4Textures = GetTexture("I");
            var kiai2_5Textures = GetTexture("can't");
            var kiai2_6Textures = GetTexture("get");
            var kiai2_7Textures = GetTexture("back");
            var kiai2_8Textures = GetTexture("in");

            var line9_Textures = GetTexture("Just");
            var line9_1Textures = GetTexture("let");
            var line9_2Textures = GetTexture("me");
            var line9_3Textures = GetTexture("be");
            var line9_4Textures = GetTexture("my");
            var line9_5Textures = GetTexture("self");

            int cinemaOffset = cinemaPositions ? 20 : 0;

            MoveLyrics(30739, 34359, new Vector2(30, 395 - cinemaOffset), new Vector2(90, 395- cinemaOffset), line1Textures);
            MoveLyrics(30739, 34359, new Vector2(130, 395- cinemaOffset), new Vector2(190, 395- cinemaOffset), line1_1Textures);
            MoveLyrics(30739, 34359, new Vector2(180, 395- cinemaOffset), new Vector2(235, 395- cinemaOffset), line1_2Textures);
            MoveLyrics(30739, 34359, new Vector2(230, 395- cinemaOffset), new Vector2(290, 395- cinemaOffset), line1_3Textures);
            float offset = 60;

            // please give me one last show
            MoveLyrics(37821, 41678, new Vector2(30, 395- cinemaOffset), new Vector2(90, 395- cinemaOffset), line2Textures);
            MoveLyrics(37821, 41678, new Vector2(100, 395- cinemaOffset), new Vector2(100 + offset, 395- cinemaOffset), line2_1Textures);
            MoveLyrics(37821, 41678, new Vector2(150, 395- cinemaOffset), new Vector2(150 + offset, 395- cinemaOffset), line2_2Textures);
            MoveLyrics(37821, 41678, new Vector2(200, 395- cinemaOffset), new Vector2(200 + offset, 395- cinemaOffset), line2_3Textures);
            MoveLyrics(37821, 41678, new Vector2(260, 395- cinemaOffset), new Vector2(260 + offset, 395- cinemaOffset), line2_4Textures);
            MoveLyrics(37821, 41678, new Vector2(330, 395- cinemaOffset), new Vector2(330 + offset, 395- cinemaOffset), line2_5Textures);

            // lossen my mind from within
            MoveLyrics(45218, 49065, new Vector2(30, 395- cinemaOffset), new Vector2(90, 395- cinemaOffset), line3Textures);
            MoveLyrics(45218, 49065, new Vector2(96, 395- cinemaOffset), new Vector2(96 + offset, 395- cinemaOffset), line3_1Textures);
            MoveLyrics(45218, 49065, new Vector2(150, 395- cinemaOffset), new Vector2(150 + offset, 395- cinemaOffset), line3_2Textures);
            MoveLyrics(45218, 49065, new Vector2(220, 395- cinemaOffset), new Vector2(220 + offset, 395- cinemaOffset), line3_3Textures);
            MoveLyrics(45218, 49065, new Vector2(300, 395- cinemaOffset), new Vector2(300 + offset, 395- cinemaOffset), line3_4Textures);

            // before it starts to wear and thin
            MoveLyrics(52201, 56078, new Vector2(30, 395- cinemaOffset), new Vector2(30 + offset, 395- cinemaOffset), line4Textures);
            MoveLyrics(52201, 56078, new Vector2(90, 395- cinemaOffset), new Vector2(90 + offset, 395- cinemaOffset), line4_1Textures);
            MoveLyrics(52201, 56078, new Vector2(145, 395- cinemaOffset), new Vector2(145 + offset, 395- cinemaOffset), line4_2Textures);
            MoveLyrics(52201, 56078, new Vector2(207.5F, 395- cinemaOffset), new Vector2(207.5F + offset, 395- cinemaOffset), line4_3Textures);
            MoveLyrics(52201, 56078, new Vector2(257.5f, 395- cinemaOffset), new Vector2(257.5f + offset, 395- cinemaOffset), line4_4Textures);
            MoveLyrics(52201, 56078, new Vector2(320, 395- cinemaOffset), new Vector2(320 + offset, 395- cinemaOffset), line4_5Textures);
            MoveLyrics(54947, 56078, new Vector2(420, 395- cinemaOffset), new Vector2(440, 395- cinemaOffset), line4_6Textures);

            // i don't know
            MoveLyrics(60829, 63092, new Vector2(459, 162+cinemaOffset), new Vector2(310, 162+cinemaOffset), kiaiTextures, true);
            MoveLyrics(60829, 63092, new Vector2(500, 162+cinemaOffset), new Vector2(360, 162+cinemaOffset), kiai_1Textures, true);
            MoveLyrics(60829, 63092, new Vector2(580, 162+cinemaOffset), new Vector2(430, 162+cinemaOffset), kiai_2Textures, true);

            MoveLyrics(64449, 68748, new Vector2(459, 162+cinemaOffset), new Vector2(310, 162+cinemaOffset), kiaiTextures, true);
            MoveLyrics(64449, 68748, new Vector2(500, 162+cinemaOffset), new Vector2(360, 162+cinemaOffset), kiai_1Textures, true);
            MoveLyrics(64449, 68748, new Vector2(580, 162+cinemaOffset), new Vector2(430, 162+cinemaOffset), kiai_2Textures, true);
            // what i'm doing here
            MoveLyrics(66033, 68748, new Vector2(431, 209+cinemaOffset), new Vector2(382, 209+cinemaOffset), kiai_3Textures, true);  
            MoveLyrics(66259, 68748, new Vector2(484, 209+cinemaOffset), new Vector2(449, 209+cinemaOffset), kiai_4Textures, true);  
            MoveLyrics(66712, 68748, new Vector2(535, 209+cinemaOffset), new Vector2(514, 209+cinemaOffset), kiai_5Textures, true);  
            MoveLyrics(67617, 68748, new Vector2(594, 209+cinemaOffset), new Vector2(577, 213+cinemaOffset), kiai_6Textures, true);
            // i don't know
            MoveLyrics(75422, 77458, new Vector2(459, 155+cinemaOffset), new Vector2(410, 155+cinemaOffset), kiaiTextures, true);
            MoveLyrics(75422, 77458, new Vector2(500, 155+cinemaOffset), new Vector2(460, 155+cinemaOffset), kiai_1Textures, true);
            MoveLyrics(75422, 77458, new Vector2(580, 155+cinemaOffset), new Vector2(530, 155+cinemaOffset), kiai_2Textures, true);

            MoveLyrics(79042, 83227, new Vector2(459, 155+cinemaOffset), new Vector2(310, 155+cinemaOffset), kiaiTextures, true);
            MoveLyrics(79042, 83227, new Vector2(500, 155+cinemaOffset), new Vector2(360, 155+cinemaOffset), kiai_1Textures, true);
            MoveLyrics(79042, 83227, new Vector2(580, 155+cinemaOffset), new Vector2(430, 155+cinemaOffset), kiai_2Textures, true);
            // what i'm doing here
            MoveLyrics(80512, 83227, new Vector2(431, 209+cinemaOffset), new Vector2(382, 209+cinemaOffset), kiai_3Textures, true);  
            MoveLyrics(80760, 83227, new Vector2(484, 209+cinemaOffset), new Vector2(449, 209+cinemaOffset), kiai_4Textures, true);  
            MoveLyrics(81120, 83227, new Vector2(535, 209+cinemaOffset), new Vector2(514, 209+cinemaOffset), kiai_5Textures, true);  
            MoveLyrics(82062, 83227, new Vector2(594, 209+cinemaOffset), new Vector2(577, 213+cinemaOffset), kiai_6Textures, true);

            // mrs magic radio
            MoveLyrics(95873,99517, new Vector2(30, 395- cinemaOffset), new Vector2(30 + offset, 395- cinemaOffset), line5_Textures);
            MoveLyrics(95873,99517, new Vector2(120, 395- cinemaOffset), new Vector2(120 + offset, 395- cinemaOffset), line5_1Textures);
            MoveLyrics(95873,99517, new Vector2(200, 395- cinemaOffset), new Vector2(200 + offset, 395- cinemaOffset), line5_2Textures);
            // give me one last chance to show
            MoveLyrics(103137, 106757, new Vector2(30, 395- cinemaOffset), new Vector2(90, 395- cinemaOffset), line6_Textures);
            MoveLyrics(103137, 106757, new Vector2(80, 395- cinemaOffset), new Vector2(80 + offset, 395- cinemaOffset), line6_1Textures);
            MoveLyrics(103137, 106757, new Vector2(130, 395- cinemaOffset), new Vector2(130 + offset, 395- cinemaOffset), line6_2Textures);
            MoveLyrics(103137, 106757, new Vector2(190, 395- cinemaOffset), new Vector2(190 + offset, 395- cinemaOffset), line6_3Textures);
            MoveLyrics(103137, 106757, new Vector2(275, 395- cinemaOffset), new Vector2(275 + offset, 395- cinemaOffset), line6_4Textures);
            MoveLyrics(103137, 106757, new Vector2(340, 395- cinemaOffset), new Vector2(340 + offset, 395- cinemaOffset), line6_5Textures);
            MoveLyrics(103137, 106757, new Vector2(395, 395- cinemaOffset), new Vector2(395 + offset, 395- cinemaOffset), line6_6Textures);

            MoveLyrics(110377, 114675, new Vector2(30, 395- cinemaOffset), new Vector2(90, 395- cinemaOffset), line7_Textures);
            MoveLyrics(110377, 114675, new Vector2(80, 395- cinemaOffset), new Vector2(80 + offset, 395- cinemaOffset), line7_1Textures);
            MoveLyrics(110377, 114675, new Vector2(145, 395- cinemaOffset), new Vector2(145 + offset, 395- cinemaOffset), line7_2Textures);
            MoveLyrics(110377, 114675, new Vector2(220, 395- cinemaOffset), new Vector2(220 + offset, 395- cinemaOffset), line7_3Textures);
            MoveLyrics(110377, 114675, new Vector2(285, 395- cinemaOffset), new Vector2(285 + offset, 395- cinemaOffset), line7_4Textures);
            MoveLyrics(110377, 114675, new Vector2(360, 395- cinemaOffset), new Vector2(360 + offset, 395- cinemaOffset), line7_5Textures);

            MoveLyrics(117617, 121236, new Vector2(30, 395- cinemaOffset), new Vector2(90, 395- cinemaOffset), line8_Textures);
            MoveLyrics(117617, 121236, new Vector2(110, 395- cinemaOffset), new Vector2(110 + offset, 395- cinemaOffset), line8_1Textures);
            MoveLyrics(117617, 121236, new Vector2(175, 395- cinemaOffset), new Vector2(175 + offset, 395- cinemaOffset), line8_2Textures);
            MoveLyrics(117617, 121236, new Vector2(260, 395- cinemaOffset), new Vector2(260 + offset, 395- cinemaOffset), line8_3Textures);
            MoveLyrics(120331, 121236, new Vector2(402, 395- cinemaOffset), new Vector2(416, 395- cinemaOffset), line8_4Textures);

             // i don't know
            MoveLyrics(125988, 128024, new Vector2(459, 162+cinemaOffset), new Vector2(310 + 20, 162+cinemaOffset), kiaiTextures, true);
            MoveLyrics(125988, 128024, new Vector2(500, 162+cinemaOffset), new Vector2(360+ 20, 162+cinemaOffset), kiai_1Textures, true);
            MoveLyrics(125988, 128024, new Vector2(580, 162+cinemaOffset), new Vector2(430+ 20, 162+cinemaOffset), kiai_2Textures, true);

            MoveLyrics(129608, 133906, new Vector2(459, 162+cinemaOffset), new Vector2(310, 162+cinemaOffset), kiaiTextures, true);
            MoveLyrics(129608, 133906, new Vector2(500, 162+cinemaOffset), new Vector2(360, 162+cinemaOffset), kiai_1Textures, true);
            MoveLyrics(129608, 133906, new Vector2(580, 162+cinemaOffset), new Vector2(430, 162+cinemaOffset), kiai_2Textures, true);
            // what i'm doing here
            MoveLyrics(131191, 133906, new Vector2(431, 209+cinemaOffset), new Vector2(382, 209+cinemaOffset), kiai_3Textures, true);  
            MoveLyrics(131531, 133906, new Vector2(484, 209+cinemaOffset), new Vector2(449, 209+cinemaOffset), kiai_4Textures, true);  
            MoveLyrics(131870, 133906, new Vector2(535, 209+cinemaOffset), new Vector2(514, 209+cinemaOffset), kiai_5Textures, true);  
            MoveLyrics(132775, 133906, new Vector2(594, 209+cinemaOffset), new Vector2(577, 213+cinemaOffset), kiai_6Textures, true);

             // i don't know
            MoveLyrics(140467, 142503, new Vector2(459, 162+cinemaOffset), new Vector2(310+ 20, 162+cinemaOffset), kiaiTextures, true);
            MoveLyrics(140467, 142503, new Vector2(500, 162+cinemaOffset), new Vector2(360+ 20, 162+cinemaOffset), kiai_1Textures, true);
            MoveLyrics(140467, 142503, new Vector2(580, 162+cinemaOffset), new Vector2(430+ 20, 162+cinemaOffset), kiai_2Textures, true);

            MoveLyrics(144087, 148386, new Vector2(459, 162+cinemaOffset), new Vector2(310, 162+cinemaOffset), kiaiTextures, true);
            MoveLyrics(144087, 148386, new Vector2(500, 162+cinemaOffset), new Vector2(360, 162+cinemaOffset), kiai_1Textures, true);
            MoveLyrics(144087, 148386, new Vector2(580, 162+cinemaOffset), new Vector2(430, 162+cinemaOffset), kiai_2Textures, true);
            // what i'm doing here
            MoveLyrics(145671, 148386, new Vector2(431, 209+cinemaOffset), new Vector2(382, 209+cinemaOffset), kiai_3Textures, true);  
            MoveLyrics(146010, 148386, new Vector2(484, 209+cinemaOffset), new Vector2(449, 209+cinemaOffset), kiai_4Textures, true);  
            MoveLyrics(146350, 148386, new Vector2(535, 209+cinemaOffset), new Vector2(514, 209+cinemaOffset), kiai_5Textures, true);  
            MoveLyrics(147255, 148386, new Vector2(594, 209+cinemaOffset), new Vector2(577, 213+cinemaOffset), kiai_6Textures, true);

            // leaving me outside
            MoveLyrics(155626, 168295, new Vector2(459, 162+cinemaOffset), new Vector2(310, 162+cinemaOffset), kiai2_Textures, true);
            MoveLyrics(155626, 168295, new Vector2(535, 162+cinemaOffset), new Vector2(390, 162+cinemaOffset), kiai2_1Textures, true);
            MoveLyrics(155626, 168295, new Vector2(620, 162+cinemaOffset), new Vector2(470, 162+cinemaOffset), kiai2_2Textures, true);

            MoveLyrics(160829, 163770, new Vector2(431, 209+cinemaOffset), new Vector2(431 - offset, 209+cinemaOffset), kiai2_3Textures, true);  
            MoveLyrics(161055, 163770, new Vector2(470, 209+cinemaOffset), new Vector2(470 - offset, 209+cinemaOffset), kiai2_4Textures, true);  
            MoveLyrics(161282, 163770, new Vector2(520, 209+cinemaOffset), new Vector2(520 - offset, 209+cinemaOffset), kiai2_5Textures, true);  
            MoveLyrics(161847, 163770, new Vector2(580, 209+cinemaOffset), new Vector2(580 - offset, 213+cinemaOffset), kiai2_6Textures, true);
            MoveLyrics(162187, 163770, new Vector2(635, 209+cinemaOffset), new Vector2(635 - offset, 213+cinemaOffset), kiai2_7Textures, true);
            MoveLyrics(162639, 163770, new Vector2(680, 209+cinemaOffset), new Vector2(680 - offset, 213+cinemaOffset), kiai2_8Textures, true);

            MoveLyrics(164449, 168295, new Vector2(431, 209+cinemaOffset), new Vector2(431 - offset, 209+cinemaOffset), kiai2_3Textures, true);  
            MoveLyrics(164675, 168295, new Vector2(470, 209+cinemaOffset), new Vector2(470 - offset, 209+cinemaOffset), kiai2_4Textures, true);  
            MoveLyrics(164902, 168295, new Vector2(520, 209+cinemaOffset), new Vector2(520 - offset, 209+cinemaOffset), kiai2_5Textures, true);  
            MoveLyrics(165354, 168295, new Vector2(580, 209+cinemaOffset), new Vector2(580 - offset, 213+cinemaOffset), kiai2_6Textures, true);
            MoveLyrics(165807, 168295, new Vector2(635, 209+cinemaOffset), new Vector2(635 - offset, 213+cinemaOffset), kiai2_7Textures, true);
            MoveLyrics(166259, 168295, new Vector2(680, 209+cinemaOffset), new Vector2(680 - offset, 213+cinemaOffset), kiai2_8Textures, true);

            MoveLyrics(170105, 182775, new Vector2(459, 162+cinemaOffset), new Vector2(310, 162+cinemaOffset), kiai2_Textures, true);
            MoveLyrics(170105, 182775, new Vector2(535, 162+cinemaOffset), new Vector2(390, 162+cinemaOffset), kiai2_1Textures, true);
            MoveLyrics(170105, 182775, new Vector2(620, 162+cinemaOffset), new Vector2(470, 162+cinemaOffset), kiai2_2Textures, true);

            MoveLyrics(175309, 178250, new Vector2(431, 209+cinemaOffset), new Vector2(431 - offset, 209+cinemaOffset), kiai2_3Textures, true);  
            MoveLyrics(175535, 178250, new Vector2(470, 209+cinemaOffset), new Vector2(470 - offset, 209+cinemaOffset), kiai2_4Textures, true);  
            MoveLyrics(175761, 178250, new Vector2(520, 209+cinemaOffset), new Vector2(520 - offset, 209+cinemaOffset), kiai2_5Textures, true);  
            MoveLyrics(176214, 178250, new Vector2(580, 209+cinemaOffset), new Vector2(580 - offset, 213+cinemaOffset), kiai2_6Textures, true);
            MoveLyrics(176666, 178250, new Vector2(635, 209+cinemaOffset), new Vector2(635 - offset, 213+cinemaOffset), kiai2_7Textures, true);
            MoveLyrics(177119, 178250, new Vector2(680, 209+cinemaOffset), new Vector2(680 - offset, 213+cinemaOffset), kiai2_8Textures, true);

            MoveLyrics(178929, 182775, new Vector2(431, 209+cinemaOffset), new Vector2(431 - offset, 209+cinemaOffset), kiai2_3Textures, true);  
            MoveLyrics(179155, 182775, new Vector2(470, 209+cinemaOffset), new Vector2(470 - offset, 209+cinemaOffset), kiai2_4Textures, true);  
            MoveLyrics(179381, 182775, new Vector2(520, 209+cinemaOffset), new Vector2(520 - offset, 209+cinemaOffset), kiai2_5Textures, true);  
            MoveLyrics(179834, 182775, new Vector2(580, 209+cinemaOffset), new Vector2(580 - offset, 213+cinemaOffset), kiai2_6Textures, true);
            MoveLyrics(180286, 182775, new Vector2(635, 209+cinemaOffset), new Vector2(635 - offset, 213+cinemaOffset), kiai2_7Textures, true);
            MoveLyrics(180739, 182775, new Vector2(680, 209+cinemaOffset), new Vector2(680 - offset, 213+cinemaOffset), kiai2_8Textures, true);


            MoveLyrics(190015, 193718, new Vector2(30, 395), new Vector2(90, 395), line1Textures);
            MoveLyrics(190015, 193718, new Vector2(130, 395), new Vector2(190, 395), line1_1Textures);
            MoveLyrics(190015, 193718, new Vector2(180, 395), new Vector2(235, 395), line1_2Textures);
            MoveLyrics(190015, 193718, new Vector2(230, 395), new Vector2(290, 395), line1_3Textures);

            // just let me be myself
            MoveLyrics(195553, 206540, new Vector2(30, 395), new Vector2(90, 395), line9_Textures);
            MoveLyrics(195879, 206540, new Vector2(90, 395), new Vector2(90 + offset, 395), line9_1Textures);
            MoveLyrics(196330, 206540, new Vector2(140, 395), new Vector2(140 + offset, 395), line9_2Textures);
            MoveLyrics(197195, 206540, new Vector2(190, 395), new Vector2(190 + offset, 395), line9_3Textures);
            MoveLyrics(197600, 206540, new Vector2(240, 395), new Vector2(240 + offset, 395), line9_4Textures);
            MoveLyrics(199661, 206540, new Vector2(295, 395), new Vector2(280 + offset, 395), line9_5Textures);
        }

        public void MoveLyrics(double start, double end, Vector2 startPos, Vector2 endPos, LyricTextures textures, bool kiai = false)
        {
            // let's fake that the blur is moving with it, so we would add padding to the left and right for movement
            int randTransitionDuration = Random(150, 500);
            float blurMovement = Random(2.0f, 10.5f);
            OsbSprite blurSprite = layer.CreateSprite(textures.blurredTexture);
            OsbSprite sprite = layer.CreateSprite(textures.texture.Path);
            endPos.Y += Random(-2.5f, 2.5f);

            blurSprite.Move(start - randTransitionDuration, start, new Vector2(!kiai ? startPos.X - blurMovement : startPos.X + blurMovement, startPos.Y), startPos);
            blurSprite.Fade(start - randTransitionDuration, start - (randTransitionDuration / 2), 0, 1);
            blurSprite.Fade(start - (randTransitionDuration / 2), start, 1, 0);
            blurSprite.Scale(start - randTransitionDuration, 0.5);
            blurSprite.Rotate(start, 0);

            sprite.Move(start - (randTransitionDuration / 2), end, new Vector2(!kiai ? startPos.X - (blurMovement / 2) : startPos.X + (blurMovement / 2), startPos.Y), endPos);
            sprite.Fade(start - (randTransitionDuration / 2), start, 0, 1);
            sprite.Scale(start - (randTransitionDuration / 2), 0.5);
            sprite.Fade(end - (randTransitionDuration / 2), end, 1, 0);
            sprite.Rotate(start - (randTransitionDuration / 2), end, 0, Random(-0.2f, 0.2f));

            blurSprite.Fade(end - (randTransitionDuration / 2), end + randTransitionDuration, 1, 0);
            blurSprite.Move(end - (randTransitionDuration / 2), end + randTransitionDuration, sprite.PositionAt(end - (randTransitionDuration / 2)), !kiai ? ((Vector2)sprite.PositionAt(end - (randTransitionDuration / 2))) + new Vector2(blurMovement, 0) : ((Vector2)sprite.PositionAt(end - (randTransitionDuration / 2))) - new Vector2(blurMovement, 0));
            blurSprite.Rotate(end - (randTransitionDuration / 2), end + randTransitionDuration, sprite.RotationAt(end - (randTransitionDuration / 2)), sprite.RotationAt(end));
        }


        public LyricTextures GetTexture(string character)
        {
            LyricTextures returningChar;
            if (!fontLyrics.Any(t => t.spriteChar == character))
            {
                FontTexture texture = font.GetTexture(character);
                GaussianBlur blur = new GaussianBlur(GetMapsetBitmap(texture.Path, false));
                var blurImage = blur.Process(BlurRadius);
                string blurTexturePath = $"sb/b/{Path.GetFileName(texture.Path)}";
                Log(blurTexturePath);

                blurImage.Save(Path.Combine(MapsetPath, blurTexturePath), ImageFormat.Png);

                returningChar = new LyricTextures
                {
                    texture = texture,
                    spriteChar = character,
                    blurredTexture = blurTexturePath
                };
                fontLyrics.Add(returningChar);
            }
            else
            {
                returningChar = fontLyrics.First(t => t.spriteChar == character);
            }

            return returningChar;
        }

        public class LyricTextures
        {
            public string spriteChar;
            public FontTexture texture;
            public string blurredTexture;
        }
    }
}
