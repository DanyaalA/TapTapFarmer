﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TapTapFarmer.Constants
{
    class LocationConstants
    {
        //Global Locations || Locations that are used throughout the game
        //public static Point GLOBAL_BOT_IDLE_CLICK = new Point(300, 725); // D
        //public static Point GLOBAL_BATTLE_SKIP = new Point(514, 861); // D
        //public static Point GLOBAL_BATTLE_SKIP_CONFIRM = new Point(180, 620); //D
        //public static Point GLOBAL_BATTLE_FINISHED = new Point(272, 834); //D
        //public static Point GLOBAL_BATTLE_CHECK_WIN = new Point(252, 399);
        public static Point GLOBAL_LEVEL_BAR = new Point(130, 20);

        //public static Point GLOBAL_ENEMYINFO_BATTLE_CONFIRM = new Point(320, 735); //D
        public static Point GLOBAL_TEAM_BATTLE_CONFIRM = new Point(269, 869); //D


        // Screen
        public static Point SCREEN_CITY_TOP = new Point(267, 56);
        public static Point SCREEN_CITY_BOTTOM = new Point(267, 870); 

        // Home ButtonsD:\Visual Studio\2019\TapTapFarmer\TapTapFarmer\Constants\OtherConstants.cs
        public static Point HOME_MENU_BUTTON = new Point(136, 95);//D
        public static Point HOME_DAILYBONUS_BUTTON = new Point(493, 155);
        public static Point HOME_PROFILE_BUTTON = new Point(42, 10);
        public static Point HOME_ACCOUNT_ALREADY_LOGGED = new Point(267, 590);
        public static Point HOME_BOSS_BATTLE_NEXT = new Point(270, 165);
        public static Point HOME_BOSS_IDLE_NEXT = new Point(288, 634);
        public static Point HOME_PIRVALLEGE_BUTTON = new Point(492, 155);
        public static Point HOME_BOSS_MAP_CIRCLE = new Point(446, 125);
        public static Point PRIVALLEGE_CHECKIN_BUTTON = new Point(434, 852);

        // Profile Buttons
        public static Point PROFILE_CLAIM_BUTTON = new Point(488, 590);

        // Crate Buttons
        public static Point CRATE_EXIT_BUTTON = new Point(505, 73);

        // Bag Buttons
        public static Point BAG_SHARDS_BUTTON = new Point(382, 57);
        public static Point BAG_SHARDS_REWARDS_BUTTON = new Point(114, 166);
        public static Point BAG_SHARDS_REWARDS_EXCHANGE_BUTTON = new Point(374, 689);
        public static Point BAG_SHARDS_REWARDS_CLAIM_BUTTON = new Point(272, 700);
        public static Point BAG_EXIT_BUTTON = new Point(503, 123);

        public static Point TAVERN_COMPLETE = new Point(424, 704);
        public static Point TAVERN_QUICK = new Point(168, 765);
        public static Point TAVERN_START = new Point(424, 759);
        public static Point TAVERN_SPEED = new Point(206, 519);

        // 8hr Money Bonus Buttons (Meowth Coin)
        public static Point MONEYBONUS_FREE_BUTTON = new Point(419, 326);
        public static Point MONEYBONUS_EXIT_BUTTON = new Point(501, 168);

        //Home Bottom Buttons
        public static Point HOME_BOTTOM_BATTLE = new Point(273, 954);
        //public static Point HOME_BOTTOM_BATTLE_ACTIVE = new Point(317, 235);
        public static Point HOME_BOTTOM_CITY = new Point(399, 944);

        //Menu Strip Buttons
        public static Point MENU_MAIL_BUTTON = new Point(54, 808);

        //City Buttons
        public static Point CITY_CURSOR_SCROLL = new Point(284, 119);
        public static Point CITY_ITEMCENTER_BUTTON = new Point(84, 552);
        public static Point CITY_SHOP_BUTTON = new Point(454, 532);
        public static Point CITY_PMGARDEN_BUTTON = new Point(231, 354);
        public static Point CITY_LINKTRADE_BUTTON = new Point(372, 149);
        public static Point CITY_GAMECORNER_BUTTON = new Point(66, 801);

        public static Point CITY_DISPATCH_BUTTON = new Point(380, 702);
        public static Point CITY_SAFARIZONE_BUTTON = new Point(195, 572);
        public static Point CITY_BATTLELEAGUE_BUTTON = new Point(518, 566);
        public static Point CITY_SKYPILAR_BUTTON = new Point(108, 465);
        public static Point CITY_BATTLESUBWAY_BUTTON = new Point(385, 360);
        public static Point CITY_GYM_BUTTON = new Point(254, 308);

        // Mail Buttons
        public static Point MAIL_CLAIMALL_BUTTON = new Point(94, 702);
        public static Point MAIL_DELETE_BUTTON = new Point(353, 707);
        public static Point MAIL_CLAIM_BUTTON = new Point(275, 701);

        //Sky Pillar
        //public static Point SKYPILLAR_BATTLE_LOCATION = new Point(424, 676);
        //Gym
        //public static Point GYM_BATTLE_LOCATION = new Point(448, 578);

        //Test
        public static Point GOLD_RED_CLAIM = new Point(525, 9);

        //Updated
        ///
        ////
        /////
        //Global
        public static Point GLOBAL_BOT_IDLE_CLICK = new Point(300, 725);
        public static Point GLOBAL_ENEMYINFO_BATTLE_CONFIRM = new Point(263, 682);
        public static Point GLOBAL_BATTLE_TEAM_CONFIRM_LOCATION = new Point(266, 823);
        public static Point GLOBAL_BATTLE_SKIP = new Point(513, 826);
        public static Point GLOBAL_BATTLE_SKIP_CONFIRM = new Point(153, 566);
        public static Point GLOBAL_BATTLE_FINISHED = new Point(316, 809);
        public static Point GLOBAL_BATTLE_CHECK_WIN = new Point(219, 419);
        public static Point GLOBAL_BATTLE_CHECK_LOSS = new Point(265, 403);

        //SHARDS
        public static Point MENU_QUEST = new Point(58, 391);
        public static Point MENU_EVENTS = new Point(58, 424);
        public static Point MENU_FRIENDS = new Point(58, 519);
        public static Point MENU_FAMILIAR = new Point(58, 645);
        public static Point MENU_MAILS = new Point(58, 709);

        //Friends Menu
        public static Point FRIENDS_LIST = new Point(144, 103);
        public static Point FRIENDS_CLAIM_SEND = new Point(436,692);
        public static Point FRIENDS_REQUESTS = new Point(384, 103);
        public static Point FRIENDS_COOP = new Point(503,103);
        public static Point FRIENDS_SCOUT = new Point(336, 676);
        public static Point FRIENDS_ACCEPT = new Point(439, 277);
        public static Point FRIENDS_DELETE = new Point(459, 210);

        //Home Screen Buttons
        public static Point HOME_MAINMENU_LOCATION = new Point(136, 95);
        public static Point HOME_BOSS_BATTLE_LOCATION = new Point(332, 167);
        public static Point HOME_BOTTOM_BATTLE_ACTIVE = new Point(289, 869);
        public static Point HOME_NEXT_BATTLE_LOCATION = new Point(311, 186);
        public static Point HOME_NEXT_SELECT_BATTLE_LOCATION = new Point(313, 679);

        //Home Bottom Buttons
        public static Point HOME_BOTTOM_HEROES_LOCATION = new Point(46, 909);
        public static Point HOME_BOTTOM_CASTLE_LOCATION = new Point(404, 941);
        public static Point HOME_BOTTOM_GUILD = new Point(139, 909);
        public static Point HOME_BOTTOM_BATTLE_LOCATION = new Point(270, 980);
        public static Point HOME_BOTTOM_ACTIVE_BATTLE_LOCATION = new Point(296, 902);
        public static Point HOME_ALCHEMY_BUTTON = new Point(515, 28);

        //Alchemy
        public static Point ALCHEMY_FREE_BUTTON = new Point(417, 298);
        public static Point ALCHEMY_20GEMS_BUTTON = new Point(462, 496);
        public static Point ALCHEMY_50GEMS_BUTTON = new Point(465, 667);

        //Fortune Wheel
        public static Point FORTUNE_SPIN1_BUTTON = new Point(203, 788);
        public static Point FORTUNE_SPINAGAIN1_BUTTON = new Point(206, 707);
        public static Point FORTUNE_PURCHASE = new Point(489, 175);
        public static Point FORTUNE_BUY = new Point(321, 646);

        //Hero Chest
        public static Point HEROCHEST_GRAND_FREE_CIRCLE = new Point(496, 302);
        public static Point HEROCHEST_COMMON_FREE_CIRCLE = new Point(496, 590);
        public static Point HEROCHEST_GRAND_CLAIM = new Point(461, 339);
        public static Point HEROCHEST_COMMON_CLAIM = new Point(451, 629);

        //Menu Buttons
        public static Point MENU_QUESTS_BUTTON_LOCATION = new Point(60, 424);
        public static Point MENU_MAIL_LOCATION = new Point(60, 763);
        public static Point MENU_OPTIONS_LOCATION = new Point(49, 866);

        //Quest Constants
        public static Point QUEST_CLAIMAIN_LOCATION = new Point(445, 245);
        public static Point QUEST_BUTTON2_LOCATION = new Point(447, 481);

        //Mail Menu
        public static Point MAIL_RECEIVE = new Point(308, 709);
        public static Point MAIL_RECEIVEALL = new Point(97, 686);

        //HERO BUTTON LOCATIONS
        public static Point HEROES_SIXTH_HERO_LOCATION = new Point(121, 361);
        public static Point HEROES_UPGRADE_NORMAL_LOCATION = new Point(273, 873);
        public static Point HEROES_SELECTED_CLOSE_LOCATION = new Point(508, 110);
        public static Point HEROES_CLOSE_LOCATION = new Point(508, 161);

        public static Point BOSS_BATTLE_SELECT_LOCATION = new Point(321, 735); //Change to GLOBAL_BATTLE_ENEMYINFO_CONFIRM_LOCATION
        public static Point BOSS_BATTLE_CONFIRM_LOCATION = new Point(315, 880); //Change To GLOBAL_BATTLE_TEAM_CONFIRM_LOCATION
        public static Point BOSS_BATTLE_FINISHED_BACK_LOCATION = new Point(274, 431);

        //Castle Buttons (Now Also Obsolete as i use the more efficient button for these)
        public static Point CASTLE_SCROLL_LOCATION = new Point(503, 600);
        public static Point CASTLE_BLACKSMITH_LOCATION = new Point(359, 703);
        public static Point CASTLE_HERO_CHEST_CHECK_LOCATION = new Point(80, 514);
        public static Point CASTLE_HERO_CHEST_LOCATION = new Point(320, 545);
        public static Point CASTLE_ALTAR_LOCATION = new Point(148, 420);
        public static Point CASTLE_MARKET_CHECK_LOCATION = new Point(296, 234);
        public static Point CASTLE_MARKET_LOCATION = new Point(387, 266);
        public static Point CASTLE_CREATION_BAG_LOCATION = new Point(230, 140);

        //Obsolute: Don't need the below as a more efficient method is now used
        public static Point CASTLE_FORTUNE_WHEEL_LOCATION = new Point(193, 669);
        public static Point CASTLE_ARENA_LOCATION = new Point(260, 400);
        public static Point CASTLE_DOS_LOCATION = new Point(378, 220);
        public static Point CASTLE_MIRCLE_EYE_LOCATION = new Point(255, 608);
        public static Point CASTLE_TAVERN_LOCATION = new Point(253, 581);
        public static Point CASTLE_EXPEDITION_LOCATION = new Point(217, 826);
        public static Point CASTLE_PLANET_TRIAL_LOCATION = new Point(323, 580);

        //Guild
        public static Point GUILD_BATTLE = new Point(347, 637);
        public static Point GUILD_ATTACK = new Point(306, 438);
        public static Point GUILD_MINE = new Point(163, 358);
        public static Point GUILD_MINE_BONUS = new Point(371, 750);
        public static Point GUILD_CLAIM_BONUS = new Point(330, 770);
        public static Point GUILD_CLAIM = new Point(275, 691);
        public static Point GUILD_START_DIGGING = new Point(486, 755);
        public static Point GUILD_WAR_TEAM = new Point(104, 474);
        public static Point GUILD_SET_TEAM = new Point(275, 825);
        public static Point GUILD_DAILY_COINS = new Point(336, 258);

        //Den Of Secrets
        public static Point DOS_BATTLE_LOCATION = new Point(479, 585);

        //Events
        public static Point EVENTS_CLAIM_1 = new Point(462, 324);
        public static Point EVENTS_CLAIM_2 = new Point(462, 534);
        public static Point EVENTS_CLAIM_3 = new Point(462, 744);

        public static Point EVENTS_ATTACK_1 = new Point(280, 220);
        public static Point EVENTS_ATTACK_2 = new Point(280, 427);
        public static Point EVENTS_ATTACK_3 = new Point(280, 635);

        public static Point EVENTS_CHALLENGE_BOTTOM = new Point(452, 732);


        //Blacksmith
        public static Point BLACKSMITH_WEAPON = new Point(138, 468);
        public static Point BLACKSMITH_ARMOR = new Point(260, 467);
        public static Point BLACKSMITH_ACCESSORY = new Point(381, 469);
        public static Point BLACKSMITH_HELMET = new Point(504, 468);

        public static Point BLACKSMITH_DEFAULT = new Point(115, 535);
        public static Point BLACKSMITH_LOWER = new Point(176, 309);
        public static Point BLACKSMITH_CLAIM = new Point(323, 714);
        public static Point BLACKSMITH_PURCHASE = new Point(409, 407);

        public static Point QUEST_CLAIM = new Point(485, 328);
        public static Point QUEST_CLAIM_MASTER = new Point(485, 210);

        public static Point BRAVE_REFRESH = new Point(457, 421);
        public static Point BRAVE_BATTLE1 = new Point(454, 505);
        public static Point BRAVE_BATTLE2 = new Point(454, 599);
        public static Point BRAVE_BATTLE3 = new Point(462, 698);

        public static Point BRAVE_CHOSEREWARD = new Point(270, 476);
        public static Point BRAVE_RANDOM = new Point(270, 647);
        //Sky Pillar
        public static Point SKYPILLAR_BATTLE_LOCATION = new Point(414, 304);
    }
}
