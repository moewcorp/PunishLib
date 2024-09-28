﻿using Dalamud.Logging;
using Dalamud.Plugin;
using ECommons.DalamudServices;
using Newtonsoft.Json;
using PunishLib.Configuration;
using PunishLib.ImGuiMethods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace PunishLib
{
    public class PunishLibMain
    {
        internal static string PluginName = "";
        internal static IDalamudPluginInterface PluginInterface;
        internal static AboutPlugin About;
        internal static SharedConfig SharedConfig;
        public static PunishConfig PunishConfig;
        public static PluginManifest PluginManifest;

        public static void Init(IDalamudPluginInterface pluginInterface, string pluginName, AboutPlugin about = null, params PunishOption[] opts)
        {
            PluginName = pluginName;
            PluginInterface = pluginInterface;
            PluginManifest = new();
            About = about ?? new();
            PunishConfig = PunishConfigMethods.Load();
            SharedConfig = new();
            GenericHelpers.Safe(delegate
            {
                var path = Path.Combine(PunishLibMain.PluginInterface.AssemblyLocation.DirectoryName,
                    $"{Path.GetFileNameWithoutExtension(PunishLibMain.PluginInterface.AssemblyLocation.FullName)}.json");
                Svc.Log.Debug($"Path: {path}");
                PluginManifest = JsonConvert.DeserializeObject<PluginManifest>(File.ReadAllText(path));
            });
            if (opts.Contains(PunishOption.DefaultKoFi))
            {
                About.Sponsor = "https://ko-fi.com/spetsnaz";
            }
        }

        public static void Init(IDalamudPluginInterface pluginInterface, string pluginName, params PunishOption[] opts) => Init(pluginInterface, pluginName, null, opts);

        public static void Dispose() { }
    }
}
