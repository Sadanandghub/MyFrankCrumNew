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
    ///The Select_Company recording.
    /// </summary>
    [TestModule("08404687-1bf3-4ad5-b53e-becdc510a179", ModuleType.Recording, 1)]
    public partial class Select_Company : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Select_Company instance = new Select_Company();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Company()
        {
            CompName = "A0F21";
            RepoURL = "mfcqa01.frankcrum.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Company Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable RepoURL.
        /// </summary>
        [TestVariable("c75816bd-3150-4b49-aa6d-f8479454f515")]
        public string RepoURL
        {
            get { return repo.RepoURL; }
            set { repo.RepoURL = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CompName.
        /// </summary>
        [TestVariable("5ac666fd-4de1-4e60-8c76-7b15e63726f4")]
        public string CompName
        {
            get { return repo.CompName; }
            set { repo.CompName = value; }
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

            // Company Selector
            Report.Log(ReportLevel.Info, "Section", "Company Selector", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Text1' at Center.", repo.ApplicationUnderTest.Text1Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Text1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Text1' at Center.", repo.ApplicationUnderTest.Text1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Text1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CompName' with focus on 'ApplicationUnderTest.Text1'.", repo.ApplicationUnderTest.Text1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Text1.PressKeys(CompName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.compselect' at Center.", repo.ApplicationUnderTest.compselectInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.compselect.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(5));
            Delay.Duration(4000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
