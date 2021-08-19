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
    ///The PTO_Delete recording.
    /// </summary>
    [TestModule("10b92aad-3562-4992-b6be-a2d5899e93d0", ModuleType.Recording, 1)]
    public partial class PTO_Delete : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static PTO_Delete instance = new PTO_Delete();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PTO_Delete()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PTO_Delete Instance
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

            Report.Screenshot(ReportLevel.Info, "User", "before delete PTO Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(0));
            
            // Click Delete in the menu on the right of the PTO Plans row
            Report.Log(ReportLevel.Info, "Section", "Click Delete in the menu on the right of the PTO Plans row", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODropdownMenuButton' at Center.", repo.ApplicationUnderTest.PTODropdownMenuButtonInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.PTODropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODelete' at Center.", repo.ApplicationUnderTest.PTODeleteInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.PTODelete.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODeletePopup' at Center.", repo.ApplicationUnderTest.PTODeletePopupInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.PTODeletePopup.Click();
            Delay.Milliseconds(0);
            
            // Press the Delete button
            Report.Log(ReportLevel.Info, "Section", "Press the Delete button", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODropdownMenuButton' at Center.", repo.ApplicationUnderTest.PTODropdownMenuButtonInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.PTODropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODelete' at Center.", repo.ApplicationUnderTest.PTODeleteInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.PTODelete.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(10));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PTODeletebtn' at Center.", repo.ApplicationUnderTest.PTODeletebtnInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.PTODeletebtn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(12));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After delete PTO Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(13));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
