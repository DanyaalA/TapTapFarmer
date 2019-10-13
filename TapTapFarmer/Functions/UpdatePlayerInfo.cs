﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapTapFarmer.Constants;
using System.Threading;
using System.Drawing;

namespace TapTapFarmer.Functions
{
    class UpdatePlayerInfo
    {
        public static void CheckMenu()
        {
            WindowCapture.CaptureApplication(GlobalVariables.GLOBAL_PROC_NAME);
            //Reset To Main Menu
            Main.ResetToHome();

            //Open Menu First
            MouseHandler.MoveCursor(LocationConstants.HOME_MENU_BUTTON, true);

            //Setting Up Boolean Var
            Boolean[] NotifAvailable = new Boolean[7];

            //Take New Screenshot
            WindowCapture.CaptureApplication(GlobalVariables.GLOBAL_PROC_NAME);
            
            //Check If Anything on the menu needs to be completed (Keep In Mind Quests Needs a deeper Check)
            GlobalVariables.QUESTS_FINISHED = !PixelChecker.CheckPixelValue(LocationConstants.MENU_QUEST, ColorConstants.MENU_QUEST_RED); //Requires more checks

            //Events Require Two Checks
            if (PixelChecker.CheckPixelValue(LocationConstants.MENU_EVENTS, ColorConstants.MENU_EVENTS_GREEN) || PixelChecker.CheckPixelValue(LocationConstants.MENU_EVENTS, ColorConstants.MENU_EVENTS_RED))
            {
                GlobalVariables.EVENTS_COMPLETED = false;
            }


            GlobalVariables.HEARTS_SENT = !PixelChecker.CheckPixelValue(LocationConstants.MENU_FRIENDS, ColorConstants.MENU_FRIENDS_RED);
            GlobalVariables.UPGRADED_FAMILIAR = !PixelChecker.CheckPixelValue(LocationConstants.MENU_FAMILIAR, ColorConstants.MENU_FAMILIAR_GREEN);
            GlobalVariables.MAIL_EMPTY = !PixelChecker.CheckPixelValue(LocationConstants.MENU_MAILS, ColorConstants.MENU_MAIL_RED);

            Console.WriteLine(GlobalVariables.QUESTS_FINISHED);
            Console.WriteLine(GlobalVariables.EVENTS_COMPLETED);
            Console.WriteLine(GlobalVariables.HEARTS_SENT);
            Console.WriteLine(GlobalVariables.UPGRADED_FAMILIAR);
            Console.WriteLine(GlobalVariables.MAIL_EMPTY);
        }

        public static void UpdateMenu()
        {
            //Easiest Think on List is To Claim Mail so ill do it first
            if (GlobalVariables.MAIL_EMPTY == false)
            {
                ClaimMail();
            }
        }

        public static int[] GetCurrecyDetails()
        {
            Main.ResetToHome();
            Main.Sleep(1);
            OpenObjects.OpenAltar();
            Main.Sleep(2);
            int[] CurrencyArray = new int[5]; // 0 = Gold; 1 = Gem; 2 = Level; 3 = Purple Soul; 4 = Golden Soul;

            //Task/Thread This Later
            CurrencyArray[0] = ImageToText.GetMoneyAmount();
            CurrencyArray[1] = ImageToText.GetGemAmount();
            CurrencyArray[2] = ImageToText.GetLevel();
            CurrencyArray[3] = ImageToText.GetPurpleSoulAmount();
            CurrencyArray[4] = ImageToText.GetGoldenSoulAmount();

            if (CurrencyArray[2] == -1)
            {
                MouseHandler.MoveCursor(TextConstants.LEVEL_START, true);
                CurrencyArray[2] = ImageToText.GetLevelAdvanced();
            }

            Console.WriteLine("Gold " + CurrencyArray[0]);
            Console.WriteLine("Gem " + CurrencyArray[1]);
            Console.WriteLine("Level " + CurrencyArray[2]);
            Console.WriteLine("Purple " + CurrencyArray[3]);
            Console.WriteLine("Golden " + CurrencyArray[4]);

            return CurrencyArray;
        }

        public static Boolean ClaimFriends()
        {
            WindowCapture.CaptureApplication("Nox");

            Main.ResetToHome();

            //if (!Main.ResetToHome())
            //{
            //    Console.WriteLine("Not Home");
            //    return false;
            //}

            Main.ResetToHome();

            Thread.Sleep(500);
            MouseHandler.MoveCursor(LocationConstants.HOME_MAINMENU_LOCATION, true);
            Main.Sleep(1);
            
            if (!PixelChecker.CheckPixelValue(LocationConstants.MENU_FRIENDS, ColorConstants.MENU_FRIENDS_RED))
            {
                Console.WriteLine("Its Not Red");
                return true;
            }

            Main.Sleep(1);

            MouseHandler.MoveCursor(LocationConstants.MENU_FRIENDS, true);
            Main.Sleep(1);

            if (PixelChecker.CheckPixelValue(LocationConstants.FRIENDS_LIST, ColorConstants.FRIENDS_LIST_RED))
            {
                MouseHandler.MoveCursor(LocationConstants.FRIENDS_LIST, true);
                Main.Sleep(1);
                MouseHandler.MoveCursor(LocationConstants.FRIENDS_CLAIM_SEND, true);
                Main.Sleep(1);
            }

            if (PixelChecker.CheckPixelValue(LocationConstants.FRIENDS_REQUESTS, ColorConstants.FRIENDS_REQUESTS_GREEN))
            {
                //Do Nothing for now

            }

            if (PixelChecker.CheckPixelValue(LocationConstants.FRIENDS_COOP, ColorConstants.FRIENDS_COOP_RED))
            {
                MouseHandler.MoveCursor(LocationConstants.FRIENDS_COOP, true);
                Main.Sleep(1);
                MouseHandler.MoveCursor(LocationConstants.FRIENDS_SCOUT, true);
                Main.Sleep(1);
            }

            

            Main.ResetToHome();

            return true;
        }

        public static Boolean ClaimEvents()
        {
            WindowCapture.CaptureApplication("Nox");
            Main.LogConsole("Trying to Claim Daily Events");
            Main.ResetToHome();

            Thread.Sleep(500);
            MouseHandler.MoveCursor(LocationConstants.HOME_MAINMENU_LOCATION, true);
            Main.Sleep(1);

            if (!PixelChecker.CheckPixelValue(LocationConstants.MENU_EVENTS, ColorConstants.MENU_EVENTS_GREEN) && !PixelChecker.CheckPixelValue(LocationConstants.MENU_EVENTS, ColorConstants.MENU_EVENTS_RED))
            {
                Main.LogConsole("Events Already Claimed!");
                return true;
            }

            MouseHandler.MoveCursor(LocationConstants.MENU_EVENTS, true);
            bool[] wonAttack = { false, false, false };
            bool[] attacked = { false, false, false };
            int totalClaimed = 0;
            //remove 96 Height

            #region Attack Event
            //Check if an attack is available
            if (PixelChecker.CheckPixelValue(LocationConstants.EVENTS_ATTACK_1, ColorConstants.EVENTS_ATTACK_1))
            {
                attacked[0] = true;
                MouseHandler.MoveCursor(LocationConstants.EVENTS_ATTACK_1, true);
                OpenChallenge();
                if (!Attack.EventsAttack())
                {
                    Main.LogConsole("Failed Win Event 1 Challenge!");
                }
                else
                {
                    Main.LogConsole("Successfully Defeated Event 1 Challenge!");
                    totalClaimed++;
                    wonAttack[0] = true;
                }
            }

            if (attacked[0])
            {
                OpenObjects.OpenEvents();
            }

            if (PixelChecker.CheckPixelValue(LocationConstants.EVENTS_ATTACK_2, ColorConstants.EVENTS_ATTACK_2))
            {
                attacked[1] = true;
                MouseHandler.MoveCursor(LocationConstants.EVENTS_ATTACK_2, true);
                OpenChallenge();
                if (!Attack.EventsAttack())
                {
                    Main.LogConsole("Failed Win Event 2 Challenge!");
                }
                else
                {
                    Main.LogConsole("Successfully Defeated Event 1 Challenge!");
                    totalClaimed++;
                    wonAttack[1] = true;
                }

            }

            if (attacked[1])
            {
                OpenObjects.OpenEvents();
            }

            if (PixelChecker.CheckPixelValue(LocationConstants.EVENTS_ATTACK_3, ColorConstants.EVENTS_ATTACK_3))
            {
                attacked[2] = true;
                MouseHandler.MoveCursor(LocationConstants.EVENTS_ATTACK_3, true);
                OpenChallenge();
                if (!Attack.EventsAttack())
                {
                    Main.LogConsole("Failed Win Event 3 Challenge!");
                }
                else
                {
                    Main.LogConsole("Successfully Defeated Event 1 Challenge!");
                    totalClaimed++;
                    wonAttack[2] = true;
                }
            }
            #endregion

            if (attacked[2])
            {
                OpenObjects.OpenEvents();
            }
            
            #region Claim Events
            while (PixelChecker.CheckPixelValue(LocationConstants.EVENTS_CLAIM_1, ColorConstants.EVENTS_CLAIM_1))
            {
                totalClaimed++;
                MouseHandler.MoveCursor(LocationConstants.EVENTS_CLAIM_1, true);
            }

            while (PixelChecker.CheckPixelValue(LocationConstants.EVENTS_CLAIM_2, ColorConstants.EVENTS_CLAIM_2))
            {
                totalClaimed++;
                MouseHandler.MoveCursor(LocationConstants.EVENTS_CLAIM_2, true);
            }

            while (PixelChecker.CheckPixelValue(LocationConstants.EVENTS_CLAIM_3, ColorConstants.EVENTS_CLAIM_3))
            {
                totalClaimed++;
                MouseHandler.MoveCursor(LocationConstants.EVENTS_CLAIM_3, true);
            }

            #endregion

            Main.LogConsole($"Claimed {totalClaimed.ToString()} Daily Events");

            Main.ResetToHome();

            return true;
        }

        private static void OpenChallenge()
        {
            if (!PixelChecker.SearchPixel(ColorConstants.EVENTS_UNCLAIMABLE, out Point unClaimLoc))
            {
                for (int i = 0; i < 3; i++)
                {
                    MouseHandler.MoveCursor(LocationConstants.HOME_BOTTOM_CASTLE_LOCATION, true);
                }
                OpenChallenge();
            }
            unClaimLoc = new Point(unClaimLoc.X, unClaimLoc.Y - 96);
            MouseHandler.MoveCursor(unClaimLoc, true);
        }

        public static Boolean ClaimPrivellage()
        {
            Main.ResetToHome();

            MouseHandler.MoveCursor(LocationConstants.HOME_PIRVALLEGE_BUTTON, true);

            while (PixelChecker.CheckPixelValue(LocationConstants.PRIVALLEGE_CHECKIN_BUTTON, ColorConstants.PRIVALLEGE_CHECKIN_YELLOW))
            {
                MouseHandler.MoveCursor(LocationConstants.PRIVALLEGE_CHECKIN_BUTTON, true);
                Thread.Sleep(500);
            }

            return true;
        }

        public static Boolean CombineEquipment()
        {
            /*   0   1   2   3   4  
            * 0  D | D | D | D | D
            * 1  D | D | D | D | D
            * 2  D | X | X | X | N
            */

            /* START AT (115, 535)
             * WHEN MOVING TO THE RIGHT DO (115 + (POS * 95), 535)
             * WHEN MOVING DOWN DO (115, 535 + (POS * 85))
             * THIS SHOULD LEAVE U TO THE LAST Y =  705
             * SO IN TOTAL THE CALCULATION IS
             * (115 + (POS * 95), 535 + (POS * 85))
             */

            ColorConstants.SetColours();

            //Main.ResetToHome();
            //OpenObjects.OpenBlackSmith();

            

            Point startPos = LocationConstants.BLACKSMITH_DEFAULT;
            Point setPos = startPos;
            //Console.WriteLine(ColorConstants.Equipments[0, 0].ToString());

            int combined = 0;

            //Thread.Sleep(1000);
            
            for (int y = 0; y < 3; y++)
            {

                for (int x = 0; x < 5; x++)
                {
                    if (combined == 3)
                    {
                        return true;
                    }

                    setPos = new Point(115 + (x * 95), 535 + (y * 85));
                    if (PixelChecker.CheckPixelValue(setPos, ColorConstants.Equipments[y, x]))
                    {
                        if (setPos.X == 495)
                        {
                            setPos = new Point(setPos.X - 5, setPos.Y);
                        }
                        Console.WriteLine($"Found Equipment that needs to be combined. Location - {x}:{y}");
                        int CombineAmount = ImageToText.GetCombineAmount();
                        if (CombineAmount == -1)
                        {
                            Console.WriteLine($"Unable To Read Combine Amount. Skipping Equipment Peice");
                        }
                        else if (CombineAmount <= 3 && CombineAmount != -1)
                        {
                            int price = ImageToText.GetBlacksmithPurchaseAmount();
                            Console.WriteLine(price);
                            combined = CombineAmount;
                        }
                        else
                        {
                            Console.WriteLine(CombineAmount);
                        }
                        MouseHandler.MoveCursor(setPos, true);
                    }
                }
            }
               
            
            Console.WriteLine("Finished");

            return true;
        }

        public static Boolean ClaimAlchemy()
        {
            bool ClaimFree = false;
            bool Claim20 = false;
            bool Claim50 = false;
            MouseHandler.MoveCursor(LocationConstants.HOME_ALCHEMY_BUTTON, true);
            if (PixelChecker.CheckPixelValue(LocationConstants.ALCHEMY_FREE_BUTTON, ColorConstants.ALCHEMY_FREE))
            {
                ClaimFree = true;
            }

            if (PixelChecker.CheckPixelValue(LocationConstants.ALCHEMY_20GEMS_BUTTON, ColorConstants.ALCHEMY_20GEMS))
            {
                Claim20 = true;
                if (GlobalVariables.CURRENCY_INFO[2] < 30 && GlobalVariables.CURRENCY_INFO[2] != -1)
                {
                    Claim20 = false;
                    Main.LogConsole("Not Claiming 20 Gem Alchemy As Gem Amount is below 30");
                }
            }

            if (PixelChecker.CheckPixelValue(LocationConstants.ALCHEMY_50GEMS_BUTTON, ColorConstants.ALCHEMY_50GEMS))
            {
                Claim50 = true;
                if (ClaimFree && Claim20)
                {
                    Claim20 = false;
                    Main.LogConsole("Not Claiming 50 Gem Alchemy As Free & 20 Gem is Available");
                }
                else if (GlobalVariables.CURRENCY_INFO[2] < 400 && GlobalVariables.CURRENCY_INFO[2] != -1)
                {

                    Claim20 = false;
                    Main.LogConsole("Not Claiming 50 Gem Alchemy As Gem Amount is below 500");
                }
            }

            if (ClaimFree && Claim20)
            {
                MouseHandler.MoveCursor(LocationConstants.ALCHEMY_FREE_BUTTON, true);
                Thread.Sleep(400);

                MouseHandler.MoveCursor(LocationConstants.ALCHEMY_20GEMS_BUTTON, true);
                Thread.Sleep(400);
                Main.LogConsole("Claimed Daily Free & 20 Gem Alchemy");
            }
            else if (ClaimFree && Claim50)
            {
                MouseHandler.MoveCursor(LocationConstants.ALCHEMY_FREE_BUTTON, true);
                Thread.Sleep(400);

                MouseHandler.MoveCursor(LocationConstants.ALCHEMY_50GEMS_BUTTON, true);
                Thread.Sleep(400);
                Main.LogConsole("Claimed Daily Free & 50 Gem Alchemy");
            }
            else if (ClaimFree && Claim50)
            {
                MouseHandler.MoveCursor(LocationConstants.ALCHEMY_20GEMS_BUTTON, true);
                Thread.Sleep(400);

                MouseHandler.MoveCursor(LocationConstants.ALCHEMY_50GEMS_BUTTON, true);
                Thread.Sleep(400);
                Main.LogConsole("Claimed Daily 20 & 50 Gem Alchemy");
            }
            else
            {
                return false;
            }

            return true;
        }

        public static Boolean Defeat3Main()
        {
            Main.ResetToHome();
            bool IdleClick = true;


            var task = new Thread(() =>
            {
                while (IdleClick)
                {
                    MouseHandler.MoveCursor(LocationConstants.GLOBAL_BOT_IDLE_CLICK, true);
                    Thread.Sleep(100);
                }
            });

            task.Start();

            Thread.Sleep(2 * 60000); //Sleep For 15 Minutes Before Continuing
            IdleClick = false;
            return true;
        }

        public static Boolean SpinWheel()
        {
            OpenObjects.OpenFortuneWheel();
            Thread.Sleep(500);
            int Tokens = ImageToText.GetWheelCoinAmount();

            if (Tokens < 2)
            {
                //Add Purchasing Token Below
                if (GlobalVariables.CURRENCY_INFO[2] < 300 && GlobalVariables.CURRENCY_INFO[2] != -1)
                {
                    Main.LogConsole("Not Enough Tokens & Gem Amount Below 300. Not Purchasing Any Tokens");
                    return false;
                }
                if (Tokens == 1)
                {
                    Main.LogConsole("Gems Above 300. Purchasing 1 Token");
                    //Add Token Purchasing
                    //MouseHandler.MoveCursor()
                    PurchaseTokens();
                    Thread.Sleep(1000);

                }
                else if (Tokens == 0)
                {
                    Main.LogConsole("Gems Above 300. Purchasing 2 Tokens");
                    //Add Token Purchasing
                    PurchaseTokens();
                    Thread.Sleep(1000);
                    PurchaseTokens();
                    Thread.Sleep(1000);
                }
            }

            Main.LogConsole("Got Enough Tokens Spinning Wheel");
            MouseHandler.MoveCursor(LocationConstants.FORTUNE_SPIN1_BUTTON, true);
            Thread.Sleep(3000);
            MouseHandler.MoveCursor(LocationConstants.FORTUNE_SPINAGAIN1_BUTTON, true);
            Thread.Sleep(3000);
            Main.LogConsole("Spun Daily Wheel");
            


            Main.ResetToHome();

            return true;
        }

        private static void PurchaseTokens()
        {
            MouseHandler.MoveCursor(LocationConstants.FORTUNE_PURCHASE, true);
            if (PixelChecker.CheckPixelValue(LocationConstants.FORTUNE_PURCHASE, ColorConstants.FORTUNE_PURCHASE))
            {
                MouseHandler.MoveCursor(LocationConstants.FORTUNE_PURCHASE);
            }
            else
            {
                Main.ResetToHome();
                OpenObjects.OpenFortuneWheel();
                PurchaseTokens();
            }

        }

        public static Boolean SummonGrandKey()
        {
            Main.ResetToHome();
            OpenObjects.OpenHeroChest();

            bool claimedGrand = false;

            //Goes to Bottom Of Hero Chest Screen
            for (int i = 0; i < 10; i++)
            {
                MouseHandler.MoveCursor(LocationConstants.HOME_BOTTOM_CASTLE_LOCATION, true);
            }

            Main.LogConsole("Checking For Grand Key");

            if (PixelChecker.CheckPixelValue(LocationConstants.HEROCHEST_GRAND_FREE_CIRCLE, ColorConstants.HEROCHEST_GRAND_FREE))
            {
                Main.LogConsole("Claiming Daily Free Grand Summon Key");
                MouseHandler.MoveCursor(LocationConstants.HEROCHEST_GRAND_FREE_CIRCLE, true);
                return true;
            }

            if (!claimedGrand)
            {
                int GrandKeyNo = ImageToText.GetGrandKeyAmount();
                if (GrandKeyNo > 0)
                {
                    Main.LogConsole("Using Extra Grand Summon Key In Backpack. Since No More Free Keys");
                    MouseHandler.MoveCursor(LocationConstants.HEROCHEST_GRAND_CLAIM, true);
                    return true;
                }
                
            }

            Main.LogConsole("No Keys Available to Summon Grand Chest");

            return false;
        }

        public static Boolean SummonCommonKey()
        {
            Main.ResetToHome();
            OpenObjects.OpenHeroChest();

            bool claimedCommon = false;

            //Goes to Bottom Of Hero Chest Screen
            for (int i = 0; i < 10; i++)
            {
                MouseHandler.MoveCursor(LocationConstants.HOME_BOTTOM_CASTLE_LOCATION, true);
            }

            Main.LogConsole("Checking Daily Common Key");

            if (PixelChecker.CheckPixelValue(LocationConstants.HEROCHEST_COMMON_FREE_CIRCLE, ColorConstants.HEROCHEST_COMMON_FREE))
            {
                Main.LogConsole("Claiming Daily Free Common Summon Key");
                MouseHandler.MoveCursor(LocationConstants.HEROCHEST_COMMON_FREE_CIRCLE, true);
                return true;
            }

            if (!claimedCommon)
            {
                int CommonKeyNo = ImageToText.GetCommonKeyAmount();
                if (CommonKeyNo > 0)
                {
                    Main.LogConsole("Using Extra Common Summon Key In Backpack. Since No More Free Keys");
                    MouseHandler.MoveCursor(LocationConstants.HEROCHEST_COMMON_CLAIM, true);
                    return true;
                }
            }

            Main.LogConsole("No Keys Available to Summon Common Chest");

            return false; ;
        }

        public static Boolean ClaimMail()
        {
            WindowCapture.CaptureApplication("Nox");

            Main.ResetToHome();

            //if (!Main.ResetToHome())
            //{
            //    Console.WriteLine("Returning False");
            //    return false;
            //}

            Thread.Sleep(500);
            MouseHandler.MoveCursor(LocationConstants.HOME_MAINMENU_LOCATION, true);
            Main.Sleep(3);
            if (PixelChecker.CheckPixelValue(LocationConstants.MENU_MAILS, ColorConstants.MENU_MAIL_RED))
            {
                Console.WriteLine("Its Red");
                MouseHandler.MoveCursor(LocationConstants.MENU_MAILS, true);
                Main.Sleep(1);
                MouseHandler.MoveCursor(LocationConstants.MAIL_RECEIVEALL, true);

                if (GlobalVariables.dailySettings.DeleteMail == false)
                {
                    Main.ResetToHome();
                    return true;
                }

                while (PixelChecker.CheckPixelValue(LocationConstants.MAIL_RECEIVE, ColorConstants.MAIL_DELETE))
                {
                    MouseHandler.MoveCursor(LocationConstants.MAIL_RECEIVE, true);
                }
            }
            else
            {
                Console.WriteLine("Its Not Red");
                MouseHandler.MoveCursor(LocationConstants.GLOBAL_BOT_IDLE_CLICK, true);
            }
            Main.ResetToHome();

            return true;
        }

    }
}
