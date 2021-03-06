﻿// <copyright file="ConversionSettingsTemplateSelector.cs" company="AAllard">License: http://www.gnu.org/licenses/gpl.html GPL version 3.</copyright>

namespace FileConverter.Windows
{
    using System.Windows;
    using System.Windows.Controls;

    public class ConversionSettingsTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultDataTemplate
        {
            get;
            set;
        }

        public DataTemplate AviSettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate FlacSettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate WavSettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate Mp3SettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate Mp4SettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate OggSettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate OgvSettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate AacSettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate GifSettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate JpgSettingsDataTemplate
        {
            get;
            set;
        }
        
        public DataTemplate PngSettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate MkvSettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate WebmSettingsDataTemplate
        {
            get;
            set;
        }

        public DataTemplate WebpSettingsDataTemplate
        {
            get;
            set;
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
            {
                return this.DefaultDataTemplate;
            }

            OutputType outputType = (OutputType)item;
           
            switch (outputType)
            {
                case OutputType.Aac:
                    return this.AacSettingsDataTemplate;

                case OutputType.Avi:
                    return this.AviSettingsDataTemplate;

                case OutputType.Flac:
                    return this.FlacSettingsDataTemplate;

                case OutputType.Gif:
                    return this.GifSettingsDataTemplate;

                case OutputType.Jpg:
                    return this.JpgSettingsDataTemplate;

                case OutputType.Mkv:
                    return this.MkvSettingsDataTemplate;

                case OutputType.Mp3:
                    return this.Mp3SettingsDataTemplate;

                case OutputType.Mp4:
                    return this.Mp4SettingsDataTemplate;

                case OutputType.Ogg:
                    return this.OggSettingsDataTemplate;

                case OutputType.Ogv:
                    return this.OgvSettingsDataTemplate;

                case OutputType.Png:
                    return this.PngSettingsDataTemplate;

                case OutputType.Wav:
                    return this.WavSettingsDataTemplate;

                case OutputType.Webm:
                    return this.WebmSettingsDataTemplate;

                case OutputType.Webp:
                    return this.WebpSettingsDataTemplate;
            }

            return this.DefaultDataTemplate;
        }
    }
}
