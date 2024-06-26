﻿using Dalamud.Interface;
using Dalamud.Interface.Colors;
using ImGuiNET;
using PunishLib.ImGuiMethods;
using System;
using System.Diagnostics;

namespace PunishLib
{
    public class AboutPlugin
    {
        public string Sponsor { get; set; }
        public string Developer { get; set; }
        public string Translator { get; set; }
        public string Afdian { get; set; }
        internal Action WithLoveBy => Developer == null ? WithLoveByPunish : WithLoveByOther;

        static void WithLoveByPunish()
        {
            ImGuiEx.ImGuiLineCentered("AboutHeader", delegate
            {
                ImGuiEx.Text($"Published and developed with ");
                ImGui.PushFont(UiBuilder.IconFont);
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudRed, FontAwesomeIcon.Heart.ToIconString());
                ImGui.PopFont();
                ImGui.SameLine(0, 0);
                ImGuiEx.Text($" by Puni.sh");
            });
            ImGuiEx.ImGuiLineCentered("AboutHeader2", delegate
            {
                ImGuiEx.Text($"本汉化版的本地化和功能适配，");
                ImGui.PushFont(UiBuilder.IconFont);
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudRed, FontAwesomeIcon.Heart.ToIconString());
                ImGui.PopFont();
                ImGui.SameLine(0, 0);
                ImGuiEx.Text($"来自{PunishLibMain.About.Translator} (猫猫公司)");
            });
            ImGuiEx.ImGuiLineCentered("AboutHeader3", delegate
            {
                ImGui.PushFont(UiBuilder.IconFont);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.PopFont();
                ImGui.SameLine(0, 0);
                ImGuiEx.Text("插件开源免费，汉化维护不易，请勿从任何闲鱼小店上购买本插件");
                ImGui.PushFont(UiBuilder.IconFont);
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.PopFont();
            });
            ImGuiEx.ImGuiLineCentered("AboutHeader4", delegate
            {
                ImGui.PushFont(UiBuilder.IconFont);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.PopFont();
                ImGui.SameLine(0, 0);
                ImGuiEx.Text("包括但不限于倒卖插件，倒卖信息差");
                ImGui.PushFont(UiBuilder.IconFont);
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.PopFont();
            });
            if (PunishLibMain.About.Afdian != null)
            {
                ImGuiEx.ImGuiLineCentered("AboutHeader5", delegate
                {
                    ImGuiEx.Text("用爱发电，随意支持");
                    ImGui.SameLine(0, 0);
                    ImGui.PushFont(UiBuilder.IconFont);
                    ImGuiEx.Text(ImGuiColors.DalamudRed, FontAwesomeIcon.Heart.ToIconString());
                    ImGui.PopFont();
                    ImGui.SameLine();
                    if (ImGui.Button("爱发电"))
                    {
                        Process.Start(new ProcessStartInfo()
                        {
                            FileName = PunishLibMain.About.Afdian,
                            UseShellExecute = true
                        });
                    }
                });
            }
        }

        static void WithLoveByOther()
        {
            //Developed with ❤️ by {Developer}, published by Puni.sh
            ImGuiEx.ImGuiLineCentered("AboutHeader", delegate
            {
                ImGuiEx.Text($"Developed with ");
                ImGui.PushFont(UiBuilder.IconFont);
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudRed, FontAwesomeIcon.Heart.ToIconString());
                ImGui.PopFont();
                ImGui.SameLine(0, 0);
                ImGuiEx.Text($" by {PunishLibMain.About.Developer}, published by Puni.sh");
            });
            ImGuiEx.ImGuiLineCentered("AboutHeader2", delegate
            {
                ImGuiEx.Text($"本汉化版的本地化和功能适配，");
                ImGui.PushFont(UiBuilder.IconFont);
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudRed, FontAwesomeIcon.Heart.ToIconString());
                ImGui.PopFont();
                ImGui.SameLine(0, 0);
                ImGuiEx.Text($"来自{PunishLibMain.About.Translator} (猫猫公司)");
            });
            ImGuiEx.ImGuiLineCentered("AboutHeader3", delegate
            {
                ImGui.PushFont(UiBuilder.IconFont);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.PopFont();
                ImGui.SameLine(0, 0);
                ImGuiEx.Text("插件开源免费，汉化维护不易，请勿从任何闲鱼小店上购买本插件");
                ImGui.PushFont(UiBuilder.IconFont);
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.PopFont();
            });
            ImGuiEx.ImGuiLineCentered("AboutHeader4", delegate
            {
                ImGui.PushFont(UiBuilder.IconFont);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.PopFont();
                ImGui.SameLine(0, 0);
                ImGuiEx.Text("包括但不限于倒卖插件，倒卖信息差");
                ImGui.PushFont(UiBuilder.IconFont);
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudYellow, FontAwesomeIcon.ExclamationTriangle.ToIconString());
                ImGui.PopFont();
            });
            if (PunishLibMain.About.Afdian != null)
            {
                ImGuiEx.ImGuiLineCentered("AboutHeader5", delegate
                {
                    ImGuiEx.Text("用爱发电，随意支持");
                    ImGui.SameLine(0, 0);
                    ImGui.PushFont(UiBuilder.IconFont);
                    ImGuiEx.Text(ImGuiColors.DalamudRed, FontAwesomeIcon.Heart.ToIconString());
                    ImGui.PopFont();
                    ImGui.SameLine();
                    if (ImGui.Button("爱发电"))
                    {
                        Process.Start(new ProcessStartInfo()
                        {
                            FileName = PunishLibMain.About.Afdian,
                            UseShellExecute = true
                        });
                    }
                });
            }
        }
    }

}