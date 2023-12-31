﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Chrome_Test.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BackToHomePage recording.
    /// </summary>
    [TestModule("c5b83313-ab86-4e05-9a58-4a98973ad8a0", ModuleType.Recording, 1)]
    public partial class BackToHomePage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Chrome_Test.Chrome_TestRepository repository.
        /// </summary>
        public static global::Chrome_Test.Chrome_TestRepository repo = global::Chrome_Test.Chrome_TestRepository.Instance;

        static BackToHomePage instance = new BackToHomePage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BackToHomePage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BackToHomePage Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoogleChrome_window.back_button' at 20;15.", repo.GoogleChrome_window.back_buttonInfo, new RecordItemIndex(0));
            repo.GoogleChrome_window.back_button.Click("20;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
