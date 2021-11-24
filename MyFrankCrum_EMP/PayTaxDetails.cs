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
    ///The PayTaxDetails recording.
    /// </summary>
    [TestModule("c36547d9-1966-4b85-9e00-5dfd79539d3d", ModuleType.Recording, 1)]
    public partial class PayTaxDetails : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static PayTaxDetails instance = new PayTaxDetails();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PayTaxDetails()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PayTaxDetails Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PayTaxDetails' at 35;8.", repo.ApplicationUnderTest.PayTaxDetailsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.PayTaxDetails.Click("35;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After Clicked Pay tax detail Link", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BalanceViewContainer.PayDistribution' at 49;15.", repo.ApplicationUnderTest.BalanceViewContainer.PayDistributionInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.BalanceViewContainer.PayDistribution.Click("49;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After Clicked Pay Distribution Tab", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BalanceViewContainer.Taxes' at 25;17.", repo.ApplicationUnderTest.BalanceViewContainer.TaxesInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.BalanceViewContainer.Taxes.Click("25;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After Clicked Taxes Tab", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BalanceViewContainer.Deductions' at 39;16.", repo.ApplicationUnderTest.BalanceViewContainer.DeductionsInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.BalanceViewContainer.Deductions.Click("39;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(10));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After Clicked Deduction Tab", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BalanceViewContainer.LiTagAll' at 10;14.", repo.ApplicationUnderTest.BalanceViewContainer.LiTagAllInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.BalanceViewContainer.LiTagAll.Click("10;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(13));
            Delay.Duration(3000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}