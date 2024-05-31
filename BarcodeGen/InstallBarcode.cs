﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BarcodeGen
{
    
    public class InstallBarcode
    {
        [System.Runtime.InteropServices.DllImport("gdi32", EntryPoint = "AddFontResource")]
        public static extern int AddFontResourceA(string lpFileName);
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern int AddFontResource(string lpszFilename);
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern int CreateScalableFontResource(uint fdwHidden, string
            lpszFontRes, string lpszFontFile, string lpszCurrentPath);

        /// <summary>
        /// Installs font on the user's system and adds it to the registry so it's available on the next session
        /// Your font must be included in your project with its build path set to 'Content' and its Copy property
        /// set to 'Copy Always'
        /// </summary>
        /// <param name="contentFontName">Your font to be passed as a resource (i.e. "myfont.tff")</param>
        public static void RegisterFont(string contentFontName = "BARCODEs.TTF")
        {
            Exception ex = new Exception();
            try
            {
                // Creates the full path where your font will be installed
                var fontDestination = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Fonts), contentFontName);

                if (!File.Exists(fontDestination))
                {
                    // Copies font to destination
                    System.IO.File.Copy(Path.Combine(System.IO.Directory.GetCurrentDirectory(), contentFontName), fontDestination);

                    // Retrieves font name
                    // Makes sure you reference System.Drawing
                    System.Drawing.Text.PrivateFontCollection fontCol = new System.Drawing.Text.PrivateFontCollection();
                    fontCol.AddFontFile(fontDestination);
                    var actualFontName = fontCol.Families[0].Name;

                    //Add font
                    AddFontResource(fontDestination);
                    //Add registry entry   
                    Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts", actualFontName, contentFontName, Microsoft.Win32.RegistryValueKind.String);
                }
            }
            catch (Exception exception)
            {
                throw exception;
                //ex = exception;
            }
            //return ex;
        }
    }

}
