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
    ///The PaycheckViewDetail recording.
    /// </summary>
    [TestModule("08aa277b-0669-4912-ab45-f4ac2f3deeef", ModuleType.Recording, 1)]
    public partial class PaycheckViewDetail : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static PaycheckViewDetail instance = new PaycheckViewDetail();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PaycheckViewDetail()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PaycheckViewDetail Instance
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

            // View Personal Details
            Report.Log(ReportLevel.Info, "Section", "View Personal Details", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PaycheckViewDetails' at Center.", repo.ApplicationUnderTest.PaycheckViewDetailsInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.PaycheckViewDetails.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "after click Paycheck View Detail page", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Home' at 23;10.", repo.ApplicationUnderTest.HomeInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Home.Click("23;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
            // Earnings This Tax Year card
            Report.Log(ReportLevel.Info, "Section", "Earnings This Tax Year card", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BalanceViewContainer.ViewDetails' at 31;8.", repo.ApplicationUnderTest.BalanceViewContainer.ViewDetailsInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.BalanceViewContainer.ViewDetails.Click("31;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(8));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "after click Paycheck View Detail page", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Home' at 23;10.", repo.ApplicationUnderTest.HomeInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.Home.Click("23;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(11));
            Delay.Duration(3000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}