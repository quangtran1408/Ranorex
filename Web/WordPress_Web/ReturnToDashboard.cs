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

namespace WordPress_Web
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ReturnToDashboard recording.
    /// </summary>
    [TestModule("deeaf185-3fb0-4f8f-b579-e4a3d137bf6f", ModuleType.Recording, 1)]
    public partial class ReturnToDashboard : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WordPress_WebRepository repository.
        /// </summary>
        public static WordPress_WebRepository repo = WordPress_WebRepository.Instance;

        static ReturnToDashboard instance = new ReturnToDashboard();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReturnToDashboard()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ReturnToDashboard Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WordPress_Main_Page.home_link' at 115;17.", repo.WordPress_Main_Page.home_linkInfo, new RecordItemIndex(0));
            repo.WordPress_Main_Page.home_link.Click("115;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'WordPress_Main_Page.posts_link'.", repo.WordPress_Main_Page.posts_linkInfo, new RecordItemIndex(1));
            repo.WordPress_Main_Page.posts_link.EnsureVisible();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}