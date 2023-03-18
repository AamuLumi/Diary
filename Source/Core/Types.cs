﻿using RimWorld;
using Verse;

namespace Diary
{
    public enum ExportFormat
    {
        Text,
        RTF
    }

    public enum DefaultMessage
    {
        NoEntryFound,
        Empty
    }

    public enum LogFilter
    {
        All,
        Events,
        Chats
    }

    public enum LogWriterFilter
    {
        All,
        Events,
        Chats,
        None
    }

    public enum AutomaticExportPeriod
    {
        Day,
        Week,
        Month
    }

    public class DiaryTypeTools
    {
        public static string GetFormatName(ExportFormat format)
        {
            switch (format)
            {
                case ExportFormat.Text: return "Diary_Format_Text".Translate();
                case ExportFormat.RTF: return "Diary_Format_RTF".Translate();
                default: return "";
            }
        }

        public static string GetDefaultMessageName(DefaultMessage m)
        {
            switch (m)
            {
                case DefaultMessage.Empty: return "Diary_Empty".Translate();
                case DefaultMessage.NoEntryFound: return "Diary_No_Entry_Found_Message".Translate();
                default: return "";
            }
        }

        public static string GetLogFilterName(LogFilter f)
        {
            switch (f)
            {
                case LogFilter.All: return "Diary_All".Translate();
                case LogFilter.Chats: return "Diary_Chats".Translate();
                case LogFilter.Events: return "Diary_Events".Translate();
                default: return "";
            }
        }

        public static string GetLogWriterFilterName(LogWriterFilter f)
        {
            switch (f)
            {
                case LogWriterFilter.All: return "Diary_All".Translate();
                case LogWriterFilter.Chats: return "Diary_Chats".Translate();
                case LogWriterFilter.Events: return "Diary_Events".Translate();
                case LogWriterFilter.None: return "Diary_None".Translate();
                default: return "";
            }
        }

        public static string GetAutomaticExportPeriodName(AutomaticExportPeriod f)
        {
            switch (f)
            {
                case AutomaticExportPeriod.Day: return "Diary_Every_Day".Translate();
                case AutomaticExportPeriod.Week: return "Diary_Every_Week".Translate();
                case AutomaticExportPeriod.Month: return "Diary_Every_Month".Translate();
                default: return "";
            }
        }
    }

    public class DiaryImageEntry : IExposable
    {
        public int Days;
        public int Hours;
        public string Path;
        public Quadrum Quadrum;
        public int Year;

        public DiaryImageEntry()
        {
        }

        public DiaryImageEntry(string path, int hours, int day, Quadrum quadrum, int year)
        {
            Path = path;
            Hours = hours;
            Days = day;
            Quadrum = quadrum;
            Year = year;
        }

        public void ExposeData()
        {
            Scribe_Values.Look(ref Path, "Path");
            Scribe_Values.Look(ref Hours, "Hours");
            Scribe_Values.Look(ref Days, "Days");
            Scribe_Values.Look(ref Quadrum, "Quadrum");
            Scribe_Values.Look(ref Year, "Year");
        }
    }

    public class PawnStatus
    {
        private bool _dead;
        private bool _downed;

        public PawnStatus(bool downed, bool dead)
        {
            _downed = downed;
            _dead = dead;
        }

        public bool Downed { get; }
        public bool Dead { get; }
    }
}