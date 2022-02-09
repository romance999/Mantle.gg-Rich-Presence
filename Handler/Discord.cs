﻿using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantleRPC.Handler
{
    internal class Discord
    {
        public static DiscordRpcClient client;

        public static void DiscordID()
        {
            try
            {
                client = new DiscordRpcClient("811723701955461130");
                client.Initialize();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error occured. Error: {ex.Message}");
            }
        }

        public static void Start() //only run this once
        {
            try
            {
                DiscordID();
                client.SetPresence(new RichPresence()
                {
                    Details = $"Using Mantle capes",
                    State = $"Mantle is the awesome cape system which works with your favorite clients",
                    Assets = new Assets()
                    {
                        LargeImageKey = "mantle",
                        LargeImageText = "https://mantle.gg/",
                    }
                });
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error occured. Error: {ex.Message}");
            }
        }

        public static void Update(string details, string state)
        {
            try
            {
                client.SetPresence(new RichPresence()
                {
                    Details = details,
                    State = state,
                    Assets = new Assets()
                    {
                        LargeImageKey = "mantle",
                        LargeImageText = "https://mantle.gg/",
                    }
                });
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error occured. Error: {ex.Message}");
            }
        }
    }
}