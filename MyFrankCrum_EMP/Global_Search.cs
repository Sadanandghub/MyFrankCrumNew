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

namespace MyFrankCrum_EMP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Global_Search recording.
    /// </summary>
    [TestModule("f50f578a-eba4-4d07-a5a6-fbd636b0fd18", ModuleType.Recording, 1)]
    public partial class Global_Search : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Global_Search instance = new Global_Search();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Global_Search()
        {
            GlobalEmpName = "Apple";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Global_Search Instance
        {
            get { return instance; }
        }

#region Variables

        string _GlobalEmpName;

        /// <summary>
        /// Gets or sets the value of variable GlobalEmpName.
        /// </summary>
        [TestVariable("bb707a65-aa8b-4ae3-b89b-ae49254771e0")]
        public string GlobalEmpName
        {
            get { return _GlobalEmpName; }
            set { _GlobalEmpName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RepoURL.
        /// </summary>
        [TestVariable("c75816bd-3150-4b49-aa6d-f8479454f515")]
        public string RepoURL
        {
            get { return repo.RepoURL; }
            set { repo.RepoURL = value; }
        }

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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Text3' at Center.", repo.ApplicationUnderTest.Text3Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Text3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GlobalEmpName' with focus on 'ApplicationUnderTest.Text3'.", repo.ApplicationUnderTest.Text3Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Text3.PressKeys(GlobalEmpName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Text3'.", repo.ApplicationUnderTest.Text3Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Text3.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(3));
            Delay.Duration(10000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Globle search screenshot", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DropdownMenuButton1' at CenterLeft.", repo.ApplicationUnderTest.DropdownMenuButton1Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.DropdownMenuButton1.Click(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EmpdetailsClick' at Center.", repo.ApplicationUnderTest.EmpdetailsClickInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.EmpdetailsClick.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Globle search screenshot", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(8));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
