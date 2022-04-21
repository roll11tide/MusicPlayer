using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Music_Player
{
    public class Settings
    {
        public class SettingsObject
        {
            public string DefaultShufflePath { get; set; }
            public string LastDirectoryViewed { get; set; }
            public int DefaultVolume { get; set; }

            public SettingsObject() { }
        }

        public static void defaultSettings()
        {
            // Default settings are defined here
            Form1.settings.DefaultShufflePath = "";
            Form1.settings.LastDirectoryViewed = "";
            Form1.settings.DefaultVolume = 50;

            saveSettings();
        }

        #region XML Methods
        public static void saveSettings()
        {
            if (!File.Exists("Settings.xml"))
            {
                File.Create("Settings.xml").Close();
            }

            FileStream file = File.Create(Environment.CurrentDirectory + "//Settings.xml");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsObject));
            xmlSerializer.Serialize(file, Form1.settings);

            file.Close();
        }

        public static void initializeSettings()
        {
            if (File.Exists("Settings.xml"))
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load("Settings.xml");
                    XmlSerializer serializer = new XmlSerializer(typeof(SettingsObject));

                    using (XmlNodeReader reader = new XmlNodeReader(xmlDocument))
                    {
                        Form1.settings = (SettingsObject)serializer.Deserialize(reader);
                    }
                } catch (Exception e)
                {
                    MessageBox.Show("Settings are damaged! Settings will now be defaulted.\r\n\r\n" + e.ToString(), "Invalid Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    defaultSettings();
                }
            } else
            {
                defaultSettings();
            }
        }
        #endregion
    }
}