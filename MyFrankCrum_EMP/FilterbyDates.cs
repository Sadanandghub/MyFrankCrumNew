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
    ///The FilterbyDates recording.
    /// </summary>
    [TestModule("3e9b28ba-3fb5-47e1-b175-f5bca7540ee6", ModuleType.Recording, 1)]
    public partial class FilterbyDates : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static FilterbyDates instance = new FilterbyDates();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FilterbyDates()
        {
            InvoiceFromDate = "05/23/2019";
            InvoiceToDate = "05/23/2019";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FilterbyDates Instance
        {
            get { return instance; }
        }

#region Variables

        string _InvoiceFromDate;

        /// <summary>
        /// Gets or sets the value of variable InvoiceFromDate.
        /// </summary>
        [TestVariable("877f8519-3467-40ef-ba96-5bf23d4d6dad")]
        public string InvoiceFromDate
        {
            get { return _InvoiceFromDate; }
            set { _InvoiceFromDate = value; }
        }

        string _InvoiceToDate;

        /// <summary>
        /// Gets or sets the value of variable InvoiceToDate.
        /// </summary>
        [TestVariable("7f29a15a-5bd0-4d60-b961-bd2ed7ba43c9")]
        public string InvoiceToDate
        {
            get { return _InvoiceToDate; }
            set { _InvoiceToDate = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InvoiceFromDate' at Center.", repo.ApplicationUnderTest.InvoiceFromDateInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.InvoiceFromDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$InvoiceFromDate' with focus on 'ApplicationUnderTest.InvoiceFromDate'.", repo.ApplicationUnderTest.InvoiceFromDateInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.InvoiceFromDate.PressKeys(InvoiceFromDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Invoices' at Center.", repo.ApplicationUnderTest.InvoicesInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Invoices.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InvoiceTodate' at Center.", repo.ApplicationUnderTest.InvoiceTodateInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.InvoiceTodate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$InvoiceToDate' with focus on 'ApplicationUnderTest.InvoiceTodate'.", repo.ApplicationUnderTest.InvoiceTodateInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.InvoiceTodate.PressKeys(InvoiceToDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Sreenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Invoices' at Center.", repo.ApplicationUnderTest.InvoicesInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Invoices.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}